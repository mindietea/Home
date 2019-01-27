using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalDropScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Resource pickup
            other.gameObject.GetComponent<PlayerExploreScript>().AddStars(1);

            AudioSource audio = GameObject.Find("Audio").GetComponent<AudioSource>();
            AudioScript script = GameObject.Find("Audio").GetComponent<AudioScript>();
            audio.PlayOneShot(script.starPickup, 1.0f);

            // Destroy
            Destroy(gameObject);
        }
    }
}
