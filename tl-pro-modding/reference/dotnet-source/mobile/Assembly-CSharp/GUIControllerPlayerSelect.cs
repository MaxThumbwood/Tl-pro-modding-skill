using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000AF RID: 175
[Token(Token = "0x20000AF")]
public class GUIControllerPlayerSelect : FileAPI
{
	// Token: 0x0600045F RID: 1119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045F")]
	[Address(RVA = "0xD64C80", Offset = "0xD64C80", VA = "0xD64C80", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00003528 File Offset: 0x00001728
	[Token(Token = "0x6000460")]
	[Address(RVA = "0xD65224", Offset = "0xD65224", VA = "0xD65224", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000461")]
	[Address(RVA = "0xD64DC8", Offset = "0xD64DC8", VA = "0xD64DC8")]
	private void UpdateScroll()
	{
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000462")]
	[Address(RVA = "0xD6522C", Offset = "0xD6522C", VA = "0xD6522C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00003540 File Offset: 0x00001740
	[Token(Token = "0x6000463")]
	[Address(RVA = "0xD6552C", Offset = "0xD6552C", VA = "0xD6552C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000464")]
	[Address(RVA = "0xD656D4", Offset = "0xD656D4", VA = "0xD656D4")]
	public GUIControllerPlayerSelect()
	{
	}

	// Token: 0x0400064C RID: 1612
	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x8")]
	public int selectedControl;

	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	public enum Controls
	{
		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		Back,
		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		Delete,
		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		Favourite,
		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		EditName,
		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		Play,
		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		New
	}
}
