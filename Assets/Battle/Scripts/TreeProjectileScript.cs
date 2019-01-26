using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * A projectile that runs for its maxDistance then stops. If droppable, will become a wood pickup once it stops.
 * Damages the Player.
 */
public class TreeProjectileScript : MonoBehaviour
{
    public float maxDistance = 10.0f;
    public Vector2 direction = new Vector2(1.0f, 0.0f);
    public float speed = 2.0f;
    public bool droppable = true;
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

        if(!dropped && GetDistanceTraveled() > maxDistance)
        {
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
            Vector3 direction3d = new Vector3((direction * speed).x, (direction * speed).y, 0);
            transform.position += direction3d;
        }
    }

    float GetDistanceTraveled()
    {
        return Vector2.Distance(transform.position, startPos);
    }
}
