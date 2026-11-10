using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E5A RID: 3674
	[Token(Token = "0x2000E5A")]
	internal class SoapClient
	{
		// Token: 0x06006AC0 RID: 27328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AC0")]
		[Address(RVA = "0xBA07A0", Offset = "0xBA07A0", VA = "0xBA07A0")]
		public SoapClient(Uri url, string serviceType)
		{
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AC1")]
		[Address(RVA = "0xBA07C4", Offset = "0xBA07C4", VA = "0xBA07C4")]
		public Task<XmlDocument> InvokeAsync(string operationName, IDictionary<string, object> args)
		{
			return null;
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AC2")]
		[Address(RVA = "0xBA0900", Offset = "0xBA0900", VA = "0xBA0900")]
		private static Task<WebResponse> GetWebResponse(WebRequest request)
		{
			return null;
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AC3")]
		[Address(RVA = "0xBA0A20", Offset = "0xBA0A20", VA = "0xBA0A20")]
		private HttpWebRequest BuildHttpWebRequest(string operationName, byte[] messageBody)
		{
			return null;
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AC4")]
		[Address(RVA = "0xBA0DB8", Offset = "0xBA0DB8", VA = "0xBA0DB8")]
		private byte[] BuildMessageBody(string operationName, IEnumerable<KeyValuePair<string, object>> args)
		{
			return null;
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AC5")]
		[Address(RVA = "0xBA18A4", Offset = "0xBA18A4", VA = "0xBA18A4")]
		private XmlDocument GetXmlDocument(string response)
		{
			return null;
		}

		// Token: 0x0400A832 RID: 43058
		[Token(Token = "0x400A832")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly string _serviceType;

		// Token: 0x0400A833 RID: 43059
		[Token(Token = "0x400A833")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly Uri _url;

		// Token: 0x02000E5B RID: 3675
		[Token(Token = "0x2000E5B")]
		[StructLayout(3)]
		private struct <InvokeAsync>d__3 : FileAPI
		{
			// Token: 0x06006AC6 RID: 27334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AC6")]
			[Address(RVA = "0xBA1BC8", Offset = "0xBA1BC8", VA = "0xBA1BC8", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006AC7 RID: 27335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AC7")]
			[Address(RVA = "0xBA2764", Offset = "0xBA2764", VA = "0xBA2764", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A834 RID: 43060
			[Token(Token = "0x400A834")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A835 RID: 43061
			[Token(Token = "0x400A835")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<XmlDocument> <>t__builder;

			// Token: 0x0400A836 RID: 43062
			[Token(Token = "0x400A836")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SoapClient <>4__this;

			// Token: 0x0400A837 RID: 43063
			[Token(Token = "0x400A837")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public string operationName;

			// Token: 0x0400A838 RID: 43064
			[Token(Token = "0x400A838")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IDictionary<string, object> args;

			// Token: 0x0400A839 RID: 43065
			[Token(Token = "0x400A839")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private byte[] <messageBody>5__2;

			// Token: 0x0400A83A RID: 43066
			[Token(Token = "0x400A83A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private HttpWebRequest <request>5__3;

			// Token: 0x0400A83B RID: 43067
			[Token(Token = "0x400A83B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Stream <stream>5__4;

			// Token: 0x0400A83C RID: 43068
			[Token(Token = "0x400A83C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<Stream> <>u__1;

			// Token: 0x0400A83D RID: 43069
			[Token(Token = "0x400A83D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private TaskAwaiter <>u__2;

			// Token: 0x0400A83E RID: 43070
			[Token(Token = "0x400A83E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<WebResponse> <>u__3;
		}

		// Token: 0x02000E5C RID: 3676
		[Token(Token = "0x2000E5C")]
		[StructLayout(3)]
		private struct <GetWebResponse>d__4 : FileAPI
		{
			// Token: 0x06006AC8 RID: 27336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AC8")]
			[Address(RVA = "0xBA27F4", Offset = "0xBA27F4", VA = "0xBA27F4", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006AC9 RID: 27337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AC9")]
			[Address(RVA = "0xBA2BB0", Offset = "0xBA2BB0", VA = "0xBA2BB0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A83F RID: 43071
			[Token(Token = "0x400A83F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A840 RID: 43072
			[Token(Token = "0x400A840")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<WebResponse> <>t__builder;

			// Token: 0x0400A841 RID: 43073
			[Token(Token = "0x400A841")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WebRequest request;

			// Token: 0x0400A842 RID: 43074
			[Token(Token = "0x400A842")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private TaskAwaiter<WebResponse> <>u__1;
		}
	}
}
