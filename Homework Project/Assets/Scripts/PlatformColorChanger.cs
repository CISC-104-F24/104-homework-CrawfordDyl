using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColorChanger : MonoBehaviour
{
    public Color colorOnJump = Color.red;
    public Color originalColor;
    private Renderer platformRenderer;

    // Start is called before the first frame update
    void Start()
    {
        platformRenderer = GetComponent<Renderer>();
        originalColor = platformRenderer.material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            platformRenderer.material.color = colorOnJump;
        }
    }
        private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
            {
                platformRenderer.material.color = originalColor;
            }
    }
}
