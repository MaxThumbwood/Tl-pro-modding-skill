using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CBE RID: 3262
	[Token(Token = "0x2000CBE")]
	public class NetCreativePowersModule : NetModule
	{
		// Token: 0x06006109 RID: 24841 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
		[Token(Token = "0x6006109")]
		[Address(RVA = "0xAA39D8", Offset = "0xAA39D8", VA = "0xAA39D8")]
		public static NetPacket PreparePacket(ushort powerId, int specificInfoBytesInPacketCount)
		{
			return default(NetPacket);
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
		[Token(Token = "0x600610A")]
		[Address(RVA = "0xAA3AA0", Offset = "0xAA3AA0", VA = "0xAA3AA0", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610B")]
		[Address(RVA = "0xAA4050", Offset = "0xAA4050", VA = "0xAA4050")]
		public NetCreativePowersModule()
		{
		}

		// Token: 0x04009FBF RID: 40895
		[Token(Token = "0x4009FBF")]
		[FieldOffset(Offset = "0x0")]
		public static int specificPlrDeserialise;
	}
}
