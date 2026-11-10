using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B37 RID: 2871
	[Token(Token = "0x2000B37")]
	public class BiomeSquareDungeonRoom : BiomeDungeonRoom
	{
		// Token: 0x06005913 RID: 22803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005913")]
		[Address(RVA = "0x895410", Offset = "0x895410", VA = "0x895410")]
		public BiomeSquareDungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005914")]
		[Address(RVA = "0x895414", Offset = "0x895414", VA = "0x895414", Slot = "10")]
		public override void CalculateRoom(DungeonData data)
		{
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x00029970 File Offset: 0x00027B70
		[Token(Token = "0x6005915")]
		[Address(RVA = "0x8963F8", Offset = "0x8963F8", VA = "0x8963F8", Slot = "13")]
		public override bool GenerateRoom(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005916")]
		[Address(RVA = "0x895478", Offset = "0x895478", VA = "0x895478")]
		public void BiomeRoom(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x04009AA8 RID: 39592
		[Token(Token = "0x4009AA8")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 Position;

		// Token: 0x04009AA9 RID: 39593
		[Token(Token = "0x4009AA9")]
		[FieldOffset(Offset = "0x28")]
		public int RoomInnerSize;

		// Token: 0x04009AAA RID: 39594
		[Token(Token = "0x4009AAA")]
		[FieldOffset(Offset = "0x2C")]
		public int RoomOuterSize;

		// Token: 0x04009AAB RID: 39595
		[Token(Token = "0x4009AAB")]
		[FieldOffset(Offset = "0x30")]
		public int WallDepth;
	}
}
