using System;
using Il2CppDummyDll;

// Token: 0x02000336 RID: 822
[Token(Token = "0x2000336")]
public class UserStaticState
{
	// Token: 0x06001441 RID: 5185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001441")]
	[Address(RVA = "0xDBE054", Offset = "0xDBE054", VA = "0xDBE054")]
	public UserStaticState()
	{
	}

	// Token: 0x04002811 RID: 10257
	[Token(Token = "0x4002811")]
	[FieldOffset(Offset = "0x0")]
	public static UserStaticState CurrentlyBound;

	// Token: 0x04002812 RID: 10258
	[Token(Token = "0x4002812")]
	[FieldOffset(Offset = "0x8")]
	public LockOnHelperStaticData LockOnHelper;
}
