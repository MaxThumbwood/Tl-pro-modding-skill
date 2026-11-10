using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.UI.Chat
{
	// Token: 0x020008A3 RID: 2211
	[Token(Token = "0x20008A3")]
	public struct PositionedSnippet
	{
		// Token: 0x06004B25 RID: 19237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x64CE34", Offset = "0x64CE34", VA = "0x64CE34")]
		public PositionedSnippet(TextSnippet snippet, int origIndex, int line, Vector2 position, Vector2 size)
		{
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x64CE58", Offset = "0x64CE58", VA = "0x64CE58")]
		public void Scale(float scale)
		{
		}

		// Token: 0x04009040 RID: 36928
		[Token(Token = "0x4009040")]
		[FieldOffset(Offset = "0x0")]
		public readonly TextSnippet Snippet;

		// Token: 0x04009041 RID: 36929
		[Token(Token = "0x4009041")]
		[FieldOffset(Offset = "0x4")]
		public readonly int OrigIndex;

		// Token: 0x04009042 RID: 36930
		[Token(Token = "0x4009042")]
		[FieldOffset(Offset = "0x8")]
		public readonly int Line;

		// Token: 0x04009043 RID: 36931
		[Token(Token = "0x4009043")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 Position;

		// Token: 0x04009044 RID: 36932
		[Token(Token = "0x4009044")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 Size;
	}
}
