using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singletion<SoundManager>
{
    public AudioSource AllScreen;
    public AudioSource Source;
    public AudioClip btnClip;
    public AudioClip Punch;
    public AudioClip Explode;
    public void BtnClick(AudioClip c)
    {
        Source.PlayOneShot(c);



    }
   
    private void OnEnable()
    {
        MuteSound();
    }

    public void MuteSound()
    {
        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            AllScreen.mute = false;
            Source.mute = false;
        }
        else
        {
            AllScreen.mute = true;
            Source.mute = true;
        }
    }
}
