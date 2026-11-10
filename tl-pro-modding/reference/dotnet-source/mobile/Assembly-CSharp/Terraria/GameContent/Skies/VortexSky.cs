using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C93 RID: 3219
	[Token(Token = "0x2000C93")]
	public class VortexSky : CustomSky
	{
		// Token: 0x06005F42 RID: 24386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F42")]
		[Address(RVA = "0xA8D520", Offset = "0xA8D520", VA = "0xA8D520", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F43")]
		[Address(RVA = "0xA8D890", Offset = "0xA8D890", VA = "0xA8D890", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x0002C100 File Offset: 0x0002A300
		[Token(Token = "0x6005F44")]
		[Address(RVA = "0xA8DC18", Offset = "0xA8DC18", VA = "0xA8DC18", Slot = "12")]
		public override Color OnTileColor(Color inColor)
		{
			return default(Color);
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F45")]
		[Address(RVA = "0xA8DD80", Offset = "0xA8DD80", VA = "0xA8DD80", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x0002C118 File Offset: 0x0002A318
		[Token(Token = "0x6005F46")]
		[Address(RVA = "0xA8E920", Offset = "0xA8E920", VA = "0xA8E920", Slot = "13")]
		public override float GetCloudAlpha()
		{
			return 0f;
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F47")]
		[Address(RVA = "0xA8E948", Offset = "0xA8E948", VA = "0xA8E948", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F48")]
		[Address(RVA = "0xA8EA10", Offset = "0xA8EA10", VA = "0xA8EA10", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F49")]
		[Address(RVA = "0xA8EA1C", Offset = "0xA8EA1C", VA = "0xA8EA1C", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x0002C130 File Offset: 0x0002A330
		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0xA8EA28", Offset = "0xA8EA28", VA = "0xA8EA28", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4B")]
		[Address(RVA = "0xA8EA5C", Offset = "0xA8EA5C", VA = "0xA8EA5C")]
		public VortexSky()
		{
		}

		// Token: 0x04009EA1 RID: 40609
		[Token(Token = "0x4009EA1")]
		[FieldOffset(Offset = "0x14")]
		private UnifiedRandom _random;

		// Token: 0x04009EA2 RID: 40610
		[Token(Token = "0x4009EA2")]
		[FieldOffset(Offset = "0x18")]
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04009EA3 RID: 40611
		[Token(Token = "0x4009EA3")]
		[FieldOffset(Offset = "0x1C")]
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04009EA4 RID: 40612
		[Token(Token = "0x4009EA4")]
		[FieldOffset(Offset = "0x20")]
		private Asset<Texture2D> _boltTexture;

		// Token: 0x04009EA5 RID: 40613
		[Token(Token = "0x4009EA5")]
		[FieldOffset(Offset = "0x24")]
		private Asset<Texture2D> _flashTexture;

		// Token: 0x04009EA6 RID: 40614
		[Token(Token = "0x4009EA6")]
		[FieldOffset(Offset = "0x28")]
		private bool _isActive;

		// Token: 0x04009EA7 RID: 40615
		[Token(Token = "0x4009EA7")]
		[FieldOffset(Offset = "0x2C")]
		private int _ticksUntilNextBolt;

		// Token: 0x04009EA8 RID: 40616
		[Token(Token = "0x4009EA8")]
		[FieldOffset(Offset = "0x30")]
		private float _fadeOpacity;

		// Token: 0x04009EA9 RID: 40617
		[Token(Token = "0x4009EA9")]
		[FieldOffset(Offset = "0x34")]
		private VortexSky.Bolt[] _bolts;

		// Token: 0x02000C94 RID: 3220
		[Token(Token = "0x2000C94")]
		private struct Bolt
		{
			// Token: 0x04009EAA RID: 40618
			[Token(Token = "0x4009EAA")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04009EAB RID: 40619
			[Token(Token = "0x4009EAB")]
			[FieldOffset(Offset = "0x8")]
			public float Depth;

			// Token: 0x04009EAC RID: 40620
			[Token(Token = "0x4009EAC")]
			[FieldOffset(Offset = "0xC")]
			public int Life;

			// Token: 0x04009EAD RID: 40621
			[Token(Token = "0x4009EAD")]
			[FieldOffset(Offset = "0x10")]
			public bool IsAlive;
		}
	}
}
