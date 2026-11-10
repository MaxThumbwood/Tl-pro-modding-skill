using System;
using Il2CppDummyDll;

namespace Terraria.Physics
{
	// Token: 0x02000647 RID: 1607
	[Token(Token = "0x2000647")]
	public struct BallPassThroughEvent
	{
		// Token: 0x06003E55 RID: 15957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x1E6ADC4", Offset = "0x1E6ADC4", VA = "0x1E6ADC4")]
		public BallPassThroughEvent(float timeScale, Tile tile, Entity entity, BallPassThroughType type)
		{
		}

		// Token: 0x040048A7 RID: 18599
		[Token(Token = "0x40048A7")]
		[FieldOffset(Offset = "0x0")]
		public readonly Tile Tile;

		// Token: 0x040048A8 RID: 18600
		[Token(Token = "0x40048A8")]
		[FieldOffset(Offset = "0x4")]
		public readonly Entity Entity;

		// Token: 0x040048A9 RID: 18601
		[Token(Token = "0x40048A9")]
		[FieldOffset(Offset = "0x8")]
		public readonly BallPassThroughType Type;

		// Token: 0x040048AA RID: 18602
		[Token(Token = "0x40048AA")]
		[FieldOffset(Offset = "0xC")]
		public readonly float TimeScale;
	}
}
