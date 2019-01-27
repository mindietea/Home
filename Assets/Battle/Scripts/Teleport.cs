using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject Portal;

    public GameObject room;

    void Start()
    {
        room = GameObject.FindWithTag("Room");
        room.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            room.SetActive(true);
            SceneManager.LoadScene(PlayerPrefs.GetInt("Home"));
        }
    }
}
