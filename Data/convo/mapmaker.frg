// Mapmaker function
//
// Keywords:
// job, what*do*do, blank, map, plot*course, chart*course, sextant,
//
//
// 
// - jls


#Fragment Britannia, Job, Britannia_Mapmaker {

#Sophistication High {
#KEY "*job*", "*what*do*do*",  "*occupation*",  "*profession*"     {
#Attitude Wicked {
	"I am a mapmaker. Anyone can do it, really - just buy a blank map, and get thee to the spot thou wouldst set down, and map it. Takes a bit of work to become a master at it, mind."
}
#Attitude Neutral {
	"I am a mapmaker. Wouldst thou like to learn to make maps? In theory, 'tis simple - find a blank map, go to the spot thou wouldst map, and map it. In practice, of course, this requires a bit of skill ...",
}
#Attitude Goodhearted {
	"I am a mapmaker. Making maps is not altogether difficult. One takes a blank map, goes to the spot one wishes to map, and maps the area. Of course the skill takes practice to perfect ...",
}
}
#KEY "*skill*" "*mapmaking*" "*make maps*" "*map making*" {
	#Attitude Wicked {
	"Supongo que puedo ayudarte a aprender a hacer tus propios mapas. Preferiría que me dejaras en paz, pero puedo enseñarte, si lo necesitas.",
"¡Mi ardiente deseo es que ME DEJES EN PAZ! Por supuesto, podría enseñarte a hacer tus propios mapas, y tendrías menos razones para venir a molestarme.",
"Por favor, déjame en paz. No tengo tiempo para ti."
			}
	#Attitude Neutral {
	"Si quieres aprender, podría ser, um, persuadido para enseñarte a hacer mapas.",
"Deberías saber algo sobre la creación de mapas. Podría serte de utilidad.",
"Si necesitas ayuda con tu cartografía, solo pídeme que te enseñe y si puedo, lo haré.",
"Puedo enseñarte a hacer mejores mapas. Podría serte de utilidad en el futuro."
			}
	#Attitude Goodhearted {
	"Me alegraría que aprendieras lo que sé sobre hacer mapas. Podría darte lecciones por unas pocas monedas.",
"Siempre puedes aprender cosas nuevas, amigo mío. Podría enseñarte algunas cosas que podrían ayudarte a trazar tu camino. Por una pequeña cantidad de dinero, por supuesto.",
"Si estás dispuesto a aprender, entonces podría enseñarte algunas formas mejores de hacer mapas. Sin embargo, necesitaría que me pagaras por mi tiempo."
			}
		}
#KEY "*blank*" "*empty*" "*new*" "*vellum*" {
#Attitude Wicked {
	"I can sell thee a blank map. Or find one elsewhere, I suppose. Matters not to me."
}
#Attitude Neutral {
	"Thou canst purchase a blank map from me, shouldst thou desire one. I believe I have some about."
}
#Attitude Goodhearted {
	"I would be most happy to sell thee a blank map, if thou desirest. I believe I have some in stock."
}
}
#KEY "*map*"{
#Attitude Wicked {
	"A map is a very useful object - surely anyone can see that.",
	"One can set a course to sail by using a map. 'Tis especially useful if thou'rt not a master sailor.",
	"If there be others in thy party, thou canst make a map and give it them, or use a map to discuss where you're going. Tends to cut down on arguments."
}
#Attitude Neutral {
	"A map is a very useful object - one can use it to chart a course to sail by, for example.",
	"Plotting a course to sail by on a map is a particularly good idea for the less than seaworthy captain.",
	"Sometimes 'tis good to look at a map with thy companions before striking off someplace or agreeing to meet. Wouldn't want anyone to get lost!"
}
#Attitude Goodhearted {
	"A good map is a useful thing - thou canst make one to give to a friend who is going to meet thee somewhere, for example.",
	"Thou canst plot a course to sail by on a map - 'tis a good idea if thou hast little experience as a captain.",
	"Sometimes 'tis helpful to look at a map with thy companions when trying to decide where to go."
}
}
#KEY "*plot*course*" "*chart*course*"{
#Attitude Wicked {
	"Thou plottest thy course by sticking pins in a map to mark the places where thou wouldst go. Of course, thou dost need a good map, first. And a ship."
}
#Attitude Neutral {
	"To plot a course, thou stickst pins in a map to mark points on thy route. Thou canst then show this to a tiller, that he or she will know where to steer thy ship."
}
#Attitude Goodhearted {
	"Thou canst plot a course on a map by sticking pins in it to mark the places thou wouldst visit. Thou canst then show this to the tiller of thy ship, for he or she to steer by."
}
}
#KEY "*sextant*"{
#Attitude Wicked {
	"Art interested in purchasing a sextant? With it, thou canst determine where in Britannia thou'rt standing. No traveler should be without one, methinks."
}
#Attitude Neutral {
	"Ahh, the sextant. 'Tis a marvelous invention, is it not? To know thy location with pinpoint accuracy! I believe I may have one I could sell thee, if thou'rt interested."
}
#Attitude Goodhearted {
	"I find the sextant a truly fascinating instrument. To be able to pinpoint thy location using mathematics alone. I might have a sextant to sell thee, if thou shouldst like to try it."
}
}
}
#Sophistication Medium {
#KEY "*job*", "*what*do*do*",  "*occupation*",  "*profession*"     {
#Attitude Wicked {
	"I am a mapmaker. Anyone can do it, really - just buy a blank map, and get thee to the spot thou wouldst set down, and map it. Takes a bit of work to become a master at it, mind."
}
#Attitude Neutral {
	"I am a mapmaker. Wouldst thou like to learn to make maps? In theory, 'tis simple - find a blank map, go to the spot thou wouldst map, and map it. In practice, of course, this requires a bit of skill ...",
}
#Attitude Goodhearted {
	"I am a mapmaker. Making maps is not altogether difficult. One takes a blank map, goes to the spot one wishes to map, and maps the area. Of course the skill takes practice to perfect ...",
}
}
#KEY "*skill*" "*mapmaking*" "*make maps*" "*map making*" {
	#Attitude Wicked {
	"Supongo que puedo ayudarte a aprender a hacer tus propios mapas. Preferiría que me dejaras en paz, pero puedo enseñarte, si lo necesitas.",
