using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CC3 RID: 3267
	[Token(Token = "0x2000CC3")]
	public class NetTeleportPylonModule : NetModule
	{
		// Token: 0x0600611A RID: 24858 RVA: 0x0002CCB8 File Offset: 0x0002AEB8
		[Token(Token = "0x600611A")]
		[Address(RVA = "0xAA5300", Offset = "0xAA5300", VA = "0xAA5300")]
		public static NetPacket SerializePylonWasAddedOrRemoved(TeleportPylonInfo info, NetTeleportPylonModule.SubPacketType packetType)
		{
			return default(NetPacket);
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x0002CCD0 File Offset: 0x0002AED0
		[Token(Token = "0x600611B")]
		[Address(RVA = "0xAA5470", Offset = "0xAA5470", VA = "0xAA5470")]
		public static NetPacket SerializeUseRequest(TeleportPylonInfo info)
		{
			return default(NetPacket);
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
		[Token(Token = "0x600611C")]
		[Address(RVA = "0xAA55DC", Offset = "0xAA55DC", VA = "0xAA55DC", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611D")]
		[Address(RVA = "0xAA58E0", Offset = "0xAA58E0", VA = "0xAA58E0")]
		public NetTeleportPylonModule()
		{
		}

		// Token: 0x02000CC4 RID: 3268
		[Token(Token = "0x2000CC4")]
		public enum SubPacketType : byte
		{
			// Token: 0x04009FC3 RID: 40899
			[Token(Token = "0x4009FC3")]
			PylonWasAdded,
			// Token: 0x04009FC4 RID: 40900
			[Token(Token = "0x4009FC4")]
			PylonWasRemoved,
			// Token: 0x04009FC5 RID: 40901
			[Token(Token = "0x4009FC5")]
			PlayerRequestsTeleport
		}
	}
}
