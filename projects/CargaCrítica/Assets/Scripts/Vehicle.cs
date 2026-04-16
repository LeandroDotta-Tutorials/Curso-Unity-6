using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform loadSlot;

    private Load load;

    public bool IsLoaded => load != null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag.LOAD))
        {
            if (IsLoaded)
            {
                // TODO: Send event indicating the vehicle is loaded and can't get more load
                return;
            }

            LoadCollectible collectible = other.GetComponent<LoadCollectible>();
            collectible.loadModel.SetParent(loadSlot);
            collectible.loadModel.localPosition = Vector3.zero;
            load = collectible.loadModel.GetComponent<Load>();
            collectible.Remove();
        }
        else if (other.CompareTag(Tag.FINISH))
        {
            if (!IsLoaded) return;

            DeliveryPoint delivery = other.GetComponent<DeliveryPoint>();

            if (delivery.PutLoad(load))
            {
                load = null;
            }
        }
    }
    
    public void OnAccelerate(InputValue value)
    {
        if (value.isPressed)
        {
            animator.SetTrigger("accelerate");
            animator.SetFloat("wheel-speed", 1);
        }
        else
        {
            animator.SetFloat("wheel-speed", 0);
        }
    }

    public void OnBrake(InputValue value)
    {
        if (value.isPressed)
        {
            animator.SetTrigger("brake");
            animator.SetFloat("wheel-speed", -1);
        }
        else
        {
            animator.SetFloat("wheel-speed", 0);
        }
    }
    
    public void OnTurn(InputValue value)
    {
        float steering = value.Get<float>();
        animator.SetFloat("steering", steering);
    }
}
