using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x20005D2")]
	public class MultiTimer
	{
		// Token: 0x06003BD7 RID: 15319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x1E15128", Offset = "0x1E15128", VA = "0x1E15128")]
		public MultiTimer()
		{
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x1E1520C", Offset = "0x1E1520C", VA = "0x1E1520C")]
		public MultiTimer(int ticksBetweenPrint)
		{
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x1E152F8", Offset = "0x1E152F8", VA = "0x1E152F8")]
		public void Start()
		{
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x1E1533C", Offset = "0x1E1533C", VA = "0x1E1533C")]
		public void Record(string key)
		{
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x0001E318 File Offset: 0x0001C518
		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x1E156F8", Offset = "0x1E156F8", VA = "0x1E156F8")]
		public bool StopAndPrint()
		{
			return default(bool);
		}

		// Token: 0x0400475D RID: 18269
		[Token(Token = "0x400475D")]
		[FieldOffset(Offset = "0x8")]
		private int _ticksBetweenPrint;

		// Token: 0x0400475E RID: 18270
		[Token(Token = "0x400475E")]
		[FieldOffset(Offset = "0xC")]
		private int _ticksElapsedForPrint;

		// Token: 0x0400475F RID: 18271
		[Token(Token = "0x400475F")]
		[FieldOffset(Offset = "0x10")]
		private Stopwatch _timer;

		// Token: 0x04004760 RID: 18272
		[Token(Token = "0x4004760")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<string, MultiTimer.TimerData> _timerDataMap;

		// Token: 0x020005D3 RID: 1491
		[Token(Token = "0x20005D3")]
		private struct TimerData
		{
			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x06003BDC RID: 15324 RVA: 0x0001E330 File Offset: 0x0001C530
			[Token(Token = "0x1700078F")]
			public double Average
			{
				[Token(Token = "0x6003BDC")]
				[Address(RVA = "0x1E16034", Offset = "0x1E16034", VA = "0x1E16034")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x06003BDD RID: 15325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BDD")]
			[Address(RVA = "0x1E16048", Offset = "0x1E16048", VA = "0x1E16048")]
			private TimerData(double min, double max, double ticks, double total)
			{
			}

			// Token: 0x06003BDE RID: 15326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BDE")]
			[Address(RVA = "0x1E155EC", Offset = "0x1E155EC", VA = "0x1E155EC")]
			public TimerData(double startTime)
			{
			}

			// Token: 0x06003BDF RID: 15327 RVA: 0x0001E348 File Offset: 0x0001C548
			[Token(Token = "0x6003BDF")]
			[Address(RVA = "0x1E15614", Offset = "0x1E15614", VA = "0x1E15614")]
			public MultiTimer.TimerData AddTick(double time)
			{
				return default(MultiTimer.TimerData);
			}

			// Token: 0x04004761 RID: 18273
			[Token(Token = "0x4004761")]
			[FieldOffset(Offset = "0x0")]
			public readonly double Min;

			// Token: 0x04004762 RID: 18274
			[Token(Token = "0x4004762")]
			[FieldOffset(Offset = "0x8")]
			public readonly double Max;

			// Token: 0x04004763 RID: 18275
			[Token(Token = "0x4004763")]
			[FieldOffset(Offset = "0x10")]
			public readonly double Ticks;

			// Token: 0x04004764 RID: 18276
			[Token(Token = "0x4004764")]
			[FieldOffset(Offset = "0x18")]
			public readonly double Total;
		}
	}
}
