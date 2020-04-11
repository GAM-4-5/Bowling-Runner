using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ScoreData
{
    public int pinScore;

    public ScoreData (PlayerCollision pinscore)
    {
        pinScore = pinscore.pinScore;
    }

}
