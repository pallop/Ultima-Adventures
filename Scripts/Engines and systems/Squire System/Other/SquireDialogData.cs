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
                "No puedo, {master_nickname}, forzar cerraduras requiere un toque delicado, necesito estar más cerca.",
                "*Se frustra por no estar más cerca de la cerradura para forzarla.*",
                "Necesito estar justo al lado de una cerradura para forzarla.",
                "No puedo forzar una cerradura tan lejos, {master_nickname}.",
                "{master_nickname}, eso está demasiado lejos para que intente forzarla.",
                "No puedo forzar esa cerradura desde tan lejos."
            }},
            { SquireDialogTree.NotLocked, new List<string> {
                "No puedo, {master_nickname}, esto no está cerrado con llave.",
                "*Guarda sus ganzúas, no hay trabajo que hacer aquí.*",
                "Esto no está cerrado con llave.",
                "No puedo forzar una cerradura que no está realmente cerrada, {master_nickname}.",
                "{master_nickname}, esto no está cerrado con llave.",
                "Esto no parece estar cerrado con llave."
            }},
            { SquireDialogTree.CannotUnlock, new List<string> {
                "No puedo, {master_nickname}, no puedo desbloquear esto.",
                "*No puede desbloquear esto.*",
                "No veo ninguna forma en la que pueda desbloquear esto.",
                "No puedo forzar esta cerradura, {master_nickname}.",
                "{master_nickname}, no puedo desbloquear esto.",
                "¡No puedo desbloquear esto!"
            }},
            { SquireDialogTree.BrokenLockpick, new List<string> {
                "Lo siento, {master_nickname}, se me rompió la ganzúa.",
                "*La ganzúa se rompe en su mano.*",
                "Mi ganzúa parece haberse roto.",
                "Rompí mi ganzúa, {master_nickname}.",
                "{master_nickname}, rompí una ganzúa.",
                "¡Rompí una ganzúa!"
            }},
            { SquireDialogTree.AbnormalLock, new List<string> {
                "Lo siento, {master_nickname}, no creo que esto se pueda desbloquear por medios normales.",
                "*Está perplejo por esta cerradura.*",
                "Esto no se puede desbloquear por medios normales.",
                "Esta es una cerradura extraña, {master_nickname}.",
                "{master_nickname}, no creo que esta cerradura se pueda forzar por medios normales.",
                "¡Esto no parece que se pueda desbloquear por medios normales!"
            }},
            { SquireDialogTree.HardLock, new List<string> {
                "Lo siento, {master_nickname}, no soy lo suficientemente hábil para desbloquear esto.",
                "*Admite la derrota ante esta cerradura.*",
                "Esta cerradura parece más dura que las otras que he visto.",
                "No creo que pueda desbloquear esto ahora mismo, {master_nickname}.",
                "{master_nickname}, creo que necesito entrenar un poco más antes de intentar con esta.",
                "No veo cómo se puede manipular esta cerradura."
            }},
            { SquireDialogTree.UnsuccessfulLockpick, new List<string> {
                "Lo siento, {master_nickname}, déjame intentar forzarla de nuevo.",
                "*No pudo forzar la cerradura.*",
                "No pude forzar esta cerradura.",
                "No tuve éxito en forzar esta cerradura, {master_nickname}.",
                "{master_nickname}, fallé al forzar esta cerradura.",
                "No pude forzar esta cerradura."
            }},
            { SquireDialogTree.SuccessfulLockpick, new List<string> {
                "¡Lo he hecho, {master_nickname}, la cerradura ha sido forzada!",
                "*Pudo forzar la cerradura.*",
                "¡A por el contenido, {master_nickname}!",
                "¡Tuve éxito en forzar esta cerradura, {master_nickname}!",
                "¡{master_nickname}, he forzado la cerradura con éxito!",
                "¡La cerradura ha cedido a mi habilidad!"
            }},
            { SquireDialogTree.HandsAreFull, new List<string> {
                "No puedo, {master_nickname}, tengo las manos ocupadas.",
                "*Las manos están un poco demasiado ocupadas.*",
                "¡Necesito vaciar mis manos, {master_nickname}!",
                "¡Tengo las manos un poco ocupadas aquí, {master_nickname}!",
                "{master_nickname}, primero necesito guardar los objetos que tengo en las manos.",
                "Mis manos están un poco ocupadas para robar."
            }},
            { SquireDialogTree.StealingNotAllowedHere, new List<string> {
                "¡No puedo hacerlo, {master_nickname}, no puedo robar en esta área!",
                "*Está confundido por la fuerza invisible que le impide robar.*",
                "¡Esta área no nos permitirá robar, {master_nickname}!",
                "¡No puedo robar en esta área, {master_nickname}!",
                "{master_nickname}, no podemos robar aquí.",
                "No se permite robar en esta área."
            }},
            { SquireDialogTree.NotAPartOfThievesGuild, new List<string> {
                "¡No puedo, {master_nickname}, necesitamos unirnos al gremio de ladrones!",
                "*No puede robar a otro jugador sin antes unirse al gremio de ladrones.*",
                "¡Únete al gremio de ladrones primero, {master_nickname}!",
                "¡No podemos robar a los jugadores a menos que estemos en el gremio de ladrones, {master_nickname}!",
                "¡{master_nickname}, necesitamos unirnos al gremio de ladrones!",
                "No podemos robar a los jugadores porque no somos parte del gremio de ladrones."
            }},
            { SquireDialogTree.SuspendedFromThievesGuild, new List<string> {
                "¡No puedo, {master_nickname}, estamos suspendidos del gremio!",
                "*La suspensión del gremio los detiene.*",
                "¡No podemos robar a los jugadores mientras estemos suspendidos del gremio, {master_nickname}!",
                "¡La suspensión nos impide robar a otros jugadores, {master_nickname}!",
                "¡{master_nickname}, no podemos robar a los jugadores mientras estemos suspendidos!",
                "¡Actualmente estamos suspendidos en el gremio de ladrones!"
            }},
            { SquireDialogTree.CannotStealFromVendors, new List<string> {
                "¡Eso es un vendedor, {master_nickname}, no podemos robarles!",
                "*Se niega a robar a un vendedor.*",
                "¡No se puede robar a los vendedores, {master_nickname}!",
                "¡No podemos robar a los vendedores, {master_nickname}!",
                "¡{master_nickname}, no podemos robar a los vendedores!",
                "¡No podemos robar a los vendedores!"
            }},
            { SquireDialogTree.CannotSeeStealingTarget, new List<string> {
                "No puedo verlo, {master_nickname}, ¿quizás si me acercaras?",
                "*No puede localizar el objeto que quieres que roben.*",
                "¡No puedo verlo, {master_nickname}!",
                "¡Tendría que poder ver lo que quieres que robe, {master_nickname}!",
                "{master_nickname}, no puedo robar lo que no puedo ver.",
                "No puedo ver eso."
            }},
            { SquireDialogTree.FullBackpackStealing, new List<string> {
                "Mi mochila está llena, {master_nickname}, no puedo meter más.",
                "*No puede meter más objetos en su mochila.*",
                "¡Mi mochila no puede contener más, {master_nickname}!",
                "¡No hay nada más que pueda meter en mi mochila, {master_nickname}!",
                "{master_nickname}, mi mochila está llena.",
                "Mi mochila no puede contener más."
            }},
            { SquireDialogTree.NeedToBeCloserToSteal, new List<string> {
                "No puedo robarlo, {master_nickname}, estoy demasiado lejos.",
                "*Los brazos no pueden llegar tan lejos.*",
                "¡Estoy demasiado lejos del objetivo para robarlo, {master_nickname}!",
                "¡No puedo robar el objetivo tan lejos, {master_nickname}!",
                "{master_nickname}, acércame al objetivo.",
                "Necesito estar más cerca del objetivo para robarlo."
            }},
            { SquireDialogTree.CannotStealThat, new List<string> {
                "No puedo robar eso, {master_nickname}, ¿qué esperas de mí?",
                "*No puede robar eso.*",
                "¡No puedo robar eso, {master_nickname}!",
                "¡Qué esperas de mí, {master_nickname}!",
                "¡{master_nickname}, eso no es algo que pueda robar!",
                "¡No puedo robar eso!"
            }},
            { SquireDialogTree.CannotStealWhileMorphed, new List<string> {
                "No puedo robar, {master_nickname}, no mientras estoy transformado.",
                "*no puede robar mientras está transformado.*",
                "¡Esta transformación me impide robar, {master_nickname}!",
                "¡No podré robar hasta que vuelva a transformarme, {master_nickname}!",
                "{master_nickname}, no puedo robar mientras soy otra cosa o alguien más.",
                "¡No puedo robar mientras no soy yo mismo!"
            }},
            { SquireDialogTree.NotSkilledEnoughToStealItem, new List<string> {
                "No soy lo suficientemente hábil, {master_nickname}, no puedo robar ese objeto.",
                "*Se da cuenta de que no es lo suficientemente hábil para robar ese objeto.*",
                "No puedo robar ese objeto ahora, {master_nickname}.",
                "Necesito entrenar más, {master_nickname}.",
                "{master_nickname}, necesito entrenar más primero.",
                "No soy lo suficientemente hábil para robar ese objeto."
            }},
            { SquireDialogTree.CannotStealFromTheirHands, new List<string> {
                "No soy lo suficientemente hábil, {master_nickname}, no lo suficientemente hábil para robar directamente de sus manos.",
                "*No está seguro de su habilidad para robar directamente de la mano de esa persona.*",
                "Seguramente nos notarían, {master_nickname}.",
                "Quizás algo de su mochila en su lugar, {master_nickname}.",
                "{master_nickname}, no creo que sea lo suficientemente hábil para tomar el objeto de sus manos.",
                "Sería una tontería para nosotros intentar robar de sus manos."
            }},
            { SquireDialogTree.StealFromSelf, new List<string> {
                "Podría dártelo, {master_nickname}, no necesito robármelo a mí mismo.",
                "*Está confundido de por qué le dijeron que robara su propio objeto.*",
                "Eso es un poco extraño, {master_nickname}.",
                "¿No preferirías que simplemente te lo entregara, {master_nickname}?",
                "¡{master_nickname}, me he pillado intentando robar!",
                "¡Ajá! ¡Te he pillado! Espera..."
            }},
            { SquireDialogTree.TooHeavyToSteal, new List<string> {
                "Eso sería demasiado pesado, {master_nickname}, no podría moverlo.",
                "*No puede mover ese objeto lo suficientemente rápido con lo pesado que es.*",
                "Eso es demasiado pesado para robar, {master_nickname}.",
                "Quizás si fuera más fuerte, {master_nickname}.",
                "{master_nickname}, no podría mover eso lo suficientemente rápido.",
                "Eso es demasiado pesado para robar."
            }},
            { SquireDialogTree.SuccessfulSteal, new List<string> {
                "¡He logrado robar el objeto, {master_nickname}, deberíamos correr!",
                "*Guarda rápidamente el objeto en su bolsillo.*",
                "¡Lo tengo, {master_nickname}!",
                "¡He tenido éxito, {master_nickname}!",
                "¡{master_nickname}, he logrado robar!",
                "¡He robado el objeto con éxito!"
            }},
            { SquireDialogTree.UnsuccessfulSteal, new List<string> {
                "He fallado al robar el objeto, {master_nickname}, ¿estaremos bien?",
                "*No pudo liberar el objeto de su dueño.*",
                "He fallado al tomar el objeto, {master_nickname}.",
                "No pude robar el objeto, {master_nickname}.",
                "{master_nickname}, he fallado al robar el objeto.",
                "He fallado al robar el objeto."
            }},
            { SquireDialogTree.TooSoonToLockpick, new List<string> {
                "Dame un momento, {master_nickname}, entonces estaré listo para intentarlo de nuevo.",
                "*Suspira derrotado, necesita otro momento antes de volver a intentarlo.*",
                "No puedo forzar la cerradura de nuevo de inmediato, {master_nickname}.",
                "Necesito un poco de tiempo, {master_nickname}.",
                "{master_nickname}, déjame prepararme primero.",
                "Necesito un momento."
            }},
            { SquireDialogTree.TooSoonToSteal, new List<string> {
                "Dame un momento, {master_nickname}, entonces estaré listo para intentarlo de nuevo.",
                "*Suspira derrotado, necesita otro momento antes de volver a intentarlo.*",
                "No puedo intentar robar de nuevo de inmediato, {master_nickname}.",
                "Necesito un poco de tiempo, {master_nickname}.",
                "{master_nickname}, déjame prepararme primero.",
                "Necesito un momento."
            }},
            { SquireDialogTree.WhatShouldISteal, new List<string> {
                "Señálame el objetivo, {master_nickname}, lo robaré a tu orden.",
                "*Espera órdenes de robo.*",
                "Señala el objetivo, {master_nickname}.",
                "Señala el objeto, {master_nickname}.",
                "{master_nickname}, ¿cuál es el objetivo?",
                "¿Qué debo robar?"
            }},
            { SquireDialogTree.LearnsFromContract, new List<string> {
                "¡Eso es genial, {master_nickname}, siento que sé mucho más!",
                "*Se siente mucho más inteligente.*",
                "¡Gracias, {master_nickname}, he aprendido mucho!",
                "¡He aprendido mucho, {master_nickname}!",
                "¡{master_nickname}, me siento más inteligente!",
                "¡Ya me siento más inteligente!"
            }},
            { SquireDialogTree.RefusesToLootPlayers, new List<string> {
                "No puedo, {master_nickname}, iría en contra de las virtudes.",
                "*Se siente muy incómodo saqueando a esta persona.*",
                "Lo siento, {master_nickname}, simplemente no puedo saquearlos.",
                "¡Esto estaría mal, {master_nickname}!",
                "{master_nickname}, no me siento bien saqueando a esta persona.",
                "Me niego a saquear a un jugador."
            }},
            { SquireDialogTree.UnequipsTwoHandedForShield, new List<string> {
                "¡Gracias, {master_nickname}, por favor toma esta arma de dos manos a cambio!",
                "*Cambia el arma de dos manos que estaba usando por el escudo.*",
                "Gracias, {master_nickname}, por favor toma esta arma de dos manos de vuelta.",
                "¡Con este escudo, ya no puedo usar esa arma de dos manos que me diste, {master_nickname}!",
                "{master_nickname}, ya no estoy usando esa arma de dos manos que me diste.",
                "He quitado el arma de dos manos que sostenía."
            }},
            { SquireDialogTree.FirstHandMissing, new List<string> {
                "¡Lo siento, {master_nickname}, parece que he perdido el objeto!",
                "*Rebusca en su mochila sin poder localizar el objeto.*",
                "Lo siento, {master_nickname}, parece que he perdido el objeto que quieres que sostenga.",
                "¡Dónde lo puse, {master_nickname}!",
                "{master_nickname}, no parece que pueda encontrar el primer objeto que debo sostener.",
                "No parece que pueda encontrar lo que se supone que debo sostener en mi primera mano..."
            }},
            { SquireDialogTree.SecondHandMissing, new List<string> {
                "¡Lo siento, {master_nickname}, parece que he perdido el objeto!",
                "*Rebusca en su mochila sin poder localizar el objeto.*",
                "Lo siento, {master_nickname}, parece que he perdido el objeto que quieres que sostenga.",
                "¡Dónde lo puse, {master_nickname}!",
                "{master_nickname}, no parece que pueda encontrar el objeto que debo sostener.",
                "No parece que pueda encontrar lo que se supone que debo sostener en mi segunda mano..."
            }},
            { SquireDialogTree.EmptyHands, new List<string> {
                "¡De acuerdo, {master_nickname}, iré con las manos desnudas!",
                "*Aprieta los puños, golpeando el aire frente a ellos.*",
                "Muy bien, {master_nickname}, lucharé con las manos vacías.",
                "¡Con las manos desnudas voy, {master_nickname}!",
                "{master_nickname}, ¿supongo que la lucha será mi habilidad entonces?",
                "¡Supongo que iré con las manos vacías!"
            }},
            { SquireDialogTree.SuccessfulSetCreation, new List<string> {
                "¡De acuerdo, {master_nickname}, lucharé con valentía!",
                "*Agarra el equipo aceptando su lugar.*",
                "Muy bien, {master_nickname}, lucharé con esto.",
                "Conjunto de armas creado, {master_nickname}.",
                "{master_nickname}, usaré estas armas con valentía.",
                "¡Muy bien, conjunto creado!"
            }},
            { SquireDialogTree.Unarmed, new List<string> {
                "De acuerdo, {master_nickname}, me he desarmado.",
                "*Guarda el equipo en su mochila.*",
                "Muy bien, {master_nickname}, he guardado mi equipo.",
                "El equipo ha sido guardado, {master_nickname}.",
                "{master_nickname}, me he desequipado.",
                "Muy bien, he guardado los objetos que sostenía en mi mochila."
            }},
            { SquireDialogTree.SpiritSpeakSuccess, new List<string> {
                "De acuerdo, {master_nickname}, escuchemos a los espíritus.",
                "*Tararea un mantra mientras comienzan a comulgar con los espíritus.*",
                "Entonces, {master_nickname}, puedo hablar con los espíritus.",
                "Lo he hecho, {master_nickname}, he canalizado el mundo de los espíritus.",
                "{master_nickname}, ahora puedo comulgar con los fantasmas.",
                "He canalizado con éxito el mundo de los espíritus."
            }},
            { SquireDialogTree.SpiritSpeakFail, new List<string> {
                "Lo siento, {master_nickname}, no puedo oír a los espíritus.",
                "*Hace una mueca mientras fallan en canalizar el mundo de los espíritus.*",
                "Lo siento, {master_nickname}, no puedo hablar con los espíritus.",
                "He fallado, {master_nickname}.",
                "{master_nickname}, no puedo comulgar con los fantasmas.",
                "He fallado en canalizar el mundo de los espíritus."
            }},
            { SquireDialogTree.TooSoonToSpiritSpeak, new List<string> {
                "No puedo canalizar de nuevo tan pronto.",
                "*Intenta canalizar a los espíritus pero falla.*",
                "Mi conexión con el mundo de los espíritus es débil.",
                "No puedo intentar canalizar espíritus de nuevo tan pronto, {master_nickname}.",
                "Los canales son débiles, necesito tiempo.",
                "Es demasiado pronto para intentar comulgar con los espíritus de nuevo, {master_nickname}."
            }},
            { SquireDialogTree.SpiritChannelFades, new List<string> {
                "Ya no puedo hablar con los espíritus.",
                "*Siente que su conexión con los espíritus se desvanece.*",
                "El canal que tenía con el mundo de los espíritus se ha desvanecido.",
                "Mi conexión con el mundo de los espíritus se ha ido, {master_nickname}.",
                "Mi comunión con el mundo de los espíritus ha terminado.",
                "Mi canal con el mundo de los espíritus se está desvaneciendo, {master_nickname}."
            }},
            { SquireDialogTree.StillConnectedToSpirits, new List<string> {
                "Todavía puedo hablar con los espíritus.",
                "*Todavía está conectado a los espíritus.*",
                "El canal que tenía con el mundo de los espíritus está actualmente activo.",
                "Mi conexión con el mundo de los espíritus sigue activa, {master_nickname}.",
                "Mi comunión con el mundo de los espíritus sigue canalizada.",
                "Mi canal con el mundo de los espíritus sigue intacto, {master_nickname}."
            }},
            { SquireDialogTree.OpenQuiver, new List<string> {
                "Mira el contenido de mi carcaj si quieres.",
                "*Te abre su carcaj con orgullo.*",
                "Estoy seguro de que el contenido de tu mochila es más interesante que mi carcaj.",
                "Aquí está lo que tu pequeño {squire_nickname} está sosteniendo.",
                "¿Q-quieres ver mi qué? Oh, mi carcaj.",
                "Aquí está lo que hay en mi carcaj."
            }},
            { SquireDialogTree.NotAQuiver, new List<string> {
                "¿Estás bien, {master_nickname}?",
                "*Mira brevemente por encima de su hombro a su espalda.*",
                "No creo que lleve un carcaj, {master_nickname}.",
                "No hay ningún carcaj en mi espalda.",
                "Me disculpo, {master_nickname}, pero no llevo un carcaj.",
                "Sin embargo, no llevo un carcaj."
            }},
            { SquireDialogTree.PoisonToApply, new List<string> {
                "¿Qué veneno se debe usar, {master_nickname}?",
                "*Está listo para que elijas el veneno que usarán.*",
                "¿Qué botella debo usar, {master_nickname}?",
                "¿Qué veneno debo usar?",
                "¿Qué veneno quieres que use, {master_nickname}?",
                "¿Qué veneno debo usar?"
            }},
            { SquireDialogTree.ApplyPoisonTo, new List<string> {
                "¿Qué necesita un poco de veneno, {master_nickname}?",
                "*Prepara su veneno.*",
                "¿Qué quieres que envenene, {master_nickname}?",
                "¿Qué es lo que debo envenenar?",
                "¿Qué debo envenenar, {master_nickname}?",
                "¿A qué te gustaría que le aplicara el veneno?"
            }},
            { SquireDialogTree.NotAPoisonPotion, new List<string> {
                "Eso no es veneno, {master_nickname}.",
                "*Está confundido porque eso no es veneno.*",
                "No veo ningún veneno aquí.",
                "Eso no parece ser veneno.",
                "¿Estás seguro de que eso es veneno, {master_nickname}?",
                "Eso no es una poción de veneno."
            }},
            { SquireDialogTree.TooFarToPoison, new List<string> {
                "Estás un poco demasiado lejos para eso, {master_nickname}.",
                "*Mira la distancia entre ustedes dos.*",
                "No puedo envenenar algo tan lejos.",
                "Tu mochila está un poco demasiado lejos para que la alcance.",
                "¿Podrías acercarte, {master_nickname}?",
                "Estás demasiado lejos para que use eso."
            }},
            { SquireDialogTree.CannotPoisonNotInfectious, new List<string> {
                "No puedo envenenar eso, no es infeccioso, {master_nickname}.",
                "*No puede envenenar ese objeto.*",
                "Es imposible para mí envenenar eso.",
                "No puedo envenenar algo que no se puede infectar.",
                "Eso no es infeccioso, {master_nickname}.",
                "Lo siento, {master_nickname}, pero no puedo envenenar algo que no es infeccioso."
            }},
            { SquireDialogTree.CannotPoisonNotBPFoD, new List<string> {
                "No puedo envenenar eso, no es afilado, perforante, comida o bebida, {master_nickname}.",
                "*No puede envenenar ese objeto.*",
                "Es imposible para mí envenenar eso.",
                "No puedo envenenar algo que no sea afilado, perforante, comida o bebida.",
                "Eso no es afilado, perforante, comida o bebida, {master_nickname}.",
                "Lo siento, {master_nickname}, pero no puedo envenenar algo que no sea afilado, perforante, o comida o bebida."
            }},
            { SquireDialogTree.PoisoningSuccess, new List<string> {
                "Fue un éxito, {master_nickname}.",
                "*Sonríe mientras su envenenamiento tiene éxito.*",
                "El objeto ha sido envenenado.",
                "El envenenamiento ha ocurrido con éxito.",
                "¡He aplicado el veneno, {master_nickname}!",
                "¡He logrado aplicar el veneno!"
            }},
            { SquireDialogTree.PoisoningFailure, new List<string> {
                "Fue un fracaso, {master_nickname}.",
                "*Hace una mueca mientras falla su envenenamiento.*",
                "El objeto no ha sido envenenado.",
                "El envenenamiento ha fallado con éxito.",
                "He fallado al aplicar el veneno, {master_nickname}.",
                "He fallado al aplicar una cantidad suficiente de veneno."
            }},
            { SquireDialogTree.TerribleMistake, new List<string> {
                "He cometido un terrible error, {master_nickname}.",
                "*Hace una mueca mientras se envenena.*",
                "¡Me ha entrado un poco en la boca!",
                "¡Necesito una poción de cura rápidamente!",
                "He fallado y he cometido un terrible error, {master_nickname}.",
                "He cometido un terrible error al aplicar este veneno."
            }},
            { SquireDialogTree.NoAnkhNearby, new List<string> {
                "Necesitaré estar un poco más cerca de un ankh para diezmar, {master_nickname}.",
                "*Se pregunta si se espera que diezmen su oro al suelo.*",
                "No parece que esté cerca de un ankh.",
                "Lo siento, necesito estar más cerca de un ankh para diezmar mi oro.",
                "No estoy lo suficientemente cerca de un ankh, {master_nickname}.",
                "Debo estar cerca de un ankh para diezmar."
            }},
            { SquireDialogTree.TitheSuccess, new List<string> {
                "*Deja su oro ante el ankh, rezando por buena fortuna.*",
                "*Diezma oro como señal de devoción.*",
                "*Reza al santuario, diezmando su oro.*",
                "*Diezma su oro al ankh.*",
                "*Reza por buena fortuna mientras diezma su oro.*",
                "*Murmura una oración mientras diezma su oro.*"
            }},
            { SquireDialogTree.NoGoldToTithe, new List<string> {
                "Necesitaré más oro para diezmar, {master_nickname}.",
                "*Revisa su mochila a fondo en busca de oro para diezmar.*",
                "No hay oro en mi mochila que pueda diezmar.",
                "Lo siento, para diezmar oro, primero debo tener oro para diezmar.",
                "¿Puedo tener algunos fondos para diezmar, {master_nickname}?",
                "Me faltan fondos."
            }},
            { SquireDialogTree.NotEnoughTithe, new List<string> {
                "Tengo muy pocos puntos de diezmo, {master_nickname}.",
                "*Está decepcionado por su falta de puntos de diezmo.*",
                "Puede que no sea lo suficientemente devoto para lanzar esto, necesitaré diezmar más.",
                "Lo siento, me faltan los puntos de diezmo necesarios para lanzar esto.",
                "Necesitaré más puntos de diezmo para lanzar eso, {master_nickname}.",
                "Tengo muy pocos puntos de diezmo para lanzar esto."
            }},
            { SquireDialogTree.NotEnoughMana, new List<string> {
                "Tengo muy poco maná, {master_nickname}.",
                "*Le falta el maná necesario para lanzar esto.*",
                "Tengo poco maná.",
                "Lo siento, me falta el maná necesario para lanzar esto.",
                "Necesitaré más maná para lanzar eso, {master_nickname}.",
                "Tengo muy poco maná para lanzar esto."
            }},
            { SquireDialogTree.NoChivalryBook, new List<string> {
                "Me costaría lanzar eso, {master_nickname}, necesito un libro de Caballería.",
                "*No tiene un libro de Caballería.*",
                "Necesitaré un libro de Caballería para lanzar esto.",
                "Lo siento, no parece que tenga un libro de Caballería encima.",
                "No estoy familiarizado con ese hechizo, {master_nickname}, necesitaré un libro de Caballería.",
                "Necesitaré un libro de Caballería para lanzar eso."
            }},
            { SquireDialogTree.TooSoonToMeditate, new List<string> {
                "No puedo concentrarme en meditar de nuevo tan pronto.",
                "*Se enfurece demasiado para meditar.*",
                "Dame un tiempo, por favor.",
                "Necesito un momento.",
                "No intentaré meditar de nuevo tan pronto, {master_nickname}.",
                "Es un poco pronto para que intente meditar, {master_nickname}."
            }},
            { SquireDialogTree.TooSoonToCastASpell, new List<string> {
                "No puedo concentrarme en lanzar otro hechizo tan pronto.",
                "*No puede concentrarse en lanzar otro hechizo tan pronto.*",
                "Dame un tiempo, por favor.",
                "Necesito un momento.",
                "No intentaré lanzar un hechizo de nuevo tan pronto, {master_nickname}.",
                "Es un poco pronto para que intente lanzar otro hechizo, {master_nickname}."
            }},
            { SquireDialogTree.NotEnoughSpellSkill, new List<string> {
                "Me falta el conocimiento para lanzar esto.",
                "*No confía en su capacidad para lanzar este hechizo.*",
                "No confío en mi capacidad para lanzar esto todavía.",
                "Me falta el conocimiento para lanzar esto todavía.",
                "Necesitaré mejorar en esta habilidad primero, {master_nickname}.",
                "No soy lo suficientemente hábil para lanzar eso todavía, {master_nickname}."
            }},
            { SquireDialogTree.NoExplosionPotion, new List<string> {
                "No parece que tenga una.",
                "*Revisa su mochila en busca de una poción de explosión.*",
                "Es difícil para mí lanzar lo que no tengo.",
                "¿Tienes una poción de explosión para mí?",
                "Podría necesitar una poción de explosión para lanzar, {master_nickname}.",
                "No parece que tenga una poción de explosión, {master_nickname}."
            }},
            { SquireDialogTree.SquireHasANewTeam, new List<string> {
                "Déjame intentar gritarlo... ¡VAMOS {squire_team_upper}! ¡Sí, eso funciona!",
                "*¡Está más que emocionado de ser parte de {squire_team}!*",
                "{squire_team}, ¿eh? ¡Intentaré llevarme bien con ellos!",
                "Estoy seguro de que me acostumbraré al equipo {squire_team}.",
                "¡{squire_team}, vamos a hacerlo!",
                "Muy bien, perteneceré a {squire_team} de ahora en adelante."
            }},
            { SquireDialogTree.NoBushidoBook, new List<string> {
                "Me costaría lanzar eso, {master_nickname}, necesito un libro de Bushido.",
                "*No tiene un libro de Bushido.*",
                "Necesitaré un libro de Bushido para lanzar esto.",
                "Lo siento, no parece que tenga un libro de Bushido encima.",
                "No estoy familiarizado con ese hechizo, {master_nickname}, necesitaré un libro de Bushido.",
                "Necesitaré un libro de Bushido para lanzar eso."
            }},
            { SquireDialogTree.NoNecroBook, new List<string> {
                "Me costaría lanzar eso, {master_nickname}, necesito un libro de Nigromancia.",
                "*No tiene un libro de Nigromancia.*",
                "Necesitaré un libro de Nigromancia para lanzar esto.",
                "Lo siento, no parece que tenga un libro de Nigromancia encima.",
                "No estoy familiarizado con ese hechizo, {master_nickname}, necesitaré un libro de Nigromancia.",
                "Necesitaré un libro de Nigromancia para lanzar eso."
            }},
        };
    }
}
