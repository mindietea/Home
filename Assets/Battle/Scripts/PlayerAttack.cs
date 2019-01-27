using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackCooldown = 0.5f;
    public float lastAttack = 1000.0f;

    public GameObject attack;
    

    public float attackDistance = 2.0f;

    void Start()
    {
        attack.SetActive(false);
        lastAttack = 1000.0f;
    }

    void Update()
    {
        lastAttack += Time.deltaTime;
        
        if (Input.GetMouseButtonDown(0) && (lastAttack >= attackCooldown))
        {
            lastAttack = 0.0f;
            Vector3 mouseVec = new Vector3(GetCursorVector(transform.position).x, GetCursorVector(transform.position).y, 0);
            attack.transform.position = transform.position + mouseVec * attackDistance;
            attack.SetActive(true);
            AudioSource source = GameObject.Find("Audio").GetComponent<AudioSource>();
            AudioScript script = GameObject.Find("Audio").GetComponent<AudioScript>();
            source.PlayOneShot(script.playerAttack, 1.0f);
        }
        
    }

    public static Vector2 GetCursorVector(Vector2 pos)
    {
        Vector3 worldCursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 cursor = new Vector2(worldCursor.x, worldCursor.y);
        Vector2 vector = (cursor - pos).normalized;

        return vector;
    }
}
