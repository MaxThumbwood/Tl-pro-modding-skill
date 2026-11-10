using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000DAA RID: 3498
	[Token(Token = "0x2000DAA")]
	public class RemadeChatMonitor : FileAPI
	{
		// Token: 0x06006724 RID: 26404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006724")]
		[Address(RVA = "0xB6C224", Offset = "0xB6C224", VA = "0xB6C224")]
		public RemadeChatMonitor()
		{
		}

		// Token: 0x06006725 RID: 26405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006725")]
		[Address(RVA = "0xB6C2CC", Offset = "0xB6C2CC", VA = "0xB6C2CC", Slot = "4")]
		public void NewText(string newText, byte R = 255, byte G = 255, byte B = 255)
		{
		}

		// Token: 0x06006726 RID: 26406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006726")]
		[Address(RVA = "0xB6C48C", Offset = "0xB6C48C", VA = "0xB6C48C", Slot = "5")]
		public void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1)
		{
		}

		// Token: 0x06006727 RID: 26407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006727")]
		[Address(RVA = "0xB6C31C", Offset = "0xB6C31C", VA = "0xB6C31C")]
		public void AddNewMessage(string text, Color color, int widthLimitInPixels = -1)
		{
		}

		// Token: 0x06006728 RID: 26408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006728")]
		[Address(RVA = "0xB6C4A8", Offset = "0xB6C4A8", VA = "0xB6C4A8")]
		public void DrawChat(bool drawingPlayerChat)
		{
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006729")]
		[Address(RVA = "0xB6CB78", Offset = "0xB6CB78", VA = "0xB6CB78", Slot = "6")]
		public void Clear()
		{
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672A")]
		[Address(RVA = "0xB6CBF8", Offset = "0xB6CBF8", VA = "0xB6CBF8", Slot = "7")]
		public void Update()
		{
		}

		// Token: 0x0600672B RID: 26411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672B")]
		[Address(RVA = "0xB6CD94", Offset = "0xB6CD94", VA = "0xB6CD94", Slot = "8")]
		public void Offset(int linesOffset)
		{
		}

		// Token: 0x0600672C RID: 26412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672C")]
		[Address(RVA = "0xB6CDA4", Offset = "0xB6CDA4", VA = "0xB6CDA4")]
		private void ClampMessageIndex()
		{
		}

		// Token: 0x0600672D RID: 26413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672D")]
		[Address(RVA = "0xB6CF80", Offset = "0xB6CF80", VA = "0xB6CF80", Slot = "9")]
		public void ResetOffset()
		{
		}

		// Token: 0x0400A42C RID: 42028
		[Token(Token = "0x400A42C")]
		private const int MaxMessages = 500;

		// Token: 0x0400A42D RID: 42029
		[Token(Token = "0x400A42D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int _showCount;

		// Token: 0x0400A42E RID: 42030
		[Token(Token = "0x400A42E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int _startChatLine;

		// Token: 0x0400A42F RID: 42031
		[Token(Token = "0x400A42F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<ChatMessageContainer> _messages;

		// Token: 0x0400A430 RID: 42032
		[Token(Token = "0x400A430")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _lastChatWidthLimit;
	}
}
