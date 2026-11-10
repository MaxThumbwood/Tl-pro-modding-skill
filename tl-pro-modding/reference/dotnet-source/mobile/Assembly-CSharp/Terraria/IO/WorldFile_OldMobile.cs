using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x02000684 RID: 1668
	[Token(Token = "0x2000684")]
	public class WorldFile_OldMobile
	{
		// Token: 0x06004010 RID: 16400 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		[Token(Token = "0x6004010")]
		[Address(RVA = "0x1EB9CBC", Offset = "0x1EB9CBC", VA = "0x1EB9CBC")]
		public bool LoadSaveData(byte[] srcData)
		{
			return default(bool);
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x0001F800 File Offset: 0x0001DA00
		[Token(Token = "0x6004011")]
		[Address(RVA = "0x1EBA114", Offset = "0x1EBA114", VA = "0x1EBA114")]
		private int loadWorldHeader(BinaryReader fileIO)
		{
			return 0;
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004012")]
		[Address(RVA = "0x1EBB5D8", Offset = "0x1EBB5D8", VA = "0x1EBB5D8")]
		private static void DecryptWorldData(long offset, long encryptedSize)
		{
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004013")]
		[Address(RVA = "0x1EBB7F4", Offset = "0x1EBB7F4", VA = "0x1EBB7F4")]
		private void BadMarker(BinaryReader reader, string marker)
		{
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004014")]
		[Address(RVA = "0x1EBA458", Offset = "0x1EBA458", VA = "0x1EBA458")]
		private void loadWorldData(BinaryReader reader, int release)
		{
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004015")]
		[Address(RVA = "0x1EBBD30", Offset = "0x1EBBD30", VA = "0x1EBBD30")]
		public static byte[] ReadAllBytes(Stream stream)
		{
			return null;
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004016")]
		[Address(RVA = "0x1EBBF3C", Offset = "0x1EBBF3C", VA = "0x1EBBF3C")]
		public static WorldFileData GetAllMetadata(string file, bool cloudSave)
		{
			return null;
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x0001F818 File Offset: 0x0001DA18
		[Token(Token = "0x6004017")]
		[Address(RVA = "0x1EBC828", Offset = "0x1EBC828", VA = "0x1EBC828")]
		private static int loadWorldHeaderMeta(WorldFileData data, BinaryReader fileIO)
		{
			return 0;
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004018")]
		[Address(RVA = "0x1EBC944", Offset = "0x1EBC944", VA = "0x1EBC944")]
		private static void loadWorldDataMeta(WorldFileData data, BinaryReader reader, int release)
		{
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004019")]
		[Address(RVA = "0x1EBCFD0", Offset = "0x1EBCFD0", VA = "0x1EBCFD0")]
		public WorldFile_OldMobile()
		{
		}

		// Token: 0x04004B6F RID: 19311
		[Token(Token = "0x4004B6F")]
		public const int VERSION_49 = 49;

		// Token: 0x04004B70 RID: 19312
		[Token(Token = "0x4004B70")]
		public const int VERSION_50 = 50;

		// Token: 0x04004B71 RID: 19313
		[Token(Token = "0x4004B71")]
		public const int VERSION_51 = 51;

		// Token: 0x04004B72 RID: 19314
		[Token(Token = "0x4004B72")]
		public const int VERSION_52 = 52;

		// Token: 0x04004B73 RID: 19315
		[Token(Token = "0x4004B73")]
		public const int VERSION_53 = 53;

		// Token: 0x04004B74 RID: 19316
		[Token(Token = "0x4004B74")]
		public const int VERSION_54 = 54;

		// Token: 0x04004B75 RID: 19317
		[Token(Token = "0x4004B75")]
		public const int VERSION_55 = 55;

		// Token: 0x04004B76 RID: 19318
		[Token(Token = "0x4004B76")]
		public const int VERSION_56 = 56;

		// Token: 0x04004B77 RID: 19319
		[Token(Token = "0x4004B77")]
		public const int VERSION_57 = 57;

		// Token: 0x04004B78 RID: 19320
		[Token(Token = "0x4004B78")]
		public const int VERSION_58 = 58;

		// Token: 0x04004B79 RID: 19321
		[Token(Token = "0x4004B79")]
		public const int VERSION_59 = 59;

		// Token: 0x04004B7A RID: 19322
		[Token(Token = "0x4004B7A")]
		public const int VERSION_60 = 60;

		// Token: 0x04004B7B RID: 19323
		[Token(Token = "0x4004B7B")]
		public const int VERSION_61 = 61;

		// Token: 0x04004B7C RID: 19324
		[Token(Token = "0x4004B7C")]
		public const int VERSION_62 = 62;

		// Token: 0x04004B7D RID: 19325
		[Token(Token = "0x4004B7D")]
		public const int VERSION_63 = 63;

		// Token: 0x04004B7E RID: 19326
		[Token(Token = "0x4004B7E")]
		public const int VERSION_64 = 64;

		// Token: 0x04004B7F RID: 19327
		[Token(Token = "0x4004B7F")]
		public const int VERSION_65 = 65;

		// Token: 0x04004B80 RID: 19328
		[Token(Token = "0x4004B80")]
		public const int VERSION_66 = 66;

		// Token: 0x04004B81 RID: 19329
		[Token(Token = "0x4004B81")]
		public const int VERSION_67 = 67;

		// Token: 0x04004B82 RID: 19330
		[Token(Token = "0x4004B82")]
		public const int VERSION_68 = 68;

		// Token: 0x04004B83 RID: 19331
		[Token(Token = "0x4004B83")]
		public const int VERSION_69 = 69;

		// Token: 0x04004B84 RID: 19332
		[Token(Token = "0x4004B84")]
		public const int VERSION_70 = 70;

		// Token: 0x04004B85 RID: 19333
		[Token(Token = "0x4004B85")]
		public const int VERSION_71 = 71;

		// Token: 0x04004B86 RID: 19334
		[Token(Token = "0x4004B86")]
		public const int VERSION_72 = 72;

		// Token: 0x04004B87 RID: 19335
		[Token(Token = "0x4004B87")]
		public const int VERSION_73 = 73;

		// Token: 0x04004B88 RID: 19336
		[Token(Token = "0x4004B88")]
		public const int VERSION_CURRENT = 73;

		// Token: 0x04004B89 RID: 19337
		[Token(Token = "0x4004B89")]
		public const int NEW_WORLD_DATA_VERSION = 73;

		// Token: 0x04004B8A RID: 19338
		[Token(Token = "0x4004B8A")]
		[FieldOffset(Offset = "0x8")]
		private bool isCloudSave;

		// Token: 0x04004B8B RID: 19339
		[Token(Token = "0x4004B8B")]
		[FieldOffset(Offset = "0xC")]
		private int worldID;

		// Token: 0x04004B8C RID: 19340
		[Token(Token = "0x4004B8C")]
		[FieldOffset(Offset = "0x10")]
		private int worldTimestamp;

		// Token: 0x04004B8D RID: 19341
		[Token(Token = "0x4004B8D")]
		[FieldOffset(Offset = "0x14")]
		private int hellLayer;

		// Token: 0x04004B8E RID: 19342
		[Token(Token = "0x4004B8E")]
		[FieldOffset(Offset = "0x0")]
		private static Weather_OldMobile weather;

		// Token: 0x04004B8F RID: 19343
		[Token(Token = "0x4004B8F")]
		[FieldOffset(Offset = "0x4")]
		private static NPCInfo_OldMobile npcInfo;

		// Token: 0x04004B90 RID: 19344
		[Token(Token = "0x4004B90")]
		[FieldOffset(Offset = "0x8")]
		private static TimeInfo_OldMobile tempTime;

		// Token: 0x04004B91 RID: 19345
		[Token(Token = "0x4004B91")]
		[FieldOffset(Offset = "0xC")]
		private static FishingInfo_OldMobile fishingInfo;

		// Token: 0x04004B92 RID: 19346
		[Token(Token = "0x4004B92")]
		[FieldOffset(Offset = "0x10")]
		private static RandomStyleInfo_OldMobile tree;

		// Token: 0x04004B93 RID: 19347
		[Token(Token = "0x4004B93")]
		[FieldOffset(Offset = "0x14")]
		private static RandomStyleInfo_OldMobile caveBack;

		// Token: 0x04004B94 RID: 19348
		[Token(Token = "0x4004B94")]
		[FieldOffset(Offset = "0x18")]
		private static TilInfo_OldMobile tileInfo;

		// Token: 0x04004B95 RID: 19349
		[Token(Token = "0x4004B95")]
		[FieldOffset(Offset = "0x1C")]
		private static ChestInfo_OldMobile chestInfo;

		// Token: 0x04004B96 RID: 19350
		[Token(Token = "0x4004B96")]
		[FieldOffset(Offset = "0x20")]
		private static SignInfo_OldMobile signInfo;

		// Token: 0x04004B97 RID: 19351
		[Token(Token = "0x4004B97")]
		[FieldOffset(Offset = "0x24")]
		private static BlowFish worldDecrypter;

		// Token: 0x04004B98 RID: 19352
		[Token(Token = "0x4004B98")]
		[FieldOffset(Offset = "0x28")]
		private static byte[] inputData;

		// Token: 0x04004B99 RID: 19353
		[Token(Token = "0x4004B99")]
		[FieldOffset(Offset = "0x18")]
		private int saveRelease;

		// Token: 0x04004B9A RID: 19354
		[Token(Token = "0x4004B9A")]
		[FieldOffset(Offset = "0x1C")]
		private uint timestamp;

		// Token: 0x04004B9B RID: 19355
		[Token(Token = "0x4004B9B")]
		[FieldOffset(Offset = "0x20")]
		private List<uint> timestamps;
	}
}
