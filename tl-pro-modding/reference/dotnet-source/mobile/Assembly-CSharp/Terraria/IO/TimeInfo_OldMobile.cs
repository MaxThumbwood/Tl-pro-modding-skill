using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x02000682 RID: 1666
	[Token(Token = "0x2000682")]
	public class TimeInfo_OldMobile
	{
		// Token: 0x0600400A RID: 16394 RVA: 0x0001F788 File Offset: 0x0001D988
		[Token(Token = "0x600400A")]
		[Address(RVA = "0x1EB97CC", Offset = "0x1EB97CC", VA = "0x1EB97CC")]
		public bool Load(BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		[Token(Token = "0x600400B")]
		[Address(RVA = "0x1EB99E0", Offset = "0x1EB99E0", VA = "0x1EB99E0")]
		public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600400C")]
		[Address(RVA = "0x1EB9AF0", Offset = "0x1EB9AF0", VA = "0x1EB9AF0")]
		public TimeInfo_OldMobile()
		{
		}

		// Token: 0x04004B6B RID: 19307
		[Token(Token = "0x4004B6B")]
		[FieldOffset(Offset = "0x8")]
		private short totalDays;

		// Token: 0x04004B6C RID: 19308
		[Token(Token = "0x4004B6C")]
		[FieldOffset(Offset = "0xA")]
		private byte moonType;

		// Token: 0x04004B6D RID: 19309
		[Token(Token = "0x4004B6D")]
		[FieldOffset(Offset = "0xC")]
		public short daysSinceHardmode;
	}
}
