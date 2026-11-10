using System;
using Il2CppDummyDll;

// Token: 0x0200022E RID: 558
[Token(Token = "0x200022E")]
public class PlayerSelectMenu_Layout : LayoutDefinition
{
	// Token: 0x06000E1B RID: 3611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0xC91578", Offset = "0xC91578", VA = "0xC91578")]
	private void Awake()
	{
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00007908 File Offset: 0x00005B08
	[Token(Token = "0x17000173")]
	public int PlatformMaxPlayers
	{
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0xC915CC", Offset = "0xC915CC", VA = "0xC915CC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1D")]
	[Address(RVA = "0xC9164C", Offset = "0xC9164C", VA = "0xC9164C")]
	public PlayerSelectMenu_Layout()
	{
	}

	// Token: 0x0400184B RID: 6219
	[Token(Token = "0x400184B")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerSelectMenu_Layout Instance;

	// Token: 0x0400184C RID: 6220
	[Token(Token = "0x400184C")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x0400184D RID: 6221
	[Token(Token = "0x400184D")]
	[FieldOffset(Offset = "0x10")]
	public DraggableItemGrid_Layout PlayerGrid;

	// Token: 0x0400184E RID: 6222
	[Token(Token = "0x400184E")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Title;

	// Token: 0x0400184F RID: 6223
	[Token(Token = "0x400184F")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout New;

	// Token: 0x04001850 RID: 6224
	[Token(Token = "0x4001850")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Back;

	// Token: 0x04001851 RID: 6225
	[Token(Token = "0x4001851")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001852 RID: 6226
	[Token(Token = "0x4001852")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Options;

	// Token: 0x04001853 RID: 6227
	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout OptionsBacking;

	// Token: 0x04001854 RID: 6228
	[Token(Token = "0x4001854")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x04001855 RID: 6229
	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x30")]
	public Panel_Layout OptionsGreyout;

	// Token: 0x04001856 RID: 6230
	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout Play;

	// Token: 0x04001857 RID: 6231
	[Token(Token = "0x4001857")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout EditName;

	// Token: 0x04001858 RID: 6232
	[Token(Token = "0x4001858")]
	[FieldOffset(Offset = "0x3C")]
	public TransactionButton_Layout Delete;

	// Token: 0x04001859 RID: 6233
	[Token(Token = "0x4001859")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Favorite;

	// Token: 0x0400185A RID: 6234
	[Token(Token = "0x400185A")]
	[FieldOffset(Offset = "0x44")]
	public TransactionButton_Layout Cloud;

	// Token: 0x0400185B RID: 6235
	[Token(Token = "0x400185B")]
	[FieldOffset(Offset = "0x48")]
	public SelectPlayerFavoriteIcons FavoriteIcons;

	// Token: 0x0400185C RID: 6236
	[Token(Token = "0x400185C")]
	[FieldOffset(Offset = "0x4C")]
	public SelectPlayerFavoriteIcons CloudIcons;

	// Token: 0x0400185D RID: 6237
	[Token(Token = "0x400185D")]
	[FieldOffset(Offset = "0x50")]
	public Panel_Layout ItemBacking;

	// Token: 0x0400185E RID: 6238
	[Token(Token = "0x400185E")]
	[FieldOffset(Offset = "0x54")]
	public Panel_Layout ItemGreyout;

	// Token: 0x0400185F RID: 6239
	[Token(Token = "0x400185F")]
	[FieldOffset(Offset = "0x58")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04001860 RID: 6240
	[Token(Token = "0x4001860")]
	[FieldOffset(Offset = "0x5C")]
	public Panel_Layout ItemSelectedGreyout;

	// Token: 0x04001861 RID: 6241
	[Token(Token = "0x4001861")]
	[FieldOffset(Offset = "0x60")]
	public Button_Layout ItemPlay;

	// Token: 0x04001862 RID: 6242
	[Token(Token = "0x4001862")]
	[FieldOffset(Offset = "0x64")]
	public Button_Layout ItemEditName;

	// Token: 0x04001863 RID: 6243
	[Token(Token = "0x4001863")]
	[FieldOffset(Offset = "0x68")]
	public Button_Layout ItemDelete;

	// Token: 0x04001864 RID: 6244
	[Token(Token = "0x4001864")]
	[FieldOffset(Offset = "0x6C")]
	public Button_Layout ItemFavourite;

	// Token: 0x04001865 RID: 6245
	[Token(Token = "0x4001865")]
	[FieldOffset(Offset = "0x70")]
	public Button_Layout ItemCloud;

	// Token: 0x04001866 RID: 6246
	[Token(Token = "0x4001866")]
	[FieldOffset(Offset = "0x74")]
	public Button_Layout ItemDivider;

	// Token: 0x04001867 RID: 6247
	[Token(Token = "0x4001867")]
	[FieldOffset(Offset = "0x78")]
	public Panel_Layout ItemHealthBacking;

	// Token: 0x04001868 RID: 6248
	[Token(Token = "0x4001868")]
	[FieldOffset(Offset = "0x7C")]
	public Button_Layout ItemHealthIcon;

	// Token: 0x04001869 RID: 6249
	[Token(Token = "0x4001869")]
	[FieldOffset(Offset = "0x80")]
	public String_Layout ItemHealth;

	// Token: 0x0400186A RID: 6250
	[Token(Token = "0x400186A")]
	[FieldOffset(Offset = "0x84")]
	public Panel_Layout ItemManaBacking;

	// Token: 0x0400186B RID: 6251
	[Token(Token = "0x400186B")]
	[FieldOffset(Offset = "0x88")]
	public Button_Layout ItemManaIcon;

	// Token: 0x0400186C RID: 6252
	[Token(Token = "0x400186C")]
	[FieldOffset(Offset = "0x8C")]
	public String_Layout ItemMana;

	// Token: 0x0400186D RID: 6253
	[Token(Token = "0x400186D")]
	[FieldOffset(Offset = "0x90")]
	public String_Layout ItemName;

	// Token: 0x0400186E RID: 6254
	[Token(Token = "0x400186E")]
	[FieldOffset(Offset = "0x94")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x0400186F RID: 6255
	[Token(Token = "0x400186F")]
	[FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout PlayerName;

	// Token: 0x04001870 RID: 6256
	[Token(Token = "0x4001870")]
	[FieldOffset(Offset = "0x9C")]
	public Panel_Layout ItemTimeBacking;

	// Token: 0x04001871 RID: 6257
	[Token(Token = "0x4001871")]
	[FieldOffset(Offset = "0xA0")]
	public String_Layout ItemTime;

	// Token: 0x04001872 RID: 6258
	[Token(Token = "0x4001872")]
	[FieldOffset(Offset = "0xA4")]
	public Panel_Layout ItemModeBacking;

	// Token: 0x04001873 RID: 6259
	[Token(Token = "0x4001873")]
	[FieldOffset(Offset = "0xA8")]
	public String_Layout ItemMode;

	// Token: 0x04001874 RID: 6260
	[Token(Token = "0x4001874")]
	[FieldOffset(Offset = "0xAC")]
	public Panel_Layout ItemImage;

	// Token: 0x04001875 RID: 6261
	[Token(Token = "0x4001875")]
	[FieldOffset(Offset = "0xB0")]
	public String_Layout SyncInformation;

	// Token: 0x04001876 RID: 6262
	[Token(Token = "0x4001876")]
	[FieldOffset(Offset = "0xB4")]
	public Button_Layout SyncIcon;

	// Token: 0x04001877 RID: 6263
	[Token(Token = "0x4001877")]
	[FieldOffset(Offset = "0xB8")]
	public int MaxPlayers;

	// Token: 0x04001878 RID: 6264
	[Token(Token = "0x4001878")]
	[FieldOffset(Offset = "0xBC")]
	public int MaxPlayers_Stadia;

	// Token: 0x04001879 RID: 6265
	[Token(Token = "0x4001879")]
	[FieldOffset(Offset = "0xC0")]
	public bool FavouriteVisualScroll;
}
