using System;
using Il2CppDummyDll;
using Terraria.GameContent.Generation.Dungeon.Rooms;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B1C RID: 2844
	[Token(Token = "0x2000B1C")]
	public struct DungeonRoomSearchSettings
	{
		// Token: 0x040099CD RID: 39373
		[Token(Token = "0x40099CD")]
		[FieldOffset(Offset = "0x0")]
		public int Fluff;

		// Token: 0x040099CE RID: 39374
		[Token(Token = "0x40099CE")]
		[FieldOffset(Offset = "0x4")]
		public DungeonRoom ExcludedRoom;

		// Token: 0x040099CF RID: 39375
		[Token(Token = "0x40099CF")]
		[FieldOffset(Offset = "0x8")]
		public ProgressionStageCheck ProgressionStageCheck;

		// Token: 0x040099D0 RID: 39376
		[Token(Token = "0x40099D0")]
		[FieldOffset(Offset = "0xC")]
		public int? ProgressionStage;

		// Token: 0x040099D1 RID: 39377
		[Token(Token = "0x40099D1")]
		[FieldOffset(Offset = "0x14")]
		public int? MaximumDistance;

		// Token: 0x040099D2 RID: 39378
		[Token(Token = "0x40099D2")]
		[FieldOffset(Offset = "0x1C")]
		public bool UseOuterBounds;
	}
}
