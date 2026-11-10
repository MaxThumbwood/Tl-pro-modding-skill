using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000281 RID: 641
[Token(Token = "0x2000281")]
public class GUIAccountProfile
{
	// Token: 0x06000EE5 RID: 3813 RVA: 0x00007A88 File Offset: 0x00005C88
	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0xCA034C", Offset = "0xCA034C", VA = "0xCA034C")]
	public bool AnyAvailable()
	{
		return default(bool);
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0xCA0354", Offset = "0xCA0354", VA = "0xCA0354")]
	public void Draw()
	{
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0xCA03BC", Offset = "0xCA03BC", VA = "0xCA03BC")]
	public GUIAccountProfile()
	{
	}

	// Token: 0x04001EDD RID: 7901
	[Token(Token = "0x4001EDD")]
	[FieldOffset(Offset = "0x8")]
	private string displayName;

	// Token: 0x04001EDE RID: 7902
	[Token(Token = "0x4001EDE")]
	[FieldOffset(Offset = "0xC")]
	private Texture2D profileTexture;
}
