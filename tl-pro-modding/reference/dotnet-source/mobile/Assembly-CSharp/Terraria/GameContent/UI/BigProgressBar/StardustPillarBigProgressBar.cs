using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DC1 RID: 3521
	[Token(Token = "0x2000DC1")]
	public class StardustPillarBigProgressBar : LunarPillarBigProgessBar
	{
		// Token: 0x06006781 RID: 26497 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
		[Token(Token = "0x6006781")]
		[Address(RVA = "0xB7553C", Offset = "0xB7553C", VA = "0xB7553C", Slot = "6")]
		internal override float GetCurrentShieldValue()
		{
			return 0f;
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x0002EB00 File Offset: 0x0002CD00
		[Token(Token = "0x6006782")]
		[Address(RVA = "0xB755A8", Offset = "0xB755A8", VA = "0xB755A8", Slot = "7")]
		internal override float GetMaxShieldValue()
		{
			return 0f;
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x0002EB18 File Offset: 0x0002CD18
		[Token(Token = "0x6006783")]
		[Address(RVA = "0xB75614", Offset = "0xB75614", VA = "0xB75614", Slot = "8")]
		internal override bool IsPlayerInCombatArea()
		{
			return default(bool);
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006784")]
		[Address(RVA = "0xB75690", Offset = "0xB75690", VA = "0xB75690")]
		public StardustPillarBigProgressBar()
		{
		}
	}
}
