using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x02000837 RID: 2103
	[Token(Token = "0x2000837")]
	public struct CalculatedStyle
	{
		// Token: 0x060048CE RID: 18638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048CE")]
		[Address(RVA = "0x5E987C", Offset = "0x5E987C", VA = "0x5E987C")]
		public CalculatedStyle(float x, float y, float width, float height)
		{
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x00022B30 File Offset: 0x00020D30
		[Token(Token = "0x60048CF")]
		[Address(RVA = "0x5E9888", Offset = "0x5E9888", VA = "0x5E9888")]
		public Rectangle ToRectangle()
		{
			return default(Rectangle);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x00022B48 File Offset: 0x00020D48
		[Token(Token = "0x60048D0")]
		[Address(RVA = "0x5E9918", Offset = "0x5E9918", VA = "0x5E9918")]
		public Vector2 Position()
		{
			return default(Vector2);
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00022B60 File Offset: 0x00020D60
		[Token(Token = "0x60048D1")]
		[Address(RVA = "0x5E9940", Offset = "0x5E9940", VA = "0x5E9940")]
		public Vector2 Center()
		{
			return default(Vector2);
		}

		// Token: 0x04008EE9 RID: 36585
		[Token(Token = "0x4008EE9")]
		[FieldOffset(Offset = "0x0")]
		public float X;

		// Token: 0x04008EEA RID: 36586
		[Token(Token = "0x4008EEA")]
		[FieldOffset(Offset = "0x4")]
		public float Y;

		// Token: 0x04008EEB RID: 36587
		[Token(Token = "0x4008EEB")]
		[FieldOffset(Offset = "0x8")]
		public float Width;

		// Token: 0x04008EEC RID: 36588
		[Token(Token = "0x4008EEC")]
		[FieldOffset(Offset = "0xC")]
		public float Height;
	}
}
