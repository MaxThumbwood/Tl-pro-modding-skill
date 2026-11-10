using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000101 RID: 257
[Token(Token = "0x2000101")]
public class GUIPlayerCreateController_Gender : FileAPI
{
	// Token: 0x060006C0 RID: 1728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C0")]
	[Address(RVA = "0xF2A064", Offset = "0xF2A064", VA = "0xF2A064")]
	public GUIPlayerCreateController_Gender(GUIPlayerCreateController controller)
	{
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00004980 File Offset: 0x00002B80
	[Token(Token = "0x60006C1")]
	[Address(RVA = "0xF2A778", Offset = "0xF2A778", VA = "0xF2A778", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C2")]
	[Address(RVA = "0xF2A780", Offset = "0xF2A780", VA = "0xF2A780", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C3")]
	[Address(RVA = "0xF2A864", Offset = "0xF2A864", VA = "0xF2A864", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00004998 File Offset: 0x00002B98
	[Token(Token = "0x60006C4")]
	[Address(RVA = "0xF2AA8C", Offset = "0xF2AA8C", VA = "0xF2AA8C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x04000781 RID: 1921
	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x0")]
	private static int[] actualStyleOrder;

	// Token: 0x04000782 RID: 1922
	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x04000783 RID: 1923
	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0xC")]
	public int selectionIndex;
}
