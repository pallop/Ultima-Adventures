using System;
using System.Collections.Generic;

namespace Server.Mobiles
{
    public static class SquireDialogData
    {
        public enum SquireDialogTree
        {
            HideFailure, TooSoonToHide, MissingInstrument, TooSoonToPlayMusic, MissingSnow, TooSoonToPackSnow,
            MasterHasANewNickname, SquireHasANewNickname, SquireHealsMaster, SquireCuresMaster, SquireRezsMaster,
            ASquiresConcern, ASquiresStay, SquiresNewName, ShowingOffASquiresBackpack, SquireCantReach,
            SquireCantLiftNotItem, SquireCantLiftItem, SquireCantLiftCorpse, ItemIsNotCorpse,
            SquireCantLootAllItems, SquireCantLootNotCorpse, SquireHealsWounded, SquireCuresHumanoid,
            SquireCuresAnimal, SquireRezsHumanoid, SquireRezsAnimal, SquireCantRez, WoundedIsNotHurtEnough,
            WoundedOutOfRange, WoundedInvisible, SquireHealsPlayer, SquireCuresPlayer, SquireRezsPlayer,
            SquireCantRezPlayer, WoundedPlayerIsNotHurtEnough, WoundedPlayerOutOfRange, HealingTargetNotCreature,
            BeginProvoking, WheredMyInstrumentGo, LoyalToTheirMaster, CantDiscord, CantCalm, CantCalmHere,
            CantCalmThere, AlreadyDiscord, AlreadyCalmed, NoChanceToProvoke, NoChanceToCalm, CantProvokeOne,
            CantInciteAnger, TooFarApartToProvoke, BadPerformance, FailedPerformanceProvoke,
            FailedPerformanceDiscord, GoodPerformanceProvoke, GoodPerformanceDiscord, GoodPerformancePeace,
            ProvokeOnThemselves, PeaceNobody, ThisIsTooHeavy, TooHeavyForNow, ThankYou, ToldToShutUp,
            CanTalkAgain, NoPotions, TooSoonToDrink, AgilityPotion, PoisonPotion, RefreshPotion,
            StrengthPotion, HealthPotion, CantHealthPotion, StillPoisoned, MortallyWoundedHP, CurePotion,
            CantCurePotion, UsePowerScroll, CantUsePowerScroll, MissingLockpicks, LockpickTooFar, NotLocked,
            CannotUnlock, BrokenLockpick, AbnormalLock, HardLock, UnsuccessfulLockpick, SuccessfulLockpick,
            HandsAreFull, StealingNotAllowedHere, NotAPartOfThievesGuild, SuspendedFromThievesGuild,
            CannotStealFromVendors, CannotSeeStealingTarget, FullBackpackStealing, NeedToBeCloserToSteal,
            CannotStealThat, CannotStealWhileMorphed, NotSkilledEnoughToStealItem, CannotStealFromTheirHands,
            StealFromSelf, TooHeavyToSteal, SuccessfulSteal, UnsuccessfulSteal, TooSoonToLockpick,
            TooSoonToSteal, WhatShouldISteal, LearnsFromContract, RefusesToLootPlayers, UnequipsTwoHandedForShield,
            FirstHandMissing, SecondHandMissing, EmptyHands, SuccessfulSetCreation, Unarmed, SpiritSpeakSuccess,
            SpiritSpeakFail, TooSoonToSpiritSpeak, SpiritChannelFades, StillConnectedToSpirits, OpenQuiver,
            NotAQuiver, PoisonToApply, ApplyPoisonTo, NotAPoisonPotion, TooFarToPoison, CannotPoisonNotInfectious,
            CannotPoisonNotBPFoD, PoisoningSuccess, PoisoningFailure, TerribleMistake, NoAnkhNearby,
            TitheSuccess, NoGoldToTithe, NotEnoughTithe, NotEnoughMana, NoChivalryBook, TooSoonToMeditate,
            TooSoonToCastASpell, NotEnoughSpellSkill, NoExplosionPotion, SquireHasANewTeam, NoBushidoBook, NoNecroBook
        }

