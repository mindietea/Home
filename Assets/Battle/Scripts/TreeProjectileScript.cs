using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * A projectile that runs for its maxDistance then stops. If droppable, will become a wood pickup once it stops.
 * Damages the Player.
 */
public class TreeProjectileScript : MonoBehaviour
{
    public int damage = 1;
    public int pickupValue = 1;
    public float maxDistance = 5.0f;
    public Vector2 direction = new Vector2(1.0f, 0.0f);
    public float speed = 2.0f;
    public bool droppable = false;
    public bool dropped = false;

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        direction.Normalize();
    }

    void FixedUpdate()
    {

        // Reached max distance
        if(!dropped && GetDistanceTraveled() > maxDistance)
        {
            Debug.Log("Reached max distance, droppable = " + droppable);
            // Drop or destroy
            if(droppable)
            {
                dropped = true;
            } else
            {
                Destroy(gameObject);
            }

        } else if(!dropped)
        {
            // Keep traveling
            direction.Normalize();
            Vector3 direction3d = new Vector3((direction * speed).x, (direction * speed).y, 0);
            transform.position += direction3d;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            // Hit behavior
            if(!dropped)
            {
                // Damage
                other.gameObject.GetComponent<PlayerExploreScript>().Damage(damage);
            } else
            {
                // Resource pickup
                other.gameObject.GetComponent<PlayerExploreScript>().AddLogs(pickupValue);
            }

            // Destroy
            Destroy(gameObject);
        }
    }

    float GetDistanceTraveled()
    {
        return Vector2.Distance(transform.position, startPos);
    }
}
