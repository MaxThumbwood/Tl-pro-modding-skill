using System;
using Il2CppDummyDll;

// Token: 0x020001AE RID: 430
[Token(Token = "0x20001AE")]
public class ButtonBar_Layout : LayoutDefinition
{
	// Token: 0x06000C86 RID: 3206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C86")]
	[Address(RVA = "0xC67248", Offset = "0xC67248", VA = "0xC67248")]
	private void Awake()
	{
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C87")]
	[Address(RVA = "0xC6729C", Offset = "0xC6729C", VA = "0xC6729C")]
	public ButtonBar_Layout()
	{
	}

	// Token: 0x0400105B RID: 4187
	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x0")]
	public static ButtonBar_Layout Instance;

	// Token: 0x0400105C RID: 4188
	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0xC")]
	public float GridItemScale;

	// Token: 0x0400105D RID: 4189
	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0x10")]
	public Stretched_Layout Backing;

	// Token: 0x0400105E RID: 4190
	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0x14")]
	public ItemGrid_Layout ButtonGrid;

	// Token: 0x0400105F RID: 4191
	[Token(Token = "0x400105F")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout ButtonCollapsed;

	// Token: 0x04001060 RID: 4192
	[Token(Token = "0x4001060")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout ButtonTemplateFirst;

	// Token: 0x04001061 RID: 4193
	[Token(Token = "0x4001061")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout ButtonTemplateEntry;

	// Token: 0x04001062 RID: 4194
	[Token(Token = "0x4001062")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout ButtonTemplateLast;

	// Token: 0x04001063 RID: 4195
	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0x28")]
	public Texture_Layout ExpandIcon;

	// Token: 0x04001064 RID: 4196
	[Token(Token = "0x4001064")]
	[FieldOffset(Offset = "0x2C")]
	public Texture_Layout CollapseIcon;

	// Token: 0x04001065 RID: 4197
	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0x30")]
	public Texture_Layout ChatIcon;

	// Token: 0x04001066 RID: 4198
	[Token(Token = "0x4001066")]
	[FieldOffset(Offset = "0x34")]
	public Texture_Layout TutorialIcon;

	// Token: 0x04001067 RID: 4199
	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0x38")]
	public Texture_Layout TutorialIconSelected;

	// Token: 0x04001068 RID: 4200
	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0x3C")]
	public Texture_Layout JourneyWorldSettingsIcon;

	// Token: 0x04001069 RID: 4201
	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0x40")]
	public Texture_Layout HousingIcon;

	// Token: 0x0400106A RID: 4202
	[Token(Token = "0x400106A")]
	[FieldOffset(Offset = "0x44")]
	public Texture_Layout PVPIcon;

	// Token: 0x0400106B RID: 4203
	[Token(Token = "0x400106B")]
	[FieldOffset(Offset = "0x48")]
	public Texture_Layout BestiaryIcon;

	// Token: 0x0400106C RID: 4204
	[Token(Token = "0x400106C")]
	[FieldOffset(Offset = "0x4C")]
	public Texture_Layout DuplicateIcon;

	// Token: 0x0400106D RID: 4205
	[Token(Token = "0x400106D")]
	[FieldOffset(Offset = "0x50")]
	public Texture_Layout MapIcon;
}
