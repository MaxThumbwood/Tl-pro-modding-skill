using System;
using Il2CppDummyDll;

// Token: 0x0200024A RID: 586
[Token(Token = "0x200024A")]
public class WorldSelectMenu_Layout : LayoutDefinition
{
	// Token: 0x06000E47 RID: 3655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E47")]
	[Address(RVA = "0xC934F8", Offset = "0xC934F8", VA = "0xC934F8")]
	private void Awake()
	{
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000174")]
	public DraggableItemGrid_Layout DisplayGrid
	{
		[Token(Token = "0x6000E48")]
		[Address(RVA = "0xC9354C", Offset = "0xC9354C", VA = "0xC9354C")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00007938 File Offset: 0x00005B38
	[Token(Token = "0x17000175")]
	public int PlatformMaxWorlds
	{
		[Token(Token = "0x6000E49")]
		[Address(RVA = "0xC93604", Offset = "0xC93604", VA = "0xC93604")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0xC93684", Offset = "0xC93684", VA = "0xC93684")]
	public WorldSelectMenu_Layout()
	{
	}

	// Token: 0x04001A95 RID: 6805
	[Token(Token = "0x4001A95")]
	[FieldOffset(Offset = "0x0")]
	public static WorldSelectMenu_Layout Instance;

	// Token: 0x04001A96 RID: 6806
	[Token(Token = "0x4001A96")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x04001A97 RID: 6807
	[Token(Token = "0x4001A97")]
	[FieldOffset(Offset = "0x10")]
	public DraggableItemGrid_Layout WorldGrid;

	// Token: 0x04001A98 RID: 6808
	[Token(Token = "0x4001A98")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Title;

	// Token: 0x04001A99 RID: 6809
	[Token(Token = "0x4001A99")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout New;

	// Token: 0x04001A9A RID: 6810
	[Token(Token = "0x4001A9A")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Back;

	// Token: 0x04001A9B RID: 6811
	[Token(Token = "0x4001A9B")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001A9C RID: 6812
	[Token(Token = "0x4001A9C")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout NoDedicatedServer;

	// Token: 0x04001A9D RID: 6813
	[Token(Token = "0x4001A9D")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Options;

	// Token: 0x04001A9E RID: 6814
	[Token(Token = "0x4001A9E")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout OptionsGreyout;

	// Token: 0x04001A9F RID: 6815
	[Token(Token = "0x4001A9F")]
	[FieldOffset(Offset = "0x30")]
	public Panel_Layout OptionsBacking;

	// Token: 0x04001AA0 RID: 6816
	[Token(Token = "0x4001AA0")]
	[FieldOffset(Offset = "0x34")]
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x04001AA1 RID: 6817
	[Token(Token = "0x4001AA1")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Play;

	// Token: 0x04001AA2 RID: 6818
	[Token(Token = "0x4001AA2")]
	[FieldOffset(Offset = "0x3C")]
	public TransactionButton_Layout Delete;

	// Token: 0x04001AA3 RID: 6819
	[Token(Token = "0x4001AA3")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Favorite;

	// Token: 0x04001AA4 RID: 6820
	[Token(Token = "0x4001AA4")]
	[FieldOffset(Offset = "0x44")]
	public TransactionButton_Layout Rename;

	// Token: 0x04001AA5 RID: 6821
	[Token(Token = "0x4001AA5")]
	[FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout SeedDisplay;

	// Token: 0x04001AA6 RID: 6822
	[Token(Token = "0x4001AA6")]
	[FieldOffset(Offset = "0x4C")]
	public TransactionButton_Layout Cloud;

	// Token: 0x04001AA7 RID: 6823
	[Token(Token = "0x4001AA7")]
	[FieldOffset(Offset = "0x50")]
	public SelectWorldFavoriteIcons FavoriteIcons;

	// Token: 0x04001AA8 RID: 6824
	[Token(Token = "0x4001AA8")]
	[FieldOffset(Offset = "0x54")]
	public SelectWorldFavoriteIcons CloudIcons;

	// Token: 0x04001AA9 RID: 6825
	[Token(Token = "0x4001AA9")]
	[FieldOffset(Offset = "0x58")]
	public Panel_Layout ItemBacking;

	// Token: 0x04001AAA RID: 6826
	[Token(Token = "0x4001AAA")]
	[FieldOffset(Offset = "0x5C")]
	public Panel_Layout ItemGreyout;

	// Token: 0x04001AAB RID: 6827
	[Token(Token = "0x4001AAB")]
	[FieldOffset(Offset = "0x60")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04001AAC RID: 6828
	[Token(Token = "0x4001AAC")]
	[FieldOffset(Offset = "0x64")]
	public Panel_Layout ItemSelectedGreyout;

	// Token: 0x04001AAD RID: 6829
	[Token(Token = "0x4001AAD")]
	[FieldOffset(Offset = "0x68")]
	public Button_Layout ItemPlay;

	// Token: 0x04001AAE RID: 6830
	[Token(Token = "0x4001AAE")]
	[FieldOffset(Offset = "0x6C")]
	public Button_Layout ItemDelete;

	// Token: 0x04001AAF RID: 6831
	[Token(Token = "0x4001AAF")]
	[FieldOffset(Offset = "0x70")]
	public Button_Layout ItemFavourite;

	// Token: 0x04001AB0 RID: 6832
	[Token(Token = "0x4001AB0")]
	[FieldOffset(Offset = "0x74")]
	public Button_Layout ItemRename;

	// Token: 0x04001AB1 RID: 6833
	[Token(Token = "0x4001AB1")]
	[FieldOffset(Offset = "0x78")]
	public Button_Layout ItemSeedDisplay;

	// Token: 0x04001AB2 RID: 6834
	[Token(Token = "0x4001AB2")]
	[FieldOffset(Offset = "0x7C")]
	public Button_Layout ItemCloud;

	// Token: 0x04001AB3 RID: 6835
	[Token(Token = "0x4001AB3")]
	[FieldOffset(Offset = "0x80")]
	public Button_Layout PlayedByActivePlayer;

	// Token: 0x04001AB4 RID: 6836
	[Token(Token = "0x4001AB4")]
	[FieldOffset(Offset = "0x84")]
	public Button_Layout ItemDivider;

	// Token: 0x04001AB5 RID: 6837
	[Token(Token = "0x4001AB5")]
	[FieldOffset(Offset = "0x88")]
	public String_Layout ItemName;

	// Token: 0x04001AB6 RID: 6838
	[Token(Token = "0x4001AB6")]
	[FieldOffset(Offset = "0x8C")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x04001AB7 RID: 6839
	[Token(Token = "0x4001AB7")]
	[FieldOffset(Offset = "0x90")]
	public Panel_Layout ItemTimeBacking;

	// Token: 0x04001AB8 RID: 6840
	[Token(Token = "0x4001AB8")]
	[FieldOffset(Offset = "0x94")]
	public String_Layout ItemTime;

	// Token: 0x04001AB9 RID: 6841
	[Token(Token = "0x4001AB9")]
	[FieldOffset(Offset = "0x98")]
	public Panel_Layout ItemModeBacking;

	// Token: 0x04001ABA RID: 6842
	[Token(Token = "0x4001ABA")]
	[FieldOffset(Offset = "0x9C")]
	public String_Layout ItemMode;

	// Token: 0x04001ABB RID: 6843
	[Token(Token = "0x4001ABB")]
	[FieldOffset(Offset = "0xA0")]
	public Panel_Layout ItemSizeBacking;

	// Token: 0x04001ABC RID: 6844
	[Token(Token = "0x4001ABC")]
	[FieldOffset(Offset = "0xA4")]
	public String_Layout ItemSize;

	// Token: 0x04001ABD RID: 6845
	[Token(Token = "0x4001ABD")]
	[FieldOffset(Offset = "0xA8")]
	public Panel_Layout ItemSeedBacking;

	// Token: 0x04001ABE RID: 6846
	[Token(Token = "0x4001ABE")]
	[FieldOffset(Offset = "0xAC")]
	public String_Layout ItemSeed;

	// Token: 0x04001ABF RID: 6847
	[Token(Token = "0x4001ABF")]
	[FieldOffset(Offset = "0xB0")]
	public float ItemSeedWrapSpeed;

	// Token: 0x04001AC0 RID: 6848
	[Token(Token = "0x4001AC0")]
	[FieldOffset(Offset = "0xB4")]
	public Panel_Layout ItemImage;

	// Token: 0x04001AC1 RID: 6849
	[Token(Token = "0x4001AC1")]
	[FieldOffset(Offset = "0xB8")]
	public Panel_Layout CompletedItemImage;

	// Token: 0x04001AC2 RID: 6850
	[Token(Token = "0x4001AC2")]
	[FieldOffset(Offset = "0xBC")]
	public Panel_Layout ItemMixedSeed;

	// Token: 0x04001AC3 RID: 6851
	[Token(Token = "0x4001AC3")]
	[FieldOffset(Offset = "0xC0")]
	public int MaxWorlds;

	// Token: 0x04001AC4 RID: 6852
	[Token(Token = "0x4001AC4")]
	[FieldOffset(Offset = "0xC4")]
	public int MaxWorlds_Stadia;

	// Token: 0x04001AC5 RID: 6853
	[Token(Token = "0x4001AC5")]
	[FieldOffset(Offset = "0xC8")]
	public bool FavouriteVisualScroll;

	// Token: 0x04001AC6 RID: 6854
	[Token(Token = "0x4001AC6")]
	[FieldOffset(Offset = "0xCC")]
	public String_Layout SyncInformation;

	// Token: 0x04001AC7 RID: 6855
	[Token(Token = "0x4001AC7")]
	[FieldOffset(Offset = "0xD0")]
	public Button_Layout SyncIcon;

	// Token: 0x04001AC8 RID: 6856
	[Token(Token = "0x4001AC8")]
	[FieldOffset(Offset = "0xD4")]
	public GUIWorldSelectMenu.WorldRenameOption worldRenameOption;
}