"¡Mi ardiente deseo es que ME DEJES EN PAZ! Por supuesto, podría enseñarte a hacer tus propios mapas, y tendrías menos razones para venir a molestarme.",
"Por favor, déjame en paz. No tengo tiempo para ti."
			}
	#Attitude Neutral {
	"Si quieres aprender, podría ser, um, persuadido para enseñarte a hacer mapas.",
"Deberías saber algo sobre la creación de mapas. Podría serte de utilidad.",
"Si necesitas ayuda con tu cartografía, solo pídeme que te enseñe y si puedo, lo haré.",
"Puedo enseñarte a hacer mejores mapas. Podría serte de utilidad en el futuro."
			}
	#Attitude Goodhearted {
	"Me alegraría que aprendieras lo que sé sobre hacer mapas. Podría darte lecciones por unas pocas monedas.",
"Siempre puedes aprender cosas nuevas, amigo mío. Podría enseñarte algunas cosas que podrían ayudarte a trazar tu camino. Por una pequeña cantidad de dinero, por supuesto.",
"Si estás dispuesto a aprender, entonces podría enseñarte algunas formas mejores de hacer mapas. Sin embargo, necesitaría que me pagaras por mi tiempo."
			}
		}
#KEY "*blank*" "*empty*" "*new*" "*vellum*" {
#Attitude Wicked {
	"Thou canst purchase a blank map from me. Or find one elsewhere I suppose."
}
#Attitude Neutral {
	"Thou canst purchase a blank map from me, shouldst thou desire one. I believe I have some about."
}
#Attitude Goodhearted {
	"I would be most happy to sell thee a blank map, if thou desirest. I believe I have some in stock."
}
}
#KEY "*map*"{
#Attitude Wicked {
	"A map is a very useful object - surely anyone can see that.",
	"One can set a course to sail by using a map. 'Tis especially useful if thou'rt not a master sailor.",
	"If there be others in thy party, thou canst make a map and give it them, or use a map to discuss where you're going. Tends to cut down on arguments."
}
#Attitude Neutral {
	"A map is a very useful object - one can use it to chart a course to sail by, for example.",
	"Plotting a course to sail by on a map is a particularly good idea for the less than seaworthy captain.",
	"Sometimes 'tis good to look at a map with thy companions before striking off someplace or agreeing to meet. Wouldn't want anyone to get lost!"
}
#Attitude Goodhearted {
	"A good map is a useful thing - thou canst make one to give to a friend who is going to meet thee somewhere, for example.",
	"Thou canst plot a course to sail by on a map - 'tis a good idea if thou hast little experience as a captain.",
	"Sometimes 'tis helpful to look at a map with thy companions when trying to decide where to go."
}
}
#KEY "*plot*course*" "*chart*course*"{
#Attitude Wicked {
	"Thou plottest thy course by sticking pins in a map to mark the places where thou wouldst go. Of course, thou needst a good map, first. And a ship."
}
#Attitude Neutral {
	"To plot a course, thou stickst pins in a map to mark points on thy route. Thou canst then show this to a tiller, that he or she will know where to steer thy ship."
}
#Attitude Goodhearted {
	"Thou canst plot a course on a map by sticking pins in it to mark the places thou wouldst visit. Thou canst then show this to the tiller of thy ship, for he or she to steer by."
}
}
#KEY "*sextant*"{
#Attitude Wicked {
	"Art interested in purchasing a sextant? With it, thou canst determine where in Britannia thou'rt standing. No traveler should be without one, methinks."
}
#Attitude Neutral {
	"Ahh, the sextant. 'Tis a marvelous invention, is it not? To know thy location with pinpoint accuracy! I believe I may have one I could sell thee, if thou'rt interested."
}
#Attitude Goodhearted {
	"I find the sextant a truly fascinating instrument. To be able to pinpoint thy location using mathematics alone. I might have a sextant to sell thee, if thou shouldst like to try it."
}
}
}
#Sophistication Low {
#KEY "*job*", "*what*do*do*",  "*occupation*",  "*profession*"     {
#Attitude Wicked {
	"I'm a mapmaker, $milord/milady$. Real easy, it is - just buy a blank map and get thee to a good place, and
