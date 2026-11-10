using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x02000A08 RID: 2568
	[Token(Token = "0x2000A08")]
	public class TeamArmorShaderData : ArmorShaderData
	{
		// Token: 0x0600539E RID: 21406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539E")]
		[Address(RVA = "0x80209C", Offset = "0x80209C", VA = "0x80209C")]
		public TeamArmorShaderData(Asset<Effect> shader, string passName)
		{
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539F")]
		[Address(RVA = "0x802358", Offset = "0x802358", VA = "0x802358", Slot = "4")]
		public override void Apply(Entity entity, DrawData? drawData)
		{
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A0")]
		[Address(RVA = "0x8026D0", Offset = "0x8026D0", VA = "0x8026D0", Slot = "6")]
		public override ArmorShaderData GetSecondaryShader(Entity entity)
		{
			return null;
		}

		// Token: 0x04009763 RID: 38755
		[Token(Token = "0x4009763")]
		[FieldOffset(Offset = "0x0")]
		private static bool isInitialized;

		// Token: 0x04009764 RID: 38756
		[Token(Token = "0x4009764")]
		[FieldOffset(Offset = "0x4")]
		private static ArmorShaderData[] dustShaderData;
	}
}
