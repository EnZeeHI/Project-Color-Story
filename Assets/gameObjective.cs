using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class gameObjective : EventTrigger
{
    public Text gameObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnPointerEnter(PointerEventData eventdata)
    {
        gameObj.text = "go fuck yourself";
    }

    public override void OnPointerExit(PointerEventData eventdata)
    {
        gameObj.text = "Hint:";
    }
}
