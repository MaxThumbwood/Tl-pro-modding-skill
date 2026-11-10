using System;
using System.Xml;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E57 RID: 3671
	[Token(Token = "0x2000E57")]
	internal class GetPortMappingEntryResponseMessage : ResponseMessageBase
	{
		// Token: 0x06006AAB RID: 27307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AAB")]
		[Address(RVA = "0xBA0070", Offset = "0xBA0070", VA = "0xBA0070")]
		internal GetPortMappingEntryResponseMessage(XmlDocument response, string serviceType, bool genericMapping)
		{
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06006AAC RID: 27308 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AAD RID: 27309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7B")]
		public string RemoteHost
		{
			[Token(Token = "0x6006AAC")]
			[Address(RVA = "0xBA0720", Offset = "0xBA0720", VA = "0xBA0720")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AAD")]
			[Address(RVA = "0xBA0728", Offset = "0xBA0728", VA = "0xBA0728")]
			private set
			{
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06006AAE RID: 27310 RVA: 0x000301C8 File Offset: 0x0002E3C8
		// (set) Token: 0x06006AAF RID: 27311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7C")]
		public int ExternalPort
		{
			[Token(Token = "0x6006AAE")]
			[Address(RVA = "0xBA0730", Offset = "0xBA0730", VA = "0xBA0730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006AAF")]
			[Address(RVA = "0xBA0738", Offset = "0xBA0738", VA = "0xBA0738")]
			private set
			{
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x000301E0 File Offset: 0x0002E3E0
		// (set) Token: 0x06006AB1 RID: 27313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7D")]
		public Protocol Protocol
		{
			[Token(Token = "0x6006AB0")]
			[Address(RVA = "0xBA0740", Offset = "0xBA0740", VA = "0xBA0740")]
			get
			{
				return Protocol.Tcp;
			}
			[Token(Token = "0x6006AB1")]
			[Address(RVA = "0xBA0748", Offset = "0xBA0748", VA = "0xBA0748")]
			private set
			{
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x000301F8 File Offset: 0x0002E3F8
		// (set) Token: 0x06006AB3 RID: 27315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7E")]
		public int InternalPort
		{
			[Token(Token = "0x6006AB2")]
			[Address(RVA = "0xBA0750", Offset = "0xBA0750", VA = "0xBA0750")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006AB3")]
			[Address(RVA = "0xBA0758", Offset = "0xBA0758", VA = "0xBA0758")]
			private set
			{
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AB5 RID: 27317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7F")]
		public string InternalClient
		{
			[Token(Token = "0x6006AB4")]
			[Address(RVA = "0xBA0760", Offset = "0xBA0760", VA = "0xBA0760")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AB5")]
			[Address(RVA = "0xBA0768", Offset = "0xBA0768", VA = "0xBA0768")]
			private set
			{
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06006AB6 RID: 27318 RVA: 0x00030210 File Offset: 0x0002E410
		// (set) Token: 0x06006AB7 RID: 27319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B80")]
		public bool Enabled
		{
			[Token(Token = "0x6006AB6")]
			[Address(RVA = "0xBA0770", Offset = "0xBA0770", VA = "0xBA0770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006AB7")]
			[Address(RVA = "0xBA0778", Offset = "0xBA0778", VA = "0xBA0778")]
			private set
			{
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06006AB8 RID: 27320 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AB9 RID: 27321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B81")]
		public string PortMappingDescription
		{
			[Token(Token = "0x6006AB8")]
			[Address(RVA = "0xBA0780", Offset = "0xBA0780", VA = "0xBA0780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AB9")]
			[Address(RVA = "0xBA0788", Offset = "0xBA0788", VA = "0xBA0788")]
			private set
			{
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06006ABA RID: 27322 RVA: 0x00030228 File Offset: 0x0002E428
		// (set) Token: 0x06006ABB RID: 27323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B82")]
		public int LeaseDuration
		{
			[Token(Token = "0x6006ABA")]
			[Address(RVA = "0xBA0790", Offset = "0xBA0790", VA = "0xBA0790")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006ABB")]
			[Address(RVA = "0xBA0798", Offset = "0xBA0798", VA = "0xBA0798")]
			private set
			{
			}
		}

		// Token: 0x0400A827 RID: 43047
		[Token(Token = "0x400A827")]
		[FieldOffset(Offset = "0x14")]
		private string <RemoteHost>k__BackingField;

		// Token: 0x0400A828 RID: 43048
		[Token(Token = "0x400A828")]
		[FieldOffset(Offset = "0x18")]
		private int <ExternalPort>k__BackingField;

		// Token: 0x0400A829 RID: 43049
		[Token(Token = "0x400A829")]
		[FieldOffset(Offset = "0x1C")]
		private Protocol <Protocol>k__BackingField;

		// Token: 0x0400A82A RID: 43050
		[Token(Token = "0x400A82A")]
		[FieldOffset(Offset = "0x20")]
		private int <InternalPort>k__BackingField;

		// Token: 0x0400A82B RID: 43051
		[Token(Token = "0x400A82B")]
		[FieldOffset(Offset = "0x24")]
		private string <InternalClient>k__BackingField;

		// Token: 0x0400A82C RID: 43052
		[Token(Token = "0x400A82C")]
		[FieldOffset(Offset = "0x28")]
		private bool <Enabled>k__BackingField;

		// Token: 0x0400A82D RID: 43053
		[Token(Token = "0x400A82D")]
		[FieldOffset(Offset = "0x2C")]
		private string <PortMappingDescription>k__BackingField;

		// Token: 0x0400A82E RID: 43054
		[Token(Token = "0x400A82E")]
		[FieldOffset(Offset = "0x30")]
		private int <LeaseDuration>k__BackingField;
	}
}
