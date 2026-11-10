using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CC2 RID: 3266
	[Token(Token = "0x2000CC2")]
	public class NetPingModule : NetModule
	{
		// Token: 0x06006117 RID: 24855 RVA: 0x0002CC88 File Offset: 0x0002AE88
		[Token(Token = "0x6006117")]
		[Address(RVA = "0xAA5060", Offset = "0xAA5060", VA = "0xAA5060")]
		public static NetPacket Serialize(Vector2 position)
		{
			return default(NetPacket);
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
		[Token(Token = "0x6006118")]
		[Address(RVA = "0xAA514C", Offset = "0xAA514C", VA = "0xAA514C", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006119")]
		[Address(RVA = "0xAA52F8", Offset = "0xAA52F8", VA = "0xAA52F8")]
		public NetPingModule()
		{
		}
	}
}
