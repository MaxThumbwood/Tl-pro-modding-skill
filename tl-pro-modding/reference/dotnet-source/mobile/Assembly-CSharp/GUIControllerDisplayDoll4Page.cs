using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000D4 RID: 212
[Token(Token = "0x20000D4")]
public class GUIControllerDisplayDoll4Page : GUIControllerDisplayDoll
{
	// Token: 0x06000557 RID: 1367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000557")]
	[Address(RVA = "0xE5FC7C", Offset = "0xE5FC7C", VA = "0xE5FC7C", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00003CF0 File Offset: 0x00001EF0
	[Token(Token = "0x6000558")]
	[Address(RVA = "0xE5FF1C", Offset = "0xE5FF1C", VA = "0xE5FF1C")]
	private bool IsValidPosition(int col, int row)
	{
		return default(bool);
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000559")]
	[Address(RVA = "0xE5FD20", Offset = "0xE5FD20", VA = "0xE5FD20")]
	private void MoveToValidPosition()
	{
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00003D08 File Offset: 0x00001F08
	[Token(Token = "0x600055A")]
	[Address(RVA = "0xE60334", Offset = "0xE60334", VA = "0xE60334")]
	private bool MoveToValidRowInColumn(int yDir = 0)
	{
		return default(bool);
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055B")]
	[Address(RVA = "0xE603F4", Offset = "0xE603F4", VA = "0xE603F4", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00003D20 File Offset: 0x00001F20
	[Token(Token = "0x600055C")]
	[Address(RVA = "0xE604DC", Offset = "0xE604DC", VA = "0xE604DC", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600055D")]
	[Address(RVA = "0xE605DC", Offset = "0xE605DC", VA = "0xE605DC", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00003D38 File Offset: 0x00001F38
	[Token(Token = "0x600055E")]
	[Address(RVA = "0xE60AB8", Offset = "0xE60AB8", VA = "0xE60AB8", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055F")]
	[Address(RVA = "0xE60E38", Offset = "0xE60E38", VA = "0xE60E38")]
	public GUIControllerDisplayDoll4Page()
	{
	}
}
