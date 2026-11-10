using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C81 RID: 3201
	[Token(Token = "0x2000C81")]
	public class LanternSky : CustomSky
	{
		// Token: 0x06005ED2 RID: 24274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED2")]
		[Address(RVA = "0x9CC2D0", Offset = "0x9CC2D0", VA = "0x9CC2D0", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED3")]
		[Address(RVA = "0x9CC358", Offset = "0x9CC358", VA = "0x9CC358")]
		private void GenerateLanterns(bool onlyMissing)
		{
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED4")]
		[Address(RVA = "0x9CC61C", Offset = "0x9CC61C", VA = "0x9CC61C")]
		public void ResetLantern(int i)
		{
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED5")]
		[Address(RVA = "0x9CC87C", Offset = "0x9CC87C", VA = "0x9CC87C", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED6")]
		[Address(RVA = "0x9CCD9C", Offset = "0x9CCD9C", VA = "0x9CCD9C", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED7")]
		[Address(RVA = "0x9CD688", Offset = "0x9CD688", VA = "0x9CD688")]
		private void DrawLantern(SpriteBatch spriteBatch, LanternSky.Lantern lantern, Color opacity, Vector2 depthScale, Vector2 position, float alpha)
		{
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED8")]
		[Address(RVA = "0x9CDCA8", Offset = "0x9CDCA8", VA = "0x9CDCA8", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED9")]
		[Address(RVA = "0x9CDCEC", Offset = "0x9CDCEC", VA = "0x9CDCEC", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x0002BE30 File Offset: 0x0002A030
		[Token(Token = "0x6005EDA")]
		[Address(RVA = "0x9CDCF8", Offset = "0x9CDCF8", VA = "0x9CDCF8", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDB")]
		[Address(RVA = "0x9CDD00", Offset = "0x9CDD00", VA = "0x9CDD00", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0x9CDD0C", Offset = "0x9CDD0C", VA = "0x9CDD0C")]
		public LanternSky()
		{
		}

		// Token: 0x04009E36 RID: 40502
		[Token(Token = "0x4009E36")]
		[FieldOffset(Offset = "0x14")]
		private bool _active;

		// Token: 0x04009E37 RID: 40503
		[Token(Token = "0x4009E37")]
		[FieldOffset(Offset = "0x15")]
		private bool _leaving;

		// Token: 0x04009E38 RID: 40504
		[Token(Token = "0x4009E38")]
		[FieldOffset(Offset = "0x18")]
		private float _opacity;

		// Token: 0x04009E39 RID: 40505
		[Token(Token = "0x4009E39")]
		[FieldOffset(Offset = "0x1C")]
		private Asset<Texture2D> _texture;

		// Token: 0x04009E3A RID: 40506
		[Token(Token = "0x4009E3A")]
		[FieldOffset(Offset = "0x20")]
		private LanternSky.Lantern[] _lanterns;

		// Token: 0x04009E3B RID: 40507
		[Token(Token = "0x4009E3B")]
		[FieldOffset(Offset = "0x24")]
		private UnifiedRandom _random;

		// Token: 0x04009E3C RID: 40508
		[Token(Token = "0x4009E3C")]
		[FieldOffset(Offset = "0x28")]
		private int _lanternsDrawing;

		// Token: 0x04009E3D RID: 40509
		[Token(Token = "0x4009E3D")]
		private const float slowDown = 0.5f;

		// Token: 0x02000C82 RID: 3202
		[Token(Token = "0x2000C82")]
		private struct Lantern
		{
			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x06005EDD RID: 24285 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005EDE RID: 24286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A73")]
			public Texture2D Texture
			{
				[Token(Token = "0x6005EDD")]
				[Address(RVA = "0x9CDD88", Offset = "0x9CDD88", VA = "0x9CDD88")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005EDE")]
				[Address(RVA = "0x9CC818", Offset = "0x9CC818", VA = "0x9CC818")]
				set
				{
				}
			}

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x06005EDF RID: 24287 RVA: 0x0002BE48 File Offset: 0x0002A048
			[Token(Token = "0x17000A74")]
			public float FloatAdjustedSpeed
			{
				[Token(Token = "0x6005EDF")]
				[Address(RVA = "0x9CCD78", Offset = "0x9CCD78", VA = "0x9CCD78")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06005EE0 RID: 24288 RVA: 0x0002BE60 File Offset: 0x0002A060
			[Token(Token = "0x6005EE0")]
			[Address(RVA = "0x9CDC6C", Offset = "0x9CDC6C", VA = "0x9CDC6C")]
			public Rectangle GetSourceRectangle()
			{
				return default(Rectangle);
			}

			// Token: 0x04009E3E RID: 40510
			[Token(Token = "0x4009E3E")]
			private const int MAX_FRAMES_X = 3;

			// Token: 0x04009E3F RID: 40511
			[Token(Token = "0x4009E3F")]
			[FieldOffset(Offset = "0x0")]
			public int Variant;

			// Token: 0x04009E40 RID: 40512
			[Token(Token = "0x4009E40")]
			[FieldOffset(Offset = "0x4")]
			public int TimeUntilFloat;

			// Token: 0x04009E41 RID: 40513
			[Token(Token = "0x4009E41")]
			[FieldOffset(Offset = "0x8")]
			public int TimeUntilFloatMax;

			// Token: 0x04009E42 RID: 40514
			[Token(Token = "0x4009E42")]
			[FieldOffset(Offset = "0xC")]
			private Texture2D _texture;

			// Token: 0x04009E43 RID: 40515
			[Token(Token = "0x4009E43")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 Position;

			// Token: 0x04009E44 RID: 40516
			[Token(Token = "0x4009E44")]
			[FieldOffset(Offset = "0x18")]
			public float Depth;

			// Token: 0x04009E45 RID: 40517
			[Token(Token = "0x4009E45")]
			[FieldOffset(Offset = "0x1C")]
			public float Rotation;

			// Token: 0x04009E46 RID: 40518
			[Token(Token = "0x4009E46")]
			[FieldOffset(Offset = "0x20")]
			public int FrameHeight;

			// Token: 0x04009E47 RID: 40519
			[Token(Token = "0x4009E47")]
			[FieldOffset(Offset = "0x24")]
			public int FrameWidth;

			// Token: 0x04009E48 RID: 40520
			[Token(Token = "0x4009E48")]
			[FieldOffset(Offset = "0x28")]
			public float Speed;

			// Token: 0x04009E49 RID: 40521
			[Token(Token = "0x4009E49")]
			[FieldOffset(Offset = "0x2C")]
			public bool Active;
		}
	}
}
