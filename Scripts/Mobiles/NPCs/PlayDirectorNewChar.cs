using System;
using Server;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Misc;
using Server.Commands;
using Server.Mobiles.Data;
using Server.OneTime;

namespace Server.Mobiles
{

    public class PlayDirectorNewChar : BaseCreature, IOneTime
    {

        public static List<Mobile> PlayersWaiting = new List<Mobile>();
		private int m_OneTimeType;
        public int OneTimeType
        {
            get{ return m_OneTimeType; }
            set{ m_OneTimeType = value; }
        }

        private Direction oldDirection;
        public override bool CanOpenDoors { get { return true; } }
        public override bool Unprovokable { get { return true; } }
		public override bool InitialInnocent{ get{ return true; } }
		public override bool DeleteCorpseOnDeath{ get{ return true; } }

        private ArrayList m_WayPoints;

        // Does the Attacker become Criminal?
        private bool m_criminalAction = false; //default

        [CommandProperty(AccessLevel.GameMaster)]
        public bool AttackIsCriminal
        {
            get { return m_criminalAction; }
            set { m_criminalAction = value; }
        }

        private Mobile Actor1;

        private Mobile Actor2;

        private Mobile Actor3;

        private Mobile NewPlayer;

        private int PlayStep;

        private bool ActivePlay;

        private int PlayCheck; // 0 is inactive, 1 is no response (play only), 2+ is response needed

        private int CheckCount;

        private bool Waiting;

        private int NoAnswer;

        [Constructable]
        public PlayDirectorNewChar()
            : this(Utility.RandomBool(), null, null)
        {
        }

        [Constructable]
        public PlayDirectorNewChar( bool sex)
            : this(sex, null, null)
        {
        }

        [Constructable]
        public PlayDirectorNewChar(bool sex, string name)
            : this(sex, name, null)
        {
        }

        [Constructable]
        public PlayDirectorNewChar(bool sex, string name, string title)
            : base(AIType.AI_PlayActor, FightMode.None, 10, 1, 0.8, 1.6)
        {
            m_WayPoints = new ArrayList();
            m_OneTimeType = 3;

            Name = name;
            Title = title;

            SetStr(45, 90);
            SetDex(35, 70);
            SetInt(35, 70);

            SetHits(35, 120);
            SetStam(60, 80);
            SetMana(25, 50);

            SetDamage(7, 25);
            SetDamageType(ResistanceType.Physical, 100);
            SetResistance(ResistanceType.Physical, 10, 20);

            VirtualArmor = 30;

            if (!sex)
            {
                Body = 0x191;
                if (Name == null)
                    Name = NameList.RandomName("female");
            }
            else
            {
                Body = 0x190;
                if (Name == null)
                    Name = NameList.RandomName("male");

                // add beard
                switch (Utility.Random(7))
                {
                    default: FacialHairItemID = 0x00; break; //None
                    case 0: FacialHairItemID = 0x2041; break; //Mustache
                    case 1: FacialHairItemID = 0x203F; break; //ShortBeard
                    case 2: FacialHairItemID = 0x204D; break; //Vandyke
                    case 3:
                        {
                            if (Utility.RandomBool())
                                FacialHairItemID = 0x203E; //LongBeard
                            else 
                                FacialHairItemID = 0x2040; //Goatee
                            break;
                        }
                }
            }

            switch (Utility.Random(7))
            {
                case 0: HairItemID = 0x2047; break; //Afro
                case 1: HairItemID = 0x2045; break; //PageboyHair
                case 2: HairItemID = 0x203D; break; //PonyTail
                case 3: HairItemID = 0x203B; break; //ShortHair
                case 4: HairItemID = 0x2049; break; //TwoPigTails
                case 5: HairItemID = 0x203C; break; //LongHair
                case 6:
                    {
                        if (Female)
                            HairItemID = 0x2046; //BunsHair
                        else
                            HairItemID = 0x2048; //ReceedingHair
                        break;
                    }
            }

            Hue = Utility.RandomSkinHue();
            HairHue = Utility.RandomHairHue();
            FacialHairHue = HairHue;
            SpeechHue = Utility.RandomDyedHue();
            Hidden = true;

            PlayStep = 0;
            PlayCheck = 0;
            CheckCount = 0;
            Waiting = false;
            ActivePlay = false;
            NoAnswer = 0;

            if (PlayersWaiting == null)
                PlayersWaiting = new List<Mobile>();

            Actor1 = null;
            Actor2 = null;
            Actor3 = null;

            NewPlayer = null;

            InitOutfit();
            InitPlay();
            Console.WriteLine( "created");

        }


