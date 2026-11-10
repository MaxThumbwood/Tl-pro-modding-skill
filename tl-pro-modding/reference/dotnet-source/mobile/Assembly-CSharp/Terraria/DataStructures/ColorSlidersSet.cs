using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x0200074F RID: 1871
	[Token(Token = "0x200074F")]
	public class ColorSlidersSet
	{
		// Token: 0x060042A2 RID: 17058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A2")]
		[Address(RVA = "0x4F8758", Offset = "0x4F8758", VA = "0x4F8758")]
		public void SetHSL(Color color)
		{
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A3")]
		[Address(RVA = "0x4F87DC", Offset = "0x4F87DC", VA = "0x4F87DC")]
		public void SetHSL(Vector3 vector)
		{
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x00020448 File Offset: 0x0001E648
		[Token(Token = "0x60042A4")]
		[Address(RVA = "0x4F87E8", Offset = "0x4F87E8", VA = "0x4F87E8")]
		public Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x00020460 File Offset: 0x0001E660
		[Token(Token = "0x60042A5")]
		[Address(RVA = "0x4F88AC", Offset = "0x4F88AC", VA = "0x4F88AC")]
		public Vector3 GetHSLVector()
		{
			return default(Vector3);
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A6")]
		[Address(RVA = "0x4F88E4", Offset = "0x4F88E4", VA = "0x4F88E4")]
		public void ApplyToMainLegacyBars()
		{
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A7")]
		[Address(RVA = "0x4F897C", Offset = "0x4F897C", VA = "0x4F897C")]
		public ColorSlidersSet()
		{
		}

		// Token: 0x04008A26 RID: 35366
		[Token(Token = "0x4008A26")]
		[FieldOffset(Offset = "0x8")]
		public float Hue;

		// Token: 0x04008A27 RID: 35367
		[Token(Token = "0x4008A27")]
		[FieldOffset(Offset = "0xC")]
		public float Saturation;

		// Token: 0x04008A28 RID: 35368
		[Token(Token = "0x4008A28")]
		[FieldOffset(Offset = "0x10")]
		public float Luminance;

		// Token: 0x04008A29 RID: 35369
		[Token(Token = "0x4008A29")]
		[FieldOffset(Offset = "0x14")]
		public float Alpha;
	}
}
