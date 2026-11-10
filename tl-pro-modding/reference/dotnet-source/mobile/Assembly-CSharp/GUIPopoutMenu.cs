using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000124 RID: 292
[Token(Token = "0x2000124")]
public static class GUIPopoutMenu
{
	// Token: 0x06000767 RID: 1895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000767")]
	[Address(RVA = "0x166EDF8", Offset = "0x166EDF8", VA = "0x166EDF8")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00004F20 File Offset: 0x00003120
	[Token(Token = "0x6000768")]
	[Address(RVA = "0x166EF38", Offset = "0x166EF38", VA = "0x166EF38")]
	private static int DrawMenu(PopoutMenu_Layout layout, string[] options, ref Rectangle menuRegion)
	{
		return 0;
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00004F38 File Offset: 0x00003138
	[Token(Token = "0x6000769")]
	[Address(RVA = "0x166FBA4", Offset = "0x166FBA4", VA = "0x166FBA4")]
	public static int Draw(PopoutMenu_Layout layout, string[] options, ref bool menuOpen, ref float scale, ref Rectangle menuRegion)
	{
		return 0;
	}

	// Token: 0x0400081E RID: 2078
	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x0")]
	public static Texture2D _menuClosed;

	// Token: 0x0400081F RID: 2079
	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x4")]
	public static Texture2D _menuOpen;
}
