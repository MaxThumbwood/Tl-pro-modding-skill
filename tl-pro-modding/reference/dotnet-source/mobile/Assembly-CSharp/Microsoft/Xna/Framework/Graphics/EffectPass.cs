using System;
using Il2CppDummyDll;
using Terraria.Graphics.Shaders;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003DB RID: 987
	[Token(Token = "0x20003DB")]
	public class EffectPass
	{
		// Token: 0x06001AE4 RID: 6884 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0xE46654", Offset = "0xE46654", VA = "0xE46654")]
		private static int GetNextBatchIndex()
		{
			return 0;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0xE466AC", Offset = "0xE466AC", VA = "0xE466AC")]
		public EffectPass(Effect effect, int passindex, string name, Material material)
		{
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0xE46734", Offset = "0xE46734", VA = "0xE46734")]
		public EffectPass(Effect effect, EffectPass existing)
		{
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0xE46850", Offset = "0xE46850", VA = "0xE46850")]
		public EffectPass(EffectPass existing, ShaderData armourData)
		{
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0xE46980", Offset = "0xE46980", VA = "0xE46980")]
		public void ApplyValuesToMaterial(Material material)
		{
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0xE46A9C", Offset = "0xE46A9C", VA = "0xE46A9C")]
		public void SetRegion(Vector4 sourceRect, Texture2D texture)
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0xE46D84", Offset = "0xE46D84", VA = "0xE46D84")]
		public void Apply()
		{
		}

		// Token: 0x04002E2C RID: 11820
		[Token(Token = "0x4002E2C")]
		[FieldOffset(Offset = "0x0")]
		public static EffectPass BoundEffect;

		// Token: 0x04002E2D RID: 11821
		[Token(Token = "0x4002E2D")]
		[FieldOffset(Offset = "0x8")]
		public readonly int PassIndex;

		// Token: 0x04002E2E RID: 11822
		[Token(Token = "0x4002E2E")]
		[FieldOffset(Offset = "0xC")]
		public readonly string Name;

		// Token: 0x04002E2F RID: 11823
		[Token(Token = "0x4002E2F")]
		[FieldOffset(Offset = "0x10")]
		public readonly Effect _effect;

		// Token: 0x04002E30 RID: 11824
		[Token(Token = "0x4002E30")]
		[FieldOffset(Offset = "0x14")]
		public readonly Material _material;

		// Token: 0x04002E31 RID: 11825
		[Token(Token = "0x4002E31")]
		[FieldOffset(Offset = "0x18")]
		public readonly int BatchIndex;

		// Token: 0x04002E32 RID: 11826
		[Token(Token = "0x4002E32")]
		[FieldOffset(Offset = "0x1C")]
		public readonly ShaderData _armour;

		// Token: 0x04002E33 RID: 11827
		[Token(Token = "0x4002E33")]
		[FieldOffset(Offset = "0x4")]
		private static int NextBatchIndex;
	}
}
