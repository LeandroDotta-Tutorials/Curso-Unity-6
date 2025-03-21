using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private EnemyWave[] waves;
    private int currentWave = -1;

    private void Start()
    {
        waves = transform.GetComponentsInChildren<EnemyWave>(true);

        StartNextWave();
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private void OnWaveEnd()
    {
        if (!enabled)
        {
            return;
        }

        StartNextWave();
    }

    private void StartNextWave()
    {
        currentWave++;
        
        if (currentWave < waves.Length)
        {
            waves[currentWave].gameObject.SetActive(true);
        }
        else
        {
            SendMessage("OnLevelEnd", SendMessageOptions.RequireReceiver);
        }
    }
}
