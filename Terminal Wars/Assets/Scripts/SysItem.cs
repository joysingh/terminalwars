using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SysItem
{
	public string name;
	public string directory;
	public string date_created;

	public SysItem()
	{
		name = "New File";
	}
	public SysItem(string n)
	{
		name = n;
	}

	public void setName(string n)
	{
		name = n;
	}

	public void setDirectory(string d)
	{
		directory = d;
	}

	public void setCreated(string d)
	{
		date_created = d;
	}

	public string getName()
	{
		return name;
	}

}
