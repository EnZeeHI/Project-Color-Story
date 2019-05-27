using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialouge 
{
    public string name;
    public string convName;

    [TextArea(2, 12)]
    public string reaction;

    [TextArea(2, 12)]
    public string[] sentences;

    [TextArea(2,6)]
    public string[] choices;

    public Image face;

}
