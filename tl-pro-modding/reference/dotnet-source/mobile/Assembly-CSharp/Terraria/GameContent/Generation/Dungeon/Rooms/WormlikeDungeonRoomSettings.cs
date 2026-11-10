using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B47 RID: 2887
	[Token(Token = "0x2000B47")]
	public class WormlikeDungeonRoomSettings : DungeonRoomSettings
	{
		// Token: 0x06005966 RID: 22886 RVA: 0x00029D48 File Offset: 0x00027F48
		[Token(Token = "0x6005966")]
		[Address(RVA = "0x8A1490", Offset = "0x8A1490", VA = "0x8A1490", Slot = "4")]
		public override int GetBoundingRadius()
		{
			return 0;
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005967")]
		[Address(RVA = "0x8A14F0", Offset = "0x8A14F0", VA = "0x8A14F0")]
		public WormlikeDungeonRoomSettings()
		{
		}

		// Token: 0x04009AFF RID: 39679
		[Token(Token = "0x4009AFF")]
		[FieldOffset(Offset = "0x44")]
		public int FirstSideIterations;

		// Token: 0x04009B00 RID: 39680
		[Token(Token = "0x4009B00")]
		[FieldOffset(Offset = "0x48")]
		public int SecondSideIterations;
	}
}
