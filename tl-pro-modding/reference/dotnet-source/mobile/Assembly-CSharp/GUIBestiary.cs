using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;

// Token: 0x02000136 RID: 310
[Token(Token = "0x2000136")]
public class GUIBestiary
{
	// Token: 0x060007EA RID: 2026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x1E387A0", Offset = "0x1E387A0", VA = "0x1E387A0")]
	public GUIBestiary()
	{
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x1E392D4", Offset = "0x1E392D4", VA = "0x1E392D4")]
	public static void LoadContent()
	{
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x1E396E0", Offset = "0x1E396E0", VA = "0x1E396E0")]
	public void DrawButton()
	{
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x1E3984C", Offset = "0x1E3984C", VA = "0x1E3984C")]
	private void NPCDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x000054C0 File Offset: 0x000036C0
	[Token(Token = "0x60007EE")]
	[Address(RVA = "0x1E3A51C", Offset = "0x1E3A51C", VA = "0x1E3A51C")]
	private float NPCScale(int index)
	{
		return 0f;
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EF")]
	[Address(RVA = "0x1E3A584", Offset = "0x1E3A584", VA = "0x1E3A584")]
	private void NPCOver(int index)
	{
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x1E3A8B4", Offset = "0x1E3A8B4", VA = "0x1E3A8B4")]
	public void Close()
	{
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x1E3AD88", Offset = "0x1E3AD88", VA = "0x1E3AD88")]
	private void RefreshEntries()
	{
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x000054D8 File Offset: 0x000036D8
	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x1E3BC1C", Offset = "0x1E3BC1C", VA = "0x1E3BC1C")]
	private int SortCompare(BestiaryEntry x, BestiaryEntry y)
	{
		return 0;
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x1E3BE3C", Offset = "0x1E3BE3C", VA = "0x1E3BE3C")]
	private void DrawFilterSearch()
	{
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x1E3A7E8", Offset = "0x1E3A7E8", VA = "0x1E3A7E8")]
	private void CloseSearchInput()
	{
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x1E3C6AC", Offset = "0x1E3C6AC", VA = "0x1E3C6AC")]
	public void SetSearchTerm(string term)
	{
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x1E3C7E0", Offset = "0x1E3C7E0", VA = "0x1E3C7E0")]
	public void Open()
	{
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x000054F0 File Offset: 0x000036F0
	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x1E3CBFC", Offset = "0x1E3CBFC", VA = "0x1E3CBFC")]
	private bool IsOverLoot(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00005508 File Offset: 0x00003708
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x1E3CD6C", Offset = "0x1E3CD6C", VA = "0x1E3CD6C")]
	private bool IsOverOrders(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00005520 File Offset: 0x00003720
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x1E3CEDC", Offset = "0x1E3CEDC", VA = "0x1E3CEDC")]
	private bool IsOverFilters(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x1E3D04C", Offset = "0x1E3D04C", VA = "0x1E3D04C")]
	private void DrawLootDrops()
	{
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x1E3E37C", Offset = "0x1E3E37C", VA = "0x1E3E37C")]
	private void DrawProgressBar()
	{
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x1E3C96C", Offset = "0x1E3C96C", VA = "0x1E3C96C")]
	private void RefreshPercentUnlocked()
	{
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x1E3E85C", Offset = "0x1E3E85C", VA = "0x1E3E85C")]
	public void Draw()
	{
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x1E416A8", Offset = "0x1E416A8", VA = "0x1E416A8")]
	private void FilterDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x1E41AC4", Offset = "0x1E41AC4", VA = "0x1E41AC4")]
	private void FilterOver(int index)
	{
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00005538 File Offset: 0x00003738
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x1E41D4C", Offset = "0x1E41D4C", VA = "0x1E41D4C")]
	private float FilterScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x1E40270", Offset = "0x1E40270", VA = "0x1E40270")]
	private void DrawFilters()
	{
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x1E41D54", Offset = "0x1E41D54", VA = "0x1E41D54")]
	private void OrderDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x1E42084", Offset = "0x1E42084", VA = "0x1E42084")]
	private void OrderOver(int index)
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00005550 File Offset: 0x00003750
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x1E42140", Offset = "0x1E42140", VA = "0x1E42140")]
	private float OrderScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x1E40BF0", Offset = "0x1E40BF0", VA = "0x1E40BF0")]
	private void DrawOrders()
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000806")]
	[Address(RVA = "0x1E42148", Offset = "0x1E42148", VA = "0x1E42148")]
	private NamePlateInfoElement GetName(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000807")]
	[Address(RVA = "0x1E3A434", Offset = "0x1E3A434", VA = "0x1E3A434")]
	private IBestiaryEntryDisplayIndex GetDisplayIndex(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000808")]
	[Address(RVA = "0x1E42254", Offset = "0x1E42254", VA = "0x1E42254")]
	private NPCPortraitInfoElement GetNPCPortraitInfo(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000809")]
	[Address(RVA = "0x1E3DDBC", Offset = "0x1E3DDBC", VA = "0x1E3DDBC")]
	private NPCStatsReportInfoElement GetNPCStatsInfo(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080A")]
	[Address(RVA = "0x1E42360", Offset = "0x1E42360", VA = "0x1E42360")]
	private NPCKillCounterInfoElement GetKillCounterInfo(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x1E3A888", Offset = "0x1E3A888", VA = "0x1E3A888")]
	private void RefreshSelectedStats()
	{
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x1E4246C", Offset = "0x1E4246C", VA = "0x1E4246C")]
	private FlavorTextBestiaryInfoElement GetNPCFlavourInfo(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x1E42578", Offset = "0x1E42578", VA = "0x1E42578")]
	private IPreferenceProviderElement GetPreferenceProvider(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080E")]
	[Address(RVA = "0x1E42660", Offset = "0x1E42660", VA = "0x1E42660")]
	private List<IBestiaryBackgroundImagePathAndColorProvider> GetBackgroundImageProviders(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080F")]
	[Address(RVA = "0x1E428B8", Offset = "0x1E428B8", VA = "0x1E428B8")]
	private List<IBestiaryBackgroundOverlayAndColorProvider> GetBackgroundOverlayProviders(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00005568 File Offset: 0x00003768
	[Token(Token = "0x6000810")]
	[Address(RVA = "0x1E42BB0", Offset = "0x1E42BB0", VA = "0x1E42BB0")]
	private int SortBackgroundOverlayElements(IBestiaryBackgroundOverlayAndColorProvider x, IBestiaryBackgroundOverlayAndColorProvider y)
	{
		return 0;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000811")]
	[Address(RVA = "0x1E42CF8", Offset = "0x1E42CF8", VA = "0x1E42CF8")]
	private List<FilterProviderInfoElement> GetFilterProviders(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000812")]
	[Address(RVA = "0x1E3DBA8", Offset = "0x1E3DBA8", VA = "0x1E3DBA8")]
	private List<ItemDropBestiaryInfoElement> GetDropProviders(BestiaryEntry entry)
	{
		return null;
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000813")]
	[Address(RVA = "0x1E42EFC", Offset = "0x1E42EFC", VA = "0x1E42EFC")]
	private void UpdateBackgroundImages(BestiaryEntry entry)
	{
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000814")]
	[Address(RVA = "0x1E43AA0", Offset = "0x1E43AA0", VA = "0x1E43AA0")]
	private void DrawImageBackgrounds(Rectangle region, BestiaryEntry entry)
	{
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00005580 File Offset: 0x00003780
	[Token(Token = "0x6000815")]
	[Address(RVA = "0x1E43BDC", Offset = "0x1E43BDC", VA = "0x1E43BDC")]
	private float StarScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000816")]
	[Address(RVA = "0x1E43C44", Offset = "0x1E43C44", VA = "0x1E43C44")]
	private void StarOver(int index)
	{
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000817")]
	[Address(RVA = "0x1E43C48", Offset = "0x1E43C48", VA = "0x1E43C48")]
	private void StarDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x00005598 File Offset: 0x00003798
	[Token(Token = "0x6000818")]
	[Address(RVA = "0x1E43E48", Offset = "0x1E43E48", VA = "0x1E43E48")]
	private float DropScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000819")]
	[Address(RVA = "0x1E43E50", Offset = "0x1E43E50", VA = "0x1E43E50")]
	private void DropOver(int index)
	{
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081A")]
	[Address(RVA = "0x1E43F84", Offset = "0x1E43F84", VA = "0x1E43F84")]
	private void SetBestiaryNotesOnItemCache(DropRateInfo info)
	{
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081B")]
	[Address(RVA = "0x1E442D4", Offset = "0x1E442D4", VA = "0x1E442D4")]
	private void DropDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x000055B0 File Offset: 0x000037B0
	[Token(Token = "0x600081C")]
	[Address(RVA = "0x1E44A14", Offset = "0x1E44A14", VA = "0x1E44A14")]
	private float SpawnScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081D")]
	[Address(RVA = "0x1E44A1C", Offset = "0x1E44A1C", VA = "0x1E44A1C")]
	private void SpawnOver(int index)
	{
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081E")]
	[Address(RVA = "0x1E44A20", Offset = "0x1E44A20", VA = "0x1E44A20")]
	private void SpawnDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081F")]
	[Address(RVA = "0x1E3DEC8", Offset = "0x1E3DEC8", VA = "0x1E3DEC8")]
	private void DrawCoins()
	{
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000820")]
	[Address(RVA = "0x1E3F198", Offset = "0x1E3F198", VA = "0x1E3F198")]
	private void DrawSelectedEntry()
	{
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000821")]
	[Address(RVA = "0x1E3ACC4", Offset = "0x1E3ACC4", VA = "0x1E3ACC4")]
	private void CloseLootDrops()
	{
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000822")]
	[Address(RVA = "0x1E3AB4C", Offset = "0x1E3AB4C", VA = "0x1E3AB4C")]
	private void CloseFilters()
	{
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000823")]
	[Address(RVA = "0x1E3AC08", Offset = "0x1E3AC08", VA = "0x1E3AC08")]
	private void CloseSortOrder()
	{
	}

	// Token: 0x04000896 RID: 2198
	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x0")]
	private static Texture2D lockedIcon;

	// Token: 0x04000897 RID: 2199
	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0x4")]
	private static Texture2D iconRankLight;

	// Token: 0x04000898 RID: 2200
	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x8")]
	private static Texture2D iconRankDim;

	// Token: 0x04000899 RID: 2201
	[Token(Token = "0x4000899")]
	[FieldOffset(Offset = "0xC")]
	private static Texture2D iconTagsShadow;

	// Token: 0x0400089A RID: 2202
	[Token(Token = "0x400089A")]
	[FieldOffset(Offset = "0x8")]
	private GUIControllerBestiary _controllerInput;

	// Token: 0x0400089B RID: 2203
	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0x10")]
	private static Texture_Layout sortIconBackup;

	// Token: 0x0400089C RID: 2204
	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0x14")]
	private static Texture_Layout sortIconBackup2;

	// Token: 0x0400089D RID: 2205
	[Token(Token = "0x400089D")]
	[FieldOffset(Offset = "0xC")]
	private float bestiaryButtonScale;

	// Token: 0x0400089E RID: 2206
	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x10")]
	private float TitleScale;

	// Token: 0x0400089F RID: 2207
	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0x14")]
	private float BackScale;

	// Token: 0x040008A0 RID: 2208
	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x18")]
	private GUIItemGrid.CursorOver npcItemOver;

	// Token: 0x040008A1 RID: 2209
	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0x1C")]
	private GUIItemGrid.GetItemScaleHandler npcScale;

	// Token: 0x040008A2 RID: 2210
	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x20")]
	private GUIItemGrid.DrawItemHandler npcDraw;

	// Token: 0x040008A3 RID: 2211
	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x24")]
	private int EntryOver;

	// Token: 0x040008A4 RID: 2212
	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0x28")]
	public BestiaryEntry SelectedEntry;

	// Token: 0x040008A5 RID: 2213
	[Token(Token = "0x40008A5")]
	[FieldOffset(Offset = "0x2C")]
	public float ScrollOffset;

	// Token: 0x040008A6 RID: 2214
	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0x30")]
	private float ScrollMomentum;

	// Token: 0x040008A7 RID: 2215
	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0x34")]
	private int ScrollDragging;

	// Token: 0x040008A8 RID: 2216
	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 DragOffset;

	// Token: 0x040008A9 RID: 2217
	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x40")]
	public List<BestiaryEntry> SortedEntries;

	// Token: 0x040008AA RID: 2218
	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x44")]
	private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

	// Token: 0x040008AB RID: 2219
	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x48")]
	private bool editingSearch;

	// Token: 0x040008AC RID: 2220
	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x4C")]
	private string searchTerm;

	// Token: 0x040008AD RID: 2221
	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x50")]
	private string editDisplaySearch;

	// Token: 0x040008AE RID: 2222
	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x54")]
	private float BeginSearchScale;

	// Token: 0x040008AF RID: 2223
	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x58")]
	private ISearchFilter<BestiaryEntry> searchFilter;

	// Token: 0x040008B0 RID: 2224
	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x5C")]
	private int ActiveFilterCount;

	// Token: 0x040008B1 RID: 2225
	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x60")]
	private int SelectedSort;

	// Token: 0x040008B2 RID: 2226
	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x64")]
	public float LootScrollOffset;

	// Token: 0x040008B3 RID: 2227
	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x68")]
	private float LootScrollMomentum;

	// Token: 0x040008B4 RID: 2228
	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0x6C")]
	private int LootScrollDragging;

	// Token: 0x040008B5 RID: 2229
	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 LootDragOffset;

	// Token: 0x040008B6 RID: 2230
	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x78")]
	public List<bool> filterEnabled;

	// Token: 0x040008B7 RID: 2231
	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x7C")]
	private List<Texture2D> filterTexture;

	// Token: 0x040008B8 RID: 2232
	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x80")]
	private List<string> filterName;

	// Token: 0x040008B9 RID: 2233
	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0x84")]
	private List<Rectangle> filterFrame;

	// Token: 0x040008BA RID: 2234
	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0x88")]
	private List<bool> filterAvailable;

	// Token: 0x040008BB RID: 2235
	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0x8C")]
	public bool Enabled;

	// Token: 0x040008BC RID: 2236
	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0x8D")]
	public bool OpenedFromInv;

	// Token: 0x040008BD RID: 2237
	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0x90")]
	private GUIInputRegionExclusive _lootBlocker;

	// Token: 0x040008BE RID: 2238
	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0x94")]
	private int unlockedEntries;

	// Token: 0x040008BF RID: 2239
	[Token(Token = "0x40008BF")]
	[FieldOffset(Offset = "0x98")]
	private bool displayFilters;

	// Token: 0x040008C0 RID: 2240
	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0x99")]
	private bool displayOrders;

	// Token: 0x040008C1 RID: 2241
	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x9C")]
	private float filtersScale;

	// Token: 0x040008C2 RID: 2242
	[Token(Token = "0x40008C2")]
	[FieldOffset(Offset = "0xA0")]
	private float ordersScale;

	// Token: 0x040008C3 RID: 2243
	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0xA4")]
	private GUIItemGrid.CursorOver filterItemOver;

	// Token: 0x040008C4 RID: 2244
	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0xA8")]
	private GUIItemGrid.GetItemScaleHandler filterScale;

	// Token: 0x040008C5 RID: 2245
	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0xAC")]
	private GUIItemGrid.DrawItemHandler filterDraw;

	// Token: 0x040008C6 RID: 2246
	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0xB0")]
	private int filterOver;

	// Token: 0x040008C7 RID: 2247
	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0xB4")]
	private GUIInputRegionExclusive _filterBlocker;

	// Token: 0x040008C8 RID: 2248
	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x18")]
	private static StringBuilder sb;

	// Token: 0x040008C9 RID: 2249
	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0xB8")]
	private GUIItemGrid.CursorOver orderItemOver;

	// Token: 0x040008CA RID: 2250
	[Token(Token = "0x40008CA")]
	[FieldOffset(Offset = "0xBC")]
	private GUIItemGrid.GetItemScaleHandler orderScale;

	// Token: 0x040008CB RID: 2251
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0xC0")]
	private GUIItemGrid.DrawItemHandler orderDraw;

	// Token: 0x040008CC RID: 2252
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0xC4")]
	private int orderOver;

	// Token: 0x040008CD RID: 2253
	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0xC8")]
	private GUIInputRegionExclusive _orderBlocker;

	// Token: 0x040008CE RID: 2254
	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0xCC")]
	private List<IBestiaryBackgroundImagePathAndColorProvider> BackgroundImageProviders;

	// Token: 0x040008CF RID: 2255
	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0xD0")]
	private List<IBestiaryBackgroundOverlayAndColorProvider> BackgroundOverlayProviders;

	// Token: 0x040008D0 RID: 2256
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0xD4")]
	private List<FilterProviderInfoElement> FilterProviders;

	// Token: 0x040008D1 RID: 2257
	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0xD8")]
	private List<ItemDropBestiaryInfoElement> DropProviders;

	// Token: 0x040008D2 RID: 2258
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0xDC")]
	private BestiaryEntry backgroundEntry;

	// Token: 0x040008D3 RID: 2259
	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0xE0")]
	private int backgroundImageCount;

	// Token: 0x040008D4 RID: 2260
	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0xE4")]
	private Texture2D[] backgroundImage;

	// Token: 0x040008D5 RID: 2261
	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0xE8")]
	private Color[] backgroundColour;

	// Token: 0x040008D6 RID: 2262
	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0xEC")]
	private GUIItemGrid.CursorOver starOver;

	// Token: 0x040008D7 RID: 2263
	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0xF0")]
	private GUIItemGrid.GetItemScaleHandler starScale;

	// Token: 0x040008D8 RID: 2264
	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0xF4")]
	private GUIItemGrid.DrawItemHandler starDraw;

	// Token: 0x040008D9 RID: 2265
	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0xF8")]
	private int starCount;

	// Token: 0x040008DA RID: 2266
	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0xFC")]
	private GUIItemGrid.CursorOver dropOver;

	// Token: 0x040008DB RID: 2267
	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x100")]
	private GUIItemGrid.GetItemScaleHandler dropScale;

	// Token: 0x040008DC RID: 2268
	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x104")]
	private GUIItemGrid.DrawItemHandler dropDraw;

	// Token: 0x040008DD RID: 2269
	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x108")]
	private int DropItemOver;

	// Token: 0x040008DE RID: 2270
	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x10C")]
	private int SelectedDropItem;

	// Token: 0x040008DF RID: 2271
	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0x110")]
	private Item dropItemInfo;

	// Token: 0x040008E0 RID: 2272
	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x114")]
	private int dropCount;

	// Token: 0x040008E1 RID: 2273
	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x118")]
	private GUIItemGrid.CursorOver spawnOver;

	// Token: 0x040008E2 RID: 2274
	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x11C")]
	private GUIItemGrid.GetItemScaleHandler spawnScale;

	// Token: 0x040008E3 RID: 2275
	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x120")]
	private GUIItemGrid.DrawItemHandler spawnDraw;

	// Token: 0x040008E4 RID: 2276
	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x124")]
	private int spawnCount;

	// Token: 0x040008E5 RID: 2277
	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x128")]
	private bool drawLootDrops;

	// Token: 0x040008E6 RID: 2278
	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x12C")]
	private NPCStatsReportInfoElement dummyStatsInfo;
}
