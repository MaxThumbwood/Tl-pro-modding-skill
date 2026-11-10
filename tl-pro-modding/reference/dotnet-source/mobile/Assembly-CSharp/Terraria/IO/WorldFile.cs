using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Terraria.WorldBuilding;

namespace Terraria.IO
{
	// Token: 0x0200068A RID: 1674
	[Token(Token = "0x200068A")]
	public class WorldFile
	{
		// Token: 0x06004028 RID: 16424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004028")]
		[Address(RVA = "0x1E939B0", Offset = "0x1E939B0", VA = "0x1E939B0")]
		public static void ReuseTempsForNextSave()
		{
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004029")]
		[Address(RVA = "0x1E93A18", Offset = "0x1E93A18", VA = "0x1E93A18")]
		public static void SetOngoingToTemps()
		{
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x0001F938 File Offset: 0x0001DB38
		[Token(Token = "0x600402A")]
		[Address(RVA = "0x1E93CF4", Offset = "0x1E93CF4", VA = "0x1E93CF4")]
		public static bool IsValidWorld(string file, bool cloudSave)
		{
			return default(bool);
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402B")]
		[Address(RVA = "0x1E942E8", Offset = "0x1E942E8", VA = "0x1E942E8")]
		public static WorldFileData GetInputWorld()
		{
			return null;
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402C")]
		[Address(RVA = "0x1E962C4", Offset = "0x1E962C4", VA = "0x1E962C4")]
		public static WorldFileData GetTutorialMetadata()
		{
			return null;
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402D")]
		[Address(RVA = "0x1E9447C", Offset = "0x1E9447C", VA = "0x1E9447C")]
		public static WorldFileData GetWorldFileData(WorldFileData data, byte[] fileData)
		{
			return null;
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402E")]
		[Address(RVA = "0x1E9768C", Offset = "0x1E9768C", VA = "0x1E9768C")]
		public static WorldFileData GetAllMetadata(string file, bool cloudSave)
		{
			return null;
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600402F")]
		[Address(RVA = "0x1E99800", Offset = "0x1E99800", VA = "0x1E99800")]
		public static WorldFileData CreateMetadata(string name, bool cloudSave, int GameMode)
		{
			return null;
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004030")]
		[Address(RVA = "0x1E99AD4", Offset = "0x1E99AD4", VA = "0x1E99AD4")]
		public static void ResetTemps()
		{
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004031")]
		[Address(RVA = "0x1E99BE8", Offset = "0x1E99BE8", VA = "0x1E99BE8")]
		private static void ClearTempTiles()
		{
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004032")]
		[Address(RVA = "0x1E99D68", Offset = "0x1E99D68", VA = "0x1E99D68")]
		private static void ReregisterTiles()
		{
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004033")]
		[Address(RVA = "0x1E99F50", Offset = "0x1E99F50", VA = "0x1E99F50")]
		public static void LoadTutorialOnMainThread(object threadContext)
		{
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004034")]
		[Address(RVA = "0x1E9A018", Offset = "0x1E9A018", VA = "0x1E9A018")]
		public static void LoadWorld(bool canCheckFileState = false)
		{
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004035")]
		[Address(RVA = "0x1EA1748", Offset = "0x1EA1748", VA = "0x1EA1748")]
		public static void CheckSavedOreTiers()
		{
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004036")]
		[Address(RVA = "0x1E9BE94", Offset = "0x1E9BE94", VA = "0x1E9BE94")]
		public static void SaveWorld(WorldFile.WorldSaveContext saveContext = WorldFile.WorldSaveContext.Normal)
		{
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004037")]
		[Address(RVA = "0x1EA1E5C", Offset = "0x1EA1E5C", VA = "0x1EA1E5C")]
		public static void SaveWorld(bool useCloudSaving, bool resetTime = false, WorldFile.WorldSaveContext saveContext = WorldFile.WorldSaveContext.Normal)
		{
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004038")]
		[Address(RVA = "0x1EA2440", Offset = "0x1EA2440", VA = "0x1EA2440")]
		private static void InternalSaveWorld(bool useCloudSaving, bool resetTime)
		{
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x0001F950 File Offset: 0x0001DB50
		[Token(Token = "0x6004039")]
		[Address(RVA = "0x1EA4DE8", Offset = "0x1EA4DE8", VA = "0x1EA4DE8")]
		public static bool RenameWorld(string newName, bool useCloudSaving = false)
		{
			return default(bool);
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x0001F968 File Offset: 0x0001DB68
		[Token(Token = "0x600403A")]
		[Address(RVA = "0x1EA6840", Offset = "0x1EA6840", VA = "0x1EA6840")]
		public static bool RenameWorldUsingLoadAndSave(string newName)
		{
			return default(bool);
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403B")]
		[Address(RVA = "0x1EA6A08", Offset = "0x1EA6A08", VA = "0x1EA6A08")]
		private static void RenameWorldCheck()
		{
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403C")]
		[Address(RVA = "0x1EA6B98", Offset = "0x1EA6B98", VA = "0x1EA6B98")]
		private static void RenameWorldUsingLoadAndSave()
		{
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x1EA6CFC", Offset = "0x1EA6CFC", VA = "0x1EA6CFC")]
		private static void renameWorldCallBack(object threadContext)
		{
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x1EA4BAC", Offset = "0x1EA4BAC", VA = "0x1EA4BAC")]
		private static void DoRollingBackups(string backupWorldWritePath)
		{
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600403F")]
		[Address(RVA = "0x1EA3420", Offset = "0x1EA3420", VA = "0x1EA3420")]
		private static void ResetTempsToDayTime()
		{
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004040")]
		[Address(RVA = "0x1EA3140", Offset = "0x1EA3140", VA = "0x1EA3140")]
		public static void SetTempToOngoing()
		{
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004041")]
		[Address(RVA = "0x1EA6F78", Offset = "0x1EA6F78", VA = "0x1EA6F78")]
		private static void ConvertMannequin(int px, int py)
		{
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004042")]
		[Address(RVA = "0x1EA75F4", Offset = "0x1EA75F4", VA = "0x1EA75F4")]
		private static void ConvertWeaponRack(int px, int py)
		{
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004043")]
		[Address(RVA = "0x1EA19F0", Offset = "0x1EA19F0", VA = "0x1EA19F0")]
		private static void ConvertOldTileEntities()
		{
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004044")]
		[Address(RVA = "0x1EA365C", Offset = "0x1EA365C", VA = "0x1EA365C")]
		private static void SaveWorld_Version2(BinaryWriter writer)
		{
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x0001F980 File Offset: 0x0001DB80
		[Token(Token = "0x6004045")]
		[Address(RVA = "0x1EA7B34", Offset = "0x1EA7B34", VA = "0x1EA7B34")]
		private static int SaveFileFormatHeader(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x0001F998 File Offset: 0x0001DB98
		[Token(Token = "0x6004046")]
		[Address(RVA = "0x1EAA318", Offset = "0x1EAA318", VA = "0x1EAA318")]
		private static int SaveHeaderPointers(BinaryWriter writer, int[] pointers)
		{
			return 0;
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x0001F9B0 File Offset: 0x0001DBB0
		[Token(Token = "0x6004047")]
		[Address(RVA = "0x1EA7E24", Offset = "0x1EA7E24", VA = "0x1EA7E24")]
		private static int SaveWorldHeader(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004048")]
		[Address(RVA = "0x1EAA49C", Offset = "0x1EAA49C", VA = "0x1EAA49C")]
		public static void SaveWorldFlags(BinaryWriter writer)
		{
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004049")]
		[Address(RVA = "0x1EAC1FC", Offset = "0x1EAC1FC", VA = "0x1EAC1FC")]
		public static void SaveManifest(BinaryWriter writer, WorldManifest manifest)
		{
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		[Token(Token = "0x600404A")]
		[Address(RVA = "0x1EA8118", Offset = "0x1EA8118", VA = "0x1EA8118")]
		private static int SaveWorldTilesFast(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		[Token(Token = "0x600404B")]
		[Address(RVA = "0x1EAC268", Offset = "0x1EAC268", VA = "0x1EAC268")]
		public static int SaveWorldTiles(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		[Token(Token = "0x600404C")]
		[Address(RVA = "0x1EA8AE0", Offset = "0x1EA8AE0", VA = "0x1EA8AE0")]
		private static int SaveChests(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x0001FA10 File Offset: 0x0001DC10
		[Token(Token = "0x600404D")]
		[Address(RVA = "0x1EA9108", Offset = "0x1EA9108", VA = "0x1EA9108")]
		private static int SaveSigns(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x0001FA28 File Offset: 0x0001DC28
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x1EA92F0", Offset = "0x1EA92F0", VA = "0x1EA92F0")]
		private static int SaveNPCs(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x0001FA40 File Offset: 0x0001DC40
		[Token(Token = "0x600404F")]
		[Address(RVA = "0x1EA6738", Offset = "0x1EA6738", VA = "0x1EA6738")]
		private static int SaveFooter(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0001FA58 File Offset: 0x0001DC58
		[Token(Token = "0x6004050")]
		[Address(RVA = "0x1EA07A4", Offset = "0x1EA07A4", VA = "0x1EA07A4")]
		private static int LoadWorld_Version2(BinaryReader reader)
		{
			return 0;
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004051")]
		[Address(RVA = "0x1EB0FAC", Offset = "0x1EB0FAC", VA = "0x1EB0FAC")]
		private static void LoadWorld_LastMinuteFixes()
		{
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004052")]
		[Address(RVA = "0x1EB1658", Offset = "0x1EB1658", VA = "0x1EB1658")]
		private static void FixAgainstExploits()
		{
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x0001FA70 File Offset: 0x0001DC70
		[Token(Token = "0x6004053")]
		[Address(RVA = "0x1EA6350", Offset = "0x1EA6350", VA = "0x1EA6350")]
		public static bool LoadFileFormatHeader(BinaryReader reader, out bool[] importance, out int[] positions, out int positionsOffset)
		{
			return default(bool);
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004054")]
		[Address(RVA = "0x1EADBAC", Offset = "0x1EADBAC", VA = "0x1EADBAC")]
		private static void LoadHeader(BinaryReader reader)
		{
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004055")]
		[Address(RVA = "0x1EB1BA8", Offset = "0x1EB1BA8", VA = "0x1EB1BA8")]
		public static void LoadWorldFlags(BinaryReader reader, int version)
		{
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004056")]
		[Address(RVA = "0x1EADF60", Offset = "0x1EADF60", VA = "0x1EADF60")]
		private static void LoadWorldTiles(BinaryReader reader, bool[] importance)
		{
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004057")]
		[Address(RVA = "0x1EB52C4", Offset = "0x1EB52C4", VA = "0x1EB52C4")]
		private static void FixupSinks()
		{
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004058")]
		[Address(RVA = "0x1EAECBC", Offset = "0x1EAECBC", VA = "0x1EAECBC")]
		public static void LoadChests(BinaryReader reader)
		{
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004059")]
		[Address(RVA = "0x1EB11CC", Offset = "0x1EB11CC", VA = "0x1EB11CC")]
		private static void ConvertIlluminantPaintToNewField()
		{
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405A")]
		[Address(RVA = "0x1EAF368", Offset = "0x1EAF368", VA = "0x1EAF368")]
		private static void LoadSigns(BinaryReader reader)
		{
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405B")]
		[Address(RVA = "0x1EB01C4", Offset = "0x1EB01C4", VA = "0x1EB01C4")]
		private static void LoadDummies(BinaryReader reader)
		{
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405C")]
		[Address(RVA = "0x1EAFA30", Offset = "0x1EAFA30", VA = "0x1EAFA30")]
		private static void LoadNPCs(BinaryReader reader)
		{
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405D")]
		[Address(RVA = "0x1EB5BDC", Offset = "0x1EB5BDC", VA = "0x1EB5BDC")]
		private static void ValidateLoadNPCs(BinaryReader fileIO)
		{
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0001FA88 File Offset: 0x0001DC88
		[Token(Token = "0x600405E")]
		[Address(RVA = "0x1EB1050", Offset = "0x1EB1050", VA = "0x1EB1050")]
		private static int LoadFooter(BinaryReader reader)
		{
			return 0;
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		[Token(Token = "0x600405F")]
		[Address(RVA = "0x1EA38D0", Offset = "0x1EA38D0", VA = "0x1EA38D0")]
		private static bool ValidateWorld(BinaryReader fileIO)
		{
			return default(bool);
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004060")]
		[Address(RVA = "0x1E93D68", Offset = "0x1E93D68", VA = "0x1E93D68")]
		private static FileMetadata GetFileMetadata(string file, bool cloudSave)
		{
			return null;
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004061")]
		[Address(RVA = "0x1EB5844", Offset = "0x1EB5844", VA = "0x1EB5844")]
		private static void FixDresserChests()
		{
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004062")]
		[Address(RVA = "0x1EB4FD4", Offset = "0x1EB4FD4", VA = "0x1EB4FD4")]
		private static void FixEndlessRainWorlds()
		{
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		[Token(Token = "0x6004063")]
		[Address(RVA = "0x1EA9988", Offset = "0x1EA9988", VA = "0x1EA9988")]
		private static int SaveTileEntities(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004064")]
		[Address(RVA = "0x1EB022C", Offset = "0x1EB022C", VA = "0x1EB022C")]
		private static void LoadTileEntities(BinaryReader reader)
		{
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		[Token(Token = "0x6004065")]
		[Address(RVA = "0x1EA9D4C", Offset = "0x1EA9D4C", VA = "0x1EA9D4C")]
		private static int SaveWeightedPressurePlates(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004066")]
		[Address(RVA = "0x1EB0C14", Offset = "0x1EB0C14", VA = "0x1EB0C14")]
		private static void LoadWeightedPressurePlates(BinaryReader reader)
		{
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0001FAE8 File Offset: 0x0001DCE8
		[Token(Token = "0x6004067")]
		[Address(RVA = "0x1EAA110", Offset = "0x1EAA110", VA = "0x1EAA110")]
		private static int SaveTownManager(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004068")]
		[Address(RVA = "0x1EB0DE4", Offset = "0x1EB0DE4", VA = "0x1EB0DE4")]
		private static void LoadTownManager(BinaryReader reader)
		{
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x0001FB00 File Offset: 0x0001DD00
		[Token(Token = "0x6004069")]
		[Address(RVA = "0x1EAA1D8", Offset = "0x1EAA1D8", VA = "0x1EAA1D8")]
		private static int SaveBestiary(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406A")]
		[Address(RVA = "0x1EB0E68", Offset = "0x1EB0E68", VA = "0x1EB0E68")]
		private static void LoadBestiary(BinaryReader reader, int loadVersionNumber)
		{
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406B")]
		[Address(RVA = "0x1EB0EF4", Offset = "0x1EB0EF4", VA = "0x1EB0EF4")]
		private static void LoadBestiaryForVersionsBefore210()
		{
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x0001FB18 File Offset: 0x0001DD18
		[Token(Token = "0x600406C")]
		[Address(RVA = "0x1EAA2A0", Offset = "0x1EAA2A0", VA = "0x1EAA2A0")]
		private static int SaveCreativePowers(BinaryWriter writer)
		{
			return 0;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406D")]
		[Address(RVA = "0x1EB0F70", Offset = "0x1EB0F70", VA = "0x1EB0F70")]
		private static void LoadCreativePowers(BinaryReader reader, int loadVersionNumber)
		{
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x0001FB30 File Offset: 0x0001DD30
		[Token(Token = "0x600406E")]
		[Address(RVA = "0x1E9C030", Offset = "0x1E9C030", VA = "0x1E9C030")]
		private static int LoadWorld_Version1_Old_BeforeRelease88(BinaryReader fileIO)
		{
			return 0;
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406F")]
		[Address(RVA = "0x1EB5DDC", Offset = "0x1EB5DDC", VA = "0x1EB5DDC")]
		public WorldFile()
		{
		}

		// Token: 0x04004E0E RID: 19982
		[Token(Token = "0x4004E0E")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly object IOLock;

		// Token: 0x04004E0F RID: 19983
		[Token(Token = "0x4004E0F")]
		[FieldOffset(Offset = "0x4")]
		private static bool _reuseTempsForNextSave;

		// Token: 0x04004E10 RID: 19984
		[Token(Token = "0x4004E10")]
		[FieldOffset(Offset = "0x8")]
		public static double _tempTime;

		// Token: 0x04004E11 RID: 19985
		[Token(Token = "0x4004E11")]
		[FieldOffset(Offset = "0x10")]
		public static bool _tempRaining;

		// Token: 0x04004E12 RID: 19986
		[Token(Token = "0x4004E12")]
		[FieldOffset(Offset = "0x14")]
		public static float _tempMaxRain;

		// Token: 0x04004E13 RID: 19987
		[Token(Token = "0x4004E13")]
		[FieldOffset(Offset = "0x18")]
		public static int _tempRainTime;

		// Token: 0x04004E14 RID: 19988
		[Token(Token = "0x4004E14")]
		[FieldOffset(Offset = "0x1C")]
		public static bool _tempDayTime;

		// Token: 0x04004E15 RID: 19989
		[Token(Token = "0x4004E15")]
		[FieldOffset(Offset = "0x1D")]
		public static bool _tempBloodMoon;

		// Token: 0x04004E16 RID: 19990
		[Token(Token = "0x4004E16")]
		[FieldOffset(Offset = "0x1E")]
		public static bool _tempEclipse;

		// Token: 0x04004E17 RID: 19991
		[Token(Token = "0x4004E17")]
		[FieldOffset(Offset = "0x20")]
		public static int _tempMoonPhase;

		// Token: 0x04004E18 RID: 19992
		[Token(Token = "0x4004E18")]
		[FieldOffset(Offset = "0x24")]
		public static int _tempCultistDelay;

		// Token: 0x04004E19 RID: 19993
		[Token(Token = "0x4004E19")]
		[FieldOffset(Offset = "0x28")]
		public static int _versionNumber;

		// Token: 0x04004E1A RID: 19994
		[Token(Token = "0x4004E1A")]
		[FieldOffset(Offset = "0x2C")]
		public static bool _isWorldOnCloud;

		// Token: 0x04004E1B RID: 19995
		[Token(Token = "0x4004E1B")]
		[FieldOffset(Offset = "0x2D")]
		public static bool _tempPartyGenuine;

		// Token: 0x04004E1C RID: 19996
		[Token(Token = "0x4004E1C")]
		[FieldOffset(Offset = "0x2E")]
		public static bool _tempPartyManual;

		// Token: 0x04004E1D RID: 19997
		[Token(Token = "0x4004E1D")]
		[FieldOffset(Offset = "0x30")]
		public static int _tempPartyCooldown;

		// Token: 0x04004E1E RID: 19998
		[Token(Token = "0x4004E1E")]
		[FieldOffset(Offset = "0x34")]
		public static readonly List<int> TempPartyCelebratingNPCs;

		// Token: 0x04004E1F RID: 19999
		[Token(Token = "0x4004E1F")]
		[FieldOffset(Offset = "0x38")]
		public static bool _tempSandstormHappening;

		// Token: 0x04004E20 RID: 20000
		[Token(Token = "0x4004E20")]
		[FieldOffset(Offset = "0x3C")]
		public static int _tempSandstormTimeLeft;

		// Token: 0x04004E21 RID: 20001
		[Token(Token = "0x4004E21")]
		[FieldOffset(Offset = "0x40")]
		public static float _tempSandstormSeverity;

		// Token: 0x04004E22 RID: 20002
		[Token(Token = "0x4004E22")]
		[FieldOffset(Offset = "0x44")]
		public static float _tempSandstormIntendedSeverity;

		// Token: 0x04004E23 RID: 20003
		[Token(Token = "0x4004E23")]
		[FieldOffset(Offset = "0x48")]
		public static bool _tempLanternNightGenuine;

		// Token: 0x04004E24 RID: 20004
		[Token(Token = "0x4004E24")]
		[FieldOffset(Offset = "0x49")]
		public static bool _tempLanternNightManual;

		// Token: 0x04004E25 RID: 20005
		[Token(Token = "0x4004E25")]
		[FieldOffset(Offset = "0x4A")]
		public static bool _tempLanternNightNextNightIsGenuine;

		// Token: 0x04004E26 RID: 20006
		[Token(Token = "0x4004E26")]
		[FieldOffset(Offset = "0x4C")]
		public static int _tempLanternNightCooldown;

		// Token: 0x04004E27 RID: 20007
		[Token(Token = "0x4004E27")]
		[FieldOffset(Offset = "0x50")]
		public static int _tempCoinRain;

		// Token: 0x04004E28 RID: 20008
		[Token(Token = "0x4004E28")]
		[FieldOffset(Offset = "0x54")]
		public static int _tempMeteorShowerCount;

		// Token: 0x04004E29 RID: 20009
		[Token(Token = "0x4004E29")]
		[FieldOffset(Offset = "0x58")]
		public static Exception LastThrownLoadException;

		// Token: 0x04004E2A RID: 20010
		[Token(Token = "0x4004E2A")]
		[FieldOffset(Offset = "0x5C")]
		private static byte[] TutorialWorldData;

		// Token: 0x04004E2B RID: 20011
		[Token(Token = "0x4004E2B")]
		[FieldOffset(Offset = "0x60")]
		public static bool LoadInputWorld;

		// Token: 0x04004E2C RID: 20012
		[Token(Token = "0x4004E2C")]
		[FieldOffset(Offset = "0x61")]
		private static bool PendingSaveAndExit;

		// Token: 0x04004E2D RID: 20013
		[Token(Token = "0x4004E2D")]
		[FieldOffset(Offset = "0x62")]
		public static bool SavingWorld;

		// Token: 0x04004E2E RID: 20014
		[Token(Token = "0x4004E2E")]
		private const int VersionNumberForChestRework = 294;

		// Token: 0x04004E2F RID: 20015
		[Token(Token = "0x4004E2F")]
		[FieldOffset(Offset = "0x63")]
		public static bool RequireConvertOldTileEntities;

		// Token: 0x04004E30 RID: 20016
		[Token(Token = "0x4004E30")]
		[FieldOffset(Offset = "0x64")]
		public static bool RequireClearTempTiles;

		// Token: 0x0200068B RID: 1675
		[Token(Token = "0x200068B")]
		public enum WorldSaveContext
		{
			// Token: 0x04004E32 RID: 20018
			[Token(Token = "0x4004E32")]
			Normal,
			// Token: 0x04004E33 RID: 20019
			[Token(Token = "0x4004E33")]
			SaveAndExit
		}

		// Token: 0x0200068C RID: 1676
		[Token(Token = "0x200068C")]
		public static class TilePacker
		{
			// Token: 0x04004E34 RID: 20020
			[Token(Token = "0x4004E34")]
			public const int Header1_1 = 1;

			// Token: 0x04004E35 RID: 20021
			[Token(Token = "0x4004E35")]
			public const int Header1_2 = 2;

			// Token: 0x04004E36 RID: 20022
			[Token(Token = "0x4004E36")]
			public const int Header1_4 = 4;

			// Token: 0x04004E37 RID: 20023
			[Token(Token = "0x4004E37")]
			public const int Header1_8 = 8;

			// Token: 0x04004E38 RID: 20024
			[Token(Token = "0x4004E38")]
			public const int Header1_10 = 16;

			// Token: 0x04004E39 RID: 20025
			[Token(Token = "0x4004E39")]
			public const int Header1_18 = 24;

			// Token: 0x04004E3A RID: 20026
			[Token(Token = "0x4004E3A")]
			public const int Header1_20 = 32;

			// Token: 0x04004E3B RID: 20027
			[Token(Token = "0x4004E3B")]
			public const int Header1_40 = 64;

			// Token: 0x04004E3C RID: 20028
			[Token(Token = "0x4004E3C")]
			public const int Header1_80 = 128;

			// Token: 0x04004E3D RID: 20029
			[Token(Token = "0x4004E3D")]
			public const int Header1_C0 = 192;

			// Token: 0x04004E3E RID: 20030
			[Token(Token = "0x4004E3E")]
			public const int Header2_1 = 1;

			// Token: 0x04004E3F RID: 20031
			[Token(Token = "0x4004E3F")]
			public const int Header2_2 = 2;

			// Token: 0x04004E40 RID: 20032
			[Token(Token = "0x4004E40")]
			public const int Header2_4 = 4;

			// Token: 0x04004E41 RID: 20033
			[Token(Token = "0x4004E41")]
			public const int Header2_8 = 8;

			// Token: 0x04004E42 RID: 20034
			[Token(Token = "0x4004E42")]
			public const int Header2_10 = 16;

			// Token: 0x04004E43 RID: 20035
			[Token(Token = "0x4004E43")]
			public const int Header2_20 = 32;

			// Token: 0x04004E44 RID: 20036
			[Token(Token = "0x4004E44")]
			public const int Header2_40 = 64;

			// Token: 0x04004E45 RID: 20037
			[Token(Token = "0x4004E45")]
			public const int Header2_70 = 112;

			// Token: 0x04004E46 RID: 20038
			[Token(Token = "0x4004E46")]
			public const int Header2_80 = 128;

			// Token: 0x04004E47 RID: 20039
			[Token(Token = "0x4004E47")]
			public const int Header3_1 = 1;

			// Token: 0x04004E48 RID: 20040
			[Token(Token = "0x4004E48")]
			public const int Header3_2 = 2;

			// Token: 0x04004E49 RID: 20041
			[Token(Token = "0x4004E49")]
			public const int Header3_4 = 4;

			// Token: 0x04004E4A RID: 20042
			[Token(Token = "0x4004E4A")]
			public const int Header3_8 = 8;

			// Token: 0x04004E4B RID: 20043
			[Token(Token = "0x4004E4B")]
			public const int Header3_10 = 16;

			// Token: 0x04004E4C RID: 20044
			[Token(Token = "0x4004E4C")]
			public const int Header3_20 = 32;

			// Token: 0x04004E4D RID: 20045
			[Token(Token = "0x4004E4D")]
			public const int Header3_40 = 64;

			// Token: 0x04004E4E RID: 20046
			[Token(Token = "0x4004E4E")]
			public const int Header3_80 = 128;

			// Token: 0x04004E4F RID: 20047
			[Token(Token = "0x4004E4F")]
			public const int Header4_1 = 1;

			// Token: 0x04004E50 RID: 20048
			[Token(Token = "0x4004E50")]
			public const int Header4_2 = 2;

			// Token: 0x04004E51 RID: 20049
			[Token(Token = "0x4004E51")]
			public const int Header4_4 = 4;

			// Token: 0x04004E52 RID: 20050
			[Token(Token = "0x4004E52")]
			public const int Header4_8 = 8;

			// Token: 0x04004E53 RID: 20051
			[Token(Token = "0x4004E53")]
			public const int Header4_10 = 16;

			// Token: 0x04004E54 RID: 20052
			[Token(Token = "0x4004E54")]
			public const int Header4_20 = 32;

			// Token: 0x04004E55 RID: 20053
			[Token(Token = "0x4004E55")]
			public const int Header4_40 = 64;

			// Token: 0x04004E56 RID: 20054
			[Token(Token = "0x4004E56")]
			public const int Header4_80 = 128;
		}
	}
}
