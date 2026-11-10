using System;
using Il2CppDummyDll;
using ReLogic.OS.Base;

namespace ReLogic.OS.OSX
{
	// Token: 0x02000DF0 RID: 3568
	[Token(Token = "0x2000DF0")]
	internal class Clipboard : Clipboard
	{
		// Token: 0x060068A5 RID: 26789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068A5")]
		[Address(RVA = "0xB8162C", Offset = "0xB8162C", VA = "0xB8162C", Slot = "7")]
		protected override string GetClipboard()
		{
			return null;
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A6")]
		[Address(RVA = "0xB81A18", Offset = "0xB81A18", VA = "0xB81A18", Slot = "8")]
		protected override void SetClipboard(string text)
		{
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A7")]
		[Address(RVA = "0xB81E14", Offset = "0xB81E14", VA = "0xB81E14")]
		public Clipboard()
		{
		}
	}
}
