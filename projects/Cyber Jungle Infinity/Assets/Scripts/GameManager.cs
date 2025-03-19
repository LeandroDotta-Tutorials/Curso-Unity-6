using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator panelStart;
    public Animator panelEnd;
    public Animator ratingStar1;
    public Animator ratingStar2;
    public Animator ratingStar3;
    public GameObject panelInGame;
    public TMP_Text textScore;
    public TMP_Text textFinalScore;

    private LevelManager levelManager;
    private int maxScore;
    private int currentScore;

    private void Start()
    {
        levelManager = GetComponent<LevelManager>();

        foreach (Enemy enemy in GetComponentsInChildren<Enemy>(true))
        {
            maxScore += enemy.score;
        }

        panelStart.gameObject.SetActive(true);
        panelInGame.SetActive(false);
        ratingStar1.gameObject.SetActive(false);
        ratingStar2.gameObject.SetActive(false);
        ratingStar3.gameObject.SetActive(false);
        Invoke("StartLevel", 5f);
    }

    private void StartLevel()
    {
        panelStart.Play("Hide");
        panelInGame.SetActive(true);
        levelManager.enabled = true;
    }

    private void OnLevelEnd()
    {
        GameOver();
    }

    public void GameOver()
    {
        levelManager.enabled = false;

        textFinalScore.text = currentScore.ToString();
        panelInGame.SetActive(false);
        panelEnd.gameObject.SetActive(true);

        // CalculateRating();
        StartCoroutine(ShowRatingCoroutine());
    }

    private int CalculateRating()
    {
        int rating = 0;

        float scorePercentage = (float)currentScore / maxScore * 100;
        Debug.Log($"SCORE PERCENTAGE: {scorePercentage}%");

        if (scorePercentage >= 100f)
        {
            rating = 3;
        }
        else if (scorePercentage >= 75f)
        {
            rating = 2;
        }
        else if (scorePercentage >= 50f)
        {
            rating = 1;
        }

        return rating;
    }

    private IEnumerator ShowRatingCoroutine()
    {
        int rating = CalculateRating();

        yield return new WaitForSeconds(2f);
        ratingStar1.gameObject.SetActive(true);
        ratingStar1.SetBool("enabled", rating >= 1);

        yield return new WaitForSeconds(0.3f);
        ratingStar2.gameObject.SetActive(true);
        ratingStar2.SetBool("enabled", rating >= 2);

        yield return new WaitForSeconds(0.3f);
        ratingStar3.gameObject.SetActive(true);
        ratingStar3.SetBool("enabled", rating >= 3);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnEnemyLoose(Enemy enemy)
    {
        currentScore += enemy.score;
        textScore.text = currentScore.ToString();
    }
}
