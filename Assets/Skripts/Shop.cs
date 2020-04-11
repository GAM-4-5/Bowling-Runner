using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SceneManagement;

public class Shop : PlayerCollision
{

    public int selectedCharacter = 0;

    public GameObject GreenB;
    public GameObject GreenS;

    public GameObject WhiteB;
    public GameObject WhiteS;

    public GameObject YellowB;
    public GameObject YellowS;

    public GameObject BlueB;
    public GameObject BlueS;

    public GameObject GreenishB;
    public GameObject GreenishS;

    public Text pinScoreText;
    public TextMeshProUGUI select1;
    public TextMeshProUGUI select2;
    public TextMeshProUGUI select3;
    public TextMeshProUGUI select4;
    public TextMeshProUGUI select5;

    public int player1;
    public int player2;
    public int player3;
    public int player4;
    public int player5;

    public int broj = 0;
    public int test = 0;

    //public int pinScore;
    public int price = 100;

    // Start is called before the first frame update
    void Start()
    {
        ScoreData data = SaveSystem.LoadScore();
        pinScore = data.pinScore;
        pinScoreText.text = pinScore.ToString();

        PlayerData data1 = Save.LoadPlayer();
        player1 = data1.player1;
        player2 = data1.player2;
        player3 = data1.player3;
        player4 = data1.player4;
        player5 = data1.player5;
        test = data1.test;


        Select();
        
    
    }

    // Update is called once per frame
    void Update()
    {
        if (test == 0)
        {
            player1 = 0;
            player2 = 0;
            player3 = 0;
            player4 = 0;
            player5 = 0;
            selectedCharacter = 0;
            Save.SavePlayer(this);
        }
        if (test == 0)
        {
            Select();
            test += 1;
            Save.SavePlayer(this);
        }
        //Save.SavePlayer(this);
    }

    public void Play()
    {
        SceneManager.LoadScene("Test01");
    }

    public void Buy1()
    {
        if (pinScore >= price)
        {
            pinScore = pinScore - price;
            SaveSystem.SaveScore(this);
            pinScoreText.text = pinScore.ToString();
            player1 = 1;
            Save.SavePlayer(this);
            GreenS.SetActive(true);
            GreenB.SetActive(false);
        }
    }
    public void Buy2()
    {
        if (pinScore >= price)
        {

            pinScore = pinScore - price;
            SaveSystem.SaveScore(this);
            pinScoreText.text = pinScore.ToString();
            player2 = 2;
            Save.SavePlayer(this);
            WhiteS.SetActive(true);
            WhiteB.SetActive(false);
        }
    }
    public void Buy3()
    {
        if (pinScore >= price)
        {

            pinScore = pinScore - price;
            SaveSystem.SaveScore(this);
            pinScoreText.text = pinScore.ToString();
            player3 = 3;
            Save.SavePlayer(this);
            YellowS.SetActive(true);
            YellowB.SetActive(false);
        }
    }
    public void Buy4()
    {
        if (pinScore >= price)
        {

            pinScore = pinScore - price;
            SaveSystem.SaveScore(this);
            pinScoreText.text = pinScore.ToString();
            player4 = 4;
            Save.SavePlayer(this);
            BlueS.SetActive(true);
            BlueB.SetActive(false);
        }
    }
    public void Buy5()
    {
        if (pinScore >= price)
        {
            HighScore = HighScore + 1 - 1;
            pinScore = pinScore - price;
            SaveSystem.SaveScore(this);
            pinScoreText.text = pinScore.ToString();
            player5 = 5;
            Save.SavePlayer(this);
            GreenishS.SetActive(true);
            GreenishB.SetActive(false);
        }
    }

    void Select()
    {
        if (player1 == 1)
        {
            GreenS.SetActive(true);
            GreenB.SetActive(false);
        }
        else
        {
            GreenS.SetActive(false);
            GreenB.SetActive(true);
        }
        if (player2 == 2)
        {
            WhiteS.SetActive(true);
            WhiteB.SetActive(false);
        }
        else
        {
            WhiteS.SetActive(false);
            WhiteB.SetActive(true);
        }
        if (player3 == 3)
        {
            YellowS.SetActive(true);
            YellowB.SetActive(false);
        }
        else
        {
            YellowS.SetActive(false);
            YellowB.SetActive(true);
        }
        if (player4 == 4)
        {
            BlueS.SetActive(true);
            BlueB.SetActive(false);
        }
        else
        {
            BlueS.SetActive(false);
            BlueB.SetActive(true);
        }
        if (player5 == 5)
        {
            GreenishS.SetActive(true);
            GreenishB.SetActive(false);
        }
        else
        {
            GreenishS.SetActive(false);
            GreenishB.SetActive(true);
        }
    }

    public void SelectPLayer0()
    {
        selectedCharacter = 0;
        Save.SavePlayer(this);
    }

    public void SelectPlayer1()
    {
        selectedCharacter = 1;
        Save.SavePlayer(this);
    }
    public void SelectPlayer2()
    {
        selectedCharacter = 2;
        Save.SavePlayer(this);
    }
    public void SelectPlayer3()
    {
        selectedCharacter = 3;
        Save.SavePlayer(this);
    }
    public void SelectPlayer4()
    {
        selectedCharacter = 4;
        Save.SavePlayer(this);
    }
    public void SelectPlayer5()
    {
        selectedCharacter = 5;
        Save.SavePlayer(this);
    }

}

