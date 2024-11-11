using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableCube : MonoBehaviour
{
    public float pushStrength = 5f;

    private void nCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 pushDirection = other.transform.forward;

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(pushDirection * pushStrength);
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
