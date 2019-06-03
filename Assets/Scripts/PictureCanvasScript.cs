using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PictureCanvasScript : MonoBehaviour
{  
    
    string gameFilesPath;
    string PicturesPath;
    string[] Pictures = null ;
    int PicturesIndex =0;


    public GameObject Canvas;
    
    

    void Start()
    {
        gameFilesPath = Application.dataPath;
        PicturesPath = gameFilesPath + "/Pictures";
        //Debug.Log(PicturesPath);
        FindPictures(); 
       DisplayPictures();
    }

    // Update is called once per frame
    void Update()
    {
       
      
      
    }
    void FindPictures()
    {
        Pictures = Directory.GetFiles(Application.dataPath + "/Pictures","*.png");
    }
    void DisplayPictures()
    {   

       string pathToFile = Pictures[PicturesIndex];
       Texture2D texture = GetScreenshotImage (pathToFile);
       Sprite sp = Sprite.Create(texture, new Rect( 0, 0, texture.width, texture.height), new Vector2(0.5f,0.5f));
       Canvas.GetComponent<Image>().sprite = sp;
       
    }
    Texture2D GetScreenshotImage(string filePath)
    {
        Texture2D texture = null;
        byte[] fileBytes;
        if (File.Exists(filePath))
        {
            fileBytes = File.ReadAllBytes(filePath);
            texture = new Texture2D(2,2,TextureFormat.RGB24, false);
            texture.LoadImage(fileBytes);
        }
        return texture;
    }
    public void NextPicture()
    {
        if(Pictures.Length >0)
        {
            PicturesIndex += 1;
            if(PicturesIndex > Pictures.Length -1)
            {
                PicturesIndex = 0;
            }
            DisplayPictures();
        }
    }
    public void PreviousPicture()
    {
        if(Pictures.Length >0)
        {
            PicturesIndex -=1;
            if(PicturesIndex <0)
            {
                PicturesIndex = Pictures.Length-1;
            }
            DisplayPictures();
        }
        
    }
}
