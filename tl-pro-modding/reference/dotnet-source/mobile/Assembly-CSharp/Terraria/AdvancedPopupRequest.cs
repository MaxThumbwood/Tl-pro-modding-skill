using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	public struct AdvancedPopupRequest
	{
		// Token: 0x0400422D RID: 16941
		[Token(Token = "0x400422D")]
		[FieldOffset(Offset = "0x0")]
		public string Text;

		// Token: 0x0400422E RID: 16942
		[Token(Token = "0x400422E")]
		[FieldOffset(Offset = "0x4")]
		public Color Color;

		// Token: 0x0400422F RID: 16943
		[Token(Token = "0x400422F")]
		[FieldOffset(Offset = "0x8")]
		public int DurationInFrames;

		// Token: 0x04004230 RID: 16944
		[Token(Token = "0x4004230")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 Velocity;
	}
}
