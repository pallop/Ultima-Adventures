//Britannia Armourer Fragment				    
//Notes:  This is used for general information pertaining to all Britannian Armourers, Armourers, and Blacksmits
//	Eventually, armourers and armourers will be put into separate frags.
//Current Keyword List:	
//Additional Keywords:
//Revision Date:  3/14/96
//Author:  Andrew Morris


#Fragment Britannia, Job, Britannia_Armourer 
{
	#Sophistication High 
	{
		#KEY "*job*", "*what*do*do*", "*profession*", "*occupation*" 
		{
			#Attitude Wicked 
			{
				"I'm an armourer.",
				"I pound steel into submission.",
				"I create, buy, and sell armor."
			}
			#Attitude Neutral 
			{
				"I've been an armourer most of my life.",
				"I'm an armourer.",
				"I make and sell armor."
			}
			#Attitude Goodhearted 
			{
				"I make armor. I enjoy what I do! 'Tis good to hammer out a beautiful breastplate!",
				"Working metal is what I was born to do!."
			}
		}
		#KEY "*Breastplate*" 
		{
			#Attitude Wicked 
			{
				"Good for protection, breastplates are.  Thou wouldst probably be in need of much protection, from the looks of it.",
				"A good breastplate could keep a sword from between thy ribs.",
				"Some skill and metal are all that goes in to the making of armor.  And the right tools, of course."
			}
			#Attitude Neutral 
			{
				"I sell breastplates at a reasonable price.  I do need to make a profit.",
				"I tend to have a few breastplates in my inventory.  Enough to fit most sizes of people, in fact.",
				"Thou can learn to make thine own. It takes metal, the tools of a smith, and skill."
			}
			#Attitude Goodhearted 
			{
				"I sell breastplates at a competitive price $milord/milady$. Knives too.",
				"I always try to carry a supply of breastplates and shields, $milord/milady$.",
				"Someday thou might be able to make thine own armor."
			}
		}
		#KEY "*plate*" "*padded*" "*chain*" "*ring*" "*gorget*" "*shield*" "*buckler*" "*heater*" "*helm*" "*gauntlet*" "*inventory*"  
		{
			#Attitude Wicked 
			{
				"Dost thou want armor?  I have plenty of that!",
				"I carry many different types of armor for many different types of people.",
				"Buy what thou dost need. Or sell what thou dost have extra.",
				"All my armor is guaranteed to reduce damage to the person wearing it."
			}
			#Attitude Neutral 
			{
				"In need of armor, my friend?  Thou'rt come to the right place!",
				"I have armor to fit everyone!",
				"I'll buy from thee what extra armor thou art carrying around.",
				"All of my armor is guaranteed to reduce the risk of injuries."
			}
			#Attitude Goodhearted 
			{
				"Dost thou need armor, $milord/milady$?  Thou hast come to the right place!",
				"I have armor for everyone!  Especially an adventuresome sort like thee, $milord/milady$",
				"I can offer thee fair price for what armor thou dost carry with thee.",
				"All of my armor is guaranteed to reduce the risk of injuries."
			}
		}
		#KEY "*Smith*", "*Armourer*", "*Armorer*"  
		{
			#Attitude Wicked 
			{
				"I've been a smith for a good number of years.",
				"Smithing is my life.",
				"I learned how to work metal before I could stand upright.",
				"I have armoring people all of my adult life."
			}
			#Attitude Neutral 
			{
				"I've been a smith for a good number of years.",
				"Smithing is my life.",
				"I learned how to work metal before I could stand upright.",
				"I have been armoring people all of my adult life."
			}
			#Attitude Goodhearted 
			{
				"I've been a smith for a good number of years.",
				"Smithing is my life.",
				"I learned how to work metal before I could stand upright.",
				"I have been an armourer all of my adult life."
			}
		}
		#KEY "*armor*", "*Armour*", "*protection*" 
		{
			#Attitude Wicked 
			{
				"I carry a bunch of armor in my inventory.",
				"I shall offer to buy pre-owned armor if thou didst have some to sell.",
				"I can purchase thine armor, if thou dost wish it.",
				"I craft the finest armor.",
				"Chainmail, shields, gauntlets... thou dost name it, I probably have it."
			}
			#Attitude Neutral 
			{
				"I carry fine armor in my inventory.",
				"I shall buy thy pre-owned armor if thou wouldst be willing to sell.",
				"I sell excellent armor at reasonable prices.",
				"I craft some of the finest armor.",
				"Chainmail, shields, gauntlets... thou dost name it, I probably have it."
			}
			#Attitude Goodhearted 
			{
				"I carry only the best armor.",
				"If thou art willing to sell, I would buy thy unwanted armor from thee.",
				"I sell the best armor at fair prices.",
				"I craft some of the sturdiest armor.",
				"Chainmail, shields, gauntlets... thou dost name it, $milord/milady$, I probably have it."
			}
		}
		#KEY "*shield*" 
		{ 
			#Attitude Wicked 
			{
				"I have many different shields for sale.",
				"I carry kite-shields, heaters... thou dost name the shield, I should have it.",
				"I'll buy and sell what armor thou have or need."
			}
			#Attitude Neutral 
			{
				"I have several different shields in stock.",
				"I carry kite-shields, heaters, bucklers, and many more.",
				"I would be happy to buy and sell what pieces of armor thou dost have or need."
			}
			#Attitude Goodhearted 
			{
				"I have many shields in stock, $milord/milady$.",
				"I carry kite-shields, heaters, bucklers, and many more, $milord/milady$.",
				"I'll be willing to buy and sell what armor thou dost have or need, friend."
			}
		}
		#KEY "*skill*" 
		{
			#Attitude Wicked 
			{
				"Oh, no me digas que quieres aprender a hacer armaduras. Me costaría mucho entrenar a alguien como tú.",
				"¿Qué, quieres practicar la fabricación de armaduras? Bueno, podría enseñarte una o dos cosas.",
				"Bueno, por una pequeña compensación, podría mostrarte algunas cosas para practicar y mejorar tu habilidad en el trabajo del metal."
			}
			#Attitude Neutral 
			{
				"Se sabe que enseño a algunos a mejorar sus habilidades, por unas pocas monedas.",
				"Si necesitas algo de entrenamiento en la fabricación de armaduras, solo dilo.",
				"Puedo darte algo de práctica en la construcción de armaduras, todo lo que tienes que hacer es pedirlo. Y darme unas pocas monedas por mi tiempo."
			}
			#Attitude Goodhearted 
			{
				"Estaría feliz de ayudarte a entrenar en algunas técnicas de blindaje. Sin embargo, te pediría unas pocas monedas para ayudar a cubrir mi tiempo.",
				"Me sentiría honrado de enseñarte algo de lo que sé. Sin embargo, dependería de ti practicarlo.",
				"Puedo enseñarte solo si estás dispuesto a aprender. Y pagarme por el tiempo que invertiría. Unas pocas monedas serían suficientes."
			}
		}
	}
	#Sophistication Medium 
	{
		#KEY "*job*", "*what*do*do*", "*profession*", "*occupation*" 
		{
			#Attitude Wicked 
			{
				"I'm an armourer.",
				"I pound steel into submission.",
				"I create, buy, and sell armor."
			}
			#Attitude Neutral 
			{
				"I've been an armourer most of my life.",
				"I'm an armourer.",
				"I make and sell armor."
			}
			#Attitude Goodhearted 
			{
				"I make armor. I enjoy what I do! 'Tis good to hammer out a beautiful breastplate!",
				"Working metal is what I was born to do!."
			}
		}
		#KEY "*Breastplate*" 
		{
			#Attitude Wicked 
			{
				"Good for protection, breastplates are. Thou wouldst probably be in need of much protection, from the looks of it.",
				"A good breastplate could keep a sword from between thy ribs.",
				"Some skill and metal are all that goes in to the making of armor.  And the right tools, of course."
			}
			#Attitude Neutral 
			{
				"I sell breastplates at a reasonable price. I do need to make a profit.",
				"I tend to have a few breastplates in my inventory. Enough to fit most sizes of people, in fact.",
				"Thou can learn to make thine own. It takes metal, the tools of a smith, and skill."
			}
			#Attitude Goodhearted 
			{
				"I sell breastplates at a competitive price $milord/milady$. Knives too.",
				"I always try to carry a supply of breastplates and shields, $milord/milady$.",
				"Someday thou might be able to make thine own armor."
			}
		}
		#KEY "*plate*" "*padded*" "*chain*" "*ring*" "*gorget*" "*shield*" "*buckler*" "*heater*" "*helm*" "*gauntlet*" "*inventory*"  
		{ 
			#Attitude Wicked 
			{
				"Dost thou want armor? I carry plenty of that!",
				"I carry many different types of armor for many different types of people.",
				"Buy what thou dost need. Or sell what thou dost have extra.",
				"All my armor is guaranteed to reduce damage to the person wearing it."
			}
			#Attitude Neutral 
			{
				"In need of armor, my friend?  Thou'rt come to the right place!",
				"I have armor to fit everyone!",
				"I'll buy from thee what extra armor thou art carrying around.",
				"All of my armor is guaranteed to reduce the risk of injuries."
			}
			#Attitude Goodhearted 
			{
				"Dost thou need armor, $milord/milady$? Thou hast come to the right place!",
				"I have armor for everyone! Especially an adventuresome sort like thee, $milord/milady$",
				"I can offer thee fair price for what armor thou dost carry with thee.",
				"All of my armor is guaranteed to reduce the risk of injuries."
			}
		}
		#KEY "*Smith*"  "*Armourer*"  "*Armourer*"  
		{
			#Attitude Wicked 
			{
				"I've been a smith for a good number of years.",
				"Smithing is my life.",
				"I learned how to work metal before I could stand upright.",
				"I have armoring people all of my adult life."
			}
			#Attitude Neutral 
			{
				"I've been a smith for a good number of years.",
				"Smithing is my life.",
				"I learned how to work metal before I could stand upright.",
				"I have been armoring people all of my adult life."
			}
			#Attitude Goodhearted 
			{
				"I've been a smith for a good number of years.",
				"Smithing is my life.",
				"I learned how to work metal before I could stand upright.",
				"I have been an armourer all of my adult life."
			}
		}
		#KEY "*armor*"  "*Armour*" "*protection*" 
		{ 
			#Attitude Wicked 
			{
				"I carry a bunch of armor in my inventory.",
				"I shall offer to buy pre-owned armor if thou didst have some to sell.",
				"I can purchase thine armor, if thou dost wish it.",
				"I craft the finest armor.",
				"Chainmail, shields, gauntlets... thou dost name it, I probably have it."
			}
			#Attitude Neutral 
			{
				"I carry fine armor in my inventory.",
				"I shall buy thy pre-owned armor if thou wouldst be willing to sell.",
				"I sell excellent armor at reasonable prices.",
				"I craft some of the finest armor.",
				"Chainmail, shields, gauntlets... thou dost name it, I probably have it."
			}
			#Attitude Goodhearted 
			{
				"I carry only the best armor.",
				"If thou art willing to sell, I would buy thy unwanted armor from thee.",
				"I sell the best armor at fair prices.",
				"I craft some of the sturdiest armor.",
				"Chainmail, shields, gauntlets... thou dost name it, $milord/milady$, I probably have it."
			}
		}
		#KEY "*shield*" 
		{ 
			#Attitude Wicked 
			{
				"I have many different shields for sale.",
				"I carry kite-shields, heaters... thou dost name the shield, I should have it.",
				"I'll buy and sell what armor thou have or need."
			}
			#Attitude Neutral 
			{
				"I have several different shields in stock.",
				"I carry kite-shields, heaters, bucklers, and many more.",
				"I would be happy to buy and sell what pieces of armor thou dost have or need."
			}
			#Attitude Goodhearted 
			{
				"I have many shields in stock, $milord/milady$.",
				"I carry kite-shields, heaters, bucklers, and many more, $milord/milady$.",
				"I'll be willing to buy and sell what armor thou dost have or need, friend."
			}
		}
		#KEY "*skill*" 
		{   
			#Attitude Wicked 
			{
				"Oh, no me digas que quieres aprender a hacer armaduras. Me costaría mucho entrenar a alguien como tú.",
				"¿Qué, quieres practicar la fabricación de armaduras? Bueno, podría enseñarte una o dos cosas.",
				"Bueno, por una pequeña compensación, podría mostrarte algunas cosas para practicar y mejorar tu habilidad en el trabajo del metal."
			}
			#Attitude Neutral 
			{
				"Se sabe que enseño a algunos a mejorar sus habilidades, por unas pocas monedas.",
				"Si necesitas algo de entrenamiento en la fabricación de armaduras, solo dilo.",
				"Puedo darte algo de práctica en la construcción de armaduras, todo lo que tienes que hacer es pedirlo. Y darme unas pocas monedas por mi tiempo."
			}
			#Attitude Goodhearted 
			{
				"Estaría feliz de ayudarte a entrenar en algunas técnicas de blindaje. Sin embargo, te pediría unas pocas monedas para ayudar a cubrir mi tiempo.",
				"Me sentiría honrado de enseñarte algo de lo que sé. Sin embargo, dependería de ti practicarlo.",
				"Puedo enseñarte solo si estás dispuesto a aprender. Y pagarme por el tiempo que invertiría. Unas pocas monedas serían suficientes."
			}
		}
	}
	#Sophistication Low 
	{
		#KEY "*job*", "*what*do*do*", "*profession*", "*occupation*" 
		{
			#Attitude Wicked 
			{
				"I'm an armourer.",
				"I pound steel into armor.",
				"I make, buy, and sell armor."
			}
			#Attitude Neutral 
			{
				"Been an armorer most of my life.",
				"I'm an armorer.",
				"I make and sell armor."
			}
			#Attitude Goodhearted 
			{
			"I make armor. I love it! 'Tis good to hammer out a strong breastplate!",
			"Workin' metal is what I was born to do!."
			}
		}
		#KEY "*Breastplate*" 
		{
			#Attitude Wicked 
			{
				"Good for protection, breastplates are. Thou would probably be needin' a lot of protection, from the looks of it.",
				"A good breastplate can keep a sword from between thy ribs.",
				"Some skill and metal are all that goes into the making of armor. And the right tools, of course."
			}
			#Attitude Neutral 
			{
				"I sell breastplates at a good price. I gotta make a profit.",
				"I tend to have a few breastplates in the store. Enough to fit most sizes of people, in fact.",
				"Learn to make thine own! It takes metal, the tools of a smith, and skill."
			}
			#Attitude Goodhearted 
			{
				"I sell breastplates at a good price $milord/milady$. Knives too.",
				"I try to carry a supply of breastplates and shields, $milord/milady$.",
				"Someday thou might be able to make thine own armor."
			}
		}
		#KEY "*plate*" "*padded*" "*chain*" "*ring*" "*gorget*" "*shield*" "*buckler*" "*heater*" "*helm*" "*gauntlet*"  "*inventory*" 
		{
			#Attitude Wicked 
			{
				"Want armor? I got plenty of that!",
				"I carry a lot of different types of armor for lots of different types of people.",
				"Buy what thou need. Or sell what thou got extra.",
				"All my armor is guaranteed to limit damage to the person wearin' it."
			}
			#Attitude Neutral 
			{
				"Need armor? Thou'rt in the right place!",
				"I got armor for everyone!",
				"I'll buy what extra armor thou'rt carryin' 'round.",
				"All my armor is guaranteed to limit the risk of injuries."
			}
			#Attitude Goodhearted 
			{
				"Need armor, $milord/milady$? Thou'rt in the right place!",
				"I got armor enough for everyone! 'Specially a wanderin' sort like thee, $milord/milady$",
				"I can offer a fair price for what armor thou'rt carryin'.",
				"All my armor is guaranteed to limit the risk of injuries."
			}
		}
		#KEY "*Smith*"  "*Armourer*" "*Armourer*"  
		{
			#Attitude Wicked 
			{
				"I been a smith for years.",
				"Smithin's my life.",
				"I learned to work metal 'fore I could stand upright.",
				"I been armorin' people all of my adult life."
			}
			#Attitude Neutral 
			{
				"I been a smith for years.",
				"Smithin's my life.",
				"I learned to work metal 'fore I could stand upright.",
				"I been armorin' people all of my adult life."
			}
			#Attitude Goodhearted 
			{
				"I've been a smith for years.",
				"Smithin's my life.",
				"I learned to work metal 'fore I could stand upright.",
				"I been an armorer all my life."
			}
		}
		#KEY "*armor*"  "*Armour*" "*protection*" 
		{
			#Attitude Wicked 
			{
				"I carry a bunch of armor in my inventory.",
				"I'll offer to buy pre-owned armor if thou had some to sell.",
				"I can take thine armor off thy hands, if thou wish it.",
				"I make the finest armor.",
				"Chainmail, shields, gauntlets... thou names it, I probably have it."
			}
			#Attitude Neutral 
			{
				"I carry good armor in my inventory.",
				"I'll buy thy armor if thou'ld be willin' to sell.",
				"I sell great armor at good prices.",
				"I make some of the finest armor.",
				"Chainmail, shields, gauntlets... thou names it, I probably got it."
			}
			#Attitude Goodhearted 
			{
				"I got only the best armor.",
				"If thou'rt willin' to sell, I'd buy thy unwanted armor from thee.",
				"I sell the best armor at fair prices.",
				"I make some of the sturdiest armor.",
				"Chainmail, shields, gauntlets... thou names it, $milord/milady$, I probably got it."
			}
		}
		#KEY "*shield*" 
		{ 
			#Attitude Wicked 
			{
				"I got lotsa different shields for sale.",
				"I carry kite-shields, heaters... name the shield, I should have it.",
				"I'll buy and sell what armor thou got or need."
			}
			#Attitude Neutral 
			{
				"I got several different shields in stock.",
				"I carry kite-shields, heaters, bucklers, and many more.",
				"I'd be happy to buy and sell what armor thou got or need."
			}
			#Attitude Goodhearted 
			{
				"I have lotsa shields in stock, $milord/milady$.",
				"I got kite-shields, heaters, bucklers, and lots more, $milord/milady$.",
				"I'm willin' to buy and sell what armor thou have or need, friend."
			}
		}
		#KEY "*skill*" 
		{
			#Attitude Wicked 
			{
				"No tengo que enseñarte nada. Pero, si me dejas unas pocas monedas, supongo que podrías practicar un poco en mi tienda.",
				"¿Qué, quieres practicar la fabricación de armaduras? Bueno, podría enseñarte una o dos cosas. No debería ser difícil.",
				"Bueno, por un poco de dinero, podría mostrarte algunas cosas que podrías practicar."
			}
			#Attitude Neutral 
			{
				"Se sabe que enseño a algunas personas, por unas pocas monedas.",
				"Si necesitas que te entrenen en la fabricación de armaduras, solo dilo.",
				"Puedo dejarte practicar la construcción de armaduras aquí, todo lo que tienes que hacer es pedirlo. Y darme unas pocas monedas por mi tiempo."
			}
			#Attitude Goodhearted 
			{
				"¿No es adorable? Estaría feliz de ayudarte a practicar un poco de blindaje. Sin embargo, te pediría algo de dinero para ayudar a cubrir mi tiempo.",
				"Me sentiría honrado de enseñarte algo de lo que sé. Sin embargo, dependería de ti practicarlo.",
				"Te enseñaré solo si quieres aprender. Y págame por el tiempo que dedicaría. Unas pocas monedas estarían bien."
			}
		}
	}
}


