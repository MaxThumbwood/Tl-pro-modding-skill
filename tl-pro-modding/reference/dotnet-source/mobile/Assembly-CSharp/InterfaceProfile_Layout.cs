using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x20001F7")]
[Serializable]
public class InterfaceProfile_Layout
{
	// Token: 0x06000D5D RID: 3421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0xC7D6F4", Offset = "0xC7D6F4", VA = "0xC7D6F4")]
	public void InvalidateMinResolution()
	{
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00007548 File Offset: 0x00005748
	// (set) Token: 0x06000D5F RID: 3423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000165")]
	public float PreSplitChangeMinVertRes
	{
		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0xC7D7AC", Offset = "0xC7D7AC", VA = "0xC7D7AC")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0xC7D7B4", Offset = "0xC7D7B4", VA = "0xC7D7B4")]
		private set
		{
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00007560 File Offset: 0x00005760
	// (set) Token: 0x06000D61 RID: 3425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000166")]
	public float PreSplitChangeVertRes
	{
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0xC7D7BC", Offset = "0xC7D7BC", VA = "0xC7D7BC")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000D61")]
		[Address(RVA = "0xC7D7C4", Offset = "0xC7D7C4", VA = "0xC7D7C4")]
		private set
		{
		}
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0xC7D7CC", Offset = "0xC7D7CC", VA = "0xC7D7CC")]
	public void UpdatePreSplitChangeValues()
	{
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00007578 File Offset: 0x00005778
	[Token(Token = "0x17000167")]
	public int MinVerticalResolution
	{
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0xC7D7F4", Offset = "0xC7D7F4", VA = "0xC7D7F4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00007590 File Offset: 0x00005790
	[Token(Token = "0x6000D64")]
	[Address(RVA = "0xC7E308", Offset = "0xC7E308", VA = "0xC7E308")]
	public bool IsPageSelected(GUIPageIcons.Category category)
	{
		return default(bool);
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x000075A8 File Offset: 0x000057A8
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0xC7E450", Offset = "0xC7E450", VA = "0xC7E450")]
	public bool LoadSettingRegion(GUIPageIconGrouping.SettingCategory category)
	{
		return default(bool);
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D66")]
	[Address(RVA = "0xC7E854", Offset = "0xC7E854", VA = "0xC7E854")]
	public GUIPageIconGrouping GetSettingGrouping(GUIPageIconGrouping.SettingCategory category)
	{
		return null;
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D67")]
	[Address(RVA = "0xC7EA04", Offset = "0xC7EA04", VA = "0xC7EA04")]
	public static GUIPageIconGrouping GetActivePageGrouping()
	{
		return null;
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0xC77EDC", Offset = "0xC77EDC", VA = "0xC77EDC")]
	public GUIPageIconGrouping GetCategoryGrouping(GUIPageIcons.Category category, bool includeOptions = true)
	{
		return null;
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x000075C0 File Offset: 0x000057C0
	[Token(Token = "0x6000D69")]
	[Address(RVA = "0xC7EBD4", Offset = "0xC7EBD4", VA = "0xC7EBD4")]
	public bool HasCategoryOption(GUIPageIcons.Category category)
	{
		return default(bool);
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0xC7ED60", Offset = "0xC7ED60", VA = "0xC7ED60")]
	public void SetCollapsed(GUIPageIcons.Category category, bool collapsed)
	{
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x000075D8 File Offset: 0x000057D8
	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0xC7EE80", Offset = "0xC7EE80", VA = "0xC7EE80")]
	public bool IsCollapsed(GUIPageIcons.Category category)
	{
		return default(bool);
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x000075F0 File Offset: 0x000057F0
	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0xC7F1B8", Offset = "0xC7F1B8", VA = "0xC7F1B8")]
	private bool IsGroupSame(GUIPageIconGrouping dest, GUIPageIconGrouping src, int groupIndex, bool allowFixups)
	{
		return default(bool);
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x00007608 File Offset: 0x00005808
	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0xC7F598", Offset = "0xC7F598", VA = "0xC7F598")]
	private bool IsGroupListSame(List<GUIPageIconGrouping> dest, List<GUIPageIconGrouping> src, bool allowFixups, int groupOffset = 0)
	{
		return default(bool);
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x00007620 File Offset: 0x00005820
	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0xC7F6A8", Offset = "0xC7F6A8", VA = "0xC7F6A8")]
	public bool IsSame(InterfaceProfile_Layout other, bool allowFixups = false)
	{
		return default(bool);
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x00007638 File Offset: 0x00005838
	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0xC7F798", Offset = "0xC7F798", VA = "0xC7F798")]
	public bool IsSameExceptResolution(InterfaceProfile_Layout other, bool allowFixups = false)
	{
		return default(bool);
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0xC7F87C", Offset = "0xC7F87C", VA = "0xC7F87C")]
	private void CopyGroup(GUIPageIconGrouping dest, GUIPageIconGrouping src, bool copySerialiseSettings = false)
	{
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0xC7FA2C", Offset = "0xC7FA2C", VA = "0xC7FA2C")]
	private void CopyGroupList(List<GUIPageIconGrouping> dest, List<GUIPageIconGrouping> src, bool copySerialiseSettings = false)
	{
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0xC7FC3C", Offset = "0xC7FC3C", VA = "0xC7FC3C")]
	public void Copy(InterfaceProfile_Layout other, bool copySerialiseSettings = false)
	{
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0xC80248", Offset = "0xC80248", VA = "0xC80248")]
	private void CleanGroupList(List<GUIPageIconGrouping> dest, bool touchProfile)
	{
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0xC80534", Offset = "0xC80534", VA = "0xC80534")]
	public void Clean(bool touchProfile = false)
	{
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0xC805F0", Offset = "0xC805F0", VA = "0xC805F0")]
	public void OpenUI(GUIPageIcons.Category left, GUIPageIcons.Category right)
	{
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0xC81928", Offset = "0xC81928", VA = "0xC81928")]
	public void Close(bool shutdown = false)
	{
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00007650 File Offset: 0x00005850
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0xC81C0C", Offset = "0xC81C0C", VA = "0xC81C0C")]
	public GUIPageIcons.Category GetFirstSelectedCategory()
	{
		return GUIPageIcons.Category.Crafting;
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x00007668 File Offset: 0x00005868
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0xC77D98", Offset = "0xC77D98", VA = "0xC77D98")]
	public bool AnyOpen()
	{
		return default(bool);
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x00007680 File Offset: 0x00005880
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0xC81D90", Offset = "0xC81D90", VA = "0xC81D90")]
	private GUIPageIcons.Category RequiredCraftDupBanCategory()
	{
		return GUIPageIcons.Category.Crafting;
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00007698 File Offset: 0x00005898
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0xC81EFC", Offset = "0xC81EFC", VA = "0xC81EFC")]
	public bool IsMissingAllCraftDupBanCategories()
	{
		return default(bool);
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x000076B0 File Offset: 0x000058B0
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0xC82164", Offset = "0xC82164", VA = "0xC82164")]
	public bool IsMissingRequiredCraftDupBanCategory()
	{
		return default(bool);
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x000076C8 File Offset: 0x000058C8
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0xC822A8", Offset = "0xC822A8", VA = "0xC822A8")]
	private bool HasHousingIcon()
	{
		return default(bool);
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x000076E0 File Offset: 0x000058E0
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0xC82028", Offset = "0xC82028", VA = "0xC82028")]
	private bool HasCraftingIcon()
	{
		return default(bool);
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x000076F8 File Offset: 0x000058F8
	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0xC82044", Offset = "0xC82044", VA = "0xC82044")]
	private bool HasDuplicateIcon()
	{
		return default(bool);
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x00007710 File Offset: 0x00005910
	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0xC820D4", Offset = "0xC820D4", VA = "0xC820D4")]
	private bool HasBannerIcon()
	{
		return default(bool);
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x00007728 File Offset: 0x00005928
	[Token(Token = "0x6000D80")]
	[Address(RVA = "0xC822C4", Offset = "0xC822C4", VA = "0xC822C4")]
	private GUIPageIcons.Category FindReplacementCategoryIfNeeded(GUIPageIcons.Category category)
	{
		return GUIPageIcons.Category.Crafting;
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D81")]
	[Address(RVA = "0xC824F0", Offset = "0xC824F0", VA = "0xC824F0")]
	private void CleanPrimaryOptions()
	{
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D82")]
	[Address(RVA = "0xC82D3C", Offset = "0xC82D3C", VA = "0xC82D3C")]
	private void AddAvailable(GUIPageIcons.Category category)
	{
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D83")]
	[Address(RVA = "0xC80E10", Offset = "0xC80E10", VA = "0xC80E10")]
	public void RefreshAllItems()
	{
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D84")]
	[Address(RVA = "0xC8338C", Offset = "0xC8338C", VA = "0xC8338C")]
	public void DrawClosed()
	{
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D85")]
	[Address(RVA = "0xC834C4", Offset = "0xC834C4", VA = "0xC834C4")]
	public void ClearBanner()
	{
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D86")]
	[Address(RVA = "0xC8360C", Offset = "0xC8360C", VA = "0xC8360C")]
	public void Draw()
	{
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D87")]
	[Address(RVA = "0xC83C20", Offset = "0xC83C20", VA = "0xC83C20")]
	public void DrawEdit()
	{
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D88")]
	[Address(RVA = "0xC84D30", Offset = "0xC84D30", VA = "0xC84D30")]
	public void LeftRightPageController()
	{
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D89")]
	[Address(RVA = "0xC86280", Offset = "0xC86280", VA = "0xC86280")]
	public GUIControllerItem GetGroupUp(GUIPageIconGrouping sourceGroup, int column)
	{
		return null;
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0xC86604", Offset = "0xC86604", VA = "0xC86604")]
	public GUIControllerItem GetGroupDown(GUIPageIconGrouping sourceGroup, int column)
	{
		return null;
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0xC869B8", Offset = "0xC869B8", VA = "0xC869B8")]
	public GUIControllerItem GetGroupLeft(GUIPageIconGrouping sourceGroup, int row)
	{
		return null;
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0xC86C8C", Offset = "0xC86C8C", VA = "0xC86C8C")]
	public GUIControllerItem GetGroupRight(GUIPageIconGrouping sourceGroup, int row)
	{
		return null;
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0xC86F60", Offset = "0xC86F60", VA = "0xC86F60")]
	public InterfaceProfile_Layout()
	{
	}

	// Token: 0x04001541 RID: 5441
	[Token(Token = "0x4001541")]
	[FieldOffset(Offset = "0x8")]
	public string ProfileName;

	// Token: 0x04001542 RID: 5442
	[Token(Token = "0x4001542")]
	[FieldOffset(Offset = "0xC")]
	public int VerticalResolution;

	// Token: 0x04001543 RID: 5443
	[Token(Token = "0x4001543")]
	[FieldOffset(Offset = "0x10")]
	private Vector2 _minResolution;

	// Token: 0x04001544 RID: 5444
	[Token(Token = "0x4001544")]
	[FieldOffset(Offset = "0x18")]
	private float <PreSplitChangeMinVertRes>k__BackingField;

	// Token: 0x04001545 RID: 5445
	[Token(Token = "0x4001545")]
	[FieldOffset(Offset = "0x1C")]
	private float <PreSplitChangeVertRes>k__BackingField;

	// Token: 0x04001546 RID: 5446
	[Token(Token = "0x4001546")]
	[FieldOffset(Offset = "0x20")]
	private bool forceEquipmentExpanded;

	// Token: 0x04001547 RID: 5447
	[Token(Token = "0x4001547")]
	[FieldOffset(Offset = "0x21")]
	public bool NextLeftSameGroup;

	// Token: 0x04001548 RID: 5448
	[Token(Token = "0x4001548")]
	[FieldOffset(Offset = "0x24")]
	public GUIPageIcons.Category NextLeftCategory;

	// Token: 0x04001549 RID: 5449
	[Token(Token = "0x4001549")]
	[FieldOffset(Offset = "0x28")]
	public bool NextRightSameGroup;

	// Token: 0x0400154A RID: 5450
	[Token(Token = "0x400154A")]
	[FieldOffset(Offset = "0x2C")]
	public GUIPageIcons.Category NextRightCategory;

	// Token: 0x0400154B RID: 5451
	[Token(Token = "0x400154B")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<GUIPageIcons.Category, bool> GroupsCollapsed;

	// Token: 0x0400154C RID: 5452
	[Token(Token = "0x400154C")]
	[FieldOffset(Offset = "0x34")]
	public List<GUIPageIconGrouping> LeftGroupings;

	// Token: 0x0400154D RID: 5453
	[Token(Token = "0x400154D")]
	[FieldOffset(Offset = "0x38")]
	public List<GUIPageIconGrouping> RightGroupings;
}
