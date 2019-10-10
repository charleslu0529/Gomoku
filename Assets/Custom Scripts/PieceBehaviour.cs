using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceBehaviour : MonoBehaviour {


	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D[] hitUpP1 = Physics2D.RaycastAll(transform.position, new Vector3(0,0.527210884f,0), 5, 1 << 8);
		RaycastHit2D[] hitRightP1 = Physics2D.RaycastAll(transform.position, new Vector3(0.527210884f,0,0), 5, 1 << 8);
		RaycastHit2D[] hitDownP1 = Physics2D.RaycastAll(transform.position, new Vector3(0,-0.527210884f,0), 5, 1 << 8);
		RaycastHit2D[] hitLeftP1 = Physics2D.RaycastAll(transform.position, new Vector3(-0.527210884f,0,0), 5, 1 << 8);
		RaycastHit2D[] hitRightUpP1 = Physics2D.RaycastAll(transform.position, new Vector3(0.527210884f,0.527210884f,0), 5, 1 << 8);
		RaycastHit2D[] hitLeftUpP1 = Physics2D.RaycastAll(transform.position, new Vector3(-0.527210884f,0.527210884f,0), 5, 1 << 8);

		RaycastHit2D[] hitUpP2 = Physics2D.RaycastAll(transform.position, new Vector3(0,0.527210884f,0), 5, 1 << 9);
		RaycastHit2D[] hitRightP2 = Physics2D.RaycastAll(transform.position, new Vector3(0.527210884f,0,0), 5, 1 << 9);
		RaycastHit2D[] hitDownP2 = Physics2D.RaycastAll(transform.position, new Vector3(0,-0.527210884f,0), 5, 1 << 9);
		RaycastHit2D[] hitLeftP2 = Physics2D.RaycastAll(transform.position, new Vector3(-0.527210884f,0,0), 5, 1 << 9);
		RaycastHit2D[] hitRightUpP2 = Physics2D.RaycastAll(transform.position, new Vector3(0.527210884f,0.527210884f,0), 5, 1 << 9);
		RaycastHit2D[] hitLeftUpP2 = Physics2D.RaycastAll(transform.position, new Vector3(-0.527210884f,0.527210884f,0), 5, 1 << 9);

		if(hitUpP1.Length == 5 || hitRightP1.Length == 5 || hitDownP1.Length == 5 || hitLeftP1.Length == 5 || hitRightUpP1.Length == 5 || hitLeftUpP1.Length == 5)
		{
			GameManager.instance.endGame(1);
		}else if(hitUpP2.Length == 5 || hitRightP2.Length == 5 || hitDownP2.Length == 5 || hitLeftP2.Length == 5 || hitRightUpP2.Length == 5 || hitLeftUpP2.Length == 5)
		{
			GameManager.instance.endGame(2);
		}
	}
}
