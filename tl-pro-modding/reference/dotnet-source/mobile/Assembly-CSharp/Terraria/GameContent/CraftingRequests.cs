using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria.GameContent
{
	// Token: 0x02000955 RID: 2389
	[Token(Token = "0x2000955")]
	public static class CraftingRequests
	{
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06004F91 RID: 20369 RVA: 0x00025050 File Offset: 0x00023250
		[Token(Token = "0x17000988")]
		public static bool HasPendingRequests
		{
			[Token(Token = "0x6004F91")]
			[Address(RVA = "0x74FA4C", Offset = "0x74FA4C", VA = "0x74FA4C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F92")]
		[Address(RVA = "0x74FADC", Offset = "0x74FADC", VA = "0x74FADC")]
		public static void Clear()
		{
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F93")]
		[Address(RVA = "0x74FB74", Offset = "0x74FB74", VA = "0x74FB74")]
		public static void CraftItem(Recipe recipe, int qty = 1, bool quickCraft = false)
		{
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F94")]
		[Address(RVA = "0x7507E4", Offset = "0x7507E4", VA = "0x7507E4")]
		private static Item CreateResult(Recipe recipe)
		{
			return null;
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F95")]
		[Address(RVA = "0x7500C8", Offset = "0x7500C8", VA = "0x7500C8")]
		private static void CraftLocally(Recipe recipe, bool quickCraft, List<DestinationInventory> sources, List<Recipe.RequiredItemEntry> ingredients)
		{
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F96")]
		[Address(RVA = "0x75032C", Offset = "0x75032C", VA = "0x75032C")]
		private static void CraftViaRequest(Recipe recipe, bool quickCraft, List<DestinationInventory> sources, List<Recipe.RequiredItemEntry> ingredients)
		{
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x00025068 File Offset: 0x00023268
		[Token(Token = "0x6004F97")]
		[Address(RVA = "0x751254", Offset = "0x751254", VA = "0x751254")]
		private static bool IsLocallyAccessible(Chest chest)
		{
			return default(bool);
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x00025080 File Offset: 0x00023280
		[Token(Token = "0x6004F98")]
		[Address(RVA = "0x7512F8", Offset = "0x7512F8", VA = "0x7512F8")]
		private static bool CanCraftLocally(Recipe.RequiredItemEntry req, List<DestinationInventory> sources)
		{
			return default(bool);
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x00025098 File Offset: 0x00023298
		[Token(Token = "0x6004F99")]
		[Address(RVA = "0x7516E0", Offset = "0x7516E0", VA = "0x7516E0")]
		private static int CountMatches(Recipe.RequiredItemEntry req, List<Chest> chests)
		{
			return 0;
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x000250B0 File Offset: 0x000232B0
		[Token(Token = "0x6004F9A")]
		[Address(RVA = "0x75192C", Offset = "0x75192C", VA = "0x75192C")]
		private static int CountMatches(Recipe.RequiredItemEntry req, ChestItem[] inv, int maxItems)
		{
			return 0;
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x000250C8 File Offset: 0x000232C8
		[Token(Token = "0x6004F9B")]
		[Address(RVA = "0x751654", Offset = "0x751654", VA = "0x751654")]
		private static int CountMatches(Recipe.RequiredItemEntry req, Item[] inv, int maxItems)
		{
			return 0;
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x000250E0 File Offset: 0x000232E0
		[Token(Token = "0x6004F9C")]
		[Address(RVA = "0x7508D4", Offset = "0x7508D4", VA = "0x7508D4")]
		private static int Consume(Recipe.RequiredItemEntry req, List<DestinationInventory> sources, List<Item> consumedItems, bool fromChests)
		{
			return 0;
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x000250F8 File Offset: 0x000232F8
		[Token(Token = "0x6004F9D")]
		[Address(RVA = "0x751E60", Offset = "0x751E60", VA = "0x751E60")]
		private static int Consume(Recipe.RequiredItemEntry req, List<Chest> sources)
		{
			return 0;
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9E")]
		[Address(RVA = "0x7519A4", Offset = "0x7519A4", VA = "0x7519A4")]
		private static void ConsumeItemsFrom(Item[] inventory, int maxItems, Recipe.RequiredItemEntry req, ref int toConsume, [Optional] List<Item> consumedItems, int chestIndex = -1)
		{
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9F")]
		[Address(RVA = "0x751CF0", Offset = "0x751CF0", VA = "0x751CF0")]
		private static void ConsumeItemsFrom(ChestItem[] inventory, int maxItems, Recipe.RequiredItemEntry req, ref int toConsume, int chestIndex)
		{
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x00025110 File Offset: 0x00023310
		[Token(Token = "0x6004FA0")]
		[Address(RVA = "0x752078", Offset = "0x752078", VA = "0x752078")]
		public static bool CanCraftFromChest(Chest chest, int whoAmI)
		{
			return default(bool);
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA1")]
		[Address(RVA = "0x75215C", Offset = "0x75215C", VA = "0x75215C")]
		private static void HandleRequest(int whoAmI, List<Recipe.RequiredItemEntry> items, List<Chest> chests)
		{
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA2")]
		[Address(RVA = "0x7527FC", Offset = "0x7527FC", VA = "0x7527FC")]
		private static void HandleResponse(bool approved)
		{
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA3")]
		[Address(RVA = "0x752CC8", Offset = "0x752CC8", VA = "0x752CC8")]
		public static void Refund(Item item)
		{
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA4")]
		[Address(RVA = "0x752DA8", Offset = "0x752DA8", VA = "0x752DA8")]
		public static void SubtractPendingRequests()
		{
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA5")]
		[Address(RVA = "0x753140", Offset = "0x753140", VA = "0x753140")]
		public static void SavePossibleRefunds(BinaryWriter writer)
		{
		}

		// Token: 0x040093A2 RID: 37794
		[Token(Token = "0x40093A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Queue<CraftingRequests.RemoteCraftRequest> _pendingCrafts;

		// Token: 0x02000956 RID: 2390
		[Token(Token = "0x2000956")]
		public struct RemoteCraftRequest
		{
			// Token: 0x040093A3 RID: 37795
			[Token(Token = "0x40093A3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Recipe recipe;

			// Token: 0x040093A4 RID: 37796
			[Token(Token = "0x40093A4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Item result;

			// Token: 0x040093A5 RID: 37797
			[Token(Token = "0x40093A5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<Item> consumed;

			// Token: 0x040093A6 RID: 37798
			[Token(Token = "0x40093A6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public List<Recipe.RequiredItemEntry> requested;

			// Token: 0x040093A7 RID: 37799
			[Token(Token = "0x40093A7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool quickCraft;
		}

		// Token: 0x02000957 RID: 2391
		[Token(Token = "0x2000957")]
		public class NetCraftingRequestsModule : NetModule
		{
			// Token: 0x06004FA7 RID: 20391 RVA: 0x00025128 File Offset: 0x00023328
			[Token(Token = "0x6004FA7")]
			[Address(RVA = "0x750D5C", Offset = "0x750D5C", VA = "0x750D5C")]
			public static NetPacket WriteRequest(List<Recipe.RequiredItemEntry> items, List<DestinationInventory> sources)
			{
				return default(NetPacket);
			}

			// Token: 0x06004FA8 RID: 20392 RVA: 0x00025140 File Offset: 0x00023340
			[Token(Token = "0x6004FA8")]
			[Address(RVA = "0x752734", Offset = "0x752734", VA = "0x752734")]
			public static NetPacket WriteResponse(bool approved)
			{
				return default(NetPacket);
			}

			// Token: 0x06004FA9 RID: 20393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FA9")]
			[Address(RVA = "0x7536A4", Offset = "0x7536A4", VA = "0x7536A4")]
			public void DeserializeRequest(BinaryReader reader, int userId)
			{
			}

			// Token: 0x06004FAA RID: 20394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FAA")]
			[Address(RVA = "0x753AAC", Offset = "0x753AAC", VA = "0x753AAC")]
			public void DeserializeResponse(BinaryReader reader)
			{
			}

			// Token: 0x06004FAB RID: 20395 RVA: 0x00025158 File Offset: 0x00023358
			[Token(Token = "0x6004FAB")]
			[Address(RVA = "0x753B34", Offset = "0x753B34", VA = "0x753B34", Slot = "4")]
			public override bool Deserialize(BinaryReader reader, int userId)
			{
				return default(bool);
			}

			// Token: 0x06004FAC RID: 20396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FAC")]
			[Address(RVA = "0x753C38", Offset = "0x753C38", VA = "0x753C38")]
			public NetCraftingRequestsModule()
			{
			}
		}

		// Token: 0x02000958 RID: 2392
		[Token(Token = "0x2000958")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004FAD RID: 20397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FAD")]
			[Address(RVA = "0x7500C0", Offset = "0x7500C0", VA = "0x7500C0")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06004FAE RID: 20398 RVA: 0x00025170 File Offset: 0x00023370
			[Token(Token = "0x6004FAE")]
			[Address(RVA = "0x753C40", Offset = "0x753C40", VA = "0x753C40")]
			internal bool <CraftItem>b__0(Recipe.RequiredItemEntry req)
			{
				return default(bool);
			}

			// Token: 0x040093A8 RID: 37800
			[Token(Token = "0x40093A8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<DestinationInventory> chests;

			// Token: 0x040093A9 RID: 37801
			[Token(Token = "0x40093A9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Func<Recipe.RequiredItemEntry, bool> <>9__0;
		}

		// Token: 0x02000959 RID: 2393
		[Token(Token = "0x2000959")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06004FAF RID: 20399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FAF")]
			[Address(RVA = "0x75272C", Offset = "0x75272C", VA = "0x75272C")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x06004FB0 RID: 20400 RVA: 0x00025188 File Offset: 0x00023388
			[Token(Token = "0x6004FB0")]
			[Address(RVA = "0x753CB8", Offset = "0x753CB8", VA = "0x753CB8")]
			internal bool <HandleRequest>b__0(Chest chest)
			{
				return default(bool);
			}

			// Token: 0x06004FB1 RID: 20401 RVA: 0x000251A0 File Offset: 0x000233A0
			[Token(Token = "0x6004FB1")]
			[Address(RVA = "0x753D3C", Offset = "0x753D3C", VA = "0x753D3C")]
			internal bool <HandleRequest>b__1(Recipe.RequiredItemEntry req)
			{
				return default(bool);
			}

			// Token: 0x040093AA RID: 37802
			[Token(Token = "0x40093AA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int whoAmI;

			// Token: 0x040093AB RID: 37803
			[Token(Token = "0x40093AB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public List<Chest> chests;
		}

		// Token: 0x0200095A RID: 2394
		[Token(Token = "0x200095A")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004FB3 RID: 20403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FB3")]
			[Address(RVA = "0x753E38", Offset = "0x753E38", VA = "0x753E38")]
			public <>c()
			{
			}

			// Token: 0x06004FB4 RID: 20404 RVA: 0x000251B8 File Offset: 0x000233B8
			[Token(Token = "0x6004FB4")]
			[Address(RVA = "0x753E40", Offset = "0x753E40", VA = "0x753E40")]
			internal int <SavePossibleRefunds>b__23_0(CraftingRequests.RemoteCraftRequest c)
			{
				return 0;
			}

			// Token: 0x040093AC RID: 37804
			[Token(Token = "0x40093AC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly CraftingRequests.<>c <>9;

			// Token: 0x040093AD RID: 37805
			[Token(Token = "0x40093AD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<CraftingRequests.RemoteCraftRequest, int> <>9__23_0;
		}
	}
}
