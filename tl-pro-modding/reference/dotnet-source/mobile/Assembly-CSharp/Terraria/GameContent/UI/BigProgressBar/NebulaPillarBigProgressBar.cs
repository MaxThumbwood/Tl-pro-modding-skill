using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DC0 RID: 3520
	[Token(Token = "0x2000DC0")]
	public class NebulaPillarBigProgressBar : LunarPillarBigProgessBar
	{
		// Token: 0x0600677D RID: 26493 RVA: 0x0002EAA0 File Offset: 0x0002CCA0
		[Token(Token = "0x600677D")]
		[Address(RVA = "0xB753E0", Offset = "0xB753E0", VA = "0xB753E0", Slot = "6")]
		internal override float GetCurrentShieldValue()
		{
			return 0f;
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x0002EAB8 File Offset: 0x0002CCB8
		[Token(Token = "0x600677E")]
		[Address(RVA = "0xB7544C", Offset = "0xB7544C", VA = "0xB7544C", Slot = "7")]
		internal override float GetMaxShieldValue()
		{
			return 0f;
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x0002EAD0 File Offset: 0x0002CCD0
		[Token(Token = "0x600677F")]
		[Address(RVA = "0xB754B8", Offset = "0xB754B8", VA = "0xB754B8", Slot = "8")]
		internal override bool IsPlayerInCombatArea()
		{
			return default(bool);
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006780")]
		[Address(RVA = "0xB75534", Offset = "0xB75534", VA = "0xB75534")]
		public NebulaPillarBigProgressBar()
		{
		}
	}
}
