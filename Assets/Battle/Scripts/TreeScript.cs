using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{

    public float projectileCooldown = 2.0f;
    public float currentTimer = 0.0f;
    public int maxDrops = 3;
    public Transform projectile;

    private int alreadyDropped = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Time to fire
        if(currentTimer >= projectileCooldown)
        {
            Transform shot = Instantiate(projectile);
            if(alreadyDropped < maxDrops)
            {
                alreadyDropped++;
                shot.GetComponent<TreeProjectileScript>().droppable = true;
            } else
            {
                shot.GetComponent<TreeProjectileScript>().droppable = false;
            }

            shot.GetComponent<TreeProjectileScript>().direction = GameObject.FindWithTag("Player").transform.position - transform.position;

        } else
        {
            currentTimer += Time.deltaTime;
        }
    }
}
