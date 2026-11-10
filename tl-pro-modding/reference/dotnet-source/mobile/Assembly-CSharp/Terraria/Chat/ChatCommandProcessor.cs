using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Chat.Commands;
using Terraria.Localization;

namespace Terraria.Chat
{
	// Token: 0x0200091B RID: 2331
	[Token(Token = "0x200091B")]
	public class ChatCommandProcessor : FileAPI
	{
		// Token: 0x06004E3C RID: 20028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3C")]
		public ChatCommandProcessor AddCommand<T>() where T : IChatCommand, new()
		{
			return null;
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x7304B4", Offset = "0x7304B4", VA = "0x7304B4")]
		public void AddAlias(LocalizedText alias, Func<string> result)
		{
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3E")]
		[Address(RVA = "0x730528", Offset = "0x730528", VA = "0x730528")]
		public void PrepareAliases()
		{
		}

		// Token: 0x06004E3F RID: 20031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3F")]
		public ChatCommandProcessor AddDefaultCommand<T>() where T : IChatCommand, new()
		{
			return null;
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x00024840 File Offset: 0x00022A40
		[Token(Token = "0x6004E40")]
		private static bool ParseCommandPrefix<T>(string text, Dictionary<LocalizedText, T> commands, out string remainder, out T value)
		{
			return default(bool);
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E41")]
		[Address(RVA = "0x7307F8", Offset = "0x7307F8", VA = "0x7307F8", Slot = "5")]
		public ChatMessage CreateOutgoingMessage(string text)
		{
			return null;
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E42")]
		[Address(RVA = "0x730B60", Offset = "0x730B60", VA = "0x730B60", Slot = "4")]
		public void ProcessIncomingMessage(ChatMessage message, int clientId)
		{
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E43")]
		[Address(RVA = "0x730D08", Offset = "0x730D08", VA = "0x730D08")]
		public ChatCommandProcessor()
		{
		}

		// Token: 0x040092F5 RID: 37621
		[Token(Token = "0x40092F5")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<LocalizedText, ChatCommandId> _localizedCommands;

		// Token: 0x040092F6 RID: 37622
		[Token(Token = "0x40092F6")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<ChatCommandId, IChatCommand> _commands;

		// Token: 0x040092F7 RID: 37623
		[Token(Token = "0x40092F7")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<LocalizedText, Func<string>> _aliases;

		// Token: 0x040092F8 RID: 37624
		[Token(Token = "0x40092F8")]
		[FieldOffset(Offset = "0x14")]
		private IChatCommand _defaultCommand;
	}
}
