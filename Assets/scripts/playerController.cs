using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class playerController : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float run_speed = 3f;
    public float jumpForce = 1f;
    private float moveHorizontal;
    private bool jump = false;
    private bool facingRight;
    public Transform groundcheck;
    private float groundradious = 0.4f;
    public LayerMask lm;
    private bool isGrounded;
    public AudioSource walk;
    public AudioSource jump_sound;
    public bool isWalking = false;
    public GameObject gameover;
    public AudioSource game_over;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        facingRight = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = SimpleInput.GetAxis("Horizontal");


        if (isWalking && isGrounded)
        {
            if (!walk.isPlaying)
            {
                walk.Play();
            }

        }
        else
        {
            walk.Stop();
        }


        if ( Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            jump = true;
            
        }

        if(jump)
        {
            jump_sound.Play();
        }



        flip();
       
    }

    private void flip()
    {
        if ((moveHorizontal < 0) && (facingRight == true))
        {
            facingRight = false;
            Quaternion rotater = transform.rotation;
            rotater = Quaternion.Euler(0, 180, 0);
            transform.rotation = rotater;



        }
        else if ((moveHorizontal > 0) && (facingRight == false))
        {
            facingRight = true;
            Quaternion rotater = transform.rotation;
            rotater = Quaternion.Euler(0, 0, 0);
            transform.rotation = rotater;

        }

    }

    public void jumpPlayer()
    {
        if (isGrounded)
        {
            jump = true;
        }
        
    }

    private void FixedUpdate()
    {
        Vector2 x_velocity = new Vector2(moveHorizontal * run_speed, rb2d.velocity.y);
        rb2d.velocity = x_velocity;
        if (x_velocity.x != 0)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        

        isGrounded = Physics2D.OverlapCircle(groundcheck.position, groundradious, lm);

        if(jump)
        {
            rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            jump = false;
        }
    }


    public void Die()
    {
        gameover.SetActive(true);
        Time.timeScale = 0f;
        walk.mute = true;
        jump_sound.mute = true;
        game_over.Play();
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if( other.gameObject.tag == "traps")
        {
            Die();
        }
    }

}
