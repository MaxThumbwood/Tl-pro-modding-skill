using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020002AA RID: 682
[Token(Token = "0x20002AA")]
public class GUIPageGroupEdit
{
	// Token: 0x06001026 RID: 4134 RVA: 0x00007E48 File Offset: 0x00006048
	[Token(Token = "0x6001026")]
	[Address(RVA = "0xCE1BE4", Offset = "0xCE1BE4", VA = "0xCE1BE4")]
	private int SortSettings(GUIPageIconGrouping.SettingCategory x, GUIPageIconGrouping.SettingCategory y)
	{
		return 0;
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00007E60 File Offset: 0x00006060
	[Token(Token = "0x6001027")]
	[Address(RVA = "0xCE1CE4", Offset = "0xCE1CE4", VA = "0xCE1CE4")]
	private int SortCategories(GUIPageIcons.Category x, GUIPageIcons.Category y)
	{
		return 0;
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00007E78 File Offset: 0x00006078
	[Token(Token = "0x6001028")]
	[Address(RVA = "0xCE1D98", Offset = "0xCE1D98", VA = "0xCE1D98")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001029")]
	[Address(RVA = "0xCE1FE0", Offset = "0xCE1FE0", VA = "0xCE1FE0")]
	public void Draw()
	{
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00007E90 File Offset: 0x00006090
	[Token(Token = "0x600102A")]
	[Address(RVA = "0xCE3150", Offset = "0xCE3150", VA = "0xCE3150")]
	private float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102B")]
	[Address(RVA = "0xCE317C", Offset = "0xCE317C", VA = "0xCE317C")]
	private void ItemOver(int index)
	{
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102C")]
	[Address(RVA = "0xCE3184", Offset = "0xCE3184", VA = "0xCE3184")]
	private void DisableCategory(GUIPageIcons.Category cat)
	{
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102D")]
	[Address(RVA = "0xCE34EC", Offset = "0xCE34EC", VA = "0xCE34EC")]
	private void DisableSetting(GUIPageIconGrouping.SettingCategory cat)
	{
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102E")]
	[Address(RVA = "0xCE3854", Offset = "0xCE3854", VA = "0xCE3854")]
	private void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102F")]
	[Address(RVA = "0xCE30BC", Offset = "0xCE30BC", VA = "0xCE30BC")]
	public void Close()
	{
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00007EA8 File Offset: 0x000060A8
	[Token(Token = "0x6001030")]
	[Address(RVA = "0xCE4DE4", Offset = "0xCE4DE4", VA = "0xCE4DE4")]
	private bool IsOverGroupOptions(Vector2 position)
	{
		return default(bool);
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001031")]
	[Address(RVA = "0xCE4FF4", Offset = "0xCE4FF4", VA = "0xCE4FF4")]
	public GUIPageGroupEdit()
	{
	}

	// Token: 0x04002064 RID: 8292
	[Token(Token = "0x4002064")]
	[FieldOffset(Offset = "0x8")]
	private bool LastHorizontal;

	// Token: 0x04002065 RID: 8293
	[Token(Token = "0x4002065")]
	[FieldOffset(Offset = "0x9")]
	public bool Enabled;

	// Token: 0x04002066 RID: 8294
	[Token(Token = "0x4002066")]
	[FieldOffset(Offset = "0xC")]
	private List<GUIPageIcons.Category> PageOptions;

	// Token: 0x04002067 RID: 8295
	[Token(Token = "0x4002067")]
	[FieldOffset(Offset = "0x10")]
	private List<GUIPageIconGrouping.SettingCategory> SettingOptions;

	// Token: 0x04002068 RID: 8296
	[Token(Token = "0x4002068")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 toggleSize;

	// Token: 0x04002069 RID: 8297
	[Token(Token = "0x4002069")]
	[FieldOffset(Offset = "0x1C")]
	private int hoverItem;

	// Token: 0x0400206A RID: 8298
	[Token(Token = "0x400206A")]
	[FieldOffset(Offset = "0x20")]
	private bool CanOptionBeAdded;

	// Token: 0x0400206B RID: 8299
	[Token(Token = "0x400206B")]
	[FieldOffset(Offset = "0x24")]
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x0400206C RID: 8300
	[Token(Token = "0x400206C")]
	[FieldOffset(Offset = "0x28")]
	private Rectangle popupRegion;
}
