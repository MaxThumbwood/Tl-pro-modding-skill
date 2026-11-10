using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;

// Token: 0x0200015D RID: 349
[Token(Token = "0x200015D")]
public class GUIInstance
{
	// Token: 0x060009C1 RID: 2497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x91A230", Offset = "0x91A230", VA = "0x91A230")]
	public void AddUICallback(Action action)
	{
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x91A2EC", Offset = "0x91A2EC", VA = "0x91A2EC")]
	public void ExectureUICallbacks()
	{
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x91A4D8", Offset = "0x91A4D8", VA = "0x91A4D8")]
	public void AddPreUICallback(Action action)
	{
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x91A594", Offset = "0x91A594", VA = "0x91A594")]
	public void ExecturePreUICallbacks()
	{
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D7")]
	public static Player DisplayPlayer
	{
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x91A780", Offset = "0x91A780", VA = "0x91A780")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00005FD0 File Offset: 0x000041D0
	[Token(Token = "0x170000D8")]
	public static int WorldSelectMode
	{
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x91A894", Offset = "0x91A894", VA = "0x91A894")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x91A904", Offset = "0x91A904", VA = "0x91A904")]
	public void ClosePopups()
	{
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x91AA64", Offset = "0x91AA64", VA = "0x91AA64")]
	public void CloseDialoguesAndPopups()
	{
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x91AC90", Offset = "0x91AC90", VA = "0x91AC90")]
	public void CloseNonPageDialogues()
	{
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x91AD64", Offset = "0x91AD64", VA = "0x91AD64")]
	public GUIInstance()
	{
	}

	// Token: 0x04000AEC RID: 2796
	[Token(Token = "0x4000AEC")]
	[FieldOffset(Offset = "0x0")]
	public static GUIInstance Active;

	// Token: 0x04000AED RID: 2797
	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x8")]
	public XNAUnityRunner.ForcedInputMode LastPrimaryInputMode;

	// Token: 0x04000AEE RID: 2798
	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0xC")]
	public InterfaceProfile_Layout _active;

	// Token: 0x04000AEF RID: 2799
	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0x10")]
	public bool UseLargeMinimap;

	// Token: 0x04000AF0 RID: 2800
	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0x14")]
	public int _framesWithRespawnSkipAvailable;

	// Token: 0x04000AF1 RID: 2801
	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0x18")]
	public GUIControllerNavigationController GUIControllerNavigationController;

	// Token: 0x04000AF2 RID: 2802
	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x1C")]
	public GUIControllerPageRedirect GUIControllerPageRedirect;

	// Token: 0x04000AF3 RID: 2803
	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x20")]
	public GUIVirtualInputController GUIVirtualInputController;

	// Token: 0x04000AF4 RID: 2804
	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x24")]
	private List<Action> uiCallbackActions;

	// Token: 0x04000AF5 RID: 2805
	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x28")]
	private List<Action> preUICallbackActions;

	// Token: 0x04000AF6 RID: 2806
	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x4")]
	private static Player EmptyDisplay;

	// Token: 0x04000AF7 RID: 2807
	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0x2C")]
	public GUIAccessoryInfo GUIAccessoryInfo;

	// Token: 0x04000AF8 RID: 2808
	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x30")]
	public GUIMenuNameEdit GUIMenuNameEdit;

	// Token: 0x04000AF9 RID: 2809
	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x34")]
	public GUISpectatorMode GUISpectatorMode;

	// Token: 0x04000AFA RID: 2810
	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0x38")]
	public GUIGenericPopup GUIGenericPopup;

	// Token: 0x04000AFB RID: 2811
	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x3C")]
	public GUIReforgePopup GUIReforgePopup;

	// Token: 0x04000AFC RID: 2812
	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0x40")]
	public GUIAmmo GUIAmmo;

	// Token: 0x04000AFD RID: 2813
	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0x44")]
	public GUIBossBar GUIBossBar;

	// Token: 0x04000AFE RID: 2814
	[Token(Token = "0x4000AFE")]
	[FieldOffset(Offset = "0x48")]
	public GUIBuffs GUIBuffs;

	// Token: 0x04000AFF RID: 2815
	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x4C")]
	public GUIChest GUIChest;

	// Token: 0x04000B00 RID: 2816
	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x50")]
	public GUIChestQuickStack GUIChestQuickStack;

	// Token: 0x04000B01 RID: 2817
	[Token(Token = "0x4000B01")]
	[FieldOffset(Offset = "0x54")]
	public GUIChestSplitStack GUIChestSplitStack;

	// Token: 0x04000B02 RID: 2818
	[Token(Token = "0x4000B02")]
	[FieldOffset(Offset = "0x58")]
	public GUIClothesWindow GUIClothesWindow;

	// Token: 0x04000B03 RID: 2819
	[Token(Token = "0x4000B03")]
	[FieldOffset(Offset = "0x5C")]
	public GUICoins GUICoins;

	// Token: 0x04000B04 RID: 2820
	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0x60")]
	public GUIControlsBanner GUIControlsBanner;

	// Token: 0x04000B05 RID: 2821
	[Token(Token = "0x4000B05")]
	[FieldOffset(Offset = "0x64")]
	public GUIControlsStatusIndicators GUIControlsStatusIndicators;

	// Token: 0x04000B06 RID: 2822
	[Token(Token = "0x4000B06")]
	[FieldOffset(Offset = "0x68")]
	public GUICraftGuide GUICraftGuide;

	// Token: 0x04000B07 RID: 2823
	[Token(Token = "0x4000B07")]
	[FieldOffset(Offset = "0x6C")]
	public GUICraftGuidePopup GUICraftGuidePopup;

	// Token: 0x04000B08 RID: 2824
	[Token(Token = "0x4000B08")]
	[FieldOffset(Offset = "0x70")]
	public GUICrafting GUICrafting;

	// Token: 0x04000B09 RID: 2825
	[Token(Token = "0x4000B09")]
	[FieldOffset(Offset = "0x74")]
	public GUIBannerCrafting GUIBannerCrafting;

	// Token: 0x04000B0A RID: 2826
	[Token(Token = "0x4000B0A")]
	[FieldOffset(Offset = "0x78")]
	public GUIDisplayDoll GUIDisplayDoll;

	// Token: 0x04000B0B RID: 2827
	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x7C")]
	public GUIEmotesWindow GUIEmotesWindow;

	// Token: 0x04000B0C RID: 2828
	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0x80")]
	public GUIEquipment GUIEquipment;

	// Token: 0x04000B0D RID: 2829
	[Token(Token = "0x4000B0D")]
	[FieldOffset(Offset = "0x84")]
	public GUIEquipmentUtility GUIEquipmentUtility;

	// Token: 0x04000B0E RID: 2830
	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0x88")]
	public GUIEvents GUIEvents;

	// Token: 0x04000B0F RID: 2831
	[Token(Token = "0x4000B0F")]
	[FieldOffset(Offset = "0x8C")]
	public GUIHairWindow GUIHairWindow;

	// Token: 0x04000B10 RID: 2832
	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0x90")]
	public GUIHatRack GUIHatRack;

	// Token: 0x04000B11 RID: 2833
	[Token(Token = "0x4000B11")]
	[FieldOffset(Offset = "0x94")]
	public GUIResearchPage GUIResearchPage;

	// Token: 0x04000B12 RID: 2834
	[Token(Token = "0x4000B12")]
	[FieldOffset(Offset = "0x98")]
	public GUIHearts GUIHearts;

	// Token: 0x04000B13 RID: 2835
	[Token(Token = "0x4000B13")]
	[FieldOffset(Offset = "0x9C")]
	public GUIHotbar GUIHotbar;

	// Token: 0x04000B14 RID: 2836
	[Token(Token = "0x4000B14")]
	[FieldOffset(Offset = "0xA0")]
	public GUIHousingMenu GUIHousingMenu;

	// Token: 0x04000B15 RID: 2837
	[Token(Token = "0x4000B15")]
	[FieldOffset(Offset = "0xA4")]
	public GUIInventory GUIInventory;

	// Token: 0x04000B16 RID: 2838
	[Token(Token = "0x4000B16")]
	[FieldOffset(Offset = "0xA8")]
	public GUIWiresUI GUIWiresUI;

	// Token: 0x04000B17 RID: 2839
	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0xAC")]
	public GUIRubbleMaker GUIRubbleMaker;

	// Token: 0x04000B18 RID: 2840
	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0xB0")]
	public GUIInventorySplitStack GUIInventorySplitStack;

	// Token: 0x04000B19 RID: 2841
	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0xB4")]
	public GUIInventoryTransactions GUIInventoryTransactions;

	// Token: 0x04000B1A RID: 2842
	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0xB8")]
	public GUIItemDuplication GUIItemDuplication;

	// Token: 0x04000B1B RID: 2843
	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0xBC")]
	public GUIMagnify GUIMagnify;

	// Token: 0x04000B1C RID: 2844
	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0xC0")]
	public GUIMana GUIMana;

	// Token: 0x04000B1D RID: 2845
	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0xC4")]
	public GUIMap GUIMap;

	// Token: 0x04000B1E RID: 2846
	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0xC8")]
	public GUIMouseItem GUIMouseItem;

	// Token: 0x04000B1F RID: 2847
	[Token(Token = "0x4000B1F")]
	[FieldOffset(Offset = "0xCC")]
	public GUIChat_Core GUIChat;

	// Token: 0x04000B20 RID: 2848
	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0xD0")]
	public GUINetplayStatusText GUINetplayStatusText;

	// Token: 0x04000B21 RID: 2849
	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0xD4")]
	public GUINPCDialogue GUINPCDialogue;

	// Token: 0x04000B22 RID: 2850
	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0xD8")]
	public GUIPageIcons GUIPageIcons;

	// Token: 0x04000B23 RID: 2851
	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0xDC")]
	public GUIProfileSwitch GUIProfileSwitch;

	// Token: 0x04000B24 RID: 2852
	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0xE0")]
	public GUIPVPIcons GUIPVPIcons;

	// Token: 0x04000B25 RID: 2853
	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0xE4")]
	public GUIServerInfoInvite GUIServerInfoInvite;

	// Token: 0x04000B26 RID: 2854
	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0xE8")]
	public GUIReforge GUIReforge;

	// Token: 0x04000B27 RID: 2855
	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0xEC")]
	public GUIScrollControl GUIScrollControl;

	// Token: 0x04000B28 RID: 2856
	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0xF0")]
	public GUIJourneyModeSettings GUIJourneyModeSettings;

	// Token: 0x04000B29 RID: 2857
	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0xF4")]
	public GUISettings GUISettings;

	// Token: 0x04000B2A RID: 2858
	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0xF8")]
	public GUISettingsPauseMenu GUISettingsPauseMenu;

	// Token: 0x04000B2B RID: 2859
	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0xFC")]
	public GUIShop GUIShop;

	// Token: 0x04000B2C RID: 2860
	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x100")]
	public GUITrashCan GUITrashCan;

	// Token: 0x04000B2D RID: 2861
	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x104")]
	public GUIWorldOperationProgress GUIWorldOperationProgress;

	// Token: 0x04000B2E RID: 2862
	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x108")]
	public GUIZoom GUIZoom;

	// Token: 0x04000B2F RID: 2863
	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x10C")]
	public GUIAchievementsMenu GUIAchievementsMenu;

	// Token: 0x04000B30 RID: 2864
	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x110")]
	public GUICredits GUICredits;

	// Token: 0x04000B31 RID: 2865
	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x114")]
	public GUIDeleteDedicatedServer GUIDeleteDedicatedServer;

	// Token: 0x04000B32 RID: 2866
	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x118")]
	public GUIDeletePlayer GUIDeletePlayer;

	// Token: 0x04000B33 RID: 2867
	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x11C")]
	public GUIDeleteWorld GUIDeleteWorld;

	// Token: 0x04000B34 RID: 2868
	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x120")]
	public GUICancelPlayerCreation GUICancelPlayerCreation;

	// Token: 0x04000B35 RID: 2869
	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x124")]
	public GUIErrorScreen GUIErrorScreen;

	// Token: 0x04000B36 RID: 2870
	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x128")]
	public GUIFileSyncInProgress GUIFileSyncInProgress;

	// Token: 0x04000B37 RID: 2871
	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x12C")]
	public GUIInterfaceEdit GUIInterfaceEdit;

	// Token: 0x04000B38 RID: 2872
	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x130")]
	public GUILogo GUILogo;

	// Token: 0x04000B39 RID: 2873
	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x134")]
	public GUILowDiskSpacePopup GUILowDiskSpacePopup;

	// Token: 0x04000B3A RID: 2874
	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x138")]
	public GUISaveVersionPopup GUISaveVersionPopup;

	// Token: 0x04000B3B RID: 2875
	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x13C")]
	public GUILowMemoryPopup GUILowMemoryPopup;

	// Token: 0x04000B3C RID: 2876
	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x140")]
	public GUILowMemorySetttings GUILowMemorySetttings;

	// Token: 0x04000B3D RID: 2877
	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x144")]
	public GUINetSafetyPopup GUINetSafetyPopup;

	// Token: 0x04000B3E RID: 2878
	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0x148")]
	public GUIConfigureTouchControlsPopup GUIConfigureTouchControlsPopup;

	// Token: 0x04000B3F RID: 2879
	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x14C")]
	public GUIMainMenu GUIMainMenu;

	// Token: 0x04000B40 RID: 2880
	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0x150")]
	public GUIMultiplayerHost GUIMultiplayerHost;

	// Token: 0x04000B41 RID: 2881
	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0x154")]
	public GUIMultiplayerJoin GUIMultiplayerJoin;

	// Token: 0x04000B42 RID: 2882
	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0x158")]
	public GUICrossplayDisabledPopup GUICrossplayDisabledPopup;

	// Token: 0x04000B43 RID: 2883
	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0x15C")]
	public GUIMultiplayerLobby GUIMultiplayerLobby;

	// Token: 0x04000B44 RID: 2884
	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0x160")]
	public GUIMultiplayerMenu GUIMultiplayerMenu;

	// Token: 0x04000B45 RID: 2885
	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x164")]
	public GUIMultiplayerServerIP GUIMultiplayerServerIP;

	// Token: 0x04000B46 RID: 2886
	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x168")]
	public GUIMultiplayerServerPassword GUIMultiplayerServerPassword;

	// Token: 0x04000B47 RID: 2887
	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0x16C")]
	public GUIMultiplayerServerPort GUIMultiplayerServerPort;

	// Token: 0x04000B48 RID: 2888
	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x170")]
	public GUIMultiplayerServerRequestedPassword GUIMultiplayerServerRequestedPassword;

	// Token: 0x04000B49 RID: 2889
	[Token(Token = "0x4000B49")]
	[FieldOffset(Offset = "0x174")]
	public GUIMultiplayerWaitingHost GUIMultiplayerWaitingHost;

	// Token: 0x04000B4A RID: 2890
	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0x178")]
	public GUINetPlayStatusMenu GUINetPlayStatusMenu;

	// Token: 0x04000B4B RID: 2891
	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0x17C")]
	public GUIPlayerAndGameModeMismatch GUIPlayerAndGameModeMismatch;

	// Token: 0x04000B4C RID: 2892
	[Token(Token = "0x4000B4C")]
	[FieldOffset(Offset = "0x180")]
	public GUIPlayerCreateMenu GUIPlayerCreateMenu;

	// Token: 0x04000B4D RID: 2893
	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0x184")]
	public GUIPlayerNameMenu GUIPlayerNameMenu;

	// Token: 0x04000B4E RID: 2894
	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x188")]
	public GUIPlayerSelectMenu GUIPlayerSelectMenu;

	// Token: 0x04000B4F RID: 2895
	[Token(Token = "0x4000B4F")]
	[FieldOffset(Offset = "0x18C")]
	public GUIQuitConfirm GUIQuitConfirm;

	// Token: 0x04000B50 RID: 2896
	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0x190")]
	public GUIResetSettings GUIResetSettings;

	// Token: 0x04000B51 RID: 2897
	[Token(Token = "0x4000B51")]
	[FieldOffset(Offset = "0x194")]
	public GUISafeRegionEdit GUISafeRegionEdit;

	// Token: 0x04000B52 RID: 2898
	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x198")]
	public GUISettingsOverlay GUISettingsOverlay;

	// Token: 0x04000B53 RID: 2899
	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0x19C")]
	public GUIStatusMenu GUIStatusMenu;

	// Token: 0x04000B54 RID: 2900
	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x1A0")]
	public GUIVirtualInputControllerEdit GUIVirtualInputControllerEdit;

	// Token: 0x04000B55 RID: 2901
	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0x1A4")]
	public GUIPageGroupEdit GUIPageGroupEdit;

	// Token: 0x04000B56 RID: 2902
	[Token(Token = "0x4000B56")]
	[FieldOffset(Offset = "0x1A8")]
	public GUIWorldCreateMenu GUIWorldCreateMenu;

	// Token: 0x04000B57 RID: 2903
	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0x1AC")]
	public GUIWorldGenerateMenu GUIWorldGenerateMenu;

	// Token: 0x04000B58 RID: 2904
	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0x1B0")]
	public GUIWorldLoadBackup GUIWorldLoadBackup;

	// Token: 0x04000B59 RID: 2905
	[Token(Token = "0x4000B59")]
	[FieldOffset(Offset = "0x1B4")]
	public GUIWorldNameMenu GUIWorldNameMenu;

	// Token: 0x04000B5A RID: 2906
	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0x1B8")]
	public GUIWorldNoBackup GUIWorldNoBackup;

	// Token: 0x04000B5B RID: 2907
	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0x1BC")]
	public GUIWorldSelectMenu GUIWorldSelectMenu;

	// Token: 0x04000B5C RID: 2908
	[Token(Token = "0x4000B5C")]
	[FieldOffset(Offset = "0x1C0")]
	public GUIPageOptions GUIPageOptions;

	// Token: 0x04000B5D RID: 2909
	[Token(Token = "0x4000B5D")]
	[FieldOffset(Offset = "0x1C4")]
	public GUITalkerList GUITalkerList;

	// Token: 0x04000B5E RID: 2910
	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0x1C8")]
	public GUIControllerDisconnected GUIControllerDisconnected;

	// Token: 0x04000B5F RID: 2911
	[Token(Token = "0x4000B5F")]
	[FieldOffset(Offset = "0x1CC")]
	public GUIAccessoryInfoToggles GUIAccessoryInfoToggles;

	// Token: 0x04000B60 RID: 2912
	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0x1D0")]
	public GUIEquipmentLoadout GUIEquipmentLoadout;

	// Token: 0x04000B61 RID: 2913
	[Token(Token = "0x4000B61")]
	[FieldOffset(Offset = "0x1D4")]
	public GUIWorldCreateSecretSeeds GUIWorldCreateSecretSeeds;

	// Token: 0x04000B62 RID: 2914
	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x1D8")]
	public GUIControllerMappings GUIControllerMappings;

	// Token: 0x04000B63 RID: 2915
	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x1DC")]
	public VirtualControllerInputState VirtualControllerInputState;

	// Token: 0x04000B64 RID: 2916
	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0x1E0")]
	public GUIResearch GUIResearch;

	// Token: 0x04000B65 RID: 2917
	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0x1E4")]
	public GUIKeyboardMappings GUIKeyboardMappings;

	// Token: 0x04000B66 RID: 2918
	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0x1E8")]
	public GUIBestiary GUIBestiary;

	// Token: 0x04000B67 RID: 2919
	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x1EC")]
	public GUIBuilderAccToggles GUIBuilderAccToggles;

	// Token: 0x04000B68 RID: 2920
	[Token(Token = "0x4000B68")]
	[FieldOffset(Offset = "0x1F0")]
	public GUIPS4MultiplayerChecks GUIPS4MultiplayerChecks;

	// Token: 0x04000B69 RID: 2921
	[Token(Token = "0x4000B69")]
	[FieldOffset(Offset = "0x1F4")]
	public GUIReturnToTouch GUIReturnToTouch;

	// Token: 0x04000B6A RID: 2922
	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x1F8")]
	public Rectangle BottomCentre_Root;

	// Token: 0x04000B6B RID: 2923
	[Token(Token = "0x4000B6B")]
	[FieldOffset(Offset = "0x208")]
	public Rectangle BottomCentre_ChatUI;

	// Token: 0x04000B6C RID: 2924
	[Token(Token = "0x4000B6C")]
	[FieldOffset(Offset = "0x218")]
	public Rectangle BottomCentre_BossBar;

	// Token: 0x04000B6D RID: 2925
	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0x228")]
	public Rectangle BottomCentre_EventBar;

	// Token: 0x04000B6E RID: 2926
	[Token(Token = "0x4000B6E")]
	[FieldOffset(Offset = "0x238")]
	public Rectangle BottomCentre_SpectatorMode;

	// Token: 0x04000B6F RID: 2927
	[Token(Token = "0x4000B6F")]
	[FieldOffset(Offset = "0x248")]
	public Rectangle BottomCentre_ProgressIndicator;

	// Token: 0x04000B70 RID: 2928
	[Token(Token = "0x4000B70")]
	[FieldOffset(Offset = "0x258")]
	public Rectangle BottomCentre_Notification;

	// Token: 0x04000B71 RID: 2929
	[Token(Token = "0x4000B71")]
	[FieldOffset(Offset = "0x268")]
	public Rectangle TopMenuCentre_Root;

	// Token: 0x04000B72 RID: 2930
	[Token(Token = "0x4000B72")]
	[FieldOffset(Offset = "0x278")]
	public Rectangle Right_Root;

	// Token: 0x04000B73 RID: 2931
	[Token(Token = "0x4000B73")]
	[FieldOffset(Offset = "0x288")]
	public Rectangle Right_MainUI;

	// Token: 0x04000B74 RID: 2932
	[Token(Token = "0x4000B74")]
	[FieldOffset(Offset = "0x298")]
	public Rectangle Right_TextNotifications;

	// Token: 0x04000B75 RID: 2933
	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x2A8")]
	public Rectangle Right_Event;

	// Token: 0x04000B76 RID: 2934
	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x2B8")]
	public Rectangle Right_BossBar;

	// Token: 0x04000B77 RID: 2935
	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x2C8")]
	public Rectangle Right_StatusIndicator;

	// Token: 0x04000B78 RID: 2936
	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0x2D8")]
	public Rectangle Right_InfoAccessories;

	// Token: 0x04000B79 RID: 2937
	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x2E8")]
	public Rectangle Right_InfoAccessories2;

	// Token: 0x04000B7A RID: 2938
	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x2F8")]
	public Rectangle Right_AchievementNotifiations;

	// Token: 0x04000B7B RID: 2939
	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x308")]
	public Rectangle _gridItemRegion;

	// Token: 0x04000B7C RID: 2940
	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x318")]
	public Rectangle PageGroupRegion;

	// Token: 0x04000B7D RID: 2941
	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0x328")]
	public Rectangle PageContentRegion;

	// Token: 0x04000B7E RID: 2942
	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x338")]
	public Rectangle _leftPageRegion;

	// Token: 0x04000B7F RID: 2943
	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x348")]
	public Rectangle _rightPageRegion;

	// Token: 0x04000B80 RID: 2944
	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x358")]
	public Rectangle _selectedItemRegion;

	// Token: 0x04000B81 RID: 2945
	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x368")]
	public Rectangle _buttonRegion;

	// Token: 0x04000B82 RID: 2946
	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x378")]
	public Rectangle _mainMenuPageRegion;

	// Token: 0x04000B83 RID: 2947
	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x388")]
	public Vector2 LeftInterface;

	// Token: 0x04000B84 RID: 2948
	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x390")]
	public Vector2 RightInterface;

	// Token: 0x04000B85 RID: 2949
	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x398")]
	public bool AllowSecondRow;

	// Token: 0x04000B86 RID: 2950
	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x399")]
	public bool UseCollpasedCoinsAmmo;

	// Token: 0x04000B87 RID: 2951
	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x39C")]
	public int AllowRowHeight;

	// Token: 0x04000B88 RID: 2952
	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x3A0")]
	public bool AllowDraw;

	// Token: 0x04000B89 RID: 2953
	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x3A4")]
	public int currentFrame;

	// Token: 0x04000B8A RID: 2954
	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x3A8")]
	public RightSideHUDAnchorUpdator.TopRightDisplay TopRightDisplay;

	// Token: 0x04000B8B RID: 2955
	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x3AC")]
	public int BottomCentreHUDUpdateFrame;

	// Token: 0x04000B8C RID: 2956
	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x3B0")]
	public int TopScreenMenuLogoAnchorFrame;

	// Token: 0x04000B8D RID: 2957
	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x3B4")]
	public WiresUI.Settings.MultiToolMode ToolMode;

	// Token: 0x04000B8E RID: 2958
	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x3B8")]
	public int _lastActuatorEnabled;

	// Token: 0x04000B8F RID: 2959
	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x3BC")]
	public List<int> optionRedirection;

	// Token: 0x04000B90 RID: 2960
	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x3C0")]
	public Vector3 mouseHSL;

	// Token: 0x04000B91 RID: 2961
	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x3CC")]
	public Vector3 mouseBorderHSL;

	// Token: 0x04000B92 RID: 2962
	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x3D8")]
	public Vector3 controllerHSL;

	// Token: 0x04000B93 RID: 2963
	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x3E4")]
	public Vector3 controllerBorderHSL;
}
