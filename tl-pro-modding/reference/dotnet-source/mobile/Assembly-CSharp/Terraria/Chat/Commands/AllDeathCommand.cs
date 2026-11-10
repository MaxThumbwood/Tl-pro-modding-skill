using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000925 RID: 2341
	[Token(Token = "0x2000925")]
	public class AllDeathCommand : FileAPI
	{
		// Token: 0x06004E65 RID: 20069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E65")]
		[Address(RVA = "0x732318", Offset = "0x732318", VA = "0x732318", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E66")]
		[Address(RVA = "0x732BB0", Offset = "0x732BB0", VA = "0x732BB0", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E67")]
		[Address(RVA = "0x732BB4", Offset = "0x732BB4", VA = "0x732BB4")]
		public AllDeathCommand()
		{
		}

		// Token: 0x04009307 RID: 37639
		[Token(Token = "0x4009307")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RESPONSE_COLOR;

		// Token: 0x02000926 RID: 2342
		[Token(Token = "0x2000926")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E6A RID: 20074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E6A")]
			[Address(RVA = "0x732CBC", Offset = "0x732CBC", VA = "0x732CBC")]
			public <>c()
			{
			}

			// Token: 0x06004E6B RID: 20075 RVA: 0x000248A0 File Offset: 0x00022AA0
			[Token(Token = "0x6004E6B")]
			[Address(RVA = "0x732CC4", Offset = "0x732CC4", VA = "0x732CC4")]
			internal bool <ProcessIncomingMessage>b__1_0(Player x)
			{
				return default(bool);
			}

			// Token: 0x06004E6C RID: 20076 RVA: 0x000248B8 File Offset: 0x00022AB8
			[Token(Token = "0x6004E6C")]
			[Address(RVA = "0x732CE0", Offset = "0x732CE0", VA = "0x732CE0")]
			internal int <ProcessIncomingMessage>b__1_1(Player x)
			{
				return 0;
			}

			// Token: 0x04009308 RID: 37640
			[Token(Token = "0x4009308")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AllDeathCommand.<>c <>9;

			// Token: 0x04009309 RID: 37641
			[Token(Token = "0x4009309")]
			[FieldOffset(Offset = "0x4")]
			public static Func<Player, bool> <>9__1_0;

			// Token: 0x0400930A RID: 37642
			[Token(Token = "0x400930A")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Player, int> <>9__1_1;
		}
	}
}
