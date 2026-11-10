using System;
using Il2CppDummyDll;

// Token: 0x020001AA RID: 426
[Token(Token = "0x20001AA")]
public class BossBar_Layout : LayoutDefinition
{
	// Token: 0x06000C7B RID: 3195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0xC66BA8", Offset = "0xC66BA8", VA = "0xC66BA8")]
	private void Awake()
	{
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0xC66C40", Offset = "0xC66C40", VA = "0xC66C40")]
	public BossBar_Layout()
	{
	}

	// Token: 0x0400101E RID: 4126
	[Token(Token = "0x400101E")]
	[FieldOffset(Offset = "0x0")]
	public static BossBar_Layout Instance;

	// Token: 0x0400101F RID: 4127
	[Token(Token = "0x400101F")]
	[FieldOffset(Offset = "0x4")]
	public static BossBar_Layout InstanceMobile;

	// Token: 0x04001020 RID: 4128
	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout BarBacking;

	// Token: 0x04001021 RID: 4129
	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout BarFrame;

	// Token: 0x04001022 RID: 4130
	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout BossIcon;

	// Token: 0x04001023 RID: 4131
	[Token(Token = "0x4001023")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout ControllerBarBacking;

	// Token: 0x04001024 RID: 4132
	[Token(Token = "0x4001024")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout ControllerBarFrame;

	// Token: 0x04001025 RID: 4133
	[Token(Token = "0x4001025")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout ControllerBossIcon;

	// Token: 0x04001026 RID: 4134
	[Token(Token = "0x4001026")]
	[FieldOffset(Offset = "0x24")]
	public Texture_Layout LifeCap;

	// Token: 0x04001027 RID: 4135
	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x28")]
	public Texture_Layout LifeFill;

	// Token: 0x04001028 RID: 4136
	[Token(Token = "0x4001028")]
	[FieldOffset(Offset = "0x2C")]
	public Texture_Layout ShieldCap;

	// Token: 0x04001029 RID: 4137
	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x30")]
	public Texture_Layout ShieldFill;

	// Token: 0x0400102A RID: 4138
	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0x34")]
	public bool RemainingOnly;

	// Token: 0x0400102B RID: 4139
	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x38")]
	public String_Layout HealthAmount;
}
