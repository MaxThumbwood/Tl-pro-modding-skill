using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria.Localization
{
	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x2000660")]
	public class LanguageManager
	{
		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06003F21 RID: 16161 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003F22 RID: 16162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003B")]
		public event LanguageChangeCallback OnLanguageChanging
		{
			[Token(Token = "0x6003F21")]
			[Address(RVA = "0x1E7E54C", Offset = "0x1E7E54C", VA = "0x1E7E54C")]
			add
			{
			}
			[Token(Token = "0x6003F22")]
			[Address(RVA = "0x1E7E5FC", Offset = "0x1E7E5FC", VA = "0x1E7E5FC")]
			remove
			{
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06003F23 RID: 16163 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003F24 RID: 16164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003C")]
		public event LanguageChangeCallback OnLanguageChanged
		{
			[Token(Token = "0x6003F23")]
			[Address(RVA = "0x1E7E6AC", Offset = "0x1E7E6AC", VA = "0x1E7E6AC")]
			add
			{
			}
			[Token(Token = "0x6003F24")]
			[Address(RVA = "0x1E7E75C", Offset = "0x1E7E75C", VA = "0x1E7E75C")]
			remove
			{
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003F26 RID: 16166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F1")]
		public GameCulture ActiveCulture
		{
			[Token(Token = "0x6003F25")]
			[Address(RVA = "0x1E7E80C", Offset = "0x1E7E80C", VA = "0x1E7E80C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F26")]
			[Address(RVA = "0x1E7E814", Offset = "0x1E7E814", VA = "0x1E7E814")]
			private set
			{
			}
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F27")]
		[Address(RVA = "0x1E7E81C", Offset = "0x1E7E81C", VA = "0x1E7E81C")]
		private LanguageManager()
		{
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0001F278 File Offset: 0x0001D478
		[Token(Token = "0x6003F28")]
		[Address(RVA = "0x1E7D098", Offset = "0x1E7D098", VA = "0x1E7D098")]
		public int GetCategorySize(string name)
		{
			return 0;
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F29")]
		[Address(RVA = "0x1E7EA90", Offset = "0x1E7EA90", VA = "0x1E7EA90")]
		public void SetLanguage(int legacyId)
		{
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2A")]
		[Address(RVA = "0x1E7EC80", Offset = "0x1E7EC80", VA = "0x1E7EC80")]
		public void SetLanguage(string cultureName)
		{
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x0001F290 File Offset: 0x0001D490
		[Token(Token = "0x6003F2B")]
		[Address(RVA = "0x1E7ECF4", Offset = "0x1E7ECF4", VA = "0x1E7ECF4")]
		public int EstimateWordCount()
		{
			return 0;
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x1E7F12C", Offset = "0x1E7F12C", VA = "0x1E7F12C")]
		private void SetAllTextValuesToKeys()
		{
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2D")]
		[Address(RVA = "0x1E7F42C", Offset = "0x1E7F42C", VA = "0x1E7F42C")]
		private string[] GetLanguageFilesForCulture(GameCulture culture)
		{
			return null;
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2E")]
		[Address(RVA = "0x1E7F614", Offset = "0x1E7F614", VA = "0x1E7F614")]
		public void DelayedInit()
		{
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2F")]
		[Address(RVA = "0x1E7EB04", Offset = "0x1E7EB04", VA = "0x1E7EB04")]
		public void SetLanguage(GameCulture culture)
		{
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x1E7F624", Offset = "0x1E7F624", VA = "0x1E7F624")]
		private void LoadLanguage(GameCulture culture, bool processCopyCommands = true)
		{
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F31")]
		[Address(RVA = "0x1E7F6E8", Offset = "0x1E7F6E8", VA = "0x1E7F6E8")]
		private void LoadFilesForCulture(GameCulture culture)
		{
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F32")]
		[Address(RVA = "0x1E7FC58", Offset = "0x1E7FC58", VA = "0x1E7FC58")]
		private void ProcessCopyCommandsInTexts()
		{
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F33")]
		[Address(RVA = "0x1E7FF50", Offset = "0x1E7FF50", VA = "0x1E7FF50")]
		public void LoadLanguageFromFileText(string fileText)
		{
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x1E80E4C", Offset = "0x1E80E4C", VA = "0x1E80E4C")]
		private void ValidateAllCharactersContainedInFont(SpriteFont font)
		{
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x1E7D1F4", Offset = "0x1E7D1F4", VA = "0x1E7D1F4")]
		public LocalizedText[] FindAll(Regex regex)
		{
			return null;
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x1E7D60C", Offset = "0x1E7D60C", VA = "0x1E7D60C")]
		public LocalizedText[] FindAll(LanguageSearchFilter filter)
		{
			return null;
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F37")]
		[Address(RVA = "0x1E7D93C", Offset = "0x1E7D93C", VA = "0x1E7D93C")]
		public LocalizedText[] FindAll(string categoryName)
		{
			return null;
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F38")]
		[Address(RVA = "0x1E7DC40", Offset = "0x1E7DC40", VA = "0x1E7DC40")]
		public LocalizedText SelectRandom(LanguageSearchFilter filter, [Optional] UnifiedRandom random)
		{
			return null;
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F39")]
		[Address(RVA = "0x1E7E0CC", Offset = "0x1E7E0CC", VA = "0x1E7E0CC")]
		public LocalizedText RandomFromCategory(string categoryName, [Optional] UnifiedRandom random)
		{
			return null;
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3A")]
		[Address(RVA = "0x1E80E50", Offset = "0x1E80E50", VA = "0x1E80E50")]
		public LocalizedText RandomFromCategories(string[] categoryNames, ref int keyIndexToSkip, [Optional] UnifiedRandom random)
		{
			return null;
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x1E816E4", Offset = "0x1E816E4", VA = "0x1E816E4")]
		public LocalizedText IndexedFromCategory(string categoryName, int index)
		{
			return null;
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
		[Token(Token = "0x6003F3C")]
		[Address(RVA = "0x1E7CFAC", Offset = "0x1E7CFAC", VA = "0x1E7CFAC")]
		public bool Exists(string key)
		{
			return default(bool);
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3D")]
		[Address(RVA = "0x1E7B914", Offset = "0x1E7B914", VA = "0x1E7B914")]
		public LocalizedText GetText(string key)
		{
			return null;
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3E")]
		[Address(RVA = "0x1E7BB38", Offset = "0x1E7BB38", VA = "0x1E7BB38")]
		public string GetTextValue(string key)
		{
			return null;
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3F")]
		[Address(RVA = "0x1E7C10C", Offset = "0x1E7C10C", VA = "0x1E7C10C")]
		public string GetTextValue(string key, object arg0)
		{
			return null;
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x1E7C2E0", Offset = "0x1E7C2E0", VA = "0x1E7C2E0")]
		public string GetTextValue(string key, object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x1E7C4C8", Offset = "0x1E7C4C8", VA = "0x1E7C4C8")]
		public string GetTextValue(string key, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F42")]
		[Address(RVA = "0x1E7C6A8", Offset = "0x1E7C6A8", VA = "0x1E7C6A8")]
		public string GetTextValue(string key, object[] args)
		{
			return null;
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F43")]
		[Address(RVA = "0x1E80CB0", Offset = "0x1E80CB0", VA = "0x1E80CB0")]
		private void AddVariant(string key, string variant, string value)
		{
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x0001F2C0 File Offset: 0x0001D4C0
		[Token(Token = "0x6003F44")]
		[Address(RVA = "0x1E7E3B0", Offset = "0x1E7E3B0", VA = "0x1E7E3B0")]
		public bool TryGetVariation(string key, string variant, out string value)
		{
			return default(bool);
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F45")]
		[Address(RVA = "0x1E8191C", Offset = "0x1E8191C", VA = "0x1E8191C")]
		public void SetFallbackCulture(GameCulture culture)
		{
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F47")]
		[Address(RVA = "0x1E81994", Offset = "0x1E81994", VA = "0x1E81994")]
		private string <ProcessCopyCommandsInTexts>b__30_0(Match match)
		{
			return null;
		}

		// Token: 0x0400493C RID: 18748
		[Token(Token = "0x400493C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LanguageManager Instance;

		// Token: 0x0400493F RID: 18751
		[Token(Token = "0x400493F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GameCulture <ActiveCulture>k__BackingField;

		// Token: 0x04004940 RID: 18752
		[Token(Token = "0x4004940")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly Dictionary<string, LocalizedText> _localizedTexts;

		// Token: 0x04004941 RID: 18753
		[Token(Token = "0x4004941")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, List<string>> _categoryGroupedKeys;

		// Token: 0x04004942 RID: 18754
		[Token(Token = "0x4004942")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<string, Dictionary<string, string>> _textVariations;

		// Token: 0x04004943 RID: 18755
		[Token(Token = "0x4004943")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameCulture _fallbackCulture;

		// Token: 0x04004944 RID: 18756
		[Token(Token = "0x4004944")]
		public const char VariationSeparatorSign = '$';

		// Token: 0x04004945 RID: 18757
		[Token(Token = "0x4004945")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool intialLoadDone;

		// Token: 0x04004946 RID: 18758
		[Token(Token = "0x4004946")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameCulture delayedActiveCulture;

		// Token: 0x04004947 RID: 18759
		[Token(Token = "0x4004947")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public GameCulture LoadingCulture;

		// Token: 0x02000661 RID: 1633
		[Token(Token = "0x2000661")]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06003F48 RID: 16200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F48")]
			[Address(RVA = "0x1E7F60C", Offset = "0x1E7F60C", VA = "0x1E7F60C")]
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x06003F49 RID: 16201 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
			[Token(Token = "0x6003F49")]
			[Address(RVA = "0x1E81A9C", Offset = "0x1E81A9C", VA = "0x1E81A9C")]
			internal bool <GetLanguageFilesForCulture>b__0(string element)
			{
				return default(bool);
			}

			// Token: 0x04004948 RID: 18760
			[Token(Token = "0x4004948")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameCulture culture;
		}
	}
}
