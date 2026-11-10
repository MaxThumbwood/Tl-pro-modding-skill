using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DBE RID: 3518
	[Token(Token = "0x2000DBE")]
	public class SolarFlarePillarBigProgressBar : LunarPillarBigProgessBar
	{
		// Token: 0x06006775 RID: 26485 RVA: 0x0002EA10 File Offset: 0x0002CC10
		[Token(Token = "0x6006775")]
		[Address(RVA = "0xB75138", Offset = "0xB75138", VA = "0xB75138", Slot = "6")]
		internal override float GetCurrentShieldValue()
		{
			return 0f;
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x0002EA28 File Offset: 0x0002CC28
		[Token(Token = "0x6006776")]
		[Address(RVA = "0xB751A4", Offset = "0xB751A4", VA = "0xB751A4", Slot = "7")]
		internal override float GetMaxShieldValue()
		{
			return 0f;
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x0002EA40 File Offset: 0x0002CC40
		[Token(Token = "0x6006777")]
		[Address(RVA = "0xB75210", Offset = "0xB75210", VA = "0xB75210", Slot = "8")]
		internal override bool IsPlayerInCombatArea()
		{
			return default(bool);
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006778")]
		[Address(RVA = "0xB70734", Offset = "0xB70734", VA = "0xB70734")]
		public SolarFlarePillarBigProgressBar()
		{
		}
	}
}
