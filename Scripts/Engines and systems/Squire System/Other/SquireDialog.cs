using System;
using Server.Mobiles;
using System.Collections.Generic;

using System.Collections.Generic;

namespace Server.Mobiles
{
	public class SquireDialog
	{
		public static Dictionary<SquireDialogTree, List<string>> TranslatedDialogs = new Dictionary<SquireDialogTree, List<string>>();
		
		private static void SayRandom(Squire squire, SquireDialogTree dialog, Mobile master, BaseCreature creature, PlayerMobile player)
		{
			List<string> lines = null;

			if (TranslatedDialogs.ContainsKey(dialog) && TranslatedDialogs[dialog].Count > 0)
			{
				lines = TranslatedDialogs[dialog];
			}
			else if (SquireDialogData.Dialogs.ContainsKey(dialog))
			{
				lines = SquireDialogData.Dialogs[dialog];
			}

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
			if (master != null)
			{
				line = line.Replace("{master_name}", master.Name);
			}
			if (creature != null)
				line = line.Replace("{creature_name}", creature.Name);
			if (player != null)
				line = line.Replace("{player_name}", player.Name);

			// Say or Emote
			if (line.StartsWith("*") && line.EndsWith("*"))
			{
				squire.Emote(line);
			}
			else
			{
				squire.Say(line);
			}
		}

		public static void DoSquireDialog( Mobile master, Squire squire, SquireDialogTree dialog, BaseCreature creature, PlayerMobile player )
		{
            switch (dialog)
            {
                // General
                case SquireDialogTree.HideFailure: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooSoonToHide: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.MissingInstrument: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooSoonToPlayMusic: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.MissingSnow: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooSoonToPackSnow: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.MasterHasANewNickname: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireHasANewNickname: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireHealsMaster: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCuresMaster: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireRezsMaster: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.ASquiresConcern: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.ASquiresStay: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquiresNewName: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.ShowingOffASquiresBackpack: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCantReach: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCantLiftNotItem: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCantLiftItem: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCantLiftCorpse: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.ItemIsNotCorpse: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCantLootAllItems: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCantLootNotCorpse: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireHealsWounded: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCuresHumanoid: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCuresAnimal: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireRezsHumanoid: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireRezsAnimal: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCantRez: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.WoundedIsNotHurtEnough: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.WoundedOutOfRange: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.WoundedInvisible: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireHealsPlayer: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCuresPlayer: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireRezsPlayer: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireCantRezPlayer: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.WoundedPlayerIsNotHurtEnough: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.WoundedPlayerOutOfRange: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.HealingTargetNotCreature: SayRandom(squire, dialog, master, creature, player); break;

                // Bard
                case SquireDialogTree.BeginProvoking: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.WheredMyInstrumentGo: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.LoyalToTheirMaster: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CantDiscord: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CantCalm: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CantCalmHere: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CantCalmThere: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.AlreadyDiscord: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.AlreadyCalmed: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NoChanceToProvoke: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NoChanceToCalm: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CantProvokeOne: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CantInciteAnger: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooFarApartToProvoke: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.BadPerformance: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.FailedPerformanceProvoke: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.FailedPerformanceDiscord: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.GoodPerformanceProvoke: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.GoodPerformanceDiscord: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.GoodPerformancePeace: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.ProvokeOnThemselves: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.PeaceNobody: SayRandom(squire, dialog, master, creature, player); break;

                // Misc
                case SquireDialogTree.ThisIsTooHeavy: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooHeavyForNow: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.ThankYou: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.ToldToShutUp: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CanTalkAgain: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NoPotions: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooSoonToDrink: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.AgilityPotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.PoisonPotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.RefreshPotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.StrengthPotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.HealthPotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CantHealthPotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.StillPoisoned: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.MortallyWoundedHP: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CurePotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CantCurePotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.UsePowerScroll: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CantUsePowerScroll: SayRandom(squire, dialog, master, creature, player); break;

                // Thief
                case SquireDialogTree.MissingLockpicks: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.LockpickTooFar: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NotLocked: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CannotUnlock: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.BrokenLockpick: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.AbnormalLock: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.HardLock: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.UnsuccessfulLockpick: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SuccessfulLockpick: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.HandsAreFull: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.StealingNotAllowedHere: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NotAPartOfThievesGuild: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SuspendedFromThievesGuild: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CannotStealFromVendors: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CannotSeeStealingTarget: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.FullBackpackStealing: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NeedToBeCloserToSteal: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CannotStealThat: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CannotStealWhileMorphed: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NotSkilledEnoughToStealItem: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CannotStealFromTheirHands: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.StealFromSelf: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooHeavyToSteal: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SuccessfulSteal: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.UnsuccessfulSteal: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooSoonToLockpick: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooSoonToSteal: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.WhatShouldISteal: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.LearnsFromContract: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.RefusesToLootPlayers: SayRandom(squire, dialog, master, creature, player); break;

                // Equipment
                case SquireDialogTree.UnequipsTwoHandedForShield: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.FirstHandMissing: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SecondHandMissing: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.EmptyHands: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SuccessfulSetCreation: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.Unarmed: SayRandom(squire, dialog, master, creature, player); break;

                // Magery
                case SquireDialogTree.SpiritSpeakSuccess: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SpiritSpeakFail: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooSoonToSpiritSpeak: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SpiritChannelFades: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.StillConnectedToSpirits: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.OpenQuiver: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NotAQuiver: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.PoisonToApply: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.ApplyPoisonTo: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NotAPoisonPotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooFarToPoison: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CannotPoisonNotInfectious: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.CannotPoisonNotBPFoD: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.PoisoningSuccess: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.PoisoningFailure: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TerribleMistake: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NoAnkhNearby: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TitheSuccess: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NoGoldToTithe: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NotEnoughTithe: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NotEnoughMana: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NoChivalryBook: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooSoonToMeditate: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.TooSoonToCastASpell: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NotEnoughSpellSkill: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NoExplosionPotion: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.SquireHasANewTeam: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NoBushidoBook: SayRandom(squire, dialog, master, creature, player); break;
                case SquireDialogTree.NoNecroBook: SayRandom(squire, dialog, master, creature, player); break;
            }
		}
	}
}