        public virtual void InitOutfit()
        {
            int hueRange;

            // shoes (hehe - figure this one out)
            switch ( Utility.Random(9)  )
            {
                case 1: break; // barefoot poor
                case 2: AddItem(new Shoes(GetShoeHue())); break; // poor, normal
                case 3: AddItem(new Sandals(GetShoeHue())); break; // poor, rich
                default:
                case 4: AddItem(new Shoes(GetShoeHue())); break; // normal
                case 6: AddItem(new Boots(GetShoeHue())); break; // normal, rich
                case 9: AddItem(new ThighBoots(GetShoeHue())); break; // rich
            }

            if (Female)
            {
                hueRange = Utility.Random(5); //get a color scheme


                            switch (Utility.Random(4))
                            {
                                case 0:
                                    {
                                        AddItem(new PlainDress(GetRandomHueRange(hueRange)));
                                        break;
                                    }
                                case 1:
                                    {
                                        AddItem(new Skirt(GetRandomHueRange(hueRange)));
                                        AddItem(new Shirt(GetRandomHueRange(hueRange)));
                                        break;
                                    }
                                case 2:
                                    {
                                        AddItem(new LongPants(GetRandomHueRange(hueRange)));
                                        DoShirt(hueRange);
                                        break;
                                    }
                                case 3:
                                    {
                                        AddItem(new ShortPants(GetRandomHueRange(hueRange)));
                                        DoShirt(hueRange);
                                        break;
                                    }
                            }

                            switch (Utility.Random(5))
                            {
                                default: break;
                                case 0: AddItem(new Bonnet(GetRandomHueRange(hueRange))); break;
                                case 1: AddItem(new FloppyHat(GetRandomHueRange(hueRange))); break;
                                case 2: AddItem(new Cap(GetRandomHueRange(hueRange))); break;
                            }

                            if (Utility.RandomDouble() < .08)
                                AddItem(new FullApron(Utility.RandomNeutralHue()));

                            if (Utility.RandomBool())
                                AddItem(new GoldRing());


                
            }

            else // Male 
            {
                hueRange = Utility.Random(3);

                            switch (Utility.Random(3))
                            {
                                case 0: AddItem(new FancyShirt(GetRandomHueRange(hueRange))); break;
                                case 1: AddItem(new Doublet(GetRandomHueRange(hueRange))); break;
                                case 2: AddItem(new Shirt(GetRandomHueRange(hueRange))); break;
                            }

                            switch (Utility.Random(2))
                            {
                                case 0: AddItem(new LongPants(GetRandomHueRange(hueRange))); break;
                                case 1: AddItem(new ShortPants(GetRandomHueRange(hueRange))); break;
                            }

                            switch (Utility.Random(5))
                            {
                                default: break;
                                case 0: AddItem(new FloppyHat(Utility.RandomNeutralHue())); break;
                                case 1: AddItem(new FeatheredHat(GetRandomHueRange(hueRange))); break;
                            }

                            if (Utility.RandomDouble() < .16)
                                AddItem(new FullApron(Utility.RandomNeutralHue()));

                            if (Utility.RandomBool())
                                AddItem(new GoldRing());

                
            }
        }


