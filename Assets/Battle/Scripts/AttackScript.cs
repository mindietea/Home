using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public float duration = 1.0f;

    public float lifetime = 0.0f;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        lifetime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lifetime += Time.deltaTime;
        if(lifetime >= duration)
        {
            lifetime = 0.0f;
            gameObject.SetActive(false);
        }
    }
}
