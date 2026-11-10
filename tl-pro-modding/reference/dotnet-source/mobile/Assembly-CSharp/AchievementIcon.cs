using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001A5 RID: 421
[Token(Token = "0x20001A5")]
[Serializable]
public class AchievementIcon
{
	// Token: 0x06000C71 RID: 3185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C71")]
	[Address(RVA = "0xC663D4", Offset = "0xC663D4", VA = "0xC663D4")]
	private void Awake()
	{
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C72")]
	[Address(RVA = "0xC66428", Offset = "0xC66428", VA = "0xC66428")]
	public AchievementIcon()
	{
	}

	// Token: 0x04000FA0 RID: 4000
	[Token(Token = "0x4000FA0")]
	[FieldOffset(Offset = "0x0")]
	public static AchievementIcon Instance;

	// Token: 0x04000FA1 RID: 4001
	[Token(Token = "0x4000FA1")]
	[FieldOffset(Offset = "0x8")]
	public string SpriteTextureID;

	// Token: 0x04000FA2 RID: 4002
	[Token(Token = "0x4000FA2")]
	[FieldOffset(Offset = "0xC")]
	public string BorderTextureID;

	// Token: 0x04000FA3 RID: 4003
	[Token(Token = "0x4000FA3")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x04000FA4 RID: 4004
	[Token(Token = "0x4000FA4")]
	[FieldOffset(Offset = "0x14")]
	public int SpriteIconSize;

	// Token: 0x04000FA5 RID: 4005
	[Token(Token = "0x4000FA5")]
	[FieldOffset(Offset = "0x18")]
	public int SpriteIconSizeWithSpace;

	// Token: 0x04000FA6 RID: 4006
	[Token(Token = "0x4000FA6")]
	[FieldOffset(Offset = "0x1C")]
	public int SpriteIconsPerRow;

	// Token: 0x04000FA7 RID: 4007
	[Token(Token = "0x4000FA7")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 BorderLocation;

	// Token: 0x04000FA8 RID: 4008
	[Token(Token = "0x4000FA8")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 IconLocation;

	// Token: 0x04000FA9 RID: 4009
	[Token(Token = "0x4000FA9")]
	[FieldOffset(Offset = "0x30")]
	public float IconScale;
}
