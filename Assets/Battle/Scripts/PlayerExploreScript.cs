using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExploreScript : MonoBehaviour
{

    public int health = 20;
    public int logs = 0;
    public int rocks = 0;
    public int stars = 0;

    public int Damage(int dmg)
    {
        health = Mathf.Max(0, health - dmg);
        Debug.Log("Health is now " + health);
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
