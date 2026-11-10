using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	public struct Bits256
	{
		// Token: 0x06002ED0 RID: 11984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x188A614", Offset = "0x188A614", VA = "0x188A614")]
		public void ClearAll()
		{
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x188A624", Offset = "0x188A624", VA = "0x188A624")]
		public void SetAll()
		{
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00016650 File Offset: 0x00014850
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x188A64C", Offset = "0x188A64C", VA = "0x188A64C")]
		public bool AnySet()
		{
			return default(bool);
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x00016668 File Offset: 0x00014868
		// (set) Token: 0x06002ED4 RID: 11988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061E")]
		public bool Item
		{
			[Token(Token = "0x6002ED3")]
			[Address(RVA = "0x188A6B0", Offset = "0x188A6B0", VA = "0x188A6B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002ED4")]
			[Address(RVA = "0x188A740", Offset = "0x188A740", VA = "0x188A740")]
			set
			{
			}
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00016680 File Offset: 0x00014880
		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x188A7D8", Offset = "0x188A7D8", VA = "0x188A7D8")]
		public static bool operator ==(Bits256 a, Bits256 b)
		{
			return default(bool);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00016698 File Offset: 0x00014898
		[Token(Token = "0x6002ED6")]
		[Address(RVA = "0x188A850", Offset = "0x188A850", VA = "0x188A850")]
		public static bool operator !=(Bits256 a, Bits256 b)
		{
			return default(bool);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED7")]
		[Address(RVA = "0x188A8C4", Offset = "0x188A8C4", VA = "0x188A8C4")]
		public void Serialise(BinaryWriter writer)
		{
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED8")]
		[Address(RVA = "0x188AA14", Offset = "0x188AA14", VA = "0x188AA14")]
		public void Deserialise(BinaryReader reader)
		{
		}

		// Token: 0x04003ECC RID: 16076
		[Token(Token = "0x4003ECC")]
		[FieldOffset(Offset = "0x0")]
		private uint ul0;

		// Token: 0x04003ECD RID: 16077
		[Token(Token = "0x4003ECD")]
		[FieldOffset(Offset = "0x4")]
		private uint ul1;

		// Token: 0x04003ECE RID: 16078
		[Token(Token = "0x4003ECE")]
		[FieldOffset(Offset = "0x8")]
		private uint ul2;

		// Token: 0x04003ECF RID: 16079
		[Token(Token = "0x4003ECF")]
		[FieldOffset(Offset = "0xC")]
		private uint ul3;

		// Token: 0x04003ED0 RID: 16080
		[Token(Token = "0x4003ED0")]
		[FieldOffset(Offset = "0x10")]
		private uint ul4;

		// Token: 0x04003ED1 RID: 16081
		[Token(Token = "0x4003ED1")]
		[FieldOffset(Offset = "0x14")]
		private uint ul5;

		// Token: 0x04003ED2 RID: 16082
		[Token(Token = "0x4003ED2")]
		[FieldOffset(Offset = "0x18")]
		private uint ul6;

		// Token: 0x04003ED3 RID: 16083
		[Token(Token = "0x4003ED3")]
		[FieldOffset(Offset = "0x1C")]
		private uint ul7;
	}
}
