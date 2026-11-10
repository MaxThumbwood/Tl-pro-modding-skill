using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000183 RID: 387
[Token(Token = "0x2000183")]
public class GUISettings
{
	// Token: 0x06000B5C RID: 2908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5C")]
	[Address(RVA = "0xC212D4", Offset = "0xC212D4", VA = "0xC212D4")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0xC21414", Offset = "0xC21414", VA = "0xC21414")]
	public void ShutdownUI()
	{
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x000069F0 File Offset: 0x00004BF0
	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0xC217CC", Offset = "0xC217CC", VA = "0xC217CC")]
	public bool Draw()
	{
		return default(bool);
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0xC24650", Offset = "0xC24650", VA = "0xC24650")]
	public GUISettings()
	{
	}

	// Token: 0x04000D86 RID: 3462
	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0x8")]
	public bool Visible;

	// Token: 0x04000D87 RID: 3463
	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0x9")]
	public bool KeySwitch;

	// Token: 0x04000D88 RID: 3464
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0xA")]
	public bool KeyRelease;

	// Token: 0x04000D89 RID: 3465
	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0x0")]
	public static Texture2D _settingsTexture;

	// Token: 0x04000D8A RID: 3466
	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0x4")]
	private static Texture2D _settingsSelectedTexture;

	// Token: 0x04000D8B RID: 3467
	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0xC")]
	private float settingsButtonScale;
}
