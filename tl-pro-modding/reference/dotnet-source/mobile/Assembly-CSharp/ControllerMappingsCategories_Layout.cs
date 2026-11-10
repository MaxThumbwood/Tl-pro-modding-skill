using System;
using Il2CppDummyDll;

// Token: 0x020001BC RID: 444
[Token(Token = "0x20001BC")]
[Serializable]
public class ControllerMappingsCategories_Layout
{
	// Token: 0x06000C9F RID: 3231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0xC68308", Offset = "0xC68308", VA = "0xC68308")]
	public void GetCategorySetup(GUISettingID id, out ControllerMappingsCategories_Layout.Category category, out int sortOrder)
	{
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0xC68684", Offset = "0xC68684", VA = "0xC68684")]
	public void GetCategorySetup(string actionId, out ControllerMappingsCategories_Layout.Category category, out int sortOrder)
	{
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0xC6C3F4", Offset = "0xC6C3F4", VA = "0xC6C3F4")]
	public ControllerMappingsCategories_Layout()
	{
	}

	// Token: 0x04001129 RID: 4393
	[Token(Token = "0x4001129")]
	[FieldOffset(Offset = "0x8")]
	public Panel_Layout Backing;

	// Token: 0x0400112A RID: 4394
	[Token(Token = "0x400112A")]
	[FieldOffset(Offset = "0xC")]
	public TransactionButton_Layout GeneralSettings;

	// Token: 0x0400112B RID: 4395
	[Token(Token = "0x400112B")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Exploration;

	// Token: 0x0400112C RID: 4396
	[Token(Token = "0x400112C")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Fighting;

	// Token: 0x0400112D RID: 4397
	[Token(Token = "0x400112D")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Miscellaneous;

	// Token: 0x0400112E RID: 4398
	[Token(Token = "0x400112E")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout UI;

	// Token: 0x0400112F RID: 4399
	[Token(Token = "0x400112F")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Chest;

	// Token: 0x04001130 RID: 4400
	[Token(Token = "0x4001130")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Equipment;

	// Token: 0x04001131 RID: 4401
	[Token(Token = "0x4001131")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Multiplayer;

	// Token: 0x04001132 RID: 4402
	[Token(Token = "0x4001132")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout ShopCraft;

	// Token: 0x04001133 RID: 4403
	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Map;

	// Token: 0x04001134 RID: 4404
	[Token(Token = "0x4001134")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout LB;

	// Token: 0x04001135 RID: 4405
	[Token(Token = "0x4001135")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout RB;

	// Token: 0x04001136 RID: 4406
	[Token(Token = "0x4001136")]
	[FieldOffset(Offset = "0x3C")]
	public ControllerMappingsCategories_Layout.MappingCategories MappingSettings;

	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	public enum Category
	{
		// Token: 0x04001138 RID: 4408
		[Token(Token = "0x4001138")]
		GeneralSettings,
		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x4001139")]
		Exploration,
		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x400113A")]
		Fighting,
		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400113B")]
		Miscellaneous,
		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x400113C")]
		UI,
		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400113D")]
		Chest,
		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		Equipment,
		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x400113F")]
		Multiplayer,
		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x4001140")]
		ShopCraft,
		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x4001141")]
		Map
	}

	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	[Serializable]
	public class Setting
	{
		// Token: 0x06000CA2 RID: 3234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0xC6C400", Offset = "0xC6C400", VA = "0xC6C400")]
		public Setting()
		{
		}

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x8")]
		public ControllerMappingsCategories_Layout.Category Category;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0xC")]
		public int SortOrder;
	}

	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	[Serializable]
	public class MappingCategories
	{
		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0xC6C410", Offset = "0xC6C410", VA = "0xC6C410")]
		public MappingCategories()
		{
		}

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x8")]
		public ControllerMappingsCategories_Layout.Setting Controls;

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0xC")]
		public ControllerMappingsCategories_Layout.Setting ControllerAimAndUseMode;

		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x4001146")]
		[FieldOffset(Offset = "0x10")]
		public ControllerMappingsCategories_Layout.Setting ControllerAimSensitivity;

		// Token: 0x04001147 RID: 4423
		[Token(Token = "0x4001147")]
		[FieldOffset(Offset = "0x14")]
		public ControllerMappingsCategories_Layout.Setting ControllerInterfaceMovementDelay;

		// Token: 0x04001148 RID: 4424
		[Token(Token = "0x4001148")]
		[FieldOffset(Offset = "0x18")]
		public ControllerMappingsCategories_Layout.Setting ControllerInterfaceMovementRepeatDelay;

		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x4001149")]
		[FieldOffset(Offset = "0x1C")]
		public ControllerMappingsCategories_Layout.Setting ControllerSmartCursorMode;

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		[FieldOffset(Offset = "0x20")]
		public ControllerMappingsCategories_Layout.Setting ControllerSwapShoulderButtons;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		[FieldOffset(Offset = "0x24")]
		public ControllerMappingsCategories_Layout.Setting ControllerShowControlsBanner;

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		[FieldOffset(Offset = "0x28")]
		public ControllerMappingsCategories_Layout.Setting MovementAxis;

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x2C")]
		public ControllerMappingsCategories_Layout.Setting MovementAxisAlt;

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x30")]
		public ControllerMappingsCategories_Layout.Setting FireAxis;

		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x400114F")]
		[FieldOffset(Offset = "0x34")]
		public ControllerMappingsCategories_Layout.Setting FireAxisAlt;

		// Token: 0x04001150 RID: 4432
		[Token(Token = "0x4001150")]
		[FieldOffset(Offset = "0x38")]
		public ControllerMappingsCategories_Layout.Setting GrappleAxis;

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0x3C")]
		public ControllerMappingsCategories_Layout.Setting GridSnapAxis;

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x40")]
		public ControllerMappingsCategories_Layout.Setting HotbarAxis;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x44")]
		public ControllerMappingsCategories_Layout.Setting GrappleFire;

		// Token: 0x04001154 RID: 4436
		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x48")]
		public ControllerMappingsCategories_Layout.Setting Jump;

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x4C")]
		public ControllerMappingsCategories_Layout.Setting Fire;

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x50")]
		public ControllerMappingsCategories_Layout.Setting FireAlt;

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x54")]
		public ControllerMappingsCategories_Layout.Setting Interact;

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x58")]
		public ControllerMappingsCategories_Layout.Setting TargetLockOn;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x5C")]
		public ControllerMappingsCategories_Layout.Setting InventoryToggle;

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x60")]
		public ControllerMappingsCategories_Layout.Setting WorldFocusToggle;

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x64")]
		public ControllerMappingsCategories_Layout.Setting AutoSelect;

		// Token: 0x0400115C RID: 4444
		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0x68")]
		public ControllerMappingsCategories_Layout.Setting SmartCursor;

		// Token: 0x0400115D RID: 4445
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x6C")]
		public ControllerMappingsCategories_Layout.Setting AutoFire;

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x70")]
		public ControllerMappingsCategories_Layout.Setting HotbarNext;

		// Token: 0x0400115F RID: 4447
		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x74")]
		public ControllerMappingsCategories_Layout.Setting HotbarPrevious;

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x78")]
		public ControllerMappingsCategories_Layout.Setting BuffNext;

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x7C")]
		public ControllerMappingsCategories_Layout.Setting BuffPrevious;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x80")]
		public ControllerMappingsCategories_Layout.Setting BuffRemove;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x84")]
		public ControllerMappingsCategories_Layout.Setting ZoomIn;

		// Token: 0x04001164 RID: 4452
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x88")]
		public ControllerMappingsCategories_Layout.Setting ZoomOut;

		// Token: 0x04001165 RID: 4453
		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0x8C")]
		public ControllerMappingsCategories_Layout.Setting MapZoomIn;

		// Token: 0x04001166 RID: 4454
		[Token(Token = "0x4001166")]
		[FieldOffset(Offset = "0x90")]
		public ControllerMappingsCategories_Layout.Setting MapZoomOut;

		// Token: 0x04001167 RID: 4455
		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0x94")]
		public ControllerMappingsCategories_Layout.Setting MapZoomDefault;

		// Token: 0x04001168 RID: 4456
		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x98")]
		public ControllerMappingsCategories_Layout.Setting QuickHeal;

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x4001169")]
		[FieldOffset(Offset = "0x9C")]
		public ControllerMappingsCategories_Layout.Setting QuickMana;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0xA0")]
		public ControllerMappingsCategories_Layout.Setting QuickBuff;

		// Token: 0x0400116B RID: 4459
		[Token(Token = "0x400116B")]
		[FieldOffset(Offset = "0xA4")]
		public ControllerMappingsCategories_Layout.Setting QuickMount;

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0xA8")]
		public ControllerMappingsCategories_Layout.Setting MapToggle;

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0xAC")]
		public ControllerMappingsCategories_Layout.Setting MiniMapToggle;

		// Token: 0x0400116E RID: 4462
		[Token(Token = "0x400116E")]
		[FieldOffset(Offset = "0xB0")]
		public ControllerMappingsCategories_Layout.Setting ChatToggle;

		// Token: 0x0400116F RID: 4463
		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0xB4")]
		public ControllerMappingsCategories_Layout.Setting MiniChatToggle;

		// Token: 0x04001170 RID: 4464
		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0xB8")]
		public ControllerMappingsCategories_Layout.Setting OverlayChatToggle;

		// Token: 0x04001171 RID: 4465
		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0xBC")]
		public ControllerMappingsCategories_Layout.Setting EmotesToggle;

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0xC0")]
		public ControllerMappingsCategories_Layout.Setting WiringOptions;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0xC4")]
		public ControllerMappingsCategories_Layout.Setting ToggleEmotes;

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0xC8")]
		public ControllerMappingsCategories_Layout.Setting InventoryNavigation;

		// Token: 0x04001175 RID: 4469
		[Token(Token = "0x4001175")]
		[FieldOffset(Offset = "0xCC")]
		public ControllerMappingsCategories_Layout.Setting InventoryNavigationAlt;

		// Token: 0x04001176 RID: 4470
		[Token(Token = "0x4001176")]
		[FieldOffset(Offset = "0xD0")]
		public ControllerMappingsCategories_Layout.Setting LeftPageCycle;

		// Token: 0x04001177 RID: 4471
		[Token(Token = "0x4001177")]
		[FieldOffset(Offset = "0xD4")]
		public ControllerMappingsCategories_Layout.Setting RightPageCycle;

		// Token: 0x04001178 RID: 4472
		[Token(Token = "0x4001178")]
		[FieldOffset(Offset = "0xD8")]
		public ControllerMappingsCategories_Layout.Setting ThrowItem;

		// Token: 0x04001179 RID: 4473
		[Token(Token = "0x4001179")]
		[FieldOffset(Offset = "0xDC")]
		public ControllerMappingsCategories_Layout.Setting TrashItem;

		// Token: 0x0400117A RID: 4474
		[Token(Token = "0x400117A")]
		[FieldOffset(Offset = "0xE0")]
		public ControllerMappingsCategories_Layout.Setting DepositHeldItem;

		// Token: 0x0400117B RID: 4475
		[Token(Token = "0x400117B")]
		[FieldOffset(Offset = "0xE4")]
		public ControllerMappingsCategories_Layout.Setting FavouriteItem;

		// Token: 0x0400117C RID: 4476
		[Token(Token = "0x400117C")]
		[FieldOffset(Offset = "0xE8")]
		public ControllerMappingsCategories_Layout.Setting SplitItem;

		// Token: 0x0400117D RID: 4477
		[Token(Token = "0x400117D")]
		[FieldOffset(Offset = "0xEC")]
		public ControllerMappingsCategories_Layout.Setting ResearchItem;

		// Token: 0x0400117E RID: 4478
		[Token(Token = "0x400117E")]
		[FieldOffset(Offset = "0xF0")]
		public ControllerMappingsCategories_Layout.Setting ShowHideItem;

		// Token: 0x0400117F RID: 4479
		[Token(Token = "0x400117F")]
		[FieldOffset(Offset = "0xF4")]
		public ControllerMappingsCategories_Layout.Setting ShareItem;

		// Token: 0x04001180 RID: 4480
		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0xF8")]
		public ControllerMappingsCategories_Layout.Setting Sort;

		// Token: 0x04001181 RID: 4481
		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0xFC")]
		public ControllerMappingsCategories_Layout.Setting BuilderTools;

		// Token: 0x04001182 RID: 4482
		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x100")]
		public ControllerMappingsCategories_Layout.Setting ChestQuickStack;

		// Token: 0x04001183 RID: 4483
		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x104")]
		public ControllerMappingsCategories_Layout.Setting ChestLootAll;

		// Token: 0x04001184 RID: 4484
		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x108")]
		public ControllerMappingsCategories_Layout.Setting ChestDepositAll;

		// Token: 0x04001185 RID: 4485
		[Token(Token = "0x4001185")]
		[FieldOffset(Offset = "0x10C")]
		public ControllerMappingsCategories_Layout.Setting ChestRestock;

		// Token: 0x04001186 RID: 4486
		[Token(Token = "0x4001186")]
		[FieldOffset(Offset = "0x110")]
		public ControllerMappingsCategories_Layout.Setting ChestRename;

		// Token: 0x04001187 RID: 4487
		[Token(Token = "0x4001187")]
		[FieldOffset(Offset = "0x114")]
		public ControllerMappingsCategories_Layout.Setting ChestLoot;

		// Token: 0x04001188 RID: 4488
		[Token(Token = "0x4001188")]
		[FieldOffset(Offset = "0x118")]
		public ControllerMappingsCategories_Layout.Setting ChestDeposit;

		// Token: 0x04001189 RID: 4489
		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x11C")]
		public ControllerMappingsCategories_Layout.Setting ChestSort;

		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x400118A")]
		[FieldOffset(Offset = "0x120")]
		public ControllerMappingsCategories_Layout.Setting EquipmentEquip;

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x124")]
		public ControllerMappingsCategories_Layout.Setting EquipmentUnequip;

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x128")]
		public ControllerMappingsCategories_Layout.Setting ShopSell;

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x12C")]
		public ControllerMappingsCategories_Layout.Setting ShopBuy;

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0x130")]
		public ControllerMappingsCategories_Layout.Setting MaterialPrevious;

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x134")]
		public ControllerMappingsCategories_Layout.Setting MaterialNext;

		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x138")]
		public ControllerMappingsCategories_Layout.Setting PVPEnableToggle;

		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x13C")]
		public ControllerMappingsCategories_Layout.Setting PVPTeleport;

		// Token: 0x04001192 RID: 4498
		[Token(Token = "0x4001192")]
		[FieldOffset(Offset = "0x140")]
		public ControllerMappingsCategories_Layout.Setting PVPSwitchTeam;

		// Token: 0x04001193 RID: 4499
		[Token(Token = "0x4001193")]
		[FieldOffset(Offset = "0x144")]
		public ControllerMappingsCategories_Layout.Setting InvitePopup;

		// Token: 0x04001194 RID: 4500
		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x148")]
		public ControllerMappingsCategories_Layout.Setting BestiaryFilters;

		// Token: 0x04001195 RID: 4501
		[Token(Token = "0x4001195")]
		[FieldOffset(Offset = "0x14C")]
		public ControllerMappingsCategories_Layout.Setting BestiaryFilterSearch;

		// Token: 0x04001196 RID: 4502
		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x150")]
		public ControllerMappingsCategories_Layout.Setting BestiarySortOrder;

		// Token: 0x04001197 RID: 4503
		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x154")]
		public ControllerMappingsCategories_Layout.Setting BestiaryDrops;

		// Token: 0x04001198 RID: 4504
		[Token(Token = "0x4001198")]
		[FieldOffset(Offset = "0x158")]
		public ControllerMappingsCategories_Layout.Setting PickupPlaceItem;

		// Token: 0x04001199 RID: 4505
		[Token(Token = "0x4001199")]
		[FieldOffset(Offset = "0x15C")]
		public ControllerMappingsCategories_Layout.Setting InventoryClose;

		// Token: 0x0400119A RID: 4506
		[Token(Token = "0x400119A")]
		[FieldOffset(Offset = "0x160")]
		public ControllerMappingsCategories_Layout.Setting ReforgeItem;

		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400119B")]
		[FieldOffset(Offset = "0x164")]
		public ControllerMappingsCategories_Layout.Setting CraftItem;

		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		[FieldOffset(Offset = "0x168")]
		public ControllerMappingsCategories_Layout.Setting FilterItems;

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x16C")]
		public ControllerMappingsCategories_Layout.Setting InfoAccessories;

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0x170")]
		public ControllerMappingsCategories_Layout.Setting FilterItemsSearch;

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x174")]
		public ControllerMappingsCategories_Layout.Setting ToggleCraftDuplicate;

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x178")]
		public ControllerMappingsCategories_Layout.Setting ToggleCraftBanner;

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x17C")]
		public ControllerMappingsCategories_Layout.Setting HousingQuery;

		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x40011A2")]
		[FieldOffset(Offset = "0x180")]
		public ControllerMappingsCategories_Layout.Setting TakeOne;

		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x40011A3")]
		[FieldOffset(Offset = "0x184")]
		public ControllerMappingsCategories_Layout.Setting SearchItems;

		// Token: 0x040011A4 RID: 4516
		[Token(Token = "0x40011A4")]
		[FieldOffset(Offset = "0x188")]
		public ControllerMappingsCategories_Layout.Setting ChestCraftToggle;

		// Token: 0x040011A5 RID: 4517
		[Token(Token = "0x40011A5")]
		[FieldOffset(Offset = "0x18C")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar1;

		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		[FieldOffset(Offset = "0x190")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar2;

		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x40011A7")]
		[FieldOffset(Offset = "0x194")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar3;

		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x40011A8")]
		[FieldOffset(Offset = "0x198")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar4;

		// Token: 0x040011A9 RID: 4521
		[Token(Token = "0x40011A9")]
		[FieldOffset(Offset = "0x19C")]
		public ControllerMappingsCategories_Layout.Setting Hotbar1;

		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x40011AA")]
		[FieldOffset(Offset = "0x1A0")]
		public ControllerMappingsCategories_Layout.Setting Hotbar2;

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		[FieldOffset(Offset = "0x1A4")]
		public ControllerMappingsCategories_Layout.Setting Hotbar3;

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		[FieldOffset(Offset = "0x1A8")]
		public ControllerMappingsCategories_Layout.Setting Hotbar4;

		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x40011AD")]
		[FieldOffset(Offset = "0x1AC")]
		public ControllerMappingsCategories_Layout.Setting Hotbar5;

		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x40011AE")]
		[FieldOffset(Offset = "0x1B0")]
		public ControllerMappingsCategories_Layout.Setting Hotbar6;

		// Token: 0x040011AF RID: 4527
		[Token(Token = "0x40011AF")]
		[FieldOffset(Offset = "0x1B4")]
		public ControllerMappingsCategories_Layout.Setting Hotbar7;

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x40011B0")]
		[FieldOffset(Offset = "0x1B8")]
		public ControllerMappingsCategories_Layout.Setting Hotbar8;

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x1BC")]
		public ControllerMappingsCategories_Layout.Setting Hotbar9;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x40011B2")]
		[FieldOffset(Offset = "0x1C0")]
		public ControllerMappingsCategories_Layout.Setting Hotbar10;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[FieldOffset(Offset = "0x1C4")]
		public ControllerMappingsCategories_Layout.Setting Loadout1;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x1C8")]
		public ControllerMappingsCategories_Layout.Setting Loadout2;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[FieldOffset(Offset = "0x1CC")]
		public ControllerMappingsCategories_Layout.Setting Loadout3;

		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x40011B6")]
		[FieldOffset(Offset = "0x1D0")]
		public ControllerMappingsCategories_Layout.Setting LoadoutCycle;

		// Token: 0x040011B7 RID: 4535
		[Token(Token = "0x40011B7")]
		[FieldOffset(Offset = "0x1D4")]
		public ControllerMappingsCategories_Layout.Setting LoadoutsToggle;

		// Token: 0x040011B8 RID: 4536
		[Token(Token = "0x40011B8")]
		[FieldOffset(Offset = "0x1D8")]
		public ControllerMappingsCategories_Layout.Setting Dash;

		// Token: 0x040011B9 RID: 4537
		[Token(Token = "0x40011B9")]
		[FieldOffset(Offset = "0x1DC")]
		public ControllerMappingsCategories_Layout.Setting ArmorSetAbility;
	}
}
