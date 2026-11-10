using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000135 RID: 309
[Token(Token = "0x2000135")]
public class GUIBannerCrafting
{
	// Token: 0x060007DD RID: 2013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x19EAC38", Offset = "0x19EAC38", VA = "0x19EAC38")]
	public GUIBannerCrafting()
	{
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x19EAEC4", Offset = "0x19EAEC4", VA = "0x19EAEC4")]
	public void Reset()
	{
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060007DF RID: 2015 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x170000BD")]
	public bool HasFocus
	{
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x19EAF8C", Offset = "0x19EAF8C", VA = "0x19EAF8C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x19EB114", Offset = "0x19EB114", VA = "0x19EB114")]
	public void DrawCraftButton()
	{
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00005490 File Offset: 0x00003690
	[Token(Token = "0x170000BE")]
	public bool Collapsed
	{
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x19EC2EC", Offset = "0x19EC2EC", VA = "0x19EC2EC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x19EC36C", Offset = "0x19EC36C", VA = "0x19EC36C")]
	private void UpdateFilter(bool force = false)
	{
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x19EC694", Offset = "0x19EC694", VA = "0x19EC694")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x19EC7A8", Offset = "0x19EC7A8", VA = "0x19EC7A8")]
	public void RefreshGridNav()
	{
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x19EC950", Offset = "0x19EC950", VA = "0x19EC950")]
	public void Draw()
	{
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x000054A8 File Offset: 0x000036A8
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x19ECEA0", Offset = "0x19ECEA0", VA = "0x19ECEA0")]
	public float CraftItemScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x19EBC84", Offset = "0x19EBC84", VA = "0x19EBC84")]
	public void CraftButtonOver(GUITransactionButton.InputState state)
	{
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x19ECF08", Offset = "0x19ECF08", VA = "0x19ECF08")]
	public void CraftItemOverImp(int index)
	{
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x19ED5A4", Offset = "0x19ED5A4", VA = "0x19ED5A4")]
	public void CraftItemDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0400087E RID: 2174
	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x8")]
	private GUIItemGrid.GetItemScaleHandler CraftItemScale;

	// Token: 0x0400087F RID: 2175
	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0xC")]
	private GUIItemGrid.CursorOver CraftItemOver;

	// Token: 0x04000880 RID: 2176
	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x10")]
	private GUIItemGrid.DrawItemHandler CraftItemDraw;

	// Token: 0x04000881 RID: 2177
	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x14")]
	public GUIItemFilter Filter;

	// Token: 0x04000882 RID: 2178
	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x18")]
	private float CraftButtonScale;

	// Token: 0x04000883 RID: 2179
	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x1C")]
	private int Offset;

	// Token: 0x04000884 RID: 2180
	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0x20")]
	private int focusedBanner;

	// Token: 0x04000885 RID: 2181
	[Token(Token = "0x4000885")]
	[FieldOffset(Offset = "0x24")]
	public float craftScrollOffset;

	// Token: 0x04000886 RID: 2182
	[Token(Token = "0x4000886")]
	[FieldOffset(Offset = "0x28")]
	private float craftScrollMomentum;

	// Token: 0x04000887 RID: 2183
	[Token(Token = "0x4000887")]
	[FieldOffset(Offset = "0x2C")]
	private int craftScrollDragging;

	// Token: 0x04000888 RID: 2184
	[Token(Token = "0x4000888")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 craftDragOffset;

	// Token: 0x04000889 RID: 2185
	[Token(Token = "0x4000889")]
	[FieldOffset(Offset = "0x38")]
	public List<int> FilteredItems;

	// Token: 0x0400088A RID: 2186
	[Token(Token = "0x400088A")]
	[FieldOffset(Offset = "0x3C")]
	public float hoverCraftDelay;

	// Token: 0x0400088B RID: 2187
	[Token(Token = "0x400088B")]
	[FieldOffset(Offset = "0x40")]
	public GUITransactionButton.InputState lastState;

	// Token: 0x0400088C RID: 2188
	[Token(Token = "0x400088C")]
	[FieldOffset(Offset = "0x44")]
	private float ExpandButtonScale;

	// Token: 0x0400088D RID: 2189
	[Token(Token = "0x400088D")]
	[FieldOffset(Offset = "0x48")]
	private DateTime NavigationTick;

	// Token: 0x0400088E RID: 2190
	[Token(Token = "0x400088E")]
	[FieldOffset(Offset = "0x50")]
	private int bannerState;

	// Token: 0x0400088F RID: 2191
	[Token(Token = "0x400088F")]
	[FieldOffset(Offset = "0x54")]
	private string LastSearch;

	// Token: 0x04000890 RID: 2192
	[Token(Token = "0x4000890")]
	[FieldOffset(Offset = "0x58")]
	private int multiCraftDelay;

	// Token: 0x04000891 RID: 2193
	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x5C")]
	private int multiCraftRecipe;

	// Token: 0x04000892 RID: 2194
	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0x60")]
	private bool wasOverItem;

	// Token: 0x04000893 RID: 2195
	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x64")]
	private int cursorOver;

	// Token: 0x04000894 RID: 2196
	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x68")]
	public int CraftHover;

	// Token: 0x04000895 RID: 2197
	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x6C")]
	private Item blankItem;
}
