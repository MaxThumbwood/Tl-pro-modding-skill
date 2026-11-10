using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CBD RID: 3261
	[Token(Token = "0x2000CBD")]
	public class NetCreativeUnlocksModule : NetModule
	{
		// Token: 0x06006106 RID: 24838 RVA: 0x0002CB98 File Offset: 0x0002AD98
		[Token(Token = "0x6006106")]
		[Address(RVA = "0xAA3750", Offset = "0xAA3750", VA = "0xAA3750")]
		public static NetPacket SerializeItemSacrifice(int itemId, int sacrificeCount)
		{
			return default(NetPacket);
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		[Token(Token = "0x6006107")]
		[Address(RVA = "0xAA3850", Offset = "0xAA3850", VA = "0xAA3850", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006108")]
		[Address(RVA = "0xAA39D0", Offset = "0xAA39D0", VA = "0xAA39D0")]
		public NetCreativeUnlocksModule()
		{
		}
	}
}
