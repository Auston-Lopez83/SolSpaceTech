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
		public static void DrawCard(string Cards, int PlayerCards)
		{
			var rnd = new Random(DateTime.Now.Millisecond);
			int x = rnd.Next(0, 29);
			Cards.Clone();
			Cards.Remove(x);

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
