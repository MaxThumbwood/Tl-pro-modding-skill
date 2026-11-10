using System;
using Il2CppDummyDll;
using Terraria.ID;

namespace Terraria.GameContent
{
	// Token: 0x02000948 RID: 2376
	[Token(Token = "0x2000948")]
	public class ChildSafety
	{
		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x00024EE8 File Offset: 0x000230E8
		// (set) Token: 0x06004F5C RID: 20316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000984")]
		public static bool Disabled
		{
			[Token(Token = "0x6004F5B")]
			[Address(RVA = "0x74C66C", Offset = "0x74C66C", VA = "0x74C66C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F5C")]
			[Address(RVA = "0x74C6D4", Offset = "0x74C6D4", VA = "0x74C6D4")]
			set
			{
			}
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x00024F00 File Offset: 0x00023100
		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0x74C740", Offset = "0x74C740", VA = "0x74C740")]
		public static bool DangerousGore(int id)
		{
			return default(bool);
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x00024F18 File Offset: 0x00023118
		[Token(Token = "0x6004F5E")]
		[Address(RVA = "0x74C7C4", Offset = "0x74C7C4", VA = "0x74C7C4")]
		public static bool DangerousDust(int id)
		{
			return default(bool);
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5F")]
		[Address(RVA = "0x74C848", Offset = "0x74C848", VA = "0x74C848")]
		public ChildSafety()
		{
		}

		// Token: 0x04009380 RID: 37760
		[Token(Token = "0x4009380")]
		[FieldOffset(Offset = "0x0")]
		private static SetFactory factoryDust;

		// Token: 0x04009381 RID: 37761
		[Token(Token = "0x4009381")]
		[FieldOffset(Offset = "0x4")]
		private static SetFactory factoryGore;

		// Token: 0x04009382 RID: 37762
		[Token(Token = "0x4009382")]
		[FieldOffset(Offset = "0x8")]
		private static readonly bool[] SafeGore;

		// Token: 0x04009383 RID: 37763
		[Token(Token = "0x4009383")]
		[FieldOffset(Offset = "0xC")]
		private static readonly bool[] SafeDust;
	}
}
