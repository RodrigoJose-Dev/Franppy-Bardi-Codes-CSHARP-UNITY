using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource jumpSound;

    public float jumpForce = 22;

    public GameObject gameOver;

    private void Awake()
    {
        jumpSound = GetComponent<AudioSource>();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
            jumpSound.Play();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

}
