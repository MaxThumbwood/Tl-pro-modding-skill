using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Il2CppDummyDll;

namespace ReLogic.Text
{
	// Token: 0x02000DE3 RID: 3555
	[Token(Token = "0x2000DE3")]
	internal static class StringReaderWrapExtension
	{
		// Token: 0x06006872 RID: 26738 RVA: 0x0002F7A8 File Offset: 0x0002D9A8
		[Token(Token = "0x6006872")]
		[Address(RVA = "0xB7EAA0", Offset = "0xB7EAA0", VA = "0xB7EAA0")]
		internal static bool IsCultureSupported(CultureInfo culture)
		{
			return default(bool);
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x0002F7C0 File Offset: 0x0002D9C0
		[Token(Token = "0x6006873")]
		[Address(RVA = "0xB7EB30", Offset = "0xB7EB30", VA = "0xB7EB30")]
		internal static bool IsIgnoredCharacter(char character)
		{
			return default(bool);
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
		[Token(Token = "0x6006874")]
		[Address(RVA = "0xB7EB4C", Offset = "0xB7EB4C", VA = "0xB7EB4C")]
		internal static bool CanBreakBetween(char previousChar, char nextChar, CultureInfo culture)
		{
			return default(bool);
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x0002F7F0 File Offset: 0x0002D9F0
		[Token(Token = "0x6006875")]
		[Address(RVA = "0xB7ECB0", Offset = "0xB7ECB0", VA = "0xB7ECB0")]
		internal static StringReaderWrapExtension.WrapScanMode GetModeForCharacter(char character)
		{
			return StringReaderWrapExtension.WrapScanMode.Space;
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006876")]
		[Address(RVA = "0xB7E5A8", Offset = "0xB7E5A8", VA = "0xB7E5A8")]
		internal static string ReadUntilBreakable(StringReader reader, CultureInfo culture)
		{
			return null;
		}

		// Token: 0x0400A4E4 RID: 42212
		[Token(Token = "0x400A4E4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<char> InvalidCharactersForLineStart;

		// Token: 0x0400A4E5 RID: 42213
		[Token(Token = "0x400A4E5")]
		[FieldOffset(Offset = "0x4")]
		private static readonly HashSet<char> InvalidCharactersForLineEnd;

		// Token: 0x0400A4E6 RID: 42214
		[Token(Token = "0x400A4E6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly CultureInfo[] SupportedCultures;

		// Token: 0x0400A4E7 RID: 42215
		[Token(Token = "0x400A4E7")]
		[FieldOffset(Offset = "0xC")]
		private static readonly CultureInfo SimplifiedChinese;

		// Token: 0x02000DE4 RID: 3556
		[Token(Token = "0x2000DE4")]
		internal enum WrapScanMode
		{
			// Token: 0x0400A4E9 RID: 42217
			[Token(Token = "0x400A4E9")]
			Space,
			// Token: 0x0400A4EA RID: 42218
			[Token(Token = "0x400A4EA")]
			NewLine,
			// Token: 0x0400A4EB RID: 42219
			[Token(Token = "0x400A4EB")]
			Word,
			// Token: 0x0400A4EC RID: 42220
			[Token(Token = "0x400A4EC")]
			None
		}
	}
}
