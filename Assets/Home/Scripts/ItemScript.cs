using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour
{

    private bool bought = false;

    public GameObject furnitureDisplay;

    // Start is called before the first frame update
    void Start()
    {
        if(furnitureDisplay == null)
        {
            Debug.LogWarning("WARNING: Your ItemScript doesn't have a furnitureDisplay attached! GO name: " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(furnitureDisplay == null)
        {

        } else if(!bought && CanAfford() && !furnitureDisplay.active)
        {
            gameObject.GetComponent<CanvasGroup>().alpha = 1.0f;
        } else
        {
            gameObject.GetComponent<CanvasGroup>().alpha = 0.5f;
        }
    }

    private bool CanAfford()
    {
        return GameObject.Find("PlayerStats").GetComponent<PlayerStats>().CanAfford(GetLogsCost(), GetRocksCost(), GetStarsCost());
    }

    private int GetLogsCost()
    {
        return int.Parse(transform.Find("Cost/Logs/LogsCost").gameObject.GetComponent<Text>().text);
    }

    private int GetRocksCost()
    {
        return int.Parse(transform.Find("Cost/Rocks/RocksCost").gameObject.GetComponent<Text>().text);
    }

    private int GetStarsCost()
    {
        return int.Parse(transform.Find("Cost/Stars/StarsCost").gameObject.GetComponent<Text>().text);
    }

    public void Buy()
    {
        if(!bought && CanAfford() && !furnitureDisplay.active)
        {
            GameObject.Find("PlayerStats").GetComponent<PlayerStats>().logs -= GetLogsCost();
            GameObject.Find("PlayerStats").GetComponent<PlayerStats>().rocks -= GetRocksCost();
            GameObject.Find("PlayerStats").GetComponent<PlayerStats>().stars -= GetStarsCost();
            bought = true;
            furnitureDisplay.SetActive(true);
        }
    }
}
