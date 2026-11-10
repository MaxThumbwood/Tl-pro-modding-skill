using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x02000896 RID: 2198
	[Token(Token = "0x2000896")]
	public class UIMouseEvent : UIEvent
	{
		// Token: 0x06004ACF RID: 19151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0x63F66C", Offset = "0x63F66C", VA = "0x63F66C")]
		public UIMouseEvent(UIElement target, Vector2 mousePosition)
		{
		}

		// Token: 0x04009003 RID: 36867
		[Token(Token = "0x4009003")]
		[FieldOffset(Offset = "0xC")]
		public readonly Vector2 MousePosition;
	}
}
