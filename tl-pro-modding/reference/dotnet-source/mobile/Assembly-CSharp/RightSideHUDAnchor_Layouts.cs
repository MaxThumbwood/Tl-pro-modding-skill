using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200025B RID: 603
[Token(Token = "0x200025B")]
public class RightSideHUDAnchor_Layouts : LayoutDefinition
{
	// Token: 0x06000E70 RID: 3696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E70")]
	[Address(RVA = "0xC94C30", Offset = "0xC94C30", VA = "0xC94C30")]
	private void Awake()
	{
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E71")]
	[Address(RVA = "0xC94C84", Offset = "0xC94C84", VA = "0xC94C84")]
	public RightSideHUDAnchor_Layouts()
	{
	}

	// Token: 0x04001C6C RID: 7276
	[Token(Token = "0x4001C6C")]
	[FieldOffset(Offset = "0x0")]
	public static RightSideHUDAnchor_Layouts Instance;

	// Token: 0x04001C6D RID: 7277
	[Token(Token = "0x4001C6D")]
	[FieldOffset(Offset = "0xC")]
	public Anchor_Layout StartAnchor;

	// Token: 0x04001C6E RID: 7278
	[Token(Token = "0x4001C6E")]
	[FieldOffset(Offset = "0x10")]
	public Anchor_Layout StartAnchor2;

	// Token: 0x04001C6F RID: 7279
	[Token(Token = "0x4001C6F")]
	[FieldOffset(Offset = "0x14")]
	public Anchor_Layout StartAnchorHorizontalBars;

	// Token: 0x04001C70 RID: 7280
	[Token(Token = "0x4001C70")]
	[FieldOffset(Offset = "0x18")]
	public Anchor_Layout StartAnchorHorizontalBars2;

	// Token: 0x04001C71 RID: 7281
	[Token(Token = "0x4001C71")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 NonMapSpacing;

	// Token: 0x04001C72 RID: 7282
	[Token(Token = "0x4001C72")]
	[FieldOffset(Offset = "0x24")]
	public float MapSpacing;

	// Token: 0x04001C73 RID: 7283
	[Token(Token = "0x4001C73")]
	[FieldOffset(Offset = "0x28")]
	public float MapSpacingLarge;

	// Token: 0x04001C74 RID: 7284
	[Token(Token = "0x4001C74")]
	[FieldOffset(Offset = "0x2C")]
	public float MiniChatSpacing;

	// Token: 0x04001C75 RID: 7285
	[Token(Token = "0x4001C75")]
	[FieldOffset(Offset = "0x30")]
	public float EvemtSpacing;

	// Token: 0x04001C76 RID: 7286
	[Token(Token = "0x4001C76")]
	[FieldOffset(Offset = "0x34")]
	public float BossBarSpacing;

	// Token: 0x04001C77 RID: 7287
	[Token(Token = "0x4001C77")]
	[FieldOffset(Offset = "0x38")]
	public float StatusIndicatorSpacing;

	// Token: 0x04001C78 RID: 7288
	[Token(Token = "0x4001C78")]
	[FieldOffset(Offset = "0x3C")]
	public bool AllowMapMovement;
}
