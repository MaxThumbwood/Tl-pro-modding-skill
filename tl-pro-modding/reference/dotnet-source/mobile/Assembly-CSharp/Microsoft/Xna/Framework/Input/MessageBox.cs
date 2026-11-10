using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003C0 RID: 960
	[Token(Token = "0x20003C0")]
	public static class MessageBox
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B6")]
		public static bool IsVisible
		{
			[Token(Token = "0x60019A8")]
			[Address(RVA = "0xE29C5C", Offset = "0xE29C5C", VA = "0xE29C5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60019A9")]
			[Address(RVA = "0xE29CAC", Offset = "0xE29CAC", VA = "0xE29CAC")]
			private set
			{
			}
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0xE29D00", Offset = "0xE29D00", VA = "0xE29D00")]
		public static Task<int?> Show(string title, string description, IEnumerable<string> buttons)
		{
			return null;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0xE29E20", Offset = "0xE29E20", VA = "0xE29E20")]
		public static void Cancel(int? result)
		{
		}

		// Token: 0x04002C8F RID: 11407
		[Token(Token = "0x4002C8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool <IsVisible>k__BackingField;

		// Token: 0x020003C1 RID: 961
		[Token(Token = "0x20003C1")]
		[StructLayout(3)]
		private struct <Show>d__4 : FileAPI
		{
			// Token: 0x060019AC RID: 6572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019AC")]
			[Address(RVA = "0xE29ED0", Offset = "0xE29ED0", VA = "0xE29ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x060019AD RID: 6573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019AD")]
			[Address(RVA = "0xE2A28C", Offset = "0xE2A28C", VA = "0xE2A28C", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04002C90 RID: 11408
			[Token(Token = "0x4002C90")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04002C91 RID: 11409
			[Token(Token = "0x4002C91")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<int?> <>t__builder;

			// Token: 0x04002C92 RID: 11410
			[Token(Token = "0x4002C92")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IEnumerable<string> buttons;
		}
	}
}
