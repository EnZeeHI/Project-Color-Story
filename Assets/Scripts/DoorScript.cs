using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool openTheDoor;
    public bool objectiveComplete ;
    Vector3 doorOpenVector;
    Vector3 doorClosedVector;
    public bool doorOpen = false;
    bool doorClosed = true;
    public Animator doorOpenAnimation;
    // Start is called before the first frame update
    void Start()
    {
        doorOpenAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(objectiveComplete = true)
        {
        if (openTheDoor)
        {
            //doorOpenVector = transform.position + new Vector3 (0,0,2);
            //doorClosedVector =  transform.position + new Vector3 (0,0,-2);
            if (openTheDoor && doorOpen)
            {
                //transform.position = doorClosedVector;
                doorClosed = true;
                doorOpen = false;
                openTheDoor =false;
                doorOpenAnimation.SetBool("DoorOpen", false);
                transform.GetComponent<BoxCollider>().isTrigger = false;
            }
            if (openTheDoor && doorClosed)
            {
                //transform.position = doorOpenVector;
                doorClosed = false;
                doorOpen  = true;
                openTheDoor =false;
                doorOpenAnimation.SetBool("DoorOpen", true);
                transform.GetComponent<BoxCollider>().isTrigger = true;
            }
            
        }
        }
    }
}
