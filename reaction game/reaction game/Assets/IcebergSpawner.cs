using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IcebergSpawner : MonoBehaviour
{
    public GameObject icebergPrefab;
    public Transform[] spawnPoint;
    public float gameTime;
    public Text gameText;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        gameTime = gameTime - Time.deltaTime;
        if (gameTime < 1)
        {
            gameTime = 0;
        }
        gameText.text = gameTime.ToString();
    }

    public void Spawn()
    {
        GameObject iceberg = Instantiate(icebergPrefab) as GameObject;
        iceberg.transform.position = spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position;
    }
}
