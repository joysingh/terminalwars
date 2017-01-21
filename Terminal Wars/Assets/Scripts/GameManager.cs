using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public GameObject[] terminal;
	public string _currentdirectory;
	public int _currentline;
	// Use this for initialization
	void Start () 
	{
		terminal[0].GetComponent<Text>().text = "Welcome to Terminaltor!";
		terminal[1].GetComponent<Text>().text = "Your mission should you choose to accept it is...";
		terminal[2].GetComponent<Text>().text = "Fuck around to the MAX!";
		terminal[3].GetComponent<Text>().text = "Ousmanes-MacBook-Pro:terminalwars QuanticSymphonia$";
		_currentline = 3;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.Return))
		{
			int _nextline = _currentline + 1;
			terminal[_nextline].GetComponent<Text> ().text = "Ousmanes-MacBook-Pro:terminalwars QuanticSymphonia$";
			_currentline += 1;
		}
		if (Input.GetKeyUp (KeyCode.Backspace)) 
		{
			string newString = (terminal [_currentline].GetComponent<Text> ().text).Substring (0, terminal [_currentline].GetComponent<Text> ().text.Length - 2);
			terminal [_currentline].GetComponent<Text> ().text = newString;
	 
			Debug.Log (terminal [_currentline].GetComponent<Text> ().text.Length);
		}

		if (Input.inputString != "") 
		{
			terminal[_currentline].GetComponent<Text>().text += Input.inputString;
		}
			
	}

	// Creates a brand new file System For The Game!
	void initializeGame()
	{

	}

	//
	void input() 
	{

	}
}
