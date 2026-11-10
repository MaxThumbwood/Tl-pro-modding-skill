using System;
using Il2CppDummyDll;

namespace Terraria.Chat
{
	// Token: 0x0200091E RID: 2334
	[Token(Token = "0x200091E")]
	public interface IChatProcessor
	{
		// Token: 0x06004E53 RID: 20051
		[Token(Token = "0x6004E53")]
		void ProcessIncomingMessage(ChatMessage message, int clientId);

		// Token: 0x06004E54 RID: 20052
		[Token(Token = "0x6004E54")]
		ChatMessage CreateOutgoingMessage(string text);
	}
}
