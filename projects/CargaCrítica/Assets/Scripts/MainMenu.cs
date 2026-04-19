using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindFirstObjectByType<SceneLoader>();
    }

    public void StartGame()
    {
        sceneLoader.Load(SceneNames.LEVEL_PREFIX + "1");
    }

    public void Quit()
    {
        sceneLoader.Quit();
        Debug.Log("Game exiting...");
    }
}
