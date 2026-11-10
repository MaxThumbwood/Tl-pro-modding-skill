using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000E4 RID: 228
[Token(Token = "0x20000E4")]
public class GUIControllerPageGroup : FileAPI
{
	// Token: 0x060005DB RID: 1499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DB")]
	[Address(RVA = "0xE68EC8", Offset = "0xE68EC8", VA = "0xE68EC8")]
	public GUIControllerPageGroup(GUIPageIconGrouping grouping)
	{
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DC")]
	[Address(RVA = "0xE68EE4", Offset = "0xE68EE4", VA = "0xE68EE4", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00004158 File Offset: 0x00002358
	[Token(Token = "0x60005DD")]
	[Address(RVA = "0xE68EE8", Offset = "0xE68EE8", VA = "0xE68EE8", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005DE")]
	[Address(RVA = "0xE68FA4", Offset = "0xE68FA4", VA = "0xE68FA4", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DF")]
	[Address(RVA = "0xE69288", Offset = "0xE69288", VA = "0xE69288")]
	public void ClampMenuItem(bool preferUp = true)
	{
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00004170 File Offset: 0x00002370
	[Token(Token = "0x60005E0")]
	[Address(RVA = "0xE69418", Offset = "0xE69418", VA = "0xE69418", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x8")]
	public readonly GUIPageIconGrouping Grouping;

	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0xC")]
	public int MenuRow;
}
