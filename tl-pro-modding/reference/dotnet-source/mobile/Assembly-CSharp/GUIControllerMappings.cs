using System;
using System.Collections.Generic;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.IO;

// Token: 0x0200007B RID: 123
[Token(Token = "0x200007B")]
public class GUIControllerMappings
{
	// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x4BD2A8", Offset = "0x4BD2A8", VA = "0x4BD2A8")]
	public void ClearMappingStates()
	{
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x4BD2EC", Offset = "0x4BD2EC", VA = "0x4BD2EC")]
	private void ClearWorldMappings()
	{
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x4BD9F8", Offset = "0x4BD9F8", VA = "0x4BD9F8")]
	private void ClearInventoryMappings()
	{
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x4BDEF0", Offset = "0x4BDEF0", VA = "0x4BDEF0")]
	public void Backup()
	{
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x4BF8F4", Offset = "0x4BF8F4", VA = "0x4BF8F4")]
	public void RestoreBackup()
	{
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x4BFB24", Offset = "0x4BFB24", VA = "0x4BFB24")]
	public void ClearMapping()
	{
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x4BC6E4", Offset = "0x4BC6E4", VA = "0x4BC6E4")]
	public void RegisterOverlay(GUIControllerMappingEntryBase entry, Rectangle region)
	{
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x4BFCCC", Offset = "0x4BFCCC", VA = "0x4BFCCC")]
	public void Draw()
	{
	}

	// Token: 0x060002AA RID: 682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x4C2670", Offset = "0x4C2670", VA = "0x4C2670")]
	public void LooseFocus()
	{
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x4C02F8", Offset = "0x4C02F8", VA = "0x4C02F8")]
	private void GainFocus()
	{
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00002E08 File Offset: 0x00001008
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x4C2708", Offset = "0x4C2708", VA = "0x4C2708")]
	private bool IsOverCategories(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x4C0EA0", Offset = "0x4C0EA0", VA = "0x4C0EA0")]
	private void DrawCategories()
	{
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x4C0258", Offset = "0x4C0258", VA = "0x4C0258")]
	public void Close()
	{
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x4C1D9C", Offset = "0x4C1D9C", VA = "0x4C1D9C")]
	private void DrawMainButtons()
	{
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x4C07EC", Offset = "0x4C07EC", VA = "0x4C07EC")]
	private void DrawTitle()
	{
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x4C03E4", Offset = "0x4C03E4", VA = "0x4C03E4")]
	private void DrawBacking()
	{
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x4C0530", Offset = "0x4C0530", VA = "0x4C0530")]
	private void DrawCategoryOptions()
	{
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00002E20 File Offset: 0x00001020
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x4C2A10", Offset = "0x4C2A10", VA = "0x4C2A10")]
	private float SettingScale(int index)
	{
		return 0f;
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x4C2A18", Offset = "0x4C2A18", VA = "0x4C2A18")]
	private void SettingOver(int index)
	{
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x4C2A1C", Offset = "0x4C2A1C", VA = "0x4C2A1C")]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00002E38 File Offset: 0x00001038
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x4C2BEC", Offset = "0x4C2BEC", VA = "0x4C2BEC")]
	private Vector2 SettingSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x4BE0E4", Offset = "0x4BE0E4", VA = "0x4BE0E4")]
	public void SetCategory(ControllerMappingsCategories_Layout.Category category)
	{
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00002E50 File Offset: 0x00001050
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x4C2CF0", Offset = "0x4C2CF0", VA = "0x4C2CF0")]
	public bool MappingsMatchesScheme(GUIControllerMappingScheme scheme)
	{
		return default(bool);
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x4BC960", Offset = "0x4BC960", VA = "0x4BC960")]
	public void RefreshConfigurationState()
	{
	}

	// Token: 0x060002BA RID: 698 RVA: 0x00002E68 File Offset: 0x00001068
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x4C3024", Offset = "0x4C3024", VA = "0x4C3024")]
	public VirtualControllerInputState.CursorInputMode GetMode(Preferences preferences, string id, VirtualControllerInputState.CursorInputMode defaultValue)
	{
		return VirtualControllerInputState.CursorInputMode.Item;
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x4C30A0", Offset = "0x4C30A0", VA = "0x4C30A0")]
	public void LoadConfiguration(Preferences preferences, bool existingConfiguration)
	{
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x4C3F98", Offset = "0x4C3F98", VA = "0x4C3F98")]
	public GUIControllerMappingScheme GetDefaultScheme(GUIControllerMappings.MappingType mappingType)
	{
		return null;
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x4C3C90", Offset = "0x4C3C90", VA = "0x4C3C90")]
	public void SetMapping(GUIControllerMappings.MappingType mappingType)
	{
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x4C4080", Offset = "0x4C4080", VA = "0x4C4080")]
	private void SetupUIMappingState(ControllerActionButton buttonMapping)
	{
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x4C4280", Offset = "0x4C4280", VA = "0x4C4280")]
	private void SetupWorldUIMappingState(ControllerActionButton buttonMapping)
	{
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x4C45CC", Offset = "0x4C45CC", VA = "0x4C45CC")]
	private void DisableNavigationVector()
	{
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x4C4A64", Offset = "0x4C4A64", VA = "0x4C4A64")]
	public void UpdateUIInteractionOverloads(GUIControllerMappings.InteractionOverloadState newInteractionOverloadState)
	{
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x4C5648", Offset = "0x4C5648", VA = "0x4C5648")]
	public void SetupMappings()
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x4BC910", Offset = "0x4BC910", VA = "0x4BC910")]
	public void LoadMappingValues()
	{
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x4CBA38", Offset = "0x4CBA38", VA = "0x4CBA38")]
	public void SaveConfiguration(Preferences preferences)
	{
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x4CC27C", Offset = "0x4CC27C", VA = "0x4CC27C")]
	public void DisableUntilClearInventoryConflicts(ControllerActionButton button)
	{
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x4CC4B4", Offset = "0x4CC4B4", VA = "0x4CC4B4")]
	public GUIControllerMappings()
	{
	}

	// Token: 0x040004BB RID: 1211
	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x8")]
	public bool FromPauseMenu;

	// Token: 0x040004BC RID: 1212
	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x9")]
	public bool Enabled;

	// Token: 0x040004BD RID: 1213
	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0xC")]
	public GUIControllerMappings.MappingType mapping;

	// Token: 0x040004BE RID: 1214
	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x10")]
	private VirtualControllerInputState.CursorInputMode BackupControllerAimAndUse;

	// Token: 0x040004BF RID: 1215
	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x14")]
	private VirtualControllerInputState.CursorInputMode BackupControllerSmartCursor;

	// Token: 0x040004C0 RID: 1216
	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x18")]
	private bool BackupSwapBumpersTriggers;

	// Token: 0x040004C1 RID: 1217
	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x1C")]
	private float BackupNavigationDelay;

	// Token: 0x040004C2 RID: 1218
	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x20")]
	private float BackupControllerAimSensitivity;

	// Token: 0x040004C3 RID: 1219
	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x24")]
	private GUIControllerMappingEntryBase overlayEntry;

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x28")]
	private Rectangle overlayRegion;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x38")]
	public bool performingBinding;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x3C")]
	private int disableScroll;

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x40")]
	private bool hasFocus;

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x44")]
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x48")]
	private float TimeSinceItemChange;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x4C")]
	private ControllerMappingsCategories_Layout.Category[] TabOrder;

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x50")]
	public ControllerMappingsCategories_Layout.Category Selected;

	// Token: 0x040004CC RID: 1228
	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x54")]
	private float GameplayButtonScale;

	// Token: 0x040004CD RID: 1229
	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x58")]
	private float UIButtonScale;

	// Token: 0x040004CE RID: 1230
	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x5C")]
	private float SaveAndCloseButtonScale;

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x60")]
	private float ResetSettingsButtonScale;

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x64")]
	private float titleScale;

	// Token: 0x040004D1 RID: 1233
	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x68")]
	public float ScrollOffset;

	// Token: 0x040004D2 RID: 1234
	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x6C")]
	private float ScrollMomentum;

	// Token: 0x040004D3 RID: 1235
	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x70")]
	private int ScrollDragging;

	// Token: 0x040004D4 RID: 1236
	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x74")]
	private Vector2 DragOffset;

	// Token: 0x040004D5 RID: 1237
	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x7C")]
	public List<GUIControllerMappingEntryBase> _allSettings;

	// Token: 0x040004D6 RID: 1238
	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x80")]
	public List<GUIControllerMappingEntryBase> _categorySettings;

	// Token: 0x040004D7 RID: 1239
	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x84")]
	public GUIControllerMappings.InteractionOverloadState interactionOverloadState;

	// Token: 0x040004D8 RID: 1240
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x88")]
	private ControllerActionButton.RequiredButtonState noModifiers;

	// Token: 0x040004D9 RID: 1241
	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x8C")]
	private ControllerActionButton.RequiredButtonState noLeftModifiers;

	// Token: 0x040004DA RID: 1242
	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x90")]
	private ControllerActionButton.RequiredButtonState noRightModifiers;

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x94")]
	private List<GUIControllerMappingScheme> Schemes;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x98")]
	public GUIControllerMappingOverlay _controllerInput;

	// Token: 0x040004DD RID: 1245
	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x9C")]
	public List<ControllerActionAxis> WorldAxisTable;

	// Token: 0x040004DE RID: 1246
	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0xA0")]
	public List<ControllerActionVector> WorldAxisMappings;

	// Token: 0x040004DF RID: 1247
	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0xA4")]
	public List<ControllerActionButton> WorldButtonMappings;

	// Token: 0x040004E0 RID: 1248
	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0xA8")]
	public List<ControllerActionVector> InventoryAxisMappings;

	// Token: 0x040004E1 RID: 1249
	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0xAC")]
	public List<ControllerActionAxis> InventoryAxisTable;

	// Token: 0x040004E2 RID: 1250
	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0xB0")]
	public List<ControllerActionButton> InventoryButtonMappings;

	// Token: 0x040004E3 RID: 1251
	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0xB4")]
	public List<ControllerActionButton> BaseInventoryTable;

	// Token: 0x040004E4 RID: 1252
	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0xB8")]
	public List<ControllerActionButton> InventoryTable;

	// Token: 0x040004E5 RID: 1253
	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0xBC")]
	public List<ControllerActionButton> EquipmentTable;

	// Token: 0x040004E6 RID: 1254
	[Token(Token = "0x40004E6")]
	[FieldOffset(Offset = "0xC0")]
	public List<ControllerActionButton> ItemHeldTable;

	// Token: 0x040004E7 RID: 1255
	[Token(Token = "0x40004E7")]
	[FieldOffset(Offset = "0xC4")]
	public List<ControllerActionButton> ChestInvTable;

	// Token: 0x040004E8 RID: 1256
	[Token(Token = "0x40004E8")]
	[FieldOffset(Offset = "0xC8")]
	public List<ControllerActionButton> ChestTable;

	// Token: 0x040004E9 RID: 1257
	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0xCC")]
	public List<ControllerActionButton> ShopTable;

	// Token: 0x040004EA RID: 1258
	[Token(Token = "0x40004EA")]
	[FieldOffset(Offset = "0xD0")]
	public List<ControllerActionButton> ShopInvTable;

	// Token: 0x040004EB RID: 1259
	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0xD4")]
	public List<ControllerActionButton> CraftingTable;

	// Token: 0x040004EC RID: 1260
	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0xD8")]
	public List<ControllerActionButton> PVPTable;

	// Token: 0x040004ED RID: 1261
	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0xDC")]
	public List<ControllerActionButton> HousingTable;

	// Token: 0x040004EE RID: 1262
	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0xE0")]
	public List<ControllerActionButton> ReforgeTable;

	// Token: 0x040004EF RID: 1263
	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0xE4")]
	public List<ControllerActionButton> ChatTable;

	// Token: 0x040004F0 RID: 1264
	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0xE8")]
	public List<ControllerActionAxis> AxisTableEmpty;

	// Token: 0x040004F1 RID: 1265
	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0xEC")]
	public ControllerActionAxis MovementAxisX;

	// Token: 0x040004F2 RID: 1266
	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0xF0")]
	public ControllerActionAxis MovementAxisY;

	// Token: 0x040004F3 RID: 1267
	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0xF4")]
	public ControllerActionVector MovementAxis;

	// Token: 0x040004F4 RID: 1268
	[Token(Token = "0x40004F4")]
	[FieldOffset(Offset = "0xF8")]
	public ControllerActionAxis MapAxisX;

	// Token: 0x040004F5 RID: 1269
	[Token(Token = "0x40004F5")]
	[FieldOffset(Offset = "0xFC")]
	public ControllerActionAxis MapAxisY;

	// Token: 0x040004F6 RID: 1270
	[Token(Token = "0x40004F6")]
	[FieldOffset(Offset = "0x100")]
	public ControllerActionVector MapAxis;

	// Token: 0x040004F7 RID: 1271
	[Token(Token = "0x40004F7")]
	[FieldOffset(Offset = "0x104")]
	public ControllerActionAxis MovementAxisAltX;

	// Token: 0x040004F8 RID: 1272
	[Token(Token = "0x40004F8")]
	[FieldOffset(Offset = "0x108")]
	public ControllerActionAxis MovementAxisAltY;

	// Token: 0x040004F9 RID: 1273
	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x10C")]
	public ControllerActionVector MovementAxisAlt;

	// Token: 0x040004FA RID: 1274
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x110")]
	public ControllerActionAxis FireAxisX;

	// Token: 0x040004FB RID: 1275
	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x114")]
	public ControllerActionAxis FireAxisY;

	// Token: 0x040004FC RID: 1276
	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0x118")]
	public ControllerActionVector FireAxis;

	// Token: 0x040004FD RID: 1277
	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x11C")]
	public ControllerActionAxis FireAxisAltX;

	// Token: 0x040004FE RID: 1278
	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0x120")]
	public ControllerActionAxis FireAxisAltY;

	// Token: 0x040004FF RID: 1279
	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0x124")]
	public ControllerActionVector FireAxisAlt;

	// Token: 0x04000500 RID: 1280
	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0x128")]
	public ControllerActionAxis GrappleAxisX;

	// Token: 0x04000501 RID: 1281
	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0x12C")]
	public ControllerActionAxis GrappleAxisY;

	// Token: 0x04000502 RID: 1282
	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x130")]
	public ControllerActionVector GrappleAxis;

	// Token: 0x04000503 RID: 1283
	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x134")]
	public ControllerActionButton GrappleFire;

	// Token: 0x04000504 RID: 1284
	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x138")]
	public ControllerActionButton Jump;

	// Token: 0x04000505 RID: 1285
	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x13C")]
	public ControllerActionButton Fire;

	// Token: 0x04000506 RID: 1286
	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x140")]
	public ControllerActionButton Interact;

	// Token: 0x04000507 RID: 1287
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x144")]
	public ControllerActionButton TargetLockOn;

	// Token: 0x04000508 RID: 1288
	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x148")]
	public ControllerActionButton InventoryToggle;

	// Token: 0x04000509 RID: 1289
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x14C")]
	public ControllerActionButton AutoSelect;

	// Token: 0x0400050A RID: 1290
	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x150")]
	public ControllerActionButton SmartCursor;

	// Token: 0x0400050B RID: 1291
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x154")]
	public ControllerActionButton AutoFire;

	// Token: 0x0400050C RID: 1292
	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x158")]
	public ControllerActionButton HotbarNext;

	// Token: 0x0400050D RID: 1293
	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x15C")]
	public ControllerActionButton HotbarPrevious;

	// Token: 0x0400050E RID: 1294
	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x160")]
	public ControllerActionButton FireAlt;

	// Token: 0x0400050F RID: 1295
	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x164")]
	public ControllerActionAxis GridSnapAxisX;

	// Token: 0x04000510 RID: 1296
	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x168")]
	public ControllerActionAxis GridSnapAxisY;

	// Token: 0x04000511 RID: 1297
	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x16C")]
	public ControllerActionVector GridSnapAxis;

	// Token: 0x04000512 RID: 1298
	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x170")]
	public ControllerActionButton BuffNext;

	// Token: 0x04000513 RID: 1299
	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x174")]
	public ControllerActionButton BuffPrevious;

	// Token: 0x04000514 RID: 1300
	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x178")]
	public ControllerActionButton BuffRemove;

	// Token: 0x04000515 RID: 1301
	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x17C")]
	public ControllerActionAxis HotbarAxisX;

	// Token: 0x04000516 RID: 1302
	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x180")]
	public ControllerActionAxis HotbarAxisY;

	// Token: 0x04000517 RID: 1303
	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x184")]
	public ControllerActionVector HotbarAxis;

	// Token: 0x04000518 RID: 1304
	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x188")]
	public ControllerActionButton ZoomIn;

	// Token: 0x04000519 RID: 1305
	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x18C")]
	public ControllerActionButton ZoomOut;

	// Token: 0x0400051A RID: 1306
	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x190")]
	public ControllerActionButton MapZoomIn;

	// Token: 0x0400051B RID: 1307
	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x194")]
	public ControllerActionButton MapZoomOut;

	// Token: 0x0400051C RID: 1308
	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x198")]
	public ControllerActionButton MapZoomDefault;

	// Token: 0x0400051D RID: 1309
	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x19C")]
	public ControllerActionButton QuickMount;

	// Token: 0x0400051E RID: 1310
	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x1A0")]
	public ControllerActionButton QuickHeal;

	// Token: 0x0400051F RID: 1311
	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0x1A4")]
	public ControllerActionButton QuickBuff;

	// Token: 0x04000520 RID: 1312
	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0x1A8")]
	public ControllerActionButton QuickMana;

	// Token: 0x04000521 RID: 1313
	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x1AC")]
	public ControllerActionButton MapToggle;

	// Token: 0x04000522 RID: 1314
	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x1B0")]
	public ControllerActionButton MiniMapToggle;

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x1B4")]
	public ControllerActionButton MiniChatToggle;

	// Token: 0x04000524 RID: 1316
	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x1B8")]
	public ControllerActionButton OverlayChatToggle;

	// Token: 0x04000525 RID: 1317
	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x1BC")]
	public ControllerActionButton ChatToggle;

	// Token: 0x04000526 RID: 1318
	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x1C0")]
	public ControllerActionButton EmotesToggle;

	// Token: 0x04000527 RID: 1319
	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x1C4")]
	public ControllerActionButton Dash;

	// Token: 0x04000528 RID: 1320
	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x1C8")]
	public ControllerActionButton ArmorSetAbility;

	// Token: 0x04000529 RID: 1321
	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x1CC")]
	public ControllerActionButton Hotbar1;

	// Token: 0x0400052A RID: 1322
	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0x1D0")]
	public ControllerActionButton Hotbar2;

	// Token: 0x0400052B RID: 1323
	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x1D4")]
	public ControllerActionButton Hotbar3;

	// Token: 0x0400052C RID: 1324
	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x1D8")]
	public ControllerActionButton Hotbar4;

	// Token: 0x0400052D RID: 1325
	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x1DC")]
	public ControllerActionButton Hotbar5;

	// Token: 0x0400052E RID: 1326
	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x1E0")]
	public ControllerActionButton Hotbar6;

	// Token: 0x0400052F RID: 1327
	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x1E4")]
	public ControllerActionButton Hotbar7;

	// Token: 0x04000530 RID: 1328
	[Token(Token = "0x4000530")]
	[FieldOffset(Offset = "0x1E8")]
	public ControllerActionButton Hotbar8;

	// Token: 0x04000531 RID: 1329
	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0x1EC")]
	public ControllerActionButton Hotbar9;

	// Token: 0x04000532 RID: 1330
	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0x1F0")]
	public ControllerActionButton Hotbar10;

	// Token: 0x04000533 RID: 1331
	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0x1F4")]
	public ControllerActionButton DynamicHotbar1;

	// Token: 0x04000534 RID: 1332
	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0x1F8")]
	public ControllerActionButton DynamicHotbar2;

	// Token: 0x04000535 RID: 1333
	[Token(Token = "0x4000535")]
	[FieldOffset(Offset = "0x1FC")]
	public ControllerActionButton DynamicHotbar3;

	// Token: 0x04000536 RID: 1334
	[Token(Token = "0x4000536")]
	[FieldOffset(Offset = "0x200")]
	public ControllerActionButton DynamicHotbar4;

	// Token: 0x04000537 RID: 1335
	[Token(Token = "0x4000537")]
	[FieldOffset(Offset = "0x204")]
	public ControllerActionButton Loadout1;

	// Token: 0x04000538 RID: 1336
	[Token(Token = "0x4000538")]
	[FieldOffset(Offset = "0x208")]
	public ControllerActionButton Loadout2;

	// Token: 0x04000539 RID: 1337
	[Token(Token = "0x4000539")]
	[FieldOffset(Offset = "0x20C")]
	public ControllerActionButton Loadout3;

	// Token: 0x0400053A RID: 1338
	[Token(Token = "0x400053A")]
	[FieldOffset(Offset = "0x210")]
	public ControllerActionButton LoadoutCycle;

	// Token: 0x0400053B RID: 1339
	[Token(Token = "0x400053B")]
	[FieldOffset(Offset = "0x214")]
	public ControllerActionAxis InventoryNavigationX;

	// Token: 0x0400053C RID: 1340
	[Token(Token = "0x400053C")]
	[FieldOffset(Offset = "0x218")]
	public ControllerActionAxis InventoryNavigationY;

	// Token: 0x0400053D RID: 1341
	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0x21C")]
	public ControllerActionVector InventoryNavigation;

	// Token: 0x0400053E RID: 1342
	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0x220")]
	public ControllerActionAxis InventoryNavigationAltX;

	// Token: 0x0400053F RID: 1343
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x224")]
	public ControllerActionAxis InventoryNavigationAltY;

	// Token: 0x04000540 RID: 1344
	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0x228")]
	public ControllerActionVector InventoryNavigationAlt;

	// Token: 0x04000541 RID: 1345
	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x22C")]
	public ControllerActionButton WorldFocusToggle;

	// Token: 0x04000542 RID: 1346
	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x230")]
	public ControllerActionButton LeftPageCycle;

	// Token: 0x04000543 RID: 1347
	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x234")]
	public ControllerActionButton RightPageCycle;

	// Token: 0x04000544 RID: 1348
	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x238")]
	public ControllerActionButton ThrowItem;

	// Token: 0x04000545 RID: 1349
	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x23C")]
	public ControllerActionButton TrashItem;

	// Token: 0x04000546 RID: 1350
	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x240")]
	public ControllerActionButton DepositHeldItem;

	// Token: 0x04000547 RID: 1351
	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x244")]
	public ControllerActionButton ShareItem;

	// Token: 0x04000548 RID: 1352
	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x248")]
	public ControllerActionButton FavouriteItem;

	// Token: 0x04000549 RID: 1353
	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x24C")]
	public ControllerActionButton ResearchItem;

	// Token: 0x0400054A RID: 1354
	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0x250")]
	public ControllerActionButton SplitItem;

	// Token: 0x0400054B RID: 1355
	[Token(Token = "0x400054B")]
	[FieldOffset(Offset = "0x254")]
	public ControllerActionButton PickupPlaceItem;

	// Token: 0x0400054C RID: 1356
	[Token(Token = "0x400054C")]
	[FieldOffset(Offset = "0x258")]
	public ControllerActionButton CraftItem;

	// Token: 0x0400054D RID: 1357
	[Token(Token = "0x400054D")]
	[FieldOffset(Offset = "0x25C")]
	public ControllerActionButton FilterItems;

	// Token: 0x0400054E RID: 1358
	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x260")]
	public ControllerActionButton ToggleCraftDuplicate;

	// Token: 0x0400054F RID: 1359
	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x264")]
	public ControllerActionButton ToggleCraftBanner;

	// Token: 0x04000550 RID: 1360
	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x268")]
	public ControllerActionButton HousingQuery;

	// Token: 0x04000551 RID: 1361
	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x26C")]
	public ControllerActionButton Sort;

	// Token: 0x04000552 RID: 1362
	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x270")]
	public ControllerActionButton BuilderTools;

	// Token: 0x04000553 RID: 1363
	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x274")]
	public ControllerActionButton TakeOne;

	// Token: 0x04000554 RID: 1364
	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x278")]
	public ControllerActionButton ChestCraftToggle;

	// Token: 0x04000555 RID: 1365
	[Token(Token = "0x4000555")]
	[FieldOffset(Offset = "0x27C")]
	public ControllerActionButton SearchItems;

	// Token: 0x04000556 RID: 1366
	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x280")]
	public ControllerActionButton InventoryClose;

	// Token: 0x04000557 RID: 1367
	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x284")]
	public ControllerActionButton ReforgeItem;

	// Token: 0x04000558 RID: 1368
	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x288")]
	public ControllerActionButton ShowHideItem;

	// Token: 0x04000559 RID: 1369
	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x28C")]
	public ControllerActionButton InfoAccessories;

	// Token: 0x0400055A RID: 1370
	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x290")]
	public ControllerActionButton ChestQuickStack;

	// Token: 0x0400055B RID: 1371
	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x294")]
	public ControllerActionButton ChestLootAll;

	// Token: 0x0400055C RID: 1372
	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x298")]
	public ControllerActionButton ChestDepositAll;

	// Token: 0x0400055D RID: 1373
	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x29C")]
	public ControllerActionButton ChestRestock;

	// Token: 0x0400055E RID: 1374
	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x2A0")]
	public ControllerActionButton ChestRename;

	// Token: 0x0400055F RID: 1375
	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x2A4")]
	public ControllerActionButton ChestLoot;

	// Token: 0x04000560 RID: 1376
	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x2A8")]
	public ControllerActionButton ChestDeposit;

	// Token: 0x04000561 RID: 1377
	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x2AC")]
	public ControllerActionButton ChestSort;

	// Token: 0x04000562 RID: 1378
	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x2B0")]
	public ControllerActionButton EquipmentEquip;

	// Token: 0x04000563 RID: 1379
	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x2B4")]
	public ControllerActionButton EquipmentUnequip;

	// Token: 0x04000564 RID: 1380
	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x2B8")]
	public ControllerActionButton ShopSell;

	// Token: 0x04000565 RID: 1381
	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0x2BC")]
	public ControllerActionButton ShopBuy;

	// Token: 0x04000566 RID: 1382
	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x2C0")]
	public ControllerActionButton PVPEnableToggle;

	// Token: 0x04000567 RID: 1383
	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x2C4")]
	public ControllerActionButton PVPSwitchTeam;

	// Token: 0x04000568 RID: 1384
	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0x2C8")]
	public ControllerActionButton LoadoutsToggle;

	// Token: 0x04000569 RID: 1385
	[Token(Token = "0x4000569")]
	[FieldOffset(Offset = "0x2CC")]
	public ControllerActionButton InvitePopup;

	// Token: 0x0400056A RID: 1386
	[Token(Token = "0x400056A")]
	[FieldOffset(Offset = "0x2D0")]
	public GUIControllerMappingStateTable WorldInteractFallback;

	// Token: 0x0400056B RID: 1387
	[Token(Token = "0x400056B")]
	[FieldOffset(Offset = "0x2D4")]
	public GUIControllerMappingStateTable WorldInteract;

	// Token: 0x0400056C RID: 1388
	[Token(Token = "0x400056C")]
	[FieldOffset(Offset = "0x2D8")]
	public GUIControllerMappingStateTable WorldShared;

	// Token: 0x0400056D RID: 1389
	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0x2DC")]
	public GUIControllerMappingStateTable World;

	// Token: 0x0400056E RID: 1390
	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0x2E0")]
	public GUIControllerMappingStateTable BaseInventory;

	// Token: 0x0400056F RID: 1391
	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0x2E4")]
	public GUIControllerMappingStateTable Inventory;

	// Token: 0x04000570 RID: 1392
	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0x2E8")]
	public GUIControllerMappingStateTable Equipment;

	// Token: 0x04000571 RID: 1393
	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0x2EC")]
	public GUIControllerMappingStateTable PVP;

	// Token: 0x04000572 RID: 1394
	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0x2F0")]
	public GUIControllerMappingStateTable Housing;

	// Token: 0x04000573 RID: 1395
	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0x2F4")]
	public GUIControllerMappingStateTable ItemHeld;

	// Token: 0x04000574 RID: 1396
	[Token(Token = "0x4000574")]
	[FieldOffset(Offset = "0x2F8")]
	public GUIControllerMappingStateTable ChestInv;

	// Token: 0x04000575 RID: 1397
	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0x2FC")]
	public GUIControllerMappingStateTable Chest;

	// Token: 0x04000576 RID: 1398
	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x300")]
	public GUIControllerMappingStateTable ShopInv;

	// Token: 0x04000577 RID: 1399
	[Token(Token = "0x4000577")]
	[FieldOffset(Offset = "0x304")]
	public GUIControllerMappingStateTable Shop;

	// Token: 0x04000578 RID: 1400
	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0x308")]
	public GUIControllerMappingStateTable Crafting;

	// Token: 0x04000579 RID: 1401
	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x30C")]
	public GUIControllerMappingStateTable Reforge;

	// Token: 0x0400057A RID: 1402
	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x310")]
	public GUIControllerMappingStateTable Chat;

	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public enum MappingType
	{
		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		Default,
		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		Advanced,
		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		Console,
		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		Custom
	}

	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public enum InteractionOverloadState
	{
		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		None,
		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		Inventory,
		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		NPC,
		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		NPCItem,
		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		Map,
		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		SimplePopup
	}

	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x4CCE60", Offset = "0x4CCE60", VA = "0x4CCE60")]
		public <>c()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x4CCE68", Offset = "0x4CCE68", VA = "0x4CCE68")]
		internal int <SetCategory>b__50_0(GUIControllerMappingEntryBase e1, GUIControllerMappingEntryBase e2)
		{
			return 0;
		}

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GUIControllerMappings.<>c <>9;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x4")]
		public static Comparison<GUIControllerMappingEntryBase> <>9__50_0;
	}
}
