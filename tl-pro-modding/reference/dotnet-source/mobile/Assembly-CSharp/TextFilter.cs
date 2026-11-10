using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

// Token: 0x02000068 RID: 104
[Token(Token = "0x2000068")]
public static class TextFilter
{
	// Token: 0x0600021A RID: 538 RVA: 0x00002BF8 File Offset: 0x00000DF8
	[Token(Token = "0x600021A")]
	[Address(RVA = "0x4AEBB0", Offset = "0x4AEBB0", VA = "0x4AEBB0")]
	private static bool IsWordBreak(char value)
	{
		return default(bool);
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x0600021B RID: 539 RVA: 0x00002C10 File Offset: 0x00000E10
	[Token(Token = "0x17000078")]
	public static bool AllCommunicationBlocked
	{
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4AEC48", Offset = "0x4AEC48", VA = "0x4AEC48")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x4AECC0", Offset = "0x4AECC0", VA = "0x4AECC0")]
	public static string FilterNetworkChestName(string text)
	{
		return null;
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x4AEE24", Offset = "0x4AEE24", VA = "0x4AEE24")]
	public static string FilterNetworkText(string text, bool isPotentialCommunication, bool menuFilter = false)
	{
		return null;
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x4AF7B8", Offset = "0x4AF7B8", VA = "0x4AF7B8")]
	public static void Load()
	{
	}

	// Token: 0x04000467 RID: 1127
	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x0")]
	private static TextFilter.DictionaryNode rootNode;

	// Token: 0x04000468 RID: 1128
	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x4")]
	private static StringBuilder outputBuilder;

	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	public class DictionaryNode : Dictionary<char, TextFilter.DictionaryNode>
	{
		// Token: 0x06000220 RID: 544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4AF964", Offset = "0x4AF964", VA = "0x4AF964")]
		public void InsertString(string filterString, int offset)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4AF340", Offset = "0x4AF340", VA = "0x4AF340")]
		public bool TestString(StringBuilder stringValue, int wordstart, ref int wordEnd, bool filterSubstrings)
		{
			return default(bool);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4AFCD0", Offset = "0x4AFCD0", VA = "0x4AFCD0")]
		public DictionaryNode()
		{
		}

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x30")]
		private bool hasEnd;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x31")]
		private bool filterAll;
	}
}
