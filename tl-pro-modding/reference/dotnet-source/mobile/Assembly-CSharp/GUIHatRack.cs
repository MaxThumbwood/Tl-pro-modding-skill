using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Tile_Entities;

// Token: 0x02000157 RID: 343
[Token(Token = "0x2000157")]
public class GUIHatRack
{
	// Token: 0x06000983 RID: 2435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000983")]
	[Address(RVA = "0x7CE500", Offset = "0x7CE500", VA = "0x7CE500")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000984 RID: 2436 RVA: 0x00005E38 File Offset: 0x00004038
	// (set) Token: 0x06000985 RID: 2437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000D0")]
	private int itemPieceSelected
	{
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x7CE72C", Offset = "0x7CE72C", VA = "0x7CE72C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x7CE734", Offset = "0x7CE734", VA = "0x7CE734")]
		set
		{
		}
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000986")]
	[Address(RVA = "0x7CE744", Offset = "0x7CE744", VA = "0x7CE744")]
	public void MarkSelectedItemDirty()
	{
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00005E50 File Offset: 0x00004050
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x7CE750", Offset = "0x7CE750", VA = "0x7CE750")]
	public float HatScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00005E68 File Offset: 0x00004068
	[Token(Token = "0x6000988")]
	[Address(RVA = "0x7CE7B8", Offset = "0x7CE7B8", VA = "0x7CE7B8")]
	public float HatDyeScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000989")]
	[Address(RVA = "0x7CE820", Offset = "0x7CE820", VA = "0x7CE820")]
	private void ItemOver(Item[] inv, int index, GUIHatRack.EquipmentItemType equipmentType, int itemContext, ref int itemDragStart)
	{
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098A")]
	[Address(RVA = "0x7CEF10", Offset = "0x7CEF10", VA = "0x7CEF10")]
	public void HatOver(int index)
	{
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098B")]
	[Address(RVA = "0x7CEF5C", Offset = "0x7CEF5C", VA = "0x7CEF5C")]
	public void HatDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x7CF658", Offset = "0x7CF658", VA = "0x7CF658")]
	public void HatDyeOver(int index)
	{
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098D")]
	[Address(RVA = "0x7CF6A4", Offset = "0x7CF6A4", VA = "0x7CF6A4")]
	public void HatDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00005E80 File Offset: 0x00004080
	[Token(Token = "0x600098E")]
	[Address(RVA = "0x7CFBEC", Offset = "0x7CFBEC", VA = "0x7CFBEC")]
	public int CanBeEquipedAccessory(Item checkItem)
	{
		return 0;
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00005E98 File Offset: 0x00004098
	[Token(Token = "0x600098F")]
	[Address(RVA = "0x7CFEEC", Offset = "0x7CFEEC", VA = "0x7CFEEC")]
	public bool CanBeEquiped(Item checkItem)
	{
		return default(bool);
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00005EB0 File Offset: 0x000040B0
	[Token(Token = "0x6000990")]
	[Address(RVA = "0x7CFF10", Offset = "0x7CFF10", VA = "0x7CFF10")]
	public bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00005EC8 File Offset: 0x000040C8
	[Token(Token = "0x6000991")]
	[Address(RVA = "0x7CF600", Offset = "0x7CF600", VA = "0x7CF600")]
	public bool CanBeStored(int context, Item checkItem, int slot)
	{
		return default(bool);
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000992")]
	[Address(RVA = "0x7CFF44", Offset = "0x7CFF44", VA = "0x7CFF44")]
	private void DrawHats()
	{
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000993")]
	[Address(RVA = "0x7D05A0", Offset = "0x7D05A0", VA = "0x7D05A0")]
	public Item GetSelectedItem()
	{
		return null;
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000994")]
	[Address(RVA = "0x7D05E8", Offset = "0x7D05E8", VA = "0x7D05E8")]
	public void DrawUnequipButton()
	{
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000995 RID: 2453 RVA: 0x00005EE0 File Offset: 0x000040E0
	[Token(Token = "0x170000D1")]
	public bool HasFocus
	{
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x7CF4D0", Offset = "0x7CF4D0", VA = "0x7CF4D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000996")]
	[Address(RVA = "0x7D1248", Offset = "0x7D1248", VA = "0x7D1248")]
	public void Draw()
	{
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000997")]
	[Address(RVA = "0x7D14E8", Offset = "0x7D14E8", VA = "0x7D14E8")]
	public GUIHatRack()
	{
	}

	// Token: 0x04000AA5 RID: 2725
	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x8")]
	private int cursorOver;

	// Token: 0x04000AA6 RID: 2726
	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0xC")]
	private int itemOver;

	// Token: 0x04000AA7 RID: 2727
	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x10")]
	private int itemDragStartHat;

	// Token: 0x04000AA8 RID: 2728
	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x14")]
	private int itemDragStartHatDye;

	// Token: 0x04000AA9 RID: 2729
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x18")]
	private GUIHatRack.EquipmentItemType itemType;

	// Token: 0x04000AAA RID: 2730
	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x1C")]
	private int itemPieceSelected_internal;

	// Token: 0x04000AAB RID: 2731
	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x20")]
	public bool itemPieceSelected_dirty;

	// Token: 0x04000AAC RID: 2732
	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x24")]
	private float UnequipButtonScale;

	// Token: 0x04000AAD RID: 2733
	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x28")]
	private TEHatRack HatRack;

	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	private enum EquipmentItemType
	{
		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		Hat,
		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		HatDye
	}
}
