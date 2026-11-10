using System;
using Il2CppDummyDll;

// Token: 0x02000045 RID: 69
[Token(Token = "0x2000045")]
public class PlatformControllerDisplay : Singleton<PlatformControllerDisplay>
{
	// Token: 0x0600017D RID: 381 RVA: 0x00002AC0 File Offset: 0x00000CC0
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x4A5128", Offset = "0x4A5128", VA = "0x4A5128")]
	public PlatformControllerDisplay.ControllerDisplayState DisplayedController()
	{
		return PlatformControllerDisplay.ControllerDisplayState.Controller_None;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x4A525C", Offset = "0x4A525C", VA = "0x4A525C")]
	public PlatformControllerDisplay()
	{
	}

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0xC")]
	public string[] Controller_XBO;

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x10")]
	public string[] Controller_PS4;

	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public enum ControllerDisplayState
	{
		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		Controller_None,
		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		Controller_XBO,
		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		Controller_PS4
	}

	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[Serializable]
	public class PlatformControllerDisplayState
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x4A52EC", Offset = "0x4A52EC", VA = "0x4A52EC")]
		public PlatformControllerDisplayState()
		{
		}

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x8")]
		public string ControllerId;

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0xC")]
		public PlatformControllerDisplay.ControllerDisplayState DisplayState;
	}
}
