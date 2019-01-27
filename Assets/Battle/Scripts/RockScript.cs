using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    public float spikeFrequency = 0.75f;
    public float spikeCooldown = 5.0f;

    private GameObject innerSpikes;
    private GameObject middleSpikes;
    private GameObject outerSpikes;

    private float currentTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        innerSpikes = transform.Find("InnerSpikes").gameObject;
        middleSpikes = transform.Find("MiddleSpikes").gameObject;
        outerSpikes = transform.Find("OuterSpikes").gameObject;

        DeactivateSpikes();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTimer += Time.deltaTime;

        if (currentTimer >= spikeCooldown)
        {
            if(currentTimer >= spikeCooldown + 3*spikeFrequency)
            {
                DeactivateSpikes();
                currentTimer = 0.0f;
            } else if((currentTimer >= spikeCooldown + 2*spikeFrequency) && !outerSpikes.active)
            {
                DeactivateSpikes();
                outerSpikes.SetActive(true);
            } else if((currentTimer >= spikeCooldown + 1*spikeFrequency) && !middleSpikes.active && !outerSpikes.active)
            {
                DeactivateSpikes();
                middleSpikes.SetActive(true);
            } else if((currentTimer >= spikeCooldown) && !innerSpikes.active && !middleSpikes.active && !outerSpikes.active)
            {
                DeactivateSpikes();
                innerSpikes.SetActive(true);
            }
        }   
    }

    void DeactivateSpikes()
    {
        innerSpikes.SetActive(false);
        middleSpikes.SetActive(false);
        outerSpikes.SetActive(false);
    }
}
