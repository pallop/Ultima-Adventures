using System;
using Server.Items;
using Server.Spells;

namespace Server.Engines.Craft
{
	public class DefInscription : CraftSystem
	{
		public override SkillName MainSkill
		{
			get { return SkillName.Inscribe; }
		}

		public override int GumpTitleNumber
		{
			get { return 1044009; } // <CENTER>INSCRIPTION MENU</CENTER>
		}

		private static CraftSystem m_CraftSystem;

		public static CraftSystem CraftSystem
		{
			get
			{
				if (m_CraftSystem == null)
					m_CraftSystem = new DefInscription();

				return m_CraftSystem;
			}
		}

		public override double GetChanceAtMin(CraftItem item)
		{
			return 0.0; // 0%
		}

		private DefInscription()
			: base(1, 1, 1.25)// base( 1, 1, 3.0 )
		{
		}

		public override int CanCraft(Mobile from, BaseTool tool, Type typeItem)
		{
			if (tool == null || tool.Deleted || tool.UsesRemaining < 0)
				return 1044038; // You have worn out your tool!
			else if (!BaseTool.CheckAccessible(tool, from))
				return 1044263; // The tool must be on your person to use.

			if (typeItem != null)
			{
				object o = Activator.CreateInstance(typeItem);

				if (o is SpellScroll)
				{
					SpellScroll scroll = (SpellScroll)o;
					Spellbook book = Spellbook.Find(from, scroll.SpellID);

					bool hasSpell = (book != null && book.HasSpell(scroll.SpellID));

					scroll.Delete();

					return (hasSpell ? 0 : 1042404); // null : You don't have that spell!
				}
				else if (o is Item)
				{
					((Item)o).Delete();
				}
			}

			return 0;
		}

		public override void PlayCraftEffect(Mobile from)
		{
			from.PlaySound(0x249);
		}

		private static Type typeofSpellScroll = typeof(SpellScroll);

		public override int PlayEndingEffect(Mobile from, bool failed, bool lostMaterial, bool toolBroken, int quality, bool makersMark, CraftItem item)
		{
			if (toolBroken)
				from.SendLocalizedMessage(1044038); // You have worn out your tool

			if (!typeofSpellScroll.IsAssignableFrom(item.ItemType)) //  not a scroll
			{
				if (failed)
				{
					if (lostMaterial)
						return 1044043; // You failed to create the item, and some of your materials are lost.
					else
						return 1044157; // You failed to create the item, but no materials were lost.
				}
				else
				{
					if (quality == 0)
						return 502785; // You were barely able to make this item.  It's quality is below average.
					else if (makersMark && quality == 2)
						return 1044156; // You create an exceptional quality item and affix your maker's mark.
					else if (quality == 2)
						return 1044155; // You create an exceptional quality item.
					else
						return 1044154; // You create the item.
				}
			}
			else
			{
				if (failed)
					return 501630; // You fail to inscribe the scroll, and the scroll is ruined.
				else
					return 501629; // You inscribe the spell and put the scroll in your backpack.
			}
		}

		private int m_Circle, m_Mana;

		private enum Reg { BlackPearl, Bloodmoss, Garlic, Ginseng, MandrakeRoot, Nightshade, SulfurousAsh, SpidersSilk }

		private Type[] m_RegTypes = new Type[]
			{
				typeof( BlackPearl ),
				typeof( Bloodmoss ),
				typeof( Garlic ),
				typeof( Ginseng ),
				typeof( MandrakeRoot ),
				typeof( Nightshade ),
				typeof( SulfurousAsh ),
				typeof( SpidersSilk )
			};

		private int m_Index;

		private void AddSpell(Type type, params Reg[] regs)
		{
			double minSkill, maxSkill;

			switch (m_Circle)
			{
				default:
				case 0: minSkill = -25.0; maxSkill = 25.0; break;
				case 1: minSkill = -10.8; maxSkill = 39.2; break;
				case 2: minSkill = 03.5; maxSkill = 53.5; break;
				case 3: minSkill = 17.8; maxSkill = 67.8; break;
				case 4: minSkill = 32.1; maxSkill = 82.1; break;
				case 5: minSkill = 46.4; maxSkill = 96.4; break;
				case 6: minSkill = 60.7; maxSkill = 110.7; break;
				case 7: minSkill = 75.0; maxSkill = 125.0; break;
			}

			int index = AddCraft(type, 1044369 + m_Circle, 1044381 + m_Index++, minSkill, maxSkill, m_RegTypes[(int)regs[0]], 1044353 + (int)regs[0], 1, 1044361 + (int)regs[0]);

			for (int i = 1; i < regs.Length; ++i)
				AddRes(index, m_RegTypes[(int)regs[i]], 1044353 + (int)regs[i], 1, 1044361 + (int)regs[i]);

			AddRes(index, typeof(BlankScroll), 1044377, 1, 1044378);

			SetManaReq(index, m_Mana);
		}

