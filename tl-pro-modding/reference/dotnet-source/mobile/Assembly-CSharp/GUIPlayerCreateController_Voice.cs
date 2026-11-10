using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000107 RID: 263
[Token(Token = "0x2000107")]
public class GUIPlayerCreateController_Voice : FileAPI
{
	// Token: 0x060006E7 RID: 1767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0xF2A048", Offset = "0xF2A048", VA = "0xF2A048")]
	public GUIPlayerCreateController_Voice(GUIPlayerCreateController controller)
	{
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E8")]
	[Address(RVA = "0xF2C8EC", Offset = "0xF2C8EC", VA = "0xF2C8EC", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00004AB8 File Offset: 0x00002CB8
	[Token(Token = "0x60006E9")]
	[Address(RVA = "0xF2CCD8", Offset = "0xF2CCD8", VA = "0xF2CCD8", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EA")]
	[Address(RVA = "0xF2CCE0", Offset = "0xF2CCE0", VA = "0xF2CCE0", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EB")]
	[Address(RVA = "0xF2CCCC", Offset = "0xF2CCCC", VA = "0xF2CCCC")]
	public void ActivateOptions(int selectedOption)
	{
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0xF2CE00", Offset = "0xF2CE00", VA = "0xF2CE00")]
	public void DeactivateOptions()
	{
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006ED")]
	[Address(RVA = "0xF2CE0C", Offset = "0xF2CE0C", VA = "0xF2CE0C")]
	public void ActivateName()
	{
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EE")]
	[Address(RVA = "0xF2CE18", Offset = "0xF2CE18", VA = "0xF2CE18")]
	public void DeactivateName()
	{
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00004AD0 File Offset: 0x00002CD0
	[Token(Token = "0x60006EF")]
	[Address(RVA = "0xF2CE24", Offset = "0xF2CE24", VA = "0xF2CE24", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x04000791 RID: 1937
	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x04000792 RID: 1938
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0xC")]
	public int element;
}
