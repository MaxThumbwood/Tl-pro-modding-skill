using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x020009C8 RID: 2504
	[Token(Token = "0x20009C8")]
	public static class SecretSeedsTracker
	{
		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x060051C6 RID: 20934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AA")]
		private static List<string> _seedsForConfig
		{
			[Token(Token = "0x60051C6")]
			[Address(RVA = "0x783F0C", Offset = "0x783F0C", VA = "0x783F0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x060051C7 RID: 20935 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060051C8 RID: 20936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AB")]
		private static List<WorldGen.SecretSeed> _seedsForInterface
		{
			[Token(Token = "0x60051C7")]
			[Address(RVA = "0x783F74", Offset = "0x783F74", VA = "0x783F74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051C8")]
			[Address(RVA = "0x783FDC", Offset = "0x783FDC", VA = "0x783FDC")]
			set
			{
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060051C9 RID: 20937 RVA: 0x00026058 File Offset: 0x00024258
		// (set) Token: 0x060051CA RID: 20938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AC")]
		private static bool _processedConfig
		{
			[Token(Token = "0x60051C9")]
			[Address(RVA = "0x784048", Offset = "0x784048", VA = "0x784048")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60051CA")]
			[Address(RVA = "0x7840B0", Offset = "0x7840B0", VA = "0x7840B0")]
			set
			{
			}
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CB")]
		[Address(RVA = "0x78411C", Offset = "0x78411C", VA = "0x78411C")]
		public static void SetstringsFromConfig(ICollection<string> seedStrings)
		{
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CC")]
		[Address(RVA = "0x7841D8", Offset = "0x7841D8", VA = "0x7841D8")]
		public static void PrepareInterface()
		{
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x00026070 File Offset: 0x00024270
		[Token(Token = "0x60051CD")]
		[Address(RVA = "0x784BB4", Offset = "0x784BB4", VA = "0x784BB4")]
		private static bool SeedHasSecret(string seedString, out WorldGen.SecretSeed seed)
		{
			return default(bool);
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x784C24", Offset = "0x784C24", VA = "0x784C24")]
		public static void AddSeedToTrack(string seedString)
		{
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x784F50", Offset = "0x784F50", VA = "0x784F50")]
		public static List<string> GetStringsToSave()
		{
			return null;
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AD")]
		public static List<WorldGen.SecretSeed> SeedsForInterface
		{
			[Token(Token = "0x60051D0")]
			[Address(RVA = "0x784FB8", Offset = "0x784FB8", VA = "0x784FB8")]
			get
			{
				return null;
			}
		}

		// Token: 0x020009C9 RID: 2505
		[Token(Token = "0x20009C9")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060051D2 RID: 20946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051D2")]
			[Address(RVA = "0x785094", Offset = "0x785094", VA = "0x785094")]
			public <>c()
			{
			}

			// Token: 0x060051D3 RID: 20947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60051D3")]
			[Address(RVA = "0x78509C", Offset = "0x78509C", VA = "0x78509C")]
			internal string <PrepareInterface>b__9_1(WorldGen.SecretSeed x)
			{
				return null;
			}

			// Token: 0x060051D4 RID: 20948 RVA: 0x00026088 File Offset: 0x00024288
			[Token(Token = "0x60051D4")]
			[Address(RVA = "0x7850C0", Offset = "0x7850C0", VA = "0x7850C0")]
			internal int <PrepareInterface>b__9_0(WorldGen.SecretSeed a, WorldGen.SecretSeed b)
			{
				return 0;
			}

			// Token: 0x0400951B RID: 38171
			[Token(Token = "0x400951B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SecretSeedsTracker.<>c <>9;

			// Token: 0x0400951C RID: 38172
			[Token(Token = "0x400951C")]
			[FieldOffset(Offset = "0x4")]
			public static Func<WorldGen.SecretSeed, string> <>9__9_1;

			// Token: 0x0400951D RID: 38173
			[Token(Token = "0x400951D")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<WorldGen.SecretSeed> <>9__9_0;
		}
	}
}
