using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B66 RID: 2918
	[Token(Token = "0x2000B66")]
	public abstract class DungeonFeature : FileAPI
	{
		// Token: 0x060059D5 RID: 22997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D5")]
		[Address(RVA = "0x8B9018", Offset = "0x8B9018", VA = "0x8B9018")]
		public DungeonFeature(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059D6 RID: 22998
		[Token(Token = "0x60059D6")]
		public abstract bool GenerateFeature(DungeonData data, int x, int y);

		// Token: 0x060059D7 RID: 22999 RVA: 0x0002A0D8 File Offset: 0x000282D8
		[Token(Token = "0x60059D7")]
		[Address(RVA = "0x8BD9EC", Offset = "0x8BD9EC", VA = "0x8BD9EC", Slot = "5")]
		public virtual bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x04009B59 RID: 39769
		[Token(Token = "0x4009B59")]
		[FieldOffset(Offset = "0x8")]
		public DungeonFeatureSettings settings;

		// Token: 0x04009B5A RID: 39770
		[Token(Token = "0x4009B5A")]
		[FieldOffset(Offset = "0xC")]
		public DungeonBounds Bounds;

		// Token: 0x04009B5B RID: 39771
		[Token(Token = "0x4009B5B")]
		[FieldOffset(Offset = "0x10")]
		public bool generated;
	}
}
