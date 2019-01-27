using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject Portal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            /*Scene sceneToLoad = SceneManager.GetSceneByName("Home");
            SceneManager.LoadScene(sceneToLoad.name, LoadSceneMode.Additive);
            SceneManager.MoveGameObjectToScene(Controller.gameObject, sceneToLoad);
            DontDestroyOnLoad(Controller.gameObject);*/
            SceneManager.LoadScene(PlayerPrefs.GetInt("Home"));
            
        }
    }
}
