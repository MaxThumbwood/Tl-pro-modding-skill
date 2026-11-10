using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation.Dungeon.Entrances;
using Terraria.GameContent.Generation.Dungeon.Halls;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B15 RID: 2837
	[Token(Token = "0x2000B15")]
	public static class DungeonCrawler
	{
		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06005847 RID: 22599 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005848 RID: 22600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009EB")]
		public static DungeonData CurrentDungeonData
		{
			[Token(Token = "0x6005847")]
			[Address(RVA = "0x868F5C", Offset = "0x868F5C", VA = "0x868F5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005848")]
			[Address(RVA = "0x86907C", Offset = "0x86907C", VA = "0x86907C")]
			set
			{
			}
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005849")]
		[Address(RVA = "0x8691A4", Offset = "0x8691A4", VA = "0x8691A4")]
		public static void SetupDungeonData(int currentDungeon, bool clearOld = false)
		{
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584A")]
		[Address(RVA = "0x869408", Offset = "0x869408", VA = "0x869408")]
		public static void SetupDungeonGenVarVariables(DungeonGenVars genVars, UnifiedRandom genRand)
		{
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584B")]
		[Address(RVA = "0x86ACD8", Offset = "0x86ACD8", VA = "0x86ACD8")]
		public static void SetupDungeonDataVariables(int iteration, UnifiedRandom genRand)
		{
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584C")]
		[Address(RVA = "0x86BFD8", Offset = "0x86BFD8", VA = "0x86BFD8")]
		public static void MakeDungeon(int x, int y, [Optional] GenerationProgress progress)
		{
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584D")]
		[Address(RVA = "0x86EE20", Offset = "0x86EE20", VA = "0x86EE20")]
		public static void MakeDungeon_GenerateNextEntranceHall_Legacy(DungeonData data, int x, int y)
		{
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584E")]
		[Address(RVA = "0x86E9F8", Offset = "0x86E9F8", VA = "0x86E9F8")]
		public static void MakeDungeon_GenerateNextEntranceHall_Precalculated(DungeonData data, UnifiedRandom genRand, double dist, Vector2D entrancePos, ref int amountPassed, ref Vector2D currentPos)
		{
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584F")]
		[Address(RVA = "0x86F5C8", Offset = "0x86F5C8", VA = "0x86F5C8")]
		public static DungeonRoomSettings MakeDungeon_GetRoomSettings(DungeonRoomType roomType, DungeonData data, DungeonControlLine line)
		{
			return null;
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005850")]
		[Address(RVA = "0x86E140", Offset = "0x86E140", VA = "0x86E140")]
		public static DungeonHallSettings MakeDungeon_GetHallSettings(DungeonHallType hallType, DungeonData data, Vector2 hallStart, Vector2 hallEnd, DungeonGenerationStyleData style)
		{
			return null;
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005851")]
		[Address(RVA = "0x86F088", Offset = "0x86F088", VA = "0x86F088")]
		public static DungeonEntranceSettings MakeDungeon_GetEntranceSettings(PreGenDungeonEntranceSettings preSettings, DungeonData data)
		{
			return null;
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005852")]
		[Address(RVA = "0x86A98C", Offset = "0x86A98C", VA = "0x86A98C")]
		public static DungeonEntranceSettings MakeDungeon_GetEntranceSettings(DungeonEntranceType entranceType, DungeonGenerationStyleData styleData, DungeonData data)
		{
			return null;
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005853")]
		[Address(RVA = "0x870714", Offset = "0x870714", VA = "0x870714")]
		public static DungeonRoom MakeDungeon_TryRoom(DungeonData data, int i, int j, DungeonRoomSettings roomSettings, bool addToData = true, int fluff = 0, bool noRoomOverlap = true)
		{
			return null;
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005854")]
		[Address(RVA = "0x86E64C", Offset = "0x86E64C", VA = "0x86E64C")]
		public static DungeonRoom MakeDungeon_GetRoom(DungeonRoomSettings settings, bool addToData = true)
		{
			return null;
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005855")]
		[Address(RVA = "0x86E588", Offset = "0x86E588", VA = "0x86E588")]
		public static LegacyDungeonHall MakeDungeon_GetHall_Legacy(LegacyDungeonHallSettings settings)
		{
			return null;
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005856")]
		[Address(RVA = "0x86F2BC", Offset = "0x86F2BC", VA = "0x86F2BC")]
		public static DungeonHall MakeDungeon_GetHall(DungeonHallSettings settings, bool addToData = true)
		{
			return null;
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005857")]
		[Address(RVA = "0x86F138", Offset = "0x86F138", VA = "0x86F138")]
		public static DungeonEntrance MakeDungeon_GetEntrance(DungeonEntranceSettings settings, bool addToData = true)
		{
			return null;
		}

		// Token: 0x040099A2 RID: 39330
		[Token(Token = "0x40099A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<DungeonData> dungeonData;
	}
}
