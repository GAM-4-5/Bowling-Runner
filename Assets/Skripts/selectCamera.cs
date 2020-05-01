using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectCamera : MonoBehaviour
{
    public int kont;
    public int selectedCharacter = 0;

    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;
    public GameObject camera6;
    public GameObject camera7;
    public GameObject camera8;
    public GameObject camera9;

    AudioListener camera1AudioLis;
    AudioListener camera2AudioLis;
    AudioListener camera3AudioLis;
    AudioListener camera4AudioLis;
    AudioListener camera5AudioLis;
    AudioListener camera6AudioLis;
    AudioListener camera7AudioLis;
    AudioListener camera8AudioLis;
    AudioListener camera9AudioLis;

    // Use this for initialization
    void Start()
    {
        PlayerData data1 = Save.LoadPlayer();
        selectedCharacter = data1.selectedCharacter;



        //Get Camera Listeners
        camera1AudioLis = camera1.GetComponent<AudioListener>();
        camera2AudioLis = camera2.GetComponent<AudioListener>();
        camera3AudioLis = camera3.GetComponent<AudioListener>();
        camera4AudioLis = camera4.GetComponent<AudioListener>();
        camera5AudioLis = camera5.GetComponent<AudioListener>();
        camera6AudioLis = camera6.GetComponent<AudioListener>();
        camera7AudioLis = camera7.GetComponent<AudioListener>();
        camera8AudioLis = camera8.GetComponent<AudioListener>();
        camera9AudioLis = camera9.GetComponent<AudioListener>();

        //Camera Position Set
        //cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));


        SelectCamera();
    }

    //provjerava koja kugla je odabrana te aktivira kameru za tu kuglu dok ostale gasi
    void SelectCamera()
    {
        if (selectedCharacter == 0)
        {
            camera1.SetActive(true);
            camera1AudioLis.enabled = true;

            camera2AudioLis.enabled = false;
            camera2.SetActive(false);

            camera3AudioLis.enabled = false;
            camera3.SetActive(false);

            camera4AudioLis.enabled = false;
            camera4.SetActive(false);

            camera5AudioLis.enabled = false;
            camera5.SetActive(false);

            camera6AudioLis.enabled = false;
            camera6.SetActive(false);

            camera7AudioLis.enabled = false;
            camera7.SetActive(false);

            camera8AudioLis.enabled = false;
            camera8.SetActive(false);

            camera9AudioLis.enabled = false;
            camera9.SetActive(false);

        }
        if (selectedCharacter == 1)
        {
            camera2.SetActive(true);
            camera2AudioLis.enabled = true;

            camera1AudioLis.enabled = false;
            camera1.SetActive(false);

            camera3AudioLis.enabled = false;
            camera3.SetActive(false);

            camera4AudioLis.enabled = false;
            camera4.SetActive(false);

            camera5AudioLis.enabled = false;
            camera5.SetActive(false);

            camera6AudioLis.enabled = false;
            camera6.SetActive(false);

            camera7AudioLis.enabled = false;
            camera7.SetActive(false);

            camera8AudioLis.enabled = false;
            camera8.SetActive(false);

            camera9AudioLis.enabled = false;
            camera9.SetActive(false);

        }
        if (selectedCharacter == 2)
        {
            camera3.SetActive(true);
            camera3AudioLis.enabled = true;

            camera2AudioLis.enabled = false;
            camera2.SetActive(false);

            camera1AudioLis.enabled = false;
            camera1.SetActive(false);

            camera4AudioLis.enabled = false;
            camera4.SetActive(false);

            camera5AudioLis.enabled = false;
            camera5.SetActive(false);

            camera6AudioLis.enabled = false;
            camera6.SetActive(false);

            camera7AudioLis.enabled = false;
            camera7.SetActive(false);

            camera8AudioLis.enabled = false;
            camera8.SetActive(false);

            camera9AudioLis.enabled = false;
            camera9.SetActive(false);

        }
        if (selectedCharacter == 3)
        {
            camera4.SetActive(true);
            camera4AudioLis.enabled = true;

            camera2AudioLis.enabled = false;
            camera2.SetActive(false);

            camera3AudioLis.enabled = false;
            camera3.SetActive(false);

            camera1AudioLis.enabled = false;
            camera1.SetActive(false);

            camera5AudioLis.enabled = false;
            camera5.SetActive(false);

            camera6AudioLis.enabled = false;
            camera6.SetActive(false);

            camera7AudioLis.enabled = false;
            camera7.SetActive(false);

            camera8AudioLis.enabled = false;
            camera8.SetActive(false);

            camera9AudioLis.enabled = false;
            camera9.SetActive(false);

        }
        if (selectedCharacter == 4)
        {
            camera5.SetActive(true);
            camera5AudioLis.enabled = true;

            camera2AudioLis.enabled = false;
            camera2.SetActive(false);

            camera3AudioLis.enabled = false;
            camera3.SetActive(false);

            camera4AudioLis.enabled = false;
            camera4.SetActive(false);

            camera1AudioLis.enabled = false;
            camera1.SetActive(false);

            camera6AudioLis.enabled = false;
            camera6.SetActive(false);

            camera7AudioLis.enabled = false;
            camera7.SetActive(false);

            camera8AudioLis.enabled = false;
            camera8.SetActive(false);

            camera9AudioLis.enabled = false;
            camera9.SetActive(false);

        }
        if (selectedCharacter == 5)
        {
            camera6.SetActive(true);
            camera6AudioLis.enabled = true;

            camera2AudioLis.enabled = false;
            camera2.SetActive(false);

            camera3AudioLis.enabled = false;
            camera3.SetActive(false);

            camera4AudioLis.enabled = false;
            camera4.SetActive(false);

            camera1AudioLis.enabled = false;
            camera1.SetActive(false);

            camera5AudioLis.enabled = false;
            camera5.SetActive(false);

            camera7AudioLis.enabled = false;
            camera7.SetActive(false);

            camera8AudioLis.enabled = false;
            camera8.SetActive(false);

            camera9AudioLis.enabled = false;
            camera9.SetActive(false);

        }
        if (selectedCharacter == 6)
        {
            camera6.SetActive(false);
            camera6AudioLis.enabled = false;

            camera2AudioLis.enabled = false;
            camera2.SetActive(false);

            camera3AudioLis.enabled = false;
            camera3.SetActive(false);

            camera4AudioLis.enabled = false;
            camera4.SetActive(false);

            camera1AudioLis.enabled = false;
            camera1.SetActive(false);

            camera5AudioLis.enabled = false;
            camera5.SetActive(false);

            camera7AudioLis.enabled = true;
            camera7.SetActive(true);

            camera8AudioLis.enabled = false;
            camera8.SetActive(false);

            camera9AudioLis.enabled = false;
            camera9.SetActive(false);

        }
        if (selectedCharacter == 7)
        {
            camera6.SetActive(false);
            camera6AudioLis.enabled = false;

            camera2AudioLis.enabled = false;
            camera2.SetActive(false);

            camera3AudioLis.enabled = false;
            camera3.SetActive(false);

            camera4AudioLis.enabled = false;
            camera4.SetActive(false);

            camera1AudioLis.enabled = false;
            camera1.SetActive(false);

            camera5AudioLis.enabled = false;
            camera5.SetActive(false);

            camera7AudioLis.enabled = false;
            camera7.SetActive(false);

            camera8AudioLis.enabled = true;
            camera8.SetActive(true);

            camera9AudioLis.enabled = false;
            camera9.SetActive(false);

        }
        if (selectedCharacter == 8)
        {
            camera6.SetActive(false);
            camera6AudioLis.enabled = false;

            camera2AudioLis.enabled = false;
            camera2.SetActive(false);

            camera3AudioLis.enabled = false;
            camera3.SetActive(false);

            camera4AudioLis.enabled = false;
            camera4.SetActive(false);

            camera1AudioLis.enabled = false;
            camera1.SetActive(false);

            camera5AudioLis.enabled = false;
            camera5.SetActive(false);

            camera7AudioLis.enabled = false;
            camera7.SetActive(false);

            camera8AudioLis.enabled = false;
            camera8.SetActive(false);

            camera9AudioLis.enabled = true;
            camera9.SetActive(true);

        }
    }
}
