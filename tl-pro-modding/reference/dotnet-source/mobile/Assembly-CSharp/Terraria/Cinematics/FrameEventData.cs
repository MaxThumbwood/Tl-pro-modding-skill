using System;
using Il2CppDummyDll;

namespace Terraria.Cinematics
{
	// Token: 0x02000913 RID: 2323
	[Token(Token = "0x2000913")]
	public struct FrameEventData
	{
		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06004E01 RID: 19969 RVA: 0x00024678 File Offset: 0x00022878
		[Token(Token = "0x17000963")]
		public int AbsoluteFrame
		{
			[Token(Token = "0x6004E01")]
			[Address(RVA = "0x72E848", Offset = "0x72E848", VA = "0x72E848")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06004E02 RID: 19970 RVA: 0x00024690 File Offset: 0x00022890
		[Token(Token = "0x17000964")]
		public int Start
		{
			[Token(Token = "0x6004E02")]
			[Address(RVA = "0x72E850", Offset = "0x72E850", VA = "0x72E850")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06004E03 RID: 19971 RVA: 0x000246A8 File Offset: 0x000228A8
		[Token(Token = "0x17000965")]
		public int Duration
		{
			[Token(Token = "0x6004E03")]
			[Address(RVA = "0x72E858", Offset = "0x72E858", VA = "0x72E858")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06004E04 RID: 19972 RVA: 0x000246C0 File Offset: 0x000228C0
		[Token(Token = "0x17000966")]
		public int Frame
		{
			[Token(Token = "0x6004E04")]
			[Address(RVA = "0x72B710", Offset = "0x72B710", VA = "0x72B710")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06004E05 RID: 19973 RVA: 0x000246D8 File Offset: 0x000228D8
		[Token(Token = "0x17000967")]
		public bool IsFirstFrame
		{
			[Token(Token = "0x6004E05")]
			[Address(RVA = "0x72A4D4", Offset = "0x72A4D4", VA = "0x72A4D4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06004E06 RID: 19974 RVA: 0x000246F0 File Offset: 0x000228F0
		[Token(Token = "0x17000968")]
		public bool IsLastFrame
		{
			[Token(Token = "0x6004E06")]
			[Address(RVA = "0x72E860", Offset = "0x72E860", VA = "0x72E860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06004E07 RID: 19975 RVA: 0x00024708 File Offset: 0x00022908
		[Token(Token = "0x17000969")]
		public int Remaining
		{
			[Token(Token = "0x6004E07")]
			[Address(RVA = "0x72B720", Offset = "0x72B720", VA = "0x72B720")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E08")]
		[Address(RVA = "0x72E880", Offset = "0x72E880", VA = "0x72E880")]
		public FrameEventData(int absoluteFrame, int start, int duration)
		{
		}

		// Token: 0x040092E0 RID: 37600
		[Token(Token = "0x40092E0")]
		[FieldOffset(Offset = "0x0")]
		private int _absoluteFrame;

		// Token: 0x040092E1 RID: 37601
		[Token(Token = "0x40092E1")]
		[FieldOffset(Offset = "0x4")]
		private int _start;

		// Token: 0x040092E2 RID: 37602
		[Token(Token = "0x40092E2")]
		[FieldOffset(Offset = "0x8")]
		private int _duration;
	}
}
