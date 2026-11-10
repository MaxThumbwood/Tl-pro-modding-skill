using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x02000954 RID: 2388
	[Token(Token = "0x2000954")]
	public class CraftingEffects
	{
		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06004F83 RID: 20355 RVA: 0x00024FD8 File Offset: 0x000231D8
		// (set) Token: 0x06004F84 RID: 20356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000986")]
		private static int _justCraftedItemType
		{
			[Token(Token = "0x6004F83")]
			[Address(RVA = "0x74EC50", Offset = "0x74EC50", VA = "0x74EC50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004F84")]
			[Address(RVA = "0x74ECB8", Offset = "0x74ECB8", VA = "0x74ECB8")]
			set
			{
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06004F85 RID: 20357 RVA: 0x00024FF0 File Offset: 0x000231F0
		// (set) Token: 0x06004F86 RID: 20358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000987")]
		private static float _mouseItemGlow
		{
			[Token(Token = "0x6004F85")]
			[Address(RVA = "0x74ED24", Offset = "0x74ED24", VA = "0x74ED24")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004F86")]
			[Address(RVA = "0x74ED8C", Offset = "0x74ED8C", VA = "0x74ED8C")]
			set
			{
			}
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F87")]
		[Address(RVA = "0x74EE04", Offset = "0x74EE04", VA = "0x74EE04")]
		public static void OnCraft(Recipe recipe, bool quickCraft)
		{
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F88")]
		[Address(RVA = "0x74EF4C", Offset = "0x74EF4C", VA = "0x74EF4C")]
		public static void OnCraftItemGranted(Recipe recipe, Item result, bool quickCraft)
		{
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F89")]
		[Address(RVA = "0x74F060", Offset = "0x74F060", VA = "0x74F060")]
		public static void Update()
		{
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x00025008 File Offset: 0x00023208
		[Token(Token = "0x6004F8A")]
		[Address(RVA = "0x74F184", Offset = "0x74F184", VA = "0x74F184")]
		public static float GetGlow(Item cursorItem)
		{
			return 0f;
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8B")]
		[Address(RVA = "0x74EF14", Offset = "0x74EF14", VA = "0x74EF14")]
		private static void SpawnEffects_BeforeGrantingItem(Recipe recipe, Item result)
		{
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8C")]
		[Address(RVA = "0x74F05C", Offset = "0x74F05C", VA = "0x74F05C")]
		public static void SpawnEffects_AfterGrantingItem(Recipe recipe, Item result, bool quickCraft)
		{
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x00025020 File Offset: 0x00023220
		[Token(Token = "0x6004F8D")]
		[Address(RVA = "0x74F2BC", Offset = "0x74F2BC", VA = "0x74F2BC")]
		private static bool RecipeUsesCraftingStation(Recipe recipe, int tileId)
		{
			return default(bool);
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x00025038 File Offset: 0x00023238
		[Token(Token = "0x6004F8E")]
		[Address(RVA = "0x74F2E8", Offset = "0x74F2E8", VA = "0x74F2E8")]
		public static CraftingEffectDetails GetEffectDetails(Item newItem)
		{
			return default(CraftingEffectDetails);
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8F")]
		[Address(RVA = "0x74F4FC", Offset = "0x74F4FC", VA = "0x74F4FC")]
		private static void CreateBubbleParticles(int n)
		{
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F90")]
		[Address(RVA = "0x74FA44", Offset = "0x74FA44", VA = "0x74FA44")]
		public CraftingEffects()
		{
		}
	}
}
