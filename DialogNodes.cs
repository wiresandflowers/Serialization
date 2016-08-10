using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BaseNode 
{

	public Rect window;
	public Type Class;

	public BaseNode ()
	{
	
	}
}


public class DialogNode : BaseNode
{
	public string Text;
	
	public DialogNode ()
	{
		
	}
}
