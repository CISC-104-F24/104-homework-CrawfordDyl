using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatform : MonoBehaviour
{
    public float bounceForce = 12f;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRb = other.gameObject.GetComponent<Rigidbody>();
            if (playerRb != null)
            {
                playerRb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
            }
        }
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
