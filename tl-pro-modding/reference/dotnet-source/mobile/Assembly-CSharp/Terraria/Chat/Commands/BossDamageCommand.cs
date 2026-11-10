using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200091F RID: 2335
	[Token(Token = "0x200091F")]
	public class BossDamageCommand : FileAPI
	{
		// Token: 0x06004E55 RID: 20053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E55")]
		[Address(RVA = "0x731338", Offset = "0x731338", VA = "0x731338", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E56 RID: 20054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E56")]
		[Address(RVA = "0x7318CC", Offset = "0x7318CC", VA = "0x7318CC", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E57")]
		[Address(RVA = "0x7318D0", Offset = "0x7318D0", VA = "0x7318D0")]
		public BossDamageCommand()
		{
		}

		// Token: 0x04009303 RID: 37635
		[Token(Token = "0x4009303")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RESPONSE_COLOR;
	}
}
