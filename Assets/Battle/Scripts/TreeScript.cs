using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{

    public float projectileCooldown = 2.0f;
    public float currentTimer = 0.0f;
    public int maxDrops = 5;
    public Transform projectile;
    public float shortRange = 5.0f;
    public float maxRange = 15.0f;

    private int shotsFired = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Time to fire
        if(currentTimer >= projectileCooldown && InLongRange())
        {
            currentTimer = 0.0f;

            // Long shots
            if(shotsFired >= maxDrops)
            {
                Transform shot = Instantiate(projectile);
                shot.position = transform.position;
                shot.GetComponent<TreeProjectileScript>().droppable = false;
                shot.GetComponent<TreeProjectileScript>().direction = GameObject.FindWithTag("Player").transform.position - transform.position;
                shot.GetComponent<TreeProjectileScript>().maxDistance = maxRange;
                shotsFired++;


                AudioSource source = GameObject.Find("Audio").GetComponent<AudioSource>();
                AudioScript script = GameObject.Find("Audio").GetComponent<AudioScript>();
                source.PlayOneShot(script.treeShoot, 1.0f);
            }
            // Short shots
            else if(InShortRange())
            {
                Transform shot = Instantiate(projectile);
                shot.position = transform.position;
                shot.GetComponent<TreeProjectileScript>().droppable = true;
                shot.GetComponent<TreeProjectileScript>().direction = GameObject.FindWithTag("Player").transform.position - transform.position;
                shot.GetComponent<TreeProjectileScript>().maxDistance = shortRange;
                shotsFired++;

                AudioSource source = GameObject.Find("Audio").GetComponent<AudioSource>();
                AudioScript script = GameObject.Find("Audio").GetComponent<AudioScript>();
                source.PlayOneShot(script.treeShoot, 1.0f);
            }

        } else
        {
            currentTimer += Time.deltaTime;
        }
    }

    private bool InShortRange()
    {
        return Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position) <= shortRange;
    }

    private bool InLongRange()
    {
        return Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position) <= maxRange;
    }
}
