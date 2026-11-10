using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000250 RID: 592
[Token(Token = "0x2000250")]
public class PageIconsExtended_Layout : LayoutDefinition
{
	// Token: 0x06000E55 RID: 3669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E55")]
	[Address(RVA = "0xC93978", Offset = "0xC93978", VA = "0xC93978")]
	private void Awake()
	{
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E56")]
	[Address(RVA = "0xC939CC", Offset = "0xC939CC", VA = "0xC939CC")]
	public DraggableItemGrid_Layout GetDisplayGrid(bool rightGrid, bool collapsedGrid)
	{
		return null;
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E57")]
	[Address(RVA = "0xC93AC8", Offset = "0xC93AC8", VA = "0xC93AC8")]
	public PageIconsExtended_Layout()
	{
	}

	// Token: 0x04001B0C RID: 6924
	[Token(Token = "0x4001B0C")]
	[FieldOffset(Offset = "0x0")]
	public static PageIconsExtended_Layout Instance;

	// Token: 0x04001B0D RID: 6925
	[Token(Token = "0x4001B0D")]
	[FieldOffset(Offset = "0xC")]
	public ItemGrid_Layout InventoryPageGrid;

	// Token: 0x04001B0E RID: 6926
	[Token(Token = "0x4001B0E")]
	[FieldOffset(Offset = "0x10")]
	public ItemGrid_Layout CraftingPageGrid;

	// Token: 0x04001B0F RID: 6927
	[Token(Token = "0x4001B0F")]
	[FieldOffset(Offset = "0x14")]
	public ItemGrid_Layout InteractionPageGrid;

	// Token: 0x04001B10 RID: 6928
	[Token(Token = "0x4001B10")]
	[FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout EquipmentPageGrid;

	// Token: 0x04001B11 RID: 6929
	[Token(Token = "0x4001B11")]
	[FieldOffset(Offset = "0x1C")]
	public ItemGrid_Layout PageGridLeft;

	// Token: 0x04001B12 RID: 6930
	[Token(Token = "0x4001B12")]
	[FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout PageGridRight;

	// Token: 0x04001B13 RID: 6931
	[Token(Token = "0x4001B13")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout SingleEntry;

	// Token: 0x04001B14 RID: 6932
	[Token(Token = "0x4001B14")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout TopEntry;

	// Token: 0x04001B15 RID: 6933
	[Token(Token = "0x4001B15")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout MiddleEntry;

	// Token: 0x04001B16 RID: 6934
	[Token(Token = "0x4001B16")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout BottomEntry;

	// Token: 0x04001B17 RID: 6935
	[Token(Token = "0x4001B17")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout ClosedEntry;

	// Token: 0x04001B18 RID: 6936
	[Token(Token = "0x4001B18")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout Expaned;

	// Token: 0x04001B19 RID: 6937
	[Token(Token = "0x4001B19")]
	[FieldOffset(Offset = "0x3C")]
	public Panel_Layout Collapsed;

	// Token: 0x04001B1A RID: 6938
	[Token(Token = "0x4001B1A")]
	[FieldOffset(Offset = "0x40")]
	public Panel_Layout Notification;

	// Token: 0x04001B1B RID: 6939
	[Token(Token = "0x4001B1B")]
	[FieldOffset(Offset = "0x44")]
	public Color InventoryBackingColour;

	// Token: 0x04001B1C RID: 6940
	[Token(Token = "0x4001B1C")]
	[FieldOffset(Offset = "0x48")]
	public Color InventorySelectedBackingColour;

	// Token: 0x04001B1D RID: 6941
	[Token(Token = "0x4001B1D")]
	[FieldOffset(Offset = "0x4C")]
	public Color CraftingBackingColour;

	// Token: 0x04001B1E RID: 6942
	[Token(Token = "0x4001B1E")]
	[FieldOffset(Offset = "0x50")]
	public Color CraftingSelectedBackingColour;

	// Token: 0x04001B1F RID: 6943
	[Token(Token = "0x4001B1F")]
	[FieldOffset(Offset = "0x54")]
	public Color BannerClaimBackingColour;

	// Token: 0x04001B20 RID: 6944
	[Token(Token = "0x4001B20")]
	[FieldOffset(Offset = "0x58")]
	public Color BannerClaimSelectedBackingColour;

	// Token: 0x04001B21 RID: 6945
	[Token(Token = "0x4001B21")]
	[FieldOffset(Offset = "0x5C")]
	public Color CraftingGuideBackingColour;

	// Token: 0x04001B22 RID: 6946
	[Token(Token = "0x4001B22")]
	[FieldOffset(Offset = "0x60")]
	public Color CraftingGuideSelectedBackingColour;

	// Token: 0x04001B23 RID: 6947
	[Token(Token = "0x4001B23")]
	[FieldOffset(Offset = "0x64")]
	public Color ReforgeBackingColour;

	// Token: 0x04001B24 RID: 6948
	[Token(Token = "0x4001B24")]
	[FieldOffset(Offset = "0x68")]
	public Color ReforgeSelectedBackingColour;

	// Token: 0x04001B25 RID: 6949
	[Token(Token = "0x4001B25")]
	[FieldOffset(Offset = "0x6C")]
	public Color ResearchBackingColour;

	// Token: 0x04001B26 RID: 6950
	[Token(Token = "0x4001B26")]
	[FieldOffset(Offset = "0x70")]
	public Color ResearchSelectedBackingColour;

	// Token: 0x04001B27 RID: 6951
	[Token(Token = "0x4001B27")]
	[FieldOffset(Offset = "0x74")]
	public Color PVPBackingColour;

	// Token: 0x04001B28 RID: 6952
	[Token(Token = "0x4001B28")]
	[FieldOffset(Offset = "0x78")]
	public Color PVPSelectedBackingColour;

	// Token: 0x04001B29 RID: 6953
	[Token(Token = "0x4001B29")]
	[FieldOffset(Offset = "0x7C")]
	public Color ChestBackingColour;

	// Token: 0x04001B2A RID: 6954
	[Token(Token = "0x4001B2A")]
	[FieldOffset(Offset = "0x80")]
	public Color ChestSelectedBackingColour;

	// Token: 0x04001B2B RID: 6955
	[Token(Token = "0x4001B2B")]
	[FieldOffset(Offset = "0x84")]
	public Color BankBackingColour;

	// Token: 0x04001B2C RID: 6956
	[Token(Token = "0x4001B2C")]
	[FieldOffset(Offset = "0x88")]
	public Color BankSelectedBackingColour;

	// Token: 0x04001B2D RID: 6957
	[Token(Token = "0x4001B2D")]
	[FieldOffset(Offset = "0x8C")]
	public Color ChatBackingColour;

	// Token: 0x04001B2E RID: 6958
	[Token(Token = "0x4001B2E")]
	[FieldOffset(Offset = "0x90")]
	public Color ChatSelectedBackingColour;

	// Token: 0x04001B2F RID: 6959
	[Token(Token = "0x4001B2F")]
	[FieldOffset(Offset = "0x94")]
	public Color EquipmentBackingColour;

	// Token: 0x04001B30 RID: 6960
	[Token(Token = "0x4001B30")]
	[FieldOffset(Offset = "0x98")]
	public Color EquipmentSelectedBackingColour;

	// Token: 0x04001B31 RID: 6961
	[Token(Token = "0x4001B31")]
	[FieldOffset(Offset = "0x9C")]
	public Color HousingBackingColour;

	// Token: 0x04001B32 RID: 6962
	[Token(Token = "0x4001B32")]
	[FieldOffset(Offset = "0xA0")]
	public Color HousingSelectedBackingColour;

	// Token: 0x04001B33 RID: 6963
	[Token(Token = "0x4001B33")]
	[FieldOffset(Offset = "0xA4")]
	public Color ShopBackingColour;

	// Token: 0x04001B34 RID: 6964
	[Token(Token = "0x4001B34")]
	[FieldOffset(Offset = "0xA8")]
	public Color ShopSelectedBackingColour;

	// Token: 0x04001B35 RID: 6965
	[Token(Token = "0x4001B35")]
	[FieldOffset(Offset = "0xAC")]
	public Color DuplicateBackingColour;

	// Token: 0x04001B36 RID: 6966
	[Token(Token = "0x4001B36")]
	[FieldOffset(Offset = "0xB0")]
	public Color DuplicateSelectedBackingColour;

	// Token: 0x04001B37 RID: 6967
	[Token(Token = "0x4001B37")]
	[FieldOffset(Offset = "0xB4")]
	public Color HatRackBackingColour;

	// Token: 0x04001B38 RID: 6968
	[Token(Token = "0x4001B38")]
	[FieldOffset(Offset = "0xB8")]
	public Color HatRackSelectedBackingColour;

	// Token: 0x04001B39 RID: 6969
	[Token(Token = "0x4001B39")]
	[FieldOffset(Offset = "0xBC")]
	public Color DisplayDollBackingColour;

	// Token: 0x04001B3A RID: 6970
	[Token(Token = "0x4001B3A")]
	[FieldOffset(Offset = "0xC0")]
	public Color DisplayDollSelectedBackingColour;

	// Token: 0x04001B3B RID: 6971
	[Token(Token = "0x4001B3B")]
	[FieldOffset(Offset = "0xC4")]
	public Color CraftingStationBackingColour;

	// Token: 0x04001B3C RID: 6972
	[Token(Token = "0x4001B3C")]
	[FieldOffset(Offset = "0xC8")]
	public Color CraftingStationSelectedBackingColour;

	// Token: 0x04001B3D RID: 6973
	[Token(Token = "0x4001B3D")]
	[FieldOffset(Offset = "0xCC")]
	public Color BankButtonNormalColour;

	// Token: 0x04001B3E RID: 6974
	[Token(Token = "0x4001B3E")]
	[FieldOffset(Offset = "0xD0")]
	public Color BankButtonPressedColour;

	// Token: 0x04001B3F RID: 6975
	[Token(Token = "0x4001B3F")]
	[FieldOffset(Offset = "0xD4")]
	public Color BankButtonDisabledColour;

	// Token: 0x04001B40 RID: 6976
	[Token(Token = "0x4001B40")]
	[FieldOffset(Offset = "0xD8")]
	public DraggableItemGrid_Layout Left_ConsoleGrid;

	// Token: 0x04001B41 RID: 6977
	[Token(Token = "0x4001B41")]
	[FieldOffset(Offset = "0xDC")]
	public DraggableItemGrid_Layout Left_ConsoleGridCollapsed;

	// Token: 0x04001B42 RID: 6978
	[Token(Token = "0x4001B42")]
	[FieldOffset(Offset = "0xE0")]
	public DraggableItemGrid_Layout Left_TouchGrid;

	// Token: 0x04001B43 RID: 6979
	[Token(Token = "0x4001B43")]
	[FieldOffset(Offset = "0xE4")]
	public DraggableItemGrid_Layout Left_TouchGridCollapsed;

	// Token: 0x04001B44 RID: 6980
	[Token(Token = "0x4001B44")]
	[FieldOffset(Offset = "0xE8")]
	public DraggableItemGrid_Layout Right_ConsoleGrid;

	// Token: 0x04001B45 RID: 6981
	[Token(Token = "0x4001B45")]
	[FieldOffset(Offset = "0xEC")]
	public DraggableItemGrid_Layout Right_ConsoleGridCollapsed;

	// Token: 0x04001B46 RID: 6982
	[Token(Token = "0x4001B46")]
	[FieldOffset(Offset = "0xF0")]
	public DraggableItemGrid_Layout Right_TouchGrid;

	// Token: 0x04001B47 RID: 6983
	[Token(Token = "0x4001B47")]
	[FieldOffset(Offset = "0xF4")]
	public DraggableItemGrid_Layout Right_TouchGridCollapsed;
}
