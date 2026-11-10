using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000931 RID: 2353
	[Token(Token = "0x2000931")]
	public class RollCommand : FileAPI
	{
		// Token: 0x06004E97 RID: 20119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E97")]
		[Address(RVA = "0x73597C", Offset = "0x73597C", VA = "0x73597C", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E98")]
		[Address(RVA = "0x735CD4", Offset = "0x735CD4", VA = "0x735CD4", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E99")]
		[Address(RVA = "0x735CD8", Offset = "0x735CD8", VA = "0x735CD8")]
		public RollCommand()
		{
		}

		// Token: 0x04009319 RID: 37657
		[Token(Token = "0x4009319")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RESPONSE_COLOR;
	}
}
