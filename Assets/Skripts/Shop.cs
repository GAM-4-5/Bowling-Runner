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

    public GameObject FireB;
    public GameObject FireS;

    public GameObject WaterB;
    public GameObject WaterS;

    public GameObject GalaxyB;
    public GameObject GalaxyS;

    public Text pinScoreText;
    public TextMeshProUGUI select1;
    public TextMeshProUGUI select2;
    public TextMeshProUGUI select3;
    public TextMeshProUGUI select4;
    public TextMeshProUGUI select5;
    public TextMeshProUGUI select6;
    public TextMeshProUGUI select7;
    public TextMeshProUGUI select8;

    public int player1;
    public int player2;
    public int player3;
    public int player4;
    public int player5;
    public int player6;
    public int player7;
    public int player8;

    public int broj = 0;
    public int test = 0;

    //public int pinScore;
    public int price = 100;
    public int price2 = 150;

    //učitavanje spremljenih podataka
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
        player6 = data1.player6;
        player7 = data1.player7;
        player8 = data1.player8;
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
            player6 = 0;
            player7 = 0;
            player8 = 0;
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

    //na klik se pokreće igra
    public void Play()
    {
        SceneManager.LoadScene("Test01");
    }

    //kupnja kugle 1, provjera broja skupljenih čunjeva te oduzimanje i spremanje nove količine skupljenih čunjeva
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
    //kupnja kugle 2, provjera broja skupljenih čunjeva te oduzimanje i spremanje nove količine skupljenih čunjeva
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
    //kupnja kugle 3, provjera broja skupljenih čunjeva te oduzimanje i spremanje nove količine skupljenih čunjeva
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
    //kupnja kugle 4, provjera broja skupljenih čunjeva te oduzimanje i spremanje nove količine skupljenih čunjeva
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
    //kupnja kugle 5, provjera broja skupljenih čunjeva te oduzimanje i spremanje nove količine skupljenih čunjeva
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
    //kupnja kugle 6, provjera broja skupljenih čunjeva te oduzimanje i spremanje nove količine skupljenih čunjeva
    public void Buy6()
    {
        if (pinScore >= price2)
        {
            HighScore = HighScore + 1 - 1;
            pinScore = pinScore - price2;
            SaveSystem.SaveScore(this);
            pinScoreText.text = pinScore.ToString();
            player6 = 6;
            Save.SavePlayer(this);
            FireS.SetActive(true);
            FireB.SetActive(false);
        }
    }
    //kupnja kugle 7, provjera broja skupljenih čunjeva te oduzimanje i spremanje nove količine skupljenih čunjeva
    public void Buy7()
    {
        if (pinScore >= price2)
        {
            HighScore = HighScore + 1 - 1;
            pinScore = pinScore - price2;
            SaveSystem.SaveScore(this);
            pinScoreText.text = pinScore.ToString();
            player7 = 7;
            Save.SavePlayer(this);
            WaterS.SetActive(true);
            WaterB.SetActive(false);
        }
    }
    //kupnja kugle 8, provjera broja skupljenih čunjeva te oduzimanje i spremanje nove količine skupljenih čunjeva
    public void Buy8()
    {
        if (pinScore >= price2)
        {
            HighScore = HighScore + 1 - 1;
            pinScore = pinScore - price2;
            SaveSystem.SaveScore(this);
            pinScoreText.text = pinScore.ToString();
            player8 = 8;
            Save.SavePlayer(this);
            GalaxyS.SetActive(true);
            GalaxyB.SetActive(false);
        }
    }

    //aktivacija kupljenih lopti, omogućavanje odabira kugle
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
        if (player6 == 6)
        {
            FireS.SetActive(true);
            FireB.SetActive(false);
        }
        else
        {
            FireS.SetActive(false);
            FireB.SetActive(true);
        }
        if (player7 == 7)
        {
            WaterS.SetActive(true);
            WaterB.SetActive(false);
        }
        else
        {
            WaterS.SetActive(false);
            WaterB.SetActive(true);
        }
        if (player8 == 8)
        {
            GalaxyS.SetActive(true);
            GalaxyB.SetActive(false);
        }
        else
        {
            GalaxyS.SetActive(false);
            GalaxyB.SetActive(true);
        }
    }

    //spremanje odaberene kugle
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
    public void SelectPlayer6()
    {
        selectedCharacter = 6;
        Save.SavePlayer(this);
    }
    public void SelectPlayer7()
    {
        selectedCharacter = 7;
        Save.SavePlayer(this);
    }
    public void SelectPlayer8()
    {
        selectedCharacter = 8;
        Save.SavePlayer(this);
    }

}

