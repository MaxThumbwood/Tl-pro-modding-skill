using System;
using Il2CppDummyDll;

// Token: 0x020001A6 RID: 422
[Token(Token = "0x20001A6")]
public class AchievementToast_Layout : LayoutDefinition
{
	// Token: 0x06000C73 RID: 3187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C73")]
	[Address(RVA = "0xC664AC", Offset = "0xC664AC", VA = "0xC664AC")]
	private void Awake()
	{
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C74")]
	[Address(RVA = "0xC66500", Offset = "0xC66500", VA = "0xC66500")]
	public AchievementToast_Layout()
	{
	}

	// Token: 0x04000FAA RID: 4010
	[Token(Token = "0x4000FAA")]
	[FieldOffset(Offset = "0x0")]
	public static AchievementToast_Layout Instance;

	// Token: 0x04000FAB RID: 4011
	[Token(Token = "0x4000FAB")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout achievementBacking;

	// Token: 0x04000FAC RID: 4012
	[Token(Token = "0x4000FAC")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout achievementTitle;

	// Token: 0x04000FAD RID: 4013
	[Token(Token = "0x4000FAD")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout achievementIcon;

	// Token: 0x04000FAE RID: 4014
	[Token(Token = "0x4000FAE")]
	[FieldOffset(Offset = "0x18")]
	public int ToastsSpacing;

	// Token: 0x04000FAF RID: 4015
	[Token(Token = "0x4000FAF")]
	[FieldOffset(Offset = "0x1C")]
	public int ToastsTime;

	// Token: 0x04000FB0 RID: 4016
	[Token(Token = "0x4000FB0")]
	[FieldOffset(Offset = "0x20")]
	public bool ReverseOrder;
}
