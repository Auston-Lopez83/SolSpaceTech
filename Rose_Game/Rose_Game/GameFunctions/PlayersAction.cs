//
// PlayersAction.cs
//
// Created on 12/5/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System;
using System.Collections.Generic;
using Rose_Game;
namespace Rose_Game
{
	public class PlayersAction
	{
		public  PlayersAction()
		{
			
		}
		public static void DrawCard()
		{
			List<string> Cards = new List<string>();
			for (int x = 1; x < 31; x++)
			{
				Cards.Add("Card"+ x);

			}
			for (int x = 1; x < 31; x++)
			{
				Console.WriteLine(Cards);
			}

			Console.WriteLine("You took a card");
		}
		public static void PlaceTile()
		{
			Console.WriteLine("You Place a Tile");
		}
		public static void ScoreCard()
		{
			
			Console.WriteLine("You Play a Score Card");
		}
	}
}
