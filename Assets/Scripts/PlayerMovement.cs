using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed = 100f;

    Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        direction = new Vector3(h, v, 0f);
    }

    void FixedUpdate()
    {

        rb.AddForce(direction * speed, ForceMode2D.Force);

    }
}
