using System;
using Il2CppDummyDll;
using Terraria.GameContent.Generation.Dungeon.Rooms;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B79 RID: 2937
	[Token(Token = "0x2000B79")]
	public class DungeonPitTrapSettings : DungeonFeatureSettings
	{
		// Token: 0x06005A1A RID: 23066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0x8E7894", Offset = "0x8E7894", VA = "0x8E7894")]
		public DungeonPitTrapSettings()
		{
		}

		// Token: 0x04009B72 RID: 39794
		[Token(Token = "0x4009B72")]
		[FieldOffset(Offset = "0x8")]
		public DungeonGenerationStyleData Style;

		// Token: 0x04009B73 RID: 39795
		[Token(Token = "0x4009B73")]
		[FieldOffset(Offset = "0xC")]
		public int Width;

		// Token: 0x04009B74 RID: 39796
		[Token(Token = "0x4009B74")]
		[FieldOffset(Offset = "0x10")]
		public int Height;

		// Token: 0x04009B75 RID: 39797
		[Token(Token = "0x4009B75")]
		[FieldOffset(Offset = "0x14")]
		public int EdgeWidth;

		// Token: 0x04009B76 RID: 39798
		[Token(Token = "0x4009B76")]
		[FieldOffset(Offset = "0x18")]
		public int EdgeHeight;

		// Token: 0x04009B77 RID: 39799
		[Token(Token = "0x4009B77")]
		[FieldOffset(Offset = "0x1C")]
		public int TopDensity;

		// Token: 0x04009B78 RID: 39800
		[Token(Token = "0x4009B78")]
		[FieldOffset(Offset = "0x20")]
		public bool Flooded;

		// Token: 0x04009B79 RID: 39801
		[Token(Token = "0x4009B79")]
		[FieldOffset(Offset = "0x24")]
		public DungeonRoom ConnectedRoom;
	}
}
