using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialouge 
{
    public string name;
    public string convName;

    [TextArea(2, 12)]
    public string[] sentences;

    [TextArea(2,6)]
    public string[] choices;

}
