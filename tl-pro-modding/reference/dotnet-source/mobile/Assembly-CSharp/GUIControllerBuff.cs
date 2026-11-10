using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000095 RID: 149
[Token(Token = "0x2000095")]
public class GUIControllerBuff : FileAPI
{
	// Token: 0x060003DE RID: 990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xC50D58", Offset = "0xC50D58", VA = "0xC50D58", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060003DF RID: 991 RVA: 0x000030C0 File Offset: 0x000012C0
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xC50D64", Offset = "0xC50D64", VA = "0xC50D64", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xC50D6C", Offset = "0xC50D6C", VA = "0xC50D6C")]
	private void Clamp()
	{
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xC50E54", Offset = "0xC50E54", VA = "0xC50E54")]
	public void NavigateNext()
	{
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xC50F4C", Offset = "0xC50F4C", VA = "0xC50F4C")]
	public void NavigatePrevious()
	{
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0xC51000", Offset = "0xC51000", VA = "0xC51000", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x000030D8 File Offset: 0x000012D8
	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xC51040", Offset = "0xC51040", VA = "0xC51040")]
	public int GetSelectedItem()
	{
		return 0;
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x000030F0 File Offset: 0x000012F0
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xC51048", Offset = "0xC51048", VA = "0xC51048", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xC513E4", Offset = "0xC513E4", VA = "0xC513E4")]
	public GUIControllerBuff()
	{
	}

	// Token: 0x040005D6 RID: 1494
	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x8")]
	private int selectedItem;
}
