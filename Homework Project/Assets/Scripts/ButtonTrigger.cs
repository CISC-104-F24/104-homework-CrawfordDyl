using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject Door;
    public Transform PushableCube;
    private bool isPushableCubeOnButton = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == PushableCube)
        {
            isPushableCubeOnButton = true;
            Door.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.transform == PushableCube)
        {
            isPushableCubeOnButton = false;
            Door.SetActive(true);
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
