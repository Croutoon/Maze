using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    private int KeysCollected = 0;
    public TextMeshProUGUI keysText;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(KeysCollected == 2)
        {
            foreach(GameObject door in GameObject.FindGameObjectsWithTag("door")) {
                Door d = door.GetComponent<Door>();
                if (d.endDoor)
                {
                    d.ForceOpen();
                }
            }
        }

        keysText.text = "Keys: " + KeysCollected + "/2";

    }

    public void AddKey()
    {
        KeysCollected++;
    }
}
