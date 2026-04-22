using UnityEngine;
using UnityEngine.Events;

public class LevelSelectionPoint : MonoBehaviour
{
    public int level = 0;

    private Animator animator;
    private const string ANIM_PARAMETER_SELECTED = "selected";

    public static event UnityAction<LevelSelectionPoint> OnPointSelected;
    public static event UnityAction<LevelSelectionPoint> OnPointDeselected;

    private void Start() 
    {
        animator = GetComponent<Animator>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag.PLAYER))
        {
            Select();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Tag.PLAYER))
        {
            Deselect();
        }
    }

    private void Select()
    {
        animator.SetBool(ANIM_PARAMETER_SELECTED, true);
        OnPointSelected?.Invoke(this);
    }
    
    private void Deselect()
    {
        animator.SetBool(ANIM_PARAMETER_SELECTED, false);
        OnPointDeselected?.Invoke(this);
    }
}
