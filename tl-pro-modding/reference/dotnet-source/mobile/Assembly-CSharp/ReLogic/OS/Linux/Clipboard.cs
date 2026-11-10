using System;
using Il2CppDummyDll;
using ReLogic.OS.Base;

namespace ReLogic.OS.Linux
{
	// Token: 0x02000DF3 RID: 3571
	[Token(Token = "0x2000DF3")]
	internal class Clipboard : Clipboard
	{
		// Token: 0x060068B0 RID: 26800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068B0")]
		[Address(RVA = "0xB81F28", Offset = "0xB81F28", VA = "0xB81F28", Slot = "7")]
		protected override string GetClipboard()
		{
			return null;
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B1")]
		[Address(RVA = "0xB82314", Offset = "0xB82314", VA = "0xB82314")]
		private void ClearClipboard()
		{
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B2")]
		[Address(RVA = "0xB8267C", Offset = "0xB8267C", VA = "0xB8267C", Slot = "8")]
		protected override void SetClipboard(string text)
		{
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B3")]
		[Address(RVA = "0xB82AB4", Offset = "0xB82AB4", VA = "0xB82AB4")]
		public Clipboard()
		{
		}
	}
}
