using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000EA RID: 234
[Token(Token = "0x20000EA")]
public class GUIControllerReforgePopup : FileAPI
{
	// Token: 0x0600060E RID: 1550 RVA: 0x000043B0 File Offset: 0x000025B0
	[Token(Token = "0x600060E")]
	[Address(RVA = "0xE6C130", Offset = "0xE6C130", VA = "0xE6C130", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060F")]
	[Address(RVA = "0xE6C138", Offset = "0xE6C138", VA = "0xE6C138", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000610")]
	[Address(RVA = "0xE6C144", Offset = "0xE6C144", VA = "0xE6C144", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x000043C8 File Offset: 0x000025C8
	[Token(Token = "0x6000611")]
	[Address(RVA = "0xE6C174", Offset = "0xE6C174", VA = "0xE6C174", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000612")]
	[Address(RVA = "0xE6C2AC", Offset = "0xE6C2AC", VA = "0xE6C2AC")]
	public GUIControllerReforgePopup()
	{
	}

	// Token: 0x0400074B RID: 1867
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x8")]
	public GUIControllerReforgePopup.Controls selectedControl;

	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	public enum Controls
	{
		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		Reforge,
		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		Back
	}
}
