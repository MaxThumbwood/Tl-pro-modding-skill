using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C8F RID: 3215
	[Token(Token = "0x2000C8F")]
	public class SolarSky : CustomSky
	{
		// Token: 0x06005F2C RID: 24364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2C")]
		[Address(RVA = "0xA8A3E8", Offset = "0xA8A3E8", VA = "0xA8A3E8", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2D")]
		[Address(RVA = "0xA8A69C", Offset = "0xA8A69C", VA = "0xA8A69C", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x0002C040 File Offset: 0x0002A240
		[Token(Token = "0x6005F2E")]
		[Address(RVA = "0xA8A978", Offset = "0xA8A978", VA = "0xA8A978", Slot = "12")]
		public override Color OnTileColor(Color inColor)
		{
			return default(Color);
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2F")]
		[Address(RVA = "0xA8AAE0", Offset = "0xA8AAE0", VA = "0xA8AAE0", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x0002C058 File Offset: 0x0002A258
		[Token(Token = "0x6005F30")]
		[Address(RVA = "0xA8B7C8", Offset = "0xA8B7C8", VA = "0xA8B7C8", Slot = "13")]
		public override float GetCloudAlpha()
		{
			return 0f;
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F31")]
		[Address(RVA = "0xA8B7F0", Offset = "0xA8B7F0", VA = "0xA8B7F0", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x0002C070 File Offset: 0x0002A270
		[Token(Token = "0x6005F32")]
		[Address(RVA = "0xA8BBC4", Offset = "0xA8BBC4", VA = "0xA8BBC4")]
		private int SortMethod(SolarSky.Meteor meteor1, SolarSky.Meteor meteor2)
		{
			return 0;
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F33")]
		[Address(RVA = "0xA8BC14", Offset = "0xA8BC14", VA = "0xA8BC14", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F34")]
		[Address(RVA = "0xA8BC20", Offset = "0xA8BC20", VA = "0xA8BC20", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x0002C088 File Offset: 0x0002A288
		[Token(Token = "0x6005F35")]
		[Address(RVA = "0xA8BC2C", Offset = "0xA8BC2C", VA = "0xA8BC2C", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F36")]
		[Address(RVA = "0xA8BC60", Offset = "0xA8BC60", VA = "0xA8BC60")]
		public SolarSky()
		{
		}

		// Token: 0x04009E88 RID: 40584
		[Token(Token = "0x4009E88")]
		[FieldOffset(Offset = "0x14")]
		private UnifiedRandom _random;

		// Token: 0x04009E89 RID: 40585
		[Token(Token = "0x4009E89")]
		[FieldOffset(Offset = "0x18")]
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04009E8A RID: 40586
		[Token(Token = "0x4009E8A")]
		[FieldOffset(Offset = "0x1C")]
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04009E8B RID: 40587
		[Token(Token = "0x4009E8B")]
		[FieldOffset(Offset = "0x20")]
		private Asset<Texture2D> _meteorTexture;

		// Token: 0x04009E8C RID: 40588
		[Token(Token = "0x4009E8C")]
		[FieldOffset(Offset = "0x24")]
		private bool _isActive;

		// Token: 0x04009E8D RID: 40589
		[Token(Token = "0x4009E8D")]
		[FieldOffset(Offset = "0x28")]
		private SolarSky.Meteor[] _meteors;

		// Token: 0x04009E8E RID: 40590
		[Token(Token = "0x4009E8E")]
		[FieldOffset(Offset = "0x2C")]
		private float _fadeOpacity;

		// Token: 0x02000C90 RID: 3216
		[Token(Token = "0x2000C90")]
		private struct Meteor
		{
			// Token: 0x04009E8F RID: 40591
			[Token(Token = "0x4009E8F")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04009E90 RID: 40592
			[Token(Token = "0x4009E90")]
			[FieldOffset(Offset = "0x8")]
			public float Depth;

			// Token: 0x04009E91 RID: 40593
			[Token(Token = "0x4009E91")]
			[FieldOffset(Offset = "0xC")]
			public int FrameCounter;

			// Token: 0x04009E92 RID: 40594
			[Token(Token = "0x4009E92")]
			[FieldOffset(Offset = "0x10")]
			public float Scale;

			// Token: 0x04009E93 RID: 40595
			[Token(Token = "0x4009E93")]
			[FieldOffset(Offset = "0x14")]
			public float StartX;
		}
	}
}
