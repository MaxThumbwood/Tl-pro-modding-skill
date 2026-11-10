using System;
using Il2CppDummyDll;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000932 RID: 2354
	[Token(Token = "0x2000932")]
	public class SayChatCommand : FileAPI
	{
		// Token: 0x06004E9B RID: 20123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9B")]
		[Address(RVA = "0x735D6C", Offset = "0x735D6C", VA = "0x735D6C", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9C")]
		[Address(RVA = "0x735FF4", Offset = "0x735FF4", VA = "0x735FF4", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9D")]
		[Address(RVA = "0x735FF8", Offset = "0x735FF8", VA = "0x735FF8")]
		public SayChatCommand()
		{
		}
	}
}
