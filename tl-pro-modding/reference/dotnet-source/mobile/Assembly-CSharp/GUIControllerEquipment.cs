using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000D7 RID: 215
[Token(Token = "0x20000D7")]
public class GUIControllerEquipment : GUIPageContentController
{
	// Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000566")]
	[Address(RVA = "0xE6194C", Offset = "0xE6194C", VA = "0xE6194C")]
	public GUIControllerEquipment()
	{
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000567")]
	[Address(RVA = "0xE61958", Offset = "0xE61958", VA = "0xE61958", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000568")]
	[Address(RVA = "0xE6195C", Offset = "0xE6195C", VA = "0xE6195C", Slot = "14")]
	public virtual void NavigateInto(Vector2 source, Vector2 navigationVector)
	{
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000569")]
	[Address(RVA = "0xE61960", Offset = "0xE61960", VA = "0xE61960", Slot = "15")]
	public virtual void ClampAccessories()
	{
	}

	// Token: 0x04000706 RID: 1798
	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x04000707 RID: 1799
	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x18")]
	public int itemColumn;

	// Token: 0x04000708 RID: 1800
	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x1C")]
	public bool inAccessories;

	// Token: 0x04000709 RID: 1801
	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x1D")]
	public bool inLoadout;
}
