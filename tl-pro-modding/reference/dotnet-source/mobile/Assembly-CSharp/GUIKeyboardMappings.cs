using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.IO;
using UnityEngine;

// Token: 0x020001A1 RID: 417
[Token(Token = "0x20001A1")]
public class GUIKeyboardMappings
{
	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00007080 File Offset: 0x00005280
	// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000126")]
	public bool KeyboardEnabled
	{
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0xC60908", Offset = "0xC60908", VA = "0xC60908")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0xC60910", Offset = "0xC60910", VA = "0xC60910")]
		set
		{
		}
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0xC601DC", Offset = "0xC601DC", VA = "0xC601DC")]
	public void RegisterOverlay(GUIKeyboardMappingEntry entry, Rectangle region)
	{
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0xC60984", Offset = "0xC60984", VA = "0xC60984")]
	private ControllerActionButton CreateButtonMapping(string id)
	{
		return null;
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00007098 File Offset: 0x00005298
	// (set) Token: 0x06000C4D RID: 3149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000127")]
	public bool EscapeOpensInventory
	{
		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0xC60B40", Offset = "0xC60B40", VA = "0xC60B40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0xC60B48", Offset = "0xC60B48", VA = "0xC60B48")]
		set
		{
		}
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0xC60B5C", Offset = "0xC60B5C", VA = "0xC60B5C")]
	public void SetupEscapeKeySetting()
	{
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0xC6069C", Offset = "0xC6069C", VA = "0xC6069C")]
	public void DisableEscapeKeyUsage()
	{
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0xC60C2C", Offset = "0xC60C2C", VA = "0xC60C2C")]
	public void SetupMappings()
	{
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x000070B0 File Offset: 0x000052B0
	[Token(Token = "0x6000C51")]
	[Address(RVA = "0xC61F50", Offset = "0xC61F50", VA = "0xC61F50")]
	private KeyCode LoadKeyCode(Preferences preferences, string id, ref bool loaded)
	{
		return KeyCode.None;
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C52")]
	[Address(RVA = "0xC621AC", Offset = "0xC621AC", VA = "0xC621AC")]
	public void LoadConfiguration(Preferences preferences)
	{
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C53")]
	[Address(RVA = "0xC6256C", Offset = "0xC6256C", VA = "0xC6256C")]
	public void SaveConfiguration(Preferences preferences)
	{
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C54")]
	[Address(RVA = "0xC615E4", Offset = "0xC615E4", VA = "0xC615E4")]
	public void LoadDefaults()
	{
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C55")]
	[Address(RVA = "0xC6028C", Offset = "0xC6028C", VA = "0xC6028C")]
	public void ClearBinding(KeyCode key, [Optional] List<ControllerActionButton> allowedActions)
	{
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C56")]
	[Address(RVA = "0xC629EC", Offset = "0xC629EC", VA = "0xC629EC")]
	public void Draw()
	{
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C57")]
	[Address(RVA = "0xC64B74", Offset = "0xC64B74", VA = "0xC64B74")]
	public void LooseFocus()
	{
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C58")]
	[Address(RVA = "0xC62E04", Offset = "0xC62E04", VA = "0xC62E04")]
	private void GainFocus()
	{
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x000070C8 File Offset: 0x000052C8
	[Token(Token = "0x6000C59")]
	[Address(RVA = "0xC64C08", Offset = "0xC64C08", VA = "0xC64C08")]
	private bool IsOverCategories(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0xC6399C", Offset = "0xC6399C", VA = "0xC6399C")]
	private void DrawCategories()
	{
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0xC6581C", Offset = "0xC6581C", VA = "0xC6581C")]
	public void Close()
	{
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0xC658BC", Offset = "0xC658BC", VA = "0xC658BC")]
	public void Backup()
	{
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0xC6597C", Offset = "0xC6597C", VA = "0xC6597C")]
	public void RestoreBackup()
	{
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0xC643B4", Offset = "0xC643B4", VA = "0xC643B4")]
	private void DrawMainButtons()
	{
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0xC65A3C", Offset = "0xC65A3C", VA = "0xC65A3C")]
	private void ClearMapping()
	{
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C60")]
	[Address(RVA = "0xC632F0", Offset = "0xC632F0", VA = "0xC632F0")]
	private void DrawTitle()
	{
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C61")]
	[Address(RVA = "0xC62EE8", Offset = "0xC62EE8", VA = "0xC62EE8")]
	private void DrawBacking()
	{
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C62")]
	[Address(RVA = "0xC63034", Offset = "0xC63034", VA = "0xC63034")]
	private void DrawCategoryOptions()
	{
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x000070E0 File Offset: 0x000052E0
	[Token(Token = "0x6000C63")]
	[Address(RVA = "0xC65B24", Offset = "0xC65B24", VA = "0xC65B24")]
	private float SettingScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C64")]
	[Address(RVA = "0xC65B2C", Offset = "0xC65B2C", VA = "0xC65B2C")]
	private void SettingOver(int index)
	{
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C65")]
	[Address(RVA = "0xC65B30", Offset = "0xC65B30", VA = "0xC65B30")]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x000070F8 File Offset: 0x000052F8
	[Token(Token = "0x6000C66")]
	[Address(RVA = "0xC65D3C", Offset = "0xC65D3C", VA = "0xC65D3C")]
	private Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C67")]
	[Address(RVA = "0xC64EC8", Offset = "0xC64EC8", VA = "0xC64EC8")]
	public void SetCategory(KeyboardMappingsCategories_Layout.Category category)
	{
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C68")]
	[Address(RVA = "0xC65E8C", Offset = "0xC65E8C", VA = "0xC65E8C")]
	public static string GetControlTag(ControlsKeyboardTagHandler.MappingType mappingType)
	{
		return null;
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C69")]
	[Address(RVA = "0xC65F18", Offset = "0xC65F18", VA = "0xC65F18")]
	public GUIKeyboardMappings()
	{
	}

	// Token: 0x04000F29 RID: 3881
	[Token(Token = "0x4000F29")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private bool _keyboardEnabled;

	// Token: 0x04000F2A RID: 3882
	[Token(Token = "0x4000F2A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GUIKeyboardMappingOverlay _controllerInput;

	// Token: 0x04000F2B RID: 3883
	[Token(Token = "0x4000F2B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GUIKeyboardMappingEntry overlayEntry;

	// Token: 0x04000F2C RID: 3884
	[Token(Token = "0x4000F2C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Rectangle overlayRegion;

	// Token: 0x04000F2D RID: 3885
	[Token(Token = "0x4000F2D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool Enabled;

	// Token: 0x04000F2E RID: 3886
	[Token(Token = "0x4000F2E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool performingBinding;

	// Token: 0x04000F2F RID: 3887
	[Token(Token = "0x4000F2F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool FromPauseMenu;

	// Token: 0x04000F30 RID: 3888
	[Token(Token = "0x4000F30")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int disableScroll;

	// Token: 0x04000F31 RID: 3889
	[Token(Token = "0x4000F31")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ControllerActionAxis MovementAxisX;

	// Token: 0x04000F32 RID: 3890
	[Token(Token = "0x4000F32")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ControllerActionAxis MovementAxisY;

	// Token: 0x04000F33 RID: 3891
	[Token(Token = "0x4000F33")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ControllerActionVector MovementAxis;

	// Token: 0x04000F34 RID: 3892
	[Token(Token = "0x4000F34")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ControllerActionButton GrappleFire;

	// Token: 0x04000F35 RID: 3893
	[Token(Token = "0x4000F35")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public ControllerActionButton Jump;

	// Token: 0x04000F36 RID: 3894
	[Token(Token = "0x4000F36")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ControllerActionButton Fire;

	// Token: 0x04000F37 RID: 3895
	[Token(Token = "0x4000F37")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public ControllerActionButton Interact;

	// Token: 0x04000F38 RID: 3896
	[Token(Token = "0x4000F38")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ControllerActionButton TargetLockOn;

	// Token: 0x04000F39 RID: 3897
	[Token(Token = "0x4000F39")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public ControllerActionButton InventoryToggle;

	// Token: 0x04000F3A RID: 3898
	[Token(Token = "0x4000F3A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ControllerActionButton AutoSelect;

	// Token: 0x04000F3B RID: 3899
	[Token(Token = "0x4000F3B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public ControllerActionButton SmartCursor;

	// Token: 0x04000F3C RID: 3900
	[Token(Token = "0x4000F3C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ControllerActionButton Settings;

	// Token: 0x04000F3D RID: 3901
	[Token(Token = "0x4000F3D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public ControllerActionButton HotbarNext;

	// Token: 0x04000F3E RID: 3902
	[Token(Token = "0x4000F3E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ControllerActionButton HotbarPrevious;

	// Token: 0x04000F3F RID: 3903
	[Token(Token = "0x4000F3F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public ControllerActionButton LeftPageCycle;

	// Token: 0x04000F40 RID: 3904
	[Token(Token = "0x4000F40")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ControllerActionButton RightPageCycle;

	// Token: 0x04000F41 RID: 3905
	[Token(Token = "0x4000F41")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public ControllerActionButton ZoomIn;

	// Token: 0x04000F42 RID: 3906
	[Token(Token = "0x4000F42")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ControllerActionButton ZoomOut;

	// Token: 0x04000F43 RID: 3907
	[Token(Token = "0x4000F43")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public ControllerActionButton MapZoomIn;

	// Token: 0x04000F44 RID: 3908
	[Token(Token = "0x4000F44")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ControllerActionButton MapZoomOut;

	// Token: 0x04000F45 RID: 3909
	[Token(Token = "0x4000F45")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public ControllerActionButton MapZoomDefault;

	// Token: 0x04000F46 RID: 3910
	[Token(Token = "0x4000F46")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ControllerActionButton QuickMount;

	// Token: 0x04000F47 RID: 3911
	[Token(Token = "0x4000F47")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public ControllerActionButton QuickHeal;

	// Token: 0x04000F48 RID: 3912
	[Token(Token = "0x4000F48")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ControllerActionButton QuickBuff;

	// Token: 0x04000F49 RID: 3913
	[Token(Token = "0x4000F49")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public ControllerActionButton QuickMana;

	// Token: 0x04000F4A RID: 3914
	[Token(Token = "0x4000F4A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ControllerActionButton MapToggle;

	// Token: 0x04000F4B RID: 3915
	[Token(Token = "0x4000F4B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public ControllerActionButton MiniMapToggle;

	// Token: 0x04000F4C RID: 3916
	[Token(Token = "0x4000F4C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public ControllerActionButton MiniChatToggle;

	// Token: 0x04000F4D RID: 3917
	[Token(Token = "0x4000F4D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public ControllerActionButton OverlayChatToggle;

	// Token: 0x04000F4E RID: 3918
	[Token(Token = "0x4000F4E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ControllerActionButton ChatToggle;

	// Token: 0x04000F4F RID: 3919
	[Token(Token = "0x4000F4F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public ControllerActionButton EmotesToggle;

	// Token: 0x04000F50 RID: 3920
	[Token(Token = "0x4000F50")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public ControllerActionButton Hotbar1;

	// Token: 0x04000F51 RID: 3921
	[Token(Token = "0x4000F51")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public ControllerActionButton Hotbar2;

	// Token: 0x04000F52 RID: 3922
	[Token(Token = "0x4000F52")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public ControllerActionButton Hotbar3;

	// Token: 0x04000F53 RID: 3923
	[Token(Token = "0x4000F53")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public ControllerActionButton Hotbar4;

	// Token: 0x04000F54 RID: 3924
	[Token(Token = "0x4000F54")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ControllerActionButton Hotbar5;

	// Token: 0x04000F55 RID: 3925
	[Token(Token = "0x4000F55")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public ControllerActionButton Hotbar6;

	// Token: 0x04000F56 RID: 3926
	[Token(Token = "0x4000F56")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public ControllerActionButton Hotbar7;

	// Token: 0x04000F57 RID: 3927
	[Token(Token = "0x4000F57")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public ControllerActionButton Hotbar8;

	// Token: 0x04000F58 RID: 3928
	[Token(Token = "0x4000F58")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public ControllerActionButton Hotbar9;

	// Token: 0x04000F59 RID: 3929
	[Token(Token = "0x4000F59")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public ControllerActionButton Hotbar10;

	// Token: 0x04000F5A RID: 3930
	[Token(Token = "0x4000F5A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public ControllerActionButton Loadout1;

	// Token: 0x04000F5B RID: 3931
	[Token(Token = "0x4000F5B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public ControllerActionButton Loadout2;

	// Token: 0x04000F5C RID: 3932
	[Token(Token = "0x4000F5C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public ControllerActionButton Loadout3;

	// Token: 0x04000F5D RID: 3933
	[Token(Token = "0x4000F5D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public ControllerActionButton LoadoutCycle;

	// Token: 0x04000F5E RID: 3934
	[Token(Token = "0x4000F5E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ControllerActionButton Dash;

	// Token: 0x04000F5F RID: 3935
	[Token(Token = "0x4000F5F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public ControllerActionButton ArmorSetAbility;

	// Token: 0x04000F60 RID: 3936
	[Token(Token = "0x4000F60")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private List<ControllerActionButton> AllButtonMappings;

	// Token: 0x04000F61 RID: 3937
	[Token(Token = "0x4000F61")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool _escapeOpensInventory;

	// Token: 0x04000F62 RID: 3938
	[Token(Token = "0x4000F62")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float TimeSinceItemChange;

	// Token: 0x04000F63 RID: 3939
	[Token(Token = "0x4000F63")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private KeyboardMappingsCategories_Layout.Category[] TabOrder;

	// Token: 0x04000F64 RID: 3940
	[Token(Token = "0x4000F64")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public KeyboardMappingsCategories_Layout.Category Selected;

	// Token: 0x04000F65 RID: 3941
	[Token(Token = "0x4000F65")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float GameplayButtonScale;

	// Token: 0x04000F66 RID: 3942
	[Token(Token = "0x4000F66")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private float UIButtonScale;

	// Token: 0x04000F67 RID: 3943
	[Token(Token = "0x4000F67")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private float SaveAndCloseButtonScale;

	// Token: 0x04000F68 RID: 3944
	[Token(Token = "0x4000F68")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float ResetSettingsButtonScale;

	// Token: 0x04000F69 RID: 3945
	[Token(Token = "0x4000F69")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float titleScale;

	// Token: 0x04000F6A RID: 3946
	[Token(Token = "0x4000F6A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public float ScrollOffset;

	// Token: 0x04000F6B RID: 3947
	[Token(Token = "0x4000F6B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float ScrollMomentum;

	// Token: 0x04000F6C RID: 3948
	[Token(Token = "0x4000F6C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int ScrollDragging;

	// Token: 0x04000F6D RID: 3949
	[Token(Token = "0x4000F6D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x04000F6E RID: 3950
	[Token(Token = "0x4000F6E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public List<GUIKeyboardMappingEntry> _allSettings;

	// Token: 0x04000F6F RID: 3951
	[Token(Token = "0x4000F6F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public List<GUIKeyboardMappingEntry> _categorySettings;

	// Token: 0x04000F70 RID: 3952
	[Token(Token = "0x4000F70")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private bool hasFocus;

	// Token: 0x04000F71 RID: 3953
	[Token(Token = "0x4000F71")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000C6B RID: 3179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0xC66154", Offset = "0xC66154", VA = "0xC66154")]
		public <>c()
		{
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0xC6615C", Offset = "0xC6615C", VA = "0xC6615C")]
		internal int <SetCategory>b__106_0(GUIKeyboardMappingEntry e1, GUIKeyboardMappingEntry e2)
		{
			return 0;
		}

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly GUIKeyboardMappings.<>c <>9;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Comparison<GUIKeyboardMappingEntry> <>9__106_0;
	}
}
