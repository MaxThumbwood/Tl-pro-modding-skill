using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria
{
	// Token: 0x020004F2 RID: 1266
	[Token(Token = "0x20004F2")]
	public class RecipeGroup
	{
		// Token: 0x0600318D RID: 12685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318D")]
		[Address(RVA = "0x19FE3C8", Offset = "0x19FE3C8", VA = "0x19FE3C8")]
		private static Func<string> WithDefaultCombineFormat(string key)
		{
			return null;
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x00017F10 File Offset: 0x00016110
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000697")]
		public int RegisteredId
		{
			[Token(Token = "0x600318E")]
			[Address(RVA = "0x19FE4F4", Offset = "0x19FE4F4", VA = "0x19FE4F4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600318F")]
			[Address(RVA = "0x19FE4FC", Offset = "0x19FE4FC", VA = "0x19FE4FC")]
			private set
			{
			}
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003190")]
		[Address(RVA = "0x19FE504", Offset = "0x19FE504", VA = "0x19FE504")]
		public RecipeGroup(string groupDescriptorKey, int[] validItems)
		{
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003191")]
		[Address(RVA = "0x19FE580", Offset = "0x19FE580", VA = "0x19FE580")]
		public RecipeGroup(Func<string> getName, int[] validItems)
		{
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003192")]
		[Address(RVA = "0x19FE6C8", Offset = "0x19FE6C8", VA = "0x19FE6C8")]
		public RecipeGroup Add(int itemID, [Optional] Func<bool> isPreferred)
		{
			return null;
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003193")]
		[Address(RVA = "0x19FE7C8", Offset = "0x19FE7C8", VA = "0x19FE7C8")]
		internal void SortDecraftingEntries()
		{
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003194")]
		[Address(RVA = "0x19FE91C", Offset = "0x19FE91C", VA = "0x19FE91C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003195")]
		[Address(RVA = "0x19FE944", Offset = "0x19FE944", VA = "0x19FE944")]
		public RecipeGroup Register()
		{
			return null;
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x00017F28 File Offset: 0x00016128
		[Token(Token = "0x6003196")]
		[Address(RVA = "0x19FEA64", Offset = "0x19FEA64", VA = "0x19FEA64")]
		public int CountUsableItems(Dictionary<int, int> itemStacksAvailable)
		{
			return 0;
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x00017F40 File Offset: 0x00016140
		[Token(Token = "0x6003197")]
		[Address(RVA = "0x19FEC48", Offset = "0x19FEC48", VA = "0x19FEC48")]
		public int GetGroupFakeItemId()
		{
			return 0;
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x00017F58 File Offset: 0x00016158
		[Token(Token = "0x6003198")]
		[Address(RVA = "0x19FECB8", Offset = "0x19FECB8", VA = "0x19FECB8")]
		public bool Contains(int itemType)
		{
			return default(bool);
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x00017F70 File Offset: 0x00016170
		[Token(Token = "0x6003199")]
		[Address(RVA = "0x19FED24", Offset = "0x19FED24", VA = "0x19FED24")]
		public int GetPlaceholderItemType()
		{
			return 0;
		}

		// Token: 0x04004242 RID: 16962
		[Token(Token = "0x4004242")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FakeItemIdOffset;

		// Token: 0x04004243 RID: 16963
		[Token(Token = "0x4004243")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static LocalizedText DefaultCombineFormat;

		// Token: 0x04004244 RID: 16964
		[Token(Token = "0x4004244")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <RegisteredId>k__BackingField;

		// Token: 0x04004245 RID: 16965
		[Token(Token = "0x4004245")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Func<string> GetText;

		// Token: 0x04004246 RID: 16966
		[Token(Token = "0x4004246")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public HashSet<int> ValidItems;

		// Token: 0x04004247 RID: 16967
		[Token(Token = "0x4004247")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public List<int> Items;

		// Token: 0x04004248 RID: 16968
		[Token(Token = "0x4004248")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DecraftItemId;

		// Token: 0x04004249 RID: 16969
		[Token(Token = "0x4004249")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Dictionary<int, RecipeGroup> recipeGroups;

		// Token: 0x0400424A RID: 16970
		[Token(Token = "0x400424A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int nextRecipeGroupIndex;

		// Token: 0x020004F3 RID: 1267
		[Token(Token = "0x20004F3")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x0600319B RID: 12699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600319B")]
			[Address(RVA = "0x19FE4EC", Offset = "0x19FE4EC", VA = "0x19FE4EC")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x0600319C RID: 12700 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600319C")]
			[Address(RVA = "0x19FEEB0", Offset = "0x19FEEB0", VA = "0x19FEEB0")]
			internal string <WithDefaultCombineFormat>b__0()
			{
				return null;
			}

			// Token: 0x0400424B RID: 16971
			[Token(Token = "0x400424B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public LocalizedText text;
		}

		// Token: 0x020004F4 RID: 1268
		[Token(Token = "0x20004F4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600319E RID: 12702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600319E")]
			[Address(RVA = "0x19FEFAC", Offset = "0x19FEFAC", VA = "0x19FEFAC")]
			public <>c()
			{
			}

			// Token: 0x0600319F RID: 12703 RVA: 0x00017F88 File Offset: 0x00016188
			[Token(Token = "0x600319F")]
			[Address(RVA = "0x19FEFB4", Offset = "0x19FEFB4", VA = "0x19FEFB4")]
			internal int <SortDecraftingEntries>b__14_0(int e)
			{
				return 0;
			}

			// Token: 0x0400424C RID: 16972
			[Token(Token = "0x400424C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly RecipeGroup.<>c <>9;

			// Token: 0x0400424D RID: 16973
			[Token(Token = "0x400424D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<int, int> <>9__14_0;
		}
	}
}
