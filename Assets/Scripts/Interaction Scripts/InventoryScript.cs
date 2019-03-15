using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript 
{
    public static string inventoryObject1, inventoryObject2;
    public static string InventoryObject1
    {
        get
        {
            return inventoryObject1;
        }
        set
        {
            inventoryObject1 = value;
        }
    }
    public static string InventoryObject2
    {
         get
        {
            return inventoryObject2;
        }
        set
        {
            inventoryObject2 = value;
        }
    }
}

