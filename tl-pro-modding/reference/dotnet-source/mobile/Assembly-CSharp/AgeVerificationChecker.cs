using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027F RID: 639
[Token(Token = "0x200027F")]
public class AgeVerificationChecker : MonoBehaviour
{
	// Token: 0x06000EDB RID: 3803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0xC9EB7C", Offset = "0xC9EB7C", VA = "0xC9EB7C")]
	public static void PerformCheck()
	{
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0xC9EB80", Offset = "0xC9EB80", VA = "0xC9EB80")]
	public static void Draw()
	{
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0xC9EEB0", Offset = "0xC9EEB0", VA = "0xC9EEB0")]
	public void Request()
	{
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0xC9FC10", Offset = "0xC9FC10", VA = "0xC9FC10")]
	private void RequestEditor()
	{
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0xC9EF08", Offset = "0xC9EF08", VA = "0xC9EF08")]
	private void RequestGoogle()
	{
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0xC9FD78", Offset = "0xC9FD78", VA = "0xC9FD78")]
	private void RequestSamsung()
	{
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0xC9F4D4", Offset = "0xC9F4D4", VA = "0xC9F4D4")]
	private void RequestIOS()
	{
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0xC9F644", Offset = "0xC9F644", VA = "0xC9F644")]
	private void RequestAmazon()
	{
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0xC9FC64", Offset = "0xC9FC64", VA = "0xC9FC64")]
	public void OnResult(string result)
	{
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0xCA0344", Offset = "0xCA0344", VA = "0xCA0344")]
	public AgeVerificationChecker()
	{
	}

	// Token: 0x04001ED5 RID: 7893
	[Token(Token = "0x4001ED5")]
	[FieldOffset(Offset = "0x0")]
	public static AgeVerificationChecker Instance;

	// Token: 0x04001ED6 RID: 7894
	[Token(Token = "0x4001ED6")]
	[FieldOffset(Offset = "0xC")]
	public AgeVerificationChecker.Status State;

	// Token: 0x02000280 RID: 640
	[Token(Token = "0x2000280")]
	public enum Status
	{
		// Token: 0x04001ED8 RID: 7896
		[Token(Token = "0x4001ED8")]
		Valid,
		// Token: 0x04001ED9 RID: 7897
		[Token(Token = "0x4001ED9")]
		Retry,
		// Token: 0x04001EDA RID: 7898
		[Token(Token = "0x4001EDA")]
		Supervised_Denied,
		// Token: 0x04001EDB RID: 7899
		[Token(Token = "0x4001EDB")]
		Supervised_Pending,
		// Token: 0x04001EDC RID: 7900
		[Token(Token = "0x4001EDC")]
		Supervised_Underaged
	}
}
