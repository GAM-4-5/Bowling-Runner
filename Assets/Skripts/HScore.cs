using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class HScore
{
    public float HighScore;

    public HScore(PlayerCollision Highscore)
    {
        HighScore = Highscore.HighScore;
    }

}

