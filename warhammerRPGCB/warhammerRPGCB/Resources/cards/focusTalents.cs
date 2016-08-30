//
// focusTalents.cs
//
// Created on 8/27/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System;
namespace warhammerRPGCB
{
	public class focusTalents
	{
		public focusTalents()
		{
			//
			int[] whiteDice = {-3,-2,-1,0,1,2,3};
			int[] redDice = {-3,-2,-1,0,1,2,3};
			int[] greenDice = {-3,-2,-1,0,1,2,3};
			int[] purpleDice = {-3,-2,-1,0,1,2,3};
			int[] blueDice = {-3,-2,-1,0,1,2,3};
			int[] blackDice = {-3,-2,-1,0,1,2,3};
			int[] yellowDice = {-3,-2,-1,0,1,2,3};

			/*
			 * 
			 * first idea with cards bing in an array
			string[] focusName = new string[50];
			string[] focusText = new string[50];
			//cards
			focusName[0] = "Pick a Fight";
			focusText[0] = "This does some things that will hurt people";
			whitedice[2];
			focusName[1] = "Talk to people";
			focusText[1] = "You know talk to people";
			*/

			//cards in the form of a method
			/*
			 * basic card form to fill
			 * 
			 * static void nameOfCard()
			 * {
			 * string cardName =  "The card's name here";
			 * string cardText = "The card's text here";
			 * if there is a die mod put it here;
			 * }
			 * 
			*/
			static void pickAFight()
			{
				string cardName = "Pick A Fight";
				string cardText = "Some text on the card";
				whiteDice[3];
			}
			static void talkToPeople()
			{
				string cardName = "Talk to People";
				string cardText = "You know, talk to people";
				purpleDice[2];
			}
			static void knowAGuy()
			{
				string cardName = "Know a Guy";
				string cardText = "You know a person that may have some knolage to help";
				yellowDice[4];
			}
			static void knowingHowToRead()
			{
				string cardName = "Knowing How To Read";
				string cardText = "You know how to read words";
				Console.W
			}



		}
	}
}

