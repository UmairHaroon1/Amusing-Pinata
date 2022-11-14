using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void Update()
    {
        if (CanvasManager.isgameover)
        {
            Destroy(gameObject);
        }
    }

    public void Checked()
    {
        Debug.Log("Button is Working");
        GetComponent<BoxCollider2D>().enabled = false;
        if (gameObject.CompareTag("Correct"))
        {
            Score.Instance.score++;
            transform.DOScale(Vector3.zero, 0.2f).OnComplete(() =>
            {
                Destroy(gameObject);
            });
        }
        else if (gameObject.CompareTag("Incorrect"))
        {
            Life.instance.health--;
            transform.DOScale(Vector3.zero, 0.2f).OnComplete(() =>
            {
                Destroy(gameObject);
            });

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("True"))
        {
            Destroy(gameObject);
        }
       
    }
}
