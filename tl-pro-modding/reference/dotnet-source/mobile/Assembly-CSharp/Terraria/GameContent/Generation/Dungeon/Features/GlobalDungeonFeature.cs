using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B67 RID: 2919
	[Token(Token = "0x2000B67")]
	public abstract class GlobalDungeonFeature : FileAPI
	{
		// Token: 0x060059D8 RID: 23000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D8")]
		[Address(RVA = "0x8BD9F4", Offset = "0x8BD9F4", VA = "0x8BD9F4")]
		public GlobalDungeonFeature(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059D9 RID: 23001
		[Token(Token = "0x60059D9")]
		public abstract bool GenerateFeature(DungeonData data);

		// Token: 0x04009B5C RID: 39772
		[Token(Token = "0x4009B5C")]
		[FieldOffset(Offset = "0x8")]
		public DungeonFeatureSettings settings;

		// Token: 0x04009B5D RID: 39773
		[Token(Token = "0x4009B5D")]
		[FieldOffset(Offset = "0xC")]
		public bool generated;
	}
}
