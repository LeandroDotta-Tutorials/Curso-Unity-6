using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float endDelay = 15f;

    private Horde[] hordes;
    private int currentHorde = -1;

    private void Start()
    {
        hordes = transform.GetComponentsInChildren<Horde>(true);
        StartNextHorde();
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private void OnHordeEnd()
    {
        if (!enabled)
        {
            return;
        }

        StartNextHorde();
    }

    private void StartNextHorde()
    {
        currentHorde++;

        if (currentHorde < hordes.Length)
        {
            hordes[currentHorde].gameObject.SetActive(true);
        }
        else
        {
            SendMessage("OnLevelEnd", SendMessageOptions.RequireReceiver);
        }
    }
}
