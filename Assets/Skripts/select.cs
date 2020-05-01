
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class select : MonoBehaviour
{
    public int selectedCharacter = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerData data1 = Save.LoadPlayer();
        selectedCharacter = data1.selectedCharacter;


        SelectCharacter();


    }

    // Update is called once per frame
    void Update()
    {

    }

    //aktivira odabranu kuglu ostale su neaktivne
    void SelectCharacter()
    {
        int i = 0;
        foreach (Transform player in transform)
        {
            if (i == selectedCharacter)
                player.gameObject.SetActive(true);
            else
                player.gameObject.SetActive(false);
            i++;
        }
    }
}
