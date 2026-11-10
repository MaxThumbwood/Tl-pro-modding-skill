using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.UI
{
	// Token: 0x02000884 RID: 2180
	[Token(Token = "0x2000884")]
	public class ItemTooltip
	{
		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x000237C0 File Offset: 0x000219C0
		[Token(Token = "0x1700090E")]
		public int Lines
		{
			[Token(Token = "0x6004A2B")]
			[Address(RVA = "0x61AAA0", Offset = "0x61AAA0", VA = "0x61AAA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2C")]
		[Address(RVA = "0x61ADB0", Offset = "0x61ADB0", VA = "0x61ADB0")]
		private ItemTooltip()
		{
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2D")]
		[Address(RVA = "0x61ADB8", Offset = "0x61ADB8", VA = "0x61ADB8")]
		private ItemTooltip(short id, string key)
		{
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A2E")]
		[Address(RVA = "0x61AE3C", Offset = "0x61AE3C", VA = "0x61AE3C")]
		public static ItemTooltip FromLanguageKey(short id, string key)
		{
			return null;
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0x61AF74", Offset = "0x61AF74", VA = "0x61AF74")]
		public string GetLine(int line)
		{
			return null;
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A30")]
		[Address(RVA = "0x61AFA0", Offset = "0x61AFA0", VA = "0x61AFA0")]
		private ItemTooltip(string[] hardcodedLines)
		{
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x61B050", Offset = "0x61B050", VA = "0x61B050")]
		public static ItemTooltip FromHardcodedText(string[] text)
		{
			return null;
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A32")]
		[Address(RVA = "0x61AAC0", Offset = "0x61AAC0", VA = "0x61AAC0")]
		private void ValidateTooltip()
		{
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x61B148", Offset = "0x61B148", VA = "0x61B148")]
		public static void AddGlobalProcessor(TooltipProcessor processor)
		{
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x61B238", Offset = "0x61B238", VA = "0x61B238")]
		public static void RemoveGlobalProcessor(TooltipProcessor processor)
		{
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x61B2D8", Offset = "0x61B2D8", VA = "0x61B2D8")]
		public static void ClearGlobalProcessors()
		{
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x61B388", Offset = "0x61B388", VA = "0x61B388")]
		public static void InvalidateTooltips()
		{
		}

		// Token: 0x04008FAD RID: 36781
		[Token(Token = "0x4008FAD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ItemTooltip None;

		// Token: 0x04008FAE RID: 36782
		[Token(Token = "0x4008FAE")]
		[FieldOffset(Offset = "0x4")]
		private static readonly List<TooltipProcessor> _globalProcessors;

		// Token: 0x04008FAF RID: 36783
		[Token(Token = "0x4008FAF")]
		[FieldOffset(Offset = "0x8")]
		private static ulong _globalValidatorKey;

		// Token: 0x04008FB0 RID: 36784
		[Token(Token = "0x4008FB0")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ulong _neverUpdateHack;

		// Token: 0x04008FB1 RID: 36785
		[Token(Token = "0x4008FB1")]
		[FieldOffset(Offset = "0x8")]
		private string[] _tooltipLines;

		// Token: 0x04008FB2 RID: 36786
		[Token(Token = "0x4008FB2")]
		[FieldOffset(Offset = "0x10")]
		private ulong _validatorKey;

		// Token: 0x04008FB3 RID: 36787
		[Token(Token = "0x4008FB3")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalizedText _text;

		// Token: 0x04008FB4 RID: 36788
		[Token(Token = "0x4008FB4")]
		[FieldOffset(Offset = "0x1C")]
		private string _processedText;

		// Token: 0x04008FB5 RID: 36789
		[Token(Token = "0x4008FB5")]
		[FieldOffset(Offset = "0x20")]
		private readonly short _id;
	}
}
