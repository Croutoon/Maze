using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public float speed = 0.125f;
    public Transform player;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }
}
