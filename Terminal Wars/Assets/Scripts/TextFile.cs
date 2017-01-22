using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFile : SysItem
{
	public string _content;

	public TextFile(string n) : base(n)
	{ }

	public void set_content(string c)
	{
		_content = c;
	}

}
