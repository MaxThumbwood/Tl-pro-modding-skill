using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000765 RID: 1893
	[Token(Token = "0x2000765")]
	public class GeneralIssueReporter : FileAPI
	{
		// Token: 0x060042EA RID: 17130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042EA")]
		[Address(RVA = "0x4FA4E8", Offset = "0x4FA4E8", VA = "0x4FA4E8")]
		public void AddReport(string textToShow)
		{
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EB")]
		[Address(RVA = "0x4FA658", Offset = "0x4FA658", VA = "0x4FA658", Slot = "4")]
		public List<IssueReport> GetReports()
		{
			return null;
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042EC")]
		[Address(RVA = "0x4FA660", Offset = "0x4FA660", VA = "0x4FA660")]
		public GeneralIssueReporter()
		{
		}

		// Token: 0x04008A71 RID: 35441
		[Token(Token = "0x4008A71")]
		[FieldOffset(Offset = "0x8")]
		private List<IssueReport> _reports;
	}
}
