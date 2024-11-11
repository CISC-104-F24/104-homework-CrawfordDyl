using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;         // Speed of the platform
    public float moveDistance = 5f;  // Maximum distance from the starting position

    private Vector3 startPosition;    // Starting position of the platform

    void Start()
    {
        // Record the starting position of the platform
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position using a sine wave for smooth oscillation
        float offset = Mathf.Sin(Time.time * speed) * moveDistance;
        transform.position = new Vector3(startPosition.x + offset, transform.position.y, transform.position.z);
    }
}
