//
// focusTalentsInfosInfosInfo.cs
//
// Created on 9/8/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System;
namespace warhammerTalents
{
	public class focusTalentsInfosInfo
	{
		string cardName;
		string cardText;
		int fortuneDice;
		int missfortuneDice;
		int conservativeDice;
		int recklessDice;
		int challengeDice;
		int characteristicDice;
		int expertiseDice;

		public focusTalentsInfosInfo()
		{

			focusTalentsInfosInfo iveSeenWorse = new focusTalentsInfosInfo();
			iveSeenWorse.cardName = "I've Seen Worse...";
			iveSeenWorse.cardText = "Exhaust this card to add 2 fortune dice to any Willpower check";

			focusTalentsInfosInfo clearMinded = new focusTalentsInfosInfo();
			clearMinded.cardName = "Clear Minded";
			clearMinded.cardText = "Actions using Willpower checks gains:\r\n" +
				" Boon: Recover 1 stress";

			focusTalentsInfosInfo clever =new focusTalentsInfosInfo();
			clever.cardName = "Clever";
			clever.cardText = "When spendinf a fortune point on an Intelligence check, the check gains:\r\n" +
				"2 Boons Add a Success to the result";

			focusTalentsInfosInfo determined = new focusTalentsInfosInfo();
			determined.cardName = "Determinded";
			determined.cardText = "When spending fortune points on a Willpower check, the check gains:\r\n" +
				"2 Boon Add a Success to the result";

			focusTalentsInfosInfo iSeemToRecall = new focusTalentsInfosInfo();
			iSeemToRecall.cardName = "I Seem to Recall...";
			iSeemToRecall.cardText = "Exhaust this card to add 2 fortune dice to any Intelligence check";

			focusTalentsInfosInfo contemplative = new focusTalentsInfosInfo();
			contemplative.cardName = "Contemplative";
			contemplative.cardText = "If you are in a concervative stance, you may spend 1 fortune point to convert " +
				"one more characteristic die into a convervative die then your stance" +
				"would normally alow";

			focusTalentsInfosInfo resolute = new focusTalentsInfosInfo();
			resolute.cardName = "Resolute";
			resolute.cardText = "Exhause this card to recover 2 stress";

			focusTalentsInfosInfo instinctive = new focusTalentsInfosInfo();
			instinctive.cardName = "Instinctive";
			instinctive.cardText = "Add 1 fortune die to Intution checks";

			focusTalentsInfosInfo shadowStalker = new focusTalentsInfosInfo();
			shadowStalker.cardName = "Shadow Stalker";
			shadowStalker.cardText = "Add 1 fortune die to Stealth checks";

			focusTalentsInfosInfo deductiveReasoning = new focusTalentsInfosInfo();
			deductiveReasoning.cardName = "Deductive Reasoning";
			deductiveReasoning.cardText = "Itelligence checks gain a Boon tot hte results pool if at least 3 Success are generated";

			focusTalentsInfosInfo quickWits = new focusTalentsInfosInfo();
			quickWits.cardName = "Quick Wits";
			quickWits.cardText = "Exhauset this card to remove 2 recharge tokens from one of your currently recharing cards";

			focusTalentsInfosInfo keenEyes = new focusTalentsInfosInfo();
			keenEyes.cardName = "Keen Eyes";
			keenEyes.cardText = "Gain 1 fortune die to Observation checks where vision is relevant";

			focusTalentsInfosInfo jackOfAllTrades = new focusTalentsInfosInfo();
			jackOfAllTrades.cardName = "Jack of All Trades";
			jackOfAllTrades.cardText = "You may suffer one stress to add 1 fortune dice to any skill check";

			focusTalentsInfosInfo skygazer = new focusTalentsInfosInfo();
			skygazer.cardName = "Skygazer";
			skygazer.cardText = "Your Intelligence checks gain 1 fortune die so long as you are under the sky";

			focusTalentsInfosInfo creativeThinking = new focusTalentsInfosInfo();
			creativeThinking.cardName = "Creative Thinking";
			creativeThinking.cardText = "Exhaust this tallent to choose and equip a new tallent that you possess of any" +
				"type in this slot; that talent remains equipped untill Creative Thinking Recharges";

			focusTalentsInfosInfo aethyricConduit = new focusTalentsInfosInfo();
			aethyricConduit.cardName = "Aethyric Conduit";
			aethyricConduit.cardText = "When you recover or lose power during your end of turn tep due to not geing" +
				"at equuilibrium, you recover or lose 1 additinal power (unless this would take you past equilibrium)";

			focusTalentsInfosInfo forsight = new focusTalentsInfosInfo();
			forsight.cardName = "Forsight";
			forsight.cardText = "Your Initative checks gain: \r\n" +
				"Boon: Add one sucess to the results pool";
		}
	}
}

