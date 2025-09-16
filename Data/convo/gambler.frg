// Gambler function
//
// Keywords:
// job, gamble, game, cheat
//
//
// 
// - cwm


#Fragment Britannia, Job, Britannia_Gambler {

#Sophistication High {
#KEY "*job*" "*what*do*do*"  "*occupation*"  "*profession*"  {
#Attitude Wicked {
	"I'm a gamer by trade.  The cards and dice are my partners.",
	"I play the odds."
	}
#Attitude Neutral {
	"I'm a gamesman."
	"A good gambler doesn't need a job."
	}
#Attitude Goodhearted {
	"It could be said that I instruct the unsophisticated in the laws of elementary probability."
	"I am a sportsman and gentleman of leisure."
	}
	}
#KEY "*skill*" "*appraise*"  "*evaluate*"  "*peek*"  {
	#Attitude Wicked {
	"Puedo enseñarte algunas cosas. Podría ayudarte cuando lo necesites, si me sigues. Sin embargo, tienes que pagarme algo.",
"Deberías saber algo sobre la gente con la que es probable que pases tiempo cuando estés en la ciudad. Podría serte de utilidad.",
"Podría enseñarte algunas cosas que pueden serte de utilidad. No gratis, por supuesto."
			}
	#Attitude Neutral {
	"Si quieres aprender, podría persuadirte para que te enseñe a sobrevivir en la ciudad.",
"Podría mostrarte algunas cosas que a la guardia local no le gustarían mucho, estoy seguro.",
"Puedo enseñarte cosas sobre la gente que ves todos los días."
			}
	#Attitude Goodhearted {
	"Estaría feliz de enseñarte algunas, digamos, habilidades sociales.",
"Siempre puedes aprender cosas nuevas, amigo mío. Podría mostrarte algunas cosas, por ejemplo, sobre la gente que podrían ayudarte cuando no tengas un centavo.",
"Puedo enseñarte cosas que podrían ayudarte en las ciudades. Por supuesto, necesitaría que me pagaras por mi tiempo."
			}
		}
#KEY "*gamble*" {
#Attitude Wicked {
	"Gambling is what I should be doing now, instead of telling my life story to a tinhorn.",
	"Sure I gamble. What's it to thee?"
	}
#Attitude Neutral {
	"Gambling is only a vice if thou art inexperienced at it.",
	"Life is a gamble, and gambling is my life."
	}
#Attitude Goodhearted {
	"Stable boys gamble. Gentlemen game.",
	"I must confess an endless fascination with games of chance."
}
}
#KEY "*game*" {
#Attitude Wicked {
	"I've no wish to game with such as thee.",
	"If thou knowest where I might find a game, speak up. Otherwise, begone."
		}
#Attitude Neutral {
	"There's always a game going on somewhere, if one knows where to look.",
	"I only game with high rollers."
		}
#Attitude Goodhearted {
	"Gaming is an art. It's skill and will, not luck.",
	"There's always a game around when thou dost want one."
}
}
#KEY "*cheat*" {
#Attitude Wicked {
	"I'm no cheat, liar! [Attack]"
	}
#Attitude Neutral {
	"I'll not be called a cheat by such as thee. [Leave]"
	}
#Attitude Goodhearted {
	"If any man would call me a cheat, that man would be a liar."
}
}
}
#Sophistication Medium {
#KEY "*job*" "*what*do*do*"  "*occupation*"  "*profession*"  {
#Attitude Wicked {
	"I don't know about a job, but what I do is play the odds.",
	"I gamble."
	}
#Attitude Neutral {
	"I'm a gamesman."
	"A good gambler doesn't need a job."
	}
#Attitude Goodhearted {
	"It could be said that I instruct the unsophisticated in the laws of elementary probability."
	"I am a sportsman and gentleman of leisure."
	}
	}
#KEY "*skill*" "*appraise*"  "*evaluate*"  "*peek*"  {
	#Attitude Wicked {
	"Puedo enseñarte algunas cosas. Podría ayudarte cuando lo necesites, si me sigues. Sin embargo, tienes que pagarme algo.",
"Deberías saber algo sobre la gente con la que es probable que pases tiempo cuando estés en la ciudad. Podría serte de utilidad.",
"Podría enseñarte algunas cosas que pueden serte de utilidad. No gratis, por supuesto."
			}
	#Attitude Neutral {
	"Si quieres aprender, podría persuadirte para que te enseñe a sobrevivir en la ciudad.",
"Podría mostrarte algunas cosas que a la guardia local no le gustarían mucho, estoy seguro.",
"Puedo enseñarte cosas sobre la gente que ves todos los días."
			}
	#Attitude Goodhearted {
	"Estaría feliz de enseñarte algunas, digamos, habilidades sociales.",
