using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public static Life instance;
    public void Awake()
    {
        instance = this;  
    }
    private int _health;
    public int health
    {
        get
        {
            return _health;


        }
        set
        {
            _health = value;
            foreach (Image img in hearts)
            {
                img.sprite = GreyHearts;
            }
           
            for (int i = 0; i < hearts.Length; i++)
            { if (i < _health)
                { hearts[i].sprite = RedHearts; }
            }
            Debug.Log(health);
            if (health == 0)
            {
                CanvasManager.isgameover = true;
                
                CanvasManager.instance.Scorepanel.Show(true);
                CanvasManager.instance.PlayScreen.SetActive(false);
                CanvasManager.instance.Gameplay.SetActive(false);


            }

        }
    }
    public Image[] hearts;
    public Sprite RedHearts;
    public Sprite GreyHearts;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 3;

    }

    // Update is called once per frame
    void Update()
    {
      
    }

        
       
                
}
