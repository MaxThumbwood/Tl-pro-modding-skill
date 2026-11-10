using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x200075D")]
	public class EntrySorter<TEntryType, TStepType> : FileAPI where TEntryType : new() where TStepType : IEntrySortStep<TEntryType>
	{
		// Token: 0x060042DB RID: 17115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042DB")]
		public void AddSortSteps(List<TStepType> sortSteps)
		{
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x00020538 File Offset: 0x0001E738
		[Token(Token = "0x60042DC")]
		public int Compare(TEntryType x, TEntryType y)
		{
			return 0;
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042DD")]
		public void SetPrioritizedStepIndex(int index)
		{
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DE")]
		public string GetDisplayName()
		{
			return null;
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042DF")]
		public EntrySorter()
		{
		}

		// Token: 0x04008A58 RID: 35416
		[Token(Token = "0x4008A58")]
		[FieldOffset(Offset = "0x0")]
		public List<TStepType> Steps;

		// Token: 0x04008A59 RID: 35417
		[Token(Token = "0x4008A59")]
		[FieldOffset(Offset = "0x0")]
		private int _prioritizedStep;
	}
}
