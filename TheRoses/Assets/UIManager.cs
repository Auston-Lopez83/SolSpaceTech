using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace TheRoses

{
	public class UIManager : MonoBehaviour
	{

		public Text whatIsInMe;


		// Use this for initialization
		void Start (string color)
		{
			whatIsInMe.text = color;
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

	}
}