"Siempre puedes aprender cosas nuevas, amigo mío. Podría mostrarte algunas cosas, por ejemplo, sobre la gente que podrían ayudarte cuando no tengas un centavo.",
"Puedo enseñarte cosas que podrían ayudarte en las ciudades. Por supuesto, necesitaría que me pagaras por mi tiempo."
			}
		}
#KEY "*gamble*" {
#Attitude Wicked {
	"Gambling is what I should be doing now, instead of telling my life story to a tinhorn.",
	"Sure I gamble. What's it to thee?"
	}
#Attitude Neutral {
	"Gambling is only a vice if thou'rt no good at it.",
	"Life is a gamble, and gambling is my life."
	}
#Attitude Goodhearted {
	"Stable boys gamble. Gentlemen game.",
	"I must confess an endless fascination with games of chance."
}
}
#KEY "*game*" {
#Attitude Wicked {
	"I've no wish to game with such as thee.",
	"If thou knowest where I might find a game, speak up. Otherwise, begone."
		}
#Attitude Neutral {
	"There's always a game going on somewhere, if one knows where to look.",
	"I only game with high rollers."
		}
#Attitude Goodhearted {
	"Gaming is an art. It's skill and will, not luck.",
	"There's always a game around when thou dost want one."
}
}
#KEY "*cheat*" {
#Attitude Wicked {
	"I'm no cheat, liar! [Attack]"
	}
#Attitude Neutral {
	"I'll not be called a cheat by such as thee. [Leave]"
	}
#Attitude Goodhearted {
	"If any man would call me a cheat, that man would be a liar."
}
}
}
#Sophistication Low {
#KEY "*job*" "*what*do*do*"  "*occupation*"  "*profession*"  {
#Attitude Wicked {
	"I don't know about no job, but what I do is gamble.",
	"I gamble."
	}
#Attitude Neutral {
	"I'm a gamesman."
	"A good gambler don't need a job."
	}
#Attitude Goodhearted {
	"It could be said that I play the odds."
	"I'm a sportsman and gentleman of leisure."
	}
	}
#KEY "*skill*" "*appraise*"  "*evaluate*"  "*peek*"  {
	#Attitude Wicked {
	"Puedo enseñar cosas que te ayudarán cuando lo necesites, si me sigues. Sin embargo, tienes que pagarme algo.",
"Deberías saber algo sobre la gente con la que pasas el tiempo. Podría serte de utilidad.",
"Podría enseñarte algunas cosas que pueden serte de utilidad. No gratis, por supuesto."
			}
	#Attitude Neutral {
	"Si quieres aprender, podría persuadirte para que te enseñe a sobrevivir en la ciudad.",
"Podría mostrarte cosas que a la guardia local no le gustarían, estoy seguro.",
"Puedo enseñarte cosas sobre la gente que ves todos los días."
			}
	#Attitude Goodhearted {
	"Estaría feliz de enseñarte algunas, digamos, habilidades sociales.",
"Puedes aprender de mí. Podría mostrarte algunas cosas que podrían ayudarte cuando no tengas un centavo.",
"Puedo enseñarte cosas que podrían ayudarte en las ciudades. Por supuesto, necesitaría que me pagaras por mi tiempo."
			}
		}
#KEY "*gamble*" {
#Attitude Wicked {
	"Gamblin' is what I should be doing now, 'stead of talkin' to thee.",
	"Sure I gamble. What's it to thee?"
	}
#Attitude Neutral {
	"Gamblin's only a vice if thou'rt no good at it.",
	"Life's a gamble, and gamblin's my life."
	}
#Attitude Goodhearted {
	"Stable boys gamble. I game.",
	"I must confess an interest in games of chance."
}
}
#KEY "*game*" {
#Attitude Wicked {
	"I ain't got no wish to game with such as thee.",
	"If thou knows where I might find a game, speak up. Otherwise, begone."
		}
#Attitude Neutral {
	"There's always a game going on somewheres, if one knows where to look.",
	"I only game with high rollers."
		}
#Attitude Goodhearted {
	"Gaming's an art. It's skill and will, not luck.",
	"There's always a game around when thou wants one."
}
}
#KEY "*cheat*" {
#Attitude Wicked {
	"I ain't no cheat! [Attack]"
	}
#Attitude Neutral {
	"I ain't gonna sit an' be called a cheat! [Leave]"
	}
#Attitude Goodhearted {
	"If any man would call me a cheat, that man would be a liar."
}
}
}
}
