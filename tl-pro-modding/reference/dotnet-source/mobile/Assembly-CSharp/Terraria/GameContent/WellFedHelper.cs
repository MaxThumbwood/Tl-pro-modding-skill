using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x020009F2 RID: 2546
	[Token(Token = "0x20009F2")]
	public struct WellFedHelper
	{
		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060052C7 RID: 21191 RVA: 0x00026898 File Offset: 0x00024A98
		[Token(Token = "0x170009C0")]
		public int TimeLeft
		{
			[Token(Token = "0x60052C7")]
			[Address(RVA = "0x7E7184", Offset = "0x7E7184", VA = "0x7E7184")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060052C8 RID: 21192 RVA: 0x000268B0 File Offset: 0x00024AB0
		[Token(Token = "0x170009C1")]
		public int Rank
		{
			[Token(Token = "0x60052C8")]
			[Address(RVA = "0x7E7198", Offset = "0x7E7198", VA = "0x7E7198")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C9")]
		[Address(RVA = "0x7E71D4", Offset = "0x7E71D4", VA = "0x7E71D4")]
		public void Eat(int foodRank, int foodBuffTime)
		{
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CA")]
		[Address(RVA = "0x7E72A4", Offset = "0x7E72A4", VA = "0x7E72A4")]
		public void Update()
		{
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CB")]
		[Address(RVA = "0x7E731C", Offset = "0x7E731C", VA = "0x7E731C")]
		public void Clear()
		{
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CC")]
		[Address(RVA = "0x7E726C", Offset = "0x7E726C", VA = "0x7E726C")]
		private void AddTimeTo(ref int foodTimeCounter, ref int timeLeftToAdd, int counterMaximumTime)
		{
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CD")]
		[Address(RVA = "0x7E72E0", Offset = "0x7E72E0", VA = "0x7E72E0")]
		private void ReduceTimeLeft()
		{
		}

		// Token: 0x04009707 RID: 38663
		[Token(Token = "0x4009707")]
		private const int MAXIMUM_TIME_LEFT_PER_COUNTER = 72000;

		// Token: 0x04009708 RID: 38664
		[Token(Token = "0x4009708")]
		[FieldOffset(Offset = "0x0")]
		private int _timeLeftRank1;

		// Token: 0x04009709 RID: 38665
		[Token(Token = "0x4009709")]
		[FieldOffset(Offset = "0x4")]
		private int _timeLeftRank2;

		// Token: 0x0400970A RID: 38666
		[Token(Token = "0x400970A")]
		[FieldOffset(Offset = "0x8")]
		private int _timeLeftRank3;
	}
}
