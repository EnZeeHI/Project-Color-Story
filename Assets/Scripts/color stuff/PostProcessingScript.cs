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
    public PlayerInfo PlayerInfo;
    GameObject questPerson;
    public AudioSource HappySound;
    public AudioSource DepressedSound;
    bool functionCalled = false;
    float happynesCompareValue;

    void Start()
    {
        p_colorGrading  = ScriptableObject.CreateInstance<ColorGrading>();
        p_colorGrading.enabled.Override(true);
        p_colorGrading.hueShift.Override(hueShiftValue);
        p_colorGrading.saturation.Override(saturationValue);
        p_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, p_colorGrading);
        questPerson = GameObject.Find("QuestPerson");
        happynesCompareValue = PlayerInfo.PlayerMood;
    }
    void Update()
    {   
       p_colorGrading.saturation.Override(saturationValue);
       ValueCompare(PlayerInfo.PlayerMood);
       SaturationChange(PlayerInfo.PlayerMood);
     
       
    }
    public void SaturationChange(float value)
    {
        if (value > 0)
        {// happy
            
            
            if (saturationValue <= value)
            {
                saturationValue = saturationValue+1;
                //Debug.Log(saturationValue);
            }
            else if (saturationValue <= value)
            {
                saturationValue = saturationValue-1;
            }
            
            
        }
        else if (value<0)
        {// depressed
           
            
            if (saturationValue >=value)
            {
                saturationValue = saturationValue-1;
            }
            else if (saturationValue <=value)
            {
                  saturationValue = saturationValue+1;
            }
                   
        }
        
        
        
    }

    void PlayAudio(AudioSource sound)
    { bool soundPlayed = false;
        if (!sound.isPlaying && !soundPlayed)
        {   
               sound.Play();
               soundPlayed = true;
        }
       

    }
    void ValueCompare( float value)
    {   if (!functionCalled &&happynesCompareValue > value)
        {
            PlayAudio(DepressedSound);
            functionCalled = true;
            
        }    
        else if (!functionCalled && happynesCompareValue < value)
        {
            PlayAudio(HappySound);
            functionCalled = true;
            
        }
        if (value != happynesCompareValue)
        {
            functionCalled = false;
            happynesCompareValue = value;
        }
        
    }
}


