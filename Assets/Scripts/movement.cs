using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float forwardSpeed, horizontalSpeed, gravity;
    //public CharacterController controller;

    public float turnSpeed = 0.2f;
    float turnVelocity;

    float currentSpeed;

    public float speedTime = 0.1f;
    float speedVelocity;
    public Animator animator;

    Transform cameraT;

    public GameObject UI;

    
    // Start is called before the first frame update
    void Start()
    {
        cameraT = Camera.main.transform;
        animator = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.activeInHierarchy == false)
        {
            float forward = Input.GetAxis("Vertical"), horizontal = Input.GetAxis("Horizontal");
            if (Input.GetAxis("Vertical") !=0 ||Input.GetAxis("Horizontal") != 0)
            {
                
                animator.SetBool("IsWalking", true);
            }
            else
            {
                animator.SetBool("IsWalking", false);
            }

            //Debug.Log(forward);
            //Vector3 move = new Vector3(horizontal * horizontalSpeed, gravity, forward * forwardSpeed);

            //controller.Move(move * Time.deltaTime);

            Vector2 input = new Vector2(horizontal, forward);
            Vector2 inputDir = input.normalized;

            if (inputDir != Vector2.zero)
            {
                float targetRotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + cameraT.eulerAngles.y;
                transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnVelocity, turnSpeed);
            }

            float targetSpeed = forwardSpeed * inputDir.magnitude;
            currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedVelocity, speedTime);

            transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);

        }
    }
}
