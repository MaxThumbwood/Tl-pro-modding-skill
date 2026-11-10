using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.Testing.ChatCommands
{
	// Token: 0x02000613 RID: 1555
	[Token(Token = "0x2000613")]
	public class ArgumentListResult : FileAPI, GUIControllerItem
	{
		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x0001E8B8 File Offset: 0x0001CAB8
		[Token(Token = "0x170007A9")]
		public int Count
		{
			[Token(Token = "0x6003D28")]
			[Address(RVA = "0x1E6185C", Offset = "0x1E6185C", VA = "0x1E6185C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AA")]
		public string Item
		{
			[Token(Token = "0x6003D29")]
			[Address(RVA = "0x1E618B4", Offset = "0x1E618B4", VA = "0x1E618B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D2A")]
		[Address(RVA = "0x1E61728", Offset = "0x1E61728", VA = "0x1E61728")]
		public ArgumentListResult(IEnumerable<string> results)
		{
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D2B")]
		[Address(RVA = "0x1E61920", Offset = "0x1E61920", VA = "0x1E61920")]
		private ArgumentListResult(bool isValid)
		{
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2C")]
		[Address(RVA = "0x1E619C0", Offset = "0x1E619C0", VA = "0x1E619C0", Slot = "4")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2D")]
		[Address(RVA = "0x1E61A64", Offset = "0x1E61A64", VA = "0x1E61A64", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x04004813 RID: 18451
		[Token(Token = "0x4004813")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ArgumentListResult Empty;

		// Token: 0x04004814 RID: 18452
		[Token(Token = "0x4004814")]
		[FieldOffset(Offset = "0x4")]
		public static readonly ArgumentListResult Invalid;

		// Token: 0x04004815 RID: 18453
		[Token(Token = "0x4004815")]
		[FieldOffset(Offset = "0x8")]
		public readonly bool IsValid;

		// Token: 0x04004816 RID: 18454
		[Token(Token = "0x4004816")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<string> _results;
	}
}
