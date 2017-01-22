using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folder: SysItem
{
	public List<SysItem> items; // List of items in current folder including sub folders and hidden data.

	public Folder() : base()
	{
		items = new List<SysItem> ();
	}

	public Folder(string n) : base(n)
	{ 
		items = new List<SysItem> ();
	}

	public void addItem(SysItem s)
	{
		items.Add (s);
	}

	public string[] getItemList()
	{
		int numItems = items.Count;
		string[] il = new string[numItems];

		int c = 0;
		foreach(SysItem si in items)
		{
			il [c] = si.getName ();
			c++;
		}

		return il;
	}

}
