using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalMonsterScript : MonoBehaviour
{

    public float shortRange = 3.0f;
    public float longRange = 6.0f;
    public float lowSpeed = 0.04f;
    public float highSpeed = 0.08f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 dir = GameObject.FindWithTag("Player").transform.position - transform.position;
        dir.Normalize();

        if (InShortRange())
        {
            transform.Translate(dir * highSpeed);
        } else if(InLongRange())
        {
            transform.Translate(dir * lowSpeed);
        }
    }

    private bool InLongRange()
    {
        return Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position) <= longRange;
    }

    private bool InShortRange()
    {
        return Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position) <= shortRange;
    }
}
