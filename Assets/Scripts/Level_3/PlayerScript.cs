using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10;
    public float jumpAmount = 10;

    private Vector3 movement;
    private Rigidbody rb;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.AddForce(movement * speed);
    }

    public void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();
        movement = new Vector3(v.x, 0.0f, v.y);
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plane")
            isGrounded = true;

        if (collision.gameObject.tag == "End")
            SceneManager.LoadScene("Victory");
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Plane")
            isGrounded = false;
    }
}
