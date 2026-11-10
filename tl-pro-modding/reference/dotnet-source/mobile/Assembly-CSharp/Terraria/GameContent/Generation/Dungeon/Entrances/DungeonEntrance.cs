using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation.Dungeon.Features;

namespace Terraria.GameContent.Generation.Dungeon.Entrances
{
	// Token: 0x02000B88 RID: 2952
	[Token(Token = "0x2000B88")]
	public abstract class DungeonEntrance
	{
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x0002A4E0 File Offset: 0x000286E0
		[Token(Token = "0x17000A03")]
		public bool Processed
		{
			[Token(Token = "0x6005A40")]
			[Address(RVA = "0x8F805C", Offset = "0x8F805C", VA = "0x8F805C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A41")]
		[Address(RVA = "0x8F3434", Offset = "0x8F3434", VA = "0x8F3434")]
		public DungeonEntrance(DungeonEntranceSettings settings)
		{
		}

		// Token: 0x06005A42 RID: 23106
		[Token(Token = "0x6005A42")]
		public abstract void CalculateEntrance(DungeonData data, int x, int y);

		// Token: 0x06005A43 RID: 23107
		[Token(Token = "0x6005A43")]
		public abstract bool GenerateEntrance(DungeonData data, int x, int y);

		// Token: 0x06005A44 RID: 23108 RVA: 0x0002A4F8 File Offset: 0x000286F8
		[Token(Token = "0x6005A44")]
		[Address(RVA = "0x8F760C", Offset = "0x8F760C", VA = "0x8F760C", Slot = "6")]
		public virtual bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x04009B97 RID: 39831
		[Token(Token = "0x4009B97")]
		[FieldOffset(Offset = "0x8")]
		public DungeonEntranceSettings settings;

		// Token: 0x04009B98 RID: 39832
		[Token(Token = "0x4009B98")]
		[FieldOffset(Offset = "0xC")]
		public bool calculated;

		// Token: 0x04009B99 RID: 39833
		[Token(Token = "0x4009B99")]
		[FieldOffset(Offset = "0xD")]
		public bool generated;

		// Token: 0x04009B9A RID: 39834
		[Token(Token = "0x4009B9A")]
		[FieldOffset(Offset = "0x10")]
		public DungeonBounds Bounds;

		// Token: 0x04009B9B RID: 39835
		[Token(Token = "0x4009B9B")]
		[FieldOffset(Offset = "0x14")]
		public Point OldManSpawn;
	}
}
