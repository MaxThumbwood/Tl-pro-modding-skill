using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Ionic.Zlib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Map
{
	// Token: 0x02000809 RID: 2057
	[Token(Token = "0x2000809")]
	public static class MapHelper
	{
		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700086E")]
		private static object IOLock
		{
			[Token(Token = "0x6004675")]
			[Address(RVA = "0x5901B0", Offset = "0x5901B0", VA = "0x5901B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x000215A0 File Offset: 0x0001F7A0
		// (set) Token: 0x06004677 RID: 18039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086F")]
		public static Rectangle sceneArea
		{
			[Token(Token = "0x6004676")]
			[Address(RVA = "0x590218", Offset = "0x590218", VA = "0x590218")]
			get
			{
				return default(Rectangle);
			}
			[Token(Token = "0x6004677")]
			[Address(RVA = "0x590284", Offset = "0x590284", VA = "0x590284")]
			set
			{
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06004678 RID: 18040 RVA: 0x000215B8 File Offset: 0x0001F7B8
		// (set) Token: 0x06004679 RID: 18041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000870")]
		public static float sceneSnowiness
		{
			[Token(Token = "0x6004678")]
			[Address(RVA = "0x590300", Offset = "0x590300", VA = "0x590300")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004679")]
			[Address(RVA = "0x590368", Offset = "0x590368", VA = "0x590368")]
			set
			{
			}
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467A")]
		[Address(RVA = "0x56D8C4", Offset = "0x56D8C4", VA = "0x56D8C4")]
		public static void Initialize()
		{
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x000215D0 File Offset: 0x0001F7D0
		[Token(Token = "0x600467B")]
		[Address(RVA = "0x5903D8", Offset = "0x5903D8", VA = "0x5903D8")]
		public static Color MultiplyMapColor(Color color, float multiplier)
		{
			return default(Color);
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467C")]
		[Address(RVA = "0x590454", Offset = "0x590454", VA = "0x590454")]
		public static void ResetMapData()
		{
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x000215E8 File Offset: 0x0001F7E8
		[Token(Token = "0x600467D")]
		[Address(RVA = "0x5904BC", Offset = "0x5904BC", VA = "0x5904BC")]
		public static bool HasOption(int tileType, int option)
		{
			return default(bool);
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x00021600 File Offset: 0x0001F800
		[Token(Token = "0x600467E")]
		[Address(RVA = "0x590548", Offset = "0x590548", VA = "0x590548")]
		public static int TileToLookup(int tileType, int option)
		{
			return 0;
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x00021618 File Offset: 0x0001F818
		[Token(Token = "0x600467F")]
		[Address(RVA = "0x5905CC", Offset = "0x5905CC", VA = "0x5905CC")]
		public static int LookupCount()
		{
			return 0;
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004680")]
		[Address(RVA = "0x590648", Offset = "0x590648", VA = "0x590648")]
		public static void CaptureSceneState(SceneMetrics metrics)
		{
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004681")]
		[Address(RVA = "0x590830", Offset = "0x590830", VA = "0x590830")]
		public static void MapColor(ushort type, ref Color oldColor, byte colorType)
		{
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x00021630 File Offset: 0x0001F830
		[Token(Token = "0x6004682")]
		[Address(RVA = "0x590ABC", Offset = "0x590ABC", VA = "0x590ABC")]
		public static Color GetMapTileXnaColor(ref MapTile tile)
		{
			return default(Color);
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x00021648 File Offset: 0x0001F848
		[Token(Token = "0x6004683")]
		[Address(RVA = "0x590C88", Offset = "0x590C88", VA = "0x590C88")]
		public static MapTile CreateMapTile(int i, int j, byte Light)
		{
			return default(MapTile);
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004684")]
		[Address(RVA = "0x591F4C", Offset = "0x591F4C", VA = "0x591F4C")]
		public static void GetTileBaseOption(int x, int y, int tileType, Tile tileCache, ref int baseOption)
		{
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004685")]
		[Address(RVA = "0x595858", Offset = "0x595858", VA = "0x595858")]
		public static void GetTileBaseOption(int x, int y, ushort tileType, int frameX, int frameY, ref int baseOption)
		{
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004686")]
		[Address(RVA = "0x59689C", Offset = "0x59689C", VA = "0x59689C")]
		public static void SaveMap(bool forceSave = false)
		{
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004687")]
		[Address(RVA = "0x596D98", Offset = "0x596D98", VA = "0x596D98")]
		private static void InternalSaveMapCompressed()
		{
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004688")]
		[Address(RVA = "0x598240", Offset = "0x598240", VA = "0x598240")]
		private static void InternalSaveMap()
		{
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004689")]
		[Address(RVA = "0x599F20", Offset = "0x599F20", VA = "0x599F20")]
		private static void LoadMapHeader(BinaryReader fileIO)
		{
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468A")]
		[Address(RVA = "0x59A114", Offset = "0x59A114", VA = "0x59A114")]
		private static void ReadRunLengthEncodingData(MapHelper.RunLengthEncodingCompressionProfile compressionProfile, DeflateStream deflateStream, Action<int, int, uint> dataRead)
		{
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468B")]
		[Address(RVA = "0x59A4C8", Offset = "0x59A4C8", VA = "0x59A4C8")]
		public static void LoadMapWithUltraCompression(MemoryStream wholeStream, bool isLocalMap)
		{
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468C")]
		[Address(RVA = "0x59A9E0", Offset = "0x59A9E0", VA = "0x59A9E0")]
		public static void LoadMapVersion1(BinaryReader fileIO, int release)
		{
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468D")]
		[Address(RVA = "0x59B694", Offset = "0x59B694", VA = "0x59B694")]
		public static void LoadMapVersion2(BinaryReader fileIO, int release)
		{
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468E")]
		[Address(RVA = "0x59CA2C", Offset = "0x59CA2C", VA = "0x59CA2C")]
		public static void LoadMapVersionCompressed(BinaryReader fileIO, int release)
		{
		}

		// Token: 0x04008D56 RID: 36182
		[Token(Token = "0x4008D56")]
		[FieldOffset(Offset = "0x0")]
		public static int maxUpdateTile;

		// Token: 0x04008D57 RID: 36183
		[Token(Token = "0x4008D57")]
		[FieldOffset(Offset = "0x4")]
		public static int numUpdateTile;

		// Token: 0x04008D58 RID: 36184
		[Token(Token = "0x4008D58")]
		[FieldOffset(Offset = "0x8")]
		public static short[] updateTileX;

		// Token: 0x04008D59 RID: 36185
		[Token(Token = "0x4008D59")]
		[FieldOffset(Offset = "0xC")]
		public static short[] updateTileY;

		// Token: 0x04008D5A RID: 36186
		[Token(Token = "0x4008D5A")]
		[FieldOffset(Offset = "0x10")]
		public static bool noStatusText;

		// Token: 0x04008D5B RID: 36187
		[Token(Token = "0x4008D5B")]
		public const int drawLoopMilliseconds = 5;

		// Token: 0x04008D5C RID: 36188
		[Token(Token = "0x4008D5C")]
		public const int drawMapLoadingLoopMilliseconds = 30;

		// Token: 0x04008D5D RID: 36189
		[Token(Token = "0x4008D5D")]
		private const int HeaderEmpty = 0;

		// Token: 0x04008D5E RID: 36190
		[Token(Token = "0x4008D5E")]
		private const int HeaderTile = 1;

		// Token: 0x04008D5F RID: 36191
		[Token(Token = "0x4008D5F")]
		private const int HeaderWall = 2;

		// Token: 0x04008D60 RID: 36192
		[Token(Token = "0x4008D60")]
		private const int HeaderWater = 3;

		// Token: 0x04008D61 RID: 36193
		[Token(Token = "0x4008D61")]
		private const int HeaderLava = 4;

		// Token: 0x04008D62 RID: 36194
		[Token(Token = "0x4008D62")]
		private const int HeaderHoney = 5;

		// Token: 0x04008D63 RID: 36195
		[Token(Token = "0x4008D63")]
		private const int HeaderHeavenAndHell = 6;

		// Token: 0x04008D64 RID: 36196
		[Token(Token = "0x4008D64")]
		private const int HeaderBackground = 7;

		// Token: 0x04008D65 RID: 36197
		[Token(Token = "0x4008D65")]
		private const int Header2_ReadHeader3Bit = 1;

		// Token: 0x04008D66 RID: 36198
		[Token(Token = "0x4008D66")]
		private const int Header2Color1 = 2;

		// Token: 0x04008D67 RID: 36199
		[Token(Token = "0x4008D67")]
		private const int Header2Color2 = 4;

		// Token: 0x04008D68 RID: 36200
		[Token(Token = "0x4008D68")]
		private const int Header2Color3 = 8;

		// Token: 0x04008D69 RID: 36201
		[Token(Token = "0x4008D69")]
		private const int Header2Color4 = 16;

		// Token: 0x04008D6A RID: 36202
		[Token(Token = "0x4008D6A")]
		private const int Header2Color5 = 32;

		// Token: 0x04008D6B RID: 36203
		[Token(Token = "0x4008D6B")]
		private const int Header2ShimmerBit = 64;

		// Token: 0x04008D6C RID: 36204
		[Token(Token = "0x4008D6C")]
		private const int Header2_UnusedBit8 = 128;

		// Token: 0x04008D6D RID: 36205
		[Token(Token = "0x4008D6D")]
		private const int Header3_ReservedForHeader4Bit = 1;

		// Token: 0x04008D6E RID: 36206
		[Token(Token = "0x4008D6E")]
		private const int Header3_UnusudBit2 = 2;

		// Token: 0x04008D6F RID: 36207
		[Token(Token = "0x4008D6F")]
		private const int Header3_UnusudBit3 = 4;

		// Token: 0x04008D70 RID: 36208
		[Token(Token = "0x4008D70")]
		private const int Header3_UnusudBit4 = 8;

		// Token: 0x04008D71 RID: 36209
		[Token(Token = "0x4008D71")]
		private const int Header3_UnusudBit5 = 16;

		// Token: 0x04008D72 RID: 36210
		[Token(Token = "0x4008D72")]
		private const int Header3_UnusudBit6 = 32;

		// Token: 0x04008D73 RID: 36211
		[Token(Token = "0x4008D73")]
		private const int Header3_UnusudBit7 = 64;

		// Token: 0x04008D74 RID: 36212
		[Token(Token = "0x4008D74")]
		private const int Header3_UnusudBit8 = 128;

		// Token: 0x04008D75 RID: 36213
		[Token(Token = "0x4008D75")]
		public const int maxTileOptions = 13;

		// Token: 0x04008D76 RID: 36214
		[Token(Token = "0x4008D76")]
		public const int maxWallOptions = 2;

		// Token: 0x04008D77 RID: 36215
		[Token(Token = "0x4008D77")]
		public const int maxLiquidTypes = 4;

		// Token: 0x04008D78 RID: 36216
		[Token(Token = "0x4008D78")]
		public const int maxSkyGradients = 256;

		// Token: 0x04008D79 RID: 36217
		[Token(Token = "0x4008D79")]
		public const int maxDirtGradients = 256;

		// Token: 0x04008D7A RID: 36218
		[Token(Token = "0x4008D7A")]
		public const int maxRockGradients = 256;

		// Token: 0x04008D7B RID: 36219
		[Token(Token = "0x4008D7B")]
		[FieldOffset(Offset = "0x14")]
		public static int[] tileOptionCounts;

		// Token: 0x04008D7C RID: 36220
		[Token(Token = "0x4008D7C")]
		[FieldOffset(Offset = "0x18")]
		public static int[] wallOptionCounts;

		// Token: 0x04008D7D RID: 36221
		[Token(Token = "0x4008D7D")]
		[FieldOffset(Offset = "0x1C")]
		public static ushort[] tileLookup;

		// Token: 0x04008D7E RID: 36222
		[Token(Token = "0x4008D7E")]
		[FieldOffset(Offset = "0x20")]
		public static ushort[] wallLookup;

		// Token: 0x04008D7F RID: 36223
		[Token(Token = "0x4008D7F")]
		[FieldOffset(Offset = "0x24")]
		private static ushort tilePosition;

		// Token: 0x04008D80 RID: 36224
		[Token(Token = "0x4008D80")]
		[FieldOffset(Offset = "0x26")]
		public static ushort wallPosition;

		// Token: 0x04008D81 RID: 36225
		[Token(Token = "0x4008D81")]
		[FieldOffset(Offset = "0x28")]
		public static ushort liquidPosition;

		// Token: 0x04008D82 RID: 36226
		[Token(Token = "0x4008D82")]
		[FieldOffset(Offset = "0x2A")]
		public static ushort skyPosition;

		// Token: 0x04008D83 RID: 36227
		[Token(Token = "0x4008D83")]
		[FieldOffset(Offset = "0x2C")]
		public static ushort dirtPosition;

		// Token: 0x04008D84 RID: 36228
		[Token(Token = "0x4008D84")]
		[FieldOffset(Offset = "0x2E")]
		public static ushort rockPosition;

		// Token: 0x04008D85 RID: 36229
		[Token(Token = "0x4008D85")]
		[FieldOffset(Offset = "0x30")]
		public static ushort hellPosition;

		// Token: 0x04008D86 RID: 36230
		[Token(Token = "0x4008D86")]
		[FieldOffset(Offset = "0x34")]
		public static Color[] colorLookup;

		// Token: 0x04008D87 RID: 36231
		[Token(Token = "0x4008D87")]
		[FieldOffset(Offset = "0x38")]
		public static Dictionary<ushort, bool> snowLookup;

		// Token: 0x04008D88 RID: 36232
		[Token(Token = "0x4008D88")]
		[FieldOffset(Offset = "0x3C")]
		private static ushort wallRangeStart;

		// Token: 0x04008D89 RID: 36233
		[Token(Token = "0x4008D89")]
		[FieldOffset(Offset = "0x3E")]
		private static ushort wallRangeEnd;

		// Token: 0x0200080A RID: 2058
		[Token(Token = "0x200080A")]
		private class RunLengthEncodingCompressionProfile
		{
			// Token: 0x06004690 RID: 18064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004690")]
			[Address(RVA = "0x59DBE8", Offset = "0x59DBE8", VA = "0x59DBE8")]
			public RunLengthEncodingCompressionProfile(uint numBitsPerValue, uint bitCountForRunLengths)
			{
			}

			// Token: 0x04008D8A RID: 36234
			[Token(Token = "0x4008D8A")]
			[FieldOffset(Offset = "0x8")]
			public readonly uint BitCountPerValue;

			// Token: 0x04008D8B RID: 36235
			[Token(Token = "0x4008D8B")]
			[FieldOffset(Offset = "0xC")]
			public readonly uint BitCountForRunLengths;

			// Token: 0x04008D8C RID: 36236
			[Token(Token = "0x4008D8C")]
			[FieldOffset(Offset = "0x10")]
			public readonly uint MinRepeatsToUseRunLengthEncoding;

			// Token: 0x04008D8D RID: 36237
			[Token(Token = "0x4008D8D")]
			[FieldOffset(Offset = "0x14")]
			public readonly uint MaxCompressedValue;

			// Token: 0x04008D8E RID: 36238
			[Token(Token = "0x4008D8E")]
			[FieldOffset(Offset = "0x18")]
			public readonly uint MaxRunLengthRepeatValue;
		}

		// Token: 0x0200080B RID: 2059
		[Token(Token = "0x200080B")]
		private struct OldMapHelper
		{
			// Token: 0x06004691 RID: 18065 RVA: 0x00021660 File Offset: 0x0001F860
			[Token(Token = "0x6004691")]
			[Address(RVA = "0x59DD1C", Offset = "0x59DD1C", VA = "0x59DD1C")]
			public bool active()
			{
				return default(bool);
			}

			// Token: 0x06004692 RID: 18066 RVA: 0x00021678 File Offset: 0x0001F878
			[Token(Token = "0x6004692")]
			[Address(RVA = "0x59DD28", Offset = "0x59DD28", VA = "0x59DD28")]
			public bool water()
			{
				return default(bool);
			}

			// Token: 0x06004693 RID: 18067 RVA: 0x00021690 File Offset: 0x0001F890
			[Token(Token = "0x6004693")]
			[Address(RVA = "0x59DD34", Offset = "0x59DD34", VA = "0x59DD34")]
			public bool lava()
			{
				return default(bool);
			}

			// Token: 0x06004694 RID: 18068 RVA: 0x000216A8 File Offset: 0x0001F8A8
			[Token(Token = "0x6004694")]
			[Address(RVA = "0x59DD40", Offset = "0x59DD40", VA = "0x59DD40")]
			public bool honey()
			{
				return default(bool);
			}

			// Token: 0x06004695 RID: 18069 RVA: 0x000216C0 File Offset: 0x0001F8C0
			[Token(Token = "0x6004695")]
			[Address(RVA = "0x59DD4C", Offset = "0x59DD4C", VA = "0x59DD4C")]
			public bool changed()
			{
				return default(bool);
			}

			// Token: 0x06004696 RID: 18070 RVA: 0x000216D8 File Offset: 0x0001F8D8
			[Token(Token = "0x6004696")]
			[Address(RVA = "0x59DD58", Offset = "0x59DD58", VA = "0x59DD58")]
			public bool wall()
			{
				return default(bool);
			}

			// Token: 0x06004697 RID: 18071 RVA: 0x000216F0 File Offset: 0x0001F8F0
			[Token(Token = "0x6004697")]
			[Address(RVA = "0x59DD64", Offset = "0x59DD64", VA = "0x59DD64")]
			public byte option()
			{
				return 0;
			}

			// Token: 0x06004698 RID: 18072 RVA: 0x00021708 File Offset: 0x0001F908
			[Token(Token = "0x6004698")]
			[Address(RVA = "0x59DD88", Offset = "0x59DD88", VA = "0x59DD88")]
			public byte color()
			{
				return 0;
			}

			// Token: 0x04008D8F RID: 36239
			[Token(Token = "0x4008D8F")]
			[FieldOffset(Offset = "0x0")]
			public byte misc;

			// Token: 0x04008D90 RID: 36240
			[Token(Token = "0x4008D90")]
			[FieldOffset(Offset = "0x1")]
			public byte misc2;
		}

		// Token: 0x0200080C RID: 2060
		[Token(Token = "0x200080C")]
		public class BitReader
		{
			// Token: 0x06004699 RID: 18073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004699")]
			[Address(RVA = "0x59DD94", Offset = "0x59DD94", VA = "0x59DD94")]
			public BitReader(Stream input)
			{
			}

			// Token: 0x0600469A RID: 18074 RVA: 0x00021720 File Offset: 0x0001F920
			[Token(Token = "0x600469A")]
			[Address(RVA = "0x59DDB8", Offset = "0x59DDB8", VA = "0x59DDB8")]
			public uint Read(uint bitCount)
			{
				return 0U;
			}

			// Token: 0x04008D91 RID: 36241
			[Token(Token = "0x4008D91")]
			[FieldOffset(Offset = "0x8")]
			private readonly Stream InnerStream;

			// Token: 0x04008D92 RID: 36242
			[Token(Token = "0x4008D92")]
			[FieldOffset(Offset = "0xC")]
			private byte CurByteOfData;

			// Token: 0x04008D93 RID: 36243
			[Token(Token = "0x4008D93")]
			[FieldOffset(Offset = "0x10")]
			private uint CurBit;
		}

		// Token: 0x0200080D RID: 2061
		[Token(Token = "0x200080D")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x0600469B RID: 18075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600469B")]
			[Address(RVA = "0x59DF30", Offset = "0x59DF30", VA = "0x59DF30")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x0600469C RID: 18076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600469C")]
			[Address(RVA = "0x59DF38", Offset = "0x59DF38", VA = "0x59DF38")]
			internal void <LoadMapWithUltraCompression>b__0(int x, int y, uint compressedLightValue)
			{
			}

			// Token: 0x04008D94 RID: 36244
			[Token(Token = "0x4008D94")]
			[FieldOffset(Offset = "0x8")]
			public MapHelper.RunLengthEncodingCompressionProfile lightCompressionProfile;
		}
	}
}
