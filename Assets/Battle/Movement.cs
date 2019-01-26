using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour // Normal Movements Variables
{
    public float speed;
    public Transform Player;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate (Character1.up * speed);       
            transform.position += character1.up * speed;

            Rigidbody2D.Addforce(character1.up);
            Rigidbody2D.velocity = character1.up;
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Translate (Character1.left * speed);       
            transform.position +=character1.left * speed;

            Rigidbody2D.Addforce(character1.left);
            Rigidbody2D.velocity = character1.left;
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate (Character1.down * speed);       
            transform.position +=character1.down * speed;

            Rigidbody2D.Addforce(character1.down);
            Rigidbody2D.velocity = character1.down;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate (Character1.right * speed);       
            transform.position +=character1.right * speed;

            Rigidbody2D.Addforce(character1.right);
            Rigidbody2D.velocity = character1.down;
        }
    }
}
