using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000A0B RID: 2571
	[Token(Token = "0x2000A0B")]
	public class BlizzardShaderData : ScreenShaderData
	{
		// Token: 0x060053A5 RID: 21413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A5")]
		[Address(RVA = "0x802C24", Offset = "0x802C24", VA = "0x802C24")]
		public BlizzardShaderData(string passName)
		{
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A6")]
		[Address(RVA = "0x802CFC", Offset = "0x802CFC", VA = "0x802CFC", Slot = "6")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A7")]
		[Address(RVA = "0x803070", Offset = "0x803070", VA = "0x803070", Slot = "5")]
		public override void Apply()
		{
		}

		// Token: 0x04009765 RID: 38757
		[Token(Token = "0x4009765")]
		[FieldOffset(Offset = "0x64")]
		private Vector2 _texturePosition;

		// Token: 0x04009766 RID: 38758
		[Token(Token = "0x4009766")]
		[FieldOffset(Offset = "0x6C")]
		private float windSpeed;
	}
}
