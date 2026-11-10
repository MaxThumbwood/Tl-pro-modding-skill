using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Open.Nat;

// Token: 0x0200030D RID: 781
[Token(Token = "0x200030D")]
public static class UPNPUtility
{
	// Token: 0x0600136E RID: 4974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136E")]
	[Address(RVA = "0xD9D6A4", Offset = "0xD9D6A4", VA = "0xD9D6A4")]
	public static void Init()
	{
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136F")]
	[Address(RVA = "0xD9D850", Offset = "0xD9D850", VA = "0xD9D850")]
	private static void DetectDevice()
	{
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001370")]
	[Address(RVA = "0xD9D8DC", Offset = "0xD9D8DC", VA = "0xD9D8DC")]
	public static void AnnouncePort()
	{
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001371")]
	[Address(RVA = "0xD9D9E8", Offset = "0xD9D9E8", VA = "0xD9D9E8")]
	private static void DisplayPortMessage(object dat)
	{
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001372")]
	[Address(RVA = "0xD9DF0C", Offset = "0xD9DF0C", VA = "0xD9DF0C")]
	public static void OpenPort(int port)
	{
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001373")]
	[Address(RVA = "0xD9E034", Offset = "0xD9E034", VA = "0xD9E034")]
	private static void OpenPortThread(object port)
	{
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x00008D30 File Offset: 0x00006F30
	[Token(Token = "0x6001374")]
	[Address(RVA = "0xD9E224", Offset = "0xD9E224", VA = "0xD9E224")]
	public static bool IsPrivate(IPAddress ip)
	{
		return default(bool);
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001375")]
	[Address(RVA = "0xD9E180", Offset = "0xD9E180", VA = "0xD9E180")]
	public static void OpenPortInternal(int port)
	{
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001376")]
	[Address(RVA = "0xD9E37C", Offset = "0xD9E37C", VA = "0xD9E37C")]
	public static void ClosePort()
	{
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001377")]
	[Address(RVA = "0xD9E464", Offset = "0xD9E464", VA = "0xD9E464")]
	public static void ClosePortThread()
	{
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001378")]
	[Address(RVA = "0xD9E540", Offset = "0xD9E540", VA = "0xD9E540")]
	public static void ClosePortInternal()
	{
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001379")]
	[Address(RVA = "0xD9E5CC", Offset = "0xD9E5CC", VA = "0xD9E5CC")]
	public static List<IPAddress> LocalAdresses()
	{
		return null;
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x00008D48 File Offset: 0x00006F48
	[Token(Token = "0x600137A")]
	[Address(RVA = "0xD9EDBC", Offset = "0xD9EDBC", VA = "0xD9EDBC")]
	private static bool ValidateLocalAddresses()
	{
		return default(bool);
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600137B")]
	[Address(RVA = "0xD9F170", Offset = "0xD9F170", VA = "0xD9F170")]
	public static void Reset()
	{
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600137C")]
	[Address(RVA = "0xD9C6A4", Offset = "0xD9C6A4", VA = "0xD9C6A4")]
	public static void Update()
	{
	}

	// Token: 0x04002571 RID: 9585
	[Token(Token = "0x4002571")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static UPNPUtility.State CurrentState;

	// Token: 0x04002572 RID: 9586
	[Token(Token = "0x4002572")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static NatDevice Device;

	// Token: 0x04002573 RID: 9587
	[Token(Token = "0x4002573")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static IPAddress DeviceLocalIP;

	// Token: 0x04002574 RID: 9588
	[Token(Token = "0x4002574")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static bool PortMapped;

	// Token: 0x04002575 RID: 9589
	[Token(Token = "0x4002575")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public static bool PortMappedFailed;

	// Token: 0x04002576 RID: 9590
	[Token(Token = "0x4002576")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static DateTime DeviceCheckTime;

	// Token: 0x04002577 RID: 9591
	[Token(Token = "0x4002577")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static IPAddress ExternalAddress;

	// Token: 0x04002578 RID: 9592
	[Token(Token = "0x4002578")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static int ExternalPort;

	// Token: 0x04002579 RID: 9593
	[Token(Token = "0x4002579")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Mapping TCPMappingInUse;

	// Token: 0x0400257A RID: 9594
	[Token(Token = "0x400257A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static Mapping UDPMappingInUse;

	// Token: 0x0400257B RID: 9595
	[Token(Token = "0x400257B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int RequestedPort;

	// Token: 0x0400257C RID: 9596
	[Token(Token = "0x400257C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static List<IPAddress> RefreshAddresses;

	// Token: 0x0400257D RID: 9597
	[Token(Token = "0x400257D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static List<IPAddress> CachedAddresses;

	// Token: 0x0400257E RID: 9598
	[Token(Token = "0x400257E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static NetworkInterface[] NetworkInterfaces;

	// Token: 0x0400257F RID: 9599
	[Token(Token = "0x400257F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static bool AnnoucePortPending;

	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	public enum State
	{
		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		None,
		// Token: 0x04002582 RID: 9602
		[Token(Token = "0x4002582")]
		RefreshingDevice,
		// Token: 0x04002583 RID: 9603
		[Token(Token = "0x4002583")]
		Available,
		// Token: 0x04002584 RID: 9604
		[Token(Token = "0x4002584")]
		Unavailable
	}

	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	[StructLayout(3)]
	private struct <DetectDevice>d__16 : FileAPI
	{
		// Token: 0x0600137E RID: 4990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137E")]
		[Address(RVA = "0xD9F2E0", Offset = "0xD9F2E0", VA = "0xD9F2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137F")]
		[Address(RVA = "0xD9FAEC", Offset = "0xD9FAEC", VA = "0xD9FAEC", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04002585 RID: 9605
		[Token(Token = "0x4002585")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04002586 RID: 9606
		[Token(Token = "0x4002586")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x04002587 RID: 9607
		[Token(Token = "0x4002587")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TaskAwaiter<NatDevice> <>u__1;
	}

	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	[StructLayout(3)]
	private struct <OpenPortInternal>d__23 : FileAPI
	{
		// Token: 0x06001380 RID: 4992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001380")]
		[Address(RVA = "0xD9FB00", Offset = "0xD9FB00", VA = "0xD9FB00", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001381")]
		[Address(RVA = "0xDA1848", Offset = "0xDA1848", VA = "0xDA1848", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04002588 RID: 9608
		[Token(Token = "0x4002588")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04002589 RID: 9609
		[Token(Token = "0x4002589")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x0400258A RID: 9610
		[Token(Token = "0x400258A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int port;

		// Token: 0x0400258B RID: 9611
		[Token(Token = "0x400258B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IPAddress <ip>5__2;

		// Token: 0x0400258C RID: 9612
		[Token(Token = "0x400258C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private TaskAwaiter<IPAddress> <>u__1;

		// Token: 0x0400258D RID: 9613
		[Token(Token = "0x400258D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IEnumerable<Mapping> <mappings>5__3;

		// Token: 0x0400258E RID: 9614
		[Token(Token = "0x400258E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TaskAwaiter<IEnumerable<Mapping>> <>u__2;

		// Token: 0x0400258F RID: 9615
		[Token(Token = "0x400258F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter <>u__3;
	}

	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	[StructLayout(3)]
	private struct <ClosePortInternal>d__26 : FileAPI
	{
		// Token: 0x06001382 RID: 4994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001382")]
		[Address(RVA = "0xDA1854", Offset = "0xDA1854", VA = "0xDA1854", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001383")]
		[Address(RVA = "0xDA1CD8", Offset = "0xDA1CD8", VA = "0xDA1CD8", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04002590 RID: 9616
		[Token(Token = "0x4002590")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04002591 RID: 9617
		[Token(Token = "0x4002591")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x04002592 RID: 9618
		[Token(Token = "0x4002592")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TaskAwaiter <>u__1;
	}
}
