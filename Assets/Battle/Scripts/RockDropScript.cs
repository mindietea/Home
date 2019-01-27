using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDropScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Resource pickup
            other.gameObject.GetComponent<PlayerExploreScript>().AddRocks(1);
            // Destroy
            Destroy(gameObject);
        }
    }
}
