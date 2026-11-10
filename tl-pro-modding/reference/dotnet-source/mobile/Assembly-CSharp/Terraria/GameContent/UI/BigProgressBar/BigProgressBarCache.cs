using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DBB RID: 3515
	[Token(Token = "0x2000DBB")]
	public struct BigProgressBarCache
	{
		// Token: 0x0600676A RID: 26474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676A")]
		[Address(RVA = "0xB72EC8", Offset = "0xB72EC8", VA = "0xB72EC8")]
		public void SetLife(float current, float max)
		{
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676B")]
		[Address(RVA = "0xB74A30", Offset = "0xB74A30", VA = "0xB74A30")]
		public void SetShield(float current, float max)
		{
		}

		// Token: 0x0400A458 RID: 42072
		[Token(Token = "0x400A458")]
		[FieldOffset(Offset = "0x0")]
		public float LifeCurrent;

		// Token: 0x0400A459 RID: 42073
		[Token(Token = "0x400A459")]
		[FieldOffset(Offset = "0x4")]
		public float LifeMax;

		// Token: 0x0400A45A RID: 42074
		[Token(Token = "0x400A45A")]
		[FieldOffset(Offset = "0x8")]
		public float ShieldCurrent;

		// Token: 0x0400A45B RID: 42075
		[Token(Token = "0x400A45B")]
		[FieldOffset(Offset = "0xC")]
		public float ShieldMax;
	}
}
