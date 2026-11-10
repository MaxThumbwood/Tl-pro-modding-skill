using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000138 RID: 312
[Token(Token = "0x2000138")]
public class GUIBuffs
{
	// Token: 0x06000827 RID: 2087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x1E45AF4", Offset = "0x1E45AF4", VA = "0x1E45AF4")]
	public GUIBuffs()
	{
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x000055C8 File Offset: 0x000037C8
	[Token(Token = "0x6000828")]
	[Address(RVA = "0x1E45D34", Offset = "0x1E45D34", VA = "0x1E45D34")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000829")]
	[Address(RVA = "0x1E45EB0", Offset = "0x1E45EB0", VA = "0x1E45EB0")]
	private void ChangeBuffString(int buffType)
	{
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082A")]
	[Address(RVA = "0x1E45F2C", Offset = "0x1E45F2C", VA = "0x1E45F2C")]
	private void NextItem()
	{
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082B")]
	[Address(RVA = "0x1E460C4", Offset = "0x1E460C4", VA = "0x1E460C4")]
	private void PreviousItem()
	{
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082C")]
	[Address(RVA = "0x1E4625C", Offset = "0x1E4625C", VA = "0x1E4625C")]
	private void RemoveBuff()
	{
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082D")]
	[Address(RVA = "0x1E46830", Offset = "0x1E46830", VA = "0x1E46830")]
	public void UpdateBuffNavigation()
	{
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x000055E0 File Offset: 0x000037E0
	[Token(Token = "0x600082E")]
	[Address(RVA = "0x1E46CF0", Offset = "0x1E46CF0", VA = "0x1E46CF0")]
	private bool CanRemoveBuff()
	{
		return default(bool);
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082F")]
	[Address(RVA = "0x1E462A4", Offset = "0x1E462A4", VA = "0x1E462A4")]
	private void RemoveBuff(int buff)
	{
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000830")]
	[Address(RVA = "0x1E46E14", Offset = "0x1E46E14", VA = "0x1E46E14")]
	public void Draw()
	{
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x000055F8 File Offset: 0x000037F8
	[Token(Token = "0x6000831")]
	[Address(RVA = "0x1E48034", Offset = "0x1E48034", VA = "0x1E48034")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000832")]
	[Address(RVA = "0x1E48060", Offset = "0x1E48060", VA = "0x1E48060")]
	public void ItemOver(int index)
	{
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000833")]
	[Address(RVA = "0x1E48430", Offset = "0x1E48430", VA = "0x1E48430")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x00005610 File Offset: 0x00003810
	[Token(Token = "0x6000834")]
	[Address(RVA = "0x1E4985C", Offset = "0x1E4985C", VA = "0x1E4985C")]
	private Rectangle GetPotRegion(int selectedItem)
	{
		return default(Rectangle);
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000835")]
	[Address(RVA = "0x1E475A4", Offset = "0x1E475A4", VA = "0x1E475A4")]
	private void DrawPots()
	{
	}

	// Token: 0x040008E7 RID: 2279
	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x8")]
	private int buffOver;

	// Token: 0x040008E8 RID: 2280
	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0xC")]
	private int buffToRemove;

	// Token: 0x040008E9 RID: 2281
	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x10")]
	private int lastDrawBuffText;

	// Token: 0x040008EA RID: 2282
	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x14")]
	private float lastdoubleClickTimer;

	// Token: 0x040008EB RID: 2283
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x18")]
	public int numActiveBuffs;

	// Token: 0x040008EC RID: 2284
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x1C")]
	private int[] activeBuffs;

	// Token: 0x040008ED RID: 2285
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x20")]
	public bool buffTogglePressed;

	// Token: 0x040008EE RID: 2286
	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x21")]
	public bool buffActive;

	// Token: 0x040008EF RID: 2287
	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x24")]
	public GUIControllerBuff buffController;

	// Token: 0x040008F0 RID: 2288
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x28")]
	private DateTime NavigationTick;

	// Token: 0x040008F1 RID: 2289
	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x30")]
	public GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x040008F2 RID: 2290
	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x34")]
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x040008F3 RID: 2291
	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x38")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	// Token: 0x040008F4 RID: 2292
	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x3C")]
	private Item buffItem;
}
