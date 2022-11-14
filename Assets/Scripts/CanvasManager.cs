using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager instance;
    public GameObject Scorepanel;
    public GameObject MainMenu;
    public GameObject Settingpanel;
    public GameObject PinataPanel;
    public GameObject PlayScreen;
    public static bool isgameover;

    public GameObject Gameplay;
    // Start is called before the first frame update
    void OnClickPlay()
    {
        SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        PlayScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reload()
    {
        SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        isgameover = false;
        Fade.Instance.LoadScene("Game");
    }
    public void ScorePanel()
    {
      
        SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        PinataPanel.Hide();
        Settingpanel.Hide();
        PlayScreen.Hide();
        MainMenu.Hide();
        Scorepanel.Show(true);
    }
    public void BackonMainMenu()
    {

        SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        PinataPanel.Hide();
        Settingpanel.Hide();
        PlayScreen.Hide();
        MainMenu.Show(true);
        Scorepanel.Hide();
    }
    //public void SceneChanger()
    //{
    //    UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    //}

    public void Awake()
    {
        instance = this;
    }
   
}
