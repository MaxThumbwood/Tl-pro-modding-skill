using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CBB RID: 3259
	[Token(Token = "0x2000CBB")]
	public class NetBestiaryModule : NetModule
	{
		// Token: 0x06006101 RID: 24833 RVA: 0x0002CB38 File Offset: 0x0002AD38
		[Token(Token = "0x6006101")]
		[Address(RVA = "0xAA3048", Offset = "0xAA3048", VA = "0xAA3048")]
		public static NetPacket SerializeKillCount(int npcNetId, int killcount)
		{
			return default(NetPacket);
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x0002CB50 File Offset: 0x0002AD50
		[Token(Token = "0x6006102")]
		[Address(RVA = "0xAA3198", Offset = "0xAA3198", VA = "0xAA3198")]
		public static NetPacket SerializeSight(int npcNetId)
		{
			return default(NetPacket);
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x0002CB68 File Offset: 0x0002AD68
		[Token(Token = "0x6006103")]
		[Address(RVA = "0xAA3294", Offset = "0xAA3294", VA = "0xAA3294")]
		public static NetPacket SerializeChat(int npcNetId)
		{
			return default(NetPacket);
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x0002CB80 File Offset: 0x0002AD80
		[Token(Token = "0x6006104")]
		[Address(RVA = "0xAA3390", Offset = "0xAA3390", VA = "0xAA3390", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006105")]
		[Address(RVA = "0xAA3748", Offset = "0xAA3748", VA = "0xAA3748")]
		public NetBestiaryModule()
		{
		}

		// Token: 0x02000CBC RID: 3260
		[Token(Token = "0x2000CBC")]
		private enum BestiaryUnlockType : byte
		{
			// Token: 0x04009FBC RID: 40892
			[Token(Token = "0x4009FBC")]
			Kill,
			// Token: 0x04009FBD RID: 40893
			[Token(Token = "0x4009FBD")]
			Sight,
			// Token: 0x04009FBE RID: 40894
			[Token(Token = "0x4009FBE")]
			Chat
		}
	}
}
