using System;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20004B1")]
	public struct ChestItem
	{
		// Token: 0x06002EDA RID: 11994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDA")]
		[Address(RVA = "0x188ABD8", Offset = "0x188ABD8", VA = "0x188ABD8")]
		public void Clear()
		{
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x188ABE8", Offset = "0x188ABE8", VA = "0x188ABE8")]
		public void SetDefaults(int id)
		{
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDC")]
		[Address(RVA = "0x188ABF8", Offset = "0x188ABF8", VA = "0x188ABF8")]
		public void netDefaults(int type)
		{
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDD")]
		[Address(RVA = "0x188AE64", Offset = "0x188AE64", VA = "0x188AE64")]
		public void FixAgainstExploit()
		{
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000166C8 File Offset: 0x000148C8
		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x188B0E0", Offset = "0x188B0E0", VA = "0x188B0E0")]
		public bool Prefix(int prefixWeWant)
		{
			return default(bool);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x000166E0 File Offset: 0x000148E0
		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x188B100", Offset = "0x188B100", VA = "0x188B100")]
		public bool Prefix(int prefixWeWant, out bool rolledPrefixIsTopTier)
		{
			return default(bool);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000166F8 File Offset: 0x000148F8
		[Token(Token = "0x6002EE0")]
		[Address(RVA = "0x188B00C", Offset = "0x188B00C", VA = "0x188B00C")]
		public bool CanRollPrefix(int prefix)
		{
			return default(bool);
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE1")]
		[Address(RVA = "0x188B0D4", Offset = "0x188B0D4", VA = "0x188B0D4")]
		public void ResetPrefix()
		{
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE2")]
		[Address(RVA = "0x188B6F0", Offset = "0x188B6F0", VA = "0x188B6F0")]
		public void SetToItem(Item item)
		{
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EE3")]
		[Address(RVA = "0x188B760", Offset = "0x188B760", VA = "0x188B760")]
		public Item ExpandItem()
		{
			return null;
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE4")]
		[Address(RVA = "0x188AF3C", Offset = "0x188AF3C", VA = "0x188AF3C")]
		public void TurnToAir()
		{
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x00016710 File Offset: 0x00014910
		[Token(Token = "0x17000620")]
		public bool IsAir
		{
			[Token(Token = "0x6002EE5")]
			[Address(RVA = "0x188B850", Offset = "0x188B850", VA = "0x188B850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x00016728 File Offset: 0x00014928
		[Token(Token = "0x17000621")]
		public bool IsACoin
		{
			[Token(Token = "0x6002EE6")]
			[Address(RVA = "0x188B874", Offset = "0x188B874", VA = "0x188B874")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x00016740 File Offset: 0x00014940
		[Token(Token = "0x17000622")]
		public int rare
		{
			[Token(Token = "0x6002EE7")]
			[Address(RVA = "0x188B88C", Offset = "0x188B88C", VA = "0x188B88C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x00016758 File Offset: 0x00014958
		[Token(Token = "0x17000623")]
		public byte dye
		{
			[Token(Token = "0x6002EE8")]
			[Address(RVA = "0x188B94C", Offset = "0x188B94C", VA = "0x188B94C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x00016770 File Offset: 0x00014970
		[Token(Token = "0x17000624")]
		public short maxStack
		{
			[Token(Token = "0x6002EE9")]
			[Address(RVA = "0x188AF4C", Offset = "0x188AF4C", VA = "0x188AF4C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04003ED6 RID: 16086
		[Token(Token = "0x4003ED6")]
		[FieldOffset(Offset = "0x0")]
		public short type;

		// Token: 0x04003ED7 RID: 16087
		[Token(Token = "0x4003ED7")]
		[FieldOffset(Offset = "0x2")]
		public short stack;

		// Token: 0x04003ED8 RID: 16088
		[Token(Token = "0x4003ED8")]
		[FieldOffset(Offset = "0x4")]
		public byte prefix;

		// Token: 0x04003ED9 RID: 16089
		[Token(Token = "0x4003ED9")]
		[FieldOffset(Offset = "0x5")]
		public bool favorited;
	}
}
