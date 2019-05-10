using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToNextScene : MonoBehaviour
{
    public float countdown;
    // Start is called before the first frame update
    void Start()
    {
        countdown = Time.time + 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <= Time.time)
        {
            SceneManager.LoadScene("Main menu");
        }
    }
}
