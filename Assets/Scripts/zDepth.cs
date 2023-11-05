using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zDepth : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x, pos.y, pos.y);
    }
}
