using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000C44 RID: 3140
	[Token(Token = "0x2000C44")]
	public struct GameAnimationSegment
	{
		// Token: 0x04009D8B RID: 40331
		[Token(Token = "0x4009D8B")]
		[FieldOffset(Offset = "0x0")]
		public SpriteBatch SpriteBatch;

		// Token: 0x04009D8C RID: 40332
		[Token(Token = "0x4009D8C")]
		[FieldOffset(Offset = "0x4")]
		public Vector2 AnchorPositionOnScreen;

		// Token: 0x04009D8D RID: 40333
		[Token(Token = "0x4009D8D")]
		[FieldOffset(Offset = "0xC")]
		public int TimeInAnimation;

		// Token: 0x04009D8E RID: 40334
		[Token(Token = "0x4009D8E")]
		[FieldOffset(Offset = "0x10")]
		public float DisplayOpacity;
	}
}
