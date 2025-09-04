using System;
using System.Collections.Generic;

namespace Server.Mobiles
{
    public static class SquireDialogData
    {
        public static Dictionary<SquireDialogTree, List<string>> Dialogs = new Dictionary<SquireDialogTree, List<string>>
        {
            { SquireDialogTree.HideFailure, new List<string> {
                "Esto es demasiado difícil...",
                "*No puedo comprender el concepto de esconderme.*",
                "Esconderme parece fuera de mi alcance en este momento.",
                "¡{master_nickname_upper}, TE HE FALLADO!",
                "He fallado al esconderme, {master_nickname}.",
                "Lo siento, {master_nickname}, he fallado al esconderme."
            }},
            { SquireDialogTree.TooSoonToHide, new List<string> {
                "¡Ah! ¡He fallado al esconderme! Espera... No, todavía es demasiado pronto.",
                "*Se tropieza con sus propios pies tratando de esconderse tan pronto.*",
                "Dame un tiempo, por favor.",
                "Necesito un momento.",
                "No intentaré esconderme de nuevo tan pronto, {master_nickname}.",
                "Es un poco pronto para intentar esconderme, {master_nickname}."
            }},
            { SquireDialogTree.MissingInstrument, new List<string> {
                "Un instrumento sería útil ahora mismo.",
                "*Toca 'el laúd más pequeño del mundo'.*",
                "¿Te gustaría que silbara?",
                "Necesito algo para tocar, {master_nickname}.",
                "Ahora, ¿dónde lo puse...",
                "No parece que tenga un instrumento, {master_nickname}."
            }},
            { SquireDialogTree.TooSoonToPlayMusic, new List<string> {
                "Podría romper mi instrumento tocando tan rápido.",
                "*Recupera el equilibrio después de intentar tocar de nuevo demasiado pronto.*",
                "No puedo tocar tan rápido.",
                "{master_nickname}, es un poco pronto.",
                "Podría desgarrarme un músculo si intento tocar demasiado pronto.",
                "Es demasiado pronto para tocar mi instrumento, {master_nickname}."
            }},
            { SquireDialogTree.MissingSnow, new List<string> {
                "La nieve está fuera de mi alcance.",
                "*Intenta recoger nieve del suelo y falla.*",
                "No hay nieve en mi mochila.",
                "{master_nickname}, ¿tendrías algo de nieve para que la lance?",
                "No parece que pueda encontrar nieve.",
                "No parece que tenga nieve, {master_nickname}."
            }},
            { SquireDialogTree.TooSoonToPackSnow, new List<string> {
                "No puedo hacer una bola con tan poca nieve.",
                "*Intenta y falla al hacer una bola de nieve.*",
                "La nieve es un poco escasa ahora mismo. Dale un momento.",
                "No puedo hacer una bola de nieve tan rápido, {master_nickname}.",
                "Hay muy poca nieve en este montón.",
                "Es demasiado pronto para intentar hacer una bola de nieve, {master_nickname}."
            }},
            { SquireDialogTree.MasterHasANewNickname, new List<string> {
                "Déjame intentar gritarlo... ¡{master_nickname_upper}! ¡Sí, eso funciona!",
                "*Está más que emocionado de referirse a ti como {master_nickname}.*",
                "¡{master_nickname} te queda muy bien!",
                "No puedo esperar a acostumbrarme a referirme a ti como {master_nickname}.",
                "{master_nickname}... De acuerdo.",
                "De acuerdo, me referiré a ti como {master_nickname} de ahora en adelante."
            }},
            { SquireDialogTree.SquireHasANewNickname, new List<string> {
                "Déjame intentar gritarlo... ¡{squire_nickname_upper}! ¡Sí, eso funciona!",
                "*¡Está más que emocionado de que se refieran a él como {squire_nickname}!*",
                "¡{squire_nickname} me queda muy bien!",
                "Estoy seguro de que me acostumbraré a que me llamen {squire_nickname} de ahora en adelante.",
                "{squire_nickname}... No es... Terrible...",
                "De acuerdo, responderé a {squire_nickname} de ahora en adelante."
            }},
            { SquireDialogTree.SquireHealsMaster, new List<string> {
                "Mantén la calma {squire_nickname}, {master_nickname} estará bien, haz tu trabajo.",
                "*Murmura una pequeña oración.*",
                "¡NO TE MUERAS, {master_nickname_upper}!",
                "Estarás bien, {master_nickname}, solo aguanta.",
                "Tus heridas no son las peores que he visto.",
                "Déjame vendar esa herida, {master_nickname}."
            }},
            { SquireDialogTree.SquireCuresMaster, new List<string> {
                "Este veneno desaparecerá rápidamente.",
                "*Mueve los labios diciendo 'An Nox'.*",
                "Este veneno no es TAN malo.",
                "Los magos de Moonglow me enseñaron este.",
                "Aprendí este pequeño remedio en Papúa durante mi juventud.",
                "Déjame intentar curarte, {master_nickname}."
            }},
            { SquireDialogTree.SquireRezsMaster, new List<string> {
                "Es demasiado pronto para que dejes este mundo, {master_nickname}.",
                "*Mueve los labios diciendo 'An Corp'.*",
                "{squire_nickname} te tiene, {master_nickname}.",
                "Esta es una técnica de curación que aprendí en Nujel'm.",
                "Soy un fracaso como escudero, por favor perdóname, {master_nickname}.",
                "Déjame intentar resucitarte, {master_nickname}."
            }},
            { SquireDialogTree.ASquiresConcern, new List<string> {
                "Por favor no te mueras, {master_nickname}.",
                "*Suda nerviosamente.*",
                "No puedo creer que perdí de vista a {master_nickname}, soy un escudero terrible.",
                "¡{master_nickname} está herido, pero no puedo verlo!",
                "¡{master_nickname_upper}, DÓNDE ESTÁS!",
                "¿{master_nickname}? ¡Por favor, muéstrate! ¿¡{master_nickname}!?"
            }},
            { SquireDialogTree.ASquiresStay, new List<string> {
                "No puedo moverme de donde estoy, {master_nickname}, por favor llámame.",
                "*Suda ansiosamente.*",
                "{squire_nickname} se quedará aquí, tal como {master_nickname} le dijo.",
                "Ayúdame a ayudarte, {master_nickname}. ¡Llámame!",
                "¡{master_nickname_upper}, ME DIJISTE QUE NO ME MOVIERA DE ESTE LUGAR!",
                "Estaría allí para curarte, {master_nickname}, pero me pediste que me quedara."
            }},
            { SquireDialogTree.SquiresNewName, new List<string> {
                "¿Qué tal, {squire_name}?",
                "*Piensa profundamente en {squire_name} como su nuevo nombre.*",
                "¿Cuál es mi nombre? ¡Qué tal {squire_name}!",
                "{squire_name} suena bien, ¿verdad?",
                "{master_nickname} y {squire_name}.",
                "Creo que el nombre {squire_name} me queda mejor, ¿no crees?"
            }},
            { SquireDialogTree.ShowingOffASquiresBackpack, new List<string> {
                "Mira el contenido de mi mochila si quieres.",
                "*Te abre su mochila con orgullo.*",
                "Estoy seguro de que el contenido de tu mochila es más interesante que el mío.",
                "Aquí está lo que tu pequeño {squire_nickname} está sosteniendo.",
                "¿Q-quieres ver mi qué? Oh, mi mochila.",
                "Aquí está lo que estoy sosteniendo."
            }},
            { SquireDialogTree.SquireCantReach, new List<string> {
                "Eso está un poco lejos para mí.",
                "*Intenta alcanzar el objetivo, pero falla.*",
                "¡Mis brazos no llegan!",
                "Está un poco fuera de mi alcance.",
                "{master_nickname}, ¿podrías acercarme?",
                "No puedo alcanzar eso desde aquí."
            }},
            { SquireDialogTree.SquireCantLiftNotItem, new List<string> {
                "Eso no es un objeto, así que no puedo levantarlo.",
                "*Intenta levantar el objetivo, pero falla.*",
                "¿Estás seguro?",
                "Eso no es algo que pueda llevar.",
                "¿Hablas en serio?",
                "No puedo levantar eso."
            }},
            { SquireDialogTree.SquireCantLiftItem, new List<string> {
                "No soy tan fuerte como tú, {master_nickname}.",
                "*Intenta levantar el objetivo, pero falla.*",
                "Parece un poco pesado.",
                "¿Se puede mover eso?",
                "Podría ser un poco pesado para mí.",
                "No pude levantar ese objeto."
            }},
            { SquireDialogTree.SquireCantLiftCorpse, new List<string> {
                "Parece que se está pudriendo. ¿Estás seguro de que no quieres que lo saquee?",
                "*Hace un intento débil de levantar el cadáver.*",
                "{master_nickname}... Eso es asqueroso.",
                "Parece que tiene objetos, ¿estás seguro de que no quieres que lo saquee?",
                "Me niego a levantar un cuerpo.",
                "No puedo levantar esto, ¿querías que lo saqueara en su lugar?"
            }},
            { SquireDialogTree.ItemIsNotCorpse, new List<string> {
                "Esto no se puede saquear.",
                "*Pincha el objeto antes de mirarte.*",
                "{master_nickname}... ¿Estás bien?",
                "No me parece un cadáver.",
                "Esto no es un cadáver.",
                "¿Querías decir agarrar?"
            }},
            { SquireDialogTree.SquireCantLootAllItems, new List<string> {
                "Había demasiado.",
                "*Los objetos se le escapan de las manos a {squire_name} y vuelven al cadáver.*",
                "No pude sostener todos los objetos.",
                "Había demasiado para que yo lo agarrara.",
                "Lo siento, {master_nickname}, pero no pude recoger todos los objetos.",
                "No pude recoger todos los objetos."
            }},
            { SquireDialogTree.SquireCantLootNotCorpse, new List<string> {
                "Eso no es un cadáver, así que no puedo saquearlo.",
                "*Intenta saquear el objetivo, pero falla.*",
                "¿Estás seguro?",
                "Eso no es algo que pueda saquear.",
                "¿Hablas en serio?",
                "No puedo saquear eso."
            }},
            { SquireDialogTree.SquireHealsWounded, new List<string> {
                "Mantén la calma {squire_nickname}, {creature_name} estará bien, haz tu trabajo.",
                "*Murmura una pequeña oración.*",
                "Me aseguraré de que no mueras, {creature_name}.",
                "Estarás bien, {creature_name}, solo aguanta.",
                "Tus heridas no son las peores que he visto.",
                "Déjame vendar esa herida, {creature_name}."
            }},
            { SquireDialogTree.SquireCuresHumanoid, new List<string> {
                "Este veneno desaparecerá rápidamente.",
                "*Mueve los labios diciendo 'An Nox'.*",
                "Este veneno no es TAN malo.",
                "Los magos de Moonglow me enseñaron este.",
                "Aprendí este pequeño remedio en Papúa durante mi juventud.",
                "Déjame intentar curarte, {creature_name}."
            }},
            { SquireDialogTree.SquireCuresAnimal, new List<string> {
                "Este veneno desaparecerá rápidamente.",
                "*Mueve los labios diciendo 'An Nox'.*",
                "Tu veneno no es tan malo, {creature_name}.",
                "Aprendí a cuidar animales en mis viajes, aquí...",
                "Los remedios de Papúa son potentes, me han dicho.",
                "Tranquilo, {creature_name}, pronto te curarás."
            }},
            { SquireDialogTree.SquireRezsHumanoid, new List<string> {
                "Es demasiado pronto para que dejes este mundo, {creature_name}.",
                "*Mueve los labios diciendo 'An Corp'.*",
                "{squire_name} te tiene, {creature_name}.",
                "Esta es una técnica de curación que aprendí en Nujel'm.",
                "{master_nickname} debe ser un buen amigo tuyo para que me pida hacer esto.",
                "Déjame intentar resucitarte, {creature_name}."
            }},
            { SquireDialogTree.SquireRezsAnimal, new List<string> {
                "Es demasiado pronto para que dejes este mundo, {creature_name}.",
                "*Mueve los labios diciendo 'An Corp'.*",
                "{squire_name} te tiene, {creature_name}.",
                "Esta es una técnica de curación que aprendí en Delucia.",
                "{master_nickname} es una persona amable.",
                "Déjame intentar resucitarte, {creature_name}."
            }},
            { SquireDialogTree.SquireCantRez, new List<string> {
                "Simplemente no tengo la habilidad para hacer esto.",
                "No puedo resucitar a {creature_name}.",
                "Lo siento, pero no hay nada que pueda hacer.",
                "Los magos de Moonglow no me prepararon lo suficiente para esto.",
                "Has sobrestimado mis habilidades, {master_nickname}, no puedo resucitar a {creature_name}.",
                "Me disculpo, {creature_name}, pero no puedo resucitarte porque no tengo la habilidad suficiente."
            }},
            { SquireDialogTree.WoundedIsNotHurtEnough, new List<string> {
                "Estarás bien pronto.",
                "*Se ríe entre dientes.*",
                "Estarán bien en un momento.",
                "Me niego a desperdiciar vendas.",
                "{master_nickname}, eres demasiado amable, sería un desperdicio de vendas en este momento.",
                "{creature_name} no está lo suficientemente herido."
            }},
            { SquireDialogTree.WoundedOutOfRange, new List<string> {
                "Están demasiado lejos.",
                "*Intenta estirar los brazos hacia {creature_name}.*",
                "Las vendas son más efectivas cuando se aplican directamente sobre la herida.",
                "No puedo alcanzar a {creature_name}.",
                "Este '{creature_name}' está demasiado lejos.",
                "{creature_name} está fuera de mi alcance."
            }},
            { SquireDialogTree.WoundedInvisible, new List<string> {
                "Debes ser capaz de ver lo invisible.",
                "*Lanza una venda al aire frente a ellos.* ¿Lo logré?",
                "Deben estar escondidos.",
                "¿Quieres que cure el aire?",
                "¿Qué me estás diciendo que cure?",
                "No puedo ver eso."
            }},
            { SquireDialogTree.SquireHealsPlayer, new List<string> {
                "Mantén la calma {squire_nickname}, {player_name} estará bien, haz tu trabajo.",
                "*Murmura una pequeña oración.*",
                "Me aseguraré de que no mueras, {player_name}.",
                "Estarás bien, {player_name}, solo aguanta.",
                "Tus heridas no son las peores que he visto.",
                "Déjame vendar esa herida, {player_name}."
            }},
            { SquireDialogTree.SquireCuresPlayer, new List<string> {
                "Este veneno desaparecerá rápidamente.",
                "*Mueve los labios diciendo 'An Nox'.*",
                "Este veneno no es TAN malo.",
                "Los magos de Moonglow me enseñaron este.",
                "Aprendí este pequeño remedio en Papúa durante mi juventud.",
                "Déjame intentar curarte, {player_name}."
            }},
            { SquireDialogTree.SquireRezsPlayer, new List<string> {
                "Es demasiado pronto para que dejes este mundo, {player_name}.",
                "*Mueve los labios diciendo 'An Corp'.*",
                "{squire_name} te tiene, {player_name}.",
                "Esta es una técnica de curación que aprendí en Nujel'm.",
                "{master_nickname} debe ser un buen amigo tuyo para que me pida hacer esto.",
                "Déjame intentar resucitarte, {player_name}."
            }},
            { SquireDialogTree.SquireCantRezPlayer, new List<string> {
                "Simplemente no tengo la habilidad para hacer esto.",
                "No puedo resucitar a {player_name}.",
                "Lo siento, pero no hay nada que pueda hacer.",
                "Los magos de Moonglow no me prepararon lo suficiente para esto.",
                "Has sobrestimado mis habilidades, {master_nickname}, no puedo resucitar a {player_name}.",
                "Me disculpo, {player_name}, pero no puedo resucitarte porque no tengo la habilidad suficiente."
            }},
            { SquireDialogTree.WoundedPlayerIsNotHurtEnough, new List<string> {
                "Estarás bien pronto.",
                "*Se ríe entre dientes.*",
                "Estarán bien en un momento.",
                "Me niego a desperdiciar vendas.",
                "{master_nickname}, eres demasiado amable, sería un desperdicio de vendas en este momento.",
                "{player_name} no está lo suficientemente herido."
            }},
            { SquireDialogTree.WoundedPlayerOutOfRange, new List<string> {
                "Están demasiado lejos.",
                "*Intenta estirar los brazos hacia {player_name}.*",
                "Las vendas son más efectivas cuando se aplican directamente sobre la herida.",
                "No puedo alcanzar a {player_name}.",
                "Este '{player_name}' está demasiado lejos.",
                "{player_name} está fuera de mi alcance."
            }},
            { SquireDialogTree.HealingTargetNotCreature, new List<string> {
                "¿Estás bien?",
                "*Mira confundido a {master_nickname}.*",
                "Las heridas son necesarias, y eso no puede ser herido.",
                "¿Por qué curaría eso?",
                "Eso no es una criatura.",
                "Eso no se puede curar."
            }},
            { SquireDialogTree.BeginProvoking, new List<string> {
                "¿A quién te gustaría que peleara con alguien?",
                "*Prepara el instrumento, mirándote en busca de un objetivo.*",
                "{master_nickname}, ¿a quién quieres que pelee?",
                "¿A quién debería provocar?",
                "¿A quién debería enfadar?",
                "¿A quién te gustaría que enfadara?"
            }},
            { SquireDialogTree.WheredMyInstrumentGo, new List<string> {
                "¡Estoy seguro de que estaba aquí!",
                "*Busca en su bolsa en busca del instrumento.*",
                "Mi instrumento... ¡Ha desaparecido!",
                "Ahora, ¿dónde lo puse...",
                "Qué raro, lo tenía aquí hace un momento...",
                "No encuentro mi instrumento."
            }},
            { SquireDialogTree.LoyalToTheirMaster, new List<string> {
                "Eso no funcionará en una criatura que pertenece a otra persona.",
                "Me niego a provocar a algo que pertenece a otra persona.",
                "Pertenece a otra persona, no puedo provocarlo.",
                "Esa criatura pertenece a otra persona.",
                "Esa criatura es demasiado leal a su amo para ser provocada.",
                "No puedo provocar a esto, es demasiado leal a su amo."
            }},
            { SquireDialogTree.CantDiscord, new List<string> {
                "Mi canción no afectaría a eso.",
                "¿Eso siquiera tiene oídos?",
                "No estoy seguro de que eso pueda ser discordado.",
                "Esa cosa no puede ser discordada.",
                "No creo que pueda cantar una canción de discordia a eso.",
                "Una canción de discordia no tendría efecto en eso."
            }},
            { SquireDialogTree.CantCalm, new List<string> {
                "Mi canción no afectaría a eso.",
                "¿Eso siquiera tiene oídos?",
                "No estoy seguro de que eso pueda ser calmado.",
                "¿Te golpeaste la cabeza, {master_nickname}?",
                "No creo que se pueda calmar un objeto inanimado...",
                "Eso no se puede calmar."
            }},
            { SquireDialogTree.CantCalmHere, new List<string> {
                "Mi canción no afectaría a eso aquí.",
                "Lo siento, no puedo tocar aquí.",
                "Esta área no me permite tocar música relajante.",
                "{master_nickname}, no puedo tocar una canción relajante aquí.",
                "Esta área tiene un aura extraña, no puedo calmar las cosas aquí.",
                "La pacificación no funcionará aquí."
            }},
            { SquireDialogTree.CantCalmThere, new List<string> {
                "Mi canción no afectaría a eso allí.",
                "Lo siento, no puedo tocar allí.",
                "Esa área no me permite tocar música relajante.",
                "{master_nickname}, no puedo tocar una canción relajante allí.",
                "Esa área tiene un aura extraña, no puedo calmar las cosas allí.",
                "La pacificación no funcionará allí."
            }},
            { SquireDialogTree.AlreadyDiscord, new List<string> {
                "Mi canción no afectaría de nuevo tan pronto.",
                "Otra canción de discordia no tendría efecto en eso.",
                "Eso no puede ser discordado de nuevo.",
                "No puedo discordar algo que ya está bajo el efecto de la canción.",
                "Lo siento, pero eso ya está discordado.",
                "Esa criatura ya está discordada."
            }},
            { SquireDialogTree.AlreadyCalmed, new List<string> {
                "Mi canción no afectaría de nuevo tan pronto.",
                "Otra canción de calma no tendría efecto en eso.",
                "Eso no puede ser calmado de nuevo.",
                "No puedo calmar algo que ya está calmado.",
                "Lo siento, pero eso ya está calmado.",
                "Esa criatura ya ha hecho las paces."
            }},
            { SquireDialogTree.NoChanceToProvoke, new List<string> {
                "Simplemente no hay nada que pueda hacer para provocar a esa criatura.",
                "Simplemente no tengo ninguna posibilidad de provocar a esa criatura.",
                "No puedo provocar a eso, simplemente no tengo ninguna posibilidad.",
                "Simplemente no tengo la oportunidad de provocar a esa criatura.",
                "Lo siento, {master_nickname}, pero no tengo ninguna posibilidad de provocar a eso.",
                "No tengo ninguna posibilidad de provocar a esta criatura."
            }},
            { SquireDialogTree.NoChanceToCalm, new List<string> {
                "Simplemente no hay nada que pueda hacer para calmar a esa criatura.",
                "Simplemente no tengo ninguna posibilidad de calmar a esa criatura.",
                "No puedo calmar a eso, simplemente no tengo ninguna posibilidad.",
                "Simplemente no tengo la oportunidad de calmar a esa criatura.",
                "Lo siento, {master_nickname}, pero no tengo ninguna posibilidad de calmar a eso.",
                "No tengo ninguna posibilidad de calmar a esta criatura."
            }},
            { SquireDialogTree.CantProvokeOne, new List<string> {
                "¿Ahora quién debería sentir su ira?",
                "¿A quién podemos hacer que este tipo pelee?",
                "¡Éxito! ¿Contra quién deberían pelear?",
                "{master_nickname}, ¿a quién te gustaría que atacaran?",
                "¡De acuerdo! ¡Están bastante enojados! ¿Contra quién quieres que peleen?",
                "¡Muy bien! Este está enojado, ¿a quién te gustaría que provocara para que atacara?"
            }},
            { SquireDialogTree.CantInciteAnger, new List<string> {
                "Eso no puede ser enfadado.",
                "Eso no puede sentir ira.",
                "La ira no puede ser incitada desde esto.",
                "{master_nickname}, ¿estás bien?",
                "Eso no puede sentir ira.",
                "¡No puedo provocar a eso!"
            }},
            { SquireDialogTree.TooFarApartToProvoke, new List<string> {
                "Están demasiado lejos.",
                "¿Podríamos acercarlos de alguna manera, {master_nickname}?",
                "No creo que esa criatura pueda enojarse con esta otra si están tan lejos.",
                "{master_nickname}, ¿tienes alguna idea de cómo podríamos acercarlos?",
                "Si tan solo pudiéramos acercarlos...",
                "Las dos criaturas están demasiado lejos la una de la otra para que yo las provoque."
            }},
            { SquireDialogTree.BadPerformance, new List<string> {
                "{squire_nickname} podría necesitar un poco más de práctica, {master_nickname}.",
                "*Intenta cubrirse la cara avergonzado por su pobre actuación.*",
                "Mi instrumento no debe estar afinado correctamente...",
                "Uf, ¿estaba en la clave equivocada?",
                "Parece que necesito un poco más de práctica.",
                "Lo siento, {master_nickname}, toqué lo mejor que pude."
            }},
            { SquireDialogTree.FailedPerformanceProvoke, new List<string> {
                "Podría necesitar un poco más de práctica...",
                "*Mira confundido a las criaturas.* ¿Por qué no están peleando?",
                "Mi instrumento no debe estar afinado correctamente...",
                "¿Toqué lo suficientemente bien?",
                "No pude incitar suficiente ira con mi música.",
                "Parece que no pude enfadarlos lo suficiente..."
            }},
            { SquireDialogTree.FailedPerformanceDiscord, new List<string> {
                "Podría necesitar un poco más de práctica...",
                "*Mira confundido a la criatura.* No parece más débil...",
                "Mi instrumento no debe estar afinado correctamente...",
                "¿Toqué lo suficientemente bien?",
                "No pude reducir su ataque con mi música.",
                "Parece que no pude desequilibrarlos..."
            }},
            { SquireDialogTree.GoodPerformanceProvoke, new List<string> {
                "¡Genial!",
                "*Parece muy contento mientras las dos criaturas comienzan a pelear.*",
                "¡{master_nickname}, mira cómo pelean!",
                "¡No puedo esperar a que se maten entre ellos!",
                "¡Mira cómo van!",
                "¡Sí! ¡Pelea!"
            }},
            { SquireDialogTree.GoodPerformanceDiscord, new List<string> {
                "¡Están desequilibrados!",
                "*Levanta el puño con éxito por su canción.*",
                "¡{master_nickname}, ve a por su garganta!",
                "¡Ahora es el momento de atacar!",
                "¡Están debilitados!",
                "¡Sí! ¡Siente el ataque reducido!"
            }},
            { SquireDialogTree.GoodPerformancePeace, new List<string> {
                "¡Su lucha ha cesado!",
                "*Suspira de alivio.*",
                "¡{master_nickname}, se han detenido!",
                "¡Dejen de pelear!",
                "¡Paz! ¡Jaja!",
                "¡Todos, CÁLMENSE!"
            }},
            { SquireDialogTree.ProvokeOnThemselves, new List<string> {
                "Lo siento, {master_nickname}, pero una criatura no puede luchar contra sí misma.",
                "*Está decepcionado de no poder hacer que alguien luche contra sí mismo.*",
                "No creo que su auto-odio sea lo suficientemente fuerte.",
                "No puedo hacerlo, {master_nickname}, no puedo hacer que luchen contra sí mismos.",
                "Ojalá se golpearan a sí mismos en la cara...",
                "No puedo hacer que esta criatura luche contra sí misma."
            }},
            { SquireDialogTree.PeaceNobody, new List<string> {
                "Lo siento, {master_nickname}, pero nadie escuchó mi canción.",
                "*Tararea feliz para sí mismo.*",
                "¡Nadie puede escuchar esta próxima canción!",
                "¡Música, que nadie puede oír!",
                "¡No hay nadie cerca para escuchar mi música!",
                "¡He tocado música hipnótica pero nadie puede oírla!"
            }},
            { SquireDialogTree.ThisIsTooHeavy, new List<string> {
                "Lo siento, {master_nickname}, pero no puedo usar esto.",
                "*Lucha intentando usar el objeto, entregándotelo dócilmente.*",
                "Por favor, toma esto de vuelta, no puedo usarlo eficazmente.",
                "¿Estás bromeando? ¡No puedo sostener esto! ¡Soy demasiado débil!",
                "{master_nickname}, esto es demasiado pesado para que lo use. Por favor, tómalo de vuelta.",
                "Lo siento, soy demasiado débil para usar esto."
            }},
            { SquireDialogTree.TooHeavyForNow, new List<string> {
                "Lo siento, {master_nickname}, pero no puedo usar esto ahora mismo, lo guardaré en mi mochila por ahora.",
                "*Falla al equipar una pieza de equipo, en su lugar la coloca en su mochila.*",
                "Guardaré esto en mi mochila por ahora, no puedo usarlo actualmente.",
                "Soy demasiado débil para este equipo ahora mismo, lo pondré en mi mochila.",
                "{master_nickname}, esto es demasiado pesado para que lo use en este momento, lo pondré en mi mochila.",
                "Lo siento, soy demasiado débil para usar esto ahora mismo."
            }},
            { SquireDialogTree.ThankYou, new List<string> {
                "¡Gracias, {master_nickname}, lo usaré bien!",
                "*Se pone el equipo con orgullo.*",
                "Prometo usar esto lo mejor que pueda.",
                "¡Estoy seguro de que esto me ayudará a ser más difícil de matar!",
                "¡{master_nickname}, muchas gracias por el equipo!",
                "¡Gracias! Le daré un buen uso."
            }},
            { SquireDialogTree.ToldToShutUp, new List<string> {
                "Está bien, {master_nickname}, me callaré.",
                "*Se cierra la cremallera del labio.*",
                "Claro.",
                "Dejaré de hablar ahora.",
                "Muy bien, {master_nickname}.",
                "Muy bien, me quedaré callado."
            }},
            { SquireDialogTree.CanTalkAgain, new List<string> {
                "Está bien, {master_nickname}, empezaré a hablar de nuevo.",
                "*Respira aliviado.*",
                "¡Claro!",
                "¡Empezaré a hablar de nuevo!",
                "¡Muy bien, {master_nickname}!",
                "¡Gracias, tenía mucho que decir!"
            }},
            { SquireDialogTree.NoPotions, new List<string> {
                "No puedo, {master_nickname}, no las encuentro en mi mochila.",
                "*Suspira profundamente, buscando la poción en su mochila.*",
                "No parece que pueda encontrar esas pociones en mi mochila.",
                "¡A dónde fueron! ¡No parece que pueda encontrarlas!",
                "Lo siento, {master_nickname}, pero no tengo esas pociones.",
                "No parece que tenga ninguna poción de ese tipo."
            }},
            { SquireDialogTree.TooSoonToDrink, new List<string> {
                "No puedo, {master_nickname}, no puedo tragar eso de inmediato.",
                "*Sacude la cabeza, tapando la botella y guardándola en su mochila.*",
                "Lo siento, simplemente no puedo tragar eso de nuevo tan pronto.",
                "Simplemente no puedo tragar eso de nuevo tan pronto.",
                "Lo siento, {master_nickname}, pero no puedo tragar más de esa mezcla.",
                "No puedo beber eso de inmediato."
            }},
            { SquireDialogTree.AgilityPotion, new List<string> {
                "¡Muchas gracias, {master_nickname}, me siento increíble!",
                "*Respira hondo, sintiéndose eufórico.*",
                "¡Me siento considerablemente más ligero!",
                "¿¡Qué había en esa poción!?",
                "¡Guau, {master_nickname}, me siento genial!",
                "¡Siento que podría correr más lejos!"
            }},
            { SquireDialogTree.PoisonPotion, new List<string> {
                "Muchas gracias, {master_nickname}, siento que me estoy muriendo...",
                "*Contiene la respiración, esperando no vomitar.*",
                "Ya me siento considerablemente enfermo, ¿qué me hiciste?",
                "¿Qué había en esa poción?",
                "{master_nickname}, ¿qué hiciste?",
                "No me siento muy bien..."
            }},
            { SquireDialogTree.RefreshPotion, new List<string> {
                "¡Muchas gracias, {master_nickname}, me siento genial!",
                "*Respira hondo, sintiéndose renovado.*",
                "¡Me siento considerablemente mejor!",
                "¡Esto es increíble! ¡Me siento genial! ¡YO! ¡PUEDO! ¡HACER! ¡ESTO!",
                "¡Guau, {master_nickname}, me siento renovado!",
                "¡Me siento absolutamente renovado!"
            }},
            { SquireDialogTree.StrengthPotion, new List<string> {
                "¡Muchas gracias, {master_nickname}, me siento más fuerte!",
                "*Abre los ojos bruscamente, una señal de gran fuerza.*",
                "¡La fuerza fluye por mis venas!",
                "¡Esto es increíble! ¡Me siento genial! ¡YO! ¡PUEDO! ¡HACER! ¡ESTO!",
                "¡Guau, {master_nickname}, me siento más fuerte!",
                "¡Me siento mucho más fuerte!"
            }},
            { SquireDialogTree.HealthPotion, new List<string> {
                "¡Muchas gracias, {master_nickname}, me siento mucho mejor!",
                "*Sus articulaciones y heridas se estremecen mientras comienzan a sanar.*",
                "¡Puedo sentir mis heridas sanando!",
                "¡Mis órganos se sienten mucho mejor!",
                "{master_nickname}, gracias por esta bebida.",
                "Eso está mejor."
            }},
            { SquireDialogTree.CantHealthPotion, new List<string> {
                "Muchas gracias, {master_nickname}, pero no puedo, me siento demasiado bien.",
                "*Guarda la poción de salud de nuevo en su mochila.*",
                "¡No te preocupes por mí!",
                "Me siento un poco demasiado bien para beber una poción de salud en este momento.",
                "{master_nickname}, no puedo, la guardaré de nuevo en mi mochila.",
                "No estoy lo suficientemente herido como para beber esta mezcla."
            }},
            { SquireDialogTree.StillPoisoned, new List<string> {
                "¿Puedo tomar una poción de cura primero, {master_nickname}? Esta poción de salud no me servirá de nada de lo contrario.",
                "*Guarda la poción de salud de nuevo en su mochila.*",
                "¡Esto no me servirá de nada mientras esté envenenado!",
                "Lo siento, no puedo tragar esto mientras estoy envenenado.",
                "{master_nickname}, no puedo, todavía estoy envenenado.",
                "No puedo beber una poción de salud mientras estoy envenenado."
            }},
            { SquireDialogTree.MortallyWoundedHP, new List<string> {
                "Necesito vendas primero, {master_nickname}. Esta poción de salud no me servirá de nada de lo contrario.",
                "*Guarda la poción de salud de nuevo en su mochila.*",
                "¡Esto no me servirá de nada mientras esté herido tan gravemente!",
                "Lo siento, no puedo tragar esto mientras tengo una gran herida en el estómago.",
                "{master_nickname}, no puedo, todavía estoy mortalmente herido.",
                "No puedo beber una poción de salud mientras estoy mortalmente herido."
            }},
            { SquireDialogTree.CurePotion, new List<string> {
                "¡Muchas gracias, {master_nickname}, me siento un poco mejor!",
                "*El dolor en su rostro se desvanece para dar paso al alivio.*",
                "¡Puedo sentir mi estómago sanando!",
                "¡Me siento menos enfermo!",
                "{master_nickname}, gracias por esta bebida.",
                "Me siento un poco mejor."
            }},
            { SquireDialogTree.CantCurePotion, new List<string> {
                "¡No puedo, {master_nickname}, no me siento enfermo!",
                "*Guarda la poción de cura de nuevo en su mochila.*",
                "No hay razón para que beba una poción de cura ahora.",
                "Me niego a desperdiciar tus recursos, {master_nickname}.",
                "{master_nickname}, tendría que estar envenenado antes de tragar esa... Mezcla.",
                "Eso sería un desperdicio, no estoy envenenado."
            }},
            { SquireDialogTree.UsePowerScroll, new List<string> {
                "¡Gracias, {master_nickname}, siento que hay más por saber!",
                "*Respira hondo, sintiendo que hay más que puede aprender.*",
                "Hay mucho más en este mundo de lo que imaginaba.",
                "Tengo una mayor sed de conocimiento, {master_nickname}.",
                "{master_nickname}, siento que puedo aprender más ahora.",
                "¡Puedo sentir mis límites aumentando!"
            }},
            { SquireDialogTree.CantUsePowerScroll, new List<string> {
                "¡No puedo, {master_nickname}, mis límites para este conocimiento ya son más altos!",
                "*Guarda el pergamino de poder en su mochila.*",
                "No hay razón para que use esto, ya que mis límites ya son más altos.",
                "Me niego a desperdiciar tu pergamino de poder, {master_nickname}.",
                "{master_nickname}, no puedo usar este pergamino de poder, lo guardaré en mi mochila.",
                "No puedo usar este pergamino de poder, mis límites ya son más altos que esto."
            }},
            { SquireDialogTree.MissingLockpicks, new List<string> {
                "Lo siento, {master_nickname}, parece que me he quedado sin ganzúas.",
                "*Busca ganzúas en su mochila, sin encontrar ninguna.*",
                "No parece que haya ninguna ganzúa en mi mochila.",
                "No puedo encontrar mis ganzúas, {master_nickname}.",
                "{master_nickname}, no parece que tenga ninguna ganzúa.",
                "No parece que pueda localizar mis ganzúas..."
            }},
            { SquireDialogTree.LockpickTooFar, new List<string> {
                "I can't, {master_nickname}, lockpicking takes a delicate touch, I need to be closer.",
                "*Is frustrated they aren't closer to the lock to pick it.*",
                "I need to be right next to a lock to pick it.",
                "I cannot pick a lock that far away, {master_nickname}.",
                "{master_nickname}, that is too far away for me to attempt to pick it.",
                "I can't pick that lock this far away."
            }},
            { SquireDialogTree.NotLocked, new List<string> {
                "I can't, {master_nickname}, this isn't locked.",
                "*Puts their lockpicks away, there is no job to be done here.*",
                "This isn't locked.",
                "I cannot pick a lock that isn't actually locked, {master_nickname}.",
                "{master_nickname}, this isn't locked.",
                "This doesn't appear to be locked."
            }},
            { SquireDialogTree.CannotUnlock, new List<string> {
                "I can't, {master_nickname}, I cannot unlock this.",
                "*Cannot unlock this.*",
                "I see no way in which I can unlock this.",
                "I cannot pick this lock, {master_nickname}.",
                "{master_nickname}, I cannot unlock this.",
                "I can't unlock this!"
            }},
            { SquireDialogTree.BrokenLockpick, new List<string> {
                "I'm sorry, {master_nickname}, my lockpick broke.",
                "*The lockpick breaks in their hand.*",
                "My lockpick seems to have broken.",
                "I broke my lockpick, {master_nickname}.",
                "{master_nickname}, I broke a lockpick.",
                "I broke a lockpick!"
            }},
            { SquireDialogTree.AbnormalLock, new List<string> {
                "I'm sorry, {master_nickname}, I do not think this can be unlocked by normal means.",
                "*Is perplexed by this lock.*",
                "This cannot be unlocked by normal means.",
                "This is a strange lock, {master_nickname}.",
                "{master_nickname}, I do not believe this lock can be picked by normal means.",
                "This doesn't look like it can be unlocked by normal means!"
            }},
            { SquireDialogTree.HardLock, new List<string> {
                "I'm sorry, {master_nickname}, I'm not skilled enough to unlock this.",
                "*Admits defeat to this lock.*",
                "This lock seems tougher than the others I've seen.",
                "I don't think I can unlock this right now, {master_nickname}.",
                "{master_nickname}, I think I need to train a bit more before we try this one.",
                "I don't see how this lock can be manipulated."
            }},
            { SquireDialogTree.UnsuccessfulLockpick, new List<string> {
                "I'm sorry, {master_nickname}, let me try picking that again.",
                "*Was unable to pick the lock.*",
                "I couldn't pick this lock.",
                "I wasn't successful in picking this lock, {master_nickname}.",
                "{master_nickname}, I failed to pick this lock.",
                "I was unable to pick this lock."
            }},
            { SquireDialogTree.SuccessfulLockpick, new List<string> {
                "I've done it, {master_nickname}, the lock has been picked!",
                "*Was able to pick the lock.*",
                "Have at the contents, {master_nickname}!",
                "I was successful in picking this lock, {master_nickname}!",
                "{master_nickname}, I've successfully picked the lock!",
                "The lock has yielded to my skill!"
            }},
            { SquireDialogTree.HandsAreFull, new List<string> {
                "I can't, {master_nickname}, my hands are full.",
                "*Hands are a little too full.*",
                "I need to empty my hands, {master_nickname}!",
                "I've got my hands a little full here, {master_nickname}!",
                "{master_nickname}, I need to the items in my hands away first.",
                "My hands are a little full to steal."
            }},
            { SquireDialogTree.StealingNotAllowedHere, new List<string> {
                "I cannot do it, {master_nickname}, I cannot steal in this area!",
                "*Is confused by the invisible force stopping them from stealing.*",
                "This area won't allow us to steal, {master_nickname}!",
                "I can't steal in this area, {master_nickname}!",
                "{master_nickname}, we cannot steal here.",
                "Stealing isn't allowed in this area."
            }},
            { SquireDialogTree.NotAPartOfThievesGuild, new List<string> {
                "I can't, {master_nickname}, we need to join the thieves guild!",
                "*Cannot steal from another player without first joining the thieves guild.*",
                "Join the thieves guild first, {master_nickname}!",
                "We cannot steal from players unless we're in the thieves guild, {master_nickname}!",
                "{master_nickname}, we need to join the thieves guild!",
                "We cannot steal from players because we are not a part of the thieves guild."
            }},
            { SquireDialogTree.SuspendedFromThievesGuild, new List<string> {
                "I can't, {master_nickname}, we're suspended from the guild!",
                "*Suspention from the guild stops them.*",
                "We cannot steal from players while suspended from the guild, {master_nickname}!",
                "Suspention is preventing us from stealing from other players, {master_nickname}!",
                "{master_nickname}, we cannot steal from players while suspended!",
                "We're currently on suspention in the thieves guild!"
            }},
            { SquireDialogTree.CannotStealFromVendors, new List<string> {
                "That is a vendor, {master_nickname}, we cannot steal from them!",
                "*Refuses to steal from a vendor.*",
                "Vendors cannot be stolen from, {master_nickname}!",
                "We cannot steal from vendors, {master_nickname}!",
                "{master_nickname}, we cannot steal from vendors!",
                "We cannot steal from vendors!"
            }},
            { SquireDialogTree.CannotSeeStealingTarget, new List<string> {
                "I can't see it, {master_nickname}, maybe if you brought me closer?",
                "*Unable to locate the item you want them to steal.*",
                "I cannot see it, {master_nickname}!",
                "I'd have to be able to see what you want me to steal, {master_nickname}!",
                "{master_nickname}, I cannot steal what I cannot see.",
                "I cannot see that."
            }},
            { SquireDialogTree.FullBackpackStealing, new List<string> {
                "My backpack is full, {master_nickname}, I cannot fit any more.",
                "*Cannot stuff any more items in their backpack.*",
                "My backpack cannot hold anymore, {master_nickname}!",
                "There is no more that I can fit in my backpack, {master_nickname}!",
                "{master_nickname}, my backpack is full.",
                "My backpack cannot hold any more."
            }},
            { SquireDialogTree.NeedToBeCloserToSteal, new List<string> {
                "I can't steal it, {master_nickname}, I'm too far away.",
                "*Arms cannot reach that far.*",
                "I am too far away from the target to steal it, {master_nickname}!",
                "I can't steal the target this far away, {master_nickname}!",
                "{master_nickname}, bring me closer to the target.",
                "I need to be closer to the target to steal it."
            }},
            { SquireDialogTree.CannotStealThat, new List<string> {
                "I cannot steal that, {master_nickname}, what do you expect from me?",
                "*Is unable to steal that.*",
                "I can't steal that, {master_nickname}!",
                "What do you expect of me, {master_nickname}!",
                "{master_nickname}, that is not something I can steal!",
                "I cannot steal that!"
            }},
            { SquireDialogTree.CannotStealWhileMorphed, new List<string> {
                "I can't steal, {master_nickname}, not while I'm transformed.",
                "*is unable to steal while transformed.*",
                "This transformation prevents me from stealing, {master_nickname}!",
                "I will be unable to steal until I transform back, {master_nickname}!",
                "{master_nickname}, I cannot steal while I'm something or somebody else.",
                "I cannot steal while I'm not myself!"
            }},
            { SquireDialogTree.NotSkilledEnoughToStealItem, new List<string> {
                "I'm not skilled enough, {master_nickname}, I cannot steal that item.",
                "*Realizes they are not skilled enough to steal that item.*",
                "I cannot steal that item now, {master_nickname}.",
                "I need to train more, {master_nickname}.",
                "{master_nickname}, I need to train more first.",
                "I am not skilled enough to steal that item."
            }},
            { SquireDialogTree.CannotStealFromTheirHands, new List<string> {
                "I'm not skilled enough, {master_nickname}, not skilled enough to steal directly from their hands.",
                "*Is unsure of their ability to steal straight from that person's hand.*",
                "They would certainly notice us, {master_nickname}.",
                "Perhaps something from their backpack instead, {master_nickname}.",
                "{master_nickname}, I don't think I am skilled enough to take the item from their hands.",
                "It would be foolish for us to attempt to steal from their hands."
            }},
            { SquireDialogTree.StealFromSelf, new List<string> {
                "I could just give it to you, {master_nickname}, I don't need to steal it from myself.",
                "*Is confused as to why they were told to steal their own item.*",
                "That's a little strange, {master_nickname}.",
                "Wouldn't you rather I just hand it to you, {master_nickname}?",
                "{master_nickname}, I've caught myself trying to steal!",
                "Aha! I've caught you! Wait..."
            }},
            { SquireDialogTree.TooHeavyToSteal, new List<string> {
                "That would be too heavy, {master_nickname}, I would not be able to move it.",
                "*Cannot move that item fast enough with how heavy it is.*",
                "That is too heavy to steal, {master_nickname}.",
                "Perhaps if I was stronger, {master_nickname}.",
                "{master_nickname}, I wouldn't be able to move that fast enough.",
                "That is too heavy to steal."
            }},
            { SquireDialogTree.SuccessfulSteal, new List<string> {
                "I've succeeded in stealing the item, {master_nickname}, we should run!",
                "*Quickly pockets the item.*",
                "I've got it, {master_nickname}!",
                "I've succeeded, {master_nickname}!",
                "{master_nickname}, I've succeeded in stealing!",
                "I've successfully stolen the item!"
            }},
            { SquireDialogTree.UnsuccessfulSteal, new List<string> {
                "I've failed to steal the item, {master_nickname}, are we gonna be alright?",
                "*Was unable to liberate the item from its owner.*",
                "I've failed to take the item, {master_nickname}.",
                "I was unable to steal the item, {master_nickname}.",
                "{master_nickname}, I've failed to steal the item.",
                "I've failed to steal the item."
            }},
            { SquireDialogTree.TooSoonToLockpick, new List<string> {
                "Give me one moment, {master_nickname}, then I'll be ready to try again.",
                "*Sighs in defeat, needs another moment before trying again.*",
                "I can't pick the lock again right away, {master_nickname}.",
                "I need a little time, {master_nickname}.",
                "{master_nickname}, let me prepare myself first.",
                "I need a moment."
            }},
            { SquireDialogTree.TooSoonToSteal, new List<string> {
                "Give me one moment, {master_nickname}, then I'll be ready to try again.",
                "*Sighs in defeat, needs another moment before trying again.*",
                "I can't attempt to steal again right away, {master_nickname}.",
                "I need a little time, {master_nickname}.",
                "{master_nickname}, let me prepare myself first.",
                "I need a moment."
            }},
            { SquireDialogTree.WhatShouldISteal, new List<string> {
                "Point me to the target, {master_nickname}, I'll steal it on your command.",
                "*Awaits stealing orders.*",
                "Point to the target, {master_nickname}.",
                "Point to the item, {master_nickname}.",
                "{master_nickname}, what's the target?",
                "What should I steal?"
            }},
            { SquireDialogTree.LearnsFromContract, new List<string> {
                "That's great, {master_nickname}, I feel like I know so much more!",
                "*Feels much more intelligent.*",
                "Thank you, {master_nickname}, I've learned a lot!",
                "I've learned so much, {master_nickname}!",
                "{master_nickname}, I feel smarter!",
                "I feel more intelligent already!"
            }},
            { SquireDialogTree.RefusesToLootPlayers, new List<string> {
                "No can do, {master_nickname}, I would be going against the virtues.",
                "*Feels very uneasy about looting this person.*",
                "I'm sorry, {master_nickname}, I simply cannot loot them.",
                "This would be wrong, {master_nickname}!",
                "{master_nickname}, I don't feel right looting this person.",
                "I refuse to loot a player."
            }},
            { SquireDialogTree.UnequipsTwoHandedForShield, new List<string> {
                "Thanks, {master_nickname}, please take this two handed weapon back in exchange!",
                "*Trades the two handed weapon they were using for the shield.*",
                "Thank you, {master_nickname}, please take this two handed weapon back.",
                "With this shield, I can no longer use that two handed weapon you gave me, {master_nickname}!",
                "{master_nickname}, I'm no longer using that two handed weapon you gave me.",
                "I've removed the two handed weapon I was holding."
            }},
            { SquireDialogTree.FirstHandMissing, new List<string> {
                "Sorry, {master_nickname}, I seem to have lost the item!",
                "*Rifles through their backpack unable to locate the item.*",
                "I'm sorry, {master_nickname}, I seem to have lost the item you want me to hold.",
                "Where did I put it, {master_nickname}!",
                "{master_nickname}, I can't seem to find the first item I'm to hold.",
                "I can't seem to find what I'm supposed to be holding in my first hand..."
            }},
            { SquireDialogTree.SecondHandMissing, new List<string> {
                "Sorry, {master_nickname}, I seem to have lost the item!",
                "*Rifles through their backpack unable to locate the item.*",
                "I'm sorry, {master_nickname}, I seem to have lost the item you want me to hold.",
                "Where did I put it, {master_nickname}!",
                "{master_nickname}, I can't seem to find the item I'm to hold.",
                "I can't seem to find what I'm supposed to be holding in my second hand..."
            }},
            { SquireDialogTree.EmptyHands, new List<string> {
                "Okay, {master_nickname}, I'll go barehanded!",
                "*Clenches fists, punching the air before them.*",
                "Alright, {master_nickname}, I'll fight empty handed.",
                "Bare handed I go, {master_nickname}!",
                "{master_nickname}, I suppose wrestling will be my skill then?",
                "Guess I'm going empty handed!"
            }},
            { SquireDialogTree.SuccessfulSetCreation, new List<string> {
                "Okay, {master_nickname}, I'll fight with bravery!",
                "*Grips equipment accepting their place.*",
                "Alright, {master_nickname}, I'll fight with these.",
                "Weapon set created, {master_nickname}.",
                "{master_nickname}, I will use these weapons bravely.",
                "Alright, set created!"
            }},
            { SquireDialogTree.Unarmed, new List<string> {
                "Okay, {master_nickname}, I've unarmed myself.",
                "*Places equipment away in their backpack.*",
                "Alright, {master_nickname}, I've stored my equipment.",
                "Equipment has been stored, {master_nickname}.",
                "{master_nickname}, I have unequipped myself.",
                "Alright, I've put the items I was holding in my backpack."
            }},
            { SquireDialogTree.SpiritSpeakSuccess, new List<string> {
                "Okay, {master_nickname}, let's hear the spirits.",
                "*Humms a mantra as they begin communing with spirits.*",
                "So, {master_nickname}, I can talk to spirits.",
                "I've done it, {master_nickname}, I've channeled the spirit world.",
                "{master_nickname}, I can now commune with ghosts.",
                "I've successfully channeled the spirit world."
            }},
            { SquireDialogTree.SpiritSpeakFail, new List<string> {
                "I'm sorry, {master_nickname}, I cannot hear the spirits.",
                "*Grimaces as they fail to channel the spirit world.*",
                "Sorry, {master_nickname}, I cannot speak with spirits.",
                "I have failed, {master_nickname}.",
                "{master_nickname}, I am unable to commune with ghosts.",
                "I've failed to channel the spirit world."
            }},
            { SquireDialogTree.TooSoonToSpiritSpeak, new List<string> {
                "I can't channel again so soon.",
                "*Attempts to channel the spirits but fails.*",
                "My connection with the spirit world is weak.",
                "I cannot attempt to channel spirits again this soon, {master_nickname}.",
                "The channels are weak, I need time.",
                "It is too soon to try to commune with spirits again, {master_nickname}."
            }},
            { SquireDialogTree.SpiritChannelFades, new List<string> {
                "I can no longer talk to the spirits.",
                "*Feels their connection with the spirits fade.*",
                "The channel I had to the spirit world has faded.",
                "My connection to the spirit world is gone, {master_nickname}.",
                "My communion with the spirit world has ended.",
                "My channel to the spirit world is fading, {master_nickname}."
            }},
            { SquireDialogTree.StillConnectedToSpirits, new List<string> {
                "I am still able to talk to the spirits.",
                "*Is still connected to the spirits.*",
                "The channel I had to the spirit world is currently active.",
                "My connection to the spirit world is still active, {master_nickname}.",
                "My communion with the spirit world is still channelled.",
                "My channel to the spirit world is still in tact, {master_nickname}."
            }},
            { SquireDialogTree.OpenQuiver, new List<string> {
                "Look at the contents of my quiver if you want.",
                "*Proudly opens their quiver to you.*",
                "I am sure your backpack's contents are more interesting than my quiver.",
                "Here is what your little {squire_nickname} is holding.",
                "Y-you'd like to see my what? Oh, my quiver.",
                "Here is what is in my quiver."
            }},
            { SquireDialogTree.NotAQuiver, new List<string> {
                "Are you okay, {master_nickname}.",
                "*Briefly looks over their shoulder at their back.*",
                "I do not believe I am wearing a quiver, {master_nickname}.",
                "There is no quiver on my back.",
                "I apologize, {master_nickname}, but I am not holding a quiver.",
                "I am not wearing a quiver, though."
            }},
            { SquireDialogTree.PoisonToApply, new List<string> {
                "What poison should be used, {master_nickname}?",
                "*Is ready for you to choose the poison for them to use.*",
                "Which bottle should I use, {master_nickname}?",
                "Which poison should I use?",
                "What poison do you want me to use, {master_nickname}?",
                "What poison should I use?"
            }},
            { SquireDialogTree.ApplyPoisonTo, new List<string> {
                "What needs some poison, {master_nickname}?",
                "*Readies their poison.*",
                "What would you have me poison, {master_nickname}?",
                "What is it I should poison?",
                "What should I poison, {master_nickname}?",
                "What would you like me to apply the poison to?"
            }},
            { SquireDialogTree.NotAPoisonPotion, new List<string> {
                "That is not poison, {master_nickname}.",
                "*Is confused by that not being poison.*",
                "I see no poison here.",
                "That doesn't appear to be poison.",
                "Are you sure that's poison, {master_nickname}?",
                "That is not a poison potion."
            }},
            { SquireDialogTree.TooFarToPoison, new List<string> {
                "You're a little too far for that, {master_nickname}.",
                "*Eyes the distance between you two.*",
                "I cannot poison something so far away.",
                "Your backpack is a little too far away for me to reach.",
                "Could you come closer, {master_nickname}?",
                "You're too far away for me to use that."
            }},
            { SquireDialogTree.CannotPoisonNotInfectious, new List<string> {
                "I cannot poison that, it is not infectious, {master_nickname}.",
                "*Is unable to poison that item.*",
                "It is impossible for me to poison that.",
                "I cannot poison something that cannot be infected.",
                "That is not infectious, {master_nickname}.",
                "I am sorry, {master_nickname}, but I cannot poison something that is not infectious."
            }},
            { SquireDialogTree.CannotPoisonNotBPFoD, new List<string> {
                "I cannot poison that, it is not bladed, piercing, food or drink, {master_nickname}.",
                "*Is unable to poison that item.*",
                "It is impossible for me to poison that.",
                "I cannot poison something that is not bladed, piercing, food or drink.",
                "That is not bladed, piercing, food or drink, {master_nickname}.",
                "I am sorry, {master_nickname}, but I cannot poison something that is not bladed, piercing, or food or drink."
            }},
            { SquireDialogTree.PoisoningSuccess, new List<string> {
                "It was a success, {master_nickname}.",
                "*Grins as their poisoning succeeds.*",
                "The item has been poisoned.",
                "Poisoning has happened successfully.",
                "I've applied the poison, {master_nickname}!",
                "I've succeeded in applying the poison!"
            }},
            { SquireDialogTree.PoisoningFailure, new List<string> {
                "It was a failure, {master_nickname}.",
                "*Grimaces as they fail their poisoning.*",
                "The item has not been poisoned.",
                "Poisoning has failed successfully.",
                "I've failed to applied the poison, {master_nickname}.",
                "I have failed to apply a sufficient amount of poison."
            }},
            { SquireDialogTree.TerribleMistake, new List<string> {
                "I have made a terrible mistake, {master_nickname}.",
                "*Grimaces as they poison themselves.*",
                "I got some in my mouth!",
                "I need a cure potion quickly!",
                "I've failed, and made a terrible mistake, {master_nickname}.",
                "I have made a terrible mistake while applying this poison."
            }},
            { SquireDialogTree.NoAnkhNearby, new List<string> {
                "I'll need to be a little more closer to an ankh in order to tithe, {master_nickname}.",
                "*Wonders if they're expected to tithe their gold to the ground.*",
                "I don't seem to be near an ankh.",
                "Sorry, I need to be closer to an ankh in order to tithe my gold.",
                "I am not close enough to an ankh, {master_nickname}.",
                "I must be near an ankh to tithe."
            }},
            { SquireDialogTree.TitheSuccess, new List<string> {
                "*Lays their gold before the ankh, praying for good fortune.*",
                "*Tithes gold as a sign of devotion.*",
                "*Prays to the shrine, tithing their gold.*",
                "*Tithes their gold to the ankh.*",
                "*Prays for good fortune as they tithe their gold.*",
                "*Mutters a prayer as they tithe their gold.*"
            }},
            { SquireDialogTree.NoGoldToTithe, new List<string> {
                "I will require more gold to tithe, {master_nickname}.",
                "*Checks their backpack thuroughly for gold to tithe.*",
                "There is no gold in my backpack which I may tithe.",
                "Sorry, in order to tithe gold, first I must have gold to tithe.",
                "May I have some funds to tithe, {master_nickname}?",
                "I lack funds."
            }},
            { SquireDialogTree.NotEnoughTithe, new List<string> {
                "I am too low on tithing points, {master_nickname}.",
                "*Is disappointed in their lack of tithing points.*",
                "I might not be devoted enough to cast this, I will need to tithe more.",
                "Sorry, I lack the tithing points required to cast this.",
                "I will need more tithe points to cast that, {master_nickname}.",
                "I am too low on tithing points to cast this."
            }},
            { SquireDialogTree.NotEnoughMana, new List<string> {
                "I am too low on mana, {master_nickname}.",
                "*Lacks the mana required to cast this.*",
                "I am low on mana.",
                "Sorry, I lack the mana required to cast this.",
                "I will need more mana to cast that, {master_nickname}.",
                "I am too low on mana to cast this."
            }},
            { SquireDialogTree.NoChivalryBook, new List<string> {
                "I would struggle casting that, {master_nickname}, I need a Chivalry book.",
                "*Does not have a Chivalry book.*",
                "Will need a Chivalry book to cast this.",
                "Sorry, I don't seem to have a Chivalry book on me.",
                "I am unfamiliar with that spell, {master_nickname}, I will need a Chivalry book.",
                "I will need a Chivalry book to cast that."
            }},
            { SquireDialogTree.TooSoonToMeditate, new List<string> {
                "I cannot concentrate on meditating again this soon.",
                "*Becomes too infuriated to meditate.*",
                "Give me some time, please.",
                "I need a moment.",
                "I will not attempt to meditate again this soon, {master_nickname}.",
                "It's a little too soon for me to attempt meditating, {master_nickname}."
            }},
            { SquireDialogTree.TooSoonToCastASpell, new List<string> {
                "I can't concentrate on casting another spell this soon.",
                "*Cannot concentrate on casting another spell this soon.*",
                "Give me some time, please.",
                "I need a moment.",
                "I will not attempt to cast a spell again this soon, {master_nickname}.",
                "It's a little too soon for me to attempt casting another spell, {master_nickname}."
            }},
            { SquireDialogTree.NotEnoughSpellSkill, new List<string> {
                "I lack the knowledge to cast this.",
                "*Is not confident in their ability to cast this spell.*",
                "I am not confident in my ability to cast this yet.",
                "I lack the knowledge to cast this yet.",
                "I will need to get better at this skill first, {master_nickname}.",
                "I am not skilled enough to cast that yet, {master_nickname}."
            }},
            { SquireDialogTree.NoExplosionPotion, new List<string> {
                "I don't seem to have one.",
                "*Checks their backpack for an explosion potion.*",
                "It's hard for me to throw what I don't have.",
                "Do you have an explosion potion for me?",
                "I might need an explosion potion to throw, {master_nickname}.",
                "I don't seem to have an explosion potion, {master_nickname}."
            }},
            { SquireDialogTree.SquireHasANewTeam, new List<string> {
                "Let me try screaming it... GO {squire_team_upper}! Yeah, that works!",
                "*Is more than excited to be a part of {squire_team}!*",
                "{squire_team}, huh? I will try to get along with them!",
                "I am certain I will get used to the team {squire_team}.",
                "{squire_team}, let's do this!",
                "Alright, I will belong to {squire_team} from now on."
            }},
            { SquireDialogTree.NoBushidoBook, new List<string> {
                "I would struggle casting that, {master_nickname}, I need a Bushido book.",
                "*Does not have a Bushido book.*",
                "Will need a Bushido book to cast this.",
                "Sorry, I don't seem to have a Bushido book on me.",
                "I am unfamiliar with that spell, {master_nickname}, I will need a Bushido book.",
                "I will need a Bushido book to cast that."
            }},
            { SquireDialogTree.NoNecroBook, new List<string> {
                "I would struggle casting that, {master_nickname}, I need a Necro book.",
                "*Does not have a Necro book.*",
                "Will need a Necro book to cast this.",
                "Sorry, I don't seem to have a Necro book on me.",
                "I am unfamiliar with that spell, {master_nickname}, I will need a Necro book.",
                "I will need a Necro book to cast that."
            }},
        };
    }
}
