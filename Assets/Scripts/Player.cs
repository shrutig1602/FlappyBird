using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //SpriteRenderer sp;
    Rigidbody2D rb;
    //public Sprite[] playerSprites;
    //private int playerSpritesIndex;
    public float speed;

    bool touchedGround;

    //references
    public GameManager gameManager;
    public Spawner spawner;
    
    /*int angle;
    int maxAngle = 20;
    int minAngle = -90;*/

    

    void Start()
    {
      
        //sp = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        // InvokeRepeating(nameof(animateSprite),0.15f,0.15f);


        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && GameManager.gameIsPaused == false)
        {
            if (GameManager.gameHasStarted == false)
            {
                rb.gravityScale = 0.8f;
                Flap();//we only want our bird to go up and dont want to change anything on horizontal direction

                //spawner reference
                spawner.InstantiatePrefab();

                gameManager.GameHasStarted();
            }
            else {
                Flap();
            }

            
        }

        //birdRotation();
    }


    void Flap()
    {
        AudioManager.audiomanager.Play("flap");
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }


   /* void birdRotation()
    {
        if (rb.velocity.y > 0)
        {
            rb.gravityScale = 0.8f;
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = 0.5f;

            if (rb.velocity.y < -1.3f)
            {
                if (angle >= minAngle)
                {
                    angle = angle - 3;
                }
            }
            
        }

        
            transform.rotation = Quaternion.Euler(0, 0, angle);
        
        

    }*/


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (collision.gameObject.tag == "Obstacle")
            {
            AudioManager.audiomanager.Play("hit");
            FindObjectOfType<GameManager>().GameOver();
            }
            else if (collision.gameObject.tag == "Scoring")
            {
            AudioManager.audiomanager.Play("point");
            FindObjectOfType<GameManager>().IncreaseScore();
            }
       
    }

   

    /*private void animateSprite()
    {
        playerSpritesIndex++;

        if (playerSpritesIndex >= playerSprites.Length)
        {
            playerSpritesIndex = 0;
        }

        sp.sprite = playerSprites[playerSpritesIndex];

    }*/



}
