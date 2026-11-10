using System;
using Il2CppDummyDll;

namespace ReLogic.OS.Base
{
	// Token: 0x02000DF7 RID: 3575
	[Token(Token = "0x2000DF7")]
	internal abstract class PathService : FileAPI
	{
		// Token: 0x060068C3 RID: 26819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C3")]
		[Address(RVA = "0xB82DBC", Offset = "0xB82DBC", VA = "0xB82DBC", Slot = "6")]
		public string ExpandPathVariables(string path)
		{
			return null;
		}

		// Token: 0x060068C4 RID: 26820
		[Token(Token = "0x60068C4")]
		public abstract string GetStoragePath();

		// Token: 0x060068C5 RID: 26821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C5")]
		[Address(RVA = "0xB82DC8", Offset = "0xB82DC8", VA = "0xB82DC8", Slot = "5")]
		public string GetStoragePath(string subfolder)
		{
			return null;
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C6")]
		[Address(RVA = "0xB80E84", Offset = "0xB80E84", VA = "0xB80E84")]
		protected PathService()
		{
		}
	}
}
