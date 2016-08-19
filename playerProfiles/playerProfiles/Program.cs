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
			int x = 0;


			//end of stuff
			Console.WriteLine("Hello World! and welcom to Rugby Player Profiles");
			Console.ReadKey();
			Console.WriteLine("Lets get started. What is the Coach's name?");
			String coach = Console.ReadLine();
			Console.WriteLine("What is the name of the team?");
			String teamName = Console.ReadLine();
			Console.WriteLine("Hello Coach {0} Let us start to enter the players names and Info",coach);
			String yOrn = "Y";
			while (yOrn == "Y" || yOrn == "y")
			{


				Console.WriteLine("What is the players full name?");
				playersName[playerx] = Console.ReadLine();
				Console.WriteLine("What is the players age?");
				playersAge[playerx] = Console.ReadLine();
				Console.WriteLine("What is the players Weight? in lbs. please");
				playersWeight[playerx] = Console.ReadLine();
				Console.WriteLine("What is the players Hight? Feet first.");
				playersHightFeet[playerx] = Console.ReadLine();
				Console.WriteLine("Now Inches");
				playersHightInches[playerx] = Console.ReadLine();
				Console.WriteLine("Number of seasons they played Rugby");
				playersSeasons[playerx] = Console.ReadLine();
				Console.WriteLine("NUmber of Seasons with {0}", teamName);
				playersSeasonTeam[playerx] = Console.ReadLine();
				playerx = playerx + 1;
				Console.WriteLine("Do you still want to add more players (y) or (n)?");
				yOrn = Console.ReadLine();
			}
			{
				Console.WriteLine("Here is the list of players in your team with their stats.\n \n");
				// making the rows and colloms
				Console.Write("Num,".PadLeft(3));
				Console.Write("Name,".PadLeft(25));
				Console.Write("Age,".PadLeft(7));
				Console.Write("Hight,".PadLeft(7));
				Console.Write("Weight,".PadLeft(10));
				Console.Write("Years Played,".PadLeft(20));
				Console.WriteLine("Years with The {0}".PadLeft(25),teamName);
				while(x<playerx)
				{
					Console.WriteLine($"{x+1,3}" + 
					                  $"{playersName[x],25}" + 
					                  $"{playersAge[x],7}" + 
					                  $"{playersHightFeet[x],4}" + 
					                  $"{playersHightInches[x],3}" +
					                  $"{playersWeight,10}" + 
					                  $"{playersSeasons[x],20}" +
					                  $"{playersSeasonTeam[x],25}");
					x = x + 1;
					                  
				}

				Console.WriteLine("\t\t\tAnd Coach {0} of The Team The {1}",coach,teamName);
				
				
			}



		}
	}
}
