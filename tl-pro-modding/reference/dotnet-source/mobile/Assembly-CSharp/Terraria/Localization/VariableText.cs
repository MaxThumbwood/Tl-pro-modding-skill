using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Terraria.Localization
{
	// Token: 0x02000667 RID: 1639
	[Token(Token = "0x2000667")]
	internal class VariableText
	{
		// Token: 0x06003F73 RID: 16243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x1E84704", Offset = "0x1E84704", VA = "0x1E84704")]
		private VariableText(string original, string format, VariableText.Condition[] conditions, string[] variables)
		{
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0001F350 File Offset: 0x0001D550
		[Token(Token = "0x6003F74")]
		[Address(RVA = "0x1E847D8", Offset = "0x1E847D8", VA = "0x1E847D8")]
		public static bool TryCreate(string s, out VariableText text)
		{
			return default(bool);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x0001F368 File Offset: 0x0001D568
		[Token(Token = "0x6003F75")]
		[Address(RVA = "0x1E84AE4", Offset = "0x1E84AE4", VA = "0x1E84AE4")]
		private bool CheckConditionsAndLoadArgs(Func<string, object> lookup)
		{
			return default(bool);
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x0001F380 File Offset: 0x0001D580
		[Token(Token = "0x6003F76")]
		[Address(RVA = "0x1E84CD8", Offset = "0x1E84CD8", VA = "0x1E84CD8")]
		public bool ConditionsMet(Func<string, object> lookup)
		{
			return default(bool);
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x0001F398 File Offset: 0x0001D598
		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x1E84CDC", Offset = "0x1E84CDC", VA = "0x1E84CDC")]
		public bool TryFormat(Func<string, object> lookup, out string formatted)
		{
			return default(bool);
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F78")]
		[Address(RVA = "0x1E84D78", Offset = "0x1E84D78", VA = "0x1E84D78", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400495B RID: 18779
		[Token(Token = "0x400495B")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _original;

		// Token: 0x0400495C RID: 18780
		[Token(Token = "0x400495C")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _format;

		// Token: 0x0400495D RID: 18781
		[Token(Token = "0x400495D")]
		[FieldOffset(Offset = "0x10")]
		private readonly VariableText.Condition[] _conditions;

		// Token: 0x0400495E RID: 18782
		[Token(Token = "0x400495E")]
		[FieldOffset(Offset = "0x14")]
		private readonly string[] _variables;

		// Token: 0x0400495F RID: 18783
		[Token(Token = "0x400495F")]
		[FieldOffset(Offset = "0x18")]
		private readonly object[] _formatArgBuffer;

		// Token: 0x04004960 RID: 18784
		[Token(Token = "0x4004960")]
		[FieldOffset(Offset = "0x1C")]
		private readonly StringBuilder _formatBuffer;

		// Token: 0x04004961 RID: 18785
		[Token(Token = "0x4004961")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex _substitutionRegex;

		// Token: 0x02000668 RID: 1640
		[Token(Token = "0x2000668")]
		private struct Condition
		{
			// Token: 0x04004962 RID: 18786
			[Token(Token = "0x4004962")]
			[FieldOffset(Offset = "0x0")]
			public bool RequiredValue;

			// Token: 0x04004963 RID: 18787
			[Token(Token = "0x4004963")]
			[FieldOffset(Offset = "0x4")]
			public string Name;
		}

		// Token: 0x02000669 RID: 1641
		[Token(Token = "0x2000669")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06003F7A RID: 16250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F7A")]
			[Address(RVA = "0x1E84ADC", Offset = "0x1E84ADC", VA = "0x1E84ADC")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06003F7B RID: 16251 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003F7B")]
			[Address(RVA = "0x1E84E34", Offset = "0x1E84E34", VA = "0x1E84E34")]
			internal string <TryCreate>b__0(Match match)
			{
				return null;
			}

			// Token: 0x04004964 RID: 18788
			[Token(Token = "0x4004964")]
			[FieldOffset(Offset = "0x8")]
			public List<VariableText.Condition> conditions;

			// Token: 0x04004965 RID: 18789
			[Token(Token = "0x4004965")]
			[FieldOffset(Offset = "0xC")]
			public List<string> variables;
		}
	}
}
