﻿using UnityEngine;
using System.Collections;

public static class ExtensionMethods 
{

	public static Vector3 RoundXY(this Vector3 position)
	{
		float x = Mathf.Ceil (position.x);
		float y = Mathf.Floor (position.y);
		float z = position.z;

		return new Vector3(x,y,z);
	}

}