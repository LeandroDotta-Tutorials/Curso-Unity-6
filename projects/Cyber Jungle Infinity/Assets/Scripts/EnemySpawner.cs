using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float interval = 2f;

    private float timer;

    private void Update() 
    {
        if (timer >= interval)
        {
            timer -= timer;
            SpawnEnemy();
        }

        timer += Time.deltaTime;
    }

    private void SpawnEnemy()
    {
        float maxPositionX = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
        float minPositionX = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;

        Vector3 position = transform.position;
        position.x = Random.Range(minPositionX, maxPositionX);

        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
