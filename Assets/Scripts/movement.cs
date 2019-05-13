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
    public float sprintSpeedTime = 0.9f;
    float speedVelocity;
    public Animator animator;
    public AudioSource insideFootsteps;
    public AudioSource outsideFootsteps;

    public bool playAudio;
    public bool isPlaying;
    public bool sprintEnabled = false;


    Transform cameraT;

    public GameObject UI;
    public GameObject UI2;
    public GameObject pauseMenu;

    public int pauseMenuActive = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        cameraT = Camera.main.transform;
        animator = transform.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.activeInHierarchy == false && pauseMenuActive == 0)
        {
            Cursor.visible = false;
            float forward = Input.GetAxis("Vertical"), horizontal = Input.GetAxis("Horizontal");
            if (Input.GetAxis("Vertical") !=0 ||Input.GetAxis("Horizontal") != 0)
            {
                
                animator.SetBool("IsWalking", true);
                playAudio = true;
                 if (gameObject.transform.position.y >0 )
                {  
                    if (playAudio && isPlaying == false)
                    {
                        outsideFootsteps.Play(0);
                        
                        Debug.Log("oustide");
                        isPlaying = true;
                        
                    }
                   
                }
                else
                {
                     if (playAudio  && isPlaying == false)
                    {
                       insideFootsteps.Play(0);
                        Debug.Log("inside");
                        isPlaying = true;
                        
                    }
                    sprintEnabled = false;
                }
                

            }
            else
            {
                playAudio = false;
                animator.SetBool("IsWalking", false);
                insideFootsteps.Stop();
                outsideFootsteps.Stop();
                Debug.Log("isnt walking");
                isPlaying = false;
                
                //outsideFootsteps.Stop();
                //insideFootsteps.Stop();
            }
            if (gameObject.transform.position.y > 0)
            {
                sprintEnabled = true;
            }
            else
            {
                sprintEnabled = false;
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
            if (Input.GetKey("left shift") )
            {if (sprintEnabled)
                {
                    currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed *1.3f , ref speedVelocity, speedTime);
                    animator.speed = 1.3f;
                    //Debug.Log("sprint enabled");
                }
                else
                {
                    currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedVelocity, speedTime);
                    //Debug.Log("sprint disabled");
                    animator.speed = 1;
                }
            }
            else
            {
                currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedVelocity, speedTime);
                animator.speed = 1;
            }
            

            transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);
            //Debug.Log(currentSpeed);

            

        }
       
        else
            {
                Cursor.visible = true;
                playAudio = false;
                animator.SetBool("IsWalking", false);
                insideFootsteps.Stop();
                outsideFootsteps.Stop();
                Debug.Log("isnt walking");
                isPlaying = false;
                
                //outsideFootsteps.Stop();
                //insideFootsteps.Stop();
            }

        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("YEET");
            if (pauseMenuActive == 0)
            {
                pauseMenu.SetActive(true);
                pauseMenuActive = 1;
            }
            else
            {
                pauseMenu.SetActive(false);
                pauseMenuActive = 0;
            }
        }
    }
}
