using System;
using Il2CppDummyDll;

// Token: 0x0200007A RID: 122
[Token(Token = "0x200007A")]
public class GUIControllerMappingEntryBase : GUISettingEntry
{
	// Token: 0x060002A1 RID: 673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x4B868C", Offset = "0x4B868C", VA = "0x4B868C")]
	public GUIControllerMappingEntryBase(GUISettingID id)
	{
	}

	// Token: 0x040004B9 RID: 1209
	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x14")]
	public ControllerMappingsCategories_Layout.Category Category;

	// Token: 0x040004BA RID: 1210
	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x18")]
	public int SortOrder;
}
