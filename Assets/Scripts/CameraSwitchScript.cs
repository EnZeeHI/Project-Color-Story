using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchScript : MonoBehaviour
{

    public Camera camera1;
    public Camera camera2;
    public PictureCaptureScript PictureCaptureScript;
    

    // Start is called before the first frame update
    void Start()
    {
     camera1.enabled = true;
     camera2.enabled = false; 
     PictureCaptureScript = GameObject.Find("Picture Camera").GetComponent<PictureCaptureScript>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
            PictureCaptureScript.ableToCapture = !PictureCaptureScript.ableToCapture;
        }
        // if (camera2.enabled)
        // {
        //     PictureCaptureScript.ableToCapture = true;
        // }
        // else
        // {
        //     PictureCaptureScript.ableToCapture = true;
        // }
        
    }
}
