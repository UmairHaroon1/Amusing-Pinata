using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance;
    public TextMeshProUGUI[] _scoretext;

    public static int HighScore;
    public int _score;


    public int score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            foreach (var a in _scoretext)
            {
                a.text = _score.ToString();
            }
            
            if (_score > HighScore)

                HighScore = _score;
                SaveScore();
            //ScorePaneltext = _scoretext;


            Debug.Log("HighScore:" + HighScore);

        }

    }

    public void Awake()
    {
        Instance = this;
    }
    public void SaveScore()
    {
        PlayerPrefs.SetInt("HighScore", HighScore);
        
        Debug.Log("HighScore is Saved");
    }
    public void GetHighScore()
    {
          HighScore=PlayerPrefs.GetInt("HighScore",0);
    }
    private void Start()
    {
        GetHighScore();
    }
}