using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200009C RID: 156
[Token(Token = "0x200009C")]
public class GUIControllerHotbarRadial : FileAPI
{
	// Token: 0x06000409 RID: 1033 RVA: 0x00003258 File Offset: 0x00001458
	[Token(Token = "0x6000409")]
	[Address(RVA = "0xC53074", Offset = "0xC53074", VA = "0xC53074", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040A")]
	[Address(RVA = "0xC5307C", Offset = "0xC5307C", VA = "0xC5307C", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600040B")]
	[Address(RVA = "0xC53398", Offset = "0xC53398", VA = "0xC53398", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00003270 File Offset: 0x00001470
	[Token(Token = "0x600040C")]
	[Address(RVA = "0xC53788", Offset = "0xC53788", VA = "0xC53788")]
	public int GetSelectedItem()
	{
		return 0;
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00003288 File Offset: 0x00001488
	[Token(Token = "0x600040D")]
	[Address(RVA = "0xC5389C", Offset = "0xC5389C", VA = "0xC5389C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040E")]
	[Address(RVA = "0xC53FBC", Offset = "0xC53FBC", VA = "0xC53FBC")]
	public GUIControllerHotbarRadial()
	{
	}

	// Token: 0x040005E9 RID: 1513
	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0x8")]
	private bool hotbarMode;

	// Token: 0x040005EA RID: 1514
	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0xC")]
	private int selectedRow;

	// Token: 0x040005EB RID: 1515
	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x10")]
	private int selectedColumn;
}
