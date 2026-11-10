using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000923 RID: 2339
	[Token(Token = "0x2000923")]
	public class DeathCommand : FileAPI
	{
		// Token: 0x06004E5D RID: 20061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E5D")]
		[Address(RVA = "0x731980", Offset = "0x731980", VA = "0x731980", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E5E")]
		[Address(RVA = "0x731DB4", Offset = "0x731DB4", VA = "0x731DB4", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E5F")]
		[Address(RVA = "0x731DB8", Offset = "0x731DB8", VA = "0x731DB8")]
		public DeathCommand()
		{
		}

		// Token: 0x04009305 RID: 37637
		[Token(Token = "0x4009305")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RESPONSE_COLOR;
	}
}
