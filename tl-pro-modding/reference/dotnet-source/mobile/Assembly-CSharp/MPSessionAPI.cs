using System;
using Il2CppDummyDll;

// Token: 0x02000306 RID: 774
[Token(Token = "0x2000306")]
public interface MPSessionAPI
{
	// Token: 0x06001356 RID: 4950
	[Token(Token = "0x6001356")]
	void OpenInviteOverlay(MPSession session, PlatformUser user, int numSlotsLeft);

	// Token: 0x06001357 RID: 4951
	[Token(Token = "0x6001357")]
	MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state);

	// Token: 0x06001358 RID: 4952
	[Token(Token = "0x6001358")]
	MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort);

	// Token: 0x06001359 RID: 4953
	[Token(Token = "0x6001359")]
	void FindUserSessions(PlatformUser[] users, MPSessionManager.MPSessionFriendSearchResult result);

	// Token: 0x0600135A RID: 4954
	[Token(Token = "0x600135A")]
	void Update();
}
