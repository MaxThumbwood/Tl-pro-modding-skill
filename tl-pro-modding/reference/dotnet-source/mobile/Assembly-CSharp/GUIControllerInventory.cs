using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000DF RID: 223
[Token(Token = "0x20000DF")]
public class GUIControllerInventory : GUIPageContentController
{
	// Token: 0x060005A8 RID: 1448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0xE66188", Offset = "0xE66188", VA = "0xE66188")]
	public GUIControllerInventory()
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0xE66194", Offset = "0xE66194", VA = "0xE66194", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0xE66320", Offset = "0xE66320", VA = "0xE66320")]
	public static GUIControllerItem NavigateIntoCoinsAmmo(int row)
	{
		return null;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AB")]
	[Address(RVA = "0xE664F0", Offset = "0xE664F0", VA = "0xE664F0", Slot = "14")]
	public virtual void NavigateToItem(int item)
	{
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060005AC RID: 1452 RVA: 0x00003F90 File Offset: 0x00002190
	[Token(Token = "0x1700008E")]
	private static int MaxRowIndex
	{
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xE665FC", Offset = "0xE665FC", VA = "0xE665FC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x060005AD RID: 1453 RVA: 0x00003FA8 File Offset: 0x000021A8
	[Token(Token = "0x1700008F")]
	private static int MaxColumnIndex
	{
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xE666D0", Offset = "0xE666D0", VA = "0xE666D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AE")]
	[Address(RVA = "0xE667A0", Offset = "0xE667A0", VA = "0xE667A0", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00003FC0 File Offset: 0x000021C0
	[Token(Token = "0x60005AF")]
	[Address(RVA = "0xE66BA0", Offset = "0xE66BA0", VA = "0xE66BA0", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0400071E RID: 1822
	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x0400071F RID: 1823
	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x18")]
	public int itemColumn;

	// Token: 0x04000720 RID: 1824
	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x1C")]
	public int toolRow;

	// Token: 0x04000721 RID: 1825
	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x20")]
	public int toolColumn;
}
