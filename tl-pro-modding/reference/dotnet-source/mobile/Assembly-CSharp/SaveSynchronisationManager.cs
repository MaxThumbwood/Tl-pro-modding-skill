using System;
using Il2CppDummyDll;

// Token: 0x02000329 RID: 809
[Token(Token = "0x2000329")]
public class SaveSynchronisationManager
{
	// Token: 0x06001401 RID: 5121 RVA: 0x00008F88 File Offset: 0x00007188
	[Token(Token = "0x6001401")]
	[Address(RVA = "0xDB5190", Offset = "0xDB5190", VA = "0xDB5190")]
	public bool AttemptHostConnection(bool isLocalHost)
	{
		return default(bool);
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001402")]
	[Address(RVA = "0xDB5288", Offset = "0xDB5288", VA = "0xDB5288")]
	public void ProcessServerMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001403")]
	[Address(RVA = "0xDB25D0", Offset = "0xDB25D0", VA = "0xDB25D0")]
	public void ProcessClientMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001404")]
	[Address(RVA = "0xDB5428", Offset = "0xDB5428", VA = "0xDB5428")]
	public void Update()
	{
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x00008FA0 File Offset: 0x000071A0
	[Token(Token = "0x6001405")]
	[Address(RVA = "0xDB2460", Offset = "0xDB2460", VA = "0xDB2460")]
	public bool AttemptClientConnection()
	{
		return default(bool);
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x00008FB8 File Offset: 0x000071B8
	[Token(Token = "0x6001406")]
	[Address(RVA = "0xDB5464", Offset = "0xDB5464", VA = "0xDB5464")]
	public bool IsLookingForConnection()
	{
		return default(bool);
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001407")]
	[Address(RVA = "0xDB5480", Offset = "0xDB5480", VA = "0xDB5480")]
	public void Startup()
	{
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001408")]
	[Address(RVA = "0xDB57D0", Offset = "0xDB57D0", VA = "0xDB57D0")]
	public void Shutdown()
	{
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001409")]
	[Address(RVA = "0xDB26EC", Offset = "0xDB26EC", VA = "0xDB26EC")]
	public void Restart()
	{
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140A")]
	[Address(RVA = "0xDB5900", Offset = "0xDB5900", VA = "0xDB5900")]
	public void Connect(string connectionAddress)
	{
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140B")]
	[Address(RVA = "0xDB5A24", Offset = "0xDB5A24", VA = "0xDB5A24")]
	public SaveSynchronisationManager()
	{
	}

	// Token: 0x040027B3 RID: 10163
	[Token(Token = "0x40027B3")]
	[FieldOffset(Offset = "0x0")]
	public static SaveSynchronisationManager Instance;

	// Token: 0x040027B4 RID: 10164
	[Token(Token = "0x40027B4")]
	[FieldOffset(Offset = "0x8")]
	public SaveSynchronisationState LocalState;

	// Token: 0x040027B5 RID: 10165
	[Token(Token = "0x40027B5")]
	[FieldOffset(Offset = "0xC")]
	public SaveSynchronisationState RemoteState;

	// Token: 0x040027B6 RID: 10166
	[Token(Token = "0x40027B6")]
	[FieldOffset(Offset = "0x10")]
	public SaveSynchronisationClient client;

	// Token: 0x040027B7 RID: 10167
	[Token(Token = "0x40027B7")]
	[FieldOffset(Offset = "0x14")]
	public SaveSynchronisationHost server;

	// Token: 0x040027B8 RID: 10168
	[Token(Token = "0x40027B8")]
	[FieldOffset(Offset = "0x18")]
	public object Lock;

	// Token: 0x040027B9 RID: 10169
	[Token(Token = "0x40027B9")]
	[FieldOffset(Offset = "0x1C")]
	public SaveSynchronisationManager.ConnectionState ClientState;

	// Token: 0x040027BA RID: 10170
	[Token(Token = "0x40027BA")]
	[FieldOffset(Offset = "0x20")]
	public SaveSynchronisationManager.ConnectionState HostState;

	// Token: 0x040027BB RID: 10171
	[Token(Token = "0x40027BB")]
	[FieldOffset(Offset = "0x24")]
	public bool HostIsConnectedToLocal;

	// Token: 0x0200032A RID: 810
	[Token(Token = "0x200032A")]
	public enum ConnectionState
	{
		// Token: 0x040027BD RID: 10173
		[Token(Token = "0x40027BD")]
		Waiting,
		// Token: 0x040027BE RID: 10174
		[Token(Token = "0x40027BE")]
		Connecting,
		// Token: 0x040027BF RID: 10175
		[Token(Token = "0x40027BF")]
		Connected
	}
}
