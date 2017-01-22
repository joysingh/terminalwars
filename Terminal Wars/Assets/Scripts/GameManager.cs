using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public GameObject[] terminal;
	public string _currentdirectory;
	public Folder _currentfolder;
	public int _currentline;
	protected string cmd_str;
	// Use this for initialization
	void Start () 
	{
		_currentline = 3;
		_currentdirectory = "virtual-enviornoment:Home Guest";
		_currentfolder = new Folder ("Home");

		terminal[0].GetComponent<Text>().text = "Welcome to Terminaltor!";
		terminal[1].GetComponent<Text>().text = "Your mission should you choose to accept it is...";
		terminal[2].GetComponent<Text>().text = "Fuck around to the MAX!";
		terminal[3].GetComponent<Text>().text = _currentdirectory + " ";


	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Return)) {

			if (cmd_str.StartsWith("ls")) {
				string[] il = _currentfolder.getItemList ();
				Debug.Log (il);
				foreach (string si in il) {
					terminal [_currentline + 1].GetComponent<Text> ().text = si;
					_currentline += 1;
				}
				terminal [_currentline + 1].GetComponent<Text> ().text = _currentdirectory + " ";
				_currentline += 1;
				cmd_str = "";

			} else if (cmd_str.StartsWith ("touch")) {
				TextFile tf = new TextFile (cmd_str.Substring(5));
				_currentfolder.addItem (tf);

				terminal [_currentline + 1].GetComponent<Text> ().text = _currentdirectory + " ";
				_currentline += 1;
				cmd_str = "";

			} else if (cmd_str.StartsWith ("mkdir")) {
				Folder tf = new Folder (cmd_str.Substring(5));
				_currentfolder.addItem (tf);

				terminal [_currentline + 1].GetComponent<Text> ().text = _currentdirectory + " ";
				_currentline += 1;
				cmd_str = "";

			} else if (cmd_str.StartsWith ("cd")) {
				_currentfolder = (Folder)_currentfolder.getItem (cmd_str.Substring (2));

				terminal [_currentline + 1].GetComponent<Text> ().text = _currentdirectory + " ";
				_currentline += 1;
				cmd_str = "";

			} else {
				terminal [_currentline + 1].GetComponent<Text> ().text = " COMMAND NOT FOUND ";
				_currentline += 1;

				terminal [_currentline + 1].GetComponent<Text> ().text = _currentdirectory + " ";
				_currentline += 1;
				cmd_str = "";
			} 
		} else if (Input.GetKeyUp (KeyCode.Backspace)) {
			string newString = (terminal [_currentline].GetComponent<Text> ().text).Substring (0, terminal [_currentline].GetComponent<Text> ().text.Length - 2);
			cmd_str = cmd_str.Substring (0, cmd_str.Length - 2);
			terminal [_currentline].GetComponent<Text> ().text = newString;
		}

		if (Input.inputString != "") {
			terminal[_currentline].GetComponent<Text>().text += Input.inputString;
			cmd_str += Input.inputString;

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