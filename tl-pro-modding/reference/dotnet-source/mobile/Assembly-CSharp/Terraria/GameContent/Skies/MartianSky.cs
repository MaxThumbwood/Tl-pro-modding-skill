using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C83 RID: 3203
	[Token(Token = "0x2000C83")]
	public class MartianSky : CustomSky
	{
		// Token: 0x06005EE1 RID: 24289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE1")]
		[Address(RVA = "0x9CDD90", Offset = "0x9CDD90", VA = "0x9CDD90", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE2")]
		[Address(RVA = "0x9CE06C", Offset = "0x9CE06C", VA = "0x9CE06C", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE3")]
		[Address(RVA = "0x9CEA9C", Offset = "0x9CEA9C", VA = "0x9CEA9C")]
		private void GenerateUfos()
		{
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE4")]
		[Address(RVA = "0x9CEF90", Offset = "0x9CEF90", VA = "0x9CEF90", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE5")]
		[Address(RVA = "0x9CF0D4", Offset = "0x9CF0D4", VA = "0x9CF0D4", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x0002BE78 File Offset: 0x0002A078
		[Token(Token = "0x6005EE6")]
		[Address(RVA = "0x9CF0E0", Offset = "0x9CF0E0", VA = "0x9CF0E0", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE7")]
		[Address(RVA = "0x9CF0E8", Offset = "0x9CF0E8", VA = "0x9CF0E8", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE8")]
		[Address(RVA = "0x9CF0F4", Offset = "0x9CF0F4", VA = "0x9CF0F4")]
		public MartianSky()
		{
		}

		// Token: 0x04009E4A RID: 40522
		[Token(Token = "0x4009E4A")]
		[FieldOffset(Offset = "0x14")]
		private MartianSky.Ufo[] _ufos;

		// Token: 0x04009E4B RID: 40523
		[Token(Token = "0x4009E4B")]
		[FieldOffset(Offset = "0x18")]
		private UnifiedRandom _random;

		// Token: 0x04009E4C RID: 40524
		[Token(Token = "0x4009E4C")]
		[FieldOffset(Offset = "0x1C")]
		private int _maxUfos;

		// Token: 0x04009E4D RID: 40525
		[Token(Token = "0x4009E4D")]
		[FieldOffset(Offset = "0x20")]
		private bool _active;

		// Token: 0x04009E4E RID: 40526
		[Token(Token = "0x4009E4E")]
		[FieldOffset(Offset = "0x21")]
		private bool _leaving;

		// Token: 0x04009E4F RID: 40527
		[Token(Token = "0x4009E4F")]
		[FieldOffset(Offset = "0x24")]
		private int _activeUfos;

		// Token: 0x02000C84 RID: 3204
		[Token(Token = "0x2000C84")]
		private abstract class IUfoController
		{
			// Token: 0x06005EE9 RID: 24297
			[Token(Token = "0x6005EE9")]
			public abstract void InitializeUfo(ref MartianSky.Ufo ufo);

			// Token: 0x06005EEA RID: 24298
			[Token(Token = "0x6005EEA")]
			public abstract bool Update(ref MartianSky.Ufo ufo);

			// Token: 0x06005EEB RID: 24299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EEB")]
			[Address(RVA = "0xA858E0", Offset = "0xA858E0", VA = "0xA858E0")]
			protected IUfoController()
			{
			}
		}

		// Token: 0x02000C85 RID: 3205
		[Token(Token = "0x2000C85")]
		private class ZipBehavior : MartianSky.IUfoController
		{
			// Token: 0x06005EEC RID: 24300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EEC")]
			[Address(RVA = "0xA858E8", Offset = "0xA858E8", VA = "0xA858E8", Slot = "4")]
			public override void InitializeUfo(ref MartianSky.Ufo ufo)
			{
			}

			// Token: 0x06005EED RID: 24301 RVA: 0x0002BE90 File Offset: 0x0002A090
			[Token(Token = "0x6005EED")]
			[Address(RVA = "0xA85BB4", Offset = "0xA85BB4", VA = "0xA85BB4", Slot = "5")]
			public override bool Update(ref MartianSky.Ufo ufo)
			{
				return default(bool);
			}

			// Token: 0x06005EEE RID: 24302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EEE")]
			[Address(RVA = "0xA85CB0", Offset = "0xA85CB0", VA = "0xA85CB0")]
			public ZipBehavior()
			{
			}

			// Token: 0x04009E50 RID: 40528
			[Token(Token = "0x4009E50")]
			[FieldOffset(Offset = "0x8")]
			private Vector2 _speed;

			// Token: 0x04009E51 RID: 40529
			[Token(Token = "0x4009E51")]
			[FieldOffset(Offset = "0x10")]
			private int _ticks;

			// Token: 0x04009E52 RID: 40530
			[Token(Token = "0x4009E52")]
			[FieldOffset(Offset = "0x14")]
			private int _maxTicks;
		}

		// Token: 0x02000C86 RID: 3206
		[Token(Token = "0x2000C86")]
		private class HoverBehavior : MartianSky.IUfoController
		{
			// Token: 0x06005EEF RID: 24303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EEF")]
			[Address(RVA = "0xA85CB8", Offset = "0xA85CB8", VA = "0xA85CB8", Slot = "4")]
			public override void InitializeUfo(ref MartianSky.Ufo ufo)
			{
			}

			// Token: 0x06005EF0 RID: 24304 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
			[Token(Token = "0x6005EF0")]
			[Address(RVA = "0xA85E24", Offset = "0xA85E24", VA = "0xA85E24", Slot = "5")]
			public override bool Update(ref MartianSky.Ufo ufo)
			{
				return default(bool);
			}

			// Token: 0x06005EF1 RID: 24305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EF1")]
			[Address(RVA = "0xA85E88", Offset = "0xA85E88", VA = "0xA85E88")]
			public HoverBehavior()
			{
			}

			// Token: 0x04009E53 RID: 40531
			[Token(Token = "0x4009E53")]
			[FieldOffset(Offset = "0x8")]
			private int _ticks;

			// Token: 0x04009E54 RID: 40532
			[Token(Token = "0x4009E54")]
			[FieldOffset(Offset = "0xC")]
			private int _maxTicks;
		}

		// Token: 0x02000C87 RID: 3207
		[Token(Token = "0x2000C87")]
		private struct Ufo
		{
			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x0002BEC0 File Offset: 0x0002A0C0
			// (set) Token: 0x06005EF3 RID: 24307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A75")]
			public int Frame
			{
				[Token(Token = "0x6005EF2")]
				[Address(RVA = "0xA85E90", Offset = "0xA85E90", VA = "0xA85E90")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6005EF3")]
				[Address(RVA = "0xA85E98", Offset = "0xA85E98", VA = "0xA85E98")]
				set
				{
				}
			}

			// Token: 0x17000A76 RID: 2678
			// (get) Token: 0x06005EF4 RID: 24308 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005EF5 RID: 24309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A76")]
			public Texture2D Texture
			{
				[Token(Token = "0x6005EF4")]
				[Address(RVA = "0xA85EBC", Offset = "0xA85EBC", VA = "0xA85EBC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005EF5")]
				[Address(RVA = "0xA85EC4", Offset = "0xA85EC4", VA = "0xA85EC4")]
				set
				{
				}
			}

			// Token: 0x17000A77 RID: 2679
			// (get) Token: 0x06005EF6 RID: 24310 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005EF7 RID: 24311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A77")]
			public MartianSky.IUfoController Controller
			{
				[Token(Token = "0x6005EF6")]
				[Address(RVA = "0xA85F18", Offset = "0xA85F18", VA = "0xA85F18")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005EF7")]
				[Address(RVA = "0xA85F20", Offset = "0xA85F20", VA = "0xA85F20")]
				set
				{
				}
			}

			// Token: 0x06005EF8 RID: 24312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EF8")]
			[Address(RVA = "0xA85F58", Offset = "0xA85F58", VA = "0xA85F58")]
			public Ufo(Texture2D texture, float depth = 1f)
			{
			}

			// Token: 0x06005EF9 RID: 24313 RVA: 0x0002BED8 File Offset: 0x0002A0D8
			[Token(Token = "0x6005EF9")]
			[Address(RVA = "0xA86094", Offset = "0xA86094", VA = "0xA86094")]
			public Rectangle GetSourceRectangle()
			{
				return default(Rectangle);
			}

			// Token: 0x06005EFA RID: 24314 RVA: 0x0002BEF0 File Offset: 0x0002A0F0
			[Token(Token = "0x6005EFA")]
			[Address(RVA = "0xA860DC", Offset = "0xA860DC", VA = "0xA860DC")]
			public bool Update()
			{
				return default(bool);
			}

			// Token: 0x06005EFB RID: 24315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EFB")]
			[Address(RVA = "0xA86160", Offset = "0xA86160", VA = "0xA86160")]
			public void AssignNewBehavior()
			{
			}

			// Token: 0x04009E55 RID: 40533
			[Token(Token = "0x4009E55")]
			private const int MAX_FRAMES = 3;

			// Token: 0x04009E56 RID: 40534
			[Token(Token = "0x4009E56")]
			private const int FRAME_RATE = 4;

			// Token: 0x04009E57 RID: 40535
			[Token(Token = "0x4009E57")]
			[FieldOffset(Offset = "0x0")]
			public static UnifiedRandom Random;

			// Token: 0x04009E58 RID: 40536
			[Token(Token = "0x4009E58")]
			[FieldOffset(Offset = "0x0")]
			private int _frame;

			// Token: 0x04009E59 RID: 40537
			[Token(Token = "0x4009E59")]
			[FieldOffset(Offset = "0x4")]
			private Texture2D _texture;

			// Token: 0x04009E5A RID: 40538
			[Token(Token = "0x4009E5A")]
			[FieldOffset(Offset = "0x8")]
			private MartianSky.IUfoController _controller;

			// Token: 0x04009E5B RID: 40539
			[Token(Token = "0x4009E5B")]
			[FieldOffset(Offset = "0xC")]
			public Texture2D GlowTexture;

			// Token: 0x04009E5C RID: 40540
			[Token(Token = "0x4009E5C")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 Position;

			// Token: 0x04009E5D RID: 40541
			[Token(Token = "0x4009E5D")]
			[FieldOffset(Offset = "0x18")]
			public int FrameHeight;

			// Token: 0x04009E5E RID: 40542
			[Token(Token = "0x4009E5E")]
			[FieldOffset(Offset = "0x1C")]
			public int FrameWidth;

			// Token: 0x04009E5F RID: 40543
			[Token(Token = "0x4009E5F")]
			[FieldOffset(Offset = "0x20")]
			public float Depth;

			// Token: 0x04009E60 RID: 40544
			[Token(Token = "0x4009E60")]
			[FieldOffset(Offset = "0x24")]
			public float Scale;

			// Token: 0x04009E61 RID: 40545
			[Token(Token = "0x4009E61")]
			[FieldOffset(Offset = "0x28")]
			public float Opacity;

			// Token: 0x04009E62 RID: 40546
			[Token(Token = "0x4009E62")]
			[FieldOffset(Offset = "0x2C")]
			public bool IsActive;

			// Token: 0x04009E63 RID: 40547
			[Token(Token = "0x4009E63")]
			[FieldOffset(Offset = "0x30")]
			public float Rotation;
		}

		// Token: 0x02000C88 RID: 3208
		[Token(Token = "0x2000C88")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005EFE RID: 24318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EFE")]
			[Address(RVA = "0xA86394", Offset = "0xA86394", VA = "0xA86394")]
			public <>c()
			{
			}

			// Token: 0x06005EFF RID: 24319 RVA: 0x0002BF08 File Offset: 0x0002A108
			[Token(Token = "0x6005EFF")]
			[Address(RVA = "0xA8639C", Offset = "0xA8639C", VA = "0xA8639C")]
			internal int <Activate>b__13_0(MartianSky.Ufo ufo1, MartianSky.Ufo ufo2)
			{
				return 0;
			}

			// Token: 0x04009E64 RID: 40548
			[Token(Token = "0x4009E64")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MartianSky.<>c <>9;

			// Token: 0x04009E65 RID: 40549
			[Token(Token = "0x4009E65")]
			[FieldOffset(Offset = "0x4")]
			public static Comparison<MartianSky.Ufo> <>9__13_0;
		}
	}
}
