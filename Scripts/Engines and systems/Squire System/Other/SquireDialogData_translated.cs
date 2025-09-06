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
                "Esto es demasiado difícil...", "*No puedo comprender el concepto de esconderme.*",
                "Esconderme parece fuera de mi alcance en este momento.", "¡{master_nickname_upper}, TE HE FALLADO!",
                "He fallado al esconderme, {master_nickname}.", "Lo siento, {master_nickname}, he fallado al esconderme."
            }},
            { SquireDialogTree.TooSoonToHide, new List<string> {
                "¡Ah! ¡He fallado al esconderme! Espera... No, todavía es demasiado pronto.", "*Se tropieza con sus propios pies tratando de esconderse tan pronto.*",
                "Dame un tiempo, por favor.", "Necesito un momento.",
                "No intentaré esconderme de nuevo tan pronto, {master_nickname}.", "Es un poco pronto para intentar esconderme, {master_nickname}."
            }},
            { SquireDialogTree.MissingInstrument, new List<string> {
                "Un instrumento sería útil ahora mismo.", "*Toca 'el laúd más pequeño del mundo'.*",
                "¿Te gustaría que silbara?", "Necesito algo para tocar, {master_nickname}.",
                "Ahora, ¿dónde lo puse...", "No parece que tenga un instrumento, {master_nickname}."
            }},
            { SquireDialogTree.TooSoonToPlayMusic, new List<string> {
                "Podría romper mi instrumento tocando tan rápido.", "*Recupera el equilibrio después de intentar tocar de nuevo demasiado pronto.*",
                "No puedo tocar tan rápido.", "{master_nickname}, es un poco pronto.",
                "Podría desgarrarme un músculo si intento tocar demasiado pronto.", "Es demasiado pronto para tocar mi instrumento, {master_nickname}."
            }},
            { SquireDialogTree.MissingSnow, new List<string> {
                "La nieve está fuera de mi alcance.", "*Intenta recoger nieve del suelo y falla.*",
                "No hay nieve en mi mochila.", "{master_nickname}, ¿tendrías algo de nieve para que la lance?",
                "No parece que pueda encontrar nieve.", "No parece que tenga nieve, {master_nickname}."
            }},
            { SquireDialogTree.TooSoonToPackSnow, new List<string> {
                "No puedo hacer una bola con tan poca nieve.", "*Intenta y falla al hacer una bola de nieve.*",
                "La nieve es un poco escasa ahora mismo. Dale un momento.", "No puedo hacer una bola de nieve tan rápido, {master_nickname}.",
                "Hay muy poca nieve en este montón.", "Es demasiado pronto para intentar hacer una bola de nieve, {master_nickname}."
            }},
            { SquireDialogTree.MasterHasANewNickname, new List<string> {
                "Déjame intentar gritarlo... ¡{master_nickname_upper}! ¡Sí, eso funciona!", "*Está más que emocionado de referirse a ti como {master_nickname}.*",
                "¡{master_nickname} te queda muy bien!", "No puedo esperar a acostumbrarme a referirme a ti como {master_nickname}.",
                "{master_nickname}... De acuerdo.", "De acuerdo, me referiré a ti como {master_nickname} de ahora en adelante."
            }},
            { SquireDialogTree.SquireHasANewNickname, new List<string> {
                "Déjame intentar gritarlo... ¡{squire_nickname_upper}! ¡Sí, eso funciona!", "*¡Está más que emocionado de que se refieran a él como {squire_nickname}!*",
                "¡{squire_nickname} me queda muy bien!", "Estoy seguro de que me acostumbraré a que me llamen {squire_nickname} de ahora en adelante.",
                "{squire_nickname}... No es... Terrible...", "De acuerdo, responderé a {squire_nickname} de ahora en adelante."
            }},
            { SquireDialogTree.SquireHealsMaster, new List<string> {
                "Mantén la calma {squire_nickname}, {master_nickname} estará bien, haz tu trabajo.", "*Murmura una pequeña oración.*",
                "¡NO TE MUERAS, {master_nickname_upper}!", "Estarás bien, {master_nickname}, solo aguanta.",
                "Tus heridas no son las peores que he visto.", "Déjame vendar esa herida, {master_nickname}."
            }},
            { SquireDialogTree.SquireCuresMaster, new List<string> {
                "Este veneno desaparecerá rápidamente.", "*Mueve los labios diciendo 'An Nox'.*",
                "Este veneno no es TAN malo.", "Los magos de Moonglow me enseñaron este.",
                "Aprendí este pequeño remedio en Papúa durante mi juventud.", "Déjame intentar curarte, {master_nickname}."
            }},
            { SquireDialogTree.SquireRezsMaster, new List<string> {
                "Es demasiado pronto para que dejes este mundo, {master_nickname}.", "*Mueve los labios diciendo 'An Corp'.*",
                "{squire_nickname} te tiene, {master_nickname}.", "Esta es una técnica de curación que aprendí en Nujel'm.",
                "Soy un fracaso como escudero, por favor perdóname, {master_nickname}.", "Déjame intentar resucitarte, {master_nickname}."
            }},
            { SquireDialogTree.ASquiresConcern, new List<string> {
                "Por favor no te mueras, {master_nickname}.", "*Suda nerviosamente.*",
                "No puedo creer que perdí de vista a {master_nickname}, soy un escudero terrible.", "¡{master_nickname} está herido, pero no puedo verlo!",
                "¡{master_nickname_upper}, DÓNDE ESTÁS!", "¿{master_nickname}? ¡Por favor, muéstrate! ¿¡{master_nickname}!?"
            }},
            { SquireDialogTree.ASquiresStay, new List<string> {
                "No puedo moverme de donde estoy, {master_nickname}, por favor llámame.", "*Suda ansiosamente.*",
                "{squire_nickname} se quedará aquí, tal como {master_nickname} le dijo.", "Ayúdame a ayudarte, {master_nickname}. ¡Llámame!",
                "¡{master_nickname_upper}, ME DIJISTE QUE NO ME MOVIERA DE ESTE LUGAR!", "Estaría allí para curarte, {master_nickname}, pero me pediste que me quedara."
            }},
            { SquireDialogTree.SquiresNewName, new List<string> {
                "¿Qué tal, {squire_name}?", "*Piensa profundamente en {squire_name} como su nuevo nombre.*",
                "¿Cuál es mi nombre? ¡Qué tal {squire_name}!", "¿{squire_name} suena bien, ¿verdad?",
                "{master_nickname} y {squire_name}.", "Creo que el nombre {squire_name} me queda mejor, ¿no crees?"
            }},
            { SquireDialogTree.ShowingOffASquiresBackpack, new List<string> {
                "Mira el contenido de mi mochila si quieres.", "*Te abre su mochila con orgullo.*",
                "Estoy seguro de que el contenido de tu mochila es más interesante que el mío.", "Aquí está lo que tu pequeño {squire_nickname} está sosteniendo.",
                "¿Q-quieres ver mi qué? Oh, mi mochila.", "Aquí está lo que estoy sosteniendo."
            }},
            { SquireDialogTree.SquireCantReach, new List<string> {
                "Eso está un poco lejos para mí.", "*Intenta alcanzar el objetivo, pero falla.*",
                "¡Mis brazos no llegan!", "Está un poco fuera de mi alcance.",
                "{master_nickname}, ¿podrías acercarme?", "No puedo alcanzar eso desde aquí."
            }},
            { SquireDialogTree.SquireCantLiftNotItem, new List<string> {
                "Eso no es un objeto, así que no puedo levantarlo.", "*Intenta levantar el objetivo, pero falla.*",
                "¿Estás seguro?", "Eso no es algo que pueda llevar.",
                "¿Hablas en serio?", "No puedo levantar eso."
            }},
            { SquireDialogTree.SquireCantLiftItem, new List<string> {
                "No soy tan fuerte como tú, {master_nickname}.", "*Intenta levantar el objetivo, pero falla.*",
                "Parece un poco pesado.", "¿Se puede mover eso?",
                "Podría ser un poco pesado para mí.", "No pude levantar ese objeto."
            }},
            { SquireDialogTree.SquireCantLiftCorpse, new List<string> {
                "Parece que se está pudriendo. ¿Estás seguro de que no quieres que lo saquee?", "*Hace un intento débil de levantar el cadáver.*",
                "{master_nickname}... Eso es asqueroso.", "Parece que tiene objetos, ¿estás seguro de que no quieres que lo saquee?",
                "Me niego a levantar un cuerpo.", "¿No puedo levantar esto, querías que lo saqueara en su lugar?"
            }},
            { SquireDialogTree.ItemIsNotCorpse, new List<string> {
                "Esto no se puede saquear.", "*Pincha el objeto antes de mirarte.*",
                "{master_nickname}... ¿Estás bien?", "No me parece un cadáver.",
                "Esto no es un cadáver.", "¿Querías decir agarrar?"
            }},
            { SquireDialogTree.SquireCantLootAllItems, new List<string> {
                "Había demasiado.", "*Los objetos se le escapan de las manos a {squire_name} y vuelven al cadáver.*",
                "No pude sostener todos los objetos.", "Había demasiado para que yo lo agarrara.",
                "Lo siento, {master_nickname}, pero no pude recoger todos los objetos.", "No pude recoger todos los objetos."
            }},
            { SquireDialogTree.SquireCantLootNotCorpse, new List<string> {
                "Eso no es un cadáver, así que no puedo saquearlo.", "*Intenta saquear el objetivo, pero falla.*",
                "¿Estás seguro?", "Eso no es algo que pueda saquear.",
                "¿Hablas en serio?", "No puedo saquear eso."
            }},
            { SquireDialogTree.SquireHealsWounded, new List<string> {
                "Mantén la calma {squire_nickname}, {creature_name} estará bien, haz tu trabajo.", "*Murmura una pequeña oración.*",
                "Me aseguraré de que no mueras, {creature_name}.", "Estarás bien, {creature_name}, solo aguanta.",
                "Tus heridas no son las peores que he visto.", "Déjame vendar esa herida, {creature_name}."
            }},
            { SquireDialogTree.SquireCuresHumanoid, new List<string> {
                "Este veneno desaparecerá rápidamente.", "*Mueve los labios diciendo 'An Nox'.*",
                "Este veneno no es TAN malo.", "Los magos de Moonglow me enseñaron este.",
                "Aprendí este pequeño remedio en Papúa durante mi juventud.", "Déjame intentar curarte, {creature_name}."
            }},
            { SquireDialogTree.SquireCuresAnimal, new List<string> {
                "Este veneno desaparecerá rápidamente.", "*Mueve los labios diciendo 'An Nox'.*",
                "Tu veneno no es tan malo, {creature_name}.", "Aprendí a cuidar animales en mis viajes, aquí...",
                "Los remedios de Papúa son potentes, me han dicho.", "Tranquilo, {creature_name}, pronto te curarás."
            }},
            { SquireDialogTree.SquireRezsHumanoid, new List<string> {
                "Es demasiado pronto para que dejes este mundo, {creature_name}.", "*Mueve los labios diciendo 'An Corp'.*",
                "{squire_name} te tiene, {creature_name}.", "Esta es una técnica de curación que aprendí en Nujel'm.",
                "{master_nickname} debe ser un buen amigo tuyo para que me pida hacer esto.", "Déjame intentar resucitarte, {creature_name}."
            }},
            { SquireDialogTree.SquireRezsAnimal, new List<string> {
                "Es demasiado pronto para que dejes este mundo, {creature_name}.", "*Mueve los labios diciendo 'An Corp'.*",
                "{squire_name} te tiene, {creature_name}.", "Esta es una técnica de curación que aprendí en Delucia.",
                "{master_nickname} es una persona amable.", "Déjame intentar resucitarte, {creature_name}."
            }},
            { SquireDialogTree.SquireCantRez, new List<string> {
                "Simplemente no tengo la habilidad para hacer esto.", "No puedo resucitar a {creature_name}.",
                "Lo siento, pero no hay nada que pueda hacer.", "Los magos de Moonglow no me prepararon lo suficiente para esto.",
                "Has sobrestimado mis habilidades, {master_nickname}, no puedo resucitar a {creature_name}.", "Me disculpo, {creature_name}, pero no puedo resucitarte porque no tengo la habilidad suficiente."
            }},
            { SquireDialogTree.WoundedIsNotHurtEnough, new List<string> {
                "Estarás bien pronto.", "*Se ríe entre dientes.*",
                "Estarán bien en un momento.", "Me niego a desperdiciar vendas.",
                "{master_nickname}, eres demasiado amable, sería un desperdicio de vendas en este momento.", "{creature_name} no está lo suficientemente herido."
            }},
            { SquireDialogTree.BandagingWounded, new List<string> {
                "No te muevas, {creature_name}, o podría fallar.", "Ahora, para aplicar el vendaje...",
                "Me estoy concentrando en mis habilidades de curación.", "Déjame vendarte, {creature_name}.",
                "Aguanta, {creature_name}, estarás bien pronto.", "No puedo hablar ahora, {master_nickname}, estoy vendando a {creature_name}."
            }},
            { SquireDialogTree.BandagingWoundedFail, new List<string> {
                "¡Maldita sea! ¡Lo arruiné!", "Mis vendajes han fallado.",
                "¡Ups!", "¡Rayos!",
                "Lo siento, {master_nickname}, fallé.", "Lo siento, {creature_name}, fallé."
            }},
            { SquireDialogTree.BandagingWoundedSuccess, new List<string> {
                "¡Todo listo!", "Mis habilidades de curación son excelentes.",
                "Ahí tienes, {creature_name}, como nuevo.", "No te preocupes, {creature_name}, te pondrás bien.",
                "Estoy mejorando en esto.", "Lección uno, {master_nickname}, nunca te rindas."
            }},
            { SquireDialogTree.CureWounded, new List<string> {
                "Ahora, para curar a {creature_name}...", "¡An Nox!",
                "Uus Por!", "Kal Ort Xen!",
                "¡Que los venenos sean purgados!", "Ahora, ¿dónde está ese veneno?"
            }},
            { SquireDialogTree.CureWoundedFail, new List<string> {
                "¡Maldita sea! ¡Lo arruiné!", "Mis hechizos han fallado.",
                "¡Ups!", "¡Rayos!",
                "Lo siento, {master_nickname}, fallé.", "Lo siento, {creature_name}, fallé."
            }},
            { SquireDialogTree.CureWoundedSuccess, new List<string> {
                "¡Todo listo!", "Mis habilidades de lanzamiento de hechizos son excelentes.",
                "Ahí tienes, {creature_name}, como nuevo.", "No te preocupes, {creature_name}, te pondrás bien.",
                "Estoy mejorando en esto.", "Lección uno, {master_nickname}, nunca te rindas."
            }},
            { SquireDialogTree.Attacking, new List<string> {
                "¡Muere, {creature_name}!", "¡Por {master_nickname}!",
                "¡Voy a por ti, {creature_name}!", "¡No escaparás de mí!",
                "¡Prueba mi acero!", "¡No me detendrás!"
            }},
            { SquireDialogTree.OnTheAttack, new List<string> {
                "¡Ya voy!", "¡Déjame llegar a ellos!",
                "¡Estoy en camino!", "¡No te preocupes, {master_nickname}, me encargaré de ellos!"
            }},
            { SquireDialogTree.StopAndFollow, new List<string> {
                "Como desees, {master_nickname}.", "De acuerdo, {master_nickname}.",
                "Está bien.", "Sí, {master_nickname}."
            }},
            { SquireDialogTree.Boarding, new List<string> {
                "¡Todos a bordo!", "¡Estoy abordando el barco!",
                "¡Allá voy!", "¡Como desees, {master_nickname}!"
            }},
            { SquireDialogTree.Looting, new List<string> {
                "Veamos qué tenemos aquí.", "Espero encontrar algo bueno.",
                "No te preocupes, {master_nickname}, lo saquearé por ti.", "¡Botín!"
            }},
            { SquireDialogTree.NothingToLoot, new List<string> {
                "No hay nada aquí.", "No encontré nada.",
                "El cuerpo está limpio.", "Lo siento, {master_nickname}, no hay nada que saquear."
            }},
            { SquireDialogTree.DoneLooting, new List<string> {
                "He terminado de saquear.", "Eso es todo.",
                "He saqueado todo lo que he podido.", "He terminado, {master_nickname}."
            }},
            { SquireDialogTree.Guarding, new List<string> {
                "Estoy en ello.", "Protegeré a {creature_name} con mi vida.",
                "No te preocupes, {master_nickname}, no dejaré que nada le pase a {creature_name}.", "Como desees."
            }},
            { SquireDialogTree.WoundedOutOfRange, new List<string> {
                "Están demasiado lejos para que pueda curarlos.", "*Se esfuerza por alcanzar a los heridos, pero no puede.*",
                "No puedo alcanzarlos desde aquí.", "Están fuera de mi alcance.",
                "{master_nickname}, no puedo alcanzarlos.", "Están demasiado lejos."
            }},
            { SquireDialogTree.WoundedInvisible, new List<string> {
                "No puedo verlos para curarlos.", "*Mira a su alrededor, pero no puede encontrar a los heridos.*",
                "¿A dónde fueron?", "No puedo verlos.",
                "{master_nickname}, no puedo verlos.", "No son visibles para mí."
            }},
            { SquireDialogTree.SquireHealsPlayer, new List<string> {
                "Mantén la calma {squire_nickname}, {player_name} estará bien, haz tu trabajo.", "*Susurra una pequeña oración.*",
                "Me aseguraré de que no mueras, {player_name}.", "Estarás bien, {player_name}, solo aguanta.",
                "Tus heridas no son las peores que he visto.", "Déjame vendar esa herida, {player_name}."
            }},
            { SquireDialogTree.SquireCuresPlayer, new List<string> {
                "Este veneno desaparecerá rápidamente.", "*Mueve los labios diciendo 'An Nox'.*",
                "Este veneno no es TAN malo.", "Los magos de Moonglow me enseñaron este.",
                "Aprendí este pequeño remedio en Papúa durante mi juventud.", "Déjame intentar curarte, {player_name}."
            }},
            { SquireDialogTree.SquireRezsPlayer, new List<string> {
                "Es demasiado pronto para que dejes este mundo, {player_name}.", "*Mueve los labios diciendo 'An Corp'.*",
                "{squire_name} te tiene, {player_name}.", "Esta es una técnica de curación que aprendí en Nujel'm.",
                "{master_nickname} debe ser un buen amigo tuyo para que me pida hacer esto.", "Déjame intentar resucitarte, {player_name}."
            }},
            { SquireDialogTree.SquireCantRezPlayer, new List<string> {
                "Simplemente no tengo la habilidad para hacer esto.", "No puedo resucitar a {player_name}.",
                "Lo siento, pero no hay nada que pueda hacer.", "Los magos de Moonglow no me prepararon lo suficiente para esto.",
                "Has sobrestimado mis habilidades, {master_nickname}, no puedo resucitar a {player_name}.", "Me disculpo, {player_name}, pero no puedo resucitarte porque no tengo la habilidad suficiente."
            }},
            { SquireDialogTree.WoundedPlayerIsNotHurtEnough, new List<string> {
                "Estarás bien pronto.", "*Se ríe entre dientes.*",
                "Estarás bien en un momento.", "Me niego a desperdiciar vendas.",
                "{master_nickname}, eres demasiado amable, sería un desperdicio de vendas en este momento.", "{player_name} no está lo suficientemente herido."
            }},
            { SquireDialogTree.WoundedPlayerOutOfRange, new List<string> {
                "Estás demasiado lejos para que pueda curarte.", "*Se esfuerza por alcanzarte, pero no puede.*",
                "No puedo alcanzarte desde aquí.", "Estás fuera de mi alcance.",
                "{master_nickname}, no puedo alcanzarlos.", "Estás demasiado lejos."
            }},
            { SquireDialogTree.HealingTargetNotCreature, new List<string> {
                "No puedo curar eso.", "*Mira al objetivo, luego a ti.*",
                "Eso no es una criatura.", "Solo puedo curar seres vivos.",
                "{master_nickname}, eso no es una criatura.", "No puedo curar eso."
            }},
            { SquireDialogTree.BeginProvoking, new List<string> {
                "Veamos cómo va esto.", "*Se truena los nudillos.*",
                "Intentaré provocarlos.", "Aquí voy.",
                "Deséame suerte, {master_nickname}.", "Haré lo mejor que pueda."
            }},
            { SquireDialogTree.WheredMyInstrumentGo, new List<string> {
                "¿A dónde se fue mi instrumento?", "*Busca su instrumento a su alrededor.*",
                "No puedo encontrar mi instrumento.", "Parece que he perdido mi instrumento.",
                "{master_nickname}, no puedo encontrar mi instrumento.", "No tengo un instrumento."
            }},
            { SquireDialogTree.LoyalToTheirMaster, new List<string> {
                "Son demasiado leales a su amo.", "*Falla al provocar a la criatura.*",
                "No puedo hacer que se vuelvan contra su amo.", "No serán provocados.",
                "{master_nickname}, no puedo hacer que se vuelvan.", "Son demasiado leales."
            }},
            { SquireDialogTree.CantDiscord, new List<string> {
                "No puedo discordar eso.", "*Falla al discordar a la criatura.*",
                "No puedo hacer que sean discordados.", "No serán discordados.",
                "{master_nickname}, no puedo hacer que sean discordados.", "No puedo discordarlos."
            }},
            { SquireDialogTree.CantCalm, new List<string> {
                "No puedo calmar eso.", "*Falla al calmar a la criatura.*",
                "No puedo hacer que se calmen.", "No se calmarán.",
                "{master_nickname}, no puedo hacer que se calmen.", "No puedo calmarlos."
            }},
            { SquireDialogTree.CantCalmHere, new List<string> {
                "No puedo calmarlos aquí.", "*Falla al calmar a la criatura.*",
                "No puedo hacer que se calmen aquí.", "No se calmarán aquí.",
                "{master_nickname}, no puedo hacer que se calmen aquí.", "No puedo calmarlos aquí."
            }},
            { SquireDialogTree.CantCalmThere, new List<string> {
                "No puedo calmarlos allí.", "*Falla al calmar a la criatura.*",
                "No puedo hacer que se calmen allí.", "No se calmarán allí.",
                "{master_nickname}, no puedo hacer que se calmen allí.", "No puedo calmarlos allí."
            }},
            { SquireDialogTree.AlreadyDiscord, new List<string> {
                "Ya están discordados.", "*Nota que la criatura ya está discordada.*",
                "Ya están bajo los efectos de la discordancia.", "Ya están discordados.",
                "{master_nickname}, ya están discordados.", "Ya están discordados."
            }},
            { SquireDialogTree.AlreadyCalmed, new List<string> {
                "Ya están calmados.", "*Nota que la criatura ya está calmada.*",
                "Ya están bajo los efectos de la pacificación.", "Ya están calmados.",
                "{master_nickname}, ya están calmados.", "Ya están calmados."
            }},
            { SquireDialogTree.NoChanceToProvoke, new List<string> {
                "No tengo ninguna posibilidad de provocarlos.", "*Suspira derrotado.*",
                "No puedo provocarlos.", "Son demasiado poderosos para que yo los provoque.",
                "{master_nickname}, no puedo provocarlos.", "No tengo ninguna posibilidad."
            }},
            { SquireDialogTree.NoChanceToCalm, new List<string> {
                "No tengo ninguna posibilidad de calmarlos.", "*Suspira derrotado.*",
                "No puedo calmarlos.", "Son demasiado poderosos para que yo los calme.",
                "{master_nickname}, no puedo calmarlos.", "No tengo ninguna posibilidad."
            }},
            { SquireDialogTree.CantProvokeOne, new List<string> {
                "No puedo provocar solo a uno de ellos.", "*Falla al provocar a la criatura.*",
                "No puedo hacer que solo uno de ellos sea provocado.", "No serán provocados.",
                "{master_nickname}, no puedo hacer que solo uno de ellos sea provocado.", "No puedo provocar solo a uno."
            }},
            { SquireDialogTree.CantInciteAnger, new List<string> {
                "No puedo incitar su ira.", "*Falla al provocar a la criatura.*",
                "No puedo hacer que se enojen.", "No se enojarán.",
                "{master_nickname}, no puedo hacer que se enojen.", "No puedo incitar su ira."
            }},
            { SquireDialogTree.TooFarApartToProvoke, new List<string> {
                "Están demasiado lejos para que los provoque.", "*Falla al provocar a la criatura.*",
                "No puedo hacer que sean provocados, están demasiado lejos.", "No serán provocados, están demasiado lejos.",
                "{master_nickname}, no puedo hacer que sean provocados, están demasiado lejos.", "Están demasiado lejos."
            }},
            { SquireDialogTree.BadPerformance, new List<string> {
                "Esa fue una mala actuación.", "*Suspira derrotado.*",
                "No actué bien.", "Esa no fue mi mejor actuación.",
                "{master_nickname}, no actué bien.", "Esa fue una mala actuación."
            }},
            { SquireDialogTree.FailedPerformanceProvoke, new List<string> {
                "Fallé en provocarlos.", "*Falla al provocar a la criatura.*",
                "No pude hacer que fueran provocados.", "No serán provocados.",
                "{master_nickname}, no pude hacer que fueran provocados.", "Fallé en provocarlos."
            }},
            { SquireDialogTree.FailedPerformanceDiscord, new List<string> {
                "Fallé en discordarlos.", "*Falla al discordar a la criatura.*",
                "No pude hacer que fueran discordados.", "No serán discordados.",
                "{master_nickname}, no pude hacer que fueran discordados.", "Fallé en discordarlos."
            }},
            { SquireDialogTree.GoodPerformanceProvoke, new List<string> {
                "Esa fue una buena actuación.", "*Se inclina.*",
                "Actué bien.", "Esa fue mi mejor actuación.",
                "{master_nickname}, actué bien.", "Esa fue una buena actuación."
            }},
            { SquireDialogTree.GoodPerformanceDiscord, new List<string> {
                "Esa fue una buena actuación.", "*Se inclina.*",
                "Actué bien.", "Esa fue mi mejor actuación.",
                "{master_nickname}, actué bien.", "Esa fue una buena actuación."
            }},
            { SquireDialogTree.GoodPerformancePeace, new List<string> {
                "Esa fue una buena actuación.", "*Se inclina.*",
                "Actué bien.", "Esa fue mi mejor actuación.",
                "{master_nickname}, actué bien.", "Esa fue una buena actuación."
            }},
            { SquireDialogTree.ProvokeOnThemselves, new List<string> {
                "No puedo provocarlos a sí mismos.", "*Falla al provocar a la criatura.*",
                "No puedo hacer que se provoquen a sí mismos.", "No se provocarán a sí mismos.",
                "{master_nickname}, no puedo hacer que se provoquen a sí mismos.", "No puedo provocarlos a sí mismos."
            }},
            { SquireDialogTree.PeaceNobody, new List<string> {
                "No puedo pacificar a nadie.", "*Falla al pacificar a la criatura.*",
                "No puedo hacer que nadie sea pacificado.", "Nadie será pacificado.",
                "{master_nickname}, no puedo hacer que nadie sea pacificado.", "No puedo pacificar a nadie."
            }},
            { SquireDialogTree.ThisIsTooHeavy, new List<string> {
                "Esto es demasiado pesado para que lo levante.", "*Se esfuerza por levantar el objeto, pero no puede.*",
                "No puedo levantar esto.", "Esto es demasiado pesado.",
                "{master_nickname}, esto es demasiado pesado para que lo levante.", "Esto es demasiado pesado."
            }},
            { SquireDialogTree.TooHeavyForNow, new List<string> {
                "Estoy demasiado pesado para levantar eso ahora mismo.", "*Se esfuerza por levantar el objeto, pero no puede.*",
                "No puedo levantar esto ahora mismo.", "Estoy demasiado pesado ahora mismo.",
                "{master_nickname}, estoy demasiado pesado para levantar eso ahora mismo.", "Estoy demasiado pesado ahora mismo."
            }},
            { SquireDialogTree.ThankYou, new List<string> {
                "Gracias, {master_nickname}.", "*Se inclina.*",
                "Te lo agradezco, {master_nickname}.", "Gracias."
            }},
            { SquireDialogTree.ToldToShutUp, new List<string> {
                "Me callaré ahora.", "*Asiente.*",
                "No volveré a hablar hasta que me lo digas.", "Me callaré."
            }},
            { SquireDialogTree.CanTalkAgain, new List<string> {
                "¡Puedo hablar de nuevo!", "*Sonríe.*",
                "Estoy tan feliz de poder hablar de nuevo.", "Puedo hablar de nuevo."
            }},
            { SquireDialogTree.NoPotions, new List<string> {
                "No tengo ninguna poción.", "*Busca en su mochila.*",
                "No puedo encontrar ninguna poción.", "No tengo ninguna poción.",
                "{master_nickname}, no tengo ninguna poción.", "No tengo ninguna poción."
            }},
            { SquireDialogTree.TooSoonToDrink, new List<string> {
                "No puedo beber otra poción tan pronto.", "*Se tambalea.*",
                "Necesito esperar un momento antes de beber otra poción.", "No puedo beber otra poción tan pronto.",
                "{master_nickname}, no puedo beber otra poción tan pronto.", "No puedo beber otra poción tan pronto."
            }},
            { SquireDialogTree.AgilityPotion, new List<string> {
                "Me siento más ágil ahora.", "*Se estira.*",
                "Me siento mucho más ágil.", "Me siento más ágil."
            }},
            { SquireDialogTree.PoisonPotion, new List<string> {
                "Me siento enfermo.", "*Se ve pálido.*",
                "No me siento bien.", "Me siento enfermo."
            }},
            { SquireDialogTree.RefreshPotion, new List<string> {
                "Me siento renovado.", "*Toma una respiración profunda.*",
                "Me siento mucho más renovado.", "Me siento renovado."
            }},
            { SquireDialogTree.StrengthPotion, new List<string> {
                "Me siento más fuerte ahora.", "*Flexiona los músculos.*",
                "Me siento mucho más fuerte.", "Me siento más fuerte."
            }},
            { SquireDialogTree.HealthPotion, new List<string> {
                "Me siento más saludable ahora.", "*Se ve más saludable.*",
                "Me siento mucho más saludable.", "Me siento más saludable."
            }},
            { SquireDialogTree.CantHealthPotion, new List<string> {
                "No puedo beber una poción de salud ahora mismo.", "*Mira la poción.*",
                "Necesito esperar un momento antes de beber una poción de salud.", "No puedo beber una poción de salud ahora mismo.",
                "{master_nickname}, no puedo beber una poción de salud ahora mismo.", "No puedo beber una poción de salud ahora mismo."
            }},
            { SquireDialogTree.StillPoisoned, new List<string> {
                "Todavía estoy envenenado.", "*Se ve pálido.*",
                "No me siento bien.", "Todavía estoy envenenado."
            }},
            { SquireDialogTree.MortallyWoundedHP, new List<string> {
                "Estoy herido de muerte.", "*Se ve pálido.*",
                "No me siento bien.", "Estoy herido de muerte."
            }},
            { SquireDialogTree.CurePotion, new List<string> {
                "Me siento mejor ahora.", "*Se ve más saludable.*",
                "Me siento mucho más saludable.", "Me siento mejor."
            }},
            { SquireDialogTree.CantCurePotion, new List<string> {
                "No puedo beber una poción de cura ahora mismo.", "*Mira la poción.*",
                "Necesito esperar un momento antes de beber una poción de cura.", "No puedo beber una poción de cura ahora mismo.",
                "{master_nickname}, no puedo beber una poción de cura ahora mismo.", "No puedo beber una poción de cura ahora mismo."
            }},
            { SquireDialogTree.UsePowerScroll, new List<string> {
                "Me siento más poderoso ahora.", "*Se ve más fuerte.*",
                "Me siento mucho más poderoso.", "Me siento más poderoso."
            }},
            { SquireDialogTree.CantUsePowerScroll, new List<string> {
                "No puedo usar un pergamino de poder ahora mismo.", "*Mira el pergamino.*",
                "Necesito esperar un momento antes de usar un pergamino de poder.", "No puedo usar un pergamino de poder ahora mismo.",
                "{master_nickname}, no puedo usar un pergamino de poder ahora mismo.", "No puedo usar un pergamino de poder ahora mismo."
            }},
            { SquireDialogTree.MissingLockpicks, new List<string> {
                "No tengo ganzúas.", "*Busca en su mochila.*",
                "No puedo encontrar ganzúas.", "No tengo ganzúas.",
                "{master_nickname}, no tengo ganzúas.", "No tengo ganzúas."
            }},
            { SquireDialogTree.LockpickTooFar, new List<string> {
                "Eso está demasiado lejos para que lo fuerce.", "*Se esfuerza por alcanzar la cerradura, pero no puede.*",
                "No puedo alcanzar eso desde aquí.", "Eso está fuera de mi alcance.",
                "{master_nickname}, no puedo alcanzar eso.", "Eso está demasiado lejos."
            }},
            { SquireDialogTree.NotLocked, new List<string> {
                "Eso no está cerrado.", "*Mira la cerradura.*",
                "No necesito forzar eso.", "Eso no está cerrado."
            }},
            { SquireDialogTree.CannotUnlock, new List<string> {
                "No puedo desbloquear eso.", "*Mira la cerradura.*",
                "No sé cómo desbloquear eso.", "No puedo desbloquear eso."
            }},
            { SquireDialogTree.BrokenLockpick, new List<string> {
                "Mi ganzúa se rompió.", "*Suspira.*",
                "Rompí mi ganzúa.", "Mi ganzúa se rompió."
            }},
            { SquireDialogTree.AbnormalLock, new List<string> {
                "Esa cerradura es anormal.", "*Mira la cerradura.*",
                "No sé cómo desbloquear eso.", "Esa cerradura es anormal."
            }},
            { SquireDialogTree.HardLock, new List<string> {
                "Esa es una cerradura difícil.", "*Mira la cerradura.*",
                "No sé cómo desbloquear eso.", "Esa es una cerradura difícil."
            }},
            { SquireDialogTree.UnsuccessfulLockpick, new List<string> {
                "No tuve éxito al forzar la cerradura.", "*Suspira.*",
                "No pude forzar la cerradura.", "No tuve éxito al forzar la cerradura."
            }},
            { SquireDialogTree.SuccessfulLockpick, new List<string> {
                "He forzado la cerradura.", "*Sonríe.*",
                "He forzado la cerradura con éxito.", "He forzado la cerradura."
            }},
            { SquireDialogTree.HandsAreFull, new List<string> {
                "Mis manos están llenas.", "*Se mira las manos.*",
                "No puedo sostener nada más.", "Mis manos están llenas."
            }},
            { SquireDialogTree.StealingNotAllowedHere, new List<string> {
                "No puedo robar aquí.", "*Mira a su alrededor.*",
                "No se me permite robar aquí.", "No puedo robar aquí."
            }},
            { SquireDialogTree.NotAPartOfThievesGuild, new List<string> {
                "No soy parte del gremio de ladrones.", "*Se mira las manos.*",
                "No puedo robar, no soy parte del gremio de ladrones.", "No soy parte del gremio de ladrones."
            }},
            { SquireDialogTree.SuspendedFromThievesGuild, new List<string> {
                "Estoy suspendido del gremio de ladrones.", "*Se mira las manos.*",
                "No puedo robar, estoy suspendido del gremio de ladrones.", "Estoy suspendido del gremio de ladrones."
            }},
            { SquireDialogTree.CannotStealFromVendors, new List<string> {
                "No puedo robar a los vendedores.", "*Mira al vendedor.*",
                "No se me permite robar a los vendedores.", "No puedo robar a los vendedores."
            }},
            { SquireDialogTree.CannotSeeStealingTarget, new List<string> {
                "No puedo ver a qué le estoy robando.", "*Mira a su alrededor.*",
                "No puedo ver a mi objetivo.", "No puedo ver a qué le estoy robando."
            }},
            { SquireDialogTree.FullBackpackStealing, new List<string> {
                "Mi mochila está llena.", "*Mira su mochila.*",
                "No puedo sostener nada más.", "Mi mochila está llena."
            }},
            { SquireDialogTree.NeedToBeCloserToSteal, new List<string> {
                "Necesito estar más cerca para robarles.", "*Se esfuerza por alcanzar al objetivo, pero no puede.*",
                "No puedo alcanzarlos desde aquí.", "Están fuera de mi alcance.",
                "{master_nickname}, no puedo alcanzarlos.", "Están demasiado lejos."
            }},
            { SquireDialogTree.CannotStealThat, new List<string> {
                "No puedo robar eso.", "*Mira el objeto.*",
                "No sé cómo robar eso.", "No puedo robar eso."
            }},
            { SquireDialogTree.CannotStealWhileMorphed, new List<string> {
                "No puedo robar mientras estoy transformado.", "*Se mira las manos.*",
                "No se me permite robar mientras estoy transformado.", "No puedo robar mientras estoy transformado."
            }},
            { SquireDialogTree.NotSkilledEnoughToStealItem, new List<string> {
                "No soy lo suficientemente hábil para robar eso.", "*Mira el objeto.*",
                "No sé cómo robar eso.", "No soy lo suficientemente hábil para robar eso."
            }},
            { SquireDialogTree.CannotStealFromTheirHands, new List<string> {
                "No puedo robar de sus manos.", "*Se mira las manos.*",
                "No se me permite robar de sus manos.", "No puedo robar de sus manos."
            }},
            { SquireDialogTree.StealFromSelf, new List<string> {
                "No puedo robarme a mí mismo.", "*Se mira las manos.*",
                "No se me permite robarme a mí mismo.", "No puedo robarme a mí mismo."
            }},
            { SquireDialogTree.TooHeavyToSteal, new List<string> {
                "Eso es demasiado pesado para que lo robe.", "*Se esfuerza por levantar el objeto, pero no puede.*",
                "No puedo levantar esto.", "Esto es demasiado pesado.",
                "{master_nickname}, esto es demasiado pesado para que lo robe.", "Esto es demasiado pesado."
            }},
            { SquireDialogTree.SuccessfulSteal, new List<string> {
                "He robado el objeto.", "*Sonríe.*",
                "He robado el objeto con éxito.", "He robado el objeto."
            }},
            { SquireDialogTree.UnsuccessfulSteal, new List<string> {
                "No tuve éxito al robar el objeto.", "*Suspira.*",
                "No pude robar el objeto.", "No tuve éxito al robar el objeto."
            }},
            { SquireDialogTree.TooSoonToLockpick, new List<string> {
                "No puedo forzar cerraduras de nuevo tan pronto.", "*Se mira las manos.*",
                "Necesito esperar un momento antes de volver a forzar cerraduras.", "No puedo forzar cerraduras de nuevo tan pronto.",
                "{master_nickname}, no puedo forzar cerraduras de nuevo tan pronto.", "No puedo forzar cerraduras de nuevo tan pronto."
            }},
            { SquireDialogTree.TooSoonToSteal, new List<string> {
                "No puedo robar de nuevo tan pronto.", "*Se mira las manos.*",
                "Necesito esperar un momento antes de volver a robar.", "No puedo robar de nuevo tan pronto.",
                "{master_nickname}, no puedo robar de nuevo tan pronto.", "No puedo robar de nuevo tan pronto."
            }},
            { SquireDialogTree.WhatShouldISteal, new List<string> {
                "¿Qué debo robar?", "*Mira a su alrededor.*",
                "No sé qué robar.", "¿Qué debo robar?"
            }},
            { SquireDialogTree.LearnsFromContract, new List<string> {
                "He aprendido de este contrato.", "*Mira el contrato.*",
                "He aprendido una nueva habilidad.", "He aprendido de este contrato."
            }},
            { SquireDialogTree.RefusesToLootPlayers, new List<string> {
                "Me niego a saquear a los jugadores.", "*Mira al jugador.*",
                "No saquearé a los jugadores.", "Me niego a saquear a los jugadores."
            }},
            { SquireDialogTree.UnequipsTwoHandedForShield, new List<string> {
                "Debo desequipar mi arma de dos manos para usar un escudo.", "*Mira su arma.*",
                "No puedo usar un escudo con un arma de dos manos.", "Debo desequipar mi arma de dos manos para usar un escudo."
            }},
            { SquireDialogTree.FirstHandMissing, new List<string> {
                "Me falta la primera mano.", "*Se mira las manos.*",
                "No puedo usar un escudo sin mi primera mano.", "Me falta la primera mano."
            }},
            { SquireDialogTree.SecondHandMissing, new List<string> {
                "Me falta la segunda mano.", "*Se mira las manos.*",
                "No puedo usar un escudo sin mi segunda mano.", "Me falta la segunda mano."
            }},
            { SquireDialogTree.EmptyHands, new List<string> {
                "Mis manos están vacías.", "*Se mira las manos.*",
                "No tengo nada en mis manos.", "Mis manos están vacías."
            }},
            { SquireDialogTree.SuccessfulSetCreation, new List<string> {
                "He creado el conjunto con éxito.", "*Sonríe.*",
                "He creado el conjunto.", "He creado el conjunto con éxito."
            }},
            { SquireDialogTree.Unarmed, new List<string> {
                "Estoy desarmado.", "*Se mira las manos.*",
                "No tengo arma.", "Estoy desarmado."
            }},
            { SquireDialogTree.SpiritSpeakSuccess, new List<string> {
                "Puedo oír a los espíritus.", "*Mira a su alrededor.*",
                "Los espíritus me están hablando.", "Puedo oír a los espíritus."
            }},
            { SquireDialogTree.SpiritSpeakFail, new List<string> {
                "No puedo oír a los espíritus.", "*Mira a su alrededor.*",
                "Los espíritus no me están hablando.", "No puedo oír a los espíritus."
            }},
            { SquireDialogTree.TooSoonToSpiritSpeak, new List<string> {
                "No puedo hablar con los espíritus de nuevo tan pronto.", "*Se mira las manos.*",
                "Necesito esperar un momento antes de volver a hablar con los espíritus.", "No puedo hablar con los espíritus de nuevo tan pronto.",
                "{master_nickname}, no puedo hablar con los espíritus de nuevo tan pronto.", "No puedo hablar con los espíritus de nuevo tan pronto."
            }},
            { SquireDialogTree.SpiritChannelFades, new List<string> {
                "El canal espiritual se está desvaneciendo.", "*Mira a su alrededor.*",
                "Los espíritus me están abandonando.", "El canal espiritual se está desvaneciendo."
            }},
            { SquireDialogTree.StillConnectedToSpirits, new List<string> {
                "Todavía estoy conectado con los espíritus.", "*Mira a su alrededor.*",
                "Los espíritus todavía están conmigo.", "Todavía estoy conectado con los espíritus."
            }},
            { SquireDialogTree.OpenQuiver, new List<string> {
                "He abierto mi carcaj.", "*Mira su carcaj.*",
                "Mi carcaj está abierto.", "He abierto mi carcaj."
            }},
            { SquireDialogTree.NotAQuiver, new List<string> {
                "Eso no es un carcaj.", "*Mira el objeto.*",
                "No puedo abrir eso.", "Eso no es un carcaj."
            }},
            { SquireDialogTree.PoisonToApply, new List<string> {
                "¿Qué veneno debo aplicar?", "*Mira sus pociones.*",
                "No sé qué veneno aplicar.", "¿Qué veneno debo aplicar?"
            }},
            { SquireDialogTree.ApplyPoisonTo, new List<string> {
                "¿A qué debo aplicar el veneno?", "*Mira a su alrededor.*",
                "No sé a qué aplicar el veneno.", "¿A qué debo aplicar el veneno?"
            }},
            { SquireDialogTree.NotAPoisonPotion, new List<string> {
                "Esa no es una poción de veneno.", "*Mira la poción.*",
                "No puedo aplicar eso.", "Esa no es una poción de veneno."
            }},
            { SquireDialogTree.TooFarToPoison, new List<string> {
                "Eso está demasiado lejos para que lo envenene.", "*Se esfuerza por alcanzar al objetivo, pero no puede.*",
                "No puedo alcanzarlos desde aquí.", "Están fuera de mi alcance.",
                "{master_nickname}, no puedo alcanzarlos.", "Están demasiado lejos."
            }},
            { SquireDialogTree.CannotPoisonNotInfectious, new List<string> {
                "No puedo envenenar eso, no es infeccioso.", "*Mira al objetivo.*",
                "Solo puedo envenenar objetivos infecciosos.", "No puedo envenenar eso, no es infeccioso."
            }},
            { SquireDialogTree.CannotPoisonNotBPFoD, new List<string> {
                "No puedo envenenar eso, no es una hoja, perforante o arma de fuego.", "*Mira el arma.*",
                "Solo puedo envenenar hojas, armas perforantes o armas de fuego.", "No puedo envenenar eso, no es una hoja, perforante o arma de fuego."
            }},
            { SquireDialogTree.PoisoningSuccess, new List<string> {
                "He envenenado el objeto con éxito.", "*Sonríe.*",
                "He envenenado el objeto.", "He envenenado el objeto con éxito."
            }},
            { SquireDialogTree.PoisoningFailure, new List<string> {
                "No tuve éxito al envenenar el objeto.", "*Suspira.*",
                "No pude envenenar el objeto.", "No tuve éxito al envenenar el objeto."
            }},
            { SquireDialogTree.TerribleMistake, new List<string> {
                "He cometido un terrible error.", "*Se mira las manos.*",
                "Me he envenenado a mí mismo.", "He cometido un terrible error."
            }},
            { SquireDialogTree.NoAnkhNearby, new List<string> {
                "No hay ningún ankh cerca.", "*Mira a su alrededor.*",
                "No puedo encontrar un ankh.", "No hay ningún ankh cerca."
            }},
            { SquireDialogTree.TitheSuccess, new List<string> {
                "He diezmado con éxito.", "*Sonríe.*",
                "He diezmado.", "He diezmado con éxito."
            }},
            { SquireDialogTree.NoGoldToTithe, new List<string> {
                "No tengo oro para diezmar.", "*Mira su mochila.*",
                "No puedo encontrar oro.", "No tengo oro para diezmar."
            }},
            { SquireDialogTree.NotEnoughTithe, new List<string> {
                "No tengo suficiente oro para diezmar.", "*Mira su mochila.*",
                "No puedo encontrar suficiente oro.", "No tengo suficiente oro para diezmar."
            }},
            { SquireDialogTree.NotEnoughMana, new List<string> {
                "No tengo suficiente maná.", "*Se mira las manos.*",
                "No puedo lanzar un hechizo sin suficiente maná.", "No tengo suficiente maná."
            }},
            { SquireDialogTree.NoChivalryBook, new List<string> {
                "No tengo un libro de caballería.", "*Busca en su mochila.*",
                "No puedo encontrar un libro de caballería.", "No tengo un libro de caballería."
            }},
            { SquireDialogTree.TooSoonToMeditate, new List<string> {
                "No puedo meditar de nuevo tan pronto.", "*Se mira las manos.*",
                "Necesito esperar un momento antes de volver a meditar.", "No puedo meditar de nuevo tan pronto.",
                "{master_nickname}, no puedo meditar de nuevo tan pronto.", "No puedo meditar de nuevo tan pronto."
            }},
            { SquireDialogTree.TooSoonToCastASpell, new List<string> {
                "No puedo lanzar un hechizo de nuevo tan pronto.", "*Se mira las manos.*",
                "Necesito esperar un momento antes de volver a lanzar un hechizo.", "No puedo lanzar un hechizo de nuevo tan pronto.",
                "{master_nickname}, no puedo lanzar un hechizo de nuevo tan pronto.", "No puedo lanzar un hechizo de nuevo tan pronto."
            }},
            { SquireDialogTree.NotEnoughSpellSkill, new List<string> {
                "No soy lo suficientemente hábil para lanzar ese hechizo.", "*Se mira las manos.*",
                "No sé cómo lanzar ese hechizo.", "No soy lo suficientemente hábil para lanzar ese hechizo."
            }},
            { SquireDialogTree.NoExplosionPotion, new List<string> {
                "No tengo una poción de explosión.", "*Busca en su mochila.*",
                "No puedo encontrar una poción de explosión.", "No tengo una poción de explosión."
            }},
            { SquireDialogTree.SquireHasANewTeam, new List<string> {
                "¡Tengo un nuevo equipo!", "*Mira a su equipo.*",
                "Ahora soy parte del equipo {squire_team}.", "¡Tengo un nuevo equipo!"
            }},
            { SquireDialogTree.NoBushidoBook, new List<string> {
                "No tengo un libro de bushido.", "*Busca en su mochila.*",
                "No puedo encontrar un libro de bushido.", "No tengo un libro de bushido."
            }},
            { SquireDialogTree.NoNecroBook, new List<string> {
                "No tengo un libro de nigromancia.", "*Busca en su mochila.*",
                "No puedo encontrar un libro de nigromancia.", "No tengo un libro de nigromancia."
            }},
        };
    }
}
