using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020002F8 RID: 760
[Token(Token = "0x20002F8")]
public static class CrossplaySessionIdGenerator
{
	// Token: 0x0600129A RID: 4762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129A")]
	[Address(RVA = "0xD9246C", Offset = "0xD9246C", VA = "0xD9246C")]
	public static string Generate()
	{
		return null;
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00008868 File Offset: 0x00006A68
	[Token(Token = "0x600129B")]
	[Address(RVA = "0xD92734", Offset = "0xD92734", VA = "0xD92734")]
	public static bool LooksLikeSessionId(string id)
	{
		return default(bool);
	}

	// Token: 0x04002510 RID: 9488
	[Token(Token = "0x4002510")]
	private const string characterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";

	// Token: 0x04002511 RID: 9489
	[Token(Token = "0x4002511")]
	[FieldOffset(Offset = "0x0")]
	private static byte[] rndBuffer;

	// Token: 0x04002512 RID: 9490
	[Token(Token = "0x4002512")]
	[FieldOffset(Offset = "0x4")]
	private static StringBuilder sb;

	// Token: 0x04002513 RID: 9491
	[Token(Token = "0x4002513")]
	[FieldOffset(Offset = "0x8")]
	private static char[] outputBuffer;
}
