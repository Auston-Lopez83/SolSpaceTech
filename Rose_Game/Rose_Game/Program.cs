//
// Program.cs
//
// Created on 12/2/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System;
using System.Security.Cryptography.X509Certificates;
using Rose_Game;
using System.Runtime.CompilerServices;
using System.Net;
using System.Collections.Generic;

namespace Rose_Game
{
	class MainClass
	{


		public static void Main(string[] args)
		{
			var Cards = new List<string>();
			for (int X = 1; X < 31; X++)
			{
				Cards.Add("Card" + X);
			}
			var PlayerCards = new List<string>();
			//testing this
			string[,] board = new string[4, 4];


			board[0, 0] = "W";
			board[0, 1] = "W";
			board[0, 2] = "W";
			board[0, 3] = "R";
			board[1, 0] = null;
			board[1, 1] = "W";
			board[1, 2] = "W";
			board[1, 3] = "W";
			board[2, 0] = "W";
			board[2, 1] = "W";
			board[2, 2] = "W";
			board[2, 3] = "W";
			board[3, 0] = "W";
			board[3, 1] = "P";
			board[3, 2] = "R";
			board[3, 3] = "R";


			string Slot1 = "Y";
			string Slot2 = "R";
			int action = 1;

			//end of testing
			int x = -1;
			int y = -1;
			int z = 0;



			//player taks an action
			switch (action)
			{
				case 1:
					PlayersAction.DrawCard(Cards,PlayerCards);
					break;
				case 2:
					PlayersAction.PlaceTile();
					break;
				case 3:
					PlayersAction.ScoreCard();
					Positions.Pos1(Slot1, Slot2, board, x, y, z);
					break;
				default:
					break;
			}

		}
	}
}
