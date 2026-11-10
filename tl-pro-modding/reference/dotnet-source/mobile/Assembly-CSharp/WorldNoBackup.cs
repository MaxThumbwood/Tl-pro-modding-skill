using System;
using Il2CppDummyDll;

// Token: 0x0200021D RID: 541
[Token(Token = "0x200021D")]
[Serializable]
public class WorldNoBackup
{
	// Token: 0x06000DFA RID: 3578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0xC907A4", Offset = "0xC907A4", VA = "0xC907A4")]
	private void Awake()
	{
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0xC907F8", Offset = "0xC907F8", VA = "0xC907F8")]
	public WorldNoBackup()
	{
	}

	// Token: 0x04001737 RID: 5943
	[Token(Token = "0x4001737")]
	[FieldOffset(Offset = "0x0")]
	public static WorldNoBackup Instance;

	// Token: 0x04001738 RID: 5944
	[Token(Token = "0x4001738")]
	[FieldOffset(Offset = "0x8")]
	public StringButton_Layout Status;

	// Token: 0x04001739 RID: 5945
	[Token(Token = "0x4001739")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Description;

	// Token: 0x0400173A RID: 5946
	[Token(Token = "0x400173A")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Back;
}
