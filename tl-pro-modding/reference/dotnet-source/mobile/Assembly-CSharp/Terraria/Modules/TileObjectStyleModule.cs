using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Modules
{
	// Token: 0x02000657 RID: 1623
	[Token(Token = "0x2000657")]
	public class TileObjectStyleModule
	{
		// Token: 0x06003EF7 RID: 16119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF7")]
		[Address(RVA = "0x1E7A2DC", Offset = "0x1E7A2DC", VA = "0x1E7A2DC")]
		public TileObjectStyleModule([Optional] TileObjectStyleModule copyFrom)
		{
		}

		// Token: 0x04004916 RID: 18710
		[Token(Token = "0x4004916")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int style;

		// Token: 0x04004917 RID: 18711
		[Token(Token = "0x4004917")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool horizontal;

		// Token: 0x04004918 RID: 18712
		[Token(Token = "0x4004918")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int styleWrapLimit;

		// Token: 0x04004919 RID: 18713
		[Token(Token = "0x4004919")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int styleMultiplier;

		// Token: 0x0400491A RID: 18714
		[Token(Token = "0x400491A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int styleLineSkip;

		// Token: 0x0400491B RID: 18715
		[Token(Token = "0x400491B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int? styleWrapLimitVisualOverride;

		// Token: 0x0400491C RID: 18716
		[Token(Token = "0x400491C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int? styleLineSkipVisualoverride;
	}
}
