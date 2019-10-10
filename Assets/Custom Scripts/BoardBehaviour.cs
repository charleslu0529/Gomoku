using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardBehaviour : MonoBehaviour {

	public GameObject buttons;

	float xPos = -4.730092f;
	float yPos = 4.730092f;
	// Use this for initialization
	void Start () {
		for (int i=0;i<19;i++)
		{
			for(int j=0;j<19;j++)
			{
				Instantiate(buttons, new Vector3(xPos, yPos, transform.position.z - 2), Quaternion.identity,transform);
				xPos = xPos + 0.5255657f;
			}

			xPos = -4.730092f;
			yPos = yPos - 0.5255657f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
