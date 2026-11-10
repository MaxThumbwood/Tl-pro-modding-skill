using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D84 RID: 3460
	[Token(Token = "0x2000D84")]
	public class UIImage : UIElement
	{
		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06006641 RID: 26177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF1")]
		public Asset<Texture2D> Texture
		{
			[Token(Token = "0x6006641")]
			[Address(RVA = "0xB5EA34", Offset = "0xB5EA34", VA = "0xB5EA34")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006642")]
		[Address(RVA = "0xB5EA3C", Offset = "0xB5EA3C", VA = "0xB5EA3C")]
		protected UIImage()
		{
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006643")]
		[Address(RVA = "0xB5EB78", Offset = "0xB5EB78", VA = "0xB5EB78")]
		public UIImage(Asset<Texture2D> texture)
		{
		}

		// Token: 0x06006644 RID: 26180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006644")]
		[Address(RVA = "0xB5ED74", Offset = "0xB5ED74", VA = "0xB5ED74")]
		public void SetImage(Asset<Texture2D> texture)
		{
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006645")]
		[Address(RVA = "0xB5EE60", Offset = "0xB5EE60", VA = "0xB5EE60", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A384 RID: 41860
		[Token(Token = "0x400A384")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400A385 RID: 41861
		[Token(Token = "0x400A385")]
		[FieldOffset(Offset = "0xF8")]
		public float ImageScale;

		// Token: 0x0400A386 RID: 41862
		[Token(Token = "0x400A386")]
		[FieldOffset(Offset = "0xFC")]
		public float Rotation;

		// Token: 0x0400A387 RID: 41863
		[Token(Token = "0x400A387")]
		[FieldOffset(Offset = "0x100")]
		public bool ScaleToFit;

		// Token: 0x0400A388 RID: 41864
		[Token(Token = "0x400A388")]
		[FieldOffset(Offset = "0x101")]
		public Color Color;

		// Token: 0x0400A389 RID: 41865
		[Token(Token = "0x400A389")]
		[FieldOffset(Offset = "0x108")]
		public Vector2 NormalizedOrigin;

		// Token: 0x0400A38A RID: 41866
		[Token(Token = "0x400A38A")]
		[FieldOffset(Offset = "0x110")]
		public Rectangle? Frame;

		// Token: 0x0400A38B RID: 41867
		[Token(Token = "0x400A38B")]
		[FieldOffset(Offset = "0x124")]
		public bool RemoveFloatingPointsFromDrawPosition;
	}
}
