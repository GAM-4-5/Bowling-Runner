using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{

    public int selectedCharacter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectPlayer1()
    {
        selectedCharacter = 1;
    }
    public void SelectPlayer2()
    {
        selectedCharacter = 2;
    }
    public void SelectPlayer3()
    {
        selectedCharacter = 3;
    }
    public void SelectPlayer4()
    {
        selectedCharacter = 4;
    }
    public void SelectPlayer5()
    {
        selectedCharacter = 5;
    }
}
