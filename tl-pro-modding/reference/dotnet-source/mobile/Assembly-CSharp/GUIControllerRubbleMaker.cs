using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000B1 RID: 177
[Token(Token = "0x20000B1")]
public class GUIControllerRubbleMaker : FileAPI
{
	// Token: 0x06000465 RID: 1125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000465")]
	[Address(RVA = "0xD656DC", Offset = "0xD656DC", VA = "0xD656DC", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00003558 File Offset: 0x00001758
	[Token(Token = "0x6000466")]
	[Address(RVA = "0xD657A0", Offset = "0xD657A0", VA = "0xD657A0", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000467")]
	[Address(RVA = "0xD657A8", Offset = "0xD657A8", VA = "0xD657A8", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000468")]
	[Address(RVA = "0xD65F60", Offset = "0xD65F60", VA = "0xD65F60")]
	private void ClampMaterialGrid()
	{
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000469")]
	[Address(RVA = "0xD66104", Offset = "0xD66104", VA = "0xD66104")]
	private void ClampRubbleGrid()
	{
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00003570 File Offset: 0x00001770
	[Token(Token = "0x600046A")]
	[Address(RVA = "0xD662B8", Offset = "0xD662B8", VA = "0xD662B8", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046B")]
	[Address(RVA = "0xD66890", Offset = "0xD66890", VA = "0xD66890")]
	public GUIControllerRubbleMaker()
	{
	}

	// Token: 0x04000654 RID: 1620
	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x8")]
	private bool wasInFilterGrid;

	// Token: 0x04000655 RID: 1621
	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0xC")]
	private int filterGridRow;

	// Token: 0x04000656 RID: 1622
	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x10")]
	private int filterGridCol;

	// Token: 0x04000657 RID: 1623
	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x14")]
	private bool inGrid;

	// Token: 0x04000658 RID: 1624
	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x18")]
	private int gridRow;

	// Token: 0x04000659 RID: 1625
	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x1C")]
	private int gridCol;

	// Token: 0x0400065A RID: 1626
	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x20")]
	private bool filterButton;

	// Token: 0x0400065B RID: 1627
	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x21")]
	private bool sizeButton;
}
