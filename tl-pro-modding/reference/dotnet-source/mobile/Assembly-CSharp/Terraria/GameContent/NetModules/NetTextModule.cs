using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;
using Terraria.Localization;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CC5 RID: 3269
	[Token(Token = "0x2000CC5")]
	public class NetTextModule : NetModule
	{
		// Token: 0x0600611E RID: 24862 RVA: 0x0002CD00 File Offset: 0x0002AF00
		[Token(Token = "0x600611E")]
		[Address(RVA = "0xAA58E8", Offset = "0xAA58E8", VA = "0xAA58E8")]
		public static NetPacket SerializeClientMessage(ChatMessage message)
		{
			return default(NetPacket);
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x0002CD18 File Offset: 0x0002AF18
		[Token(Token = "0x600611F")]
		[Address(RVA = "0xAA59A8", Offset = "0xAA59A8", VA = "0xAA59A8")]
		public static NetPacket SerializeServerMessage(NetworkText text, Color color)
		{
			return default(NetPacket);
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x0002CD30 File Offset: 0x0002AF30
		[Token(Token = "0x6006120")]
		[Address(RVA = "0xAA59D8", Offset = "0xAA59D8", VA = "0xAA59D8")]
		public static NetPacket SerializeServerMessage(NetworkText text, Color color, byte authorId)
		{
			return default(NetPacket);
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x0002CD48 File Offset: 0x0002AF48
		[Token(Token = "0x6006121")]
		[Address(RVA = "0xAA5B24", Offset = "0xAA5B24", VA = "0xAA5B24")]
		private bool DeserializeAsClient(BinaryReader reader, int senderPlayerId)
		{
			return default(bool);
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x0002CD60 File Offset: 0x0002AF60
		[Token(Token = "0x6006122")]
		[Address(RVA = "0xAA5C50", Offset = "0xAA5C50", VA = "0xAA5C50")]
		private bool DeserializeAsServer(BinaryReader reader, int senderPlayerId)
		{
			return default(bool);
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x0002CD78 File Offset: 0x0002AF78
		[Token(Token = "0x6006123")]
		[Address(RVA = "0xAA5CF0", Offset = "0xAA5CF0", VA = "0xAA5CF0", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int senderPlayerId)
		{
			return default(bool);
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006124")]
		[Address(RVA = "0xAA5E00", Offset = "0xAA5E00", VA = "0xAA5E00")]
		public NetTextModule()
		{
		}
	}
}
