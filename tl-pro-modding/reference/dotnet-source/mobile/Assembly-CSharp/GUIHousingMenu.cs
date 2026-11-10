using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200015C RID: 348
[Token(Token = "0x200015C")]
public class GUIHousingMenu
{
	// Token: 0x060009B0 RID: 2480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x915CA0", Offset = "0x915CA0", VA = "0x915CA0")]
	public GUIHousingMenu()
	{
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00005F58 File Offset: 0x00004158
	// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000D3")]
	public bool Visible
	{
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x915DE8", Offset = "0x915DE8", VA = "0x915DE8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x915DF0", Offset = "0x915DF0", VA = "0x915DF0")]
		set
		{
		}
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x915EE8", Offset = "0x915EE8", VA = "0x915EE8")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00005F70 File Offset: 0x00004170
	[Token(Token = "0x170000D4")]
	public bool collapsed
	{
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x915FC4", Offset = "0x915FC4", VA = "0x915FC4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D5")]
	private Texture2D _npcHeadTextureEmpty
	{
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x916044", Offset = "0x916044", VA = "0x916044")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00005F88 File Offset: 0x00004188
	[Token(Token = "0x170000D6")]
	public bool HasFocus
	{
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x9160CC", Offset = "0x9160CC", VA = "0x9160CC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x9161FC", Offset = "0x9161FC", VA = "0x9161FC")]
	private void RefreshNPCEntries()
	{
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00005FA0 File Offset: 0x000041A0
	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x9167CC", Offset = "0x9167CC", VA = "0x9167CC")]
	public int NPCIndexToButtonIndex(int npcIndex)
	{
		return 0;
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00005FB8 File Offset: 0x000041B8
	[Token(Token = "0x60009B9")]
	[Address(RVA = "0x9168A4", Offset = "0x9168A4", VA = "0x9168A4")]
	public float NPCScale(int index)
	{
		return 0f;
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x91690C", Offset = "0x91690C", VA = "0x91690C")]
	public void NPCOver(int index)
	{
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BB")]
	[Address(RVA = "0x9173E4", Offset = "0x9173E4", VA = "0x9173E4")]
	public void NPCDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x918BE4", Offset = "0x918BE4", VA = "0x918BE4")]
	public void UpdateHotbarNavigation()
	{
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x9195CC", Offset = "0x9195CC", VA = "0x9195CC")]
	private void PreviousItem()
	{
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x9193D4", Offset = "0x9193D4", VA = "0x9193D4")]
	private void NextItem()
	{
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x9197C4", Offset = "0x9197C4", VA = "0x9197C4")]
	private void UpdateHotbarScroll()
	{
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x919A00", Offset = "0x919A00", VA = "0x919A00")]
	public void Draw()
	{
	}

	// Token: 0x04000AD6 RID: 2774
	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x8")]
	private bool _visible;

	// Token: 0x04000AD7 RID: 2775
	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0xC")]
	public int LastNPCHousingHover;

	// Token: 0x04000AD8 RID: 2776
	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0x10")]
	public int NPCHousingHover;

	// Token: 0x04000AD9 RID: 2777
	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0x14")]
	public List<int> _activeNPCEntries;

	// Token: 0x04000ADA RID: 2778
	[Token(Token = "0x4000ADA")]
	[FieldOffset(Offset = "0x18")]
	public string npcString;

	// Token: 0x04000ADB RID: 2779
	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0x1C")]
	private int _lastNPCOVer;

	// Token: 0x04000ADC RID: 2780
	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0x20")]
	private bool _npcOver;

	// Token: 0x04000ADD RID: 2781
	[Token(Token = "0x4000ADD")]
	[FieldOffset(Offset = "0x24")]
	private int over;

	// Token: 0x04000ADE RID: 2782
	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0x28")]
	private Texture2D _npcHeadTexture;

	// Token: 0x04000ADF RID: 2783
	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0x2C")]
	public float scrollOffset;

	// Token: 0x04000AE0 RID: 2784
	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0x30")]
	private float scrollMomentum;

	// Token: 0x04000AE1 RID: 2785
	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0x34")]
	private int scrollDragging;

	// Token: 0x04000AE2 RID: 2786
	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 dragOffset;

	// Token: 0x04000AE3 RID: 2787
	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0x40")]
	private float scrollDelay;

	// Token: 0x04000AE4 RID: 2788
	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0x44")]
	private int _npcCount;

	// Token: 0x04000AE5 RID: 2789
	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0x48")]
	public int ActiveNPCCount;

	// Token: 0x04000AE6 RID: 2790
	[Token(Token = "0x4000AE6")]
	[FieldOffset(Offset = "0x4C")]
	public GUIItemGrid.GetItemScaleHandler NPCScaleHandler;

	// Token: 0x04000AE7 RID: 2791
	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0x50")]
	private float HousingQueryScale;

	// Token: 0x04000AE8 RID: 2792
	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0x54")]
	public bool menuTogglePressed;

	// Token: 0x04000AE9 RID: 2793
	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x58")]
	private DateTime NavigationTick;

	// Token: 0x04000AEA RID: 2794
	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x60")]
	private bool hotbarActive;

	// Token: 0x04000AEB RID: 2795
	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x64")]
	private float ScrollAmount;
}
