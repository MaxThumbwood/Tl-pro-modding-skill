using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000A0D RID: 2573
	[Token(Token = "0x2000A0D")]
	public class MoonLordScreenShaderData : ScreenShaderData
	{
		// Token: 0x060053AA RID: 21418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053AA")]
		[Address(RVA = "0x8032E4", Offset = "0x8032E4", VA = "0x8032E4")]
		public MoonLordScreenShaderData(string passName, bool aimAtPlayer)
		{
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053AB")]
		[Address(RVA = "0x803300", Offset = "0x803300", VA = "0x803300")]
		private void UpdateMoonLordIndex()
		{
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053AC")]
		[Address(RVA = "0x803A40", Offset = "0x803A40", VA = "0x803A40", Slot = "5")]
		public override void Apply()
		{
		}

		// Token: 0x04009767 RID: 38759
		[Token(Token = "0x4009767")]
		[FieldOffset(Offset = "0x64")]
		private bool _aimAtPlayer;

		// Token: 0x04009768 RID: 38760
		[Token(Token = "0x4009768")]
		[FieldOffset(Offset = "0x0")]
		public static float LatestFilterStrength;

		// Token: 0x04009769 RID: 38761
		[Token(Token = "0x4009769")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 _targetPositionInWorld;
	}
}
