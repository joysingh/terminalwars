using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folder: SysItem
{
	public List<SysItem> items; // List of items in current folder including sub folders and hidden data.

	public Folder() : base()
	{ }

	public Folder(string n) : base(n)
	{ }

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
		}

		return il;
	}

}
