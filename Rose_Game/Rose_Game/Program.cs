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

namespace Rose_Game
{
	class MainClass
	{


		public static void Main(string[] args)
		{
			//testing this
			string[,] board = new string[4, 4];


			board[0, 0] = "W";
			board[0, 1] = "W";
			board[0, 2] = "W";
			board[0, 3] = "W";
			board[1, 0] = null;
			board[1, 1] = "W";
			board[1, 2] = "P";
			board[1, 3] = "W";
			board[2, 0] = "W";
			board[2, 1] = "Y";
			board[2, 2] = "R";
			board[2, 3] = "W";
			board[3, 0] = "W";
			board[3, 1] = "P";
			board[3, 2] = "R";
			board[3, 3] = "W";

			string Slot1 = "Y";
			string Slot2 = "R";

			//end of testing
			int x = 0;
			int y = 0;


			Positions.Pos1(Slot1,Slot2,board,x,y);

		}
	}
}
