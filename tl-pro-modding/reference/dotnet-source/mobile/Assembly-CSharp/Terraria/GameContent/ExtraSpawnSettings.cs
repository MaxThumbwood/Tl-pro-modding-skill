using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x02000972 RID: 2418
	[Token(Token = "0x2000972")]
	public struct ExtraSpawnSettings
	{
		// Token: 0x040093E8 RID: 37864
		[Token(Token = "0x40093E8")]
		[FieldOffset(Offset = "0x0")]
		public ExtraSpawnType spawnType;

		// Token: 0x040093E9 RID: 37865
		[Token(Token = "0x40093E9")]
		[FieldOffset(Offset = "0x4")]
		public bool surface;

		// Token: 0x040093EA RID: 37866
		[Token(Token = "0x40093EA")]
		[FieldOffset(Offset = "0x5")]
		public bool remix;

		// Token: 0x040093EB RID: 37867
		[Token(Token = "0x40093EB")]
		[FieldOffset(Offset = "0x6")]
		public bool roundLandmass;

		// Token: 0x040093EC RID: 37868
		[Token(Token = "0x40093EC")]
		[FieldOffset(Offset = "0x7")]
		public bool skyblock;

		// Token: 0x040093ED RID: 37869
		[Token(Token = "0x40093ED")]
		[FieldOffset(Offset = "0x8")]
		public bool extraLiquid;
	}
}
