using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoorScript : MonoBehaviour
{


    public GameObject linkedDoor;
    public GameObject player;
    public InteractionScript interactionScript;
    public bool openDoor = false;
    
    // Start is called before the first frame update
    void Start()
    {
     interactionScript = player.GetComponent<InteractionScript>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (openDoor)
        {
            player.transform.position = (linkedDoor.transform.position + (player.transform.forward * 5));
            openDoor = false;
        }
        else
        {
            //player.transform.position != (linkedDoor.transform.position + new Vector3 (0,0,5));
        }
    }
}
