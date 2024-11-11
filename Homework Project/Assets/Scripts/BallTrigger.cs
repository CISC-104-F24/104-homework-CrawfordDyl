using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    private bool ballSpawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !ballSpawned)
        {
            SpawnBall();
            ballSpawned = true;
        }
    }

    private void SpawnBall()
    {
        Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
