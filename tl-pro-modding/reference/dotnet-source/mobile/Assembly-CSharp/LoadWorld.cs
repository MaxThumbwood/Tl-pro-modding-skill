using System;
using Il2CppDummyDll;

// Token: 0x0200021C RID: 540
[Token(Token = "0x200021C")]
[Serializable]
public class LoadWorld
{
	// Token: 0x06000DF8 RID: 3576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0xC90748", Offset = "0xC90748", VA = "0xC90748")]
	private void Awake()
	{
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0xC9079C", Offset = "0xC9079C", VA = "0xC9079C")]
	public LoadWorld()
	{
	}

	// Token: 0x04001733 RID: 5939
	[Token(Token = "0x4001733")]
	[FieldOffset(Offset = "0x0")]
	public static LoadWorld Instance;

	// Token: 0x04001734 RID: 5940
	[Token(Token = "0x4001734")]
	[FieldOffset(Offset = "0x8")]
	public StringButton_Layout Status;

	// Token: 0x04001735 RID: 5941
	[Token(Token = "0x4001735")]
	[FieldOffset(Offset = "0xC")]
	public TransactionButton_Layout Load;

	// Token: 0x04001736 RID: 5942
	[Token(Token = "0x4001736")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Back;
}
