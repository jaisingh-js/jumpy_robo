using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{

    public Transform groundCheck;
    public LayerMask lm;
    public Animator anim;
    private float run_velo;
    public bool isGrounded;
    public Rigidbody2D rb2d;
    private float jump_checker;

    public float circle_radious = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed" , run_velo);

        if( jump_checker == 0f)
        {
            if (isGrounded == false)
            {
                jump_checker =1f;
                anim.SetTrigger("jump");
                anim.SetBool("onGround" , false);
            }
        }
        else if(jump_checker == 1f)
        {
            if(isGrounded == true)
            {
                jump_checker = 0f;
                anim.SetBool("onGround" , true);
            }
        }

        
        
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position , circle_radious , lm);
        run_velo = Mathf.Abs(rb2d.velocity.x) ;
    }
}
