using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200092D RID: 2349
	[Token(Token = "0x200092D")]
	public class HelpCommand : FileAPI
	{
		// Token: 0x06004E84 RID: 20100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E84")]
		[Address(RVA = "0x73469C", Offset = "0x73469C", VA = "0x73469C", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E85")]
		[Address(RVA = "0x7347A0", Offset = "0x7347A0", VA = "0x7347A0")]
		private static Dictionary<string, List<LocalizedText>> GetCommandAliasesByID()
		{
			return null;
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E86")]
		[Address(RVA = "0x734B24", Offset = "0x734B24", VA = "0x734B24")]
		private static NetworkText ComposeMessage(Dictionary<string, List<LocalizedText>> aliases)
		{
			return null;
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E87")]
		[Address(RVA = "0x734FA0", Offset = "0x734FA0", VA = "0x734FA0", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E88")]
		[Address(RVA = "0x734FA4", Offset = "0x734FA4", VA = "0x734FA4")]
		public HelpCommand()
		{
		}

		// Token: 0x04009313 RID: 37651
		[Token(Token = "0x4009313")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RESPONSE_COLOR;
	}
}
