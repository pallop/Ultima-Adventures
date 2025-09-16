//Britannia Healer Fragment				    
//Notes:  This is used for general information pertaining to all Britannian Healers
//Current Keyword List:
//   job
//   heal, cure, poison, resurrect, resurrection, healing
//   help
//   buy, potions, healing scrolls, potion, items
//   temple
//
//Additional Keywords:
//Revision Date:  3/15/96
//Author:  Marshall Andrews (dab)

//!! Change heal, cure, resurrect

#Fragment Britannia, Job, Britannia_Healer 
{
	#Sophistication High 
	{
		#Key "*job*", "*work*", "*what*do*do*", "*occupation*", "*profession*" 
		{
                	"I am one of the many healers of Britannia, $milord/milady$. I also sell potions and healing scrolls.",
                	"Why I am a healer,  $milord/milady$. I can also sell thee healing items if thou dost wish to purchase them.",
                	"Healing is what I do, $milord/milady$, for I am a healer."
                }
		#Key "*heal*", "*healing*" 
		{
                	"Aye, I could heal thee if I were not so weak at the moment. Use a bandage on thy wound and thou should heal more quickly.",
                	"$Milord/Milady$, art thou injured?  I would heal thee, but my powers are not at their normal strength. Use a bandage. 'Tis all I could do anyway, except for selliing thee potions or scrolls.",
                	"My strength is not what it used to be. I can sell thee some potions or healing scrolls if thou needest them. Bandages are available also."
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
			"If thou art injured, I have items that could be of help to thee.",
			"My potions and scrolls should fix thee right up.",
			"My abilities are limited to selling thee potions or scrolls. I am terribly sorry. Resurrections drain me so.",
                        "I can sell thee bandages or a potion to heal thy wounds."
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
                        "Thou'rt very kind, $milord/milady$. I would be happy to sell potions and healing scrolls to thee.",
                        "If thou wilt pardon the boast, $milord/milady$, my potions and healing scrolls are very good. They can heal the most horrific wounds.",
                        "I sell healing potions and healing scrolls. They are made from the roots of various trees scattered throughout the land."
                }
                #Key "*potions*", "*potion*" 
		{
                        "Healing potions? That is, in fact, one of the items I sell, $milord/milady$.",
                        "I used to have many kinds of potions, but for now I only make healing potions.",
                        "There are all sorts of potions. Some heal and some cure poison."
                }
                #Key "*healing scrolls*" 
		{
                        "Healing scrolls can be used to help heal wounds. I can sell thee some.",
                        "My healing scrolls are made from strong cloth fibers and silk. I still have some if thou dost want to buy them.",
                        "Why, I sell healing scrolls $milord/milady$. They can aid in the healing of many types of wounds."
                }
                #Key "*shrine*" 
		{
                        "The shrine is a mystical place where people can bring back the dead.",
                        "Rumor has it that some shrines have magical stones that bring the dead back to life.",
                        "Why, some say many shrines have magical stones that will return life to the nonliving."
                }
                #Key "*items*" 
		{
                        "I sell potions, bandages, and healing scrolls, $milord/milady$. In my most humble opinion, they are the best around.",
                        "Why, the items I have are potions, healing scrolls and bandages. I sell them so people like thee need not travel all the way back here for aid.",
                        "Bandages, potions, and healing scrolls are the items I sell, $milord/milady$. I sell them to travelers for their injuries."
                }
		#Key "*bandage*"
		{
			"Thou can buy some bandages from me, certainly. Thou can also make thy own. All thou dost need is cloth and something to cut it with.",
			"Thou can make thy own bandages, or thou can buy them from me. Whichever thou prefer."
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
                        "I can sell thee items to heal thyself. Bandages could help thee some. Potions and Scrolls are better, though.",
                        "Healing potions will help thee. And thou could use bandages on thy wounds, also.",
                        "Healing scrolls and healing potions help wounds to heal, as well as simply bandaging them."
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
				"Siempre puedes aprender cosas nuevas, amigo mío. Podría mostrarte algunas cosas que podrían ayudarte a realizar los primeros auxilios, por ejemplo. Por una pequeña cantidad de dinero, por supuesto.",
				"Puedo enseñarte cosas que podrían ayudarte cuando estés herido. Sin embargo, necesitaría que me pagaras por mi tiempo."
			}
		}
                #Key "*help*" "*hurt*" "*injured*" 
		{
			"Art thou hurt? I have items to help thee.",
			"My potions and scrolls should help thee.",
			"My abilities are limited to selling thee potions or scrolls.",
			"I can sell thee bandages or a potion to heal thy wounds."
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
                        "I sell healing items.",
                        "I can sell thee potions or healing scrolls."
                }
                #Key "*potions*", "*potion*" 
		{
                        "I belive my potions to be the best around.",
                        "The potions here are the finest in this area, $milord/milady$.",
                        "Surely thou canst never have enough healing potions."
                }
                #Key "*healing scrolls*" 
		{
                        "These healing scrolls will soothe thy wounds.",
                        "I have healing scrolls made from the strongest cloth.",
                        "I have lots of healing scrolls."
                }
                #Key "*shrine*" 
		{
                        "The shrine mayest resurrects those who are dead.",
                        "Shrines are very powerful and mystic places.",
                        "Many spiritual acts are said to occur at the shrines."
                }
                #Key "*items*" 
		{
                        "Why, I sell potions, healing scrolls, and bandages.",
                        "Potions and healing scrolls are what I sell. Oh, and bandages.",
                        "I sell healing scrolls, healing potions, and bandages."
                }
		#Key "*bandage*"
		{
			"Thou can make them, thou knowest? Bandages, I mean. Just need some cloth and something to cut it with.",
			"I can sell thee bandages, or thou can make them thyself. Cloth is all thou dost need."
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
                        "Potions would help. Or get some badages.",
                        "Healing scrolls are good for wounds. And thou can make thy own bandages.",
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
                        "I can sell scrolls an' potions.",
                        "I should have some potions or scrolls around here.",
                        "I can sell bandages or a potion to heal thy wounds. That's about all I can do, though."
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
                        "I sell healing items.",
                        "I sell potions and healing scrolls.",
                        "What's thou wantin'?"
                }
                #Key "*potions*", "*potion*" 
		{
                        "I sell healing potions.",
                        "Thou'rt interested in healing potions?.",
                        "I got potions that canst heal thy wounds."
                }
                #Key "*healing scrolls*" 
		{
                        "I sell healing scrolls.",
                        "Thou'rt interested in healing scrolls?.",
                        "I got healing scrolls."
                }
                #Key "*shrine*" 
		{
                        "Shrines are powerful.",
                        "I've heard of such places.",
                        "I know little about shrines."
                }
                #Key "*items*" 
		{
                        "Potions and healing scrolls are my items. I sell bandages, too.",
                        "Items? Why, potions and bandages.",
                        "Items? Oh, yeah, I got healing scrolls and some healing potions and some bandages."
                }
		#Key "*bandage*"
		{
			"Bandages? I sell 'em. Thou can make 'em, too.",
			"Make thy bandages or buy 'em from me, I don't care."
		}
        }
}
