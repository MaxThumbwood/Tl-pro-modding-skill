using System;
using Il2CppDummyDll;

// Token: 0x02000041 RID: 65
[Token(Token = "0x2000041")]
[Serializable]
public class DrEditorProfile
{
	// Token: 0x06000167 RID: 359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x4A5074", Offset = "0x4A5074", VA = "0x4A5074")]
	public DrEditorProfile()
	{
	}

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x8")]
	public string Name;

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0xC")]
	public string RootFolder;

	// Token: 0x04000352 RID: 850
	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x10")]
	public bool HasMultiplayerPermission;

	// Token: 0x04000353 RID: 851
	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x11")]
	public bool HasChatPermission;

	// Token: 0x04000354 RID: 852
	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x12")]
	public bool HasUGCPermission;
}
