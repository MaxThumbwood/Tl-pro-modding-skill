using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B55 RID: 2901
	[Token(Token = "0x2000B55")]
	public abstract class StepBasedDungeonHallSettings : DungeonHallSettings
	{
		// Token: 0x060059A3 RID: 22947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A3")]
		[Address(RVA = "0x8ADD88", Offset = "0x8ADD88", VA = "0x8ADD88")]
		protected StepBasedDungeonHallSettings()
		{
		}

		// Token: 0x04009B32 RID: 39730
		[Token(Token = "0x4009B32")]
		[FieldOffset(Offset = "0x3C")]
		public int OverrideStrength;

		// Token: 0x04009B33 RID: 39731
		[Token(Token = "0x4009B33")]
		[FieldOffset(Offset = "0x40")]
		public int OverrideSteps;

		// Token: 0x04009B34 RID: 39732
		[Token(Token = "0x4009B34")]
		[FieldOffset(Offset = "0x44")]
		public bool ForceHorizontal;

		// Token: 0x04009B35 RID: 39733
		[Token(Token = "0x4009B35")]
		[FieldOffset(Offset = "0x48")]
		public double OverrideInteriorToExteriorRatio;
	}
}
