using UnityEngine;
using System.Collections;
using System;
using UnityEngine.EventSystems;
namespace TheRoses

{
	public class BoardPos : MonoBehaviour
	{
		public void colorFlower (string color,string[,] board)
		{
			board[0,0] = color;
		}
	
	}
}

