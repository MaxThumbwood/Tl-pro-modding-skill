using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001A9 RID: 425
[Token(Token = "0x20001A9")]
public class Bestiary_Layout : LayoutDefinition
{
	// Token: 0x06000C79 RID: 3193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0xC66A8C", Offset = "0xC66A8C", VA = "0xC66A8C")]
	private void Awake()
	{
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0xC66AE0", Offset = "0xC66AE0", VA = "0xC66AE0")]
	public Bestiary_Layout()
	{
	}

	// Token: 0x04000FDE RID: 4062
	[Token(Token = "0x4000FDE")]
	[FieldOffset(Offset = "0x0")]
	public static Bestiary_Layout Instance;

	// Token: 0x04000FDF RID: 4063
	[Token(Token = "0x4000FDF")]
	[FieldOffset(Offset = "0xC")]
	public TransactionButton_Layout BestiaryButton;

	// Token: 0x04000FE0 RID: 4064
	[Token(Token = "0x4000FE0")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x04000FE1 RID: 4065
	[Token(Token = "0x4000FE1")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Title;

	// Token: 0x04000FE2 RID: 4066
	[Token(Token = "0x4000FE2")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Back;

	// Token: 0x04000FE3 RID: 4067
	[Token(Token = "0x4000FE3")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout LeftRightSeperator;

	// Token: 0x04000FE4 RID: 4068
	[Token(Token = "0x4000FE4")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout MenuSeperator;

	// Token: 0x04000FE5 RID: 4069
	[Token(Token = "0x4000FE5")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout CoinsSeperator;

	// Token: 0x04000FE6 RID: 4070
	[Token(Token = "0x4000FE6")]
	[FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout BestiaryGrid;

	// Token: 0x04000FE7 RID: 4071
	[Token(Token = "0x4000FE7")]
	[FieldOffset(Offset = "0x2C")]
	public float BestiaryScale;

	// Token: 0x04000FE8 RID: 4072
	[Token(Token = "0x4000FE8")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Order;

	// Token: 0x04000FE9 RID: 4073
	[Token(Token = "0x4000FE9")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout OrderController;

	// Token: 0x04000FEA RID: 4074
	[Token(Token = "0x4000FEA")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Filters;

	// Token: 0x04000FEB RID: 4075
	[Token(Token = "0x4000FEB")]
	[FieldOffset(Offset = "0x3C")]
	public TransactionButton_Layout FiltersController;

	// Token: 0x04000FEC RID: 4076
	[Token(Token = "0x4000FEC")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Close;

	// Token: 0x04000FED RID: 4077
	[Token(Token = "0x4000FED")]
	[FieldOffset(Offset = "0x44")]
	public TransactionButton_Layout Loot;

	// Token: 0x04000FEE RID: 4078
	[Token(Token = "0x4000FEE")]
	[FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout LootController;

	// Token: 0x04000FEF RID: 4079
	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x4C")]
	public Panel_Layout LootBacking;

	// Token: 0x04000FF0 RID: 4080
	[Token(Token = "0x4000FF0")]
	[FieldOffset(Offset = "0x50")]
	public DraggableItemGrid_Layout LootGrid;

	// Token: 0x04000FF1 RID: 4081
	[Token(Token = "0x4000FF1")]
	[FieldOffset(Offset = "0x54")]
	public TransactionButton_Layout LootEntry;

	// Token: 0x04000FF2 RID: 4082
	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x58")]
	public String_Layout LootEntryCount;

	// Token: 0x04000FF3 RID: 4083
	[Token(Token = "0x4000FF3")]
	[FieldOffset(Offset = "0x5C")]
	public String_Layout UnlockProgress;

	// Token: 0x04000FF4 RID: 4084
	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x60")]
	public Panel_Layout UnlockBarBacking;

	// Token: 0x04000FF5 RID: 4085
	[Token(Token = "0x4000FF5")]
	[FieldOffset(Offset = "0x64")]
	public Panel_Layout UnlockBarProgress;

	// Token: 0x04000FF6 RID: 4086
	[Token(Token = "0x4000FF6")]
	[FieldOffset(Offset = "0x68")]
	public Panel_Layout ItemBacking;

	// Token: 0x04000FF7 RID: 4087
	[Token(Token = "0x4000FF7")]
	[FieldOffset(Offset = "0x6C")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04000FF8 RID: 4088
	[Token(Token = "0x4000FF8")]
	[FieldOffset(Offset = "0x70")]
	public Panel_Layout ItemImage;

	// Token: 0x04000FF9 RID: 4089
	[Token(Token = "0x4000FF9")]
	[FieldOffset(Offset = "0x74")]
	public String_Layout ItemId;

	// Token: 0x04000FFA RID: 4090
	[Token(Token = "0x4000FFA")]
	[FieldOffset(Offset = "0x78")]
	public float ItemLockedScale;

	// Token: 0x04000FFB RID: 4091
	[Token(Token = "0x4000FFB")]
	[FieldOffset(Offset = "0x7C")]
	public Panel_Layout FiltersBacking;

	// Token: 0x04000FFC RID: 4092
	[Token(Token = "0x4000FFC")]
	[FieldOffset(Offset = "0x80")]
	public ItemGrid_Layout FiltersGrid;

	// Token: 0x04000FFD RID: 4093
	[Token(Token = "0x4000FFD")]
	[FieldOffset(Offset = "0x84")]
	public TransactionButton_Layout FilterEntry;

	// Token: 0x04000FFE RID: 4094
	[Token(Token = "0x4000FFE")]
	[FieldOffset(Offset = "0x88")]
	public Panel_Layout SearchSeperator;

	// Token: 0x04000FFF RID: 4095
	[Token(Token = "0x4000FFF")]
	[FieldOffset(Offset = "0x8C")]
	public TransactionButton_Layout BeginSearch;

	// Token: 0x04001000 RID: 4096
	[Token(Token = "0x4001000")]
	[FieldOffset(Offset = "0x90")]
	public float SearchTextWrapSize;

	// Token: 0x04001001 RID: 4097
	[Token(Token = "0x4001001")]
	[FieldOffset(Offset = "0x94")]
	public String_Layout SearchText;

	// Token: 0x04001002 RID: 4098
	[Token(Token = "0x4001002")]
	[FieldOffset(Offset = "0x98")]
	public Color SearchValidTextColor;

	// Token: 0x04001003 RID: 4099
	[Token(Token = "0x4001003")]
	[FieldOffset(Offset = "0x9C")]
	public Color SearchInvalidTextColor;

	// Token: 0x04001004 RID: 4100
	[Token(Token = "0x4001004")]
	[FieldOffset(Offset = "0xA0")]
	public Panel_Layout OrdersBacking;

	// Token: 0x04001005 RID: 4101
	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0xA4")]
	public ItemGrid_Layout OrdersGrid;

	// Token: 0x04001006 RID: 4102
	[Token(Token = "0x4001006")]
	[FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout OrderEntry;

	// Token: 0x04001007 RID: 4103
	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0xAC")]
	public Texture_Layout[] OrderIcons;

	// Token: 0x04001008 RID: 4104
	[Token(Token = "0x4001008")]
	[FieldOffset(Offset = "0xB0")]
	public Panel_Layout EntryNameBacking;

	// Token: 0x04001009 RID: 4105
	[Token(Token = "0x4001009")]
	[FieldOffset(Offset = "0xB4")]
	public String_Layout EntryName;

	// Token: 0x0400100A RID: 4106
	[Token(Token = "0x400100A")]
	[FieldOffset(Offset = "0xB8")]
	public Panel_Layout EntryImage;

	// Token: 0x0400100B RID: 4107
	[Token(Token = "0x400100B")]
	[FieldOffset(Offset = "0xBC")]
	public Panel_Layout EntryImageOverlay;

	// Token: 0x0400100C RID: 4108
	[Token(Token = "0x400100C")]
	[FieldOffset(Offset = "0xC0")]
	public Panel_Layout EntryScrollDivider;

	// Token: 0x0400100D RID: 4109
	[Token(Token = "0x400100D")]
	[FieldOffset(Offset = "0xC4")]
	public ItemGrid_Layout EntryStars;

	// Token: 0x0400100E RID: 4110
	[Token(Token = "0x400100E")]
	[FieldOffset(Offset = "0xC8")]
	public float EntryStarScale;

	// Token: 0x0400100F RID: 4111
	[Token(Token = "0x400100F")]
	[FieldOffset(Offset = "0xCC")]
	public ItemGrid_Layout EntrySpawns;

	// Token: 0x04001010 RID: 4112
	[Token(Token = "0x4001010")]
	[FieldOffset(Offset = "0xD0")]
	public Panel_Layout EntrySpawnBacking;

	// Token: 0x04001011 RID: 4113
	[Token(Token = "0x4001011")]
	[FieldOffset(Offset = "0xD4")]
	public Panel_Layout EntrySpawnIcon;

	// Token: 0x04001012 RID: 4114
	[Token(Token = "0x4001012")]
	[FieldOffset(Offset = "0xD8")]
	public String_Layout EntrySpawnType;

	// Token: 0x04001013 RID: 4115
	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0xDC")]
	public TransactionButton_Layout EntryHealth;

	// Token: 0x04001014 RID: 4116
	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout EntryAttack;

	// Token: 0x04001015 RID: 4117
	[Token(Token = "0x4001015")]
	[FieldOffset(Offset = "0xE4")]
	public TransactionButton_Layout EntryDefence;

	// Token: 0x04001016 RID: 4118
	[Token(Token = "0x4001016")]
	[FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout EntryKnockback;

	// Token: 0x04001017 RID: 4119
	[Token(Token = "0x4001017")]
	[FieldOffset(Offset = "0xEC")]
	public TransactionButton_Layout EntryKills;

	// Token: 0x04001018 RID: 4120
	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout EntryCoinDropBacking;

	// Token: 0x04001019 RID: 4121
	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0xF4")]
	public TransactionButton_Layout EntryCoinPlatinum;

	// Token: 0x0400101A RID: 4122
	[Token(Token = "0x400101A")]
	[FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout EntryCoinGold;

	// Token: 0x0400101B RID: 4123
	[Token(Token = "0x400101B")]
	[FieldOffset(Offset = "0xFC")]
	public TransactionButton_Layout EntryCoinSilver;

	// Token: 0x0400101C RID: 4124
	[Token(Token = "0x400101C")]
	[FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout EntryCoinCopper;

	// Token: 0x0400101D RID: 4125
	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0x104")]
	public String_Layout EntryDescription;
}
