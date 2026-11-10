using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C8D RID: 3213
	[Token(Token = "0x2000C8D")]
	public class SlimeSky : CustomSky
	{
		// Token: 0x06005F1E RID: 24350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1E")]
		[Address(RVA = "0xA88AD4", Offset = "0xA88AD4", VA = "0xA88AD4", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1F")]
		[Address(RVA = "0xA88CE0", Offset = "0xA88CE0", VA = "0xA88CE0")]
		private void GenerateSlimes()
		{
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F20")]
		[Address(RVA = "0xA892F0", Offset = "0xA892F0", VA = "0xA892F0", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F21")]
		[Address(RVA = "0xA898F8", Offset = "0xA898F8", VA = "0xA898F8", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F22")]
		[Address(RVA = "0xA8A324", Offset = "0xA8A324", VA = "0xA8A324", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F23")]
		[Address(RVA = "0xA8A33C", Offset = "0xA8A33C", VA = "0xA8A33C", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F24")]
		[Address(RVA = "0xA8A348", Offset = "0xA8A348", VA = "0xA8A348", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005F25 RID: 24357 RVA: 0x0002BFF8 File Offset: 0x0002A1F8
		[Token(Token = "0x6005F25")]
		[Address(RVA = "0xA8A354", Offset = "0xA8A354", VA = "0xA8A354", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005F26 RID: 24358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F26")]
		[Address(RVA = "0xA8A35C", Offset = "0xA8A35C", VA = "0xA8A35C")]
		public SlimeSky()
		{
		}

		// Token: 0x04009E78 RID: 40568
		[Token(Token = "0x4009E78")]
		[FieldOffset(Offset = "0x14")]
		private Asset<Texture2D>[] _textures;

		// Token: 0x04009E79 RID: 40569
		[Token(Token = "0x4009E79")]
		[FieldOffset(Offset = "0x18")]
		private SlimeSky.Slime[] _slimes;

		// Token: 0x04009E7A RID: 40570
		[Token(Token = "0x4009E7A")]
		[FieldOffset(Offset = "0x1C")]
		private UnifiedRandom _random;

		// Token: 0x04009E7B RID: 40571
		[Token(Token = "0x4009E7B")]
		[FieldOffset(Offset = "0x20")]
		private int _slimesRemaining;

		// Token: 0x04009E7C RID: 40572
		[Token(Token = "0x4009E7C")]
		[FieldOffset(Offset = "0x24")]
		private bool _isActive;

		// Token: 0x04009E7D RID: 40573
		[Token(Token = "0x4009E7D")]
		[FieldOffset(Offset = "0x25")]
		private bool _isLeaving;

		// Token: 0x02000C8E RID: 3214
		[Token(Token = "0x2000C8E")]
		private struct Slime
		{
			// Token: 0x17000A78 RID: 2680
			// (get) Token: 0x06005F27 RID: 24359 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005F28 RID: 24360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A78")]
			public Texture2D Texture
			{
				[Token(Token = "0x6005F27")]
				[Address(RVA = "0xA8A3D8", Offset = "0xA8A3D8", VA = "0xA8A3D8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005F28")]
				[Address(RVA = "0xA892A0", Offset = "0xA892A0", VA = "0xA892A0")]
				set
				{
				}
			}

			// Token: 0x17000A79 RID: 2681
			// (get) Token: 0x06005F29 RID: 24361 RVA: 0x0002C010 File Offset: 0x0002A210
			// (set) Token: 0x06005F2A RID: 24362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A79")]
			public int Frame
			{
				[Token(Token = "0x6005F29")]
				[Address(RVA = "0xA8A3E0", Offset = "0xA8A3E0", VA = "0xA8A3E0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6005F2A")]
				[Address(RVA = "0xA898D4", Offset = "0xA898D4", VA = "0xA898D4")]
				set
				{
				}
			}

			// Token: 0x06005F2B RID: 24363 RVA: 0x0002C028 File Offset: 0x0002A228
			[Token(Token = "0x6005F2B")]
			[Address(RVA = "0xA8A2D8", Offset = "0xA8A2D8", VA = "0xA8A2D8")]
			public Rectangle GetSourceRectangle()
			{
				return default(Rectangle);
			}

			// Token: 0x04009E7E RID: 40574
			[Token(Token = "0x4009E7E")]
			private const int MAX_FRAMES = 4;

			// Token: 0x04009E7F RID: 40575
			[Token(Token = "0x4009E7F")]
			private const int FRAME_RATE = 6;

			// Token: 0x04009E80 RID: 40576
			[Token(Token = "0x4009E80")]
			[FieldOffset(Offset = "0x0")]
			private Texture2D _texture;

			// Token: 0x04009E81 RID: 40577
			[Token(Token = "0x4009E81")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 Position;

			// Token: 0x04009E82 RID: 40578
			[Token(Token = "0x4009E82")]
			[FieldOffset(Offset = "0xC")]
			public float Depth;

			// Token: 0x04009E83 RID: 40579
			[Token(Token = "0x4009E83")]
			[FieldOffset(Offset = "0x10")]
			public int FrameHeight;

			// Token: 0x04009E84 RID: 40580
			[Token(Token = "0x4009E84")]
			[FieldOffset(Offset = "0x14")]
			public int FrameWidth;

			// Token: 0x04009E85 RID: 40581
			[Token(Token = "0x4009E85")]
			[FieldOffset(Offset = "0x18")]
			public float Speed;

			// Token: 0x04009E86 RID: 40582
			[Token(Token = "0x4009E86")]
			[FieldOffset(Offset = "0x1C")]
			public bool Active;

			// Token: 0x04009E87 RID: 40583
			[Token(Token = "0x4009E87")]
			[FieldOffset(Offset = "0x20")]
			private int _frame;
		}
	}
}