		private void AddNecroSpell(int spell, int mana, double minSkill, Type type, params Type[] regs)
		{
			int id = CraftItem.ItemIDOf(regs[0]);

			int index = AddCraft(type, 1061677, 1060509 + spell, minSkill, minSkill + 1.0, regs[0], id < 0x4000 ? 1020000 + id : 1078872 + id, 1, 501627);	//Yes, on OSI it's only 1.0 skill diff'.  Don't blame me, blame OSI.

			for (int i = 1; i < regs.Length; ++i)
			{
				id = CraftItem.ItemIDOf(regs[i]);
				AddRes(index, regs[i], id < 0x4000 ? 1020000 + id : 1078872 + id, 1, 501627);
			}

			AddRes(index, typeof(BlankScroll), 1044377, 1, 1044378);

			SetManaReq(index, mana);
		}

		public override void InitCraftList()
		{
			m_Circle = 0;
			m_Mana = 4;

			AddSpell(typeof(ReactiveArmorScroll), Reg.Garlic, Reg.SpidersSilk, Reg.SulfurousAsh);
			AddSpell(typeof(ClumsyScroll), Reg.Bloodmoss, Reg.Nightshade);
			AddSpell(typeof(CreateFoodScroll), Reg.Garlic, Reg.Ginseng, Reg.MandrakeRoot);
			AddSpell(typeof(FeeblemindScroll), Reg.Nightshade, Reg.Ginseng);
			AddSpell(typeof(HealScroll), Reg.Garlic, Reg.Ginseng, Reg.SpidersSilk);
			AddSpell(typeof(MagicArrowScroll), Reg.SulfurousAsh);
			AddSpell(typeof(NightSightScroll), Reg.SpidersSilk, Reg.SulfurousAsh);
			AddSpell(typeof(WeakenScroll), Reg.Garlic, Reg.Nightshade);

			m_Circle = 1;
			m_Mana = 6;

			AddSpell(typeof(AgilityScroll), Reg.Bloodmoss, Reg.MandrakeRoot);
			AddSpell(typeof(CunningScroll), Reg.Nightshade, Reg.MandrakeRoot);
			AddSpell(typeof(CureScroll), Reg.Garlic, Reg.Ginseng);
			AddSpell(typeof(HarmScroll), Reg.Nightshade, Reg.SpidersSilk);
			AddSpell(typeof(MagicTrapScroll), Reg.Garlic, Reg.SpidersSilk, Reg.SulfurousAsh);
			AddSpell(typeof(MagicUnTrapScroll), Reg.Bloodmoss, Reg.SulfurousAsh);
			AddSpell(typeof(ProtectionScroll), Reg.Garlic, Reg.Ginseng, Reg.SulfurousAsh);
			AddSpell(typeof(StrengthScroll), Reg.Nightshade, Reg.MandrakeRoot);

			m_Circle = 2;
			m_Mana = 9;

			AddSpell(typeof(BlessScroll), Reg.Garlic, Reg.MandrakeRoot);
			AddSpell(typeof(FireballScroll), Reg.BlackPearl);
			AddSpell(typeof(MagicLockScroll), Reg.Bloodmoss, Reg.Garlic, Reg.SulfurousAsh);
			AddSpell(typeof(PoisonScroll), Reg.Nightshade);
			AddSpell(typeof(TelekinisisScroll), Reg.Bloodmoss, Reg.MandrakeRoot);
			AddSpell(typeof(TeleportScroll), Reg.Bloodmoss, Reg.MandrakeRoot);
			AddSpell(typeof(UnlockScroll), Reg.Bloodmoss, Reg.SulfurousAsh);
			AddSpell(typeof(WallOfStoneScroll), Reg.Bloodmoss, Reg.Garlic);

			m_Circle = 3;
			m_Mana = 11;

			AddSpell(typeof(ArchCureScroll), Reg.Garlic, Reg.Ginseng, Reg.MandrakeRoot);
			AddSpell(typeof(ArchProtectionScroll), Reg.Garlic, Reg.Ginseng, Reg.MandrakeRoot, Reg.SulfurousAsh);
			AddSpell(typeof(CurseScroll), Reg.Garlic, Reg.Nightshade, Reg.SulfurousAsh);
			AddSpell(typeof(FireFieldScroll), Reg.BlackPearl, Reg.SpidersSilk, Reg.SulfurousAsh);
			AddSpell(typeof(GreaterHealScroll), Reg.Garlic, Reg.SpidersSilk, Reg.MandrakeRoot, Reg.Ginseng);
			AddSpell(typeof(LightningScroll), Reg.MandrakeRoot, Reg.SulfurousAsh);
			AddSpell(typeof(ManaDrainScroll), Reg.BlackPearl, Reg.SpidersSilk, Reg.MandrakeRoot);
			AddSpell(typeof(RecallScroll), Reg.BlackPearl, Reg.Bloodmoss, Reg.MandrakeRoot);

			m_Circle = 4;
			m_Mana = 14;

			AddSpell(typeof(BladeSpiritsScroll), Reg.BlackPearl, Reg.Nightshade, Reg.MandrakeRoot);
			AddSpell(typeof(DispelFieldScroll), Reg.BlackPearl, Reg.Garlic, Reg.SpidersSilk, Reg.SulfurousAsh);
			AddSpell(typeof(IncognitoScroll), Reg.Bloodmoss, Reg.Garlic, Reg.Nightshade);
			AddSpell(typeof(MagicReflectScroll), Reg.Garlic, Reg.MandrakeRoot, Reg.SpidersSilk);
			AddSpell(typeof(MindBlastScroll), Reg.BlackPearl, Reg.MandrakeRoot, Reg.Nightshade, Reg.SulfurousAsh);
			AddSpell(typeof(ParalyzeScroll), Reg.Garlic, Reg.MandrakeRoot, Reg.SpidersSilk);
			AddSpell(typeof(PoisonFieldScroll), Reg.BlackPearl, Reg.Nightshade, Reg.SpidersSilk);
			AddSpell(typeof(SummonCreatureScroll), Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SpidersSilk);

			m_Circle = 5;
			m_Mana = 20;

			AddSpell(typeof(DispelScroll), Reg.Garlic, Reg.MandrakeRoot, Reg.SulfurousAsh);
			AddSpell(typeof(EnergyBoltScroll), Reg.BlackPearl, Reg.Nightshade);
			AddSpell(typeof(ExplosionScroll), Reg.Bloodmoss, Reg.MandrakeRoot);
			AddSpell(typeof(InvisibilityScroll), Reg.Bloodmoss, Reg.Nightshade);
			AddSpell(typeof(MarkScroll), Reg.Bloodmoss, Reg.BlackPearl, Reg.MandrakeRoot);
			AddSpell(typeof(MassCurseScroll), Reg.Garlic, Reg.MandrakeRoot, Reg.Nightshade, Reg.SulfurousAsh);
			AddSpell(typeof(ParalyzeFieldScroll), Reg.BlackPearl, Reg.Ginseng, Reg.SpidersSilk);
			AddSpell(typeof(RevealScroll), Reg.Bloodmoss, Reg.SulfurousAsh);

			m_Circle = 6;
			m_Mana = 40;

			AddSpell(typeof(ChainLightningScroll), Reg.BlackPearl, Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SulfurousAsh);
			AddSpell(typeof(EnergyFieldScroll), Reg.BlackPearl, Reg.MandrakeRoot, Reg.SpidersSilk, Reg.SulfurousAsh);
			AddSpell(typeof(FlamestrikeScroll), Reg.SpidersSilk, Reg.SulfurousAsh);
			AddSpell(typeof(GateTravelScroll), Reg.BlackPearl, Reg.MandrakeRoot, Reg.SulfurousAsh);
			AddSpell(typeof(ManaVampireScroll), Reg.BlackPearl, Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SpidersSilk);
			AddSpell(typeof(MassDispelScroll), Reg.BlackPearl, Reg.Garlic, Reg.MandrakeRoot, Reg.SulfurousAsh);
			AddSpell(typeof(MeteorSwarmScroll), Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SulfurousAsh, Reg.SpidersSilk);
			AddSpell(typeof(PolymorphScroll), Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SpidersSilk);

			m_Circle = 7;
			m_Mana = 50;

			AddSpell(typeof(EarthquakeScroll), Reg.Bloodmoss, Reg.MandrakeRoot, Reg.Ginseng, Reg.SulfurousAsh);
			AddSpell(typeof(EnergyVortexScroll), Reg.BlackPearl, Reg.Bloodmoss, Reg.MandrakeRoot, Reg.Nightshade);
			AddSpell(typeof(ResurrectionScroll), Reg.Bloodmoss, Reg.Garlic, Reg.Ginseng);
			AddSpell(typeof(SummonAirElementalScroll), Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SpidersSilk);
			AddSpell(typeof(SummonDaemonScroll), Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SpidersSilk, Reg.SulfurousAsh);
			AddSpell(typeof(SummonEarthElementalScroll), Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SpidersSilk);
			AddSpell(typeof(SummonFireElementalScroll), Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SpidersSilk, Reg.SulfurousAsh);
			AddSpell(typeof(SummonWaterElementalScroll), Reg.Bloodmoss, Reg.MandrakeRoot, Reg.SpidersSilk);

			if (Core.SE)
			{
				AddNecroSpell(0, 23, 39.6, typeof(AnimateDeadScroll), Reagent.GraveDust, Reagent.DaemonBlood);
				AddNecroSpell(1, 13, 19.6, typeof(BloodOathScroll), Reagent.DaemonBlood);
				AddNecroSpell(2, 11, 19.6, typeof(CorpseSkinScroll), Reagent.BatWing, Reagent.GraveDust);
				AddNecroSpell(3, 7, 19.6, typeof(CurseWeaponScroll), Reagent.PigIron);
				AddNecroSpell(4, 11, 19.6, typeof(EvilOmenScroll), Reagent.BatWing, Reagent.NoxCrystal);
				AddNecroSpell(5, 11, 39.6, typeof(HorrificBeastScroll), Reagent.BatWing, Reagent.DaemonBlood);
				AddNecroSpell(6, 23, 69.6, typeof(LichFormScroll), Reagent.GraveDust, Reagent.DaemonBlood, Reagent.NoxCrystal);
				AddNecroSpell(7, 17, 29.6, typeof(MindRotScroll), Reagent.BatWing, Reagent.DaemonBlood, Reagent.PigIron);
				AddNecroSpell(8, 5, 19.6, typeof(PainSpikeScroll), Reagent.GraveDust, Reagent.PigIron);
				AddNecroSpell(9, 17, 49.6, typeof(PoisonStrikeScroll), Reagent.NoxCrystal);
				AddNecroSpell(10, 29, 64.6, typeof(StrangleScroll), Reagent.DaemonBlood, Reagent.NoxCrystal);
				AddNecroSpell(11, 17, 29.6, typeof(SummonFamiliarScroll), Reagent.BatWing, Reagent.GraveDust, Reagent.DaemonBlood);
				AddNecroSpell(12, 23, 98.6, typeof(VampiricEmbraceScroll), Reagent.BatWing, Reagent.NoxCrystal, Reagent.PigIron);
				AddNecroSpell(13, 41, 79.6, typeof(VengefulSpiritScroll), Reagent.BatWing, Reagent.GraveDust, Reagent.PigIron);
				AddNecroSpell(14, 23, 59.6, typeof(WitherScroll), Reagent.GraveDust, Reagent.NoxCrystal, Reagent.PigIron);
				AddNecroSpell(15, 17, 79.6, typeof(WraithFormScroll), Reagent.NoxCrystal, Reagent.PigIron);
				AddNecroSpell(16, 40, 79.6, typeof(ExorcismScroll), Reagent.NoxCrystal, Reagent.GraveDust);
			}

			int index;

			// Blank Scrolls
			index = AddCraft( typeof( BlankScroll ), 1044294, 1044377, 40.0, 70.0, typeof( BarkFragment ), 1073477, 1, 1073478 );
			SetUseAllRes( index, true );

			// Runebook
			index = AddCraft( typeof( Runebook ), 1044294, 1041267, 45.0, 95.0, typeof( BlankScroll ), 1044377, 8, 1044378 );
			AddRes( index, typeof( RecallScroll ), 1044445, 1, 1044253 );
			AddRes( index, typeof( Beeswax ), 1025154, 5, 1044253 );
			AddRes( index, typeof( GateTravelScroll ), 1044446, 1, 1044253 );

			index = AddCraft(typeof(Engines.BulkOrders.BulkOrderBook), 1044294, 1028793, 65.0, 115.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 5, 1044253 );

			index = AddCraft(typeof(Spellbook), 1044294, 1023834, 50.0, 126, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 5, 1044253 );

			index = AddCraft(typeof(NecromancerSpellbook), 1044294, 1028787, 50.0, 126, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 5, 1044253 );

			//index = AddCraft(typeof(SongBook), 1044294, 1028787, 50.0, 126, typeof(BlankScroll), 1044377, 10, 1044378); //nox change
			index = AddCraft(typeof(SongBook), 1044294, "Libro de Canciones", 50.0, 126, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 5, 1044253 );

			MarkOption = true;

			index = AddCraft(typeof(ArmysPaeonScroll), 1044294, "Pergamino de Peón de Ejército", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(EnchantingEtudeScroll), 1044294, "Estudio Encantador", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(EnergyCarolScroll), 1044294, "Villancico de Energía", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(EnergyThrenodyScroll), 1044294, "Trenodia de Energía", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(FireCarolScroll), 1044294, "Villancico de Fuego", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(FireThrenodyScroll), 1044294, "Trenodia de Fuego", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(FoeRequiemScroll), 1044294, "Réquiem del Enemigo", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(IceCarolScroll), 1044294, "Villancico de Hielo", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(IceThrenodyScroll), 1044294, "Trenodia de Hielo", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(KnightsMinneScroll), 1044294, "Minne de Caballero", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(MagesBalladScroll), 1044294, "Balada de Magos", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(MagicFinaleScroll), 1044294, "Final Mágico", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(PoisonCarolScroll), 1044294, "Villancico de Veneno", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(PoisonThrenodyScroll), 1044294, "Trenodia de Veneno", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(SheepfoeMamboScroll), 1044294, "Mambo de la Oveja Enemiga", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			index = AddCraft(typeof(SinewyEtudeScroll), 1044294, "Estudio Nervudo", 75.0, 95.0, typeof (BlankScroll), 1044377, 1, 1044378);
			AddRes( index, typeof(Lute), "laúd", 1, 1044253);
			AddSkill( index, SkillName.Musicianship, 95.0, 120.0);

			//Expert Study Books
			index = AddCraft( typeof(StandardAlchemyStudyBook), "Libros de Estudio de Experto", "Alquimia Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Alchemy, 70.0, 80.0 );

			index = AddCraft( typeof(StandardAnatomyStudyBook), "Libros de Estudio de Experto", "Anatomía Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Anatomy, 70.0, 80.0 );

			index = AddCraft( typeof(StandardAnimalLoreStudyBook), "Libros de Estudio de Experto", "Conocimiento Animal Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.AnimalLore, 70.0, 80.0 );

			index = AddCraft( typeof(StandardAnimalTamingStudyBook), "Libros de Estudio de Experto", "Doma de Animales Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.AnimalTaming, 70.0, 80.0 );

			index = AddCraft( typeof(StandardArcheryStudyBook), "Libros de Estudio de Experto", "Arquería Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Archery, 70.0, 80.0 );

			index = AddCraft( typeof(StandardArmsLoreStudyBook), "Libros de Estudio de Experto", "Conocimiento de Armas Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.ArmsLore, 70.0, 80.0 );

			index = AddCraft( typeof(StandardBeggingStudyBook), "Libros de Estudio de Experto", "Mendicidad Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Begging, 70.0, 80.0 );

			index = AddCraft( typeof(StandardBlacksmithStudyBook), "Libros de Estudio de Experto", "Herrería Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Blacksmith, 70.0, 80.0 );	

			index = AddCraft( typeof(StandardBushidoStudyBook), "Libros de Estudio de Experto", "Bushido Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Bushido, 70.0, 80.0 );	

			index = AddCraft( typeof(StandardCampingStudyBook), "Libros de Estudio de Experto", "Acampada Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Camping, 70.0, 80.0 );

			index = AddCraft( typeof(StandardCarpentryStudyBook), "Libros de Estudio de Experto", "Carpintería Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Carpentry, 70.0, 80.0 );

			index = AddCraft( typeof(StandardCartographyStudyBook), "Libros de Estudio de Experto", "Cartografía Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Cartography, 70.0, 80.0 );

			index = AddCraft( typeof(StandardChivalryStudyBook), "Libros de Estudio de Experto", "Caballería Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Chivalry, 70.0, 80.0 );

			index = AddCraft( typeof(StandardCookingStudyBook), "Libros de Estudio de Experto", "Cocina Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Cooking, 70.0, 80.0 );

			index = AddCraft( typeof(StandardDetectHiddenStudyBook), "Libros de Estudio de Experto", "Detección de Ocultos Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.DetectHidden, 70.0, 80.0 );

			index = AddCraft( typeof(StandardDiscordanceStudyBook), "Libros de Estudio de Experto", "Discordancia Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Discordance, 70.0, 80.0 );

			index = AddCraft( typeof(StandardEvalIntStudyBook), "Libros de Estudio de Experto", "Evaluación de Inteligencia Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.EvalInt, 70.0, 80.0 );

			index = AddCraft( typeof(StandardFencingStudyBook), "Libros de Estudio de Experto", "Esgrima Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Fencing, 70.0, 80.0 );

			index = AddCraft( typeof(StandardFishingStudyBook), "Libros de Estudio de Experto", "Pesca Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Fishing, 70.0, 80.0 );

			index = AddCraft( typeof(StandardFocusStudyBook), "Libros de Estudio de Experto", "Concentración Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Focus, 70.0, 80.0 );

			index = AddCraft( typeof(StandardForensicsStudyBook), "Libros de Estudio de Experto", "Evaluación Forense Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Forensics, 70.0, 80.0 );

			index = AddCraft( typeof(StandardHealingStudyBook), "Libros de Estudio de Experto", "Curación Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Healing, 70.0, 80.0 );

			index = AddCraft( typeof(StandardHerdingStudyBook), "Libros de Estudio de Experto", "Pastoreo Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Herding, 70.0, 80.0 );

			index = AddCraft( typeof(StandardHidingStudyBook), "Libros de Estudio de Experto", "Ocultación Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Hiding, 70.0, 80.0 );

			index = AddCraft( typeof(StandardInscribeStudyBook), "Libros de Estudio de Experto", "Inscripción Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Inscribe, 70.0, 80.0 );

			index = AddCraft( typeof(StandardItemIDStudyBook), "Libros de Estudio de Experto", "Identificación de Objetos Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.ItemID, 70.0, 80.0 );

			index = AddCraft( typeof(StandardLockpickingStudyBook), "Libros de Estudio de Experto", "Ganzuado Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Lockpicking, 70.0, 80.0 );

			index = AddCraft( typeof(StandardLumberjackingStudyBook), "Libros de Estudio de Experto", "Tala de Árboles Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Lumberjacking, 70.0, 80.0 );

			index = AddCraft( typeof(StandardMacingStudyBook), "Libros de Estudio de Experto", "Lucha con Maza Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Macing, 70.0, 80.0 );

			index = AddCraft( typeof(StandardMageryStudyBook), "Libros de Estudio de Experto", "Magia Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Magery, 70.0, 80.0 );

			index = AddCraft( typeof(StandardMagicResistStudyBook), "Libros de Estudio de Experto", "Resistencia Mágica Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.MagicResist, 70.0, 80.0 );

			index = AddCraft( typeof(StandardMeditationStudyBook), "Libros de Estudio de Experto", "Meditación Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Meditation, 70.0, 80.0 );

			index = AddCraft( typeof(StandardMiningStudyBook), "Libros de Estudio de Experto", "Minería Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Mining, 70.0, 80.0 );

			index = AddCraft( typeof(StandardMusicianshipStudyBook), "Libros de Estudio de Experto", "Música Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Musicianship, 70.0, 80.0 );

			index = AddCraft( typeof(StandardNecromancyStudyBook), "Libros de Estudio de Experto", "Nigromancia Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Necromancy, 70.0, 80.0 );

			index = AddCraft( typeof(StandardNinjitsuStudyBook), "Libros de Estudio de Experto", "Ninjitsu Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Ninjitsu, 70.0, 80.0 );

			index = AddCraft( typeof(StandardParryStudyBook), "Libros de Estudio de Experto", "Parada Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Parry, 70.0, 80.0 );

			index = AddCraft( typeof(StandardPeacemakingStudyBook), "Libros de Estudio de Experto", "Pacificador Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Peacemaking, 70.0, 80.0 );

			index = AddCraft( typeof(StandardPoisoningStudyBook), "Libros de Estudio de Experto", "Envenenamiento Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Poisoning, 70.0, 80.0 );

			index = AddCraft( typeof(StandardProvocationStudyBook), "Libros de Estudio de Experto", "Provocación Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Provocation, 70.0, 80.0 );

			index = AddCraft( typeof(StandardRemoveTrapStudyBook), "Libros de Estudio de Experto", "Remover Trampas Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.RemoveTrap, 70.0, 80.0 );

			index = AddCraft( typeof(StandardSnoopingStudyBook), "Libros de Estudio de Experto", "Fisgoneo Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Snooping, 70.0, 80.0 );

			index = AddCraft( typeof(StandardSpiritSpeakStudyBook), "Libros de Estudio de Experto", "Habla Espiritual Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.SpiritSpeak, 70.0, 80.0 );

			index = AddCraft( typeof(StandardStealingStudyBook), "Libros de Estudio de Experto", "Robo Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Stealing, 70.0, 80.0 );

			index = AddCraft( typeof(StandardStealthStudyBook), "Libros de Estudio de Experto", "Sigilo Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Stealth, 70.0, 80.0 );

			index = AddCraft( typeof(StandardSwordsStudyBook), "Libros de Estudio de Experto", "Esgrima Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Swords, 70.0, 80.0 );

			index = AddCraft( typeof(StandardTacticsStudyBook), "Libros de Estudio de Experto", "Tácticas Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Tactics, 70.0, 80.0 );

			index = AddCraft( typeof(StandardTailoringStudyBook), "Libros de Estudio de Experto", "Sastrería Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Tailoring, 70.0, 80.0 );

			index = AddCraft( typeof(StandardTasteIDStudyBook), "Libros de Estudio de Experto", "Identificación de Sabores Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.TasteID, 70.0, 80.0 );

			index = AddCraft( typeof(StandardThrowingStudyBook), "Libros de Estudio de Experto", "Lanzamiento Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Throwing, 70.0, 80.0 );

			index = AddCraft( typeof(StandardTinkeringStudyBook), "Libros de Estudio de Experto", "Manitas Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Tinkering, 70.0, 80.0 );

			index = AddCraft( typeof(StandardTrackingStudyBook), "Libros de Estudio de Experto", "Rastreo Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Tracking, 70.0, 80.0 );

			index = AddCraft( typeof(StandardVeterinaryStudyBook), "Libros de Estudio de Experto", "Veterinaria Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Veterinary, 70.0, 80.0 );

			index = AddCraft( typeof(StandardWrestlingStudyBook), "Libros de Estudio de Experto", "Lucha Experta", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 1, 1044253 );
			AddRes( index, typeof( Leather ),1044462, 2, 1044253 );
			AddSkill( index, SkillName.Wrestling, 70.0, 80.0 );



			//Grandmaster Study Books
			
			index = AddCraft( typeof(AdvancedAlchemyStudyBook), "Libros de Estudio de Gran Maestro", "Alquimia Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirAlchemy ), "elixir de alquimia", 1, 1044253 );
			AddSkill( index, SkillName.Alchemy, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedAnatomyStudyBook), "Libros de Estudio de Gran Maestro", "Anatomía Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirAnatomy ), "elixir de anatomía", 1, 1044253 );
			AddSkill( index, SkillName.Anatomy, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedAnimalLoreStudyBook), "Libros de Estudio de Gran Maestro", "Conocimiento Animal Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirAnimalLore ), "elixir de conocimiento animal", 1, 1044253 );
			AddSkill( index, SkillName.AnimalLore, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedAnimalTamingStudyBook), "Libros de Estudio de Gran Maestro", "Doma de Animales Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirAnimalTaming ), "elixir de doma de animales", 1, 1044253 );
			AddSkill( index, SkillName.AnimalTaming, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedArcheryStudyBook), "Libros de Estudio de Gran Maestro", "Arquería Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirArchery ), "elixir de arquería", 1, 1044253 );
			AddSkill( index, SkillName.Archery, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedArmsLoreStudyBook), "Libros de Estudio de Gran Maestro", "Conocimiento de Armas Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirArmsLore ), "elixir de conocimiento de armas", 1, 1044253 );
			AddSkill( index, SkillName.ArmsLore, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedBeggingStudyBook), "Libros de Estudio de Gran Maestro", "Mendicidad Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirBegging ), "elixir de mendicidad", 1, 1044253 );
			AddSkill( index, SkillName.Begging, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedBlacksmithStudyBook), "Libros de Estudio de Gran Maestro", "Herrería Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirBlacksmith ), "elixir de herrería", 1, 1044253 );
			AddSkill( index, SkillName.Blacksmith, 100.0, 100.0 );	

			index = AddCraft( typeof(AdvancedBushidoStudyBook), "Libros de Estudio de Gran Maestro", "Bushido Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirParry ), "elixir de parada", 1, 1044253 );
			AddSkill( index, SkillName.Bushido, 100.0, 100.0 );	

			index = AddCraft( typeof(AdvancedCampingStudyBook), "Libros de Estudio de Gran Maestro", "Acampada Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirCamping ), "elixir de acampada", 1, 1044253 );
			AddSkill( index, SkillName.Camping, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedCarpentryStudyBook), "Libros de Estudio de Gran Maestro", "Carpintería Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirCarpentry ), "elixir de carpintería", 1, 1044253 );
			AddSkill( index, SkillName.Carpentry, 100.0, 100.0 );	

			index = AddCraft( typeof(AdvancedCartographyStudyBook), "Libros de Estudio de Gran Maestro", "Cartografía Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirCartography ), "elixir de cartografía", 1, 1044253 );
			AddSkill( index, SkillName.Cartography, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedChivalryStudyBook), "Libros de Estudio de Gran Maestro", "Caballería Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( Diamond ), "diamante", 10, 1044253 );
			AddSkill( index, SkillName.Chivalry, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedCookingStudyBook), "Libros de Estudio de Gran Maestro", "Cocina Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirCooking ), "elixir de cocina", 1, 1044253 );
			AddSkill( index, SkillName.Cooking, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedDetectHiddenStudyBook), "Libros de Estudio de Gran Maestro", "Detección de Ocultos Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirDetectHidden ), "elixir de detección de ocultos", 1, 1044253 );
			AddSkill( index, SkillName.DetectHidden, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedDiscordanceStudyBook), "Libros de Estudio de Gran Maestro", "Discordancia Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirDiscordance ), "elixir de discordancia", 1, 1044253 );
			AddSkill( index, SkillName.Discordance, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedEvalIntStudyBook), "Libros de Estudio de Gran Maestro", "Evaluación de Inteligencia Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirEvalInt ), "elixir de evaluación de inteligencia", 1, 1044253 );
			AddSkill( index, SkillName.EvalInt, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedFencingStudyBook), "Libros de Estudio de Gran Maestro", "Esgrima Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirFencing ), "elixir de esgrima", 1, 1044253 );
			AddSkill( index, SkillName.Fencing, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedFishingStudyBook), "Libros de Estudio de Gran Maestro", "Pesca Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirFishing ), "elixir de pesca", 1, 1044253 );
			AddSkill( index, SkillName.Fishing, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedFocusStudyBook), "Libros de Estudio de Gran Maestro", "Concentración Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirFocus ), "elixir de concentración", 1, 1044253 );
			AddSkill( index, SkillName.Focus, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedForensicsStudyBook), "Libros de Estudio de Gran Maestro", "Evaluación Forense Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirForensics ), "elixir de evaluación forense", 1, 1044253 );
			AddSkill( index, SkillName.Forensics, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedHealingStudyBook), "Libros de Estudio de Gran Maestro", "Curación Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirHealing ), "elixir de curación", 1, 1044253 );
			AddSkill( index, SkillName.Healing, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedHerdingStudyBook), "Libros de Estudio de Gran Maestro", "Pastoreo Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirHerding ), "elixir de pastoreo", 1, 1044253 );
			AddSkill( index, SkillName.Herding, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedHidingStudyBook), "Libros de Estudio de Gran Maestro", "Ocultación Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirHiding ), "elixir de ocultación", 1, 1044253 );
			AddSkill( index, SkillName.Hiding, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedInscribeStudyBook), "Libros de Estudio de Gran Maestro", "Inscripción Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirInscribe ), "elixir de inscripción", 1, 1044253 );
			AddSkill( index, SkillName.Inscribe, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedItemIDStudyBook), "Libros de Estudio de Gran Maestro", "Identificación de Objetos Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirItemID ), "elixir de identificación de objetos", 1, 1044253 );
			AddSkill( index, SkillName.ItemID, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedLockpickingStudyBook), "Libros de Estudio de Gran Maestro", "Ganzuado Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirLockpicking ), "elixir de ganzuado", 1, 1044253 );
			AddSkill( index, SkillName.Lockpicking, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedLumberjackingStudyBook), "Libros de Estudio de Gran Maestro", "Tala de Árboles Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirLumberjacking ), "elixir de tala de árboles", 1, 1044253 );
			AddSkill( index, SkillName.Lumberjacking, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedMacingStudyBook), "Libros de Estudio de Gran Maestro", "Lucha con Maza Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirMacing ), "elixir de lucha con maza", 1, 1044253 );
			AddSkill( index, SkillName.Macing, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedMageryStudyBook), "Libros de Estudio de Gran Maestra", "Magia Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( LiquidFire ), "fuego líquido", 1, 1044253 );
			AddSkill( index, SkillName.Magery, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedMagicResistStudyBook), "Libros de Estudio de Gran Maestra", "Resistencia Mágica Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirMagicResist ), "elixir de resistencia mágica", 1, 1044253 );
			AddSkill( index, SkillName.MagicResist, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedMeditationStudyBook), "Libros de Estudio de Gran Maestra", "Meditación Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirMeditation ), "elixir de meditación", 1, 1044253 );
			AddSkill( index, SkillName.Meditation, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedMiningStudyBook), "Libros de Estudio de Gran Maestra", "Minería Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirMining ), "elixir de minería", 1, 1044253 );
			AddSkill( index, SkillName.Mining, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedMusicianshipStudyBook), "Libros de Estudio de Gran Maestra", "Música Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirMusicianship ), "elixir de música", 1, 1044253 );
			AddSkill( index, SkillName.Musicianship, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedNecromancyStudyBook), "Libros de Estudio de Gran Maestra", "Nigromancia Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirSpiritSpeak ), "elixir de habla espiritual", 1, 1044253 );
			AddSkill( index, SkillName.Necromancy, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedNinjitsuStudyBook), "Libros de Estudio de Gran Maestra", "Ninjitsu Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirStealth ), "elixir de sigilo", 1, 1044253 );
			AddSkill( index, SkillName.Ninjitsu, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedParryStudyBook), "Libros de Estudio de Gran Maestra", "Parada Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirParry ), "elixir de parada", 1, 1044253 );
			AddSkill( index, SkillName.Parry, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedPeacemakingStudyBook), "Libros de Estudio de Gran Maestro", "Pacificador Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirPeacemaking ), "elixir de pacificador", 1, 1044253 );
			AddSkill( index, SkillName.Peacemaking, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedPoisoningStudyBook), "Libros de Estudio de Gran Maestro", "Envenenamiento Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirPoisoning ), "elixir de envenenamiento", 1, 1044253 );
			AddSkill( index, SkillName.Poisoning, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedProvocationStudyBook), "Libros de Estudio de Gran Maestro", "Provocación Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirProvocation ), "elixir de provocación", 1, 1044253 );
			AddSkill( index, SkillName.Provocation, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedRemoveTrapStudyBook), "Libros de Estudio de Gran Maestro", "Remover Trampas Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirRemoveTrap ), "elixir de remover trampas", 1, 1044253 );
			AddSkill( index, SkillName.RemoveTrap, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedSnoopingStudyBook), "Libros de Estudio de Gran Maestro", "Fisgoneo Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirSnooping ), "elixir de fisgoneo", 1, 1044253 );
			AddSkill( index, SkillName.Snooping, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedSpiritSpeakStudyBook), "Libros de Estudio de Gran Maestra", "Habla Espiritual Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirSpiritSpeak ), "elixir de habla espiritual", 1, 1044253 );
			AddSkill( index, SkillName.SpiritSpeak, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedStealingStudyBook), "Libros de Estudio de Gran Maestra", "Robo Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirStealing ), "elixir de robo", 1, 1044253 );
			AddSkill( index, SkillName.Stealing, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedStealthStudyBook), "Libros de Estudio de Gran Maestra", "Sigilo Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirStealth ), "elixir de sigilo", 1, 1044253 );
			AddSkill( index, SkillName.Stealth, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedSwordsStudyBook), "Libros de Estudio de Gran Maestra", "Esgrima Gran Maestra", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirSwords ), "elixir de esgrima", 1, 1044253 );
			AddSkill( index, SkillName.Swords, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedTacticsStudyBook), "Libros de Estudio de Gran Maestro", "Tácticas Gran Maestro", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirTactics ), "elixir de tácticas", 1, 1044253 );
			AddSkill( index, SkillName.Tactics, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedTailoringStudyBook), "Libros de Estudio de Gran Maestro", "Sastrería Gran Maestro", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirTailoring ), "elixir de sastrería", 1, 1044253 );
			AddSkill( index, SkillName.Tailoring, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedTasteIDStudyBook), "Libros de Estudio de Gran Maestro", "Identificación de Sabores Gran Maestro", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirTasteID ), "elixir de identificación de sabores", 1, 1044253 );
			AddSkill( index, SkillName.TasteID, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedThrowingStudyBook), "Libros de Estudio de Gran Maestro", "Lanzamiento Gran Maestro", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirArchery ), "elixir de arquería", 1, 1044253 );
			AddSkill( index, SkillName.Throwing, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedTinkeringStudyBook), "Libros de Estudio de Gran Maestro", "Manitas Gran Maestro", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirTinkering ), "elixir de manitas", 1, 1044253 );
			AddSkill( index, SkillName.Tinkering, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedTrackingStudyBook), "Libros de Estudio de Gran Maestro", "Rastreo Gran Maestro", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirTracking ), "elixir de rastreo", 1, 1044253 );
			AddSkill( index, SkillName.Tracking, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedVeterinaryStudyBook), "Libros de Estudio de Gran Maestro", "Veterinaria Gran Maestro", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirVeterinary ), "elixir de veterinaria", 1, 1044253 );
			AddSkill( index, SkillName.Veterinary, 100.0, 100.0 );

			index = AddCraft( typeof(AdvancedWrestlingStudyBook), "Libros de Estudio de Gran Maestro", "Lucha Gran Maestro", 65.0, 85.0, typeof(BlankScroll), 1044377, 10, 1044378);
			AddRes( index, typeof( Beeswax ), 1025154, 3, 1044253 );
			AddRes( index, typeof( ArcaneGem ),"gema arcana", 2, 1044253 );
			AddRes( index, typeof( ElixirWrestling ), "elixir de lucha", 1, 1044253 );
			AddSkill( index, SkillName.Wrestling, 100.0, 100.0 );


			//Legendary Study Books
			// index = AddCraft( typeof(AdvancedAlchemyStudyBook), "Legendary Study Books", "Legendary Alchemy", 120.0, 120.0, typeof(BlankScroll), 1044377, 10, 1044378);
			// AddRes( index, typeof( Beeswax ), 1025154, 5, 1044253 );
			// AddRes( index, typeof( ArcaneGem ), "arcane gem", 5, 1044253 );
			// AddRes( index, typeof( ElixirAlchemy ), "alchemy elixir", 1, 1044253 );
			// AddSkill( index, SkillName.Alchemy, 120.0, 120.0 );
			// SetManaReq(index, 150);		



		}
	}
}