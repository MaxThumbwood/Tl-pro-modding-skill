using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation.Dungeon.Features;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B36 RID: 2870
	[Token(Token = "0x2000B36")]
	public class BiomeRuggedDungeonRoom : BiomeDungeonRoom
	{
		// Token: 0x0600590D RID: 22797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590D")]
		[Address(RVA = "0x8938DC", Offset = "0x8938DC", VA = "0x8938DC")]
		public BiomeRuggedDungeonRoom(DungeonRoomSettings settings)
		{
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590E")]
		[Address(RVA = "0x893984", Offset = "0x893984", VA = "0x893984", Slot = "10")]
		public override void CalculateRoom(DungeonData data)
		{
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x00029940 File Offset: 0x00027B40
		[Token(Token = "0x600590F")]
		[Address(RVA = "0x894F4C", Offset = "0x894F4C", VA = "0x894F4C", Slot = "13")]
		public override bool GenerateRoom(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x00029958 File Offset: 0x00027B58
		[Token(Token = "0x6005910")]
		[Address(RVA = "0x894FB4", Offset = "0x894FB4", VA = "0x894FB4", Slot = "4")]
		public override bool CanGenerateFeatureAt(DungeonData data, IDungeonFeature feature, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005911")]
		[Address(RVA = "0x8950AC", Offset = "0x8950AC", VA = "0x8950AC", Slot = "6")]
		public override void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
		{
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005912")]
		[Address(RVA = "0x8939E8", Offset = "0x8939E8", VA = "0x8939E8")]
		public void BiomeRoom(DungeonData data, int i, int j, bool generating)
		{
		}

		// Token: 0x04009AA4 RID: 39588
		[Token(Token = "0x4009AA4")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 Position;

		// Token: 0x04009AA5 RID: 39589
		[Token(Token = "0x4009AA5")]
		[FieldOffset(Offset = "0x28")]
		public int RoomInnerSize;

		// Token: 0x04009AA6 RID: 39590
		[Token(Token = "0x4009AA6")]
		[FieldOffset(Offset = "0x2C")]
		public int RoomOuterSize;

		// Token: 0x04009AA7 RID: 39591
		[Token(Token = "0x4009AA7")]
		[FieldOffset(Offset = "0x30")]
		public int WallDepth;
	}
}
