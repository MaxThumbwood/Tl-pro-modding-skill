using System;
using Il2CppDummyDll;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C14 RID: 3092
	[Token(Token = "0x2000C14")]
	public class FlavorTextBestiaryInfoElement : FileAPI
	{
		// Token: 0x06005CCF RID: 23759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCF")]
		[Address(RVA = "0x99E9D8", Offset = "0x99E9D8", VA = "0x99E9D8")]
		public FlavorTextBestiaryInfoElement(string languageKey)
		{
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD0")]
		[Address(RVA = "0x9A483C", Offset = "0x9A483C", VA = "0x9A483C", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD1")]
		[Address(RVA = "0x9A4C88", Offset = "0x9A4C88", VA = "0x9A4C88")]
		private static void AddDynamicResize(UIElement container, UIText text)
		{
		}

		// Token: 0x04009D2C RID: 40236
		[Token(Token = "0x4009D2C")]
		[FieldOffset(Offset = "0x8")]
		public string _key;

		// Token: 0x02000C15 RID: 3093
		[Token(Token = "0x2000C15")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06005CD2 RID: 23762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005CD2")]
			[Address(RVA = "0x9A4DB0", Offset = "0x9A4DB0", VA = "0x9A4DB0")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06005CD3 RID: 23763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005CD3")]
			[Address(RVA = "0x9A4DB8", Offset = "0x9A4DB8", VA = "0x9A4DB8")]
			internal void <AddDynamicResize>b__0()
			{
			}

			// Token: 0x04009D2D RID: 40237
			[Token(Token = "0x4009D2D")]
			[FieldOffset(Offset = "0x8")]
			public UIElement container;

			// Token: 0x04009D2E RID: 40238
			[Token(Token = "0x4009D2E")]
			[FieldOffset(Offset = "0xC")]
			public UIText text;
		}
	}
}
