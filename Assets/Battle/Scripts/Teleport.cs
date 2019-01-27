using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject Portal;


    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Cash in resources
            GameObject.FindWithTag("Player").GetComponent<PlayerExploreScript>().CashIn();

            GameObject playerStats = GameObject.FindWithTag("PlayerStats");
            if(playerStats != null)
            {
                playerStats.GetComponent<PlayerStats>().room.SetActive(true);
            }


            SceneManager.LoadScene(PlayerPrefs.GetInt("Home"));
        }
    }
}
