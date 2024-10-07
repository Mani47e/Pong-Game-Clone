using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
    public float playerSpeed;

    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float Ydirection = Input.GetAxisRaw("Vertical1");

        playerDirection = new Vector2 (0,Ydirection).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = playerDirection*playerSpeed;
    }
}
