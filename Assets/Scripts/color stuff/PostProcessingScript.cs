using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingScript : MonoBehaviour
{
    PostProcessVolume p_Volume;
    ColorGrading p_colorGrading;
    public float hueShiftValue;
    public float saturationValue;
    public bool isThePersonHappy;

    GameObject questPerson;

    void Start()
    {
        p_colorGrading  = ScriptableObject.CreateInstance<ColorGrading>();
        p_colorGrading.enabled.Override(true);
        p_colorGrading.hueShift.Override(hueShiftValue);
        p_colorGrading.saturation.Override(saturationValue);
        p_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, p_colorGrading);
        questPerson = GameObject.Find("QuestPerson");
    }
    void Update()
    {   
       p_colorGrading.saturation.Override(saturationValue);
       
    }
    public void SaturationChange(float value)
    {
        if (value > 0)
        {
            if (saturationValue <= value)
            {
                saturationValue = saturationValue+1;
                //Debug.Log(saturationValue);
            }
        }
        if (value<0)
        {
            if (saturationValue >=value)
            {
                saturationValue = saturationValue-1;
            }
                
        }
            
        
    }
    
}


