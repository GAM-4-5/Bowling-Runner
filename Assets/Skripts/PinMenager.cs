using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinMenager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 400.0f;
    private float tileLength = 50.0f;
    private int amnTilesOnScreen = 7;
    public int spawnX;
    private float spawnY = 2.7f;

    // Start is called before the first frame update
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
    private void SpawnTile(int prefabIndex = -1)
    {
        spawnX = Random.Range(-20, 20);
        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = new Vector3(spawnX,spawnY,spawnZ);
        spawnZ += tileLength;
    }
}