        public void InitPlay()
        {
                Mobile mm = null;
                for ( int i = 0; i < PlayersWaiting.Count; i++ ) 
				{			
					Mobile m = (Mobile)PlayersWaiting[i];
					if (m == NewPlayer) 
                        mm = m;
				} 
                if (mm != null)
                {
                    PlayersWaiting.Remove( mm );
                } 

            //delete old actors
            if (Actor1 != null)
            Actor1.Delete();
            if (Actor2 != null)
            Actor2.Delete();
            if (Actor3 != null)
            Actor3.Delete();

            if (ActivePlay)
            {
                ActivePlay = false;
                PlayStep = 0;
            }

            if (NewPlayer != null)
                NewPlayer = null;

            if (m_WayPoints == null)
                m_WayPoints = new ArrayList();
            foreach( WayPoint wp in m_WayPoints )
            {
                if (wp != null)
				    wp.Delete();     
            }    

            m_WayPoints.Clear();  

                Actor1 = new PlayActor( true );
                //assign clothing for actor 1 here
                Actor1.AddItem( new Boots() );
                Item cloth1 = new Robe();
                    cloth1.Hue = 1635;
                    Actor1.AddItem( cloth1 );
                Item cloth2 = new WizardsHat();
                    cloth2.Hue = 1633;
                    Actor1.AddItem( cloth2 );
                Actor1.Name = "Peter Grimm";
                Actor1.Title = "el Vil";
                Actor1.SpeechHue = 233;
                Actor1.MoveToWorld( new Point3D( 1953, 1327, 0), Map.Malas );
            
                Actor2 = new PlayActor( true );
                Actor2.AddItem( new PlateChest() );
                Actor2.AddItem( new PlateLegs() );
                Actor2.AddItem( new PlateGorget() );
                Actor2.AddItem( new PlateGloves() );
                Actor2.AddItem( new PlateHelm() );
                Actor2.AddItem( new Boots( ) );
                Actor2.Name = "Sygun";
                Actor2.Title = "el Sumiso";
                Actor2.SpeechHue = 64;
                Actor2.MoveToWorld( new Point3D(1958,1323,0), Map.Malas );
            
                Actor3 = new PlayActor( true );
                Actor3.Name = "Giro Final";
                Actor3.Title = "el administrador";
                Item doublet = new Doublet();
                doublet.Hue = 1291;
                Actor3.AddItem( doublet );
                Item halby = new Halberd();
                halby.Hue = 1291;
                Actor3.AddItem( halby );
                Item kilt = new Kilt();
                kilt.Hue = 1291;
                Actor3.AddItem( kilt);
                Item boots = new Boots();
                boots.Hue = 1291;
                Actor3.AddItem( boots );
                Actor3.SpeechHue = 50;
                Actor3.MoveToWorld( new Point3D( 1908, 1321, -50), Map.Malas );

                       if (Actor1.X != 1953)
                            Actor1.MoveToWorld( new Point3D( 1953, 1327, 0), Map.Malas);
                        if (Actor2.X != 1958)
                            Actor2.MoveToWorld( new Point3D(1958,1323,0), Map.Malas);
                        if (Actor3.X != 1908)
                            Actor3.MoveToWorld( new Point3D(1908, 1321, -50), Map.Malas );

            PlayCheck = 0;
            NoAnswer = 0;

            if (CheckWaiting(null, false)) //someone is Waiting in the line
            {
                
                for ( int i = 0; i < PlayersWaiting.Count; i++ ) 
				{			
					Mobile m = (Mobile)PlayersWaiting[i];
					if (m != null) 
                        NewPlayer = m;
				} 
                if (NewPlayer != null  && NewPlayer.Map != Map.Trammel)
                {
                    PlayersWaiting.Remove( NewPlayer );
                    NewPlayer.MoveToWorld( new Point3D(1961, 1318, 0), Map.Malas ); 
                }           
            }
        }

