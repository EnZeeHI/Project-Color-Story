using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PictureCanvasScript : MonoBehaviour
{  
    PlayerInfo PlayerInfo;
    
    string gameFilesPath;
    string PicturesPath;
    string[] Pictures = null ;
    int PicturesIndex =0;


    public GameObject Canvas;

    // picture spaces

    public GameObject picture1;
    public GameObject picture2;
    public GameObject picture3;
    public GameObject picture4;
    public GameObject picture5;
    public GameObject picture6;
    public GameObject displayedImage;
    
    

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
       Resources.Load("");
       FindPictures();
      
      
    }
    void FindPictures()
    {
        Pictures = Directory.GetFiles(Application.dataPath + "/Resources/Pictures","*.png");
    }
    void DisplayPictures()
    {   

       string pathToFile = Pictures[PicturesIndex];
       Texture2D texture = GetScreenshotImage (pathToFile);
       Sprite sp = Sprite.Create(texture, new Rect( 0, 0, texture.width, texture.height), new Vector2(0.5f,0.5f));
       displayedImage.GetComponent<Image>().sprite = sp;
       
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
    public void ExitScreen()
    {
        Canvas.SetActive(false);
    }
    public void ConfirmSelection()
    {
        string filePath = Pictures[PicturesIndex];
        if(PlayerInfo.PlayerPhoto1 == null)
        {
           PlayerInfo.PlayerPhoto1 = filePath;

        }
        else if (PlayerInfo.PlayerPhoto2 == null)
        {
            PlayerInfo.PlayerPhoto2 = filePath;
        }
        else if (PlayerInfo.PlayerPhoto3 == null)
        {
            PlayerInfo.PlayerPhoto3 = filePath;
        }
        else if (PlayerInfo.PlayerPhoto4 == null)
        {
            PlayerInfo.PlayerPhoto4 = filePath;
        }
        else if (PlayerInfo.PlayerPhoto5 == null)
        {
            PlayerInfo.PlayerPhoto5 = filePath;
        }
        else if (PlayerInfo.PlayerPhoto6 == null)
        {
            PlayerInfo.PlayerPhoto6 = filePath;
        }
        PlacePhoto();
        Debug.Log("PlacePhoto");
    }
    
    public void PlacePhoto()
    {   if (PlayerInfo.PlayerPhoto1 !=null)
        {
            string pathToFile1 = PlayerInfo.PlayerPhoto1;
            Debug.Log(pathToFile1);
            Texture2D texture1 = GetScreenshotImage (pathToFile1);
            Sprite sp1 = Sprite.Create(texture1, new Rect( 0, 0, texture1.width, texture1.height), new Vector2(0.5f,0.5f));
            picture1.GetComponent<SpriteRenderer>().sprite = sp1;
        }
        if (PlayerInfo.PlayerPhoto2 !=null)
        {
            string pathToFile2 = PlayerInfo.PlayerPhoto2;
            Debug.Log(pathToFile2);
            Texture2D texture2 = GetScreenshotImage (pathToFile2);
            Sprite sp2 = Sprite.Create(texture2, new Rect( 0, 0, texture2.width, texture2.height), new Vector2(0.5f,0.5f));
            picture2.GetComponent<SpriteRenderer>().sprite = sp2;
        }
        if (PlayerInfo.PlayerPhoto3 !=null)
        {
            string pathToFile3 = PlayerInfo.PlayerPhoto3;
            Debug.Log(pathToFile3);
            Texture2D texture3 = GetScreenshotImage (pathToFile3);
            Sprite sp3 = Sprite.Create(texture3, new Rect( 0, 0, texture3.width, texture3.height), new Vector2(0.5f,0.5f));
            picture3.GetComponent<SpriteRenderer>().sprite = sp3;
        }
        if (PlayerInfo.PlayerPhoto4 !=null)
        {
            string pathToFile4 = PlayerInfo.PlayerPhoto4;
            Debug.Log(pathToFile4);
            Texture2D texture4 = GetScreenshotImage (pathToFile4);
            Sprite sp4 = Sprite.Create(texture4, new Rect( 0, 0, texture4.width, texture4.height), new Vector2(0.5f,0.5f));
            picture4.GetComponent<SpriteRenderer>().sprite = sp4;
        }
        if (PlayerInfo.PlayerPhoto5 !=null)
        {
            string pathToFile5 = PlayerInfo.PlayerPhoto5;
            Debug.Log(pathToFile5);
            Texture2D texture5 = GetScreenshotImage (pathToFile5);
            Sprite sp5 = Sprite.Create(texture5, new Rect( 0, 0, texture5.width, texture5.height), new Vector2(0.5f,0.5f));
            picture5.GetComponent<SpriteRenderer>().sprite = sp5;
        }
         if (PlayerInfo.PlayerPhoto6 !=null)
        {
            string pathToFile6 = PlayerInfo.PlayerPhoto1;
            Debug.Log(pathToFile6);
            Texture2D texture6 = GetScreenshotImage (pathToFile6);
            Sprite sp6 = Sprite.Create(texture6, new Rect( 0, 0, texture6.width, texture6.height), new Vector2(0.5f,0.5f));
            picture6.GetComponent<SpriteRenderer>().sprite = sp6;
        }
        
    }
       
}