        public static Dictionary<SquireDialogTree, List<string>> Dialogs = new Dictionary<SquireDialogTree, List<string>>
        {
            { SquireDialogTree.HideFailure, new List<string> {
                "This is too difficult...", "*I cannot grasp the concept of hiding.*",
                "Hiding seems beyond my grasp at the moment.", "{master_nickname_upper}, I HAVE FAILED YOU!",
                "I have failed to hide, {master_nickname}.", "I am sorry, {master_nickname}, I have failed to hide."
            }},
            { SquireDialogTree.TooSoonToHide, new List<string> {
                "Ah! I have failed to hide! Wait... No, it is still too soon.", "*Trips over their own feet trying to hide so soon.*",
                "Give me some time, please.", "I need a moment.",
                "I will not attempt to hide again so soon, {master_nickname}.", "It is a bit too soon to attempt to hide, {master_nickname}."
            }},
            { SquireDialogTree.MissingInstrument, new List<string> {
                "An instrument would be useful right now.", "*Plays 'the world's smallest lute'.*",
                "Would you like me to whistle?", "I need something to play, {master_nickname}.",
                "Now, where did I put it...", "I do not seem to have an instrument, {master_nickname}."
            }},
            { SquireDialogTree.TooSoonToPlayMusic, new List<string> {
                "I might break my instrument playing so fast.", "*Recovers their balance after trying to play again too soon.*",
                "I cannot play that fast.", "{master_nickname}, it is a bit too soon.",
                "I might pull a muscle if I try to play too soon.", "It is too soon to play my instrument, {master_nickname}."
            }},
            { SquireDialogTree.MissingSnow, new List<string> {
                "Snow is out of my reach.", "*Tries to pick up snow from the ground and fails.*",
                "There is no snow in my backpack.", "{master_nickname}, would you have some snow for me to throw?",
                "I cannot seem to find any snow.", "I do not seem to have any snow, {master_nickname}."
            }},
            { SquireDialogTree.TooSoonToPackSnow, new List<string> {
                "I cannot make a ball with so little snow.", "*Tries and fails to make a snowball.*",
                "Snow is a bit scarce right now. Give it a moment.", "I cannot make a snowball so fast, {master_nickname}.",
                "There is too little snow in this pile.", "It is too soon to attempt to make a snowball, {master_nickname}."
            }},
            { SquireDialogTree.MasterHasANewNickname, new List<string> {
                "Let me try shouting it... {master_nickname_upper}! Yes, that works!", "*Is more than excited to refer to you as {master_nickname}.*",
                "{master_nickname} suits you well!", "I cannot wait to get used to referring to you as {master_nickname}.",
                "{master_nickname}... Agreed.", "Agreed, I will refer to you as {master_nickname} from now on."
            }},
            { SquireDialogTree.SquireHasANewNickname, new List<string> {
                "Let me try shouting it... {squire_nickname_upper}! Yes, that works!", "*Is more than excited to be referred to as {squire_nickname}!*",
                "{squire_nickname} suits me well!", "I am sure I will get used to being called {squire_nickname} from now on.",
                "{squire_nickname}... It is not... Terrible...", "Agreed, I will answer to {squire_nickname} from now on."
            }},
            { SquireDialogTree.SquireHealsMaster, new List<string> {
                "Stay calm {squire_nickname}, {master_nickname} will be fine, do your job.", "*Whispers a small prayer.*",
                "DO NOT DIE, {master_nickname_upper}!", "You will be fine, {master_nickname}, just hang on.",
                "Your wounds are not the worst I have seen.", "Let me bandage that wound, {master_nickname}."
            }},
            { SquireDialogTree.SquireCuresMaster, new List<string> {
                "This poison will be gone swiftly.", "*Moves lips mouthing 'An Nox'.*",
                "This poison isn't SO bad.", "The mages of Moonglow taught me this one.",
                "I learned this little remedy in Papua during my youth.", "Let me attempt to cure you, {master_nickname}."
            }},
            { SquireDialogTree.SquireRezsMaster, new List<string> {
                "It is too soon for you to leave this world, {master_nickname}.", "*Moves lips mouthing 'An Corp'.*",
                "{squire_name} has got you, {master_nickname}.", "This is a healing technique I learned from Nujel'm.",
                "I am a failure of a squire, please forgive me, {master_nickname}.", "Let me attempt to resurrect you, {master_nickname}."
            }},
            { SquireDialogTree.ASquiresConcern, new List<string> {
                "Please do not die, {master_nickname}.", "*Sweats nervously.*",
                "I cannot believe I lost sight of {master_nickname}, I am a terrible squire.", "{master_nickname} is hurt, but I cannot see them!",
                "{master_nickname_upper}, WHERE ARE YOU!", "{master_nickname}? Please show yourself! {master_nickname}!?"
            }},
            { SquireDialogTree.ASquiresStay, new List<string> {
                "I cannot move from where I am, {master_nickname}, please call me over.", "*Sweats anxiously.*",
                "{squire_nickname} will stay here, just as {master_nickname} told him to.", "Help me help you, {master_nickname}. Call me over!",
                "{master_nickname_upper}, YOU TOLD ME NOT TO MOVE FROM THIS SPOT!", "I would be there to heal you, {master_nickname}, but you asked me to stay."
            }},
            { SquireDialogTree.SquiresNewName, new List<string> {
                "How about, {squire_name}?", "*Thinks deeply about {squire_name} as their new name.*",
                "What is my name? How about {squire_name}!", "{squire_name} has a nice ring to it, does it not?",
                "{master_nickname} and {squire_name}.", "I think the name {squire_name} suits me better, do you not think?"
            }},
            { SquireDialogTree.ShowingOffASquiresBackpack, new List<string> {
                "Look into the contents of my pack if you would like.", "*Opens up their backpack to you with pride.*",
                "I am sure the contents of your pack are more interesting than mine.", "Here is what your little {squire_nickname} is holding.",
                "Y-you want to see my what? Oh, my backpack.", "Here is what I am holding."
            }},
            { SquireDialogTree.SquireCantReach, new List<string> {
                "That is a bit too far for me.", "*Tries to reach for the target, but fails.*",
                "My arms do not reach!", "It is a bit out of my reach.",
                "{master_nickname}, could you move me closer?", "I cannot reach that from here."
            }},
            { SquireDialogTree.SquireCantLiftNotItem, new List<string> {
                "That is not an item, so I cannot lift it.", "*Tries to lift the target, but fails.*",
                "Are you sure?", "That is not something I can carry.",
                "Are you serious?", "I cannot lift that."
            }},
            { SquireDialogTree.SquireCantLiftItem, new List<string> {
                "I am not as strong as you, {master_nickname}.", "*Tries to lift the target, but fails.*",
                "It seems a bit heavy.", "Is that even movable?",
                "It might be a bit heavy for me.", "I could not lift that item."
            }},
            { SquireDialogTree.SquireCantLiftCorpse, new List<string> {
                "It seems to be decaying. Are you sure you do not want me to loot it?", "*Makes a weak attempt to lift the corpse.*",
                "{master_nickname}... That is disgusting.", "It seems to have items on it, are you sure you do not want me to loot it?",
                "I refuse to lift a body.", "I cannot lift this, did you mean to loot it instead?"
            }},
            { SquireDialogTree.ItemIsNotCorpse, new List<string> {
                "This cannot be looted.", "*Pokes the item before looking back at you.*",
                "{master_nickname}... Are you alright?", "That does not look like a corpse to me.",
                "This is not a corpse.", "Did you mean to say grab?"
            }},
            { SquireDialogTree.SquireCantLootAllItems, new List<string> {
                "There was too much.", "*The items slip out of {squire_name}'s hands and back onto the corpse.*",
                "I could not hold all of the items.", "There was too much for me to grab.",
                "I am sorry, {master_nickname}, but I could not pick up all of the items.", "I could not pick up all of the items."
            }},
            { SquireDialogTree.SquireCantLootNotCorpse, new List<string> {
                "That is not a corpse, so I cannot loot it.", "*Tries to loot the target, but fails.*",
                "Are you sure?", "That is not something I can loot.",
                "Are you serious?", "I cannot loot that."
            }},
            { SquireDialogTree.SquireHealsWounded, new List<string> {
                "Stay calm {squire_nickname}, {creature_name} will be fine, do your job.", "*Whispers a small prayer.*",
                "I will make sure you do not die, {creature_name}.", "You will be fine, {creature_name}, just hang on.",
                "Your wounds are not the worst I have seen.", "Let me bandage that wound, {creature_name}."
            }},
            { SquireDialogTree.SquireCuresHumanoid, new List<string> {
                "This poison will be gone swiftly.", "*Moves lips mouthing 'An Nox'.*",
                "This poison isn't SO bad.", "The mages of Moonglow taught me this one.",
                "I learned this little remedy in Papua during my youth.", "Let me attempt to cure you, {creature_name}."
            }},
            { SquireDialogTree.SquireCuresAnimal, new List<string> {
                "This poison will be gone swiftly.", "*Moves lips mouthing 'An Nox'.*",
                "Your poison is not so bad, {creature_name}.", "I learned to care for animals on my travels, here...",
                "The remedies of Papua are potent, I have been told.", "Easy there, {creature_name}, you will be cured soon."
            }},
            { SquireDialogTree.SquireRezsHumanoid, new List<string> {
                "It is too soon for you to leave this world, {creature_name}.", "*Moves lips mouthing 'An Corp'.*",
                "{squire_name} has got you, {creature_name}.", "This is a healing technique I learned from Nujel'm.",
                "{master_nickname} must be a good friend of yours for him to ask me to do this.", "Let me attempt to resurrect you, {creature_name}."
            }},
            { SquireDialogTree.SquireRezsAnimal, new List<string> {
                "It is too soon for you to leave this world, {creature_name}.", "*Moves lips mouthing 'An Corp'.*",
                "{squire_name} has got you, {creature_name}.", "This is a healing technique I learned from Delucia.",
                "{master_nickname} is a kind person.", "Let me attempt to resurrect you, {creature_name}."
            }},
            { SquireDialogTree.SquireCantRez, new List<string> {
                "I just do not have the skill to do this.", "I cannot resurrect {creature_name}.",
                "I'm sorry, but there is nothing I can do.", "The mages of Moonglow did not prepare me enough for this.",
                "You have overestimated my abilities, {master_nickname}, I cannot resurrect {creature_name}.", "I apologize, {creature_name}, but I am unable to resurrect you for I am not skilled enough."
            }},
            { SquireDialogTree.WoundedIsNotHurtEnough, new List<string> {
                "You will be fine soon.", "*Chuckles*",
                "They will be alright in a moment.", "I refuse to waste bandages.",
                "{master_nickname}, you are too kind, it would be a waste of bandages at this time.", "{creature_name} is not hurt enough."
            }},
            { SquireDialogTree.BandagingWounded, new List<string> {
                "Do not move, {creature_name}, or I might fail.", "Now, to apply the bandage...",
                "I am concentrating on my healing abilities.", "Let me bandage you, {creature_name}.",
                "Hold on, {creature_name}, you will be fine soon.", "I cannot talk right now, {master_nickname}, I am bandaging {creature_name}."
            }},
            { SquireDialogTree.BandagingWoundedFail, new List<string> {
                "Damn it! I messed up!", "My bandages have failed.",
                "Oops!", "Darn!",
                "I am sorry, {master_nickname}, I failed.", "I am sorry, {creature_name}, I failed."
            }},
            { SquireDialogTree.BandagingWoundedSuccess, new List<string> {
                "All done!", "My healing abilities are superb.",
                "There you go, {creature_name}, good as new.", "Do not worry, {creature_name}, you will be fine.",
                "I am getting better at this.", "Lesson one, {master_nickname}, never give up."
            }},
            { SquireDialogTree.CureWounded, new List<string> {
                "Now, to cure {creature_name}...", "An Nox!",
                "Uus Por!", "Kal Ort Xen!",
                "May the poisons be purged!", "Now, where is that poison?"
            }},
            { SquireDialogTree.CureWoundedFail, new List<string> {
                "Damn it! I messed up!", "My spells have failed.",
                "Oops!", "Darn!",
                "I am sorry, {master_nickname}, I failed.", "I am sorry, {creature_name}, I failed."
            }},
            { SquireDialogTree.CureWoundedSuccess, new List<string> {
                "All done!", "My spellcasting abilities are superb.",
                "There you go, {creature_name}, good as new.", "Do not worry, {creature_name}, you will be fine.",
                "I am getting better at this.", "Lesson one, {master_nickname}, never give up."
            }},
            { SquireDialogTree.Attacking, new List<string> {
                "Die, {creature_name}!", "For {master_nickname}!",
                "I am coming for you, {creature_name}!", "You will not escape me!",
                "Taste my steel!", "You will not stop me!"
            }},
            { SquireDialogTree.OnTheAttack, new List<string> {
                "I am on my way!", "Let me at them!",
                "I am on my way!", "Do not worry, {master_nickname}, I will take care of them!"
            }},
            { SquireDialogTree.StopAndFollow, new List<string> {
                "As you wish, {master_nickname}.", "Alright, {master_nickname}.",
                "Okay.", "Yes, {master_nickname}."
            }},
            { SquireDialogTree.Boarding, new List<string> {
                "All aboard!", "I am boarding the ship!",
                "Here I go!", "As you wish, {master_nickname}!"
            }},
            { SquireDialogTree.Looting, new List<string> {
                "Let's see what we have here.", "I hope I find something good.",
                "Do not worry, {master_nickname}, I will loot it for you.", "Loot!"
            }},
            { SquireDialogTree.NothingToLoot, new List<string> {
                "There is nothing here.", "I did not find anything.",
                "The body is clean.", "I am sorry, {master_nickname}, there is nothing to loot."
            }},
            { SquireDialogTree.DoneLooting, new List<string> {
                "I am done looting.", "That is all.",
                "I have looted all I can.", "I am done, {master_nickname}."
            }},
            { SquireDialogTree.Guarding, new List<string> {
                "I am on it.", "I will protect {creature_name} with my life.",
                "Do not worry, {master_nickname}, I will not let anything happen to {creature_name}.", "As you wish."
            }},
        };
    }
}
