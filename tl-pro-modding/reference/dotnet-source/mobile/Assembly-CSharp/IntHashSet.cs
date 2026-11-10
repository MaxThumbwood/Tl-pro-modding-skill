using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000317 RID: 791
[Token(Token = "0x2000317")]
public class IntHashSet
{
	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D9")]
	public List<int> Values
	{
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0xDA7A0C", Offset = "0xDA7A0C", VA = "0xDA7A0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013A1")]
		[Address(RVA = "0xDA7A14", Offset = "0xDA7A14", VA = "0xDA7A14")]
		set
		{
		}
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x00008D78 File Offset: 0x00006F78
	[Token(Token = "0x60013A2")]
	[Address(RVA = "0xDA7A1C", Offset = "0xDA7A1C", VA = "0xDA7A1C")]
	public bool Add(int valueToAdd)
	{
		return default(bool);
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x00008D90 File Offset: 0x00006F90
	[Token(Token = "0x60013A3")]
	[Address(RVA = "0xDA7B88", Offset = "0xDA7B88", VA = "0xDA7B88")]
	public bool Contains(int valueToCheck)
	{
		return default(bool);
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x00008DA8 File Offset: 0x00006FA8
	[Token(Token = "0x60013A4")]
	[Address(RVA = "0xDA7C44", Offset = "0xDA7C44", VA = "0xDA7C44")]
	public bool ContainsSet(int[] values)
	{
		return default(bool);
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00008DC0 File Offset: 0x00006FC0
	[Token(Token = "0x170001DA")]
	public int Count
	{
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0xDA7D48", Offset = "0xDA7D48", VA = "0xDA7D48")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A6")]
	[Address(RVA = "0xDA7DA0", Offset = "0xDA7DA0", VA = "0xDA7DA0")]
	public IntHashSet()
	{
	}

	// Token: 0x0400276C RID: 10092
	[Token(Token = "0x400276C")]
	[FieldOffset(Offset = "0x8")]
	private List<int> ValuesInSet;
}
