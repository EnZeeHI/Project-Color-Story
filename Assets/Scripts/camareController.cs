using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camareController : MonoBehaviour
{
    float yaw, pitch;

    public float mouseSens;

    public Transform target;

    public float offset;

    public Vector2 pitchMM = new Vector2(-40, 85);

    public GameObject UI;
    
    // Update is called once per frame
    void LateUpdate()
    {
        if (UI.activeInHierarchy == false)
        {


            yaw += Input.GetAxis("Mouse X") * mouseSens;
            pitch -= Input.GetAxis("Mouse Y") * mouseSens;

            yaw += Input.GetAxis("HorizontalCamera") * mouseSens;
            pitch -= Input.GetAxis("VerticalCamera") * mouseSens;

            pitch = Mathf.Clamp(pitch, pitchMM.x, pitchMM.y);

            Vector3 targetRot = new Vector3(pitch, yaw);
            transform.eulerAngles = targetRot;

            transform.position = target.position - transform.forward * offset;
        }
    }
}
