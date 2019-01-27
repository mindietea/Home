using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExploreButtonScript : MonoBehaviour
{
    public void LoadExploreScene()
    {
        GameObject playerStats = GameObject.FindWithTag("PlayerStats");
        if(playerStats != null)
        {
            playerStats.GetComponent<PlayerStats>().room.SetActive(false);
        }
        SceneManager.LoadScene("Explore");
    }
}
