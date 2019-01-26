using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour // Normal Movements Variables
{
    private Animator anim;
    public float speed;
    public Transform Player;
    private Rigidbody2D rb2d;
   
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate (Vector2.up * speed);
            anim.SetBool("Walking", true);
            //anim.SetFloat("SpeedX" = 0);
            //anim.SetFloat("SpeedY" = 1);
            //transform.position += character1.up * speed;

            //Rigidbody2D.Addforce(character1.up);
            //Rigidbody2D.velocity = character1.up;
        }
       
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate (Vector3.left * speed);
            anim.SetBool("Walking", true);
            //anim.SetFloat("SpeedX" = -1);
            //anim.SetFloat("SpeedY" = 0);
            //transform.position +=character1.left * speed;

            //Rigidbody2D.Addforce(character1.left);
            //Rigidbody2D.velocity = character1.left;
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate (Vector2.down * speed);
            anim.SetBool("Walking", true);
            //anim.SetFloat("SpeedX" = 0);
            //anim.SetFloat("SpeedY" = -1);
            //transform.position +=character1.down * speed;

            //Rigidbody2D.Addforce(character1.down);
            //Rigidbody2D.velocity = character1.down;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate (Vector3.right * speed);
            anim.SetBool("Walking", true);
            //anim.SetFloat("SpeedX" = 1);
            //anim.SetFloat("SpeedY" = 0);
            //transform.position +=character1.right * speed;

            //Rigidbody2D.Addforce(character1.right);
            //Rigidbody2D.velocity = character1.down;
        }
        else
        {
            if(Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.S) == false && Input.GetKey(KeyCode.D) == false) 
            anim.SetBool("Walking", false);
        }
        
    }
}
