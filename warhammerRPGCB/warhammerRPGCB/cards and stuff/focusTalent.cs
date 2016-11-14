//
// focusTalent.cs
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
	public class focusTalent
	{
		
		public string cardName;
		public string cardText;
		public int fortuneDice;
		public int missfortuneDice;
		public int conservativeDice;
		public int recklessDice;
		public int challengeDice;
		public int characteristicDice;
		public int expertiseDice;


		public focusTalent()
		{
			focusTalent iveSeenWorse = new focusTalent();
			iveSeenWorse.cardName = "I've Seen Worse...";
			iveSeenWorse.cardText = "Exhaust this card to add 2 fortune dice to any Willpower check";

			focusTalent clearMinded = new focusTalent();
			clearMinded.cardName = "Clear Minded";
			clearMinded.cardText = "Actions using Willpower checks gains:\r\n" +
				" Boon: Recover 1 stress";

			focusTalent clever =new focusTalent();
			clever.cardName = "Clever";
			clever.cardText = "When spendinf a fortune point on an Intelligence check, the check gains:\r\n" +
				"2 Boons Add a Success to the result";

			focusTalent determined = new focusTalent();
			determined.cardName = "Determinded";
			determined.cardText = "When spending fortune points on a Willpower check, the check gains:\r\n" +
				"2 Boon Add a Success to the result";

			focusTalent iSeemToRecall = new focusTalent();
			iSeemToRecall.cardName = "I Seem to Recall...";
			iSeemToRecall.cardText = "Exhaust this card to add 2 fortune dice to any Intelligence check";

			focusTalent contemplative = new focusTalent();
			contemplative.cardName = "Contemplative";
			contemplative.cardText = "If you are in a concervative stance, you may spend 1 fortune point to convert " +
				"one more characteristic die into a convervative die then your stance" +
				"would normally alow";

			focusTalent resolute = new focusTalent();
			resolute.cardName = "Resolute";
			resolute.cardText = "Exhause this card to recover 2 stress";

			focusTalent instinctive = new focusTalent();
			instinctive.cardName = "Instinctive";
			instinctive.cardText = "Add 1 fortune die to Intution checks";

			focusTalent shadowStalker = new focusTalent();
			shadowStalker.cardName = "Shadow Stalker";
			shadowStalker.cardText = "Add 1 fortune die to Stealth checks";

			focusTalent deductiveReasoning = new focusTalent();
			deductiveReasoning.cardName = "Deductive Reasoning";
			deductiveReasoning.cardText = "Itelligence checks gain a Boon tot hte results pool if at least 3 Success are generated";

			focusTalent quickWits = new focusTalent();
			quickWits.cardName = "Quick Wits";
			quickWits.cardText = "Exhauset this card to remove 2 recharge tokens from one of your currently recharing cards";

			focusTalent keenEyes = new focusTalent();
			keenEyes.cardName = "Keen Eyes";
			keenEyes.cardText = "Gain 1 fortune die to Observation checks where vision is relevant";

			focusTalent jackOfAllTrades = new focusTalent();
			jackOfAllTrades.cardName = "Jack of All Trades";
			jackOfAllTrades.cardText = "You may suffer one stress to add 1 fortune dice to any skill check";

			focusTalent skygazer = new focusTalent();
			skygazer.cardName = "Skygazer";
			skygazer.cardText = "Your Intelligence checks gain 1 fortune die so long as you are under the sky";

			focusTalent creativeThinking = new focusTalent();
			creativeThinking.cardName = "Creative Thinking";
			creativeThinking.cardText = "Exhaust this tallent to choose and equip a new tallent that you possess of any" +
				"type in this slot; that talent remains equipped untill Creative Thinking Recharges";

			focusTalent aethyricConduit = new focusTalent();
			aethyricConduit.cardName = "Aethyric Conduit";
			aethyricConduit.cardText = "When you recover or lose power during your end of turn tep due to not geing" +
				"at equuilibrium, you recover or lose 1 additinal power (unless this would take you past equilibrium)";

			focusTalent forsight = new focusTalent();
			forsight.cardName = "Forsight";
			forsight.cardText = "Your Initative checks gain: \r\n" +
				"Boon: Add one sucess to the results pool";
			
			}
	}
}

