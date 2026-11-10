using System;
using Il2CppDummyDll;

// Token: 0x02000203 RID: 515
[Token(Token = "0x2000203")]
[Serializable]
public class KeyboardMappingsCategories_Layout
{
	// Token: 0x06000DA6 RID: 3494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0xC8A564", Offset = "0xC8A564", VA = "0xC8A564")]
	public void GetCategorySetup(string id, out KeyboardMappingsCategories_Layout.Category category, out int sortOrder, int axisIndex = 0)
	{
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0xC8C0C4", Offset = "0xC8C0C4", VA = "0xC8C0C4")]
	public KeyboardMappingsCategories_Layout()
	{
	}

	// Token: 0x040015E8 RID: 5608
	[Token(Token = "0x40015E8")]
	[FieldOffset(Offset = "0x8")]
	public Panel_Layout Backing;

	// Token: 0x040015E9 RID: 5609
	[Token(Token = "0x40015E9")]
	[FieldOffset(Offset = "0xC")]
	public TransactionButton_Layout GeneralSettings;

	// Token: 0x040015EA RID: 5610
	[Token(Token = "0x40015EA")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Exploration;

	// Token: 0x040015EB RID: 5611
	[Token(Token = "0x40015EB")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Fighting;

	// Token: 0x040015EC RID: 5612
	[Token(Token = "0x40015EC")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Miscellaneous;

	// Token: 0x040015ED RID: 5613
	[Token(Token = "0x40015ED")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout UI;

	// Token: 0x040015EE RID: 5614
	[Token(Token = "0x40015EE")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Chest;

	// Token: 0x040015EF RID: 5615
	[Token(Token = "0x40015EF")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Equipment;

	// Token: 0x040015F0 RID: 5616
	[Token(Token = "0x40015F0")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Multiplayer;

	// Token: 0x040015F1 RID: 5617
	[Token(Token = "0x40015F1")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout ShopCraft;

	// Token: 0x040015F2 RID: 5618
	[Token(Token = "0x40015F2")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Map;

	// Token: 0x040015F3 RID: 5619
	[Token(Token = "0x40015F3")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout LB;

	// Token: 0x040015F4 RID: 5620
	[Token(Token = "0x40015F4")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout RB;

	// Token: 0x040015F5 RID: 5621
	[Token(Token = "0x40015F5")]
	[FieldOffset(Offset = "0x3C")]
	public KeyboardMappingsCategories_Layout.MappingCategories MappingSettings;

	// Token: 0x02000204 RID: 516
	[Token(Token = "0x2000204")]
	public enum Category
	{
		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		GeneralSettings,
		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		Exploration,
		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		Fighting,
		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		Miscellaneous,
		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		UI,
		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		Chest,
		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		Equipment,
		// Token: 0x040015FE RID: 5630
		[Token(Token = "0x40015FE")]
		Multiplayer,
		// Token: 0x040015FF RID: 5631
		[Token(Token = "0x40015FF")]
		ShopCraft,
		// Token: 0x04001600 RID: 5632
		[Token(Token = "0x4001600")]
		Map
	}

	// Token: 0x02000205 RID: 517
	[Token(Token = "0x2000205")]
	[Serializable]
	public class Setting
	{
		// Token: 0x06000DA8 RID: 3496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0xC8C0CC", Offset = "0xC8C0CC", VA = "0xC8C0CC")]
		public Setting()
		{
		}

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[FieldOffset(Offset = "0x8")]
		public KeyboardMappingsCategories_Layout.Category Category;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[FieldOffset(Offset = "0xC")]
		public int SortOrder;
	}

	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	[Serializable]
	public class MappingCategories
	{
		// Token: 0x06000DA9 RID: 3497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0xC8C0DC", Offset = "0xC8C0DC", VA = "0xC8C0DC")]
		public MappingCategories()
		{
		}

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0x8")]
		public KeyboardMappingsCategories_Layout.Setting Up;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[FieldOffset(Offset = "0xC")]
		public KeyboardMappingsCategories_Layout.Setting Left;

		// Token: 0x04001605 RID: 5637
		[Token(Token = "0x4001605")]
		[FieldOffset(Offset = "0x10")]
		public KeyboardMappingsCategories_Layout.Setting Down;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[FieldOffset(Offset = "0x14")]
		public KeyboardMappingsCategories_Layout.Setting Right;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x18")]
		public KeyboardMappingsCategories_Layout.Setting GrappleFire;

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x1C")]
		public KeyboardMappingsCategories_Layout.Setting Jump;

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x20")]
		public KeyboardMappingsCategories_Layout.Setting Fire;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x24")]
		public KeyboardMappingsCategories_Layout.Setting Interact;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x28")]
		public KeyboardMappingsCategories_Layout.Setting TargetLockOn;

		// Token: 0x0400160C RID: 5644
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x2C")]
		public KeyboardMappingsCategories_Layout.Setting InventoryToggle;

		// Token: 0x0400160D RID: 5645
		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x30")]
		public KeyboardMappingsCategories_Layout.Setting AutoSelect;

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x34")]
		public KeyboardMappingsCategories_Layout.Setting SmartCursor;

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x38")]
		public KeyboardMappingsCategories_Layout.Setting AutoFire;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x3C")]
		public KeyboardMappingsCategories_Layout.Setting HotbarNext;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x40")]
		public KeyboardMappingsCategories_Layout.Setting HotbarPrevious;

		// Token: 0x04001612 RID: 5650
		[Token(Token = "0x4001612")]
		[FieldOffset(Offset = "0x44")]
		public KeyboardMappingsCategories_Layout.Setting ZoomIn;

		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		[FieldOffset(Offset = "0x48")]
		public KeyboardMappingsCategories_Layout.Setting ZoomOut;

		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		[FieldOffset(Offset = "0x4C")]
		public KeyboardMappingsCategories_Layout.Setting MapZoomIn;

		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		[FieldOffset(Offset = "0x50")]
		public KeyboardMappingsCategories_Layout.Setting MapZoomOut;

		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		[FieldOffset(Offset = "0x54")]
		public KeyboardMappingsCategories_Layout.Setting MapZoomDefault;

		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		[FieldOffset(Offset = "0x58")]
		public KeyboardMappingsCategories_Layout.Setting QuickMount;

		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		[FieldOffset(Offset = "0x5C")]
		public KeyboardMappingsCategories_Layout.Setting QuickHeal;

		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		[FieldOffset(Offset = "0x60")]
		public KeyboardMappingsCategories_Layout.Setting QuickBuff;

		// Token: 0x0400161A RID: 5658
		[Token(Token = "0x400161A")]
		[FieldOffset(Offset = "0x64")]
		public KeyboardMappingsCategories_Layout.Setting QuickMana;

		// Token: 0x0400161B RID: 5659
		[Token(Token = "0x400161B")]
		[FieldOffset(Offset = "0x68")]
		public KeyboardMappingsCategories_Layout.Setting MapToggle;

		// Token: 0x0400161C RID: 5660
		[Token(Token = "0x400161C")]
		[FieldOffset(Offset = "0x6C")]
		public KeyboardMappingsCategories_Layout.Setting MiniMapToggle;

		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x70")]
		public KeyboardMappingsCategories_Layout.Setting ChatToggle;

		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x74")]
		public KeyboardMappingsCategories_Layout.Setting MiniChatToggle;

		// Token: 0x0400161F RID: 5663
		[Token(Token = "0x400161F")]
		[FieldOffset(Offset = "0x78")]
		public KeyboardMappingsCategories_Layout.Setting OverlayChatToggle;

		// Token: 0x04001620 RID: 5664
		[Token(Token = "0x4001620")]
		[FieldOffset(Offset = "0x7C")]
		public KeyboardMappingsCategories_Layout.Setting EmotesToggle;

		// Token: 0x04001621 RID: 5665
		[Token(Token = "0x4001621")]
		[FieldOffset(Offset = "0x80")]
		public KeyboardMappingsCategories_Layout.Setting Settings;

		// Token: 0x04001622 RID: 5666
		[Token(Token = "0x4001622")]
		[FieldOffset(Offset = "0x84")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar1;

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x88")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar2;

		// Token: 0x04001624 RID: 5668
		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x8C")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar3;

		// Token: 0x04001625 RID: 5669
		[Token(Token = "0x4001625")]
		[FieldOffset(Offset = "0x90")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar4;

		// Token: 0x04001626 RID: 5670
		[Token(Token = "0x4001626")]
		[FieldOffset(Offset = "0x94")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar5;

		// Token: 0x04001627 RID: 5671
		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0x98")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar6;

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x9C")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar7;

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0xA0")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar8;

		// Token: 0x0400162A RID: 5674
		[Token(Token = "0x400162A")]
		[FieldOffset(Offset = "0xA4")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar9;

		// Token: 0x0400162B RID: 5675
		[Token(Token = "0x400162B")]
		[FieldOffset(Offset = "0xA8")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar10;

		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0xAC")]
		public KeyboardMappingsCategories_Layout.Setting Loadout1;

		// Token: 0x0400162D RID: 5677
		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0xB0")]
		public KeyboardMappingsCategories_Layout.Setting Loadout2;

		// Token: 0x0400162E RID: 5678
		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0xB4")]
		public KeyboardMappingsCategories_Layout.Setting Loadout3;

		// Token: 0x0400162F RID: 5679
		[Token(Token = "0x400162F")]
		[FieldOffset(Offset = "0xB8")]
		public KeyboardMappingsCategories_Layout.Setting LoadoutCycle;

		// Token: 0x04001630 RID: 5680
		[Token(Token = "0x4001630")]
		[FieldOffset(Offset = "0xBC")]
		public KeyboardMappingsCategories_Layout.Setting LeftPageCycle;

		// Token: 0x04001631 RID: 5681
		[Token(Token = "0x4001631")]
		[FieldOffset(Offset = "0xC0")]
		public KeyboardMappingsCategories_Layout.Setting RightPageCycle;

		// Token: 0x04001632 RID: 5682
		[Token(Token = "0x4001632")]
		[FieldOffset(Offset = "0xC4")]
		public KeyboardMappingsCategories_Layout.Setting Dash;

		// Token: 0x04001633 RID: 5683
		[Token(Token = "0x4001633")]
		[FieldOffset(Offset = "0xC8")]
		public KeyboardMappingsCategories_Layout.Setting ArmorSetAbility;
	}
}
