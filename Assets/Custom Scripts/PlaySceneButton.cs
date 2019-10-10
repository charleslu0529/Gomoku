using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaySceneButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TaskOnClick()
    {
    	SceneManager.LoadScene("Play Scene");
    }
}
