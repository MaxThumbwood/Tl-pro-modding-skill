using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200092E RID: 2350
	[Token(Token = "0x200092E")]
	public class ListPlayersCommand : FileAPI
	{
		// Token: 0x06004E8A RID: 20106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E8A")]
		[Address(RVA = "0x735038", Offset = "0x735038", VA = "0x735038", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E8B")]
		[Address(RVA = "0x7353C8", Offset = "0x7353C8", VA = "0x7353C8", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E8C")]
		[Address(RVA = "0x7353CC", Offset = "0x7353CC", VA = "0x7353CC")]
		public ListPlayersCommand()
		{
		}

		// Token: 0x04009314 RID: 37652
		[Token(Token = "0x4009314")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RESPONSE_COLOR;

		// Token: 0x0200092F RID: 2351
		[Token(Token = "0x200092F")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E8F RID: 20111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E8F")]
			[Address(RVA = "0x7354D4", Offset = "0x7354D4", VA = "0x7354D4")]
			public <>c()
			{
			}

			// Token: 0x06004E90 RID: 20112 RVA: 0x00024900 File Offset: 0x00022B00
			[Token(Token = "0x6004E90")]
			[Address(RVA = "0x7354DC", Offset = "0x7354DC", VA = "0x7354DC")]
			internal bool <ProcessIncomingMessage>b__1_0(Player player)
			{
				return default(bool);
			}

			// Token: 0x06004E91 RID: 20113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E91")]
			[Address(RVA = "0x735500", Offset = "0x735500", VA = "0x735500")]
			internal string <ProcessIncomingMessage>b__1_1(Player player)
			{
				return null;
			}

			// Token: 0x04009315 RID: 37653
			[Token(Token = "0x4009315")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ListPlayersCommand.<>c <>9;

			// Token: 0x04009316 RID: 37654
			[Token(Token = "0x4009316")]
			[FieldOffset(Offset = "0x4")]
			public static Func<Player, bool> <>9__1_0;

			// Token: 0x04009317 RID: 37655
			[Token(Token = "0x4009317")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Player, string> <>9__1_1;
		}
	}
}
