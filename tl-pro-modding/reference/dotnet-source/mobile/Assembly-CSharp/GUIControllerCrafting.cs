using System;
using Il2CppDummyDll;

// Token: 0x020000CD RID: 205
[Token(Token = "0x20000CD")]
public class GUIControllerCrafting : GUIPageContentController
{
	// Token: 0x06000516 RID: 1302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000516")]
	[Address(RVA = "0xE5DE24", Offset = "0xE5DE24", VA = "0xE5DE24")]
	public GUIControllerCrafting()
	{
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x00003A80 File Offset: 0x00001C80
	[Token(Token = "0x6000517")]
	[Address(RVA = "0xE5DE30", Offset = "0xE5DE30", VA = "0xE5DE30", Slot = "14")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000518")]
	[Address(RVA = "0xE5DE38", Offset = "0xE5DE38", VA = "0xE5DE38", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000519")]
	[Address(RVA = "0xE5DE3C", Offset = "0xE5DE3C", VA = "0xE5DE3C", Slot = "15")]
	public virtual void RefreshScrollOffset()
	{
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051A")]
	[Address(RVA = "0xE5DE40", Offset = "0xE5DE40", VA = "0xE5DE40", Slot = "16")]
	protected virtual void UpdateScroll()
	{
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051B")]
	[Address(RVA = "0xE5DE44", Offset = "0xE5DE44", VA = "0xE5DE44", Slot = "17")]
	protected virtual void ClampPosition()
	{
	}

	// Token: 0x040006EC RID: 1772
	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x040006ED RID: 1773
	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x18")]
	public int itemColumn;

	// Token: 0x040006EE RID: 1774
	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x1C")]
	public int scrollOffset;
}
