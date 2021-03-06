﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMenager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 400.0f;
    private float tileLength = 50.0f;
    private int amnTilesOnScreen = 8;
    private int spawnX;
    private float spawnY = 2.8f;

    // Start is called before the first frame update
    // provjerava na kojoj se koordinati nalazi igrač te postavlja nove prepreke
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (playerTransform.position.z > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
        }
    }
    //stvaranje nove prepreke
    private void SpawnTile(int prefabIndex = -1)
    {
        spawnX = Random.Range(-17, 17);
        spawnZ = Random.Range(spawnZ - 20, spawnZ + 20); 
        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = new Vector3(spawnX, spawnY, spawnZ);
        spawnZ += tileLength;
    }
}
