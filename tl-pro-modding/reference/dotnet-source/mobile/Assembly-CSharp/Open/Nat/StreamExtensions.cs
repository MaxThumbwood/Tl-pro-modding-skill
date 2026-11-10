using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E68 RID: 3688
	[Token(Token = "0x2000E68")]
	internal static class StreamExtensions
	{
		// Token: 0x06006AF6 RID: 27382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF6")]
		[Address(RVA = "0xBA26C0", Offset = "0xBA26C0", VA = "0xBA26C0")]
		internal static string ReadAsMany(StreamReader stream, int bytesToRead)
		{
			return null;
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF7")]
		[Address(RVA = "0xB9FFC8", Offset = "0xB9FFC8", VA = "0xB9FFC8")]
		internal static string GetXmlElementText(XmlNode node, string elementName)
		{
			return null;
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x00030288 File Offset: 0x0002E488
		[Token(Token = "0x6006AF8")]
		[Address(RVA = "0xBAA254", Offset = "0xBAA254", VA = "0xBAA254")]
		internal static bool ContainsIgnoreCase(string s, string pattern)
		{
			return default(bool);
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF9")]
		[Address(RVA = "0xB940D0", Offset = "0xB940D0", VA = "0xB940D0")]
		internal static void LogInfo(TraceSource source, string format, object[] args)
		{
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFA")]
		[Address(RVA = "0xB9748C", Offset = "0xB9748C", VA = "0xB9748C")]
		internal static void LogWarn(TraceSource source, string format, object[] args)
		{
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFB")]
		[Address(RVA = "0xB93464", Offset = "0xB93464", VA = "0xB93464")]
		internal static void LogError(TraceSource source, string format, object[] args)
		{
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AFC")]
		[Address(RVA = "0xBAA4A4", Offset = "0xBAA4A4", VA = "0xBAA4A4")]
		internal static string ToPrintableXml(XmlDocument document)
		{
			return null;
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AFD")]
		public static Task<TResult> TimeoutAfter<TResult>(Task<TResult> task, TimeSpan timeout)
		{
			return null;
		}

		// Token: 0x02000E69 RID: 3689
		[Token(Token = "0x2000E69")]
		[StructLayout(3)]
		private struct <TimeoutAfter>d__7<TResult> : FileAPI
		{
			// Token: 0x06006AFE RID: 27390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AFE")]
			private void MoveNext()
			{
			}

			// Token: 0x06006AFF RID: 27391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AFF")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A87C RID: 43132
			[Token(Token = "0x400A87C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A87D RID: 43133
			[Token(Token = "0x400A87D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<TResult> <>t__builder;

			// Token: 0x0400A87E RID: 43134
			[Token(Token = "0x400A87E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Task<TResult> task;

			// Token: 0x0400A87F RID: 43135
			[Token(Token = "0x400A87F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TimeSpan timeout;

			// Token: 0x0400A880 RID: 43136
			[Token(Token = "0x400A880")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private CancellationTokenSource <timeoutCancellationTokenSource>5__2;

			// Token: 0x0400A881 RID: 43137
			[Token(Token = "0x400A881")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<Task> <>u__1;

			// Token: 0x0400A882 RID: 43138
			[Token(Token = "0x400A882")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<TResult> <>u__2;
		}
	}
}
