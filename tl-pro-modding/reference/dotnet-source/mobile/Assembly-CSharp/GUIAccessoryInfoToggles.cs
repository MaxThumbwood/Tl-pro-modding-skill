using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000133 RID: 307
[Token(Token = "0x2000133")]
public class GUIAccessoryInfoToggles
{
	// Token: 0x060007CD RID: 1997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x19E5450", Offset = "0x19E5450", VA = "0x19E5450")]
	public void CloseExpandedFilter()
	{
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x000053E8 File Offset: 0x000035E8
	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x19E5550", Offset = "0x19E5550", VA = "0x19E5550")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x19E5868", Offset = "0x19E5868", VA = "0x19E5868")]
	public void DrawToggles()
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00005400 File Offset: 0x00003600
	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x19E6C50", Offset = "0x19E6C50", VA = "0x19E6C50")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x19E6990", Offset = "0x19E6990", VA = "0x19E6990")]
	private void DrawInfoAccesoriesToggles()
	{
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00005418 File Offset: 0x00003618
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x19E6E38", Offset = "0x19E6E38", VA = "0x19E6E38")]
	public float InfoAccScale(int index)
	{
		return 0f;
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x19E6EA0", Offset = "0x19E6EA0", VA = "0x19E6EA0")]
	public void InfoAccOver(int index)
	{
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x19E73AC", Offset = "0x19E73AC", VA = "0x19E73AC")]
	public void InfoAccDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x19E8098", Offset = "0x19E8098", VA = "0x19E8098")]
	public GUIAccessoryInfoToggles()
	{
	}

	// Token: 0x04000870 RID: 2160
	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x8")]
	public bool Expanded;

	// Token: 0x04000871 RID: 2161
	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0xC")]
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x04000872 RID: 2162
	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x10")]
	private float buttonScale;

	// Token: 0x04000873 RID: 2163
	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x14")]
	private int accOver;

	// Token: 0x04000874 RID: 2164
	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x18")]
	private float HideShowButtonScale;
}
