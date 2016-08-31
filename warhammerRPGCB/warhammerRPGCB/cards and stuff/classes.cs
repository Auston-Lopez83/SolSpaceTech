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
			agent.carrerSkills = "Charm, Education, Folklore, Guile, Intuition";
			agent.stanceRed = 2;
			agent.stanceGreen = 2;
			agent.primaryChar = "Intelligence, Felloship";
			agent.talentSlots = new string[] {"focusTalent","reputationTalent"};

			classes agitator = new classes();
			agitator.className = "Agitator";
			agitator.carrerSkills = "Charm, Guile, Intuition, Leadership, Observation";
			agitator.stanceRed = 2;
			agitator.stanceGreen = 2;
			agitator.primaryChar = "Intelligence, Fellowship";
			agitator.talentSlots = new string[] {"reputationTalent","reputationTalent"};

			classes apprenticeWizard = new classes();
			apprenticeWizard.className = "Apprentice Wizard";
			apprenticeWizard.carrerSkills = "Channeling, Discipline, Education, Intuition, Magical Sight, Observation, Spellcraft";
			apprenticeWizard.primaryChar = "Intelligence, Willpower";
			apprenticeWizard.talentSlots = new string[] {"focusTalent","orderTalent"};

			classes apothecary = new classes();
			apothecary.className = "Apothecary";
			apothecary.carrerSkills = "Folklore, First Aid, Intuition, Nature Lore, Observation";
			apothecary.stanceRed = 1;
			apothecary.stanceGreen = 3;
			apothecary.primaryChar = "Intelligence, Toughness";
			apothecary.talentSlots = new string[] {"focusTalent", "focusTalent"};


			classes barberSurgeon = new classes();
			barberSurgeon.className = "Barber-Surgeon";
			barberSurgeon.carrerSkills = "Charm, Discipline, First Aid, Folklore, Leadership";
			barberSurgeon.stanceRed = 1;
			barberSurgeon.stanceGreen = 3;
			barberSurgeon.primaryChar = "Intelligence, Fellowship";
			barberSurgeon.talentSlots = new string[] {"focusTalent","reputationTalent"};

			classes boatman = new classes();
			boatman.className = "Boatman";
			boatman.carrerSkills = "Athletics, Coordination, Nature Lore, Observation, Resilience";
			boatman.stanceRed = 3;
			boatman.stanceGreen = 1;
			boatman.primaryChar = "Strenght, Agility";
			boatman.talentSlots= new string[] {"focusTalent","tacticTalent"};

			classes burgher = new classes();
			burgher.className = "Burgher";
			burgher.carrerSkills = "Charm, Discipline, Education, Folklore, Tradecraft";
			burgher.stanceRed = 1;
			burgher.stanceGreen = 3;
			burgher.primaryChar = "Intelligence, Fellowship";
			burgher.talentSlots = new string[] {"reputationTalent","reputationTalent"};

			classes charlatan = new classes();
			charlatan.className = "Charlatan";
			charlatan.carrerSkills = "Charm, Discipline, Guile, Leadership, Stealth";
			charlatan.stanceRed = 2;
			charlatan.stanceGreen = 2;
			charlatan.primaryChar = "Willpower, Fellowship";
			charlatan.talentSlots = new string[] {"reputationTalent","reputationTalent","focusTalent"};

			classes coachman = new classes();
			coachman.className = "Coachman";
			coachman.carrerSkills = "Animal Handling, Ballistic Skill, Coordination, Resilience, Ride";
			coachman.stanceRed = 2;
			coachman.stanceGreen = 2;
			coachman.primaryChar = "Toughness, Agility";
			coachman.talentSlots = new string [] {"reputationTalent","tacticTalent"};

			classes commoner = new classes();
			commoner.className = "Commoner";
			commoner.carrerSkills = "Animal Handling, Athletics, Folklore, Nature Lore, Resilience";
			commoner.stanceRed = 1;
			commoner.stanceGreen = 3;
			commoner.primaryChar = "Toughness, Willpower";
			commoner.talentSlots = new string[] {"focusTalent","reputationTalent"};

			classes dilettante = new classes(); 
			dilettante.className = "Dilettante";
			dilettante.carrerSkills = "Charm, Education, Folklore, Guile, Ride";
			dilettante.stanceRed = 2;
			dilettante.stanceGreen = 2;
			dilettante.primaryChar = "Intelligence, Fellowship";
			dilettante.talentSlots = new string[] {"focusTalent","reputationTalent"};

			classes disciple = new classes();
			disciple.className = "Disciple";
			disciple.carrerSkills = "Charm, Education, First Aid, Intuition, Invocation, Piety";
			disciple.primaryChar = "Willpower, Fellowship";
			disciple.talentSlots = new string[] {"faithTalent","focusTalent"};

			classes envoy = new classes(); 
			envoy.className = "Envoy";
			envoy.carrerSkills = "Charm, Folklore, Intutition, Leadership, Observation";
			envoy.stanceRed = 1;
			envoy.stanceGreen = 3;
			envoy.primaryChar = "Intelligence ,Fellowship";
			envoy.talentSlots = new string[] {"reputationTalent","reputationTalent"};

			classes flagellant = new classes();
			flagellant.className = "Flagellant";
			flagellant.carrerSkills = "Discipline, Intimidation, Piety, resilience, Weapon Skill";
			flagellant.stanceRed = 3;
			flagellant.stanceGreen = 1;
			flagellant.primaryChar = "Strength, Toughness";
			flagellant.talentSlots = new string[] {"focusTalent","reputationTalent","insanity"};

			classes forger = new classes();
			forger.className = "Forger";
			forger.carrerSkills = "Coordination, Guile, Intuition, Observation, Skulduggery";
			forger.stanceRed = 2;
			forger.stanceGreen = 2;
			forger.primaryChar = "Agility, Intelligence";
			forger.talentSlots = new string[] {"focusTalent","focusTalent"};

			classes graveRobber = new classes();
			graveRobber.className = "Grave Rober";
			graveRobber.carrerSkills = "Coordination, Discipline, Guile, Resilence, Stealth";
			graveRobber.stanceRed = 2;
			graveRobber.stanceGreen = 2;
			graveRobber.primaryChar = "Toughness, Willpower";
			graveRobber.talentSlots = new string[] {"focusTalent","reputationTalent"};

			classes gambler = new classes();
			gambler.className = "Gambler";
			gambler.carrerSkills = "Guile, Intuition, Observation, Skulduggery, Stealth";
			gambler.stanceRed = 3;
			gambler.stanceGreen = 1;
			gambler.primaryChar = "Agility, Felowship";
			gambler.talentSlots = new string[] {"focusTalent","reputationTalent"};

			classes giantSlayer = new classes();
			giantSlayer.className = "Giant Slayer";
			giantSlayer.carrerSkills = "Athletics, Intimidate, Resilience, Weapon Skill";
			giantSlayer.stanceRed = 3;
			giantSlayer.stanceGreen = 1;
			giantSlayer.primaryChar = "Strength, Toughness";
			giantSlayer.talentSlots = new string[] {"tacticTalent","tacticTalent"};

			classes hunter = new classes();
			hunter.className = "Hunter";
			hunter.carrerSkills = "Athletics, Ballistic Skill, Nature Lore, Observation, Stealth";
			hunter.stanceRed = 2;
			hunter.stanceGreen = 2;
			hunter.primaryChar = "Toughness, Agility";
			hunter.talentSlots = new string[] {"focusTalent","tacticTalent"};

			classes initiate = new classes();
			initiate.className = "Initiate";
			initiate.carrerSkills = "Charm, Education, First Aid, Intuition, Piety";
			initiate.primaryChar = "Willpower, Fellowship";
			initiate.talentSlots = new string[] {"faithTalent","focusTalent"};

			classes merchant = new classes();
			merchant.className = "Mearchant";
			merchant.carrerSkills = "Discipline, Folklore, Guile, Intuition, Tradecraft";
			merchant.stanceRed = 2;
			merchant.stanceGreen = 2;
			merchant.primaryChar = "Intelligence, Fellowship";
			merchant.talentSlots = new string[] {"reputationTalent","reputationTalent","reputationTalent"};

			classes mercenary = new classes();
			mercenary.className = "Mercenary";
			mercenary.carrerSkills = "Athletics, Bellistic Skill, Guile, Ride, Weapon Skill";
			mercenary.stanceRed = 2;
			mercenary.stanceGreen =2;
			mercenary.primaryChar = "Strength, Willpower";
			mercenary.talentSlots = new string[] {"focusTalent","tacticTalent"};

			classes messenger = new classes();
			messenger.className = "Messenger";
			messenger.carrerSkills = "Charm, Folklore, Intuition, Ride, Stealth";
			messenger.stanceRed = 1;
			messenger.stanceGreen = 3;
			messenger.primaryChar = "Agility, Fellowship";
			messenger.talentSlots = new string[] {"focusTalent","reputationTalent"};

			classes navigator = new classes();
			navigator.className = "Navigator";
			navigator.carrerSkills = "Athletics, Intuition, Observation, Resilience, Ride";
			navigator.stanceRed = 2;
			navigator.stanceGreen = 2;
			navigator.primaryChar = "Toughness, Intelligence";
			navigator.talentSlots = new string[] {"focusTalent","focusTalent"};

			classes physician = new classes();
			physician.className = "Physician";
			physician.carrerSkills = "Discipline, Education, First Aid, Intuition, Medicine, Observation";
			physician.stanceRed = 1;
			physician.stanceGreen = 3;
			physician.primaryChar = "Intelligence, Willpower";
			physician.talentSlots = new string[] {"focusTalent","focusTalent","focusTalent"};

			classes roadwarden = new classes();
			roadwarden.className = "Roadwarden";
			roadwarden.carrerSkills = "Folklore, Intuition, Observation, Ride, Weapon Skill";
			roadwarden.stanceRed = 2;
			roadwarden.stanceGreen =2;
			roadwarden.primaryChar = "Toughness, Intelligence";
			roadwarden.talentSlots = new string[] {"reputationTalent","tacticTalent"};

			classes scout = new classes();
			scout.className = "Scout";
			scout.carrerSkills = "Ballistic Skill, Nature Lore, Observation, Rice, Stealth";
			scout.stanceRed = 1;
			scout.stanceGreen = 3;
			scout.primaryChar = "Agility, Intelligence";
			scout.talentSlots = new string [] {"focusTalent","tacticTalent"};

			classes scholar = new classes();
			scholar.className = "SCholar";
			scholar.carrerSkills = "Discipline, Education, Folklore, Nature Lore, Tradecraft";
			scholar.stanceRed =1;
			scholar.stanceGreen =3;
			scholar.primaryChar = "Intelligence, Willpower";
			scholar.talentSlots = new string[] {"focusTalent","focusTalent","reputationTalent"};

			classes servant = new classes();
			servant.className = "Servant";
			servant.carrerSkills = "Athletics, Coordination, Folklore, Intuition, Resilience";
			servant.stanceRed = 2;
			servant.stanceGreen = 2;
			servant.primaryChar = "Toughness, Willpower";
			servant.talentSlots = new string [] {"focusTalent","reputationTalent"};

			classes soldier = new classes();
			soldier.className = "Soldier";
			soldier.carrerSkills = "Ballistic Skill, Discipline, Leadership, Ride, Weapon Skill";
			soldier.stanceRed =2;
			soldier.stanceGreen = 2;
			soldier.primaryChar = "Toughness, Willpower";
			soldier.talentSlots = new string[] {"reputationTalent","tacticTalent"};

			classes student = new classes();
			student.className = "Student";
			student.carrerSkills = "Discipline, Education, Folklore, Nature Lore, Observation";
			student.stanceRed = 1;
			student.stanceGreen = 3;
			student.primaryChar = "Intelligence, Felowship";
			student.talentSlots = new string[] {"focusTalent","focusTalent"};

			classes theif = new classes();
			theif.className = "Theif";
			theif.carrerSkills  = "Coordination ,Discipline, Guile, Skullduggery, Stealth";
			theif.stanceRed = 3;
			theif.stanceGreen = 1;
			theif.primaryChar = "Agility, Fellowship";
			theif.talentSlots = new string [] {"focusTalent","reputationTalent"};
			classes thug = new classes();
			thug.className = "Thug";
			thug.carrerSkills = "Athletics, Guile, Intimidation, Skullduggery, Weapon Skill";
			thug.stanceRed = 3;
			thug.stanceGreen = 1;
			thug.primaryChar = "Strength, Agility";
			thug.talentSlots = new string[] {"tacticTalent","tacticTalent"};

			classes trollSlayer = new classes();
			trollSlayer.className = "Troll Slayer";
			trollSlayer.carrerSkills = "Athletics, Intimidate, Resilence, Weapon Skill";
			trollSlayer.stanceRed = 3;
			trollSlayer.stanceGreen = 1;
			trollSlayer.primaryChar = "Strength, Toughness";
			trollSlayer.talentSlots = new string [] {"tacticTalent","tacticTalent"};

			classes warlock = new classes();
			warlock.className = "Warlock";
			warlock.carrerSkills = "Channeling, Folklore, Intuition, Magical Sight, Resilence, Spellcraft";
			warlock.stanceRed = 3;
			warlock.stanceGreen =1;
			warlock.primaryChar = "Toughness, Willpower";
			warlock.talentSlots = new string [] {"focusTalent","WitchcraftTalent","WitchcraftTalent"};

			classes witch = new classes();
			witch.className = "Witch";
			witch.carrerSkills = "Guile, Folklore, Intuition, Resilience, Spellcraft";
			witch.stanceRed = 2;
			witch.stanceGreen = 2;
			witch.primaryChar = "Fellowship, Willpower";
			witch.talentSlots = new string[] {"WitchcraftTalent","focusTalent"};

			classes wizard = new classes();
			wizard.className = "Wizard";
			wizard.carrerSkills = "Channelling, Discipline, Education, Intuition, Magical Sight, Observaion, Spellcraft";
			wizard.primaryChar = "Intelligence, Willpower";
			wizard.talentSlots = new string[] {"focusTalnet","focusTalent","orderTalent"};

			classes waywatcher= new classes();
			waywatcher.className = "Waywatcher";
			waywatcher.carrerSkills = "Athelitcs, Ballistic Skill, Coorcination, Nature Lore, Stealth";
			waywatcher.stanceRed = 2;
			waywatcher.stanceGreen = 2;
			waywatcher.primaryChar = "agility, Willpower";
			waywatcher.talentSlots = new string[] {"focusTalent","tacticTalent"}
;
			classes witchHunter = new classes();
			witchHunter.className = "Witch Hunter";
			witchHunter.carrerSkills = "Ballistic Skill. Folklore, Intuition, Piety, Stealth";
			witchHunter.stanceRed = 3;
			witchHunter.stanceGreen = 1;
			witchHunter.primaryChar = "Agility, Intelligence";
			witchHunter.talentSlots = new string[] {"reputationTalent","tacticTalent"};

			classes watchman = new classes();
			watchman.className = "Watchman";
			watchman.carrerSkills = "Discipline, Intuition, Leadership, Observation, Resilience";
			watchman.stanceRed = 2;
			watchman.stanceGreen = 2;
			watchman.primaryChar = "Toughness. Fellowship";
			watchman.talentSlots = new string[] {"reputationTalent","tacticTalent"};

			classes zealot = new classes();
			zealot.className = "Zealot";
			zealot.carrerSkills = "Athletics, Descipline, Intimidate, Piety, Resilience";
			zealot.stanceRed = 3;
			zealot.stanceGreen = 1;
			zealot.primaryChar = "Toughnes, Willpower";
			zealot.talentSlots = new string[] {"focusTalent","insanity"};


		}
	}
}

