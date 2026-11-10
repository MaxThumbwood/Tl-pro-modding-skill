using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Modules
{
	// Token: 0x02000656 RID: 1622
	[Token(Token = "0x2000656")]
	public class TileObjectDrawModule
	{
		// Token: 0x06003EF6 RID: 16118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF6")]
		[Address(RVA = "0x1E7A27C", Offset = "0x1E7A27C", VA = "0x1E7A27C")]
		public TileObjectDrawModule([Optional] TileObjectDrawModule copyFrom)
		{
		}

		// Token: 0x04004911 RID: 18705
		[Token(Token = "0x4004911")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int xOffset;

		// Token: 0x04004912 RID: 18706
		[Token(Token = "0x4004912")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int yOffset;

		// Token: 0x04004913 RID: 18707
		[Token(Token = "0x4004913")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool flipHorizontal;

		// Token: 0x04004914 RID: 18708
		[Token(Token = "0x4004914")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool flipVertical;

		// Token: 0x04004915 RID: 18709
		[Token(Token = "0x4004915")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int stepDown;
	}
}
