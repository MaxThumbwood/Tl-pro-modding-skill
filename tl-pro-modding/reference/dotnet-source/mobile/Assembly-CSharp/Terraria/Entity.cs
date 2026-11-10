using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x20004BE")]
	public abstract class Entity : FileAPI
	{
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x000170E8 File Offset: 0x000152E8
		[Token(Token = "0x17000626")]
		public bool AnyWet
		{
			[Token(Token = "0x6002F8D")]
			[Address(RVA = "0x189D868", Offset = "0x189D868", VA = "0x189D868")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x00017100 File Offset: 0x00015300
		[Token(Token = "0x17000627")]
		public virtual Vector2 VisualPosition
		{
			[Token(Token = "0x6002F8E")]
			[Address(RVA = "0x189D8A4", Offset = "0x189D8A4", VA = "0x189D8A4", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00017118 File Offset: 0x00015318
		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x189D8B8", Offset = "0x189D8B8", VA = "0x189D8B8")]
		public float AngleTo(Vector2 Destination)
		{
			return 0f;
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00017130 File Offset: 0x00015330
		[Token(Token = "0x6002F90")]
		[Address(RVA = "0x189DA2C", Offset = "0x189DA2C", VA = "0x189DA2C")]
		public float AngleFrom(Vector2 Source)
		{
			return 0f;
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00017148 File Offset: 0x00015348
		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x189DB58", Offset = "0x189DB58", VA = "0x189DB58")]
		public float Distance(Vector2 Other)
		{
			return 0f;
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00017160 File Offset: 0x00015360
		[Token(Token = "0x6002F92")]
		[Address(RVA = "0x189DC28", Offset = "0x189DC28", VA = "0x189DC28")]
		public float DistanceSQ(Vector2 Other)
		{
			return 0f;
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x00017178 File Offset: 0x00015378
		[Token(Token = "0x6002F93")]
		[Address(RVA = "0x189DCF8", Offset = "0x189DCF8", VA = "0x189DCF8")]
		public Vector2 DirectionTo(Vector2 Destination)
		{
			return default(Vector2);
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x00017190 File Offset: 0x00015390
		[Token(Token = "0x6002F94")]
		[Address(RVA = "0x189DDF0", Offset = "0x189DDF0", VA = "0x189DDF0")]
		public Vector2 DirectionFrom(Vector2 Source)
		{
			return default(Vector2);
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x000171A8 File Offset: 0x000153A8
		[Token(Token = "0x6002F95")]
		[Address(RVA = "0x189DEE8", Offset = "0x189DEE8", VA = "0x189DEE8")]
		public bool WithinRange(Vector2 Target, float MaxRange)
		{
			return default(bool);
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x000171C0 File Offset: 0x000153C0
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000628")]
		public Vector2 Center
		{
			[Token(Token = "0x6002F96")]
			[Address(RVA = "0x189D9E4", Offset = "0x189D9E4", VA = "0x189D9E4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002F97")]
			[Address(RVA = "0x189DFE0", Offset = "0x189DFE0", VA = "0x189DFE0")]
			set
			{
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000171D8 File Offset: 0x000153D8
		// (set) Token: 0x06002F99 RID: 12185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000629")]
		public Vector2 Left
		{
			[Token(Token = "0x6002F98")]
			[Address(RVA = "0x189E044", Offset = "0x189E044", VA = "0x189E044")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002F99")]
			[Address(RVA = "0x189E07C", Offset = "0x189E07C", VA = "0x189E07C")]
			set
			{
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x000171F0 File Offset: 0x000153F0
		// (set) Token: 0x06002F9B RID: 12187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062A")]
		public Vector2 Right
		{
			[Token(Token = "0x6002F9A")]
			[Address(RVA = "0x189E0CC", Offset = "0x189E0CC", VA = "0x189E0CC")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002F9B")]
			[Address(RVA = "0x189E114", Offset = "0x189E114", VA = "0x189E114")]
			set
			{
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x00017208 File Offset: 0x00015408
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062B")]
		public Vector2 Top
		{
			[Token(Token = "0x6002F9C")]
			[Address(RVA = "0x189E178", Offset = "0x189E178", VA = "0x189E178")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002F9D")]
			[Address(RVA = "0x189E1B4", Offset = "0x189E1B4", VA = "0x189E1B4")]
			set
			{
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x00017220 File Offset: 0x00015420
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062C")]
		public Vector2 TopLeft
		{
			[Token(Token = "0x6002F9E")]
			[Address(RVA = "0x189E204", Offset = "0x189E204", VA = "0x189E204")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002F9F")]
			[Address(RVA = "0x189E218", Offset = "0x189E218", VA = "0x189E218")]
			set
			{
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x00017238 File Offset: 0x00015438
		// (set) Token: 0x06002FA1 RID: 12193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062D")]
		public Vector2 TopRight
		{
			[Token(Token = "0x6002FA0")]
			[Address(RVA = "0x189E224", Offset = "0x189E224", VA = "0x189E224")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002FA1")]
			[Address(RVA = "0x189E25C", Offset = "0x189E25C", VA = "0x189E25C")]
			set
			{
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x00017250 File Offset: 0x00015450
		// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062E")]
		public Vector2 Bottom
		{
			[Token(Token = "0x6002FA2")]
			[Address(RVA = "0x189E2A8", Offset = "0x189E2A8", VA = "0x189E2A8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002FA3")]
			[Address(RVA = "0x189E2F0", Offset = "0x189E2F0", VA = "0x189E2F0")]
			set
			{
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x00017268 File Offset: 0x00015468
		// (set) Token: 0x06002FA5 RID: 12197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062F")]
		public Vector2 BottomLeft
		{
			[Token(Token = "0x6002FA4")]
			[Address(RVA = "0x189E354", Offset = "0x189E354", VA = "0x189E354")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002FA5")]
			[Address(RVA = "0x189E388", Offset = "0x189E388", VA = "0x189E388")]
			set
			{
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x00017280 File Offset: 0x00015480
		// (set) Token: 0x06002FA7 RID: 12199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000630")]
		public Vector2 BottomRight
		{
			[Token(Token = "0x6002FA6")]
			[Address(RVA = "0x189E3D4", Offset = "0x189E3D4", VA = "0x189E3D4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002FA7")]
			[Address(RVA = "0x189E418", Offset = "0x189E418", VA = "0x189E418")]
			set
			{
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x00017298 File Offset: 0x00015498
		// (set) Token: 0x06002FA9 RID: 12201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000631")]
		public Vector2 Size
		{
			[Token(Token = "0x6002FA8")]
			[Address(RVA = "0x189E478", Offset = "0x189E478", VA = "0x189E478")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002FA9")]
			[Address(RVA = "0x189E4AC", Offset = "0x189E4AC", VA = "0x189E4AC")]
			set
			{
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x000172B0 File Offset: 0x000154B0
		// (set) Token: 0x06002FAB RID: 12203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000632")]
		public Rectangle Hitbox
		{
			[Token(Token = "0x6002FAA")]
			[Address(RVA = "0x1897BCC", Offset = "0x1897BCC", VA = "0x1897BCC")]
			get
			{
				return default(Rectangle);
			}
			[Token(Token = "0x6002FAB")]
			[Address(RVA = "0x189E4F0", Offset = "0x189E4F0", VA = "0x189E4F0")]
			set
			{
			}
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0x189E550", Offset = "0x189E550", VA = "0x189E550")]
		protected Entity()
		{
		}

		// Token: 0x04003F2C RID: 16172
		[Token(Token = "0x4003F2C")]
		[FieldOffset(Offset = "0x8")]
		public int whoAmI;

		// Token: 0x04003F2D RID: 16173
		[Token(Token = "0x4003F2D")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 position;

		// Token: 0x04003F2E RID: 16174
		[Token(Token = "0x4003F2E")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 velocity;

		// Token: 0x04003F2F RID: 16175
		[Token(Token = "0x4003F2F")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 oldPosition;

		// Token: 0x04003F30 RID: 16176
		[Token(Token = "0x4003F30")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 oldVelocity;

		// Token: 0x04003F31 RID: 16177
		[Token(Token = "0x4003F31")]
		[FieldOffset(Offset = "0x2C")]
		public int oldDirection;

		// Token: 0x04003F32 RID: 16178
		[Token(Token = "0x4003F32")]
		[FieldOffset(Offset = "0x30")]
		public int direction;

		// Token: 0x04003F33 RID: 16179
		[Token(Token = "0x4003F33")]
		[FieldOffset(Offset = "0x34")]
		public int width;

		// Token: 0x04003F34 RID: 16180
		[Token(Token = "0x4003F34")]
		[FieldOffset(Offset = "0x38")]
		public int height;

		// Token: 0x04003F35 RID: 16181
		[Token(Token = "0x4003F35")]
		[FieldOffset(Offset = "0x3C")]
		public bool wet;

		// Token: 0x04003F36 RID: 16182
		[Token(Token = "0x4003F36")]
		[FieldOffset(Offset = "0x3D")]
		public bool shimmerWet;

		// Token: 0x04003F37 RID: 16183
		[Token(Token = "0x4003F37")]
		[FieldOffset(Offset = "0x3E")]
		public bool honeyWet;

		// Token: 0x04003F38 RID: 16184
		[Token(Token = "0x4003F38")]
		[FieldOffset(Offset = "0x3F")]
		public byte wetCount;

		// Token: 0x04003F39 RID: 16185
		[Token(Token = "0x4003F39")]
		[FieldOffset(Offset = "0x40")]
		public bool lavaWet;
	}
}
