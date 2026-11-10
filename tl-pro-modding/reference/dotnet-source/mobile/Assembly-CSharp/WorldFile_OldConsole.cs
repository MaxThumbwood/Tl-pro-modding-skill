using System;
using System.IO;
using Il2CppDummyDll;
using Terraria;
using Terraria.IO;

// Token: 0x02000343 RID: 835
[Token(Token = "0x2000343")]
internal class WorldFile_OldConsole
{
	// Token: 0x06001472 RID: 5234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001472")]
	[Address(RVA = "0xDC95F4", Offset = "0xDC95F4", VA = "0xDC95F4")]
	public static WorldFileData GetAllMetadata(string file)
	{
		return null;
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001473")]
	[Address(RVA = "0xDCADF4", Offset = "0xDCADF4", VA = "0xDCADF4")]
	public static byte[] DecompressData(byte[] srcData)
	{
		return null;
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x00009048 File Offset: 0x00007248
	[Token(Token = "0x6001474")]
	[Address(RVA = "0xDCB240", Offset = "0xDCB240", VA = "0xDCB240")]
	public static bool LoadSaveData(byte[] srcData)
	{
		return default(bool);
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001475")]
	[Address(RVA = "0xDD0E54", Offset = "0xDD0E54", VA = "0xDD0E54")]
	private static void CleanItemsStoredInTiles()
	{
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001476")]
	[Address(RVA = "0xDD1018", Offset = "0xDD1018", VA = "0xDD1018")]
	private static void CheckWeaponsRack(int i, int j)
	{
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00009060 File Offset: 0x00007260
	[Token(Token = "0x6001477")]
	[Address(RVA = "0xDD238C", Offset = "0xDD238C", VA = "0xDD238C")]
	public static bool ItemFitsWeaponRack(Item i)
	{
		return default(bool);
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001478")]
	[Address(RVA = "0xDD2410", Offset = "0xDD2410", VA = "0xDD2410")]
	public static void PlaceWeapon(int x, int y, Item item)
	{
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001479")]
	[Address(RVA = "0xDD1830", Offset = "0xDD1830", VA = "0xDD1830")]
	private static void CheckMannequin(int i, int j)
	{
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00009078 File Offset: 0x00007278
	[Token(Token = "0x600147A")]
	[Address(RVA = "0xDD087C", Offset = "0xDD087C", VA = "0xDD087C")]
	private static int LoadWorld_Version2(BinaryReader reader)
	{
		return 0;
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147B")]
	[Address(RVA = "0xDD8580", Offset = "0xDD8580", VA = "0xDD8580")]
	private static void LoadWeightedPressurePlates(BinaryReader reader)
	{
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147C")]
	[Address(RVA = "0xDD8750", Offset = "0xDD8750", VA = "0xDD8750")]
	private static void LoadTownManager(BinaryReader reader)
	{
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147D")]
	[Address(RVA = "0xDD7B64", Offset = "0xDD7B64", VA = "0xDD7B64")]
	private static void LoadTileEntities(BinaryReader reader)
	{
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00009090 File Offset: 0x00007290
	[Token(Token = "0x600147E")]
	[Address(RVA = "0xDD2B64", Offset = "0xDD2B64", VA = "0xDD2B64")]
	private static bool LoadFileFormatHeader(BinaryReader reader, out bool[] importance, out int[] positions)
	{
		return default(bool);
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147F")]
	[Address(RVA = "0xDD2EF0", Offset = "0xDD2EF0", VA = "0xDD2EF0")]
	private static void LoadHeader(BinaryReader reader)
	{
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001480")]
	[Address(RVA = "0xDD51A8", Offset = "0xDD51A8", VA = "0xDD51A8")]
	private static void LoadWorldTiles(BinaryReader reader, bool[] importance)
	{
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001481")]
	[Address(RVA = "0xDD6800", Offset = "0xDD6800", VA = "0xDD6800")]
	private static void LoadChests(BinaryReader reader)
	{
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001482")]
	[Address(RVA = "0xDD89DC", Offset = "0xDD89DC", VA = "0xDD89DC")]
	private static void FixDresserChests()
	{
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001483")]
	[Address(RVA = "0xDD7030", Offset = "0xDD7030", VA = "0xDD7030")]
	private static void LoadSigns(BinaryReader reader)
	{
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001484")]
	[Address(RVA = "0xDD7AFC", Offset = "0xDD7AFC", VA = "0xDD7AFC")]
	private static void LoadDummies(BinaryReader reader)
	{
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001485")]
	[Address(RVA = "0xDD76F8", Offset = "0xDD76F8", VA = "0xDD76F8")]
	private static void LoadNPCs(BinaryReader reader)
	{
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x000090A8 File Offset: 0x000072A8
	[Token(Token = "0x6001486")]
	[Address(RVA = "0xDD87D4", Offset = "0xDD87D4", VA = "0xDD87D4")]
	private static int LoadFooter(BinaryReader reader)
	{
		return 0;
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x000090C0 File Offset: 0x000072C0
	[Token(Token = "0x6001487")]
	[Address(RVA = "0xDCB718", Offset = "0xDCB718", VA = "0xDCB718")]
	public static int LoadWorld_Version1(BinaryReader fileIO)
	{
		return 0;
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x000090D8 File Offset: 0x000072D8
	[Token(Token = "0x6001488")]
	[Address(RVA = "0xDD8950", Offset = "0xDD8950", VA = "0xDD8950")]
	private static int ReadItemID(BinaryReader fileIO)
	{
		return 0;
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001489")]
	[Address(RVA = "0xDD8D74", Offset = "0xDD8D74", VA = "0xDD8D74")]
	public WorldFile_OldConsole()
	{
	}

	// Token: 0x0400292F RID: 10543
	[Token(Token = "0x400292F")]
	public const int WorldVersion_AddGUID = 1000;

	// Token: 0x04002930 RID: 10544
	[Token(Token = "0x4002930")]
	public const int WorldVersion_CompressWorld = 1001;

	// Token: 0x04002931 RID: 10545
	[Token(Token = "0x4002931")]
	public const int WorldVersion_StoreFrameAsRowsAndColumnsInsteadOfPixels = 1002;

	// Token: 0x04002932 RID: 10546
	[Token(Token = "0x4002932")]
	public const int WorldVersion_1_3_2 = 1003;

	// Token: 0x04002933 RID: 10547
	[Token(Token = "0x4002933")]
	public const int WorldVersion_1_3_3 = 1004;

	// Token: 0x04002934 RID: 10548
	[Token(Token = "0x4002934")]
	public const int WorldVersion_1_3_4 = 1005;

	// Token: 0x04002935 RID: 10549
	[Token(Token = "0x4002935")]
	public const int WorldVersion_RemapConsoleSpecificItems = 1006;

	// Token: 0x04002936 RID: 10550
	[Token(Token = "0x4002936")]
	public const int WorldVersionOneMaxRelease = 87;

	// Token: 0x04002937 RID: 10551
	[Token(Token = "0x4002937")]
	public const int WorldFileVersion = 1006;

	// Token: 0x04002938 RID: 10552
	[Token(Token = "0x4002938")]
	public const int ApproximateWriteSize = 7000000;

	// Token: 0x04002939 RID: 10553
	[Token(Token = "0x4002939")]
	public const int MaximumWriteSize = 16777216;

	// Token: 0x0400293A RID: 10554
	[Token(Token = "0x400293A")]
	[FieldOffset(Offset = "0x0")]
	private static int versionNumber;
}
