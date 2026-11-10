using System;
using Il2CppDummyDll;

// Token: 0x0200025E RID: 606
[Token(Token = "0x200025E")]
public class SaveDataViewPlayer_Layout : LayoutDefinition
{
	// Token: 0x06000E79 RID: 3705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E79")]
	[Address(RVA = "0xC95250", Offset = "0xC95250", VA = "0xC95250")]
	private void Awake()
	{
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0xC952A4", Offset = "0xC952A4", VA = "0xC952A4")]
	public SaveDataViewPlayer_Layout()
	{
	}

	// Token: 0x04001CD0 RID: 7376
	[Token(Token = "0x4001CD0")]
	[FieldOffset(Offset = "0x0")]
	public static SaveDataViewPlayer_Layout Instance;

	// Token: 0x04001CD1 RID: 7377
	[Token(Token = "0x4001CD1")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x04001CD2 RID: 7378
	[Token(Token = "0x4001CD2")]
	[FieldOffset(Offset = "0x10")]
	public DraggableItemGrid_Layout PlayerGrid;

	// Token: 0x04001CD3 RID: 7379
	[Token(Token = "0x4001CD3")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Title;

	// Token: 0x04001CD4 RID: 7380
	[Token(Token = "0x4001CD4")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout New;

	// Token: 0x04001CD5 RID: 7381
	[Token(Token = "0x4001CD5")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Back;

	// Token: 0x04001CD6 RID: 7382
	[Token(Token = "0x4001CD6")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Options;

	// Token: 0x04001CD7 RID: 7383
	[Token(Token = "0x4001CD7")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout OptionsBacking;

	// Token: 0x04001CD8 RID: 7384
	[Token(Token = "0x4001CD8")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x04001CD9 RID: 7385
	[Token(Token = "0x4001CD9")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout OptionsGreyout;

	// Token: 0x04001CDA RID: 7386
	[Token(Token = "0x4001CDA")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Play;

	// Token: 0x04001CDB RID: 7387
	[Token(Token = "0x4001CDB")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout Delete;

	// Token: 0x04001CDC RID: 7388
	[Token(Token = "0x4001CDC")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Favorite;

	// Token: 0x04001CDD RID: 7389
	[Token(Token = "0x4001CDD")]
	[FieldOffset(Offset = "0x3C")]
	public TransactionButton_Layout Cloud;

	// Token: 0x04001CDE RID: 7390
	[Token(Token = "0x4001CDE")]
	[FieldOffset(Offset = "0x40")]
	public SelectPlayerFavoriteIcons FavoriteIcons;

	// Token: 0x04001CDF RID: 7391
	[Token(Token = "0x4001CDF")]
	[FieldOffset(Offset = "0x44")]
	public SelectPlayerFavoriteIcons CloudIcons;

	// Token: 0x04001CE0 RID: 7392
	[Token(Token = "0x4001CE0")]
	[FieldOffset(Offset = "0x48")]
	public Panel_Layout ItemBacking;

	// Token: 0x04001CE1 RID: 7393
	[Token(Token = "0x4001CE1")]
	[FieldOffset(Offset = "0x4C")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04001CE2 RID: 7394
	[Token(Token = "0x4001CE2")]
	[FieldOffset(Offset = "0x50")]
	public Button_Layout ItemPlay;

	// Token: 0x04001CE3 RID: 7395
	[Token(Token = "0x4001CE3")]
	[FieldOffset(Offset = "0x54")]
	public Button_Layout ItemDelete;

	// Token: 0x04001CE4 RID: 7396
	[Token(Token = "0x4001CE4")]
	[FieldOffset(Offset = "0x58")]
	public Button_Layout ItemFavourite;

	// Token: 0x04001CE5 RID: 7397
	[Token(Token = "0x4001CE5")]
	[FieldOffset(Offset = "0x5C")]
	public Button_Layout ItemCloud;

	// Token: 0x04001CE6 RID: 7398
	[Token(Token = "0x4001CE6")]
	[FieldOffset(Offset = "0x60")]
	public Button_Layout ItemDivider;

	// Token: 0x04001CE7 RID: 7399
	[Token(Token = "0x4001CE7")]
	[FieldOffset(Offset = "0x64")]
	public Panel_Layout ItemHealthBacking;

	// Token: 0x04001CE8 RID: 7400
	[Token(Token = "0x4001CE8")]
	[FieldOffset(Offset = "0x68")]
	public Button_Layout ItemHealthIcon;

	// Token: 0x04001CE9 RID: 7401
	[Token(Token = "0x4001CE9")]
	[FieldOffset(Offset = "0x6C")]
	public String_Layout ItemHealth;

	// Token: 0x04001CEA RID: 7402
	[Token(Token = "0x4001CEA")]
	[FieldOffset(Offset = "0x70")]
	public Panel_Layout ItemManaBacking;

	// Token: 0x04001CEB RID: 7403
	[Token(Token = "0x4001CEB")]
	[FieldOffset(Offset = "0x74")]
	public Button_Layout ItemManaIcon;

	// Token: 0x04001CEC RID: 7404
	[Token(Token = "0x4001CEC")]
	[FieldOffset(Offset = "0x78")]
	public String_Layout ItemMana;

	// Token: 0x04001CED RID: 7405
	[Token(Token = "0x4001CED")]
	[FieldOffset(Offset = "0x7C")]
	public String_Layout ItemName;

	// Token: 0x04001CEE RID: 7406
	[Token(Token = "0x4001CEE")]
	[FieldOffset(Offset = "0x80")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x04001CEF RID: 7407
	[Token(Token = "0x4001CEF")]
	[FieldOffset(Offset = "0x84")]
	public Panel_Layout ItemTimeBacking;

	// Token: 0x04001CF0 RID: 7408
	[Token(Token = "0x4001CF0")]
	[FieldOffset(Offset = "0x88")]
	public String_Layout ItemTime;

	// Token: 0x04001CF1 RID: 7409
	[Token(Token = "0x4001CF1")]
	[FieldOffset(Offset = "0x8C")]
	public Panel_Layout ItemModeBacking;

	// Token: 0x04001CF2 RID: 7410
	[Token(Token = "0x4001CF2")]
	[FieldOffset(Offset = "0x90")]
	public String_Layout ItemMode;

	// Token: 0x04001CF3 RID: 7411
	[Token(Token = "0x4001CF3")]
	[FieldOffset(Offset = "0x94")]
	public Panel_Layout ItemImage;
}
