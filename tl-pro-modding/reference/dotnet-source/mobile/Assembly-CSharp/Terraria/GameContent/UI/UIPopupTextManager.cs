using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D37 RID: 3383
	[Token(Token = "0x2000D37")]
	public class UIPopupTextManager
	{
		// Token: 0x06006454 RID: 25684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006454")]
		[Address(RVA = "0xB257E4", Offset = "0xB257E4", VA = "0xB257E4")]
		public void ResetText(UIPopupText text)
		{
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
		[Token(Token = "0x6006455")]
		[Address(RVA = "0xB25860", Offset = "0xB25860", VA = "0xB25860")]
		public int NewText(UIAdvancedPopupRequest request)
		{
			return 0;
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x0002DF00 File Offset: 0x0002C100
		[Token(Token = "0x6006456")]
		[Address(RVA = "0xB25AE8", Offset = "0xB25AE8", VA = "0xB25AE8")]
		private int FindNextItemTextSlot()
		{
			return 0;
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006457")]
		[Address(RVA = "0xB25C28", Offset = "0xB25C28", VA = "0xB25C28")]
		public void UpdateItemText()
		{
		}

		// Token: 0x06006458 RID: 25688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006458")]
		[Address(RVA = "0xB261C0", Offset = "0xB261C0", VA = "0xB261C0")]
		public void ClearAll()
		{
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006459")]
		[Address(RVA = "0xB262AC", Offset = "0xB262AC", VA = "0xB262AC")]
		public void DrawItemTextPopups(float scaleTarget)
		{
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645A")]
		[Address(RVA = "0xB26B54", Offset = "0xB26B54", VA = "0xB26B54")]
		public UIPopupTextManager()
		{
		}

		// Token: 0x0400A1DB RID: 41435
		[Token(Token = "0x400A1DB")]
		public const int maxItemText = 20;

		// Token: 0x0400A1DC RID: 41436
		[Token(Token = "0x400A1DC")]
		[FieldOffset(Offset = "0x8")]
		public UIPopupText[] popupText;

		// Token: 0x0400A1DD RID: 41437
		[Token(Token = "0x400A1DD")]
		[FieldOffset(Offset = "0xC")]
		public int numActive;
	}
}
