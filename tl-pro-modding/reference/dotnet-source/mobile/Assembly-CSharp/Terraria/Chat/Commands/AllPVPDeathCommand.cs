using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000927 RID: 2343
	[Token(Token = "0x2000927")]
	public class AllPVPDeathCommand : FileAPI
	{
		// Token: 0x06004E6D RID: 20077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6D")]
		[Address(RVA = "0x732D04", Offset = "0x732D04", VA = "0x732D04", Slot = "4")]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6E")]
		[Address(RVA = "0x73359C", Offset = "0x73359C", VA = "0x73359C", Slot = "5")]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6F")]
		[Address(RVA = "0x7335A0", Offset = "0x7335A0", VA = "0x7335A0")]
		public AllPVPDeathCommand()
		{
		}

		// Token: 0x0400930B RID: 37643
		[Token(Token = "0x400930B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RESPONSE_COLOR;

		// Token: 0x02000928 RID: 2344
		[Token(Token = "0x2000928")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E72 RID: 20082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E72")]
			[Address(RVA = "0x7336A8", Offset = "0x7336A8", VA = "0x7336A8")]
			public <>c()
			{
			}

			// Token: 0x06004E73 RID: 20083 RVA: 0x000248D0 File Offset: 0x00022AD0
			[Token(Token = "0x6004E73")]
			[Address(RVA = "0x7336B0", Offset = "0x7336B0", VA = "0x7336B0")]
			internal bool <ProcessIncomingMessage>b__1_0(Player x)
			{
				return default(bool);
			}

			// Token: 0x06004E74 RID: 20084 RVA: 0x000248E8 File Offset: 0x00022AE8
			[Token(Token = "0x6004E74")]
			[Address(RVA = "0x7336CC", Offset = "0x7336CC", VA = "0x7336CC")]
			internal int <ProcessIncomingMessage>b__1_1(Player x)
			{
				return 0;
			}

			// Token: 0x0400930C RID: 37644
			[Token(Token = "0x400930C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AllPVPDeathCommand.<>c <>9;

			// Token: 0x0400930D RID: 37645
			[Token(Token = "0x400930D")]
			[FieldOffset(Offset = "0x4")]
			public static Func<Player, bool> <>9__1_0;

			// Token: 0x0400930E RID: 37646
			[Token(Token = "0x400930E")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Player, int> <>9__1_1;
		}
	}
}
