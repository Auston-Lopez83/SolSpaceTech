//
// faithTalent.cs
//
// Created on 8/31/2016
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
	public class faithTalent
	{
		string cardName;
		string cardText;
		int stanceRed;
		int stanceGreen;
		public faithTalent()
		{
			faithTalent shallya = new faithTalent();
			shallya.cardName = "Shallya, Goddess of Healing & Mercy";
			shallya.cardText = "Each time an ally within close range" +
				"(other then you) is critically wounded gain 1 favour.";
			shallya.stanceRed = 1;
			shallya.stanceGreen = 3;

			faithTalent sigmar = new faithTalent();
			sigmar.cardName = "Sigmar, God of the Empire";
			sigmar.cardText = "Each time you inflict 1 or more critical wounds, gain 1 favour";
			sigmar.stanceRed = 3;
			sigmar.stanceGreen = 1;

			faithTalent morr = new faithTalent();
			morr.cardName = "Morr, God of Dreams & Death";
			morr.cardText = "Once per turn, you may perform Morr's Last Rights over the dead" +
				"or dying person within close range gain 1 favour. " +
				"Performing the rights is a prepare manoeuvre";
			morr.stanceRed = 2;
			morr.stanceGreen = 2;

		}
	}
}

