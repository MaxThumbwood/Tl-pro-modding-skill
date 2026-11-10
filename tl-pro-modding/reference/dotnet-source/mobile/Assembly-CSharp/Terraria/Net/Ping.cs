using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Terraria.Net
{
	// Token: 0x020007F9 RID: 2041
	[Token(Token = "0x20007F9")]
	public class Ping
	{
		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x00021420 File Offset: 0x0001F620
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000866")]
		public static int CurrentPing
		{
			[Token(Token = "0x6004617")]
			[Address(RVA = "0x58B280", Offset = "0x58B280", VA = "0x58B280")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004618")]
			[Address(RVA = "0x58B2E4", Offset = "0x58B2E4", VA = "0x58B2E4")]
			private set
			{
			}
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004619")]
		[Address(RVA = "0x58B34C", Offset = "0x58B34C", VA = "0x58B34C")]
		public static void Reset()
		{
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461A")]
		[Address(RVA = "0x58B420", Offset = "0x58B420", VA = "0x58B420")]
		public static void Update()
		{
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461B")]
		[Address(RVA = "0x58B6A4", Offset = "0x58B6A4", VA = "0x58B6A4")]
		internal static void PingRecieved()
		{
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461C")]
		[Address(RVA = "0x58B77C", Offset = "0x58B77C", VA = "0x58B77C")]
		public Ping()
		{
		}

		// Token: 0x04008D2C RID: 36140
		[Token(Token = "0x4008D2C")]
		[FieldOffset(Offset = "0x0")]
		private static int <CurrentPing>k__BackingField;

		// Token: 0x04008D2D RID: 36141
		[Token(Token = "0x4008D2D")]
		[FieldOffset(Offset = "0x4")]
		private static Stopwatch _stopwatch;

		// Token: 0x04008D2E RID: 36142
		[Token(Token = "0x4008D2E")]
		[FieldOffset(Offset = "0x8")]
		private static bool _waitingForResponse;
	}
}
