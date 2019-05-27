using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public Dialouge dialouge;

    public float convTypeThis;

    public void TriggerDialouge ()
    {
        FindObjectOfType<DialougeManager>().StartDialouge(dialouge);
        FindObjectOfType<DialougeManager>().convType = convTypeThis;
    }
}
