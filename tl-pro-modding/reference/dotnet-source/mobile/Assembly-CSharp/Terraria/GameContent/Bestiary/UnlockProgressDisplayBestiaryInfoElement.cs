using System;
using Il2CppDummyDll;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C16 RID: 3094
	[Token(Token = "0x2000C16")]
	public class UnlockProgressDisplayBestiaryInfoElement : FileAPI
	{
		// Token: 0x06005CD4 RID: 23764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD4")]
		[Address(RVA = "0x9A4E14", Offset = "0x9A4E14", VA = "0x9A4E14")]
		public UnlockProgressDisplayBestiaryInfoElement(BestiaryUnlockProgressReport progressReport)
		{
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD5")]
		[Address(RVA = "0x9A4E38", Offset = "0x9A4E38", VA = "0x9A4E38", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD6")]
		[Address(RVA = "0x9A5478", Offset = "0x9A5478", VA = "0x9A5478")]
		private void AddDynamicResize(UIElement container, UIText text)
		{
		}

		// Token: 0x04009D2F RID: 40239
		[Token(Token = "0x4009D2F")]
		[FieldOffset(Offset = "0x8")]
		private BestiaryUnlockProgressReport _progressReport;

		// Token: 0x04009D30 RID: 40240
		[Token(Token = "0x4009D30")]
		[FieldOffset(Offset = "0x10")]
		private UIElement _text1;

		// Token: 0x04009D31 RID: 40241
		[Token(Token = "0x4009D31")]
		[FieldOffset(Offset = "0x14")]
		private UIElement _text2;

		// Token: 0x02000C17 RID: 3095
		[Token(Token = "0x2000C17")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06005CD7 RID: 23767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005CD7")]
			[Address(RVA = "0x9A5594", Offset = "0x9A5594", VA = "0x9A5594")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06005CD8 RID: 23768 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005CD8")]
			[Address(RVA = "0x9A559C", Offset = "0x9A559C", VA = "0x9A559C")]
			internal void <AddDynamicResize>b__0()
			{
			}

			// Token: 0x04009D32 RID: 40242
			[Token(Token = "0x4009D32")]
			[FieldOffset(Offset = "0x8")]
			public UIElement container;

			// Token: 0x04009D33 RID: 40243
			[Token(Token = "0x4009D33")]
			[FieldOffset(Offset = "0xC")]
			public UnlockProgressDisplayBestiaryInfoElement <>4__this;
		}
	}
}
