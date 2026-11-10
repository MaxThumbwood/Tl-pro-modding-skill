using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat
{
	// Token: 0x02000917 RID: 2327
	[Token(Token = "0x2000917")]
	public static class ChatHelper
	{
		// Token: 0x06004E23 RID: 20003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E23")]
		[Address(RVA = "0x72EA08", Offset = "0x72EA08", VA = "0x72EA08")]
		public static void DisplayMessageOnClient(NetworkText text, Color color, int playerId)
		{
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E24")]
		[Address(RVA = "0x72ED88", Offset = "0x72ED88", VA = "0x72ED88")]
		public static void SendChatMessageToClient(NetworkText text, Color color, int playerId)
		{
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E25")]
		[Address(RVA = "0x72EE08", Offset = "0x72EE08", VA = "0x72EE08")]
		public static void SendChatMessageToClientAs(byte messageAuthor, NetworkText text, Color color, int playerId)
		{
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E26")]
		[Address(RVA = "0x72EF88", Offset = "0x72EF88", VA = "0x72EF88")]
		public static void BroadcastChatMessage(NetworkText text, Color color, int excludedPlayer = -1)
		{
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E27")]
		[Address(RVA = "0x72F008", Offset = "0x72F008", VA = "0x72F008")]
		public static void BroadcastChatMessageAs(byte messageAuthor, NetworkText text, Color color, int excludedPlayer = -1)
		{
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x000247C8 File Offset: 0x000229C8
		[Token(Token = "0x6004E28")]
		[Address(RVA = "0x72F340", Offset = "0x72F340", VA = "0x72F340")]
		public static bool OnlySendToPlayersWhoAreLoggedIn(int clientIndex)
		{
			return default(bool);
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E29")]
		[Address(RVA = "0x72F4EC", Offset = "0x72F4EC", VA = "0x72F4EC")]
		public static void SendChatMessageFromClient(ChatMessage message)
		{
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2A")]
		[Address(RVA = "0x72F5B8", Offset = "0x72F5B8", VA = "0x72F5B8")]
		public static void DisplayCheckedMessage(bool result, ChatHelper.ChatRequest request)
		{
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2B")]
		[Address(RVA = "0x72FA10", Offset = "0x72FA10", VA = "0x72FA10")]
		public static void PlatformCheckedMessage(string message, Color color, byte messageAuthor)
		{
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0x72EB84", Offset = "0x72EB84", VA = "0x72EB84")]
		public static void DisplayMessage(NetworkText text, Color color, byte messageAuthor, bool onlyCurrentPlayer = false)
		{
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x72F8B8", Offset = "0x72F8B8", VA = "0x72F8B8")]
		private static void CacheMessage(string message, Color color)
		{
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2E")]
		[Address(RVA = "0x72FE3C", Offset = "0x72FE3C", VA = "0x72FE3C")]
		public static void ShowCachedMessages()
		{
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0x730160", Offset = "0x730160", VA = "0x730160")]
		public static void ClearDelayedMessagesCache()
		{
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x000247E0 File Offset: 0x000229E0
		[Token(Token = "0x6004E30")]
		[Address(RVA = "0x72F830", Offset = "0x72F830", VA = "0x72F830")]
		private static bool ShouldCacheMessage()
		{
			return default(bool);
		}

		// Token: 0x040092EB RID: 37611
		[Token(Token = "0x40092EB")]
		[FieldOffset(Offset = "0x0")]
		private static List<Tuple<string, Color>> _cachedMessages;

		// Token: 0x040092EC RID: 37612
		[Token(Token = "0x40092EC")]
		[FieldOffset(Offset = "0x4")]
		private static byte broadcastMessageAuthor;

		// Token: 0x02000918 RID: 2328
		[Token(Token = "0x2000918")]
		public class ChatRequest
		{
			// Token: 0x06004E32 RID: 20018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E32")]
			[Address(RVA = "0x72FD58", Offset = "0x72FD58", VA = "0x72FD58")]
			public ChatRequest()
			{
			}

			// Token: 0x040092ED RID: 37613
			[Token(Token = "0x40092ED")]
			[FieldOffset(Offset = "0x8")]
			public PlatformUser LocalUser;

			// Token: 0x040092EE RID: 37614
			[Token(Token = "0x40092EE")]
			[FieldOffset(Offset = "0x10")]
			public PlatformUser SendingUser;

			// Token: 0x040092EF RID: 37615
			[Token(Token = "0x40092EF")]
			[FieldOffset(Offset = "0x18")]
			public ChatHelper.ChatRequest.ChatRequestCallback Callback;

			// Token: 0x040092F0 RID: 37616
			[Token(Token = "0x40092F0")]
			[FieldOffset(Offset = "0x1C")]
			public string message;

			// Token: 0x040092F1 RID: 37617
			[Token(Token = "0x40092F1")]
			[FieldOffset(Offset = "0x20")]
			public Color color;

			// Token: 0x040092F2 RID: 37618
			[Token(Token = "0x40092F2")]
			[FieldOffset(Offset = "0x24")]
			public byte messageAuthor;

			// Token: 0x040092F3 RID: 37619
			[Token(Token = "0x40092F3")]
			[FieldOffset(Offset = "0x25")]
			public bool result;

			// Token: 0x02000919 RID: 2329
			// (Invoke) Token: 0x06004E34 RID: 20020
			[Token(Token = "0x2000919")]
			public delegate void ChatRequestCallback(bool result, ChatHelper.ChatRequest request);
		}
	}
}
