using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    public float speed;
    private Animator anim;

    public float hitRedDuration = 0.3f;
    private float lastHit = 1000.0f;

    private void Start()
    {

    }
    
    void Update()
    {
        lastHit += Time.deltaTime;

        if(lastHit >= hitRedDuration)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }

        if (health <= 0)
        {
            if(gameObject.GetComponent<DropOnDeathScript>() != null)
            {
                gameObject.GetComponent<DropOnDeathScript>().Drop();
            }
            GameObject.Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    
    }

    public void TakeDamage(int damage)
    {
        health = Mathf.Max(0, health - damage);
        Debug.Log("damage Taken");
        
        AudioSource audio = GameObject.Find("Audio").GetComponent<AudioSource>();
        AudioScript script = GameObject.Find("Audio").GetComponent<AudioScript>();
        audio.PlayOneShot(script.rockHurt, 1.0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "PlayerAttack")
        {
            lastHit = 0.0f;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            TakeDamage(other.gameObject.GetComponent<AttackScript>().damage);
        }
    }
}
