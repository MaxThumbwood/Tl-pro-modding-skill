using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CBF RID: 3263
	[Token(Token = "0x2000CBF")]
	public class NetCreativeUnlocksPlayerReportModule : NetModule
	{
		// Token: 0x0600610D RID: 24845 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
		[Token(Token = "0x600610D")]
		[Address(RVA = "0xAA40AC", Offset = "0xAA40AC", VA = "0xAA40AC")]
		public static NetPacket SerializeSacrificeRequest(int userId, int itemId, int amount)
		{
			return default(NetPacket);
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x0002CC10 File Offset: 0x0002AE10
		[Token(Token = "0x600610E")]
		[Address(RVA = "0xAA41E4", Offset = "0xAA41E4", VA = "0xAA41E4", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610F")]
		[Address(RVA = "0xAA461C", Offset = "0xAA461C", VA = "0xAA461C")]
		public NetCreativeUnlocksPlayerReportModule()
		{
		}
	}
}
