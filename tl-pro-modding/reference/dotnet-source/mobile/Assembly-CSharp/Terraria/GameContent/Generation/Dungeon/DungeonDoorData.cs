using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B1A RID: 2842
	[Token(Token = "0x2000B1A")]
	public struct DungeonDoorData
	{
		// Token: 0x040099B6 RID: 39350
		[Token(Token = "0x40099B6")]
		[FieldOffset(Offset = "0x0")]
		public Point Position;

		// Token: 0x040099B7 RID: 39351
		[Token(Token = "0x40099B7")]
		[FieldOffset(Offset = "0x8")]
		public DungeonGenerationStyleData OverrideGenerationStyle;

		// Token: 0x040099B8 RID: 39352
		[Token(Token = "0x40099B8")]
		[FieldOffset(Offset = "0xC")]
		public int? OverrideStyle;

		// Token: 0x040099B9 RID: 39353
		[Token(Token = "0x40099B9")]
		[FieldOffset(Offset = "0x14")]
		public int Direction;

		// Token: 0x040099BA RID: 39354
		[Token(Token = "0x40099BA")]
		[FieldOffset(Offset = "0x18")]
		public bool InAHallway;

		// Token: 0x040099BB RID: 39355
		[Token(Token = "0x40099BB")]
		[FieldOffset(Offset = "0x1C")]
		public int? OverrideWidthFluff;

		// Token: 0x040099BC RID: 39356
		[Token(Token = "0x40099BC")]
		[FieldOffset(Offset = "0x24")]
		public bool SkipOtherDoorsCheck;

		// Token: 0x040099BD RID: 39357
		[Token(Token = "0x40099BD")]
		[FieldOffset(Offset = "0x25")]
		public bool SkipSpaceCheck;

		// Token: 0x040099BE RID: 39358
		[Token(Token = "0x40099BE")]
		[FieldOffset(Offset = "0x26")]
		public bool AlwaysClearArea;
	}
}
