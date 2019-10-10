using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour {

	public GameObject PlayerOnePiece;
	public GameObject PlayerOneHover;
	public GameObject PlayerTwoPiece;
	public GameObject PlayerTwoHover;

	bool clicked = false;
	public static bool notInButton;
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
    	if(!GameManager.instance.getIsEndGame())
    	{
    		if(!clicked)
	        {
	        	if(GameManager.instance.getTurn() == 1)
	        	{
	        		if(transform.position.x < 0.5f && transform.position.y < 0.5f)
	        		{
	        			if(transform.position.x > -0.5f && transform.position.y > -0.5f)
	        			{
	        				if(GameManager.instance.playerPiece())
					        {
					        	Instantiate(PlayerTwoPiece,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }else{
					        	Instantiate(PlayerOnePiece,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }
					        GameManager.instance.endTurn();
		        			clicked = true;
	        			}
	        		}
	        	}else if(GameManager.instance.getTurn() == 2){
	        		if(transform.position.x < 1.1f && transform.position.y < 1.1f)
	        		{
	        			if(transform.position.x > -1.1f && transform.position.y > -1.1f)
	        			{
	        				if(GameManager.instance.playerPiece())
					        {
					        	Instantiate(PlayerTwoPiece,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }else{
					        	Instantiate(PlayerOnePiece,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }
					        GameManager.instance.endTurn();
		        			clicked = true;
	        			}
	        		}
	        	}else if(GameManager.instance.getTurn() == 3){
	        		if(transform.position.x < 1.6f && transform.position.y < 1.6f)
	        		{
	        			if(transform.position.x > -1.6f && transform.position.y > -1.6f)
	        			{
	        				if(GameManager.instance.playerPiece())
					        {
					        	Instantiate(PlayerTwoPiece,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }else{
					        	Instantiate(PlayerOnePiece,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }
					        GameManager.instance.endTurn();
		        			clicked = true;
	        			}
	        		}
	        	}else{
	        		if(GameManager.instance.playerPiece())
			        {
			        	Instantiate(PlayerTwoPiece,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
			        }else{
			        	Instantiate(PlayerOnePiece,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
			        }
			        GameManager.instance.endTurn();
		        	clicked = true;
	        	}
	        }
    	} 
    }

    void OnMouseEnter() {

    	if(!GameManager.instance.getIsEndGame())
    	{
    		if(!clicked)
	        {
	        	notInButton = false;
	        	if(GameManager.instance.getTurn() == 1)
	        	{
	        		if(transform.position.x < 0.5f && transform.position.y < 0.5f)
	        		{
	        			if(transform.position.x > -0.5f && transform.position.y > -0.5f)
	        			{
				        	if(GameManager.instance.playerPiece())
					        {
					        	Instantiate(PlayerTwoHover,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }else{
					        	Instantiate(PlayerOneHover,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }
	        			}
	        		}
	        	}else if(GameManager.instance.getTurn() == 2){
	        		if(transform.position.x < 1.1f && transform.position.y < 1.1f)
	        		{
	        			if(transform.position.x > -1.1f && transform.position.y > -1.1f)
	        			{
				        	if(GameManager.instance.playerPiece())
					        {
					        	Instantiate(PlayerTwoHover,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }else{
					        	Instantiate(PlayerOneHover,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }
	        			}
	        		}
	        	}else if(GameManager.instance.getTurn() == 3){
	        		if(transform.position.x < 1.5f && transform.position.y < 1.5f)
	        		{
	        			if(transform.position.x > -1.5f && transform.position.y > -1.5f)
	        			{
				        	if(GameManager.instance.playerPiece())
					        {
					        	Instantiate(PlayerTwoHover,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }else{
					        	Instantiate(PlayerOneHover,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					        }
	        			}
	        		}
	        	}else{
			        if(GameManager.instance.playerPiece())
				    {
					    Instantiate(PlayerTwoHover,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
					}else{
					   	Instantiate(PlayerOneHover,new Vector3(transform.position.x, transform.position.y, transform.position.z-0.2f),Quaternion.identity);
				    }
	        	}
	        	
	        }
    	}	
    }

    void OnMouseExit(){
    	notInButton = true;
    }
}
