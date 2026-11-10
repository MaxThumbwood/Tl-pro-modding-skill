using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C91 RID: 3217
	[Token(Token = "0x2000C91")]
	public class StardustSky : CustomSky
	{
		// Token: 0x06005F37 RID: 24375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F37")]
		[Address(RVA = "0xA8BCDC", Offset = "0xA8BCDC", VA = "0xA8BCDC", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F38")]
		[Address(RVA = "0xA8C098", Offset = "0xA8C098", VA = "0xA8C098", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x0002C0A0 File Offset: 0x0002A2A0
		[Token(Token = "0x6005F39")]
		[Address(RVA = "0xA8C158", Offset = "0xA8C158", VA = "0xA8C158", Slot = "12")]
		public override Color OnTileColor(Color inColor)
		{
			return default(Color);
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3A")]
		[Address(RVA = "0xA8C2C0", Offset = "0xA8C2C0", VA = "0xA8C2C0", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x0002C0B8 File Offset: 0x0002A2B8
		[Token(Token = "0x6005F3B")]
		[Address(RVA = "0xA8D018", Offset = "0xA8D018", VA = "0xA8D018", Slot = "13")]
		public override float GetCloudAlpha()
		{
			return 0f;
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3C")]
		[Address(RVA = "0xA8D040", Offset = "0xA8D040", VA = "0xA8D040", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x0002C0D0 File Offset: 0x0002A2D0
		[Token(Token = "0x6005F3D")]
		[Address(RVA = "0xA8D3FC", Offset = "0xA8D3FC", VA = "0xA8D3FC")]
		private int SortMethod(StardustSky.Star meteor1, StardustSky.Star meteor2)
		{
			return 0;
		}

		// Token: 0x06005F3E RID: 24382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3E")]
		[Address(RVA = "0xA8D458", Offset = "0xA8D458", VA = "0xA8D458", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005F3F RID: 24383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3F")]
		[Address(RVA = "0xA8D464", Offset = "0xA8D464", VA = "0xA8D464", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
		[Token(Token = "0x6005F40")]
		[Address(RVA = "0xA8D470", Offset = "0xA8D470", VA = "0xA8D470", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F41")]
		[Address(RVA = "0xA8D4A4", Offset = "0xA8D4A4", VA = "0xA8D4A4")]
		public StardustSky()
		{
		}

		// Token: 0x04009E94 RID: 40596
		[Token(Token = "0x4009E94")]
		[FieldOffset(Offset = "0x14")]
		private UnifiedRandom _random;

		// Token: 0x04009E95 RID: 40597
		[Token(Token = "0x4009E95")]
		[FieldOffset(Offset = "0x18")]
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04009E96 RID: 40598
		[Token(Token = "0x4009E96")]
		[FieldOffset(Offset = "0x1C")]
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04009E97 RID: 40599
		[Token(Token = "0x4009E97")]
		[FieldOffset(Offset = "0x20")]
		private Asset<Texture2D>[] _starTextures;

		// Token: 0x04009E98 RID: 40600
		[Token(Token = "0x4009E98")]
		[FieldOffset(Offset = "0x24")]
		private bool _isActive;

		// Token: 0x04009E99 RID: 40601
		[Token(Token = "0x4009E99")]
		[FieldOffset(Offset = "0x28")]
		private StardustSky.Star[] _stars;

		// Token: 0x04009E9A RID: 40602
		[Token(Token = "0x4009E9A")]
		[FieldOffset(Offset = "0x2C")]
		private float _fadeOpacity;

		// Token: 0x02000C92 RID: 3218
		[Token(Token = "0x2000C92")]
		private struct Star
		{
			// Token: 0x04009E9B RID: 40603
			[Token(Token = "0x4009E9B")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04009E9C RID: 40604
			[Token(Token = "0x4009E9C")]
			[FieldOffset(Offset = "0x8")]
			public float Depth;

			// Token: 0x04009E9D RID: 40605
			[Token(Token = "0x4009E9D")]
			[FieldOffset(Offset = "0xC")]
			public int TextureIndex;

			// Token: 0x04009E9E RID: 40606
			[Token(Token = "0x4009E9E")]
			[FieldOffset(Offset = "0x10")]
			public float SinOffset;

			// Token: 0x04009E9F RID: 40607
			[Token(Token = "0x4009E9F")]
			[FieldOffset(Offset = "0x14")]
			public float AlphaFrequency;

			// Token: 0x04009EA0 RID: 40608
			[Token(Token = "0x4009EA0")]
			[FieldOffset(Offset = "0x18")]
			public float AlphaAmplitude;
		}
	}
}
