using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    
  

    // Update is called once per frame
   public void LoadScene(string scene)
   {
     SceneManager.LoadScene(scene);
   }
}
