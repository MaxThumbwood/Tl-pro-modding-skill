using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x02000982 RID: 2434
	[Token(Token = "0x2000982")]
	public class TreePaintingSettings
	{
		// Token: 0x0600505E RID: 20574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505E")]
		[Address(RVA = "0x769CE0", Offset = "0x769CE0", VA = "0x769CE0")]
		public TreePaintingSettings()
		{
		}

		// Token: 0x04009436 RID: 37942
		[Token(Token = "0x4009436")]
		[FieldOffset(Offset = "0x8")]
		public TreePaintingSettings.TreePaintingSettingsId Id;

		// Token: 0x04009437 RID: 37943
		[Token(Token = "0x4009437")]
		[FieldOffset(Offset = "0xC")]
		public float SpecialGroupMinimalHueValue;

		// Token: 0x04009438 RID: 37944
		[Token(Token = "0x4009438")]
		[FieldOffset(Offset = "0x10")]
		public float SpecialGroupMaximumHueValue;

		// Token: 0x04009439 RID: 37945
		[Token(Token = "0x4009439")]
		[FieldOffset(Offset = "0x14")]
		public float SpecialGroupMinimumSaturationValue;

		// Token: 0x0400943A RID: 37946
		[Token(Token = "0x400943A")]
		[FieldOffset(Offset = "0x18")]
		public float SpecialGroupMaximumSaturationValue;

		// Token: 0x0400943B RID: 37947
		[Token(Token = "0x400943B")]
		[FieldOffset(Offset = "0x1C")]
		public float HueTestOffset;

		// Token: 0x0400943C RID: 37948
		[Token(Token = "0x400943C")]
		[FieldOffset(Offset = "0x20")]
		public bool UseSpecialGroups;

		// Token: 0x0400943D RID: 37949
		[Token(Token = "0x400943D")]
		[FieldOffset(Offset = "0x21")]
		public bool UseWallShaderHacks;

		// Token: 0x0400943E RID: 37950
		[Token(Token = "0x400943E")]
		[FieldOffset(Offset = "0x22")]
		public bool InvertSpecialGroupResult;

		// Token: 0x02000983 RID: 2435
		[Token(Token = "0x2000983")]
		public enum TreePaintingSettingsId
		{
			// Token: 0x04009440 RID: 37952
			[Token(Token = "0x4009440")]
			None,
			// Token: 0x04009441 RID: 37953
			[Token(Token = "0x4009441")]
			DefaultDirt,
			// Token: 0x04009442 RID: 37954
			[Token(Token = "0x4009442")]
			CullMud,
			// Token: 0x04009443 RID: 37955
			[Token(Token = "0x4009443")]
			WoodPurity,
			// Token: 0x04009444 RID: 37956
			[Token(Token = "0x4009444")]
			WoodCorruption,
			// Token: 0x04009445 RID: 37957
			[Token(Token = "0x4009445")]
			WoodJungle,
			// Token: 0x04009446 RID: 37958
			[Token(Token = "0x4009446")]
			WoodHallow,
			// Token: 0x04009447 RID: 37959
			[Token(Token = "0x4009447")]
			WoodSnow,
			// Token: 0x04009448 RID: 37960
			[Token(Token = "0x4009448")]
			WoodCrimson,
			// Token: 0x04009449 RID: 37961
			[Token(Token = "0x4009449")]
			WoodJungleUnderground,
			// Token: 0x0400944A RID: 37962
			[Token(Token = "0x400944A")]
			WoodGlowingMushroom,
			// Token: 0x0400944B RID: 37963
			[Token(Token = "0x400944B")]
			VanityCherry,
			// Token: 0x0400944C RID: 37964
			[Token(Token = "0x400944C")]
			VanityYellowWillow,
			// Token: 0x0400944D RID: 37965
			[Token(Token = "0x400944D")]
			GemTree,
			// Token: 0x0400944E RID: 37966
			[Token(Token = "0x400944E")]
			PalmTreePurity,
			// Token: 0x0400944F RID: 37967
			[Token(Token = "0x400944F")]
			PalmTreeCorruption,
			// Token: 0x04009450 RID: 37968
			[Token(Token = "0x4009450")]
			PalmTreeCrimson,
			// Token: 0x04009451 RID: 37969
			[Token(Token = "0x4009451")]
			PalmTreeHallow,
			// Token: 0x04009452 RID: 37970
			[Token(Token = "0x4009452")]
			Count
		}
	}
}
