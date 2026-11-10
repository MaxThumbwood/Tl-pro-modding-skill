using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20004C4")]
	public class Gore
	{
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x00017358 File Offset: 0x00015558
		[Token(Token = "0x17000633")]
		public float Width
		{
			[Token(Token = "0x6002FC7")]
			[Address(RVA = "0x18A33B4", Offset = "0x18A33B4", VA = "0x18A33B4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002FC8 RID: 12232 RVA: 0x00017370 File Offset: 0x00015570
		[Token(Token = "0x17000634")]
		public float Height
		{
			[Token(Token = "0x6002FC8")]
			[Address(RVA = "0x18A34F8", Offset = "0x18A34F8", VA = "0x18A34F8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x00017388 File Offset: 0x00015588
		[Token(Token = "0x17000635")]
		public Rectangle AABBRectangle
		{
			[Token(Token = "0x6002FC9")]
			[Address(RVA = "0x18A363C", Offset = "0x18A363C", VA = "0x18A363C")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002FCA RID: 12234 RVA: 0x000173A0 File Offset: 0x000155A0
		// (set) Token: 0x06002FCB RID: 12235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000636")]
		public byte frame
		{
			[Token(Token = "0x6002FCA")]
			[Address(RVA = "0x18A3824", Offset = "0x18A3824", VA = "0x18A3824")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002FCB")]
			[Address(RVA = "0x18A382C", Offset = "0x18A382C", VA = "0x18A382C")]
			set
			{
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002FCC RID: 12236 RVA: 0x000173B8 File Offset: 0x000155B8
		// (set) Token: 0x06002FCD RID: 12237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000637")]
		public byte numFrames
		{
			[Token(Token = "0x6002FCC")]
			[Address(RVA = "0x18A3834", Offset = "0x18A3834", VA = "0x18A3834")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002FCD")]
			[Address(RVA = "0x18A383C", Offset = "0x18A383C", VA = "0x18A383C")]
			set
			{
			}
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x18A3894", Offset = "0x18A3894", VA = "0x18A3894")]
		private void UpdateAmbientFloorCloud()
		{
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0x18A3C88", Offset = "0x18A3C88", VA = "0x18A3C88")]
		private void UpdateAmbientAirborneCloud()
		{
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD0")]
		[Address(RVA = "0x18A3FC8", Offset = "0x18A3FC8", VA = "0x18A3FC8")]
		private void UpdateFogMachineCloud()
		{
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0x18A42F4", Offset = "0x18A42F4", VA = "0x18A42F4")]
		private void UpdateLightningBunnySparks()
		{
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x000173D0 File Offset: 0x000155D0
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x18A45A4", Offset = "0x18A45A4", VA = "0x18A45A4")]
		private float ChumFloatingChunk_GetWaterLine(int X, int Y)
		{
			return 0f;
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x000173E8 File Offset: 0x000155E8
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x18A497C", Offset = "0x18A497C", VA = "0x18A497C")]
		private bool DeactivateIfOutsideOfWorld()
		{
			return default(bool);
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD4")]
		[Address(RVA = "0x18A4AC0", Offset = "0x18A4AC0", VA = "0x18A4AC0")]
		public void Update()
		{
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x18A9FC0", Offset = "0x18A9FC0", VA = "0x18A9FC0")]
		private void Gore_UpdateLeaf()
		{
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x18A9728", Offset = "0x18A9728", VA = "0x18A9728")]
		private void Gore_UpdateSail()
		{
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x18AB470", Offset = "0x18AB470", VA = "0x18AB470")]
		public static Gore NewGorePerfect(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
		{
			return null;
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD8")]
		[Address(RVA = "0x18A9630", Offset = "0x18A9630", VA = "0x18A9630")]
		public static Gore NewGoreDirect(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
		{
			return null;
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00017400 File Offset: 0x00015600
		[Token(Token = "0x6002FD9")]
		[Address(RVA = "0x18999B0", Offset = "0x18999B0", VA = "0x18999B0")]
		public static int NewGore(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
		{
			return 0;
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00017418 File Offset: 0x00015618
		[Token(Token = "0x6002FDA")]
		[Address(RVA = "0x18AB548", Offset = "0x18AB548", VA = "0x18AB548")]
		public Color GetAlpha(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x18AB730", Offset = "0x18AB730", VA = "0x18AB730")]
		public Gore()
		{
		}

		// Token: 0x04003F5C RID: 16220
		[Token(Token = "0x4003F5C")]
		[FieldOffset(Offset = "0x0")]
		public static int goreTime;

		// Token: 0x04003F5D RID: 16221
		[Token(Token = "0x4003F5D")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 position;

		// Token: 0x04003F5E RID: 16222
		[Token(Token = "0x4003F5E")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 velocity;

		// Token: 0x04003F5F RID: 16223
		[Token(Token = "0x4003F5F")]
		[FieldOffset(Offset = "0x18")]
		public float rotation;

		// Token: 0x04003F60 RID: 16224
		[Token(Token = "0x4003F60")]
		[FieldOffset(Offset = "0x1C")]
		public float scale;

		// Token: 0x04003F61 RID: 16225
		[Token(Token = "0x4003F61")]
		[FieldOffset(Offset = "0x20")]
		public int alpha;

		// Token: 0x04003F62 RID: 16226
		[Token(Token = "0x4003F62")]
		[FieldOffset(Offset = "0x24")]
		public int type;

		// Token: 0x04003F63 RID: 16227
		[Token(Token = "0x4003F63")]
		[FieldOffset(Offset = "0x28")]
		public float light;

		// Token: 0x04003F64 RID: 16228
		[Token(Token = "0x4003F64")]
		[FieldOffset(Offset = "0x2C")]
		public bool active;

		// Token: 0x04003F65 RID: 16229
		[Token(Token = "0x4003F65")]
		[FieldOffset(Offset = "0x2D")]
		public bool sticky;

		// Token: 0x04003F66 RID: 16230
		[Token(Token = "0x4003F66")]
		[FieldOffset(Offset = "0x30")]
		public int timeLeft;

		// Token: 0x04003F67 RID: 16231
		[Token(Token = "0x4003F67")]
		[FieldOffset(Offset = "0x34")]
		public bool behindTiles;

		// Token: 0x04003F68 RID: 16232
		[Token(Token = "0x4003F68")]
		[FieldOffset(Offset = "0x35")]
		public byte frameCounter;

		// Token: 0x04003F69 RID: 16233
		[Token(Token = "0x4003F69")]
		[FieldOffset(Offset = "0x38")]
		public SpriteFrame Frame;

		// Token: 0x04003F6A RID: 16234
		[Token(Token = "0x4003F6A")]
		[FieldOffset(Offset = "0x44")]
		public int PlayerOnly;
	}
}
