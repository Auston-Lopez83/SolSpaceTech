//
// reputationTalent.cs
//
// Created on 8/27/2016
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
	public class ReputationTalent

	{
		string cardName;
		string cardText;

		public ReputationTalent()
		{
			ReputationTalent iKnowAGuy = new ReputationTalent();
			iKnowAGuy.cardName = "I Kkow a Guy...";
			iKnowAGuy.cardText = "Exhause this card to add 2 fortune dice to a Felowship check\r\n" +
				"If the check fails, suffer 1 stress";

			ReputationTalent resourceful = new ReputationTalent();
			resourceful.cardName = "Resourcefull";
			resourceful.cardText = "Exhause this card to add 1 expertise dice to an Intelligence check";

			ReputationTalent icyStare = new ReputationTalent();
			icyStare.cardName = "Icy Stare";
			icyStare.cardText = "Your Social action using Guile gain:\r\n" +
				"2 boons; The target must make an Avrage (1d) Discipline(WP) check or gain the Rattled condition for 2 rounds";

			ReputationTalent strongWilled = new ReputationTalent();
			strongWilled.cardName = "Strong Willed";
			strongWilled.cardText = "Exhaust this card to recover 1 fatigus and 1 stress";

			ReputationTalent confident = new ReputationTalent();
			confident.cardName = "Confident";
			confident.cardText = "Exhaust this card to negate up to 2 banes generated during an Intelligence, Willpower, or Fellowship check";

			ReputationTalent notorious = new ReputationTalent();
			notorious.cardName = "Notorious";
			notorious.cardText = "Add 1 fortune die to Guile Checks";

			ReputationTalent gregarious = new ReputationTalent();
			gregarious.cardName = "Gregarious";
			gregarious.cardText = "Add 1 fortune die to Charm checks";

			ReputationTalent favouredByFortune = new ReputationTalent();
			favouredByFortune.cardName = "Favoured By Fortune";
			favouredByFortune.cardText = "After rolling an Intelligence, Willpower, or Felloship check, exhaust this card to reroll all" +
				"fortune and misfortune dice in the current dice pool";

			ReputationTalent betterLuckyThenGood = new ReputationTalent();
			betterLuckyThenGood.cardName = "Better Lucky Then Good";
			betterLuckyThenGood.cardText = "When you spend a fortune point to add dice to a check using a basic skill you do not have trained in, you may" +
				"add 2 fortune dice insted of 1";

			ReputationTalent shady = new ReputationTalent();
			shady.cardName = "Shady";
			shady.cardText = "Your Skulduggery checks gain 1 fortune die";

			ReputationTalent fearless = new ReputationTalent();
			fearless.cardName = "Fearless";
			fearless.cardText = "Add 1 forutne die to all Discipline checks to resist Fear or Terror\r\n" +
				"Echaust this card to reroll a failld Disicipline check against a Fear or Terror rating";
			
			ReputationTalent silverTongue = new ReputationTalent();
			silverTongue.cardName = "Silver Tongue";
			silverTongue.cardText = "Fellowship checks add 1 boon to the results pool of at least 3 sucsess are generated";

			ReputationTalent charismatic = new ReputationTalent();
			charismatic.cardName = "Charismatic";
			charismatic.cardText = "When you spent a fortune point on a Fellowship check, the check gains:\r\n" +
				"2 Boons: Add 1 sucses to the results";

			ReputationTalent intimidatingPresence = new ReputationTalent();
			intimidatingPresence.cardName = "Intimidatinf Presence";
			intimidatingPresence.cardText = "Your Intemidate checks gain:\r\n" +
				"1 Boo: The target suffers 1 stress";

			ReputationTalent voiceOfReason = new ReputationTalent();
			voiceOfReason.cardName = "Voice of Reason";
			voiceOfReason.cardText = "Echause this card to use Intelligence rather then Fellowship for a skill check. The check gains:\r\n" +
				"1 Bane: Add 1 challange to the results pool";

			ReputationTalent magicRmpathy = new ReputationTalent();
			magicRmpathy.cardName = "Magic Empathy";
			magicRmpathy.cardText = "Gain 1 fortune die to Fellowship checks or Social actions targiting a wizard";

			ReputationTalent universityEducation = new ReputationTalent();
			universityEducation.cardName = "University Education";
			universityEducation.cardText = "Your Education or Folklore checks gain:\r\n" +
				"2 Banes: Add 1 sucess to the sesults pool";

			ReputationTalent wellTraveled = new ReputationTalent();
			wellTraveled.cardName = "Well-Traveled";
			wellTraveled.cardText = "You gain 1 fortune die to Charm, Education, and Folklore checks pertaining to exotic people or places.\r\n" +
				"Exhaust this dard to ignore a penalty on a Social action based on cultural diffrences";

			ReputationTalent weatherbeaten = new ReputationTalent();
			weatherbeaten.cardName = "Weatherbeaten";
			weatherbeaten.cardText = "When you suffer fatigue, stress, or wounds due to inclement weather or environmental effects," +
				"reduce the fatgue, stress, or wounds you suffer by 1 to a minnimun of 1." +
				"you also suffer 1 fewer misfortune die from wether effects.";
			



			}
	}
}

