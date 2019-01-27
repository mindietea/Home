using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if(GameObject.FindWithTag("PlayerStats").GetComponent<PlayerStats>().room == null)
        {
            GameObject.FindWithTag("PlayerStats").GetComponent<PlayerStats>().room = gameObject;
        } else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