        public static bool CheckWaiting( Mobile player, bool add)
        {
			if (add && player != null && player is PlayerMobile)
			{
				PlayersWaiting.Add( player );
				return false;
			}
			else 
			{
				for ( int i = 0; i < PlayersWaiting.Count; i++ ) 
				{			
					Mobile m = (Mobile)PlayersWaiting[i];
					if (m != null) 
                    {
						return true;
                    }
				}
				
				return false; //nobody here
			}
        }
        public void StartPlay( Mobile mob)
        {
            if (!(mob is PlayerMobile))
                return;
            
            NewPlayer = mob;

            ((PlayerMobile)NewPlayer).Direction = NewPlayer.GetDirectionTo( Actor2.Location );

            if (mob.AccessLevel == AccessLevel.Player)
                mob.Frozen = true;
                       
                        ActivePlay = true;
                        PlayCheck = 1;
                        PlayStep = 0;

        }
        public void OneTimeTick()
        {
            //check to make sure everything is as it should be
            if (Actor1 == null || Actor2 == null || Actor3 == null)
                InitPlay();

            if (!ActivePlay && NewPlayer != null)
                NewPlayer = null;

            if (ActivePlay)
            {
                if (NewPlayer == null)
                {
                    InitPlay();
                    return;
                }
                
                if (NewPlayer.Hunger <20 )
                    NewPlayer.Hunger = 20;
                if (NewPlayer.Thirst <20)
                    NewPlayer.Thirst = 20;

                if (PlayCheck == 1) // play is going to run
                {
                    if (PlayStep == 0)
                    {
                        // play just started, check actors are in place
                        if (Actor1.X != 1953)
                            MoveActor( Actor1, new Point3D( 1953, 1327, 0));
                        if (Actor2.X != 1958)
                            MoveActor( Actor2, new Point3D(1958,1323,0) );
                        if (Actor3.X != 1908)
                            Actor3.MoveToWorld( new Point3D(1908, 1321, -50), Map.Malas );//doesnt start in the room
                    }
                    if (PlayStep == 1)
                    {
                        //move actor 2 down in front of cell
                        MoveActor( Actor2, new Point3D(1963,1323,0) );
                    }
                    if (PlayStep == 4)
                    {
                        //Move actor 2 up in front of cell
                        MoveActor( Actor2, new Point3D(1958,1323,0) );
                        Actor1.PlaySound( 0xF9 );
                    }
                    if (PlayStep == 7)
                    {
                        //Move actor 2 down in front of cell
                        MoveActor( Actor2, new Point3D(1963,1323,0) );
                        Actor2.Say("*eructa*");
                    }
                    if (PlayStep == 10)
                    {
                        //Move actor 2 up in front of cell
                        MoveActor( Actor2, new Point3D(1958,1323,0) );
                    }
                    if (PlayStep == 11)
                    {
                        //move actor 2 down in front of cell
                        MoveActor( Actor2, new Point3D(1963,1323,0) );
                        Actor1.PlaySound( 0x249 );
                    }
                    if (PlayStep == 14)
                    {
                        //Move actor 2 up in front of cell
                        MoveActor( Actor2, new Point3D(1958,1323,0) );
                        Actor1.Say("Sí... sí....");
                    }
                    if (PlayStep == 17)
                    {
                        //Move actor 2 down in front of cell
                        MoveActor( Actor2, new Point3D(1963,1323,0) );
                    }
                    if (PlayStep == 20)
                    {
                        //Move actor 2 up in front of cell
                        MoveActor( Actor2, new Point3D(1958,1323,0) );
                    }
                    if (PlayStep == 22)
                    {
                        //Change direction to face Actor 1
                        ((PlayActor)Actor2).Direction = Actor2.GetDirectionTo( NewPlayer.Location );
                    }
                    if (PlayStep == 24)
                    {
                        //Change direction to face Actor 1
                        ((PlayActor)Actor2).Direction = Actor2.GetDirectionTo( Actor1.Location );

                        //Actor 2 says the player woke up
                        Actor2.Say("Mi Señor, el prisionero ha despertado.");
                    }
                    if (PlayStep == 28)
                    {
                        Actor1.Say("Maldición, mi nuevo hechizo de sueño ha vuelto a fallar.");
                    }
                    if (PlayStep == 34)
                    {
                        Actor1.Say("Necesitaré que me traigas más de ese ingrediente especial.");
                    }
                    if (PlayStep == 40)
                    {
                        Actor2.Say("Pero, Mi Señor");
                    }
                    if (PlayStep == 43)
                        Actor1.Say("Sin peros, holgazán.");
                    if (PlayStep == 45)
                        Actor1.Say("Ve, o volveré a soltar a mis mascotas paragon sobre ti.");
                    if (PlayStep == 50)
                        Actor2.Say("Sí, Mi Señor");
                    if (PlayStep == 52)
                    {
                        //Move actor to exit point
                        MoveActor( Actor2, new Point3D(1959,1332,0) );
                    }
                    if (PlayStep == 57)
                    {
                        Actor2.MoveToWorld( new Point3D(1908, 1321, -50), Map.Malas); //remove from play (via exit point)
                        Actor2.PlaySound( 0xEC );
                    }
                    if (PlayStep == 58)
                        Actor1.Say("*Refunfuña*");
                    
                    //Moongate gate = new Moongate();
                    
                    DummyGate gate = null;

                    if (PlayStep == 60)
                    {
                        Effects.PlaySound( Actor1.Location, Actor1.Map, 0x20E );
                        gate = new DummyGate();
                        gate.Hue = 543;
                        gate.MoveToWorld ( new Point3D(1964,1325,0), Map.Malas);
                    }
                    if (PlayStep == 62)
                    {
                        MoveActor(Actor1, new Point3D(1953,1325,0) ); // Actor 1 moves away from chair
                    }
                    if (PlayStep == 63)
                    {
                        ((PlayActor)Actor1).Direction = Actor1.GetDirectionTo( new Point3D(1964,1325,0) );
                        Actor1.Say("¿Qué es esto?");
                    }
                    if (PlayStep == 66)
                    {
                        Actor3.MoveToWorld(new Point3D(1964,1325,0), Map.Malas);
                        
                    }
                    if (PlayStep == 67)
                    {
                        MoveActor(Actor3, new Point3D(1962,1325,0) );
                    }
                    if (PlayStep == 68)
                    {
                        ((PlayActor)Actor3).Direction = Actor3.GetDirectionTo( Actor1.Location );
                        Actor3.Say("¡AJA! ¡Te encontré!");
                    }
                    if (PlayStep == 72)
                    {
                        Actor1.Say("¡Malditos percebes! ¡Han roto las defensas!");
                    }
                    if (PlayStep == 77)
                        Actor3.Say("¡Impediré que uses más exploits!");
                    if (PlayStep == 82)
                    {
                        Actor3.Say("Vas Flam");
                    }
                    if (PlayStep == 83)
                        Actor1.Say("¡Nos volveremos a ver, Final!");
                    if (PlayStep == 84)
                    {
                        Actor1.Say("¡Señor de los Exploits, llévame!");
                        Effects.SendLocationParticles( EffectItem.Create( Actor1.Location, Actor1.Map, EffectItem.DefaultDuration ), 0x3728, 10, 10, 0, 0, 2023, 0 );
                        Actor1.PlaySound( 0x1FE );
                    }
                    if (PlayStep == 85)
                    {
                        Actor1.MoveToWorld( new Point3D(1908, 1321, -50), Map.Malas);

                        if (gate != null)
                            gate.Delete();
                        else
                        {
                            Item del = null;
			                foreach ( object o in Actor3.GetObjectsInRange( 10 ) )
			                {
                                if (o is Item && ((Item)o).ItemID == 0xF6C )
                                    del = (Item)o;
                            }
                            if (del != null)
                                del.Delete();
                                    
                        }
                        Actor3.Say("Ese Peter Grimm... Siempre intentando encontrar nuevos exploits para conseguir oro ilimitado.");


                    }
                    if (PlayStep == 90)
                    {
                        MoveActor(Actor3, new Point3D(1961,1323,0));
                    }
                    if (PlayStep == 92)
                        ((PlayActor)Actor3).Direction = Actor3.GetDirectionTo( new Point3D(1961,1318,0) );
                    if (PlayStep == 95)
                        Actor3.Say("Vaya, vaya... ¿qué tenemos aquí?... ¡un nuevo aventurero!");
                    if (PlayStep == 100)
                        Actor3.Say("¿Atrapado en la cárcel, eh?");
                    if (PlayStep == 104)
                        Actor3.Say("Bueno... supongo que puedo dejarte salir.");
                    if (PlayStep == 108)
                        Actor3.Say("Pero primero necesito saber algunas cosas.");
                    if (PlayStep == 114)
                        Actor3.Say("Este mundo fue creado por un ser llamado Djeryv hace mucho tiempo.");
                    if (PlayStep == 120)
                        Actor3.Say("Pero ha cambiado, se ha transformado... para bien o para mal.");
                    if (PlayStep == 130)
                        Actor3.Say("Las fuerzas del Bien y del Mal luchan por el dominio, y el mundo está plagado de horribles seres de poder.");
                    if (PlayStep == 140)
                    {
                        Actor3.Say("Si te dejo salir, necesito saber algunas cosas...");
                    }
                    if (PlayStep == 145)
                    {
                        NewPlayer.SendGump(new PlayDirectorGump(this));
                        PlayCheck = 0; // Stop the play while waiting for gump response
                    }

                    if (PlayStep < 145)
                        PlayStep++;
                }
                else if (PlayCheck == 5)
                {
                    if (CheckCount == 2)
                        Actor3.Say("¡Nos vemos ahí fuera!");
                    if (CheckCount == 5) // needs to keep talking
                    {
                        Actor3.Say("An Vam Trav"); 
                    }

                    if (CheckCount == 8)
                    {
                        NewPlayer.Frozen = false;
                        NewPlayer.MoveToWorld(new Point3D(2983, 1043, 25), Map.Trammel);

                        for ( int i = 0; i < PlayersWaiting.Count; i++ ) 
                        {			
                            Mobile m = (Mobile)PlayersWaiting[i];
                            if (m == NewPlayer) 
                                PlayersWaiting.Remove( NewPlayer );
                        }         

                        InitPlay();
                    }
 
                    if (CheckCount >= 8)
                    {
                        CheckCount = 0;
                    }
                    else
                        CheckCount ++;


                }
                else if (Waiting  && NewPlayer != null)
                {
                    if (NoAnswer >= 10)
                    {
                        NewPlayer.MoveToWorld(new Point3D(2008, 1316, 0), Map.Malas);
                        NewPlayer.Frozen = false;
                        InitPlay();
                        return;
                        //Logout!!!! kick this player off
                    }
                    if (CheckCount > Utility.RandomMinMax(6,8))
                    {
                        switch (Utility.Random(7))
                        {
                            case 0: Actor3.Say("¿Hola?"); break;
                            case 1: Actor3.Say("Entonces, ¿qué será, sí o no?"); break;
                            case 2: Actor3.Say("Puedes simplemente decirme tu respuesta."); break;
                            case 3: Actor3.Say("¿Quieres que repita? Solo di 'repetir'."); break;
                            case 4: Actor3.Say("¿Qué será, amigo?"); break;
                            case 5: Actor3.Say("Lo sé... es una decisión difícil."); break;
                            case 6: Actor3.Say("Si quieres que repita lo que dije, solo pídeme que repita :)"); break;
                        }
                        CheckCount = 0;
                        NoAnswer ++;
                    }
                    else    
                        CheckCount ++;
                }

            }

		}

