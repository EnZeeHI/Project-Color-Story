using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoorScript : MonoBehaviour
{


    public GameObject linkedDoor;
    public GameObject player;
    public InteractionScript interactionScript;
    public bool openDoor = false;
    public Camera camera; 
    Vector3 rotation; 
     
    
    // Start is called before the first frame update
    void Start()
    {
     interactionScript = player.GetComponent<InteractionScript>(); 
     rotation = linkedDoor.transform.rotation.eulerAngles; 
     rotation = new Vector3(rotation.x, rotation.y, rotation.z) ;
    }

    // Update is called once per frame
    void Update()
    {
        if (openDoor)
        {
            player.transform.position = (linkedDoor.transform.position + (linkedDoor.transform.forward * 2));
            player.transform.rotation = Quaternion.Euler(rotation);
            camera.transform.rotation = Quaternion.Euler(rotation);
            openDoor = false;
        }
        else
        {
            //player.transform.position != (linkedDoor.transform.position + new Vector3 (0,0,5));
        }
    }
}
