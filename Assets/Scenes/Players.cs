using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public bool Player1;
    public bool Player2;
    public bool AI;
    public float movespeed = 5f;
    public Rigidbody2D player;
    private float Move;
    public GameObject Ball;
    public bool Easy;
    public bool Medium;
    public bool Hard;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1)
        {
            Move = Input.GetAxisRaw("Vertical");
            Vector2 movement = new Vector2(0f, Move);
            player.velocity = movement.normalized * movespeed;
        }
        else if (Player2)
        {
            Move = Input.GetAxisRaw("Vertical2");
            Vector2 movement = new Vector2(0f, Move);
            player.velocity = movement.normalized * movespeed;
        }
        else if (AI && Easy)
        {
            if (Ball.transform.position.y > transform.position.y + 0.35f)
            {
                Move = 1;
            }
            if (Ball.transform.position.y < transform.position.y - 0.35f)
            {
                Move = -1;
            }
        }
        else if (AI && Medium)
        {
            if (Ball.transform.position.y > transform.position.y + 0.2f)
            {
                Move = 1;
            }
            if (Ball.transform.position.y < transform.position.y - 0.2f)
            {
                Move = -1;
            }
        }
        else if (AI && Hard)
        {
            if (Ball.transform.position.y > transform.position.y)
            {
                Move = 1;
            }
            if (Ball.transform.position.y < transform.position.y)
            {
                Move = -1;
            }
        }

        player.velocity = new Vector2(player.velocity.x, Move * movespeed);
        
    }
    
    
}
