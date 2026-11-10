using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005C7 RID: 1479
	[Token(Token = "0x20005C7")]
	public static class CrashDump
	{
		// Token: 0x06003B8F RID: 15247 RVA: 0x0001E048 File Offset: 0x0001C248
		[Token(Token = "0x6003B8F")]
		[Address(RVA = "0x1E11AF8", Offset = "0x1E11AF8", VA = "0x1E11AF8")]
		public static bool WriteException(CrashDump.Options options, string outputDirectory = ".")
		{
			return default(bool);
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x0001E060 File Offset: 0x0001C260
		[Token(Token = "0x6003B90")]
		[Address(RVA = "0x1E11B08", Offset = "0x1E11B08", VA = "0x1E11B08")]
		public static bool Write(CrashDump.Options options, string outputDirectory = ".")
		{
			return default(bool);
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B91")]
		[Address(RVA = "0x1E11B10", Offset = "0x1E11B10", VA = "0x1E11B10")]
		private static string CreateDumpName()
		{
			return null;
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x0001E078 File Offset: 0x0001C278
		[Token(Token = "0x6003B92")]
		[Address(RVA = "0x1E11B00", Offset = "0x1E11B00", VA = "0x1E11B00")]
		private static bool Write(CrashDump.Options options, CrashDump.ExceptionInfo exceptionInfo, string outputDirectory)
		{
			return default(bool);
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x0001E090 File Offset: 0x0001C290
		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x1E11E68", Offset = "0x1E11E68", VA = "0x1E11E68")]
		private static bool Write(SafeHandle fileHandle, CrashDump.Options options, CrashDump.ExceptionInfo exceptionInfo)
		{
			return default(bool);
		}

		// Token: 0x020005C8 RID: 1480
		[Token(Token = "0x20005C8")]
		public enum Options : uint
		{
			// Token: 0x04004734 RID: 18228
			[Token(Token = "0x4004734")]
			Normal,
			// Token: 0x04004735 RID: 18229
			[Token(Token = "0x4004735")]
			WithDataSegs,
			// Token: 0x04004736 RID: 18230
			[Token(Token = "0x4004736")]
			WithFullMemory,
			// Token: 0x04004737 RID: 18231
			[Token(Token = "0x4004737")]
			WithHandleData = 4U,
			// Token: 0x04004738 RID: 18232
			[Token(Token = "0x4004738")]
			FilterMemory = 8U,
			// Token: 0x04004739 RID: 18233
			[Token(Token = "0x4004739")]
			ScanMemory = 16U,
			// Token: 0x0400473A RID: 18234
			[Token(Token = "0x400473A")]
			WithUnloadedModules = 32U,
			// Token: 0x0400473B RID: 18235
			[Token(Token = "0x400473B")]
			WithIndirectlyReferencedMemory = 64U,
			// Token: 0x0400473C RID: 18236
			[Token(Token = "0x400473C")]
			FilterModulePaths = 128U,
			// Token: 0x0400473D RID: 18237
			[Token(Token = "0x400473D")]
			WithProcessThreadData = 256U,
			// Token: 0x0400473E RID: 18238
			[Token(Token = "0x400473E")]
			WithPrivateReadWriteMemory = 512U,
			// Token: 0x0400473F RID: 18239
			[Token(Token = "0x400473F")]
			WithoutOptionalData = 1024U,
			// Token: 0x04004740 RID: 18240
			[Token(Token = "0x4004740")]
			WithFullMemoryInfo = 2048U,
			// Token: 0x04004741 RID: 18241
			[Token(Token = "0x4004741")]
			WithThreadInfo = 4096U,
			// Token: 0x04004742 RID: 18242
			[Token(Token = "0x4004742")]
			WithCodeSegs = 8192U,
			// Token: 0x04004743 RID: 18243
			[Token(Token = "0x4004743")]
			WithoutAuxiliaryState = 16384U,
			// Token: 0x04004744 RID: 18244
			[Token(Token = "0x4004744")]
			WithFullAuxiliaryState = 32768U,
			// Token: 0x04004745 RID: 18245
			[Token(Token = "0x4004745")]
			WithPrivateWriteCopyMemory = 65536U,
			// Token: 0x04004746 RID: 18246
			[Token(Token = "0x4004746")]
			IgnoreInaccessibleMemory = 131072U,
			// Token: 0x04004747 RID: 18247
			[Token(Token = "0x4004747")]
			ValidTypeFlags = 262143U
		}

		// Token: 0x020005C9 RID: 1481
		[Token(Token = "0x20005C9")]
		private enum ExceptionInfo
		{
			// Token: 0x04004749 RID: 18249
			[Token(Token = "0x4004749")]
			None,
			// Token: 0x0400474A RID: 18250
			[Token(Token = "0x400474A")]
			Present
		}

		// Token: 0x020005CA RID: 1482
		[Token(Token = "0x20005CA")]
		private struct MiniDumpExceptionInformation
		{
			// Token: 0x0400474B RID: 18251
			[Token(Token = "0x400474B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint ThreadId;

			// Token: 0x0400474C RID: 18252
			[Token(Token = "0x400474C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public IntPtr ExceptionPointers;

			// Token: 0x0400474D RID: 18253
			[Token(Token = "0x400474D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool ClientPointers;
		}
	}
}
