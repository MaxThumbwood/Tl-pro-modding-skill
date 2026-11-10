using System;
using System.Collections.Concurrent;
using System.Threading;
using Il2CppDummyDll;

namespace ReLogic.OS.Windows
{
	// Token: 0x02000DED RID: 3565
	[Token(Token = "0x2000DED")]
	internal class STATaskInvoker : FileAPI
	{
		// Token: 0x0600689A RID: 26778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689A")]
		[Address(RVA = "0xB80E8C", Offset = "0xB80E8C", VA = "0xB80E8C")]
		private STATaskInvoker()
		{
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689B")]
		[Address(RVA = "0xB810CC", Offset = "0xB810CC", VA = "0xB810CC")]
		public static void Invoke(Action action)
		{
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600689C")]
		public static T Invoke<T>(Func<T> action)
		{
			return null;
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689D")]
		[Address(RVA = "0xB81178", Offset = "0xB81178", VA = "0xB81178")]
		private void InvokeAndWait(Action action)
		{
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689E")]
		[Address(RVA = "0xB81360", Offset = "0xB81360", VA = "0xB81360")]
		private void TaskThreadStart()
		{
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689F")]
		[Address(RVA = "0xB814D8", Offset = "0xB814D8", VA = "0xB814D8")]
		private void Shutdown()
		{
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A0")]
		[Address(RVA = "0xB81574", Offset = "0xB81574", VA = "0xB81574", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A1")]
		[Address(RVA = "0xB81600", Offset = "0xB81600", VA = "0xB81600", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A2")]
		[Address(RVA = "0xB81614", Offset = "0xB81614", VA = "0xB81614")]
		private void <Shutdown>b__11_0()
		{
		}

		// Token: 0x0400A4FA RID: 42234
		[Token(Token = "0x400A4FA")]
		[FieldOffset(Offset = "0x0")]
		private static STATaskInvoker Instance;

		// Token: 0x0400A4FB RID: 42235
		[Token(Token = "0x400A4FB")]
		[FieldOffset(Offset = "0x8")]
		private Thread _staThread;

		// Token: 0x0400A4FC RID: 42236
		[Token(Token = "0x400A4FC")]
		[FieldOffset(Offset = "0xC")]
		private bool _shouldThreadContinue;

		// Token: 0x0400A4FD RID: 42237
		[Token(Token = "0x400A4FD")]
		[FieldOffset(Offset = "0x10")]
		private BlockingCollection<Action> _staTasks;

		// Token: 0x0400A4FE RID: 42238
		[Token(Token = "0x400A4FE")]
		[FieldOffset(Offset = "0x14")]
		private object _taskInvokeLock;

		// Token: 0x0400A4FF RID: 42239
		[Token(Token = "0x400A4FF")]
		[FieldOffset(Offset = "0x18")]
		private object _taskCompletionLock;

		// Token: 0x0400A500 RID: 42240
		[Token(Token = "0x400A500")]
		[FieldOffset(Offset = "0x1C")]
		private bool disposedValue;

		// Token: 0x02000DEE RID: 3566
		[Token(Token = "0x2000DEE")]
		private sealed class <>c__DisplayClass8_0<T>
		{
			// Token: 0x060068A3 RID: 26787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068A3")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x060068A4 RID: 26788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068A4")]
			internal void <Invoke>b__0()
			{
			}

			// Token: 0x0400A501 RID: 42241
			[Token(Token = "0x400A501")]
			[FieldOffset(Offset = "0x0")]
			public T output;

			// Token: 0x0400A502 RID: 42242
			[Token(Token = "0x400A502")]
			[FieldOffset(Offset = "0x0")]
			public Func<T> action;
		}
	}
}
