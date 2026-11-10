using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000793 RID: 1939
	[Token(Token = "0x2000793")]
	public struct PlayerMovementAccsCache
	{
		// Token: 0x06004412 RID: 17426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004412")]
		[Address(RVA = "0x55836C", Offset = "0x55836C", VA = "0x55836C")]
		public void CopyFrom(Player player)
		{
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x558430", Offset = "0x558430", VA = "0x558430")]
		public void PasteInto(Player player)
		{
		}

		// Token: 0x04008BAF RID: 35759
		[Token(Token = "0x4008BAF")]
		[FieldOffset(Offset = "0x0")]
		private bool _readyToPaste;

		// Token: 0x04008BB0 RID: 35760
		[Token(Token = "0x4008BB0")]
		[FieldOffset(Offset = "0x1")]
		private bool _mountPreventedFlight;

		// Token: 0x04008BB1 RID: 35761
		[Token(Token = "0x4008BB1")]
		[FieldOffset(Offset = "0x2")]
		private bool _mountPreventedExtraJumps;

		// Token: 0x04008BB2 RID: 35762
		[Token(Token = "0x4008BB2")]
		[FieldOffset(Offset = "0x4")]
		private int rocketTime;

		// Token: 0x04008BB3 RID: 35763
		[Token(Token = "0x4008BB3")]
		[FieldOffset(Offset = "0x8")]
		private float wingTime;

		// Token: 0x04008BB4 RID: 35764
		[Token(Token = "0x4008BB4")]
		[FieldOffset(Offset = "0xC")]
		private int rocketDelay;

		// Token: 0x04008BB5 RID: 35765
		[Token(Token = "0x4008BB5")]
		[FieldOffset(Offset = "0x10")]
		private int rocketDelay2;

		// Token: 0x04008BB6 RID: 35766
		[Token(Token = "0x4008BB6")]
		[FieldOffset(Offset = "0x14")]
		private bool jumpAgainCloud;

		// Token: 0x04008BB7 RID: 35767
		[Token(Token = "0x4008BB7")]
		[FieldOffset(Offset = "0x15")]
		private bool jumpAgainSandstorm;

		// Token: 0x04008BB8 RID: 35768
		[Token(Token = "0x4008BB8")]
		[FieldOffset(Offset = "0x16")]
		private bool jumpAgainBlizzard;

		// Token: 0x04008BB9 RID: 35769
		[Token(Token = "0x4008BB9")]
		[FieldOffset(Offset = "0x17")]
		private bool jumpAgainFart;

		// Token: 0x04008BBA RID: 35770
		[Token(Token = "0x4008BBA")]
		[FieldOffset(Offset = "0x18")]
		private bool jumpAgainSail;

		// Token: 0x04008BBB RID: 35771
		[Token(Token = "0x4008BBB")]
		[FieldOffset(Offset = "0x19")]
		private bool jumpAgainUnicorn;
	}
}
