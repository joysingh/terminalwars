using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folder
{
	public string name; // Name of folder.
	//public List<SysItem> items; // List of items in current folder including sub folders and hidden data.

	public Folder()
	{
		name = "New Folder";
	}

	public Folder(string n)
	{
		name = n;
	}

	public void addFile(File f)
	{

	}
}
