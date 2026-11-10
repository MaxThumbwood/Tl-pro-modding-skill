using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x02000A05 RID: 2565
	[Token(Token = "0x2000A05")]
	public class LegacyHairShaderData : HairShaderData
	{
		// Token: 0x06005395 RID: 21397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005395")]
		[Address(RVA = "0x801448", Offset = "0x801448", VA = "0x801448")]
		public LegacyHairShaderData()
		{
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00026E98 File Offset: 0x00025098
		[Token(Token = "0x6005396")]
		[Address(RVA = "0x80146C", Offset = "0x80146C", VA = "0x80146C", Slot = "7")]
		public override Color GetColor(Player player, Color lightColor)
		{
			return default(Color);
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005397")]
		[Address(RVA = "0x8015EC", Offset = "0x8015EC", VA = "0x8015EC")]
		public LegacyHairShaderData UseLegacyMethod(LegacyHairShaderData.ColorProcessingMethod colorProcessor)
		{
			return null;
		}

		// Token: 0x0400975F RID: 38751
		[Token(Token = "0x400975F")]
		[FieldOffset(Offset = "0x44")]
		private LegacyHairShaderData.ColorProcessingMethod _colorProcessor;

		// Token: 0x02000A06 RID: 2566
		// (Invoke) Token: 0x06005399 RID: 21401
		[Token(Token = "0x2000A06")]
		public delegate Color ColorProcessingMethod(Player player, Color color, ref bool lighting);
	}
}
