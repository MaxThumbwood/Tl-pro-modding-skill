using System;
using Il2CppDummyDll;

// Token: 0x0200006C RID: 108
[Token(Token = "0x200006C")]
public static class UID
{
	// Token: 0x06000237 RID: 567 RVA: 0x00002C58 File Offset: 0x00000E58
	[Token(Token = "0x6000237")]
	[Address(RVA = "0x4B227C", Offset = "0x4B227C", VA = "0x4B227C")]
	public static int Generate(string data)
	{
		return 0;
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00002C70 File Offset: 0x00000E70
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x4B2544", Offset = "0x4B2544", VA = "0x4B2544")]
	public static int Generate(byte[] data, int dataLength = -1)
	{
		return 0;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x4B2630", Offset = "0x4B2630", VA = "0x4B2630")]
	public static void InitialiseUIDGeneration(ref uint resultUID)
	{
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x4B2694", Offset = "0x4B2694", VA = "0x4B2694")]
	public static void UIDGenerationAddInt(int value, ref uint resultUID)
	{
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023B")]
	[Address(RVA = "0x4B27B0", Offset = "0x4B27B0", VA = "0x4B27B0")]
	public static void UIDGenerationAddFloat(float value, ref uint resultUID)
	{
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023C")]
	[Address(RVA = "0x4B2924", Offset = "0x4B2924", VA = "0x4B2924")]
	public static void UIDGenerationAddString(string value, ref uint resultUID)
	{
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023D")]
	[Address(RVA = "0x4B2A44", Offset = "0x4B2A44", VA = "0x4B2A44")]
	public static void FinaliseUIDGeneration(ref uint resultUID)
	{
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00002C88 File Offset: 0x00000E88
	[Token(Token = "0x600023E")]
	[Address(RVA = "0x4B2A54", Offset = "0x4B2A54", VA = "0x4B2A54")]
	private static uint Reflect(uint ulReflect, char cChar)
	{
		return 0U;
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023F")]
	[Address(RVA = "0x4B2398", Offset = "0x4B2398", VA = "0x4B2398")]
	private static void Initialise()
	{
	}

	// Token: 0x04000478 RID: 1144
	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x0")]
	private static uint[] s_lookupTable;
}
