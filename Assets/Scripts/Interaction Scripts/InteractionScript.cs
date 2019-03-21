﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    // Defining prefabs and Object this script is going to create, adding an offset for prompts adding boolean values for future use
    public GameObject InteractionObjectPrompt;
    private GameObject InteractionObjectPromptObject;
    public Vector3 offset = new Vector3(0,1,0);
    private bool isCreated;
    public bool InteractionObjectPromptActive;
    public GameObject QuestItemPromptPrefab;
    private GameObject QuestItemPromptObject;
    public GameObject QuestPersonPromptPrefab;
    private GameObject QuestPersonPromptObject;
    public bool QuestItemPromptObjectActive;
    public bool QuestPersonPromptObjectActive;
    public bool activateItem;
    public Camera camera;

    //hello aras this is my fucking about with the text
    public GameObject UI;


    //public InventoryScript InventoryScript;
    private string activeItem;
    // Start is called before the first frame update
    void Start()
    {
        // temporarilly assigning the objects to get rid of the "unassigned reference" error
        InteractionObjectPromptObject = InteractionObjectPrompt;
        QuestItemPromptObject = QuestItemPromptPrefab;
        QuestPersonPromptObject = QuestPersonPromptPrefab;
        //activeItem = null;
    }

    // Update is called once per frame
    void Update()
    {
         RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, camera.transform.TransformDirection(Vector3.forward), out hit, 3))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        // checking if the raycast is detecting the Quest Object, Instantiating a prompt once, and seting it active/unactive based on if the player aims at the object or not 
            if (hit.collider.tag == "QuestObject"  )
            {
                
                if ( hit.transform.childCount <1)
                {   
                    InteractionObjectPromptObject = Instantiate(InteractionObjectPrompt, hit.collider.transform.position+ offset, hit.collider.transform.rotation );
                    InteractionObjectPromptObject.transform.parent = hit.transform;
                    isCreated = true;                    
                }
               
               if(hit.transform.childCount ==1)
               {
                  InteractionObjectPromptObject =  hit.transform.Find("InteractionObjectPrompt(Clone)").gameObject;
               }
                InteractionObjectPromptObject.SetActive(true);
                InteractionObjectPromptActive = true;
               // Debug.Log("active")
            }
            else
            {
            // making sure that the prompt disapears if the raycast hits something else than the required object
               InteractionObjectPromptObject.SetActive(false);
               InteractionObjectPromptActive = false;
              // Debug.Log("Not InteractionObject"); 
            }
            
            
            // checking if the raycast detects a quest item, istantiating the prompt and toggling the active state of the prompt based on if the player is aiming at it or not
        if (hit.collider.tag=="QuestItem")
        {
            if ( hit.transform.childCount <1)
            {   
                QuestItemPromptObject = Instantiate(QuestItemPromptPrefab, hit.collider.transform.position+ offset, hit.collider.transform.rotation );
                QuestItemPromptObject.transform.parent = hit.transform;
                isCreated = true;              
            }
            if(hit.transform.childCount ==1)
            {
                QuestItemPromptObject =  hit.transform.Find("QuestItemPromptPrefab(Clone)").gameObject;
            }
            QuestItemPromptObject.SetActive(true);
            QuestItemPromptObjectActive = true;
           // Debug.Log("active"); 
        }
        // doing the same check as before
        else
        {
            QuestItemPromptObject.SetActive(false);
            QuestItemPromptObjectActive = false;
           // Debug.Log("Not Quest Item"); 
        }
        // same as before but for a quest person 
        if (hit.collider.tag=="QuestPerson")
        {
            if ( hit.transform.childCount <1)
            {   
                QuestPersonPromptObject = Instantiate(QuestPersonPromptPrefab, hit.collider.transform.position+ offset, hit.collider.transform.rotation );
                QuestPersonPromptObject.transform.parent = hit.transform;
                isCreated = true;              
            }
            if(hit.transform.childCount ==1)
            {
                QuestPersonPromptObject =  hit.transform.Find("QuestPersonPromptPrefab(Clone)").gameObject;
            }
            QuestPersonPromptObject.SetActive(true);
            QuestPersonPromptObjectActive = true;
            //Debug.Log("active")   
        }
        else
        {
            QuestPersonPromptObject.SetActive(false);
            QuestPersonPromptObjectActive = false;
           // Debug.Log("Not Quest Person"); 
        }
        // this the interaction with the object
        if (InteractionObjectPromptActive)
            {
                if (Input.GetButton("Interaction1"))
                hit.transform.gameObject.SetActive(false);
            }
        // this is the interaction with the item
        if (QuestItemPromptObjectActive)
        {
            if (Input.GetButton("Interaction1"))
            {
            activeItem = hit.collider.gameObject.name;
            
            if (InventoryScript.InventoryObject1 == null)
            {
                InventoryScript.InventoryObject1=  activeItem;
            } 
            else
            {
                if (InventoryScript.InventoryObject2 == null)
                {
                InventoryScript.InventoryObject2= activeItem;
                }
            }
            
            Debug.Log("Inventory Slot 1 has :" +InventoryScript.inventoryObject1);
            Debug.Log("Inventory Slot 2 has :" +InventoryScript.inventoryObject2);   
            
            hit.transform.gameObject.SetActive(false);
           
      
            }
        }

        if (QuestPersonPromptObjectActive)
        {   
            if(Input.GetButton("Interaction1"))
            {
                if (hit.transform.GetComponent<ItemCheck>() != null)
                {
                   UseItem(hit.transform.GetComponent<ItemCheck>().ItemToCheck) ;
                }
                    UI.SetActive(true);
                FindObjectOfType<NPC>().TriggerDialouge();
            }
            
           
        }
        
        }
        // disabling every prompt if the raycast doesnt detect anything
        else
        {   
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            InteractionObjectPromptObject.SetActive(false);
            InteractionObjectPromptActive = false;
            QuestItemPromptObject.SetActive(false);
            QuestItemPromptObjectActive = false;
            QuestPersonPromptObject.SetActive(false);
            QuestItemPromptObjectActive = false;
            //Debug.Log("disabled");
        }    

        
    }
    void UseItem(string item)
    {
        if(InventoryScript.InventoryObject1 == item)
        {
            InventoryScript.InventoryObject1 = string.Empty;
            activateItem = true;
            Debug.Log("Pizza Time!!");
        }
        else if (InventoryScript.InventoryObject2 == item)
        {
            InventoryScript.InventoryObject2 = string.Empty;
            activateItem = true;
            Debug.Log("Pizza Time!!");
        }
        else 
        {
            activateItem = false;
            Debug.Log(" no Pizza Time :(");
        }
    }
}
