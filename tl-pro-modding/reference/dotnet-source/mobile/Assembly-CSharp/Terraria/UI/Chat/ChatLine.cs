using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	// Token: 0x0200089D RID: 2205
	[Token(Token = "0x200089D")]
	public class ChatLine
	{
		// Token: 0x06004AF8 RID: 19192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x6416A0", Offset = "0x6416A0", VA = "0x6416A0")]
		public void UpdateTimeLeft()
		{
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x6416B4", Offset = "0x6416B4", VA = "0x6416B4")]
		public void Copy(ChatLine other)
		{
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x6417F8", Offset = "0x6417F8", VA = "0x6417F8")]
		public ChatLine()
		{
		}

		// Token: 0x04009025 RID: 36901
		[Token(Token = "0x4009025")]
		[FieldOffset(Offset = "0x8")]
		public Color color;

		// Token: 0x04009026 RID: 36902
		[Token(Token = "0x4009026")]
		[FieldOffset(Offset = "0xC")]
		public int showTime;

		// Token: 0x04009027 RID: 36903
		[Token(Token = "0x4009027")]
		[FieldOffset(Offset = "0x10")]
		public string originalText;

		// Token: 0x04009028 RID: 36904
		[Token(Token = "0x4009028")]
		[FieldOffset(Offset = "0x14")]
		public TextSnippet[] parsedNotification;

		// Token: 0x04009029 RID: 36905
		[Token(Token = "0x4009029")]
		[FieldOffset(Offset = "0x18")]
		public TextSnippet[] parsedNotificationTouch;

		// Token: 0x0400902A RID: 36906
		[Token(Token = "0x400902A")]
		[FieldOffset(Offset = "0x1C")]
		public TextSnippet[] parsedMini;

		// Token: 0x0400902B RID: 36907
		[Token(Token = "0x400902B")]
		[FieldOffset(Offset = "0x20")]
		public TextSnippet[] parsedOverlay;

		// Token: 0x0400902C RID: 36908
		[Token(Token = "0x400902C")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 calculatedSizeNotification;

		// Token: 0x0400902D RID: 36909
		[Token(Token = "0x400902D")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 calculatedSizeNotificationTouch;

		// Token: 0x0400902E RID: 36910
		[Token(Token = "0x400902E")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 calculatedSizeMini;

		// Token: 0x0400902F RID: 36911
		[Token(Token = "0x400902F")]
		[FieldOffset(Offset = "0x3C")]
		public Vector2 calculatedSizeOverlay;
	}
}
