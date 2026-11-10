using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x02000683 RID: 1667
	[Token(Token = "0x2000683")]
	public class Weather_OldMobile
	{
		// Token: 0x0600400D RID: 16397 RVA: 0x0001F7B8 File Offset: 0x0001D9B8
		[Token(Token = "0x600400D")]
		[Address(RVA = "0x1EB9AF8", Offset = "0x1EB9AF8", VA = "0x1EB9AF8")]
		public bool Load(BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x0001F7D0 File Offset: 0x0001D9D0
		[Token(Token = "0x600400E")]
		[Address(RVA = "0x1EB9C00", Offset = "0x1EB9C00", VA = "0x1EB9C00")]
		public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600400F")]
		[Address(RVA = "0x1EB9CB4", Offset = "0x1EB9CB4", VA = "0x1EB9CB4")]
		public Weather_OldMobile()
		{
		}

		// Token: 0x04004B6E RID: 19310
		[Token(Token = "0x4004B6E")]
		[FieldOffset(Offset = "0x8")]
		private float cloudBGActive;
	}
}
