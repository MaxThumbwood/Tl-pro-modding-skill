using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000BB RID: 187
[Token(Token = "0x20000BB")]
public class GUIControllerWorldSelect : FileAPI
{
	// Token: 0x06000499 RID: 1177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000499")]
	[Address(RVA = "0xD69F54", Offset = "0xD69F54", VA = "0xD69F54", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x000036F0 File Offset: 0x000018F0
	[Token(Token = "0x600049A")]
	[Address(RVA = "0xD6A504", Offset = "0xD6A504", VA = "0xD6A504", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049B")]
	[Address(RVA = "0xD6A09C", Offset = "0xD6A09C", VA = "0xD6A09C")]
	private void UpdateScroll()
	{
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049C")]
	[Address(RVA = "0xD6A50C", Offset = "0xD6A50C", VA = "0xD6A50C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00003708 File Offset: 0x00001908
	[Token(Token = "0x600049D")]
	[Address(RVA = "0xD6A80C", Offset = "0xD6A80C", VA = "0xD6A80C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049E")]
	[Address(RVA = "0xD6A9E4", Offset = "0xD6A9E4", VA = "0xD6A9E4")]
	public GUIControllerWorldSelect()
	{
	}

	// Token: 0x04000677 RID: 1655
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x8")]
	public int selectedControl;

	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	public enum Controls
	{
		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		Back,
		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		Delete,
		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		Favourite,
		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		Rename,
		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		SeedDisplay,
		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		Play,
		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		New
	}
}
