using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Content
{
	// Token: 0x02000441 RID: 1089
	[Token(Token = "0x2000441")]
	public class ThreadContentRequest
	{
		// Token: 0x06001E9D RID: 7837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9D")]
		public static T ConstructOnMainThread<T>(string asset, ThreadContentRequest.ObjectCreate createFunction) where T : class
		{
			return null;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9E")]
		public static T ConstructOnMainThread<T>(string asset, string asset2, ThreadContentRequest.ObjectCreate2 createFunction) where T : class
		{
			return null;
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9F")]
		public static T ConstructOnMainThread<T>(string asset, string asset2, string asset3, ThreadContentRequest.ObjectCreate3 createFunction) where T : class
		{
			return null;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0xF09780", Offset = "0xF09780", VA = "0xF09780")]
		public static global::UnityEngine.Object Load(string asset)
		{
			return null;
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA1")]
		[Address(RVA = "0xF09A3C", Offset = "0xF09A3C", VA = "0xF09A3C")]
		public static void UpdatingLoading()
		{
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0xF098BC", Offset = "0xF098BC", VA = "0xF098BC")]
		public ThreadContentRequest(string asset, [Optional] ThreadContentRequest.ObjectCreate createFunction)
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0xF0A03C", Offset = "0xF0A03C", VA = "0xF0A03C")]
		public ThreadContentRequest(string asset, string asset2, [Optional] ThreadContentRequest.ObjectCreate2 createFunction)
		{
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0xF0A0D0", Offset = "0xF0A0D0", VA = "0xF0A0D0")]
		public ThreadContentRequest(string asset, string asset2, string asset3, [Optional] ThreadContentRequest.ObjectCreate3 createFunction)
		{
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0xF09DB4", Offset = "0xF09DB4", VA = "0xF09DB4")]
		private void BeginLoad()
		{
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0000EC70 File Offset: 0x0000CE70
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0xF09E1C", Offset = "0xF09E1C", VA = "0xF09E1C")]
		private bool UpdateLoad()
		{
			return default(bool);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0xF09948", Offset = "0xF09948", VA = "0xF09948")]
		public global::UnityEngine.Object LoadFromMainThread()
		{
			return null;
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0xF0A16C", Offset = "0xF0A16C", VA = "0xF0A16C")]
		public object ConstructFromMainThread()
		{
			return null;
		}

		// Token: 0x04003163 RID: 12643
		[Token(Token = "0x4003163")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ConcurrentQueue<ThreadContentRequest> _pendingRequests;

		// Token: 0x04003164 RID: 12644
		[Token(Token = "0x4003164")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static List<ThreadContentRequest> _activeRequests;

		// Token: 0x04003165 RID: 12645
		[Token(Token = "0x4003165")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private object _lockObject;

		// Token: 0x04003166 RID: 12646
		[Token(Token = "0x4003166")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly string _asset;

		// Token: 0x04003167 RID: 12647
		[Token(Token = "0x4003167")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _asset2;

		// Token: 0x04003168 RID: 12648
		[Token(Token = "0x4003168")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly string _asset3;

		// Token: 0x04003169 RID: 12649
		[Token(Token = "0x4003169")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ResourceRequest _loadRequest;

		// Token: 0x0400316A RID: 12650
		[Token(Token = "0x400316A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private ResourceRequest _loadRequest2;

		// Token: 0x0400316B RID: 12651
		[Token(Token = "0x400316B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ResourceRequest _loadRequest3;

		// Token: 0x0400316C RID: 12652
		[Token(Token = "0x400316C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private global::UnityEngine.Object _resource;

		// Token: 0x0400316D RID: 12653
		[Token(Token = "0x400316D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private global::UnityEngine.Object _resource2;

		// Token: 0x0400316E RID: 12654
		[Token(Token = "0x400316E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private global::UnityEngine.Object _resource3;

		// Token: 0x0400316F RID: 12655
		[Token(Token = "0x400316F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _loaded;

		// Token: 0x04003170 RID: 12656
		[Token(Token = "0x4003170")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private ThreadContentRequest.ObjectCreate _createFunction;

		// Token: 0x04003171 RID: 12657
		[Token(Token = "0x4003171")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ThreadContentRequest.ObjectCreate2 _createFunction2;

		// Token: 0x04003172 RID: 12658
		[Token(Token = "0x4003172")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private ThreadContentRequest.ObjectCreate3 _createFunction3;

		// Token: 0x04003173 RID: 12659
		[Token(Token = "0x4003173")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _constructedObject;

		// Token: 0x02000442 RID: 1090
		// (Invoke) Token: 0x06001EAB RID: 7851
		[Token(Token = "0x2000442")]
		public delegate object ObjectCreate(global::UnityEngine.Object asset);

		// Token: 0x02000443 RID: 1091
		// (Invoke) Token: 0x06001EAF RID: 7855
		[Token(Token = "0x2000443")]
		public delegate object ObjectCreate2(global::UnityEngine.Object asset, global::UnityEngine.Object asset2);

		// Token: 0x02000444 RID: 1092
		// (Invoke) Token: 0x06001EB3 RID: 7859
		[Token(Token = "0x2000444")]
		public delegate object ObjectCreate3(global::UnityEngine.Object asset, global::UnityEngine.Object asset2, global::UnityEngine.Object asset3);
	}
}
