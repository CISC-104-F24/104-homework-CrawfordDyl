using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float sprintSpeedMultiplier = 2.0f;
    public float jumpForce = 3.0f;
    public float maxChargedJumpForce = 10.0f;
    public float minScale = 0.5f;
    public float maxScale = 2.0f;

    private bool isGrounded = true;
    private bool isSprinting = false;
    private bool isChargingJump = false;
    private float chargedJumpForce = 0.0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Check for grounded state
        isGrounded = true;

        // Movement Inputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);
        moveDirection.Normalize();

        if (isSprinting)
        {
            moveDirection *= moveSpeed * sprintSpeedMultiplier;
        }
        else
        {
            moveDirection *= moveSpeed;
        }

        transform.Translate(moveDirection * Time.deltaTime);

        // Jumping Input
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isChargingJump = true;
            }
        }

        if (isChargingJump)
        {
            if (chargedJumpForce < maxChargedJumpForce)
            {
                chargedJumpForce += Time.deltaTime * maxChargedJumpForce;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) && isGrounded && isChargingJump)
        {
            rb.AddForce(Vector3.up * (jumpForce + chargedJumpForce), ForceMode.Impulse);
            chargedJumpForce = 0.0f;
            isChargingJump = false;
        }

        // Sprinting Input
        isSprinting = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        // Scaling Input
        if (Input.GetKey(KeyCode.N))
        {
            // Shrink character using the N Key
            float currentScale = transform.localScale.x;
            float newScale = Mathf.Clamp(currentScale - 0.01f, minScale, maxScale);
            transform.localScale = new Vector3(newScale, newScale, newScale);
        }
        else if (Input.GetKey(KeyCode.M))
        {
            // Grow character using the M key
            float currentScale = transform.localScale.x;
            float newScale = Mathf.Clamp(currentScale + 0.01f, minScale, maxScale);
            transform.localScale = new Vector3(newScale, newScale, newScale);
        }
    }
}