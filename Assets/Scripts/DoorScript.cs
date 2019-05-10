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
   //bool doorClosed = true;
    public Animator doorOpenAnimation;
    public float doorOpenAngle = 90f;
    public float doorClosedAngle = 0f;
    public float smoothening = 2f;
    public GameObject doorObject;
    public Quaternion doorObjectInitialRotation;

    // Start is called before the first frame update
    void Start()
    {
        //doorOpenAnimation = GetComponent<Animator>();
        doorObjectInitialRotation =doorObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

        if(objectiveComplete = true)
        {
       
            //doorOpenVector = transform.position + new Vector3 (0,0,2);
            //doorClosedVector =  transform.position + new Vector3 (0,0,-2);
            if ( doorOpen)
            {
                //transform.position = doorClosedVector;
                //doorClosed = true;
                //doorOpen = false;
                //openTheDoor =false;
                //doorOpenAnimation.SetBool("DoorOpen", false);
                Quaternion targetRotation =  doorObjectInitialRotation* Quaternion.Euler (0,  doorOpenAngle, 0);
                doorObject.transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, smoothening * Time.deltaTime);
                //transform.GetComponent<BoxCollider>().isTrigger = false;
                Debug.Log(doorObject.transform.localRotation + "opening");
            }
            else 
            {
                //transform.position = doorOpenVector;
                //doorClosed = false;
                //doorOpen  = true;
                //openTheDoor =false;
                //doorOpenAnimation.SetBool("DoorOpen", true);
                Quaternion targetRotation2 =  doorObjectInitialRotation*Quaternion.Euler (0, doorClosedAngle, 0);
                doorObject.transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation2, smoothening * Time.deltaTime);
                //transform.GetComponent<BoxCollider>().isTrigger = true;
                Debug.Log(doorObject.transform.localRotation + "closing");
            }
            
        
        }
    }
    public void ChangeDoorState()
    {
        doorOpen= !doorOpen;
    }
}