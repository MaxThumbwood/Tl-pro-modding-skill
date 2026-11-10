using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CC0 RID: 3264
	[Token(Token = "0x2000CC0")]
	public class NetCreativePowerPermissionsModule : NetModule
	{
		// Token: 0x06006110 RID: 24848 RVA: 0x0002CC28 File Offset: 0x0002AE28
		[Token(Token = "0x6006110")]
		[Address(RVA = "0xAA4624", Offset = "0xAA4624", VA = "0xAA4624")]
		public static NetPacket SerializeCurrentPowerPermissionLevel(ushort powerId, int level)
		{
			return default(NetPacket);
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x0002CC40 File Offset: 0x0002AE40
		[Token(Token = "0x6006111")]
		[Address(RVA = "0xAA4758", Offset = "0xAA4758", VA = "0xAA4758", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006112")]
		[Address(RVA = "0xAA4CD8", Offset = "0xAA4CD8", VA = "0xAA4CD8")]
		public NetCreativePowerPermissionsModule()
		{
		}

		// Token: 0x04009FC0 RID: 40896
		[Token(Token = "0x4009FC0")]
		private const byte _setPermissionLevelId = 0;

		// Token: 0x04009FC1 RID: 40897
		[Token(Token = "0x4009FC1")]
		[FieldOffset(Offset = "0x0")]
		public static int specificPlrDeserialise;
	}
}
