using System;
using Il2CppDummyDll;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
public static class Android_UserManager
{
	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x17000042")]
	public static DrPlatform.Android.User.LoginState CurrentState
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x49EEE4", Offset = "0x49EEE4", VA = "0x49EEE4")]
		get
		{
			return DrPlatform.Android.User.LoginState.Waiting;
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x17000043")]
	public static bool AttemptingSignIn
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x49EFE8", Offset = "0x49EFE8", VA = "0x49EFE8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000044")]
	public static string UserId
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x49F0AC", Offset = "0x49F0AC", VA = "0x49F0AC")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000045")]
	public static string GamerTag
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x49F110", Offset = "0x49F110", VA = "0x49F110")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000046")]
	public static string AccountProfileURL
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x49F174", Offset = "0x49F174", VA = "0x49F174")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x49F1D8", Offset = "0x49F1D8", VA = "0x49F1D8")]
	public static void RequestLogin()
	{
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x49F240", Offset = "0x49F240", VA = "0x49F240")]
	public static void Logout()
	{
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x49F48C", Offset = "0x49F48C", VA = "0x49F48C")]
	public static void ClearCache()
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x49F5A8", Offset = "0x49F5A8", VA = "0x49F5A8")]
	public static void Update()
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x49FB00", Offset = "0x49FB00", VA = "0x49FB00")]
	private static void AttemptSignIn()
	{
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x49F2AC", Offset = "0x49F2AC", VA = "0x49F2AC")]
	private static void playerLoggedOut()
	{
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x49FF6C", Offset = "0x49FF6C", VA = "0x49FF6C")]
	private static void playerAuthenticated()
	{
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x49FDB4", Offset = "0x49FDB4", VA = "0x49FDB4")]
	private static void _authenticationSucceededEvent(string userID)
	{
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x49FE90", Offset = "0x49FE90", VA = "0x49FE90")]
	private static void _authenticationFailedEvent(string error)
	{
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002760 File Offset: 0x00000960
	// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000047")]
	public static bool EditorSignedIn
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x49FCDC", Offset = "0x49FCDC", VA = "0x49FCDC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x4A0430", Offset = "0x4A0430", VA = "0x4A0430")]
		set
		{
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000048")]
	public static string EditorUserId
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x49FD3C", Offset = "0x49FD3C", VA = "0x49FD3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x4A0498", Offset = "0x4A0498", VA = "0x4A0498")]
		set
		{
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000049")]
	public static string EditorUserAlias
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x4A03B0", Offset = "0x4A03B0", VA = "0x4A03B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x4A04F8", Offset = "0x4A04F8", VA = "0x4A04F8")]
		set
		{
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002778 File Offset: 0x00000978
	// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700004A")]
	public static float EditorSignInProcessTimeout
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x49FC88", Offset = "0x49FC88", VA = "0x49FC88")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x4A0560", Offset = "0x4A0560", VA = "0x4A0560")]
		set
		{
		}
	}

	// Token: 0x040002F9 RID: 761
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x0")]
	public static bool EditorAttemptingSignIn;

	// Token: 0x040002FA RID: 762
	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x8")]
	public static DateTime EditorSignInStart;

	// Token: 0x040002FB RID: 763
	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x10")]
	private static bool _delayedStartup;

	// Token: 0x040002FC RID: 764
	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x14")]
	private static string s_userId;

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x18")]
	private static string s_gamerTag;

	// Token: 0x040002FE RID: 766
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x1C")]
	private static string s_avatarImageURL;

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x20")]
	private static bool s_requestedLogin;

	// Token: 0x04000300 RID: 768
	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x21")]
	private static bool s_attemptedPassiveLogin;

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x22")]
	private static bool s_currentlyLoggingIn;

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x4000302")]
	private const string c_accountIdLastUserKey = "AccountId_LastUser";

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x4000303")]
	private const string c_accountIdLastUserGameTag = "AccountGamerTag_LastUser";

	// Token: 0x04000304 RID: 772
	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x23")]
	private static bool s_usingCachedId;
}
