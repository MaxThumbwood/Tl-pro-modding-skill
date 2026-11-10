using System;
using System.Collections.Generic;
using Controller;
using Il2CppDummyDll;
using Terraria;

// Token: 0x02000323 RID: 803
[Token(Token = "0x2000323")]
public class UserManagement
{
	// Token: 0x060013D5 RID: 5077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D5")]
	[Address(RVA = "0xDAC0E8", Offset = "0xDAC0E8", VA = "0xDAC0E8")]
	public static void HandleNetworkLost()
	{
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D6")]
	[Address(RVA = "0xDAC5F0", Offset = "0xDAC5F0", VA = "0xDAC5F0")]
	public static void SetupPrimary()
	{
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D7")]
	[Address(RVA = "0xDAC6D8", Offset = "0xDAC6D8", VA = "0xDAC6D8")]
	public static void SwitchPrimaryUser(PlatformUser platformUser, bool reuseData = false)
	{
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D8")]
	[Address(RVA = "0xDAE068", Offset = "0xDAE068", VA = "0xDAE068")]
	public static void UserSignIn(ControllerDevice localDevice, PlatformUser platformUser)
	{
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D9")]
	[Address(RVA = "0xDAE2D8", Offset = "0xDAE2D8", VA = "0xDAE2D8")]
	public static void AddUser(ControllerDevice localDevice, PlatformUser platformUser)
	{
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DA")]
	[Address(RVA = "0xDAE70C", Offset = "0xDAE70C", VA = "0xDAE70C")]
	public static void UserSignedOut(PlatformUser user)
	{
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DB")]
	[Address(RVA = "0xDAEB24", Offset = "0xDAEB24", VA = "0xDAEB24")]
	public static void LocalUserQuit(LocalUser user)
	{
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DC")]
	[Address(RVA = "0xDAEFA0", Offset = "0xDAEFA0", VA = "0xDAEFA0")]
	public static void SignInController(ControllerDevice localDevice)
	{
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x00008F58 File Offset: 0x00007158
	[Token(Token = "0x60013DD")]
	[Address(RVA = "0xDAEFA4", Offset = "0xDAEFA4", VA = "0xDAEFA4")]
	public static bool CanControllerBeUserForPrimaryPlayer(ControllerDevice localDevice)
	{
		return default(bool);
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x00008F70 File Offset: 0x00007170
	[Token(Token = "0x60013DE")]
	[Address(RVA = "0xDAEFAC", Offset = "0xDAEFAC", VA = "0xDAEFAC")]
	public static bool CanControllerBeUsedForPlayer(ControllerDevice localDevice, LocalUser user)
	{
		return default(bool);
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DF")]
	[Address(RVA = "0xDAEFB4", Offset = "0xDAEFB4", VA = "0xDAEFB4")]
	public static LocalUser FindLocalUserByUser(PlatformUser user)
	{
		return null;
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E0")]
	[Address(RVA = "0xDAF174", Offset = "0xDAF174", VA = "0xDAF174")]
	public static LocalUser FindLocalUserByPlayer(Player player)
	{
		return null;
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E1")]
	[Address(RVA = "0xDAF2E8", Offset = "0xDAF2E8", VA = "0xDAF2E8")]
	public static LocalUser FindLocalUserByController(ControllerDevice controller)
	{
		return null;
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E2")]
	[Address(RVA = "0xDAF444", Offset = "0xDAF444", VA = "0xDAF444")]
	public static void LookForNewUsers()
	{
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E3")]
	[Address(RVA = "0xDAF910", Offset = "0xDAF910", VA = "0xDAF910")]
	public void SwitchUser(int index)
	{
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E4")]
	[Address(RVA = "0xDAD1D8", Offset = "0xDAD1D8", VA = "0xDAD1D8")]
	public static void UpdateViewPorts()
	{
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E5")]
	[Address(RVA = "0xDAF914", Offset = "0xDAF914", VA = "0xDAF914")]
	public void ApplyCameras()
	{
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E6")]
	[Address(RVA = "0xDAFA88", Offset = "0xDAFA88", VA = "0xDAFA88")]
	public UserManagement()
	{
	}

	// Token: 0x04002799 RID: 10137
	[Token(Token = "0x4002799")]
	[FieldOffset(Offset = "0x0")]
	private static List<int> AvailableIndices;

	// Token: 0x0400279A RID: 10138
	[Token(Token = "0x400279A")]
	[FieldOffset(Offset = "0x4")]
	public static int PendingSplitChange;

	// Token: 0x0400279B RID: 10139
	[Token(Token = "0x400279B")]
	[FieldOffset(Offset = "0x8")]
	public static bool SplitHorizontalFirst;

	// Token: 0x0400279C RID: 10140
	[Token(Token = "0x400279C")]
	[FieldOffset(Offset = "0xC")]
	public static LocalUser PrimaryPlayer;

	// Token: 0x0400279D RID: 10141
	[Token(Token = "0x400279D")]
	[FieldOffset(Offset = "0x10")]
	public static List<LocalUser> LocalUsers;

	// Token: 0x0400279E RID: 10142
	[Token(Token = "0x400279E")]
	[FieldOffset(Offset = "0x14")]
	public static LocalUser PendingUser;
}
