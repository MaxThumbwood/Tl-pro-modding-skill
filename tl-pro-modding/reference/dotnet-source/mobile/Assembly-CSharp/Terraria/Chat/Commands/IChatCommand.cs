using System;
using Il2CppDummyDll;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000921 RID: 2337
	[Token(Token = "0x2000921")]
	public interface IChatCommand
	{
		// Token: 0x06004E5A RID: 20058
		[Token(Token = "0x6004E5A")]
		void ProcessIncomingMessage(string text, byte clientId);

		// Token: 0x06004E5B RID: 20059
		[Token(Token = "0x6004E5B")]
		void ProcessOutgoingMessage(ChatMessage message);
	}
}
