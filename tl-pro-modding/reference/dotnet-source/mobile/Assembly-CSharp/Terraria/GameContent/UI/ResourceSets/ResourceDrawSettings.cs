using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000D53 RID: 3411
	[Token(Token = "0x2000D53")]
	public struct ResourceDrawSettings
	{
		// Token: 0x06006523 RID: 25891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006523")]
		[Address(RVA = "0xB41404", Offset = "0xB41404", VA = "0xB41404")]
		public void Draw(SpriteBatch spriteBatch, ref bool isHovered)
		{
		}

		// Token: 0x0400A28D RID: 41613
		[Token(Token = "0x400A28D")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 TopLeftAnchor;

		// Token: 0x0400A28E RID: 41614
		[Token(Token = "0x400A28E")]
		[FieldOffset(Offset = "0x8")]
		public int ElementCount;

		// Token: 0x0400A28F RID: 41615
		[Token(Token = "0x400A28F")]
		[FieldOffset(Offset = "0xC")]
		public int ElementIndexOffset;

		// Token: 0x0400A290 RID: 41616
		[Token(Token = "0x400A290")]
		[FieldOffset(Offset = "0x10")]
		public ResourceDrawSettings.TextureGetter GetTextureMethod;

		// Token: 0x0400A291 RID: 41617
		[Token(Token = "0x400A291")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 OffsetPerDraw;

		// Token: 0x0400A292 RID: 41618
		[Token(Token = "0x400A292")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 OffsetPerDrawByTexturePercentile;

		// Token: 0x0400A293 RID: 41619
		[Token(Token = "0x400A293")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 OffsetSpriteAnchor;

		// Token: 0x0400A294 RID: 41620
		[Token(Token = "0x400A294")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 OffsetSpriteAnchorByTexturePercentile;

		// Token: 0x02000D54 RID: 3412
		// (Invoke) Token: 0x06006525 RID: 25893
		[Token(Token = "0x2000D54")]
		public delegate void TextureGetter(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> texture, out Vector2 drawOffset, out float drawScale, out Rectangle? sourceRect);
	}
}
