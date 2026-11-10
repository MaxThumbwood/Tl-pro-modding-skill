using System;
using Il2CppDummyDll;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000922 RID: 2338
	[Token(Token = "0x2000922")]
	public interface ICommandAliasProvider
	{
		// Token: 0x06004E5C RID: 20060
		[Token(Token = "0x6004E5C")]
		void PrepareAliases(ChatCommandProcessor commandProcessor);
	}
}
