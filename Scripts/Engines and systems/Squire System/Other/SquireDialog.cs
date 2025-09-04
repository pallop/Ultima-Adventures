using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;
using Server.Gumps;
using Server.Misc;
using Server.SkillHandlers;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Server.Targeting;
using Server.ContextMenus;
using Server.HuePickers;
using Server.Prompts;
using Server.Custom;

namespace Server.Mobiles
{
	public enum SquireDialogTree
	{
		HideFailure,
		TooSoonToHide,
		MissingInstrument,
		TooSoonToPlayMusic,
		MissingSnow,
		TooSoonToPackSnow,
		MasterHasANewNickname,
		SquireHasANewNickname,
		SquireHealsMaster,
		SquireCuresMaster,
		SquireRezsMaster,
		ASquiresConcern,
		ASquiresStay,
		SquiresNewName,
		ShowingOffASquiresBackpack,
		SquireCantReach,
		SquireCantLiftNotItem,
		SquireCantLiftItem,
		SquireCantLiftCorpse,
		ItemIsNotCorpse,
		SquireCantLootAllItems,
		SquireCantLootNotCorpse,
		SquireHealsWounded,
		SquireCuresHumanoid,
		SquireCuresAnimal,
		SquireRezsHumanoid,
		SquireRezsAnimal,
		SquireCantRez,
		WoundedIsNotHurtEnough,
		WoundedOutOfRange,
		WoundedInvisible,
		SquireHealsPlayer,
		SquireCuresPlayer,
		SquireRezsPlayer,
		SquireCantRezPlayer,
		WoundedPlayerIsNotHurtEnough,
		WoundedPlayerOutOfRange,
		HealingTargetNotCreature,
		BeginProvoking,
		WheredMyInstrumentGo,
		LoyalToTheirMaster,
		CantDiscord,
		CantCalm,
		CantCalmHere,
		CantCalmThere,
		AlreadyDiscord,
		AlreadyCalmed,
		NoChanceToProvoke,
		NoChanceToCalm,
		CantProvokeOne,
		CantInciteAnger,
		TooFarApartToProvoke,
		BadPerformance,
		FailedPerformanceProvoke,
		FailedPerformanceDiscord,
		GoodPerformanceProvoke,
		GoodPerformanceDiscord,
		GoodPerformancePeace,
		ProvokeOnThemselves,
		PeaceNobody,
		ThisIsTooHeavy,
		TooHeavyForNow,
		ThankYou,
		ToldToShutUp,
		CanTalkAgain,
		NoPotions,
		TooSoonToDrink,
		AgilityPotion,
		PoisonPotion,
		RefreshPotion,
		StrengthPotion,
		HealthPotion,
		CantHealthPotion,
		StillPoisoned,
		MortallyWoundedHP,
		CurePotion,
		CantCurePotion,
		UsePowerScroll,
		CantUsePowerScroll,
		MissingLockpicks,
		LockpickTooFar,
		NotLocked,
		CannotUnlock,
		BrokenLockpick,
		AbnormalLock,
		HardLock,
		UnsuccessfulLockpick,
		SuccessfulLockpick,
		HandsAreFull,
		StealingNotAllowedHere,
		NotAPartOfThievesGuild,
		SuspendedFromThievesGuild,
		CannotStealFromVendors,
		CannotSeeStealingTarget,
		FullBackpackStealing,
		NeedToBeCloserToSteal,
		CannotStealThat,
		CannotStealWhileMorphed,
		NotSkilledEnoughToStealItem,
		CannotStealFromTheirHands,
		StealFromSelf,
		TooHeavyToSteal,
		SuccessfulSteal,
		UnsuccessfulSteal,
		TooSoonToLockpick,
		TooSoonToSteal,
		WhatShouldISteal,
		LearnsFromContract,
		RefusesToLootPlayers, 
		UnequipsTwoHandedForShield, 
		FirstHandMissing, 
		SecondHandMissing, 
		EmptyHands, 
		SuccessfulSetCreation, 
		Unarmed,
		SpiritSpeakSuccess, 
		SpiritSpeakFail, 
		TooSoonToSpiritSpeak, 
		SpiritChannelFades, 
		StillConnectedToSpirits,
		OpenQuiver,
		NotAQuiver,
		PoisonToApply,
		ApplyPoisonTo,
		NotAPoisonPotion,
		TooFarToPoison,
		CannotPoisonNotInfectious,
		CannotPoisonNotBPFoD,
		PoisoningSuccess,
		PoisoningFailure,
		TerribleMistake,
		NoAnkhNearby,
		TitheSuccess,
		NoGoldToTithe,
		NotEnoughTithe,
		NotEnoughMana,
		NoChivalryBook,
		TooSoonToMeditate,
		TooSoonToCastASpell,
		NotEnoughSpellSkill,
		NoExplosionPotion,
		SquireHasANewTeam, // Added 1.9.7
		NoBushidoBook,
		NoNecroBook,
	}
	
	public class SquireDialog
	{
		private SquireDialogTree m_Dialog;
		
		public static void DoSquireDialog( Mobile master, Squire squire, SquireDialogTree dialog, BaseCreature creature, PlayerMobile player )
		{
			if (SquireDialogData.Dialogs.ContainsKey(dialog))
			{
				List<string> lines = SquireDialogData.Dialogs[dialog];
				if (lines == null || lines.Count == 0) return;

				string line = lines[Utility.Random(lines.Count)];

				// Handle placeholders
				if (squire != null)
				{
					line = line.Replace("{master_nickname}", squire.m_MasterNickname);
					line = line.Replace("{master_nickname_upper}", squire.m_MasterNickname.ToUpper());
					line = line.Replace("{squire_nickname}", squire.m_SquireNickname);
					line = line.Replace("{squire_nickname_upper}", squire.m_SquireNickname.ToUpper());
					line = line.Replace("{squire_name}", squire.Name);
					line = line.Replace("{squire_team}", squire.m_SquireTeam);
					line = line.Replace("{squire_team_upper}", squire.m_SquireTeam.ToUpper());
				}
				if (creature != null)
					line = line.Replace("{creature_name}", creature.Name);
				if (player != null)
					line = line.Replace("{player_name}", player.Name);

				// Say or Emote
				if (line.StartsWith("*") && line.EndsWith("*"))
				{
					squire.Emote(Translator.Translate(line));
				}
				else
				{
					squire.Say(Translator.Translate(line));
				}
			}
		}
	}
}