using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Terraria.Utilities;

namespace Terraria.Localization
{
	// Token: 0x0200065F RID: 1631
	[Token(Token = "0x200065F")]
	public static class Language
	{
		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F0")]
		public static GameCulture ActiveCulture
		{
			[Token(Token = "0x6003F0E")]
			[Address(RVA = "0x1E7A7BC", Offset = "0x1E7A7BC", VA = "0x1E7A7BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F0F")]
		[Address(RVA = "0x1E7B894", Offset = "0x1E7B894", VA = "0x1E7B894")]
		public static LocalizedText GetText(string key)
		{
			return null;
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F10")]
		[Address(RVA = "0x1E7BA34", Offset = "0x1E7BA34", VA = "0x1E7BA34")]
		public static string GetTextValue(string key)
		{
			return null;
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F11")]
		[Address(RVA = "0x1E7BBD8", Offset = "0x1E7BBD8", VA = "0x1E7BBD8")]
		public static string GetItemInputTextValue(short id, string key)
		{
			return null;
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F12")]
		[Address(RVA = "0x1E7BFF4", Offset = "0x1E7BFF4", VA = "0x1E7BFF4")]
		public static string GetTextValue(string key, object arg0)
		{
			return null;
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F13")]
		[Address(RVA = "0x1E7C1C0", Offset = "0x1E7C1C0", VA = "0x1E7C1C0")]
		public static string GetTextValue(string key, object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F14")]
		[Address(RVA = "0x1E7C39C", Offset = "0x1E7C39C", VA = "0x1E7C39C")]
		public static string GetTextValue(string key, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F15")]
		[Address(RVA = "0x1E7C590", Offset = "0x1E7C590", VA = "0x1E7C590")]
		public static string GetTextValue(string key, object[] args)
		{
			return null;
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F16")]
		[Address(RVA = "0x1E7C75C", Offset = "0x1E7C75C", VA = "0x1E7C75C")]
		public static string GetTextValueWith(string key, object obj)
		{
			return null;
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F17")]
		[Address(RVA = "0x1E7C9AC", Offset = "0x1E7C9AC", VA = "0x1E7C9AC")]
		public static StringBuilder GetTextValueWith(string key, object obj, StringBuilder sb)
		{
			return null;
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x0001F230 File Offset: 0x0001D430
		[Token(Token = "0x6003F18")]
		[Address(RVA = "0x1E7CEDC", Offset = "0x1E7CEDC", VA = "0x1E7CEDC")]
		public static bool Exists(string key)
		{
			return default(bool);
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x0001F248 File Offset: 0x0001D448
		[Token(Token = "0x6003F19")]
		[Address(RVA = "0x1E7D018", Offset = "0x1E7D018", VA = "0x1E7D018")]
		public static int GetCategorySize(string key)
		{
			return 0;
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1A")]
		[Address(RVA = "0x1E7D174", Offset = "0x1E7D174", VA = "0x1E7D174")]
		public static LocalizedText[] FindAll(Regex regex)
		{
			return null;
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1B")]
		[Address(RVA = "0x1E7D58C", Offset = "0x1E7D58C", VA = "0x1E7D58C")]
		public static LocalizedText[] FindAll(LanguageSearchFilter filter)
		{
			return null;
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1C")]
		[Address(RVA = "0x1E7D8BC", Offset = "0x1E7D8BC", VA = "0x1E7D8BC")]
		public static LocalizedText[] FindAll(string categoryName)
		{
			return null;
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1D")]
		[Address(RVA = "0x1E7DBB8", Offset = "0x1E7DBB8", VA = "0x1E7DBB8")]
		public static LocalizedText SelectRandom(LanguageSearchFilter filter, [Optional] UnifiedRandom random)
		{
			return null;
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0x1E7E044", Offset = "0x1E7E044", VA = "0x1E7E044")]
		public static LocalizedText RandomFromCategory(string categoryName, [Optional] UnifiedRandom random)
		{
			return null;
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x0001F260 File Offset: 0x0001D460
		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0x1E7E318", Offset = "0x1E7E318", VA = "0x1E7E318")]
		public static bool TryGetVariation(string key, string variant, out string value)
		{
			return default(bool);
		}

		// Token: 0x04004937 RID: 18743
		[Token(Token = "0x4004937")]
		public const char NodeKeySeperator = '*';

		// Token: 0x04004938 RID: 18744
		[Token(Token = "0x4004938")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static XNAUnityRunner.ForcedInputMode LastTextInputMode;

		// Token: 0x04004939 RID: 18745
		[Token(Token = "0x4004939")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static short LastItem;

		// Token: 0x0400493A RID: 18746
		[Token(Token = "0x400493A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, string> cachedInputStrings;

		// Token: 0x0400493B RID: 18747
		[Token(Token = "0x400493B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static GameCulture LastCulture;
	}
}
