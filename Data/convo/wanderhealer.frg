//Britannia Wandering Healer Fragment				    
//Notes:  This is used for general information pertaining to all 
// Britannian Wandering Healers
//Current Keyword List:
//   job
//   heal, cure, poison, resurrect, resurrection, healing
//   help
//   buy, potions, healing scrolls, potion, items
//   temple
//
//Additional Keywords:
//Revision Date:  3/15/96
//Author:  Marshall Andrews (dab) - KKoster

//!! Change heal, cure, resurrect

#Fragment Britannia, Job, Britannia_Healer 
{
	#Sophistication High 
	{
		#Key "*job*", "*work*", "*what*do*do*", "*occupation*", "*profession*" 
		{
                	"I am one of the many wandering healers of Britannia.",
                	"Why, I am a wandering healer,  $milord/milady$.",
                	"Healing is what I do, $milord/milady$, for I am a healer that travels Brittannia."
                }
		#Key "*heal*", "*healing*" "*help*" "*hurt*" "*injured*" 
		{
                	"Aye, I could heal thee if I were not so weak at the moment.",
                	"$Milord/Milady$, art thou injured?  I would heal thee, but my powers are not at their normal strength.",
                	"My strength is not what it used to be. I wouldst heal thee if I but couldst."
                }
		#KEY "*skill*" "*first aid*" "*knowledge*" "*anatomy*"  
		{
			#Attitude Wicked 
			{
				"Puedo ayudarte a aprender algunas cosas. Preferiría que me dejaras en paz, pero puedo enseñarte, si lo necesitas.",
				"Desearía que me dejaras en paz. Pero si lo necesitas, podría enseñarte algunas de mis habilidades.",
				"Por favor, déjame en paz. No tengo tiempo para ti."
			}
			#Attitude Neutral 
			{
				"Si quieres aprender, podría persuadirte para que te enseñe sobre primeros auxilios. También podría enseñarte sobre la anatomía humana. Tendrías que pagarme, por supuesto.",
				"Deberías saber algo sobre las artes curativas. Podría serte de utilidad. Creo que podría ayudarte un poco.",
				"Si necesitas ayuda con los primeros auxilios, solo pídeme que te enseñe y si puedo, lo haré. Por un módico precio.",
				"Puedo enseñarte a conocer mejor la anatomía. Podría serte de utilidad en el futuro."
			}
			#Attitude Goodhearted 
			{
				"Me alegraría que aprendieras lo que sé sobre primeros auxilios. Podría darte lecciones por unas pocas monedas.",
				"Siempre puedes aprender cosas nuevas, amigo mío. Podría enseñarte algunas cosas que podrían ayudarte a realizar los primeros auxilios, por ejemplo. Por una pequeña cantidad de dinero, por supuesto.",
				"Puedo enseñarte cosas que podrían ayudarte cuando estés herido. Sin embargo, necesitaría que me pagaras por mi tiempo."
			}
		}
                #Key "*cure*", "*poison*" 
		{
			"I am sorry, $milord/milady$, for I cannot cure poison.",
 			"$Milord/Milady$, forgive me, but my powers are not strong enough to cure thee.",
 			"The poisons in this region are much stronger than what my powers can cure. I am afraid that I can not heal you."
                }
                #Key "*resurrect*", "*raise dead*", "*resurrection*" 
		{
                        "If thou dost lose thy physical self, do what thou can to find a healer, and he or she shall help thee.",
                        "If thy spirit is all that thou dost have left, find thyself a healer. We can help thee.",
                        "If thou cannot find a shrine, then I can help resurrect thee."
                }
                #Key "*buy*" 
		{
                        "Thou'rt very kind, $milord/milady$. My master, back at the shop would be happy to sell potions and healing scrolls to thee.",
                        "If thou wilt pardon the boast, $milord/milady$, my master's potions and healing scrolls are very good. They can heal the most horrific wounds.",
                        "My master doth sell healing potions and healing scrolls. They are made from the roots of various trees scattered throughout the land that he sends me out to collect."
                }
                #Key "*potions*", "*potion*" 
		{
                        "Healing potions? That is, in fact, one of the items my master doth sell, $milord/milady$.",
                        "My master doth make many kinds of potions, but for now I only gather herbs and reagents for him.",
                        "There are all sorts of potions. Some heal and some cure poison."
                }
                #Key "*healing scrolls*" 
		{
                        "Healing scrolls can be used to help heal wounds. My master can sell thee some.",
                        "My master's healing scrolls are made from strong cloth fibers and silk.",
                        "Why, my master's shop sells healing scrolls $milord/milady$. They can aid in the healing of many types of wounds."
                }
                #Key "*shrine*" 
		{
                        "The shrine is a mystical place where people can bring back the dead.",
                        "Rumor has it that some shrines have magical stones that bring the dead back to life.",
                        "Why, some say many shrines have magical stones that will return life to the nonliving."
                }
                #Key "*items*" 
		{
                        "My master sells potions and healing scrolls, $milord/milady$. In my most humble opinion, they are the best around.",
                        "Why, the items my master has are potions and healing scrolls.",
                        "Potions and healing scrolls are the items my master sells back at the shop, $milord/milady$."
                }
               #Key "*master*" 
                {
                        "My master is the healer in _Town_.",
                        "In _Town_, my master runs the healer's shop.",
                        "I am apprenticed to the healer in _Town_."
                }

        }
        #Sophistication Medium 
	{
		#Key "*job*", "*work*", "*what*do*do*", "*occupation*", "*profession*" 
		{
                        "I heal those who are hurt.",
                        "I am a healer.",
                        "I heal the wounds of the injured."
                }
                #Key "*heal*", "*healing*" 
		{
                        "My master can sell thee items to heal thyself.",
                        "Healing potions will help thee.",
                        "Healing scrolls and healing potions help wounds to heal."
                }
		#KEY "*skill*" "*first aid*" "*knowledge*" "*anatomy*"  
		{
			#Attitude Wicked 
			{
				"Puedo ayudarte a aprender algunas cosas. Preferiría que me dejaras en paz, pero puedo enseñarte, si lo necesitas.",
				"Desearía que me dejaras en paz. Pero si lo necesitas, podría enseñarte algunas de mis habilidades.",
				"Por favor, déjame en paz. No tengo tiempo para ti."
			}
			#Attitude Neutral 
			{
				"Si quieres aprender, podría persuadirte para que te enseñe sobre primeros auxilios. También podría enseñarte sobre la anatomía humana. Tendrías que pagarme, por supuesto.",
				"Deberías saber algo sobre las artes curativas. Podría serte de utilidad. Creo que podría ayudarte un poco.",
				"Si necesitas ayuda con los primeros auxilios, solo pídeme que te enseñe y si puedo, lo haré. Por un módico precio.",
				"Puedo enseñarte a conocer mejor la anatomía. Podría serte de utilidad en el futuro."
			}
			#Attitude Goodhearted 
			{
				"Me alegraría que aprendieras lo que sé sobre primeros auxilios. Podría darte lecciones por unas pocas monedas.",
				"Siempre puedes aprender cosas nuevas, amigo mío. Podría enseñarte algunas cosas que podrían ayudarte a realizar los primeros auxilios, por ejemplo. Por una pequeña cantidad de dinero, por supuesto.",
				"Puedo enseñarte cosas que podrían ayudarte cuando estés herido. Sin embargo, necesitaría que me pagaras por mi tiempo."
			}
		}
                #Key "*help*" "*hurt*" "*injured*" 
		{
			"Art thou hurt? A well prepared traveller buys them before $his/her$ journey.",
			"My master's potions and scrolls would help thee if thou had but purchased them before leaving on your journey.",
			"My abilities are limited to gathering herbs and reagents.",
}
                #Key "*cure*", "*poison*" 
		{
			"Curing poison is a commonly-practiced skill.",
			"I beg thy pardon, $milord/milady$, but thou wilt have to find another to cure thy poisonous ailment.",
 			"Art thou poisoned? I do wish I could help thee, $milord/millady$, but alas I cannot."
                }
                #Key "*resurrect*", "*raise dead*", "*resurrection*" 
		{
                        "If thou dost lose thy physical self, do what thou can to find a healer, and he or she shall help thee.",
                        "If thy spirit is all that thou dost have left, find thyself a healer.  We can help thee.",
                        "If thou cannot find a shrine, then I can help resurrect thee."
                }
                #Key "*buy*" 
		{
                        "My master sells healing items.",
                        "My master can sell thee potions or healing scrolls."
                }
                #Key "*potions*", "*potion*" 
		{
                        "I believe my master's potions to be the best around.",
                        "The potions at my master's shop are the finest in this area, $milord/milady$.",
                        "Surely thou canst never have enough healing potions."
                }
                #Key "*healing scrolls*" 
		{
                        "Healing scrolls will soothe thy wounds.",
                        "My master has healing scrolls made from the strongest cloth back at the shop.",
                        "My master has lots of healing scrolls at his shop."
                }
                #Key "*shrine*" 
		{
                        "The shrine mayest resurrects those who are dead.",
                        "Shrines are very powerful and mystic places.",
                        "Many spiritual acts are said to occur at the shrines."
                }
                #Key "*items*" 
		{
                        "Why, my master sells potions and healing scrolls.",
                        "Potions and healing scrolls are what my master sells.",
                        "My master sells healing scrolls and healing potions."
                }
                #Key "*master*" 
                {
                        "My master is the healer in _Town_.",
                        "In _Town_, my master runs the healer's shop.",
                        "I am apprenticed to the healer in _Town_."
                }

        }
        #Sophistication Low {
		#Key "*job*", "*work*", "*what*do*do*", "*occupation*", "*profession*" 
		{
                        "I heal.",
                        "Healin's what I do.",
                        "Healing."
                }
                #Key "*heal*", "*healing*" 
		{
                        "Potions would help.",
                        "Healing scrolls are good for wounds.",
                        "Some spells heal."
                }
		#KEY "*skill*" "*first aid*" "*knowledge*" "*anatomy*"  
		{
			#Attitude Wicked 
			{
				"Puedo ayudarte. Me gustaría que me dejaras en paz, pero te enseñaré, si lo necesitas.",
				"Quiero que me dejes en paz. Pero podría enseñarte algunas de mis habilidades, por un precio.",
				"Por favor, déjame en paz."
			}
			#Attitude Neutral 
			{
				"Si quieres aprender, puedo enseñarte primeros auxilios. Por supuesto, quiero un pago.",
				"Deberías saber de curación. Podría ser útil. Creo que podría ayudarte un poco.",
				"Si necesitas aprender primeros auxilios, solo pregunta e intentaré ayudarte. Por un módico precio.",
				"Puedo enseñarte sobre anatomía. Podría ser útil en el futuro."
			}
			#Attitude Goodhearted 
			{
				"Podría enseñarte lo que sé sobre primeros auxilios por unas pocas monedas.",
				"Podría enseñarte algunas cosas sobre primeros auxilios por una pequeña cantidad de dinero.",
				"Podrías aprender cosas que podrían ayudarte cuando estés herido. Sin embargo, te costará."
			}
		}
                #Key "*help*" "*hurt*" "*injured*" 
		{
                        "My master can sell scrolls an' potions.",
                        "My master should have some potions or scrolls around his shop.",
                        "My master can sell bandages or a potion to heal thy wounds. Collecting herbs and reagents is about all I can do, though."
                }
                #Key "*cure*", "*poison*" 
		{
                        "Art thou poisoned?",
                        "I can't help.",
                        "Curin's not as easy as one might think."
                }
 		#Key "*resurrect*", "*raise dead*", "*resurrection*" 
		{
                        "I can help thee only if thou'rt dead.",
                        "Resurrection is not beyond me.",
                        "I got the power to resurrect. Find me if thou'rt in need."
                }
                #Key "*buy*" 
		{
                        "My master sells healing items.",
                        "My master sells potions and healing scrolls.",
              }
                #Key "*potions*", "*potion*" 
		{
                        "My master sells healing potions.",
                        "Thou'rt interested in healing potions? My master sells them.",
                        "My master got potions that canst heal thy wounds."
                }
                #Key "*healing scrolls*" 
		{
                        "My master sell healing scrolls.",
                        "Thou'rt interested in healing scrolls? My master has some at the shop.",
                        "My master got healing scrolls."
                }
                #Key "*shrine*" 
		{
                        "Shrines are powerful.",
                        "I've heard of such places.",
                        "I know little about shrines."
                }
                #Key "*items*" 
		{
                        "Potions and healing scrolls are what my master sells.",
                        "Items? Why, potions and bandages are what my master sells.",
                        "Items? Oh, yeah, my master got healing scrolls and some healing potions."
                }
                #Key "*master*" 
                {
                        "My master is the healer in _Town_.",
                        "In _Town_, my master runs the healer's shop.",
                        "I am apprenticed to the healer in _Town_."
                }
        }
}
