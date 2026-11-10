using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A17 RID: 2583
	[Token(Token = "0x2000A17")]
	public class BiomePreferenceListTrait : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x060053D3 RID: 21459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D3")]
		[Address(RVA = "0x809A78", Offset = "0x809A78", VA = "0x809A78")]
		public BiomePreferenceListTrait()
		{
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D4")]
		[Address(RVA = "0x809B10", Offset = "0x809B10", VA = "0x809B10")]
		public void Add(BiomePreferenceListTrait.BiomePreference preference)
		{
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D5")]
		[Address(RVA = "0x809BCC", Offset = "0x809BCC", VA = "0x809BCC")]
		public void Add(AffectionLevel level, AShoppingBiome biome)
		{
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D6")]
		[Address(RVA = "0x809CF8", Offset = "0x809CF8", VA = "0x809CF8", Slot = "4")]
		public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
		{
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D7")]
		[Address(RVA = "0x809E1C", Offset = "0x809E1C", VA = "0x809E1C")]
		private void ApplyPreference(BiomePreferenceListTrait.BiomePreference preference, HelperInfo info, ShopHelper shopHelperInstance)
		{
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D8")]
		[Address(RVA = "0x809EF8", Offset = "0x809EF8", VA = "0x809EF8", Slot = "5")]
		public IEnumerator<BiomePreferenceListTrait.BiomePreference> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D9")]
		[Address(RVA = "0x809F9C", Offset = "0x809F9C", VA = "0x809F9C", Slot = "6")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x040097A2 RID: 38818
		[Token(Token = "0x40097A2")]
		[FieldOffset(Offset = "0x8")]
		private List<BiomePreferenceListTrait.BiomePreference> _preferences;

		// Token: 0x02000A18 RID: 2584
		[Token(Token = "0x2000A18")]
		public class BiomePreference
		{
			// Token: 0x060053DA RID: 21466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053DA")]
			[Address(RVA = "0x809CD4", Offset = "0x809CD4", VA = "0x809CD4")]
			public BiomePreference(AffectionLevel affection, AShoppingBiome biome)
			{
			}

			// Token: 0x040097A3 RID: 38819
			[Token(Token = "0x40097A3")]
			[FieldOffset(Offset = "0x8")]
			public AffectionLevel Affection;

			// Token: 0x040097A4 RID: 38820
			[Token(Token = "0x40097A4")]
			[FieldOffset(Offset = "0xC")]
			public AShoppingBiome Biome;
		}
	}
}
