using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesScript : MonoBehaviour
{
    public int damage = 3;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerExploreScript>().Damage(damage);
        }
    }

}
