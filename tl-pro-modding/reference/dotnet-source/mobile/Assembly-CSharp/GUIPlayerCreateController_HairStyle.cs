using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000102 RID: 258
[Token(Token = "0x2000102")]
public class GUIPlayerCreateController_HairStyle : FileAPI
{
	// Token: 0x060006C6 RID: 1734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C6")]
	[Address(RVA = "0xF2A080", Offset = "0xF2A080", VA = "0xF2A080")]
	public GUIPlayerCreateController_HairStyle(GUIPlayerCreateController controller)
	{
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C7")]
	[Address(RVA = "0xF2AEDC", Offset = "0xF2AEDC", VA = "0xF2AEDC", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x000049B0 File Offset: 0x00002BB0
	[Token(Token = "0x60006C8")]
	[Address(RVA = "0xF2B440", Offset = "0xF2B440", VA = "0xF2B440", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C9")]
	[Address(RVA = "0xF2B448", Offset = "0xF2B448", VA = "0xF2B448", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CA")]
	[Address(RVA = "0xF2B06C", Offset = "0xF2B06C", VA = "0xF2B06C")]
	public void UpdateScroll()
	{
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060006CB RID: 1739 RVA: 0x000049C8 File Offset: 0x00002BC8
	[Token(Token = "0x170000BA")]
	public int currentScrollOffset
	{
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xF2B61C", Offset = "0xF2B61C", VA = "0xF2B61C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x000049E0 File Offset: 0x00002BE0
	[Token(Token = "0x60006CC")]
	[Address(RVA = "0xF2B864", Offset = "0xF2B864", VA = "0xF2B864", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x04000784 RID: 1924
	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x04000785 RID: 1925
	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0xC")]
	public int maxRowIndex;

	// Token: 0x04000786 RID: 1926
	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x10")]
	public int maxRowColumn;

	// Token: 0x04000787 RID: 1927
	[Token(Token = "0x4000787")]
	[FieldOffset(Offset = "0x14")]
	public int itemRow;

	// Token: 0x04000788 RID: 1928
	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x18")]
	public int itemColumn;
}
