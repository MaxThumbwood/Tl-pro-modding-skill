using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000226 RID: 550
[Token(Token = "0x2000226")]
public class MultiplayerLobby_Layout : LayoutDefinition
{
	// Token: 0x06000E0B RID: 3595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0xC90D74", Offset = "0xC90D74", VA = "0xC90D74")]
	private void Awake()
	{
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0xC90DC8", Offset = "0xC90DC8", VA = "0xC90DC8")]
	public Panel_Layout GetFriendLayout(int index)
	{
		return null;
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0xC90E30", Offset = "0xC90E30", VA = "0xC90E30")]
	public MultiplayerLobby_Layout()
	{
	}

	// Token: 0x04001798 RID: 6040
	[Token(Token = "0x4001798")]
	[FieldOffset(Offset = "0x0")]
	public static MultiplayerLobby_Layout Instance;

	// Token: 0x04001799 RID: 6041
	[Token(Token = "0x4001799")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x0400179A RID: 6042
	[Token(Token = "0x400179A")]
	[FieldOffset(Offset = "0x10")]
	public StringButton_Layout Title;

	// Token: 0x0400179B RID: 6043
	[Token(Token = "0x400179B")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Options;

	// Token: 0x0400179C RID: 6044
	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout OptionsBacking;

	// Token: 0x0400179D RID: 6045
	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout OptionsGreyout;

	// Token: 0x0400179E RID: 6046
	[Token(Token = "0x400179E")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout LB;

	// Token: 0x0400179F RID: 6047
	[Token(Token = "0x400179F")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout RB;

	// Token: 0x040017A0 RID: 6048
	[Token(Token = "0x40017A0")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Local;

	// Token: 0x040017A1 RID: 6049
	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout Dedicated;

	// Token: 0x040017A2 RID: 6050
	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Settings;

	// Token: 0x040017A3 RID: 6051
	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout Friends;

	// Token: 0x040017A4 RID: 6052
	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout MenuDivider;

	// Token: 0x040017A5 RID: 6053
	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x3C")]
	public Panel_Layout MenuDivider2;

	// Token: 0x040017A6 RID: 6054
	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Back;

	// Token: 0x040017A7 RID: 6055
	[Token(Token = "0x40017A7")]
	[FieldOffset(Offset = "0x44")]
	public TransactionButton_Layout Join;

	// Token: 0x040017A8 RID: 6056
	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Delete;

	// Token: 0x040017A9 RID: 6057
	[Token(Token = "0x40017A9")]
	[FieldOffset(Offset = "0x4C")]
	public TransactionButton_Layout Edit;

	// Token: 0x040017AA RID: 6058
	[Token(Token = "0x40017AA")]
	[FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Favorite;

	// Token: 0x040017AB RID: 6059
	[Token(Token = "0x40017AB")]
	[FieldOffset(Offset = "0x54")]
	public TransactionButton_Layout PlatformInvite;

	// Token: 0x040017AC RID: 6060
	[Token(Token = "0x40017AC")]
	[FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Profile;

	// Token: 0x040017AD RID: 6061
	[Token(Token = "0x40017AD")]
	[FieldOffset(Offset = "0x5C")]
	public Panel_Layout Friend1;

	// Token: 0x040017AE RID: 6062
	[Token(Token = "0x40017AE")]
	[FieldOffset(Offset = "0x60")]
	public Panel_Layout Friend2;

	// Token: 0x040017AF RID: 6063
	[Token(Token = "0x40017AF")]
	[FieldOffset(Offset = "0x64")]
	public Panel_Layout Friend3;

	// Token: 0x040017B0 RID: 6064
	[Token(Token = "0x40017B0")]
	[FieldOffset(Offset = "0x68")]
	public Panel_Layout Friend4;

	// Token: 0x040017B1 RID: 6065
	[Token(Token = "0x40017B1")]
	[FieldOffset(Offset = "0x6C")]
	public Panel_Layout Friend5;

	// Token: 0x040017B2 RID: 6066
	[Token(Token = "0x40017B2")]
	[FieldOffset(Offset = "0x70")]
	public bool ShowPlatformInvite;

	// Token: 0x040017B3 RID: 6067
	[Token(Token = "0x40017B3")]
	[FieldOffset(Offset = "0x71")]
	public bool AlwaysShowPlatformInvite;

	// Token: 0x040017B4 RID: 6068
	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0x74")]
	public DraggableItemGrid_Layout HostGrid;

	// Token: 0x040017B5 RID: 6069
	[Token(Token = "0x40017B5")]
	[FieldOffset(Offset = "0x78")]
	public DraggableItemGrid_Layout JoinGrid;

	// Token: 0x040017B6 RID: 6070
	[Token(Token = "0x40017B6")]
	[FieldOffset(Offset = "0x7C")]
	public TransactionButton_Layout JoinNew;

	// Token: 0x040017B7 RID: 6071
	[Token(Token = "0x40017B7")]
	[FieldOffset(Offset = "0x80")]
	public DraggableItemGrid_Layout FriendsGrid;

	// Token: 0x040017B8 RID: 6072
	[Token(Token = "0x40017B8")]
	[FieldOffset(Offset = "0x84")]
	public DraggableItemGrid_Layout LocalGrid;

	// Token: 0x040017B9 RID: 6073
	[Token(Token = "0x40017B9")]
	[FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout LocalNew;

	// Token: 0x040017BA RID: 6074
	[Token(Token = "0x40017BA")]
	[FieldOffset(Offset = "0x8C")]
	public String_Layout NoFriendsText;

	// Token: 0x040017BB RID: 6075
	[Token(Token = "0x40017BB")]
	[FieldOffset(Offset = "0x90")]
	public String_Layout NoServerEntriesText;

	// Token: 0x040017BC RID: 6076
	[Token(Token = "0x40017BC")]
	[FieldOffset(Offset = "0x94")]
	public DraggableItemGrid_Layout DedicatedGrid;

	// Token: 0x040017BD RID: 6077
	[Token(Token = "0x40017BD")]
	[FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout DedicatedNew;

	// Token: 0x040017BE RID: 6078
	[Token(Token = "0x40017BE")]
	[FieldOffset(Offset = "0x9C")]
	public TransactionButton_Layout Header;

	// Token: 0x040017BF RID: 6079
	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0xA0")]
	public Button_Layout HeaderIcon;

	// Token: 0x040017C0 RID: 6080
	[Token(Token = "0x40017C0")]
	[FieldOffset(Offset = "0xA4")]
	public Panel_Layout HeaderCollapseIcon;

	// Token: 0x040017C1 RID: 6081
	[Token(Token = "0x40017C1")]
	[FieldOffset(Offset = "0xA8")]
	public Panel_Layout HeaderExpandIcon;

	// Token: 0x040017C2 RID: 6082
	[Token(Token = "0x40017C2")]
	[FieldOffset(Offset = "0xAC")]
	public Button_Layout HeaderSearchingIcon;

	// Token: 0x040017C3 RID: 6083
	[Token(Token = "0x40017C3")]
	[FieldOffset(Offset = "0xB0")]
	public String_Layout HeaderItemCount;

	// Token: 0x040017C4 RID: 6084
	[Token(Token = "0x40017C4")]
	[FieldOffset(Offset = "0xB4")]
	public Texture_Layout FriendServerHeaderIcon;

	// Token: 0x040017C5 RID: 6085
	[Token(Token = "0x40017C5")]
	[FieldOffset(Offset = "0xB8")]
	public Texture_Layout LANServerHeaderIcon;

	// Token: 0x040017C6 RID: 6086
	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0xBC")]
	public Texture_Layout DedicatedServerHeaderIcon;

	// Token: 0x040017C7 RID: 6087
	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout InviteCodeButton;

	// Token: 0x040017C8 RID: 6088
	[Token(Token = "0x40017C8")]
	[FieldOffset(Offset = "0xC4")]
	public String_Layout InviteCodeTitle;

	// Token: 0x040017C9 RID: 6089
	[Token(Token = "0x40017C9")]
	[FieldOffset(Offset = "0xC8")]
	public String_Layout InviteCodeEdit;

	// Token: 0x040017CA RID: 6090
	[Token(Token = "0x40017CA")]
	[FieldOffset(Offset = "0xCC")]
	public Panel_Layout InviteCodeGreyout;

	// Token: 0x040017CB RID: 6091
	[Token(Token = "0x40017CB")]
	[FieldOffset(Offset = "0xD0")]
	public Panel_Layout SectionSeperator;

	// Token: 0x040017CC RID: 6092
	[Token(Token = "0x40017CC")]
	[FieldOffset(Offset = "0xD4")]
	public int SectionSeperatorSize;

	// Token: 0x040017CD RID: 6093
	[Token(Token = "0x40017CD")]
	[FieldOffset(Offset = "0xD8")]
	public SettingsOverlayToggle_Layout ToggleTemplate;

	// Token: 0x040017CE RID: 6094
	[Token(Token = "0x40017CE")]
	[FieldOffset(Offset = "0xDC")]
	public TransactionButton_Layout DedicatedMissing;

	// Token: 0x040017CF RID: 6095
	[Token(Token = "0x40017CF")]
	[FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout Searching;

	// Token: 0x040017D0 RID: 6096
	[Token(Token = "0x40017D0")]
	[FieldOffset(Offset = "0xE4")]
	public Button_Layout SearchingIcon;

	// Token: 0x040017D1 RID: 6097
	[Token(Token = "0x40017D1")]
	[FieldOffset(Offset = "0xE8")]
	public Panel_Layout ItemBacking;

	// Token: 0x040017D2 RID: 6098
	[Token(Token = "0x40017D2")]
	[FieldOffset(Offset = "0xEC")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x040017D3 RID: 6099
	[Token(Token = "0x40017D3")]
	[FieldOffset(Offset = "0xF0")]
	public Button_Layout ItemPlay;

	// Token: 0x040017D4 RID: 6100
	[Token(Token = "0x40017D4")]
	[FieldOffset(Offset = "0xF4")]
	public Button_Layout ItemDivider;

	// Token: 0x040017D5 RID: 6101
	[Token(Token = "0x40017D5")]
	[FieldOffset(Offset = "0xF8")]
	public String_Layout ItemName;

	// Token: 0x040017D6 RID: 6102
	[Token(Token = "0x40017D6")]
	[FieldOffset(Offset = "0xFC")]
	public int ItemNameMaxWidth;

	// Token: 0x040017D7 RID: 6103
	[Token(Token = "0x40017D7")]
	[FieldOffset(Offset = "0x100")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x040017D8 RID: 6104
	[Token(Token = "0x40017D8")]
	[FieldOffset(Offset = "0x104")]
	public Panel_Layout ItemPlayerBacking;

	// Token: 0x040017D9 RID: 6105
	[Token(Token = "0x40017D9")]
	[FieldOffset(Offset = "0x108")]
	public String_Layout ItemPlayer;

	// Token: 0x040017DA RID: 6106
	[Token(Token = "0x40017DA")]
	[FieldOffset(Offset = "0x10C")]
	public Panel_Layout ItemModeBacking;

	// Token: 0x040017DB RID: 6107
	[Token(Token = "0x40017DB")]
	[FieldOffset(Offset = "0x110")]
	public String_Layout ItemMode;

	// Token: 0x040017DC RID: 6108
	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0x114")]
	public Panel_Layout ItemSizeBacking;

	// Token: 0x040017DD RID: 6109
	[Token(Token = "0x40017DD")]
	[FieldOffset(Offset = "0x118")]
	public String_Layout ItemSize;

	// Token: 0x040017DE RID: 6110
	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0x11C")]
	public Panel_Layout ItemImage;

	// Token: 0x040017DF RID: 6111
	[Token(Token = "0x40017DF")]
	[FieldOffset(Offset = "0x120")]
	public Color UnknownServerTextColour;

	// Token: 0x040017E0 RID: 6112
	[Token(Token = "0x40017E0")]
	[FieldOffset(Offset = "0x124")]
	public Button_Layout ItemFavourite;

	// Token: 0x040017E1 RID: 6113
	[Token(Token = "0x40017E1")]
	[FieldOffset(Offset = "0x128")]
	public TransactionButton_Layout ItemCrossplayDedicated;

	// Token: 0x040017E2 RID: 6114
	[Token(Token = "0x40017E2")]
	[FieldOffset(Offset = "0x12C")]
	public TransactionButton_Layout ItemCrossplay;

	// Token: 0x040017E3 RID: 6115
	[Token(Token = "0x40017E3")]
	[FieldOffset(Offset = "0x130")]
	public SelectPlayerFavoriteIcons FavoriteIcons;
}
