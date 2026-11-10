using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000126 RID: 294
[Token(Token = "0x2000126")]
public static class GUIQuickActionButton
{
	// Token: 0x0600076C RID: 1900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076C")]
	[Address(RVA = "0x1670CF4", Offset = "0x1670CF4", VA = "0x1670CF4")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000BC")]
	private static Texture2D _dash
	{
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1671D80", Offset = "0x1671D80", VA = "0x1671D80")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076E")]
	[Address(RVA = "0x1671E40", Offset = "0x1671E40", VA = "0x1671E40")]
	public static NPC GetMouseNPCAtPosition(Vector2 mouseWorldPosition, out bool allowTileInteraction)
	{
		return null;
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076F")]
	[Address(RVA = "0x1672778", Offset = "0x1672778", VA = "0x1672778")]
	public static NPC GetMouseNPC(out bool allowTileInteraction)
	{
		return null;
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000770")]
	[Address(RVA = "0x167337C", Offset = "0x167337C", VA = "0x167337C")]
	public static void DrawAtPosition(QuickActionButton_Layout layout, Vector2 position, Texture2D buttonTexture, GUIQuickActionButton.InteractionState state, ref float scale)
	{
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000771")]
	[Address(RVA = "0x1673940", Offset = "0x1673940", VA = "0x1673940")]
	public static void GetIconFrame(QuickActionButton_Layout.QuickActionControl actionType, out Texture2D iconTexture, out Rectangle frame)
	{
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000772")]
	[Address(RVA = "0x16745D8", Offset = "0x16745D8", VA = "0x16745D8")]
	public static void DrawOverloadedButtonStyle(TransactionButton_Layout overloadedButton, Item drawItem, QuickActionButton_Layout layout, bool disabled, bool pressed, ref float scale)
	{
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000773")]
	[Address(RVA = "0x1674964", Offset = "0x1674964", VA = "0x1674964")]
	private static void DrawOverloadedButtonStyle(TransactionButton_Layout overloadedButton, GUITransactionButton.DrawItemHandler drawItem, QuickActionButton_Layout layout, bool disabled, bool pressed, ref float scale)
	{
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x1674BB0", Offset = "0x1674BB0", VA = "0x1674BB0")]
	public static void Draw(QuickActionButton_Layout.QuickActionControl actionType, QuickActionButton_Layout layout, bool pressed, ref float scale, bool ignoreChecks = false, bool ignoreIcon = false)
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x167E3D0", Offset = "0x167E3D0", VA = "0x167E3D0")]
	public static void DrawFrame(QuickActionButton_Layout layout, Texture2D buttonTexture, Rectangle srcRect, GUIQuickActionButton.InteractionState state, ref float scale)
	{
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x167D734", Offset = "0x167D734", VA = "0x167D734")]
	public static void DrawFrame(QuickActionButton_Layout layout, Texture2D buttonTexture, Rectangle srcRect, GUIQuickActionButton.InteractionState state, ref float scale, int itemType, Color itemColour)
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000777")]
	[Address(RVA = "0x166FDCC", Offset = "0x166FDCC", VA = "0x166FDCC")]
	public static void Draw(QuickActionButton_Layout layout, Texture2D buttonTexture, GUIQuickActionButton.InteractionState state, ref float scale)
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00004F50 File Offset: 0x00003150
	[Token(Token = "0x6000778")]
	[Address(RVA = "0x1679D08", Offset = "0x1679D08", VA = "0x1679D08")]
	private static bool CanInteract(Player player, Item item, ref Texture2D iconTexture, ref Rectangle frame, ref bool useFrame, bool smartInteract)
	{
		return default(bool);
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00004F68 File Offset: 0x00003168
	[Token(Token = "0x6000779")]
	[Address(RVA = "0x167D5F0", Offset = "0x167D5F0", VA = "0x167D5F0")]
	private static bool CanFire(Player player, Item selectedItem)
	{
		return default(bool);
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00004F80 File Offset: 0x00003180
	[Token(Token = "0x600077A")]
	[Address(RVA = "0x167D60C", Offset = "0x167D60C", VA = "0x167D60C")]
	public static bool CanHeal(Player player, Item bestHealItem)
	{
		return default(bool);
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x00004F98 File Offset: 0x00003198
	[Token(Token = "0x600077B")]
	[Address(RVA = "0x167D664", Offset = "0x167D664", VA = "0x167D664")]
	public static bool CanMana(Player player, Item bestManaItem)
	{
		return default(bool);
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00004FB0 File Offset: 0x000031B0
	[Token(Token = "0x600077C")]
	[Address(RVA = "0x1679CE4", Offset = "0x1679CE4", VA = "0x1679CE4")]
	public static bool CanBuff(Player player)
	{
		return default(bool);
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00004FC8 File Offset: 0x000031C8
	[Token(Token = "0x600077D")]
	[Address(RVA = "0x167D6D0", Offset = "0x167D6D0", VA = "0x167D6D0")]
	public static bool CanMount(Player player, Item quickMountItem)
	{
		return default(bool);
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00004FE0 File Offset: 0x000031E0
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x167E4B8", Offset = "0x167E4B8", VA = "0x167E4B8")]
	public static bool IsMounted(Player player)
	{
		return default(bool);
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00004FF8 File Offset: 0x000031F8
	[Token(Token = "0x600077F")]
	[Address(RVA = "0x1679CD4", Offset = "0x1679CD4", VA = "0x1679CD4")]
	private static bool CanGrappleSelect(Player player, Item grappleItem)
	{
		return default(bool);
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00005010 File Offset: 0x00003210
	[Token(Token = "0x6000780")]
	[Address(RVA = "0x167E4F0", Offset = "0x167E4F0", VA = "0x167E4F0")]
	public static bool IsCursorOverExpanded(Vector2 position, QuickActionButton_Layout layout, ref float expanded)
	{
		return default(bool);
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00005028 File Offset: 0x00003228
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x167E5A8", Offset = "0x167E5A8", VA = "0x167E5A8")]
	public static bool IsCursorOver(Vector2 position, QuickActionButton_Layout layout)
	{
		return default(bool);
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00005040 File Offset: 0x00003240
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x167E65C", Offset = "0x167E65C", VA = "0x167E65C")]
	public static bool IsCursorOverAtPosition(Vector2 position, QuickActionButton_Layout layout, Vector2 controlPosition)
	{
		return default(bool);
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00005058 File Offset: 0x00003258
	[Token(Token = "0x6000783")]
	[Address(RVA = "0x167E71C", Offset = "0x167E71C", VA = "0x167E71C")]
	public static bool RegisterPickingRegion(QuickActionButton_Layout layout)
	{
		return default(bool);
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00005070 File Offset: 0x00003270
	[Token(Token = "0x6000784")]
	[Address(RVA = "0x167E7B4", Offset = "0x167E7B4", VA = "0x167E7B4")]
	public static Rectangle GetRegion(QuickActionButton_Layout layout)
	{
		return default(Rectangle);
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00005088 File Offset: 0x00003288
	[Token(Token = "0x6000785")]
	[Address(RVA = "0x167E868", Offset = "0x167E868", VA = "0x167E868")]
	public static Rectangle GetRegionWithoutPicking(QuickActionButton_Layout layout)
	{
		return default(Rectangle);
	}

	// Token: 0x04000820 RID: 2080
	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x0")]
	public static bool ForceOverrideState;

	// Token: 0x04000821 RID: 2081
	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0x4")]
	public static GUIQuickActionButton.InteractionState ForcedState;

	// Token: 0x04000822 RID: 2082
	[Token(Token = "0x4000822")]
	[FieldOffset(Offset = "0x8")]
	private static Texture2D _smallAxisOuter;

	// Token: 0x04000823 RID: 2083
	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0xC")]
	private static Texture2D _axisInner;

	// Token: 0x04000824 RID: 2084
	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x10")]
	private static Texture2D _jump;

	// Token: 0x04000825 RID: 2085
	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x14")]
	private static Texture2D _grappleAxis;

	// Token: 0x04000826 RID: 2086
	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x18")]
	private static Texture2D _grappleFire;

	// Token: 0x04000827 RID: 2087
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x1C")]
	public static Texture2D _unbound;

	// Token: 0x04000828 RID: 2088
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x20")]
	public static Texture2D _zoomIn;

	// Token: 0x04000829 RID: 2089
	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x24")]
	public static Texture2D _zoomOut;

	// Token: 0x0400082A RID: 2090
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x28")]
	public static Texture2D _zoomDefault;

	// Token: 0x0400082B RID: 2091
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x2C")]
	public static Texture2D _mapZoomIn;

	// Token: 0x0400082C RID: 2092
	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x30")]
	public static Texture2D _mapZoomOut;

	// Token: 0x0400082D RID: 2093
	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x34")]
	public static Texture2D _mapZoomDefault;

	// Token: 0x0400082E RID: 2094
	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x38")]
	public static Texture2D _minimapZoomIn;

	// Token: 0x0400082F RID: 2095
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x3C")]
	public static Texture2D _minimapZoomOut;

	// Token: 0x04000830 RID: 2096
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x40")]
	public static Texture2D _minimapZoomDefault;

	// Token: 0x04000831 RID: 2097
	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x44")]
	public static Texture2D _smartCursorOn;

	// Token: 0x04000832 RID: 2098
	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x48")]
	public static Texture2D _smartCursorOff;

	// Token: 0x04000833 RID: 2099
	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x4C")]
	public static Texture2D _autoFireOn;

	// Token: 0x04000834 RID: 2100
	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x50")]
	public static Texture2D _autoFireOff;

	// Token: 0x04000835 RID: 2101
	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x54")]
	public static Texture2D _petItem;

	// Token: 0x04000836 RID: 2102
	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x58")]
	private static Texture2D _autoSelect;

	// Token: 0x04000837 RID: 2103
	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x5C")]
	private static Texture2D _interact;

	// Token: 0x04000838 RID: 2104
	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0x60")]
	private static Texture2D _smartInteract;

	// Token: 0x04000839 RID: 2105
	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x64")]
	private static Texture2D _toggleFireInteract;

	// Token: 0x0400083A RID: 2106
	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x68")]
	private static Texture2D _toggleFireInteractAlt;

	// Token: 0x0400083B RID: 2107
	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0x6C")]
	private static Texture2D _fire;

	// Token: 0x0400083C RID: 2108
	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x70")]
	private static Texture2D _dashLeft;

	// Token: 0x0400083D RID: 2109
	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x74")]
	private static Texture2D _dashRight;

	// Token: 0x0400083E RID: 2110
	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x78")]
	private static Texture2D _armorSetAbility;

	// Token: 0x0400083F RID: 2111
	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x7C")]
	public static Texture2D _map;

	// Token: 0x04000840 RID: 2112
	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x80")]
	public static Texture2D _mapOpen;

	// Token: 0x04000841 RID: 2113
	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x84")]
	public static Texture2D _combatTargetLockOn;

	// Token: 0x04000842 RID: 2114
	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x88")]
	public static Texture2D _combatTargetIndicator;

	// Token: 0x04000843 RID: 2115
	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x8C")]
	private static Texture2D _inventory;

	// Token: 0x04000844 RID: 2116
	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0x90")]
	private static Texture2D _inventoryOpen;

	// Token: 0x04000845 RID: 2117
	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0x94")]
	public static Texture2D _controlsProfile;

	// Token: 0x04000846 RID: 2118
	[Token(Token = "0x4000846")]
	[FieldOffset(Offset = "0x98")]
	private static Texture2D[] _uncollecedHeads;

	// Token: 0x04000847 RID: 2119
	[Token(Token = "0x4000847")]
	public const float NPCInteractionWidthScale = 0.25f;

	// Token: 0x04000848 RID: 2120
	[Token(Token = "0x4000848")]
	[FieldOffset(Offset = "0x9C")]
	private static Color BackupOverloadButtonColor;

	// Token: 0x04000849 RID: 2121
	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0xA0")]
	private static Color BackupOverloadButtonDisabledColor;

	// Token: 0x0400084A RID: 2122
	[Token(Token = "0x400084A")]
	[FieldOffset(Offset = "0xA4")]
	private static Color BackupOverloadButtonPressedColor;

	// Token: 0x0400084B RID: 2123
	[Token(Token = "0x400084B")]
	[FieldOffset(Offset = "0xA8")]
	public static bool interactUsingItem;

	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	public enum InteractionState
	{
		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		Disabled,
		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		Pressed,
		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		Normal
	}
}
