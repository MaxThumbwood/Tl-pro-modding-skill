using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DBF RID: 3519
	[Token(Token = "0x2000DBF")]
	public class VortexPillarBigProgressBar : LunarPillarBigProgessBar
	{
		// Token: 0x06006779 RID: 26489 RVA: 0x0002EA58 File Offset: 0x0002CC58
		[Token(Token = "0x6006779")]
		[Address(RVA = "0xB7528C", Offset = "0xB7528C", VA = "0xB7528C", Slot = "6")]
		internal override float GetCurrentShieldValue()
		{
			return 0f;
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x0002EA70 File Offset: 0x0002CC70
		[Token(Token = "0x600677A")]
		[Address(RVA = "0xB752F8", Offset = "0xB752F8", VA = "0xB752F8", Slot = "7")]
		internal override float GetMaxShieldValue()
		{
			return 0f;
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x0002EA88 File Offset: 0x0002CC88
		[Token(Token = "0x600677B")]
		[Address(RVA = "0xB75364", Offset = "0xB75364", VA = "0xB75364", Slot = "8")]
		internal override bool IsPlayerInCombatArea()
		{
			return default(bool);
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600677C")]
		[Address(RVA = "0xB7073C", Offset = "0xB7073C", VA = "0xB7073C")]
		public VortexPillarBigProgressBar()
		{
		}
	}
}
