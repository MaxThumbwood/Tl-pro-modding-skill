using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020008BF RID: 2239
	[Token(Token = "0x20008BF")]
	public class GameShaders
	{
		// Token: 0x06004BBC RID: 19388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBC")]
		[Address(RVA = "0x6E3FD0", Offset = "0x6E3FD0", VA = "0x6E3FD0")]
		public GameShaders()
		{
		}

		// Token: 0x040090B8 RID: 37048
		[Token(Token = "0x40090B8")]
		[FieldOffset(Offset = "0x0")]
		public static ArmorShaderDataSet Armor;

		// Token: 0x040090B9 RID: 37049
		[Token(Token = "0x40090B9")]
		[FieldOffset(Offset = "0x4")]
		public static HairShaderDataSet Hair;

		// Token: 0x040090BA RID: 37050
		[Token(Token = "0x40090BA")]
		[FieldOffset(Offset = "0x8")]
		public static Dictionary<string, MiscShaderData> Misc;
	}
}
