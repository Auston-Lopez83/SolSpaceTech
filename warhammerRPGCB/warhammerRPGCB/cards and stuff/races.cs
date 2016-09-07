//
// races.cs
//
// Created on 8/28/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System;
namespace warhammerRPGCB
{
	public  class races
	{
		string raceName;
		//string raceSkillName;
		//string raceSkillText;
		int woundThreshold;
		int str;
		int tou;
		int agi;
		int inte;
		int will;
		int fell;






		public races() 
		{
			races human = new races();
			human.raceName = "Human";
			human.str = 2;
			human.tou = 2;
			human.agi = 2;
			human.inte = 2;
			human.will = 2;
			human.fell = 2;



			races woodElf = new races();
			woodElf.raceName = "Wood Elf";
			woodElf.str = 2;
			woodElf.tou = 2;
			woodElf.agi = 3;
			woodElf.inte = 2;
			woodElf.will = 3;
			woodElf.fell = 2;


			races highElf = new races();
			highElf.raceName = "High Elf";
			highElf.str = 2;
			highElf.tou = 2;
			highElf.agi = 3;
			highElf.inte = 3;
			highElf.will = 2;
			highElf.fell =2;


			races dwarf = new races();
			dwarf.raceName = "Dwarf";
			dwarf.str = 3;
			dwarf.tou = 3;
			dwarf.agi = 2;
			dwarf.inte = 2;
			dwarf.will = 2;
			dwarf.fell = 2;


		}

	}
}

