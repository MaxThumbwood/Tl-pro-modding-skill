using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Terraria.Localization
{
	// Token: 0x02000662 RID: 1634
	[Token(Token = "0x2000662")]
	public class LocalizedText
	{
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06003F4A RID: 16202 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003F4B RID: 16203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F2")]
		public string Value
		{
			[Token(Token = "0x6003F4A")]
			[Address(RVA = "0x1E81B94", Offset = "0x1E81B94", VA = "0x1E81B94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F4B")]
			[Address(RVA = "0x1E81B9C", Offset = "0x1E81B9C", VA = "0x1E81B9C")]
			private set
			{
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06003F4C RID: 16204 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003F4D RID: 16205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F3")]
		public string EnglishValue
		{
			[Token(Token = "0x6003F4C")]
			[Address(RVA = "0x1E81BA4", Offset = "0x1E81BA4", VA = "0x1E81BA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F4D")]
			[Address(RVA = "0x1E81BAC", Offset = "0x1E81BAC", VA = "0x1E81BAC")]
			private set
			{
			}
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x1E80E20", Offset = "0x1E80E20", VA = "0x1E80E20")]
		internal LocalizedText(string key, string text)
		{
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4F")]
		[Address(RVA = "0x1E7F2FC", Offset = "0x1E7F2FC", VA = "0x1E7F2FC")]
		internal void SetValue(string text)
		{
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F50")]
		[Address(RVA = "0x1E7C7FC", Offset = "0x1E7C7FC", VA = "0x1E7C7FC")]
		public string FormatWith(object obj)
		{
			return null;
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F51")]
		[Address(RVA = "0x1E81BBC", Offset = "0x1E81BBC", VA = "0x1E81BBC")]
		public static void CheckAndUpdateSubstitutionsFormat(ref string value)
		{
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F52")]
		[Address(RVA = "0x1E7CA54", Offset = "0x1E7CA54", VA = "0x1E7CA54")]
		public StringBuilder FormatWith(object obj, StringBuilder sb)
		{
			return null;
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		[Token(Token = "0x6003F53")]
		[Address(RVA = "0x1E81E24", Offset = "0x1E81E24", VA = "0x1E81E24")]
		public bool CanFormatWith(object obj)
		{
			return default(bool);
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F54")]
		[Address(RVA = "0x1E8243C", Offset = "0x1E8243C", VA = "0x1E8243C")]
		public NetworkText ToNetworkText()
		{
			return null;
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x1E825BC", Offset = "0x1E825BC", VA = "0x1E825BC")]
		public NetworkText ToNetworkText(object[] substitutions)
		{
			return null;
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x1E8262C", Offset = "0x1E8262C", VA = "0x1E8262C")]
		public static explicit operator string(LocalizedText text)
		{
			return null;
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F57")]
		[Address(RVA = "0x1E818D8", Offset = "0x1E818D8", VA = "0x1E818D8")]
		public string Format(object arg0)
		{
			return null;
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x1E818E4", Offset = "0x1E818E4", VA = "0x1E818E4")]
		public string Format(object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x1E818F0", Offset = "0x1E818F0", VA = "0x1E818F0")]
		public string Format(object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5A")]
		[Address(RVA = "0x1E81910", Offset = "0x1E81910", VA = "0x1E81910")]
		public string Format(object[] args)
		{
			return null;
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x1E82650", Offset = "0x1E82650", VA = "0x1E82650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x0001F308 File Offset: 0x0001D508
		[Token(Token = "0x6003F5C")]
		[Address(RVA = "0x1E82658", Offset = "0x1E82658", VA = "0x1E82658")]
		public bool EqualsCommand(string text)
		{
			return default(bool);
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x0001F320 File Offset: 0x0001D520
		[Token(Token = "0x6003F5D")]
		[Address(RVA = "0x1E826B0", Offset = "0x1E826B0", VA = "0x1E826B0")]
		public bool ParseCommandPrefix(string text, out string remainder)
		{
			return default(bool);
		}

		// Token: 0x04004949 RID: 18761
		[Token(Token = "0x4004949")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LocalizedText Empty;

		// Token: 0x0400494A RID: 18762
		[Token(Token = "0x400494A")]
		[FieldOffset(Offset = "0x4")]
		public static Regex _substitutionRegex;

		// Token: 0x0400494B RID: 18763
		[Token(Token = "0x400494B")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Key;

		// Token: 0x0400494C RID: 18764
		[Token(Token = "0x400494C")]
		[FieldOffset(Offset = "0xC")]
		private string <Value>k__BackingField;

		// Token: 0x0400494D RID: 18765
		[Token(Token = "0x400494D")]
		[FieldOffset(Offset = "0x10")]
		private string <EnglishValue>k__BackingField;

		// Token: 0x02000663 RID: 1635
		[Token(Token = "0x2000663")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06003F5F RID: 16223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F5F")]
			[Address(RVA = "0x1E81BB4", Offset = "0x1E81BB4", VA = "0x1E81BB4")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06003F60 RID: 16224 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003F60")]
			[Address(RVA = "0x1E8288C", Offset = "0x1E8288C", VA = "0x1E8288C")]
			internal string <FormatWith>b__0(Match match)
			{
				return null;
			}

			// Token: 0x0400494E RID: 18766
			[Token(Token = "0x400494E")]
			[FieldOffset(Offset = "0x8")]
			public PropertyDescriptorCollection properties;

			// Token: 0x0400494F RID: 18767
			[Token(Token = "0x400494F")]
			[FieldOffset(Offset = "0xC")]
			public object obj;
		}

		// Token: 0x02000664 RID: 1636
		[Token(Token = "0x2000664")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06003F61 RID: 16225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F61")]
			[Address(RVA = "0x1E81E1C", Offset = "0x1E81E1C", VA = "0x1E81E1C")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x06003F62 RID: 16226 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003F62")]
			[Address(RVA = "0x1E82A18", Offset = "0x1E82A18", VA = "0x1E82A18")]
			internal string <CheckAndUpdateSubstitutionsFormat>b__0(Match match)
			{
				return null;
			}

			// Token: 0x04004950 RID: 18768
			[Token(Token = "0x4004950")]
			[FieldOffset(Offset = "0x8")]
			public PropertyDescriptorCollection properties;

			// Token: 0x04004951 RID: 18769
			[Token(Token = "0x4004951")]
			[FieldOffset(Offset = "0xC")]
			public object substitutions;
		}
	}
}
