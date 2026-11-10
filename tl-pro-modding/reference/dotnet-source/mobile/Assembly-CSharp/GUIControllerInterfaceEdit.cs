using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200009E RID: 158
[Token(Token = "0x200009E")]
public class GUIControllerInterfaceEdit : FileAPI
{
	// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000411")]
	[Address(RVA = "0xD5B0AC", Offset = "0xD5B0AC", VA = "0xD5B0AC", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x000032B8 File Offset: 0x000014B8
	[Token(Token = "0x6000412")]
	[Address(RVA = "0xD5B0B8", Offset = "0xD5B0B8", VA = "0xD5B0B8", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000413")]
	[Address(RVA = "0xD5B0C0", Offset = "0xD5B0C0", VA = "0xD5B0C0")]
	public void UpdatePageScroll()
	{
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000414")]
	[Address(RVA = "0xD5B490", Offset = "0xD5B490", VA = "0xD5B490", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x000032D0 File Offset: 0x000014D0
	[Token(Token = "0x6000415")]
	[Address(RVA = "0xD5BEC4", Offset = "0xD5BEC4", VA = "0xD5BEC4", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000416")]
	[Address(RVA = "0xD5C7A8", Offset = "0xD5C7A8", VA = "0xD5C7A8")]
	public GUIControllerInterfaceEdit()
	{
	}

	// Token: 0x040005EC RID: 1516
	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0x8")]
	public int EditControl;

	// Token: 0x040005ED RID: 1517
	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0xC")]
	private int EditProfile;

	// Token: 0x040005EE RID: 1518
	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0x10")]
	private int EditTemplate;

	// Token: 0x040005EF RID: 1519
	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0x14")]
	public int AdjustColumn;

	// Token: 0x040005F0 RID: 1520
	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0x18")]
	public int AdjustRow;

	// Token: 0x040005F1 RID: 1521
	[Token(Token = "0x40005F1")]
	[FieldOffset(Offset = "0x1C")]
	public int PageColumn;

	// Token: 0x040005F2 RID: 1522
	[Token(Token = "0x40005F2")]
	[FieldOffset(Offset = "0x20")]
	public int PageRow;
}
