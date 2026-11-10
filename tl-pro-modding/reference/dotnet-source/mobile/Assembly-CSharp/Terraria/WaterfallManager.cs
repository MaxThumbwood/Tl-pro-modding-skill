using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics;
using Terraria.IO;

namespace Terraria
{
	// Token: 0x02000513 RID: 1299
	[Token(Token = "0x2000513")]
	public class WaterfallManager
	{
		// Token: 0x060034E5 RID: 13541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x1A3C128", Offset = "0x1A3C128", VA = "0x1A3C128")]
		public WaterfallManager()
		{
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x1A3C258", Offset = "0x1A3C258", VA = "0x1A3C258")]
		public void LoadContent()
		{
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0001A868 File Offset: 0x00018A68
		[Token(Token = "0x60034E7")]
		[Address(RVA = "0x1A3C460", Offset = "0x1A3C460", VA = "0x1A3C460")]
		public bool CheckForWaterfall(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0x1A3C4E8", Offset = "0x1A3C4E8", VA = "0x1A3C4E8")]
		public void Reset()
		{
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E9")]
		[Address(RVA = "0x1A3C4FC", Offset = "0x1A3C4FC", VA = "0x1A3C4FC")]
		public void FindWaterfalls(bool forced = false)
		{
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EA")]
		[Address(RVA = "0x1A3D85C", Offset = "0x1A3D85C", VA = "0x1A3D85C")]
		public void UpdateFrame()
		{
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EB")]
		[Address(RVA = "0x1A3D994", Offset = "0x1A3D994", VA = "0x1A3D994")]
		private void DrawWaterfall(SpriteBatch spriteBatch, int Style = 0, float Alpha = 1f)
		{
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EC")]
		[Address(RVA = "0x1A43B98", Offset = "0x1A43B98", VA = "0x1A43B98")]
		private void DrawWaterfall(int waterfallType, int x, int y, float opacity, Vector2 position, ref Rectangle sourceRect, ref Color color, SpriteEffects effects)
		{
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034ED")]
		[Address(RVA = "0x1A438E4", Offset = "0x1A438E4", VA = "0x1A438E4")]
		private static void TrySparkling(int x, int y, int direction, Color aColor2)
		{
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EE")]
		[Address(RVA = "0x1A43E64", Offset = "0x1A43E64", VA = "0x1A43E64")]
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F0")]
		[Address(RVA = "0x1A44580", Offset = "0x1A44580", VA = "0x1A44580")]
		private void <.ctor>b__24_0(Preferences preferences)
		{
		}

		// Token: 0x04004397 RID: 17303
		[Token(Token = "0x4004397")]
		private const int minWet = 160;

		// Token: 0x04004398 RID: 17304
		[Token(Token = "0x4004398")]
		private const int maxWaterfallCountDefault = 1000;

		// Token: 0x04004399 RID: 17305
		[Token(Token = "0x4004399")]
		private const int maxLength = 100;

		// Token: 0x0400439A RID: 17306
		[Token(Token = "0x400439A")]
		private const int maxTypes = 28;

		// Token: 0x0400439B RID: 17307
		[Token(Token = "0x400439B")]
		[FieldOffset(Offset = "0x8")]
		public int maxWaterfallCount;

		// Token: 0x0400439C RID: 17308
		[Token(Token = "0x400439C")]
		[FieldOffset(Offset = "0xC")]
		private int qualityMax;

		// Token: 0x0400439D RID: 17309
		[Token(Token = "0x400439D")]
		[FieldOffset(Offset = "0x10")]
		private int currentMax;

		// Token: 0x0400439E RID: 17310
		[Token(Token = "0x400439E")]
		[FieldOffset(Offset = "0x14")]
		private WaterfallManager.WaterfallData[] waterfalls;

		// Token: 0x0400439F RID: 17311
		[Token(Token = "0x400439F")]
		[FieldOffset(Offset = "0x0")]
		private static Asset<Texture2D>[] waterfallTexture;

		// Token: 0x040043A0 RID: 17312
		[Token(Token = "0x40043A0")]
		[FieldOffset(Offset = "0x18")]
		private int wFallFrCounter;

		// Token: 0x040043A1 RID: 17313
		[Token(Token = "0x40043A1")]
		[FieldOffset(Offset = "0x1C")]
		private int regularFrame;

		// Token: 0x040043A2 RID: 17314
		[Token(Token = "0x40043A2")]
		[FieldOffset(Offset = "0x20")]
		private int wFallFrCounter2;

		// Token: 0x040043A3 RID: 17315
		[Token(Token = "0x40043A3")]
		[FieldOffset(Offset = "0x24")]
		private int slowFrame;

		// Token: 0x040043A4 RID: 17316
		[Token(Token = "0x40043A4")]
		[FieldOffset(Offset = "0x28")]
		private int rainFrameCounter;

		// Token: 0x040043A5 RID: 17317
		[Token(Token = "0x40043A5")]
		[FieldOffset(Offset = "0x2C")]
		private int rainFrameForeground;

		// Token: 0x040043A6 RID: 17318
		[Token(Token = "0x40043A6")]
		[FieldOffset(Offset = "0x30")]
		private int rainFrameBackground;

		// Token: 0x040043A7 RID: 17319
		[Token(Token = "0x40043A7")]
		[FieldOffset(Offset = "0x34")]
		private int lavaRainFrameCounter;

		// Token: 0x040043A8 RID: 17320
		[Token(Token = "0x40043A8")]
		[FieldOffset(Offset = "0x38")]
		private int lavaRainFrameForeground;

		// Token: 0x040043A9 RID: 17321
		[Token(Token = "0x40043A9")]
		[FieldOffset(Offset = "0x3C")]
		private int lavaRainFrameBackground;

		// Token: 0x040043AA RID: 17322
		[Token(Token = "0x40043AA")]
		[FieldOffset(Offset = "0x40")]
		private int snowFrameCounter;

		// Token: 0x040043AB RID: 17323
		[Token(Token = "0x40043AB")]
		[FieldOffset(Offset = "0x44")]
		private int snowFrameForeground;

		// Token: 0x040043AC RID: 17324
		[Token(Token = "0x40043AC")]
		[FieldOffset(Offset = "0x48")]
		private int findWaterfallCount;

		// Token: 0x040043AD RID: 17325
		[Token(Token = "0x40043AD")]
		[FieldOffset(Offset = "0x4C")]
		private int waterfallDist;

		// Token: 0x040043AE RID: 17326
		[Token(Token = "0x40043AE")]
		[FieldOffset(Offset = "0x50")]
		private VertexColors shimmerWaterFallColours;

		// Token: 0x02000514 RID: 1300
		[Token(Token = "0x2000514")]
		public struct WaterfallData
		{
			// Token: 0x040043AF RID: 17327
			[Token(Token = "0x40043AF")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x040043B0 RID: 17328
			[Token(Token = "0x40043B0")]
			[FieldOffset(Offset = "0x4")]
			public int y;

			// Token: 0x040043B1 RID: 17329
			[Token(Token = "0x40043B1")]
			[FieldOffset(Offset = "0x8")]
			public int type;

			// Token: 0x040043B2 RID: 17330
			[Token(Token = "0x40043B2")]
			[FieldOffset(Offset = "0xC")]
			public int stopAtStep;
		}
	}
}
