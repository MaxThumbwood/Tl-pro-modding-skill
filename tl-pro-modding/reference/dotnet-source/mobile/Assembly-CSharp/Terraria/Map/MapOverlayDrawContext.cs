using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.UI;

namespace Terraria.Map
{
	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2000811")]
	public struct MapOverlayDrawContext
	{
		// Token: 0x060046A3 RID: 18083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A3")]
		[Address(RVA = "0x59E968", Offset = "0x59E968", VA = "0x59E968")]
		public MapOverlayDrawContext(Vector2 mapPosition, Vector2 mapOffset, Rectangle? clippingRect, float mapScale, float drawScale, float opacity)
		{
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x00021738 File Offset: 0x0001F938
		[Token(Token = "0x60046A4")]
		[Address(RVA = "0x59EA4C", Offset = "0x59EA4C", VA = "0x59EA4C")]
		public MapOverlayDrawContext.DrawResult Draw(Texture2D texture, Vector2 position, Alignment alignment)
		{
			return default(MapOverlayDrawContext.DrawResult);
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x00021750 File Offset: 0x0001F950
		[Token(Token = "0x60046A5")]
		[Address(RVA = "0x59EABC", Offset = "0x59EABC", VA = "0x59EABC")]
		public MapOverlayDrawContext.DrawResult Draw(Texture2D texture, Vector2 position, SpriteFrame frame, Alignment alignment)
		{
			return default(MapOverlayDrawContext.DrawResult);
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x00021768 File Offset: 0x0001F968
		[Token(Token = "0x60046A6")]
		[Address(RVA = "0x59F1C0", Offset = "0x59F1C0", VA = "0x59F1C0")]
		public Rectangle GetUnclampedDrawRegion(Texture2D texture, Vector2 position, SpriteFrame frame, float scale, Alignment alignment)
		{
			return default(Rectangle);
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x00021780 File Offset: 0x0001F980
		[Token(Token = "0x60046A7")]
		[Address(RVA = "0x59F46C", Offset = "0x59F46C", VA = "0x59F46C")]
		public Rectangle GetClampedDrawRegion(Texture2D texture, Vector2 position, SpriteFrame frame, float scale, Alignment alignment, int screenBorderRegion)
		{
			return default(Rectangle);
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x00021798 File Offset: 0x0001F998
		[Token(Token = "0x60046A8")]
		[Address(RVA = "0x59F948", Offset = "0x59F948", VA = "0x59F948")]
		public MapOverlayDrawContext.DrawResult DrawClamped(Texture2D texture, Texture2D offscreenTexture, Vector2 position, Color color, SpriteFrame frame, float scaleIfNotSelected, float scaleIfSelected, float scaleIfOffscreen, Alignment alignment, int screenBorderRegion, out bool onScreen)
		{
			return default(MapOverlayDrawContext.DrawResult);
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x000217B0 File Offset: 0x0001F9B0
		[Token(Token = "0x60046A9")]
		[Address(RVA = "0x59E574", Offset = "0x59E574", VA = "0x59E574")]
		public MapOverlayDrawContext.DrawResult DrawWithOutline(Texture2D texture, Vector2 position, Alignment alignment)
		{
			return default(MapOverlayDrawContext.DrawResult);
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x000217C8 File Offset: 0x0001F9C8
		[Token(Token = "0x60046AA")]
		[Address(RVA = "0x5A0404", Offset = "0x5A0404", VA = "0x5A0404")]
		public MapOverlayDrawContext.DrawResult DrawWithOutline(Texture2D texture, Vector2 position, SpriteFrame frame, Alignment alignment)
		{
			return default(MapOverlayDrawContext.DrawResult);
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x000217E0 File Offset: 0x0001F9E0
		[Token(Token = "0x60046AB")]
		[Address(RVA = "0x5A0ACC", Offset = "0x5A0ACC", VA = "0x5A0ACC")]
		public MapOverlayDrawContext.DrawResult Draw(Texture2D texture, Vector2 position, Color color, SpriteFrame frame, float scaleIfNotSelected, float scaleIfSelected, Alignment alignment)
		{
			return default(MapOverlayDrawContext.DrawResult);
		}

		// Token: 0x04008D96 RID: 36246
		[Token(Token = "0x4008D96")]
		[FieldOffset(Offset = "0x0")]
		private readonly Vector2 _mapPosition;

		// Token: 0x04008D97 RID: 36247
		[Token(Token = "0x4008D97")]
		[FieldOffset(Offset = "0x8")]
		private readonly Vector2 _mapOffset;

		// Token: 0x04008D98 RID: 36248
		[Token(Token = "0x4008D98")]
		[FieldOffset(Offset = "0x10")]
		private readonly Rectangle? _clippingRect;

		// Token: 0x04008D99 RID: 36249
		[Token(Token = "0x4008D99")]
		[FieldOffset(Offset = "0x24")]
		private readonly float _mapScale;

		// Token: 0x04008D9A RID: 36250
		[Token(Token = "0x4008D9A")]
		[FieldOffset(Offset = "0x28")]
		private readonly float _drawScale;

		// Token: 0x04008D9B RID: 36251
		[Token(Token = "0x4008D9B")]
		[FieldOffset(Offset = "0x2C")]
		private readonly float _opacity;

		// Token: 0x02000812 RID: 2066
		[Token(Token = "0x2000812")]
		public struct DrawResult
		{
			// Token: 0x060046AC RID: 18092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046AC")]
			[Address(RVA = "0x5A10D0", Offset = "0x5A10D0", VA = "0x5A10D0")]
			public DrawResult(bool isMouseOver)
			{
			}

			// Token: 0x04008D9C RID: 36252
			[Token(Token = "0x4008D9C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MapOverlayDrawContext.DrawResult Culled;

			// Token: 0x04008D9D RID: 36253
			[Token(Token = "0x4008D9D")]
			[FieldOffset(Offset = "0x0")]
			public readonly bool IsMouseOver;
		}
	}
}
