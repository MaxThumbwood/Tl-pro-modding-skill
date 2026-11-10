using System;
using Il2CppDummyDll;

// Token: 0x020000CB RID: 203
[Token(Token = "0x20000CB")]
public class GUIControllerCoins : GUIPageContentController
{
	// Token: 0x0600050C RID: 1292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050C")]
	[Address(RVA = "0xE5D464", Offset = "0xE5D464", VA = "0xE5D464")]
	public GUIControllerCoins()
	{
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050D")]
	[Address(RVA = "0xE5D470", Offset = "0xE5D470", VA = "0xE5D470", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050E")]
	[Address(RVA = "0xE5D474", Offset = "0xE5D474", VA = "0xE5D474", Slot = "14")]
	public virtual void NavigateFromInventoryRow(int row)
	{
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x00003A20 File Offset: 0x00001C20
	[Token(Token = "0x600050F")]
	[Address(RVA = "0xE5D494", Offset = "0xE5D494", VA = "0xE5D494", Slot = "15")]
	public virtual int GetInventoryRow()
	{
		return 0;
	}

	// Token: 0x040006EB RID: 1771
	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;
}
