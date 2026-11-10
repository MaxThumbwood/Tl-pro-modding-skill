using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200015E RID: 350
[Token(Token = "0x200015E")]
public class GUIInventory
{
	// Token: 0x060009CC RID: 2508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x91CFC0", Offset = "0x91CFC0", VA = "0x91CFC0")]
	public GUIInventory()
	{
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x91D38C", Offset = "0x91D38C", VA = "0x91D38C")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x91D9D8", Offset = "0x91D9D8", VA = "0x91D9D8")]
	public Item GetSelectedItem()
	{
		return null;
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00005FE8 File Offset: 0x000041E8
	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x91DB3C", Offset = "0x91DB3C", VA = "0x91DB3C")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x91DBA4", Offset = "0x91DBA4", VA = "0x91DBA4")]
	public void ItemOver(int index)
	{
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x91F360", Offset = "0x91F360", VA = "0x91F360")]
	public void SetOverSlot(int overSlot)
	{
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x91F368", Offset = "0x91F368", VA = "0x91F368")]
	public void AddSelectedBindings()
	{
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x91F6FC", Offset = "0x91F6FC", VA = "0x91F6FC")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00006000 File Offset: 0x00004200
	[Token(Token = "0x170000D9")]
	public bool HasFocus
	{
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x91F14C", Offset = "0x91F14C", VA = "0x91F14C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D5")]
	[Address(RVA = "0x92341C", Offset = "0x92341C", VA = "0x92341C")]
	public void Draw()
	{
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D6")]
	[Address(RVA = "0x91FE18", Offset = "0x91FE18", VA = "0x91FE18")]
	public void DrawItem(SpriteBatch spriteBatch, ItemGrid_Layout gridLayout, Item[] inv, int slot, Vector2 position, Color lightColor, float scale)
	{
	}

	// Token: 0x04000B94 RID: 2964
	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x8")]
	private int cursorOver;

	// Token: 0x04000B95 RID: 2965
	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0xC")]
	private int itemOver;

	// Token: 0x04000B96 RID: 2966
	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x10")]
	private int itemOffset;

	// Token: 0x04000B97 RID: 2967
	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x14")]
	private int lastItemClicked;

	// Token: 0x04000B98 RID: 2968
	[Token(Token = "0x4000B98")]
	[FieldOffset(Offset = "0x18")]
	private int itemDragStart;

	// Token: 0x04000B99 RID: 2969
	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x1C")]
	private float doubleClickTimer;

	// Token: 0x04000B9A RID: 2970
	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x20")]
	private bool rightClickHeld;

	// Token: 0x04000B9B RID: 2971
	[Token(Token = "0x4000B9B")]
	[FieldOffset(Offset = "0x24")]
	private float favoriteButtonScale;

	// Token: 0x04000B9C RID: 2972
	[Token(Token = "0x4000B9C")]
	[FieldOffset(Offset = "0x28")]
	public bool InHandItemActionHappened;

	// Token: 0x04000B9D RID: 2973
	[Token(Token = "0x4000B9D")]
	[FieldOffset(Offset = "0x29")]
	public bool ControllerOverValidItem;

	// Token: 0x04000B9E RID: 2974
	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x2C")]
	public int ControllerOverSlot;

	// Token: 0x04000B9F RID: 2975
	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x30")]
	private GUIItemGrid.GetItemScaleHandler ItemScaleDelegate;

	// Token: 0x04000BA0 RID: 2976
	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x34")]
	private GUIItemGrid.CursorOver ItemOverDelegate;

	// Token: 0x04000BA1 RID: 2977
	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x38")]
	private GUIItemGrid.DrawItemHandler itemDrawDelegate;

	// Token: 0x04000BA2 RID: 2978
	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x3C")]
	private Rectangle PageRegion;

	// Token: 0x04000BA3 RID: 2979
	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x4C")]
	private bool PageUseHorizontalInventory;

	// Token: 0x04000BA4 RID: 2980
	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x4D")]
	private bool PageDisplayTouchOptions;

	// Token: 0x04000BA5 RID: 2981
	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x50")]
	private int PageX;

	// Token: 0x04000BA6 RID: 2982
	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x54")]
	private int PageY;

	// Token: 0x04000BA7 RID: 2983
	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x0")]
	public static float selectedItemColorScale;
}
