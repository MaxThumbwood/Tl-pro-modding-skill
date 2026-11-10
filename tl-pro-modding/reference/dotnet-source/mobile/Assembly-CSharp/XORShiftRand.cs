using System;
using Il2CppDummyDll;

// Token: 0x0200006D RID: 109
[Token(Token = "0x200006D")]
public class XORShiftRand
{
	// Token: 0x06000240 RID: 576 RVA: 0x00002CA0 File Offset: 0x00000EA0
	[Token(Token = "0x6000240")]
	[Address(RVA = "0x4B2A94", Offset = "0x4B2A94", VA = "0x4B2A94")]
	internal uint Rand()
	{
		return 0U;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00002CB8 File Offset: 0x00000EB8
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x4B2AB0", Offset = "0x4B2AB0", VA = "0x4B2AB0")]
	public int Next(int max)
	{
		return 0;
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[Token(Token = "0x6000242")]
	[Address(RVA = "0x4B2B10", Offset = "0x4B2B10", VA = "0x4B2B10")]
	public int Next(int min, int max)
	{
		return 0;
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00002CE8 File Offset: 0x00000EE8
	[Token(Token = "0x6000243")]
	[Address(RVA = "0x4B2B78", Offset = "0x4B2B78", VA = "0x4B2B78")]
	public float NextFloat()
	{
		return 0f;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x4B2BB0", Offset = "0x4B2BB0", VA = "0x4B2BB0")]
	public void Next2(int minX, int maxX, int minY, int maxY, out int x, out int y)
	{
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000245")]
	[Address(RVA = "0x4B2C84", Offset = "0x4B2C84", VA = "0x4B2C84")]
	public XORShiftRand()
	{
	}

	// Token: 0x04000479 RID: 1145
	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0x8")]
	private uint y;

	// Token: 0x0400047A RID: 1146
	[Token(Token = "0x400047A")]
	private const float RangeScale = 2.3283064E-10f;
}
