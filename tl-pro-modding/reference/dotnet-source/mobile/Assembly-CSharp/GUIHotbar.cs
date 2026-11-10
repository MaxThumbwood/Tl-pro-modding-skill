using System;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200015B RID: 347
[Token(Token = "0x200015B")]
public class GUIHotbar
{
	// Token: 0x060009A2 RID: 2466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x90F3C0", Offset = "0x90F3C0", VA = "0x90F3C0")]
	public GUIHotbar()
	{
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00005F28 File Offset: 0x00004128
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x90F5B4", Offset = "0x90F5B4", VA = "0x90F5B4")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x90F98C", Offset = "0x90F98C", VA = "0x90F98C")]
	public void ItemOver(int index)
	{
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x90FC90", Offset = "0x90FC90", VA = "0x90FC90")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x912D2C", Offset = "0x912D2C", VA = "0x912D2C")]
	public void UpdateHotbarKeybinds()
	{
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x913724", Offset = "0x913724", VA = "0x913724")]
	private void UpdateHotbarScroll()
	{
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x914524", Offset = "0x914524", VA = "0x914524")]
	public void UpdateHotbarNavigation()
	{
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00005F40 File Offset: 0x00004140
	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x9149D8", Offset = "0x9149D8", VA = "0x9149D8")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AA")]
	[Address(RVA = "0x914CC8", Offset = "0x914CC8", VA = "0x914CC8")]
	public void Draw()
	{
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x9108E4", Offset = "0x9108E4", VA = "0x9108E4")]
	public void DrawHotbarItem(SpriteBatch spriteBatch, ItemGrid_Layout layout, Item[] inv, int slot, Vector2 position, Color lightColor, float scale, ControllerActionButton slotMapping)
	{
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AC")]
	[Address(RVA = "0x9134C8", Offset = "0x9134C8", VA = "0x9134C8")]
	public void SetItem(int item)
	{
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x913F40", Offset = "0x913F40", VA = "0x913F40")]
	public void NextItem()
	{
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x9158E0", Offset = "0x9158E0", VA = "0x9158E0")]
	private void RefreshInvCursorPosition(int itemOver)
	{
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AF")]
	[Address(RVA = "0x91395C", Offset = "0x91395C", VA = "0x91395C")]
	public void PreviousItem()
	{
	}

	// Token: 0x04000ACB RID: 2763
	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0x8")]
	private int cursorOver;

	// Token: 0x04000ACC RID: 2764
	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0xC")]
	public float TimeSinceItemChange;

	// Token: 0x04000ACD RID: 2765
	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x10")]
	private string LastItem;

	// Token: 0x04000ACE RID: 2766
	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x14")]
	public bool menuTogglePressed;

	// Token: 0x04000ACF RID: 2767
	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x15")]
	public bool hotbarActive;

	// Token: 0x04000AD0 RID: 2768
	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x18")]
	public GUIControllerHotbarRadial hotbarController;

	// Token: 0x04000AD1 RID: 2769
	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x20")]
	private DateTime NavigationTick;

	// Token: 0x04000AD2 RID: 2770
	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x28")]
	private float ScrollAmount;

	// Token: 0x04000AD3 RID: 2771
	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x2C")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x04000AD4 RID: 2772
	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x30")]
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x04000AD5 RID: 2773
	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x34")]
	private GUIItemGrid.DrawItemHandler itemDraw;
}
