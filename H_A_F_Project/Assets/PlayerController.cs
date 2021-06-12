using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerStats stats;

    private Vector2 move;

    private Rigidbody2D rb;

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

      
    }

    public void Movement()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        rb.velocity = move * stats.speed;
    }
}
