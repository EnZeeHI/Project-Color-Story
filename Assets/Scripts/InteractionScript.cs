using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{


    public GameObject InteractionPrompt;
    private GameObject InteractionPromptObject;
    public Vector3 offset = new Vector3(0,1,0);
    private bool isCreated;
    public bool InteractionPromptActive;
    public
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
           

            
            if (hit.collider.tag == "QuestObject"  )
            {
                
                if ( hit.transform.childCount <1)
                {   
                   
                    
                    InteractionPromptObject = Instantiate(InteractionPrompt, hit.collider.transform.position+ offset, hit.collider.transform.rotation );
                    InteractionPromptObject.transform.parent = hit.transform;
                    isCreated = true;
                    
                    
                }
               
               if(hit.transform.childCount ==1)
               {
                  InteractionPromptObject =  hit.transform.Find("InteractionPrompt(Clone)").gameObject;
               }
                InteractionPromptObject.SetActive(true);
                InteractionPromptActive = true;
                Debug.Log("active");

            }
            else
            {
               InteractionPromptObject.SetActive(false);
               InteractionPromptActive = false;
               Debug.Log("disabled but active"); 
            }

            if (InteractionPromptActive)
        {
            if (Input.GetKeyDown("e"))
            Destroy(hit.transform.gameObject);
        }
        }
        else
        {   
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            InteractionPromptObject.SetActive(false);
            InteractionPromptActive = false;
            Debug.Log("disabled");
        }

        
        
    }
    
}
