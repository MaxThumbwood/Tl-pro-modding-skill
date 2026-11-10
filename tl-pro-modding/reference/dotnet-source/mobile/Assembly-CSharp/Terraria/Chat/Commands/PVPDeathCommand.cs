using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000924 RID: 2340
	[Token(Token = "0x2000924")]
	public class PVPDeathCommand : FileAPI
	{
		// Token: 0x06004E61 RID: 20065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E61")]
		[Address(RVA = "0x731E4C", Offset = "0x731E4C", VA = "0x731E4C", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E62")]
		[Address(RVA = "0x732280", Offset = "0x732280", VA = "0x732280", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E63")]
		[Address(RVA = "0x732284", Offset = "0x732284", VA = "0x732284")]
		public PVPDeathCommand()
		{
		}

		// Token: 0x04009306 RID: 37638
		[Token(Token = "0x4009306")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RESPONSE_COLOR;
	}
}
