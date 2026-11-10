using System;
using Il2CppDummyDll;

// Token: 0x020000C6 RID: 198
[Token(Token = "0x20000C6")]
public class GUIControllerAmmo : GUIPageContentController
{
	// Token: 0x060004E1 RID: 1249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E1")]
	[Address(RVA = "0xE5B940", Offset = "0xE5B940", VA = "0xE5B940")]
	public GUIControllerAmmo()
	{
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E2")]
	[Address(RVA = "0xE5B94C", Offset = "0xE5B94C", VA = "0xE5B94C", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E3")]
	[Address(RVA = "0xE5B950", Offset = "0xE5B950", VA = "0xE5B950", Slot = "14")]
	public virtual void NavigateFromInventoryRow(int row)
	{
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00003858 File Offset: 0x00001A58
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0xE5B978", Offset = "0xE5B978", VA = "0xE5B978", Slot = "15")]
	public virtual int GetInventoryRow()
	{
		return 0;
	}

	// Token: 0x040006E5 RID: 1765
	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x040006E6 RID: 1766
	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x18")]
	public int itemColmun;
}
