using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Modules
{
	// Token: 0x02000655 RID: 1621
	[Token(Token = "0x2000655")]
	public class TileObjectCoordinatesModule
	{
		// Token: 0x06003EF5 RID: 16117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF5")]
		[Address(RVA = "0x1E7A02C", Offset = "0x1E7A02C", VA = "0x1E7A02C")]
		public TileObjectCoordinatesModule([Optional] TileObjectCoordinatesModule copyFrom, [Optional] int[] drawHeight, [Optional] Rectangle[,] drawFrameOffs)
		{
		}

		// Token: 0x04004908 RID: 18696
		[Token(Token = "0x4004908")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int width;

		// Token: 0x04004909 RID: 18697
		[Token(Token = "0x4004909")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int[] heights;

		// Token: 0x0400490A RID: 18698
		[Token(Token = "0x400490A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int padding;

		// Token: 0x0400490B RID: 18699
		[Token(Token = "0x400490B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Point16 paddingFix;

		// Token: 0x0400490C RID: 18700
		[Token(Token = "0x400490C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int styleWidth;

		// Token: 0x0400490D RID: 18701
		[Token(Token = "0x400490D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int styleHeight;

		// Token: 0x0400490E RID: 18702
		[Token(Token = "0x400490E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool calculated;

		// Token: 0x0400490F RID: 18703
		[Token(Token = "0x400490F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int drawStyleOffset;

		// Token: 0x04004910 RID: 18704
		[Token(Token = "0x4004910")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rectangle[,] drawFrameOffsets;
	}
}
