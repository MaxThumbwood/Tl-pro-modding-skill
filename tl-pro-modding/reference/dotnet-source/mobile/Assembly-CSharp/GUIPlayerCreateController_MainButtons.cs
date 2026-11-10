using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000105 RID: 261
[Token(Token = "0x2000105")]
public class GUIPlayerCreateController_MainButtons : FileAPI
{
	// Token: 0x060006DB RID: 1755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DB")]
	[Address(RVA = "0xF29FF4", Offset = "0xF29FF4", VA = "0xF29FF4")]
	public GUIPlayerCreateController_MainButtons(GUIPlayerCreateController controller)
	{
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DC")]
	[Address(RVA = "0xF2AA80", Offset = "0xF2AA80", VA = "0xF2AA80", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00004A58 File Offset: 0x00002C58
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0xF2C300", Offset = "0xF2C300", VA = "0xF2C300", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0xF2C308", Offset = "0xF2C308", VA = "0xF2C308")]
	public GUIControllerItem NavigateIntoCurrentPage()
	{
		return null;
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0xF2C784", Offset = "0xF2C784", VA = "0xF2C784", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00004A70 File Offset: 0x00002C70
	[Token(Token = "0x60006E0")]
	[Address(RVA = "0xF2C7E0", Offset = "0xF2C7E0", VA = "0xF2C7E0", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0400078D RID: 1933
	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x0400078E RID: 1934
	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0xC")]
	public int element;
}
