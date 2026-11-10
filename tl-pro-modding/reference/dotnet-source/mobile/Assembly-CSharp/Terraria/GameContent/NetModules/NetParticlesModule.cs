using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.GameContent.Drawing;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CC1 RID: 3265
	[Token(Token = "0x2000CC1")]
	public class NetParticlesModule : NetModule
	{
		// Token: 0x06006114 RID: 24852 RVA: 0x0002CC58 File Offset: 0x0002AE58
		[Token(Token = "0x6006114")]
		[Address(RVA = "0xAA4D34", Offset = "0xAA4D34", VA = "0xAA4D34")]
		public static NetPacket Serialize(ParticleOrchestraType particleType, ParticleOrchestraSettings settings)
		{
			return default(NetPacket);
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x0002CC70 File Offset: 0x0002AE70
		[Token(Token = "0x6006115")]
		[Address(RVA = "0xAA4E3C", Offset = "0xAA4E3C", VA = "0xAA4E3C", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006116")]
		[Address(RVA = "0xAA5058", Offset = "0xAA5058", VA = "0xAA5058")]
		public NetParticlesModule()
		{
		}
	}
}
