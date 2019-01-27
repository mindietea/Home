using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExploreButtonScript : MonoBehaviour
{
    public void LoadExploreScene()
    {
        SceneManager.LoadScene("Explore");
    }
}
