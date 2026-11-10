using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D36 RID: 3382
	[Token(Token = "0x2000D36")]
	public struct UIAdvancedPopupRequest
	{
		// Token: 0x0400A1D4 RID: 41428
		[Token(Token = "0x400A1D4")]
		[FieldOffset(Offset = "0x0")]
		public UIPopupTextContext Context;

		// Token: 0x0400A1D5 RID: 41429
		[Token(Token = "0x400A1D5")]
		[FieldOffset(Offset = "0x4")]
		public UIPopupTextAlignment Alignment;

		// Token: 0x0400A1D6 RID: 41430
		[Token(Token = "0x400A1D6")]
		[FieldOffset(Offset = "0x8")]
		public string Text;

		// Token: 0x0400A1D7 RID: 41431
		[Token(Token = "0x400A1D7")]
		[FieldOffset(Offset = "0xC")]
		public Color Color;

		// Token: 0x0400A1D8 RID: 41432
		[Token(Token = "0x400A1D8")]
		[FieldOffset(Offset = "0x10")]
		public int DurationInFrames;

		// Token: 0x0400A1D9 RID: 41433
		[Token(Token = "0x400A1D9")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 Position;

		// Token: 0x0400A1DA RID: 41434
		[Token(Token = "0x400A1DA")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 Velocity;
	}
}
