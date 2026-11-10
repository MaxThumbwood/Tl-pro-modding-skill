using System;
using Il2CppDummyDll;

// Token: 0x0200021B RID: 539
[Token(Token = "0x200021B")]
public class LoadBackup_Layout : LayoutDefinition
{
	// Token: 0x06000DF6 RID: 3574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0xC9068C", Offset = "0xC9068C", VA = "0xC9068C")]
	private void Awake()
	{
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0xC906E0", Offset = "0xC906E0", VA = "0xC906E0")]
	public LoadBackup_Layout()
	{
	}

	// Token: 0x04001730 RID: 5936
	[Token(Token = "0x4001730")]
	[FieldOffset(Offset = "0x0")]
	public static LoadBackup_Layout Instance;

	// Token: 0x04001731 RID: 5937
	[Token(Token = "0x4001731")]
	[FieldOffset(Offset = "0xC")]
	public LoadWorld LoadWorld;

	// Token: 0x04001732 RID: 5938
	[Token(Token = "0x4001732")]
	[FieldOffset(Offset = "0x10")]
	public WorldNoBackup WorldNoBackup;
}
