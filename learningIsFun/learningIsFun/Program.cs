//
// Program.cs
//
// Created on 8/22/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System;

namespace learningIsFun
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			string command = "no";
			Console.WriteLine("Welcome to The -enter program name here- \r\n" +
			                  "Let us get started.\r\n" +
			                  "Enter a command please.\r\n" +
			                  "'new', 'load', or 'help'");
			

			do
			{
				


						command = Console.ReadLine();
						Console.Clear();

				
			}
			while(command == "new"|| command == "load"|| command == "help");

			switch (command)
			{
				case "new":
					Console.WriteLine("you said new");
					break;

				case "load":
					Console.WriteLine("you said Load");
					break;

				case "help":
					Console.WriteLine("You are dumb");
					break;

				default:
					break;

			}
			      

		}
	}
}
