using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020002B9 RID: 697
[Token(Token = "0x20002B9")]
public class GUISettingsOverlay
{
	// Token: 0x0600109E RID: 4254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109E")]
	[Address(RVA = "0xD01B6C", Offset = "0xD01B6C", VA = "0xD01B6C")]
	public void Init()
	{
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109F")]
	[Address(RVA = "0xD07A60", Offset = "0xD07A60", VA = "0xD07A60")]
	public void UpdateScroll(GUISettingID _id, bool setControllerItem = false)
	{
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00008058 File Offset: 0x00006258
	[Token(Token = "0x60010A0")]
	[Address(RVA = "0xD07E34", Offset = "0xD07E34", VA = "0xD07E34")]
	public bool IsFullyVisible(GUISettingID _id)
	{
		return default(bool);
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x00008070 File Offset: 0x00006270
	[Token(Token = "0x60010A1")]
	[Address(RVA = "0xD0818C", Offset = "0xD0818C", VA = "0xD0818C")]
	private bool IsHidden(GUISettingID id)
	{
		return default(bool);
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x00008088 File Offset: 0x00006288
	[Token(Token = "0x60010A2")]
	[Address(RVA = "0xD08A14", Offset = "0xD08A14", VA = "0xD08A14")]
	public bool IsDisabled(GUISettingID id)
	{
		return default(bool);
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A3")]
	[Address(RVA = "0xD08EC4", Offset = "0xD08EC4", VA = "0xD08EC4")]
	public void SetCategory(SettingsOverlayOptionCategories_Layout.Category category)
	{
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A4")]
	[Address(RVA = "0xD093C0", Offset = "0xD093C0", VA = "0xD093C0")]
	public void RegisterOverlay(GUISettingEntry entry, Rectangle region)
	{
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A5")]
	[Address(RVA = "0xD093E0", Offset = "0xD093E0", VA = "0xD093E0")]
	public void Shutdown()
	{
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A6")]
	[Address(RVA = "0xD09890", Offset = "0xD09890", VA = "0xD09890")]
	public void Draw()
	{
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x000080A0 File Offset: 0x000062A0
	[Token(Token = "0x60010A7")]
	[Address(RVA = "0xD0CDA8", Offset = "0xD0CDA8", VA = "0xD0CDA8")]
	private float SettingScale(int index)
	{
		return 0f;
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A8")]
	[Address(RVA = "0xD0CDB0", Offset = "0xD0CDB0", VA = "0xD0CDB0")]
	private void SettingOver(int index)
	{
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A9")]
	[Address(RVA = "0xD0CEA8", Offset = "0xD0CEA8", VA = "0xD0CEA8")]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AA")]
	[Address(RVA = "0xD0D078", Offset = "0xD0D078", VA = "0xD0D078")]
	private void DummyDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0xD0D250", Offset = "0xD0D250", VA = "0xD0D250")]
	private void DummyOver(int index)
	{
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AC")]
	[Address(RVA = "0xD0CAEC", Offset = "0xD0CAEC", VA = "0xD0CAEC")]
	public void RefreshInputRegion()
	{
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x000080B8 File Offset: 0x000062B8
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0xD0D254", Offset = "0xD0D254", VA = "0xD0D254")]
	private Vector2 SettingSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0xD0A7C0", Offset = "0xD0A7C0", VA = "0xD0A7C0")]
	public void DrawCategoryOptions()
	{
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AF")]
	[Address(RVA = "0xD0A674", Offset = "0xD0A674", VA = "0xD0A674")]
	private void DrawBacking()
	{
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0xD0C3A0", Offset = "0xD0C3A0", VA = "0xD0C3A0")]
	private void DrawTitle()
	{
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0xD0D358", Offset = "0xD0D358", VA = "0xD0D358")]
	private void ResetSetting(GUISettingID id)
	{
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0xD0F4C4", Offset = "0xD0F4C4", VA = "0xD0F4C4")]
	private void ResetPageSettings()
	{
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B3")]
	[Address(RVA = "0xD0BF50", Offset = "0xD0BF50", VA = "0xD0BF50")]
	private void DrawMainButtons()
	{
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B4")]
	[Address(RVA = "0xD0A494", Offset = "0xD0A494", VA = "0xD0A494")]
	public void Close()
	{
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0xD0AB24", Offset = "0xD0AB24", VA = "0xD0AB24")]
	private void DrawCategories()
	{
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0xD0F580", Offset = "0xD0F580", VA = "0xD0F580")]
	public void LooseFocus()
	{
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0xD0A3A8", Offset = "0xD0A3A8", VA = "0xD0A3A8")]
	private void GainFocus()
	{
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x000080D0 File Offset: 0x000062D0
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0xD0F618", Offset = "0xD0F618", VA = "0xD0F618")]
	private bool IsOverCategories(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B9")]
	[Address(RVA = "0xD0FAD0", Offset = "0xD0FAD0", VA = "0xD0FAD0")]
	public GUISettingsOverlay()
	{
	}

	// Token: 0x04002122 RID: 8482
	[Token(Token = "0x4002122")]
	[FieldOffset(Offset = "0x8")]
	private List<GUISettingEntry> _allSettings;

	// Token: 0x04002123 RID: 8483
	[Token(Token = "0x4002123")]
	[FieldOffset(Offset = "0xC")]
	public List<GUISettingEntry> _categorySettings;

	// Token: 0x04002124 RID: 8484
	[Token(Token = "0x4002124")]
	[FieldOffset(Offset = "0x10")]
	public GUIControllerSettingsOverlay _controllerInput;

	// Token: 0x04002125 RID: 8485
	[Token(Token = "0x4002125")]
	[FieldOffset(Offset = "0x14")]
	public SettingsOverlayOptionCategories_Layout.Category Selected;

	// Token: 0x04002126 RID: 8486
	[Token(Token = "0x4002126")]
	[FieldOffset(Offset = "0x18")]
	public int PendingSelected;

	// Token: 0x04002127 RID: 8487
	[Token(Token = "0x4002127")]
	[FieldOffset(Offset = "0x1C")]
	private int disableScroll;

	// Token: 0x04002128 RID: 8488
	[Token(Token = "0x4002128")]
	[FieldOffset(Offset = "0x20")]
	private GUISettingEntry overlayEntry;

	// Token: 0x04002129 RID: 8489
	[Token(Token = "0x4002129")]
	[FieldOffset(Offset = "0x24")]
	private Rectangle overlayRegion;

	// Token: 0x0400212A RID: 8490
	[Token(Token = "0x400212A")]
	[FieldOffset(Offset = "0x34")]
	public float ScrollOffset;

	// Token: 0x0400212B RID: 8491
	[Token(Token = "0x400212B")]
	[FieldOffset(Offset = "0x38")]
	private float ScrollMomentum;

	// Token: 0x0400212C RID: 8492
	[Token(Token = "0x400212C")]
	[FieldOffset(Offset = "0x3C")]
	private int ScrollDragging;

	// Token: 0x0400212D RID: 8493
	[Token(Token = "0x400212D")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 DragOffset;

	// Token: 0x0400212E RID: 8494
	[Token(Token = "0x400212E")]
	[FieldOffset(Offset = "0x48")]
	private bool unconfiguredControllerAttached;

	// Token: 0x0400212F RID: 8495
	[Token(Token = "0x400212F")]
	[FieldOffset(Offset = "0x4C")]
	private float titleScale;

	// Token: 0x04002130 RID: 8496
	[Token(Token = "0x4002130")]
	[FieldOffset(Offset = "0x50")]
	private float GeneralButtonScale;

	// Token: 0x04002131 RID: 8497
	[Token(Token = "0x4002131")]
	[FieldOffset(Offset = "0x54")]
	private float CursorButtonScale;

	// Token: 0x04002132 RID: 8498
	[Token(Token = "0x4002132")]
	[FieldOffset(Offset = "0x58")]
	private float VideoButtonScale;

	// Token: 0x04002133 RID: 8499
	[Token(Token = "0x4002133")]
	[FieldOffset(Offset = "0x5C")]
	private float LanguageButtonScale;

	// Token: 0x04002134 RID: 8500
	[Token(Token = "0x4002134")]
	[FieldOffset(Offset = "0x60")]
	private float SaveAndCloseButtonScale;

	// Token: 0x04002135 RID: 8501
	[Token(Token = "0x4002135")]
	[FieldOffset(Offset = "0x64")]
	private float AchievementsButtonScale;

	// Token: 0x04002136 RID: 8502
	[Token(Token = "0x4002136")]
	[FieldOffset(Offset = "0x68")]
	private float InterfaceButtonScale;

	// Token: 0x04002137 RID: 8503
	[Token(Token = "0x4002137")]
	[FieldOffset(Offset = "0x6C")]
	private float InfoButtonScale;

	// Token: 0x04002138 RID: 8504
	[Token(Token = "0x4002138")]
	[FieldOffset(Offset = "0x70")]
	private float ResetSettingsButtonScale;

	// Token: 0x04002139 RID: 8505
	[Token(Token = "0x4002139")]
	[FieldOffset(Offset = "0x74")]
	private float KeyboardMouseButtonScale;

	// Token: 0x0400213A RID: 8506
	[Token(Token = "0x400213A")]
	[FieldOffset(Offset = "0x78")]
	private float TimeSinceItemChange;

	// Token: 0x0400213B RID: 8507
	[Token(Token = "0x400213B")]
	[FieldOffset(Offset = "0x7C")]
	private SettingsOverlayOptionCategories_Layout.Category[] TabOrder;

	// Token: 0x0400213C RID: 8508
	[Token(Token = "0x400213C")]
	[FieldOffset(Offset = "0x80")]
	private bool hasFocus;

	// Token: 0x0400213D RID: 8509
	[Token(Token = "0x400213D")]
	[FieldOffset(Offset = "0x84")]
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060010BB RID: 4283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0xD2A500", Offset = "0xD2A500", VA = "0xD2A500")]
		public <>c()
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0xD2A508", Offset = "0xD2A508", VA = "0xD2A508")]
		internal int <SetCategory>b__10_0(GUISettingEntry e1, GUISettingEntry e2)
		{
			return 0;
		}

		// Token: 0x0400213E RID: 8510
		[Token(Token = "0x400213E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GUISettingsOverlay.<>c <>9;

		// Token: 0x0400213F RID: 8511
		[Token(Token = "0x400213F")]
		[FieldOffset(Offset = "0x4")]
		public static Comparison<GUISettingEntry> <>9__10_0;
	}
}
