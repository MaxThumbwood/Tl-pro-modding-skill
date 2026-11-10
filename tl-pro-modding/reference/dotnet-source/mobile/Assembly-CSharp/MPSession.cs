using System;
using Il2CppDummyDll;

// Token: 0x02000305 RID: 773
[Token(Token = "0x2000305")]
public interface MPSession
{
	// Token: 0x06001349 RID: 4937
	[Token(Token = "0x6001349")]
	PlatformUser GetHost();

	// Token: 0x0600134A RID: 4938
	[Token(Token = "0x600134A")]
	MPSessionManager.LobbyState GetState();

	// Token: 0x0600134B RID: 4939
	[Token(Token = "0x600134B")]
	void GetServerConnection(out string server, out int port);

	// Token: 0x0600134C RID: 4940
	[Token(Token = "0x600134C")]
	void SetState(MPSessionManager.LobbyState newState);

	// Token: 0x0600134D RID: 4941
	[Token(Token = "0x600134D")]
	bool ClientInSession();

	// Token: 0x0600134E RID: 4942
	[Token(Token = "0x600134E")]
	void SetClientInSession(bool activeInSession);

	// Token: 0x0600134F RID: 4943
	[Token(Token = "0x600134F")]
	MPSessionMetaData GetMetaData();

	// Token: 0x06001350 RID: 4944
	[Token(Token = "0x6001350")]
	void SetMetaData(MPSessionMetaData data);

	// Token: 0x06001351 RID: 4945
	[Token(Token = "0x6001351")]
	void UpdatePlayerCount();

	// Token: 0x06001352 RID: 4946
	[Token(Token = "0x6001352")]
	bool CanInvite();

	// Token: 0x06001353 RID: 4947
	[Token(Token = "0x6001353")]
	void Leave(PlatformUser localUser);

	// Token: 0x06001354 RID: 4948
	[Token(Token = "0x6001354")]
	void Join(PlatformUser localUser);

	// Token: 0x06001355 RID: 4949
	[Token(Token = "0x6001355")]
	bool IsSameSession(MPSession session);
}
