﻿using UnityEngine;
using System.Collections;

public class Singlton<T> : MonoBehaviour where T : MonoBehaviour {

	private static T instance;

	public static T Instance{
		get{
			if(instance==null) {
				instance=(T)FindObjectOfType(typeof(T));

				if(instance==null) {
					Debug.Log(typeof(T)+"is nothing");
				}
			}
			return instance;
		}
	}
}
