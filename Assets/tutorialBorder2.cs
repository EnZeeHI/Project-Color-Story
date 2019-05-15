using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialBorder2 : MonoBehaviour
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
        tutorialText.text = "You can interact with things that have a marker above their head using the E key";
    }
}
