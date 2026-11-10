using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000048 RID: 72
[Token(Token = "0x2000048")]
public static class XBOChatPermissions
{
	// Token: 0x06000180 RID: 384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x4A52F4", Offset = "0x4A52F4", VA = "0x4A52F4")]
	public static void Reset()
	{
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x4A5580", Offset = "0x4A5580", VA = "0x4A5580")]
	public static void CanChatWith(string xboPlayerId, XBOChatPermissions.ChatPermissionsResult result)
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x4A5930", Offset = "0x4A5930", VA = "0x4A5930")]
	public static void SetPermissions(string xboPlayerId, bool canCommunicate)
	{
	}

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, XBOChatPermissions.RequestResult> _inprogress;

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, bool> _cachedChatPermissions;

	// Token: 0x02000049 RID: 73
	// (Invoke) Token: 0x06000185 RID: 389
	[Token(Token = "0x2000049")]
	public delegate void ChatPermissionsResult(string playerId, bool result);

	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class RequestResult
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4A5574", Offset = "0x4A5574", VA = "0x4A5574")]
		public void Clear()
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000189 RID: 393 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600018A RID: 394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000003")]
		public event XBOChatPermissions.ChatPermissionsResult ResultCallbacks
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x4A5880", Offset = "0x4A5880", VA = "0x4A5880")]
			add
			{
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x4A5C84", Offset = "0x4A5C84", VA = "0x4A5C84")]
			remove
			{
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4A5D34", Offset = "0x4A5D34", VA = "0x4A5D34")]
		public RequestResult()
		{
		}

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x8")]
		public string xboPlayerId;
	}
}
