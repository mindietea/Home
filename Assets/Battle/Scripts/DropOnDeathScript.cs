using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOnDeathScript : MonoBehaviour
{

    public GameObject dropItem;

    public void Drop()
    {
        Debug.Log("drop");
        GameObject drop = Instantiate(dropItem);
        drop.transform.position = transform.position;
    }
}
