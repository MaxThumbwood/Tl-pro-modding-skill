using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000042")]
public class DrPlatformEditorData : MonoBehaviour
{
	// Token: 0x06000168 RID: 360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x4A507C", Offset = "0x4A507C", VA = "0x4A507C")]
	private void Awake()
	{
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006E")]
	public DrEditorProfile ActiveProfile
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x4A2258", Offset = "0x4A2258", VA = "0x4A2258")]
		get
		{
			return null;
		}
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x4A50D0", Offset = "0x4A50D0", VA = "0x4A50D0")]
		set
		{
		}
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x4A50D8", Offset = "0x4A50D8", VA = "0x4A50D8")]
	public DrPlatformEditorData()
	{
	}

	// Token: 0x04000355 RID: 853
	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x0")]
	public static DrPlatformEditorData Instance;

	// Token: 0x04000356 RID: 854
	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0xC")]
	public bool ForcePlatform;

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x10")]
	public DrPlatform.DrPlatformType ForcedPlatform;

	// Token: 0x04000358 RID: 856
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x14")]
	public bool ForceSKU;

	// Token: 0x04000359 RID: 857
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x18")]
	public DrPlatform.DrSKUType ForcedSKU;

	// Token: 0x0400035A RID: 858
	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x1C")]
	public bool EditorHasMultiplayerPermission;

	// Token: 0x0400035B RID: 859
	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x1D")]
	public bool EditorHasChatPermission;

	// Token: 0x0400035C RID: 860
	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x1E")]
	public bool EditorHasUGCPermission;

	// Token: 0x0400035D RID: 861
	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x1F")]
	public bool EditorHasPlatformFriends;

	// Token: 0x0400035E RID: 862
	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x20")]
	public bool EditorForceControllerDisconnected;

	// Token: 0x0400035F RID: 863
	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x21")]
	public bool EditorForceSplitScreenProfile;

	// Token: 0x04000360 RID: 864
	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x22")]
	public bool EditorSwitchedDocked;

	// Token: 0x04000361 RID: 865
	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x23")]
	public bool EditorIsTrial;

	// Token: 0x04000362 RID: 866
	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x24")]
	public bool EditorSwitchJoyCon;

	// Token: 0x04000363 RID: 867
	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x25")]
	public bool EditorMouseAsTouch;

	// Token: 0x04000364 RID: 868
	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x26")]
	public bool EditorIsChromebook;

	// Token: 0x04000365 RID: 869
	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x27")]
	public bool EditorIsVisionOS;

	// Token: 0x04000366 RID: 870
	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x28")]
	public bool UseSecondICloudPath;

	// Token: 0x04000367 RID: 871
	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x29")]
	public bool UseProfiles;

	// Token: 0x04000368 RID: 872
	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x2A")]
	public bool ValidateSetup;

	// Token: 0x04000369 RID: 873
	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x2B")]
	private bool _firstProfileAccess;

	// Token: 0x0400036A RID: 874
	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x2C")]
	private DrEditorProfile _activeProfile;

	// Token: 0x0400036B RID: 875
	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x30")]
	public int InitialEditorProfile;

	// Token: 0x0400036C RID: 876
	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x34")]
	public DrEditorProfile[] EditorProfiles;
}
