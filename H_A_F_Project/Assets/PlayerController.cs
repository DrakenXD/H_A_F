using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerStats stats;

    private Vector2 move;

    private Rigidbody2D rb;

    public float gravity;

    private void Awake()
    {
        stats.life = stats.Maxlife;
        stats.jump = stats.Maxjump;
        stats.speed = stats.Maxspeed;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();


    }
    private void FixedUpdate()
    {
        GravityController();
    }

    public void GravityController()
    {
        move.y -= gravity * Time.deltaTime;

        rb.velocity += move;
    }

    public void Movement()
    {
        move.x = Input.GetAxisRaw("Horizontal");

        rb.velocity = move * stats.speed;
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * stats.jump;
        }


    }
}
