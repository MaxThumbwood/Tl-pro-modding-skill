using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.Net
{
	// Token: 0x020007F7 RID: 2039
	[Token(Token = "0x20007F7")]
	public abstract class NetModule
	{
		// Token: 0x0600460D RID: 17933
		[Token(Token = "0x600460D")]
		public abstract bool Deserialize(BinaryReader reader, int userId);

		// Token: 0x0600460E RID: 17934 RVA: 0x000213F0 File Offset: 0x0001F5F0
		[Token(Token = "0x600460E")]
		protected static NetPacket CreatePacket<T>(int maxSize = 65530) where T : NetModule
		{
			return default(NetPacket);
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460F")]
		[Address(RVA = "0x58B070", Offset = "0x58B070", VA = "0x58B070")]
		protected NetModule()
		{
		}
	}
}
