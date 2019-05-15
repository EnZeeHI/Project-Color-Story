using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialBorder1 : MonoBehaviour
{
    public Text tutorialText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        tutorialText.text = "You can also sprint with Shift key, and pause the game with the Escape key";
    }
}
