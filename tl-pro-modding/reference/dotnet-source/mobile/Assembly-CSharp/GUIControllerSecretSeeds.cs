using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000B5 RID: 181
[Token(Token = "0x20000B5")]
public class GUIControllerSecretSeeds : FileAPI
{
	// Token: 0x0600047E RID: 1150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047E")]
	[Address(RVA = "0xD67E50", Offset = "0xD67E50", VA = "0xD67E50", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00003618 File Offset: 0x00001818
	[Token(Token = "0x600047F")]
	[Address(RVA = "0xD68158", Offset = "0xD68158", VA = "0xD68158", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000480")]
	[Address(RVA = "0xD67E5C", Offset = "0xD67E5C", VA = "0xD67E5C")]
	private void UpdateScroll()
	{
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000481")]
	[Address(RVA = "0xD68160", Offset = "0xD68160", VA = "0xD68160", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00003630 File Offset: 0x00001830
	[Token(Token = "0x6000482")]
	[Address(RVA = "0xD68210", Offset = "0xD68210", VA = "0xD68210", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000483")]
	[Address(RVA = "0xD685A4", Offset = "0xD685A4", VA = "0xD685A4")]
	public GUIControllerSecretSeeds()
	{
	}

	// Token: 0x0400065C RID: 1628
	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x8")]
	public int selectedControl;
}
