//
// Program.cs
//
// Created on 8/18/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System;

namespace playerProfiles
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//stuff
			String[] playersName = new string[50];
			String[] playersAge = new string[50];
			String[] playersWeight = new string[50];
			String[] playersHightFeet = new string[50];
			String[] playersHightInches = new string[50];
			String[] playersSeasons = new string[50];
			String[] playersSeasonTeam = new string[50];
			int playerx = 0;


			//end of stuff
			Console.WriteLine("Hello World! and welcom to Rugby Player Profiles");
			Console.ReadKey();
			Console.WriteLine("Lets get started. What is the Coach's name?");
			String coach = Console.ReadLine();
			Console.WriteLine("What is the name of the team?");
			String teamName = Console.ReadLine();
			Console.WriteLine("Hello Coach {0} Let us start to enter the players names and Info",coach);
			String yOrn = "y";
			if (yOrn == "Y"|| yOrn == "y")
			{
				Console.WriteLine("What is the players full name?");
				playersName[playerx] = Console.ReadLine();
				Console.WriteLine("What is the players age?");
				playersAge[playerx] = Console.ReadLine();
				Console.WriteLine("What is the players Weight? in lbs. please");
				playersWeight[playerx] = Console.ReadLine();
				Console.WriteLine("What is the players Hight?Feet first.");
				playersHightFeet[playerx] = Console.ReadLine();
				Console.WriteLine("Now Inches");
				playersHightInches[playerx] = Console.ReadLine();
				Console.WriteLine("Number of seasons they played Rugby");
				playersSeasons[playerx] = Console.ReadLine();
				Console.WriteLine("NUmber of Seasons with {0}",teamName);
				playersSeasonTeam[playerx] = Console.ReadLine();
				playerx = playerx + 1;

				
			}
			else if (yOrn == "N" || yOrn == "n")
			{
				Console.WriteLine("Where is the list of players in your team with their stats.");
				Console.WriteLine("End of List");
			}


		}
	}
}
