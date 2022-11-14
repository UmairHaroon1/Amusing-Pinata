using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class PlayerScript : MonoBehaviour {


	public float forcetoAdd=100;

	public int _tapcounter;
	public int random;
	public List<Sprite> Pinata;
	public int tapcounter
	{
		get
		{
			return _tapcounter;
		}
		set
		{
			_tapcounter = value;
			if (_tapcounter > random)
			{
				_tapcounter = 0;
				random = Random.Range(20, 35);
				SpawningItems.Instance.StartSpawn();

			}
		}
	}

	private void OnEnable()
	{
		GetComponent<SpriteRenderer>().sprite = Pinata[Session.Instance.ChoosenPinata];
		random = Random.Range(25, 36);

	}

	public void OnClick()
	{
		SoundManager.Instance.BtnClick(SoundManager.Instance.Punch);

		tapcounter++;

		int a = Random.Range(0, 2);
		if (a == 0)
		{
			
			GetComponent<Rigidbody2D> ().AddForce(-Vector2.right*forcetoAdd);
		}

		else
		{
			GetComponent<Rigidbody2D> ().AddForce(Vector2.right*forcetoAdd);
			
		}
	}
	void Start () {
		//gives it force
	//	GetComponent<Rigidbody2D> ().velocity = Vector2.up * 10;

	}


	void Update () {

		
	}			
}
