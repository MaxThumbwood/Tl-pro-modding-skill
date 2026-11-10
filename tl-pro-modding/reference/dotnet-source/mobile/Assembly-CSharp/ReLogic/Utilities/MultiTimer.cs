using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace ReLogic.Utilities
{
	// Token: 0x02000DCF RID: 3535
	[Token(Token = "0x2000DCF")]
	public class MultiTimer
	{
		// Token: 0x060067CE RID: 26574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067CE")]
		[Address(RVA = "0xB7A1FC", Offset = "0xB7A1FC", VA = "0xB7A1FC")]
		public MultiTimer(int ticksBetweenPrint = 100)
		{
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067CF")]
		[Address(RVA = "0xB7A2E0", Offset = "0xB7A2E0", VA = "0xB7A2E0")]
		public void Start()
		{
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067D0")]
		[Address(RVA = "0xB7A324", Offset = "0xB7A324", VA = "0xB7A324")]
		public void Record(string key)
		{
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x0002EFC8 File Offset: 0x0002D1C8
		[Token(Token = "0x60067D1")]
		[Address(RVA = "0xB7A718", Offset = "0xB7A718", VA = "0xB7A718")]
		public bool StopAndPrint()
		{
			return default(bool);
		}

		// Token: 0x0400A4AD RID: 42157
		[Token(Token = "0x400A4AD")]
		[FieldOffset(Offset = "0x8")]
		private readonly int _ticksBetweenPrint;

		// Token: 0x0400A4AE RID: 42158
		[Token(Token = "0x400A4AE")]
		[FieldOffset(Offset = "0xC")]
		private int _ticksElapsedForPrint;

		// Token: 0x0400A4AF RID: 42159
		[Token(Token = "0x400A4AF")]
		[FieldOffset(Offset = "0x10")]
		private readonly Stopwatch _timer;

		// Token: 0x0400A4B0 RID: 42160
		[Token(Token = "0x400A4B0")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<string, MultiTimer.TimerData> _timerDataMap;

		// Token: 0x02000DD0 RID: 3536
		[Token(Token = "0x2000DD0")]
		private struct TimerData
		{
			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x060067D2 RID: 26578 RVA: 0x0002EFE0 File Offset: 0x0002D1E0
			[Token(Token = "0x17000B0C")]
			public double Average
			{
				[Token(Token = "0x60067D2")]
				[Address(RVA = "0xB7B07C", Offset = "0xB7B07C", VA = "0xB7B07C")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x060067D3 RID: 26579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D3")]
			[Address(RVA = "0xB7B090", Offset = "0xB7B090", VA = "0xB7B090")]
			private TimerData(double min, double max, double ticks, double total)
			{
			}

			// Token: 0x060067D4 RID: 26580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D4")]
			[Address(RVA = "0xB7A610", Offset = "0xB7A610", VA = "0xB7A610")]
			public TimerData(double startTime)
			{
			}

			// Token: 0x060067D5 RID: 26581 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
			[Token(Token = "0x60067D5")]
			[Address(RVA = "0xB7A638", Offset = "0xB7A638", VA = "0xB7A638")]
			public MultiTimer.TimerData AddTick(double time)
			{
				return default(MultiTimer.TimerData);
			}

			// Token: 0x0400A4B1 RID: 42161
			[Token(Token = "0x400A4B1")]
			[FieldOffset(Offset = "0x0")]
			public readonly double Min;

			// Token: 0x0400A4B2 RID: 42162
			[Token(Token = "0x400A4B2")]
			[FieldOffset(Offset = "0x8")]
			public readonly double Max;

			// Token: 0x0400A4B3 RID: 42163
			[Token(Token = "0x400A4B3")]
			[FieldOffset(Offset = "0x10")]
			public readonly double Ticks;

			// Token: 0x0400A4B4 RID: 42164
			[Token(Token = "0x400A4B4")]
			[FieldOffset(Offset = "0x18")]
			public readonly double Total;
		}
	}
}
