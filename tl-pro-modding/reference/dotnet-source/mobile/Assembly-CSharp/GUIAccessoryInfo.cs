using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000131 RID: 305
[Token(Token = "0x2000131")]
public class GUIAccessoryInfo
{
	// Token: 0x060007C7 RID: 1991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x19DE600", Offset = "0x19DE600", VA = "0x19DE600")]
	public GUIAccessoryInfo()
	{
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x19DE804", Offset = "0x19DE804", VA = "0x19DE804")]
	public void Draw()
	{
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x000053D0 File Offset: 0x000035D0
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x19E4DBC", Offset = "0x19E4DBC", VA = "0x19E4DBC")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x19E4E24", Offset = "0x19E4E24", VA = "0x19E4E24")]
	public void ItemOver(int index)
	{
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x19E4E28", Offset = "0x19E4E28", VA = "0x19E4E28")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x19DFD18", Offset = "0x19DFD18", VA = "0x19DFD18")]
	public void BuildInfoAccs()
	{
	}

	// Token: 0x04000861 RID: 2145
	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0x8")]
	public int numInfoAccessories;

	// Token: 0x04000862 RID: 2146
	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0xC")]
	public int[] DisplayIcons;

	// Token: 0x04000863 RID: 2147
	[Token(Token = "0x4000863")]
	[FieldOffset(Offset = "0x10")]
	public string[] IconText;

	// Token: 0x04000864 RID: 2148
	[Token(Token = "0x4000864")]
	[FieldOffset(Offset = "0x14")]
	public string[] InfoText;

	// Token: 0x04000865 RID: 2149
	[Token(Token = "0x4000865")]
	[FieldOffset(Offset = "0x18")]
	private GUIAccessoryInfo.StringState[] InfoState;

	// Token: 0x04000866 RID: 2150
	[Token(Token = "0x4000866")]
	[FieldOffset(Offset = "0x1C")]
	private Rectangle lastDrawRegion;

	// Token: 0x04000867 RID: 2151
	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x2C")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x04000868 RID: 2152
	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0x30")]
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x04000869 RID: 2153
	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x34")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	// Token: 0x0400086A RID: 2154
	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x38")]
	private int itemOffset;

	// Token: 0x0400086B RID: 2155
	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x3C")]
	private int lastRebuild;

	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	private enum StringState
	{
		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		Normal,
		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		Disabled,
		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		Critter
	}
}
