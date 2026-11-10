using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000141 RID: 321
[Token(Token = "0x2000141")]
public class GUIChestSplitStack
{
	// Token: 0x06000871 RID: 2161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000871")]
	[Address(RVA = "0x4D2CD4", Offset = "0x4D2CD4", VA = "0x4D2CD4")]
	public GUIChestSplitStack()
	{
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00005790 File Offset: 0x00003990
	[Token(Token = "0x6000872")]
	[Address(RVA = "0x4D2E78", Offset = "0x4D2E78", VA = "0x4D2E78")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000873")]
	[Address(RVA = "0x4D30B0", Offset = "0x4D30B0", VA = "0x4D30B0")]
	public void RightClickSplit()
	{
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x000057A8 File Offset: 0x000039A8
	[Token(Token = "0x6000874")]
	[Address(RVA = "0x4D31B0", Offset = "0x4D31B0", VA = "0x4D31B0")]
	public bool WasSplit()
	{
		return default(bool);
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x000057C0 File Offset: 0x000039C0
	[Token(Token = "0x6000875")]
	[Address(RVA = "0x4D3384", Offset = "0x4D3384", VA = "0x4D3384")]
	public bool IsOpen()
	{
		return default(bool);
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000876")]
	[Address(RVA = "0x4D338C", Offset = "0x4D338C", VA = "0x4D338C")]
	public void Open()
	{
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000877")]
	[Address(RVA = "0x4D34B8", Offset = "0x4D34B8", VA = "0x4D34B8")]
	private void RefreshItemToSplit(bool SliderConsoleRightDirection = false)
	{
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000878")]
	[Address(RVA = "0x4D1CA8", Offset = "0x4D1CA8", VA = "0x4D1CA8")]
	public void Close()
	{
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000879")]
	[Address(RVA = "0x4D3684", Offset = "0x4D3684", VA = "0x4D3684")]
	public void Draw()
	{
	}

	// Token: 0x04000947 RID: 2375
	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x8")]
	public GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x04000948 RID: 2376
	[Token(Token = "0x4000948")]
	[FieldOffset(Offset = "0xC")]
	private int SelectedItemInitial;

	// Token: 0x04000949 RID: 2377
	[Token(Token = "0x4000949")]
	[FieldOffset(Offset = "0x10")]
	private bool open;

	// Token: 0x0400094A RID: 2378
	[Token(Token = "0x400094A")]
	[FieldOffset(Offset = "0x14")]
	private float splitSlider;

	// Token: 0x0400094B RID: 2379
	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x18")]
	private GUISlider.DragState dragState;

	// Token: 0x0400094C RID: 2380
	[Token(Token = "0x400094C")]
	[FieldOffset(Offset = "0x1C")]
	private Item ItemToSplit;

	// Token: 0x0400094D RID: 2381
	[Token(Token = "0x400094D")]
	[FieldOffset(Offset = "0x20")]
	private Item SplitItem;

	// Token: 0x0400094E RID: 2382
	[Token(Token = "0x400094E")]
	[FieldOffset(Offset = "0x24")]
	private float splitScale;

	// Token: 0x0400094F RID: 2383
	[Token(Token = "0x400094F")]
	[FieldOffset(Offset = "0x28")]
	private float itemScale;

	// Token: 0x04000950 RID: 2384
	[Token(Token = "0x4000950")]
	[FieldOffset(Offset = "0x2C")]
	private float mainScale;

	// Token: 0x04000951 RID: 2385
	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x30")]
	private DateTime lastSplitTime;

	// Token: 0x04000952 RID: 2386
	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 lastSplitPosition;

	// Token: 0x04000953 RID: 2387
	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x40")]
	public GUITransactionButton.InputState splitButtonState;
}
