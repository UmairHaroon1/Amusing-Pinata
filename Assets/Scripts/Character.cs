using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public List<Image>characters;
    public List<Sprite> BG;

    private void OnEnable()
    {
        for (int i = 0; i < characters.Count; i++)
        {
            characters[i].sprite = BG[0];
        }
        characters[Session.Instance.ChoosenPinata].sprite = BG[1];
    }

    // Start is called before the first frame update
    public void ChangeImage(int A)
    {
        SoundManager.Instance.BtnClick(SoundManager.Instance.btnClip);
        for (int i = 0; i < characters.Count; i++)
        {
            characters[i].sprite = BG[0];
        }
        characters[A].sprite = BG[1];
        Session.Instance.ChoosenPinata = A;
    }
        
}
