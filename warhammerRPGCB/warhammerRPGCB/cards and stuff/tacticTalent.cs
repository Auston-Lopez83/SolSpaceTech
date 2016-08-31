//
// TacticTalent.cs
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
	public class TacticTalent
	{
		string cardName;
		string cardText;

		public TacticTalent()
		{
			TacticTalent leadByExample = new TacticTalent();
			leadByExample.cardName = "Lead By Example";
			leadByExample.cardText = "You may suffer 1 fetague to perform the Assist manoeuver during anoter hero's turn";

			TacticTalent strengthInNumber = new TacticTalent();
			strengthInNumber.cardName = "Strenght in Numbers";
			strengthInNumber.cardText = "While you are within close range of at least two allies," +
				"add 1 experties die to Discipline checks ad 1 fortune die to Leadership checks";

			TacticTalent relentlessPursuit = new TacticTalent();
			relentlessPursuit.cardName = "Relentless Prusute";
			relentlessPursuit.cardText = "When you defeat the last enemy in  your engagement, " +
				"you may immediatly perform a free manouever";

			TacticTalent robust = new TacticTalent();
			robust.cardName = "Robust";
			robust.cardText = "When your critical wounds are being treated or healed, the severity of each" +
				"critical wound is reduced by 1 to a minimum of 1, Critical wounds that are already severity 0 are unaffected";

			TacticTalent shieldWall = new TacticTalent();
			shieldWall.cardName = "Shield Wall";
			shieldWall.cardText = "When in an engagement where at least two allies are equipped with shields," +
				"gain +1 to Defence";

			TacticTalent flankingManoeuvre = new TacticTalent();
			flankingManoeuvre.cardName = "Flanking Manoeuver";
			flankingManoeuvre.cardText = "When in an engagement with at least 1 ally, you and your allies add 1 " +
				"fortune die to Melee Attack dice pools against the engaged foes";
			TacticTalent mightMakesRight = new TacticTalent();
			mightMakesRight.cardName = "Might Makes Right";
			mightMakesRight.cardText = "When spending fortune points on a Strength check, the check gains:\r\n" +
				"2 Boons: Add 1 sucsses to the results";

			TacticTalent coordnatedEfforts = new TacticTalent();
			coordnatedEfforts.cardName = "Coordinated Efforts";
			coordnatedEfforts.cardText = "When spending fortune points on an Agility check, the check gains:\r\n" +
				"2 Boons: Add 1 sucsess to the result";

			TacticTalent girdingOneself = new TacticTalent();
			girdingOneself.cardName = "Girding Oneself";
			girdingOneself.cardText = "When spending fortune points on a Toughhness check, the check gains:\r\n" +
				"2 Boons: Add 1 sucsess to the result";

			TacticTalent timelySurge = new TacticTalent();
			timelySurge.cardName = "Timely Surge";
			timelySurge.cardText = "Exhaust this card to add 2 fortune dice to any Strenght check\r\n" +
				"If the check fails, suffer 1 fatgue";

			TacticTalent catlikeReflexes = new TacticTalent();
			catlikeReflexes.cardName = "Catlike Reflexes";
			catlikeReflexes.cardText = "Exhause this card to add 2 fortune dice to any Agility check, or 2 missfortune to a Dodge attempt\r\n" +
				"If your Agility check fails, suffet 1 fatigue";

			TacticTalent relentlessApproach = new TacticTalent();
			relentlessApproach.cardName = "relentless Approach";
			relentlessApproach.cardText = "After rolling a Strenght, Toughness, or Agility check, exhaust thus card to" +
				"reroll a fortune and missfortune in the current dice pool";

			TacticTalent illSleepWhenImDead = new TacticTalent();
			illSleepWhenImDead.cardName = "I'll Sleep When I'm Dead";
			illSleepWhenImDead.cardText = "Exhaust this card to recover 2 fatigue";

			TacticTalent exceptinalTraining = new TacticTalent();
			exceptinalTraining.cardName = "Exceptional Training";
			exceptinalTraining.cardText = "Exhaust thsi card to negate up to 2 Banes genorated by a Strenght, Agility, or Toughness check";

			TacticTalent charge = new TacticTalent();
			charge.cardName = "Charge";
			charge.cardText = "On the turn in which you first enter an engagement with an enemy," +
				"gain 1 fortune die to all your Melee Attack actions";

			TacticTalent combatAlertness = new TacticTalent();
			combatAlertness.cardName = "Combat Alertness";
			combatAlertness.cardText = "Gain +1 Defence againsed Melee Attacks while you have no Active Defence actions recharging";

			TacticTalent leadFromTheFront = new TacticTalent();
			leadFromTheFront.cardName = "Lead from the Front";
			leadFromTheFront.cardText = "In combat, if no enemies have acted yet during the current round, " +
				"gain 1 fortune die to one skill check you attempt on your turn";
			



		}
	}
}

