using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000A0F RID: 2575
	[Token(Token = "0x2000A0F")]
	public class SepiaScreenShaderData : ScreenShaderData
	{
		// Token: 0x060053B1 RID: 21425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B1")]
		[Address(RVA = "0x8040A0", Offset = "0x8040A0", VA = "0x8040A0")]
		public SepiaScreenShaderData(string passName)
		{
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B2")]
		[Address(RVA = "0x8040A8", Offset = "0x8040A8", VA = "0x8040A8", Slot = "6")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B3")]
		[Address(RVA = "0x804670", Offset = "0x804670", VA = "0x804670")]
		private static void GetDaylightPowers(out float nightlightPower, out float daylightPower, out float moonPower, out float dawnPower)
		{
		}
	}
}
