using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obsticalPrefabs;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    private int randomObstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void SpawnObstacle ()
    {
        if (playerControllerScript.gameOver == false)
        {
            randomObstacle = Random.Range(0, obsticalPrefabs.Length);
            Instantiate(obsticalPrefabs[randomObstacle], spawnPos, obsticalPrefabs[randomObstacle].transform.rotation);
        }
    }
}
