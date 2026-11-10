using System;
using Il2CppDummyDll;

// Token: 0x02000274 RID: 628
[Token(Token = "0x2000274")]
[Serializable]
public class VirtualControlsProfile_Layout
{
	// Token: 0x06000EB6 RID: 3766 RVA: 0x00007A40 File Offset: 0x00005C40
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0xC9AE98", Offset = "0xC9AE98", VA = "0xC9AE98")]
	public bool HasProfileMapping()
	{
		return default(bool);
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0xC9B0F8", Offset = "0xC9B0F8", VA = "0xC9B0F8")]
	public string GetDisplayName(float maxWidth = 800f)
	{
		return null;
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000185")]
	public VirtualControlsHardwareConfiguration_Layout HardwareConfig
	{
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0xC9B058", Offset = "0xC9B058", VA = "0xC9B058")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0xC9B43C", Offset = "0xC9B43C", VA = "0xC9B43C")]
	public void Copy(VirtualControlsProfile_Layout other, bool copyName = true)
	{
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00007A58 File Offset: 0x00005C58
	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0xC9B7E8", Offset = "0xC9B7E8", VA = "0xC9B7E8")]
	public bool IsSame(VirtualControlsProfile_Layout other)
	{
		return default(bool);
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0xC9BABC", Offset = "0xC9BABC", VA = "0xC9BABC")]
	public VirtualControlsProfile_Layout()
	{
	}

	// Token: 0x04001E33 RID: 7731
	[Token(Token = "0x4001E33")]
	[FieldOffset(Offset = "0x8")]
	public string Id;

	// Token: 0x04001E34 RID: 7732
	[Token(Token = "0x4001E34")]
	[FieldOffset(Offset = "0xC")]
	public string EditedName;

	// Token: 0x04001E35 RID: 7733
	[Token(Token = "0x4001E35")]
	[FieldOffset(Offset = "0x10")]
	public string Hardware;

	// Token: 0x04001E36 RID: 7734
	[Token(Token = "0x4001E36")]
	[FieldOffset(Offset = "0x14")]
	private VirtualControlsHardwareConfiguration_Layout _cachedHardware;

	// Token: 0x04001E37 RID: 7735
	[Token(Token = "0x4001E37")]
	[FieldOffset(Offset = "0x18")]
	public VirtualControlsBinding_Layout[] Controls;
}