map it. 'Tis a bit of work to become a master, but 'tain't real hard work."
}
#Attitude Neutral {
	"I'm a mapmaker, $milord/milady$. Would thou like to make maps? 'Tis real simple - find a blank map, go to
the spot thou would map, and map it. 'Course, thou needs a bit of skill to do it real well ...",
}
#Attitude Goodhearted {
	"I'm a mapmaker, $milord/milady$. 'Tis not real hard a thing, makin' maps - thou takes a blank map, goes
to the spot thou would map, and maps it. Takes a bit of practice to get good, but 'tis no secret.",
}
}
#KEY "*skill*" "*mapmaking*" "*make maps*" "*map making*" {
	#Attitude Wicked {
	"Haz tus propios mapas. Puedo enseñarte, si eso te quita de mi pelo.",
"¡Realmente quiero que ME DEJES EN PAZ! ¡Si quieres mapas, aprende a hacerlos!",
"¡Lárgate! No tengo tiempo para ti."
			}
	#Attitude Neutral {
	"Podría ser, um, convencido de enseñarte a hacer mapas.",
"¡Aprende a hacer tus propios mapas! Podría serte de utilidad.",
"¿Necesitas ayuda para hacer mapas? Solo pídeme que te enseñe y si puedo, lo haré."
			}
	#Attitude Goodhearted {
	"Sé algunas cosas sobre hacer mapas. Podría darte lecciones por unas pocas monedas.",
"Podría enseñarte algunas cosas que podrían ayudarte con tus mapas. Solo pediría un poco de dinero a cambio.",
"Podría enseñarte a hacer mejores mapas. Por unas pocas monedas."
			}
		}
#KEY "*blank*" "*empty*" "*new*" "*vellum*" {
#Attitude Wicked {
	"I'll sell thee a blank map, $milord/milady$ - if I got any about."
}
#Attitude Neutral {
	"Thou can buy a blank map from me, if thou'lt like, $milord/milady$. I think I got some about."
}
#Attitude Goodhearted {
	"I'd be real happy to sell thee a blank map, $milord/milady$, if thou wants one. I think I got some in
stock."
}
}
#KEY "*map*"{
#Attitude Wicked {
	"A map's a real useful thing - surely thou can see that, $milord/milady$.",
	"Did thee know, $milord/milady$, thou can set a course to sail by using a map? 'Tis useful if thou ain't a master sailor.",
	"If there be others in thy party, $milord/milady$,  thou can make a map and give it or show it to 'em. Cuts
down on arguments, it does."
}
#Attitude Neutral {
	"A map's is a real useful thing, $milord/milady$ - thou can chart a course to sail by, for example.",
	"Thou can plot a course usin' a map, $milord/milady$. 'Tis a good idea if thou ain't real seaworthy.",
	"Sometimes 'tis good to look at a map with thy pals. Wouldn't want noone gettin' lost!"
}
#Attitude Goodhearted {
	"A good map's a good thing, $milord/milady$ - thou can make one to give to a friend who's wantin' to meet
thee somewheres.",
	"Thou can plot a course to sail by on a map - 'tis a good idea if thou ain't got much understandin' of
sailin'.",
	"Sometimes 'tis helpful to look at a map with friends when tryin' to decide where to go."
}
}
#KEY "*plot*course*" "*chart*course*"{
#Attitude Wicked {
	"Thou plots a course by stickin' pins in a map. 'Course, thou needs a good map an' a ship first."
}
#Attitude Neutral {
	"Thou sticks pins in a map to plot a course. If thou would show this to a tiller, he or she will know where to steer."
}
#Attitude Goodhearted {
	"Thou can plot a course on a map by stickin' pins in it. Thou can then show this to the tiller of thy ship,
so's he or she can steer."
}
}
#KEY "*sextant*"{
#Attitude Wicked {
	"Interested in purchasin' a sextant? Thou can figure out where thou are with it."
}
#Attitude Neutral {
	"The sextant 'tis a marvelous invention, ain't it? I confess I don't exactly understand 'em, but I can use
one to find out where I am, alright. I think I got one I can sell thee, if thou'rt interested."
}
#Attitude Goodhearted {
	"The sextant 'tis a marvelous invention, ain't it? I don't really understand how they work, but I
can use one to find out where I am, alright. I should have one I can sell thee, if thou'rt interested."
}
}
}
}
