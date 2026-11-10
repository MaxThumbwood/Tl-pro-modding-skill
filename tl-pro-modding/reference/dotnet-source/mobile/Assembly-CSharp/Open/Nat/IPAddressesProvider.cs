using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E6C RID: 3692
	[Token(Token = "0x2000E6C")]
	internal class IPAddressesProvider : FileAPI
	{
		// Token: 0x06006B07 RID: 27399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B07")]
		[Address(RVA = "0xBAA9F8", Offset = "0xBAA9F8", VA = "0xBAA9F8", Slot = "6")]
		public IEnumerable<IPAddress> UnicastAddresses()
		{
			return null;
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B08")]
		[Address(RVA = "0xBAB07C", Offset = "0xBAB07C", VA = "0xBAB07C", Slot = "4")]
		public IEnumerable<IPAddress> DnsAddresses()
		{
			return null;
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B09")]
		[Address(RVA = "0xBAB17C", Offset = "0xBAB17C", VA = "0xBAB17C", Slot = "5")]
		public IEnumerable<IPAddress> GatewayAddresses()
		{
			return null;
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B0A")]
		[Address(RVA = "0xBAAAF8", Offset = "0xBAAAF8", VA = "0xBAAAF8")]
		private static IEnumerable<IPAddress> IPAddresses(Func<IPInterfaceProperties, IEnumerable<IPAddress>> ipExtractor)
		{
			return null;
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0B")]
		[Address(RVA = "0xB9A9A4", Offset = "0xB9A9A4", VA = "0xB9A9A4")]
		public IPAddressesProvider()
		{
		}

		// Token: 0x02000E6D RID: 3693
		[Token(Token = "0x2000E6D")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006B0D RID: 27405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B0D")]
			[Address(RVA = "0xBAB2F8", Offset = "0xBAB2F8", VA = "0xBAB2F8")]
			public <>c()
			{
			}

			// Token: 0x06006B0E RID: 27406 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B0E")]
			[Address(RVA = "0xBAB300", Offset = "0xBAB300", VA = "0xBAB300")]
			internal IEnumerable<IPAddress> <UnicastAddresses>b__0_0(IPInterfaceProperties p)
			{
				return null;
			}

			// Token: 0x06006B0F RID: 27407 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B0F")]
			[Address(RVA = "0xBAB44C", Offset = "0xBAB44C", VA = "0xBAB44C")]
			internal IPAddress <UnicastAddresses>b__0_1(UnicastIPAddressInformation x)
			{
				return null;
			}

			// Token: 0x06006B10 RID: 27408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B10")]
			[Address(RVA = "0xBAB478", Offset = "0xBAB478", VA = "0xBAB478")]
			internal IEnumerable<IPAddress> <DnsAddresses>b__1_0(IPInterfaceProperties p)
			{
				return null;
			}

			// Token: 0x06006B11 RID: 27409 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B11")]
			[Address(RVA = "0xBAB4A4", Offset = "0xBAB4A4", VA = "0xBAB4A4")]
			internal IEnumerable<IPAddress> <GatewayAddresses>b__2_0(IPInterfaceProperties p)
			{
				return null;
			}

			// Token: 0x06006B12 RID: 27410 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B12")]
			[Address(RVA = "0xBAB5F0", Offset = "0xBAB5F0", VA = "0xBAB5F0")]
			internal IPAddress <GatewayAddresses>b__2_1(GatewayIPAddressInformation x)
			{
				return null;
			}

			// Token: 0x06006B13 RID: 27411 RVA: 0x000302A0 File Offset: 0x0002E4A0
			[Token(Token = "0x6006B13")]
			[Address(RVA = "0xBAB61C", Offset = "0xBAB61C", VA = "0xBAB61C")]
			internal bool <IPAddresses>b__3_0(NetworkInterface networkInterface)
			{
				return default(bool);
			}

			// Token: 0x06006B14 RID: 27412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B14")]
			[Address(RVA = "0xBAB678", Offset = "0xBAB678", VA = "0xBAB678")]
			internal <>f__AnonymousType6<NetworkInterface, IPInterfaceProperties> <IPAddresses>b__3_1(NetworkInterface networkInterface)
			{
				return null;
			}

			// Token: 0x06006B15 RID: 27413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B15")]
			[Address(RVA = "0xBAB730", Offset = "0xBAB730", VA = "0xBAB730")]
			internal <>f__AnonymousType7<<>f__AnonymousType6<NetworkInterface, IPInterfaceProperties>, IPAddress> <IPAddresses>b__3_3(<>f__AnonymousType6<NetworkInterface, IPInterfaceProperties> <>h__TransparentIdentifier0, IPAddress address)
			{
				return null;
			}

			// Token: 0x06006B16 RID: 27414 RVA: 0x000302B8 File Offset: 0x0002E4B8
			[Token(Token = "0x6006B16")]
			[Address(RVA = "0xBAB7C8", Offset = "0xBAB7C8", VA = "0xBAB7C8")]
			internal bool <IPAddresses>b__3_4(<>f__AnonymousType7<<>f__AnonymousType6<NetworkInterface, IPInterfaceProperties>, IPAddress> <>h__TransparentIdentifier1)
			{
				return default(bool);
			}

			// Token: 0x06006B17 RID: 27415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B17")]
			[Address(RVA = "0xBAB864", Offset = "0xBAB864", VA = "0xBAB864")]
			internal IPAddress <IPAddresses>b__3_5(<>f__AnonymousType7<<>f__AnonymousType6<NetworkInterface, IPInterfaceProperties>, IPAddress> <>h__TransparentIdentifier1)
			{
				return null;
			}

			// Token: 0x0400A883 RID: 43139
			[Token(Token = "0x400A883")]
			[FieldOffset(Offset = "0x0")]
			public static readonly IPAddressesProvider.<>c <>9;

			// Token: 0x0400A884 RID: 43140
			[Token(Token = "0x400A884")]
			[FieldOffset(Offset = "0x4")]
			public static Func<UnicastIPAddressInformation, IPAddress> <>9__0_1;

			// Token: 0x0400A885 RID: 43141
			[Token(Token = "0x400A885")]
			[FieldOffset(Offset = "0x8")]
			public static Func<IPInterfaceProperties, IEnumerable<IPAddress>> <>9__0_0;

			// Token: 0x0400A886 RID: 43142
			[Token(Token = "0x400A886")]
			[FieldOffset(Offset = "0xC")]
			public static Func<IPInterfaceProperties, IEnumerable<IPAddress>> <>9__1_0;

			// Token: 0x0400A887 RID: 43143
			[Token(Token = "0x400A887")]
			[FieldOffset(Offset = "0x10")]
			public static Func<GatewayIPAddressInformation, IPAddress> <>9__2_1;

			// Token: 0x0400A888 RID: 43144
			[Token(Token = "0x400A888")]
			[FieldOffset(Offset = "0x14")]
			public static Func<IPInterfaceProperties, IEnumerable<IPAddress>> <>9__2_0;

			// Token: 0x0400A889 RID: 43145
			[Token(Token = "0x400A889")]
			[FieldOffset(Offset = "0x18")]
			public static Func<NetworkInterface, bool> <>9__3_0;

			// Token: 0x0400A88A RID: 43146
			[Token(Token = "0x400A88A")]
			[FieldOffset(Offset = "0x1C")]
			public static Func<NetworkInterface, <>f__AnonymousType6<NetworkInterface, IPInterfaceProperties>> <>9__3_1;

			// Token: 0x0400A88B RID: 43147
			[Token(Token = "0x400A88B")]
			[FieldOffset(Offset = "0x20")]
			public static Func<<>f__AnonymousType6<NetworkInterface, IPInterfaceProperties>, IPAddress, <>f__AnonymousType7<<>f__AnonymousType6<NetworkInterface, IPInterfaceProperties>, IPAddress>> <>9__3_3;

			// Token: 0x0400A88C RID: 43148
			[Token(Token = "0x400A88C")]
			[FieldOffset(Offset = "0x24")]
			public static Func<<>f__AnonymousType7<<>f__AnonymousType6<NetworkInterface, IPInterfaceProperties>, IPAddress>, bool> <>9__3_4;

			// Token: 0x0400A88D RID: 43149
			[Token(Token = "0x400A88D")]
			[FieldOffset(Offset = "0x28")]
			public static Func<<>f__AnonymousType7<<>f__AnonymousType6<NetworkInterface, IPInterfaceProperties>, IPAddress>, IPAddress> <>9__3_5;
		}

		// Token: 0x02000E6E RID: 3694
		[Token(Token = "0x2000E6E")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06006B18 RID: 27416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B18")]
			[Address(RVA = "0xBAB27C", Offset = "0xBAB27C", VA = "0xBAB27C")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06006B19 RID: 27417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B19")]
			[Address(RVA = "0xBAB8C0", Offset = "0xBAB8C0", VA = "0xBAB8C0")]
			internal IEnumerable<IPAddress> <IPAddresses>b__2(<>f__AnonymousType6<NetworkInterface, IPInterfaceProperties> <>h__TransparentIdentifier0)
			{
				return null;
			}

			// Token: 0x0400A88E RID: 43150
			[Token(Token = "0x400A88E")]
			[FieldOffset(Offset = "0x8")]
			public Func<IPInterfaceProperties, IEnumerable<IPAddress>> ipExtractor;
		}
	}
}
