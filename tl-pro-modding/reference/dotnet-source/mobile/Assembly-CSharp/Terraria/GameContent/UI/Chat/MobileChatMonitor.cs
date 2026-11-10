using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000DA9 RID: 3497
	[Token(Token = "0x2000DA9")]
	public class MobileChatMonitor : FileAPI
	{
		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600671B RID: 26395 RVA: 0x0002E818 File Offset: 0x0002CA18
		[Token(Token = "0x17000B0B")]
		public int TextMaxLengthForScreen
		{
			[Token(Token = "0x600671B")]
			[Address(RVA = "0xB6BA40", Offset = "0xB6BA40", VA = "0xB6BA40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600671C")]
		[Address(RVA = "0xB6BAA4", Offset = "0xB6BAA4", VA = "0xB6BAA4")]
		public MobileChatMonitor()
		{
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600671D")]
		[Address(RVA = "0xB6BBD8", Offset = "0xB6BBD8", VA = "0xB6BBD8", Slot = "6")]
		public void Clear()
		{
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600671E")]
		[Address(RVA = "0xB6BD0C", Offset = "0xB6BD0C", VA = "0xB6BD0C", Slot = "9")]
		public void ResetOffset()
		{
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600671F")]
		[Address(RVA = "0xB6BD18", Offset = "0xB6BD18", VA = "0xB6BD18", Slot = "7")]
		public void Update()
		{
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006720")]
		[Address(RVA = "0xB6BD54", Offset = "0xB6BD54", VA = "0xB6BD54", Slot = "8")]
		public void Offset(int linesOffset)
		{
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006721")]
		[Address(RVA = "0xB6BF44", Offset = "0xB6BF44", VA = "0xB6BF44", Slot = "4")]
		public void NewText(string newText, byte R = 255, byte G = 255, byte B = 255)
		{
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006722")]
		[Address(RVA = "0xB6BF64", Offset = "0xB6BF64", VA = "0xB6BF64")]
		public void NewTextInternal(string newText, byte R = 255, byte G = 255, byte B = 255, bool force = false)
		{
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006723")]
		[Address(RVA = "0xB6C14C", Offset = "0xB6C14C", VA = "0xB6C14C", Slot = "5")]
		public void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1)
		{
		}

		// Token: 0x0400A426 RID: 42022
		[Token(Token = "0x400A426")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int numChatLines;

		// Token: 0x0400A427 RID: 42023
		[Token(Token = "0x400A427")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ChatLine[] chatLine;

		// Token: 0x0400A428 RID: 42024
		[Token(Token = "0x400A428")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int chatLength;

		// Token: 0x0400A429 RID: 42025
		[Token(Token = "0x400A429")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int showCount;

		// Token: 0x0400A42A RID: 42026
		[Token(Token = "0x400A42A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int startChatLine;

		// Token: 0x0400A42B RID: 42027
		[Token(Token = "0x400A42B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int numChatItems;
	}
}
