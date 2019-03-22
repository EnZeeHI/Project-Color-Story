using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool openTheDoor;
    public bool objectiveComplete ;
    Vector3 doorOpenVector;
    Vector3 doorClosedVector;
    bool doorOpen = false;
    bool doorClosed = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(objectiveComplete = true)
        {
        if (openTheDoor)
        {
            doorOpenVector = transform.position + new Vector3 (0,0,2);
            doorClosedVector =  transform.position + new Vector3 (0,0,-2);
            if (openTheDoor && doorOpen)
            {
                transform.position = doorClosedVector;
                doorClosed = true;
                doorOpen = false;
                openTheDoor =false;
            }
            else if (openTheDoor && doorClosed)
            {
                transform.position = doorOpenVector;
                doorClosed = false;
                doorOpen  = true;
                openTheDoor =false;
            }
            
        }
        }
    }
}
