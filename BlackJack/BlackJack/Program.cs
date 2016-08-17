//
//  Author:
//    Auston Lopez MRPOWERZ83@me.com
//
// Created on 8/2/2016
//
//  Copyright (c) 2016, All rights reserved
//
//  All rights reserved.
//
//
using System;
using System.Collections.Generic;

namespace BlackJack
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			// crap that needs to be made
			String[] cards = 
			{
				"A 2 ",
				"A 3 ",
				"A 4 ",
				"A 5 ",
				"A 6 ",
				"A 7 ",
				"A 8 ",
				"A 9 ",
				"A 10 ",
				"A Jack ",
				"A Queen ",
				"A King ",
				"An Ace ",
				"BLANK",
				"BLANK"

			};
			String[] suites = 
			{ 
				"Of Spades",
				"Of Dimonds",
				"Of Hearts",
				"Of Clubs" 
			};





			// random cards put into an array for the player
			int Min = 1;
			int Max = 52;
			int[] playerCards = new int[11];
			Random randNum = new Random ();
			for (int i = 0; i < playerCards.Length; i++) 
			{
				playerCards [i] = randNum.Next (Min, Max);
			}
			// random cards for dealer
			int[] dealerCards = new int[11];
			for (int i = 0; i < dealerCards.Length; i++) 
			{
				dealerCards [i] = randNum.Next (Min, Max);
			}
			// dealer's cards are given a value
			int[] dealerCardsValue = new int[12];
			int y = 0;
			while (y< 9) {
				if (dealerCards [y] <= 31) 
				{
					dealerCardsValue[y] = 2 + ((dealerCards [y]) / 4);
					y = y + 1;
				} if (dealerCards [y] >= 32 && dealerCards [y] <= 47) 
				{
					dealerCardsValue[y] = 10 ;
					y = y + 1;
				} if (dealerCards [y] >= 48 && dealerCards [y] <= 54) 
				{
					dealerCardsValue [y] = 11;
					y = y + 1;
				} 
			}
			// cards are given a value
			int[] playerCardsValue = new int[12];
			int x = 0;
			while (x < 9) 
				{
				if (playerCards [x] <= 31)
				{
					playerCardsValue[x] = 2 + ((playerCards [x]) / 4);
					x = x + 1;
				} if (playerCards [x] >= 32 && playerCards [x] <= 47) 
				{
					playerCardsValue[x] = 10 ;
					x = x + 1;
				} if (playerCards [x] >= 48 && playerCards [x] <= 54) 
				{
					playerCardsValue [x] = 11;
					x = x + 1;
				} 
			}

			// end of the crap nedded
			//
			//
			// debug players cards printed
			//Console.WriteLine (string.Join(",",playerCards));
			//Console.WriteLine(string.Join(",",playerCardsValue));

			// the game text for the player

			Console.WriteLine ("Welcom to the game BlackJack. \nMy Name is Rand. \nWhat is your name?");
			String playerName = Console.ReadLine ();
			Console.WriteLine ("Hello {0}, are you ready to play?", playerName);
			Console.WriteLine ("hit any key to continue");
			Console.ReadKey();
			Console.WriteLine ("Your two cards are");
			Console.Write (cards [playerCards [0] / 4]);
			Console.Write (suites [playerCards [0] / 13]);
			Console.Write (" and ");
			Console.Write (cards [playerCards [1] / 4]);
			Console.WriteLine (suites [playerCards [1] / 13]);
			int playerTotal = playerCardsValue[0] + playerCardsValue[1];
			//	if both cards are Aces it makes one of the worth 1
			if ( playerCardsValue[1] ==11  && playerCardsValue[0] == 11)
			{
				playerTotal = playerTotal - 10;
			}


			Console.WriteLine ("For a total of {0}", playerTotal);
		
			// debug players cards printed
			//Console.WriteLine (string.Join(",",playerCards));
			//Console.WriteLine(string.Join(",",playerCardsValue));

			// the game text for the dealer
			Console.WriteLine ("hit any key to continue");
			Console.ReadKey();
			Console.WriteLine ("the Dealers two cards are");
			Console.Write (cards [dealerCards [1] / 4]);
			Console.Write (suites [dealerCards [1] / 13]);
			Console.WriteLine (" and ********** ");
			Console.WriteLine ("For a total of {0} + ?",dealerCardsValue[1]);
			int dealerTotal = dealerCardsValue [0] + dealerCardsValue [1];
			//	if both cards are Aces it makes one of the worth 1
			if ( dealerCardsValue[1] ==11  && dealerCardsValue[0] == 11)
			{
				playerTotal = playerTotal - 10;
			}
		
			if (playerTotal != 21)
			{
				

			// the hit or stay system for the player
			int playerHit = 2;
			bool more = true;
			while (more == true)
				while (true)
				{
					Console.WriteLine ("Do you want to hit(H) or stay(S)");
					ConsoleKeyInfo result = Console.ReadKey();
					if ((result.KeyChar == 'H') || (result.KeyChar == 'h'))
						{

						playerTotal = playerTotal + playerCardsValue [playerHit];
						Console.WriteLine("\r\nYour new card is ");
						Console.Write (cards [playerCards [playerHit] / 4]);
						Console.WriteLine (suites [playerCards [playerHit] / 13]);
						Console.WriteLine ("Making your total now {0}", playerTotal);
						playerHit = 1 + playerHit;
						// if the player has an ace and the total is over 21 it makes the ace worth 1
						if (playerCardsValue [x] == 11 && playerTotal > 21);
						{
							playerTotal = 10-playerTotal;
									break;
						}
							if (playerTotal> 21)
							{
								Console.WriteLine ("You bust, sorry better luck next time");
								Console.WriteLine ("Dealer won with a total of {0}", dealerTotal);
								break;
						}
						break;
					}
					else if ((result.KeyChar == 'S') || (result.KeyChar == 's'))
					{
							if (playerTotal> 21)
							{
								Console.WriteLine ("You bust, sorry better luck next time");
								Console.WriteLine ("Dealer won with a total of {0}", dealerTotal);
								break;
							}

						Console.WriteLine("\r\nSo you will Stay with a total of {0}", playerTotal);
						more = false;
						break;
					}
				}
			}

			// dealers hit turn
			int dealerHit = 2;
			Console.WriteLine ("Now it is the dealer's turn");
			while (dealerTotal <= playerTotal);
			{
				dealerTotal	= dealerTotal + dealerCardsValue [dealerHit];
				if (dealerCardsValue [x] == 11 && dealerTotal > 21)
				{
					dealerTotal = dealerTotal - 10;
				}
			}
			if (playerTotal > dealerTotal && playerTotal < 22)
			{
				Console.WriteLine ("Player wins the game with {0} vs. {1}",playerTotal , dealerTotal);
			}
			else if (playerTotal< dealerTotal && playerTotal < 22)
			{
				Console.WriteLine (" Dealer wins with {0} vs. {1}", dealerTotal, playerTotal);
			}
			else if (playerTotal >21)
			{
				Console.WriteLine ("{0} You bust and the Dealer wins",playerName);
			}
			else if (dealerTotal >21)
			{
				Console.WriteLine("Dealer bust and You win");
			}
			else 
			{
				Console.WriteLine ("It is a Push you both have {0}", playerTotal);
			}

			}
			
	}
}
