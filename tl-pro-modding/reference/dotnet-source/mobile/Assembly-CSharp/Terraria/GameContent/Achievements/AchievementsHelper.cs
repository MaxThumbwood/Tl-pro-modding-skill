using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000C56 RID: 3158
	[Token(Token = "0x2000C56")]
	public class AchievementsHelper
	{
		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06005DC7 RID: 24007 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005DC8 RID: 24008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000058")]
		public static event AchievementsHelper.ItemPickupEvent OnItemPickup
		{
			[Token(Token = "0x6005DC7")]
			[Address(RVA = "0x9B18E0", Offset = "0x9B18E0", VA = "0x9B18E0")]
			add
			{
			}
			[Token(Token = "0x6005DC8")]
			[Address(RVA = "0x9B19AC", Offset = "0x9B19AC", VA = "0x9B19AC")]
			remove
			{
			}
		}

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06005DC9 RID: 24009 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005DCA RID: 24010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000059")]
		public static event AchievementsHelper.ItemCraftEvent OnItemCraft
		{
			[Token(Token = "0x6005DC9")]
			[Address(RVA = "0x9B1A78", Offset = "0x9B1A78", VA = "0x9B1A78")]
			add
			{
			}
			[Token(Token = "0x6005DCA")]
			[Address(RVA = "0x9B1B50", Offset = "0x9B1B50", VA = "0x9B1B50")]
			remove
			{
			}
		}

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06005DCB RID: 24011 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005DCC RID: 24012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005A")]
		public static event AchievementsHelper.TileDestroyedEvent OnTileDestroyed
		{
			[Token(Token = "0x6005DCB")]
			[Address(RVA = "0x9B1C28", Offset = "0x9B1C28", VA = "0x9B1C28")]
			add
			{
			}
			[Token(Token = "0x6005DCC")]
			[Address(RVA = "0x9B1D00", Offset = "0x9B1D00", VA = "0x9B1D00")]
			remove
			{
			}
		}

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06005DCD RID: 24013 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005DCE RID: 24014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005B")]
		public static event AchievementsHelper.NPCKilledEvent OnNPCKilled
		{
			[Token(Token = "0x6005DCD")]
			[Address(RVA = "0x9B1DD8", Offset = "0x9B1DD8", VA = "0x9B1DD8")]
			add
			{
			}
			[Token(Token = "0x6005DCE")]
			[Address(RVA = "0x9B1EB0", Offset = "0x9B1EB0", VA = "0x9B1EB0")]
			remove
			{
			}
		}

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06005DCF RID: 24015 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005DD0 RID: 24016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005C")]
		public static event AchievementsHelper.ProgressionEventEvent OnProgressionEvent
		{
			[Token(Token = "0x6005DCF")]
			[Address(RVA = "0x9B1F88", Offset = "0x9B1F88", VA = "0x9B1F88")]
			add
			{
			}
			[Token(Token = "0x6005DD0")]
			[Address(RVA = "0x9B2060", Offset = "0x9B2060", VA = "0x9B2060")]
			remove
			{
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06005DD1 RID: 24017 RVA: 0x0002BB60 File Offset: 0x00029D60
		// (set) Token: 0x06005DD2 RID: 24018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6C")]
		public static bool CurrentlyMining
		{
			[Token(Token = "0x6005DD1")]
			[Address(RVA = "0x9B2138", Offset = "0x9B2138", VA = "0x9B2138")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DD2")]
			[Address(RVA = "0x9B2188", Offset = "0x9B2188", VA = "0x9B2188")]
			set
			{
			}
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD3")]
		[Address(RVA = "0x9B21DC", Offset = "0x9B21DC", VA = "0x9B21DC")]
		public static void NotifyTileDestroyed(Player player, ushort tile)
		{
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD4")]
		[Address(RVA = "0x9B22A0", Offset = "0x9B22A0", VA = "0x9B22A0")]
		public static void NotifyItemPickup(Player player, Item item)
		{
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD5")]
		[Address(RVA = "0x9B23E4", Offset = "0x9B23E4", VA = "0x9B23E4")]
		public static void NotifyItemPickup(Player player, Item item, int customStack)
		{
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD6")]
		[Address(RVA = "0x9B2518", Offset = "0x9B2518", VA = "0x9B2518")]
		public static void NotifyItemCraft(Recipe recipe)
		{
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0x99CE44", Offset = "0x99CE44", VA = "0x99CE44")]
		public static void TryGrantingBestiary100PercentAchievement()
		{
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0x9B2DEC", Offset = "0x9B2DEC", VA = "0x9B2DEC")]
		public static void Initialize()
		{
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0x9B2E84", Offset = "0x9B2E84", VA = "0x9B2E84")]
		internal static void OnPlayerEnteredWorld(Player player)
		{
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDA")]
		[Address(RVA = "0x9B42C8", Offset = "0x9B42C8", VA = "0x9B42C8")]
		public static void NotifyNPCKilled(NPC npc)
		{
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDB")]
		[Address(RVA = "0x9B44AC", Offset = "0x9B44AC", VA = "0x9B44AC")]
		public static void NotifyNPCKilledDirect(Player player, int npcNetID)
		{
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDC")]
		[Address(RVA = "0x9B2AF0", Offset = "0x9B2AF0", VA = "0x9B2AF0")]
		public static void NotifyProgressionEvent(int eventID)
		{
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDD")]
		[Address(RVA = "0x9B460C", Offset = "0x9B460C", VA = "0x9B460C")]
		public static void HandleOnEquip(Player player, Item item, int context)
		{
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDE")]
		[Address(RVA = "0x9B4D60", Offset = "0x9B4D60", VA = "0x9B4D60")]
		public static void HandleSpecialEvent(Player player, int eventID)
		{
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDF")]
		[Address(RVA = "0x9B5B78", Offset = "0x9B5B78", VA = "0x9B5B78")]
		public static void DoClassicTitleScreenAchievement()
		{
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE0")]
		[Address(RVA = "0x9B5C58", Offset = "0x9B5C58", VA = "0x9B5C58")]
		public static void CheckResearchAchievement(bool forced = false)
		{
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE1")]
		[Address(RVA = "0x9B5D90", Offset = "0x9B5D90", VA = "0x9B5D90")]
		public static void PlantedAcorn()
		{
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE2")]
		[Address(RVA = "0x9B5ED0", Offset = "0x9B5ED0", VA = "0x9B5ED0")]
		public static void HandleNurseService(int coinsSpent)
		{
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE3")]
		[Address(RVA = "0x9B6054", Offset = "0x9B6054", VA = "0x9B6054")]
		public static void HandleAnglerService()
		{
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE4")]
		[Address(RVA = "0x9B6438", Offset = "0x9B6438", VA = "0x9B6438")]
		public static void HandleRunning(Player player, float pixelsMoved)
		{
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE5")]
		[Address(RVA = "0x9B66EC", Offset = "0x9B66EC", VA = "0x9B66EC")]
		public static void HandleMining()
		{
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE6")]
		[Address(RVA = "0x9B6850", Offset = "0x9B6850", VA = "0x9B6850")]
		public static void MechaMayhem_Clear()
		{
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE7")]
		[Address(RVA = "0x9B6A14", Offset = "0x9B6A14", VA = "0x9B6A14")]
		public static void MechaMayhem_Start()
		{
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE8")]
		[Address(RVA = "0x9B6AA0", Offset = "0x9B6AA0", VA = "0x9B6AA0")]
		public static void MechaMayhem_Kill(int justKilled)
		{
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE9")]
		[Address(RVA = "0x9B68EC", Offset = "0x9B68EC", VA = "0x9B68EC")]
		private static void ScanForMechs(out bool foundSkeletronPrime, out bool foundDestroyer, out bool foundTwins)
		{
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x0002BB78 File Offset: 0x00029D78
		[Token(Token = "0x6005DEA")]
		[Address(RVA = "0x9B29F0", Offset = "0x9B29F0", VA = "0x9B29F0")]
		private static bool IsMetalBar(int itemType)
		{
			return default(bool);
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEB")]
		[Address(RVA = "0x9B6CD8", Offset = "0x9B6CD8", VA = "0x9B6CD8")]
		public AchievementsHelper()
		{
		}

		// Token: 0x04009DBE RID: 40382
		[Token(Token = "0x4009DBE")]
		[FieldOffset(Offset = "0x14")]
		private static bool _isMining;

		// Token: 0x04009DBF RID: 40383
		[Token(Token = "0x4009DBF")]
		[FieldOffset(Offset = "0x18")]
		private static int _lastResearchVersion;

		// Token: 0x04009DC0 RID: 40384
		[Token(Token = "0x4009DC0")]
		[FieldOffset(Offset = "0x1C")]
		private static bool mayhemOK;

		// Token: 0x04009DC1 RID: 40385
		[Token(Token = "0x4009DC1")]
		[FieldOffset(Offset = "0x1D")]
		private static bool mayhem1down;

		// Token: 0x04009DC2 RID: 40386
		[Token(Token = "0x4009DC2")]
		[FieldOffset(Offset = "0x1E")]
		private static bool mayhem2down;

		// Token: 0x04009DC3 RID: 40387
		[Token(Token = "0x4009DC3")]
		[FieldOffset(Offset = "0x1F")]
		private static bool mayhem3down;

		// Token: 0x02000C57 RID: 3159
		// (Invoke) Token: 0x06005DED RID: 24045
		[Token(Token = "0x2000C57")]
		public delegate void ItemPickupEvent(Player player, short itemId, int count);

		// Token: 0x02000C58 RID: 3160
		// (Invoke) Token: 0x06005DF1 RID: 24049
		[Token(Token = "0x2000C58")]
		public delegate void ItemCraftEvent(Player player, short itemId, int count);

		// Token: 0x02000C59 RID: 3161
		// (Invoke) Token: 0x06005DF5 RID: 24053
		[Token(Token = "0x2000C59")]
		public delegate void TileDestroyedEvent(Player player, ushort tileId);

		// Token: 0x02000C5A RID: 3162
		// (Invoke) Token: 0x06005DF9 RID: 24057
		[Token(Token = "0x2000C5A")]
		public delegate void NPCKilledEvent(Player player, short npcId);

		// Token: 0x02000C5B RID: 3163
		// (Invoke) Token: 0x06005DFD RID: 24061
		[Token(Token = "0x2000C5B")]
		public delegate void ProgressionEventEvent(int eventID);
	}
}
