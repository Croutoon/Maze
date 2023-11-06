using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public Transform door;
    public SpriteRenderer sr;
    public BoxCollider2D collider;
    public bool isOpened = false;
    public bool endDoor = false;

    float black = 0.5f;
    float doorY;

    void Start()
    {
        if (isOpened)
        {
            doorY = 0f;
        }
        else
        {
            doorY = .5f ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpened)
        {
            doorY = Mathf.Lerp(doorY, 0f, 4f * Time.deltaTime);
            black = Mathf.Lerp(black, 0.2f, 4f * Time.deltaTime);
        }
        else
        {
            doorY = Mathf.Lerp(doorY, 0.5f, 4f * Time.deltaTime);
            black = Mathf.Lerp(black, 0.5f, 4f * Time.deltaTime);
        }

        if(doorY < .1f)
        {
            collider.enabled = false;
        }
        else
        {
            collider.enabled = true;
        }


        
        Color c = Color.HSVToRGB(0f, 0f, black);
        if (endDoor)
        {
            c = Color.HSVToRGB(0f, 0.2f, black);
        }
        sr.color = c;

        door.localPosition = new Vector3(0f, doorY, -.1f);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(isOpened)
            {
                isOpened = false;
            }
            else
            {
                isOpened = true;
            }
        }
    }

    public void switchState()
    {
        if(!endDoor)
        {
            if (isOpened)
            {
                isOpened = false;
            }
            else
            {
                isOpened = true;
            }
        }
    }

    public void ForceOpen()
    {
        isOpened = true;
    }

    
}
