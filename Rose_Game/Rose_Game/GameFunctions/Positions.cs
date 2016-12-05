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

		public static void Pos1(string Slot1, string Slot2, string[,] board,int x, int y)
		{
			int ans = 0;


			/* not sure i want to add this now
				int ans2 = 0;
			*/

			for (int b = 0; b < 4; b++)
			{
				if (y+b<4 && board[x, y + b] == Slot1)
					{
						ans = 1;
						y = y + b;
						break;
					}



					else if (y + b < 4 && x + 1 < 4 && board[x + 1, y + b] == Slot1)
					{
						ans = 1;
						y = y + b;
						x = x + 1;
						break;						
					}
					
					else if (y + b < 4 && x + 2 < 4 && board[x + 2, y + b] == Slot1)
					{
						ans = 1;
						y = y + b;
						x = x + 2;
						break;
					}
					else if ( y + b < 4 && x + 3 < 4 &&board[x + 3, y + b] == Slot1)
					{
						ans = 1;
						y = y + b;
						x = x + 3;
						break;
					}
				}


			switch (ans)
			{
				case 1:

					Console.WriteLine("Slot1 {0} = ({1},{2})", Slot1, x, y);
					Pos2(board,Slot1, Slot2, x, y);
					break;
				default:
					Console.WriteLine("Card did not Score");
					break;
			}





		}

		public static void Pos2(string[,] board, string Slot2,string Slot1, int x, int y)
		{
			int ans = 0;

				if (y < 4 && board[x, y + 1] == Slot2)
				{
					ans = 1;
					y = y + 1;

				}

				else if (y < 0 && board[x, y - 1] == Slot2)
				{
					ans = 1;
					y = y - 1;
				}

				else if (x < 4 && board[x + 1, y] == Slot2)
				{
					ans = 1;
					x = x + 1;
				}
					
				else if (x > 0 && board[x - 1, y] == Slot2)
				{
					ans = 1;
				x = x - 1;
				}
				else 
				{
				ans = 3;
				}
					



			switch (ans)
				{
					case 1:

						Console.WriteLine(" Slot2 {0} = ({1},{2})", Slot2, x, y);
						break;
					default:
						Pos1(Slot1,Slot2,board,x,y);
						break;
				}

			}


	}
}
