using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200004E RID: 78
[Token(Token = "0x200004E")]
public static class XBOOnlinePresencePermissions
{
	// Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x4A5E38", Offset = "0x4A5E38", VA = "0x4A5E38")]
	public static void Reset()
	{
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x4A60C4", Offset = "0x4A60C4", VA = "0x4A60C4")]
	public static void CanSeeOnlinePresence(string xboPlayerId, XBOOnlinePresencePermissions.OnlinePresencePermissionsResult result)
	{
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x4A6474", Offset = "0x4A6474", VA = "0x4A6474")]
	public static void SetPermissions(string xboPlayerId, bool canCommunicate)
	{
	}

	// Token: 0x04000385 RID: 901
	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, XBOOnlinePresencePermissions.RequestResult> _inprogress;

	// Token: 0x04000386 RID: 902
	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, bool> _cachedOnlinePresencePermissions;

	// Token: 0x0200004F RID: 79
	// (Invoke) Token: 0x060001A0 RID: 416
	[Token(Token = "0x200004F")]
	public delegate void OnlinePresencePermissionsResult(string playerId, bool result);

	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class RequestResult
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x4A60B8", Offset = "0x4A60B8", VA = "0x4A60B8")]
		public void Clear()
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060001A4 RID: 420 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060001A5 RID: 421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000004")]
		public event XBOOnlinePresencePermissions.OnlinePresencePermissionsResult ResultCallbacks
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x4A63C4", Offset = "0x4A63C4", VA = "0x4A63C4")]
			add
			{
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x4A67C8", Offset = "0x4A67C8", VA = "0x4A67C8")]
			remove
			{
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x4A6878", Offset = "0x4A6878", VA = "0x4A6878")]
		public RequestResult()
		{
		}

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x8")]
		public string xboPlayerId;
	}
}
