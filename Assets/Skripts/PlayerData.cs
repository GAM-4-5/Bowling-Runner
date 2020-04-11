using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int player1;
    public int player2;
    public int player3;
    public int player4;
    public int player5;
    public int selectedCharacter = 0;
    public int test = 0;

    public PlayerData(Shop player)
    {
        player1 = player.player1;
        player2 = player.player2;
        player3 = player.player3;
        player4 = player.player4;
        player5 = player.player5;
        selectedCharacter = player.selectedCharacter;
        test = player.test;
        
    }

}
