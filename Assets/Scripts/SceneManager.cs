using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject Scorepanel;
    public GameObject MainMenu;
    public GameObject Settingpanel;
    public GameObject PinataPanel;
    public GameObject PlayScreen;
    public void Start()
    {   SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        PinataPanel.Hide();
        Settingpanel.Hide();
        PlayScreen.Hide();
        MainMenu.Show(true);
        Scorepanel.Hide();
    }
    public void settingpanel()
    {

       SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        PinataPanel.Hide();
        Settingpanel.Show(true);
        PlayScreen.Hide();
        MainMenu.Hide();
        Scorepanel.Hide();
    }
    public void pinataScreen()
    {

        SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        PinataPanel.Show(true);
        Settingpanel.Hide();
        PlayScreen.Hide();
        MainMenu.Hide();
        Scorepanel.Hide();
    }
    public void StartBTnClicked()
    {

      
        SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        PlayScreen.Show(true);
        PinataPanel.Hide();
        Settingpanel.Hide();
        MainMenu.Hide();
        Scorepanel.Hide();

    }
    public void BackBTnClicked()
    {

        SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        PinataPanel.Hide();
        Settingpanel.Hide();
        PlayScreen.Hide();
        MainMenu.Show(true);
        Scorepanel.Hide();
    }

    
}

