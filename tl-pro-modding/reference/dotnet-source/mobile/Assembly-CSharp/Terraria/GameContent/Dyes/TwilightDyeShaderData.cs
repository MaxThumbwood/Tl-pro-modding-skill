using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x02000A09 RID: 2569
	[Token(Token = "0x2000A09")]
	public class TwilightDyeShaderData : ArmorShaderData
	{
		// Token: 0x060053A1 RID: 21409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A1")]
		[Address(RVA = "0x802790", Offset = "0x802790", VA = "0x802790")]
		public TwilightDyeShaderData(Asset<Effect> shader, string passName)
		{
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A2")]
		[Address(RVA = "0x802798", Offset = "0x802798", VA = "0x802798", Slot = "4")]
		public override void Apply(Entity entity, DrawData? drawData)
		{
		}
	}
}
