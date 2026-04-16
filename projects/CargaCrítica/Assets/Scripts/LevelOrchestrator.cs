using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOrchestrator : MonoBehaviour
{
    private void OnLevelComplete()
    {
        // TODO: Implement logic to display End Level UI
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
