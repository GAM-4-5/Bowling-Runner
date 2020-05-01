using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMenager : MonoBehaviour
{

    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 50.0f;
    private int amnTilesOnScreen = 50;

    // Start is called before the first frame update
    //postavlja traku za kretanje ispred igraca ukoliko se približi rubu
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
        if(playerTransform.position.z > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
        }
    }
    //stvara novu tranu za kretanje
    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
    }
}
