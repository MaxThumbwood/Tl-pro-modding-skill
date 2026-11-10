using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000370 RID: 880
[Token(Token = "0x2000370")]
public class ScreenshotTool : MonoBehaviour
{
	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x060015A5 RID: 5541 RVA: 0x00009810 File Offset: 0x00007A10
	// (set) Token: 0x060015A6 RID: 5542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F7")]
	public bool UseControllerInput
	{
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0xDFE03C", Offset = "0xDFE03C", VA = "0xDFE03C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0xDFE044", Offset = "0xDFE044", VA = "0xDFE044")]
		set
		{
		}
	}

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00009828 File Offset: 0x00007A28
	[Token(Token = "0x170001F8")]
	public bool TakeScreenShotThisFrame
	{
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0xDFE04C", Offset = "0xDFE04C", VA = "0xDFE04C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A8")]
	[Address(RVA = "0xDFE0D8", Offset = "0xDFE0D8", VA = "0xDFE0D8")]
	private void Awake()
	{
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060015AA RID: 5546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F9")]
	public ScreenshotSetup ActiveScreenshot
	{
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0xDFE12C", Offset = "0xDFE12C", VA = "0xDFE12C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0xDFE134", Offset = "0xDFE134", VA = "0xDFE134")]
		set
		{
		}
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AB")]
	[Address(RVA = "0xDFE13C", Offset = "0xDFE13C", VA = "0xDFE13C")]
	public ScreenshotTool()
	{
	}

	// Token: 0x04002A0A RID: 10762
	[Token(Token = "0x4002A0A")]
	[FieldOffset(Offset = "0x0")]
	public static ScreenshotTool Instance;

	// Token: 0x04002A0B RID: 10763
	[Token(Token = "0x4002A0B")]
	[FieldOffset(Offset = "0xC")]
	public bool TakeScreenShot;

	// Token: 0x04002A0C RID: 10764
	[Token(Token = "0x4002A0C")]
	[FieldOffset(Offset = "0x10")]
	public float InitialDelay;

	// Token: 0x04002A0D RID: 10765
	[Token(Token = "0x4002A0D")]
	[FieldOffset(Offset = "0x14")]
	private bool LastTakeShot;

	// Token: 0x04002A0E RID: 10766
	[Token(Token = "0x4002A0E")]
	[FieldOffset(Offset = "0x18")]
	private float delayRemaining;

	// Token: 0x04002A0F RID: 10767
	[Token(Token = "0x4002A0F")]
	[FieldOffset(Offset = "0x1C")]
	private bool useControllerInput;

	// Token: 0x04002A10 RID: 10768
	[Token(Token = "0x4002A10")]
	[FieldOffset(Offset = "0x20")]
	private ScreenshotSetup _activeScreenshot;

	// Token: 0x04002A11 RID: 10769
	[Token(Token = "0x4002A11")]
	[FieldOffset(Offset = "0x24")]
	public ScreenshotSetup[] Definitions;
}
