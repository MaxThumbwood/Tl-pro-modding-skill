using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Utilities
{
	// Token: 0x020005D5 RID: 1493
	[Token(Token = "0x20005D5")]
	public static class NPCUtils
	{
		// Token: 0x06003BE4 RID: 15332 RVA: 0x0001E390 File Offset: 0x0001C590
		[Token(Token = "0x6003BE4")]
		[Address(RVA = "0x1E16644", Offset = "0x1E16644", VA = "0x1E16644")]
		public static NPCUtils.TargetSearchResults SearchForTarget(Vector2 position, NPCUtils.TargetSearchFlag flags = NPCUtils.TargetSearchFlag.All, [Optional] NPCUtils.SearchFilter<Player> playerFilter, [Optional] NPCUtils.SearchFilter<NPC> npcFilter)
		{
			return default(NPCUtils.TargetSearchResults);
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
		[Token(Token = "0x6003BE5")]
		[Address(RVA = "0x1E16BC4", Offset = "0x1E16BC4", VA = "0x1E16BC4")]
		public static NPCUtils.TargetSearchResults SearchForTarget(NPC searcher, NPCUtils.TargetSearchFlag flags = NPCUtils.TargetSearchFlag.All, [Optional] NPCUtils.SearchFilter<Player> playerFilter, [Optional] NPCUtils.SearchFilter<NPC> npcFilter)
		{
			return default(NPCUtils.TargetSearchResults);
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		[Token(Token = "0x6003BE6")]
		[Address(RVA = "0x1E16698", Offset = "0x1E16698", VA = "0x1E16698")]
		public static NPCUtils.TargetSearchResults SearchForTarget(NPC searcher, Vector2 position, NPCUtils.TargetSearchFlag flags = NPCUtils.TargetSearchFlag.All, [Optional] NPCUtils.SearchFilter<Player> playerFilter, [Optional] NPCUtils.SearchFilter<NPC> npcFilter)
		{
			return default(NPCUtils.TargetSearchResults);
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE7")]
		[Address(RVA = "0x1E16C34", Offset = "0x1E16C34", VA = "0x1E16C34")]
		public static void TargetClosestOldOnesInvasion(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE8")]
		[Address(RVA = "0x1E16F54", Offset = "0x1E16F54", VA = "0x1E16F54")]
		public static void TargetClosestNonBees(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x1E1712C", Offset = "0x1E1712C", VA = "0x1E1712C")]
		public static void TargetClosestDownwindFromNPC(NPC searcher, float distanceMaxX, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BEA")]
		[Address(RVA = "0x1E17390", Offset = "0x1E17390", VA = "0x1E17390")]
		public static void TargetClosestCommon(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BEB")]
		[Address(RVA = "0x1E173BC", Offset = "0x1E173BC", VA = "0x1E173BC")]
		public static void TargetClosestBetsy(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
		}

		// Token: 0x020005D6 RID: 1494
		// (Invoke) Token: 0x06003BED RID: 15341
		[Token(Token = "0x20005D6")]
		public delegate bool SearchFilter<T>(T entity) where T : Entity;

		// Token: 0x020005D7 RID: 1495
		// (Invoke) Token: 0x06003BF1 RID: 15345
		[Token(Token = "0x20005D7")]
		public delegate void NPCTargetingMethod(NPC searcher, bool faceTarget, Vector2? checkPosition);

		// Token: 0x020005D8 RID: 1496
		[Token(Token = "0x20005D8")]
		public static class SearchFilters
		{
			// Token: 0x06003BF4 RID: 15348 RVA: 0x0001E3D8 File Offset: 0x0001C5D8
			[Token(Token = "0x6003BF4")]
			[Address(RVA = "0x1E17878", Offset = "0x1E17878", VA = "0x1E17878")]
			public static bool OnlyCrystal(NPC npc)
			{
				return default(bool);
			}

			// Token: 0x06003BF5 RID: 15349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BF5")]
			[Address(RVA = "0x1E16E38", Offset = "0x1E16E38", VA = "0x1E16E38")]
			public static NPCUtils.SearchFilter<Player> OnlyPlayersInCertainDistance(Vector2 position, float maxDistance)
			{
				return null;
			}

			// Token: 0x06003BF6 RID: 15350 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
			[Token(Token = "0x6003BF6")]
			[Address(RVA = "0x1E178B0", Offset = "0x1E178B0", VA = "0x1E178B0")]
			public static bool NonBeeNPCs(NPC npc)
			{
				return default(bool);
			}

			// Token: 0x06003BF7 RID: 15351 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BF7")]
			[Address(RVA = "0x1E17284", Offset = "0x1E17284", VA = "0x1E17284")]
			public static NPCUtils.SearchFilter<Player> DownwindFromNPC(NPC npc, float maxDistanceX)
			{
				return null;
			}

			// Token: 0x020005D9 RID: 1497
			[Token(Token = "0x20005D9")]
			private sealed class <>c__DisplayClass1_0
			{
				// Token: 0x06003BF8 RID: 15352 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003BF8")]
				[Address(RVA = "0x1E178A8", Offset = "0x1E178A8", VA = "0x1E178A8")]
				public <>c__DisplayClass1_0()
				{
				}

				// Token: 0x06003BF9 RID: 15353 RVA: 0x0001E408 File Offset: 0x0001C608
				[Token(Token = "0x6003BF9")]
				[Address(RVA = "0x1E17968", Offset = "0x1E17968", VA = "0x1E17968")]
				internal bool <OnlyPlayersInCertainDistance>b__0(Player player)
				{
					return default(bool);
				}

				// Token: 0x04004767 RID: 18279
				[Token(Token = "0x4004767")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public Vector2 position;

				// Token: 0x04004768 RID: 18280
				[Token(Token = "0x4004768")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public float maxDistance;
			}

			// Token: 0x020005DA RID: 1498
			[Token(Token = "0x20005DA")]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x06003BFA RID: 15354 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003BFA")]
				[Address(RVA = "0x1E17960", Offset = "0x1E17960", VA = "0x1E17960")]
				public <>c__DisplayClass3_0()
				{
				}

				// Token: 0x06003BFB RID: 15355 RVA: 0x0001E420 File Offset: 0x0001C620
				[Token(Token = "0x6003BFB")]
				[Address(RVA = "0x1E179BC", Offset = "0x1E179BC", VA = "0x1E179BC")]
				internal bool <DownwindFromNPC>b__0(Player player)
				{
					return default(bool);
				}

				// Token: 0x04004769 RID: 18281
				[Token(Token = "0x4004769")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public NPC npc;

				// Token: 0x0400476A RID: 18282
				[Token(Token = "0x400476A")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float maxDistanceX;
			}
		}

		// Token: 0x020005DB RID: 1499
		[Token(Token = "0x20005DB")]
		public enum TargetType
		{
			// Token: 0x0400476C RID: 18284
			[Token(Token = "0x400476C")]
			None,
			// Token: 0x0400476D RID: 18285
			[Token(Token = "0x400476D")]
			NPC,
			// Token: 0x0400476E RID: 18286
			[Token(Token = "0x400476E")]
			Player,
			// Token: 0x0400476F RID: 18287
			[Token(Token = "0x400476F")]
			TankPet
		}

		// Token: 0x020005DC RID: 1500
		[Token(Token = "0x20005DC")]
		public struct TargetSearchResults
		{
			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x06003BFC RID: 15356 RVA: 0x0001E438 File Offset: 0x0001C638
			[Token(Token = "0x17000790")]
			public int NearestTargetIndex
			{
				[Token(Token = "0x6003BFC")]
				[Address(RVA = "0x1E54E60", Offset = "0x1E54E60", VA = "0x1E54E60")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x06003BFD RID: 15357 RVA: 0x0001E450 File Offset: 0x0001C650
			[Token(Token = "0x17000791")]
			public Rectangle NearestTargetHitbox
			{
				[Token(Token = "0x6003BFD")]
				[Address(RVA = "0x1E54FB8", Offset = "0x1E54FB8", VA = "0x1E54FB8")]
				get
				{
					return default(Rectangle);
				}
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x06003BFE RID: 15358 RVA: 0x0001E468 File Offset: 0x0001C668
			[Token(Token = "0x17000792")]
			public NPCUtils.TargetType NearestTargetType
			{
				[Token(Token = "0x6003BFE")]
				[Address(RVA = "0x1E55328", Offset = "0x1E55328", VA = "0x1E55328")]
				get
				{
					return NPCUtils.TargetType.None;
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x06003BFF RID: 15359 RVA: 0x0001E480 File Offset: 0x0001C680
			[Token(Token = "0x17000793")]
			public bool FoundTarget
			{
				[Token(Token = "0x6003BFF")]
				[Address(RVA = "0x1E55330", Offset = "0x1E55330", VA = "0x1E55330")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x06003C00 RID: 15360 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000794")]
			public NPC NearestNPC
			{
				[Token(Token = "0x6003C00")]
				[Address(RVA = "0x1E54F24", Offset = "0x1E54F24", VA = "0x1E54F24")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x06003C01 RID: 15361 RVA: 0x0001E498 File Offset: 0x0001C698
			[Token(Token = "0x17000795")]
			public bool FoundNPC
			{
				[Token(Token = "0x6003C01")]
				[Address(RVA = "0x1E55340", Offset = "0x1E55340", VA = "0x1E55340")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x06003C02 RID: 15362 RVA: 0x0001E4B0 File Offset: 0x0001C6B0
			[Token(Token = "0x17000796")]
			public int NearestNPCIndex
			{
				[Token(Token = "0x6003C02")]
				[Address(RVA = "0x1E55354", Offset = "0x1E55354", VA = "0x1E55354")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x06003C03 RID: 15363 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
			[Token(Token = "0x17000797")]
			public float NearestNPCDistance
			{
				[Token(Token = "0x6003C03")]
				[Address(RVA = "0x1E5535C", Offset = "0x1E5535C", VA = "0x1E5535C")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06003C04 RID: 15364 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000798")]
			public Player NearestTankOwner
			{
				[Token(Token = "0x6003C04")]
				[Address(RVA = "0x1E55294", Offset = "0x1E55294", VA = "0x1E55294")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06003C05 RID: 15365 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
			[Token(Token = "0x17000799")]
			public bool FoundTank
			{
				[Token(Token = "0x6003C05")]
				[Address(RVA = "0x1E55364", Offset = "0x1E55364", VA = "0x1E55364")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x06003C06 RID: 15366 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
			[Token(Token = "0x1700079A")]
			public int NearestTankOwnerIndex
			{
				[Token(Token = "0x6003C06")]
				[Address(RVA = "0x1E55378", Offset = "0x1E55378", VA = "0x1E55378")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x06003C07 RID: 15367 RVA: 0x0001E510 File Offset: 0x0001C710
			[Token(Token = "0x1700079B")]
			public float NearestTankDistance
			{
				[Token(Token = "0x6003C07")]
				[Address(RVA = "0x1E55380", Offset = "0x1E55380", VA = "0x1E55380")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x06003C08 RID: 15368 RVA: 0x0001E528 File Offset: 0x0001C728
			[Token(Token = "0x1700079C")]
			public float AdjustedTankDistance
			{
				[Token(Token = "0x6003C08")]
				[Address(RVA = "0x1E55388", Offset = "0x1E55388", VA = "0x1E55388")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x06003C09 RID: 15369 RVA: 0x0001E540 File Offset: 0x0001C740
			[Token(Token = "0x1700079D")]
			public NPCUtils.TargetType NearestTankType
			{
				[Token(Token = "0x6003C09")]
				[Address(RVA = "0x1E55390", Offset = "0x1E55390", VA = "0x1E55390")]
				get
				{
					return NPCUtils.TargetType.None;
				}
			}

			// Token: 0x06003C0A RID: 15370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C0A")]
			[Address(RVA = "0x1E55398", Offset = "0x1E55398", VA = "0x1E55398")]
			public TargetSearchResults(NPC searcher, int nearestNPCIndex, float nearestNPCDistance, int nearestTankIndex, float nearestTankDistance, float adjustedTankDistance, NPCUtils.TargetType tankType)
			{
			}

			// Token: 0x04004770 RID: 18288
			[Token(Token = "0x4004770")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NPCUtils.TargetType _nearestTargetType;

			// Token: 0x04004771 RID: 18289
			[Token(Token = "0x4004771")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private int _nearestNPCIndex;

			// Token: 0x04004772 RID: 18290
			[Token(Token = "0x4004772")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private float _nearestNPCDistance;

			// Token: 0x04004773 RID: 18291
			[Token(Token = "0x4004773")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int _nearestTankIndex;

			// Token: 0x04004774 RID: 18292
			[Token(Token = "0x4004774")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private float _nearestTankDistance;

			// Token: 0x04004775 RID: 18293
			[Token(Token = "0x4004775")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float _adjustedTankDistance;

			// Token: 0x04004776 RID: 18294
			[Token(Token = "0x4004776")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private NPCUtils.TargetType _nearestTankType;
		}

		// Token: 0x020005DD RID: 1501
		[Token(Token = "0x20005DD")]
		public enum TargetSearchFlag
		{
			// Token: 0x04004778 RID: 18296
			[Token(Token = "0x4004778")]
			None,
			// Token: 0x04004779 RID: 18297
			[Token(Token = "0x4004779")]
			NPCs,
			// Token: 0x0400477A RID: 18298
			[Token(Token = "0x400477A")]
			Players,
			// Token: 0x0400477B RID: 18299
			[Token(Token = "0x400477B")]
			All
		}
	}
}
