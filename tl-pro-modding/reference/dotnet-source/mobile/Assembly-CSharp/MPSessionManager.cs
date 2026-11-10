using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000308 RID: 776
[Token(Token = "0x2000308")]
public class MPSessionManager
{
	// Token: 0x0600135C RID: 4956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135C")]
	[Address(RVA = "0xD9B878", Offset = "0xD9B878", VA = "0xD9B878")]
	public static MPSessionManager Create()
	{
		return null;
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135D")]
	[Address(RVA = "0xD9B95C", Offset = "0xD9B95C", VA = "0xD9B95C")]
	public MPSessionManager()
	{
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135E")]
	[Address(RVA = "0xD9B9D8", Offset = "0xD9B9D8", VA = "0xD9B9D8")]
	private void SessionInviteJoined(MPSession newSession)
	{
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135F")]
	[Address(RVA = "0xD9B9E0", Offset = "0xD9B9E0", VA = "0xD9B9E0")]
	public void FindUserSessions(PlatformUser[] users, MPSessionManager.MPSessionFriendSearchResult result)
	{
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001360")]
	[Address(RVA = "0xD9BAA8", Offset = "0xD9BAA8", VA = "0xD9BAA8")]
	public MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state)
	{
		return null;
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001361")]
	[Address(RVA = "0xD9BB84", Offset = "0xD9BB84", VA = "0xD9BB84")]
	public MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort)
	{
		return null;
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001362")]
	[Address(RVA = "0xD9BC70", Offset = "0xD9BC70", VA = "0xD9BC70")]
	public void SetPendingSession(MPSession session)
	{
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001363")]
	[Address(RVA = "0xD91B48", Offset = "0xD91B48", VA = "0xD91B48")]
	public void CheckShutdownSwitchMPMenus()
	{
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001364")]
	[Address(RVA = "0xD9BD74", Offset = "0xD9BD74", VA = "0xD9BD74")]
	public void UpdateUI()
	{
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001365")]
	[Address(RVA = "0xD9C74C", Offset = "0xD9C74C", VA = "0xD9C74C")]
	public void PlayerSelected()
	{
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001366")]
	[Address(RVA = "0xD9BC78", Offset = "0xD9BC78", VA = "0xD9BC78")]
	public void CancelPending()
	{
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001367")]
	[Address(RVA = "0xD9CB18", Offset = "0xD9CB18", VA = "0xD9CB18")]
	public void OpenInviteOverlay()
	{
	}

	// Token: 0x04002555 RID: 9557
	[Token(Token = "0x4002555")]
	[FieldOffset(Offset = "0x0")]
	public static MPSessionManager Instance;

	// Token: 0x04002556 RID: 9558
	[Token(Token = "0x4002556")]
	[FieldOffset(Offset = "0x8")]
	public MPSession SessionJoining;

	// Token: 0x04002557 RID: 9559
	[Token(Token = "0x4002557")]
	[FieldOffset(Offset = "0xC")]
	public MPSession CurrentSession;

	// Token: 0x04002558 RID: 9560
	[Token(Token = "0x4002558")]
	[FieldOffset(Offset = "0x10")]
	public MPSession PendingSession;

	// Token: 0x04002559 RID: 9561
	[Token(Token = "0x4002559")]
	[FieldOffset(Offset = "0x14")]
	public MPSessionAPI platformAPI;

	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	public enum LobbyState
	{
		// Token: 0x0400255B RID: 9563
		[Token(Token = "0x400255B")]
		None,
		// Token: 0x0400255C RID: 9564
		[Token(Token = "0x400255C")]
		MenuLobby,
		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		InProgress,
		// Token: 0x0400255E RID: 9566
		[Token(Token = "0x400255E")]
		Shutdown
	}

	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	public class MPSessionFriendSearchEntry
	{
		// Token: 0x06001368 RID: 4968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001368")]
		[Address(RVA = "0xD9CD34", Offset = "0xD9CD34", VA = "0xD9CD34")]
		public MPSessionFriendSearchEntry(MPSession session)
		{
		}

		// Token: 0x0400255F RID: 9567
		[Token(Token = "0x400255F")]
		[FieldOffset(Offset = "0x8")]
		public readonly MPSession Session;

		// Token: 0x04002560 RID: 9568
		[Token(Token = "0x4002560")]
		[FieldOffset(Offset = "0xC")]
		public readonly List<PlatformUser> Friends;
	}

	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	public class MPSessionFriendSearchResult : List<MPSessionManager.MPSessionFriendSearchEntry>
	{
		// Token: 0x06001369 RID: 4969 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x6001369")]
		[Address(RVA = "0xD9CDD4", Offset = "0xD9CDD4", VA = "0xD9CDD4")]
		public bool AddFriendResult(MPSession session, PlatformUser user)
		{
			return default(bool);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00008D18 File Offset: 0x00006F18
		[Token(Token = "0x600136A")]
		[Address(RVA = "0xD9D1A4", Offset = "0xD9D1A4", VA = "0xD9D1A4")]
		public bool AddFriendResults(MPSession session, List<PlatformUser> Friends)
		{
			return default(bool);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136B")]
		[Address(RVA = "0xD9D4BC", Offset = "0xD9D4BC", VA = "0xD9D4BC")]
		public void RemoveInvalidSession(MPSession session)
		{
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136C")]
		[Address(RVA = "0xD9D620", Offset = "0xD9D620", VA = "0xD9D620")]
		public MPSessionFriendSearchResult()
		{
		}
	}
}
