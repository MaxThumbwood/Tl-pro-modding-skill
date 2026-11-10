using System;
using Il2CppDummyDll;

// Token: 0x020002FA RID: 762
[Token(Token = "0x20002FA")]
public class MPSession_Dummy : FileAPI
{
	// Token: 0x060012A3 RID: 4771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A3")]
	[Address(RVA = "0xD9293C", Offset = "0xD9293C", VA = "0xD9293C")]
	public MPSession_Dummy(PlatformUser user, string server, int port, MPSessionManager.LobbyState lobbyState)
	{
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A4")]
	[Address(RVA = "0xD92ABC", Offset = "0xD92ABC", VA = "0xD92ABC")]
	public MPSession_Dummy(PlatformUser user, MPSessionManager.LobbyState lobbyState)
	{
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A5")]
	[Address(RVA = "0xD92B74", Offset = "0xD92B74", VA = "0xD92B74", Slot = "6")]
	public void GetServerConnection(out string server, out int port)
	{
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x00008880 File Offset: 0x00006A80
	[Token(Token = "0x60012A6")]
	[Address(RVA = "0xD92B88", Offset = "0xD92B88", VA = "0xD92B88", Slot = "16")]
	public bool IsSameSession(MPSession session)
	{
		return default(bool);
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x00008898 File Offset: 0x00006A98
	[Token(Token = "0x60012A7")]
	[Address(RVA = "0xD92C54", Offset = "0xD92C54", VA = "0xD92C54", Slot = "4")]
	public PlatformUser GetHost()
	{
		return default(PlatformUser);
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x000088B0 File Offset: 0x00006AB0
	[Token(Token = "0x60012A8")]
	[Address(RVA = "0xD92C68", Offset = "0xD92C68", VA = "0xD92C68", Slot = "5")]
	public MPSessionManager.LobbyState GetState()
	{
		return MPSessionManager.LobbyState.None;
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A9")]
	[Address(RVA = "0xD92C70", Offset = "0xD92C70", VA = "0xD92C70", Slot = "7")]
	public void SetState(MPSessionManager.LobbyState newState)
	{
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AA")]
	[Address(RVA = "0xD92C80", Offset = "0xD92C80", VA = "0xD92C80", Slot = "12")]
	public void UpdatePlayerCount()
	{
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x000088C8 File Offset: 0x00006AC8
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0xD92D98", Offset = "0xD92D98", VA = "0xD92D98", Slot = "13")]
	public bool CanInvite()
	{
		return default(bool);
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AC")]
	[Address(RVA = "0xD92DA0", Offset = "0xD92DA0", VA = "0xD92DA0", Slot = "10")]
	public MPSessionMetaData GetMetaData()
	{
		return null;
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AD")]
	[Address(RVA = "0xD92DA8", Offset = "0xD92DA8", VA = "0xD92DA8", Slot = "11")]
	public void SetMetaData(MPSessionMetaData data)
	{
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AE")]
	[Address(RVA = "0xD92DB0", Offset = "0xD92DB0", VA = "0xD92DB0", Slot = "9")]
	public void SetClientInSession(bool activeInSession)
	{
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x000088E0 File Offset: 0x00006AE0
	[Token(Token = "0x60012AF")]
	[Address(RVA = "0xD92EA4", Offset = "0xD92EA4", VA = "0xD92EA4", Slot = "8")]
	public bool ClientInSession()
	{
		return default(bool);
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B0")]
	[Address(RVA = "0xD92EAC", Offset = "0xD92EAC", VA = "0xD92EAC", Slot = "14")]
	public void Leave(PlatformUser localUser)
	{
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B1")]
	[Address(RVA = "0xD92ED4", Offset = "0xD92ED4", VA = "0xD92ED4", Slot = "15")]
	public void Join(PlatformUser localUser)
	{
	}

	// Token: 0x04002514 RID: 9492
	[Token(Token = "0x4002514")]
	[FieldOffset(Offset = "0x8")]
	private MPSessionManager.LobbyState state;

	// Token: 0x04002515 RID: 9493
	[Token(Token = "0x4002515")]
	[FieldOffset(Offset = "0xC")]
	private PlatformUser hostUser;

	// Token: 0x04002516 RID: 9494
	[Token(Token = "0x4002516")]
	[FieldOffset(Offset = "0x14")]
	private MPSessionMetaData MetaData;

	// Token: 0x04002517 RID: 9495
	[Token(Token = "0x4002517")]
	[FieldOffset(Offset = "0x18")]
	private bool ActiveInSession;

	// Token: 0x04002518 RID: 9496
	[Token(Token = "0x4002518")]
	[FieldOffset(Offset = "0x1C")]
	private string serverAddress;

	// Token: 0x04002519 RID: 9497
	[Token(Token = "0x4002519")]
	[FieldOffset(Offset = "0x20")]
	private int serverPort;
}
