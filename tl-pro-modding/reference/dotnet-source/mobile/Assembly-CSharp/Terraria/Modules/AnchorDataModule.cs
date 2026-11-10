using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.Modules
{
	// Token: 0x0200064F RID: 1615
	[Token(Token = "0x200064F")]
	public class AnchorDataModule
	{
		// Token: 0x06003EEF RID: 16111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x1E79A10", Offset = "0x1E79A10", VA = "0x1E79A10")]
		public AnchorDataModule([Optional] AnchorDataModule copyFrom)
		{
		}

		// Token: 0x040048F3 RID: 18675
		[Token(Token = "0x40048F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AnchorData top;

		// Token: 0x040048F4 RID: 18676
		[Token(Token = "0x40048F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AnchorData bottom;

		// Token: 0x040048F5 RID: 18677
		[Token(Token = "0x40048F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnchorData left;

		// Token: 0x040048F6 RID: 18678
		[Token(Token = "0x40048F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AnchorData right;

		// Token: 0x040048F7 RID: 18679
		[Token(Token = "0x40048F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool wall;
	}
}
