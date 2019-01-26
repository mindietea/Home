using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{

    public float dashCooldown = 1.0f; // Time between dash ending and a new dash starting
    public float dashPower = 5.0f;

    private Rigidbody2D rb;

    private float dashTimer = 0.0f;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Idling
        if(dashTimer < dashCooldown)
        {
            dashTimer += Time.deltaTime;
        } else
        {
            // Time to dash
            dashTimer = 0.0f;
            // Get Vector between player and monster
            Vector2 dir = GameObject.FindWithTag("Player").transform.position - transform.position;
            dir.Normalize();
            rb.AddForce(dir * dashPower);
        }
    }
}
