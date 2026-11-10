using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	public static class Program
	{
		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x00017EB0 File Offset: 0x000160B0
		[Token(Token = "0x17000696")]
		public static float LoadedPercentage
		{
			[Token(Token = "0x6003172")]
			[Address(RVA = "0x19FB2F0", Offset = "0x19FB2F0", VA = "0x19FB2F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003173")]
		[Address(RVA = "0x19FB39C", Offset = "0x19FB39C", VA = "0x19FB39C")]
		public static void StartForceLoad()
		{
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003174")]
		[Address(RVA = "0x19FB404", Offset = "0x19FB404", VA = "0x19FB404")]
		public static void ForceLoadThread(object threadContext)
		{
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003175")]
		[Address(RVA = "0x19FB570", Offset = "0x19FB570", VA = "0x19FB570")]
		private static void ForceJITOnAssembly(Assembly assembly)
		{
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003176")]
		[Address(RVA = "0x19FB7C8", Offset = "0x19FB7C8", VA = "0x19FB7C8")]
		private static void ForceStaticInitializers(Assembly assembly)
		{
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003177")]
		[Address(RVA = "0x19FB4A0", Offset = "0x19FB4A0", VA = "0x19FB4A0")]
		private static void ForceLoadAssembly(Assembly assembly, bool initializeStaticMembers)
		{
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003178")]
		[Address(RVA = "0x19FB874", Offset = "0x19FB874", VA = "0x19FB874")]
		private static void ForceLoadAssembly(string name, bool initializeStaticMembers)
		{
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003179")]
		[Address(RVA = "0x19FB9D0", Offset = "0x19FB9D0", VA = "0x19FB9D0")]
		private static void SetupLogging()
		{
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317A")]
		[Address(RVA = "0x19FBEB4", Offset = "0x19FBEB4", VA = "0x19FBEB4")]
		private static void InitializeConsoleOutput()
		{
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317B")]
		[Address(RVA = "0x19FBFF4", Offset = "0x19FBFF4", VA = "0x19FBFF4")]
		public static void LaunchGame(string[] args, bool monoArgs = false)
		{
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317C")]
		[Address(RVA = "0x19FC4D4", Offset = "0x19FC4D4", VA = "0x19FC4D4")]
		private static void DisplayException(Exception e)
		{
		}

		// Token: 0x04004231 RID: 16945
		[Token(Token = "0x4004231")]
		[FieldOffset(Offset = "0x0")]
		public static bool IsXna;

		// Token: 0x04004232 RID: 16946
		[Token(Token = "0x4004232")]
		[FieldOffset(Offset = "0x1")]
		public static bool IsFna;

		// Token: 0x04004233 RID: 16947
		[Token(Token = "0x4004233")]
		[FieldOffset(Offset = "0x2")]
		public static bool IsMono;

		// Token: 0x04004234 RID: 16948
		[Token(Token = "0x4004234")]
		[FieldOffset(Offset = "0x4")]
		public static Dictionary<string, string> LaunchParameters;

		// Token: 0x04004235 RID: 16949
		[Token(Token = "0x4004235")]
		[FieldOffset(Offset = "0x8")]
		public static string SavePath;

		// Token: 0x04004236 RID: 16950
		[Token(Token = "0x4004236")]
		public const string TerrariaSaveFolderPath = "Terraria";

		// Token: 0x04004237 RID: 16951
		[Token(Token = "0x4004237")]
		[FieldOffset(Offset = "0xC")]
		private static int ThingsToLoad;

		// Token: 0x04004238 RID: 16952
		[Token(Token = "0x4004238")]
		[FieldOffset(Offset = "0x10")]
		private static int ThingsLoaded;

		// Token: 0x04004239 RID: 16953
		[Token(Token = "0x4004239")]
		[FieldOffset(Offset = "0x14")]
		public static bool LoadedEverything;

		// Token: 0x0400423A RID: 16954
		[Token(Token = "0x400423A")]
		[FieldOffset(Offset = "0x18")]
		public static IntPtr JitForcedMethodCache;
	}
}
