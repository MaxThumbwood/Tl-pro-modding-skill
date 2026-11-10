using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Localization;
using Terraria.WorldBuilding;

namespace Terraria.IO
{
	// Token: 0x0200068D RID: 1677
	[Token(Token = "0x200068D")]
	public class WorldFileData : FileData
	{
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000803")]
		public string SeedText
		{
			[Token(Token = "0x6004071")]
			[Address(RVA = "0x1EBDDC4", Offset = "0x1EBDDC4", VA = "0x1EBDDC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06004072 RID: 16498 RVA: 0x0001FB48 File Offset: 0x0001DD48
		[Token(Token = "0x17000804")]
		public int Seed
		{
			[Token(Token = "0x6004072")]
			[Address(RVA = "0x1EBDDCC", Offset = "0x1EBDDCC", VA = "0x1EBDDCC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06004073 RID: 16499 RVA: 0x0001FB60 File Offset: 0x0001DD60
		[Token(Token = "0x17000805")]
		public bool IsValid
		{
			[Token(Token = "0x6004073")]
			[Address(RVA = "0x1EBDDD4", Offset = "0x1EBDDD4", VA = "0x1EBDDD4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000806")]
		public string WorldSizeName
		{
			[Token(Token = "0x6004074")]
			[Address(RVA = "0x1EBDE4C", Offset = "0x1EBDE4C", VA = "0x1EBDE4C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06004075 RID: 16501 RVA: 0x0001FB78 File Offset: 0x0001DD78
		// (set) Token: 0x06004076 RID: 16502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000807")]
		public bool HasCrimson
		{
			[Token(Token = "0x6004075")]
			[Address(RVA = "0x1EBDE70", Offset = "0x1EBDE70", VA = "0x1EBDE70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004076")]
			[Address(RVA = "0x1EBCFC4", Offset = "0x1EBCFC4", VA = "0x1EBCFC4")]
			set
			{
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06004077 RID: 16503 RVA: 0x0001FB90 File Offset: 0x0001DD90
		[Token(Token = "0x17000808")]
		public bool HasValidSeed
		{
			[Token(Token = "0x6004077")]
			[Address(RVA = "0x1EBDE80", Offset = "0x1EBDE80", VA = "0x1EBDE80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		[Token(Token = "0x17000809")]
		public bool UseGuidAsMapName
		{
			[Token(Token = "0x6004078")]
			[Address(RVA = "0x1EBDE90", Offset = "0x1EBDE90", VA = "0x1EBDE90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06004079 RID: 16505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080A")]
		public string MapFileName
		{
			[Token(Token = "0x6004079")]
			[Address(RVA = "0x1EBDEA8", Offset = "0x1EBDEA8", VA = "0x1EBDEA8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x0001FBC0 File Offset: 0x0001DDC0
		[Token(Token = "0x1700080B")]
		public bool HasWorldBeenPlayedByActivePlayer
		{
			[Token(Token = "0x600407A")]
			[Address(RVA = "0x1EBDED0", Offset = "0x1EBDED0", VA = "0x1EBDED0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407B")]
		[Address(RVA = "0x1EBE00C", Offset = "0x1EBE00C", VA = "0x1EBE00C")]
		public string GetWorldName(bool allowCropping = false)
		{
			return null;
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407C")]
		[Address(RVA = "0x1EBE014", Offset = "0x1EBE014", VA = "0x1EBE014")]
		public string GetFullSeedText(bool allowCropping = false)
		{
			return null;
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		[Token(Token = "0x600407D")]
		[Address(RVA = "0x1EBE370", Offset = "0x1EBE370", VA = "0x1EBE370")]
		public int GetSerializedSeedsSum()
		{
			return 0;
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407E")]
		[Address(RVA = "0x1EBE3E0", Offset = "0x1EBE3E0", VA = "0x1EBE3E0")]
		public List<string> GetSecretSeedCodes()
		{
			return null;
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407F")]
		[Address(RVA = "0x1EBE4CC", Offset = "0x1EBE4CC", VA = "0x1EBE4CC")]
		public static void EnableSeedOptions(int serializedSeedSum)
		{
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		[Token(Token = "0x6004080")]
		[Address(RVA = "0x1EBE5F4", Offset = "0x1EBE5F4", VA = "0x1EBE5F4")]
		public static bool TryApplyingCopiedSeed(string input, bool playSound, out string processedSeed, out string seedTextIncludingSecrets, out List<string> secretSeedTexts)
		{
			return default(bool);
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x0001FC08 File Offset: 0x0001DE08
		[Token(Token = "0x6004081")]
		[Address(RVA = "0x1EBEC78", Offset = "0x1EBEC78", VA = "0x1EBEC78")]
		public static bool TryParseSeedOptionValue(ref string processedSeed, out int value)
		{
			return default(bool);
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x0001FC20 File Offset: 0x0001DE20
		[Token(Token = "0x6004082")]
		[Address(RVA = "0x1EBED2C", Offset = "0x1EBED2C", VA = "0x1EBED2C")]
		public static bool TryParseSecretSeed(ref string processedSeed, out string secretSeedText, out WorldGen.SecretSeed secretSeed)
		{
			return default(bool);
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004083")]
		[Address(RVA = "0x1EBEE44", Offset = "0x1EBEE44", VA = "0x1EBEE44")]
		public WorldFileData()
		{
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004084")]
		[Address(RVA = "0x1EBC6EC", Offset = "0x1EBC6EC", VA = "0x1EBC6EC")]
		public WorldFileData(string path, bool cloudSave)
		{
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x1EBEF08", Offset = "0x1EBEF08", VA = "0x1EBEF08", Slot = "4")]
		public override void SetAsActive()
		{
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x1EBCE08", Offset = "0x1EBCE08", VA = "0x1EBCE08")]
		public void SetWorldSize(int x, int y)
		{
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004087")]
		[Address(RVA = "0x1EBEF9C", Offset = "0x1EBEF9C", VA = "0x1EBEF9C")]
		public static WorldFileData FromInvalidWorld(string path, bool cloudSave, int statusCode, Exception exception)
		{
			return null;
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004088")]
		[Address(RVA = "0x1EBF204", Offset = "0x1EBF204", VA = "0x1EBF204")]
		public void SetSeedToEmpty()
		{
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004089")]
		[Address(RVA = "0x1EBF2B0", Offset = "0x1EBF2B0", VA = "0x1EBF2B0")]
		public void SetSeed(string seedText)
		{
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x0001FC38 File Offset: 0x0001DE38
		[Token(Token = "0x600408A")]
		[Address(RVA = "0x1EBF320", Offset = "0x1EBF320", VA = "0x1EBF320")]
		public static int TranslateSeed(string seedText)
		{
			return 0;
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408B")]
		[Address(RVA = "0x1EBF418", Offset = "0x1EBF418", VA = "0x1EBF418")]
		public void SetSeedToRandom()
		{
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408C")]
		[Address(RVA = "0x1EBF528", Offset = "0x1EBF528", VA = "0x1EBF528")]
		public void SetSeedToRandomWithCurrentEvents()
		{
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408D")]
		[Address(RVA = "0x1EBF674", Offset = "0x1EBF674", VA = "0x1EBF674", Slot = "5")]
		public override void MoveToCloud()
		{
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408E")]
		[Address(RVA = "0x1EBF7B4", Offset = "0x1EBF7B4", VA = "0x1EBF7B4", Slot = "6")]
		public override void MoveToLocal()
		{
		}

		// Token: 0x04004E57 RID: 20055
		[Token(Token = "0x4004E57")]
		[FieldOffset(Offset = "0x20")]
		public int fileReleaseVersion;

		// Token: 0x04004E58 RID: 20056
		[Token(Token = "0x4004E58")]
		[FieldOffset(Offset = "0x24")]
		public int _glitchFrameCounter;

		// Token: 0x04004E59 RID: 20057
		[Token(Token = "0x4004E59")]
		[FieldOffset(Offset = "0x28")]
		public int _glitchFrame;

		// Token: 0x04004E5A RID: 20058
		[Token(Token = "0x4004E5A")]
		[FieldOffset(Offset = "0x2C")]
		public int _glitchVariation;

		// Token: 0x04004E5B RID: 20059
		[Token(Token = "0x4004E5B")]
		[FieldOffset(Offset = "0x30")]
		public int _animatedIcon;

		// Token: 0x04004E5C RID: 20060
		[Token(Token = "0x4004E5C")]
		[FieldOffset(Offset = "0x34")]
		public int _animatedIconFrameCounter;

		// Token: 0x04004E5D RID: 20061
		[Token(Token = "0x4004E5D")]
		private const ulong GUID_IN_WORLD_FILE_VERSION = 777389080577UL;

		// Token: 0x04004E5E RID: 20062
		[Token(Token = "0x4004E5E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MAX_USER_SEED_TEXT_LENGTH;

		// Token: 0x04004E5F RID: 20063
		[Token(Token = "0x4004E5F")]
		[FieldOffset(Offset = "0x38")]
		public bool CurrentSaveFormat;

		// Token: 0x04004E60 RID: 20064
		[Token(Token = "0x4004E60")]
		[FieldOffset(Offset = "0x40")]
		public DateTime CreationTime;

		// Token: 0x04004E61 RID: 20065
		[Token(Token = "0x4004E61")]
		[FieldOffset(Offset = "0x48")]
		public DateTime LastPlayed;

		// Token: 0x04004E62 RID: 20066
		[Token(Token = "0x4004E62")]
		[FieldOffset(Offset = "0x50")]
		public int WorldSizeX;

		// Token: 0x04004E63 RID: 20067
		[Token(Token = "0x4004E63")]
		[FieldOffset(Offset = "0x54")]
		public int WorldSizeY;

		// Token: 0x04004E64 RID: 20068
		[Token(Token = "0x4004E64")]
		[FieldOffset(Offset = "0x58")]
		public ulong WorldGeneratorVersion;

		// Token: 0x04004E65 RID: 20069
		[Token(Token = "0x4004E65")]
		[FieldOffset(Offset = "0x60")]
		private string _seedText;

		// Token: 0x04004E66 RID: 20070
		[Token(Token = "0x4004E66")]
		[FieldOffset(Offset = "0x64")]
		private int _seed;

		// Token: 0x04004E67 RID: 20071
		[Token(Token = "0x4004E67")]
		[FieldOffset(Offset = "0x68")]
		public int LoadStatus;

		// Token: 0x04004E68 RID: 20072
		[Token(Token = "0x4004E68")]
		[FieldOffset(Offset = "0x6C")]
		public Exception LoadException;

		// Token: 0x04004E69 RID: 20073
		[Token(Token = "0x4004E69")]
		[FieldOffset(Offset = "0x70")]
		public Guid UniqueId;

		// Token: 0x04004E6A RID: 20074
		[Token(Token = "0x4004E6A")]
		[FieldOffset(Offset = "0x80")]
		public int WorldId;

		// Token: 0x04004E6B RID: 20075
		[Token(Token = "0x4004E6B")]
		[FieldOffset(Offset = "0x84")]
		public LocalizedText _worldSizeName;

		// Token: 0x04004E6C RID: 20076
		[Token(Token = "0x4004E6C")]
		[FieldOffset(Offset = "0x88")]
		public int GameMode;

		// Token: 0x04004E6D RID: 20077
		[Token(Token = "0x4004E6D")]
		[FieldOffset(Offset = "0x8C")]
		public bool DrunkWorld;

		// Token: 0x04004E6E RID: 20078
		[Token(Token = "0x4004E6E")]
		[FieldOffset(Offset = "0x8D")]
		public bool NotTheBees;

		// Token: 0x04004E6F RID: 20079
		[Token(Token = "0x4004E6F")]
		[FieldOffset(Offset = "0x8E")]
		public bool ForTheWorthy;

		// Token: 0x04004E70 RID: 20080
		[Token(Token = "0x4004E70")]
		[FieldOffset(Offset = "0x8F")]
		public bool Anniversary;

		// Token: 0x04004E71 RID: 20081
		[Token(Token = "0x4004E71")]
		[FieldOffset(Offset = "0x90")]
		public bool DontStarve;

		// Token: 0x04004E72 RID: 20082
		[Token(Token = "0x4004E72")]
		[FieldOffset(Offset = "0x91")]
		public bool RemixWorld;

		// Token: 0x04004E73 RID: 20083
		[Token(Token = "0x4004E73")]
		[FieldOffset(Offset = "0x92")]
		public bool NoTrapsWorld;

		// Token: 0x04004E74 RID: 20084
		[Token(Token = "0x4004E74")]
		[FieldOffset(Offset = "0x93")]
		public bool ZenithWorld;

		// Token: 0x04004E75 RID: 20085
		[Token(Token = "0x4004E75")]
		[FieldOffset(Offset = "0x94")]
		public bool SkyblockWorld;

		// Token: 0x04004E76 RID: 20086
		[Token(Token = "0x4004E76")]
		[FieldOffset(Offset = "0x95")]
		public bool HasCorruption;

		// Token: 0x04004E77 RID: 20087
		[Token(Token = "0x4004E77")]
		[FieldOffset(Offset = "0x96")]
		public bool IsHardMode;

		// Token: 0x04004E78 RID: 20088
		[Token(Token = "0x4004E78")]
		[FieldOffset(Offset = "0x97")]
		public bool DefeatedMoonlord;

		// Token: 0x04004E79 RID: 20089
		[Token(Token = "0x4004E79")]
		[FieldOffset(Offset = "0x98")]
		private PlayerFileData cachedActivePlayer;

		// Token: 0x04004E7A RID: 20090
		[Token(Token = "0x4004E7A")]
		[FieldOffset(Offset = "0x9C")]
		private bool hasWorldBeenPlayedByActivePlayer;

		// Token: 0x04004E7B RID: 20091
		[Token(Token = "0x4004E7B")]
		[FieldOffset(Offset = "0x4")]
		private static List<AWorldGenerationOption> seedOptionsInOrder;
	}
}
