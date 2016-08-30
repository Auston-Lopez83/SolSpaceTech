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
	public class FocusTalent
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



		public FocusTalent()
		{
			FocusTalent iveSeenWorse = new FocusTalent();
			iveSeenWorse.cardName = "I've Seen Worse...";
			iveSeenWorse.cardText = "Exhaust this card to add 2 fortune dice to any Willpower check";

			FocusTalent clearMinded = new FocusTalent();
			clearMinded.cardName = "Clear Minded";
			clearMinded.cardText = "Actions using Willpower checks gains:\r\n" +
				" Boon: Recover 1 stress";

			FocusTalent clever =new FocusTalent();
			clever.cardName = "Clever";
			clever.cardText = "When spendinf a fortune point on an Intelligence check, the check gains:\r\n" +
				"2 Boons Add a Success to the result";

			FocusTalent determined = new FocusTalent();
			determined.cardName = "Determinded";
			determined.cardText = "When spending fortune points on a Willpower check, the check gains:\r\n" +
				"2 Boon Add a Success to the result";

			FocusTalent iSeemToRecall = new FocusTalent();
			iSeemToRecall.cardName = "I Seem to Recall...";
			iSeemToRecall.cardText = "Exhaust this card to add 2 fortune dice to any Intelligence check";

			FocusTalent contemplative = new FocusTalent();
			contemplative.cardName = "Contemplative";
			contemplative.cardText = "If you are in a concervative stance, you may spend 1 fortune point to convert " +
				"one more characteristic die into a convervative die then your stance" +
				"would normally alow";

			FocusTalent resolute = new FocusTalent();
			resolute.cardName = "Resolute";
			resolute.cardText = "Exhause this card to recover 2 stress";

			FocusTalent instinctive = new FocusTalent();
			instinctive.cardName = "Instinctive";
			instinctive.cardText = "Add 1 fortune die to Intution checks";

			FocusTalent shadowStalker = new FocusTalent();
			shadowStalker.cardName = "Shadow Stalker";
			shadowStalker.cardText = "Add 1 fortune die to Stealth checks";

			FocusTalent deductiveReasoning = new FocusTalent();
			deductiveReasoning.cardName = "Deductive Reasoning";
			deductiveReasoning.cardText = "Itelligence checks gain a Boon tot hte results pool if at least 3 Success are generated";

			FocusTalent quickWits = new FocusTalent();
			quickWits.cardName = "Quick Wits";
			quickWits.cardText = "Exhauset this card to remove 2 recharge tokens from one of your currently recharing cards";

			FocusTalent keenEyes = new FocusTalent();
			keenEyes.cardName = "Keen Eyes";
			keenEyes.cardText = "Gain 1 fortune die to Observation checks where vision is relevant";

			FocusTalent jackOfAllTrades = new FocusTalent();
			jackOfAllTrades.cardName = "Jack of All Trades";
			jackOfAllTrades.cardText = "You may suffer one stress to add 1 fortune dice to any skill check";

			FocusTalent skygazer = new FocusTalent();
			skygazer.cardName = "Skygazer";
			skygazer.cardText = "Your Intelligence checks gain 1 fortune die so long as you are under the sky";

			FocusTalent creativeThinking = new FocusTalent();
			creativeThinking.cardName = "Creative Thinking";
			creativeThinking.cardText = "Exhaust this tallent to choose and equip a new tallent that you possess of any" +
				"type in this slot; that talent remains equipped untill Creative Thinking Recharges";

			FocusTalent aethyricConduit = new FocusTalent();
			aethyricConduit.cardName = "Aethyric Conduit";
			aethyricConduit.cardText = "When you recover or lose power during your end of turn tep due to not geing" +
				"at equuilibrium, you recover or lose 1 additinal power (unless this would take you past equilibrium)";

			FocusTalent forsight = new FocusTalent();
			forsight.cardName = "Forsight";
			forsight.cardText = "Your Initative checks gain: \r\n" +
				"Boon: Add one sucess to the results pool";
			
			}
	}
}

