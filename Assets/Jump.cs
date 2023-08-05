using System.Collections;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    public PlayerController2D pc;
    
    public float fallMultiplier = 2.5f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        pc = GetComponent<PlayerController2D>();
    }

    void Update()
    {
        if (rb.velocity.y < 0 && !pc.IsGrounded() && !pc.isWallSliding && !pc.isDashing) 
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1f) * Time.deltaTime;
        }
    }

}
