using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000930 RID: 2352
	[Token(Token = "0x2000930")]
	public class PartyChatCommand : FileAPI
	{
		// Token: 0x06004E92 RID: 20114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E92")]
		[Address(RVA = "0x735524", Offset = "0x735524", VA = "0x735524", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E93")]
		[Address(RVA = "0x7358E4", Offset = "0x7358E4", VA = "0x7358E4", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E94")]
		[Address(RVA = "0x735780", Offset = "0x735780", VA = "0x735780")]
		private void SendNoTeamError(byte clientId)
		{
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E95")]
		[Address(RVA = "0x7358E8", Offset = "0x7358E8", VA = "0x7358E8")]
		public PartyChatCommand()
		{
		}

		// Token: 0x04009318 RID: 37656
		[Token(Token = "0x4009318")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color ERROR_COLOR;
	}
}
