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

    public float range = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        innerSpikes = transform.Find("InnerSpikes").gameObject;
        middleSpikes = transform.Find("MiddleSpikes").gameObject;
        outerSpikes = transform.Find("OuterSpikes").gameObject;

        DeactivateSpikes();
    }

    private bool InRange()
    {
        return Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position) <= range;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTimer += Time.deltaTime;

        if(!InRange())
        {
            return;
        }

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


                AudioSource source = GameObject.Find("Audio").GetComponent<AudioSource>();
                AudioScript script = GameObject.Find("Audio").GetComponent<AudioScript>();
                source.PlayOneShot(script.rockShoot, 1.0f);
            } else if((currentTimer >= spikeCooldown + 1*spikeFrequency) && !middleSpikes.active && !outerSpikes.active)
            {
                DeactivateSpikes();
                middleSpikes.SetActive(true);


                AudioSource source = GameObject.Find("Audio").GetComponent<AudioSource>();
                AudioScript script = GameObject.Find("Audio").GetComponent<AudioScript>();
                source.PlayOneShot(script.rockShoot, 1.0f);
            } else if((currentTimer >= spikeCooldown) && !innerSpikes.active && !middleSpikes.active && !outerSpikes.active)
            {
                DeactivateSpikes();
                innerSpikes.SetActive(true);


                AudioSource source = GameObject.Find("Audio").GetComponent<AudioSource>();
                AudioScript script = GameObject.Find("Audio").GetComponent<AudioScript>();
                source.PlayOneShot(script.rockShoot, 1.0f);
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
