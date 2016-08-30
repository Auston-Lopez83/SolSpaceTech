//
// tacticTalent.cs
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
	public class tacticTalent
	{
		string cardName;
		string cardText;

		public tacticTalent()
		{
			tacticTalent leadByExample = new tacticTalent();
			leadByExample.cardName = "Lead By Example";
			leadByExample.cardText = "You may suffer 1 fetague to perform the Assist manoeuver during anoter hero's turn";

			tacticTalent strengthInNumber = new tacticTalent();
			strengthInNumber.cardName = "Strenght in Numbers";
			strengthInNumber.cardText = "While you are within close range of at least two allies," +
				"add 1 experties die to Discipline checks ad 1 fortune die to Leadership checks";

			tacticTalent relentlessPursuit = new tacticTalent();
			relentlessPursuit.cardName = "Relentless Prusute";
			relentlessPursuit.cardText = "When you defeat the last enemy in  your engagement, " +
				"you may immediatly perform a free manouever";

			tacticTalent robust = new tacticTalent();
			robust.cardName = "Robust";
			robust.cardText = "When your critical wounds are being treated or healed, the severity of each" +
				"critical wound is reduced by 1 to a minimum of 1, Critical wounds that are already severity 0 are unaffected";

			tacticTalent shieldWall = new tacticTalent();
			shieldWall.cardName = "Shield Wall";
			shieldWall.cardText = "When in an engagement where at least two allies are equipped with shields," +
				"gain +1 to Defence";

			tacticTalent flankingManoeuvre = new tacticTalent();
			flankingManoeuvre.cardName = "Flanking Manoeuver";
			flankingManoeuvre.cardText = "When in an engagement with at least 1 ally, you and your allies add 1 " +
				"fortune die to Melee Attack dice pools against the engaged foes";
			tacticTalent mightMakesRight = new tacticTalent();
			mightMakesRight.cardName = "Might Makes Right";
			mightMakesRight.cardText = "When spending fortune points on a Strength check, the check gains:\r\n" +
				"2 Boons: Add 1 sucsses to the results";

			tacticTalent coordnatedEfforts = new tacticTalent();
			coordnatedEfforts.cardName = "Coordinated Efforts";
			coordnatedEfforts.cardText = "When spending fortune points on an Agility check, the check gains:\r\n" +
				"2 Boons: Add 1 sucsess to the result";

			tacticTalent girdingOneself = new tacticTalent();
			girdingOneself.cardName = "Girding Oneself";
			girdingOneself.cardText = "When spending fortune points on a Toughhness check, the check gains:\r\n" +
				"2 Boons: Add 1 sucsess to the result";

			tacticTalent timelySurge = new tacticTalent();
			timelySurge.cardName = "Timely Surge";
			timelySurge.cardText = "Exhaust this card to add 2 fortune dice to any Strenght check\r\n" +
				"If the check fails, suffer 1 fatgue";

			tacticTalent catlikeReflexes = new tacticTalent();
			catlikeReflexes.cardName = "Catlike Reflexes";
			catlikeReflexes.cardText = "Exhause this card to add 2 fortune dice to any Agility check, or 2 missfortune to a Dodge attempt\r\n" +
				"If your Agility check fails, suffet 1 fatigue";

			tacticTalent relentlessApproach = new tacticTalent();
			relentlessApproach.cardName = "relentless Approach";
			relentlessApproach.cardText = "After rolling a Strenght, Toughness, or Agility check, exhaust thus card to" +
				"reroll a fortune and missfortune in the current dice pool";

			tacticTalent illSleepWhenImDead = new tacticTalent();
			illSleepWhenImDead.cardName = "I'll Sleep When I'm Dead";
			illSleepWhenImDead.cardText = "Exhaust this card to recover 2 fatigue";

			tacticTalent exceptinalTraining = new tacticTalent();
			exceptinalTraining.cardName = "Exceptional Training";
			exceptinalTraining.cardText = "Exhaust thsi card to negate up to 2 Banes genorated by a Strenght, Agility, or Toughness check";

			tacticTalent charge = new tacticTalent();
			charge.cardName = "Charge";
			charge.cardText = "On the turn in which you first enter an engagement with an enemy," +
				"gain 1 fortune die to all your Melee Attack actions";

			tacticTalent combatAlertness = new tacticTalent();
			combatAlertness.cardName = "Combat Alertness";
			combatAlertness.cardText = "Gain +1 Defence againsed Melee Attacks while you have no Active Defence actions recharging";

			tacticTalent leadFromTheFront = new tacticTalent();
			leadFromTheFront.cardName = "Lead from the Front";
			leadFromTheFront.cardText = "In combat, if no enemies have acted yet during the current round, " +
				"gain 1 fortune die to one skill check you attempt on your turn";
			



		}
	}
}

