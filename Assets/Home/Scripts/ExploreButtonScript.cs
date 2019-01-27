using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExploreButtonScript : MonoBehaviour
{
    public void LoadExploreScene()
    {
        GameObject.FindWithTag("Room").SetActive(false);
        SceneManager.LoadScene("Explore");
    }
}
