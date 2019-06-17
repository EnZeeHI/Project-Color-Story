using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class gameObjective : EventTrigger
{
    public Text gameObj;
    public string hint;
    Scene currentScene;
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (sceneName == "Tutorial")
        {
            hint = "Go to the end";
        }
        else if (sceneName == "day2")
        {
            hint = "Hang picture on the wall, go to bed";
        }
        else if (sceneName == "Exhibition")
        {
            hint = "Explore exhibition with Ellie";
        }
        else if (sceneName == "School")
        {
            hint = "Go to class";
        }
        else if (sceneName == "SchoolAfterClass")
        {
            hint = "Talk to Ellie and go home";
        }
        else if (sceneName == "day2Morning")
        {
            hint = "Go to the exhibition in the car";
        }
        else if (sceneName == "SampleScene")
        {
            hint = "Talk to dad and go to bed";
        }
        Debug.Log(sceneName);
        Debug.Log(hint);
    }

    public override void OnPointerEnter(PointerEventData eventdata)
    {
        gameObj.text = hint;
    }

    public override void OnPointerExit(PointerEventData eventdata)
    {
        gameObj.text = "Hint:";
    }
}
