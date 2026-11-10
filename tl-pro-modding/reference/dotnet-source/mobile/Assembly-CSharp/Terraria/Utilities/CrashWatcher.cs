using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005CB RID: 1483
	[Token(Token = "0x20005CB")]
	public static class CrashWatcher
	{
		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x0001E0A8 File Offset: 0x0001C2A8
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000789")]
		public static bool LogAllExceptions
		{
			[Token(Token = "0x6003B94")]
			[Address(RVA = "0x1E11E70", Offset = "0x1E11E70", VA = "0x1E11E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003B95")]
			[Address(RVA = "0x1E11EC0", Offset = "0x1E11EC0", VA = "0x1E11EC0")]
			set
			{
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		// (set) Token: 0x06003B97 RID: 15255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078A")]
		public static bool DumpOnException
		{
			[Token(Token = "0x6003B96")]
			[Address(RVA = "0x1E11F14", Offset = "0x1E11F14", VA = "0x1E11F14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003B97")]
			[Address(RVA = "0x1E11F64", Offset = "0x1E11F64", VA = "0x1E11F64")]
			set
			{
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		// (set) Token: 0x06003B99 RID: 15257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078B")]
		public static bool DumpOnCrash
		{
			[Token(Token = "0x6003B98")]
			[Address(RVA = "0x1E11FB8", Offset = "0x1E11FB8", VA = "0x1E11FB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003B99")]
			[Address(RVA = "0x1E12008", Offset = "0x1E12008", VA = "0x1E12008")]
			private set
			{
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06003B9A RID: 15258 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
		// (set) Token: 0x06003B9B RID: 15259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078C")]
		public static CrashDump.Options CrashDumpOptions
		{
			[Token(Token = "0x6003B9A")]
			[Address(RVA = "0x1E1205C", Offset = "0x1E1205C", VA = "0x1E1205C")]
			get
			{
				return CrashDump.Options.Normal;
			}
			[Token(Token = "0x6003B9B")]
			[Address(RVA = "0x1E120AC", Offset = "0x1E120AC", VA = "0x1E120AC")]
			private set
			{
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078D")]
		private static string DumpPath
		{
			[Token(Token = "0x6003B9C")]
			[Address(RVA = "0x1E12100", Offset = "0x1E12100", VA = "0x1E12100")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x1E121C0", Offset = "0x1E121C0", VA = "0x1E121C0")]
		public static void Inititialize()
		{
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x1E1242C", Offset = "0x1E1242C", VA = "0x1E1242C")]
		private static string PrintException(Exception ex, [Optional] string customStackTrace)
		{
			return null;
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x1E1294C", Offset = "0x1E1294C", VA = "0x1E1294C")]
		public static void EnableCrashDumps(CrashDump.Options options)
		{
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x1E129DC", Offset = "0x1E129DC", VA = "0x1E129DC")]
		public static void DisableCrashDumps()
		{
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA1")]
		[Address(RVA = "0x1E12A30", Offset = "0x1E12A30", VA = "0x1E12A30")]
		private static void HookDebugExceptionDialog()
		{
		}

		// Token: 0x0400474E RID: 18254
		[Token(Token = "0x400474E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool <LogAllExceptions>k__BackingField;

		// Token: 0x0400474F RID: 18255
		[Token(Token = "0x400474F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool <DumpOnException>k__BackingField;

		// Token: 0x04004750 RID: 18256
		[Token(Token = "0x4004750")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private static bool <DumpOnCrash>k__BackingField;

		// Token: 0x04004751 RID: 18257
		[Token(Token = "0x4004751")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static CrashDump.Options <CrashDumpOptions>k__BackingField;

		// Token: 0x020005CC RID: 1484
		[Token(Token = "0x20005CC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003BA3 RID: 15267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BA3")]
			[Address(RVA = "0x1E12AA8", Offset = "0x1E12AA8", VA = "0x1E12AA8")]
			public <>c()
			{
			}

			// Token: 0x06003BA4 RID: 15268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BA4")]
			[Address(RVA = "0x1E12AB0", Offset = "0x1E12AB0", VA = "0x1E12AB0")]
			internal void <Inititialize>b__18_0(object sender, FirstChanceExceptionEventArgs exceptionArgs)
			{
			}

			// Token: 0x06003BA5 RID: 15269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BA5")]
			[Address(RVA = "0x1E12F20", Offset = "0x1E12F20", VA = "0x1E12F20")]
			internal void <Inititialize>b__18_1(object sender, UnhandledExceptionEventArgs exceptionArgs)
			{
			}

			// Token: 0x04004752 RID: 18258
			[Token(Token = "0x4004752")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly CrashWatcher.<>c <>9;

			// Token: 0x04004753 RID: 18259
			[Token(Token = "0x4004753")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static EventHandler<FirstChanceExceptionEventArgs> <>9__18_0;

			// Token: 0x04004754 RID: 18260
			[Token(Token = "0x4004754")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static UnhandledExceptionEventHandler <>9__18_1;
		}
	}
}
