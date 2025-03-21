using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator panelStart;
    public Animator panelEnd;
    public GameObject panelInGame;
    public TMP_Text textScore;
    public TMP_Text textFinalScore;
    public RatingBar ratingBar;

    private LevelManager levelManager;
    private ScoreManager scoreManager;

    private void Start()
    {
        levelManager = GetComponent<LevelManager>();

        scoreManager = new ScoreManager(GetComponentsInChildren<Enemy>(true));

        panelInGame.SetActive(false);
        panelStart.gameObject.SetActive(true);
        Invoke("StartLevel", 5f);
    }

    private void StartLevel()
    {
        panelStart.Play("Hide");
        panelInGame.SetActive(true);
        levelManager.enabled = true;
    }

    private void OnEnemyLoose(Enemy enemy)
    {
        scoreManager.Score += enemy.score;
        textScore.text = scoreManager.Score.ToString();
    }

    private void OnLevelEnd()
    {
        GameOver();
    }

    public void GameOver()
    {
        levelManager.enabled = false;

        panelInGame.SetActive(false);
        panelEnd.gameObject.SetActive(true);

        textFinalScore.text = scoreManager.Score.ToString();
        int rating = scoreManager.CalculateRating();
        ratingBar.Show(rating);
    }    

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}