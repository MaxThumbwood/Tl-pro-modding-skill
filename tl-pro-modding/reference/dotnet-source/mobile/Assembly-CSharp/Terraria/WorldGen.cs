using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Events;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria
{
	// Token: 0x02000518 RID: 1304
	[Token(Token = "0x2000518")]
	public class WorldGen
	{
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000708")]
		public static UnifiedRandom genRand
		{
			[Token(Token = "0x6003523")]
			[Address(RVA = "0x1A62FF0", Offset = "0x1A62FF0", VA = "0x1A62FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003524")]
		[Address(RVA = "0x1A63054", Offset = "0x1A63054", VA = "0x1A63054")]
		public static void SetupStatueList()
		{
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003525")]
		[Address(RVA = "0x1A64368", Offset = "0x1A64368", VA = "0x1A64368")]
		public static void PlaceStatueTrap(int x, int y)
		{
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003526")]
		[Address(RVA = "0x1A75B18", Offset = "0x1A75B18", VA = "0x1A75B18")]
		private static EntitySource_TileBreak GetProjectileSource_TileBreak(int x, int y)
		{
			return null;
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003527")]
		[Address(RVA = "0x1A75B20", Offset = "0x1A75B20", VA = "0x1A75B20")]
		private static EntitySource_TileBreak GetNPCSource_TileBreak(int x, int y)
		{
			return null;
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003528")]
		[Address(RVA = "0x1A75B28", Offset = "0x1A75B28", VA = "0x1A75B28")]
		public static EntitySource_ShakeTree GetNPCSource_ShakeTree(int x, int y)
		{
			return null;
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003529")]
		[Address(RVA = "0x1A75BA4", Offset = "0x1A75BA4", VA = "0x1A75BA4")]
		private static EntitySource_ShakeTree GetProjectileSource_ShakeTree(int x, int y)
		{
			return null;
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352A")]
		[Address(RVA = "0x1A75C20", Offset = "0x1A75C20", VA = "0x1A75C20")]
		private static EntitySource_ShakeTree GetItemSource_ShakeTree(int x, int y)
		{
			return null;
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352B")]
		[Address(RVA = "0x1A75C9C", Offset = "0x1A75C9C", VA = "0x1A75C9C")]
		private static IEntitySource GetProjectileSource_PlayerOrWires(int x, int y, bool fromWiring, Player player)
		{
			return null;
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0001A970 File Offset: 0x00018B70
		[Token(Token = "0x600352C")]
		[Address(RVA = "0x1A75D8C", Offset = "0x1A75D8C", VA = "0x1A75D8C")]
		public static bool EmptyLiquid(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x0001A988 File Offset: 0x00018B88
		[Token(Token = "0x600352D")]
		[Address(RVA = "0x1A763EC", Offset = "0x1A763EC", VA = "0x1A763EC")]
		public static bool PlaceLiquid(int x, int y, byte liquidType, byte amount)
		{
			return default(bool);
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352E")]
		[Address(RVA = "0x1A76EFC", Offset = "0x1A76EFC", VA = "0x1A76EFC")]
		public static void PlayLiquidChangeSound(TileChangeType eventType, int x, int y, int count = 1)
		{
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		[Token(Token = "0x600352F")]
		[Address(RVA = "0x1A76E30", Offset = "0x1A76E30", VA = "0x1A76E30")]
		public static TileChangeType GetLiquidChangeType(int liquidType, int otherLiquidType)
		{
			return TileChangeType.None;
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x0001A9B8 File Offset: 0x00018BB8
		[Token(Token = "0x6003530")]
		[Address(RVA = "0x1A77060", Offset = "0x1A77060", VA = "0x1A77060")]
		public static bool MoveTownNPC(int x, int y, int n, [Optional] IRoomCheckFeedback feedback)
		{
			return default(bool);
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003531")]
		[Address(RVA = "0x1A7A6B4", Offset = "0x1A7A6B4", VA = "0x1A7A6B4")]
		public static void moveRoom(int x, int y, int n)
		{
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x0001A9D0 File Offset: 0x00018BD0
		[Token(Token = "0x6003532")]
		[Address(RVA = "0x1A7C15C", Offset = "0x1A7C15C", VA = "0x1A7C15C")]
		public static bool IsNPCEvictable(int n)
		{
			return default(bool);
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003533")]
		[Address(RVA = "0x1A7C2F4", Offset = "0x1A7C2F4", VA = "0x1A7C2F4")]
		public static void kickOut(int n)
		{
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0001A9E8 File Offset: 0x00018BE8
		[Token(Token = "0x6003534")]
		[Address(RVA = "0x1A7C508", Offset = "0x1A7C508", VA = "0x1A7C508")]
		public static int IsThereASpawnablePrioritizedTownNPC(int x, int y)
		{
			return 0;
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x0001AA00 File Offset: 0x00018C00
		[Token(Token = "0x6003535")]
		[Address(RVA = "0x1A7C8F0", Offset = "0x1A7C8F0", VA = "0x1A7C8F0")]
		public static bool IsThereASpawnablePrioritizedTownNPC_Old(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0001AA18 File Offset: 0x00018C18
		[Token(Token = "0x6003536")]
		[Address(RVA = "0x1A7A16C", Offset = "0x1A7A16C", VA = "0x1A7A16C")]
		public static bool CheckSpecialTownNPCSpawningConditions(int type)
		{
			return default(bool);
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003537")]
		[Address(RVA = "0x1A7CF78", Offset = "0x1A7CF78", VA = "0x1A7CF78")]
		public static void UnspawnTravelNPC()
		{
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003538")]
		[Address(RVA = "0x1A7D6A8", Offset = "0x1A7D6A8", VA = "0x1A7D6A8")]
		public static void SpawnHomelessNPC()
		{
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003539")]
		[Address(RVA = "0x1A8118C", Offset = "0x1A8118C", VA = "0x1A8118C")]
		public static void UnspawnHomelessNPC()
		{
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353A")]
		[Address(RVA = "0x1A819B4", Offset = "0x1A819B4", VA = "0x1A819B4")]
		public static void SpawnTravelNPC()
		{
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x0001AA30 File Offset: 0x00018C30
		[Token(Token = "0x600353B")]
		[Address(RVA = "0x1A7A96C", Offset = "0x1A7A96C", VA = "0x1A7A96C")]
		public static TownNPCSpawnResult SpawnTownNPC(int x, int y, bool canSpawnNewTownNPC = true)
		{
			return TownNPCSpawnResult.Blocked;
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x0001AA48 File Offset: 0x00018C48
		[Token(Token = "0x600353C")]
		[Address(RVA = "0x1A84484", Offset = "0x1A84484", VA = "0x1A84484")]
		private static int FindNPCLookingForHomeThatCanMoveIn(int npcType)
		{
			return 0;
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x0001AA60 File Offset: 0x00018C60
		[Token(Token = "0x600353D")]
		[Address(RVA = "0x1A804F0", Offset = "0x1A804F0", VA = "0x1A804F0")]
		private static int FindAnyHomelessTownNPC(bool includeGuide)
		{
			return 0;
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x0001AA78 File Offset: 0x00018C78
		[Token(Token = "0x600353E")]
		[Address(RVA = "0x1A846A0", Offset = "0x1A846A0", VA = "0x1A846A0")]
		private static bool IsRoomConsideredAlreadyOccupied(int spawnTileX, int spawnTileY, int npcTypeToSpawn)
		{
			return default(bool);
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353F")]
		[Address(RVA = "0x1A847F4", Offset = "0x1A847F4", VA = "0x1A847F4")]
		public static void CheckAchievement_RealEstateAndTownSlimes()
		{
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x0001AA90 File Offset: 0x00018C90
		[Token(Token = "0x6003540")]
		[Address(RVA = "0x1A78858", Offset = "0x1A78858", VA = "0x1A78858")]
		public static bool RoomNeeds()
		{
			return default(bool);
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003541")]
		[Address(RVA = "0x1A8083C", Offset = "0x1A8083C", VA = "0x1A8083C")]
		public static void QuickFindHome(int npc)
		{
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x0001AAA8 File Offset: 0x00018CA8
		[Token(Token = "0x6003542")]
		[Address(RVA = "0x1A84B6C", Offset = "0x1A84B6C", VA = "0x1A84B6C")]
		private static bool IsRoomConsideredOccupiedForNPCIndex(int npc)
		{
			return default(bool);
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		[Token(Token = "0x6003543")]
		[Address(RVA = "0x1A84D40", Offset = "0x1A84D40", VA = "0x1A84D40")]
		private static bool ScoreRoom_IsThisRoomOccupiedBySomeone(int ignoreNPC = -1, int npcTypeAsking = -1)
		{
			return default(bool);
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003544")]
		[Address(RVA = "0x1A85214", Offset = "0x1A85214", VA = "0x1A85214")]
		public static void CountTileTypesInArea(int[] tileTypeCounts, int startX, int endX, int startY, int endY)
		{
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		[Token(Token = "0x6003545")]
		[Address(RVA = "0x1A8547C", Offset = "0x1A8547C", VA = "0x1A8547C")]
		public static int GetTileTypeCountByCategory(int[] tileTypeCounts, TileScanGroup group)
		{
			return 0;
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003546")]
		[Address(RVA = "0x1A78CA0", Offset = "0x1A78CA0", VA = "0x1A78CA0")]
		public static void ScoreRoom(int ignoreNPC = -1, int npcTypeAskingToScoreRoom = -1, [Optional] IRoomCheckFeedback feedback)
		{
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003547")]
		[Address(RVA = "0x1A7CDF8", Offset = "0x1A7CDF8", VA = "0x1A7CDF8")]
		public static void Housing_GetTestedRoomBounds(out int startX, out int endX, out int startY, out int endY)
		{
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		[Token(Token = "0x6003548")]
		[Address(RVA = "0x1A85774", Offset = "0x1A85774", VA = "0x1A85774")]
		private static bool ScoreRoom_CanBeHomeSpot(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x0001AB08 File Offset: 0x00018D08
		[Token(Token = "0x6003549")]
		[Address(RVA = "0x1A85CA8", Offset = "0x1A85CA8", VA = "0x1A85CA8")]
		private static bool Housing_CheckIfIsCeiling(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x0001AB20 File Offset: 0x00018D20
		[Token(Token = "0x600354A")]
		[Address(RVA = "0x1A85BA8", Offset = "0x1A85BA8", VA = "0x1A85BA8")]
		private static bool Housing_CheckIfInRoom(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x0001AB38 File Offset: 0x00018D38
		[Token(Token = "0x600354B")]
		[Address(RVA = "0x1A782DC", Offset = "0x1A782DC", VA = "0x1A782DC")]
		public static bool StartRoomCheck(int x, int y, [Optional] IRoomCheckFeedback feedback)
		{
			return default(bool);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354C")]
		[Address(RVA = "0x1A85DA4", Offset = "0x1A85DA4", VA = "0x1A85DA4")]
		private static void CheckRoom(int x, int y, int iteration, IRoomCheckFeedback feedback)
		{
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354D")]
		[Address(RVA = "0x1A87728", Offset = "0x1A87728", VA = "0x1A87728")]
		public static void StartMeteorShower()
		{
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0001AB50 File Offset: 0x00018D50
		[Token(Token = "0x600354E")]
		[Address(RVA = "0x1A879A0", Offset = "0x1A879A0", VA = "0x1A879A0")]
		public static bool dropMeteor(bool spawnUnderGround = false)
		{
			return default(bool);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x0001AB68 File Offset: 0x00018D68
		[Token(Token = "0x600354F")]
		[Address(RVA = "0x1A88A78", Offset = "0x1A88A78", VA = "0x1A88A78")]
		public static bool meteor(int i, int j, bool ignorePlayers = false)
		{
			return default(bool);
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003550")]
		[Address(RVA = "0x1A91250", Offset = "0x1A91250", VA = "0x1A91250")]
		public static void setWorldSize()
		{
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x0001AB80 File Offset: 0x00018D80
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x1A91390", Offset = "0x1A91390", VA = "0x1A91390")]
		public static int GetWorldSize()
		{
			return 0;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003552")]
		[Address(RVA = "0x1A9142C", Offset = "0x1A9142C", VA = "0x1A9142C")]
		public static void SetWorldSize(int size)
		{
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003553")]
		[Address(RVA = "0x1A91500", Offset = "0x1A91500", VA = "0x1A91500")]
		public static void worldGenCallback(object threadContext)
		{
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x1A932E8", Offset = "0x1A932E8", VA = "0x1A932E8")]
		public static void CreateNewWorld([Optional] GenerationProgress progress)
		{
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003555")]
		[Address(RVA = "0x1A93514", Offset = "0x1A93514", VA = "0x1A93514")]
		public static void JustQuit()
		{
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003556")]
		[Address(RVA = "0x1A93838", Offset = "0x1A93838", VA = "0x1A93838")]
		private static void ShutDownServer()
		{
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003557")]
		[Address(RVA = "0x1A938B4", Offset = "0x1A938B4", VA = "0x1A938B4")]
		private static void WaitForFileSync()
		{
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003558")]
		[Address(RVA = "0x1A93BB8", Offset = "0x1A93BB8", VA = "0x1A93BB8")]
		public static void SaveAndQuitCallBack(object threadContext)
		{
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003559")]
		[Address(RVA = "0x1A94724", Offset = "0x1A94724", VA = "0x1A94724")]
		private static void LocalUserQuitOnMainThread(object localUserContext)
		{
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x1A94648", Offset = "0x1A94648", VA = "0x1A94648")]
		public static void StopWaterfallAmbienceAudio()
		{
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x1A947E0", Offset = "0x1A947E0", VA = "0x1A947E0")]
		public static void SaveAndQuit()
		{
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x1A949FC", Offset = "0x1A949FC", VA = "0x1A949FC")]
		public static void RenameWorld(WorldFileData data, string newName, [Optional] Action<string> callback)
		{
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355D")]
		[Address(RVA = "0x1A94AF0", Offset = "0x1A94AF0", VA = "0x1A94AF0")]
		public static void RenameWorldCallBack(object threadContext)
		{
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x1A94E60", Offset = "0x1A94E60", VA = "0x1A94E60")]
		public static void playWorldCallBack(object threadContext)
		{
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x1A95B5C", Offset = "0x1A95B5C", VA = "0x1A95B5C")]
		public static void JoinLocalWorld()
		{
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x1A95C80", Offset = "0x1A95C80", VA = "0x1A95C80")]
		public static void joinLocalWorldCallBack(object threadContext)
		{
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003561")]
		[Address(RVA = "0x1A961A8", Offset = "0x1A961A8", VA = "0x1A961A8")]
		public static void FinaliseOnMainThread(object threadContext)
		{
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003562")]
		[Address(RVA = "0x1A967E0", Offset = "0x1A967E0", VA = "0x1A967E0")]
		public static void loadInputWorld()
		{
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003563")]
		[Address(RVA = "0x1A97068", Offset = "0x1A97068", VA = "0x1A97068")]
		public static void playWorld()
		{
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003564")]
		[Address(RVA = "0x1A971CC", Offset = "0x1A971CC", VA = "0x1A971CC")]
		public static void saveAndPlayCallBack(object threadContext)
		{
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003565")]
		[Address(RVA = "0x1A9728C", Offset = "0x1A9728C", VA = "0x1A9728C")]
		public static void saveAndPlay()
		{
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003566")]
		[Address(RVA = "0x1A973B0", Offset = "0x1A973B0", VA = "0x1A973B0")]
		public static void saveToonWhilePlayingCallBack(object threadContext)
		{
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003567")]
		[Address(RVA = "0x1A97718", Offset = "0x1A97718", VA = "0x1A97718")]
		public static void saveToonWhilePlaying()
		{
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003568")]
		[Address(RVA = "0x1A9783C", Offset = "0x1A9783C", VA = "0x1A9783C")]
		public static void serverLoadWorldCallBack()
		{
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003569")]
		[Address(RVA = "0x1A97F0C", Offset = "0x1A97F0C", VA = "0x1A97F0C")]
		public static ManagedThread serverLoadWorld()
		{
			return null;
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356A")]
		[Address(RVA = "0x1A97FF4", Offset = "0x1A97FF4", VA = "0x1A97FF4")]
		private static void SetWorldSizeOnMainThread(object data)
		{
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356B")]
		[Address(RVA = "0x1A9822C", Offset = "0x1A9822C", VA = "0x1A9822C")]
		public static void EnsureRegionFramed(int xStart, int xEnd, int yStart, int yEnd)
		{
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356C")]
		[Address(RVA = "0x1A91A34", Offset = "0x1A91A34", VA = "0x1A91A34")]
		public static void clearWorld()
		{
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356D")]
		[Address(RVA = "0x1A98580", Offset = "0x1A98580", VA = "0x1A98580")]
		public static void setBG(int bg, int style)
		{
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356E")]
		[Address(RVA = "0x1A9B20C", Offset = "0x1A9B20C", VA = "0x1A9B20C")]
		private static void SetForestBGSet(int style, int[] mountainSet, int[] treeSet)
		{
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356F")]
		[Address(RVA = "0x1A9B8B0", Offset = "0x1A9B8B0", VA = "0x1A9B8B0")]
		public static void RandomizeWeather()
		{
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003570")]
		[Address(RVA = "0x1A9BB84", Offset = "0x1A9BB84", VA = "0x1A9BB84")]
		public static void RandomizeMoonState(UnifiedRandom random, bool guaranteeNewStyle = false)
		{
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003571")]
		[Address(RVA = "0x1A9BC6C", Offset = "0x1A9BC6C", VA = "0x1A9BC6C")]
		public static void RandomizeBackgroundBasedOnPlayer(UnifiedRandom random, Player player)
		{
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003572")]
		[Address(RVA = "0x1A9CCD0", Offset = "0x1A9CCD0", VA = "0x1A9CCD0")]
		public static void RandomizeBackgrounds(UnifiedRandom random)
		{
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x0001AB98 File Offset: 0x00018D98
		[Token(Token = "0x6003573")]
		[Address(RVA = "0x1A9C9BC", Offset = "0x1A9C9BC", VA = "0x1A9C9BC")]
		private static int RandomizeBackgrounds_Corruption(UnifiedRandom random)
		{
			return 0;
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		[Token(Token = "0x6003574")]
		[Address(RVA = "0x1A9C964", Offset = "0x1A9C964", VA = "0x1A9C964")]
		private static int RandomizeBackgrounds_Desert(UnifiedRandom random)
		{
			return 0;
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		[Token(Token = "0x6003575")]
		[Address(RVA = "0x1A9CA18", Offset = "0x1A9CA18", VA = "0x1A9CA18")]
		private static int RollRandomForestBGStyle(UnifiedRandom random)
		{
			return 0;
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		[Token(Token = "0x6003576")]
		[Address(RVA = "0x1A9CB8C", Offset = "0x1A9CB8C", VA = "0x1A9CB8C")]
		public static bool IsBackgroundConsideredTheSame(int oldBG, int newBG)
		{
			return default(bool);
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		[Token(Token = "0x6003577")]
		[Address(RVA = "0x1A9D324", Offset = "0x1A9D324", VA = "0x1A9D324")]
		public static int GetCurrentBackgroundOfStyle(int backgroundStyle)
		{
			return 0;
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003578")]
		[Address(RVA = "0x1A9D5E8", Offset = "0x1A9D5E8", VA = "0x1A9D5E8")]
		public static void RandomizeTreeStyle()
		{
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003579")]
		[Address(RVA = "0x1A9EB00", Offset = "0x1A9EB00", VA = "0x1A9EB00")]
		public static void RandomizeCaveBackgrounds()
		{
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357A")]
		[Address(RVA = "0x1A9FDAC", Offset = "0x1A9FDAC", VA = "0x1A9FDAC")]
		public static int[] GetTilesToAvoidForSpawn_TeamBasedSpawns()
		{
			return null;
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357B")]
		[Address(RVA = "0x1AA0404", Offset = "0x1AA0404", VA = "0x1AA0404")]
		private static void ResetGenerator()
		{
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x0001AC10 File Offset: 0x00018E10
		[Token(Token = "0x600357C")]
		[Address(RVA = "0x1AA0568", Offset = "0x1AA0568", VA = "0x1AA0568")]
		public static bool mayanTrap(int x2, int y2)
		{
			return default(bool);
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x0001AC28 File Offset: 0x00018E28
		[Token(Token = "0x600357D")]
		[Address(RVA = "0x1AA5FDC", Offset = "0x1AA5FDC", VA = "0x1AA5FDC")]
		public static bool placeLavaTrap(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x0001AC40 File Offset: 0x00018E40
		[Token(Token = "0x600357E")]
		[Address(RVA = "0x1AA79B8", Offset = "0x1AA79B8", VA = "0x1AA79B8")]
		public static bool AreAnyTilesInSetNearby(int x, int y, bool[] tileset, int distance)
		{
			return default(bool);
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x0001AC58 File Offset: 0x00018E58
		[Token(Token = "0x600357F")]
		[Address(RVA = "0x1AA7D6C", Offset = "0x1AA7D6C", VA = "0x1AA7D6C")]
		private static bool closeEnoughToDungeonToSpawnGhoulder(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x0001AC70 File Offset: 0x00018E70
		[Token(Token = "0x6003580")]
		[Address(RVA = "0x1AA814C", Offset = "0x1AA814C", VA = "0x1AA814C")]
		private static bool closeEnoughToSpidersToSpawnSpiderBoulder(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x0001AC88 File Offset: 0x00018E88
		[Token(Token = "0x6003581")]
		[Address(RVA = "0x1AA83A8", Offset = "0x1AA83A8", VA = "0x1AA83A8")]
		private static bool closeEnoughToLavaToSpawnLavaBoulder(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x0001ACA0 File Offset: 0x00018EA0
		[Token(Token = "0x6003582")]
		[Address(RVA = "0x1AA8700", Offset = "0x1AA8700", VA = "0x1AA8700")]
		public static bool IsTileNearby(int x, int y, int type, int distance)
		{
			return default(bool);
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x0001ACB8 File Offset: 0x00018EB8
		[Token(Token = "0x6003583")]
		[Address(RVA = "0x1AA88E4", Offset = "0x1AA88E4", VA = "0x1AA88E4")]
		private static bool placeTNTBarrel(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x0001ACD0 File Offset: 0x00018ED0
		[Token(Token = "0x6003584")]
		[Address(RVA = "0x1AA8B50", Offset = "0x1AA8B50", VA = "0x1AA8B50")]
		public static bool placeTrap_CanContinue(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x0001ACE8 File Offset: 0x00018EE8
		[Token(Token = "0x6003585")]
		[Address(RVA = "0x1AA8D58", Offset = "0x1AA8D58", VA = "0x1AA8D58")]
		public static bool placeTrap(int x2, int y2, int type = -1)
		{
			return default(bool);
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x0001AD00 File Offset: 0x00018F00
		[Token(Token = "0x6003586")]
		[Address(RVA = "0x1AB04D8", Offset = "0x1AB04D8", VA = "0x1AB04D8")]
		public static int countWires(int x, int y, int size)
		{
			return 0;
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x0001AD18 File Offset: 0x00018F18
		[Token(Token = "0x6003587")]
		[Address(RVA = "0x1AB09E4", Offset = "0x1AB09E4", VA = "0x1AB09E4")]
		public static int countTiles(int x, int y, bool jungle = false, bool lavaOk = false)
		{
			return 0;
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003588")]
		[Address(RVA = "0x1AB0A94", Offset = "0x1AB0A94", VA = "0x1AB0A94")]
		public static void nextCount(int x, int y, bool jungle = false, bool lavaOk = false)
		{
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x0001AD30 File Offset: 0x00018F30
		[Token(Token = "0x6003589")]
		[Address(RVA = "0x1AB1DA4", Offset = "0x1AB1DA4", VA = "0x1AB1DA4")]
		public static int countDirtTiles(int x, int y)
		{
			return 0;
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358A")]
		[Address(RVA = "0x1AB1E2C", Offset = "0x1AB1E2C", VA = "0x1AB1E2C")]
		public static void nextDirtCount(int x, int y)
		{
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x0001AD48 File Offset: 0x00018F48
		[Token(Token = "0x600358B")]
		[Address(RVA = "0x1AB45B4", Offset = "0x1AB45B4", VA = "0x1AB45B4")]
		public static bool InWorld(Point p, int fluff = 0)
		{
			return default(bool);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x0001AD60 File Offset: 0x00018F60
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x1A64874", Offset = "0x1A64874", VA = "0x1A64874")]
		public static bool InWorld(int x, int y, int fluff = 0)
		{
			return default(bool);
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x0001AD78 File Offset: 0x00018F78
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x1AB46C8", Offset = "0x1AB46C8", VA = "0x1AB46C8")]
		public static bool InWorld(Rectangle rect, int fluff = 0)
		{
			return default(bool);
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x0001AD90 File Offset: 0x00018F90
		[Token(Token = "0x600358E")]
		[Address(RVA = "0x1AB4798", Offset = "0x1AB4798", VA = "0x1AB4798")]
		public static bool IsTileLoaded(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358F")]
		[Address(RVA = "0x1AB4900", Offset = "0x1AB4900", VA = "0x1AB4900")]
		public static void gemCave(int x, int y)
		{
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x0001ADA8 File Offset: 0x00018FA8
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x1AB4B84", Offset = "0x1AB4B84", VA = "0x1AB4B84")]
		public static int randGem()
		{
			return 0;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x0001ADC0 File Offset: 0x00018FC0
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x1AB4CD4", Offset = "0x1AB4CD4", VA = "0x1AB4CD4")]
		public static ushort randGemTile()
		{
			return 0;
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003592")]
		[Address(RVA = "0x1AB4E1C", Offset = "0x1AB4E1C", VA = "0x1AB4E1C")]
		public static void randMoss(bool justNeon = false)
		{
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003593")]
		[Address(RVA = "0x1AB52D8", Offset = "0x1AB52D8", VA = "0x1AB52D8")]
		public static void neonMossBiome(int i, int j, int maxY = 99999)
		{
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003594")]
		[Address(RVA = "0x1AB70D8", Offset = "0x1AB70D8", VA = "0x1AB70D8")]
		public static void setMoss(int x, int y)
		{
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003595")]
		[Address(RVA = "0x1AB7274", Offset = "0x1AB7274", VA = "0x1AB7274")]
		public static void FillWallHolesInArea(Rectangle worldCoordsArea)
		{
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		[Token(Token = "0x6003596")]
		[Address(RVA = "0x1AB7444", Offset = "0x1AB7444", VA = "0x1AB7444")]
		private static int FillWallHolesInColumn(int x, int startY, int endY)
		{
			return 0;
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x0001ADF0 File Offset: 0x00018FF0
		[Token(Token = "0x6003597")]
		[Address(RVA = "0x1AB770C", Offset = "0x1AB770C", VA = "0x1AB770C")]
		private static bool FillWallHolesInSpot(int originX, int originY, int maxWallsThreshold)
		{
			return default(bool);
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003598")]
		[Address(RVA = "0x1AB8BE0", Offset = "0x1AB8BE0", VA = "0x1AB8BE0")]
		public static void tileCountAndDestroy()
		{
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x0001AE08 File Offset: 0x00019008
		[Token(Token = "0x6003599")]
		[Address(RVA = "0x1AB8E40", Offset = "0x1AB8E40", VA = "0x1AB8E40")]
		public static int tileCounter(int x, int y)
		{
			return 0;
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359A")]
		[Address(RVA = "0x1AB923C", Offset = "0x1AB923C", VA = "0x1AB923C")]
		public static void tileCounterNext(int x, int y)
		{
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x1AB9030", Offset = "0x1AB9030", VA = "0x1AB9030")]
		public static void tileCounterKill()
		{
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359C")]
		[Address(RVA = "0x1AB975C", Offset = "0x1AB975C", VA = "0x1AB975C")]
		private static void AddGenerationPass(string name, WorldGenLegacyMethod method)
		{
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359D")]
		[Address(RVA = "0x1AB982C", Offset = "0x1AB982C", VA = "0x1AB982C")]
		private static void AddGenerationPass(GenPass pass)
		{
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359E")]
		[Address(RVA = "0x1AB98B0", Offset = "0x1AB98B0", VA = "0x1AB98B0")]
		private static void AddGenerationPass(string name, double weight, WorldGenLegacyMethod method)
		{
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x0001AE20 File Offset: 0x00019020
		[Token(Token = "0x600359F")]
		[Address(RVA = "0x1AB99A8", Offset = "0x1AB99A8", VA = "0x1AB99A8")]
		public static bool checkUnderground(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x0001AE38 File Offset: 0x00019038
		[Token(Token = "0x60035A0")]
		[Address(RVA = "0x1AB9D84", Offset = "0x1AB9D84", VA = "0x1AB9D84")]
		public static int GetNextJungleChestItem()
		{
			return 0;
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A1")]
		[Address(RVA = "0x1AB9F74", Offset = "0x1AB9F74", VA = "0x1AB9F74")]
		private static void ScanTileColumnAndRemoveClumps(int x)
		{
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0x1ABA424", Offset = "0x1ABA424", VA = "0x1ABA424")]
		public static void OreHelper(int X, int Y)
		{
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x0001AE50 File Offset: 0x00019050
		[Token(Token = "0x60035A3")]
		[Address(RVA = "0x1ABA688", Offset = "0x1ABA688", VA = "0x1ABA688")]
		public static bool StonePatch(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x0001AE68 File Offset: 0x00019068
		[Token(Token = "0x60035A4")]
		[Address(RVA = "0x1ABD070", Offset = "0x1ABD070", VA = "0x1ABD070")]
		public static bool ShellPile(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x0001AE80 File Offset: 0x00019080
		[Token(Token = "0x60035A5")]
		[Address(RVA = "0x1ABEB08", Offset = "0x1ABEB08", VA = "0x1ABEB08")]
		public static bool MarblePileWithStatues(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x0001AE98 File Offset: 0x00019098
		[Token(Token = "0x60035A6")]
		[Address(RVA = "0x1AC0614", Offset = "0x1AC0614", VA = "0x1AC0614")]
		public static bool Statue(int x, int y, byte paint)
		{
			return default(bool);
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x0001AEB0 File Offset: 0x000190B0
		[Token(Token = "0x60035A7")]
		[Address(RVA = "0x1AC0B18", Offset = "0x1AC0B18", VA = "0x1AC0B18")]
		public static bool OrePatch(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x0001AEC8 File Offset: 0x000190C8
		[Token(Token = "0x60035A8")]
		[Address(RVA = "0x1AC2ED0", Offset = "0x1AC2ED0", VA = "0x1AC2ED0")]
		public static bool PlaceOasis(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x0001AEE0 File Offset: 0x000190E0
		[Token(Token = "0x60035A9")]
		[Address(RVA = "0x1AC63C4", Offset = "0x1AC63C4", VA = "0x1AC63C4")]
		public static bool BiomeTileCheck(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x0001AEF8 File Offset: 0x000190F8
		[Token(Token = "0x17000709")]
		public static double oceanLevel
		{
			[Token(Token = "0x60035AA")]
			[Address(RVA = "0x1AC66A8", Offset = "0x1AC66A8", VA = "0x1AC66A8")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x0001AF10 File Offset: 0x00019110
		[Token(Token = "0x60035AB")]
		[Address(RVA = "0x1AC6730", Offset = "0x1AC6730", VA = "0x1AC6730")]
		public static bool oceanDepths(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x0001AF28 File Offset: 0x00019128
		[Token(Token = "0x60035AC")]
		[Address(RVA = "0x1AC68BC", Offset = "0x1AC68BC", VA = "0x1AC68BC")]
		public static bool IsSurfaceForAtmospherics(Point tileCoords)
		{
			return default(bool);
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AD")]
		[Address(RVA = "0x1AC69D4", Offset = "0x1AC69D4", VA = "0x1AC69D4")]
		public static void UpdateDesertHiveBounds(int x, int y)
		{
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x0001AF40 File Offset: 0x00019140
		[Token(Token = "0x60035AE")]
		[Address(RVA = "0x1AC6B2C", Offset = "0x1AC6B2C", VA = "0x1AC6B2C")]
		public static bool ValidateTypes()
		{
			return default(bool);
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AF")]
		[Address(RVA = "0x1AB0338", Offset = "0x1AB0338", VA = "0x1AB0338")]
		public static void SetBoulderSolidity(bool solid)
		{
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B0")]
		[Address(RVA = "0x1AC6E1C", Offset = "0x1AC6E1C", VA = "0x1AC6E1C")]
		public static void SetCrackedBrickSolidity(bool solid)
		{
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x0001AF58 File Offset: 0x00019158
		[Token(Token = "0x60035B1")]
		[Address(RVA = "0x1AA5944", Offset = "0x1AA5944", VA = "0x1AA5944")]
		public static bool CanGeneratePressurePlateAt(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B2")]
		[Address(RVA = "0x1AC6EE4", Offset = "0x1AC6EE4", VA = "0x1AC6EE4")]
		public static void GenerateWorld_SetupDungeonGenVars(int currentDungeon, bool clearOld = false)
		{
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x0001AF70 File Offset: 0x00019170
		[Token(Token = "0x60035B3")]
		[Address(RVA = "0x1A92D10", Offset = "0x1A92D10", VA = "0x1A92D10")]
		public static bool GenerateWorld([Optional] GenerationProgress customProgressObject, [Optional] WorldGenerator.Controller customController)
		{
			return default(bool);
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x1AC70B0", Offset = "0x1AC70B0", VA = "0x1AC70B0")]
		public static void Reset()
		{
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x0001AF88 File Offset: 0x00019188
		[Token(Token = "0x60035B5")]
		[Address(RVA = "0x1AD1338", Offset = "0x1AD1338", VA = "0x1AD1338")]
		public static bool IsDungeonPlatformOrShelf(Tile bottomTile)
		{
			return default(bool);
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B6")]
		[Address(RVA = "0x1ACAA2C", Offset = "0x1ACAA2C", VA = "0x1ACAA2C")]
		public static void AddPasses()
		{
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x1AD0EE4", Offset = "0x1AD0EE4", VA = "0x1AD0EE4")]
		public static void DisablePassesForSpecialSeeds(List<GenPass> passes)
		{
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x1AD1550", Offset = "0x1AD1550", VA = "0x1AD1550")]
		public static void RestoreTemporaryStateChanges()
		{
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x1AD1278", Offset = "0x1AD1278", VA = "0x1AD1278")]
		public static void Finish()
		{
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x1AD1638", Offset = "0x1AD1638", VA = "0x1AD1638")]
		private static void GenerateSkyBlockWorld(GenerationProgress progress)
		{
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x0001AFA0 File Offset: 0x000191A0
		[Token(Token = "0x60035BB")]
		[Address(RVA = "0x1AD5038", Offset = "0x1AD5038", VA = "0x1AD5038")]
		public static bool SkyblockIsland(int i, int j, int islandStyle, int extraData = -1, bool forceProximityCheck = false)
		{
			return default(bool);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x1AE5D4C", Offset = "0x1AE5D4C", VA = "0x1AE5D4C")]
		private static void GenerateUnderworldStartingMound()
		{
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x0001AFB8 File Offset: 0x000191B8
		[Token(Token = "0x60035BD")]
		[Address(RVA = "0x1AE7B28", Offset = "0x1AE7B28", VA = "0x1AE7B28")]
		private static int GetPileGenerationAttempts()
		{
			return 0;
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x0001AFD0 File Offset: 0x000191D0
		[Token(Token = "0x60035BE")]
		[Address(RVA = "0x1AE5C7C", Offset = "0x1AE5C7C", VA = "0x1AE5C7C")]
		private static bool isTileSurroundedBySolidTiles(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x1AE7D50", Offset = "0x1AE7D50", VA = "0x1AE7D50")]
		public static void LiquidInteractionsCleanup()
		{
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x0001AFE8 File Offset: 0x000191E8
		[Token(Token = "0x60035C0")]
		[Address(RVA = "0x1AE84BC", Offset = "0x1AE84BC", VA = "0x1AE84BC")]
		private static int GetRightMostDungeonTile()
		{
			return 0;
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x0001B000 File Offset: 0x00019200
		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x1AE8868", Offset = "0x1AE8868", VA = "0x1AE8868")]
		private static int GetLeftMostDungeonTile()
		{
			return 0;
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x1AE8C20", Offset = "0x1AE8C20", VA = "0x1AE8C20")]
		private static void RandomizeWorldSpawn()
		{
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x1AE9454", Offset = "0x1AE9454", VA = "0x1AE9454")]
		private static void TownNPCPositionsCleanup(Point originalSpawnPoint)
		{
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x1AE9CF8", Offset = "0x1AE9CF8", VA = "0x1AE9CF8")]
		private static void OverGrownDungeon()
		{
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C5")]
		[Address(RVA = "0x1AF1914", Offset = "0x1AF1914", VA = "0x1AF1914")]
		private static void OverGrownDungeonWithRainbowMoss()
		{
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C6")]
		[Address(RVA = "0x1AF2AA8", Offset = "0x1AF2AA8", VA = "0x1AF2AA8")]
		private static void AddSpikeCaves(GenerationProgress progress)
		{
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C7")]
		[Address(RVA = "0x1AF34F0", Offset = "0x1AF34F0", VA = "0x1AF34F0")]
		private static void ShimmerifySideOfWorld(bool left)
		{
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x0001B018 File Offset: 0x00019218
		[Token(Token = "0x60035C8")]
		[Address(RVA = "0x1AE9B5C", Offset = "0x1AE9B5C", VA = "0x1AE9B5C")]
		private static Point GetAdjustedFloorPosition(int x, int y)
		{
			return default(Point);
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x1AE98B4", Offset = "0x1AE98B4", VA = "0x1AE98B4")]
		private static void Scan3By3(int topLeftX, int topLeftY, out bool isEmpty, out bool hasFloor)
		{
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x1AF3AD8", Offset = "0x1AF3AD8", VA = "0x1AF3AD8")]
		private static void FinishTenthAnniversaryWorldPaintTreesAndMushrooms()
		{
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CB")]
		[Address(RVA = "0x1AF5418", Offset = "0x1AF5418", VA = "0x1AF5418")]
		private static void FinishTenthAnniversaryWorld()
		{
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CC")]
		[Address(RVA = "0x1AF4108", Offset = "0x1AF4108", VA = "0x1AF4108")]
		private static void PaintTheMushrooms()
		{
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CD")]
		[Address(RVA = "0x1AF3B38", Offset = "0x1AF3B38", VA = "0x1AF3B38")]
		private static void PaintTheTrees()
		{
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CE")]
		[Address(RVA = "0x1AF8250", Offset = "0x1AF8250", VA = "0x1AF8250")]
		private static void PaintTheSand(byte tilePaintColor, byte wallPaintColor)
		{
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CF")]
		[Address(RVA = "0x1AF9808", Offset = "0x1AF9808", VA = "0x1AF9808")]
		private static void PaintTheSandRainbowAndSandWallsBlack()
		{
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x0001B030 File Offset: 0x00019230
		[Token(Token = "0x60035D0")]
		[Address(RVA = "0x1AFAC28", Offset = "0x1AFAC28", VA = "0x1AFAC28")]
		public static byte GetRainbowPaintIDForPosition(int x, int y, bool wiggly = false)
		{
			return 0;
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D1")]
		[Address(RVA = "0x1AFAD64", Offset = "0x1AFAD64", VA = "0x1AFAD64")]
		private static void PaintThePurityGrass(byte tilePaintColor, byte wallPaintColor)
		{
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D2")]
		[Address(RVA = "0x1AF9328", Offset = "0x1AF9328", VA = "0x1AF9328")]
		private static void PaintThePyramids(byte tilePaintColor, byte wallPaintColor)
		{
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D3")]
		[Address(RVA = "0x1AF7688", Offset = "0x1AF7688", VA = "0x1AF7688")]
		private static void PaintTheTemple(byte tilePaintColor, byte wallPaintColor)
		{
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D4")]
		[Address(RVA = "0x1AF7E28", Offset = "0x1AF7E28", VA = "0x1AF7E28")]
		private static void PaintTheClouds(byte tilePaintColor, byte wallPaintColor)
		{
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D5")]
		[Address(RVA = "0x1AF66BC", Offset = "0x1AF66BC", VA = "0x1AF66BC")]
		private static void PaintTheDungeon(byte tilePaintColor, byte wallPaintColor)
		{
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x1AF6D7C", Offset = "0x1AF6D7C", VA = "0x1AF6D7C")]
		private static void PaintTheLivingTrees(byte livingTreePaintColor, byte livingTreeWallPaintColor)
		{
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x1AF5DE8", Offset = "0x1AF5DE8", VA = "0x1AF5DE8")]
		private static void ConvertSkyIslands(int convertType, bool growTrees)
		{
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x1AF96E0", Offset = "0x1AF96E0", VA = "0x1AF96E0")]
		private static void ImproveAllChestContents()
		{
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x1B03D40", Offset = "0x1B03D40", VA = "0x1B03D40")]
		private static void GiveItemGoodPrefixes(ref ChestItem item)
		{
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x1B040D8", Offset = "0x1B040D8", VA = "0x1B040D8")]
		private static void PrefixItemFromOptions(ref ChestItem item, int[] options)
		{
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DB")]
		[Address(RVA = "0x1B042FC", Offset = "0x1B042FC", VA = "0x1B042FC")]
		private static void PutMonsterVanityInChests()
		{
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DC")]
		[Address(RVA = "0x1B047F8", Offset = "0x1B047F8", VA = "0x1B047F8")]
		private static void SpawnGraveyardBiomesEverywhere()
		{
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DD")]
		[Address(RVA = "0x1B04D1C", Offset = "0x1B04D1C", VA = "0x1B04D1C")]
		public static void SpawnGraveyardBiome(int X, int Y)
		{
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DE")]
		[Address(RVA = "0x1AE42B4", Offset = "0x1AE42B4", VA = "0x1AE42B4")]
		public static void DoAdditionalChangesAroundSpawnIfNeeded(int spawnX = -1, int spawnY = -1)
		{
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DF")]
		[Address(RVA = "0x1B076DC", Offset = "0x1B076DC", VA = "0x1B076DC")]
		public static void RemoveSpecificTilesUnderSpawn(int spawnX = -1, int spawnY = -1)
		{
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E0")]
		[Address(RVA = "0x1B06CFC", Offset = "0x1B06CFC", VA = "0x1B06CFC")]
		public static void PlaceTorchesAroundSpawn(int spawnX = -1, int spawnY = -1)
		{
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0001B048 File Offset: 0x00019248
		[Token(Token = "0x60035E1")]
		[Address(RVA = "0x1B08440", Offset = "0x1B08440", VA = "0x1B08440")]
		private static bool SkipOnDualDungeons(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E2")]
		[Address(RVA = "0x1B08898", Offset = "0x1B08898", VA = "0x1B08898")]
		private static void NotTheBees()
		{
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x0001B060 File Offset: 0x00019260
		[Token(Token = "0x60035E3")]
		[Address(RVA = "0x1B15478", Offset = "0x1B15478", VA = "0x1B15478")]
		private static int FindLowestCloud()
		{
			return 0;
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E4")]
		[Address(RVA = "0x1B15898", Offset = "0x1B15898", VA = "0x1B15898")]
		private static void FinishNotTheBees()
		{
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E5")]
		[Address(RVA = "0x1B1BBF4", Offset = "0x1B1BBF4", VA = "0x1B1BBF4")]
		private static void FinishGetGoodWorld()
		{
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E6")]
		[Address(RVA = "0x1B1E638", Offset = "0x1B1E638", VA = "0x1B1E638")]
		private static void FinishNoTraps()
		{
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E7")]
		[Address(RVA = "0x1B21864", Offset = "0x1B21864", VA = "0x1B21864")]
		private static void FinishDrunkGen()
		{
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E8")]
		[Address(RVA = "0x1B23378", Offset = "0x1B23378", VA = "0x1B23378")]
		private static void FinishRemixWorld()
		{
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x0001B078 File Offset: 0x00019278
		[Token(Token = "0x60035E9")]
		[Address(RVA = "0x1B2DF24", Offset = "0x1B2DF24", VA = "0x1B2DF24")]
		public static bool isThisInTheRockLayer(int y)
		{
			return default(bool);
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x0001B090 File Offset: 0x00019290
		[Token(Token = "0x60035EA")]
		[Address(RVA = "0x1B2E03C", Offset = "0x1B2E03C", VA = "0x1B2E03C")]
		public static bool IsItATrap(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x0001B0A8 File Offset: 0x000192A8
		[Token(Token = "0x60035EB")]
		[Address(RVA = "0x1B2E318", Offset = "0x1B2E318", VA = "0x1B2E318")]
		public static bool IsItATrigger(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EC")]
		[Address(RVA = "0x1B2E668", Offset = "0x1B2E668", VA = "0x1B2E668")]
		public static void ClearAllBrokenTraps()
		{
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035ED")]
		[Address(RVA = "0x1B2E918", Offset = "0x1B2E918", VA = "0x1B2E918")]
		public static void ClearBrokenTraps(Point startTileCoords, List<Point> pointsWeAlreadyWentOver)
		{
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x0001B0C0 File Offset: 0x000192C0
		[Token(Token = "0x60035EE")]
		[Address(RVA = "0x1B2FEB0", Offset = "0x1B2FEB0", VA = "0x1B2FEB0")]
		private static double TuneOceanDepth(int count, double depth, bool floridaStyle = false)
		{
			return 0.0;
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x0001B0D8 File Offset: 0x000192D8
		[Token(Token = "0x60035EF")]
		[Address(RVA = "0x1B31150", Offset = "0x1B31150", VA = "0x1B31150")]
		public static Point RandomRectanglePoint(Rectangle rectangle)
		{
			return default(Point);
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x0001B0F0 File Offset: 0x000192F0
		[Token(Token = "0x60035F0")]
		[Address(RVA = "0x1B312C0", Offset = "0x1B312C0", VA = "0x1B312C0")]
		public static Point RandomRectanglePoint(int x, int y, int width, int height)
		{
			return default(Point);
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x0001B108 File Offset: 0x00019308
		[Token(Token = "0x60035F1")]
		[Address(RVA = "0x1B31430", Offset = "0x1B31430", VA = "0x1B31430")]
		public static Point RandomWorldPoint(int padding)
		{
			return default(Point);
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x0001B120 File Offset: 0x00019320
		[Token(Token = "0x60035F2")]
		[Address(RVA = "0x1B314BC", Offset = "0x1B314BC", VA = "0x1B314BC")]
		public static Point RandomWorldPoint(int top = 0, int right = 0, int bottom = 0, int left = 0)
		{
			return default(Point);
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x0001B138 File Offset: 0x00019338
		[Token(Token = "0x60035F3")]
		[Address(RVA = "0x1B31678", Offset = "0x1B31678", VA = "0x1B31678")]
		public static bool GrowPalmTree(int i, int y, int treeHeightAddon = 0, bool ignoreWalls = false)
		{
			return default(bool);
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x0001B150 File Offset: 0x00019350
		[Token(Token = "0x60035F4")]
		[Address(RVA = "0x1B3394C", Offset = "0x1B3394C", VA = "0x1B3394C")]
		public static bool IsPalmOasisTree(int x)
		{
			return default(bool);
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x0001B168 File Offset: 0x00019368
		[Token(Token = "0x60035F5")]
		[Address(RVA = "0x1B33A38", Offset = "0x1B33A38", VA = "0x1B33A38")]
		public static bool GrowEpicTree(int i, int y)
		{
			return default(bool);
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x0001B180 File Offset: 0x00019380
		[Token(Token = "0x60035F6")]
		[Address(RVA = "0x1B39CFC", Offset = "0x1B39CFC", VA = "0x1B39CFC")]
		public static bool Pyramid(int i, int j, int pyramidMinDepth = 75, int pyramidMaxDepth = 125, bool noTunnel = false)
		{
			return default(bool);
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x0001B198 File Offset: 0x00019398
		[Token(Token = "0x60035F7")]
		[Address(RVA = "0x1ADBB88", Offset = "0x1ADBB88", VA = "0x1ADBB88")]
		public static bool GrowLivingTree(int i, int j, bool patch = false)
		{
			return default(bool);
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x0001B1B0 File Offset: 0x000193B0
		[Token(Token = "0x60035F8")]
		[Address(RVA = "0x1B3D944", Offset = "0x1B3D944", VA = "0x1B3D944")]
		private static bool GrowLivingTree_CanPlaceLeaves(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x0001B1C8 File Offset: 0x000193C8
		[Token(Token = "0x60035F9")]
		[Address(RVA = "0x1B42494", Offset = "0x1B42494", VA = "0x1B42494")]
		private static bool GrowLivingTree_HorizontalTunnel(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FA")]
		[Address(RVA = "0x1B3DE18", Offset = "0x1B3DE18", VA = "0x1B3DE18")]
		public static void GrowLivingTree_MakePassage(int j, int W, ref int minl, ref int minr, bool noSecretRoom = false)
		{
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FB")]
		[Address(RVA = "0x1B46460", Offset = "0x1B46460", VA = "0x1B46460")]
		private static void GrowLivingTreePassageRoom(int minl, int minr, int Y)
		{
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FC")]
		[Address(RVA = "0x1B48C7C", Offset = "0x1B48C7C", VA = "0x1B48C7C")]
		public static void TreeGrowFXCheck(int x, int y)
		{
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FD")]
		[Address(RVA = "0x1B492B8", Offset = "0x1B492B8", VA = "0x1B492B8")]
		public static void GetTreeLeaf(int x, Tile topTile, Tile t, ref int treeHeight, out int treeFrame, out int passStyle)
		{
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FE")]
		[Address(RVA = "0x1B49D28", Offset = "0x1B49D28", VA = "0x1B49D28")]
		public static void TreeGrowFX(int x, int y, int height, int treeGore, bool hitTree = false)
		{
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FF")]
		[Address(RVA = "0x1B4AA00", Offset = "0x1B4AA00", VA = "0x1B4AA00")]
		private static void TreeGrowFX_AshShake(int x, int y, int height, bool hitTree = false)
		{
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x0001B1E0 File Offset: 0x000193E0
		[Token(Token = "0x6003600")]
		[Address(RVA = "0x1B4B494", Offset = "0x1B4B494", VA = "0x1B4B494")]
		public static bool IsTileALeafyTreeTop(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x0001B1F8 File Offset: 0x000193F8
		[Token(Token = "0x6003601")]
		[Address(RVA = "0x1B4B510", Offset = "0x1B4B510", VA = "0x1B4B510")]
		public static bool IsTileALeafyTreeTop(Tile t)
		{
			return default(bool);
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x0001B210 File Offset: 0x00019410
		[Token(Token = "0x6003602")]
		[Address(RVA = "0x1B4B920", Offset = "0x1B4B920", VA = "0x1B4B920")]
		public static bool IsTileTypeFitForTree(ushort type)
		{
			return default(bool);
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x0001B228 File Offset: 0x00019428
		[Token(Token = "0x6003603")]
		[Address(RVA = "0x1B4B9BC", Offset = "0x1B4B9BC", VA = "0x1B4B9BC")]
		public static bool IsTileATreeBranch(int x, int y, out int offsetToTrunk)
		{
			return default(bool);
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x0001B240 File Offset: 0x00019440
		[Token(Token = "0x6003604")]
		[Address(RVA = "0x1B4C450", Offset = "0x1B4C450", VA = "0x1B4C450")]
		public static bool IsTileATreeRoot(int x, int y, out int offsetToTrunk)
		{
			return default(bool);
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x0001B258 File Offset: 0x00019458
		[Token(Token = "0x6003605")]
		[Address(RVA = "0x1AEB65C", Offset = "0x1AEB65C", VA = "0x1AEB65C")]
		public static bool GrowTree(int i, int y, int treeHeightAddon = 0, bool ignoreWalls = false)
		{
			return default(bool);
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x0001B270 File Offset: 0x00019470
		[Token(Token = "0x6003606")]
		[Address(RVA = "0x1B32FB8", Offset = "0x1B32FB8", VA = "0x1B32FB8")]
		public static bool DefaultTreeWallTest(int wallType)
		{
			return default(bool);
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x0001B288 File Offset: 0x00019488
		[Token(Token = "0x6003607")]
		[Address(RVA = "0x1B4CB60", Offset = "0x1B4CB60", VA = "0x1B4CB60")]
		public static bool GemTreeWallTest(int wallType)
		{
			return default(bool);
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x0001B2A0 File Offset: 0x000194A0
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x1B4CC20", Offset = "0x1B4CC20", VA = "0x1B4CC20")]
		public static bool GemTreeGroundTest(int tileType)
		{
			return default(bool);
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x0001B2B8 File Offset: 0x000194B8
		[Token(Token = "0x6003609")]
		[Address(RVA = "0x1B4CCEC", Offset = "0x1B4CCEC", VA = "0x1B4CCEC")]
		public static bool VanityTreeGroundTest(int tileType)
		{
			return default(bool);
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x0001B2D0 File Offset: 0x000194D0
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x1B4CD98", Offset = "0x1B4CD98", VA = "0x1B4CD98")]
		public static bool AshTreeGroundTest(int tileType)
		{
			return default(bool);
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x0001B2E8 File Offset: 0x000194E8
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x1AE75FC", Offset = "0x1AE75FC", VA = "0x1AE75FC")]
		public static bool TryGrowingTreeByType(int treeTileType, int checkedX, int checkedY, int treeHeightAddon = 0, bool ignoreWalls = false)
		{
			return default(bool);
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x0001B300 File Offset: 0x00019500
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x1B4CDB4", Offset = "0x1B4CDB4", VA = "0x1B4CDB4")]
		public static bool GrowTreeWithSettings(int checkedX, int checkedY, WorldGen.GrowTreeSettings settings, int treeHeightAddon = 0, bool ignoreWalls = false)
		{
			return default(bool);
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360D")]
		[Address(RVA = "0x1B528B8", Offset = "0x1B528B8", VA = "0x1B528B8")]
		public static void GrowUndergroundTree(int i, int y, int treeHeightAddon = 0)
		{
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x0001B318 File Offset: 0x00019518
		[Token(Token = "0x600360E")]
		[Address(RVA = "0x1B5809C", Offset = "0x1B5809C", VA = "0x1B5809C")]
		public static bool GrowShroom(int i, int y)
		{
			return default(bool);
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360F")]
		[Address(RVA = "0x1B2B3C8", Offset = "0x1B2B3C8", VA = "0x1B2B3C8")]
		public static void AddTrees(bool undergroundOnly = false)
		{
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x0001B330 File Offset: 0x00019530
		[Token(Token = "0x6003610")]
		[Address(RVA = "0x1B33094", Offset = "0x1B33094", VA = "0x1B33094")]
		public static bool EmptyTileCheck(int startX, int endX, int startY, int endY, int ignoreID = -1)
		{
			return default(bool);
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x1B595FC", Offset = "0x1B595FC", VA = "0x1B595FC")]
		public static void StartHardmode()
		{
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003612")]
		[Address(RVA = "0x1B598F0", Offset = "0x1B598F0", VA = "0x1B598F0")]
		public static void TryProtectingSpawnedItems()
		{
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x0001B348 File Offset: 0x00019548
		[Token(Token = "0x6003613")]
		[Address(RVA = "0x1B599E4", Offset = "0x1B599E4", VA = "0x1B599E4")]
		private static bool EligibleForSpawnProtection(WorldItem item)
		{
			return default(bool);
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x1B59AAC", Offset = "0x1B59AAC", VA = "0x1B59AAC")]
		public static void UndoSpawnedItemProtection()
		{
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x1B59B98", Offset = "0x1B59B98", VA = "0x1B59B98")]
		private static void initializeHardMode()
		{
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x1B5D134", Offset = "0x1B5D134", VA = "0x1B5D134")]
		public static void smCallBack(object threadContext)
		{
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003617")]
		[Address(RVA = "0x1B5D574", Offset = "0x1B5D574", VA = "0x1B5D574")]
		private static void FinaliseHardModeOnMainThread(object data)
		{
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x1B5D844", Offset = "0x1B5D844", VA = "0x1B5D844")]
		private static void KickOffQueuedConversion()
		{
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x1B5D998", Offset = "0x1B5D998", VA = "0x1B5D998")]
		private static void clearUnbreakableWallsCallback(object threadContext)
		{
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x1B5E068", Offset = "0x1B5E068", VA = "0x1B5E068")]
		private static void FinaliseClearUnbreakableWalls(object data)
		{
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361B")]
		[Address(RVA = "0x1B5E160", Offset = "0x1B5E160", VA = "0x1B5E160")]
		public static void ClearUnbreakableWallsWithPaintUpTo(int tierColor)
		{
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0001B360 File Offset: 0x00019560
		[Token(Token = "0x600361C")]
		[Address(RVA = "0x1B5E408", Offset = "0x1B5E408", VA = "0x1B5E408")]
		public static bool PlaceDoor(int i, int j, int type, int style = 0)
		{
			return default(bool);
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0001B378 File Offset: 0x00019578
		[Token(Token = "0x600361D")]
		[Address(RVA = "0x1B5EF6C", Offset = "0x1B5EF6C", VA = "0x1B5EF6C")]
		public static bool CloseDoor(int i, int j, bool forced = false)
		{
			return default(bool);
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x0001B390 File Offset: 0x00019590
		[Token(Token = "0x600361E")]
		[Address(RVA = "0x1B5FE14", Offset = "0x1B5FE14", VA = "0x1B5FE14")]
		public static bool AddLifeCrystal(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0001B3A8 File Offset: 0x000195A8
		[Token(Token = "0x600361F")]
		[Address(RVA = "0x1B61074", Offset = "0x1B61074", VA = "0x1B61074")]
		public static bool AddManaCrystal(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003620")]
		[Address(RVA = "0x1B62420", Offset = "0x1B62420", VA = "0x1B62420")]
		public static void AddBeeLarva(int x, int y)
		{
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003621")]
		[Address(RVA = "0x1B628BC", Offset = "0x1B628BC", VA = "0x1B628BC")]
		public static void AddLihzahrdAltar(int x, int y)
		{
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003622")]
		[Address(RVA = "0x1B62F58", Offset = "0x1B62F58", VA = "0x1B62F58")]
		public static void AddShadowOrb(int x, int y, bool crimsonHeart)
		{
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003623")]
		[Address(RVA = "0x1B63A30", Offset = "0x1B63A30", VA = "0x1B63A30")]
		public static void AddHellHouses()
		{
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003624")]
		[Address(RVA = "0x1B69FF4", Offset = "0x1B69FF4", VA = "0x1B69FF4")]
		public static void HellFort(int i, int j, ushort tileType = 75, byte wallType = 14)
		{
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x0001B3C0 File Offset: 0x000195C0
		[Token(Token = "0x6003625")]
		[Address(RVA = "0x1B71910", Offset = "0x1B71910", VA = "0x1B71910")]
		public static bool HellFort_CanCrumbleWall(int dir, int x, int y, int[] wallX, int[] wallTop, int[] wallBottom)
		{
			return default(bool);
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003626")]
		[Address(RVA = "0x1B71CE4", Offset = "0x1B71CE4", VA = "0x1B71CE4")]
		public static void HellFort_AttemptToCrumbleWall(int x, int y, int[] wallX, int[] wallTop, int[] wallBottom)
		{
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003627")]
		[Address(RVA = "0x1B710E0", Offset = "0x1B710E0", VA = "0x1B710E0")]
		public static void HellFort_AttemptToPlaceDoor(ref bool needDoor, ref bool[,] doorExists, bool[] door, int x, int[] doorX, int[] doorY, ushort wallType, int doorStyle)
		{
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0001B3D8 File Offset: 0x000195D8
		[Token(Token = "0x6003628")]
		[Address(RVA = "0x1B71258", Offset = "0x1B71258", VA = "0x1B71258")]
		public static bool HellFort_AttemptToPlaceDoor(ref bool needDoor, int x, int y, int[] doorX, int[] doorY, ushort wallType, int doorStyle)
		{
			return default(bool);
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x1B720D0", Offset = "0x1B720D0", VA = "0x1B720D0")]
		public static void Unused_HellHouse(int i, int j, byte type = 76, byte wall = 13)
		{
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362A")]
		[Address(RVA = "0x1B74230", Offset = "0x1B74230", VA = "0x1B74230")]
		public static void Unused_HellHouse_Room(int i, int j, int width, int height, byte type = 76, byte wall = 13)
		{
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362B")]
		[Address(RVA = "0x1B74978", Offset = "0x1B74978", VA = "0x1B74978")]
		public static void templeCleaner(int x, int y)
		{
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0001B3F0 File Offset: 0x000195F0
		[Token(Token = "0x600362C")]
		[Address(RVA = "0x1B756D8", Offset = "0x1B756D8", VA = "0x1B756D8")]
		public static Vector2D templePather(Vector2D templePath, int destX, int destY)
		{
			return default(Vector2D);
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362D")]
		[Address(RVA = "0x1B75B14", Offset = "0x1B75B14", VA = "0x1B75B14")]
		public static void outerTempled(int x, int y)
		{
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x1B76248", Offset = "0x1B76248", VA = "0x1B76248")]
		public static void makeTemple(int x, int y, [Optional] GenerationProgress progress)
		{
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x1B7E7D4", Offset = "0x1B7E7D4", VA = "0x1B7E7D4")]
		public static void makeTemple_GenerateBricks(int numRooms, Rectangle[] roomRects, int[] roomDepths, bool forceStrictAngles, float progressCount, float progressPercentilePerLoop, [Optional] GenerationProgress progress)
		{
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x1B7EF20", Offset = "0x1B7EF20", VA = "0x1B7EF20")]
		private static void makeTemple_GenerateBricks_Line_StrictAngles(int startX, int startY, int endX, int endY, bool fillLeft, bool fillUpwards)
		{
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x1B7F3C8", Offset = "0x1B7F3C8", VA = "0x1B7F3C8")]
		private static void makeTemple_GenerateBricks_Line(int startX, int startY, int endX, int endY, bool fillLeft, bool fillUpwards)
		{
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x1B7FB64", Offset = "0x1B7FB64", VA = "0x1B7FB64")]
		private static void makeTemple_GenerateBricks_Line_FillY(bool fillUpwards, int lastXAdjusted, int currentX, int currentY)
		{
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x1B803AC", Offset = "0x1B803AC", VA = "0x1B803AC")]
		private static void makeTemple_GenerateBricks_Line_FillX(bool fillLeft, int lastYAdjusted, int currentX, int currentY)
		{
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x1B80BC8", Offset = "0x1B80BC8", VA = "0x1B80BC8")]
		public static void templePart2()
		{
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0001B408 File Offset: 0x00019608
		[Token(Token = "0x6003635")]
		[Address(RVA = "0x1B70F24", Offset = "0x1B70F24", VA = "0x1B70F24")]
		public static bool nearPicture(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0001B420 File Offset: 0x00019620
		[Token(Token = "0x6003636")]
		[Address(RVA = "0x1B701EC", Offset = "0x1B701EC", VA = "0x1B701EC")]
		public static bool nearPicture2(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x1B82D80", Offset = "0x1B82D80", VA = "0x1B82D80")]
		private static void ShimmerCleanUp()
		{
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003638")]
		[Address(RVA = "0x1B84DD0", Offset = "0x1B84DD0", VA = "0x1B84DD0")]
		public static void ShimmerRemoveWater()
		{
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x0001B438 File Offset: 0x00019638
		[Token(Token = "0x6003639")]
		[Address(RVA = "0x1B853F0", Offset = "0x1B853F0", VA = "0x1B853F0")]
		public static bool ShimmerMakeBiome(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363A")]
		[Address(RVA = "0x1B886A8", Offset = "0x1B886A8", VA = "0x1B886A8")]
		private static void ShimmerMakeBiomeOpening(int direction, int X, int Y, int caveOpeningSize)
		{
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x1B88E34", Offset = "0x1B88E34", VA = "0x1B88E34")]
		private static void Shimminate()
		{
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x1B852E8", Offset = "0x1B852E8", VA = "0x1B852E8")]
		public static void Shimmerator(int x, int y, bool jungle = false, bool lavaOk = false)
		{
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x1B89414", Offset = "0x1B89414", VA = "0x1B89414")]
		public static void ShimmeratorNext(int x, int y)
		{
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363E")]
		[Address(RVA = "0x1B8A698", Offset = "0x1B8A698", VA = "0x1B8A698")]
		private static void DungeonDesertCleanup(int x)
		{
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x0001B450 File Offset: 0x00019650
		[Token(Token = "0x600363F")]
		[Address(RVA = "0x1B70B90", Offset = "0x1B70B90", VA = "0x1B70B90")]
		public static PaintingEntry RandHellPicture()
		{
			return default(PaintingEntry);
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x0001B468 File Offset: 0x00019668
		[Token(Token = "0x6003640")]
		[Address(RVA = "0x1B8AD6C", Offset = "0x1B8AD6C", VA = "0x1B8AD6C")]
		public static PaintingEntry RandHousePictureDesert()
		{
			return default(PaintingEntry);
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x0001B480 File Offset: 0x00019680
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x1B8AFD4", Offset = "0x1B8AFD4", VA = "0x1B8AFD4")]
		public static PaintingEntry RandHousePicture()
		{
			return default(PaintingEntry);
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x0001B498 File Offset: 0x00019698
		[Token(Token = "0x6003642")]
		[Address(RVA = "0x1B8B620", Offset = "0x1B8B620", VA = "0x1B8B620")]
		public static bool PlaceSandTrap(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x0001B4B0 File Offset: 0x000196B0
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x1B8FB9C", Offset = "0x1B8FB9C", VA = "0x1B8FB9C")]
		public static bool AddBuriedChest(Point point, int contain = 0, bool notNearOtherChests = false, int Style = -1)
		{
			return default(bool);
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x0001B4C8 File Offset: 0x000196C8
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x1B8FC34", Offset = "0x1B8FC34", VA = "0x1B8FC34")]
		public static bool IsChestRigged(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x0001B4E0 File Offset: 0x000196E0
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x1B8FE40", Offset = "0x1B8FE40", VA = "0x1B8FE40")]
		private static bool IsUndergroundDesert(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0001B4F8 File Offset: 0x000196F8
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x1B9010C", Offset = "0x1B9010C", VA = "0x1B9010C")]
		private static bool IsDungeon(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x1B902D8", Offset = "0x1B902D8", VA = "0x1B902D8")]
		public static void GetDungeonLootAndChestStyle(int x, int y, ref int itemType, ref int chestStyle)
		{
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x0001B510 File Offset: 0x00019710
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x1B90504", Offset = "0x1B90504", VA = "0x1B90504")]
		public static bool IsLockedDungeonBiomeChest(ushort chestType, int chestStyle)
		{
			return default(bool);
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x0001B528 File Offset: 0x00019728
		[Token(Token = "0x6003649")]
		[Address(RVA = "0x1B3CE74", Offset = "0x1B3CE74", VA = "0x1B3CE74")]
		public static bool AddBuriedChest(int i, int j, int mainItemInChest = 0, bool notNearOtherChests = false, int chestStyle = -1, bool trySlope = false, ushort chestTileType = 0)
		{
			return default(bool);
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x0001B540 File Offset: 0x00019740
		[Token(Token = "0x600364A")]
		[Address(RVA = "0x1B90548", Offset = "0x1B90548", VA = "0x1B90548")]
		public static bool AddBuriedChest(int i, int j, out Point chestLocation, int mainItemInChest = 0, bool notNearOtherChests = false, int chestStyle = -1, bool trySlope = false, ushort chestTileType = 0)
		{
			return default(bool);
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x1B9EAF8", Offset = "0x1B9EAF8", VA = "0x1B9EAF8")]
		public static void AddVoiceChangeItemToChest(Chest chest, ref int itemIndex)
		{
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x1B9EBD4", Offset = "0x1B9EBD4", VA = "0x1B9EBD4")]
		public static void AddMonsterVoiceChangeItemToChest(Chest chest, ref int itemIndex)
		{
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x1B9ED38", Offset = "0x1B9ED38", VA = "0x1B9ED38")]
		public static void UnlockDoor(int i, int j)
		{
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x0001B558 File Offset: 0x00019758
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x1B9F3C4", Offset = "0x1B9F3C4", VA = "0x1B9F3C4")]
		public static bool OpenDoor(int i, int j, int direction)
		{
			return default(bool);
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x1BA10A8", Offset = "0x1BA10A8", VA = "0x1BA10A8")]
		public static void Check1xX(int x, int j, short type)
		{
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0001B570 File Offset: 0x00019770
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x1B5F894", Offset = "0x1B5F894", VA = "0x1B5F894")]
		public static bool ValidateTileSquareIsActiveAndOfType(int topLeftX, int topLeftY, int width, int height, int type)
		{
			return default(bool);
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x0001B588 File Offset: 0x00019788
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x1BA1C80", Offset = "0x1BA1C80", VA = "0x1BA1C80")]
		public static int GetRandomStatueStyleForStatueMimics()
		{
			return 0;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x0001B5A0 File Offset: 0x000197A0
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x1BA1DDC", Offset = "0x1BA1DDC", VA = "0x1BA1DDC")]
		public static int StatueStyleToItem(int style)
		{
			return 0;
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x1BA1F54", Offset = "0x1BA1F54", VA = "0x1BA1F54")]
		public static void Check2xX(int i, int j, ushort type)
		{
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x0001B5B8 File Offset: 0x000197B8
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x1BA3C6C", Offset = "0x1BA3C6C", VA = "0x1BA3C6C")]
		public static bool IsBelowANonHammeredPlatform(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x1B8811C", Offset = "0x1B8811C", VA = "0x1B8811C")]
		public static void PlaceTight(int x, int y, bool spiders = false)
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x1BA4600", Offset = "0x1BA4600", VA = "0x1BA4600")]
		public static void PlaceUncheckedStalactite(int x, int y, bool preferSmall, int variation, bool spiders)
		{
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x0001B5D0 File Offset: 0x000197D0
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x1BAC630", Offset = "0x1BAC630", VA = "0x1BAC630")]
		public static bool UpdateStalagtiteStyle(int x, int j)
		{
			return default(bool);
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x1BACD60", Offset = "0x1BACD60", VA = "0x1BACD60")]
		private static void GetDesiredStalagtiteStyle(int x, int j, out bool fail, out int desiredStyle, out int height, out int y)
		{
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x1BACB1C", Offset = "0x1BACB1C", VA = "0x1BACB1C")]
		private static void GetStalagtiteStyle(int x, int y, out int style, out bool fail)
		{
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x1BAD338", Offset = "0x1BAD338", VA = "0x1BAD338")]
		public static void CheckStalactiteEcho(int x, int j)
		{
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x0001B5E8 File Offset: 0x000197E8
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x1BADC28", Offset = "0x1BADC28", VA = "0x1BADC28")]
		private static int GetStalactiteEchoDrop(int x, int j, int style)
		{
			return 0;
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x0001B600 File Offset: 0x00019800
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x1BADCB4", Offset = "0x1BADCB4", VA = "0x1BADCB4")]
		public static bool InvalidTileForPilesOrSpeleothems(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365D")]
		[Address(RVA = "0x1BAB0C0", Offset = "0x1BAB0C0", VA = "0x1BAB0C0")]
		public static void CheckStalactite(int x, int j)
		{
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365E")]
		[Address(RVA = "0x1BAE000", Offset = "0x1BAE000", VA = "0x1BAE000")]
		public static void Place1xX(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0001B618 File Offset: 0x00019818
		[Token(Token = "0x600365F")]
		[Address(RVA = "0x1BAED14", Offset = "0x1BAED14", VA = "0x1BAED14")]
		public static int checkXmasTreeDrop(int x, int y, int obj)
		{
			return 0;
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003660")]
		[Address(RVA = "0x1BAFA24", Offset = "0x1BAFA24", VA = "0x1BAFA24")]
		public static void dropXmasTree(int x, int y, int obj)
		{
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003661")]
		[Address(RVA = "0x1BB0B00", Offset = "0x1BB0B00", VA = "0x1BB0B00")]
		public static void setXmasTree(int x, int y, int obj, int style)
		{
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x0001B630 File Offset: 0x00019830
		[Token(Token = "0x6003662")]
		[Address(RVA = "0x1BB1A4C", Offset = "0x1BB1A4C", VA = "0x1BB1A4C")]
		public static int PlaceXmasTree_Direct(int x, int y, int type, int style, int dir, int alternate)
		{
			return 0;
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003663")]
		[Address(RVA = "0x1BB1F84", Offset = "0x1BB1F84", VA = "0x1BB1F84")]
		public static void PlaceXmasTree(int x, int y, ushort type = 171)
		{
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003664")]
		[Address(RVA = "0x1BB2584", Offset = "0x1BB2584", VA = "0x1BB2584")]
		public static void CheckXmasTree(int x, int y)
		{
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003665")]
		[Address(RVA = "0x1BB2FF8", Offset = "0x1BB2FF8", VA = "0x1BB2FF8")]
		public static void Place2xX(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x0001B648 File Offset: 0x00019848
		[Token(Token = "0x6003666")]
		[Address(RVA = "0x1BB3790", Offset = "0x1BB3790", VA = "0x1BB3790")]
		public static int GetItemDrop_Candles(int style)
		{
			return 0;
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x0001B660 File Offset: 0x00019860
		[Token(Token = "0x6003667")]
		[Address(RVA = "0x1BB3800", Offset = "0x1BB3800", VA = "0x1BB3800")]
		public static int GetItemDrop_Beds(int style)
		{
			return 0;
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x0001B678 File Offset: 0x00019878
		[Token(Token = "0x6003668")]
		[Address(RVA = "0x1BA458C", Offset = "0x1BA458C", VA = "0x1BA458C")]
		public static int GetItemDrop_Clocks(int style)
		{
			return 0;
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0001B690 File Offset: 0x00019890
		[Token(Token = "0x6003669")]
		[Address(RVA = "0x1BB38A8", Offset = "0x1BB38A8", VA = "0x1BB38A8")]
		public static int GetItemDrop_Benches(int style)
		{
			return 0;
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0001B6A8 File Offset: 0x000198A8
		[Token(Token = "0x600366A")]
		[Address(RVA = "0x1BB38CC", Offset = "0x1BB38CC", VA = "0x1BB38CC")]
		public static int GetItemDrop_PicnicTables(int style)
		{
			return 0;
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x0001B6C0 File Offset: 0x000198C0
		[Token(Token = "0x600366B")]
		[Address(RVA = "0x1BB38EC", Offset = "0x1BB38EC", VA = "0x1BB38EC")]
		public static int GetItemDrop_Candelabras(int style)
		{
			return 0;
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x0001B6D8 File Offset: 0x000198D8
		[Token(Token = "0x600366C")]
		[Address(RVA = "0x1BB3954", Offset = "0x1BB3954", VA = "0x1BB3954")]
		public static int GetItemDrop_Bookcases(int style)
		{
			return 0;
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x0001B6F0 File Offset: 0x000198F0
		[Token(Token = "0x600366D")]
		[Address(RVA = "0x1BB39BC", Offset = "0x1BB39BC", VA = "0x1BB39BC")]
		public static int GetItemDrop_Chandeliers(int style)
		{
			return 0;
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x0001B708 File Offset: 0x00019908
		[Token(Token = "0x600366E")]
		[Address(RVA = "0x1BB3A38", Offset = "0x1BB3A38", VA = "0x1BB3A38")]
		public static int GetItemDrop_Lanterns(int style)
		{
			return 0;
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x0001B720 File Offset: 0x00019920
		[Token(Token = "0x600366F")]
		[Address(RVA = "0x1BA1C18", Offset = "0x1BA1C18", VA = "0x1BA1C18")]
		public static int GetItemDrop_Lamps(int style)
		{
			return 0;
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x0001B738 File Offset: 0x00019938
		[Token(Token = "0x6003670")]
		[Address(RVA = "0x1BB3AD4", Offset = "0x1BB3AD4", VA = "0x1BB3AD4")]
		public static int GetItemDrop_Bottles(int style)
		{
			return 0;
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0001B750 File Offset: 0x00019950
		[Token(Token = "0x6003671")]
		[Address(RVA = "0x1BB3B08", Offset = "0x1BB3B08", VA = "0x1BB3B08")]
		public static int GetItemDrop_Pianos(int style)
		{
			return 0;
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x0001B768 File Offset: 0x00019968
		[Token(Token = "0x6003672")]
		[Address(RVA = "0x1BB3BA4", Offset = "0x1BB3BA4", VA = "0x1BB3BA4")]
		public static int GetItemDrop_Sinks(int style)
		{
			return 0;
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x0001B780 File Offset: 0x00019980
		[Token(Token = "0x6003673")]
		[Address(RVA = "0x1BB3BE8", Offset = "0x1BB3BE8", VA = "0x1BB3BE8")]
		public static int GetItemDrop_Chests(int style, bool secondType)
		{
			return 0;
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0001B798 File Offset: 0x00019998
		[Token(Token = "0x6003674")]
		[Address(RVA = "0x1BB3C30", Offset = "0x1BB3C30", VA = "0x1BB3C30")]
		public static int GetItemDrop_FakeChests(int style, bool secondType)
		{
			return 0;
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x0001B7B0 File Offset: 0x000199B0
		[Token(Token = "0x6003675")]
		[Address(RVA = "0x1BB3C78", Offset = "0x1BB3C78", VA = "0x1BB3C78")]
		public static int GetItemDrop_Tables(int style, bool secondType)
		{
			return 0;
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x0001B7C8 File Offset: 0x000199C8
		[Token(Token = "0x6003676")]
		[Address(RVA = "0x1BB3D3C", Offset = "0x1BB3D3C", VA = "0x1BB3D3C")]
		public static int GetItemDrop_Bathtubs(int style)
		{
			return 0;
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x0001B7E0 File Offset: 0x000199E0
		[Token(Token = "0x6003677")]
		[Address(RVA = "0x1BB401C", Offset = "0x1BB401C", VA = "0x1BB401C")]
		public static int GetItemDrop_Workbenches(int style)
		{
			return 0;
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x0001B7F8 File Offset: 0x000199F8
		[Token(Token = "0x6003678")]
		[Address(RVA = "0x1BB4078", Offset = "0x1BB4078", VA = "0x1BB4078")]
		public static int GetItemDrop_Chair(int style)
		{
			return 0;
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x0001B810 File Offset: 0x00019A10
		[Token(Token = "0x6003679")]
		[Address(RVA = "0x1BB409C", Offset = "0x1BB409C", VA = "0x1BB409C")]
		public static int GetItemDrop_Toilet(int style)
		{
			return 0;
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x0001B828 File Offset: 0x00019A28
		[Token(Token = "0x600367A")]
		[Address(RVA = "0x1BB40D0", Offset = "0x1BB40D0", VA = "0x1BB40D0")]
		public static int GetItemDrop_Platforms(int style)
		{
			return 0;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x0001B840 File Offset: 0x00019A40
		[Token(Token = "0x600367B")]
		[Address(RVA = "0x1BB4138", Offset = "0x1BB4138", VA = "0x1BB4138")]
		public static int GetItemDrop_MusicBoxes(int style)
		{
			return 0;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367C")]
		[Address(RVA = "0x1BB41A8", Offset = "0x1BB41A8", VA = "0x1BB41A8")]
		public static void Check1x2(int x, int j, ushort type)
		{
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367D")]
		[Address(RVA = "0x1BB55DC", Offset = "0x1BB55DC", VA = "0x1BB55DC")]
		public static void CheckOnTable1x1(int x, int y, int type)
		{
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367E")]
		[Address(RVA = "0x1BB6F7C", Offset = "0x1BB6F7C", VA = "0x1BB6F7C")]
		public static void CheckSign(int x, int y, ushort type)
		{
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x0001B858 File Offset: 0x00019A58
		[Token(Token = "0x600367F")]
		[Address(RVA = "0x1BBA96C", Offset = "0x1BBA96C", VA = "0x1BBA96C")]
		public static bool PlaceSign(int x, int y, ushort type, int Style = 0)
		{
			return default(bool);
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x0001B870 File Offset: 0x00019A70
		[Token(Token = "0x6003680")]
		[Address(RVA = "0x1BBC658", Offset = "0x1BBC658", VA = "0x1BBC658")]
		public static bool Place2x2Horizontal(int x, int y, ushort type, int Style = 0)
		{
			return default(bool);
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x0001B888 File Offset: 0x00019A88
		[Token(Token = "0x6003681")]
		[Address(RVA = "0x1BBCD90", Offset = "0x1BBCD90", VA = "0x1BBCD90")]
		public static Color paintColor(int color)
		{
			return default(Color);
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x0001B8A0 File Offset: 0x00019AA0
		[Token(Token = "0x6003682")]
		[Address(RVA = "0x1BBCF7C", Offset = "0x1BBCF7C", VA = "0x1BBCF7C")]
		public static Color coatingColor(int coating)
		{
			return default(Color);
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003683")]
		[Address(RVA = "0x1BBD054", Offset = "0x1BBD054", VA = "0x1BBD054")]
		public static List<Color> coatingColors(Tile tile, bool block)
		{
			return null;
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003684")]
		[Address(RVA = "0x1BBD55C", Offset = "0x1BBD55C", VA = "0x1BBD55C")]
		public static void paintEffect(int x, int y, byte color, byte oldColor)
		{
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003685")]
		[Address(RVA = "0x1BBD838", Offset = "0x1BBD838", VA = "0x1BBD838")]
		public static void paintCoatEffect(int x, int y, byte paintCoatId, List<Color> oldColors)
		{
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		[Token(Token = "0x6003686")]
		[Address(RVA = "0x1A8B7A0", Offset = "0x1A8B7A0", VA = "0x1A8B7A0")]
		public static bool paintTile(int x, int y, byte color, bool broadCast = false, bool paintEffects = true)
		{
			return default(bool);
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x0001B8D0 File Offset: 0x00019AD0
		[Token(Token = "0x6003687")]
		[Address(RVA = "0x1A8BB9C", Offset = "0x1A8BB9C", VA = "0x1A8BB9C")]
		public static bool paintCoatTile(int x, int y, byte paintCoatId, bool broadcast = false, bool coatingEffects = true)
		{
			return default(bool);
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		[Token(Token = "0x6003688")]
		[Address(RVA = "0x1BBDBC4", Offset = "0x1BBDBC4", VA = "0x1BBDBC4")]
		public static bool paintCoatWall(int x, int y, byte paintCoatId, bool broadcast = false, bool coatingEffects = true)
		{
			return default(bool);
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x0001B900 File Offset: 0x00019B00
		[Token(Token = "0x6003689")]
		[Address(RVA = "0x1BBE2C0", Offset = "0x1BBE2C0", VA = "0x1BBE2C0")]
		public static bool paintWall(int x, int y, byte color, bool broadCast = false, bool paintEffects = true)
		{
			return default(bool);
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368A")]
		[Address(RVA = "0x1BBE6A0", Offset = "0x1BBE6A0", VA = "0x1BBE6A0")]
		public static void Place3x3Wall(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368B")]
		[Address(RVA = "0x1BBEC44", Offset = "0x1BBEC44", VA = "0x1BBEC44")]
		public static void Check3x3Wall(int x, int y)
		{
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368C")]
		[Address(RVA = "0x1BC06A0", Offset = "0x1BC06A0", VA = "0x1BC06A0")]
		public static void Place2x3Wall(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368D")]
		[Address(RVA = "0x1BC0BAC", Offset = "0x1BC0BAC", VA = "0x1BC0BAC")]
		public static void Check2x3Wall(int x, int y)
		{
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368E")]
		[Address(RVA = "0x1BC19AC", Offset = "0x1BC19AC", VA = "0x1BC19AC")]
		public static void Place3x2Wall(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368F")]
		[Address(RVA = "0x1BC1EA4", Offset = "0x1BC1EA4", VA = "0x1BC1EA4")]
		public static void Check3x2Wall(int x, int y)
		{
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003690")]
		[Address(RVA = "0x1BC29C4", Offset = "0x1BC29C4", VA = "0x1BC29C4")]
		public static void Place4x3Wall(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003691")]
		[Address(RVA = "0x1BC2EE4", Offset = "0x1BC2EE4", VA = "0x1BC2EE4")]
		public static void Check4x3Wall(int x, int y)
		{
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003692")]
		[Address(RVA = "0x1BC3830", Offset = "0x1BC3830", VA = "0x1BC3830")]
		public static void Place6x4Wall(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003693")]
		[Address(RVA = "0x1BC3D7C", Offset = "0x1BC3D7C", VA = "0x1BC3D7C")]
		public static void Check6x4Wall(int x, int y)
		{
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x0001B918 File Offset: 0x00019B18
		[Token(Token = "0x6003694")]
		[Address(RVA = "0x1BC51F8", Offset = "0x1BC51F8", VA = "0x1BC51F8")]
		private static int RollRandomSeaShellStyle()
		{
			return 0;
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003695")]
		[Address(RVA = "0x1BC5438", Offset = "0x1BC5438", VA = "0x1BC5438")]
		public static void Place1x1(int x, int y, int type, int style = 0)
		{
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003696")]
		[Address(RVA = "0x1BC5DA0", Offset = "0x1BC5DA0", VA = "0x1BC5DA0")]
		public static void Check1x1(int x, int y, int type)
		{
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003697")]
		[Address(RVA = "0x1BC6378", Offset = "0x1BC6378", VA = "0x1BC6378")]
		public static void CheckGolf1x1(int x, int y, int type)
		{
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003698")]
		[Address(RVA = "0x1BC65D8", Offset = "0x1BC65D8", VA = "0x1BC65D8")]
		public static void CheckLogicTiles(int x, int y, int type)
		{
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003699")]
		[Address(RVA = "0x1BC69FC", Offset = "0x1BC69FC", VA = "0x1BC69FC")]
		public static void PlaceLogicTiles(int x, int y, int type, int style = 0)
		{
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369A")]
		[Address(RVA = "0x1BC712C", Offset = "0x1BC712C", VA = "0x1BC712C")]
		public static void PlaceOnTable1x1(int x, int y, int type, int style = 0)
		{
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x0001B930 File Offset: 0x00019B30
		[Token(Token = "0x600369B")]
		[Address(RVA = "0x1BC7C78", Offset = "0x1BC7C78", VA = "0x1BC7C78")]
		public static bool PlaceAlch(int x, int y, int style)
		{
			return default(bool);
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369C")]
		[Address(RVA = "0x1BC9334", Offset = "0x1BC9334", VA = "0x1BC9334")]
		public static void GrowSpike(int i, int j, ushort spikeType, ushort landType)
		{
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x0001B948 File Offset: 0x00019B48
		[Token(Token = "0x600369D")]
		[Address(RVA = "0x1BCAF8C", Offset = "0x1BCAF8C", VA = "0x1BCAF8C")]
		private static bool GrowMoreVines(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369E")]
		[Address(RVA = "0x1BCB3A0", Offset = "0x1BCB3A0", VA = "0x1BCB3A0")]
		private static void GrowGlowTulips()
		{
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369F")]
		[Address(RVA = "0x1BCBDA0", Offset = "0x1BCBDA0", VA = "0x1BCBDA0")]
		private static void PlaceChilletEggs()
		{
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0001B960 File Offset: 0x00019B60
		[Token(Token = "0x60036A0")]
		[Address(RVA = "0x1BCC6A8", Offset = "0x1BCC6A8", VA = "0x1BCC6A8")]
		private static bool NoNearbyChilletEggs(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x0001B978 File Offset: 0x00019B78
		[Token(Token = "0x60036A1")]
		[Address(RVA = "0x1BCC094", Offset = "0x1BCC094", VA = "0x1BCC094")]
		private static bool TryPlacingChilletEgg(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x0001B990 File Offset: 0x00019B90
		[Token(Token = "0x60036A2")]
		[Address(RVA = "0x1BCC9C4", Offset = "0x1BCC9C4", VA = "0x1BCC9C4")]
		private static bool HasValidGroundForChilletEggBelowSpot(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A3")]
		[Address(RVA = "0x1BCCD78", Offset = "0x1BCCD78", VA = "0x1BCCD78")]
		private static void MatureTheHerbPlants()
		{
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A4")]
		[Address(RVA = "0x1BCD818", Offset = "0x1BCD818", VA = "0x1BCD818")]
		public static void GrowAlch(int x, int y)
		{
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A5")]
		[Address(RVA = "0x1BCEF90", Offset = "0x1BCEF90", VA = "0x1BCEF90")]
		public static void PlantAlch()
		{
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A6")]
		[Address(RVA = "0x1BCF9CC", Offset = "0x1BCF9CC", VA = "0x1BCF9CC")]
		public static void PlaceSuitableHerbHere(int x, int y)
		{
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A7")]
		[Address(RVA = "0x1BD0A4C", Offset = "0x1BD0A4C", VA = "0x1BD0A4C")]
		public static void CheckAlch(int x, int y)
		{
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A8")]
		[Address(RVA = "0x1BD2E78", Offset = "0x1BD2E78", VA = "0x1BD2E78")]
		public static void CheckBanner(int x, int j, byte type)
		{
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A9")]
		[Address(RVA = "0x1BD462C", Offset = "0x1BD462C", VA = "0x1BD462C")]
		public static void PlaceBanner(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AA")]
		[Address(RVA = "0x1BD5240", Offset = "0x1BD5240", VA = "0x1BD5240")]
		public static void PlaceMan(int i, int j, int dir)
		{
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AB")]
		[Address(RVA = "0x1BD5F14", Offset = "0x1BD5F14", VA = "0x1BD5F14")]
		public static void PlaceWoman(int i, int j, int dir)
		{
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AC")]
		[Address(RVA = "0x1BD6BE8", Offset = "0x1BD6BE8", VA = "0x1BD6BE8")]
		public static void CheckWeaponsRack(int i, int j)
		{
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AD")]
		[Address(RVA = "0x1BD77C0", Offset = "0x1BD77C0", VA = "0x1BD77C0")]
		public static void ToggleGemLock(int i, int j, bool on)
		{
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AE")]
		[Address(RVA = "0x1BD81B0", Offset = "0x1BD81B0", VA = "0x1BD81B0")]
		public static void CheckMan(int i, int j)
		{
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AF")]
		[Address(RVA = "0x1BD8BC4", Offset = "0x1BD8BC4", VA = "0x1BD8BC4")]
		public static void CheckWoman(int i, int j)
		{
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B0")]
		[Address(RVA = "0x1BD95E0", Offset = "0x1BD95E0", VA = "0x1BD95E0")]
		public static void Place1x2(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B1")]
		[Address(RVA = "0x1BD9C28", Offset = "0x1BD9C28", VA = "0x1BD9C28")]
		public static void Place1x2Top(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B2")]
		[Address(RVA = "0x1BDA3B8", Offset = "0x1BDA3B8", VA = "0x1BDA3B8")]
		public static void Check1x2Top(int x, int j, ushort type)
		{
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0001B9A8 File Offset: 0x00019BA8
		[Token(Token = "0x60036B3")]
		[Address(RVA = "0x1ABC58C", Offset = "0x1ABC58C", VA = "0x1ABC58C")]
		public static bool PlaceSmallPile(int i, int j, int pileStyle, int pileSize, ushort type = 185)
		{
			return default(bool);
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B4")]
		[Address(RVA = "0x1BDB8DC", Offset = "0x1BDB8DC", VA = "0x1BDB8DC")]
		public static void CheckPile(int i, int y)
		{
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B5")]
		[Address(RVA = "0x1BDC05C", Offset = "0x1BDC05C", VA = "0x1BDC05C")]
		public static void Check2x1(int i, int y, ushort type)
		{
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B6")]
		[Address(RVA = "0x1BE0D08", Offset = "0x1BE0D08", VA = "0x1BE0D08")]
		public static void Place2x1(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B7")]
		[Address(RVA = "0x1BE19AC", Offset = "0x1BE19AC", VA = "0x1BE19AC")]
		public static void Check4x2(int i, int j, int type)
		{
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		[Token(Token = "0x60036B8")]
		[Address(RVA = "0x1BE2CA8", Offset = "0x1BE2CA8", VA = "0x1BE2CA8")]
		private static bool OasisPlantWaterCheck(int x, int y, bool boost = false)
		{
			return default(bool);
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B9")]
		[Address(RVA = "0x1BE2F90", Offset = "0x1BE2F90", VA = "0x1BE2F90")]
		public static void PlaceOasisPlant(int X, int Y, ushort type = 530)
		{
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BA")]
		[Address(RVA = "0x1BE43B4", Offset = "0x1BE43B4", VA = "0x1BE43B4")]
		public static void CheckOasisPlant(int i, int j, int type = 530)
		{
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BB")]
		[Address(RVA = "0x1BE4FC4", Offset = "0x1BE4FC4", VA = "0x1BE4FC4")]
		public static void GetCactusType(int tileX, int tileY, int frameX, int frameY, out bool evil, out bool good, out bool crimson)
		{
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BC")]
		[Address(RVA = "0x1BE5854", Offset = "0x1BE5854", VA = "0x1BE5854")]
		public static void GetBiomeInfluence(int startX, int endX, int startY, int endY, out int corruptCount, out int crimsonCount, out int hallowedCount)
		{
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BD")]
		[Address(RVA = "0x1BE5C98", Offset = "0x1BE5C98", VA = "0x1BE5C98")]
		public static void PlaceJunglePlant(int X2, int Y2, ushort type, int styleX, int styleY, bool inheritPaint)
		{
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BE")]
		[Address(RVA = "0x1BE8B04", Offset = "0x1BE8B04", VA = "0x1BE8B04")]
		public static void CheckJunglePlant(int i, int j, int type)
		{
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x1BEA814", Offset = "0x1BEA814", VA = "0x1BEA814")]
		public static void CheckSuper(int x, int y, int type)
		{
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C0")]
		[Address(RVA = "0x1BEC438", Offset = "0x1BEC438", VA = "0x1BEC438")]
		public static void Check2x2(int i, int j, int type)
		{
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x0001B9D8 File Offset: 0x00019BD8
		[Token(Token = "0x60036C1")]
		[Address(RVA = "0x1BEF5F8", Offset = "0x1BEF5F8", VA = "0x1BEF5F8")]
		public static bool CheckBoulderChest(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		[Token(Token = "0x60036C2")]
		[Address(RVA = "0x1BEFD18", Offset = "0x1BEFD18", VA = "0x1BEFD18")]
		public static bool IsAContainer(Tile t)
		{
			return default(bool);
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C3")]
		[Address(RVA = "0x1BF0088", Offset = "0x1BF0088", VA = "0x1BF0088")]
		public static void OreRunner(int i, int j, double strength, int steps, int tileType = -1, int wallType = -1, [Optional] Rectangle? stayInArea, int onlyReplaceTileType = -1, int onlyReplaceWallType = -1)
		{
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C4")]
		[Address(RVA = "0x1BF2640", Offset = "0x1BF2640", VA = "0x1BF2640")]
		public static void SmashAltar(int i, int j)
		{
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C5")]
		[Address(RVA = "0x1BF3CA4", Offset = "0x1BF3CA4", VA = "0x1BF3CA4")]
		public static void Check3x1(int i, int j, int type)
		{
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x1BF5B70", Offset = "0x1BF5B70", VA = "0x1BF5B70")]
		public static void Check3x2(int i, int j, int type)
		{
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x0001BA08 File Offset: 0x00019C08
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x1BFDEF0", Offset = "0x1BFDEF0", VA = "0x1BFDEF0")]
		public static int GetItemDrop_Dressers(int style)
		{
			return 0;
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x0001BA20 File Offset: 0x00019C20
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x1BFDE64", Offset = "0x1BFDE64", VA = "0x1BFDE64")]
		private static int GetCampfireItemDrop(int style)
		{
			return 0;
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x1BFDF60", Offset = "0x1BFDF60", VA = "0x1BFDF60")]
		public static void Check3x4(int i, int j, int type)
		{
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CA")]
		[Address(RVA = "0x1BFEC10", Offset = "0x1BFEC10", VA = "0x1BFEC10")]
		public static void Check5x4(int i, int j, int type)
		{
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x1BFF7EC", Offset = "0x1BFF7EC", VA = "0x1BFF7EC")]
		public static void Check6x3(int i, int j, int type)
		{
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x1C0112C", Offset = "0x1C0112C", VA = "0x1C0112C")]
		public static void Place6x3(int x, int y, ushort type, int direction = -1, int style = 0)
		{
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x1B6EF4C", Offset = "0x1B6EF4C", VA = "0x1B6EF4C")]
		public static void Place4x2(int x, int y, ushort type, int direction = -1, int style = 0)
		{
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x1C01854", Offset = "0x1C01854", VA = "0x1C01854")]
		public static void ShootFromCannon(int x, int y, int angle, int ammo, int Damage, float KnockBack, int owner, bool fromWire)
		{
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x0001BA38 File Offset: 0x00019C38
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x1C01D18", Offset = "0x1C01D18", VA = "0x1C01D18")]
		public static bool BunnyCannonCanFire()
		{
			return default(bool);
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x1C01EA8", Offset = "0x1C01EA8", VA = "0x1C01EA8")]
		public static void SwitchCannon(int i, int j)
		{
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x1C02604", Offset = "0x1C02604", VA = "0x1C02604")]
		public static void CheckCannon(int i, int j, int type)
		{
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D2")]
		[Address(RVA = "0x1C0317C", Offset = "0x1C0317C", VA = "0x1C0317C")]
		public static void PlaceCannon(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x1AE555C", Offset = "0x1AE555C", VA = "0x1AE555C")]
		public static void SwitchMB(int i, int j)
		{
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D4")]
		[Address(RVA = "0x1AE43E0", Offset = "0x1AE43E0", VA = "0x1AE43E0")]
		public static void SwitchMonolith(int i, int j)
		{
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D5")]
		[Address(RVA = "0x1C049A8", Offset = "0x1C049A8", VA = "0x1C049A8")]
		public static void SwitchFountain(int i, int j)
		{
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D6")]
		[Address(RVA = "0x1C050C4", Offset = "0x1C050C4", VA = "0x1C050C4")]
		public static void CheckMB(int i, int j, int type)
		{
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x1C05E74", Offset = "0x1C05E74", VA = "0x1C05E74")]
		public static void PlaceMB(int X, int y, ushort type, int style)
		{
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x1C06BAC", Offset = "0x1C06BAC", VA = "0x1C06BAC")]
		public static void Place2x2(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x0001BA50 File Offset: 0x00019C50
		[Token(Token = "0x60036D9")]
		[Address(RVA = "0x1C07DF8", Offset = "0x1C07DF8", VA = "0x1C07DF8")]
		public static bool PlaceObject(int x, int y, int type, bool mute = false, int style = 0, int alternate = 0, int random = -1, int direction = -1)
		{
			return default(bool);
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x0001BA68 File Offset: 0x00019C68
		[Token(Token = "0x60036DA")]
		[Address(RVA = "0x1C07FA8", Offset = "0x1C07FA8", VA = "0x1C07FA8")]
		public static bool ShiftTrapdoor(int x, int y, bool playerAbove, int onlyCloseOrOpen = -1)
		{
			return default(bool);
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DB")]
		[Address(RVA = "0x1C0A24C", Offset = "0x1C0A24C", VA = "0x1C0A24C")]
		public static void CheckTrapDoor(int x, int y, int type)
		{
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DC")]
		[Address(RVA = "0x1C0AF8C", Offset = "0x1C0AF8C", VA = "0x1C0AF8C")]
		public static void CheckTallGate(int x, int y, int type)
		{
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x0001BA80 File Offset: 0x00019C80
		[Token(Token = "0x60036DD")]
		[Address(RVA = "0x1C0B9BC", Offset = "0x1C0B9BC", VA = "0x1C0B9BC")]
		public static bool ShiftTallGate(int x, int y, bool closing, bool forced = false)
		{
			return default(bool);
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x0001BA98 File Offset: 0x00019C98
		[Token(Token = "0x60036DE")]
		[Address(RVA = "0x1C09E9C", Offset = "0x1C09E9C", VA = "0x1C09E9C")]
		public static Point GetTopLeftAndStyles(ref int x, ref int y, int w, int h, int frameXinc, int frameYinc)
		{
			return default(Point);
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x0001BAB0 File Offset: 0x00019CB0
		[Token(Token = "0x60036DF")]
		[Address(RVA = "0x1C0A7D8", Offset = "0x1C0A7D8", VA = "0x1C0A7D8")]
		public static bool CheckTileFrames(int type, int sx, int sy, int w, int h, int styleX, int frameXinc, int styleY, int frameYinc)
		{
			return default(bool);
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0x1C0AB04", Offset = "0x1C0AB04", VA = "0x1C0AB04")]
		public static bool CheckTileAnchors(int sx, int sy, int w, int h, int mode, AnchorType anchor)
		{
			return default(bool);
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0x1BB6050", Offset = "0x1BB6050", VA = "0x1BB6050")]
		public static bool AnchorValid(Tile tileCache, AnchorType anchor)
		{
			return default(bool);
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0x1C07B1C", Offset = "0x1C07B1C", VA = "0x1C07B1C")]
		public static bool CanPlaceSink(int x, int y, ushort type, int style)
		{
			return default(bool);
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E3")]
		[Address(RVA = "0x1C0C498", Offset = "0x1C0C498", VA = "0x1C0C498")]
		public static void Place3x4(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E4")]
		[Address(RVA = "0x1C0CD60", Offset = "0x1C0CD60", VA = "0x1C0CD60")]
		public static void Place5x4(int x, int y, ushort type, int style)
		{
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E5")]
		[Address(RVA = "0x1C0D9F0", Offset = "0x1C0D9F0", VA = "0x1C0D9F0")]
		public static void Place3x1(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E6")]
		[Address(RVA = "0x1C0E1DC", Offset = "0x1C0E1DC", VA = "0x1C0E1DC")]
		public static void Place3x2(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E7")]
		[Address(RVA = "0x1C0FB54", Offset = "0x1C0FB54", VA = "0x1C0FB54")]
		public static void Place2x2Style(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x0001BB10 File Offset: 0x00019D10
		[Token(Token = "0x60036E8")]
		[Address(RVA = "0x1C10A14", Offset = "0x1C10A14", VA = "0x1C10A14")]
		public static bool NearFriendlyWall(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E9")]
		[Address(RVA = "0x1C1131C", Offset = "0x1C1131C", VA = "0x1C1131C")]
		public static void Check2x2Style(int i, int j, int type)
		{
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EA")]
		[Address(RVA = "0x1C12708", Offset = "0x1C12708", VA = "0x1C12708")]
		public static void PlacePumpkin(int x, int superY)
		{
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EB")]
		[Address(RVA = "0x1C138A0", Offset = "0x1C138A0", VA = "0x1C138A0")]
		public static void GrowPumpkin(int i, int j, int type)
		{
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EC")]
		[Address(RVA = "0x1C14540", Offset = "0x1C14540", VA = "0x1C14540")]
		public static void FixHearts()
		{
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036ED")]
		[Address(RVA = "0x1C159E0", Offset = "0x1C159E0", VA = "0x1C159E0")]
		public static void DestroyHeart(int i, int j)
		{
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x1C14898", Offset = "0x1C14898", VA = "0x1C14898")]
		public static void FixHeart(int i, int j)
		{
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x1C15CE8", Offset = "0x1C15CE8", VA = "0x1C15CE8")]
		public static void FixChands()
		{
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x1C1603C", Offset = "0x1C1603C", VA = "0x1C1603C")]
		public static void FixChand(int i, int j)
		{
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x1C16784", Offset = "0x1C16784", VA = "0x1C16784")]
		public static void PlaceChand(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F2")]
		[Address(RVA = "0x1C17D10", Offset = "0x1C17D10", VA = "0x1C17D10")]
		public static void CheckChand(int i, int j, int type)
		{
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x1C1943C", Offset = "0x1C1943C", VA = "0x1C1943C")]
		public static void Check4x4(int i, int j, int type)
		{
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F4")]
		[Address(RVA = "0x1C1A134", Offset = "0x1C1A134", VA = "0x1C1A134")]
		public static void Check3x3(int i, int j, int type)
		{
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x1C1C0B4", Offset = "0x1C1C0B4", VA = "0x1C1C0B4")]
		public static void Check2x5(int i, int j, int type)
		{
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x1C1CD00", Offset = "0x1C1CD00", VA = "0x1C1CD00")]
		public static void Check3x5(int i, int j, int type)
		{
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x1C1D928", Offset = "0x1C1D928", VA = "0x1C1D928")]
		public static void Check3x6(int i, int j, int type)
		{
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x1C1E5F8", Offset = "0x1C1E5F8", VA = "0x1C1E5F8")]
		public static void Place3x3(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x1C1FEAC", Offset = "0x1C1FEAC", VA = "0x1C1FEAC")]
		public static void PlaceSunflower(int x, int y, ushort type = 27)
		{
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0x1C20938", Offset = "0x1C20938", VA = "0x1C20938")]
		public static void FixSunflowers()
		{
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FB")]
		[Address(RVA = "0x1C20BEC", Offset = "0x1C20BEC", VA = "0x1C20BEC")]
		public static void FixSunflower(int i, int j)
		{
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FC")]
		[Address(RVA = "0x1C21180", Offset = "0x1C21180", VA = "0x1C21180")]
		public static void CheckSunflower(int i, int j, int type = 27)
		{
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FD")]
		[Address(RVA = "0x1C2212C", Offset = "0x1C2212C", VA = "0x1C2212C")]
		public static void CheckDye(int x, int y)
		{
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x1C22484", Offset = "0x1C22484", VA = "0x1C22484")]
		public static void CheckRockGolemHead(int x, int y)
		{
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x1C22530", Offset = "0x1C22530", VA = "0x1C22530")]
		public static void CheckAnchor(int x, int y)
		{
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x0001BB28 File Offset: 0x00019D28
		[Token(Token = "0x6003700")]
		[Address(RVA = "0x1C22760", Offset = "0x1C22760", VA = "0x1C22760")]
		public static bool ValidateOrAttemptReorientingAnchor(int x, int y, int wall, ref int style, bool switchToWallIfInvalid = false)
		{
			return default(bool);
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x0001BB40 File Offset: 0x00019D40
		[Token(Token = "0x6003701")]
		[Address(RVA = "0x1C22B7C", Offset = "0x1C22B7C", VA = "0x1C22B7C")]
		private static bool ConsideredSolidTileForAnchor(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003702")]
		[Address(RVA = "0x1C23908", Offset = "0x1C23908", VA = "0x1C23908")]
		public static void CheckStinkbugBlocker(int x, int y)
		{
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003703")]
		[Address(RVA = "0x1C23BA4", Offset = "0x1C23BA4", VA = "0x1C23BA4")]
		public static void CheckGnome(int x, int j)
		{
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x1C24348", Offset = "0x1C24348", VA = "0x1C24348")]
		public static void PlaceGnome(int x, int y, int style)
		{
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x1C243D8", Offset = "0x1C243D8", VA = "0x1C243D8")]
		public static void PlaceDye(int x, int y, int style)
		{
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x0001BB58 File Offset: 0x00019D58
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x1B3CFB0", Offset = "0x1B3CFB0", VA = "0x1B3CFB0")]
		public static bool PlacePot(int x, int y, ushort type = 28, int style = 0)
		{
			return default(bool);
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x0001BB70 File Offset: 0x00019D70
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x1C26370", Offset = "0x1C26370", VA = "0x1C26370")]
		public static bool CheckCactus(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x1C27FFC", Offset = "0x1C27FFC", VA = "0x1C27FFC")]
		public static void PlantCactus(int i, int j)
		{
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003709")]
		[Address(RVA = "0x1C2B0C0", Offset = "0x1C2B0C0", VA = "0x1C2B0C0")]
		public static void CheckOrb(int i, int j, int type)
		{
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370A")]
		[Address(RVA = "0x1C2C778", Offset = "0x1C2C778", VA = "0x1C2C778")]
		public static void CheckPalmTree(int i, int j)
		{
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370B")]
		[Address(RVA = "0x1C2D2C4", Offset = "0x1C2D2C4", VA = "0x1C2D2C4")]
		public static void CheckTreeWithSettings(int x, int y, WorldGen.CheckTreeSettings settings)
		{
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x1C2FF30", Offset = "0x1C2FF30", VA = "0x1C2FF30")]
		public static void CheckTree(int i, int j)
		{
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x0001BB88 File Offset: 0x00019D88
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x1C33664", Offset = "0x1C33664", VA = "0x1C33664")]
		public static bool TileIsExposedToAir(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x1C33A58", Offset = "0x1C33A58", VA = "0x1C33A58")]
		public static bool TryConvertingOrKillingTreesAboveIfTheyWouldBecomeInvalid(int i, int j, int newFloorType)
		{
			return default(bool);
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x1C347B8", Offset = "0x1C347B8", VA = "0x1C347B8")]
		public static void ConvertTreeAndGround(int x, int y, int newFloorType, int oldTreeType, int newTreeType)
		{
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003710")]
		[Address(RVA = "0x1C35DC0", Offset = "0x1C35DC0", VA = "0x1C35DC0")]
		private static void ConvertTreeAndGround_Branches(int x, int y, int newType)
		{
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x1B850B8", Offset = "0x1B850B8", VA = "0x1B850B8")]
		public static void Convert(int i, int j, int conversionType, int size, bool tiles = true, bool walls = true)
		{
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003712")]
		[Address(RVA = "0x1AFB8B4", Offset = "0x1AFB8B4", VA = "0x1AFB8B4")]
		public static void Convert(int i2, int j2, int conversionType, bool tiles = true, bool walls = true)
		{
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003713")]
		[Address(RVA = "0x1C363F8", Offset = "0x1C363F8", VA = "0x1C363F8")]
		public static void Convert_ActuallyConvertTorch(int conversionType, int x, int y, ref Tile theTile, int newStyle)
		{
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003714")]
		[Address(RVA = "0x1C36820", Offset = "0x1C36820", VA = "0x1C36820")]
		private static void Convert_ActuallyConvertTile(int conversionType, int x, int y, ref Tile theTile, int newType)
		{
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003715")]
		[Address(RVA = "0x1C360BC", Offset = "0x1C360BC", VA = "0x1C360BC")]
		private static void Convert_ActuallyConvertWall(int conversionType, int x, int y, ref Tile theTile, int newType)
		{
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x1C36E80", Offset = "0x1C36E80", VA = "0x1C36E80")]
		public static void CactusFrame(int i, int j)
		{
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x1C28198", Offset = "0x1C28198", VA = "0x1C28198")]
		public static void GrowCactus(int i, int j)
		{
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003718")]
		[Address(RVA = "0x1C442E0", Offset = "0x1C442E0", VA = "0x1C442E0")]
		public static void CheckPot(int i, int j, int type = 28)
		{
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x0001BBB8 File Offset: 0x00019DB8
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x1C4AC24", Offset = "0x1C4AC24", VA = "0x1C4AC24")]
		public static int GetFruitForPot(int x, int y, int potStyle)
		{
			return 0;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x1C45D38", Offset = "0x1C45D38", VA = "0x1C45D38")]
		private static void SpawnThingsFromPot(int i, int j, int x2, int y2, int style)
		{
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		[Token(Token = "0x600371B")]
		[Address(RVA = "0x1B9E558", Offset = "0x1B9E558", VA = "0x1B9E558")]
		public static int PlaceChest(int x, int y, ushort type = 21, bool notNearOtherChests = false, int style = 0)
		{
			return 0;
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x1C4AFC4", Offset = "0x1C4AFC4", VA = "0x1C4AFC4")]
		public static void PlaceChestDirect(int x, int y, ushort type, int style, int id)
		{
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x1C4B9E4", Offset = "0x1C4B9E4", VA = "0x1C4B9E4")]
		public static void PlaceDresserDirect(int x, int y, ushort type, int style, int id)
		{
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371E")]
		[Address(RVA = "0x1C4C5F8", Offset = "0x1C4C5F8", VA = "0x1C4C5F8")]
		public static void CheckChest(int i, int j, int type)
		{
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x0001BBE8 File Offset: 0x00019DE8
		[Token(Token = "0x600371F")]
		[Address(RVA = "0x1C4D430", Offset = "0x1C4D430", VA = "0x1C4D430")]
		public static int GetChestIcon(int chestStyle, bool containers2)
		{
			return 0;
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x0001BC00 File Offset: 0x00019E00
		[Token(Token = "0x6003720")]
		[Address(RVA = "0x1C4D2A0", Offset = "0x1C4D2A0", VA = "0x1C4D2A0")]
		private static int GetItemDrop_Chests(int x, int y, int type)
		{
			return 0;
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x0001BC18 File Offset: 0x00019E18
		[Token(Token = "0x6003721")]
		[Address(RVA = "0x1C4D504", Offset = "0x1C4D504", VA = "0x1C4D504")]
		public static bool PlaceActuator(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x0001BC30 File Offset: 0x00019E30
		[Token(Token = "0x6003722")]
		[Address(RVA = "0x1C4D738", Offset = "0x1C4D738", VA = "0x1C4D738")]
		public static bool KillActuator(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003723")]
		[Address(RVA = "0x1C4DC60", Offset = "0x1C4DC60", VA = "0x1C4DC60")]
		public static void AddWire(int x, int y, int color = 0)
		{
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x0001BC48 File Offset: 0x00019E48
		[Token(Token = "0x6003724")]
		[Address(RVA = "0x1C4DFEC", Offset = "0x1C4DFEC", VA = "0x1C4DFEC")]
		public static bool AddWireFromPointToPoint(Point a, Point b, int wireColor = 0, bool debugPaint = false)
		{
			return default(bool);
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x0001BC60 File Offset: 0x00019E60
		[Token(Token = "0x6003725")]
		[Address(RVA = "0x1AA5C90", Offset = "0x1AA5C90", VA = "0x1AA5C90")]
		public static bool AddWireFromPointToPoint(int x, int y, int x2, int y2, int wireColor = 0, bool debugPaint = false)
		{
			return default(bool);
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x0001BC78 File Offset: 0x00019E78
		[Token(Token = "0x6003726")]
		[Address(RVA = "0x1C4E080", Offset = "0x1C4E080", VA = "0x1C4E080")]
		public static bool PlaceWire(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x0001BC90 File Offset: 0x00019E90
		[Token(Token = "0x6003727")]
		[Address(RVA = "0x1C4E2B4", Offset = "0x1C4E2B4", VA = "0x1C4E2B4")]
		public static bool KillWire(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x0001BCA8 File Offset: 0x00019EA8
		[Token(Token = "0x6003728")]
		[Address(RVA = "0x1C4E7DC", Offset = "0x1C4E7DC", VA = "0x1C4E7DC")]
		public static bool PlaceWire2(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x1C4EA10", Offset = "0x1C4EA10", VA = "0x1C4EA10")]
		public static bool KillWire2(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		[Token(Token = "0x600372A")]
		[Address(RVA = "0x1C4EF38", Offset = "0x1C4EF38", VA = "0x1C4EF38")]
		public static bool PlaceWire3(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x0001BCF0 File Offset: 0x00019EF0
		[Token(Token = "0x600372B")]
		[Address(RVA = "0x1C4F16C", Offset = "0x1C4F16C", VA = "0x1C4F16C")]
		public static bool KillWire3(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x0001BD08 File Offset: 0x00019F08
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x1C4F694", Offset = "0x1C4F694", VA = "0x1C4F694")]
		public static bool PlaceWire4(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x0001BD20 File Offset: 0x00019F20
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x1C4F8D8", Offset = "0x1C4F8D8", VA = "0x1C4F8D8")]
		public static bool KillWire4(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x0001BD38 File Offset: 0x00019F38
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x1C4FE08", Offset = "0x1C4FE08", VA = "0x1C4FE08")]
		public static bool IsFitToPlaceFlowerIn(int x, int y, int typeAttemptedToPlace)
		{
			return default(bool);
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x0001BD50 File Offset: 0x00019F50
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x1C5065C", Offset = "0x1C5065C", VA = "0x1C5065C")]
		private static bool SeaOatWaterCheck(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x0001BD68 File Offset: 0x00019F68
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x1C509D0", Offset = "0x1C509D0", VA = "0x1C509D0")]
		private static bool PlantSeaOat(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x0001BD80 File Offset: 0x00019F80
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x1C511CC", Offset = "0x1C511CC", VA = "0x1C511CC")]
		private static bool CheckSeaOat(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x0001BD98 File Offset: 0x00019F98
		[Token(Token = "0x6003732")]
		[Address(RVA = "0x1C51338", Offset = "0x1C51338", VA = "0x1C51338")]
		private static bool GrowSeaOat(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x1C515A0", Offset = "0x1C515A0", VA = "0x1C515A0")]
		private static int GetWaterDepth(int x, int y)
		{
			return 0;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x0001BDC8 File Offset: 0x00019FC8
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x1C517B0", Offset = "0x1C517B0", VA = "0x1C517B0")]
		private static int CountGrowingPlantTiles(int x, int y, int range, int type)
		{
			return 0;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0001BDE0 File Offset: 0x00019FE0
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x1C51A38", Offset = "0x1C51A38", VA = "0x1C51A38")]
		private static bool PlaceBamboo(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x1C5259C", Offset = "0x1C5259C", VA = "0x1C5259C")]
		public static void CheckBamboo(int x, int y)
		{
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003737")]
		[Address(RVA = "0x1C53260", Offset = "0x1C53260", VA = "0x1C53260")]
		public static void PlaceUnderwaterPlant(ushort type, int x, int y)
		{
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x0001BDF8 File Offset: 0x00019FF8
		[Token(Token = "0x6003738")]
		[Address(RVA = "0x1C53718", Offset = "0x1C53718", VA = "0x1C53718")]
		public static bool CanUnderwaterPlantGrowHere(ushort type, int x, int y, bool ignoreSelf)
		{
			return default(bool);
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003739")]
		[Address(RVA = "0x1C53D1C", Offset = "0x1C53D1C", VA = "0x1C53D1C")]
		public static void CheckUnderwaterPlant(ushort type, int x, int y)
		{
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x0001BE10 File Offset: 0x0001A010
		[Token(Token = "0x600373A")]
		[Address(RVA = "0x1C544E4", Offset = "0x1C544E4", VA = "0x1C544E4")]
		public static Point PlaceCatTail(int x, int j)
		{
			return default(Point);
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373B")]
		[Address(RVA = "0x1C56480", Offset = "0x1C56480", VA = "0x1C56480")]
		public static void CheckCatTail(int x, int j)
		{
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373C")]
		[Address(RVA = "0x1C59070", Offset = "0x1C59070", VA = "0x1C59070")]
		public static void GrowCheckSeaweed(int x, int y)
		{
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x1C59E0C", Offset = "0x1C59E0C", VA = "0x1C59E0C")]
		public static void GrowCatTail(int x, int j)
		{
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x0001BE28 File Offset: 0x0001A028
		[Token(Token = "0x600373E")]
		[Address(RVA = "0x1C5C64C", Offset = "0x1C5C64C", VA = "0x1C5C64C")]
		public static bool PlaceLilyPad(int x, int j)
		{
			return default(bool);
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373F")]
		[Address(RVA = "0x1B2C278", Offset = "0x1B2C278", VA = "0x1B2C278")]
		public static void CheckLilyPad(int x, int y)
		{
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x0001BE40 File Offset: 0x0001A040
		[Token(Token = "0x6003740")]
		[Address(RVA = "0x1C5E494", Offset = "0x1C5E494", VA = "0x1C5E494")]
		public static bool TryKillingReplaceableTile(int x, int y, int tileType)
		{
			return default(bool);
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x0001BE58 File Offset: 0x0001A058
		[Token(Token = "0x6003741")]
		[Address(RVA = "0x1A64BC0", Offset = "0x1A64BC0", VA = "0x1A64BC0")]
		public static bool PlaceTile(int i, int j, int Type, bool mute = false, bool forced = false, int plr = -1, int style = 0)
		{
			return default(bool);
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x0001BE70 File Offset: 0x0001A070
		[Token(Token = "0x6003742")]
		[Address(RVA = "0x1C60050", Offset = "0x1C60050", VA = "0x1C60050")]
		private static bool ValidAnchorForMultiDirectionalTile(int x, int y, Tile tileCache, int direction)
		{
			return default(bool);
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x0001BE88 File Offset: 0x0001A088
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x1C5F8E0", Offset = "0x1C5F8E0", VA = "0x1C5F8E0")]
		public static bool CheckAndAdjustMultiDirectionalTile(int i, int j, int type, out int newFrameDirection)
		{
			return default(bool);
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003744")]
		[Address(RVA = "0x1C6033C", Offset = "0x1C6033C", VA = "0x1C6033C")]
		public static void KillWall(int i, int j, bool fail = false)
		{
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x0001BEA0 File Offset: 0x0001A0A0
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x1C60814", Offset = "0x1C60814", VA = "0x1C60814")]
		private static bool KillWall_CheckFailure(bool fail, Tile tileCache)
		{
			return default(bool);
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003746")]
		[Address(RVA = "0x1C60A28", Offset = "0x1C60A28", VA = "0x1C60A28")]
		private static void KillWall_PlaySounds(int i, int j, Tile tileCache)
		{
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003747")]
		[Address(RVA = "0x1C664C0", Offset = "0x1C664C0", VA = "0x1C664C0")]
		private static void KillWall_DropItems(int i, int j, Tile tileCache)
		{
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		[Token(Token = "0x6003748")]
		[Address(RVA = "0x1C665CC", Offset = "0x1C665CC", VA = "0x1C665CC")]
		private static int KillWall_GetItemDrops(Tile tileCache)
		{
			return 0;
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003749")]
		[Address(RVA = "0x1C61470", Offset = "0x1C61470", VA = "0x1C61470")]
		private static void KillWall_MakeWallDust(int i, int j, Tile tileCache)
		{
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374A")]
		[Address(RVA = "0x1C6B838", Offset = "0x1C6B838", VA = "0x1C6B838")]
		public static void LaunchRocket(int x, int y, bool fromWiring)
		{
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374B")]
		[Address(RVA = "0x1C6BD58", Offset = "0x1C6BD58", VA = "0x1C6BD58")]
		public static void LaunchRocketSmall(int x, int y, bool fromWiring)
		{
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		[Token(Token = "0x600374C")]
		[Address(RVA = "0x1C6C130", Offset = "0x1C6C130", VA = "0x1C6C130")]
		public static bool CanKillTile(int i, int j, WorldGen.SpecialKillTileContext context)
		{
			return default(bool);
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
		[Token(Token = "0x600374D")]
		[Address(RVA = "0x1C0A1CC", Offset = "0x1C0A1CC", VA = "0x1C0A1CC")]
		public static bool CanKillTile(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x0001BF00 File Offset: 0x0001A100
		[Token(Token = "0x600374E")]
		[Address(RVA = "0x1C6C444", Offset = "0x1C6C444", VA = "0x1C6C444")]
		public static bool CanKillTile(int i, int j, out bool blockDamaged)
		{
			return default(bool);
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x0001BF18 File Offset: 0x0001A118
		[Token(Token = "0x600374F")]
		[Address(RVA = "0x1C6D548", Offset = "0x1C6D548", VA = "0x1C6D548")]
		public static bool IsTileReplaceable(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x0001BF30 File Offset: 0x0001A130
		[Token(Token = "0x6003750")]
		[Address(RVA = "0x1BF47A8", Offset = "0x1BF47A8", VA = "0x1BF47A8")]
		public static int CheckTileBreakability(int x, int y)
		{
			return 0;
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x0001BF48 File Offset: 0x0001A148
		[Token(Token = "0x6003751")]
		[Address(RVA = "0x1BEFA38", Offset = "0x1BEFA38", VA = "0x1BEFA38")]
		private static bool CheckTileBreakability_HasReasonToReturnEarly(int ignoreType, Tile target, bool scanForContainer)
		{
			return default(bool);
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x0001BF60 File Offset: 0x0001A160
		[Token(Token = "0x6003752")]
		[Address(RVA = "0x1C6E074", Offset = "0x1C6E074", VA = "0x1C6E074")]
		public static bool CheckTileBreakability2_ShouldTileSurvive(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x0001BF78 File Offset: 0x0001A178
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x1C6E6C4", Offset = "0x1C6E6C4", VA = "0x1C6E6C4")]
		public static bool ReplaceWall(int x, int y, ushort targetWall)
		{
			return default(bool);
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x0001BF90 File Offset: 0x0001A190
		[Token(Token = "0x6003754")]
		[Address(RVA = "0x1C6E9F8", Offset = "0x1C6E9F8", VA = "0x1C6E9F8")]
		public static bool ReplaceTile(int x, int y, int targetType, int targetStyle)
		{
			return default(bool);
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x1C7E028", Offset = "0x1C7E028", VA = "0x1C7E028")]
		private static void ReplaceTile_DoActualReplacement(int targetType, int targetStyle, int topLeftX, int topLeftY, Tile t)
		{
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003756")]
		[Address(RVA = "0x1C7E738", Offset = "0x1C7E738", VA = "0x1C7E738")]
		private static void ReplaceTile_DoActualReplacement_Single(int targetType, int targetStyle, int topLeftX, int topLeftY, Tile t)
		{
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003757")]
		[Address(RVA = "0x1C7F45C", Offset = "0x1C7F45C", VA = "0x1C7F45C")]
		private static void ReplaceTile_EliminateNaturalExtras(int x, int y)
		{
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003758")]
		[Address(RVA = "0x1C7E404", Offset = "0x1C7E404", VA = "0x1C7E404")]
		private static void ReplaceTile_DoActualReplacement_Area(int targetType, int targetStyle, int topLeftX, int topLeftY, int areaSizeX, int areaSizeY, int frameOffsetX = 0, int frameOffsetY = 0)
		{
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003759")]
		[Address(RVA = "0x1C70214", Offset = "0x1C70214", VA = "0x1C70214")]
		private static void MoveReplaceTileAnchor(ref int x, ref int y, int targetType, Tile t)
		{
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x1C6EB90", Offset = "0x1C6EB90", VA = "0x1C6EB90")]
		public static bool WouldTileReplacementWork(int attemptingToReplaceWith, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x1C80784", Offset = "0x1C80784", VA = "0x1C80784")]
		private static bool ReplaceTile_IsValidSolid(int type)
		{
			return default(bool);
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
		[Token(Token = "0x600375C")]
		[Address(RVA = "0x1C808D0", Offset = "0x1C808D0", VA = "0x1C808D0")]
		private static bool ReplaceTile_IsValidTorch(int type)
		{
			return default(bool);
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x0001BFF0 File Offset: 0x0001A1F0
		[Token(Token = "0x600375D")]
		[Address(RVA = "0x1C8094C", Offset = "0x1C8094C", VA = "0x1C8094C")]
		private static bool ReplaceTile_IsValidCampfire(int type)
		{
			return default(bool);
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x0001C008 File Offset: 0x0001A208
		[Token(Token = "0x600375E")]
		[Address(RVA = "0x1C80A44", Offset = "0x1C80A44", VA = "0x1C80A44")]
		private static bool ReplaceTile_IsValidChest(int type)
		{
			return default(bool);
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x0001C020 File Offset: 0x0001A220
		[Token(Token = "0x600375F")]
		[Address(RVA = "0x1C80AC0", Offset = "0x1C80AC0", VA = "0x1C80AC0")]
		private static bool ReplaceTile_IsValidDresser(int type)
		{
			return default(bool);
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x0001C038 File Offset: 0x0001A238
		[Token(Token = "0x6003760")]
		[Address(RVA = "0x1C809C8", Offset = "0x1C809C8", VA = "0x1C809C8")]
		private static bool ReplaceTile_IsValidPlatform(int type)
		{
			return default(bool);
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x0001C050 File Offset: 0x0001A250
		[Token(Token = "0x6003761")]
		[Address(RVA = "0x1C80B3C", Offset = "0x1C80B3C", VA = "0x1C80B3C")]
		public static bool GetAshTreeFoliageData(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight)
		{
			return default(bool);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x0001C068 File Offset: 0x0001A268
		[Token(Token = "0x6003762")]
		[Address(RVA = "0x1C80D2C", Offset = "0x1C80D2C", VA = "0x1C80D2C")]
		public static bool GetVanityTreeFoliageData(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight)
		{
			return default(bool);
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x0001C080 File Offset: 0x0001A280
		[Token(Token = "0x6003763")]
		[Address(RVA = "0x1C810B8", Offset = "0x1C810B8", VA = "0x1C810B8")]
		public static bool GetGemTreeFoliageData(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight)
		{
			return default(bool);
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x0001C098 File Offset: 0x0001A298
		[Token(Token = "0x6003764")]
		[Address(RVA = "0x1C81568", Offset = "0x1C81568", VA = "0x1C81568")]
		public static bool GetCommonTreeFoliageData(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight)
		{
			return default(bool);
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		[Token(Token = "0x6003765")]
		[Address(RVA = "0x1B4A954", Offset = "0x1B4A954", VA = "0x1B4A954")]
		public static int GetHollowTreeFoliageStyle()
		{
			return 0;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
		[Token(Token = "0x6003766")]
		[Address(RVA = "0x1C81D38", Offset = "0x1C81D38", VA = "0x1C81D38")]
		public static int GetTreeFrame(Tile t)
		{
			return 0;
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		[Token(Token = "0x6003767")]
		[Address(RVA = "0x1C81E88", Offset = "0x1C81E88", VA = "0x1C81E88")]
		public static TreeTypes GetTreeTypeAndTreeBottom(int x, int y, out int bottomX, out int bottomY)
		{
			return TreeTypes.None;
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		[Token(Token = "0x6003768")]
		[Address(RVA = "0x1C82988", Offset = "0x1C82988", VA = "0x1C82988")]
		public static TreeTypes GetTreeType(int x, int y)
		{
			return TreeTypes.None;
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x0001C110 File Offset: 0x0001A310
		[Token(Token = "0x6003769")]
		[Address(RVA = "0x1C8285C", Offset = "0x1C8285C", VA = "0x1C8285C")]
		public static TreeTypes GetTreeType(int tileType)
		{
			return TreeTypes.None;
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x0001C128 File Offset: 0x0001A328
		[Token(Token = "0x600376A")]
		[Address(RVA = "0x1C82A10", Offset = "0x1C82A10", VA = "0x1C82A10")]
		public static bool TreeTypeDropsAcorns(TreeTypes treeType)
		{
			return default(bool);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x0001C140 File Offset: 0x0001A340
		[Token(Token = "0x600376B")]
		[Address(RVA = "0x1C82A30", Offset = "0x1C82A30", VA = "0x1C82A30")]
		public static bool IsThisAMushroomTree(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376C")]
		[Address(RVA = "0x1A98518", Offset = "0x1A98518", VA = "0x1A98518")]
		public static void ResetTreeShakes()
		{
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376D")]
		[Address(RVA = "0x1C82B08", Offset = "0x1C82B08", VA = "0x1C82B08")]
		private static void ShakeTree(int i, int j)
		{
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376E")]
		[Address(RVA = "0x1AFB5F8", Offset = "0x1AFB5F8", VA = "0x1AFB5F8")]
		private static void GetVineTop(int i, int j, out int x, out int y)
		{
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376F")]
		[Address(RVA = "0x1C821CC", Offset = "0x1C821CC", VA = "0x1C821CC")]
		public static void GetTreeBottom(int i, int j, out int x, out int y)
		{
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003770")]
		[Address(RVA = "0x1C7D9EC", Offset = "0x1C7D9EC", VA = "0x1C7D9EC")]
		private static void AttemptFossilShattering(int i, int j, Tile tileCache, bool fail)
		{
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003771")]
		[Address(RVA = "0x1A8C294", Offset = "0x1A8C294", VA = "0x1A8C294")]
		public static void KillTile(int i, int j, bool fail = false, bool effectOnly = false, bool noItem = false)
		{
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003772")]
		[Address(RVA = "0x1C0ACF0", Offset = "0x1C0ACF0", VA = "0x1C0ACF0")]
		public static void CheckExploitDestroyQueue()
		{
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003773")]
		[Address(RVA = "0x1C8FA50", Offset = "0x1C8FA50", VA = "0x1C8FA50")]
		private static Player GetPlayerForTile(int x, int y)
		{
			return null;
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003774")]
		[Address(RVA = "0x1C7D6EC", Offset = "0x1C7D6EC", VA = "0x1C7D6EC")]
		public static void KillTile_DropItems(int x, int y, Tile tileCache, bool includeLargeObjectDrops = false)
		{
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003775")]
		[Address(RVA = "0x1C87D90", Offset = "0x1C87D90", VA = "0x1C87D90")]
		public static void KillTile_GetItemDrops(int x, int y, Tile tileCache, out int dropItem, out int dropItemStack, out int secondaryItem, out int secondaryItemStack, out bool noPrefix, bool includeLargeObjectDrops = false)
		{
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003776")]
		[Address(RVA = "0x1C90364", Offset = "0x1C90364", VA = "0x1C90364")]
		private static void SetGemTreeDrops(int gemType, int seedType, Tile tileCache, ref int dropItem, ref int secondaryItem)
		{
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003777")]
		[Address(RVA = "0x1C90568", Offset = "0x1C90568", VA = "0x1C90568")]
		private static void SetVanityTreeDrops(int dropType, Tile tileCache, ref int dropItem)
		{
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x0001C158 File Offset: 0x0001A358
		[Token(Token = "0x6003778")]
		[Address(RVA = "0x1C5F490", Offset = "0x1C5F490", VA = "0x1C5F490")]
		public static bool IsHarvestableHerbWithSeed(int type, int style, int y)
		{
			return default(bool);
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x0001C170 File Offset: 0x0001A370
		[Token(Token = "0x6003779")]
		[Address(RVA = "0x1C905F8", Offset = "0x1C905F8", VA = "0x1C905F8")]
		public static bool IsAlchemyPlantHarvestable(int style, int y)
		{
			return default(bool);
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x0001C188 File Offset: 0x0001A388
		[Token(Token = "0x600377A")]
		[Address(RVA = "0x1C8FBAC", Offset = "0x1C8FBAC", VA = "0x1C8FBAC")]
		private static bool KillTile_ShouldDropSeeds(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377B")]
		[Address(RVA = "0x1C8FCF0", Offset = "0x1C8FCF0", VA = "0x1C8FCF0")]
		private static void KillTile_GetTreeDrops(int i, int j, Tile tileCache, ref bool dropIsWood, ref bool bonusWood, ref int dropItem, ref int secondaryItem)
		{
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377C")]
		[Address(RVA = "0x1C8D878", Offset = "0x1C8D878", VA = "0x1C8D878")]
		private static void KillTile_DropBait(int i, int j, Tile tileCache)
		{
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377D")]
		[Address(RVA = "0x1C7B788", Offset = "0x1C7B788", VA = "0x1C7B788")]
		public static void KillTile_PlaySounds(int i, int j, bool fail, Tile tileCache)
		{
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
		[Token(Token = "0x600377E")]
		[Address(RVA = "0x1C908BC", Offset = "0x1C908BC", VA = "0x1C908BC")]
		public static Rectangle? GetTileVisualHitbox(int x, int y)
		{
			return null;
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
		[Token(Token = "0x600377F")]
		[Address(RVA = "0x1C70864", Offset = "0x1C70864", VA = "0x1C70864")]
		public static int KillTile_GetTileDustAmount(bool fail, Tile tileCache)
		{
			return 0;
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		[Token(Token = "0x6003780")]
		[Address(RVA = "0x1C70C54", Offset = "0x1C70C54", VA = "0x1C70C54")]
		public static int KillTile_MakeTileDust(int i, int j, Tile tileCache)
		{
			return 0;
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x0001C1E8 File Offset: 0x0001A3E8
		[Token(Token = "0x6003781")]
		[Address(RVA = "0x1A85948", Offset = "0x1A85948", VA = "0x1A85948")]
		public static bool IsOpenDoorAnchorFrame(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x0001C200 File Offset: 0x0001A400
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x1C90CE4", Offset = "0x1C90CE4", VA = "0x1C90CE4")]
		public static bool IsLockedDoor(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x0001C218 File Offset: 0x0001A418
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x1BA0E5C", Offset = "0x1BA0E5C", VA = "0x1BA0E5C")]
		public static bool IsLockedDoor(Tile t)
		{
			return default(bool);
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x0001C230 File Offset: 0x0001A430
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x1C90DAC", Offset = "0x1C90DAC", VA = "0x1C90DAC")]
		public static int GetDoorItem(int doorStyle)
		{
			return 0;
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x1C90E58", Offset = "0x1C90E58", VA = "0x1C90E58")]
		public static void DropDoorItem(int x, int y, int doorStyle)
		{
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003786")]
		[Address(RVA = "0x1BA1C10", Offset = "0x1BA1C10", VA = "0x1BA1C10")]
		public static IEntitySource GetItemSource_FromTileBreak(int x, int y)
		{
			return null;
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x1C90F64", Offset = "0x1C90F64", VA = "0x1C90F64")]
		public static IEntitySource GetItemSource_FromCoinRain(int x, int y)
		{
			return null;
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x1C4AF48", Offset = "0x1C4AF48", VA = "0x1C4AF48")]
		public static IEntitySource GetNPCSource_FromTileBreak(int x, int y)
		{
			return null;
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x1C6B830", Offset = "0x1C6B830", VA = "0x1C6B830")]
		public static IEntitySource GetItemSource_FromWallBreak(int x, int y)
		{
			return null;
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x1C8D7F8", Offset = "0x1C8D7F8", VA = "0x1C8D7F8")]
		public static IEntitySource GetItemSource_FromTreeShake(int x, int y)
		{
			return null;
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x0001C248 File Offset: 0x0001A448
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x1C90FE0", Offset = "0x1C90FE0", VA = "0x1C90FE0")]
		public static bool PlayerLOS(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378C")]
		[Address(RVA = "0x1C91380", Offset = "0x1C91380", VA = "0x1C91380")]
		public static void ChlorophyteDefense(int x, int y)
		{
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x0001C260 File Offset: 0x0001A460
		[Token(Token = "0x600378D")]
		[Address(RVA = "0x1C91448", Offset = "0x1C91448", VA = "0x1C91448")]
		public static bool CanChlorophyteGrow(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x0001C278 File Offset: 0x0001A478
		[Token(Token = "0x600378E")]
		[Address(RVA = "0x1C917F8", Offset = "0x1C917F8", VA = "0x1C917F8")]
		private static bool nearbyChlorophyte(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x0001C290 File Offset: 0x0001A490
		[Token(Token = "0x600378F")]
		[Address(RVA = "0x1C91ACC", Offset = "0x1C91ACC", VA = "0x1C91ACC")]
		public static int CountNearBlocksTypes(int i, int j, int radius, int cap, ushort tiletypes)
		{
			return 0;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003790")]
		[Address(RVA = "0x1C91D4C", Offset = "0x1C91D4C", VA = "0x1C91D4C")]
		public static void hardUpdateWorld(int i, int j, int type)
		{
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
		[Token(Token = "0x6003791")]
		[Address(RVA = "0x1C93904", Offset = "0x1C93904", VA = "0x1C93904")]
		public static bool SolidTile(short tileSHeader, ushort tileType)
		{
			return default(bool);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
		[Token(Token = "0x6003792")]
		[Address(RVA = "0x1C0C1D0", Offset = "0x1C0C1D0", VA = "0x1C0C1D0")]
		public static bool SolidTile(Tile testTile)
		{
			return default(bool);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x0001C2D8 File Offset: 0x0001A4D8
		[Token(Token = "0x6003793")]
		[Address(RVA = "0x1C939E4", Offset = "0x1C939E4", VA = "0x1C939E4")]
		public static bool TileEmpty(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x0001C2F0 File Offset: 0x0001A4F0
		[Token(Token = "0x6003794")]
		[Address(RVA = "0x1C93CEC", Offset = "0x1C93CEC", VA = "0x1C93CEC")]
		public static bool SolidOrSlopedTile(Tile tile, bool includePlatforms = false)
		{
			return default(bool);
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x0001C308 File Offset: 0x0001A508
		[Token(Token = "0x6003795")]
		[Address(RVA = "0x1AB62C4", Offset = "0x1AB62C4", VA = "0x1AB62C4")]
		public static int TileType(int x, int y)
		{
			return 0;
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x0001C320 File Offset: 0x0001A520
		[Token(Token = "0x6003796")]
		[Address(RVA = "0x1AA48C4", Offset = "0x1AA48C4", VA = "0x1AA48C4")]
		public static bool SolidOrSlopedTile(int x, int y, bool includePlatforms = false)
		{
			return default(bool);
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003797")]
		[Address(RVA = "0x1C93F48", Offset = "0x1C93F48", VA = "0x1C93F48")]
		public static void GetRopeEnds(int x, int y, out int topRopeY, out int bottomRopeY, bool treatEmptyAsTheRopeEnd = false, int rangeToCheck = 5)
		{
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x0001C338 File Offset: 0x0001A538
		[Token(Token = "0x6003798")]
		[Address(RVA = "0x1C940D8", Offset = "0x1C940D8", VA = "0x1C940D8")]
		public static bool IsRope(int x, int y, int rangeToCheck = 5)
		{
			return default(bool);
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x0001C350 File Offset: 0x0001A550
		[Token(Token = "0x6003799")]
		[Address(RVA = "0x1C94168", Offset = "0x1C94168", VA = "0x1C94168")]
		public static bool IsRope(int x, int y, out int topRopeY, out int bottomRopeY, int rangeToCheck = 5)
		{
			return default(bool);
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x0001C368 File Offset: 0x0001A568
		[Token(Token = "0x600379A")]
		[Address(RVA = "0x1C94604", Offset = "0x1C94604", VA = "0x1C94604")]
		public static bool SolidTile(Point p)
		{
			return default(bool);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x0001C380 File Offset: 0x0001A580
		[Token(Token = "0x600379B")]
		[Address(RVA = "0x1A8063C", Offset = "0x1A8063C", VA = "0x1A8063C")]
		public static bool SolidTile(int i, int j, bool noDoors = false)
		{
			return default(bool);
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x0001C398 File Offset: 0x0001A598
		[Token(Token = "0x600379C")]
		[Address(RVA = "0x1C94674", Offset = "0x1C94674", VA = "0x1C94674")]
		public static bool SolidTile(Tile tileCache, bool noDoors = false)
		{
			return default(bool);
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		[Token(Token = "0x600379D")]
		[Address(RVA = "0x1A64930", Offset = "0x1A64930", VA = "0x1A64930")]
		public static bool SolidTile2(Tile testTile)
		{
			return default(bool);
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
		[Token(Token = "0x600379E")]
		[Address(RVA = "0x1C948A4", Offset = "0x1C948A4", VA = "0x1C948A4")]
		public static bool PlatformProperTopFrame(short frameX)
		{
			return default(bool);
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
		[Token(Token = "0x600379F")]
		[Address(RVA = "0x1AA4994", Offset = "0x1AA4994", VA = "0x1AA4994")]
		public static bool SolidTileAllowBottomSlope(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x1C948FC", Offset = "0x1C948FC", VA = "0x1C948FC")]
		public static bool SolidTileNoPlatforms(Point p)
		{
			return default(bool);
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x0001C410 File Offset: 0x0001A610
		[Token(Token = "0x60037A1")]
		[Address(RVA = "0x1C94968", Offset = "0x1C94968", VA = "0x1C94968")]
		public static bool SolidTileNoPlatforms(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x0001C428 File Offset: 0x0001A628
		[Token(Token = "0x60037A2")]
		[Address(RVA = "0x1C94EDC", Offset = "0x1C94EDC", VA = "0x1C94EDC")]
		public static bool SolidTileAllowPlatformTopFrame(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x0001C440 File Offset: 0x0001A640
		[Token(Token = "0x60037A3")]
		[Address(RVA = "0x1C95534", Offset = "0x1C95534", VA = "0x1C95534")]
		public static bool AnyLiquidAt(Point p, int liquidType = -1)
		{
			return default(bool);
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x0001C458 File Offset: 0x0001A658
		[Token(Token = "0x60037A4")]
		[Address(RVA = "0x1C95840", Offset = "0x1C95840", VA = "0x1C95840")]
		public static bool AnyLiquidAt(Point p, int range, int liquidType = -1)
		{
			return default(bool);
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x0001C470 File Offset: 0x0001A670
		[Token(Token = "0x60037A5")]
		[Address(RVA = "0x1C955A8", Offset = "0x1C955A8", VA = "0x1C955A8")]
		public static bool AnyLiquidAt(int x, int y, int liquidType = -1)
		{
			return default(bool);
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x0001C488 File Offset: 0x0001A688
		[Token(Token = "0x60037A6")]
		[Address(RVA = "0x1C958C4", Offset = "0x1C958C4", VA = "0x1C958C4")]
		public static bool AnyLiquidAt(int x, int y, int range, int liquidType = -1)
		{
			return default(bool);
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		[Token(Token = "0x60037A7")]
		[Address(RVA = "0x1C95A9C", Offset = "0x1C95A9C", VA = "0x1C95A9C")]
		public static bool ActiveAndWalkableTile(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x0001C4B8 File Offset: 0x0001A6B8
		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x1BA3F90", Offset = "0x1BA3F90", VA = "0x1BA3F90")]
		public static bool SolidTileAllowTopSlope(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x0001C4D0 File Offset: 0x0001A6D0
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x1C22F80", Offset = "0x1C22F80", VA = "0x1C22F80")]
		public static bool SolidTileAllowLeftSlope(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		[Token(Token = "0x60037AA")]
		[Address(RVA = "0x1C23444", Offset = "0x1C23444", VA = "0x1C23444")]
		public static bool SolidTileAllowRightSlope(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x0001C500 File Offset: 0x0001A700
		[Token(Token = "0x60037AB")]
		[Address(RVA = "0x1BB9334", Offset = "0x1BB9334", VA = "0x1BB9334")]
		public static bool TopEdgeCanBeAttachedTo(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x0001C518 File Offset: 0x0001A718
		[Token(Token = "0x60037AC")]
		[Address(RVA = "0x1BB9E8C", Offset = "0x1BB9E8C", VA = "0x1BB9E8C")]
		public static bool RightEdgeCanBeAttachedTo(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x0001C530 File Offset: 0x0001A730
		[Token(Token = "0x60037AD")]
		[Address(RVA = "0x1BBA3FC", Offset = "0x1BBA3FC", VA = "0x1BBA3FC")]
		public static bool LeftEdgeCanBeAttachedTo(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x0001C548 File Offset: 0x0001A748
		[Token(Token = "0x60037AE")]
		[Address(RVA = "0x1BB99A0", Offset = "0x1BB99A0", VA = "0x1BB99A0")]
		public static bool BottomEdgeCanBeAttachedTo(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x0001C560 File Offset: 0x0001A760
		[Token(Token = "0x60037AF")]
		[Address(RVA = "0x1C95DE8", Offset = "0x1C95DE8", VA = "0x1C95DE8")]
		public static bool SolidTile3(Point p)
		{
			return default(bool);
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x0001C578 File Offset: 0x0001A778
		[Token(Token = "0x60037B0")]
		[Address(RVA = "0x1AE7BE0", Offset = "0x1AE7BE0", VA = "0x1AE7BE0")]
		public static bool SolidTile3(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x0001C590 File Offset: 0x0001A790
		[Token(Token = "0x60037B1")]
		[Address(RVA = "0x1C95E54", Offset = "0x1C95E54", VA = "0x1C95E54")]
		public static bool SolidTile3(Tile t)
		{
			return default(bool);
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
		[Token(Token = "0x60037B2")]
		[Address(RVA = "0x1C96130", Offset = "0x1C96130", VA = "0x1C96130")]
		public static bool SolidTile2(Point p)
		{
			return default(bool);
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
		[Token(Token = "0x60037B3")]
		[Address(RVA = "0x1BAE518", Offset = "0x1BAE518", VA = "0x1BAE518")]
		public static bool SolidTile2(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		[Token(Token = "0x60037B4")]
		[Address(RVA = "0x1C9619C", Offset = "0x1C9619C", VA = "0x1C9619C")]
		public static bool SolidTileNoAttach(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x1C967EC", Offset = "0x1C967EC", VA = "0x1C967EC")]
		public static void MineHouse(int i, int j)
		{
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B6")]
		[Address(RVA = "0x1C9F318", Offset = "0x1C9F318", VA = "0x1C9F318")]
		public static void CountTiles(int X)
		{
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x1C9F948", Offset = "0x1C9F948", VA = "0x1C9F948")]
		public static void AddUpAlignmentCounts(bool clearCounts = false)
		{
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x1C9FECC", Offset = "0x1C9FECC", VA = "0x1C9FECC")]
		public static bool checkPlantDye(int i, int j, bool exoticPlant = false)
		{
			return default(bool);
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B9")]
		[Address(RVA = "0x1CA0080", Offset = "0x1CA0080", VA = "0x1CA0080")]
		public static void plantDye(int i, int j, bool exoticPlant = false)
		{
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x0001C608 File Offset: 0x0001A808
		[Token(Token = "0x60037BA")]
		[Address(RVA = "0x1CA1194", Offset = "0x1CA1194", VA = "0x1CA1194")]
		private static int MossConversion(int thisType, int otherType)
		{
			return 0;
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BB")]
		[Address(RVA = "0x1CA15D0", Offset = "0x1CA15D0", VA = "0x1CA15D0")]
		public static void UpdateWorld()
		{
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BC")]
		[Address(RVA = "0x1CA3F00", Offset = "0x1CA3F00", VA = "0x1CA3F00")]
		private static void UpdatePrioritizedTownNPC()
		{
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x1CA41B4", Offset = "0x1CA41B4", VA = "0x1CA41B4")]
		private static void CheckForHousesNearAPlayer()
		{
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BE")]
		[Address(RVA = "0x1CB80B8", Offset = "0x1CB80B8", VA = "0x1CB80B8")]
		private static void SpawnFallingObjects()
		{
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BF")]
		[Address(RVA = "0x1CB9E9C", Offset = "0x1CB9E9C", VA = "0x1CB9E9C")]
		private static void DebugLogLightning(string msg)
		{
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x1CA3600", Offset = "0x1CA3600", VA = "0x1CA3600")]
		private static void SpawnStormLightning()
		{
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C1")]
		[Address(RVA = "0x1CB9EA0", Offset = "0x1CB9EA0", VA = "0x1CB9EA0")]
		private static void SpawnStormLightningNearPlayer(List<Rectangle> safespots, Player player)
		{
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x0001C620 File Offset: 0x0001A820
		[Token(Token = "0x60037C2")]
		[Address(RVA = "0x1CBA524", Offset = "0x1CBA524", VA = "0x1CBA524")]
		private static bool IsLightningAttractor(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x0001C638 File Offset: 0x0001A838
		[Token(Token = "0x60037C3")]
		[Address(RVA = "0x1CBA73C", Offset = "0x1CBA73C", VA = "0x1CBA73C")]
		private static bool TrySpawnLightningBolt(List<Rectangle> safespots, int x, int y, ref bool shouldSkipForThisPlayer)
		{
			return default(bool);
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x0001C650 File Offset: 0x0001A850
		[Token(Token = "0x60037C4")]
		[Address(RVA = "0x1CBAF00", Offset = "0x1CBAF00", VA = "0x1CBAF00")]
		public static bool TrySpawnLightningBolt(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x0001C668 File Offset: 0x0001A868
		[Token(Token = "0x60037C5")]
		[Address(RVA = "0x1CA3DF4", Offset = "0x1CA3DF4", VA = "0x1CA3DF4")]
		public static int GetWorldUpdateRate()
		{
			return 0;
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C6")]
		[Address(RVA = "0x1CA47A8", Offset = "0x1CA47A8", VA = "0x1CA47A8")]
		private static void UpdateWorld_OvergroundTile(int i, int j, bool checkNPCSpawns, int wallDist)
		{
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x0001C680 File Offset: 0x0001A880
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0x1CC204C", Offset = "0x1CC204C", VA = "0x1CC204C")]
		public static bool AttemptToGrowTreeFromSapling(int x, int y, bool underground, int treeHeightAddon = 0, bool ignoreWalls = false)
		{
			return default(bool);
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C8")]
		[Address(RVA = "0x1CC56F8", Offset = "0x1CC56F8", VA = "0x1CC56F8")]
		public static void DontStarveTryWateringTile(int x, int y)
		{
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x0001C698 File Offset: 0x0001A898
		[Token(Token = "0x60037C9")]
		[Address(RVA = "0x1CC59F0", Offset = "0x1CC59F0", VA = "0x1CC59F0")]
		public static bool HasAnyWireNearby(int sourceX, int sourceY, int boxSpread)
		{
			return default(bool);
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
		[Token(Token = "0x60037CA")]
		[Address(RVA = "0x1CBAB20", Offset = "0x1CBAB20", VA = "0x1CBAB20")]
		public static bool IsSafeFromRain(int startX, int startY)
		{
			return default(bool);
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x0001C6C8 File Offset: 0x0001A8C8
		[Token(Token = "0x60037CB")]
		[Address(RVA = "0x1CC5DF4", Offset = "0x1CC5DF4", VA = "0x1CC5DF4")]
		public static bool TryToggleLight(int x, int y, bool? forcedState, bool skipWires)
		{
			return default(bool);
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
		[Token(Token = "0x60037CC")]
		[Address(RVA = "0x1BC6068", Offset = "0x1BC6068", VA = "0x1BC6068")]
		private static bool HasValidGroundForAbigailsFlowerBelowSpot(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
		[Token(Token = "0x60037CD")]
		[Address(RVA = "0x1CBB3B4", Offset = "0x1CBB3B4", VA = "0x1CBB3B4")]
		private static bool TryGrowingAbigailsFlower(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x0001C710 File Offset: 0x0001A910
		[Token(Token = "0x60037CE")]
		[Address(RVA = "0x1CC64E4", Offset = "0x1CC64E4", VA = "0x1CC64E4")]
		private static bool NoNearbyAbigailsFlower(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x0001C728 File Offset: 0x0001A928
		[Token(Token = "0x60037CF")]
		[Address(RVA = "0x1C5F52C", Offset = "0x1C5F52C", VA = "0x1C5F52C")]
		private static bool HasValidGroundForGlowTulipBelowSpot(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0001C740 File Offset: 0x0001A940
		[Token(Token = "0x60037D0")]
		[Address(RVA = "0x1BCB788", Offset = "0x1BCB788", VA = "0x1BCB788")]
		private static bool TryGrowingGlowTulip(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x0001C758 File Offset: 0x0001A958
		[Token(Token = "0x60037D1")]
		[Address(RVA = "0x1CC6800", Offset = "0x1CC6800", VA = "0x1CC6800")]
		private static bool NoNearbyGlowTulips(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x0001C770 File Offset: 0x0001A970
		[Token(Token = "0x60037D2")]
		[Address(RVA = "0x1CC6B1C", Offset = "0x1CC6B1C", VA = "0x1CC6B1C")]
		private static bool TooManyJunglePlantsNearby(int i, int j, int maxCount = 2)
		{
			return default(bool);
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x0001C788 File Offset: 0x0001A988
		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x1CC2958", Offset = "0x1CC2958", VA = "0x1CC2958")]
		private static bool TooManyJungleVinesNearby(int i, int j, int maxCount = 6)
		{
			return default(bool);
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x1CAEE78", Offset = "0x1CAEE78", VA = "0x1CAEE78")]
		private static void UpdateWorld_UndergroundTile(int i, int j, bool checkNPCSpawns, int wallDist)
		{
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D5")]
		[Address(RVA = "0x1CC6EF4", Offset = "0x1CC6EF4", VA = "0x1CC6EF4")]
		public static void LavaLayerCaverer()
		{
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D6")]
		[Address(RVA = "0x1CC2CA8", Offset = "0x1CC2CA8", VA = "0x1CC2CA8")]
		private static void GrowWeb(int i, int j)
		{
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		[Token(Token = "0x60037D7")]
		[Address(RVA = "0x1CC8E30", Offset = "0x1CC8E30", VA = "0x1CC8E30")]
		public static bool GeneratePlanteraBulbOnAllMechsDefeated()
		{
			return default(bool);
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		[Token(Token = "0x60037D8")]
		[Address(RVA = "0x1CC97D8", Offset = "0x1CC97D8", VA = "0x1CC97D8")]
		private static bool AttemptToGeneratePlanteraBulbAt(int i, int j, bool forceBulb)
		{
			return default(bool);
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D9")]
		[Address(RVA = "0x1CBB894", Offset = "0x1CBB894", VA = "0x1CBB894")]
		private static void UpdateWorld_GrassGrowth(int i, int j, int minI, int maxI, int minJ, int maxJ, bool underground)
		{
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DA")]
		[Address(RVA = "0x1CC31C0", Offset = "0x1CC31C0", VA = "0x1CC31C0")]
		private static void TrySpawningTownNPC(int x, int y)
		{
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DB")]
		[Address(RVA = "0x1CC33C8", Offset = "0x1CC33C8", VA = "0x1CC33C8")]
		public static void SpreadGrassWalls(int wallDist, int i, int j)
		{
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DC")]
		[Address(RVA = "0x1CC4D58", Offset = "0x1CC4D58", VA = "0x1CC4D58")]
		public static void SpreadDesertWalls(int wallDist, int i, int j)
		{
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DD")]
		[Address(RVA = "0x1CCA99C", Offset = "0x1CCA99C", VA = "0x1CCA99C")]
		public static void PlaceWall(int i, int j, int type, bool mute = false)
		{
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DE")]
		[Address(RVA = "0x1AB64C0", Offset = "0x1AB64C0", VA = "0x1AB64C0")]
		public static void SpreadGrass(int i, int j, int dirt = 0, int grass = 2, bool repeat = true, [Optional] TileColorCache color)
		{
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DF")]
		[Address(RVA = "0x1CCACE0", Offset = "0x1CCACE0", VA = "0x1CCACE0")]
		public static void ChasmRunnerSideways(int i, int j, int direction, int steps)
		{
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		[Token(Token = "0x60037E0")]
		[Address(RVA = "0x1CCCF20", Offset = "0x1CCCF20", VA = "0x1CCCF20")]
		public static bool CanEvilReplace(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E1")]
		[Address(RVA = "0x1CCEFA8", Offset = "0x1CCEFA8", VA = "0x1CCEFA8")]
		public static void CrimStart(int i, int j)
		{
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E2")]
		[Address(RVA = "0x1CD3640", Offset = "0x1CD3640", VA = "0x1CD3640")]
		public static void CrimPlaceHearts()
		{
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E3")]
		[Address(RVA = "0x1CD2DD0", Offset = "0x1CD2DD0", VA = "0x1CD2DD0")]
		public static void CrimEnt(Vector2D position, int crimDir)
		{
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E4")]
		[Address(RVA = "0x1CD2130", Offset = "0x1CD2130", VA = "0x1CD2130")]
		public static void CrimVein(Vector2D position, Vector2D velocity)
		{
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E5")]
		[Address(RVA = "0x1CD3F68", Offset = "0x1CD3F68", VA = "0x1CD3F68")]
		public static void ChasmRunner(int i, int j, int steps, bool makeOrb = false)
		{
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E6")]
		[Address(RVA = "0x1CD618C", Offset = "0x1CD618C", VA = "0x1CD618C")]
		public static void ExecuteThreadTime()
		{
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E7")]
		[Address(RVA = "0x1B5D3CC", Offset = "0x1B5D3CC", VA = "0x1B5D3CC")]
		public static void CloseThreadTime()
		{
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x1CD65A4", Offset = "0x1CD65A4", VA = "0x1CD65A4")]
		public static void WaitForThreadTimeIfNeeded()
		{
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E9")]
		[Address(RVA = "0x1CD6618", Offset = "0x1CD6618", VA = "0x1CD6618")]
		public static void CloseThreadTimeIfNeeded()
		{
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EA")]
		[Address(RVA = "0x1B5CBB4", Offset = "0x1B5CBB4", VA = "0x1B5CBB4")]
		public static void WaitForThreadTime()
		{
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x1CD668C", Offset = "0x1CD668C", VA = "0x1CD668C")]
		public static void SpawnPlanteraThorns(Vector2 position)
		{
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EC")]
		[Address(RVA = "0x1B5B7F0", Offset = "0x1B5B7F0", VA = "0x1B5B7F0")]
		public static void GERunner(int i, int j, double speedX = 0.0, double speedY = 0.0, bool good = true)
		{
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x0001C7E8 File Offset: 0x0001A9E8
		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x1CD6CD8", Offset = "0x1CD6CD8", VA = "0x1CD6CD8")]
		private static bool badOceanCaveTiles(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x1CD73B8", Offset = "0x1CD73B8", VA = "0x1CD73B8")]
		public static void oceanCave(int i, int j)
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x1CD9800", Offset = "0x1CD9800", VA = "0x1CD9800")]
		public static void WavyCaverer(int startX, int startY, double waveStrengthScalar, double wavePercentScalar, int steps, int type)
		{
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x1CCD238", Offset = "0x1CCD238", VA = "0x1CCD238")]
		public static void TileRunner(int i, int j, double strength, int steps, int type, bool addTile = false, double speedX = 0.0, double speedY = 0.0, bool noYChange = false, bool overRide = true, int ignoreTileType = -1)
		{
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x1CDA0E0", Offset = "0x1CDA0E0", VA = "0x1CDA0E0")]
		public static void DirtyRockRunner(int i, int j)
		{
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F2")]
		[Address(RVA = "0x1CDAA38", Offset = "0x1CDAA38", VA = "0x1CDAA38")]
		public static void MudWallRunner(int i, int j)
		{
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F3")]
		[Address(RVA = "0x1B1B260", Offset = "0x1B1B260", VA = "0x1B1B260")]
		public static void SpiderWallRemover(int i, int j)
		{
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F4")]
		[Address(RVA = "0x1CDB328", Offset = "0x1CDB328", VA = "0x1CDB328")]
		public static void SnowCloudIsland(int i, int j)
		{
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F5")]
		[Address(RVA = "0x1CE0708", Offset = "0x1CE0708", VA = "0x1CE0708")]
		public static void DesertCloudIsland(int i, int j)
		{
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F6")]
		[Address(RVA = "0x1CE5038", Offset = "0x1CE5038", VA = "0x1CE5038")]
		public static void CloudIsland(int i, int j)
		{
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x0001C800 File Offset: 0x0001AA00
		[Token(Token = "0x60037F7")]
		[Address(RVA = "0x1CDFC58", Offset = "0x1CDFC58", VA = "0x1CDFC58")]
		public static bool WillWaterPlacedHereStayPut(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F8")]
		[Address(RVA = "0x1CE9A48", Offset = "0x1CE9A48", VA = "0x1CE9A48")]
		public static void CloudLake(int i, int j)
		{
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F9")]
		[Address(RVA = "0x1CEE110", Offset = "0x1CEE110", VA = "0x1CEE110")]
		public static void FloatingIsland(int i, int j)
		{
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FA")]
		[Address(RVA = "0x1CEF0C8", Offset = "0x1CEF0C8", VA = "0x1CEF0C8")]
		public static void Caverer(int X, int Y)
		{
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x0001C818 File Offset: 0x0001AA18
		[Token(Token = "0x60037FB")]
		[Address(RVA = "0x1CEFEA0", Offset = "0x1CEFEA0", VA = "0x1CEFEA0")]
		public static Vector2D digTunnel(double X, double Y, double xDir, double yDir, int Steps, int Size, bool Wet = false)
		{
			return default(Vector2D);
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FC")]
		[Address(RVA = "0x1CF07C8", Offset = "0x1CF07C8", VA = "0x1CF07C8")]
		public static void IslandHouse(int i, int j, int islandStyle)
		{
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x1CF3AF0", Offset = "0x1CF3AF0", VA = "0x1CF3AF0")]
		public static void Mountinater(int i, int j)
		{
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FE")]
		[Address(RVA = "0x1CF45E8", Offset = "0x1CF45E8", VA = "0x1CF45E8")]
		public static void MakeWateryIceThing(int i, int j)
		{
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x1CF5A80", Offset = "0x1CF5A80", VA = "0x1CF5A80")]
		public static void Lakinater(int i, int j, double strengthMultiplier = 1.0)
		{
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003800")]
		[Address(RVA = "0x1CF6720", Offset = "0x1CF6720", VA = "0x1CF6720")]
		public static void SonOfLakinater(int i, int j, double strengthMultiplier = 1.0)
		{
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003801")]
		[Address(RVA = "0x1CF8A68", Offset = "0x1CF8A68", VA = "0x1CF8A68")]
		public static void ShroomPatch(int i, int j)
		{
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003802")]
		[Address(RVA = "0x1CF9E48", Offset = "0x1CF9E48", VA = "0x1CF9E48")]
		public static void Cavinator(int i, int j, int steps)
		{
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003803")]
		[Address(RVA = "0x1CFAEF0", Offset = "0x1CFAEF0", VA = "0x1CFAEF0")]
		public static void CaveOpenater(int i, int j)
		{
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x0001C830 File Offset: 0x0001AA30
		[Token(Token = "0x6003804")]
		[Address(RVA = "0x1CCAB60", Offset = "0x1CCAB60", VA = "0x1CCAB60")]
		public static bool CanBeClearedDuringGeneration(int tileType, int x, int y, bool skipDualDungeonCheck = false)
		{
			return default(bool);
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003805")]
		[Address(RVA = "0x1CFBAB0", Offset = "0x1CFBAB0", VA = "0x1CFBAB0")]
		public static void DiamondTileFrame(int i, int j)
		{
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003806")]
		[Address(RVA = "0x1A762BC", Offset = "0x1A762BC", VA = "0x1A762BC")]
		public static void SquareTileFrame(int i, int j, bool resetFrame = true)
		{
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003807")]
		[Address(RVA = "0x1A91178", Offset = "0x1A91178", VA = "0x1A91178")]
		public static void SquareWallFrame(int i, int j, bool resetFrame = true)
		{
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003808")]
		[Address(RVA = "0x1CFBB68", Offset = "0x1CFBB68", VA = "0x1CFBB68")]
		public static void SectionTileFrameWithCheck(int startX, int startY, int endX, int endY)
		{
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003809")]
		[Address(RVA = "0x1CFBFD4", Offset = "0x1CFBFD4", VA = "0x1CFBFD4")]
		public static void RefreshSections(int startX, int startY, int endX, int endY)
		{
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380A")]
		[Address(RVA = "0x1CFC15C", Offset = "0x1CFC15C", VA = "0x1CFC15C")]
		public static void RefreshSection(int sectionX, int sectionY)
		{
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380B")]
		[Address(RVA = "0x1CFC6EC", Offset = "0x1CFC6EC", VA = "0x1CFC6EC")]
		public static void RefreshStrip(int xStart, int yStart, int xEnd, int yEnd, ref int totalEcho, ref int totalFramed)
		{
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380C")]
		[Address(RVA = "0x1CFC604", Offset = "0x1CFC604", VA = "0x1CFC604")]
		public static void Reframe(int x, int y, bool resetFrame = false)
		{
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380D")]
		[Address(RVA = "0x1CFBD80", Offset = "0x1CFBD80", VA = "0x1CFBD80")]
		public static void SectionTileFrame(int sectionStartX, int sectionStartY, int sectionEndXInclusive, int sectionEndYInclusive)
		{
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380E")]
		[Address(RVA = "0x1CFC400", Offset = "0x1CFC400", VA = "0x1CFC400")]
		public static void GetSectionBounds(int sectionStartX, int sectionStartY, int sectionEndXInclusive, int sectionEndYInclusive, out int tileStartX, out int tileEndX, out int tileStartY, out int tileEndY)
		{
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x1B337E8", Offset = "0x1B337E8", VA = "0x1B337E8")]
		public static void RangeFrame(int startX, int startY, int endX, int endY)
		{
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003810")]
		[Address(RVA = "0x1CFCB4C", Offset = "0x1CFCB4C", VA = "0x1CFCB4C")]
		public static void WaterCheck()
		{
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003811")]
		[Address(RVA = "0x1CFD000", Offset = "0x1CFD000", VA = "0x1CFD000")]
		public static void ClearPendingLiquid()
		{
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x0001C848 File Offset: 0x0001AA48
		[Token(Token = "0x6003812")]
		[Address(RVA = "0x1CFD25C", Offset = "0x1CFD25C", VA = "0x1CFD25C")]
		private static bool PlantCheck_IsBadTypeMatch(int down, int type)
		{
			return default(bool);
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x0001C860 File Offset: 0x0001AA60
		[Token(Token = "0x6003813")]
		[Address(RVA = "0x1CFD358", Offset = "0x1CFD358", VA = "0x1CFD358")]
		public static int PlantCheck_CanPlaceHook(int x, int y, int type, int style, int direction, int alternate)
		{
			return 0;
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003814")]
		[Address(RVA = "0x1CFD794", Offset = "0x1CFD794", VA = "0x1CFD794")]
		public static void PlantCheck(int x, int y)
		{
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003815")]
		[Address(RVA = "0x1CFE26C", Offset = "0x1CFE26C", VA = "0x1CFE26C")]
		private static void PlantCheck_TryGetNewType(int x, int y, int down, ref int type, ref short frameX, out bool isMushroomOrSpore)
		{
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x0001C878 File Offset: 0x0001AA78
		[Token(Token = "0x6003816")]
		[Address(RVA = "0x1C80110", Offset = "0x1C80110", VA = "0x1C80110")]
		public static bool CanPoundTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x0001C890 File Offset: 0x0001AA90
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x1CFE480", Offset = "0x1CFE480", VA = "0x1CFE480")]
		public static bool ForbidsSloping(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		[Token(Token = "0x6003818")]
		[Address(RVA = "0x1AA50E4", Offset = "0x1AA50E4", VA = "0x1AA50E4")]
		public static bool SlopeTile(int i, int j, int slope = 0, bool noEffects = false, bool quiet = true)
		{
			return default(bool);
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x1CFE650", Offset = "0x1CFE650", VA = "0x1CFE650")]
		public static bool PoundTile(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381A")]
		[Address(RVA = "0x1CFEE30", Offset = "0x1CFEE30", VA = "0x1CFEE30")]
		public static void PoundPlatform(int x, int y)
		{
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		[Token(Token = "0x600381B")]
		[Address(RVA = "0x1CFF81C", Offset = "0x1CFF81C", VA = "0x1CFF81C")]
		public static bool CacheUpdateMapTile(int i, int j, bool addToList = true)
		{
			return default(bool);
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381C")]
		[Address(RVA = "0x1CFF8EC", Offset = "0x1CFF8EC", VA = "0x1CFF8EC")]
		public static void PerformCachedMapTileUpdates()
		{
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
		[Token(Token = "0x600381D")]
		[Address(RVA = "0x1CFF9C0", Offset = "0x1CFF9C0", VA = "0x1CFF9C0")]
		public static bool UpdateMapTile(int i, int j, bool addToList = true)
		{
			return default(bool);
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381E")]
		[Address(RVA = "0x1CFFCB0", Offset = "0x1CFFCB0", VA = "0x1CFFCB0")]
		public static void TileMergeAttemptFrametest(int i, int j, int myType, int lookfor, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
		{
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381F")]
		[Address(RVA = "0x1CFFEA0", Offset = "0x1CFFEA0", VA = "0x1CFFEA0")]
		public static void TileMergeAttemptFrametest(int i, int j, int myType, bool[] lookfor, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
		{
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003820")]
		[Address(RVA = "0x1D00170", Offset = "0x1D00170", VA = "0x1D00170")]
		public static void TileMergeAttempt(int myType, int lookfor, ref int up, ref int down, ref int left, ref int right)
		{
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003821")]
		[Address(RVA = "0x1D001AC", Offset = "0x1D001AC", VA = "0x1D001AC")]
		public static void TileMergeAttempt(int myType, bool[] lookfor, ref int up, ref int down, ref int left, ref int right)
		{
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003822")]
		[Address(RVA = "0x1D0026C", Offset = "0x1D0026C", VA = "0x1D0026C")]
		public static void TileMergeAttempt(int myType, int lookfor, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
		{
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003823")]
		[Address(RVA = "0x1D002E8", Offset = "0x1D002E8", VA = "0x1D002E8")]
		public static void TileMergeAttempt(int myType, bool[] lookfor, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
		{
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003824")]
		[Address(RVA = "0x1D00458", Offset = "0x1D00458", VA = "0x1D00458")]
		public static void TileMergeAttempt(int myType, bool[] lookfor, int exclude, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
		{
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003825")]
		[Address(RVA = "0x1D0060C", Offset = "0x1D0060C", VA = "0x1D0060C")]
		public static void TileMergeAttempt(int myType, bool[] lookfor, bool[] exclude, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
		{
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003826")]
		[Address(RVA = "0x1D00884", Offset = "0x1D00884", VA = "0x1D00884")]
		public static void TileMergeAttemptWeird(int myType, int changeTo, bool[] exclude, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
		{
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x0001C908 File Offset: 0x0001AB08
		[Token(Token = "0x6003827")]
		[Address(RVA = "0x1D00A5C", Offset = "0x1D00A5C", VA = "0x1D00A5C")]
		public static int GetTileMossColor(int tileType)
		{
			return 0;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x1D00B54", Offset = "0x1D00B54", VA = "0x1D00B54")]
		public static void CheckFoodPlatter(int x, int y, int type)
		{
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003829")]
		[Address(RVA = "0x1C39A90", Offset = "0x1C39A90", VA = "0x1C39A90")]
		public static void TileFrameCosmetic(int i, int j, bool resetFrame = false)
		{
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x0001C920 File Offset: 0x0001AB20
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x1D010A4", Offset = "0x1D010A4", VA = "0x1D010A4")]
		private static bool CheckVines(int i, int j, int type, Tile tileCache)
		{
			return default(bool);
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382B")]
		[Address(RVA = "0x1D015F4", Offset = "0x1D015F4", VA = "0x1D015F4")]
		private static void TileFrameImportant(int i, int j, int type, Tile tileCache, bool resetFrame)
		{
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382C")]
		[Address(RVA = "0x1D0F5F4", Offset = "0x1D0F5F4", VA = "0x1D0F5F4")]
		public static void TileFrameDoWork(int i, int j, bool resetFrame, bool noBreak, ref bool mapCheck)
		{
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x1D0F018", Offset = "0x1D0F018", VA = "0x1D0F018")]
		public static void HandleRopeEndFraming(int i, int j)
		{
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382E")]
		[Address(RVA = "0x1D10678", Offset = "0x1D10678", VA = "0x1D10678")]
		private static void HandleRopeEndFraming_Inner(int i, int j)
		{
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382F")]
		[Address(RVA = "0x1A983B0", Offset = "0x1A983B0", VA = "0x1A983B0")]
		public static void TileFrame(int i, int j, bool resetFrame = false, bool noBreak = false)
		{
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x0001C938 File Offset: 0x0001AB38
		[Token(Token = "0x6003830")]
		[Address(RVA = "0x1D0F094", Offset = "0x1D0F094", VA = "0x1D0F094")]
		public static WorldGen.TileMergeCullCache GetTileMergeCulling(Tile tileCache, Tile tileTopCache, Tile tileBottomCache, Tile tileLeftCache, Tile tileRightCache, Tile tileBottomLeftCache, Tile tileBottomRightCache, Tile tileTopLeftCache, Tile tileTopRightCache)
		{
			return default(WorldGen.TileMergeCullCache);
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x0001C950 File Offset: 0x0001AB50
		[Token(Token = "0x6003831")]
		[Address(RVA = "0x1D00FC0", Offset = "0x1D00FC0", VA = "0x1D00FC0")]
		public static WorldGen.TileMergeCullCache GetTileMergeCulling(bool myWantedInvisibility, bool topInvisibleBlock, bool bottomInvisibleBlock, bool leftInvisibleBlock, bool rightInvisibleBlock, bool bottomLeftInvisibleBlock, bool bottomRightInvisibleBlock, bool topLeftInvisibleBlock, bool topRightInvisibleBlock)
		{
			return default(WorldGen.TileMergeCullCache);
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003832")]
		[Address(RVA = "0x1D11340", Offset = "0x1D11340", VA = "0x1D11340")]
		private static void StopMergingByInvsibility(ref int currentMerge, Tile block, bool wantedInvisibilityState)
		{
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x0001C968 File Offset: 0x0001AB68
		[Token(Token = "0x6003833")]
		[Address(RVA = "0x1D0FC50", Offset = "0x1D0FC50", VA = "0x1D0FC50")]
		private static bool SpawnFallingBlockProjectile(int i, int j, int type, Tile tileCache)
		{
			return default(bool);
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003834")]
		[Address(RVA = "0x1D0C3A8", Offset = "0x1D0C3A8", VA = "0x1D0C3A8")]
		public static void CheckTorch(int x, int y)
		{
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003835")]
		[Address(RVA = "0x1D0DCE4", Offset = "0x1D0DCE4", VA = "0x1D0DCE4")]
		public static void CheckProjectilePressurePad(int i, int j)
		{
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003836")]
		[Address(RVA = "0x1D11CF0", Offset = "0x1D11CF0", VA = "0x1D11CF0")]
		private static void CheckProjectilePressurePad_GetPossiblePlacementDirections(int i, int j, out bool canUp, out bool canLeft, out bool canRight, out bool canDown)
		{
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x0001C980 File Offset: 0x0001AB80
		[Token(Token = "0x6003837")]
		[Address(RVA = "0x1C34724", Offset = "0x1C34724", VA = "0x1C34724")]
		public static bool IsTreeType(int tree)
		{
			return default(bool);
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x0001C998 File Offset: 0x0001AB98
		[Token(Token = "0x6003838")]
		[Address(RVA = "0x1D1342C", Offset = "0x1D1342C", VA = "0x1D1342C")]
		public static int CanPlaceProjectilePressurePad(int x, int y, int type = 442, int style = 0, int direction = 0, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003839")]
		[Address(RVA = "0x1D0E9BC", Offset = "0x1D0E9BC", VA = "0x1D0E9BC")]
		private static void CheckDoorOpen(int i, int j, int tileFrameX, int tileFrameY)
		{
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383A")]
		[Address(RVA = "0x1D0E0F0", Offset = "0x1D0E0F0", VA = "0x1D0E0F0")]
		private static void CheckDoorClosed(int i, int j, int tileFrameX, int tileFrameY, int type)
		{
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383B")]
		[Address(RVA = "0x1D11C08", Offset = "0x1D11C08", VA = "0x1D11C08")]
		private static void GetSandfallProjData(int type, out int projType, out int dmg)
		{
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		[Token(Token = "0x600383C")]
		[Address(RVA = "0x1C36BD4", Offset = "0x1C36BD4", VA = "0x1C36BD4")]
		public static bool BlockBelowMakesSandConvertIntoHardenedSand(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		[Token(Token = "0x600383D")]
		[Address(RVA = "0x1D1142C", Offset = "0x1D1142C", VA = "0x1D1142C")]
		public static bool BlockBelowMakesSandFall(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		[Token(Token = "0x600383E")]
		[Address(RVA = "0x1D11610", Offset = "0x1D11610", VA = "0x1D11610")]
		public static bool AllowsSandfall(Tile tileTopCache)
		{
			return default(bool);
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x1D13558", Offset = "0x1D13558", VA = "0x1D13558")]
		public static void TriggerLunarApocalypse()
		{
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x1CA3294", Offset = "0x1CA3294", VA = "0x1CA3294")]
		public static void UpdateLunarApocalypse()
		{
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003841")]
		[Address(RVA = "0x1D14418", Offset = "0x1D14418", VA = "0x1D14418")]
		public static void StartImpendingDoom(int countdownTime)
		{
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x1D147AC", Offset = "0x1D147AC", VA = "0x1D147AC")]
		public static void GetRidOfCultists()
		{
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x1D14118", Offset = "0x1D14118", VA = "0x1D14118")]
		public static void MessageLunarApocalypse()
		{
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x1D14A08", Offset = "0x1D14A08", VA = "0x1D14A08")]
		public static void BroadcastText(NetworkText text, Vector4 color)
		{
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x1D14B08", Offset = "0x1D14B08", VA = "0x1D14B08")]
		public static void BroadcastText(NetworkText text, Vector3 color)
		{
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003846")]
		[Address(RVA = "0x1D14C00", Offset = "0x1D14C00", VA = "0x1D14C00")]
		public static void BroadcastText(NetworkText text, int r, int g, int b)
		{
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003847")]
		[Address(RVA = "0x1D14CF8", Offset = "0x1D14CF8", VA = "0x1D14CF8")]
		public static void BroadcastText(NetworkText text, byte r, byte g, byte b)
		{
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x1D14738", Offset = "0x1D14738", VA = "0x1D14738")]
		public static void BroadcastText(NetworkText text, Color color)
		{
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
		[Token(Token = "0x6003849")]
		[Address(RVA = "0x1D14DF0", Offset = "0x1D14DF0", VA = "0x1D14DF0")]
		public static bool CanCutTile(int x, int y, TileCuttingContext context)
		{
			return default(bool);
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x0001CA10 File Offset: 0x0001AC10
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x1D14F58", Offset = "0x1D14F58", VA = "0x1D14F58")]
		public static bool InAPlaceWithWind(Vector2 position, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x0001CA28 File Offset: 0x0001AC28
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x1D15654", Offset = "0x1D15654", VA = "0x1D15654")]
		public static bool DoesWindBlowAtThisHeight(int tileY)
		{
			return default(bool);
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x0001CA40 File Offset: 0x0001AC40
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x1D150C8", Offset = "0x1D150C8", VA = "0x1D150C8")]
		public static bool InAPlaceWithWind(int x, int y, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384D")]
		[Address(RVA = "0x1D156E4", Offset = "0x1D156E4", VA = "0x1D156E4")]
		public static int[] CountTileTypesInWorld(int[] oreTypes)
		{
			return null;
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384E")]
		[Address(RVA = "0x1D159F4", Offset = "0x1D159F4", VA = "0x1D159F4")]
		public WorldGen()
		{
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x0001CA58 File Offset: 0x0001AC58
		[Token(Token = "0x6003850")]
		[Address(RVA = "0x1D163BC", Offset = "0x1D163BC", VA = "0x1D163BC")]
		internal static bool <AddPasses>g__Main_tile_active|309_107(int x, int y, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
			return default(bool);
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003851")]
		[Address(RVA = "0x1D163E4", Offset = "0x1D163E4", VA = "0x1D163E4")]
		internal static void <AddPasses>g__TileActiveSet|309_108(int _tileOffset, bool isActive, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x0001CA70 File Offset: 0x0001AC70
		[Token(Token = "0x6003852")]
		[Address(RVA = "0x1D164B8", Offset = "0x1D164B8", VA = "0x1D164B8")]
		internal static short <AddPasses>g__Main_tile_frameX|309_109(int x, int y, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
			return 0;
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x0001CA88 File Offset: 0x0001AC88
		[Token(Token = "0x6003853")]
		[Address(RVA = "0x1D164DC", Offset = "0x1D164DC", VA = "0x1D164DC")]
		internal static ushort <AddPasses>g__Main_tile_type|309_110(int x, int y, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
			return 0;
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		[Token(Token = "0x6003854")]
		[Address(RVA = "0x1D16500", Offset = "0x1D16500", VA = "0x1D16500")]
		internal static byte <AddPasses>g__Main_tile_slope|309_111(int x, int y, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
			return 0;
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003855")]
		[Address(RVA = "0x1D16528", Offset = "0x1D16528", VA = "0x1D16528")]
		internal static void <AddPasses>g__Main_tile_slope_set|309_112(int _tileOffset, short slope, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		[Token(Token = "0x6003856")]
		[Address(RVA = "0x1D165B4", Offset = "0x1D165B4", VA = "0x1D165B4")]
		internal static bool <AddPasses>g__Main_tile_halfBrick|309_113(int x, int y, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
			return default(bool);
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003857")]
		[Address(RVA = "0x1D165DC", Offset = "0x1D165DC", VA = "0x1D165DC")]
		internal static void <AddPasses>g__Main_tile_halfBrick_set|309_114(int _tileOffset, bool halfBrick, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
		[Token(Token = "0x6003858")]
		[Address(RVA = "0x1D16674", Offset = "0x1D16674", VA = "0x1D16674")]
		internal static bool <AddPasses>g__Main_tile_lava|309_115(int x, int y, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
			return default(bool);
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x0001CAE8 File Offset: 0x0001ACE8
		[Token(Token = "0x6003859")]
		[Address(RVA = "0x1D1670C", Offset = "0x1D1670C", VA = "0x1D1670C")]
		internal static bool <AddPasses>g__Main_tile_honey|309_116(int x, int y, ref WorldGen.<>c__DisplayClass309_1 A_2)
		{
			return default(bool);
		}

		// Token: 0x040043E3 RID: 17379
		[Token(Token = "0x40043E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TownRoomManager TownManager;

		// Token: 0x040043E4 RID: 17380
		[Token(Token = "0x40043E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static WorldManifest Manifest;

		// Token: 0x040043E5 RID: 17381
		[Token(Token = "0x40043E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int tileReframeCount;

		// Token: 0x040043E6 RID: 17382
		[Token(Token = "0x40043E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static bool noMapUpdate;

		// Token: 0x040043E7 RID: 17383
		[Token(Token = "0x40043E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int treeBG1;

		// Token: 0x040043E8 RID: 17384
		[Token(Token = "0x40043E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int treeBG2;

		// Token: 0x040043E9 RID: 17385
		[Token(Token = "0x40043E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int treeBG3;

		// Token: 0x040043EA RID: 17386
		[Token(Token = "0x40043EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static int treeBG4;

		// Token: 0x040043EB RID: 17387
		[Token(Token = "0x40043EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int corruptBG;

		// Token: 0x040043EC RID: 17388
		[Token(Token = "0x40043EC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int jungleBG;

		// Token: 0x040043ED RID: 17389
		[Token(Token = "0x40043ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static int snowBG;

		// Token: 0x040043EE RID: 17390
		[Token(Token = "0x40043EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static int hallowBG;

		// Token: 0x040043EF RID: 17391
		[Token(Token = "0x40043EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int crimsonBG;

		// Token: 0x040043F0 RID: 17392
		[Token(Token = "0x40043F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static int desertBG;

		// Token: 0x040043F1 RID: 17393
		[Token(Token = "0x40043F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int oceanBG;

		// Token: 0x040043F2 RID: 17394
		[Token(Token = "0x40043F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static int mushroomBG;

		// Token: 0x040043F3 RID: 17395
		[Token(Token = "0x40043F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static int underworldBG;

		// Token: 0x040043F4 RID: 17396
		[Token(Token = "0x40043F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int oceanDistance;

		// Token: 0x040043F5 RID: 17397
		[Token(Token = "0x40043F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int beachDistance;

		// Token: 0x040043F6 RID: 17398
		[Token(Token = "0x40043F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int shimmerSafetyDistance;

		// Token: 0x040043F7 RID: 17399
		[Token(Token = "0x40043F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static bool crimson;

		// Token: 0x040043F8 RID: 17400
		[Token(Token = "0x40043F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public static bool generatingRandomEvil;

		// Token: 0x040043F9 RID: 17401
		[Token(Token = "0x40043F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static int[] tileCounts;

		// Token: 0x040043FA RID: 17402
		[Token(Token = "0x40043FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static int totalEvil;

		// Token: 0x040043FB RID: 17403
		[Token(Token = "0x40043FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static int totalBlood;

		// Token: 0x040043FC RID: 17404
		[Token(Token = "0x40043FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static int totalGood;

		// Token: 0x040043FD RID: 17405
		[Token(Token = "0x40043FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static int totalSolid;

		// Token: 0x040043FE RID: 17406
		[Token(Token = "0x40043FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static int totalEvil2;

		// Token: 0x040043FF RID: 17407
		[Token(Token = "0x40043FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static int totalBlood2;

		// Token: 0x04004400 RID: 17408
		[Token(Token = "0x4004400")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int totalGood2;

		// Token: 0x04004401 RID: 17409
		[Token(Token = "0x4004401")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static int totalSolid2;

		// Token: 0x04004402 RID: 17410
		[Token(Token = "0x4004402")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static byte tEvil;

		// Token: 0x04004403 RID: 17411
		[Token(Token = "0x4004403")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public static byte tBlood;

		// Token: 0x04004404 RID: 17412
		[Token(Token = "0x4004404")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public static byte tGood;

		// Token: 0x04004405 RID: 17413
		[Token(Token = "0x4004405")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static int totalX;

		// Token: 0x04004406 RID: 17414
		[Token(Token = "0x4004406")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static int totalD;

		// Token: 0x04004407 RID: 17415
		[Token(Token = "0x4004407")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static bool HMConversion;

		// Token: 0x04004408 RID: 17416
		[Token(Token = "0x4004408")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public static bool ClearingPaints;

		// Token: 0x04004409 RID: 17417
		[Token(Token = "0x4004409")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public static bool TransformingWorld;

		// Token: 0x0400440A RID: 17418
		[Token(Token = "0x400440A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static int HardModeProgress;

		// Token: 0x0400440B RID: 17419
		[Token(Token = "0x400440B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static bool noTileActions;

		// Token: 0x0400440C RID: 17420
		[Token(Token = "0x400440C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		public static bool spawnEye;

		// Token: 0x0400440D RID: 17421
		[Token(Token = "0x400440D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static int spawnHardBoss;

		// Token: 0x0400440E RID: 17422
		[Token(Token = "0x400440E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public static bool isGeneratingOrLoadingWorld;

		// Token: 0x0400440F RID: 17423
		[Token(Token = "0x400440F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		public static bool shadowOrbSmashed;

		// Token: 0x04004410 RID: 17424
		[Token(Token = "0x4004410")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static int shadowOrbCount;

		// Token: 0x04004411 RID: 17425
		[Token(Token = "0x4004411")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static int altarCount;

		// Token: 0x04004412 RID: 17426
		[Token(Token = "0x4004412")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static bool builtHouseWithNoFurniture;

		// Token: 0x04004413 RID: 17427
		[Token(Token = "0x4004413")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public static bool builtHouseWithNoLight;

		// Token: 0x04004414 RID: 17428
		[Token(Token = "0x4004414")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public static bool spawnMeteor;

		// Token: 0x04004415 RID: 17429
		[Token(Token = "0x4004415")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public static bool loadFailed;

		// Token: 0x04004416 RID: 17430
		[Token(Token = "0x4004416")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public static bool loadSuccess;

		// Token: 0x04004417 RID: 17431
		[Token(Token = "0x4004417")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public static bool worldCleared;

		// Token: 0x04004418 RID: 17432
		[Token(Token = "0x4004418")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public static bool worldBackup;

		// Token: 0x04004419 RID: 17433
		[Token(Token = "0x4004419")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA7")]
		public static bool loadBackup;

		// Token: 0x0400441A RID: 17434
		[Token(Token = "0x400441A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static int lastMaxTilesX;

		// Token: 0x0400441B RID: 17435
		[Token(Token = "0x400441B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private static int lastMaxTilesY;

		// Token: 0x0400441C RID: 17436
		[Token(Token = "0x400441C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static bool mergeUp;

		// Token: 0x0400441D RID: 17437
		[Token(Token = "0x400441D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private static bool mergeDown;

		// Token: 0x0400441E RID: 17438
		[Token(Token = "0x400441E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		private static bool mergeLeft;

		// Token: 0x0400441F RID: 17439
		[Token(Token = "0x400441F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB3")]
		private static bool mergeRight;

		// Token: 0x04004420 RID: 17440
		[Token(Token = "0x4004420")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private static bool stopDrops;

		// Token: 0x04004421 RID: 17441
		[Token(Token = "0x4004421")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public static bool AllowedToSpreadInfections;

		// Token: 0x04004422 RID: 17442
		[Token(Token = "0x4004422")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static string statusText;

		// Token: 0x04004423 RID: 17443
		[Token(Token = "0x4004423")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public static bool destroyObject;

		// Token: 0x04004424 RID: 17444
		[Token(Token = "0x4004424")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static int spawnDelay;

		// Token: 0x04004425 RID: 17445
		[Token(Token = "0x4004425")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public static int prioritizedTownNPCType;

		// Token: 0x04004426 RID: 17446
		[Token(Token = "0x4004426")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static int homelessSpawnTimeout;

		// Token: 0x04004427 RID: 17447
		[Token(Token = "0x4004427")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public static int numTileCount;

		// Token: 0x04004428 RID: 17448
		[Token(Token = "0x4004428")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static int maxTileCount;

		// Token: 0x04004429 RID: 17449
		[Token(Token = "0x4004429")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public static int maxWallOut2;

		// Token: 0x0400442A RID: 17450
		[Token(Token = "0x400442A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static int lavaCount;

		// Token: 0x0400442B RID: 17451
		[Token(Token = "0x400442B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public static int iceCount;

		// Token: 0x0400442C RID: 17452
		[Token(Token = "0x400442C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static int sandCount;

		// Token: 0x0400442D RID: 17453
		[Token(Token = "0x400442D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public static int rockCount;

		// Token: 0x0400442E RID: 17454
		[Token(Token = "0x400442E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static int shroomCount;

		// Token: 0x0400442F RID: 17455
		[Token(Token = "0x400442F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public static int maxRoomTiles;

		// Token: 0x04004430 RID: 17456
		[Token(Token = "0x4004430")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static int maxRoomTilesForQuery;

		// Token: 0x04004431 RID: 17457
		[Token(Token = "0x4004431")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public static int numRoomTiles;

		// Token: 0x04004432 RID: 17458
		[Token(Token = "0x4004432")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static int[] roomX;

		// Token: 0x04004433 RID: 17459
		[Token(Token = "0x4004433")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public static int[] roomY;

		// Token: 0x04004434 RID: 17460
		[Token(Token = "0x4004434")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static int roomCeilingsCount;

		// Token: 0x04004435 RID: 17461
		[Token(Token = "0x4004435")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public static int[] roomCeilingX;

		// Token: 0x04004436 RID: 17462
		[Token(Token = "0x4004436")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static int[] roomCeilingY;

		// Token: 0x04004437 RID: 17463
		[Token(Token = "0x4004437")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public static int roomX1;

		// Token: 0x04004438 RID: 17464
		[Token(Token = "0x4004438")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static int roomX2;

		// Token: 0x04004439 RID: 17465
		[Token(Token = "0x4004439")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public static int roomY1;

		// Token: 0x0400443A RID: 17466
		[Token(Token = "0x400443A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static int roomY2;

		// Token: 0x0400443B RID: 17467
		[Token(Token = "0x400443B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public static bool canSpawn;

		// Token: 0x0400443C RID: 17468
		[Token(Token = "0x400443C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static bool[] houseTile;

		// Token: 0x0400443D RID: 17469
		[Token(Token = "0x400443D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public static int bestX;

		// Token: 0x0400443E RID: 17470
		[Token(Token = "0x400443E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static int bestY;

		// Token: 0x0400443F RID: 17471
		[Token(Token = "0x400443F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public static int hiScore;

		// Token: 0x04004440 RID: 17472
		[Token(Token = "0x4004440")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static bool roomTorch;

		// Token: 0x04004441 RID: 17473
		[Token(Token = "0x4004441")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		private static bool roomDoor;

		// Token: 0x04004442 RID: 17474
		[Token(Token = "0x4004442")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		private static bool roomChair;

		// Token: 0x04004443 RID: 17475
		[Token(Token = "0x4004443")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x133")]
		private static bool roomTable;

		// Token: 0x04004444 RID: 17476
		[Token(Token = "0x4004444")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private static bool roomOccupied;

		// Token: 0x04004445 RID: 17477
		[Token(Token = "0x4004445")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		private static bool roomEvil;

		// Token: 0x04004446 RID: 17478
		[Token(Token = "0x4004446")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x136")]
		private static bool roomHasStandingSpace;

		// Token: 0x04004447 RID: 17479
		[Token(Token = "0x4004447")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x137")]
		private static bool roomHasStinkbug;

		// Token: 0x04004448 RID: 17480
		[Token(Token = "0x4004448")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static bool roomHasEchoStinkbug;

		// Token: 0x04004449 RID: 17481
		[Token(Token = "0x4004449")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public static int WorldGenParam_Evil;

		// Token: 0x0400444A RID: 17482
		[Token(Token = "0x400444A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static readonly int cactusWaterWidth;

		// Token: 0x0400444B RID: 17483
		[Token(Token = "0x400444B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public static readonly int cactusWaterHeight;

		// Token: 0x0400444C RID: 17484
		[Token(Token = "0x400444C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static readonly int cactusWaterLimit;

		// Token: 0x0400444D RID: 17485
		[Token(Token = "0x400444D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public static MysticLogFairiesEvent mysticLogsEvent;

		// Token: 0x0400444E RID: 17486
		[Token(Token = "0x400444E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static Point LastFoundHouse;

		// Token: 0x0400444F RID: 17487
		[Token(Token = "0x400444F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static bool currentlyTryingToUseAlternateHousingSpot;

		// Token: 0x04004450 RID: 17488
		[Token(Token = "0x4004450")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private static int sharedRoomX;

		// Token: 0x04004451 RID: 17489
		[Token(Token = "0x4004451")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static Stack<Point> _roomCheckStack;

		// Token: 0x04004452 RID: 17490
		[Token(Token = "0x4004452")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public static TownNPCRoomCheckFailureReason roomCheckFailureReason;

		// Token: 0x04004453 RID: 17491
		[Token(Token = "0x4004453")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static int meteorShowerCount;

		// Token: 0x04004454 RID: 17492
		[Token(Token = "0x4004454")]
		public const int WorldSizeSmallX = 4200;

		// Token: 0x04004455 RID: 17493
		[Token(Token = "0x4004455")]
		public const int WorldSizeSmallY = 1200;

		// Token: 0x04004456 RID: 17494
		[Token(Token = "0x4004456")]
		public const int WorldSizeMediumX = 6400;

		// Token: 0x04004457 RID: 17495
		[Token(Token = "0x4004457")]
		public const int WorldSizeMediumY = 1800;

		// Token: 0x04004458 RID: 17496
		[Token(Token = "0x4004458")]
		public const int WorldSizeLargeX = 8400;

		// Token: 0x04004459 RID: 17497
		[Token(Token = "0x4004459")]
		public const int WorldSizeLargeY = 2400;

		// Token: 0x0400445A RID: 17498
		[Token(Token = "0x400445A")]
		public const int InfectionAndGrassSpreadOuterWorldBuffer = 10;

		// Token: 0x0400445B RID: 17499
		[Token(Token = "0x400445B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public static bool generatingWorld;

		// Token: 0x0400445C RID: 17500
		[Token(Token = "0x400445C")]
		public static bool generatingWorldOnThisThread;

		// Token: 0x0400445D RID: 17501
		[Token(Token = "0x400445D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public static ManagedThread worldGenThread;

		// Token: 0x0400445E RID: 17502
		[Token(Token = "0x400445E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public static bool SavingSettings;

		// Token: 0x0400445F RID: 17503
		[Token(Token = "0x400445F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x175")]
		public static bool SavingPlayer;

		// Token: 0x04004460 RID: 17504
		[Token(Token = "0x4004460")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static int[,] trapDiag;

		// Token: 0x04004461 RID: 17505
		[Token(Token = "0x4004461")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public static List<WorldGen.nextCountNode> _countOpenNodes;

		// Token: 0x04004462 RID: 17506
		[Token(Token = "0x4004462")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public static List<WorldGen.nextCountNode> _countAvailableNodes;

		// Token: 0x04004463 RID: 17507
		[Token(Token = "0x4004463")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private static List<WorldGen.nextCountDirtNode> _dirtCountOpenNodes;

		// Token: 0x04004464 RID: 17508
		[Token(Token = "0x4004464")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static List<WorldGen.nextCountDirtNode> _dirtCountAvailableNodes;

		// Token: 0x04004465 RID: 17509
		[Token(Token = "0x4004465")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private static bool[] gem;

		// Token: 0x04004466 RID: 17510
		[Token(Token = "0x4004466")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static int[] mossType;

		// Token: 0x04004467 RID: 17511
		[Token(Token = "0x4004467")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private static ushort neonMossType;

		// Token: 0x04004468 RID: 17512
		[Token(Token = "0x4004468")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static int tileCounterNum;

		// Token: 0x04004469 RID: 17513
		[Token(Token = "0x4004469")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private static int tileCounterMax;

		// Token: 0x0400446A RID: 17514
		[Token(Token = "0x400446A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static int[] tileCounterX;

		// Token: 0x0400446B RID: 17515
		[Token(Token = "0x400446B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private static int[] tileCounterY;

		// Token: 0x0400446C RID: 17516
		[Token(Token = "0x400446C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public static ushort lastTileCounterSearch;

		// Token: 0x0400446D RID: 17517
		[Token(Token = "0x400446D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private static WorldGenerator _generator;

		// Token: 0x0400446E RID: 17518
		[Token(Token = "0x400446E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public static int SmallConsecutivesFound;

		// Token: 0x0400446F RID: 17519
		[Token(Token = "0x400446F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public static int SmallConsecutivesEliminated;

		// Token: 0x04004470 RID: 17520
		[Token(Token = "0x4004470")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public static bool remixWorldGen;

		// Token: 0x04004471 RID: 17521
		[Token(Token = "0x4004471")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public static bool everythingWorldGen;

		// Token: 0x04004472 RID: 17522
		[Token(Token = "0x4004472")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public static bool noTrapsWorldGen;

		// Token: 0x04004473 RID: 17523
		[Token(Token = "0x4004473")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public static bool drunkWorldGen;

		// Token: 0x04004474 RID: 17524
		[Token(Token = "0x4004474")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public static bool getGoodWorldGen;

		// Token: 0x04004475 RID: 17525
		[Token(Token = "0x4004475")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public static bool tenthAnniversaryWorldGen;

		// Token: 0x04004476 RID: 17526
		[Token(Token = "0x4004476")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public static bool dontStarveWorldGen;

		// Token: 0x04004477 RID: 17527
		[Token(Token = "0x4004477")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public static bool notTheBees;

		// Token: 0x04004478 RID: 17528
		[Token(Token = "0x4004478")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public static bool skyblockWorldGen;

		// Token: 0x04004479 RID: 17529
		[Token(Token = "0x4004479")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public static bool drunkWorldGenText;

		// Token: 0x0400447A RID: 17530
		[Token(Token = "0x400447A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public static bool placingTraps;

		// Token: 0x0400447B RID: 17531
		[Token(Token = "0x400447B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private static bool[] tileSolidBackup;

		// Token: 0x0400447C RID: 17532
		[Token(Token = "0x400447C")]
		private const int ItemSpawnProtectionTime = 18000;

		// Token: 0x0400447D RID: 17533
		[Token(Token = "0x400447D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public static Thread ConversionThread;

		// Token: 0x0400447E RID: 17534
		[Token(Token = "0x400447E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private static List<WorldGen.QueuedAction> queuedActions;

		// Token: 0x0400447F RID: 17535
		[Token(Token = "0x400447F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static List<Point> ShimmerTiles;

		// Token: 0x04004480 RID: 17536
		[Token(Token = "0x4004480")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private static List<Color> _coatingColors;

		// Token: 0x04004481 RID: 17537
		[Token(Token = "0x4004481")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static int catTailDistance;

		// Token: 0x04004482 RID: 17538
		[Token(Token = "0x4004482")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public static TreeTopsInfo TreeTops;

		// Token: 0x04004483 RID: 17539
		[Token(Token = "0x4004483")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public static BackgroundChangeFlashInfo BackgroundsCache;

		// Token: 0x04004484 RID: 17540
		[Token(Token = "0x4004484")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private static int maxTreeShakes;

		// Token: 0x04004485 RID: 17541
		[Token(Token = "0x4004485")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static int numTreeShakes;

		// Token: 0x04004486 RID: 17542
		[Token(Token = "0x4004486")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private static int[] treeShakeX;

		// Token: 0x04004487 RID: 17543
		[Token(Token = "0x4004487")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static int[] treeShakeY;

		// Token: 0x04004488 RID: 17544
		[Token(Token = "0x4004488")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private static bool fossilBreak;

		// Token: 0x04004489 RID: 17545
		[Token(Token = "0x4004489")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public static Queue<Point> ExploitDestroyQueue;

		// Token: 0x0400448A RID: 17546
		[Token(Token = "0x400448A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		private static bool hardModeWorldUpdates;

		// Token: 0x0400448B RID: 17547
		[Token(Token = "0x400448B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static int _lastFrame;

		// Token: 0x0400448C RID: 17548
		[Token(Token = "0x400448C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private static bool growGrassUnderground;

		// Token: 0x0400448D RID: 17549
		[Token(Token = "0x400448D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static uint plantAlchRarityRand;

		// Token: 0x0400448E RID: 17550
		[Token(Token = "0x400448E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private static bool _isRainingBoulders;

		// Token: 0x0400448F RID: 17551
		[Token(Token = "0x400448F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static List<Rectangle> _SpawnThunderStorm_SafeSpots;

		// Token: 0x04004490 RID: 17552
		[Token(Token = "0x4004490")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private static uint plantDyeRandOG;

		// Token: 0x04004491 RID: 17553
		[Token(Token = "0x4004491")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static uint plantDyeRandHMOG;

		// Token: 0x04004492 RID: 17554
		[Token(Token = "0x4004492")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private static uint lilyPadRandOG;

		// Token: 0x04004493 RID: 17555
		[Token(Token = "0x4004493")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static uint cattailRandOG;

		// Token: 0x04004494 RID: 17556
		[Token(Token = "0x4004494")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private static uint plantDyeRandUG;

		// Token: 0x04004495 RID: 17557
		[Token(Token = "0x4004495")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static uint plantDyeRandHMUG;

		// Token: 0x04004496 RID: 17558
		[Token(Token = "0x4004496")]
		public const bool BUBBLES_SOLID_STATE_FOR_HOUSING = true;

		// Token: 0x04004497 RID: 17559
		[Token(Token = "0x4004497")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		public static int grassSpread;

		// Token: 0x04004498 RID: 17560
		[Token(Token = "0x4004498")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static Point[] heartPos;

		// Token: 0x04004499 RID: 17561
		[Token(Token = "0x4004499")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private static int heartCount;

		// Token: 0x0400449A RID: 17562
		[Token(Token = "0x400449A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static object WaitingLock;

		// Token: 0x0400449B RID: 17563
		[Token(Token = "0x400449B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private static bool ThreadWaiting;

		// Token: 0x0400449C RID: 17564
		[Token(Token = "0x400449C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x23D")]
		private static bool ThreadRunning;

		// Token: 0x0400449D RID: 17565
		[Token(Token = "0x400449D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DateTime ThreadStarted;

		// Token: 0x0400449E RID: 17566
		[Token(Token = "0x400449E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static bool threadInProgress;

		// Token: 0x0400449F RID: 17567
		[Token(Token = "0x400449F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private static AutoResetEvent WaitingForThreadTime;

		// Token: 0x040044A0 RID: 17568
		[Token(Token = "0x40044A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static AutoResetEvent WaitingForThreadToSuspend;

		// Token: 0x040044A1 RID: 17569
		[Token(Token = "0x40044A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		public static int allowedThreadTime;

		// Token: 0x040044A2 RID: 17570
		[Token(Token = "0x40044A2")]
		private const int strip_w = 200;

		// Token: 0x040044A3 RID: 17571
		[Token(Token = "0x40044A3")]
		private const int strip_h = 50;

		// Token: 0x040044A4 RID: 17572
		[Token(Token = "0x40044A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static readonly Vertical64BitStrips bitStrip;

		// Token: 0x040044A5 RID: 17573
		[Token(Token = "0x40044A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		public static bool noMapUpdateRefresh;

		// Token: 0x040044A6 RID: 17574
		[Token(Token = "0x40044A6")]
		private const int MaxCachedUpdates = 20000;

		// Token: 0x040044A7 RID: 17575
		[Token(Token = "0x40044A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static uint[] CachedMapTileUpdates;

		// Token: 0x040044A8 RID: 17576
		[Token(Token = "0x40044A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		private static int CachedMapTileUpdateCount;

		// Token: 0x040044A9 RID: 17577
		[Token(Token = "0x40044A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public static bool _preventInfiniteRopeFraming;

		// Token: 0x040044AA RID: 17578
		[Token(Token = "0x40044AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x269")]
		public static bool LogFrames;

		// Token: 0x040044AB RID: 17579
		[Token(Token = "0x40044AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private static int currentStack;

		// Token: 0x040044AC RID: 17580
		[Token(Token = "0x40044AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static int maxStack;

		// Token: 0x040044AD RID: 17581
		[Token(Token = "0x40044AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		private static Rectangle fallingBlockRegion;

		// Token: 0x040044AE RID: 17582
		[Token(Token = "0x40044AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private static int maxCount;

		// Token: 0x02000519 RID: 1305
		[Token(Token = "0x2000519")]
		public class SecretSeed
		{
			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x0600385A RID: 14426 RVA: 0x0001CB00 File Offset: 0x0001AD00
			[Token(Token = "0x1700070A")]
			public static bool anySecretSeedIsActive
			{
				[Token(Token = "0x600385A")]
				[Address(RVA = "0x1D167A8", Offset = "0x1D167A8", VA = "0x1D167A8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x0600385B RID: 14427 RVA: 0x0001CB18 File Offset: 0x0001AD18
			[Token(Token = "0x1700070B")]
			public bool Enabled
			{
				[Token(Token = "0x600385B")]
				[Address(RVA = "0x1D16818", Offset = "0x1D16818", VA = "0x1D16818")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600385C RID: 14428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600385C")]
			[Address(RVA = "0x1D16820", Offset = "0x1D16820", VA = "0x1D16820")]
			private SecretSeed(string localization, LegacySoundStyle sound, string code)
			{
			}

			// Token: 0x0600385D RID: 14429 RVA: 0x0001CB30 File Offset: 0x0001AD30
			[Token(Token = "0x600385D")]
			[Address(RVA = "0x1D1684C", Offset = "0x1D1684C", VA = "0x1D1684C")]
			public bool Check(string code)
			{
				return default(bool);
			}

			// Token: 0x0600385E RID: 14430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600385E")]
			[Address(RVA = "0x1D16990", Offset = "0x1D16990", VA = "0x1D16990")]
			public static WorldGen.SecretSeed Register(string localization, LegacySoundStyle sound, string code)
			{
				return null;
			}

			// Token: 0x0600385F RID: 14431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600385F")]
			[Address(RVA = "0x1D16AC0", Offset = "0x1D16AC0", VA = "0x1D16AC0")]
			public static void ClearAllSeeds()
			{
			}

			// Token: 0x06003860 RID: 14432 RVA: 0x0001CB48 File Offset: 0x0001AD48
			[Token(Token = "0x6003860")]
			[Address(RVA = "0x1D16D90", Offset = "0x1D16D90", VA = "0x1D16D90")]
			public static bool CheckInputForSecretSeed(string worldSeed, out WorldGen.SecretSeed secretSeed)
			{
				return default(bool);
			}

			// Token: 0x06003861 RID: 14433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003861")]
			[Address(RVA = "0x1D171F4", Offset = "0x1D171F4", VA = "0x1D171F4")]
			public static void Enable(WorldGen.SecretSeed seed, bool playSound = true)
			{
			}

			// Token: 0x06003862 RID: 14434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003862")]
			[Address(RVA = "0x1D16D00", Offset = "0x1D16D00", VA = "0x1D16D00")]
			public static void Disable(WorldGen.SecretSeed seed)
			{
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06003863 RID: 14435 RVA: 0x0001CB60 File Offset: 0x0001AD60
			[Token(Token = "0x1700070C")]
			public static bool GenerateBiggerAbandonedHouses
			{
				[Token(Token = "0x6003863")]
				[Address(RVA = "0x1D17318", Offset = "0x1D17318", VA = "0x1D17318")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06003864 RID: 14436 RVA: 0x0001CB78 File Offset: 0x0001AD78
			[Token(Token = "0x1700070D")]
			public static bool GenerateRainbowGlowsticks
			{
				[Token(Token = "0x6003864")]
				[Address(RVA = "0x1D17488", Offset = "0x1D17488", VA = "0x1D17488")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003865 RID: 14437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003865")]
			[Address(RVA = "0x1D1754C", Offset = "0x1D1754C", VA = "0x1D1754C")]
			public static void InitializeSecretSeeds()
			{
			}

			// Token: 0x06003866 RID: 14438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003866")]
			[Address(RVA = "0x1D178E0", Offset = "0x1D178E0", VA = "0x1D178E0")]
			public static void FinalizeSecretSeeds()
			{
			}

			// Token: 0x06003867 RID: 14439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003867")]
			[Address(RVA = "0x1D2C904", Offset = "0x1D2C904", VA = "0x1D2C904")]
			public static void FinalSeedCleanup()
			{
			}

			// Token: 0x06003868 RID: 14440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003868")]
			[Address(RVA = "0x1D2D204", Offset = "0x1D2D204", VA = "0x1D2D204")]
			public static void FinalSeedCleanup_Paint(int x, int y)
			{
			}

			// Token: 0x06003869 RID: 14441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003869")]
			[Address(RVA = "0x1D2EB7C", Offset = "0x1D2EB7C", VA = "0x1D2EB7C")]
			public static void DoPaintEverythingNegative_SingleTile(int x, int y)
			{
			}

			// Token: 0x0600386A RID: 14442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600386A")]
			[Address(RVA = "0x1D2E6F8", Offset = "0x1D2E6F8", VA = "0x1D2E6F8")]
			public static void DoPaintEverythingGray_SingleTile(int x, int y)
			{
			}

			// Token: 0x0600386B RID: 14443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600386B")]
			[Address(RVA = "0x1D2D3F8", Offset = "0x1D2D3F8", VA = "0x1D2D3F8")]
			public static void DoCoatEverythingEcho_SingleTile(int x, int y)
			{
			}

			// Token: 0x0600386C RID: 14444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600386C")]
			[Address(RVA = "0x1D2E0BC", Offset = "0x1D2E0BC", VA = "0x1D2E0BC")]
			public static void DoCoatEverythingIlluminant_SingleTile(int x, int y)
			{
			}

			// Token: 0x0600386D RID: 14445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600386D")]
			[Address(RVA = "0x1D2DD58", Offset = "0x1D2DD58", VA = "0x1D2DD58")]
			public static void DoCoatEverythingEcho_ErrorRemoval(int x, int y)
			{
			}

			// Token: 0x0600386E RID: 14446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600386E")]
			[Address(RVA = "0x1D22648", Offset = "0x1D22648", VA = "0x1D22648")]
			public static void DoPaintEverythingGray()
			{
			}

			// Token: 0x0600386F RID: 14447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600386F")]
			[Address(RVA = "0x1D22CC0", Offset = "0x1D22CC0", VA = "0x1D22CC0")]
			public static void DoPaintEverythingNegative()
			{
			}

			// Token: 0x06003870 RID: 14448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003870")]
			[Address(RVA = "0x1D210E4", Offset = "0x1D210E4", VA = "0x1D210E4")]
			public static void DoCoatEverythingEcho()
			{
			}

			// Token: 0x06003871 RID: 14449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003871")]
			[Address(RVA = "0x1D21F10", Offset = "0x1D21F10", VA = "0x1D21F10")]
			public static void DoCoatEverythingIlluminant()
			{
			}

			// Token: 0x06003872 RID: 14450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003872")]
			[Address(RVA = "0x1D20F40", Offset = "0x1D20F40", VA = "0x1D20F40")]
			public static void DoNoSurface()
			{
			}

			// Token: 0x06003873 RID: 14451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003873")]
			[Address(RVA = "0x1D30180", Offset = "0x1D30180", VA = "0x1D30180")]
			public static void DoNoSurfaceFillTheTop()
			{
			}

			// Token: 0x06003874 RID: 14452 RVA: 0x0001CB90 File Offset: 0x0001AD90
			[Token(Token = "0x6003874")]
			[Address(RVA = "0x1D30850", Offset = "0x1D30850", VA = "0x1D30850")]
			public static ushort DoErrorWorldGetRandomBlock()
			{
				return 0;
			}

			// Token: 0x06003875 RID: 14453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003875")]
			[Address(RVA = "0x1D30A78", Offset = "0x1D30A78", VA = "0x1D30A78")]
			public static void DoErrorWorldShuffleBlocks()
			{
			}

			// Token: 0x06003876 RID: 14454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003876")]
			[Address(RVA = "0x1D274D0", Offset = "0x1D274D0", VA = "0x1D274D0")]
			public static void DoErrorWorldFinish()
			{
			}

			// Token: 0x06003877 RID: 14455 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
			[Token(Token = "0x6003877")]
			[Address(RVA = "0x1D35A14", Offset = "0x1D35A14", VA = "0x1D35A14")]
			public static int DoErrorWorldFindChestItem()
			{
				return 0;
			}

			// Token: 0x06003878 RID: 14456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003878")]
			[Address(RVA = "0x1D35B18", Offset = "0x1D35B18", VA = "0x1D35B18")]
			public static void DoExtraLiquidAddLiquid()
			{
			}

			// Token: 0x06003879 RID: 14457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003879")]
			[Address(RVA = "0x1D36550", Offset = "0x1D36550", VA = "0x1D36550")]
			public static void DoExtraLiquidAddBubbleBlocks()
			{
			}

			// Token: 0x0600387A RID: 14458 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
			[Token(Token = "0x600387A")]
			[Address(RVA = "0x1D385A8", Offset = "0x1D385A8", VA = "0x1D385A8")]
			public static bool IsConsideredTheSpawnArea(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x0600387B RID: 14459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600387B")]
			[Address(RVA = "0x1D19F14", Offset = "0x1D19F14", VA = "0x1D19F14")]
			public static void DoExtraLiquidFinish()
			{
			}

			// Token: 0x0600387C RID: 14460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600387C")]
			[Address(RVA = "0x1D38750", Offset = "0x1D38750", VA = "0x1D38750")]
			public static void DoRainsForAYear()
			{
			}

			// Token: 0x0600387D RID: 14461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600387D")]
			[Address(RVA = "0x1D24134", Offset = "0x1D24134", VA = "0x1D24134")]
			public static void DoRandomSpawn()
			{
			}

			// Token: 0x0600387E RID: 14462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600387E")]
			[Address(RVA = "0x1D20EA0", Offset = "0x1D20EA0", VA = "0x1D20EA0")]
			public static void DoStartInHardmode()
			{
			}

			// Token: 0x0600387F RID: 14463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600387F")]
			[Address(RVA = "0x1D1EBB8", Offset = "0x1D1EBB8", VA = "0x1D1EBB8")]
			public static void DoNoInfection()
			{
			}

			// Token: 0x06003880 RID: 14464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003880")]
			[Address(RVA = "0x1D1F290", Offset = "0x1D1F290", VA = "0x1D1F290")]
			public static void DoHallowOnSurface()
			{
			}

			// Token: 0x06003881 RID: 14465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003881")]
			[Address(RVA = "0x1D20178", Offset = "0x1D20178", VA = "0x1D20178")]
			public static void DoWorldIsInfected()
			{
			}

			// Token: 0x06003882 RID: 14466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003882")]
			[Address(RVA = "0x1D1AC20", Offset = "0x1D1AC20", VA = "0x1D1AC20")]
			public static void DoSurfaceIsInSpace()
			{
			}

			// Token: 0x06003883 RID: 14467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003883")]
			[Address(RVA = "0x1D1BF2C", Offset = "0x1D1BF2C", VA = "0x1D1BF2C")]
			public static void DoSurfaceIsMushrooms()
			{
			}

			// Token: 0x06003884 RID: 14468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003884")]
			[Address(RVA = "0x1D26FE4", Offset = "0x1D26FE4", VA = "0x1D26FE4")]
			public static void DoWorldIsFrozenFinish()
			{
			}

			// Token: 0x06003885 RID: 14469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003885")]
			[Address(RVA = "0x1D1D9E0", Offset = "0x1D1D9E0", VA = "0x1D1D9E0")]
			public static void DoWorldIsFrozen()
			{
			}

			// Token: 0x06003886 RID: 14470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003886")]
			[Address(RVA = "0x1D184D8", Offset = "0x1D184D8", VA = "0x1D184D8")]
			public static void DoSurfaceIsDesertFinish()
			{
			}

			// Token: 0x06003887 RID: 14471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003887")]
			[Address(RVA = "0x1D38968", Offset = "0x1D38968", VA = "0x1D38968")]
			public static void DoSurfaceIsDesert()
			{
			}

			// Token: 0x06003888 RID: 14472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003888")]
			[Address(RVA = "0x1D3DA94", Offset = "0x1D3DA94", VA = "0x1D3DA94")]
			public static void DoSurfaceIsDesertNoSurfaceCleanup()
			{
			}

			// Token: 0x06003889 RID: 14473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003889")]
			[Address(RVA = "0x1D3DF64", Offset = "0x1D3DF64", VA = "0x1D3DF64")]
			public static void DoNoSpiderCavesILiedMoreSpiderCaves()
			{
			}

			// Token: 0x0600388A RID: 14474 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
			[Token(Token = "0x600388A")]
			[Address(RVA = "0x1D3E61C", Offset = "0x1D3E61C", VA = "0x1D3E61C")]
			private static bool DoActuallyNoTraps_IsConsideredTreasure(int type)
			{
				return default(bool);
			}

			// Token: 0x0600388B RID: 14475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600388B")]
			[Address(RVA = "0x1D1B044", Offset = "0x1D1B044", VA = "0x1D1B044")]
			public static void DoActuallyNoTraps()
			{
			}

			// Token: 0x0600388C RID: 14476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600388C")]
			[Address(RVA = "0x1D241E8", Offset = "0x1D241E8", VA = "0x1D241E8")]
			public static void DoRainbowStuff()
			{
			}

			// Token: 0x0600388D RID: 14477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600388D")]
			[Address(RVA = "0x1D3E668", Offset = "0x1D3E668", VA = "0x1D3E668")]
			public static void DoDigExtraHoles()
			{
			}

			// Token: 0x0600388E RID: 14478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600388E")]
			[Address(RVA = "0x1D3EB30", Offset = "0x1D3EB30", VA = "0x1D3EB30")]
			public static void DoRoundLandMasses()
			{
			}

			// Token: 0x0600388F RID: 14479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600388F")]
			[Address(RVA = "0x1D40258", Offset = "0x1D40258", VA = "0x1D40258")]
			public static void DoPooEverywhere()
			{
			}

			// Token: 0x06003890 RID: 14480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003890")]
			[Address(RVA = "0x1D26E1C", Offset = "0x1D26E1C", VA = "0x1D26E1C")]
			public static void DoPortalGunInChests()
			{
			}

			// Token: 0x040044AF RID: 17583
			[Token(Token = "0x40044AF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static List<WorldGen.SecretSeed> AllSecretSeeds;

			// Token: 0x040044B0 RID: 17584
			[Token(Token = "0x40044B0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static WorldGen.SecretSeed paintEverythingGray;

			// Token: 0x040044B1 RID: 17585
			[Token(Token = "0x40044B1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static WorldGen.SecretSeed paintEverythingNegative;

			// Token: 0x040044B2 RID: 17586
			[Token(Token = "0x40044B2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static WorldGen.SecretSeed coatEverythingEcho;

			// Token: 0x040044B3 RID: 17587
			[Token(Token = "0x40044B3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static WorldGen.SecretSeed coatEverythingIlluminant;

			// Token: 0x040044B4 RID: 17588
			[Token(Token = "0x40044B4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static WorldGen.SecretSeed noSurface;

			// Token: 0x040044B5 RID: 17589
			[Token(Token = "0x40044B5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static WorldGen.SecretSeed extraLivingTrees;

			// Token: 0x040044B6 RID: 17590
			[Token(Token = "0x40044B6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static WorldGen.SecretSeed extraFloatingIslands;

			// Token: 0x040044B7 RID: 17591
			[Token(Token = "0x40044B7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static WorldGen.SecretSeed errorWorld;

			// Token: 0x040044B8 RID: 17592
			[Token(Token = "0x40044B8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static WorldGen.SecretSeed graveyardBloodmoonStart;

			// Token: 0x040044B9 RID: 17593
			[Token(Token = "0x40044B9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static WorldGen.SecretSeed surfaceIsInSpace;

			// Token: 0x040044BA RID: 17594
			[Token(Token = "0x40044BA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public static WorldGen.SecretSeed rainsForAYear;

			// Token: 0x040044BB RID: 17595
			[Token(Token = "0x40044BB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static WorldGen.SecretSeed biggerAbandonedHouses;

			// Token: 0x040044BC RID: 17596
			[Token(Token = "0x40044BC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public static WorldGen.SecretSeed randomSpawn;

			// Token: 0x040044BD RID: 17597
			[Token(Token = "0x40044BD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static WorldGen.SecretSeed addTeleporters;

			// Token: 0x040044BE RID: 17598
			[Token(Token = "0x40044BE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public static WorldGen.SecretSeed startInHardmode;

			// Token: 0x040044BF RID: 17599
			[Token(Token = "0x40044BF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static WorldGen.SecretSeed noInfection;

			// Token: 0x040044C0 RID: 17600
			[Token(Token = "0x40044C0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public static WorldGen.SecretSeed hallowOnTheSurface;

			// Token: 0x040044C1 RID: 17601
			[Token(Token = "0x40044C1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static WorldGen.SecretSeed worldIsInfected;

			// Token: 0x040044C2 RID: 17602
			[Token(Token = "0x40044C2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public static WorldGen.SecretSeed surfaceIsMushrooms;

			// Token: 0x040044C3 RID: 17603
			[Token(Token = "0x40044C3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static WorldGen.SecretSeed surfaceIsDesert;

			// Token: 0x040044C4 RID: 17604
			[Token(Token = "0x40044C4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public static WorldGen.SecretSeed pooEverywhere;

			// Token: 0x040044C5 RID: 17605
			[Token(Token = "0x40044C5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static WorldGen.SecretSeed noSpiderCaves;

			// Token: 0x040044C6 RID: 17606
			[Token(Token = "0x40044C6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public static WorldGen.SecretSeed actuallyNoTraps;

			// Token: 0x040044C7 RID: 17607
			[Token(Token = "0x40044C7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static WorldGen.SecretSeed rainbowStuff;

			// Token: 0x040044C8 RID: 17608
			[Token(Token = "0x40044C8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public static WorldGen.SecretSeed digExtraHoles;

			// Token: 0x040044C9 RID: 17609
			[Token(Token = "0x40044C9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static WorldGen.SecretSeed roundLandmasses;

			// Token: 0x040044CA RID: 17610
			[Token(Token = "0x40044CA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public static WorldGen.SecretSeed extraLiquid;

			// Token: 0x040044CB RID: 17611
			[Token(Token = "0x40044CB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static WorldGen.SecretSeed portalGunInChests;

			// Token: 0x040044CC RID: 17612
			[Token(Token = "0x40044CC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public static WorldGen.SecretSeed worldIsFrozen;

			// Token: 0x040044CD RID: 17613
			[Token(Token = "0x40044CD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static WorldGen.SecretSeed halloweenGen;

			// Token: 0x040044CE RID: 17614
			[Token(Token = "0x40044CE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public static WorldGen.SecretSeed endlessHalloween;

			// Token: 0x040044CF RID: 17615
			[Token(Token = "0x40044CF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static WorldGen.SecretSeed endlessChristmas;

			// Token: 0x040044D0 RID: 17616
			[Token(Token = "0x40044D0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public static WorldGen.SecretSeed vampirism;

			// Token: 0x040044D1 RID: 17617
			[Token(Token = "0x40044D1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static WorldGen.SecretSeed teamBasedSpawns;

			// Token: 0x040044D2 RID: 17618
			[Token(Token = "0x40044D2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public static WorldGen.SecretSeed dualDungeons;

			// Token: 0x040044D3 RID: 17619
			[Token(Token = "0x40044D3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static WorldGen.SecretSeed moreLightning;

			// Token: 0x040044D4 RID: 17620
			[Token(Token = "0x40044D4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public static WorldGen.SecretSeed noLightning;

			// Token: 0x040044D5 RID: 17621
			[Token(Token = "0x40044D5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly string Localization;

			// Token: 0x040044D6 RID: 17622
			[Token(Token = "0x40044D6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private readonly string _code;

			// Token: 0x040044D7 RID: 17623
			[Token(Token = "0x40044D7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly LegacySoundStyle _sound;

			// Token: 0x040044D8 RID: 17624
			[Token(Token = "0x40044D8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private string _plaintext;

			// Token: 0x040044D9 RID: 17625
			[Token(Token = "0x40044D9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string TextThatWasUsedToUnlock;

			// Token: 0x040044DA RID: 17626
			[Token(Token = "0x40044DA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static int activeSecretSeedCount;

			// Token: 0x040044DB RID: 17627
			[Token(Token = "0x40044DB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private bool _enabled;

			// Token: 0x0200051A RID: 1306
			[Token(Token = "0x200051A")]
			public static class Variations
			{
				// Token: 0x1700070E RID: 1806
				// (get) Token: 0x06003892 RID: 14482 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
				[Token(Token = "0x1700070E")]
				public static bool paintEverythingGrayJustTheSurface
				{
					[Token(Token = "0x6003892")]
					[Address(RVA = "0x1DDBC44", Offset = "0x1DDBC44", VA = "0x1DDBC44")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700070F RID: 1807
				// (get) Token: 0x06003893 RID: 14483 RVA: 0x0001CC08 File Offset: 0x0001AE08
				[Token(Token = "0x1700070F")]
				public static bool paintEverythingGrayJustTreasure
				{
					[Token(Token = "0x6003893")]
					[Address(RVA = "0x1DDBE08", Offset = "0x1DDBE08", VA = "0x1DDBE08")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000710 RID: 1808
				// (get) Token: 0x06003894 RID: 14484 RVA: 0x0001CC20 File Offset: 0x0001AE20
				[Token(Token = "0x17000710")]
				public static bool paintEverythingGrayUseWhite
				{
					[Token(Token = "0x6003894")]
					[Address(RVA = "0x1DDBEB8", Offset = "0x1DDBEB8", VA = "0x1DDBEB8")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000711 RID: 1809
				// (get) Token: 0x06003895 RID: 14485 RVA: 0x0001CC38 File Offset: 0x0001AE38
				[Token(Token = "0x17000711")]
				public static bool paintEverythingNegativeJustUnderground
				{
					[Token(Token = "0x6003895")]
					[Address(RVA = "0x1DDBF74", Offset = "0x1DDBF74", VA = "0x1DDBF74")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000712 RID: 1810
				// (get) Token: 0x06003896 RID: 14486 RVA: 0x0001CC50 File Offset: 0x0001AE50
				[Token(Token = "0x17000712")]
				public static bool paintEverythingNegativeJustSomeThings
				{
					[Token(Token = "0x6003896")]
					[Address(RVA = "0x1DDC138", Offset = "0x1DDC138", VA = "0x1DDC138")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000713 RID: 1811
				// (get) Token: 0x06003897 RID: 14487 RVA: 0x0001CC68 File Offset: 0x0001AE68
				[Token(Token = "0x17000713")]
				public static bool coatEverythingJustInnerBlocks
				{
					[Token(Token = "0x6003897")]
					[Address(RVA = "0x1DDC1E8", Offset = "0x1DDC1E8", VA = "0x1DDC1E8")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000714 RID: 1812
				// (get) Token: 0x06003898 RID: 14488 RVA: 0x0001CC80 File Offset: 0x0001AE80
				[Token(Token = "0x17000714")]
				public static bool coatEverythingEchoJustSomeThings
				{
					[Token(Token = "0x6003898")]
					[Address(RVA = "0x1DDC3A0", Offset = "0x1DDC3A0", VA = "0x1DDC3A0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000715 RID: 1813
				// (get) Token: 0x06003899 RID: 14489 RVA: 0x0001CC98 File Offset: 0x0001AE98
				[Token(Token = "0x17000715")]
				public static bool coatEverythingIlluminantJustRandomSpots
				{
					[Token(Token = "0x6003899")]
					[Address(RVA = "0x1DDC450", Offset = "0x1DDC450", VA = "0x1DDC450")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000716 RID: 1814
				// (get) Token: 0x0600389A RID: 14490 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
				[Token(Token = "0x17000716")]
				public static bool coatEverythingIlluminantJustSomeThings
				{
					[Token(Token = "0x600389A")]
					[Address(RVA = "0x1DDC4E0", Offset = "0x1DDC4E0", VA = "0x1DDC4E0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000717 RID: 1815
				// (get) Token: 0x0600389B RID: 14491 RVA: 0x0001CCC8 File Offset: 0x0001AEC8
				[Token(Token = "0x17000717")]
				public static bool noSurfaceNoFloatingIslands
				{
					[Token(Token = "0x600389B")]
					[Address(RVA = "0x1DDC60C", Offset = "0x1DDC60C", VA = "0x1DDC60C")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000718 RID: 1816
				// (get) Token: 0x0600389C RID: 14492 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
				[Token(Token = "0x17000718")]
				public static bool noSurfaceNoLivingTrees
				{
					[Token(Token = "0x600389C")]
					[Address(RVA = "0x1DDC708", Offset = "0x1DDC708", VA = "0x1DDC708")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000719 RID: 1817
				// (get) Token: 0x0600389D RID: 14493 RVA: 0x0001CCF8 File Offset: 0x0001AEF8
				[Token(Token = "0x17000719")]
				public static bool noSurfaceNoPyramids
				{
					[Token(Token = "0x600389D")]
					[Address(RVA = "0x1DDC804", Offset = "0x1DDC804", VA = "0x1DDC804")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700071A RID: 1818
				// (get) Token: 0x0600389E RID: 14494 RVA: 0x0001CD10 File Offset: 0x0001AF10
				[Token(Token = "0x1700071A")]
				public static bool noSurfaceNoSwordShrines
				{
					[Token(Token = "0x600389E")]
					[Address(RVA = "0x1DDC8C0", Offset = "0x1DDC8C0", VA = "0x1DDC8C0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700071B RID: 1819
				// (get) Token: 0x0600389F RID: 14495 RVA: 0x0001CD28 File Offset: 0x0001AF28
				[Token(Token = "0x1700071B")]
				public static bool extraLivingTreesReducedAmount
				{
					[Token(Token = "0x600389F")]
					[Address(RVA = "0x1DDC97C", Offset = "0x1DDC97C", VA = "0x1DDC97C")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700071C RID: 1820
				// (get) Token: 0x060038A0 RID: 14496 RVA: 0x0001CD40 File Offset: 0x0001AF40
				[Token(Token = "0x1700071C")]
				public static bool extraFloatingIslandsNormalAmount
				{
					[Token(Token = "0x60038A0")]
					[Address(RVA = "0x1DDCA68", Offset = "0x1DDCA68", VA = "0x1DDCA68")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700071D RID: 1821
				// (get) Token: 0x060038A1 RID: 14497 RVA: 0x0001CD58 File Offset: 0x0001AF58
				[Token(Token = "0x1700071D")]
				public static bool extraFloatingIslandsReducedAmount
				{
					[Token(Token = "0x60038A1")]
					[Address(RVA = "0x1DDCB30", Offset = "0x1DDCB30", VA = "0x1DDCB30")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x1700071E RID: 1822
				// (get) Token: 0x060038A2 RID: 14498 RVA: 0x0001CD70 File Offset: 0x0001AF70
				[Token(Token = "0x1700071E")]
				public static bool errorWorldBalancedChests
				{
					[Token(Token = "0x60038A2")]
					[Address(RVA = "0x1DDCC10", Offset = "0x1DDCC10", VA = "0x1DDCC10")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x060038A3 RID: 14499 RVA: 0x0001CD88 File Offset: 0x0001AF88
				[Token(Token = "0x60038A3")]
				[Address(RVA = "0x1DDCCC0", Offset = "0x1DDCCC0", VA = "0x1DDCCC0")]
				public static int errorWorldAdjustment(double value)
				{
					return 0;
				}

				// Token: 0x1700071F RID: 1823
				// (get) Token: 0x060038A4 RID: 14500 RVA: 0x0001CDA0 File Offset: 0x0001AFA0
				[Token(Token = "0x1700071F")]
				public static bool noSpiderCavesActuallyNoSpiderCaves
				{
					[Token(Token = "0x60038A4")]
					[Address(RVA = "0x1DDCDA4", Offset = "0x1DDCDA4", VA = "0x1DDCDA4")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000720 RID: 1824
				// (get) Token: 0x060038A5 RID: 14501 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
				[Token(Token = "0x17000720")]
				public static bool noSpiderCavesILiedMoreSpiderCaves
				{
					[Token(Token = "0x60038A5")]
					[Address(RVA = "0x1DDCE54", Offset = "0x1DDCE54", VA = "0x1DDCE54")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000721 RID: 1825
				// (get) Token: 0x060038A6 RID: 14502 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
				[Token(Token = "0x17000721")]
				public static bool actuallyNoTrapsForRealIMeanIt
				{
					[Token(Token = "0x60038A6")]
					[Address(RVA = "0x1DDCF04", Offset = "0x1DDCF04", VA = "0x1DDCF04")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000722 RID: 1826
				// (get) Token: 0x060038A7 RID: 14503 RVA: 0x0001CDE8 File Offset: 0x0001AFE8
				[Token(Token = "0x17000722")]
				public static bool surfaceIsDesertNormalFunction
				{
					[Token(Token = "0x60038A7")]
					[Address(RVA = "0x1DDCFB4", Offset = "0x1DDCFB4", VA = "0x1DDCFB4")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000723 RID: 1827
				// (get) Token: 0x060038A8 RID: 14504 RVA: 0x0001CE00 File Offset: 0x0001B000
				[Token(Token = "0x17000723")]
				public static bool surfaceIsDesertSwapDesertAndSnowBiomes
				{
					[Token(Token = "0x60038A8")]
					[Address(RVA = "0x1DDD040", Offset = "0x1DDD040", VA = "0x1DDD040")]
					get
					{
						return default(bool);
					}
				}
			}

			// Token: 0x0200051B RID: 1307
			[Token(Token = "0x200051B")]
			private sealed class <>c__DisplayClass54_0
			{
				// Token: 0x060038A9 RID: 14505 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60038A9")]
				[Address(RVA = "0x1DDD0FC", Offset = "0x1DDD0FC", VA = "0x1DDD0FC")]
				public <>c__DisplayClass54_0()
				{
				}

				// Token: 0x060038AA RID: 14506 RVA: 0x0001CE18 File Offset: 0x0001B018
				[Token(Token = "0x60038AA")]
				[Address(RVA = "0x1DDD104", Offset = "0x1DDD104", VA = "0x1DDD104")]
				internal bool <CheckInputForSecretSeed>b__0(WorldGen.SecretSeed s)
				{
					return default(bool);
				}

				// Token: 0x040044DC RID: 17628
				[Token(Token = "0x40044DC")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string worldSeed;
			}

			// Token: 0x0200051C RID: 1308
			[Token(Token = "0x200051C")]
			private sealed class <>c__DisplayClass54_1
			{
				// Token: 0x060038AB RID: 14507 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60038AB")]
				[Address(RVA = "0x1DDD130", Offset = "0x1DDD130", VA = "0x1DDD130")]
				public <>c__DisplayClass54_1()
				{
				}

				// Token: 0x060038AC RID: 14508 RVA: 0x0001CE30 File Offset: 0x0001B030
				[Token(Token = "0x60038AC")]
				[Address(RVA = "0x1DDD138", Offset = "0x1DDD138", VA = "0x1DDD138")]
				internal bool <CheckInputForSecretSeed>b__1(WorldGen.SecretSeed s)
				{
					return default(bool);
				}

				// Token: 0x040044DD RID: 17629
				[Token(Token = "0x40044DD")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string code;
			}
		}

		// Token: 0x0200051D RID: 1309
		[Token(Token = "0x200051D")]
		public static class Skyblock
		{
			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x060038AD RID: 14509 RVA: 0x0001CE48 File Offset: 0x0001B048
			[Token(Token = "0x17000724")]
			public static bool denyFloatingIslands
			{
				[Token(Token = "0x60038AD")]
				[Address(RVA = "0x1DDD164", Offset = "0x1DDD164", VA = "0x1DDD164")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x060038AE RID: 14510 RVA: 0x0001CE60 File Offset: 0x0001B060
			[Token(Token = "0x17000725")]
			public static bool spawnSolidifier
			{
				[Token(Token = "0x60038AE")]
				[Address(RVA = "0x1DDD22C", Offset = "0x1DDD22C", VA = "0x1DDD22C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x060038AF RID: 14511 RVA: 0x0001CE78 File Offset: 0x0001B078
			[Token(Token = "0x17000726")]
			public static bool spawnShimmerPool
			{
				[Token(Token = "0x60038AF")]
				[Address(RVA = "0x1DDD2FC", Offset = "0x1DDD2FC", VA = "0x1DDD2FC")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x060038B0 RID: 14512 RVA: 0x0001CE90 File Offset: 0x0001B090
			[Token(Token = "0x17000727")]
			public static bool denyAllGeneration
			{
				[Token(Token = "0x60038B0")]
				[Address(RVA = "0x1DDD3CC", Offset = "0x1DDD3CC", VA = "0x1DDD3CC")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x060038B1 RID: 14513 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
			[Token(Token = "0x17000728")]
			public static bool denySomeGeneration
			{
				[Token(Token = "0x60038B1")]
				[Address(RVA = "0x1DDD430", Offset = "0x1DDD430", VA = "0x1DDD430")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060038B2 RID: 14514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038B2")]
			[Address(RVA = "0x1DDD6B8", Offset = "0x1DDD6B8", VA = "0x1DDD6B8")]
			public static void Calculate()
			{
			}

			// Token: 0x060038B3 RID: 14515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038B3")]
			[Address(RVA = "0x1DDDC84", Offset = "0x1DDDC84", VA = "0x1DDDC84")]
			public static void ScanTiles()
			{
			}

			// Token: 0x040044DE RID: 17630
			[Token(Token = "0x40044DE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static bool noAltars;

			// Token: 0x040044DF RID: 17631
			[Token(Token = "0x40044DF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public static bool noDungeon;

			// Token: 0x040044E0 RID: 17632
			[Token(Token = "0x40044E0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public static bool noTemple;

			// Token: 0x040044E1 RID: 17633
			[Token(Token = "0x40044E1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public static bool noHellstone;

			// Token: 0x040044E2 RID: 17634
			[Token(Token = "0x40044E2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static bool noFossils;

			// Token: 0x040044E3 RID: 17635
			[Token(Token = "0x40044E3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public static bool noLifeCrystals;

			// Token: 0x040044E4 RID: 17636
			[Token(Token = "0x40044E4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public static bool noHellforge;

			// Token: 0x040044E5 RID: 17637
			[Token(Token = "0x40044E5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public static bool lowTiles;

			// Token: 0x040044E6 RID: 17638
			[Token(Token = "0x40044E6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static bool[] hasTile;

			// Token: 0x040044E7 RID: 17639
			[Token(Token = "0x40044E7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static bool[] hasWall;

			// Token: 0x040044E8 RID: 17640
			[Token(Token = "0x40044E8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static int currentActiveTiles;
		}

		// Token: 0x0200051E RID: 1310
		[Token(Token = "0x200051E")]
		public static class SavedOreTiers
		{
			// Token: 0x040044E9 RID: 17641
			[Token(Token = "0x40044E9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int Copper;

			// Token: 0x040044EA RID: 17642
			[Token(Token = "0x40044EA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static int Iron;

			// Token: 0x040044EB RID: 17643
			[Token(Token = "0x40044EB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static int Silver;

			// Token: 0x040044EC RID: 17644
			[Token(Token = "0x40044EC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static int Gold;

			// Token: 0x040044ED RID: 17645
			[Token(Token = "0x40044ED")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static int Cobalt;

			// Token: 0x040044EE RID: 17646
			[Token(Token = "0x40044EE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static int Mythril;

			// Token: 0x040044EF RID: 17647
			[Token(Token = "0x40044EF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static int Adamantite;
		}

		// Token: 0x0200051F RID: 1311
		[Token(Token = "0x200051F")]
		public static class Hooks
		{
			// Token: 0x1400002D RID: 45
			// (add) Token: 0x060038B6 RID: 14518 RVA: 0x00002053 File Offset: 0x00000253
			// (remove) Token: 0x060038B7 RID: 14519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1400002D")]
			public static event WorldGen.Hooks.WorldGenConfigProcessEvent OnWorldGenConfigProcess
			{
				[Token(Token = "0x60038B6")]
				[Address(RVA = "0x1DDE13C", Offset = "0x1DDE13C", VA = "0x1DDE13C")]
				add
				{
				}
				[Token(Token = "0x60038B7")]
				[Address(RVA = "0x1DDE208", Offset = "0x1DDE208", VA = "0x1DDE208")]
				remove
				{
				}
			}

			// Token: 0x1400002E RID: 46
			// (add) Token: 0x060038B8 RID: 14520 RVA: 0x00002053 File Offset: 0x00000253
			// (remove) Token: 0x060038B9 RID: 14521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1400002E")]
			public static event Action OnWorldLoad
			{
				[Token(Token = "0x60038B8")]
				[Address(RVA = "0x1DDE2D4", Offset = "0x1DDE2D4", VA = "0x1DDE2D4")]
				add
				{
				}
				[Token(Token = "0x60038B9")]
				[Address(RVA = "0x1DDE3AC", Offset = "0x1DDE3AC", VA = "0x1DDE3AC")]
				remove
				{
				}
			}

			// Token: 0x060038BA RID: 14522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038BA")]
			[Address(RVA = "0x1DDE484", Offset = "0x1DDE484", VA = "0x1DDE484")]
			public static void Initialize()
			{
			}

			// Token: 0x060038BB RID: 14523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038BB")]
			[Address(RVA = "0x1DDE6D0", Offset = "0x1DDE6D0", VA = "0x1DDE6D0")]
			public static void WorldLoaded()
			{
			}

			// Token: 0x060038BC RID: 14524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038BC")]
			[Address(RVA = "0x1DDE738", Offset = "0x1DDE738", VA = "0x1DDE738")]
			public static void ProcessWorldGenConfig(ref WorldGenConfiguration config)
			{
			}

			// Token: 0x02000520 RID: 1312
			// (Invoke) Token: 0x060038BE RID: 14526
			[Token(Token = "0x2000520")]
			public delegate void WorldGenConfigProcessEvent(ref WorldGenConfiguration config);

			// Token: 0x02000521 RID: 1313
			[Token(Token = "0x2000521")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060038C2 RID: 14530 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60038C2")]
				[Address(RVA = "0x1DDE968", Offset = "0x1DDE968", VA = "0x1DDE968")]
				public <>c()
				{
				}

				// Token: 0x060038C3 RID: 14531 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60038C3")]
				[Address(RVA = "0x1DDE970", Offset = "0x1DDE970", VA = "0x1DDE970")]
				internal void <Initialize>b__7_0(Player player)
				{
				}

				// Token: 0x040044F2 RID: 17650
				[Token(Token = "0x40044F2")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly WorldGen.Hooks.<>c <>9;

				// Token: 0x040044F3 RID: 17651
				[Token(Token = "0x40044F3")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public static Action<Player> <>9__7_0;
			}
		}

		// Token: 0x02000522 RID: 1314
		[Token(Token = "0x2000522")]
		public static class Spread
		{
			// Token: 0x060038C4 RID: 14532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038C4")]
			[Address(RVA = "0x1DDEA90", Offset = "0x1DDEA90", VA = "0x1DDEA90")]
			public static void Wall(int x, int y, int wallType)
			{
			}

			// Token: 0x060038C5 RID: 14533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038C5")]
			[Address(RVA = "0x1DDFFB0", Offset = "0x1DDFFB0", VA = "0x1DDFFB0")]
			public static void Wall2(int x, int y, int wallType)
			{
			}

			// Token: 0x060038C6 RID: 14534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038C6")]
			[Address(RVA = "0x1DE2784", Offset = "0x1DE2784", VA = "0x1DE2784")]
			public static void Moss(int x, int y)
			{
			}

			// Token: 0x060038C7 RID: 14535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038C7")]
			[Address(RVA = "0x1DE3528", Offset = "0x1DE3528", VA = "0x1DE3528")]
			public static void Gem(int x, int y)
			{
			}

			// Token: 0x060038C8 RID: 14536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038C8")]
			[Address(RVA = "0x1DE4E3C", Offset = "0x1DE4E3C", VA = "0x1DE4E3C")]
			public static void Spider(int x, int y)
			{
			}

			// Token: 0x060038C9 RID: 14537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038C9")]
			[Address(RVA = "0x1DE68A0", Offset = "0x1DE68A0", VA = "0x1DE68A0")]
			public static void WallDungeon(int x, int y, int wallType)
			{
			}

			// Token: 0x060038CA RID: 14538 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
			[Token(Token = "0x60038CA")]
			[Address(RVA = "0x1DE4DEC", Offset = "0x1DE4DEC", VA = "0x1DE4DEC")]
			private static bool Gemmable(int type)
			{
				return default(bool);
			}
		}

		// Token: 0x02000523 RID: 1315
		[Token(Token = "0x2000523")]
		public class nextCountNode
		{
			// Token: 0x060038CB RID: 14539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038CB")]
			[Address(RVA = "0x1DDFF98", Offset = "0x1DDFF98", VA = "0x1DDFF98")]
			public void Setup(int x, int y, bool jungle, bool lavaOk)
			{
			}

			// Token: 0x060038CC RID: 14540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038CC")]
			[Address(RVA = "0x1DDFF90", Offset = "0x1DDFF90", VA = "0x1DDFF90")]
			public nextCountNode()
			{
			}

			// Token: 0x040044F4 RID: 17652
			[Token(Token = "0x40044F4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int x;

			// Token: 0x040044F5 RID: 17653
			[Token(Token = "0x40044F5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int y;

			// Token: 0x040044F6 RID: 17654
			[Token(Token = "0x40044F6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool jungle;

			// Token: 0x040044F7 RID: 17655
			[Token(Token = "0x40044F7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool lavaOk;
		}

		// Token: 0x02000524 RID: 1316
		[Token(Token = "0x2000524")]
		internal class nextCountDirtNode
		{
			// Token: 0x060038CD RID: 14541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038CD")]
			[Address(RVA = "0x1DE7540", Offset = "0x1DE7540", VA = "0x1DE7540")]
			public void Setup(int x, int y)
			{
			}

			// Token: 0x060038CE RID: 14542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038CE")]
			[Address(RVA = "0x1DE754C", Offset = "0x1DE754C", VA = "0x1DE754C")]
			public nextCountDirtNode()
			{
			}

			// Token: 0x040044F8 RID: 17656
			[Token(Token = "0x40044F8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int x;

			// Token: 0x040044F9 RID: 17657
			[Token(Token = "0x40044F9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int y;
		}

		// Token: 0x02000525 RID: 1317
		[Token(Token = "0x2000525")]
		public static class TenthAnniversaryWorldInfo
		{
			// Token: 0x040044FA RID: 17658
			[Token(Token = "0x40044FA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int[] GoodPrefixIdsForAccessory;

			// Token: 0x040044FB RID: 17659
			[Token(Token = "0x40044FB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static int[] GoodPrefixIdsForMeleeWeapon;

			// Token: 0x040044FC RID: 17660
			[Token(Token = "0x40044FC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static int[] GoodPrefixIdsForRangedWeapon;

			// Token: 0x040044FD RID: 17661
			[Token(Token = "0x40044FD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static int[] GoodPrefixIdsForMagicWeapon;

			// Token: 0x040044FE RID: 17662
			[Token(Token = "0x40044FE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static int[] GoodPrefixIdsForSummonerWeapon;
		}

		// Token: 0x02000526 RID: 1318
		[Token(Token = "0x2000526")]
		public struct GrowTreeSettings
		{
			// Token: 0x040044FF RID: 17663
			[Token(Token = "0x40044FF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ushort TreeTileType;

			// Token: 0x04004500 RID: 17664
			[Token(Token = "0x4004500")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int TreeHeightMin;

			// Token: 0x04004501 RID: 17665
			[Token(Token = "0x4004501")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int TreeHeightMax;

			// Token: 0x04004502 RID: 17666
			[Token(Token = "0x4004502")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int TreeTopPaddingNeeded;

			// Token: 0x04004503 RID: 17667
			[Token(Token = "0x4004503")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WorldGen.GrowTreeSettings.IsTileFitForTreeGroundTest GroundTest;

			// Token: 0x04004504 RID: 17668
			[Token(Token = "0x4004504")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public WorldGen.GrowTreeSettings.IsWallTypeFitForTreeBack WallTest;

			// Token: 0x04004505 RID: 17669
			[Token(Token = "0x4004505")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ushort SaplingTileType;

			// Token: 0x02000527 RID: 1319
			// (Invoke) Token: 0x060038D1 RID: 14545
			[Token(Token = "0x2000527")]
			public delegate bool IsTileFitForTreeGroundTest(int tileType);

			// Token: 0x02000528 RID: 1320
			// (Invoke) Token: 0x060038D5 RID: 14549
			[Token(Token = "0x2000528")]
			public delegate bool IsWallTypeFitForTreeBack(int wallType);

			// Token: 0x02000529 RID: 1321
			[Token(Token = "0x2000529")]
			public static class Profiles
			{
				// Token: 0x060038D8 RID: 14552 RVA: 0x0001CED8 File Offset: 0x0001B0D8
				[Token(Token = "0x60038D8")]
				[Address(RVA = "0x1DE7A6C", Offset = "0x1DE7A6C", VA = "0x1DE7A6C")]
				public static bool TryGetFromItemId(int itemType, out WorldGen.GrowTreeSettings profile)
				{
					return default(bool);
				}

				// Token: 0x060038D9 RID: 14553 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
				[Token(Token = "0x60038D9")]
				[Address(RVA = "0x1DE7E04", Offset = "0x1DE7E04", VA = "0x1DE7E04")]
				public static bool TryGetFromTreeId(int tileType, out WorldGen.GrowTreeSettings profile)
				{
					return default(bool);
				}

				// Token: 0x04004506 RID: 17670
				[Token(Token = "0x4004506")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static WorldGen.GrowTreeSettings GemTree_Ruby;

				// Token: 0x04004507 RID: 17671
				[Token(Token = "0x4004507")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public static WorldGen.GrowTreeSettings GemTree_Diamond;

				// Token: 0x04004508 RID: 17672
				[Token(Token = "0x4004508")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public static WorldGen.GrowTreeSettings GemTree_Topaz;

				// Token: 0x04004509 RID: 17673
				[Token(Token = "0x4004509")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
				public static WorldGen.GrowTreeSettings GemTree_Amethyst;

				// Token: 0x0400450A RID: 17674
				[Token(Token = "0x400450A")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public static WorldGen.GrowTreeSettings GemTree_Sapphire;

				// Token: 0x0400450B RID: 17675
				[Token(Token = "0x400450B")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
				public static WorldGen.GrowTreeSettings GemTree_Emerald;

				// Token: 0x0400450C RID: 17676
				[Token(Token = "0x400450C")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				public static WorldGen.GrowTreeSettings GemTree_Amber;

				// Token: 0x0400450D RID: 17677
				[Token(Token = "0x400450D")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
				public static WorldGen.GrowTreeSettings VanityTree_Sakura;

				// Token: 0x0400450E RID: 17678
				[Token(Token = "0x400450E")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
				public static WorldGen.GrowTreeSettings VanityTree_Willow;

				// Token: 0x0400450F RID: 17679
				[Token(Token = "0x400450F")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
				public static WorldGen.GrowTreeSettings Tree_Ash;
			}
		}

		// Token: 0x0200052A RID: 1322
		[Token(Token = "0x200052A")]
		private struct QueuedAction
		{
			// Token: 0x04004510 RID: 17680
			[Token(Token = "0x4004510")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WaitCallback callBack;

			// Token: 0x04004511 RID: 17681
			[Token(Token = "0x4004511")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public object state;
		}

		// Token: 0x0200052B RID: 1323
		[Token(Token = "0x200052B")]
		public struct CheckTreeSettings
		{
			// Token: 0x04004512 RID: 17682
			[Token(Token = "0x4004512")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WorldGen.CheckTreeSettings.GroundValidTest IsGroundValid;

			// Token: 0x0200052C RID: 1324
			// (Invoke) Token: 0x060038DC RID: 14556
			[Token(Token = "0x200052C")]
			public delegate bool GroundValidTest(int groundTileType);
		}

		// Token: 0x0200052D RID: 1325
		[Token(Token = "0x200052D")]
		public enum SpecialKillTileContext
		{
			// Token: 0x04004514 RID: 17684
			[Token(Token = "0x4004514")]
			None,
			// Token: 0x04004515 RID: 17685
			[Token(Token = "0x4004515")]
			MowingTheGrass
		}

		// Token: 0x0200052E RID: 1326
		// (Invoke) Token: 0x060038E0 RID: 14560
		[Token(Token = "0x200052E")]
		public delegate bool GetTreeFoliageDataMethod(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight);

		// Token: 0x0200052F RID: 1327
		[Token(Token = "0x200052F")]
		public struct TileMergeCullCache
		{
			// Token: 0x060038E3 RID: 14563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038E3")]
			[Address(RVA = "0x1DE8C9C", Offset = "0x1DE8C9C", VA = "0x1DE8C9C")]
			public void Cull(ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
			{
			}

			// Token: 0x04004516 RID: 17686
			[Token(Token = "0x4004516")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool CullTop;

			// Token: 0x04004517 RID: 17687
			[Token(Token = "0x4004517")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool CullBottom;

			// Token: 0x04004518 RID: 17688
			[Token(Token = "0x4004518")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool CullLeft;

			// Token: 0x04004519 RID: 17689
			[Token(Token = "0x4004519")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public bool CullRight;

			// Token: 0x0400451A RID: 17690
			[Token(Token = "0x400451A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool CullTopLeft;

			// Token: 0x0400451B RID: 17691
			[Token(Token = "0x400451B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool CullTopRight;

			// Token: 0x0400451C RID: 17692
			[Token(Token = "0x400451C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool CullBottomLeft;

			// Token: 0x0400451D RID: 17693
			[Token(Token = "0x400451D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool CullBottomRight;
		}

		// Token: 0x02000530 RID: 1328
		[Token(Token = "0x2000530")]
		private sealed class <>c__DisplayClass181_0
		{
			// Token: 0x060038E4 RID: 14564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038E4")]
			[Address(RVA = "0x1DE8D34", Offset = "0x1DE8D34", VA = "0x1DE8D34")]
			public <>c__DisplayClass181_0()
			{
			}

			// Token: 0x060038E5 RID: 14565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038E5")]
			[Address(RVA = "0x1DE8D3C", Offset = "0x1DE8D3C", VA = "0x1DE8D3C")]
			internal void <WaitForFileSync>b__0(object data)
			{
			}

			// Token: 0x0400451E RID: 17694
			[Token(Token = "0x400451E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool stringSet;
		}

		// Token: 0x02000531 RID: 1329
		[Token(Token = "0x2000531")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060038E7 RID: 14567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038E7")]
			[Address(RVA = "0x1D41A54", Offset = "0x1D41A54", VA = "0x1D41A54")]
			public <>c()
			{
			}

			// Token: 0x060038E8 RID: 14568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038E8")]
			[Address(RVA = "0x1D41A5C", Offset = "0x1D41A5C", VA = "0x1D41A5C")]
			internal void <WaitForFileSync>b__181_1(object data)
			{
			}

			// Token: 0x060038E9 RID: 14569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038E9")]
			[Address(RVA = "0x1D41B3C", Offset = "0x1D41B3C", VA = "0x1D41B3C")]
			internal void <RenameWorldCallBack>b__187_0()
			{
			}

			// Token: 0x060038EA RID: 14570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038EA")]
			[Address(RVA = "0x1D41BA8", Offset = "0x1D41BA8", VA = "0x1D41BA8")]
			internal void <AddPasses>b__309_0(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038EB RID: 14571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038EB")]
			[Address(RVA = "0x1D41C88", Offset = "0x1D41C88", VA = "0x1D41C88")]
			internal void <AddPasses>b__309_1(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038EC RID: 14572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038EC")]
			[Address(RVA = "0x1D42940", Offset = "0x1D42940", VA = "0x1D42940")]
			internal void <AddPasses>b__309_2(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038ED RID: 14573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038ED")]
			[Address(RVA = "0x1D43860", Offset = "0x1D43860", VA = "0x1D43860")]
			internal void <AddPasses>b__309_3(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038EE RID: 14574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038EE")]
			[Address(RVA = "0x1D44000", Offset = "0x1D44000", VA = "0x1D44000")]
			internal void <AddPasses>b__309_4(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038EF RID: 14575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038EF")]
			[Address(RVA = "0x1D44DC8", Offset = "0x1D44DC8", VA = "0x1D44DC8")]
			internal void <AddPasses>b__309_5(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F0 RID: 14576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F0")]
			[Address(RVA = "0x1D45B38", Offset = "0x1D45B38", VA = "0x1D45B38")]
			internal void <AddPasses>b__309_6(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F1 RID: 14577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F1")]
			[Address(RVA = "0x1D465A8", Offset = "0x1D465A8", VA = "0x1D465A8")]
			internal void <AddPasses>b__309_7(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F2 RID: 14578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F2")]
			[Address(RVA = "0x1D471F8", Offset = "0x1D471F8", VA = "0x1D471F8")]
			internal void <AddPasses>b__309_8(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F3 RID: 14579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F3")]
			[Address(RVA = "0x1D47AB8", Offset = "0x1D47AB8", VA = "0x1D47AB8")]
			internal void <AddPasses>b__309_9(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F4 RID: 14580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F4")]
			[Address(RVA = "0x1D48AF8", Offset = "0x1D48AF8", VA = "0x1D48AF8")]
			internal void <AddPasses>b__309_10(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F5 RID: 14581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F5")]
			[Address(RVA = "0x1D49A30", Offset = "0x1D49A30", VA = "0x1D49A30")]
			internal void <AddPasses>b__309_11(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F6 RID: 14582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F6")]
			[Address(RVA = "0x1D4A2B8", Offset = "0x1D4A2B8", VA = "0x1D4A2B8")]
			internal void <AddPasses>b__309_12(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F7 RID: 14583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F7")]
			[Address(RVA = "0x1D4AEA0", Offset = "0x1D4AEA0", VA = "0x1D4AEA0")]
			internal void <AddPasses>b__309_13(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F8 RID: 14584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F8")]
			[Address(RVA = "0x1D4CB50", Offset = "0x1D4CB50", VA = "0x1D4CB50")]
			internal void <AddPasses>b__309_14(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038F9 RID: 14585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F9")]
			[Address(RVA = "0x1D4D1F8", Offset = "0x1D4D1F8", VA = "0x1D4D1F8")]
			internal void <AddPasses>b__309_15(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038FA RID: 14586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038FA")]
			[Address(RVA = "0x1D4E670", Offset = "0x1D4E670", VA = "0x1D4E670")]
			internal void <AddPasses>b__309_16(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038FB RID: 14587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038FB")]
			[Address(RVA = "0x1D4FC38", Offset = "0x1D4FC38", VA = "0x1D4FC38")]
			internal void <AddPasses>b__309_17(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038FC RID: 14588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038FC")]
			[Address(RVA = "0x1D501B0", Offset = "0x1D501B0", VA = "0x1D501B0")]
			internal void <AddPasses>b__309_18(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038FD RID: 14589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038FD")]
			[Address(RVA = "0x1D50F70", Offset = "0x1D50F70", VA = "0x1D50F70")]
			internal void <AddPasses>b__309_19(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038FE RID: 14590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038FE")]
			[Address(RVA = "0x1D541D8", Offset = "0x1D541D8", VA = "0x1D541D8")]
			internal void <AddPasses>b__309_20(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x060038FF RID: 14591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038FF")]
			[Address(RVA = "0x1D54D60", Offset = "0x1D54D60", VA = "0x1D54D60")]
			internal void <AddPasses>b__309_21(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003900 RID: 14592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003900")]
			[Address(RVA = "0x1D55AE0", Offset = "0x1D55AE0", VA = "0x1D55AE0")]
			internal void <AddPasses>b__309_22(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003901 RID: 14593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003901")]
			[Address(RVA = "0x1D57210", Offset = "0x1D57210", VA = "0x1D57210")]
			internal void <AddPasses>b__309_23(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003902 RID: 14594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003902")]
			[Address(RVA = "0x1D57760", Offset = "0x1D57760", VA = "0x1D57760")]
			internal void <AddPasses>b__309_24(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003903 RID: 14595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003903")]
			[Address(RVA = "0x1D584D0", Offset = "0x1D584D0", VA = "0x1D584D0")]
			internal void <AddPasses>b__309_25(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003904 RID: 14596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003904")]
			[Address(RVA = "0x1D5F070", Offset = "0x1D5F070", VA = "0x1D5F070")]
			internal void <AddPasses>b__309_26(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003905 RID: 14597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003905")]
			[Address(RVA = "0x1D5FBE0", Offset = "0x1D5FBE0", VA = "0x1D5FBE0")]
			internal void <AddPasses>b__309_27(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003906 RID: 14598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003906")]
			[Address(RVA = "0x1D65880", Offset = "0x1D65880", VA = "0x1D65880")]
			internal void <AddPasses>b__309_28(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003907 RID: 14599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003907")]
			[Address(RVA = "0x1D6D668", Offset = "0x1D6D668", VA = "0x1D6D668")]
			internal void <AddPasses>b__309_29(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003908 RID: 14600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003908")]
			[Address(RVA = "0x1D6EAF4", Offset = "0x1D6EAF4", VA = "0x1D6EAF4")]
			internal void <AddPasses>b__309_30(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003909 RID: 14601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003909")]
			[Address(RVA = "0x1D6F3E8", Offset = "0x1D6F3E8", VA = "0x1D6F3E8")]
			internal void <AddPasses>b__309_31(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600390A RID: 14602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600390A")]
			[Address(RVA = "0x1D6FEEC", Offset = "0x1D6FEEC", VA = "0x1D6FEEC")]
			internal void <AddPasses>b__309_32(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600390B RID: 14603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600390B")]
			[Address(RVA = "0x1D701EC", Offset = "0x1D701EC", VA = "0x1D701EC")]
			internal void <AddPasses>b__309_33(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600390C RID: 14604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600390C")]
			[Address(RVA = "0x1D71910", Offset = "0x1D71910", VA = "0x1D71910")]
			internal void <AddPasses>b__309_34(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600390D RID: 14605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600390D")]
			[Address(RVA = "0x1D72BB0", Offset = "0x1D72BB0", VA = "0x1D72BB0")]
			internal void <AddPasses>b__309_35(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600390E RID: 14606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600390E")]
			[Address(RVA = "0x1D73108", Offset = "0x1D73108", VA = "0x1D73108")]
			internal void <AddPasses>b__309_36(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600390F RID: 14607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600390F")]
			[Address(RVA = "0x1D73820", Offset = "0x1D73820", VA = "0x1D73820")]
			internal void <AddPasses>b__309_37(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003910 RID: 14608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003910")]
			[Address(RVA = "0x1D74474", Offset = "0x1D74474", VA = "0x1D74474")]
			internal void <AddPasses>b__309_38(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003911 RID: 14609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003911")]
			[Address(RVA = "0x1D78068", Offset = "0x1D78068", VA = "0x1D78068")]
			internal void <AddPasses>b__309_39(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003912 RID: 14610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003912")]
			[Address(RVA = "0x1D79568", Offset = "0x1D79568", VA = "0x1D79568")]
			internal void <AddPasses>b__309_40(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003913 RID: 14611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003913")]
			[Address(RVA = "0x1D798C0", Offset = "0x1D798C0", VA = "0x1D798C0")]
			internal void <AddPasses>b__309_41(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003914 RID: 14612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003914")]
			[Address(RVA = "0x1D7B848", Offset = "0x1D7B848", VA = "0x1D7B848")]
			internal void <AddPasses>b__309_42(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003915 RID: 14613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003915")]
			[Address(RVA = "0x1D7C318", Offset = "0x1D7C318", VA = "0x1D7C318")]
			internal void <AddPasses>b__309_43(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003916 RID: 14614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003916")]
			[Address(RVA = "0x1D7CE40", Offset = "0x1D7CE40", VA = "0x1D7CE40")]
			internal void <AddPasses>b__309_44(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003917 RID: 14615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003917")]
			[Address(RVA = "0x1D7D390", Offset = "0x1D7D390", VA = "0x1D7D390")]
			internal void <AddPasses>b__309_45(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003918 RID: 14616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003918")]
			[Address(RVA = "0x1D7E840", Offset = "0x1D7E840", VA = "0x1D7E840")]
			internal void <AddPasses>b__309_46(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003919 RID: 14617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003919")]
			[Address(RVA = "0x1D7F128", Offset = "0x1D7F128", VA = "0x1D7F128")]
			internal void <AddPasses>b__309_47(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600391A RID: 14618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600391A")]
			[Address(RVA = "0x1D812E0", Offset = "0x1D812E0", VA = "0x1D812E0")]
			internal void <AddPasses>b__309_48(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600391B RID: 14619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600391B")]
			[Address(RVA = "0x1D81A14", Offset = "0x1D81A14", VA = "0x1D81A14")]
			internal void <AddPasses>b__309_49(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600391C RID: 14620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600391C")]
			[Address(RVA = "0x1D81F60", Offset = "0x1D81F60", VA = "0x1D81F60")]
			internal void <AddPasses>b__309_50(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600391D RID: 14621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600391D")]
			[Address(RVA = "0x1D824B0", Offset = "0x1D824B0", VA = "0x1D824B0")]
			internal void <AddPasses>b__309_51(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600391E RID: 14622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600391E")]
			[Address(RVA = "0x1D850BC", Offset = "0x1D850BC", VA = "0x1D850BC")]
			internal void <AddPasses>b__309_52(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600391F RID: 14623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600391F")]
			[Address(RVA = "0x1D8AA90", Offset = "0x1D8AA90", VA = "0x1D8AA90")]
			internal void <AddPasses>b__309_53(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003920 RID: 14624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003920")]
			[Address(RVA = "0x1D8BE88", Offset = "0x1D8BE88", VA = "0x1D8BE88")]
			internal void <AddPasses>b__309_54(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003921 RID: 14625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003921")]
			[Address(RVA = "0x1D8C318", Offset = "0x1D8C318", VA = "0x1D8C318")]
			internal void <AddPasses>b__309_55(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003922 RID: 14626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003922")]
			[Address(RVA = "0x1D8DAD0", Offset = "0x1D8DAD0", VA = "0x1D8DAD0")]
			internal void <AddPasses>b__309_56(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003923 RID: 14627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003923")]
			[Address(RVA = "0x1D8E5B8", Offset = "0x1D8E5B8", VA = "0x1D8E5B8")]
			internal void <AddPasses>b__309_57(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003924 RID: 14628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003924")]
			[Address(RVA = "0x1D8F568", Offset = "0x1D8F568", VA = "0x1D8F568")]
			internal void <AddPasses>b__309_58(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003925 RID: 14629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003925")]
			[Address(RVA = "0x1D90E38", Offset = "0x1D90E38", VA = "0x1D90E38")]
			internal void <AddPasses>b__309_59(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003926 RID: 14630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003926")]
			[Address(RVA = "0x1D91CDC", Offset = "0x1D91CDC", VA = "0x1D91CDC")]
			internal void <AddPasses>b__309_60(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003927 RID: 14631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003927")]
			[Address(RVA = "0x1D92470", Offset = "0x1D92470", VA = "0x1D92470")]
			internal void <AddPasses>b__309_61(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003928 RID: 14632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003928")]
			[Address(RVA = "0x1D939A0", Offset = "0x1D939A0", VA = "0x1D939A0")]
			internal void <AddPasses>b__309_62(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003929 RID: 14633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003929")]
			[Address(RVA = "0x1D943C8", Offset = "0x1D943C8", VA = "0x1D943C8")]
			internal void <AddPasses>b__309_63(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600392A RID: 14634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600392A")]
			[Address(RVA = "0x1D94BA8", Offset = "0x1D94BA8", VA = "0x1D94BA8")]
			internal void <AddPasses>b__309_64(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600392B RID: 14635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600392B")]
			[Address(RVA = "0x1D98264", Offset = "0x1D98264", VA = "0x1D98264")]
			internal void <AddPasses>b__309_65(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600392C RID: 14636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600392C")]
			[Address(RVA = "0x1D983F8", Offset = "0x1D983F8", VA = "0x1D983F8")]
			internal void <AddPasses>b__309_66(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600392D RID: 14637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600392D")]
			[Address(RVA = "0x1D99880", Offset = "0x1D99880", VA = "0x1D99880")]
			internal void <AddPasses>b__309_67(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600392E RID: 14638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600392E")]
			[Address(RVA = "0x1D99C08", Offset = "0x1D99C08", VA = "0x1D99C08")]
			internal void <AddPasses>b__309_68(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600392F RID: 14639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600392F")]
			[Address(RVA = "0x1D99EB4", Offset = "0x1D99EB4", VA = "0x1D99EB4")]
			internal void <AddPasses>b__309_69(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003930 RID: 14640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003930")]
			[Address(RVA = "0x1D9C790", Offset = "0x1D9C790", VA = "0x1D9C790")]
			internal void <AddPasses>b__309_70(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003931 RID: 14641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003931")]
			[Address(RVA = "0x1D9EEA8", Offset = "0x1D9EEA8", VA = "0x1D9EEA8")]
			internal void <AddPasses>b__309_71(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003932 RID: 14642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003932")]
			[Address(RVA = "0x1D9F688", Offset = "0x1D9F688", VA = "0x1D9F688")]
			internal void <AddPasses>b__309_72(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003933 RID: 14643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003933")]
			[Address(RVA = "0x1DA2928", Offset = "0x1DA2928", VA = "0x1DA2928")]
			internal void <AddPasses>b__309_73(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003934 RID: 14644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003934")]
			[Address(RVA = "0x1DA35E0", Offset = "0x1DA35E0", VA = "0x1DA35E0")]
			internal void <AddPasses>b__309_74(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003935 RID: 14645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003935")]
			[Address(RVA = "0x1DA5B58", Offset = "0x1DA5B58", VA = "0x1DA5B58")]
			internal void <AddPasses>b__309_75(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003936 RID: 14646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003936")]
			[Address(RVA = "0x1DA6E48", Offset = "0x1DA6E48", VA = "0x1DA6E48")]
			internal void <AddPasses>b__309_76(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003937 RID: 14647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003937")]
			[Address(RVA = "0x1DB3F54", Offset = "0x1DB3F54", VA = "0x1DB3F54")]
			internal void <AddPasses>b__309_77(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003938 RID: 14648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003938")]
			[Address(RVA = "0x1DB5160", Offset = "0x1DB5160", VA = "0x1DB5160")]
			internal void <AddPasses>b__309_78(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003939 RID: 14649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003939")]
			[Address(RVA = "0x1DB62EC", Offset = "0x1DB62EC", VA = "0x1DB62EC")]
			internal void <AddPasses>b__309_79(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600393A RID: 14650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600393A")]
			[Address(RVA = "0x1DB8DD8", Offset = "0x1DB8DD8", VA = "0x1DB8DD8")]
			internal void <AddPasses>b__309_80(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600393B RID: 14651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600393B")]
			[Address(RVA = "0x1DB95C8", Offset = "0x1DB95C8", VA = "0x1DB95C8")]
			internal void <AddPasses>b__309_81(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600393C RID: 14652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600393C")]
			[Address(RVA = "0x1DB99A0", Offset = "0x1DB99A0", VA = "0x1DB99A0")]
			internal void <AddPasses>b__309_82(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600393D RID: 14653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600393D")]
			[Address(RVA = "0x1DB9BFC", Offset = "0x1DB9BFC", VA = "0x1DB9BFC")]
			internal void <AddPasses>b__309_83(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600393E RID: 14654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600393E")]
			[Address(RVA = "0x1DB9E88", Offset = "0x1DB9E88", VA = "0x1DB9E88")]
			internal void <AddPasses>b__309_84(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600393F RID: 14655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600393F")]
			[Address(RVA = "0x1DBA970", Offset = "0x1DBA970", VA = "0x1DBA970")]
			internal void <AddPasses>b__309_85(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003940 RID: 14656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003940")]
			[Address(RVA = "0x1DBB9E8", Offset = "0x1DBB9E8", VA = "0x1DBB9E8")]
			internal void <AddPasses>b__309_86(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003941 RID: 14657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003941")]
			[Address(RVA = "0x1DBC4A4", Offset = "0x1DBC4A4", VA = "0x1DBC4A4")]
			internal void <AddPasses>b__309_87(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003942 RID: 14658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003942")]
			[Address(RVA = "0x1DBCC90", Offset = "0x1DBCC90", VA = "0x1DBCC90")]
			internal void <AddPasses>b__309_88(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003943 RID: 14659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003943")]
			[Address(RVA = "0x1DC1790", Offset = "0x1DC1790", VA = "0x1DC1790")]
			internal void <AddPasses>b__309_89(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003944 RID: 14660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003944")]
			[Address(RVA = "0x1DC5910", Offset = "0x1DC5910", VA = "0x1DC5910")]
			internal void <AddPasses>b__309_90(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003945 RID: 14661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003945")]
			[Address(RVA = "0x1DC6898", Offset = "0x1DC6898", VA = "0x1DC6898")]
			internal void <AddPasses>b__309_91(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003946 RID: 14662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003946")]
			[Address(RVA = "0x1DC7598", Offset = "0x1DC7598", VA = "0x1DC7598")]
			internal void <AddPasses>b__309_92(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003947 RID: 14663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003947")]
			[Address(RVA = "0x1DC84C0", Offset = "0x1DC84C0", VA = "0x1DC84C0")]
			internal void <AddPasses>b__309_93(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003948 RID: 14664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003948")]
			[Address(RVA = "0x1DC8AD4", Offset = "0x1DC8AD4", VA = "0x1DC8AD4")]
			internal void <AddPasses>b__309_94(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003949 RID: 14665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003949")]
			[Address(RVA = "0x1DC947C", Offset = "0x1DC947C", VA = "0x1DC947C")]
			internal void <AddPasses>b__309_95(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600394A RID: 14666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600394A")]
			[Address(RVA = "0x1DC9A80", Offset = "0x1DC9A80", VA = "0x1DC9A80")]
			internal void <AddPasses>b__309_96(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600394B RID: 14667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600394B")]
			[Address(RVA = "0x1DCCA10", Offset = "0x1DCCA10", VA = "0x1DCCA10")]
			internal void <AddPasses>b__309_97(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600394C RID: 14668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600394C")]
			[Address(RVA = "0x1DCCFF8", Offset = "0x1DCCFF8", VA = "0x1DCCFF8")]
			internal void <AddPasses>b__309_98(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600394D RID: 14669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600394D")]
			[Address(RVA = "0x1DCF25C", Offset = "0x1DCF25C", VA = "0x1DCF25C")]
			internal void <AddPasses>b__309_99(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600394E RID: 14670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600394E")]
			[Address(RVA = "0x1DD2A24", Offset = "0x1DD2A24", VA = "0x1DD2A24")]
			internal void <AddPasses>b__309_100(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0600394F RID: 14671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600394F")]
			[Address(RVA = "0x1DD3128", Offset = "0x1DD3128", VA = "0x1DD3128")]
			internal void <AddPasses>b__309_101(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003950 RID: 14672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003950")]
			[Address(RVA = "0x1DD3F70", Offset = "0x1DD3F70", VA = "0x1DD3F70")]
			internal void <AddPasses>b__309_102(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003951 RID: 14673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003951")]
			[Address(RVA = "0x1DD5D3C", Offset = "0x1DD5D3C", VA = "0x1DD5D3C")]
			internal void <AddPasses>b__309_103(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06003952 RID: 14674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003952")]
			[Address(RVA = "0x1DD6178", Offset = "0x1DD6178", VA = "0x1DD6178")]
			internal void <AddPasses>b__309_104(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x0400451F RID: 17695
			[Token(Token = "0x400451F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly WorldGen.<>c <>9;

			// Token: 0x04004520 RID: 17696
			[Token(Token = "0x4004520")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static MainThreadExecution.ExecutionSnippet <>9__181_1;

			// Token: 0x04004521 RID: 17697
			[Token(Token = "0x4004521")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__187_0;

			// Token: 0x04004522 RID: 17698
			[Token(Token = "0x4004522")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static WorldGenLegacyMethod <>9__309_0;

			// Token: 0x04004523 RID: 17699
			[Token(Token = "0x4004523")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static WorldGenLegacyMethod <>9__309_1;

			// Token: 0x04004524 RID: 17700
			[Token(Token = "0x4004524")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static WorldGenLegacyMethod <>9__309_2;

			// Token: 0x04004525 RID: 17701
			[Token(Token = "0x4004525")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static WorldGenLegacyMethod <>9__309_3;

			// Token: 0x04004526 RID: 17702
			[Token(Token = "0x4004526")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static WorldGenLegacyMethod <>9__309_4;

			// Token: 0x04004527 RID: 17703
			[Token(Token = "0x4004527")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static WorldGenLegacyMethod <>9__309_5;

			// Token: 0x04004528 RID: 17704
			[Token(Token = "0x4004528")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static WorldGenLegacyMethod <>9__309_6;

			// Token: 0x04004529 RID: 17705
			[Token(Token = "0x4004529")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static WorldGenLegacyMethod <>9__309_7;

			// Token: 0x0400452A RID: 17706
			[Token(Token = "0x400452A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public static WorldGenLegacyMethod <>9__309_8;

			// Token: 0x0400452B RID: 17707
			[Token(Token = "0x400452B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static WorldGenLegacyMethod <>9__309_9;

			// Token: 0x0400452C RID: 17708
			[Token(Token = "0x400452C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public static WorldGenLegacyMethod <>9__309_10;

			// Token: 0x0400452D RID: 17709
			[Token(Token = "0x400452D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static WorldGenLegacyMethod <>9__309_11;

			// Token: 0x0400452E RID: 17710
			[Token(Token = "0x400452E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public static WorldGenLegacyMethod <>9__309_12;

			// Token: 0x0400452F RID: 17711
			[Token(Token = "0x400452F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static WorldGenLegacyMethod <>9__309_13;

			// Token: 0x04004530 RID: 17712
			[Token(Token = "0x4004530")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public static WorldGenLegacyMethod <>9__309_14;

			// Token: 0x04004531 RID: 17713
			[Token(Token = "0x4004531")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static WorldGenLegacyMethod <>9__309_15;

			// Token: 0x04004532 RID: 17714
			[Token(Token = "0x4004532")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public static WorldGenLegacyMethod <>9__309_16;

			// Token: 0x04004533 RID: 17715
			[Token(Token = "0x4004533")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static WorldGenLegacyMethod <>9__309_17;

			// Token: 0x04004534 RID: 17716
			[Token(Token = "0x4004534")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public static WorldGenLegacyMethod <>9__309_18;

			// Token: 0x04004535 RID: 17717
			[Token(Token = "0x4004535")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static WorldGenLegacyMethod <>9__309_19;

			// Token: 0x04004536 RID: 17718
			[Token(Token = "0x4004536")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public static WorldGenLegacyMethod <>9__309_20;

			// Token: 0x04004537 RID: 17719
			[Token(Token = "0x4004537")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static WorldGenLegacyMethod <>9__309_21;

			// Token: 0x04004538 RID: 17720
			[Token(Token = "0x4004538")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public static WorldGenLegacyMethod <>9__309_22;

			// Token: 0x04004539 RID: 17721
			[Token(Token = "0x4004539")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static WorldGenLegacyMethod <>9__309_23;

			// Token: 0x0400453A RID: 17722
			[Token(Token = "0x400453A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public static WorldGenLegacyMethod <>9__309_24;

			// Token: 0x0400453B RID: 17723
			[Token(Token = "0x400453B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static WorldGenLegacyMethod <>9__309_25;

			// Token: 0x0400453C RID: 17724
			[Token(Token = "0x400453C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public static WorldGenLegacyMethod <>9__309_26;

			// Token: 0x0400453D RID: 17725
			[Token(Token = "0x400453D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static WorldGenLegacyMethod <>9__309_27;

			// Token: 0x0400453E RID: 17726
			[Token(Token = "0x400453E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public static WorldGenLegacyMethod <>9__309_28;

			// Token: 0x0400453F RID: 17727
			[Token(Token = "0x400453F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static WorldGenLegacyMethod <>9__309_29;

			// Token: 0x04004540 RID: 17728
			[Token(Token = "0x4004540")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public static WorldGenLegacyMethod <>9__309_30;

			// Token: 0x04004541 RID: 17729
			[Token(Token = "0x4004541")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static WorldGenLegacyMethod <>9__309_31;

			// Token: 0x04004542 RID: 17730
			[Token(Token = "0x4004542")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public static WorldGenLegacyMethod <>9__309_32;

			// Token: 0x04004543 RID: 17731
			[Token(Token = "0x4004543")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static WorldGenLegacyMethod <>9__309_33;

			// Token: 0x04004544 RID: 17732
			[Token(Token = "0x4004544")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public static WorldGenLegacyMethod <>9__309_34;

			// Token: 0x04004545 RID: 17733
			[Token(Token = "0x4004545")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static WorldGenLegacyMethod <>9__309_35;

			// Token: 0x04004546 RID: 17734
			[Token(Token = "0x4004546")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public static WorldGenLegacyMethod <>9__309_36;

			// Token: 0x04004547 RID: 17735
			[Token(Token = "0x4004547")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static WorldGenLegacyMethod <>9__309_37;

			// Token: 0x04004548 RID: 17736
			[Token(Token = "0x4004548")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public static WorldGenLegacyMethod <>9__309_38;

			// Token: 0x04004549 RID: 17737
			[Token(Token = "0x4004549")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static WorldGenLegacyMethod <>9__309_39;

			// Token: 0x0400454A RID: 17738
			[Token(Token = "0x400454A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public static WorldGenLegacyMethod <>9__309_40;

			// Token: 0x0400454B RID: 17739
			[Token(Token = "0x400454B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static WorldGenLegacyMethod <>9__309_41;

			// Token: 0x0400454C RID: 17740
			[Token(Token = "0x400454C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			public static WorldGenLegacyMethod <>9__309_42;

			// Token: 0x0400454D RID: 17741
			[Token(Token = "0x400454D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static WorldGenLegacyMethod <>9__309_43;

			// Token: 0x0400454E RID: 17742
			[Token(Token = "0x400454E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			public static WorldGenLegacyMethod <>9__309_44;

			// Token: 0x0400454F RID: 17743
			[Token(Token = "0x400454F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static WorldGenLegacyMethod <>9__309_45;

			// Token: 0x04004550 RID: 17744
			[Token(Token = "0x4004550")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			public static WorldGenLegacyMethod <>9__309_46;

			// Token: 0x04004551 RID: 17745
			[Token(Token = "0x4004551")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static WorldGenLegacyMethod <>9__309_47;

			// Token: 0x04004552 RID: 17746
			[Token(Token = "0x4004552")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			public static WorldGenLegacyMethod <>9__309_48;

			// Token: 0x04004553 RID: 17747
			[Token(Token = "0x4004553")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static WorldGenLegacyMethod <>9__309_49;

			// Token: 0x04004554 RID: 17748
			[Token(Token = "0x4004554")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			public static WorldGenLegacyMethod <>9__309_50;

			// Token: 0x04004555 RID: 17749
			[Token(Token = "0x4004555")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public static WorldGenLegacyMethod <>9__309_51;

			// Token: 0x04004556 RID: 17750
			[Token(Token = "0x4004556")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			public static WorldGenLegacyMethod <>9__309_52;

			// Token: 0x04004557 RID: 17751
			[Token(Token = "0x4004557")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public static WorldGenLegacyMethod <>9__309_53;

			// Token: 0x04004558 RID: 17752
			[Token(Token = "0x4004558")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			public static WorldGenLegacyMethod <>9__309_54;

			// Token: 0x04004559 RID: 17753
			[Token(Token = "0x4004559")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public static WorldGenLegacyMethod <>9__309_55;

			// Token: 0x0400455A RID: 17754
			[Token(Token = "0x400455A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			public static WorldGenLegacyMethod <>9__309_56;

			// Token: 0x0400455B RID: 17755
			[Token(Token = "0x400455B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public static WorldGenLegacyMethod <>9__309_57;

			// Token: 0x0400455C RID: 17756
			[Token(Token = "0x400455C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			public static WorldGenLegacyMethod <>9__309_58;

			// Token: 0x0400455D RID: 17757
			[Token(Token = "0x400455D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public static WorldGenLegacyMethod <>9__309_59;

			// Token: 0x0400455E RID: 17758
			[Token(Token = "0x400455E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			public static WorldGenLegacyMethod <>9__309_60;

			// Token: 0x0400455F RID: 17759
			[Token(Token = "0x400455F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public static WorldGenLegacyMethod <>9__309_61;

			// Token: 0x04004560 RID: 17760
			[Token(Token = "0x4004560")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			public static WorldGenLegacyMethod <>9__309_62;

			// Token: 0x04004561 RID: 17761
			[Token(Token = "0x4004561")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public static WorldGenLegacyMethod <>9__309_63;

			// Token: 0x04004562 RID: 17762
			[Token(Token = "0x4004562")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			public static WorldGenLegacyMethod <>9__309_64;

			// Token: 0x04004563 RID: 17763
			[Token(Token = "0x4004563")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			public static WorldGenLegacyMethod <>9__309_65;

			// Token: 0x04004564 RID: 17764
			[Token(Token = "0x4004564")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			public static WorldGenLegacyMethod <>9__309_66;

			// Token: 0x04004565 RID: 17765
			[Token(Token = "0x4004565")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public static WorldGenLegacyMethod <>9__309_67;

			// Token: 0x04004566 RID: 17766
			[Token(Token = "0x4004566")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			public static WorldGenLegacyMethod <>9__309_68;

			// Token: 0x04004567 RID: 17767
			[Token(Token = "0x4004567")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			public static WorldGenLegacyMethod <>9__309_69;

			// Token: 0x04004568 RID: 17768
			[Token(Token = "0x4004568")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			public static WorldGenLegacyMethod <>9__309_70;

			// Token: 0x04004569 RID: 17769
			[Token(Token = "0x4004569")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			public static WorldGenLegacyMethod <>9__309_71;

			// Token: 0x0400456A RID: 17770
			[Token(Token = "0x400456A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			public static WorldGenLegacyMethod <>9__309_72;

			// Token: 0x0400456B RID: 17771
			[Token(Token = "0x400456B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			public static WorldGenLegacyMethod <>9__309_73;

			// Token: 0x0400456C RID: 17772
			[Token(Token = "0x400456C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			public static WorldGenLegacyMethod <>9__309_74;

			// Token: 0x0400456D RID: 17773
			[Token(Token = "0x400456D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public static WorldGenLegacyMethod <>9__309_75;

			// Token: 0x0400456E RID: 17774
			[Token(Token = "0x400456E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			public static WorldGenLegacyMethod <>9__309_76;

			// Token: 0x0400456F RID: 17775
			[Token(Token = "0x400456F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			public static WorldGenLegacyMethod <>9__309_77;

			// Token: 0x04004570 RID: 17776
			[Token(Token = "0x4004570")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			public static WorldGenLegacyMethod <>9__309_78;

			// Token: 0x04004571 RID: 17777
			[Token(Token = "0x4004571")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			public static WorldGenLegacyMethod <>9__309_79;

			// Token: 0x04004572 RID: 17778
			[Token(Token = "0x4004572")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			public static WorldGenLegacyMethod <>9__309_80;

			// Token: 0x04004573 RID: 17779
			[Token(Token = "0x4004573")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			public static WorldGenLegacyMethod <>9__309_81;

			// Token: 0x04004574 RID: 17780
			[Token(Token = "0x4004574")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x154")]
			public static WorldGenLegacyMethod <>9__309_82;

			// Token: 0x04004575 RID: 17781
			[Token(Token = "0x4004575")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			public static WorldGenLegacyMethod <>9__309_83;

			// Token: 0x04004576 RID: 17782
			[Token(Token = "0x4004576")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			public static WorldGenLegacyMethod <>9__309_84;

			// Token: 0x04004577 RID: 17783
			[Token(Token = "0x4004577")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			public static WorldGenLegacyMethod <>9__309_85;

			// Token: 0x04004578 RID: 17784
			[Token(Token = "0x4004578")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x164")]
			public static WorldGenLegacyMethod <>9__309_86;

			// Token: 0x04004579 RID: 17785
			[Token(Token = "0x4004579")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			public static WorldGenLegacyMethod <>9__309_87;

			// Token: 0x0400457A RID: 17786
			[Token(Token = "0x400457A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			public static WorldGenLegacyMethod <>9__309_88;

			// Token: 0x0400457B RID: 17787
			[Token(Token = "0x400457B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			public static WorldGenLegacyMethod <>9__309_89;

			// Token: 0x0400457C RID: 17788
			[Token(Token = "0x400457C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			public static WorldGenLegacyMethod <>9__309_90;

			// Token: 0x0400457D RID: 17789
			[Token(Token = "0x400457D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			public static WorldGenLegacyMethod <>9__309_91;

			// Token: 0x0400457E RID: 17790
			[Token(Token = "0x400457E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			public static WorldGenLegacyMethod <>9__309_92;

			// Token: 0x0400457F RID: 17791
			[Token(Token = "0x400457F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			public static WorldGenLegacyMethod <>9__309_93;

			// Token: 0x04004580 RID: 17792
			[Token(Token = "0x4004580")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			public static WorldGenLegacyMethod <>9__309_94;

			// Token: 0x04004581 RID: 17793
			[Token(Token = "0x4004581")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			public static WorldGenLegacyMethod <>9__309_95;

			// Token: 0x04004582 RID: 17794
			[Token(Token = "0x4004582")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			public static WorldGenLegacyMethod <>9__309_96;

			// Token: 0x04004583 RID: 17795
			[Token(Token = "0x4004583")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			public static WorldGenLegacyMethod <>9__309_97;

			// Token: 0x04004584 RID: 17796
			[Token(Token = "0x4004584")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			public static WorldGenLegacyMethod <>9__309_98;

			// Token: 0x04004585 RID: 17797
			[Token(Token = "0x4004585")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			public static WorldGenLegacyMethod <>9__309_99;

			// Token: 0x04004586 RID: 17798
			[Token(Token = "0x4004586")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			public static WorldGenLegacyMethod <>9__309_100;

			// Token: 0x04004587 RID: 17799
			[Token(Token = "0x4004587")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			public static WorldGenLegacyMethod <>9__309_101;

			// Token: 0x04004588 RID: 17800
			[Token(Token = "0x4004588")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
			public static WorldGenLegacyMethod <>9__309_102;

			// Token: 0x04004589 RID: 17801
			[Token(Token = "0x4004589")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			public static WorldGenLegacyMethod <>9__309_103;

			// Token: 0x0400458A RID: 17802
			[Token(Token = "0x400458A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			public static WorldGenLegacyMethod <>9__309_104;
		}

		// Token: 0x02000532 RID: 1330
		[Token(Token = "0x2000532")]
		private sealed class <>c__DisplayClass309_0
		{
			// Token: 0x06003953 RID: 14675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003953")]
			[Address(RVA = "0x1DE8E5C", Offset = "0x1DE8E5C", VA = "0x1DE8E5C")]
			public <>c__DisplayClass309_0()
			{
			}

			// Token: 0x06003954 RID: 14676 RVA: 0x0001CF08 File Offset: 0x0001B108
			[Token(Token = "0x6003954")]
			[Address(RVA = "0x1DE8E64", Offset = "0x1DE8E64", VA = "0x1DE8E64")]
			internal bool <AddPasses>b__105(int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x06003955 RID: 14677 RVA: 0x0001CF20 File Offset: 0x0001B120
			[Token(Token = "0x6003955")]
			[Address(RVA = "0x1DE8E74", Offset = "0x1DE8E74", VA = "0x1DE8E74")]
			internal bool <AddPasses>b__106(int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x0400458B RID: 17803
			[Token(Token = "0x400458B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool foundInvalidTile;
		}

		// Token: 0x02000533 RID: 1331
		[Token(Token = "0x2000533")]
		[StructLayout(3)]
		private struct <>c__DisplayClass309_1
		{
			// Token: 0x0400458C RID: 17804
			[Token(Token = "0x400458C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public unsafe uint* TileData_TileLookup;

			// Token: 0x0400458D RID: 17805
			[Token(Token = "0x400458D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int Main_maxTilesX;

			// Token: 0x0400458E RID: 17806
			[Token(Token = "0x400458E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public unsafe short* TileData_TileSHeader;

			// Token: 0x0400458F RID: 17807
			[Token(Token = "0x400458F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public unsafe short* TileData_TileFrameX;

			// Token: 0x04004590 RID: 17808
			[Token(Token = "0x4004590")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public unsafe ushort* TileData_TileType;

			// Token: 0x04004591 RID: 17809
			[Token(Token = "0x4004591")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public unsafe byte* TileData_TileBHeader;
		}
	}
}
