using System;
using Il2CppDummyDll;

// Token: 0x02000304 RID: 772
[Token(Token = "0x2000304")]
public class MPSession_Local : FileAPI
{
	// Token: 0x0600133B RID: 4923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133B")]
	[Address(RVA = "0xD9B628", Offset = "0xD9B628", VA = "0xD9B628")]
	public MPSession_Local()
	{
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x00008C88 File Offset: 0x00006E88
	[Token(Token = "0x600133C")]
	[Address(RVA = "0xD9B70C", Offset = "0xD9B70C", VA = "0xD9B70C", Slot = "16")]
	public bool IsSameSession(MPSession session)
	{
		return default(bool);
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133D")]
	[Address(RVA = "0xD9B790", Offset = "0xD9B790", VA = "0xD9B790", Slot = "6")]
	public void GetServerConnection(out string server, out int port)
	{
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x00008CA0 File Offset: 0x00006EA0
	[Token(Token = "0x600133E")]
	[Address(RVA = "0xD9B7F0", Offset = "0xD9B7F0", VA = "0xD9B7F0", Slot = "4")]
	public PlatformUser GetHost()
	{
		return default(PlatformUser);
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x00008CB8 File Offset: 0x00006EB8
	[Token(Token = "0x600133F")]
	[Address(RVA = "0xD9B804", Offset = "0xD9B804", VA = "0xD9B804", Slot = "5")]
	public MPSessionManager.LobbyState GetState()
	{
		return MPSessionManager.LobbyState.None;
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001340")]
	[Address(RVA = "0xD9B80C", Offset = "0xD9B80C", VA = "0xD9B80C", Slot = "7")]
	public void SetState(MPSessionManager.LobbyState newState)
	{
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001341")]
	[Address(RVA = "0xD9B81C", Offset = "0xD9B81C", VA = "0xD9B81C", Slot = "12")]
	public void UpdatePlayerCount()
	{
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x00008CD0 File Offset: 0x00006ED0
	[Token(Token = "0x6001342")]
	[Address(RVA = "0xD9B820", Offset = "0xD9B820", VA = "0xD9B820", Slot = "13")]
	public bool CanInvite()
	{
		return default(bool);
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001343")]
	[Address(RVA = "0xD9B828", Offset = "0xD9B828", VA = "0xD9B828", Slot = "10")]
	public MPSessionMetaData GetMetaData()
	{
		return null;
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001344")]
	[Address(RVA = "0xD9B830", Offset = "0xD9B830", VA = "0xD9B830", Slot = "11")]
	public void SetMetaData(MPSessionMetaData data)
	{
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001345")]
	[Address(RVA = "0xD9B838", Offset = "0xD9B838", VA = "0xD9B838", Slot = "9")]
	public void SetClientInSession(bool activeInSession)
	{
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x00008CE8 File Offset: 0x00006EE8
	[Token(Token = "0x6001346")]
	[Address(RVA = "0xD9B848", Offset = "0xD9B848", VA = "0xD9B848", Slot = "8")]
	public bool ClientInSession()
	{
		return default(bool);
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001347")]
	[Address(RVA = "0xD9B850", Offset = "0xD9B850", VA = "0xD9B850", Slot = "14")]
	public void Leave(PlatformUser localUser)
	{
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001348")]
	[Address(RVA = "0xD9B86C", Offset = "0xD9B86C", VA = "0xD9B86C", Slot = "15")]
	public void Join(PlatformUser localUser)
	{
	}

	// Token: 0x0400254F RID: 9551
	[Token(Token = "0x400254F")]
	[FieldOffset(Offset = "0x8")]
	private MPSessionManager.LobbyState state;

	// Token: 0x04002550 RID: 9552
	[Token(Token = "0x4002550")]
	[FieldOffset(Offset = "0xC")]
	private PlatformUser hostUser;

	// Token: 0x04002551 RID: 9553
	[Token(Token = "0x4002551")]
	[FieldOffset(Offset = "0x14")]
	private MPSessionMetaData MetaData;

	// Token: 0x04002552 RID: 9554
	[Token(Token = "0x4002552")]
	[FieldOffset(Offset = "0x18")]
	private bool ActiveInSession;

	// Token: 0x04002553 RID: 9555
	[Token(Token = "0x4002553")]
	[FieldOffset(Offset = "0x1C")]
	private string serverAddress;

	// Token: 0x04002554 RID: 9556
	[Token(Token = "0x4002554")]
	[FieldOffset(Offset = "0x20")]
	private int serverPort;
}