        public void MoveActor( Mobile actor, Point3D go)
        {
            if (actor == null || actor.Map == null)
                return;

            if (m_WayPoints == null)
                m_WayPoints = new ArrayList();

            WayPoint GoHere = new WayPoint();
			GoHere.Map = actor.Map;
			GoHere.Location = go;
            m_WayPoints.Add( GoHere );
            ((PlayActor)actor).CurrentWayPoint = GoHere;
        }

        public override void OnAfterDelete()
        {
            if (Actor1 != null)
                Actor1.Delete();
            if (Actor2 != null)
                Actor2.Delete();
            if (Actor3 != null)
                Actor3.Delete();
        }

        public virtual int GetShoeHue()
        {

            return Utility.RandomNeutralHue();
        }

        public virtual int GetRandomHueRange(int range)
        {
            // Used to create color coordinated outfits.
            // Passing 0-4 will return a random hue in a set range
            // 5-9 will return a Netural hue, above 9 is modded to 0-9
            switch (range % 10)
            {
                default:
                case 0: return Utility.RandomNeutralHue();
                case 1: return Utility.RandomBlueHue();
                case 2: return Utility.RandomGreenHue();
                case 3: return Utility.RandomRedHue();
                case 4: return Utility.RandomYellowHue();
            }
        }

