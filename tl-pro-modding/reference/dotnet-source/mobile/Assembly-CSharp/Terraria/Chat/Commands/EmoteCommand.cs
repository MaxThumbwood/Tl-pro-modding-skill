using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200092C RID: 2348
	[Token(Token = "0x200092C")]
	public class EmoteCommand : FileAPI
	{
		// Token: 0x06004E80 RID: 20096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E80")]
		[Address(RVA = "0x734410", Offset = "0x734410", VA = "0x734410", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E81")]
		[Address(RVA = "0x734614", Offset = "0x734614", VA = "0x734614", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E82")]
		[Address(RVA = "0x734618", Offset = "0x734618", VA = "0x734618")]
		public EmoteCommand()
		{
		}

		// Token: 0x04009312 RID: 37650
		[Token(Token = "0x4009312")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RESPONSE_COLOR;
	}
}
