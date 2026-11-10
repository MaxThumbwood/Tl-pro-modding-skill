using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001FC RID: 508
[Token(Token = "0x20001FC")]
[Serializable]
public class Inventory_Layout : PageControllerLayoutDefinition<Inventory_Layout>
{
	// Token: 0x06000D9E RID: 3486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0xC8A12C", Offset = "0xC8A12C", VA = "0xC8A12C")]
	public Inventory_Layout()
	{
	}

	// Token: 0x0400156C RID: 5484
	[Token(Token = "0x400156C")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x0400156D RID: 5485
	[Token(Token = "0x400156D")]
	[FieldOffset(Offset = "0x14")]
	public float ItemScale;

	// Token: 0x0400156E RID: 5486
	[Token(Token = "0x400156E")]
	[FieldOffset(Offset = "0x18")]
	public float ItemHighlightScale;

	// Token: 0x0400156F RID: 5487
	[Token(Token = "0x400156F")]
	[FieldOffset(Offset = "0x1C")]
	public float ScaleSpeed;

	// Token: 0x04001570 RID: 5488
	[Token(Token = "0x4001570")]
	[FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout HotbarGrid;

	// Token: 0x04001571 RID: 5489
	[Token(Token = "0x4001571")]
	[FieldOffset(Offset = "0x24")]
	public ItemGrid_Layout HorizontalHotbarGrid;

	// Token: 0x04001572 RID: 5490
	[Token(Token = "0x4001572")]
	[FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout ItemGrid;

	// Token: 0x04001573 RID: 5491
	[Token(Token = "0x4001573")]
	[FieldOffset(Offset = "0x2C")]
	public ItemGrid_Layout HorizontalItemGrid;

	// Token: 0x04001574 RID: 5492
	[Token(Token = "0x4001574")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Favorite;

	// Token: 0x04001575 RID: 5493
	[Token(Token = "0x4001575")]
	[FieldOffset(Offset = "0x34")]
	public FavoriteIcons FavoriteIcons;

	// Token: 0x04001576 RID: 5494
	[Token(Token = "0x4001576")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 BindingOffset;

	// Token: 0x04001577 RID: 5495
	[Token(Token = "0x4001577")]
	[FieldOffset(Offset = "0x40")]
	public float BindingScale;

	// Token: 0x04001578 RID: 5496
	[Token(Token = "0x4001578")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 NextBindingOffset;

	// Token: 0x04001579 RID: 5497
	[Token(Token = "0x4001579")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 NextBindingOffset_Small;

	// Token: 0x0400157A RID: 5498
	[Token(Token = "0x400157A")]
	[FieldOffset(Offset = "0x54")]
	public float NextBindingScale;

	// Token: 0x0400157B RID: 5499
	[Token(Token = "0x400157B")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 PreviousBindingOffset;

	// Token: 0x0400157C RID: 5500
	[Token(Token = "0x400157C")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 PreviousBindingOffset_Small;

	// Token: 0x0400157D RID: 5501
	[Token(Token = "0x400157D")]
	[FieldOffset(Offset = "0x68")]
	public float PreviousBindingScale;

	// Token: 0x0400157E RID: 5502
	[Token(Token = "0x400157E")]
	[FieldOffset(Offset = "0x6C")]
	public String_Layout NextBinding_Hotbar;

	// Token: 0x0400157F RID: 5503
	[Token(Token = "0x400157F")]
	[FieldOffset(Offset = "0x70")]
	public String_Layout NextBinding_HotbarHorizontal;

	// Token: 0x04001580 RID: 5504
	[Token(Token = "0x4001580")]
	[FieldOffset(Offset = "0x74")]
	public String_Layout NextBinding_Inventory;

	// Token: 0x04001581 RID: 5505
	[Token(Token = "0x4001581")]
	[FieldOffset(Offset = "0x78")]
	public String_Layout PreviousBinding_Hotbar;

	// Token: 0x04001582 RID: 5506
	[Token(Token = "0x4001582")]
	[FieldOffset(Offset = "0x7C")]
	public String_Layout PreviousBinding_HotbarHorizontal;

	// Token: 0x04001583 RID: 5507
	[Token(Token = "0x4001583")]
	[FieldOffset(Offset = "0x80")]
	public String_Layout PreviousBinding_Inventory;

	// Token: 0x04001584 RID: 5508
	[Token(Token = "0x4001584")]
	[FieldOffset(Offset = "0x84")]
	public Color ResearchRingColor;
}