        public virtual void DoShirt(int hues)
        {
            switch (Utility.Random(2))
            {
                case 0: AddItem(new Doublet(GetRandomHueRange(hues))); break;
                case 1: AddItem(new Shirt(GetRandomHueRange(hues))); break;
            }
        }


        public override void AggressiveAction(Mobile aggressor, bool criminal)
        {
            //base.AggressiveAction(aggressor, m_criminalAction);


        }

        public override void OnDamage(int amount, Mobile from, bool willKill)
        {
            //base.OnDamage(amount, from, willKill);

        }

		public override void OnDoubleClick( Mobile from )
		{
            if (from.AccessLevel > AccessLevel.Player)
               InitPlay();
        }

        public override void OnMovement(Mobile m, Point3D oldLocation)
        {

        }

        public override bool HandlesOnSpeech(Mobile from)
        {

            return true;

        }

        public bool BusyCheck()
        {
            bool busy = false;
            foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
                if (m is PlayerMobile && m.AccessLevel == AccessLevel.Player)
                    busy = true;
            }
            return busy;
        } 

        public override void OnSpeech(SpeechEventArgs e)
        {
            if (!(e.Mobile is PlayerMobile))
                return;

            Mobile m = e.Mobile;
            if (m.AccessLevel > AccessLevel.Player && Insensitive.Contains(e.Speech, "start"))
            {
                StartPlay(this);
            }

            base.OnSpeech(e);
        }

