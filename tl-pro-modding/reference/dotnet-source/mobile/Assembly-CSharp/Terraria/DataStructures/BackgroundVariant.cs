using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200074B RID: 1867
	[Token(Token = "0x200074B")]
	public class BackgroundVariant
	{
		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081B")]
		public int[] Backgrounds
		{
			[Token(Token = "0x6004290")]
			[Address(RVA = "0x4F7274", Offset = "0x4F7274", VA = "0x4F7274")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004291")]
		[Address(RVA = "0x4F727C", Offset = "0x4F727C", VA = "0x4F727C")]
		public void Set(int far, int middle, int near)
		{
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004292")]
		[Address(RVA = "0x4F6F0C", Offset = "0x4F6F0C", VA = "0x4F6F0C")]
		public void Clear()
		{
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x00020400 File Offset: 0x0001E600
		[Token(Token = "0x1700081C")]
		public bool HasAny
		{
			[Token(Token = "0x6004293")]
			[Address(RVA = "0x4F72E8", Offset = "0x4F72E8", VA = "0x4F72E8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004294")]
		[Address(RVA = "0x4F71E0", Offset = "0x4F71E0", VA = "0x4F71E0")]
		public BackgroundVariant()
		{
		}

		// Token: 0x04008A16 RID: 35350
		[Token(Token = "0x4008A16")]
		[FieldOffset(Offset = "0x8")]
		private readonly int[] _backgrounds;
	}
}
