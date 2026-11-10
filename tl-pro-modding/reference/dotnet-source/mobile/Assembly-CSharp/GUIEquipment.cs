using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000151")]
public class GUIEquipment
{
	// Token: 0x06000931 RID: 2353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000931")]
	[Address(RVA = "0x7B61E8", Offset = "0x7B61E8", VA = "0x7B61E8")]
	public GUIEquipment()
	{
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000932 RID: 2354 RVA: 0x00005C10 File Offset: 0x00003E10
	[Token(Token = "0x170000CD")]
	public bool collapsed
	{
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x7B69D4", Offset = "0x7B69D4", VA = "0x7B69D4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000933 RID: 2355 RVA: 0x00005C28 File Offset: 0x00003E28
	// (set) Token: 0x06000934 RID: 2356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000CE")]
	private int itemPieceSelected
	{
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x7B6A54", Offset = "0x7B6A54", VA = "0x7B6A54")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x7B6A5C", Offset = "0x7B6A5C", VA = "0x7B6A5C")]
		set
		{
		}
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000935")]
	[Address(RVA = "0x7B6A6C", Offset = "0x7B6A6C", VA = "0x7B6A6C")]
	public void MarkSelectedItemDirty()
	{
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000936")]
	[Address(RVA = "0x7B6A78", Offset = "0x7B6A78", VA = "0x7B6A78")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00005C40 File Offset: 0x00003E40
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x7B6FA4", Offset = "0x7B6FA4", VA = "0x7B6FA4")]
	public float ArmourScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00005C58 File Offset: 0x00003E58
	[Token(Token = "0x6000938")]
	[Address(RVA = "0x7B700C", Offset = "0x7B700C", VA = "0x7B700C")]
	public float ArmourDyeScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00005C70 File Offset: 0x00003E70
	[Token(Token = "0x6000939")]
	[Address(RVA = "0x7B7074", Offset = "0x7B7074", VA = "0x7B7074")]
	public float ArmourVanityScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00005C88 File Offset: 0x00003E88
	[Token(Token = "0x600093A")]
	[Address(RVA = "0x7B70DC", Offset = "0x7B70DC", VA = "0x7B70DC")]
	private bool ShouldShowMenu(GUIEquipment.EquipmentItemType type, int i)
	{
		return default(bool);
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093B")]
	[Address(RVA = "0x7B72A8", Offset = "0x7B72A8", VA = "0x7B72A8")]
	private void ItemOver(Item[] inv, int index, GUIEquipment.EquipmentItemType equipmentType, int itemContext, ref int itemDragStart)
	{
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093C")]
	[Address(RVA = "0x7B8518", Offset = "0x7B8518", VA = "0x7B8518")]
	public void ArmourOverImp(int index)
	{
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093D")]
	[Address(RVA = "0x7B85BC", Offset = "0x7B85BC", VA = "0x7B85BC")]
	public void ArmourDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093E")]
	[Address(RVA = "0x7B923C", Offset = "0x7B923C", VA = "0x7B923C")]
	public void ArmourDyeOverImp(int index)
	{
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093F")]
	[Address(RVA = "0x7B92E0", Offset = "0x7B92E0", VA = "0x7B92E0")]
	public void ArmourDyeDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000940")]
	[Address(RVA = "0x7B98A0", Offset = "0x7B98A0", VA = "0x7B98A0")]
	public void ArmourVanityOverImp(int index)
	{
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000941")]
	[Address(RVA = "0x7B9944", Offset = "0x7B9944", VA = "0x7B9944")]
	public void ArmourVanityDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00005CA0 File Offset: 0x00003EA0
	[Token(Token = "0x6000942")]
	[Address(RVA = "0x7B9F58", Offset = "0x7B9F58", VA = "0x7B9F58")]
	public int CanBeEquipedAccessory(Item checkItem)
	{
		return 0;
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00005CB8 File Offset: 0x00003EB8
	[Token(Token = "0x6000943")]
	[Address(RVA = "0x7BA258", Offset = "0x7BA258", VA = "0x7BA258")]
	public bool CanBeEquiped(Item checkItem)
	{
		return default(bool);
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00005CD0 File Offset: 0x00003ED0
	[Token(Token = "0x6000944")]
	[Address(RVA = "0x7BA418", Offset = "0x7BA418", VA = "0x7BA418")]
	public bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00005CE8 File Offset: 0x00003EE8
	[Token(Token = "0x6000945")]
	[Address(RVA = "0x7B8CD8", Offset = "0x7B8CD8", VA = "0x7B8CD8")]
	public bool CanBeStored(int context, Item checkItem, int slot)
	{
		return default(bool);
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000946")]
	[Address(RVA = "0x7BA5E0", Offset = "0x7BA5E0", VA = "0x7BA5E0")]
	private void DrawArmour()
	{
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00005D00 File Offset: 0x00003F00
	[Token(Token = "0x6000947")]
	[Address(RVA = "0x7BAE60", Offset = "0x7BAE60", VA = "0x7BAE60")]
	public float AccessoryScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00005D18 File Offset: 0x00003F18
	[Token(Token = "0x6000948")]
	[Address(RVA = "0x7BAEC8", Offset = "0x7BAEC8", VA = "0x7BAEC8")]
	public float AccessoryDyeScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00005D30 File Offset: 0x00003F30
	[Token(Token = "0x6000949")]
	[Address(RVA = "0x7BAF30", Offset = "0x7BAF30", VA = "0x7BAF30")]
	public float AccessoryVanityScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094A")]
	[Address(RVA = "0x7BAF98", Offset = "0x7BAF98", VA = "0x7BAF98")]
	public void AccessoryOverImp(int index)
	{
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094B")]
	[Address(RVA = "0x7BB0B0", Offset = "0x7BB0B0", VA = "0x7BB0B0")]
	public void AccessoryDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094C")]
	[Address(RVA = "0x7BC098", Offset = "0x7BC098", VA = "0x7BC098")]
	public void AccessoryDyeOverImp(int index)
	{
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094D")]
	[Address(RVA = "0x7BC1B0", Offset = "0x7BC1B0", VA = "0x7BC1B0")]
	public void AccessoryDyeDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094E")]
	[Address(RVA = "0x7BCE7C", Offset = "0x7BCE7C", VA = "0x7BCE7C")]
	public void AccessoryVanityOverImp(int index)
	{
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094F")]
	[Address(RVA = "0x7BCF94", Offset = "0x7BCF94", VA = "0x7BCF94")]
	public void AccessoryVanityDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000950")]
	[Address(RVA = "0x7BDC98", Offset = "0x7BDC98", VA = "0x7BDC98")]
	private void DrawAccesories()
	{
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00005D48 File Offset: 0x00003F48
	[Token(Token = "0x6000951")]
	[Address(RVA = "0x7BE760", Offset = "0x7BE760", VA = "0x7BE760")]
	public float QuickSlotScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00005D60 File Offset: 0x00003F60
	[Token(Token = "0x6000952")]
	[Address(RVA = "0x7BE7C8", Offset = "0x7BE7C8", VA = "0x7BE7C8")]
	public float QuickSlotDyeScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000953")]
	[Address(RVA = "0x7BE830", Offset = "0x7BE830", VA = "0x7BE830")]
	public void QuickSlotOverImp(int index)
	{
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000954")]
	[Address(RVA = "0x7BE8EC", Offset = "0x7BE8EC", VA = "0x7BE8EC")]
	public void QuickSlotDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000955")]
	[Address(RVA = "0x7BF43C", Offset = "0x7BF43C", VA = "0x7BF43C")]
	public void QuickSlotDyeOverImp(int index)
	{
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000956")]
	[Address(RVA = "0x7BF4E0", Offset = "0x7BF4E0", VA = "0x7BF4E0")]
	public void QuickSlotDyeDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000957")]
	[Address(RVA = "0x7BFA94", Offset = "0x7BFA94", VA = "0x7BFA94")]
	private void DrawQuickSlots()
	{
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000958")]
	[Address(RVA = "0x7C00E8", Offset = "0x7C00E8", VA = "0x7C00E8")]
	private void DrawHeaders()
	{
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000959")]
	[Address(RVA = "0x7C00F0", Offset = "0x7C00F0", VA = "0x7C00F0")]
	private void DrawArmourBonus()
	{
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600095A")]
	[Address(RVA = "0x7C12A4", Offset = "0x7C12A4", VA = "0x7C12A4")]
	public Item GetSelectedItem()
	{
		return null;
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095B")]
	[Address(RVA = "0x7C13F0", Offset = "0x7C13F0", VA = "0x7C13F0")]
	public void DrawUnequipButton()
	{
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00005D78 File Offset: 0x00003F78
	[Token(Token = "0x600095C")]
	[Address(RVA = "0x7C2038", Offset = "0x7C2038", VA = "0x7C2038")]
	public bool CanBeHiddenOrShow()
	{
		return default(bool);
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095D")]
	[Address(RVA = "0x7C2040", Offset = "0x7C2040", VA = "0x7C2040")]
	public void DrawExpandButton()
	{
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095E")]
	[Address(RVA = "0x7C2044", Offset = "0x7C2044", VA = "0x7C2044")]
	public void DrawHideShowButton()
	{
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095F")]
	[Address(RVA = "0x7C3070", Offset = "0x7C3070", VA = "0x7C3070")]
	public void DrawShareButton()
	{
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000960 RID: 2400 RVA: 0x00005D90 File Offset: 0x00003F90
	[Token(Token = "0x170000CF")]
	public bool HasFocus
	{
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x7B8BA8", Offset = "0x7B8BA8", VA = "0x7B8BA8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000961")]
	[Address(RVA = "0x7C393C", Offset = "0x7C393C", VA = "0x7C393C")]
	public void Draw()
	{
	}

	// Token: 0x04000A4E RID: 2638
	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0x8")]
	private int cursorOver;

	// Token: 0x04000A4F RID: 2639
	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0xC")]
	private int itemOver;

	// Token: 0x04000A50 RID: 2640
	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0x10")]
	private int itemDragStartArmour;

	// Token: 0x04000A51 RID: 2641
	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x14")]
	private int itemDragStartArmourDye;

	// Token: 0x04000A52 RID: 2642
	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x18")]
	private int itemDragStartArmourVanity;

	// Token: 0x04000A53 RID: 2643
	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x1C")]
	private int itemDragStartAccessory;

	// Token: 0x04000A54 RID: 2644
	[Token(Token = "0x4000A54")]
	[FieldOffset(Offset = "0x20")]
	private int itemDragStartAccessoryDye;

	// Token: 0x04000A55 RID: 2645
	[Token(Token = "0x4000A55")]
	[FieldOffset(Offset = "0x24")]
	private int itemDragStartAccessoryVanity;

	// Token: 0x04000A56 RID: 2646
	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0x28")]
	private int itemDragStartQuickSlot;

	// Token: 0x04000A57 RID: 2647
	[Token(Token = "0x4000A57")]
	[FieldOffset(Offset = "0x2C")]
	private int itemDragStartQuickSlotDye;

	// Token: 0x04000A58 RID: 2648
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x30")]
	private GUIItemGrid.GetItemScaleHandler AccessoryScale;

	// Token: 0x04000A59 RID: 2649
	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x34")]
	private GUIItemGrid.GetItemScaleHandler AccessoryDyeScale;

	// Token: 0x04000A5A RID: 2650
	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x38")]
	private GUIItemGrid.GetItemScaleHandler AccessoryVanityScale;

	// Token: 0x04000A5B RID: 2651
	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0x3C")]
	private GUIItemGrid.CursorOver AccessoryOver;

	// Token: 0x04000A5C RID: 2652
	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0x40")]
	private GUIItemGrid.CursorOver AccessoryDyeOver;

	// Token: 0x04000A5D RID: 2653
	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0x44")]
	private GUIItemGrid.CursorOver AccessoryVanityOver;

	// Token: 0x04000A5E RID: 2654
	[Token(Token = "0x4000A5E")]
	[FieldOffset(Offset = "0x48")]
	private GUIItemGrid.DrawItemHandler AccessoryDraw;

	// Token: 0x04000A5F RID: 2655
	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x4C")]
	private GUIItemGrid.DrawItemHandler AccessoryDyeDraw;

	// Token: 0x04000A60 RID: 2656
	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x50")]
	private GUIItemGrid.DrawItemHandler AccessoryVanityDraw;

	// Token: 0x04000A61 RID: 2657
	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x54")]
	private GUIItemGrid.GetItemScaleHandler ArmourScale;

	// Token: 0x04000A62 RID: 2658
	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0x58")]
	private GUIItemGrid.GetItemScaleHandler ArmourDyeScale;

	// Token: 0x04000A63 RID: 2659
	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0x5C")]
	private GUIItemGrid.GetItemScaleHandler ArmourVanityScale;

	// Token: 0x04000A64 RID: 2660
	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0x60")]
	private GUIItemGrid.CursorOver ArmourOver;

	// Token: 0x04000A65 RID: 2661
	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x64")]
	private GUIItemGrid.CursorOver ArmourDyeOver;

	// Token: 0x04000A66 RID: 2662
	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x68")]
	private GUIItemGrid.CursorOver ArmourVanityOver;

	// Token: 0x04000A67 RID: 2663
	[Token(Token = "0x4000A67")]
	[FieldOffset(Offset = "0x6C")]
	private GUIItemGrid.DrawItemHandler ArmourDraw;

	// Token: 0x04000A68 RID: 2664
	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x70")]
	private GUIItemGrid.DrawItemHandler ArmourDyeDraw;

	// Token: 0x04000A69 RID: 2665
	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x74")]
	private GUIItemGrid.DrawItemHandler ArmourVanityDraw;

	// Token: 0x04000A6A RID: 2666
	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x78")]
	private GUIItemGrid.GetItemScaleHandler QuickSlotScale;

	// Token: 0x04000A6B RID: 2667
	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x7C")]
	private GUIItemGrid.GetItemScaleHandler QuickSlotDyeScale;

	// Token: 0x04000A6C RID: 2668
	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x80")]
	private GUIItemGrid.CursorOver QuickSlotOver;

	// Token: 0x04000A6D RID: 2669
	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x84")]
	private GUIItemGrid.CursorOver QuickSlotDyeOver;

	// Token: 0x04000A6E RID: 2670
	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x88")]
	private GUIItemGrid.DrawItemHandler QuickSlotDraw;

	// Token: 0x04000A6F RID: 2671
	[Token(Token = "0x4000A6F")]
	[FieldOffset(Offset = "0x8C")]
	private GUIItemGrid.DrawItemHandler QuickSlotDyeDraw;

	// Token: 0x04000A70 RID: 2672
	[Token(Token = "0x4000A70")]
	[FieldOffset(Offset = "0x90")]
	private float collapseAnimationTime;

	// Token: 0x04000A71 RID: 2673
	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x94")]
	private GUIEquipment.EquipmentItemType lastItemTypeClicked;

	// Token: 0x04000A72 RID: 2674
	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x98")]
	private int lastItemClicked;

	// Token: 0x04000A73 RID: 2675
	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x9C")]
	private float doubleClickTimer;

	// Token: 0x04000A74 RID: 2676
	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0xA0")]
	private bool rightClickHeld;

	// Token: 0x04000A75 RID: 2677
	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0xA4")]
	private GUIEquipment.EquipmentItemType itemType;

	// Token: 0x04000A76 RID: 2678
	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0xA8")]
	private int itemPieceSelected_internal;

	// Token: 0x04000A77 RID: 2679
	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0xAC")]
	public bool itemPieceSelected_dirty;

	// Token: 0x04000A78 RID: 2680
	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0xB0")]
	private float UnequipButtonScale;

	// Token: 0x04000A79 RID: 2681
	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0xB4")]
	private float HideShowButtonScale;

	// Token: 0x04000A7A RID: 2682
	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0xB8")]
	private float globalAnimationOffset;

	// Token: 0x04000A7B RID: 2683
	[Token(Token = "0x4000A7B")]
	[FieldOffset(Offset = "0xBC")]
	private float row1AnimationOffset;

	// Token: 0x04000A7C RID: 2684
	[Token(Token = "0x4000A7C")]
	[FieldOffset(Offset = "0xC0")]
	private float row2AnimationOffset;

	// Token: 0x04000A7D RID: 2685
	[Token(Token = "0x4000A7D")]
	[FieldOffset(Offset = "0xC4")]
	private float row1AnimationScale;

	// Token: 0x04000A7E RID: 2686
	[Token(Token = "0x4000A7E")]
	[FieldOffset(Offset = "0xC8")]
	private float row2AnimationScale;

	// Token: 0x04000A7F RID: 2687
	[Token(Token = "0x4000A7F")]
	[FieldOffset(Offset = "0xCC")]
	private int accOffset;

	// Token: 0x04000A80 RID: 2688
	[Token(Token = "0x4000A80")]
	[FieldOffset(Offset = "0xD0")]
	private float ExpandButtonScale;

	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	private enum EquipmentItemType
	{
		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		Armour,
		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		ArmourDye,
		// Token: 0x04000A84 RID: 2692
		[Token(Token = "0x4000A84")]
		ArmourVanity,
		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		Accessory,
		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		AccessoryDye,
		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		AccessoryVanity,
		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		QuickSlot,
		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		QuickSlotDye
	}
}
