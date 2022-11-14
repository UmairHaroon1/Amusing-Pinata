using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingScreen : MonoBehaviour
{
 
    public List<GameObject> Language;
    public List<Sprite> Buttons;
    public Image SoundSprite;
    public Image languageSprites;
    public Image VibrationSprites;
   
    private void OnEnable()
    {
        SoundSprite.sprite = Buttons[PlayerPrefs.GetInt("Sound", 1)];
        VibrationSprites.sprite = Buttons[PlayerPrefs.GetInt("Vibration", 1)];
        Language.ForEach(x => x.SetActive(false));
        Language[PlayerPrefs.GetInt("Language", 1)].SetActive(true);
    }

    public void ToggleSoound()
    {
  
        int status = PlayerPrefs.GetInt("Sound",1);

        if (status == 1)
        {
            status = 0;
        }
        else
        {
            status = 1;
           
        }
        SoundSprite.sprite = Buttons[status];

        PlayerPrefs.SetInt("Sound",status);
        SoundManager.Instance.MuteSound();
       
    }
    public void ToggleLanguage(int a)
    {
        if (a == 1)
        {
            a = 1;
            

           Language[0].SetActive(false);
            Language[1].SetActive(true);
          

        }
        else
        {

            a = 0;
           Language[1].SetActive(false);
            Language[0].SetActive(true);
           
        }

        PlayerPrefs.SetInt("Language", a);
        ChangeLanguage.Instance.changelanguage();
    }
    public void ToggleVibration()
    {

        int status = PlayerPrefs.GetInt("Vibration", 1);

        if (status == 1)
        {
            status = 0;

          
        }
        else
        {
            status = 1;
           

        }
        VibrationSprites.sprite = Buttons[status];

        PlayerPrefs.SetInt("Vibration", status);
    }

}
