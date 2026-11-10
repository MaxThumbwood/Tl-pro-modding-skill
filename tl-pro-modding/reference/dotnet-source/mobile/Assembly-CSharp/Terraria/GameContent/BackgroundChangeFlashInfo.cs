using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x020009E8 RID: 2536
	[Token(Token = "0x20009E8")]
	public class BackgroundChangeFlashInfo
	{
		// Token: 0x060052A8 RID: 21160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A8")]
		[Address(RVA = "0x7E27B0", Offset = "0x7E27B0", VA = "0x7E27B0")]
		public void UpdateCache()
		{
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A9")]
		[Address(RVA = "0x7E2944", Offset = "0x7E2944", VA = "0x7E2944")]
		private void UpdateVariation(int areaId, int newVariationValue)
		{
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AA")]
		[Address(RVA = "0x7E2A10", Offset = "0x7E2A10", VA = "0x7E2A10")]
		private void ValueChanged(int areaId)
		{
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AB")]
		[Address(RVA = "0x7E2A9C", Offset = "0x7E2A9C", VA = "0x7E2A9C")]
		public void UpdateFlashValues()
		{
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x00026808 File Offset: 0x00024A08
		[Token(Token = "0x60052AC")]
		[Address(RVA = "0x7E2B30", Offset = "0x7E2B30", VA = "0x7E2B30")]
		public float GetFlashPower(int areaId)
		{
			return 0f;
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AD")]
		[Address(RVA = "0x7E2B54", Offset = "0x7E2B54", VA = "0x7E2B54")]
		public BackgroundChangeFlashInfo()
		{
		}

		// Token: 0x040096EF RID: 38639
		[Token(Token = "0x40096EF")]
		[FieldOffset(Offset = "0x8")]
		private int[] _variations;

		// Token: 0x040096F0 RID: 38640
		[Token(Token = "0x40096F0")]
		[FieldOffset(Offset = "0xC")]
		private float[] _flashPower;
	}
}
