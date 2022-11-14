using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class throwhook : MonoBehaviour {


	public GameObject hook;
	public Transform T;
	GameObject curHook;

	private void OnEnable()
	{
		Set();
	}

	void Set ()
	{

				curHook = (GameObject)Instantiate (hook, transform.position, Quaternion.identity);

				curHook.GetComponent<RopeScript> ().destiny = T.position;


				
			
				
	}
}
