using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator panelStart;
    public Animator panelEnd;
    public GameObject healthBar;

    private LevelManager levelManager;

    private void Start()
    {
        levelManager = GetComponent<LevelManager>();

        panelStart.gameObject.SetActive(true);
        healthBar.SetActive(false);
        Invoke("StartLevel", 5f);
    }

    private void StartLevel()
    {
        panelStart.Play("Hide");
        healthBar.SetActive(true);
        levelManager.enabled = true;
    }

    private void OnLevelEnd()
    {
        GameOver();
    }

    public void GameOver()
    {
        levelManager.enabled = false;

        healthBar.SetActive(false);
        panelEnd.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
