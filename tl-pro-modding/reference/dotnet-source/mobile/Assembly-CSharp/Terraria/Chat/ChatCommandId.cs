using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Chat.Commands;

namespace Terraria.Chat
{
	// Token: 0x0200091A RID: 2330
	[Token(Token = "0x200091A")]
	public struct ChatCommandId
	{
		// Token: 0x06004E37 RID: 20023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E37")]
		[Address(RVA = "0x730374", Offset = "0x730374", VA = "0x730374")]
		private ChatCommandId(string name)
		{
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x000247F8 File Offset: 0x000229F8
		[Token(Token = "0x6004E38")]
		public static ChatCommandId FromType<T>() where T : IChatCommand
		{
			return default(ChatCommandId);
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E39")]
		[Address(RVA = "0x73037C", Offset = "0x73037C", VA = "0x73037C")]
		public void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x00024810 File Offset: 0x00022A10
		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0x7303FC", Offset = "0x7303FC", VA = "0x7303FC")]
		public static ChatCommandId Deserialize(BinaryReader reader)
		{
			return default(ChatCommandId);
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x00024828 File Offset: 0x00022A28
		[Token(Token = "0x6004E3B")]
		[Address(RVA = "0x730428", Offset = "0x730428", VA = "0x730428")]
		public int GetMaxSerializedSize()
		{
			return 0;
		}

		// Token: 0x040092F4 RID: 37620
		[Token(Token = "0x40092F4")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _name;
	}
}
