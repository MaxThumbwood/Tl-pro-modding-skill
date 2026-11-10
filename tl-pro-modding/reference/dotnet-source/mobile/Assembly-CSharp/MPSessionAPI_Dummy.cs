using System;
using Il2CppDummyDll;

// Token: 0x020002F9 RID: 761
[Token(Token = "0x20002F9")]
public class MPSessionAPI_Dummy : FileAPI
{
	// Token: 0x0600129D RID: 4765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129D")]
	[Address(RVA = "0xD9288C", Offset = "0xD9288C", VA = "0xD9288C", Slot = "4")]
	public void OpenInviteOverlay(MPSession session, PlatformUser user, int numSlotsLeft)
	{
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129E")]
	[Address(RVA = "0xD92890", Offset = "0xD92890", VA = "0xD92890", Slot = "5")]
	public MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state)
	{
		return null;
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129F")]
	[Address(RVA = "0xD92A04", Offset = "0xD92A04", VA = "0xD92A04", Slot = "6")]
	public MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort)
	{
		return null;
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A0")]
	[Address(RVA = "0xD92A9C", Offset = "0xD92A9C", VA = "0xD92A9C", Slot = "7")]
	public void FindUserSessions(PlatformUser[] users, MPSessionManager.MPSessionFriendSearchResult result)
	{
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A1")]
	[Address(RVA = "0xD92AA0", Offset = "0xD92AA0", VA = "0xD92AA0", Slot = "8")]
	public void Update()
	{
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A2")]
	[Address(RVA = "0xD92AA4", Offset = "0xD92AA4", VA = "0xD92AA4")]
	public MPSessionAPI_Dummy()
	{
	}
}
