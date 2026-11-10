using System;
using Il2CppDummyDll;

namespace ReLogic.OS.Base
{
	// Token: 0x02000DF6 RID: 3574
	[Token(Token = "0x2000DF6")]
	internal abstract class Clipboard : FileAPI
	{
		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060068BC RID: 26812 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060068BD RID: 26813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B26")]
		public string Value
		{
			[Token(Token = "0x60068BC")]
			[Address(RVA = "0xB82C00", Offset = "0xB82C00", VA = "0xB82C00", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60068BD")]
			[Address(RVA = "0xB82D8C", Offset = "0xB82D8C", VA = "0xB82D8C", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060068BE RID: 26814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B27")]
		public string MultiLineValue
		{
			[Token(Token = "0x60068BE")]
			[Address(RVA = "0xB82D9C", Offset = "0xB82D9C", VA = "0xB82D9C", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BF")]
		[Address(RVA = "0xB82C20", Offset = "0xB82C20", VA = "0xB82C20")]
		private static string SanitizeClipboardText(string clipboardText, bool allowNewLine)
		{
			return null;
		}

		// Token: 0x060068C0 RID: 26816
		[Token(Token = "0x60068C0")]
		protected abstract string GetClipboard();

		// Token: 0x060068C1 RID: 26817
		[Token(Token = "0x60068C1")]
		protected abstract void SetClipboard(string text);

		// Token: 0x060068C2 RID: 26818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C2")]
		[Address(RVA = "0xB81E1C", Offset = "0xB81E1C", VA = "0xB81E1C")]
		protected Clipboard()
		{
		}
	}
}
