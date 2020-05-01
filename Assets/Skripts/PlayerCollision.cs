using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    public Text pinScoreText;
    public int pinScore;
    public float HighScore;
    public Transform player;
    public Text scoreText;
    public Text youdie;
    private int collision;
    public Text NewHigh;
    public float score;
    int number;



    void Start()
    {
        ScoreData data = SaveSystem.LoadScore();
        pinScore = data.pinScore;
        pinScoreText.text = pinScore.ToString();
        HScore data2 = SaveScore.LoadHigh();
        HighScore = data2.HighScore;
    }

    //u slučaju sudara s prepreko na ekranu pojavi "game over", ako je postavljen novi rekord ispisuje se "new highscore", sprema kolicinu skupljenih čunjeva te ucitava izbornik
    void OnCollisionEnter (Collision collisionInfo )
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            StartCoroutine(YouDie());
            movement.enabled = false;
            if ((player.position.z - 128) > HighScore)
            {
                NewHigh.text = "New highscore!!!";
            }

        }
        if (collisionInfo.collider.tag == "Pin")
        {
            pinScore += 1;
            pinScoreText.text = pinScore.ToString();
            SaveSystem.SaveScore(this);


        }
    }
    //provjerava pređenu udaljenost te ako je veća od rekorda postavlja ju kao novi rekord
    void Update()
    {
        if (player.position.z > 129)
        {
            scoreText.text = (player.position.z - 129).ToString("0");
        }
        if (player.position.z - 129 > HighScore)
        {
            score = player.position.z - 129;
            HighScore = player.position.z - 129;
            SaveScore.SaveHigh(this);
        }

    }
    IEnumerator YouDie()
    {
        var number = Random.Range(1, 10);
        Debug.Log(number);
        youdie.text = "Game over!";
        yield return new WaitForSeconds(2f);
        youdie.gameObject.SetActive(false);
        if (number % 3 == 0)
        {
            Advertisement.Initialize("3531620", false);
            while (!Advertisement.IsReady())
                yield return null;
            Advertisement.Show();
        }
        SceneManager.LoadScene("Menu");
    }



}
