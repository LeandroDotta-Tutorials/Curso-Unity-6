using UnityEngine;

public class Horde : MonoBehaviour
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
            SendMessageUpwards("OnHordeEnd");
        }
    }
}
