//
// classes.cs
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
	public class classes
	{
		string className;
		int stanceRed;
		int stanceGreen;
		string carrerSkills;
		string primaryChar;
		string[] talentSlots = new string[3];

		public classes()
		{
			

			classes agent = new classes();
			agent.className = "Agent";
			agent.carrerSkills = "Charm, Education, Folklore, Guile, Intution";
			agent.stanceRed = 2;
			agent.stanceGreen = 2;
			agent.primaryChar = "Intelligence, Felloship";
			agent.talentSlots = new string[] {"FocusTalent","ReputationTalent"};

			classes agitator = new classes();
			agitator.className = "Agitator";
			agitator.carrerSkills = "Charm, Guile, Intution, Leadership, Observation";
			agitator.stanceRed = 2;
			agitator.stanceGreen = 2;
			agitator.primaryChar = "Intelligence, Fellowship";
			agitator.talentSlots = new string[] {"ReputationTalent","ReputationTalent"};

			classes apprenticeWizard = new classes();
			apprenticeWizard.className = "Apprentice Wizard";
			apprenticeWizard.carrerSkills = "Channeling, Discipline, Education, Intution, Magical Sight, Observation, Spellcraft";
			apprenticeWizard.primaryChar = "Intelligence, Willpower";
			apprenticeWizard.talentSlots = new string[] {"FocusTalent","OrderTalent"};

			classes apothecary = new classes();
			apothecary.className = "Apothecary";
			apothecary.carrerSkills = "Folklore, First Aid, Intution, Nature Lore, Observation";
			apothecary.stanceRed = 1;
			apothecary.stanceGreen = 3;
			apothecary.primaryChar = "Intelligence, Toughness";
			apothecary.talentSlots = new string[] {"FocusTalent", "FocusTalent"};


			classes barberSurgeon = new classes();
			barberSurgeon.className = "Barber-Surgeon";
			barberSurgeon.carrerSkills = "Charm, Discipline, First Aid, Folklore, Leadership";
			barberSurgeon.stanceRed = 1;
			barberSurgeon.stanceGreen = 3;
			barberSurgeon.primaryChar = "Intelligence, Fellowship";
			barberSurgeon.talentSlots = new string[] {"FocusTalent","ReputationTalent"};

			classes boatman = new classes();
			boatman.className = "Boatman";
			boatman.carrerSkills = "Athletics, Coordination, Nature Lore, Observation, Resilience";
			boatman.stanceRed = 3;
			boatman.stanceGreen = 1;
			boatman.primaryChar = "Strenght, Agility";
			boatman.talentSlots= new string[] {"FocusTalent","TacticTalent"};

			classes burgher = new classes();
			burgher.className = "Burgher";
			burgher.carrerSkills = "Charm, Discipline, Education, Folklore, Tradecraft";
			burgher.stanceRed = 1;
			burgher.stanceGreen = 3;
			burgher.primaryChar = "Intelligence, Fellowship";
			burgher.talentSlots = new string[] {"ReputationTalent","ReputationTalent"};

			classes charlatan = new classes();
			charlatan.className = "Charlatan";
			charlatan.carrerSkills = "Charm, Discipline, Guile, Leadership, Stealth";
			charlatan.stanceRed = 2;
			charlatan.stanceGreen = 2;
			charlatan.primaryChar = "Willpower, Fellowship";
			charlatan.talentSlots = new string[] {"ReputationTalent","ReputationTalent","FocusTalent"};

			classes coachman = new classes();
			coachman.className = "Coachman";
			coachman.carrerSkills = "Animal Handling, Ballistic Skill, Coordination, Resilience, Ride";
			coachman.stanceRed = 2;
			coachman.stanceGreen = 2;
			coachman.primaryChar = "Toughness, Agility";
			coachman.talentSlots = new string [] {"ReputationTalent","TacticTalent"};

			classes commoner = new classes();
			commoner.className = "Commoner";
			commoner.carrerSkills = "Animal Handling, Athletics, Folklore, Nature Lore, Resilience";
			commoner.stanceRed = 1;
			commoner.stanceGreen = 3;
			commoner.primaryChar = "Toughness, Willpower";
			commoner.talentSlots = new string[] {"FocusTalent","ReputationTalent"};

			classes dilettante = new classes(); 
			dilettante.className = "Dilettante";
			dilettante.carrerSkills = "Charm, Education, Folklore, Guile, Ride";
			dilettante.stanceRed = 2;
			dilettante.stanceGreen = 2;
			dilettante.primaryChar = "Intelligence, Fellowship";
			dilettante.talentSlots = new string[] {"FocusTalent","ReputtionTalent"};

			classes disciple = new classes();
			disciple.className = "Disciple";
			disciple.carrerSkills = "Charm, Education, First Aid, Intution, Invocation, Piety";
			disciple.primaryChar = "Willpower, Fellowship";
			disciple.talentSlots = new string[] {"FaithTalent","FocusTalent"};

			classes envoy = new classes(); 
			envoy.className = "Envoy";
			envoy.carrerSkills = "Charm, Folklore, Intution, Leadership, Observation";
			envoy.stanceRed = 1;
			envoy.stanceGreen = 3;
			envoy.primaryChar = "Intelligence ,Fellowship";
			envoy.talentSlots = new string[] {"ReputationTalent","Reputationtalent"};















			
		}
	}
}

