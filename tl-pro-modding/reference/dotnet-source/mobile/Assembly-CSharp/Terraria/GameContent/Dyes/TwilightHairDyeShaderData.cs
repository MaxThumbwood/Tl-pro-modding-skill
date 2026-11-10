using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x02000A0A RID: 2570
	[Token(Token = "0x2000A0A")]
	public class TwilightHairDyeShaderData : HairShaderData
	{
		// Token: 0x060053A3 RID: 21411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A3")]
		[Address(RVA = "0x802A40", Offset = "0x802A40", VA = "0x802A40")]
		public TwilightHairDyeShaderData(Asset<Effect> shader, string passName)
		{
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A4")]
		[Address(RVA = "0x802A48", Offset = "0x802A48", VA = "0x802A48", Slot = "6")]
		public override void Apply(Player player, [Optional] DrawData? drawData)
		{
		}
	}
}
