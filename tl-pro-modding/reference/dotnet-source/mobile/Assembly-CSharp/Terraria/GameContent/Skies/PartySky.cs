using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C64 RID: 3172
	[Token(Token = "0x2000C64")]
	public class PartySky : CustomSky
	{
		// Token: 0x06005E3C RID: 24124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3C")]
		[Address(RVA = "0x9BBAE0", Offset = "0x9BBAE0", VA = "0x9BBAE0", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0x9BBC20", Offset = "0x9BBC20", VA = "0x9BBC20")]
		private void GenerateBalloons(bool onlyMissing)
		{
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3E")]
		[Address(RVA = "0x9BBEE4", Offset = "0x9BBEE4", VA = "0x9BBEE4")]
		public void ResetBalloon(int i)
		{
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3F")]
		[Address(RVA = "0x9BC188", Offset = "0x9BC188", VA = "0x9BC188", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E40")]
		[Address(RVA = "0x9BC63C", Offset = "0x9BC63C", VA = "0x9BC63C", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E41")]
		[Address(RVA = "0x9BD158", Offset = "0x9BD158", VA = "0x9BD158", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E42")]
		[Address(RVA = "0x9BD19C", Offset = "0x9BD19C", VA = "0x9BD19C", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x0002BBC0 File Offset: 0x00029DC0
		[Token(Token = "0x6005E43")]
		[Address(RVA = "0x9BD1A8", Offset = "0x9BD1A8", VA = "0x9BD1A8", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E44")]
		[Address(RVA = "0x9BD1B0", Offset = "0x9BD1B0", VA = "0x9BD1B0", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E45")]
		[Address(RVA = "0x9BD1BC", Offset = "0x9BD1BC", VA = "0x9BD1BC")]
		public PartySky()
		{
		}

		// Token: 0x04009DE0 RID: 40416
		[Token(Token = "0x4009DE0")]
		[FieldOffset(Offset = "0x0")]
		public static bool MultipleSkyWorkaroundFix;

		// Token: 0x04009DE1 RID: 40417
		[Token(Token = "0x4009DE1")]
		[FieldOffset(Offset = "0x14")]
		private bool _active;

		// Token: 0x04009DE2 RID: 40418
		[Token(Token = "0x4009DE2")]
		[FieldOffset(Offset = "0x15")]
		private bool _leaving;

		// Token: 0x04009DE3 RID: 40419
		[Token(Token = "0x4009DE3")]
		[FieldOffset(Offset = "0x18")]
		private Asset<Texture2D>[] _textures;

		// Token: 0x04009DE4 RID: 40420
		[Token(Token = "0x4009DE4")]
		[FieldOffset(Offset = "0x1C")]
		private PartySky.Balloon[] _balloons;

		// Token: 0x04009DE5 RID: 40421
		[Token(Token = "0x4009DE5")]
		[FieldOffset(Offset = "0x20")]
		private UnifiedRandom _random;

		// Token: 0x04009DE6 RID: 40422
		[Token(Token = "0x4009DE6")]
		[FieldOffset(Offset = "0x24")]
		private int _balloonsDrawing;

		// Token: 0x02000C65 RID: 3173
		[Token(Token = "0x2000C65")]
		private struct Balloon
		{
			// Token: 0x17000A6F RID: 2671
			// (get) Token: 0x06005E46 RID: 24134 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005E47 RID: 24135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A6F")]
			public Texture2D Texture
			{
				[Token(Token = "0x6005E46")]
				[Address(RVA = "0x9BD238", Offset = "0x9BD238", VA = "0x9BD238")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005E47")]
				[Address(RVA = "0x9BC124", Offset = "0x9BC124", VA = "0x9BC124")]
				set
				{
				}
			}

			// Token: 0x17000A70 RID: 2672
			// (get) Token: 0x06005E48 RID: 24136 RVA: 0x0002BBD8 File Offset: 0x00029DD8
			// (set) Token: 0x06005E49 RID: 24137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A70")]
			public int Frame
			{
				[Token(Token = "0x6005E48")]
				[Address(RVA = "0x9BD240", Offset = "0x9BD240", VA = "0x9BD240")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6005E49")]
				[Address(RVA = "0x9BC618", Offset = "0x9BC618", VA = "0x9BC618")]
				set
				{
				}
			}

			// Token: 0x06005E4A RID: 24138 RVA: 0x0002BBF0 File Offset: 0x00029DF0
			[Token(Token = "0x6005E4A")]
			[Address(RVA = "0x9BD104", Offset = "0x9BD104", VA = "0x9BD104")]
			public Rectangle GetSourceRectangle()
			{
				return default(Rectangle);
			}

			// Token: 0x04009DE7 RID: 40423
			[Token(Token = "0x4009DE7")]
			private const int MAX_FRAMES_X = 3;

			// Token: 0x04009DE8 RID: 40424
			[Token(Token = "0x4009DE8")]
			private const int MAX_FRAMES_Y = 3;

			// Token: 0x04009DE9 RID: 40425
			[Token(Token = "0x4009DE9")]
			private const int FRAME_RATE = 14;

			// Token: 0x04009DEA RID: 40426
			[Token(Token = "0x4009DEA")]
			[FieldOffset(Offset = "0x0")]
			public int Variant;

			// Token: 0x04009DEB RID: 40427
			[Token(Token = "0x4009DEB")]
			[FieldOffset(Offset = "0x4")]
			private Texture2D _texture;

			// Token: 0x04009DEC RID: 40428
			[Token(Token = "0x4009DEC")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 Position;

			// Token: 0x04009DED RID: 40429
			[Token(Token = "0x4009DED")]
			[FieldOffset(Offset = "0x10")]
			public float Depth;

			// Token: 0x04009DEE RID: 40430
			[Token(Token = "0x4009DEE")]
			[FieldOffset(Offset = "0x14")]
			public int FrameHeight;

			// Token: 0x04009DEF RID: 40431
			[Token(Token = "0x4009DEF")]
			[FieldOffset(Offset = "0x18")]
			public int FrameWidth;

			// Token: 0x04009DF0 RID: 40432
			[Token(Token = "0x4009DF0")]
			[FieldOffset(Offset = "0x1C")]
			public float Speed;

			// Token: 0x04009DF1 RID: 40433
			[Token(Token = "0x4009DF1")]
			[FieldOffset(Offset = "0x20")]
			public bool Active;

			// Token: 0x04009DF2 RID: 40434
			[Token(Token = "0x4009DF2")]
			[FieldOffset(Offset = "0x24")]
			private int _frameCounter;
		}
	}
}
