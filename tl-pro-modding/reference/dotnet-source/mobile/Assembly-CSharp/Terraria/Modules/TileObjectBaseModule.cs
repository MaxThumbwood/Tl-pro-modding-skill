using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.DataStructures;
using Terraria.Enums;

namespace Terraria.Modules
{
	// Token: 0x02000654 RID: 1620
	[Token(Token = "0x2000654")]
	public class TileObjectBaseModule
	{
		// Token: 0x06003EF4 RID: 16116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF4")]
		[Address(RVA = "0x1E79EEC", Offset = "0x1E79EEC", VA = "0x1E79EEC")]
		public TileObjectBaseModule([Optional] TileObjectBaseModule copyFrom)
		{
		}

		// Token: 0x04004901 RID: 18689
		[Token(Token = "0x4004901")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int width;

		// Token: 0x04004902 RID: 18690
		[Token(Token = "0x4004902")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int height;

		// Token: 0x04004903 RID: 18691
		[Token(Token = "0x4004903")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Point16 origin;

		// Token: 0x04004904 RID: 18692
		[Token(Token = "0x4004904")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TileObjectDirection direction;

		// Token: 0x04004905 RID: 18693
		[Token(Token = "0x4004905")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int randomRange;

		// Token: 0x04004906 RID: 18694
		[Token(Token = "0x4004906")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool flattenAnchors;

		// Token: 0x04004907 RID: 18695
		[Token(Token = "0x4004907")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] specificRandomStyles;
	}
}
