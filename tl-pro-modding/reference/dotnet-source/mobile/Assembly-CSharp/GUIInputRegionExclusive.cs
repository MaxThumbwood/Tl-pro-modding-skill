using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000192 RID: 402
[Token(Token = "0x2000192")]
public class GUIInputRegionExclusive
{
	// Token: 0x06000BE1 RID: 3041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0xC545D8", Offset = "0xC545D8", VA = "0xC545D8")]
	public GUIInputRegionExclusive(GUIInputRegionExclusive.IsOverHandler handler)
	{
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x00006D38 File Offset: 0x00004F38
	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0xC545F4", Offset = "0xC545F4", VA = "0xC545F4")]
	public bool Over(int x, int y)
	{
		return default(bool);
	}

	// Token: 0x04000E92 RID: 3730
	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x8")]
	public readonly GUIInputRegionExclusive.IsOverHandler isOver;

	// Token: 0x04000E93 RID: 3731
	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0xC")]
	public bool Active;

	// Token: 0x02000193 RID: 403
	// (Invoke) Token: 0x06000BE4 RID: 3044
	[Token(Token = "0x2000193")]
	public delegate bool IsOverHandler(Vector2 cursorPosition);
}
