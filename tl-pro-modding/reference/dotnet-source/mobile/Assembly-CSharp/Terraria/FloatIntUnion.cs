using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	[StructLayout(2)]
	public struct FloatIntUnion
	{
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x000165D8 File Offset: 0x000147D8
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061D")]
		public bool Item
		{
			[Token(Token = "0x6002ECA")]
			[Address(RVA = "0x1886920", Offset = "0x1886920", VA = "0x1886920")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002ECB")]
			[Address(RVA = "0x1886954", Offset = "0x1886954", VA = "0x1886954")]
			set
			{
			}
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x000165F0 File Offset: 0x000147F0
		[Token(Token = "0x6002ECC")]
		[Address(RVA = "0x1886AC4", Offset = "0x1886AC4", VA = "0x1886AC4")]
		public static implicit operator FloatIntUnion(float value)
		{
			return default(FloatIntUnion);
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x00016608 File Offset: 0x00014808
		[Token(Token = "0x6002ECD")]
		[Address(RVA = "0x188A608", Offset = "0x188A608", VA = "0x188A608")]
		public static implicit operator float(FloatIntUnion union)
		{
			return 0f;
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x00016620 File Offset: 0x00014820
		[Token(Token = "0x6002ECE")]
		[Address(RVA = "0x188A60C", Offset = "0x188A60C", VA = "0x188A60C")]
		public static implicit operator FloatIntUnion(int value)
		{
			return default(FloatIntUnion);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00016638 File Offset: 0x00014838
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0x188A610", Offset = "0x188A610", VA = "0x188A610")]
		public static implicit operator int(FloatIntUnion union)
		{
			return 0;
		}

		// Token: 0x04003ECA RID: 16074
		[Token(Token = "0x4003ECA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Float;

		// Token: 0x04003ECB RID: 16075
		[Token(Token = "0x4003ECB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Int;
	}
}
