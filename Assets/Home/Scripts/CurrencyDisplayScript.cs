using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDisplayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLogs();
        UpdateRocks();
        UpdateStars();
    }

    void UpdateLogs()
    {
        GameObject logsCost = transform.Find("Logs/LogsCost").gameObject;
        logsCost.GetComponent<Text>().text = GameObject.Find("PlayerStats").GetComponent<PlayerStats>().logs.ToString();
    }

    void UpdateRocks()
    {
        GameObject rocksCost = transform.Find("Rocks/RocksCost").gameObject;
        rocksCost.GetComponent<Text>().text = GameObject.Find("PlayerStats").GetComponent<PlayerStats>().rocks.ToString();
    }

    void UpdateStars()
    {
        GameObject starsCost = transform.Find("Stars/StarsCost").gameObject;
        starsCost.GetComponent<Text>().text = GameObject.Find("PlayerStats").GetComponent<PlayerStats>().stars.ToString();
    }
}
