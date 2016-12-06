//
// Positions.cs
//
// Created on 12/4/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO.Pipes;
using System.Linq.Expressions;
namespace Rose_Game
{
	public class Positions
	{
		public Positions()
		{
		}

		public static void Pos1(string Slot1, string Slot2, string[,] board, int x, int y,int z)
		{
			int ans = 0;

			//Console.WriteLine("Slot1 is {0}",Slot1);
			//Console.WriteLine("Slot2 is {0}",Slot2);
			if (z < 17 )
			{
				for (int c = 0; c < 16; c++)
				{
						z = z + 1;
						x = x + 1;
						if (x > 3)
						{
							x = 0;
						}
						for (int b = 0; b < 4; b++)
						{
						
							y = 1 + y;

							if (y > 3)
							{
								y = 0;
							}

							if (board[x, y] == Slot1)
							{
								ans = 1;
								Console.WriteLine("Slot1 {0} = ({1},{2})", Slot1, x, y);
								switch (ans)
								{
									case 1:
										//Console.WriteLine("Slot1 {0} = ({1},{2})", Slot1, x, y);
									Pos2(board, Slot1, Slot2, x, y, z);
										break;
									default:
										break;
								}
								return;
							}
						}
					}
				}

			Console.WriteLine("No card Scored");

		}



		public static void Pos2(string[,] board, string Slot1,string Slot2, int x, int y, int z)
		{
			int ans = 0;
			//Console.WriteLine(board[2,2]);
			//Console.WriteLine("Slot2 is {0}",Slot2);


				if (y + 1 < 4 && board[x, y + 1] == Slot2)
				{
					ans = 2;
					y = y + 1;
				}

				else if (y - 1 > 0 && board[x, y - 1] == Slot2)
				{
					ans = 2;
					y = y - 1;
				}

				else if (x + 1 < 4 && board[x + 1, y] == Slot2)
				{
					ans = 2;
					x = x + 1;
				}

				else if (x - 1 > 0 && board[x - 1, y] == Slot2)
				{
					ans = 2;
					x = x - 1;
				}
				else 
				{
					ans = 4;
				    //x = x + 1;
				}
				switch (ans)
				{
					case 2:
						Console.WriteLine(" Slot2 {0} = ({1},{2})", Slot2, x, y);
						Console.WriteLine("The card scored");
						return;
					case 3:
						Console.WriteLine("The card  did not scored");
						break;
						
					default:
						Pos1(Slot1,Slot2,board,x,y,z);
						break;
				}

			}


	}
}
