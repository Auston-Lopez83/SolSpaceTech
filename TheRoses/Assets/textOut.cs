using UnityEngine;
using System.Collections;
using System;
namespace TheRoses


{
	public class textOut : MonoBehaviour
	{

		void OnGUI() {
			GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
		}
	}
}