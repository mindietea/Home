using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerExploreScript : MonoBehaviour
{

    public int maxHealth = 20;
    public int health = 20;
    public int logs = 0;
    public int rocks = 0;
    public int stars = 0;

    public void Start()
    {
        health = maxHealth;
        GameObject.Find("MaxHealth").GetComponent<Text>().text = maxHealth.ToString();
    }

    public void Update()
    {
        GameObject.Find("CurrentHealth").GetComponent<Text>().text = health.ToString();

    }

    public int Damage(int dmg)
    {
        health = Mathf.Max(0, health - dmg);
        return health;
    }

    public void AddLogs(int logs)
    {
        this.logs += logs;
    }

    public void AddRocks(int rocks)
    {
        this.rocks += rocks;
    }

    public void AddStars(int stars)
    {
        this.stars += stars;
    }
}
