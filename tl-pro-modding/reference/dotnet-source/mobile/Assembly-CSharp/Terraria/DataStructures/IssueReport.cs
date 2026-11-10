using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x2000764")]
	public class IssueReport
	{
		// Token: 0x060042E9 RID: 17129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E9")]
		[Address(RVA = "0x4FA45C", Offset = "0x4FA45C", VA = "0x4FA45C")]
		public IssueReport(string reportText)
		{
		}

		// Token: 0x04008A6F RID: 35439
		[Token(Token = "0x4008A6F")]
		[FieldOffset(Offset = "0x8")]
		public DateTime timeReported;

		// Token: 0x04008A70 RID: 35440
		[Token(Token = "0x4008A70")]
		[FieldOffset(Offset = "0x10")]
		public string reportText;
	}
}
