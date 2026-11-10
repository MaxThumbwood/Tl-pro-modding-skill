using System;
using System.IO;
using Il2CppDummyDll;
using Terraria;
using Terraria.IO;

// Token: 0x02000345 RID: 837
[Token(Token = "0x2000345")]
internal class WorldFile_OldSwitch
{
	// Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600148F")]
	[Address(RVA = "0xDDD750", Offset = "0xDDD750", VA = "0xDDD750")]
	public static WorldFileData GetAllMetadata(string file)
	{
		return null;
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001490")]
	[Address(RVA = "0xDDEFDC", Offset = "0xDDEFDC", VA = "0xDDEFDC")]
	public static byte[] DecompressData(byte[] srcData)
	{
		return null;
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x00009120 File Offset: 0x00007320
	[Token(Token = "0x6001491")]
	[Address(RVA = "0xDDF428", Offset = "0xDDF428", VA = "0xDDF428")]
	public static bool LoadSaveData(byte[] srcData)
	{
		return default(bool);
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001492")]
	[Address(RVA = "0xDE4F40", Offset = "0xDE4F40", VA = "0xDE4F40")]
	private static void CleanItemsStoredInTiles()
	{
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001493")]
	[Address(RVA = "0xDE5104", Offset = "0xDE5104", VA = "0xDE5104")]
	private static void CheckWeaponsRack(int i, int j)
	{
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00009138 File Offset: 0x00007338
	[Token(Token = "0x6001494")]
	[Address(RVA = "0xDE61AC", Offset = "0xDE61AC", VA = "0xDE61AC")]
	public static bool ItemFitsWeaponRack(Item i)
	{
		return default(bool);
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001495")]
	[Address(RVA = "0xDE6230", Offset = "0xDE6230", VA = "0xDE6230")]
	public static void PlaceWeapon(int x, int y, Item item)
	{
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001496")]
	[Address(RVA = "0xDE58CC", Offset = "0xDE58CC", VA = "0xDE58CC")]
	private static void CheckMannequin(int i, int j)
	{
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x00009150 File Offset: 0x00007350
	[Token(Token = "0x6001497")]
	[Address(RVA = "0xDE4860", Offset = "0xDE4860", VA = "0xDE4860")]
	private static int LoadWorld_Version2(BinaryReader reader)
	{
		return 0;
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001498")]
	[Address(RVA = "0xDEBCFC", Offset = "0xDEBCFC", VA = "0xDEBCFC")]
	private static void LoadWeightedPressurePlates(BinaryReader reader)
	{
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001499")]
	[Address(RVA = "0xDEBECC", Offset = "0xDEBECC", VA = "0xDEBECC")]
	private static void LoadTownManager(BinaryReader reader)
	{
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149A")]
	[Address(RVA = "0xDEB2E0", Offset = "0xDEB2E0", VA = "0xDEB2E0")]
	private static void LoadTileEntities(BinaryReader reader)
	{
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x00009168 File Offset: 0x00007368
	[Token(Token = "0x600149B")]
	[Address(RVA = "0xDE6984", Offset = "0xDE6984", VA = "0xDE6984")]
	private static bool LoadFileFormatHeader(BinaryReader reader, out bool[] importance, out int[] positions)
	{
		return default(bool);
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149C")]
	[Address(RVA = "0xDE6D10", Offset = "0xDE6D10", VA = "0xDE6D10")]
	private static void LoadHeader(BinaryReader reader)
	{
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149D")]
	[Address(RVA = "0xDE8C90", Offset = "0xDE8C90", VA = "0xDE8C90")]
	private static void LoadWorldTiles(BinaryReader reader, bool[] importance)
	{
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149E")]
	[Address(RVA = "0xDEA084", Offset = "0xDEA084", VA = "0xDEA084")]
	private static void LoadChests(BinaryReader reader)
	{
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149F")]
	[Address(RVA = "0xDEC0F8", Offset = "0xDEC0F8", VA = "0xDEC0F8")]
	private static void FixDresserChests()
	{
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A0")]
	[Address(RVA = "0xDEA7AC", Offset = "0xDEA7AC", VA = "0xDEA7AC")]
	private static void LoadSigns(BinaryReader reader)
	{
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A1")]
	[Address(RVA = "0xDEB278", Offset = "0xDEB278", VA = "0xDEB278")]
	private static void LoadDummies(BinaryReader reader)
	{
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A2")]
	[Address(RVA = "0xDEAE74", Offset = "0xDEAE74", VA = "0xDEAE74")]
	private static void LoadNPCs(BinaryReader reader)
	{
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x00009180 File Offset: 0x00007380
	[Token(Token = "0x60014A3")]
	[Address(RVA = "0xDEBF50", Offset = "0xDEBF50", VA = "0xDEBF50")]
	private static int LoadFooter(BinaryReader reader)
	{
		return 0;
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x00009198 File Offset: 0x00007398
	[Token(Token = "0x60014A4")]
	[Address(RVA = "0xDDF900", Offset = "0xDDF900", VA = "0xDDF900")]
	public static int LoadWorld_Version1(BinaryReader fileIO)
	{
		return 0;
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x000091B0 File Offset: 0x000073B0
	[Token(Token = "0x60014A5")]
	[Address(RVA = "0xDEC0CC", Offset = "0xDEC0CC", VA = "0xDEC0CC")]
	private static int ReadItemID(BinaryReader fileIO)
	{
		return 0;
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A6")]
	[Address(RVA = "0xDEC490", Offset = "0xDEC490", VA = "0xDEC490")]
	public WorldFile_OldSwitch()
	{
	}

	// Token: 0x04002941 RID: 10561
	[Token(Token = "0x4002941")]
	public const int WorldVersion_AddGUID = 1000;

	// Token: 0x04002942 RID: 10562
	[Token(Token = "0x4002942")]
	public const int WorldVersion_CompressWorld = 1001;

	// Token: 0x04002943 RID: 10563
	[Token(Token = "0x4002943")]
	public const int WorldVersion_StoreFrameAsRowsAndColumnsInsteadOfPixels = 1002;

	// Token: 0x04002944 RID: 10564
	[Token(Token = "0x4002944")]
	public const int WorldVersion_RemoveSectionPointers = 1003;

	// Token: 0x04002945 RID: 10565
	[Token(Token = "0x4002945")]
	public const int WorldVersion_1_3_2 = 1004;

	// Token: 0x04002946 RID: 10566
	[Token(Token = "0x4002946")]
	public const int WorldVersion_1_3_3 = 1005;

	// Token: 0x04002947 RID: 10567
	[Token(Token = "0x4002947")]
	public const int WorldVersion_1_3_4 = 1007;

	// Token: 0x04002948 RID: 10568
	[Token(Token = "0x4002948")]
	public const int WorldVersion_RemapConsoleSpecificItems = 1008;

	// Token: 0x04002949 RID: 10569
	[Token(Token = "0x4002949")]
	public const int WorldVersionOneMaxRelease = 87;

	// Token: 0x0400294A RID: 10570
	[Token(Token = "0x400294A")]
	public const int WorldFileVersion = 1008;

	// Token: 0x0400294B RID: 10571
	[Token(Token = "0x400294B")]
	public const int ApproximateWriteSize = 7000000;

	// Token: 0x0400294C RID: 10572
	[Token(Token = "0x400294C")]
	public const int MaximumWriteSize = 16777216;

	// Token: 0x0400294D RID: 10573
	[Token(Token = "0x400294D")]
	[FieldOffset(Offset = "0x0")]
	private static int versionNumber;
}
