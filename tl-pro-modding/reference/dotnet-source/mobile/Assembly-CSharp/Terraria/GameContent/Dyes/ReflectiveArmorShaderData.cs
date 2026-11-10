using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x02000A07 RID: 2567
	[Token(Token = "0x2000A07")]
	public class ReflectiveArmorShaderData : ArmorShaderData
	{
		// Token: 0x0600539C RID: 21404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539C")]
		[Address(RVA = "0x80187C", Offset = "0x80187C", VA = "0x80187C")]
		public ReflectiveArmorShaderData(Asset<Effect> shader, string passName)
		{
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539D")]
		[Address(RVA = "0x801884", Offset = "0x801884", VA = "0x801884", Slot = "4")]
		public override void Apply(Entity entity, DrawData? drawData)
		{
		}

		// Token: 0x04009760 RID: 38752
		[Token(Token = "0x4009760")]
		[FieldOffset(Offset = "0x84")]
		private Entity prevEntity;

		// Token: 0x04009761 RID: 38753
		[Token(Token = "0x4009761")]
		[FieldOffset(Offset = "0x88")]
		private Vector2 prevPosition;

		// Token: 0x04009762 RID: 38754
		[Token(Token = "0x4009762")]
		[FieldOffset(Offset = "0x90")]
		private int prevFrame;
	}
}
