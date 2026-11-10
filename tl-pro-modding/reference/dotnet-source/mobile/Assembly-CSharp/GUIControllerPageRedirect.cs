using System;
using Il2CppDummyDll;

// Token: 0x020000E5 RID: 229
[Token(Token = "0x20000E5")]
public class GUIControllerPageRedirect
{
	// Token: 0x060005E1 RID: 1505 RVA: 0x00004188 File Offset: 0x00002388
	[Token(Token = "0x60005E1")]
	[Address(RVA = "0xE6964C", Offset = "0xE6964C", VA = "0xE6964C")]
	public bool IsPageController(GUIControllerItem item)
	{
		return default(bool);
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x000041A0 File Offset: 0x000023A0
	[Token(Token = "0x60005E2")]
	[Address(RVA = "0xE6999C", Offset = "0xE6999C", VA = "0xE6999C")]
	public GUIPageIcons.Category GetCategoryFromNavigationItem(GUIControllerItem item)
	{
		return GUIPageIcons.Category.Crafting;
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E3")]
	[Address(RVA = "0xE69AA8", Offset = "0xE69AA8", VA = "0xE69AA8")]
	public GUIControllerItem GetItemController(GUIPageIcons.Category item)
	{
		return null;
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0xE69CF0", Offset = "0xE69CF0", VA = "0xE69CF0")]
	public GUIControllerPageRedirect()
	{
	}

	// Token: 0x0400072D RID: 1837
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x8")]
	public GUIControllerAmmo Ammo;

	// Token: 0x0400072E RID: 1838
	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0xC")]
	public GUIControllerCoins Coins;

	// Token: 0x0400072F RID: 1839
	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x10")]
	public GUIControllerEquipment Equipment;

	// Token: 0x04000730 RID: 1840
	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x14")]
	public GUIControllerInventory Inventory;

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x18")]
	public GUIControllerHousing Housing;

	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x1C")]
	public GUIControllerPVP PVP;

	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x20")]
	public GUIControllerShop Shop;

	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x24")]
	public GUIControllerTrash Trash;

	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x28")]
	public GUIControllerChest Chest;

	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x2C")]
	public GUIControllerCrafting Crafting;

	// Token: 0x04000737 RID: 1847
	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x30")]
	public GUIControllerBannerCrafting BannerCrafting;

	// Token: 0x04000738 RID: 1848
	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x34")]
	public GUIControllerItemDuplication Duplicate;

	// Token: 0x04000739 RID: 1849
	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x38")]
	public GUIControllerDisplayDoll DisplayDoll;

	// Token: 0x0400073A RID: 1850
	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x3C")]
	public GUIControllerHatRack HatRack;

	// Token: 0x0400073B RID: 1851
	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x40")]
	public GUIControllerReforge Reforge;

	// Token: 0x0400073C RID: 1852
	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x44")]
	public GUIControllerResearchPage4Page ResearchPage;

	// Token: 0x0400073D RID: 1853
	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x48")]
	public GUIControllerDresser Dresser;

	// Token: 0x0400073E RID: 1854
	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x4C")]
	public GUIControllerHairStylist Hair;

	// Token: 0x0400073F RID: 1855
	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x50")]
	public GUIControllerCraftingGuide CraftingGuide;
}
