using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000153 RID: 339
[Token(Token = "0x2000153")]
public class GUIEquipmentLoadout
{
	// Token: 0x06000962 RID: 2402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000962")]
	[Address(RVA = "0x7C3C58", Offset = "0x7C3C58", VA = "0x7C3C58")]
	public void CloseExpandedFilter()
	{
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00005DA8 File Offset: 0x00003FA8
	[Token(Token = "0x6000963")]
	[Address(RVA = "0x7C3D58", Offset = "0x7C3D58", VA = "0x7C3D58")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000964")]
	[Address(RVA = "0x7C4018", Offset = "0x7C4018", VA = "0x7C4018")]
	public void DrawToggles()
	{
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00005DC0 File Offset: 0x00003FC0
	[Token(Token = "0x6000965")]
	[Address(RVA = "0x7C5D8C", Offset = "0x7C5D8C", VA = "0x7C5D8C")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x7C5B58", Offset = "0x7C5B58", VA = "0x7C5B58")]
	private void DrawLoadouts()
	{
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00005DD8 File Offset: 0x00003FD8
	[Token(Token = "0x6000967")]
	[Address(RVA = "0x7C5F74", Offset = "0x7C5F74", VA = "0x7C5F74")]
	public float LoadoutScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000968")]
	[Address(RVA = "0x7C5FDC", Offset = "0x7C5FDC", VA = "0x7C5FDC")]
	public void LoadoutOver(int index)
	{
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000969")]
	[Address(RVA = "0x7C611C", Offset = "0x7C611C", VA = "0x7C611C")]
	public void LoadoutDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096A")]
	[Address(RVA = "0x7C6954", Offset = "0x7C6954", VA = "0x7C6954")]
	public GUIEquipmentLoadout()
	{
	}

	// Token: 0x04000A8A RID: 2698
	[Token(Token = "0x4000A8A")]
	[FieldOffset(Offset = "0x8")]
	public bool Expanded;

	// Token: 0x04000A8B RID: 2699
	[Token(Token = "0x4000A8B")]
	[FieldOffset(Offset = "0xC")]
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x04000A8C RID: 2700
	[Token(Token = "0x4000A8C")]
	[FieldOffset(Offset = "0x10")]
	private float buttonScale;

	// Token: 0x04000A8D RID: 2701
	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0x14")]
	private int loadoutOver;

	// Token: 0x04000A8E RID: 2702
	[Token(Token = "0x4000A8E")]
	[FieldOffset(Offset = "0x18")]
	private float HideShowButtonScale;
}
