using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class MainManu : MonoBehaviour
{
    public int kont;
    public float HighScore;
    public Text HighScoreText;
    int broj = 0;
    public int score;


    void Start()
    {
        HScore data2 = SaveScore.LoadHigh();
        HighScore = data2.HighScore;
        int score = (int)HighScore + 1;
        HighScoreText.text = HighScore.ToString("0");
        PlayerPrefs.SetInt("ScoreToUpdate", score);
        UpdateLeaderboardScore();
    }
    void Update()
    {

    }



    
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void UpdateLeaderboardScore()
    {
        if (PlayerPrefs.GetInt("ScoreToUpdate", 0) == 0)
        {
            return;
        }
        Social.ReportScore(PlayerPrefs.GetInt("ScoreToUpdate", score), GPGSIds.leaderboard_high_score, (bool success) =>
        {
            if (success)
            {
                PlayerPrefs.SetInt("ScoreToUpdate", score);
            }
        });
    }

}
