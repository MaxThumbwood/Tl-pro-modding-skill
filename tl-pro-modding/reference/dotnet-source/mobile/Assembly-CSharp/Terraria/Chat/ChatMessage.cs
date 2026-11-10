using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Chat.Commands;

namespace Terraria.Chat
{
	// Token: 0x0200091D RID: 2333
	[Token(Token = "0x200091D")]
	public sealed class ChatMessage
	{
		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06004E45 RID: 20037 RVA: 0x00024858 File Offset: 0x00022A58
		// (set) Token: 0x06004E46 RID: 20038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000971")]
		public ChatCommandId CommandId
		{
			[Token(Token = "0x6004E45")]
			[Address(RVA = "0x730FE4", Offset = "0x730FE4", VA = "0x730FE4")]
			get
			{
				return default(ChatCommandId);
			}
			[Token(Token = "0x6004E46")]
			[Address(RVA = "0x730FEC", Offset = "0x730FEC", VA = "0x730FEC")]
			private set
			{
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06004E47 RID: 20039 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004E48 RID: 20040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000972")]
		public string Text
		{
			[Token(Token = "0x6004E47")]
			[Address(RVA = "0x730FF4", Offset = "0x730FF4", VA = "0x730FF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E48")]
			[Address(RVA = "0x730FFC", Offset = "0x730FFC", VA = "0x730FFC")]
			set
			{
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06004E49 RID: 20041 RVA: 0x00024870 File Offset: 0x00022A70
		// (set) Token: 0x06004E4A RID: 20042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000973")]
		public bool IsConsumed
		{
			[Token(Token = "0x6004E49")]
			[Address(RVA = "0x731004", Offset = "0x731004", VA = "0x731004")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004E4A")]
			[Address(RVA = "0x73100C", Offset = "0x73100C", VA = "0x73100C")]
			private set
			{
			}
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E4B")]
		[Address(RVA = "0x730A80", Offset = "0x730A80", VA = "0x730A80")]
		public ChatMessage(string message)
		{
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E4C")]
		[Address(RVA = "0x731014", Offset = "0x731014", VA = "0x731014")]
		private ChatMessage(string message, ChatCommandId commandId)
		{
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E4D")]
		[Address(RVA = "0x731038", Offset = "0x731038", VA = "0x731038")]
		public void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x00024888 File Offset: 0x00022A88
		[Token(Token = "0x6004E4E")]
		[Address(RVA = "0x731148", Offset = "0x731148", VA = "0x731148")]
		public int GetMaxSerializedSize()
		{
			return 0;
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4F")]
		[Address(RVA = "0x731278", Offset = "0x731278", VA = "0x731278")]
		public static ChatMessage Deserialize(BinaryReader reader)
		{
			return null;
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E50")]
		[Address(RVA = "0x730AF0", Offset = "0x730AF0", VA = "0x730AF0")]
		public void SetCommand(ChatCommandId commandId)
		{
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E51")]
		public void SetCommand<T>() where T : IChatCommand
		{
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E52")]
		[Address(RVA = "0x730CFC", Offset = "0x730CFC", VA = "0x730CFC")]
		public void Consume()
		{
		}

		// Token: 0x04009300 RID: 37632
		[Token(Token = "0x4009300")]
		[FieldOffset(Offset = "0x8")]
		private ChatCommandId <CommandId>k__BackingField;

		// Token: 0x04009301 RID: 37633
		[Token(Token = "0x4009301")]
		[FieldOffset(Offset = "0xC")]
		private string <Text>k__BackingField;

		// Token: 0x04009302 RID: 37634
		[Token(Token = "0x4009302")]
		[FieldOffset(Offset = "0x10")]
		private bool <IsConsumed>k__BackingField;
	}
}
