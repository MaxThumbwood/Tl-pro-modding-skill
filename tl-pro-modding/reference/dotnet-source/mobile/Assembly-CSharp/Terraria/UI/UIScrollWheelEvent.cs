using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x02000897 RID: 2199
	[Token(Token = "0x2000897")]
	public class UIScrollWheelEvent : UIMouseEvent
	{
		// Token: 0x06004AD0 RID: 19152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x63F698", Offset = "0x63F698", VA = "0x63F698")]
		public UIScrollWheelEvent(UIElement target, Vector2 mousePosition, int scrollWheelValue)
		{
		}

		// Token: 0x04009004 RID: 36868
		[Token(Token = "0x4009004")]
		[FieldOffset(Offset = "0x14")]
		public readonly int ScrollWheelValue;
	}
}
