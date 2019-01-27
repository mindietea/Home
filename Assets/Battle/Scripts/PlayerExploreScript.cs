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

    public GameObject playerStatsPrefab;
    public GameObject playerStats;
    
    public void Start()
    {
        health = maxHealth;
        GameObject.Find("MaxHealth").GetComponent<Text>().text = maxHealth.ToString();

        playerStats = GameObject.FindWithTag("PlayerStats");
        if(playerStats == null)
        {
            playerStats = Instantiate(playerStatsPrefab);
        }
    }

    public void Update()
    {
        GameObject.Find("CurrentHealth").GetComponent<Text>().text = health.ToString();

        GameObject.Find("LogsCount").GetComponent<Text>().text = logs.ToString();
        GameObject.Find("RocksCount").GetComponent<Text>().text = rocks.ToString();
        GameObject.Find("StarsCount").GetComponent<Text>().text = stars.ToString();
    }

    public void CashIn()
    {
        playerStats.GetComponent<PlayerStats>().logs += logs;
        playerStats.GetComponent<PlayerStats>().rocks += rocks;
        playerStats.GetComponent<PlayerStats>().stars += stars;
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
