using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(ButtonBehaviour.notInButton)
		{
			Destroy(gameObject);
		}
	}


}
