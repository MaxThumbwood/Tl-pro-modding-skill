using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B5B RID: 2907
	[Token(Token = "0x2000B5B")]
	public class RegularDungeonHallSettings : DungeonHallSettings
	{
		// Token: 0x060059BA RID: 22970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BA")]
		[Address(RVA = "0x8B5994", Offset = "0x8B5994", VA = "0x8B5994")]
		public RegularDungeonHallSettings()
		{
		}

		// Token: 0x04009B46 RID: 39750
		[Token(Token = "0x4009B46")]
		[FieldOffset(Offset = "0x3C")]
		public int OverrideInnerBoundsSize;

		// Token: 0x04009B47 RID: 39751
		[Token(Token = "0x4009B47")]
		[FieldOffset(Offset = "0x40")]
		public int OverrideOuterBoundsSize;
	}
}
