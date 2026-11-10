using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.Social.Base
{
	// Token: 0x0200063C RID: 1596
	[Token(Token = "0x200063C")]
	public class WorkshopIssueReporter : FileAPI
	{
		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06003DFF RID: 15871 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003E00 RID: 15872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000035")]
		public event Action OnNeedToOpenUI
		{
			[Token(Token = "0x6003DFF")]
			[Address(RVA = "0x1E689C8", Offset = "0x1E689C8", VA = "0x1E689C8")]
			add
			{
			}
			[Token(Token = "0x6003E00")]
			[Address(RVA = "0x1E68A78", Offset = "0x1E68A78", VA = "0x1E68A78")]
			remove
			{
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06003E01 RID: 15873 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003E02 RID: 15874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000036")]
		public event Action OnNeedToNotifyUI
		{
			[Token(Token = "0x6003E01")]
			[Address(RVA = "0x1E68B28", Offset = "0x1E68B28", VA = "0x1E68B28")]
			add
			{
			}
			[Token(Token = "0x6003E02")]
			[Address(RVA = "0x1E68BD8", Offset = "0x1E68BD8", VA = "0x1E68BD8")]
			remove
			{
			}
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E03")]
		[Address(RVA = "0x1E68C88", Offset = "0x1E68C88", VA = "0x1E68C88")]
		private void AddReport(string reportText)
		{
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E04")]
		[Address(RVA = "0x1E68DFC", Offset = "0x1E68DFC", VA = "0x1E68DFC", Slot = "4")]
		public List<IssueReport> GetReports()
		{
			return null;
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E05")]
		[Address(RVA = "0x1E68E04", Offset = "0x1E68E04", VA = "0x1E68E04")]
		private void OpenReportsScreen()
		{
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E06")]
		[Address(RVA = "0x1E68E20", Offset = "0x1E68E20", VA = "0x1E68E20")]
		private void NotifyReportsScreen()
		{
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E07")]
		[Address(RVA = "0x1E68E3C", Offset = "0x1E68E3C", VA = "0x1E68E3C")]
		public void ReportInstantUploadProblem(string textKey)
		{
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E08")]
		[Address(RVA = "0x1E68ED4", Offset = "0x1E68ED4", VA = "0x1E68ED4")]
		public void ReportInstantUploadProblem(string textKey, object subs)
		{
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E09")]
		[Address(RVA = "0x1E68F74", Offset = "0x1E68F74", VA = "0x1E68F74")]
		public void ReportDelayedUploadProblem(string textKey)
		{
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0A")]
		[Address(RVA = "0x1E6900C", Offset = "0x1E6900C", VA = "0x1E6900C")]
		public void ReportDelayedUploadProblem(string textKey, object subs)
		{
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0B")]
		[Address(RVA = "0x1E690AC", Offset = "0x1E690AC", VA = "0x1E690AC")]
		public void ReportDownloadProblem(string textKey, string path, Exception exception)
		{
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0C")]
		[Address(RVA = "0x1E691D8", Offset = "0x1E691D8", VA = "0x1E691D8")]
		public void ReportManifestCreationProblem(string textKey, Exception exception)
		{
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E0D")]
		[Address(RVA = "0x1E692FC", Offset = "0x1E692FC", VA = "0x1E692FC")]
		public WorkshopIssueReporter()
		{
		}

		// Token: 0x04004886 RID: 18566
		[Token(Token = "0x4004886")]
		[FieldOffset(Offset = "0x10")]
		private int _maxReports;

		// Token: 0x04004887 RID: 18567
		[Token(Token = "0x4004887")]
		[FieldOffset(Offset = "0x14")]
		private List<IssueReport> _reports;
	}
}
