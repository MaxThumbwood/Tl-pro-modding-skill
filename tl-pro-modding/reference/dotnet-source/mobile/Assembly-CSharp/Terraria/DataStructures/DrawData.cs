using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x2000755")]
	public struct DrawData
	{
		// Token: 0x060042BA RID: 17082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BA")]
		[Address(RVA = "0x4F8F48", Offset = "0x4F8F48", VA = "0x4F8F48")]
		public DrawData(Texture2D texture, Vector2 position, Color color)
		{
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BB")]
		[Address(RVA = "0x4F9108", Offset = "0x4F9108", VA = "0x4F9108")]
		public DrawData(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
		{
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BC")]
		[Address(RVA = "0x4F9210", Offset = "0x4F9210", VA = "0x4F9210")]
		public DrawData(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
		{
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BD")]
		[Address(RVA = "0x4F931C", Offset = "0x4F931C", VA = "0x4F931C")]
		public void Set(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
		{
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BE")]
		[Address(RVA = "0x4F9428", Offset = "0x4F9428", VA = "0x4F9428")]
		public void Set(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
		{
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BF")]
		[Address(RVA = "0x4F9530", Offset = "0x4F9530", VA = "0x4F9530")]
		public DrawData(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
		{
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C0")]
		[Address(RVA = "0x4F9588", Offset = "0x4F9588", VA = "0x4F9588")]
		public void Set(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
		{
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C1")]
		[Address(RVA = "0x4F95E0", Offset = "0x4F95E0", VA = "0x4F95E0")]
		public void Set(Texture2D texture, ref Vector2 position, ref Rectangle sourceRect, ref Color color, float rotation, ref Vector2 origin, float scale, SpriteEffects effect)
		{
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C2")]
		[Address(RVA = "0x4F9644", Offset = "0x4F9644", VA = "0x4F9644")]
		public DrawData(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
		{
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C3")]
		[Address(RVA = "0x4F96A0", Offset = "0x4F96A0", VA = "0x4F96A0")]
		public void Set(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
		{
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C4")]
		[Address(RVA = "0x4F96FC", Offset = "0x4F96FC", VA = "0x4F96FC")]
		public void Draw(SpriteBatch sb)
		{
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C5")]
		[Address(RVA = "0x4F9794", Offset = "0x4F9794", VA = "0x4F9794")]
		public void Draw(SpriteBatch sb, Vector2 offset)
		{
		}

		// Token: 0x04008A3F RID: 35391
		[Token(Token = "0x4008A3F")]
		[FieldOffset(Offset = "0x0")]
		public Texture2D texture;

		// Token: 0x04008A40 RID: 35392
		[Token(Token = "0x4008A40")]
		[FieldOffset(Offset = "0x4")]
		public Vector2 position;

		// Token: 0x04008A41 RID: 35393
		[Token(Token = "0x4008A41")]
		[FieldOffset(Offset = "0xC")]
		public Rectangle sourceRect;

		// Token: 0x04008A42 RID: 35394
		[Token(Token = "0x4008A42")]
		[FieldOffset(Offset = "0x1C")]
		public Color color;

		// Token: 0x04008A43 RID: 35395
		[Token(Token = "0x4008A43")]
		[FieldOffset(Offset = "0x20")]
		public float rotation;

		// Token: 0x04008A44 RID: 35396
		[Token(Token = "0x4008A44")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 origin;

		// Token: 0x04008A45 RID: 35397
		[Token(Token = "0x4008A45")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 scale;

		// Token: 0x04008A46 RID: 35398
		[Token(Token = "0x4008A46")]
		[FieldOffset(Offset = "0x34")]
		public SpriteEffects effect;

		// Token: 0x04008A47 RID: 35399
		[Token(Token = "0x4008A47")]
		[FieldOffset(Offset = "0x38")]
		public int shader;

		// Token: 0x04008A48 RID: 35400
		[Token(Token = "0x4008A48")]
		[FieldOffset(Offset = "0x3C")]
		public bool ignorePlayerRotation;
	}
}
