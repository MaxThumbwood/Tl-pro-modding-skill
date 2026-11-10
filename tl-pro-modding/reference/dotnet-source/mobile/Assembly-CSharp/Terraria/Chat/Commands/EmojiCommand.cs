using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000929 RID: 2345
	[Token(Token = "0x2000929")]
	public class EmojiCommand : FileAPI, GUIControllerItem
	{
		// Token: 0x06004E75 RID: 20085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E75")]
		[Address(RVA = "0x7336F0", Offset = "0x7336F0", VA = "0x7336F0")]
		public EmojiCommand()
		{
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E76")]
		[Address(RVA = "0x733790", Offset = "0x733790", VA = "0x733790")]
		public void Initialize()
		{
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E77")]
		[Address(RVA = "0x7338D0", Offset = "0x7338D0", VA = "0x7338D0", Slot = "6")]
		public void PrepareAliases(ChatCommandProcessor commandProcessor)
		{
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E78")]
		[Address(RVA = "0x733B20", Offset = "0x733B20", VA = "0x733B20", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E79")]
		[Address(RVA = "0x733B24", Offset = "0x733B24", VA = "0x733B24", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7A")]
		[Address(RVA = "0x733FC0", Offset = "0x733FC0", VA = "0x733FC0")]
		public void PrintWarning(string text)
		{
		}

		// Token: 0x0400930F RID: 37647
		[Token(Token = "0x400930F")]
		public const int PlayerEmojiDuration = 360;

		// Token: 0x04009310 RID: 37648
		[Token(Token = "0x4009310")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<LocalizedText, int> _byName;

		// Token: 0x0200092A RID: 2346
		[Token(Token = "0x200092A")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004E7B RID: 20091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E7B")]
			[Address(RVA = "0x733B18", Offset = "0x733B18", VA = "0x733B18")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06004E7C RID: 20092 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E7C")]
			[Address(RVA = "0x734020", Offset = "0x734020", VA = "0x734020")]
			internal string <PrepareAliases>b__0()
			{
				return null;
			}

			// Token: 0x04009311 RID: 37649
			[Token(Token = "0x4009311")]
			[FieldOffset(Offset = "0x8")]
			public string name;
		}
	}
}
