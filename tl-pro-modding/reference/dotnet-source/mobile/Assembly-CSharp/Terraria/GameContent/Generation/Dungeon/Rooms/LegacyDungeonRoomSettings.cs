using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B41 RID: 2881
	[Token(Token = "0x2000B41")]
	public class LegacyDungeonRoomSettings : StepBasedDungeonRoomSettings
	{
		// Token: 0x06005949 RID: 22857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005949")]
		[Address(RVA = "0x89CD34", Offset = "0x89CD34", VA = "0x89CD34")]
		public LegacyDungeonRoomSettings()
		{
		}

		// Token: 0x04009AED RID: 39661
		[Token(Token = "0x4009AED")]
		[FieldOffset(Offset = "0x88")]
		public bool IsEntranceRoom;
	}
}
