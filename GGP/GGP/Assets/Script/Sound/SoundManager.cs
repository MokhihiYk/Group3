using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AKSoundVolume : MonoBehaviour
{
    public Slider ThisSlider;
    public float MasterVolume, MusicVolume, SfxVolume;
    public string RtpcName = "MasterVolume";
    public float RtpcValue;
    int type;

    void Start() {

        AKRESULT result= AkSoundEngine.GetRIPCValue(RtpcName, gameObject, 0, out RtpcValue, ref type);
        ThisSlider.value = RtpcValue;
    }

    public void SetVolume(string WhatValue) {
        RtpcValue = ThisSlider.value;

        if (WhatValue == "Master") {
            MasterVolume = ThisSlider.value;
            AkSoundEngine.SetRTPCValue("MasterVolume", MasterVolume);
        
        }
        if (WhatValue == "Music")
        {
            MasterVolume = ThisSlider.value;
            AkSoundEngine.SetRTPCValue("MusicVolume", MusicVolume);

        }
        if (WhatValue == "SFX")
        {
            MasterVolume = ThisSlider.value;
            AkSoundEngine.SetRTPCValue("MasterVolume", SfxVolume);

        }


    }


    
}
