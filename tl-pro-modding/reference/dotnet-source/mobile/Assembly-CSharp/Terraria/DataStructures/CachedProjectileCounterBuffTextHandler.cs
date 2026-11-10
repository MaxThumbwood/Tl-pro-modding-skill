using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000767 RID: 1895
	[Token(Token = "0x2000767")]
	public class CachedProjectileCounterBuffTextHandler : FileAPI
	{
		// Token: 0x060042EE RID: 17134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042EE")]
		[Address(RVA = "0x4FA6F8", Offset = "0x4FA6F8", VA = "0x4FA6F8")]
		public CachedProjectileCounterBuffTextHandler(int[] projectileTypesToLookFor)
		{
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EF")]
		[Address(RVA = "0x4FA714", Offset = "0x4FA714", VA = "0x4FA714", Slot = "4")]
		public string HandleBuffText()
		{
			return null;
		}

		// Token: 0x04008A72 RID: 35442
		[Token(Token = "0x4008A72")]
		[FieldOffset(Offset = "0x8")]
		private int[] projectilesToLookFor;
	}
}
