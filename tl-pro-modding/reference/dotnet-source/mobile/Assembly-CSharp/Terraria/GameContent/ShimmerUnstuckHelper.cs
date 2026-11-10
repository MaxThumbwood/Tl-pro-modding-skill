using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x020009CA RID: 2506
	[Token(Token = "0x20009CA")]
	public struct ShimmerUnstuckHelper
	{
		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x060051D5 RID: 20949 RVA: 0x000260A0 File Offset: 0x000242A0
		[Token(Token = "0x170009AE")]
		public bool ShouldUnstuck
		{
			[Token(Token = "0x60051D5")]
			[Address(RVA = "0x78510C", Offset = "0x78510C", VA = "0x78510C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D6")]
		[Address(RVA = "0x785134", Offset = "0x785134", VA = "0x785134")]
		public void Update(Player player)
		{
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x785258", Offset = "0x785258", VA = "0x785258")]
		public void StartUnstuck()
		{
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D8")]
		[Address(RVA = "0x78526C", Offset = "0x78526C", VA = "0x78526C")]
		public void Clear()
		{
		}

		// Token: 0x0400951E RID: 38174
		[Token(Token = "0x400951E")]
		[FieldOffset(Offset = "0x0")]
		public int TimeLeftUnstuck;

		// Token: 0x0400951F RID: 38175
		[Token(Token = "0x400951F")]
		[FieldOffset(Offset = "0x4")]
		public bool IndefiniteProtectionActive;
	}
}
