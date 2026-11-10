using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000538 RID: 1336
	[Token(Token = "0x2000538")]
	public class WorldGenerationOptions
	{
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060039A4 RID: 14756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000739")]
		public static IEnumerable<AWorldGenerationOption> Options
		{
			[Token(Token = "0x60039A4")]
			[Address(RVA = "0x1DF7F08", Offset = "0x1DF7F08", VA = "0x1DF7F08")]
			get
			{
				return null;
			}
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A5")]
		public static T Get<T>() where T : AWorldGenerationOption
		{
			return null;
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A7")]
		public static void Register<T>() where T : AWorldGenerationOption, new()
		{
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A8")]
		[Address(RVA = "0x1DF8180", Offset = "0x1DF8180", VA = "0x1DF8180")]
		public static void Reset()
		{
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A9")]
		[Address(RVA = "0x1DF8370", Offset = "0x1DF8370", VA = "0x1DF8370")]
		public static void SelectOption(AWorldGenerationOption option)
		{
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039AA")]
		[Address(RVA = "0x1DF8478", Offset = "0x1DF8478", VA = "0x1DF8478")]
		public static AWorldGenerationOption GetOptionFromSeedText(string processedSeed)
		{
			return null;
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AB")]
		[Address(RVA = "0x1DF89E8", Offset = "0x1DF89E8", VA = "0x1DF89E8")]
		public static void TryEnablingFlagFrom(string line)
		{
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AC")]
		[Address(RVA = "0x1DF8D00", Offset = "0x1DF8D00", VA = "0x1DF8D00")]
		public WorldGenerationOptions()
		{
		}

		// Token: 0x040045B8 RID: 17848
		[Token(Token = "0x40045B8")]
		[FieldOffset(Offset = "0x0")]
		private static List<AWorldGenerationOption> _options;

		// Token: 0x040045B9 RID: 17849
		[Token(Token = "0x40045B9")]
		private const string _powerPermissionsLineHeader = "seed_";

		// Token: 0x02000539 RID: 1337
		[Token(Token = "0x2000539")]
		private class OptionStorage<T> where T : AWorldGenerationOption
		{
			// Token: 0x060039AD RID: 14765 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039AD")]
			public OptionStorage()
			{
			}

			// Token: 0x040045BA RID: 17850
			[Token(Token = "0x40045BA")]
			[FieldOffset(Offset = "0x0")]
			public static T Instance;
		}

		// Token: 0x0200053A RID: 1338
		[Token(Token = "0x200053A")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x060039AE RID: 14766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039AE")]
			[Address(RVA = "0x1DF8CF8", Offset = "0x1DF8CF8", VA = "0x1DF8CF8")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x060039AF RID: 14767 RVA: 0x0001D178 File Offset: 0x0001B378
			[Token(Token = "0x60039AF")]
			[Address(RVA = "0x1DF8D08", Offset = "0x1DF8D08", VA = "0x1DF8D08")]
			internal bool <TryEnablingFlagFrom>b__0(AWorldGenerationOption x)
			{
				return default(bool);
			}

			// Token: 0x040045BB RID: 17851
			[Token(Token = "0x40045BB")]
			[FieldOffset(Offset = "0x8")]
			public string namePiece;
		}
	}
}