        public void HandleGumpResponse(Mobile from, bool choice1, bool choice2, bool choice3)
        {
            if (from is PlayerMobile)
            {
                PlayerMobile pm = (PlayerMobile)from;

                if (!choice1) // Chose not to respect others
                {
                    Actor3.Say("De acuerdo, es tu elección, ¡adiós!");
                    from.MoveToWorld(new Point3D(2008, 1316, 0), Map.Malas);
                    InitPlay();
                    return;
                }

                Actor3.Say("¡Muy bien! Bienvenido, amigo.");

                if (choice2) // Chose to be an avatar
                {
                    Actor3.Say("Buena elección.");
                    pm.Avatar = true;
                    pm.StatCap = 250;
                }
                else
                {
                    Actor3.Say("Está bien... prefieres una experiencia más fácil.");
                    pm.Avatar = false;
                    pm.StatCap = 225;
                }

                if (choice3) // Chose to be SoulBound
                {
                    Actor3.Say("¡Buena suerte!");
                    pm.SoulBound = true;
                    pm.Avatar = true; // Soulbound implies Avatar
                    pm.Backpack.AddItem(new SoulTome());
                    pm.SbRes = true;
                    pm.ResetPlayer(pm, true);
                }
                else
                {
                    Actor3.Say("¡Me parece justo!");
                    pm.SoulBound = false;
                }

                pm.Frozen = false;
                pm.MoveToWorld(new Point3D(2983, 1043, 25), Map.Trammel);
                InitPlay();
            }
        }

        public PlayDirectorNewChar(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)1);
            writer.Write((bool)m_criminalAction);
            writer.Write((Mobile)Actor1);
            writer.Write((Mobile)Actor2);
            writer.Write((Mobile)Actor3);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch (version)
            {

                case 1:
                    {
                        m_criminalAction = reader.ReadBool();
                        Actor1 = reader.ReadMobile();
                        Actor2 = reader.ReadMobile();
                        Actor3 = reader.ReadMobile();
                        goto case 0;
                    }
                case 0:
                    {
                        // obsolete version
                        break;
                    }
            }

            m_OneTimeType = 3;

        }
        public override void OnThink()
        {
            if (Actor1 == null || Actor2 == null || Actor3 == null)
                InitPlay();

            if (!Hidden) // keep me hidden!
                Hidden = true;

            if (!ActivePlay && NewPlayer == null) // look for new players
            {
               foreach ( Mobile mob in this.GetMobilesInRange( 5 ) )
                {
                    if (mob is PlayerMobile && mob.AccessLevel == AccessLevel.Player ) // new player found
                    {
                        StartPlay(mob);
                    }
                }
            }

            base.OnThink(); 
        }


    }
}
