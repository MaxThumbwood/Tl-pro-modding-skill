using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.IO
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	public class NPCInfo_OldMobile
	{
		// Token: 0x06003FEB RID: 16363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x1E8E3D8", Offset = "0x1E8E3D8", VA = "0x1E8E3D8")]
		public void LoadNPCEntries(BinaryReader reader, int release)
		{
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x1E8E64C", Offset = "0x1E8E64C", VA = "0x1E8E64C")]
		public void ReadNPCNames(BinaryReader reader, int release)
		{
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x0001F680 File Offset: 0x0001D880
		[Token(Token = "0x6003FED")]
		[Address(RVA = "0x1E8E91C", Offset = "0x1E8E91C", VA = "0x1E8E91C")]
		public bool Load(BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x0001F698 File Offset: 0x0001D898
		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0x1E8EEF4", Offset = "0x1E8EEF4", VA = "0x1E8EEF4")]
		public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEF")]
		[Address(RVA = "0x1E8F1E0", Offset = "0x1E8F1E0", VA = "0x1E8F1E0")]
		public NPCInfo_OldMobile()
		{
		}

		// Token: 0x04004B46 RID: 19270
		[Token(Token = "0x4004B46")]
		[FieldOffset(Offset = "0x8")]
		private bool downedAnyBoss;

		// Token: 0x04004B47 RID: 19271
		[Token(Token = "0x4004B47")]
		[FieldOffset(Offset = "0x9")]
		private bool downedRabbit;

		// Token: 0x04004B48 RID: 19272
		[Token(Token = "0x4004B48")]
		[FieldOffset(Offset = "0xA")]
		private bool downedTurkor;

		// Token: 0x04004B49 RID: 19273
		[Token(Token = "0x4004B49")]
		[FieldOffset(Offset = "0xC")]
		private List<NPCInfo_OldMobile.NPCEntry> npcEntries;

		// Token: 0x0200067C RID: 1660
		[Token(Token = "0x200067C")]
		public class NPCEntry
		{
			// Token: 0x06003FF0 RID: 16368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FF0")]
			[Address(RVA = "0x1E8F278", Offset = "0x1E8F278", VA = "0x1E8F278")]
			public NPCEntry()
			{
			}

			// Token: 0x04004B4A RID: 19274
			[Token(Token = "0x4004B4A")]
			[FieldOffset(Offset = "0x8")]
			public int npcId;

			// Token: 0x04004B4B RID: 19275
			[Token(Token = "0x4004B4B")]
			[FieldOffset(Offset = "0xC")]
			public int homeTileX;

			// Token: 0x04004B4C RID: 19276
			[Token(Token = "0x4004B4C")]
			[FieldOffset(Offset = "0x10")]
			public int homeTileY;

			// Token: 0x04004B4D RID: 19277
			[Token(Token = "0x4004B4D")]
			[FieldOffset(Offset = "0x14")]
			public bool homeless;

			// Token: 0x04004B4E RID: 19278
			[Token(Token = "0x4004B4E")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 position;
		}
	}
}
