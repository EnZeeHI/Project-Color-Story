using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureCaptureScript : MonoBehaviour
{
    public int resWidth = 1920;
    public int resHeight = 1080;
    private bool takeScreenShot;
    public bool ableToCapture = false;

    public static string ScreenShotName(int width, int height)
    {
        return string.Format("{0}/Pictures/Picture_{1}x{2}_{3}.png",
                            Application.dataPath, 
                            width, height,
                            System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")
        );
    }
    public void TakeScreenShot()
    {
        takeScreenShot = true;
    }
    void Update()
    {
        takeScreenShot |= Input.GetKeyDown("e");
        if (takeScreenShot && ableToCapture)
        {
            RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
            GetComponent<Camera>().targetTexture = rt;
            Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            GetComponent<Camera>().Render();
            RenderTexture.active = rt;
            screenShot.ReadPixels(new Rect(0,0, resWidth, resHeight),0,0);
            GetComponent<Camera>().targetTexture = null;
            RenderTexture.active = null;
            Destroy (rt);
            byte[] bytes = screenShot.EncodeToPNG();
            string filename = ScreenShotName(resWidth, resHeight);
            System.IO.File.WriteAllBytes(filename, bytes);
            Debug.Log(string.Format("Took screenshot to: {0}", filename));
            takeScreenShot = false;
        }
    }
}
