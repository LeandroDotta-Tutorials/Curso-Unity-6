using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Load(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
