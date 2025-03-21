using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    private int enemyCount;

    private void Start()
    {
        enemyCount = transform.childCount;
    }

    private void OnEnemyDestroyed(Enemy enemy)
    {
        enemyCount--;

        if (enemyCount == 0)
        {
            SendMessageUpwards("OnWaveEnd", SendMessageOptions.DontRequireReceiver);
        }
    }
}
