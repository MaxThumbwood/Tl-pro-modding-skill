using System;
using Il2CppDummyDll;

// Token: 0x020002D7 RID: 727
[Token(Token = "0x20002D7")]
public class GUISettingEntry
{
	// Token: 0x06001208 RID: 4616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001208")]
	[Address(RVA = "0xD6C798", Offset = "0xD6C798", VA = "0xD6C798")]
	public GUISettingEntry(GUISettingID id)
	{
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001209")]
	[Address(RVA = "0xD78B00", Offset = "0xD78B00", VA = "0xD78B00", Slot = "4")]
	public virtual void Draw()
	{
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x00008688 File Offset: 0x00006888
	[Token(Token = "0x600120A")]
	[Address(RVA = "0xD78B04", Offset = "0xD78B04", VA = "0xD78B04", Slot = "5")]
	public virtual float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120B")]
	[Address(RVA = "0xD78B0C", Offset = "0xD78B0C", VA = "0xD78B0C", Slot = "6")]
	public virtual void DrawOverlay()
	{
	}

	// Token: 0x040022BC RID: 8892
	[Token(Token = "0x40022BC")]
	[FieldOffset(Offset = "0x8")]
	public GUISettingID _id;

	// Token: 0x040022BD RID: 8893
	[Token(Token = "0x40022BD")]
	[FieldOffset(Offset = "0xC")]
	public int _sortId;

	// Token: 0x040022BE RID: 8894
	[Token(Token = "0x40022BE")]
	[FieldOffset(Offset = "0x10")]
	public SettingsOverlayOptionCategories_Layout.Category _category;
}
