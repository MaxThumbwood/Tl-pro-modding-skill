using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public struct DictionaryIntArray
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600006D RID: 109 RVA: 0x000023B8 File Offset: 0x000005B8
	// (set) Token: 0x0600006E RID: 110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000025")]
	public int Item
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x498A5C", Offset = "0x498A5C", VA = "0x498A5C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x498ADC", Offset = "0x498ADC", VA = "0x498ADC")]
		set
		{
		}
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x498C00", Offset = "0x498C00", VA = "0x498C00")]
	public void Reset()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x498C0C", Offset = "0x498C0C", VA = "0x498C0C")]
	public int EntryCount()
	{
		return 0;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x498DC8", Offset = "0x498DC8", VA = "0x498DC8")]
	public void DecrementEntries()
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x4990EC", Offset = "0x4990EC", VA = "0x4990EC")]
	public void ClearAllButValue(int validValue)
	{
	}

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x0")]
	private static List<int> keysToDecrement;

	// Token: 0x04000125 RID: 293
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, int> data;
}
