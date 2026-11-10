using System;
using Il2CppDummyDll;
using Terraria.WorldBuilding;

// Token: 0x020002C8 RID: 712
[Token(Token = "0x20002C8")]
public class GUIWorldGenerateMenu
{
	// Token: 0x06001187 RID: 4487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001187")]
	[Address(RVA = "0xD43A80", Offset = "0xD43A80", VA = "0xD43A80")]
	public void Draw()
	{
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001188")]
	[Address(RVA = "0xD444BC", Offset = "0xD444BC", VA = "0xD444BC")]
	public GUIWorldGenerateMenu()
	{
	}

	// Token: 0x04002243 RID: 8771
	[Token(Token = "0x4002243")]
	[FieldOffset(Offset = "0x8")]
	public GenerationProgress Progress;

	// Token: 0x04002244 RID: 8772
	[Token(Token = "0x4002244")]
	[FieldOffset(Offset = "0xC")]
	public float totalProgress;

	// Token: 0x04002245 RID: 8773
	[Token(Token = "0x4002245")]
	[FieldOffset(Offset = "0x10")]
	public float progress;
}
