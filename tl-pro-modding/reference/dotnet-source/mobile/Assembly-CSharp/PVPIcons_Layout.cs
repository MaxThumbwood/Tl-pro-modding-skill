using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000255 RID: 597
[Token(Token = "0x2000255")]
public class PVPIcons_Layout : PageControllerLayoutDefinition<PVPIcons_Layout>
{
	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000178")]
	public ItemGrid_Layout TeamGridLayout
	{
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0xC93E50", Offset = "0xC93E50", VA = "0xC93E50")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000179")]
	public DraggableItemGrid_Layout Grid
	{
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0xC93EF0", Offset = "0xC93EF0", VA = "0xC93EF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017A")]
	public TransactionButton_Layout PVPIcon
	{
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0xC93FE4", Offset = "0xC93FE4", VA = "0xC93FE4")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017B")]
	public TransactionButton_Layout PlayerTeamIcon
	{
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0xC94084", Offset = "0xC94084", VA = "0xC94084")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E64")]
	[Address(RVA = "0xC94124", Offset = "0xC94124", VA = "0xC94124")]
	public PVPIcons_Layout()
	{
	}

	// Token: 0x04001BAD RID: 7085
	[Token(Token = "0x4001BAD")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x04001BAE RID: 7086
	[Token(Token = "0x4001BAE")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout PlatformInvite;

	// Token: 0x04001BAF RID: 7087
	[Token(Token = "0x4001BAF")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout PlatformInviteTouch;

	// Token: 0x04001BB0 RID: 7088
	[Token(Token = "0x4001BB0")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout PVP;

	// Token: 0x04001BB1 RID: 7089
	[Token(Token = "0x4001BB1")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout PVP_Horizontal;

	// Token: 0x04001BB2 RID: 7090
	[Token(Token = "0x4001BB2")]
	[FieldOffset(Offset = "0x24")]
	public ItemGrid_Layout TeamGrid;

	// Token: 0x04001BB3 RID: 7091
	[Token(Token = "0x4001BB3")]
	[FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout TeamGrid_Horizontal;

	// Token: 0x04001BB4 RID: 7092
	[Token(Token = "0x4001BB4")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 TeamGridLocationTouch;

	// Token: 0x04001BB5 RID: 7093
	[Token(Token = "0x4001BB5")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 TeamGridOffset;

	// Token: 0x04001BB6 RID: 7094
	[Token(Token = "0x4001BB6")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 TeamGridControllerOffset;

	// Token: 0x04001BB7 RID: 7095
	[Token(Token = "0x4001BB7")]
	[FieldOffset(Offset = "0x44")]
	public Panel_Layout TeamGridBacking;

	// Token: 0x04001BB8 RID: 7096
	[Token(Token = "0x4001BB8")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 TeamBackingTLOffset;

	// Token: 0x04001BB9 RID: 7097
	[Token(Token = "0x4001BB9")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 TeamBackingBROffset;

	// Token: 0x04001BBA RID: 7098
	[Token(Token = "0x4001BBA")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 CharacterDrawOffset;

	// Token: 0x04001BBB RID: 7099
	[Token(Token = "0x4001BBB")]
	[FieldOffset(Offset = "0x60")]
	public DraggableItemGrid_Layout PlayerGrid;

	// Token: 0x04001BBC RID: 7100
	[Token(Token = "0x4001BBC")]
	[FieldOffset(Offset = "0x64")]
	public DraggableItemGrid_Layout PlayerGridCollapsed;

	// Token: 0x04001BBD RID: 7101
	[Token(Token = "0x4001BBD")]
	[FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout PlayerTeam;

	// Token: 0x04001BBE RID: 7102
	[Token(Token = "0x4001BBE")]
	[FieldOffset(Offset = "0x6C")]
	public TransactionButton_Layout PlayerTeam_Horizontal;

	// Token: 0x04001BBF RID: 7103
	[Token(Token = "0x4001BBF")]
	[FieldOffset(Offset = "0x70")]
	public Panel_Layout PlayerClipRegion;

	// Token: 0x04001BC0 RID: 7104
	[Token(Token = "0x4001BC0")]
	[FieldOffset(Offset = "0x74")]
	public float TeamScale;

	// Token: 0x04001BC1 RID: 7105
	[Token(Token = "0x4001BC1")]
	[FieldOffset(Offset = "0x78")]
	public float TeamIconScale;

	// Token: 0x04001BC2 RID: 7106
	[Token(Token = "0x4001BC2")]
	[FieldOffset(Offset = "0x7C")]
	public Vector2 TeamIconOffset;

	// Token: 0x04001BC3 RID: 7107
	[Token(Token = "0x4001BC3")]
	[FieldOffset(Offset = "0x84")]
	public float PlayerScale;

	// Token: 0x04001BC4 RID: 7108
	[Token(Token = "0x4001BC4")]
	[FieldOffset(Offset = "0x88")]
	public float PlayerIconScale;

	// Token: 0x04001BC5 RID: 7109
	[Token(Token = "0x4001BC5")]
	[FieldOffset(Offset = "0x8C")]
	public Vector2 PlayerIconOffset;

	// Token: 0x04001BC6 RID: 7110
	[Token(Token = "0x4001BC6")]
	[FieldOffset(Offset = "0x94")]
	public Vector2 PlayerHeadOffset;

	// Token: 0x04001BC7 RID: 7111
	[Token(Token = "0x4001BC7")]
	[FieldOffset(Offset = "0x9C")]
	public float PlayerHeadScale;

	// Token: 0x04001BC8 RID: 7112
	[Token(Token = "0x4001BC8")]
	[FieldOffset(Offset = "0xA0")]
	public Vector2 GraveStoneOffset;

	// Token: 0x04001BC9 RID: 7113
	[Token(Token = "0x4001BC9")]
	[FieldOffset(Offset = "0xA8")]
	public float GraveStoneScale;

	// Token: 0x04001BCA RID: 7114
	[Token(Token = "0x4001BCA")]
	[FieldOffset(Offset = "0xAC")]
	public Texture_Layout CrownTexture;

	// Token: 0x04001BCB RID: 7115
	[Token(Token = "0x4001BCB")]
	[FieldOffset(Offset = "0xB0")]
	public Vector2 CrownOffset;

	// Token: 0x04001BCC RID: 7116
	[Token(Token = "0x4001BCC")]
	[FieldOffset(Offset = "0xB8")]
	public float CrownScale;

	// Token: 0x04001BCD RID: 7117
	[Token(Token = "0x4001BCD")]
	[FieldOffset(Offset = "0xBC")]
	public float TalkingIconScale;

	// Token: 0x04001BCE RID: 7118
	[Token(Token = "0x4001BCE")]
	[FieldOffset(Offset = "0xC0")]
	public Vector2 TalkIconOffset;

	// Token: 0x04001BCF RID: 7119
	[Token(Token = "0x4001BCF")]
	[FieldOffset(Offset = "0xC8")]
	public Texture_Layout TalkingIcon;

	// Token: 0x04001BD0 RID: 7120
	[Token(Token = "0x4001BD0")]
	[FieldOffset(Offset = "0xCC")]
	public float MutedIconScale;

	// Token: 0x04001BD1 RID: 7121
	[Token(Token = "0x4001BD1")]
	[FieldOffset(Offset = "0xD0")]
	public Vector2 MutedIconOffset;

	// Token: 0x04001BD2 RID: 7122
	[Token(Token = "0x4001BD2")]
	[FieldOffset(Offset = "0xD8")]
	public Texture_Layout MutedIcon;

	// Token: 0x04001BD3 RID: 7123
	[Token(Token = "0x4001BD3")]
	[FieldOffset(Offset = "0xDC")]
	public Color Team1BackingColour;

	// Token: 0x04001BD4 RID: 7124
	[Token(Token = "0x4001BD4")]
	[FieldOffset(Offset = "0xE0")]
	public Color Team2BackingColour;

	// Token: 0x04001BD5 RID: 7125
	[Token(Token = "0x4001BD5")]
	[FieldOffset(Offset = "0xE4")]
	public Color Team3BackingColour;

	// Token: 0x04001BD6 RID: 7126
	[Token(Token = "0x4001BD6")]
	[FieldOffset(Offset = "0xE8")]
	public Color Team4BackingColour;

	// Token: 0x04001BD7 RID: 7127
	[Token(Token = "0x4001BD7")]
	[FieldOffset(Offset = "0xEC")]
	public Color Team5BackingColour;

	// Token: 0x04001BD8 RID: 7128
	[Token(Token = "0x4001BD8")]
	[FieldOffset(Offset = "0xF0")]
	public Color Team6BackingColour;

	// Token: 0x04001BD9 RID: 7129
	[Token(Token = "0x4001BD9")]
	[FieldOffset(Offset = "0xF4")]
	public Color TeamBackingColourDisabled;

	// Token: 0x04001BDA RID: 7130
	[Token(Token = "0x4001BDA")]
	[FieldOffset(Offset = "0xF8")]
	public Color TeamIconColourDisabled;

	// Token: 0x04001BDB RID: 7131
	[Token(Token = "0x4001BDB")]
	[FieldOffset(Offset = "0xFC")]
	public Color Team1PlayerBackingColour;

	// Token: 0x04001BDC RID: 7132
	[Token(Token = "0x4001BDC")]
	[FieldOffset(Offset = "0x100")]
	public Color Team2PlayerBackingColour;

	// Token: 0x04001BDD RID: 7133
	[Token(Token = "0x4001BDD")]
	[FieldOffset(Offset = "0x104")]
	public Color Team3PlayerBackingColour;

	// Token: 0x04001BDE RID: 7134
	[Token(Token = "0x4001BDE")]
	[FieldOffset(Offset = "0x108")]
	public Color Team4PlayerBackingColour;

	// Token: 0x04001BDF RID: 7135
	[Token(Token = "0x4001BDF")]
	[FieldOffset(Offset = "0x10C")]
	public Color Team5PlayerBackingColour;

	// Token: 0x04001BE0 RID: 7136
	[Token(Token = "0x4001BE0")]
	[FieldOffset(Offset = "0x110")]
	public Color Team6PlayerBackingColour;

	// Token: 0x04001BE1 RID: 7137
	[Token(Token = "0x4001BE1")]
	[FieldOffset(Offset = "0x114")]
	public Color EmptySlotColour;

	// Token: 0x04001BE2 RID: 7138
	[Token(Token = "0x4001BE2")]
	[FieldOffset(Offset = "0x118")]
	public Color EmptySlotIconColour;

	// Token: 0x04001BE3 RID: 7139
	[Token(Token = "0x4001BE3")]
	[FieldOffset(Offset = "0x11C")]
	public float EmptySlotIconScale;

	// Token: 0x04001BE4 RID: 7140
	[Token(Token = "0x4001BE4")]
	[FieldOffset(Offset = "0x120")]
	public Texture_Layout EmptySlotIcon;

	// Token: 0x04001BE5 RID: 7141
	[Token(Token = "0x4001BE5")]
	[FieldOffset(Offset = "0x124")]
	public float CharacterScale;

	// Token: 0x04001BE6 RID: 7142
	[Token(Token = "0x4001BE6")]
	[FieldOffset(Offset = "0x128")]
	public String_Layout TeamCooldownCounter;
}
