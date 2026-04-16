using System;
using UnityEngine;

public class LevelState : MonoBehaviour
{
    private DeliveryPoint[] deliveryPoints;
    private int deliveryCount;

    private void Awake()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(Tag.FINISH);

        deliveryPoints = new DeliveryPoint[gameObjects.Length];

        for (int i = 0; i < gameObjects.Length; i++)
        {
            deliveryPoints[i] = gameObjects[i].GetComponent<DeliveryPoint>();
        }
    }

    private void Start()
    {
        foreach (DeliveryPoint point in deliveryPoints)
        {
            point.OnLoadDelivered += LoadDeliveryCallback;
        }
    }

    private void OnDestroy() 
    {
        foreach (DeliveryPoint point in deliveryPoints)
        {
            point.OnLoadDelivered -= LoadDeliveryCallback;
        }   
    }
    
    private void LoadDeliveryCallback()
    {
        deliveryCount++;

        if (deliveryCount == deliveryPoints.Length)
        {
            SendMessage("OnLevelComplete");
        }
    }
}
