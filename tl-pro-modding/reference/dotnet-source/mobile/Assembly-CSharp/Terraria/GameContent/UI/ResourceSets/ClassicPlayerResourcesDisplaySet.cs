using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000D49 RID: 3401
	[Token(Token = "0x2000D49")]
	public class ClassicPlayerResourcesDisplaySet : FileAPI, GUIControllerItem
	{
		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064DF RID: 25823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD2")]
		public string NameKey
		{
			[Token(Token = "0x60064DE")]
			[Address(RVA = "0xB3A6CC", Offset = "0xB3A6CC", VA = "0xB3A6CC", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60064DF")]
			[Address(RVA = "0xB3A6D4", Offset = "0xB3A6D4", VA = "0xB3A6D4")]
			private set
			{
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060064E0 RID: 25824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064E1 RID: 25825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD3")]
		public string ConfigKey
		{
			[Token(Token = "0x60064E0")]
			[Address(RVA = "0xB3A6DC", Offset = "0xB3A6DC", VA = "0xB3A6DC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60064E1")]
			[Address(RVA = "0xB3A6E4", Offset = "0xB3A6E4", VA = "0xB3A6E4")]
			private set
			{
			}
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E2")]
		[Address(RVA = "0xB3A6EC", Offset = "0xB3A6EC", VA = "0xB3A6EC")]
		public ClassicPlayerResourcesDisplaySet(string nameKey, string configKey)
		{
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E3")]
		[Address(RVA = "0xB3A728", Offset = "0xB3A728", VA = "0xB3A728", Slot = "4")]
		public void Draw()
		{
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E4")]
		[Address(RVA = "0xB3A7A8", Offset = "0xB3A7A8", VA = "0xB3A7A8")]
		private void DrawLife()
		{
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E5")]
		[Address(RVA = "0xB3B698", Offset = "0xB3B698", VA = "0xB3B698")]
		private void DrawMana()
		{
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E6")]
		[Address(RVA = "0xB3BDFC", Offset = "0xB3BDFC", VA = "0xB3BDFC", Slot = "5")]
		public void TryToHover()
		{
		}

		// Token: 0x0400A24A RID: 41546
		[Token(Token = "0x400A24A")]
		[FieldOffset(Offset = "0x8")]
		private int UIDisplay_ManaPerStar;

		// Token: 0x0400A24B RID: 41547
		[Token(Token = "0x400A24B")]
		[FieldOffset(Offset = "0xC")]
		private float UIDisplay_LifePerHeart;

		// Token: 0x0400A24C RID: 41548
		[Token(Token = "0x400A24C")]
		[FieldOffset(Offset = "0x10")]
		private int UI_ScreenAnchorX;

		// Token: 0x0400A24D RID: 41549
		[Token(Token = "0x400A24D")]
		[FieldOffset(Offset = "0x14")]
		private string <NameKey>k__BackingField;

		// Token: 0x0400A24E RID: 41550
		[Token(Token = "0x400A24E")]
		[FieldOffset(Offset = "0x18")]
		private string <ConfigKey>k__BackingField;
	}
}
