using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Return()
    {
        Debug.Log("return");
        GameObject playerStats = GameObject.FindWithTag("PlayerStats");
        if (playerStats != null)
        {
            playerStats.GetComponent<PlayerStats>().room.SetActive(true);
        }
        SceneManager.LoadScene(PlayerPrefs.GetInt("Home"));

    }
}
