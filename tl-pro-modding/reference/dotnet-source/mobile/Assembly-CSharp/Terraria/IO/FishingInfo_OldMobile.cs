using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x02000676 RID: 1654
	[Token(Token = "0x2000676")]
	public class FishingInfo_OldMobile
	{
		// Token: 0x06003FE4 RID: 16356 RVA: 0x0001F608 File Offset: 0x0001D808
		[Token(Token = "0x6003FE4")]
		[Address(RVA = "0x1E8BBB0", Offset = "0x1E8BBB0", VA = "0x1E8BBB0")]
		public bool Load(BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE5")]
		[Address(RVA = "0x1E8BD84", Offset = "0x1E8BD84", VA = "0x1E8BD84")]
		public FishingInfo_OldMobile()
		{
		}

		// Token: 0x0400499D RID: 18845
		[Token(Token = "0x400499D")]
		[FieldOffset(Offset = "0x8")]
		private short currentQuest;

		// Token: 0x0400499E RID: 18846
		[Token(Token = "0x400499E")]
		[FieldOffset(Offset = "0xA")]
		private bool questCompletedToday;

		// Token: 0x0400499F RID: 18847
		[Token(Token = "0x400499F")]
		[FieldOffset(Offset = "0xC")]
		private List<string> playersCompleted;
	}
}
