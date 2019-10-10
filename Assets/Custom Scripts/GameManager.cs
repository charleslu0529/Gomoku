using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public Transform BoardTransform;
	public Transform Canvas;
	public GameObject VerticalLine;
	public GameObject HorizontalLine;
	public GameObject CircleDot;
	public GameObject SideText;
	float gridInterval = 0.527210884f;
	float xPos;
	float yPos;
	int turn = 1;
	bool isEndGame = false;
	bool showingText = false;
	int playerWon;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}else if(instance != this)
		{
			Destroy(gameObject);
		}
	}
	
	// Use this for initialization
	void Start () {

		xPos = gridInterval * (-9);
		yPos = gridInterval * 9;

		for(int j=0;j<19;j++)
		{
			Instantiate(VerticalLine, new Vector3(xPos, 0, BoardTransform.position.z),Quaternion.identity, BoardTransform);
			Instantiate(HorizontalLine, new Vector3(0, yPos, BoardTransform.position.z),Quaternion.identity, BoardTransform);
			xPos += gridInterval;
			yPos -= gridInterval;
		}

		xPos = -6 * gridInterval;
		yPos = 6 * gridInterval;

		for(int i=0;i<3;i++)
		{
			for(int j=0;j<3;j++)
			{
				Instantiate(CircleDot, new Vector3(xPos, yPos, BoardTransform.position.z - 1), Quaternion.identity, BoardTransform);
				xPos += gridInterval * 6;
			}

			xPos = -6 * gridInterval;
			yPos -= 6 * gridInterval;
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(isEndGame)
		{
			if(!showingText)
			{
				SideText.GetComponent<Text>().text = "Game Over\nPlayer " + playerWon + " Wins!";
				Instantiate(SideText, new Vector3(Canvas.position.x, Canvas.position.y, Canvas.position.z-5), Quaternion.identity,Canvas);
				showingText = true;
			}
		}
	}

	public void endTurn()
	{
		turn = turn+1;
	}

	public bool playerPiece()
	{
		if(turn%2 == 0)
		{
			return true;
			}else
			{
				return false;
			}
	}

	public int getTurn()
	{
		return turn;
	}

	public bool getIsEndGame()
	{
		return isEndGame;
	}

	public void endGame(int player)
	{
		isEndGame = true;
		playerWon = player;
	}
}
