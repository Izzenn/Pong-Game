using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float ballspeed = 5f;
    public Rigidbody2D ball;
    private float x;
    private float y;
    private Vector3 respawnpoint = new Vector3(0, 0, 0);
    public scoring Score;
    
    // Start is called before the first frame update
    void Start()
    {

        launchBall();
        Score = GameObject.FindGameObjectWithTag("logic").GetComponent<scoring>();
        
        
    }
   
    // Update is called once per frame
    void Update()
    {
   
    }
    public void launchBall()
    {
        x = Random.Range(0, 2) == 0 ? -1 : 1;
        y = Random.Range(0, 2) == 0 ? -1 : 1;
        ball.velocity = new Vector2(ballspeed * x, ballspeed * y);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            
            if (collision.gameObject.layer == 6)
            {
                transform.position = respawnpoint;
                launchBall();
                Score.AddScorePlayer();

            }
            if (collision.gameObject.layer == 7)
            {
                transform.position = respawnpoint;
                launchBall();
                Score.AddScoreOpp();

            }
        
        
    }
}
