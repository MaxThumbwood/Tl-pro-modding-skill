using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Achievements;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Golf;
using Terraria.GameContent.UI.BigProgressBar;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Light;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.IO;
using Terraria.Map;
using Terraria.UI;

// Token: 0x02000314 RID: 788
[Token(Token = "0x2000314")]
public class LocalUserGameState
{
	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06001394 RID: 5012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D4")]
	public FavoritesFile LocalFavoriteData
	{
		[Token(Token = "0x6001394")]
		[Address(RVA = "0xDA73C0", Offset = "0xDA73C0", VA = "0xDA73C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06001395 RID: 5013 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001396 RID: 5014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D5")]
	public WaterfallManager waterfallManager
	{
		[Token(Token = "0x6001395")]
		[Address(RVA = "0xDA7544", Offset = "0xDA7544", VA = "0xDA7544")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001396")]
		[Address(RVA = "0xDA75CC", Offset = "0xDA75CC", VA = "0xDA75CC")]
		set
		{
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06001397 RID: 5015 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D6")]
	public LightingEngine NewEngine
	{
		[Token(Token = "0x6001397")]
		[Address(RVA = "0xDA75D4", Offset = "0xDA75D4", VA = "0xDA75D4")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06001398 RID: 5016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D7")]
	public LegacyLighting LegacyEngine
	{
		[Token(Token = "0x6001398")]
		[Address(RVA = "0xDA7678", Offset = "0xDA7678", VA = "0xDA7678")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06001399 RID: 5017 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600139A RID: 5018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D8")]
	public ILightingEngine _activeEngine
	{
		[Token(Token = "0x6001399")]
		[Address(RVA = "0xDA7760", Offset = "0xDA7760", VA = "0xDA7760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600139A")]
		[Address(RVA = "0xDA77A0", Offset = "0xDA77A0", VA = "0xDA77A0")]
		set
		{
		}
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139B")]
	[Address(RVA = "0xDA3220", Offset = "0xDA3220", VA = "0xDA3220")]
	public LocalUserGameState()
	{
	}

	// Token: 0x040025B2 RID: 9650
	[Token(Token = "0x40025B2")]
	public static LocalUserGameState Instance;

	// Token: 0x040025B3 RID: 9651
	[Token(Token = "0x40025B3")]
	[FieldOffset(Offset = "0x8")]
	public bool _panControlKeyAvailable;

	// Token: 0x040025B4 RID: 9652
	[Token(Token = "0x40025B4")]
	[FieldOffset(Offset = "0x9")]
	public Player.Settings.StackToNearbyChestsdMode StackToChestsPreferredMode;

	// Token: 0x040025B5 RID: 9653
	[Token(Token = "0x40025B5")]
	[FieldOffset(Offset = "0xC")]
	public List<string> _seedsForConfig;

	// Token: 0x040025B6 RID: 9654
	[Token(Token = "0x40025B6")]
	[FieldOffset(Offset = "0x10")]
	public List<WorldGen.SecretSeed> _seedsForInterface;

	// Token: 0x040025B7 RID: 9655
	[Token(Token = "0x40025B7")]
	[FieldOffset(Offset = "0x14")]
	public bool _processedConfig;

	// Token: 0x040025B8 RID: 9656
	[Token(Token = "0x40025B8")]
	[FieldOffset(Offset = "0x18")]
	public Player.Settings.DashPreference DashControl;

	// Token: 0x040025B9 RID: 9657
	[Token(Token = "0x40025B9")]
	[FieldOffset(Offset = "0x1C")]
	public Player.Settings.DashPreference ArmorAbilityControl;

	// Token: 0x040025BA RID: 9658
	[Token(Token = "0x40025BA")]
	[FieldOffset(Offset = "0x20")]
	public bool ShowLoadoutShareHint;

	// Token: 0x040025BB RID: 9659
	[Token(Token = "0x40025BB")]
	[FieldOffset(Offset = "0x24")]
	public Point? _lockedDesiredDirection;

	// Token: 0x040025BC RID: 9660
	[Token(Token = "0x40025BC")]
	[FieldOffset(Offset = "0x30")]
	public Point? _lockedContinuityCoords;

	// Token: 0x040025BD RID: 9661
	[Token(Token = "0x40025BD")]
	[FieldOffset(Offset = "0x3C")]
	public bool disableDontStarveDarknessDamage;

	// Token: 0x040025BE RID: 9662
	[Token(Token = "0x40025BE")]
	[FieldOffset(Offset = "0x40")]
	public int darknessTimer;

	// Token: 0x040025BF RID: 9663
	[Token(Token = "0x40025BF")]
	[FieldOffset(Offset = "0x44")]
	public int darknessHitTimer;

	// Token: 0x040025C0 RID: 9664
	[Token(Token = "0x40025C0")]
	[FieldOffset(Offset = "0x48")]
	public bool saidMessage;

	// Token: 0x040025C1 RID: 9665
	[Token(Token = "0x40025C1")]
	[FieldOffset(Offset = "0x49")]
	public bool lastFrameWasTooBright;

	// Token: 0x040025C2 RID: 9666
	[Token(Token = "0x40025C2")]
	[FieldOffset(Offset = "0x4A")]
	public bool CraftFromNearbyChests;

	// Token: 0x040025C3 RID: 9667
	[Token(Token = "0x40025C3")]
	[FieldOffset(Offset = "0x4B")]
	public bool FeetCursorActive;

	// Token: 0x040025C4 RID: 9668
	[Token(Token = "0x40025C4")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 FeetCursorPosition;

	// Token: 0x040025C5 RID: 9669
	[Token(Token = "0x40025C5")]
	[FieldOffset(Offset = "0x54")]
	public bool FilterNetworkText;

	// Token: 0x040025C6 RID: 9670
	[Token(Token = "0x40025C6")]
	[FieldOffset(Offset = "0x55")]
	public bool BlockAllCommunication;

	// Token: 0x040025C7 RID: 9671
	[Token(Token = "0x40025C7")]
	[FieldOffset(Offset = "0x56")]
	public bool UPNP;

	// Token: 0x040025C8 RID: 9672
	[Token(Token = "0x40025C8")]
	[FieldOffset(Offset = "0x57")]
	public bool foundAFairyCheck;

	// Token: 0x040025C9 RID: 9673
	[Token(Token = "0x40025C9")]
	[FieldOffset(Offset = "0x58")]
	public bool _hasDelayedFindRecipes;

	// Token: 0x040025CA RID: 9674
	[Token(Token = "0x40025CA")]
	[FieldOffset(Offset = "0x5C")]
	public List<DestinationInventory> _inRangeSources;

	// Token: 0x040025CB RID: 9675
	[Token(Token = "0x40025CB")]
	[FieldOffset(Offset = "0x60")]
	public List<DestinationInventory> _recipeSources;

	// Token: 0x040025CC RID: 9676
	[Token(Token = "0x40025CC")]
	[FieldOffset(Offset = "0x64")]
	public Dictionary<int, int> _ownedItems;

	// Token: 0x040025CD RID: 9677
	[Token(Token = "0x40025CD")]
	[FieldOffset(Offset = "0x68")]
	public int CraftingFilterX;

	// Token: 0x040025CE RID: 9678
	[Token(Token = "0x40025CE")]
	[FieldOffset(Offset = "0x6C")]
	public int CraftingFilterY;

	// Token: 0x040025CF RID: 9679
	[Token(Token = "0x40025CF")]
	[FieldOffset(Offset = "0x70")]
	public List<int> AllowedRequiredTileIdsForFilter;

	// Token: 0x040025D0 RID: 9680
	[Token(Token = "0x40025D0")]
	[FieldOffset(Offset = "0x74")]
	public List<IInGameNotification> _notifications;

	// Token: 0x040025D1 RID: 9681
	[Token(Token = "0x40025D1")]
	[FieldOffset(Offset = "0x78")]
	public int dyeSwapCounter;

	// Token: 0x040025D2 RID: 9682
	[Token(Token = "0x40025D2")]
	[FieldOffset(Offset = "0x7C")]
	public float[] inventoryGlowHue;

	// Token: 0x040025D3 RID: 9683
	[Token(Token = "0x40025D3")]
	[FieldOffset(Offset = "0x80")]
	public int[] inventoryGlowTime;

	// Token: 0x040025D4 RID: 9684
	[Token(Token = "0x40025D4")]
	[FieldOffset(Offset = "0x84")]
	public float[] inventoryGlowHueChest;

	// Token: 0x040025D5 RID: 9685
	[Token(Token = "0x40025D5")]
	[FieldOffset(Offset = "0x88")]
	public int[] inventoryGlowTimeChest;

	// Token: 0x040025D6 RID: 9686
	[Token(Token = "0x40025D6")]
	[FieldOffset(Offset = "0x8C")]
	public ItemSlot.PulseEffect[] playerSlotPulseEffects;

	// Token: 0x040025D7 RID: 9687
	[Token(Token = "0x40025D7")]
	[FieldOffset(Offset = "0x90")]
	public int _customCurrencyForSavings;

	// Token: 0x040025D8 RID: 9688
	[Token(Token = "0x40025D8")]
	[FieldOffset(Offset = "0x94")]
	public CoinSlot.CoinEntry[] CoinSlot_Savings;

	// Token: 0x040025D9 RID: 9689
	[Token(Token = "0x40025D9")]
	[FieldOffset(Offset = "0x98")]
	public CoinSlot.CoinEntry[] CoinSlot_ChestEntries;

	// Token: 0x040025DA RID: 9690
	[Token(Token = "0x40025DA")]
	[FieldOffset(Offset = "0x9C")]
	public CoinSlot.CoinEntry[] CoinSlot_InventoryEntries;

	// Token: 0x040025DB RID: 9691
	[Token(Token = "0x40025DB")]
	[FieldOffset(Offset = "0xA0")]
	public Dictionary<int, CoinSlot.CoinEntryRef> CoinSlot_Custom;

	// Token: 0x040025DC RID: 9692
	[Token(Token = "0x40025DC")]
	[FieldOffset(Offset = "0xA4")]
	public Vector2 LastCelestialBodyPosition;

	// Token: 0x040025DD RID: 9693
	[Token(Token = "0x40025DD")]
	[FieldOffset(Offset = "0xAC")]
	public Vector2 LastCelestialBodyPositionScaled;

	// Token: 0x040025DE RID: 9694
	[Token(Token = "0x40025DE")]
	[FieldOffset(Offset = "0xB4")]
	public float LastSunVisibility;

	// Token: 0x040025DF RID: 9695
	[Token(Token = "0x40025DF")]
	[FieldOffset(Offset = "0xB8")]
	public bool[] SunMask;

	// Token: 0x040025E0 RID: 9696
	[Token(Token = "0x40025E0")]
	[FieldOffset(Offset = "0xBC")]
	public AchievementManager _achievements;

	// Token: 0x040025E1 RID: 9697
	[Token(Token = "0x40025E1")]
	[FieldOffset(Offset = "0xC0")]
	public CreativePowerManager CreativePowerManager;

	// Token: 0x040025E2 RID: 9698
	[Token(Token = "0x40025E2")]
	[FieldOffset(Offset = "0xC4")]
	public bool CreativePowerManager_initialized;

	// Token: 0x040025E3 RID: 9699
	[Token(Token = "0x40025E3")]
	[FieldOffset(Offset = "0xC5")]
	public bool SwapBumpersTriggers;

	// Token: 0x040025E4 RID: 9700
	[Token(Token = "0x40025E4")]
	[FieldOffset(Offset = "0xC8")]
	public float whitening;

	// Token: 0x040025E5 RID: 9701
	[Token(Token = "0x40025E5")]
	[FieldOffset(Offset = "0xCC")]
	public float requestedLight;

	// Token: 0x040025E6 RID: 9702
	[Token(Token = "0x40025E6")]
	[FieldOffset(Offset = "0xD0")]
	public Rectangle sceneArea;

	// Token: 0x040025E7 RID: 9703
	[Token(Token = "0x40025E7")]
	[FieldOffset(Offset = "0xE0")]
	public float sceneSnowiness;

	// Token: 0x040025E8 RID: 9704
	[Token(Token = "0x40025E8")]
	[FieldOffset(Offset = "0xE4")]
	public bool AllowCrossplay;

	// Token: 0x040025E9 RID: 9705
	[Token(Token = "0x40025E9")]
	[FieldOffset(Offset = "0xE8")]
	public object MapHelperIOLock;

	// Token: 0x040025EA RID: 9706
	[Token(Token = "0x40025EA")]
	[FieldOffset(Offset = "0xEC")]
	public float ScrollSensitivity;

	// Token: 0x040025EB RID: 9707
	[Token(Token = "0x40025EB")]
	[FieldOffset(Offset = "0xF0")]
	public LockOnHelperStaticData LockOnHelperStaticData;

	// Token: 0x040025EC RID: 9708
	[Token(Token = "0x40025EC")]
	[FieldOffset(Offset = "0xF4")]
	public TileObjectPreviewData objectPreview;

	// Token: 0x040025ED RID: 9709
	[Token(Token = "0x40025ED")]
	[FieldOffset(Offset = "0xF8")]
	public Netplay.RecentServerInformation[] RecentServer;

	// Token: 0x040025EE RID: 9710
	[Token(Token = "0x40025EE")]
	[FieldOffset(Offset = "0xFC")]
	public bool flushLighting;

	// Token: 0x040025EF RID: 9711
	[Token(Token = "0x40025EF")]
	[FieldOffset(Offset = "0x100")]
	public MinimapFrame ActiveMinimapFrame;

	// Token: 0x040025F0 RID: 9712
	[Token(Token = "0x40025F0")]
	[FieldOffset(Offset = "0x104")]
	public IPlayerResourcesDisplaySet ActivePlayerResourcesSet;

	// Token: 0x040025F1 RID: 9713
	[Token(Token = "0x40025F1")]
	[FieldOffset(Offset = "0x108")]
	public int mapDelay;

	// Token: 0x040025F2 RID: 9714
	[Token(Token = "0x40025F2")]
	[FieldOffset(Offset = "0x10C")]
	public bool InReforgeMenu;

	// Token: 0x040025F3 RID: 9715
	[Token(Token = "0x40025F3")]
	[FieldOffset(Offset = "0x10D")]
	public bool InGuideCraftMenu;

	// Token: 0x040025F4 RID: 9716
	[Token(Token = "0x40025F4")]
	[FieldOffset(Offset = "0x10E")]
	public bool anglerQuestFinished;

	// Token: 0x040025F5 RID: 9717
	[Token(Token = "0x40025F5")]
	[FieldOffset(Offset = "0x10F")]
	public bool HoveringOverAnNPC;

	// Token: 0x040025F6 RID: 9718
	[Token(Token = "0x40025F6")]
	[FieldOffset(Offset = "0x110")]
	public int currentNPCShowingChatBubble;

	// Token: 0x040025F7 RID: 9719
	[Token(Token = "0x40025F7")]
	[FieldOffset(Offset = "0x114")]
	public float hBar;

	// Token: 0x040025F8 RID: 9720
	[Token(Token = "0x40025F8")]
	[FieldOffset(Offset = "0x118")]
	public float sBar;

	// Token: 0x040025F9 RID: 9721
	[Token(Token = "0x40025F9")]
	[FieldOffset(Offset = "0x11C")]
	public float lBar;

	// Token: 0x040025FA RID: 9722
	[Token(Token = "0x40025FA")]
	[FieldOffset(Offset = "0x120")]
	public float aBar;

	// Token: 0x040025FB RID: 9723
	[Token(Token = "0x40025FB")]
	[FieldOffset(Offset = "0x124")]
	public int mouseNPCIndex;

	// Token: 0x040025FC RID: 9724
	[Token(Token = "0x40025FC")]
	[FieldOffset(Offset = "0x128")]
	public int mouseNPCType;

	// Token: 0x040025FD RID: 9725
	[Token(Token = "0x40025FD")]
	[FieldOffset(Offset = "0x12C")]
	public int firstTileX;

	// Token: 0x040025FE RID: 9726
	[Token(Token = "0x40025FE")]
	[FieldOffset(Offset = "0x130")]
	public int lastTileX;

	// Token: 0x040025FF RID: 9727
	[Token(Token = "0x40025FF")]
	[FieldOffset(Offset = "0x134")]
	public int firstTileY;

	// Token: 0x04002600 RID: 9728
	[Token(Token = "0x4002600")]
	[FieldOffset(Offset = "0x138")]
	public int lastTileY;

	// Token: 0x04002601 RID: 9729
	[Token(Token = "0x4002601")]
	[FieldOffset(Offset = "0x13C")]
	public int rare;

	// Token: 0x04002602 RID: 9730
	[Token(Token = "0x4002602")]
	[FieldOffset(Offset = "0x140")]
	public int hairStart;

	// Token: 0x04002603 RID: 9731
	[Token(Token = "0x4002603")]
	[FieldOffset(Offset = "0x144")]
	public int oldHairStyle;

	// Token: 0x04002604 RID: 9732
	[Token(Token = "0x4002604")]
	[FieldOffset(Offset = "0x148")]
	public Color oldHairColor;

	// Token: 0x04002605 RID: 9733
	[Token(Token = "0x4002605")]
	[FieldOffset(Offset = "0x14C")]
	public int selClothes;

	// Token: 0x04002606 RID: 9734
	[Token(Token = "0x4002606")]
	[FieldOffset(Offset = "0x150")]
	public Color[] oldClothesColor;

	// Token: 0x04002607 RID: 9735
	[Token(Token = "0x4002607")]
	[FieldOffset(Offset = "0x154")]
	public int oldClothesStyle;

	// Token: 0x04002608 RID: 9736
	[Token(Token = "0x4002608")]
	[FieldOffset(Offset = "0x158")]
	public int oldVoiceStyle;

	// Token: 0x04002609 RID: 9737
	[Token(Token = "0x4002609")]
	[FieldOffset(Offset = "0x15C")]
	public float oldVoicePitch;

	// Token: 0x0400260A RID: 9738
	[Token(Token = "0x400260A")]
	[FieldOffset(Offset = "0x160")]
	public int interactedDresserTopLeftX;

	// Token: 0x0400260B RID: 9739
	[Token(Token = "0x400260B")]
	[FieldOffset(Offset = "0x164")]
	public int interactedDresserTopLeftY;

	// Token: 0x0400260C RID: 9740
	[Token(Token = "0x400260C")]
	[FieldOffset(Offset = "0x168")]
	public Vector2 _itemIconCacheScreenPosition;

	// Token: 0x0400260D RID: 9741
	[Token(Token = "0x400260D")]
	[FieldOffset(Offset = "0x170")]
	public int _itemIconCacheSelectedItemID;

	// Token: 0x0400260E RID: 9742
	[Token(Token = "0x400260E")]
	[FieldOffset(Offset = "0x174")]
	public int _itemIconCacheTime;

	// Token: 0x0400260F RID: 9743
	[Token(Token = "0x400260F")]
	[FieldOffset(Offset = "0x178")]
	public Player dresserInterfaceDummy;

	// Token: 0x04002610 RID: 9744
	[Token(Token = "0x4002610")]
	[FieldOffset(Offset = "0x17C")]
	public Color selColor;

	// Token: 0x04002611 RID: 9745
	[Token(Token = "0x4002611")]
	[FieldOffset(Offset = "0x180")]
	public int waterStyle;

	// Token: 0x04002612 RID: 9746
	[Token(Token = "0x4002612")]
	[FieldOffset(Offset = "0x184")]
	public bool drewLava;

	// Token: 0x04002613 RID: 9747
	[Token(Token = "0x4002613")]
	[FieldOffset(Offset = "0x188")]
	public float[] liquidAlpha;

	// Token: 0x04002614 RID: 9748
	[Token(Token = "0x4002614")]
	[FieldOffset(Offset = "0x18C")]
	public int[] activeLiquidAlpha;

	// Token: 0x04002615 RID: 9749
	[Token(Token = "0x4002615")]
	[FieldOffset(Offset = "0x190")]
	public int numActiveLiquidAlpha;

	// Token: 0x04002616 RID: 9750
	[Token(Token = "0x4002616")]
	[FieldOffset(Offset = "0x194")]
	public bool SettingsUnlock_WorldEvil;

	// Token: 0x04002617 RID: 9751
	[Token(Token = "0x4002617")]
	[FieldOffset(Offset = "0x195")]
	public bool SettingsEnabled_MinersWobble;

	// Token: 0x04002618 RID: 9752
	[Token(Token = "0x4002618")]
	[FieldOffset(Offset = "0x196")]
	public bool SettingBlockGamepadsEntirely;

	// Token: 0x04002619 RID: 9753
	[Token(Token = "0x4002619")]
	[FieldOffset(Offset = "0x197")]
	public bool SettingDontScaleMainMenuUp;

	// Token: 0x0400261A RID: 9754
	[Token(Token = "0x400261A")]
	[FieldOffset(Offset = "0x198")]
	public bool SettingsEnabled_OpaqueBoxBehindTooltips;

	// Token: 0x0400261B RID: 9755
	[Token(Token = "0x400261B")]
	[FieldOffset(Offset = "0x19C")]
	public int tooltipTime;

	// Token: 0x0400261C RID: 9756
	[Token(Token = "0x400261C")]
	[FieldOffset(Offset = "0x1A0")]
	public int inventoryTooltipTime;

	// Token: 0x0400261D RID: 9757
	[Token(Token = "0x400261D")]
	[FieldOffset(Offset = "0x1A4")]
	public bool SettingMusicReplayDelayEnabled;

	// Token: 0x0400261E RID: 9758
	[Token(Token = "0x400261E")]
	[FieldOffset(Offset = "0x1A5")]
	public bool MouseShowBuildingGrid;

	// Token: 0x0400261F RID: 9759
	[Token(Token = "0x400261F")]
	[FieldOffset(Offset = "0x1A8")]
	public float MouseBuildingGridAlpha;

	// Token: 0x04002620 RID: 9760
	[Token(Token = "0x4002620")]
	[FieldOffset(Offset = "0x1AC")]
	public float GraveyardVisualIntensity;

	// Token: 0x04002621 RID: 9761
	[Token(Token = "0x4002621")]
	[FieldOffset(Offset = "0x1B0")]
	public float SmoothedMushroomLightInfluence;

	// Token: 0x04002622 RID: 9762
	[Token(Token = "0x4002622")]
	[FieldOffset(Offset = "0x1B4")]
	public bool ScreenPostProcessor_Enabled;

	// Token: 0x04002623 RID: 9763
	[Token(Token = "0x4002623")]
	[FieldOffset(Offset = "0x1B8")]
	public List<ScreenPostProcessor> ScreenPostProcessor_Instances;

	// Token: 0x04002624 RID: 9764
	[Token(Token = "0x4002624")]
	[FieldOffset(Offset = "0x1BC")]
	public List<ScreenPostProcessor> ScreenPostProcessor_UIInstances;

	// Token: 0x04002625 RID: 9765
	[Token(Token = "0x4002625")]
	[FieldOffset(Offset = "0x1C0")]
	public List<Filter> ScreenPostProcessor_Filters;

	// Token: 0x04002626 RID: 9766
	[Token(Token = "0x4002626")]
	[FieldOffset(Offset = "0x1C4")]
	public int ScreenPostProcessor_countUpdate;

	// Token: 0x04002627 RID: 9767
	[Token(Token = "0x4002627")]
	[FieldOffset(Offset = "0x1C8")]
	public int ScreenPostProcessor_renderCheck;

	// Token: 0x04002628 RID: 9768
	[Token(Token = "0x4002628")]
	[FieldOffset(Offset = "0x1CC")]
	public ItemShopSellbackHelper shopSellbackHelper;

	// Token: 0x04002629 RID: 9769
	[Token(Token = "0x4002629")]
	[FieldOffset(Offset = "0x1D0")]
	public InventoryStorage[] shop;

	// Token: 0x0400262A RID: 9770
	[Token(Token = "0x400262A")]
	[FieldOffset(Offset = "0x1D4")]
	public int npcChatCornerItem;

	// Token: 0x0400262B RID: 9771
	[Token(Token = "0x400262B")]
	[FieldOffset(Offset = "0x1D8")]
	public int npcShop;

	// Token: 0x0400262C RID: 9772
	[Token(Token = "0x400262C")]
	[FieldOffset(Offset = "0x1DC")]
	public NPCID.Sets.NPCPortraitProvider npcChatPortrait;

	// Token: 0x0400262D RID: 9773
	[Token(Token = "0x400262D")]
	[FieldOffset(Offset = "0x1E0")]
	public DateTime npcChatPortraitFrameCounter;

	// Token: 0x0400262E RID: 9774
	[Token(Token = "0x400262E")]
	[FieldOffset(Offset = "0x1E8")]
	public bool npcChatFocus1;

	// Token: 0x0400262F RID: 9775
	[Token(Token = "0x400262F")]
	[FieldOffset(Offset = "0x1E9")]
	public bool npcChatFocus2;

	// Token: 0x04002630 RID: 9776
	[Token(Token = "0x4002630")]
	[FieldOffset(Offset = "0x1EA")]
	public bool npcChatFocus3;

	// Token: 0x04002631 RID: 9777
	[Token(Token = "0x4002631")]
	[FieldOffset(Offset = "0x1EB")]
	public bool npcChatFocus4;

	// Token: 0x04002632 RID: 9778
	[Token(Token = "0x4002632")]
	[FieldOffset(Offset = "0x1EC")]
	public string npcChatText;

	// Token: 0x04002633 RID: 9779
	[Token(Token = "0x4002633")]
	[FieldOffset(Offset = "0x1F0")]
	public string defaultChestName;

	// Token: 0x04002634 RID: 9780
	[Token(Token = "0x4002634")]
	[FieldOffset(Offset = "0x1F4")]
	public string blockKey;

	// Token: 0x04002635 RID: 9781
	[Token(Token = "0x4002635")]
	[FieldOffset(Offset = "0x1F8")]
	public bool blockInput;

	// Token: 0x04002636 RID: 9782
	[Token(Token = "0x4002636")]
	[FieldOffset(Offset = "0x1FC")]
	public string _savePath;

	// Token: 0x04002637 RID: 9783
	[Token(Token = "0x4002637")]
	[FieldOffset(Offset = "0x200")]
	public string _oldSavePath;

	// Token: 0x04002638 RID: 9784
	[Token(Token = "0x4002638")]
	[FieldOffset(Offset = "0x204")]
	public bool StateInitialised;

	// Token: 0x04002639 RID: 9785
	[Token(Token = "0x4002639")]
	[FieldOffset(Offset = "0x208")]
	public Camera Camera;

	// Token: 0x0400263A RID: 9786
	[Token(Token = "0x400263A")]
	[FieldOffset(Offset = "0x20C")]
	public FavoritesFile _localFavoriteData;

	// Token: 0x0400263B RID: 9787
	[Token(Token = "0x400263B")]
	[FieldOffset(Offset = "0x210")]
	public Preferences _configuration;

	// Token: 0x0400263C RID: 9788
	[Token(Token = "0x400263C")]
	[FieldOffset(Offset = "0x214")]
	public Preferences _inputProfiles;

	// Token: 0x0400263D RID: 9789
	[Token(Token = "0x400263D")]
	[FieldOffset(Offset = "0x218")]
	public WorldSections sectionManager;

	// Token: 0x0400263E RID: 9790
	[Token(Token = "0x400263E")]
	[FieldOffset(Offset = "0x21C")]
	public BigProgressBarSystem BigBossProgressBar;

	// Token: 0x0400263F RID: 9791
	[Token(Token = "0x400263F")]
	[FieldOffset(Offset = "0x220")]
	public float hellBlackBoxBottom;

	// Token: 0x04002640 RID: 9792
	[Token(Token = "0x4002640")]
	[FieldOffset(Offset = "0x224")]
	public int[] backTexture;

	// Token: 0x04002641 RID: 9793
	[Token(Token = "0x4002641")]
	[FieldOffset(Offset = "0x228")]
	public int[] oldBackTexture;

	// Token: 0x04002642 RID: 9794
	[Token(Token = "0x4002642")]
	[FieldOffset(Offset = "0x22C")]
	public Texture2D[] backTextureValues;

	// Token: 0x04002643 RID: 9795
	[Token(Token = "0x4002643")]
	[FieldOffset(Offset = "0x230")]
	public Texture2D[] oldBackTextureValues;

	// Token: 0x04002644 RID: 9796
	[Token(Token = "0x4002644")]
	[FieldOffset(Offset = "0x234")]
	public FileMetadata MapFileMetadata;

	// Token: 0x04002645 RID: 9797
	[Token(Token = "0x4002645")]
	[FieldOffset(Offset = "0x238")]
	public Main.MouseTextCache _mouseTextCache;

	// Token: 0x04002646 RID: 9798
	[Token(Token = "0x4002646")]
	[FieldOffset(Offset = "0x25C")]
	private WaterfallManager _waterfallManager;

	// Token: 0x04002647 RID: 9799
	[Token(Token = "0x4002647")]
	[FieldOffset(Offset = "0x260")]
	public Rain[] rain;

	// Token: 0x04002648 RID: 9800
	[Token(Token = "0x4002648")]
	[FieldOffset(Offset = "0x264")]
	public PopupText[] popupText;

	// Token: 0x04002649 RID: 9801
	[Token(Token = "0x4002649")]
	[FieldOffset(Offset = "0x268")]
	public int mouseX;

	// Token: 0x0400264A RID: 9802
	[Token(Token = "0x400264A")]
	[FieldOffset(Offset = "0x26C")]
	public int mouseY;

	// Token: 0x0400264B RID: 9803
	[Token(Token = "0x400264B")]
	[FieldOffset(Offset = "0x270")]
	public int worldMouseX;

	// Token: 0x0400264C RID: 9804
	[Token(Token = "0x400264C")]
	[FieldOffset(Offset = "0x274")]
	public int worldMouseY;

	// Token: 0x0400264D RID: 9805
	[Token(Token = "0x400264D")]
	[FieldOffset(Offset = "0x278")]
	public int lastMouseX;

	// Token: 0x0400264E RID: 9806
	[Token(Token = "0x400264E")]
	[FieldOffset(Offset = "0x27C")]
	public int lastMouseY;

	// Token: 0x0400264F RID: 9807
	[Token(Token = "0x400264F")]
	[FieldOffset(Offset = "0x280")]
	public bool mouseLeft;

	// Token: 0x04002650 RID: 9808
	[Token(Token = "0x4002650")]
	[FieldOffset(Offset = "0x281")]
	public bool mouseRight;

	// Token: 0x04002651 RID: 9809
	[Token(Token = "0x4002651")]
	[FieldOffset(Offset = "0x282")]
	public bool worldMouseLeft;

	// Token: 0x04002652 RID: 9810
	[Token(Token = "0x4002652")]
	[FieldOffset(Offset = "0x283")]
	public bool worldMouseRight;

	// Token: 0x04002653 RID: 9811
	[Token(Token = "0x4002653")]
	[FieldOffset(Offset = "0x284")]
	public bool worldMouseLeftRelease;

	// Token: 0x04002654 RID: 9812
	[Token(Token = "0x4002654")]
	[FieldOffset(Offset = "0x285")]
	public bool worldMouseRightRelease;

	// Token: 0x04002655 RID: 9813
	[Token(Token = "0x4002655")]
	[FieldOffset(Offset = "0x286")]
	public bool isMouseLeftConsumedByUI;

	// Token: 0x04002656 RID: 9814
	[Token(Token = "0x4002656")]
	[FieldOffset(Offset = "0x287")]
	public bool hairWindow;

	// Token: 0x04002657 RID: 9815
	[Token(Token = "0x4002657")]
	[FieldOffset(Offset = "0x288")]
	public bool clothesWindow;

	// Token: 0x04002658 RID: 9816
	[Token(Token = "0x4002658")]
	[FieldOffset(Offset = "0x289")]
	public bool ingameOptionsWindow;

	// Token: 0x04002659 RID: 9817
	[Token(Token = "0x4002659")]
	[FieldOffset(Offset = "0x28A")]
	public bool inFancyUI;

	// Token: 0x0400265A RID: 9818
	[Token(Token = "0x400265A")]
	[FieldOffset(Offset = "0x28B")]
	public byte gFade;

	// Token: 0x0400265B RID: 9819
	[Token(Token = "0x400265B")]
	[FieldOffset(Offset = "0x28C")]
	public float gFader;

	// Token: 0x0400265C RID: 9820
	[Token(Token = "0x400265C")]
	[FieldOffset(Offset = "0x290")]
	public byte gFadeDir;

	// Token: 0x0400265D RID: 9821
	[Token(Token = "0x400265D")]
	[FieldOffset(Offset = "0x294")]
	public float startScreenYOffset;

	// Token: 0x0400265E RID: 9822
	[Token(Token = "0x400265E")]
	[FieldOffset(Offset = "0x298")]
	public float targetScreenYOffset;

	// Token: 0x0400265F RID: 9823
	[Token(Token = "0x400265F")]
	[FieldOffset(Offset = "0x29C")]
	public int CameraMovementMode;

	// Token: 0x04002660 RID: 9824
	[Token(Token = "0x4002660")]
	[FieldOffset(Offset = "0x2A0")]
	public int ManaTextMode;

	// Token: 0x04002661 RID: 9825
	[Token(Token = "0x4002661")]
	[FieldOffset(Offset = "0x2A4")]
	public int HeartTextMode;

	// Token: 0x04002662 RID: 9826
	[Token(Token = "0x4002662")]
	[FieldOffset(Offset = "0x2A8")]
	public float screenYOffset;

	// Token: 0x04002663 RID: 9827
	[Token(Token = "0x4002663")]
	[FieldOffset(Offset = "0x2AC")]
	public float cameraOffset;

	// Token: 0x04002664 RID: 9828
	[Token(Token = "0x4002664")]
	[FieldOffset(Offset = "0x2B0")]
	public Vector2 screenPosition;

	// Token: 0x04002665 RID: 9829
	[Token(Token = "0x4002665")]
	[FieldOffset(Offset = "0x2B8")]
	public Vector2 screenLastPosition;

	// Token: 0x04002666 RID: 9830
	[Token(Token = "0x4002666")]
	[FieldOffset(Offset = "0x2C0")]
	public Vector2 screenLastCamPosition;

	// Token: 0x04002667 RID: 9831
	[Token(Token = "0x4002667")]
	[FieldOffset(Offset = "0x2C8")]
	public int screenWidth;

	// Token: 0x04002668 RID: 9832
	[Token(Token = "0x4002668")]
	[FieldOffset(Offset = "0x2CC")]
	public int screenHeight;

	// Token: 0x04002669 RID: 9833
	[Token(Token = "0x4002669")]
	[FieldOffset(Offset = "0x2D0")]
	public bool drawingPlayerChat;

	// Token: 0x0400266A RID: 9834
	[Token(Token = "0x400266A")]
	[FieldOffset(Offset = "0x2D1")]
	public bool chatRelease;

	// Token: 0x0400266B RID: 9835
	[Token(Token = "0x400266B")]
	[FieldOffset(Offset = "0x2D4")]
	public string chatText;

	// Token: 0x0400266C RID: 9836
	[Token(Token = "0x400266C")]
	[FieldOffset(Offset = "0x2D8")]
	public bool inputTextEnter;

	// Token: 0x0400266D RID: 9837
	[Token(Token = "0x400266D")]
	[FieldOffset(Offset = "0x2D9")]
	public bool inputTextEscape;

	// Token: 0x0400266E RID: 9838
	[Token(Token = "0x400266E")]
	[FieldOffset(Offset = "0x2DA")]
	public bool mouseLeftRelease;

	// Token: 0x0400266F RID: 9839
	[Token(Token = "0x400266F")]
	[FieldOffset(Offset = "0x2DB")]
	public bool mouseRightRelease;

	// Token: 0x04002670 RID: 9840
	[Token(Token = "0x4002670")]
	[FieldOffset(Offset = "0x2DC")]
	public bool playerInventory;

	// Token: 0x04002671 RID: 9841
	[Token(Token = "0x4002671")]
	[FieldOffset(Offset = "0x2E0")]
	public int stackSplit;

	// Token: 0x04002672 RID: 9842
	[Token(Token = "0x4002672")]
	[FieldOffset(Offset = "0x2E4")]
	public bool preventStackSplitReset;

	// Token: 0x04002673 RID: 9843
	[Token(Token = "0x4002673")]
	[FieldOffset(Offset = "0x2E8")]
	public int stackCounter;

	// Token: 0x04002674 RID: 9844
	[Token(Token = "0x4002674")]
	[FieldOffset(Offset = "0x2EC")]
	public int stackDelay;

	// Token: 0x04002675 RID: 9845
	[Token(Token = "0x4002675")]
	[FieldOffset(Offset = "0x2F0")]
	public int superFastStack;

	// Token: 0x04002676 RID: 9846
	[Token(Token = "0x4002676")]
	[FieldOffset(Offset = "0x2F4")]
	public int timesTriedToFastStack;

	// Token: 0x04002677 RID: 9847
	[Token(Token = "0x4002677")]
	[FieldOffset(Offset = "0x2F8")]
	public Item mouseItem;

	// Token: 0x04002678 RID: 9848
	[Token(Token = "0x4002678")]
	[FieldOffset(Offset = "0x2FC")]
	public float mouseItemTime;

	// Token: 0x04002679 RID: 9849
	[Token(Token = "0x4002679")]
	[FieldOffset(Offset = "0x300")]
	public Item[] mouseItemSource;

	// Token: 0x0400267A RID: 9850
	[Token(Token = "0x400267A")]
	[FieldOffset(Offset = "0x304")]
	public int mouseItemSourceIndex;

	// Token: 0x0400267B RID: 9851
	[Token(Token = "0x400267B")]
	[FieldOffset(Offset = "0x308")]
	public int mouseItemSourceContext;

	// Token: 0x0400267C RID: 9852
	[Token(Token = "0x400267C")]
	[FieldOffset(Offset = "0x30C")]
	public Item guideItem;

	// Token: 0x0400267D RID: 9853
	[Token(Token = "0x400267D")]
	[FieldOffset(Offset = "0x310")]
	public Item reforgeItem;

	// Token: 0x0400267E RID: 9854
	[Token(Token = "0x400267E")]
	[FieldOffset(Offset = "0x314")]
	public float inventoryScale;

	// Token: 0x0400267F RID: 9855
	[Token(Token = "0x400267F")]
	[FieldOffset(Offset = "0x318")]
	public Point rulerLineDisplayValues;

	// Token: 0x04002680 RID: 9856
	[Token(Token = "0x4002680")]
	[FieldOffset(Offset = "0x320")]
	public int[] availableRecipe;

	// Token: 0x04002681 RID: 9857
	[Token(Token = "0x4002681")]
	[FieldOffset(Offset = "0x324")]
	public int lastRecipeUpdateId;

	// Token: 0x04002682 RID: 9858
	[Token(Token = "0x4002682")]
	[FieldOffset(Offset = "0x328")]
	public int numAvailableRecipes;

	// Token: 0x04002683 RID: 9859
	[Token(Token = "0x4002683")]
	[FieldOffset(Offset = "0x32C")]
	public int focusRecipe;

	// Token: 0x04002684 RID: 9860
	[Token(Token = "0x4002684")]
	[FieldOffset(Offset = "0x330")]
	public int myPlayer;

	// Token: 0x04002685 RID: 9861
	[Token(Token = "0x4002685")]
	[FieldOffset(Offset = "0x334")]
	public int spawnTileX;

	// Token: 0x04002686 RID: 9862
	[Token(Token = "0x4002686")]
	[FieldOffset(Offset = "0x338")]
	public int spawnTileY;

	// Token: 0x04002687 RID: 9863
	[Token(Token = "0x4002687")]
	[FieldOffset(Offset = "0x33C")]
	public bool npcChatRelease;

	// Token: 0x04002688 RID: 9864
	[Token(Token = "0x4002688")]
	[FieldOffset(Offset = "0x33D")]
	public bool editSign;

	// Token: 0x04002689 RID: 9865
	[Token(Token = "0x4002689")]
	[FieldOffset(Offset = "0x33E")]
	public bool editChest;

	// Token: 0x0400268A RID: 9866
	[Token(Token = "0x400268A")]
	[FieldOffset(Offset = "0x340")]
	public int oldNPCShop;

	// Token: 0x0400268B RID: 9867
	[Token(Token = "0x400268B")]
	[FieldOffset(Offset = "0x344")]
	public bool gameMenu;

	// Token: 0x0400268C RID: 9868
	[Token(Token = "0x400268C")]
	[FieldOffset(Offset = "0x348")]
	public int menuMode;

	// Token: 0x0400268D RID: 9869
	[Token(Token = "0x400268D")]
	[FieldOffset(Offset = "0x34C")]
	public bool Quitting;

	// Token: 0x0400268E RID: 9870
	[Token(Token = "0x400268E")]
	[FieldOffset(Offset = "0x350")]
	public IChatMonitor chatMonitor;

	// Token: 0x0400268F RID: 9871
	[Token(Token = "0x400268F")]
	[FieldOffset(Offset = "0x354")]
	public List<PlayerFileData> PreviousPlayerList;

	// Token: 0x04002690 RID: 9872
	[Token(Token = "0x4002690")]
	[FieldOffset(Offset = "0x358")]
	public List<PlayerFileData> PlayerList;

	// Token: 0x04002691 RID: 9873
	[Token(Token = "0x4002691")]
	[FieldOffset(Offset = "0x35C")]
	public PlayerFileData ActivePlayerFileData;

	// Token: 0x04002692 RID: 9874
	[Token(Token = "0x4002692")]
	[FieldOffset(Offset = "0x360")]
	public Player PendingPlayer;

	// Token: 0x04002693 RID: 9875
	[Token(Token = "0x4002693")]
	[FieldOffset(Offset = "0x364")]
	public bool SmartCursorShowing;

	// Token: 0x04002694 RID: 9876
	[Token(Token = "0x4002694")]
	[FieldOffset(Offset = "0x368")]
	public int SmartCursorX;

	// Token: 0x04002695 RID: 9877
	[Token(Token = "0x4002695")]
	[FieldOffset(Offset = "0x36C")]
	public int SmartCursorY;

	// Token: 0x04002696 RID: 9878
	[Token(Token = "0x4002696")]
	[FieldOffset(Offset = "0x370")]
	public bool SmartInteractShowingGenuine;

	// Token: 0x04002697 RID: 9879
	[Token(Token = "0x4002697")]
	[FieldOffset(Offset = "0x371")]
	public bool SmartInteractShowingFake;

	// Token: 0x04002698 RID: 9880
	[Token(Token = "0x4002698")]
	[FieldOffset(Offset = "0x374")]
	public int SmartInteractX;

	// Token: 0x04002699 RID: 9881
	[Token(Token = "0x4002699")]
	[FieldOffset(Offset = "0x378")]
	public int SmartInteractY;

	// Token: 0x0400269A RID: 9882
	[Token(Token = "0x400269A")]
	[FieldOffset(Offset = "0x37C")]
	public int SmartInteractNPC;

	// Token: 0x0400269B RID: 9883
	[Token(Token = "0x400269B")]
	[FieldOffset(Offset = "0x380")]
	public int SmartInteractProj;

	// Token: 0x0400269C RID: 9884
	[Token(Token = "0x400269C")]
	[FieldOffset(Offset = "0x384")]
	public bool SmartInteractPotionOfReturn;

	// Token: 0x0400269D RID: 9885
	[Token(Token = "0x400269D")]
	[FieldOffset(Offset = "0x388")]
	public int SmartInteractTileCoordsCount;

	// Token: 0x0400269E RID: 9886
	[Token(Token = "0x400269E")]
	[FieldOffset(Offset = "0x38C")]
	public Dictionary<int, bool> SmartInteractTileCoordsSelected;

	// Token: 0x0400269F RID: 9887
	[Token(Token = "0x400269F")]
	[FieldOffset(Offset = "0x390")]
	public int TileInteractionLX;

	// Token: 0x040026A0 RID: 9888
	[Token(Token = "0x40026A0")]
	[FieldOffset(Offset = "0x394")]
	public int TileInteractionLY;

	// Token: 0x040026A1 RID: 9889
	[Token(Token = "0x40026A1")]
	[FieldOffset(Offset = "0x398")]
	public int TileInteractionHX;

	// Token: 0x040026A2 RID: 9890
	[Token(Token = "0x40026A2")]
	[FieldOffset(Offset = "0x39C")]
	public int TileInteractionHY;

	// Token: 0x040026A3 RID: 9891
	[Token(Token = "0x40026A3")]
	[FieldOffset(Offset = "0x3A0")]
	public int lxAimCursorRegion;

	// Token: 0x040026A4 RID: 9892
	[Token(Token = "0x40026A4")]
	[FieldOffset(Offset = "0x3A4")]
	public int hxAimCursorRegion;

	// Token: 0x040026A5 RID: 9893
	[Token(Token = "0x40026A5")]
	[FieldOffset(Offset = "0x3A8")]
	public int lyAimCursorRegion;

	// Token: 0x040026A6 RID: 9894
	[Token(Token = "0x40026A6")]
	[FieldOffset(Offset = "0x3AC")]
	public int hyAimCursorRegion;

	// Token: 0x040026A7 RID: 9895
	[Token(Token = "0x40026A7")]
	[FieldOffset(Offset = "0x3B0")]
	public int AimCursorRegionFrame;

	// Token: 0x040026A8 RID: 9896
	[Token(Token = "0x40026A8")]
	[FieldOffset(Offset = "0x3B4")]
	public int cursorOverride;

	// Token: 0x040026A9 RID: 9897
	[Token(Token = "0x40026A9")]
	[FieldOffset(Offset = "0x3B8")]
	public int signHover;

	// Token: 0x040026AA RID: 9898
	[Token(Token = "0x40026AA")]
	[FieldOffset(Offset = "0x3BC")]
	public int lastSignHover;

	// Token: 0x040026AB RID: 9899
	[Token(Token = "0x40026AB")]
	[FieldOffset(Offset = "0x3C0")]
	public float GamepadCursorAlpha;

	// Token: 0x040026AC RID: 9900
	[Token(Token = "0x40026AC")]
	[FieldOffset(Offset = "0x3C4")]
	public int overloadedMousePositionX;

	// Token: 0x040026AD RID: 9901
	[Token(Token = "0x40026AD")]
	[FieldOffset(Offset = "0x3C8")]
	public int overloadedMousePositionY;

	// Token: 0x040026AE RID: 9902
	[Token(Token = "0x40026AE")]
	[FieldOffset(Offset = "0x3CC")]
	public Color mouseColor;

	// Token: 0x040026AF RID: 9903
	[Token(Token = "0x40026AF")]
	[FieldOffset(Offset = "0x3D0")]
	public Color MouseBorderColor;

	// Token: 0x040026B0 RID: 9904
	[Token(Token = "0x40026B0")]
	[FieldOffset(Offset = "0x3D4")]
	public Color ControllerColor;

	// Token: 0x040026B1 RID: 9905
	[Token(Token = "0x40026B1")]
	[FieldOffset(Offset = "0x3D8")]
	public Color ControllerBorderColor;

	// Token: 0x040026B2 RID: 9906
	[Token(Token = "0x40026B2")]
	[FieldOffset(Offset = "0x3DC")]
	public Color cursorColor;

	// Token: 0x040026B3 RID: 9907
	[Token(Token = "0x40026B3")]
	[FieldOffset(Offset = "0x3E0")]
	public int cursorColorDirection;

	// Token: 0x040026B4 RID: 9908
	[Token(Token = "0x40026B4")]
	[FieldOffset(Offset = "0x3E4")]
	public float cursorAlpha;

	// Token: 0x040026B5 RID: 9909
	[Token(Token = "0x40026B5")]
	[FieldOffset(Offset = "0x3E8")]
	public float cursorScale;

	// Token: 0x040026B6 RID: 9910
	[Token(Token = "0x40026B6")]
	[FieldOffset(Offset = "0x3EC")]
	public bool signBubble;

	// Token: 0x040026B7 RID: 9911
	[Token(Token = "0x40026B7")]
	[FieldOffset(Offset = "0x3F0")]
	public int signX;

	// Token: 0x040026B8 RID: 9912
	[Token(Token = "0x40026B8")]
	[FieldOffset(Offset = "0x3F4")]
	public int signY;

	// Token: 0x040026B9 RID: 9913
	[Token(Token = "0x40026B9")]
	[FieldOffset(Offset = "0x3F8")]
	public bool hideUI;

	// Token: 0x040026BA RID: 9914
	[Token(Token = "0x40026BA")]
	[FieldOffset(Offset = "0x3F9")]
	public bool releaseUI;

	// Token: 0x040026BB RID: 9915
	[Token(Token = "0x40026BB")]
	[FieldOffset(Offset = "0x3FA")]
	public bool renderNow;

	// Token: 0x040026BC RID: 9916
	[Token(Token = "0x40026BC")]
	[FieldOffset(Offset = "0x3FC")]
	public int renderCount;

	// Token: 0x040026BD RID: 9917
	[Token(Token = "0x40026BD")]
	[FieldOffset(Offset = "0x400")]
	public bool render;

	// Token: 0x040026BE RID: 9918
	[Token(Token = "0x40026BE")]
	[FieldOffset(Offset = "0x404")]
	public Stopwatch saveTime;

	// Token: 0x040026BF RID: 9919
	[Token(Token = "0x40026BF")]
	[FieldOffset(Offset = "0x408")]
	public bool BackgroundEnabled;

	// Token: 0x040026C0 RID: 9920
	[Token(Token = "0x40026C0")]
	[FieldOffset(Offset = "0x40C")]
	public int instantBGTransitionCounter;

	// Token: 0x040026C1 RID: 9921
	[Token(Token = "0x40026C1")]
	[FieldOffset(Offset = "0x410")]
	public int bgDelay;

	// Token: 0x040026C2 RID: 9922
	[Token(Token = "0x40026C2")]
	[FieldOffset(Offset = "0x414")]
	public int background;

	// Token: 0x040026C3 RID: 9923
	[Token(Token = "0x40026C3")]
	[FieldOffset(Offset = "0x418")]
	public int caveBackground;

	// Token: 0x040026C4 RID: 9924
	[Token(Token = "0x40026C4")]
	[FieldOffset(Offset = "0x41C")]
	public float shimmerAlpha;

	// Token: 0x040026C5 RID: 9925
	[Token(Token = "0x40026C5")]
	[FieldOffset(Offset = "0x420")]
	public float shimmerDarken;

	// Token: 0x040026C6 RID: 9926
	[Token(Token = "0x40026C6")]
	[FieldOffset(Offset = "0x424")]
	public float shimmerBrightenDelay;

	// Token: 0x040026C7 RID: 9927
	[Token(Token = "0x40026C7")]
	[FieldOffset(Offset = "0x428")]
	public GolfState LocalGolfState;

	// Token: 0x040026C8 RID: 9928
	[Token(Token = "0x40026C8")]
	[FieldOffset(Offset = "0x42C")]
	public DroneCameraTracker DroneCameraTracker;

	// Token: 0x040026C9 RID: 9929
	[Token(Token = "0x40026C9")]
	[FieldOffset(Offset = "0x430")]
	public Vector2 CurrentPan;

	// Token: 0x040026CA RID: 9930
	[Token(Token = "0x40026CA")]
	[FieldOffset(Offset = "0x438")]
	public float cameraLerp;

	// Token: 0x040026CB RID: 9931
	[Token(Token = "0x40026CB")]
	[FieldOffset(Offset = "0x43C")]
	public int cameraLerpTimer;

	// Token: 0x040026CC RID: 9932
	[Token(Token = "0x40026CC")]
	[FieldOffset(Offset = "0x440")]
	public int cameraLerpTimeToggle;

	// Token: 0x040026CD RID: 9933
	[Token(Token = "0x40026CD")]
	[FieldOffset(Offset = "0x444")]
	public bool cameraGamePadLerp;

	// Token: 0x040026CE RID: 9934
	[Token(Token = "0x40026CE")]
	[FieldOffset(Offset = "0x448")]
	public float sunCircle;

	// Token: 0x040026CF RID: 9935
	[Token(Token = "0x40026CF")]
	[FieldOffset(Offset = "0x44C")]
	public int BlackFadeIn;

	// Token: 0x040026D0 RID: 9936
	[Token(Token = "0x40026D0")]
	[FieldOffset(Offset = "0x450")]
	public float ugBackTransition;

	// Token: 0x040026D1 RID: 9937
	[Token(Token = "0x40026D1")]
	[FieldOffset(Offset = "0x454")]
	public int undergroundBackground;

	// Token: 0x040026D2 RID: 9938
	[Token(Token = "0x40026D2")]
	[FieldOffset(Offset = "0x458")]
	public int oldUndergroundBackground;

	// Token: 0x040026D3 RID: 9939
	[Token(Token = "0x40026D3")]
	[FieldOffset(Offset = "0x45C")]
	public int bgStyle;

	// Token: 0x040026D4 RID: 9940
	[Token(Token = "0x40026D4")]
	[FieldOffset(Offset = "0x460")]
	public float[] bgAlphaFrontLayer;

	// Token: 0x040026D5 RID: 9941
	[Token(Token = "0x40026D5")]
	[FieldOffset(Offset = "0x464")]
	public float[] bgAlphaFarBackLayer;

	// Token: 0x040026D6 RID: 9942
	[Token(Token = "0x40026D6")]
	[FieldOffset(Offset = "0x468")]
	public int[] bgFrame;

	// Token: 0x040026D7 RID: 9943
	[Token(Token = "0x40026D7")]
	[FieldOffset(Offset = "0x46C")]
	public int[] bgFrameCounter;

	// Token: 0x040026D8 RID: 9944
	[Token(Token = "0x40026D8")]
	[FieldOffset(Offset = "0x470")]
	public bool mapEnabled;

	// Token: 0x040026D9 RID: 9945
	[Token(Token = "0x40026D9")]
	[FieldOffset(Offset = "0x474")]
	public int invasionProgressMode;

	// Token: 0x040026DA RID: 9946
	[Token(Token = "0x40026DA")]
	[FieldOffset(Offset = "0x478")]
	public bool invasionProgressNearInvasion;

	// Token: 0x040026DB RID: 9947
	[Token(Token = "0x40026DB")]
	[FieldOffset(Offset = "0x479")]
	public bool placementPreview;

	// Token: 0x040026DC RID: 9948
	[Token(Token = "0x40026DC")]
	[FieldOffset(Offset = "0x47A")]
	public bool autoSave;

	// Token: 0x040026DD RID: 9949
	[Token(Token = "0x40026DD")]
	[FieldOffset(Offset = "0x47C")]
	public Main.AutoPauseMode autoPause;

	// Token: 0x040026DE RID: 9950
	[Token(Token = "0x40026DE")]
	[FieldOffset(Offset = "0x480")]
	public SceneMetrics _cameraSceneMetrics;

	// Token: 0x040026DF RID: 9951
	[Token(Token = "0x40026DF")]
	[FieldOffset(Offset = "0x484")]
	public SceneMetrics _playerSceneMetrics;

	// Token: 0x040026E0 RID: 9952
	[Token(Token = "0x40026E0")]
	[FieldOffset(Offset = "0x488")]
	public SceneState SceneState;

	// Token: 0x040026E1 RID: 9953
	[Token(Token = "0x40026E1")]
	[FieldOffset(Offset = "0x48C")]
	public bool _usingSeparateCameraSceneMetrics;

	// Token: 0x040026E2 RID: 9954
	[Token(Token = "0x40026E2")]
	[FieldOffset(Offset = "0x48D")]
	public bool HasInteractableObjectThatIsNotATile;

	// Token: 0x040026E3 RID: 9955
	[Token(Token = "0x40026E3")]
	[FieldOffset(Offset = "0x48E")]
	public bool DisableIntenseVisualEffects;

	// Token: 0x040026E4 RID: 9956
	[Token(Token = "0x40026E4")]
	[FieldOffset(Offset = "0x48F")]
	public bool DisableCameraShake;

	// Token: 0x040026E5 RID: 9957
	[Token(Token = "0x40026E5")]
	[FieldOffset(Offset = "0x490")]
	public int WaveQuality;

	// Token: 0x040026E6 RID: 9958
	[Token(Token = "0x40026E6")]
	[FieldOffset(Offset = "0x494")]
	public bool UseStormEffects;

	// Token: 0x040026E7 RID: 9959
	[Token(Token = "0x40026E7")]
	[FieldOffset(Offset = "0x495")]
	public bool UseHeatDistortion;

	// Token: 0x040026E8 RID: 9960
	[Token(Token = "0x40026E8")]
	[FieldOffset(Offset = "0x498")]
	public float musicVolume;

	// Token: 0x040026E9 RID: 9961
	[Token(Token = "0x40026E9")]
	[FieldOffset(Offset = "0x49C")]
	public float ambientVolume;

	// Token: 0x040026EA RID: 9962
	[Token(Token = "0x40026EA")]
	[FieldOffset(Offset = "0x4A0")]
	public float soundVolume;

	// Token: 0x040026EB RID: 9963
	[Token(Token = "0x40026EB")]
	[FieldOffset(Offset = "0x4A4")]
	public bool TOWMusicUnlocked;

	// Token: 0x040026EC RID: 9964
	[Token(Token = "0x40026EC")]
	[FieldOffset(Offset = "0x4A8")]
	public int qaStyle;

	// Token: 0x040026ED RID: 9965
	[Token(Token = "0x40026ED")]
	[FieldOffset(Offset = "0x4AC")]
	public float caveParallax;

	// Token: 0x040026EE RID: 9966
	[Token(Token = "0x40026EE")]
	[FieldOffset(Offset = "0x4B0")]
	public int bgScroll;

	// Token: 0x040026EF RID: 9967
	[Token(Token = "0x40026EF")]
	[FieldOffset(Offset = "0x4B4")]
	public bool showItemText;

	// Token: 0x040026F0 RID: 9968
	[Token(Token = "0x40026F0")]
	[FieldOffset(Offset = "0x4B5")]
	public bool HidePassword;

	// Token: 0x040026F1 RID: 9969
	[Token(Token = "0x40026F1")]
	[FieldOffset(Offset = "0x4B6")]
	public bool ReversedUpDownArmorSetBonuses;

	// Token: 0x040026F2 RID: 9970
	[Token(Token = "0x40026F2")]
	[FieldOffset(Offset = "0x4B7")]
	public bool SettingsEnabled_TilesSwayInWind;

	// Token: 0x040026F3 RID: 9971
	[Token(Token = "0x40026F3")]
	[FieldOffset(Offset = "0x4B8")]
	public bool cSmartCursorModeIsToggleAndNotHold;

	// Token: 0x040026F4 RID: 9972
	[Token(Token = "0x40026F4")]
	[FieldOffset(Offset = "0x4BC")]
	public float gfxQuality;

	// Token: 0x040026F5 RID: 9973
	[Token(Token = "0x40026F5")]
	[FieldOffset(Offset = "0x4C0")]
	public float gfxRate;

	// Token: 0x040026F6 RID: 9974
	[Token(Token = "0x40026F6")]
	[FieldOffset(Offset = "0x4C4")]
	public int teamCooldown;

	// Token: 0x040026F7 RID: 9975
	[Token(Token = "0x40026F7")]
	[FieldOffset(Offset = "0x4C8")]
	public bool showFrameRate;

	// Token: 0x040026F8 RID: 9976
	[Token(Token = "0x40026F8")]
	[FieldOffset(Offset = "0x4C9")]
	public bool SettingsSavePending;

	// Token: 0x040026F9 RID: 9977
	[Token(Token = "0x40026F9")]
	[FieldOffset(Offset = "0x4CC")]
	public ParticleRenderer ParticleSystem_OverInventory;

	// Token: 0x040026FA RID: 9978
	[Token(Token = "0x40026FA")]
	[FieldOffset(Offset = "0x4D0")]
	public ParticleRenderer ParticleSystem_HousingQuery;

	// Token: 0x040026FB RID: 9979
	[Token(Token = "0x40026FB")]
	[FieldOffset(Offset = "0x4D4")]
	public int _justCraftedItemType;

	// Token: 0x040026FC RID: 9980
	[Token(Token = "0x40026FC")]
	[FieldOffset(Offset = "0x4D8")]
	public float _mouseItemGlow;

	// Token: 0x040026FD RID: 9981
	[Token(Token = "0x40026FD")]
	[FieldOffset(Offset = "0x4DC")]
	public WorldMap Map;

	// Token: 0x040026FE RID: 9982
	[Token(Token = "0x40026FE")]
	[FieldOffset(Offset = "0x4E0")]
	public bool refreshMap;

	// Token: 0x040026FF RID: 9983
	[Token(Token = "0x40026FF")]
	[FieldOffset(Offset = "0x4E4")]
	public int loadMapLastX;

	// Token: 0x04002700 RID: 9984
	[Token(Token = "0x4002700")]
	[FieldOffset(Offset = "0x4E8")]
	public bool loadMapLock;

	// Token: 0x04002701 RID: 9985
	[Token(Token = "0x4002701")]
	[FieldOffset(Offset = "0x4E9")]
	public bool loadMap;

	// Token: 0x04002702 RID: 9986
	[Token(Token = "0x4002702")]
	[FieldOffset(Offset = "0x4EA")]
	public bool loadMapSections;

	// Token: 0x04002703 RID: 9987
	[Token(Token = "0x4002703")]
	[FieldOffset(Offset = "0x4EB")]
	public bool mapReady;

	// Token: 0x04002704 RID: 9988
	[Token(Token = "0x4002704")]
	[FieldOffset(Offset = "0x4EC")]
	public bool updateMap;

	// Token: 0x04002705 RID: 9989
	[Token(Token = "0x4002705")]
	[FieldOffset(Offset = "0x4F0")]
	public int mapMinX;

	// Token: 0x04002706 RID: 9990
	[Token(Token = "0x4002706")]
	[FieldOffset(Offset = "0x4F4")]
	public int mapMaxX;

	// Token: 0x04002707 RID: 9991
	[Token(Token = "0x4002707")]
	[FieldOffset(Offset = "0x4F8")]
	public int mapMinY;

	// Token: 0x04002708 RID: 9992
	[Token(Token = "0x4002708")]
	[FieldOffset(Offset = "0x4FC")]
	public int mapMaxY;

	// Token: 0x04002709 RID: 9993
	[Token(Token = "0x4002709")]
	[FieldOffset(Offset = "0x500")]
	public int mapTimeMax;

	// Token: 0x0400270A RID: 9994
	[Token(Token = "0x400270A")]
	[FieldOffset(Offset = "0x504")]
	public int mapTime;

	// Token: 0x0400270B RID: 9995
	[Token(Token = "0x400270B")]
	[FieldOffset(Offset = "0x508")]
	public bool clearMap;

	// Token: 0x0400270C RID: 9996
	[Token(Token = "0x400270C")]
	[FieldOffset(Offset = "0x509")]
	public bool mapInit;

	// Token: 0x0400270D RID: 9997
	[Token(Token = "0x400270D")]
	[FieldOffset(Offset = "0x50C")]
	public int mapStyle;

	// Token: 0x0400270E RID: 9998
	[Token(Token = "0x400270E")]
	[FieldOffset(Offset = "0x510")]
	public float grabMapX;

	// Token: 0x0400270F RID: 9999
	[Token(Token = "0x400270F")]
	[FieldOffset(Offset = "0x514")]
	public float grabMapY;

	// Token: 0x04002710 RID: 10000
	[Token(Token = "0x4002710")]
	[FieldOffset(Offset = "0x518")]
	public float grabMapInitialX;

	// Token: 0x04002711 RID: 10001
	[Token(Token = "0x4002711")]
	[FieldOffset(Offset = "0x51C")]
	public float grabMapInitialY;

	// Token: 0x04002712 RID: 10002
	[Token(Token = "0x4002712")]
	[FieldOffset(Offset = "0x520")]
	public bool grabMapInProgress;

	// Token: 0x04002713 RID: 10003
	[Token(Token = "0x4002713")]
	[FieldOffset(Offset = "0x524")]
	public int miniMapX;

	// Token: 0x04002714 RID: 10004
	[Token(Token = "0x4002714")]
	[FieldOffset(Offset = "0x528")]
	public int miniMapY;

	// Token: 0x04002715 RID: 10005
	[Token(Token = "0x4002715")]
	[FieldOffset(Offset = "0x52C")]
	public int miniMapWidth;

	// Token: 0x04002716 RID: 10006
	[Token(Token = "0x4002716")]
	[FieldOffset(Offset = "0x530")]
	public int miniMapHeight;

	// Token: 0x04002717 RID: 10007
	[Token(Token = "0x4002717")]
	[FieldOffset(Offset = "0x534")]
	public float mapMinimapScale;

	// Token: 0x04002718 RID: 10008
	[Token(Token = "0x4002718")]
	[FieldOffset(Offset = "0x538")]
	public float mapMinimapAlpha;

	// Token: 0x04002719 RID: 10009
	[Token(Token = "0x4002719")]
	[FieldOffset(Offset = "0x53C")]
	public float mapOverlayScale;

	// Token: 0x0400271A RID: 10010
	[Token(Token = "0x400271A")]
	[FieldOffset(Offset = "0x540")]
	public float mapOverlayAlpha;

	// Token: 0x0400271B RID: 10011
	[Token(Token = "0x400271B")]
	[FieldOffset(Offset = "0x544")]
	public bool mapFullscreen;

	// Token: 0x0400271C RID: 10012
	[Token(Token = "0x400271C")]
	[FieldOffset(Offset = "0x546")]
	public Point16 MapPylonTile;

	// Token: 0x0400271D RID: 10013
	[Token(Token = "0x400271D")]
	[FieldOffset(Offset = "0x54A")]
	public bool PanTargetMapFullscreen;

	// Token: 0x0400271E RID: 10014
	[Token(Token = "0x400271E")]
	[FieldOffset(Offset = "0x54C")]
	public Vector2 PanTargetMapFullscreenEnd;

	// Token: 0x0400271F RID: 10015
	[Token(Token = "0x400271F")]
	[FieldOffset(Offset = "0x554")]
	public bool resetMapFull;

	// Token: 0x04002720 RID: 10016
	[Token(Token = "0x4002720")]
	[FieldOffset(Offset = "0x558")]
	public int resetMapFullCharacter;

	// Token: 0x04002721 RID: 10017
	[Token(Token = "0x4002721")]
	[FieldOffset(Offset = "0x55C")]
	public float mapFullscreenScale;

	// Token: 0x04002722 RID: 10018
	[Token(Token = "0x4002722")]
	[FieldOffset(Offset = "0x560")]
	public Vector2 mapFullscreenPos;

	// Token: 0x04002723 RID: 10019
	[Token(Token = "0x4002723")]
	[FieldOffset(Offset = "0x568")]
	public bool _MouseOversCanClear;

	// Token: 0x04002724 RID: 10020
	[Token(Token = "0x4002724")]
	[FieldOffset(Offset = "0x56C")]
	public TriggersPack Triggers;

	// Token: 0x04002725 RID: 10021
	[Token(Token = "0x4002725")]
	[FieldOffset(Offset = "0x570")]
	public MouseState MouseInfo;

	// Token: 0x04002726 RID: 10022
	[Token(Token = "0x4002726")]
	[FieldOffset(Offset = "0x594")]
	public MouseState MouseInfoOld;

	// Token: 0x04002727 RID: 10023
	[Token(Token = "0x4002727")]
	[FieldOffset(Offset = "0x5B8")]
	public int MouseX;

	// Token: 0x04002728 RID: 10024
	[Token(Token = "0x4002728")]
	[FieldOffset(Offset = "0x5BC")]
	public int MouseY;

	// Token: 0x04002729 RID: 10025
	[Token(Token = "0x4002729")]
	[FieldOffset(Offset = "0x5C0")]
	public bool LockGamepadTileUseButton;

	// Token: 0x0400272A RID: 10026
	[Token(Token = "0x400272A")]
	[FieldOffset(Offset = "0x5C4")]
	public int PreUIX;

	// Token: 0x0400272B RID: 10027
	[Token(Token = "0x400272B")]
	[FieldOffset(Offset = "0x5C8")]
	public int PreUIY;

	// Token: 0x0400272C RID: 10028
	[Token(Token = "0x400272C")]
	[FieldOffset(Offset = "0x5CC")]
	public int PreLockOnX;

	// Token: 0x0400272D RID: 10029
	[Token(Token = "0x400272D")]
	[FieldOffset(Offset = "0x5D0")]
	public int PreLockOnY;

	// Token: 0x0400272E RID: 10030
	[Token(Token = "0x400272E")]
	[FieldOffset(Offset = "0x5D4")]
	public int ScrollWheelValue;

	// Token: 0x0400272F RID: 10031
	[Token(Token = "0x400272F")]
	[FieldOffset(Offset = "0x5D8")]
	public int ScrollWheelValueOld;

	// Token: 0x04002730 RID: 10032
	[Token(Token = "0x4002730")]
	[FieldOffset(Offset = "0x5DC")]
	public int ScrollWheelDelta;

	// Token: 0x04002731 RID: 10033
	[Token(Token = "0x4002731")]
	[FieldOffset(Offset = "0x5E0")]
	public int taxRate;

	// Token: 0x04002732 RID: 10034
	[Token(Token = "0x4002732")]
	[FieldOffset(Offset = "0x5E4")]
	public int tileRangeX;

	// Token: 0x04002733 RID: 10035
	[Token(Token = "0x4002733")]
	[FieldOffset(Offset = "0x5E8")]
	public int tileRangeY;

	// Token: 0x04002734 RID: 10036
	[Token(Token = "0x4002734")]
	[FieldOffset(Offset = "0x5EC")]
	public int tileTargetX;

	// Token: 0x04002735 RID: 10037
	[Token(Token = "0x4002735")]
	[FieldOffset(Offset = "0x5F0")]
	public int tileTargetY;

	// Token: 0x04002736 RID: 10038
	[Token(Token = "0x4002736")]
	[FieldOffset(Offset = "0x5F4")]
	public int jumpHeight;

	// Token: 0x04002737 RID: 10039
	[Token(Token = "0x4002737")]
	[FieldOffset(Offset = "0x5F8")]
	public float jumpSpeed;

	// Token: 0x04002738 RID: 10040
	[Token(Token = "0x4002738")]
	[FieldOffset(Offset = "0x5FC")]
	public int BlockInteractionWithProjectiles;

	// Token: 0x04002739 RID: 10041
	[Token(Token = "0x4002739")]
	[FieldOffset(Offset = "0x600")]
	public bool lastPound;

	// Token: 0x0400273A RID: 10042
	[Token(Token = "0x400273A")]
	[FieldOffset(Offset = "0x604")]
	public int musicNotes;

	// Token: 0x0400273B RID: 10043
	[Token(Token = "0x400273B")]
	[FieldOffset(Offset = "0x608")]
	public bool SmartBlocksEnabled;

	// Token: 0x0400273C RID: 10044
	[Token(Token = "0x400273C")]
	[FieldOffset(Offset = "0x609")]
	public bool SmartAxeAfterPickaxe;

	// Token: 0x0400273D RID: 10045
	[Token(Token = "0x400273D")]
	[FieldOffset(Offset = "0x60C")]
	public int[] _specialsCount;

	// Token: 0x0400273E RID: 10046
	[Token(Token = "0x400273E")]
	[FieldOffset(Offset = "0x610")]
	public Point[][] _specialPositions;

	// Token: 0x0400273F RID: 10047
	[Token(Token = "0x400273F")]
	[FieldOffset(Offset = "0x614")]
	public WindGrid _windGrid;

	// Token: 0x04002740 RID: 10048
	[Token(Token = "0x4002740")]
	[FieldOffset(Offset = "0x618")]
	public bool _shouldShowInvisibleBlocks;

	// Token: 0x04002741 RID: 10049
	[Token(Token = "0x4002741")]
	[FieldOffset(Offset = "0x619")]
	public bool _shouldShowInvisibleBlocks_LastFrame;

	// Token: 0x04002742 RID: 10050
	[Token(Token = "0x4002742")]
	[FieldOffset(Offset = "0x61C")]
	public ThreadLocal<TileDrawInfo> _currentTileDrawInfo;

	// Token: 0x04002743 RID: 10051
	[Token(Token = "0x4002743")]
	[FieldOffset(Offset = "0x620")]
	public LightMode _mode;

	// Token: 0x04002744 RID: 10052
	[Token(Token = "0x4002744")]
	[FieldOffset(Offset = "0x624")]
	private LightingEngine _newEngine;

	// Token: 0x04002745 RID: 10053
	[Token(Token = "0x4002745")]
	[FieldOffset(Offset = "0x628")]
	private LegacyLighting _legacyEngine;

	// Token: 0x04002746 RID: 10054
	[Token(Token = "0x4002746")]
	[FieldOffset(Offset = "0x62C")]
	private ILightingEngine _activeEngineVal;

	// Token: 0x04002747 RID: 10055
	[Token(Token = "0x4002747")]
	[FieldOffset(Offset = "0x630")]
	public bool DisableLeftShiftTrashCan;

	// Token: 0x04002748 RID: 10056
	[Token(Token = "0x4002748")]
	[FieldOffset(Offset = "0x631")]
	public bool HighlightNewItems;

	// Token: 0x04002749 RID: 10057
	[Token(Token = "0x4002749")]
	[FieldOffset(Offset = "0x632")]
	public bool DisableQuickTrash;

	// Token: 0x0400274A RID: 10058
	[Token(Token = "0x400274A")]
	[FieldOffset(Offset = "0x633")]
	public bool ChildSafetyDisabled;

	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000315")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600139D")]
		[Address(RVA = "0xDA7998", Offset = "0xDA7998", VA = "0xDA7998")]
		public <>c()
		{
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139E")]
		[Address(RVA = "0xDA79A0", Offset = "0xDA79A0", VA = "0xDA79A0")]
		internal TileDrawInfo <.ctor>b__421_0()
		{
			return null;
		}

		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LocalUserGameState.<>c <>9;

		// Token: 0x0400274C RID: 10060
		[Token(Token = "0x400274C")]
		[FieldOffset(Offset = "0x4")]
		public static Func<TileDrawInfo> <>9__421_0;
	}
}
