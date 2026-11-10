using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B46 RID: 2886
	[Token(Token = "0x2000B46")]
	public class RegularDungeonRoom : DungeonRoom
	{
		// Token: 0x06005962 RID: 22882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005962")]
		[Address(RVA = "0x8A106C", Offset = "0x8A106C", VA = "0x8A106C")]
		public RegularDungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005963")]
		[Address(RVA = "0x8A1070", Offset = "0x8A1070", VA = "0x8A1070", Slot = "10")]
		public override void CalculateRoom(DungeonData data)
		{
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x00029D30 File Offset: 0x00027F30
		[Token(Token = "0x6005964")]
		[Address(RVA = "0x8A1428", Offset = "0x8A1428", VA = "0x8A1428", Slot = "13")]
		public override bool GenerateRoom(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005965")]
		[Address(RVA = "0x8A10D4", Offset = "0x8A10D4", VA = "0x8A10D4")]
		public void RegularRoom(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x04009AFE RID: 39678
		[Token(Token = "0x4009AFE")]
		[FieldOffset(Offset = "0x18")]
		public int _innerBoundsSize;
	}
}
