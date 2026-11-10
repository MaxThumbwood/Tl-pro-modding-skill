using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	// Token: 0x0200089E RID: 2206
	[Token(Token = "0x200089E")]
	public class ChatMessageContainer
	{
		// Token: 0x06004AFB RID: 19195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFB")]
		[Address(RVA = "0x6418F0", Offset = "0x6418F0", VA = "0x6418F0")]
		public void SetContents(string text, Color color, int widthLimitInPixels)
		{
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFC")]
		[Address(RVA = "0x641C58", Offset = "0x641C58", VA = "0x641C58")]
		public void OnWidthLimitChanged()
		{
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFD")]
		[Address(RVA = "0x641C6C", Offset = "0x641C6C", VA = "0x641C6C")]
		public void Update()
		{
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AFE")]
		[Address(RVA = "0x641C80", Offset = "0x641C80", VA = "0x641C80")]
		public TextSnippet[] GetSnippetWithInversedIndex(int snippetIndex)
		{
			return null;
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06004AFF RID: 19199 RVA: 0x000239D0 File Offset: 0x00021BD0
		[Token(Token = "0x17000916")]
		public int LineCount
		{
			[Token(Token = "0x6004AFF")]
			[Address(RVA = "0x641D2C", Offset = "0x641D2C", VA = "0x641D2C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06004B00 RID: 19200 RVA: 0x000239E8 File Offset: 0x00021BE8
		[Token(Token = "0x17000917")]
		public bool CanBeShownWhenChatIsClosed
		{
			[Token(Token = "0x6004B00")]
			[Address(RVA = "0x641D84", Offset = "0x641D84", VA = "0x641D84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06004B01 RID: 19201 RVA: 0x00023A00 File Offset: 0x00021C00
		[Token(Token = "0x17000918")]
		public bool Prepared
		{
			[Token(Token = "0x6004B01")]
			[Address(RVA = "0x641D98", Offset = "0x641D98", VA = "0x641D98")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B02")]
		[Address(RVA = "0x6419A4", Offset = "0x6419A4", VA = "0x6419A4")]
		private void Refresh()
		{
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B03")]
		[Address(RVA = "0x641DA0", Offset = "0x641DA0", VA = "0x641DA0")]
		public ChatMessageContainer()
		{
		}

		// Token: 0x04009030 RID: 36912
		[Token(Token = "0x4009030")]
		[FieldOffset(Offset = "0x8")]
		public string OriginalText;

		// Token: 0x04009031 RID: 36913
		[Token(Token = "0x4009031")]
		[FieldOffset(Offset = "0xC")]
		private bool _prepared;

		// Token: 0x04009032 RID: 36914
		[Token(Token = "0x4009032")]
		[FieldOffset(Offset = "0x10")]
		private List<TextSnippet[]> _parsedText;

		// Token: 0x04009033 RID: 36915
		[Token(Token = "0x4009033")]
		[FieldOffset(Offset = "0x14")]
		private Color _color;

		// Token: 0x04009034 RID: 36916
		[Token(Token = "0x4009034")]
		[FieldOffset(Offset = "0x18")]
		private int _widthLimitInPixels;

		// Token: 0x04009035 RID: 36917
		[Token(Token = "0x4009035")]
		[FieldOffset(Offset = "0x1C")]
		private int _timeLeft;
	}
}
