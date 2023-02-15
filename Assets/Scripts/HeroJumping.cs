using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroJumping : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 50f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("marchmallow"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
