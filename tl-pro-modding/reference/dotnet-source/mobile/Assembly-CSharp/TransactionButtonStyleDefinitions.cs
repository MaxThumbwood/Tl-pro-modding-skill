using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001DC RID: 476
[Token(Token = "0x20001DC")]
public class TransactionButtonStyleDefinitions : LayoutDefinition
{
	// Token: 0x06000D15 RID: 3349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D15")]
	[Address(RVA = "0xC78CD8", Offset = "0xC78CD8", VA = "0xC78CD8")]
	private void Awake()
	{
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0xC78D2C", Offset = "0xC78D2C", VA = "0xC78D2C")]
	public static TransactionButtonStyle_Definition GetDefinition(string id)
	{
		return null;
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D17")]
	[Address(RVA = "0xC78FA4", Offset = "0xC78FA4", VA = "0xC78FA4")]
	public TransactionButtonStyleDefinitions()
	{
	}

	// Token: 0x04001306 RID: 4870
	[Token(Token = "0x4001306")]
	[FieldOffset(Offset = "0x0")]
	public static TransactionButtonStyleDefinitions Instance;

	// Token: 0x04001307 RID: 4871
	[Token(Token = "0x4001307")]
	[FieldOffset(Offset = "0xC")]
	public List<TransactionButtonStyle_Definition> Definitions;
}
