using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Tile_Entities;

// Token: 0x0200014D RID: 333
[Token(Token = "0x200014D")]
public class GUIDisplayDoll
{
	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00005A90 File Offset: 0x00003C90
	// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000CB")]
	private int itemPieceSelected
	{
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x63101C", Offset = "0x63101C", VA = "0x63101C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x631024", Offset = "0x631024", VA = "0x631024")]
		set
		{
		}
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x631034", Offset = "0x631034", VA = "0x631034")]
	public void MarkSelectedItemDirty()
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x631040", Offset = "0x631040", VA = "0x631040")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00005AA8 File Offset: 0x00003CA8
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x63126C", Offset = "0x63126C", VA = "0x63126C")]
	public float ArmourScale(int index)
	{
		return 0f;
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00005AC0 File Offset: 0x00003CC0
	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x6312D4", Offset = "0x6312D4", VA = "0x6312D4")]
	public float ArmourDyeScale(int index)
	{
		return 0f;
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00005AD8 File Offset: 0x00003CD8
	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x63133C", Offset = "0x63133C", VA = "0x63133C")]
	public float MountScale(int index)
	{
		return 0f;
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00005AF0 File Offset: 0x00003CF0
	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x6313A4", Offset = "0x6313A4", VA = "0x6313A4")]
	public float MountDyeScale(int index)
	{
		return 0f;
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x63140C", Offset = "0x63140C", VA = "0x63140C")]
	private void ItemOver(Item[] inv, int index, GUIDisplayDoll.EquipmentItemType equipmentType, int itemContext, ref int itemDragStart)
	{
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x631BB4", Offset = "0x631BB4", VA = "0x631BB4")]
	public void ArmourOver(int index)
	{
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x631C00", Offset = "0x631C00", VA = "0x631C00")]
	public void MountOver(int index)
	{
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000900")]
	[Address(RVA = "0x631C4C", Offset = "0x631C4C", VA = "0x631C4C")]
	public void ArmourDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000901")]
	[Address(RVA = "0x632580", Offset = "0x632580", VA = "0x632580")]
	public void MountDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000902")]
	[Address(RVA = "0x632B38", Offset = "0x632B38", VA = "0x632B38")]
	public void ArmourDyeOver(int index)
	{
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000903")]
	[Address(RVA = "0x632B84", Offset = "0x632B84", VA = "0x632B84")]
	public void MountDyeOver(int index)
	{
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000904")]
	[Address(RVA = "0x632BD0", Offset = "0x632BD0", VA = "0x632BD0")]
	public void ArmourDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000905")]
	[Address(RVA = "0x633158", Offset = "0x633158", VA = "0x633158")]
	public void MountDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00005B08 File Offset: 0x00003D08
	[Token(Token = "0x6000906")]
	[Address(RVA = "0x6336E4", Offset = "0x6336E4", VA = "0x6336E4")]
	public int CanBeEquipedAccessory(Item checkItem)
	{
		return 0;
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00005B20 File Offset: 0x00003D20
	[Token(Token = "0x6000907")]
	[Address(RVA = "0x633AF8", Offset = "0x633AF8", VA = "0x633AF8")]
	public bool CanBeEquiped(Item checkItem)
	{
		return default(bool);
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00005B38 File Offset: 0x00003D38
	[Token(Token = "0x6000908")]
	[Address(RVA = "0x633B80", Offset = "0x633B80", VA = "0x633B80")]
	public bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00005B50 File Offset: 0x00003D50
	[Token(Token = "0x6000909")]
	[Address(RVA = "0x63237C", Offset = "0x63237C", VA = "0x63237C")]
	public bool CanBeStored(int context, Item checkItem, int slot)
	{
		return default(bool);
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090A")]
	[Address(RVA = "0x633BD8", Offset = "0x633BD8", VA = "0x633BD8")]
	private void DrawArmour()
	{
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090B")]
	[Address(RVA = "0x634234", Offset = "0x634234", VA = "0x634234")]
	private void DrawMount()
	{
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00005B68 File Offset: 0x00003D68
	[Token(Token = "0x600090C")]
	[Address(RVA = "0x634890", Offset = "0x634890", VA = "0x634890")]
	public float MiscScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090D")]
	[Address(RVA = "0x6348F8", Offset = "0x6348F8", VA = "0x6348F8")]
	public void MiscOver(int index)
	{
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090E")]
	[Address(RVA = "0x634944", Offset = "0x634944", VA = "0x634944")]
	public void MiscDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x00005B80 File Offset: 0x00003D80
	[Token(Token = "0x600090F")]
	[Address(RVA = "0x634D7C", Offset = "0x634D7C", VA = "0x634D7C")]
	public float AccessoryScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x00005B98 File Offset: 0x00003D98
	[Token(Token = "0x6000910")]
	[Address(RVA = "0x634DE4", Offset = "0x634DE4", VA = "0x634DE4")]
	public float AccessoryDyeScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000911")]
	[Address(RVA = "0x634E4C", Offset = "0x634E4C", VA = "0x634E4C")]
	public void AccessoryOver(int index)
	{
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000912")]
	[Address(RVA = "0x634E98", Offset = "0x634E98", VA = "0x634E98")]
	public void AccessoryDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000913")]
	[Address(RVA = "0x635414", Offset = "0x635414", VA = "0x635414")]
	public void AccessoryDyeOver(int index)
	{
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000914")]
	[Address(RVA = "0x635460", Offset = "0x635460", VA = "0x635460")]
	public void AccessoryDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000915")]
	[Address(RVA = "0x6359E0", Offset = "0x6359E0", VA = "0x6359E0")]
	private void DrawWeapon()
	{
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000916")]
	[Address(RVA = "0x635D68", Offset = "0x635D68", VA = "0x635D68")]
	private void DrawAccesories()
	{
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000917")]
	[Address(RVA = "0x6363A8", Offset = "0x6363A8", VA = "0x6363A8")]
	public Item GetSelectedItem()
	{
		return null;
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000918")]
	[Address(RVA = "0x636468", Offset = "0x636468", VA = "0x636468")]
	public void DrawUnequipButton()
	{
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000919 RID: 2329 RVA: 0x00005BB0 File Offset: 0x00003DB0
	[Token(Token = "0x170000CC")]
	public bool HasFocus
	{
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x63224C", Offset = "0x63224C", VA = "0x63224C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091A")]
	[Address(RVA = "0x637130", Offset = "0x637130", VA = "0x637130")]
	public void Draw()
	{
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091B")]
	[Address(RVA = "0x6374E8", Offset = "0x6374E8", VA = "0x6374E8")]
	public GUIDisplayDoll()
	{
	}

	// Token: 0x04000A18 RID: 2584
	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0x8")]
	private int cursorOver;

	// Token: 0x04000A19 RID: 2585
	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0xC")]
	private int itemOver;

	// Token: 0x04000A1A RID: 2586
	[Token(Token = "0x4000A1A")]
	[FieldOffset(Offset = "0x10")]
	private int itemDragStartArmour;

	// Token: 0x04000A1B RID: 2587
	[Token(Token = "0x4000A1B")]
	[FieldOffset(Offset = "0x14")]
	private int itemDragStartArmourDye;

	// Token: 0x04000A1C RID: 2588
	[Token(Token = "0x4000A1C")]
	[FieldOffset(Offset = "0x18")]
	private int itemDragStartAccessory;

	// Token: 0x04000A1D RID: 2589
	[Token(Token = "0x4000A1D")]
	[FieldOffset(Offset = "0x1C")]
	private int itemDragStartAccessoryDye;

	// Token: 0x04000A1E RID: 2590
	[Token(Token = "0x4000A1E")]
	[FieldOffset(Offset = "0x20")]
	private int itemDragStartMount;

	// Token: 0x04000A1F RID: 2591
	[Token(Token = "0x4000A1F")]
	[FieldOffset(Offset = "0x24")]
	private int itemDragStartMountDye;

	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0x28")]
	private int itemDragStartMisc;

	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x2C")]
	private GUIDisplayDoll.EquipmentItemType itemType;

	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0x30")]
	private int itemPieceSelected_internal;

	// Token: 0x04000A23 RID: 2595
	[Token(Token = "0x4000A23")]
	[FieldOffset(Offset = "0x34")]
	public bool itemPieceSelected_dirty;

	// Token: 0x04000A24 RID: 2596
	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x38")]
	private float UnequipButtonScale;

	// Token: 0x04000A25 RID: 2597
	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x3C")]
	private float HideShowButtonScale;

	// Token: 0x04000A26 RID: 2598
	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0x40")]
	private TEDisplayDoll DisplayDoll;

	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	private enum EquipmentItemType
	{
		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		Armour,
		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		ArmourDye,
		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		Accessory,
		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		AccessoryDye,
		// Token: 0x04000A2C RID: 2604
		[Token(Token = "0x4000A2C")]
		Mount,
		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		MountDye,
		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		Weapon
	}
}
