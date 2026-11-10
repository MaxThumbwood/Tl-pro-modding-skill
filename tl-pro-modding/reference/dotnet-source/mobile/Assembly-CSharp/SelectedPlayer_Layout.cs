using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000262 RID: 610
[Token(Token = "0x2000262")]
public class SelectedPlayer_Layout : LayoutDefinition
{
	// Token: 0x06000E81 RID: 3713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E81")]
	[Address(RVA = "0xC95540", Offset = "0xC95540", VA = "0xC95540")]
	private void Awake()
	{
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E82")]
	[Address(RVA = "0xC95594", Offset = "0xC95594", VA = "0xC95594")]
	public SelectedPlayer_Layout()
	{
	}

	// Token: 0x04001D32 RID: 7474
	[Token(Token = "0x4001D32")]
	[FieldOffset(Offset = "0x0")]
	public static SelectedPlayer_Layout Instance;

	// Token: 0x04001D33 RID: 7475
	[Token(Token = "0x4001D33")]
	[FieldOffset(Offset = "0xC")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x04001D34 RID: 7476
	[Token(Token = "0x4001D34")]
	[FieldOffset(Offset = "0x10")]
	public JourneySettingsButton_Layout PS4ProfileLayout;

	// Token: 0x04001D35 RID: 7477
	[Token(Token = "0x4001D35")]
	[FieldOffset(Offset = "0x14")]
	public JourneySettingsButton_Layout ProfileLayout;

	// Token: 0x04001D36 RID: 7478
	[Token(Token = "0x4001D36")]
	[FieldOffset(Offset = "0x18")]
	public JourneySettingsButton_Layout ButtonLayout;

	// Token: 0x04001D37 RID: 7479
	[Token(Token = "0x4001D37")]
	[FieldOffset(Offset = "0x1C")]
	public JourneySettingsToggle_Layout ToggleLayout;

	// Token: 0x04001D38 RID: 7480
	[Token(Token = "0x4001D38")]
	[FieldOffset(Offset = "0x20")]
	public String_Layout SelectedPlayerName;

	// Token: 0x04001D39 RID: 7481
	[Token(Token = "0x4001D39")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout SelectedPlayerNameDivider;

	// Token: 0x04001D3A RID: 7482
	[Token(Token = "0x4001D3A")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout SelectedPlayerTeam;

	// Token: 0x04001D3B RID: 7483
	[Token(Token = "0x4001D3B")]
	[FieldOffset(Offset = "0x2C")]
	public String_Layout SelectedPlayerTeamName;

	// Token: 0x04001D3C RID: 7484
	[Token(Token = "0x4001D3C")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout SelectedPlayerTeleport;

	// Token: 0x04001D3D RID: 7485
	[Token(Token = "0x4001D3D")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout SelectedPlayerMap;

	// Token: 0x04001D3E RID: 7486
	[Token(Token = "0x4001D3E")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout SelectedPlayerClose;

	// Token: 0x04001D3F RID: 7487
	[Token(Token = "0x4001D3F")]
	[FieldOffset(Offset = "0x3C")]
	public Panel_Layout SelectedPlayerDivider;

	// Token: 0x04001D40 RID: 7488
	[Token(Token = "0x4001D40")]
	[FieldOffset(Offset = "0x40")]
	public Panel_Layout SelectedPlayerDivider2;

	// Token: 0x04001D41 RID: 7489
	[Token(Token = "0x4001D41")]
	[FieldOffset(Offset = "0x44")]
	public Panel_Layout SelectedPlayerHealthBacking;

	// Token: 0x04001D42 RID: 7490
	[Token(Token = "0x4001D42")]
	[FieldOffset(Offset = "0x48")]
	public Button_Layout SelectedPlayerHealthIcon;

	// Token: 0x04001D43 RID: 7491
	[Token(Token = "0x4001D43")]
	[FieldOffset(Offset = "0x4C")]
	public String_Layout SelectedPlayerHealth;

	// Token: 0x04001D44 RID: 7492
	[Token(Token = "0x4001D44")]
	[FieldOffset(Offset = "0x50")]
	public Panel_Layout SelectedPlayerManaBacking;

	// Token: 0x04001D45 RID: 7493
	[Token(Token = "0x4001D45")]
	[FieldOffset(Offset = "0x54")]
	public Button_Layout SelectedPlayerManaIcon;

	// Token: 0x04001D46 RID: 7494
	[Token(Token = "0x4001D46")]
	[FieldOffset(Offset = "0x58")]
	public String_Layout SelectedPlayerMana;

	// Token: 0x04001D47 RID: 7495
	[Token(Token = "0x4001D47")]
	[FieldOffset(Offset = "0x5C")]
	public Texture_Layout XBOPlayerIcon;

	// Token: 0x04001D48 RID: 7496
	[Token(Token = "0x4001D48")]
	[FieldOffset(Offset = "0x60")]
	public Texture_Layout PSNPlayerIcon;

	// Token: 0x04001D49 RID: 7497
	[Token(Token = "0x4001D49")]
	[FieldOffset(Offset = "0x64")]
	public Texture_Layout NintendoPlayerIcon;

	// Token: 0x04001D4A RID: 7498
	[Token(Token = "0x4001D4A")]
	[FieldOffset(Offset = "0x68")]
	public Texture_Layout CrossplayPlayerIcon;

	// Token: 0x04001D4B RID: 7499
	[Token(Token = "0x4001D4B")]
	[FieldOffset(Offset = "0x6C")]
	public Texture_Layout KickIcon;

	// Token: 0x04001D4C RID: 7500
	[Token(Token = "0x4001D4C")]
	[FieldOffset(Offset = "0x70")]
	public Texture_Layout BanIcon;

	// Token: 0x04001D4D RID: 7501
	[Token(Token = "0x4001D4D")]
	[FieldOffset(Offset = "0x74")]
	public Texture_Layout VoiceEnabledIcon;

	// Token: 0x04001D4E RID: 7502
	[Token(Token = "0x4001D4E")]
	[FieldOffset(Offset = "0x78")]
	public Texture_Layout VoiceDisabledIcon;

	// Token: 0x04001D4F RID: 7503
	[Token(Token = "0x4001D4F")]
	[FieldOffset(Offset = "0x7C")]
	public Texture_Layout ChatEnabledIcon;

	// Token: 0x04001D50 RID: 7504
	[Token(Token = "0x4001D50")]
	[FieldOffset(Offset = "0x80")]
	public Texture_Layout ChatDisabledIcon;

	// Token: 0x04001D51 RID: 7505
	[Token(Token = "0x4001D51")]
	[FieldOffset(Offset = "0x84")]
	public Panel_Layout SelectedPlayerBacking;

	// Token: 0x04001D52 RID: 7506
	[Token(Token = "0x4001D52")]
	[FieldOffset(Offset = "0x88")]
	public String_Layout SelectedPlayerPlatformProfileName;

	// Token: 0x04001D53 RID: 7507
	[Token(Token = "0x4001D53")]
	[FieldOffset(Offset = "0x8C")]
	public Panel_Layout SelectedPlayerPlatformProfileBacking;

	// Token: 0x04001D54 RID: 7508
	[Token(Token = "0x4001D54")]
	[FieldOffset(Offset = "0x90")]
	public Panel_Layout SelectedPlayerImagePosition;

	// Token: 0x04001D55 RID: 7509
	[Token(Token = "0x4001D55")]
	[FieldOffset(Offset = "0x94")]
	public Panel_Layout SelectedPlayerImageClipRegion;

	// Token: 0x04001D56 RID: 7510
	[Token(Token = "0x4001D56")]
	[FieldOffset(Offset = "0x98")]
	public Vector2 SelectedPlayerImageDrawOffset;

	// Token: 0x04001D57 RID: 7511
	[Token(Token = "0x4001D57")]
	[FieldOffset(Offset = "0xA0")]
	public Vector2 GraveStoneOffset;

	// Token: 0x04001D58 RID: 7512
	[Token(Token = "0x4001D58")]
	[FieldOffset(Offset = "0xA8")]
	public float GraveStoneScale;

	// Token: 0x04001D59 RID: 7513
	[Token(Token = "0x4001D59")]
	[FieldOffset(Offset = "0xAC")]
	public Button_Layout HostPlayer;

	// Token: 0x04001D5A RID: 7514
	[Token(Token = "0x4001D5A")]
	[FieldOffset(Offset = "0xB0")]
	public Texture_Layout HostPlayerTexture;

	// Token: 0x04001D5B RID: 7515
	[Token(Token = "0x4001D5B")]
	[FieldOffset(Offset = "0xB4")]
	public Panel_Layout KickPlayer_Backing;

	// Token: 0x04001D5C RID: 7516
	[Token(Token = "0x4001D5C")]
	[FieldOffset(Offset = "0xB8")]
	public String_Layout KickPlayer_Message;

	// Token: 0x04001D5D RID: 7517
	[Token(Token = "0x4001D5D")]
	[FieldOffset(Offset = "0xBC")]
	public TransactionButton_Layout KickPlayer_Ban;

	// Token: 0x04001D5E RID: 7518
	[Token(Token = "0x4001D5E")]
	[FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout KickPlayer_Kick;

	// Token: 0x04001D5F RID: 7519
	[Token(Token = "0x4001D5F")]
	[FieldOffset(Offset = "0xC4")]
	public TransactionButton_Layout KickPlayer_Close;
}
