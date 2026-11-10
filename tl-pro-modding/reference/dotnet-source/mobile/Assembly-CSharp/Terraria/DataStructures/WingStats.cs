using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007D0 RID: 2000
	[Token(Token = "0x20007D0")]
	public struct WingStats
	{
		// Token: 0x060044FF RID: 17663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x55EA74", Offset = "0x55EA74", VA = "0x55EA74")]
		public WingStats(int flyTime = 100, float flySpeedOverride = -1f, float accelerationMultiplier = 1f, bool hasHoldDownHoverFeatures = false, float hoverFlySpeedOverride = -1f, float hoverAccelerationMultiplier = 1f)
		{
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00021060 File Offset: 0x0001F260
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x55EA98", Offset = "0x55EA98", VA = "0x55EA98")]
		public WingStats WithSpeedBoost(float multiplier)
		{
			return default(WingStats);
		}

		// Token: 0x04008C6D RID: 35949
		[Token(Token = "0x4008C6D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly WingStats Default;

		// Token: 0x04008C6E RID: 35950
		[Token(Token = "0x4008C6E")]
		[FieldOffset(Offset = "0x0")]
		public int FlyTime;

		// Token: 0x04008C6F RID: 35951
		[Token(Token = "0x4008C6F")]
		[FieldOffset(Offset = "0x4")]
		public float AccRunSpeedOverride;

		// Token: 0x04008C70 RID: 35952
		[Token(Token = "0x4008C70")]
		[FieldOffset(Offset = "0x8")]
		public float AccRunAccelerationMult;

		// Token: 0x04008C71 RID: 35953
		[Token(Token = "0x4008C71")]
		[FieldOffset(Offset = "0xC")]
		public bool HasDownHoverStats;

		// Token: 0x04008C72 RID: 35954
		[Token(Token = "0x4008C72")]
		[FieldOffset(Offset = "0x10")]
		public float DownHoverSpeedOverride;

		// Token: 0x04008C73 RID: 35955
		[Token(Token = "0x4008C73")]
		[FieldOffset(Offset = "0x14")]
		public float DownHoverAccelerationMult;
	}
}
