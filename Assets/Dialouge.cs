﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialouge 
{
    public string name;

    [TextArea(2, 12)]
    public string[] sentences;
}
