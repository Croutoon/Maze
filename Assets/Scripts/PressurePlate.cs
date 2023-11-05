using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        foreach (var item in GameObject.FindGameObjectsWithTag("door"))
        {
            item.GetComponent<Door>().switchState();
        }
    }

}
