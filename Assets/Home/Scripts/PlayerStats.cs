using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int logs, rocks, stars;

    public bool CanAfford(int logsCost, int rocksCost, int starsCost)
    {
        return (logs >= logsCost) && (rocks >= rocksCost) && (stars >= starsCost);
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
