using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerStats stats;

    [Header("GroundCheck")]
    public Transform G_Check;
    public float G_Radius;
    public LayerMask G_Layer;

    public Vector2 move;
    private Rigidbody2D rb;

    public float gravity;
    private Vector2 velocity;

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
        if (!GroundCheck())
        {
            move = Vector2.down * gravity;

            transform.Translate(move * Time.deltaTime);
        }
        else move.y = 0;
    }

    public bool GroundCheck()
    {
        return Physics2D.OverlapCircle(G_Check.position, G_Radius, G_Layer);
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
            rb.AddForce(Vector2.up * stats.jump, ForceMode2D.Force);
        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(G_Check.position, G_Radius);
    }
}
