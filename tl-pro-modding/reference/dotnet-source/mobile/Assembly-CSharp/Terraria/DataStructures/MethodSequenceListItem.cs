using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000776 RID: 1910
	[Token(Token = "0x2000776")]
	public class MethodSequenceListItem
	{
		// Token: 0x06004333 RID: 17203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004333")]
		[Address(RVA = "0x4FD558", Offset = "0x4FD558", VA = "0x4FD558")]
		public MethodSequenceListItem(string name, Func<bool> method, [Optional] MethodSequenceListItem parent)
		{
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x000205E0 File Offset: 0x0001E7E0
		[Token(Token = "0x6004334")]
		[Address(RVA = "0x4FD584", Offset = "0x4FD584", VA = "0x4FD584")]
		public bool ShouldAct(List<MethodSequenceListItem> sequence)
		{
			return default(bool);
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x000205F8 File Offset: 0x0001E7F8
		[Token(Token = "0x6004335")]
		[Address(RVA = "0x4FD610", Offset = "0x4FD610", VA = "0x4FD610")]
		public bool Act()
		{
			return default(bool);
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004336")]
		[Address(RVA = "0x4FD638", Offset = "0x4FD638", VA = "0x4FD638")]
		public static void ExecuteSequence(List<MethodSequenceListItem> sequence)
		{
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004337")]
		[Address(RVA = "0x4FD878", Offset = "0x4FD878", VA = "0x4FD878", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04008A96 RID: 35478
		[Token(Token = "0x4008A96")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;

		// Token: 0x04008A97 RID: 35479
		[Token(Token = "0x4008A97")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MethodSequenceListItem Parent;

		// Token: 0x04008A98 RID: 35480
		[Token(Token = "0x4008A98")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Func<bool> Method;

		// Token: 0x04008A99 RID: 35481
		[Token(Token = "0x4008A99")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool Skip;
	}
}
