using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000186 RID: 390
[Token(Token = "0x2000186")]
public class GUISpectatorMode
{
	// Token: 0x06000B71 RID: 2929 RVA: 0x00006A50 File Offset: 0x00004C50
	[Token(Token = "0x6000B71")]
	[Address(RVA = "0xC2B1C8", Offset = "0xC2B1C8", VA = "0xC2B1C8")]
	public bool CanSpectate()
	{
		return default(bool);
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B72")]
	[Address(RVA = "0xC2B700", Offset = "0xC2B700", VA = "0xC2B700")]
	public void SpectateNextPlayer(bool request = true)
	{
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B73")]
	[Address(RVA = "0xC2BA44", Offset = "0xC2BA44", VA = "0xC2BA44")]
	private void DrawTeleport()
	{
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B74")]
	[Address(RVA = "0xC2BD50", Offset = "0xC2BD50", VA = "0xC2BD50")]
	private void DrawCancel()
	{
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B75")]
	[Address(RVA = "0xC2B910", Offset = "0xC2B910", VA = "0xC2B910")]
	private void SpectatePlayer(int index)
	{
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0xC2C0A8", Offset = "0xC2C0A8", VA = "0xC2C0A8")]
	public void SpectatePreviousPlayer()
	{
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00006A68 File Offset: 0x00004C68
	[Token(Token = "0x17000108")]
	public bool Display
	{
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0xC2B2B8", Offset = "0xC2B2B8", VA = "0xC2B2B8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00006A80 File Offset: 0x00004C80
	[Token(Token = "0x17000109")]
	public bool shouldHideUI
	{
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0xC2C2B8", Offset = "0xC2C2B8", VA = "0xC2C2B8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0xC2C514", Offset = "0xC2C514", VA = "0xC2C514")]
	public void Draw()
	{
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x00006A98 File Offset: 0x00004C98
	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0xC2DB7C", Offset = "0xC2DB7C", VA = "0xC2DB7C")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0xC2DBA0", Offset = "0xC2DBA0", VA = "0xC2DBA0")]
	public void ItemOver(int index)
	{
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0xC2DBA4", Offset = "0xC2DBA4", VA = "0xC2DBA4")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x00006AB0 File Offset: 0x00004CB0
	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0xC2E834", Offset = "0xC2E834", VA = "0xC2E834")]
	public Rectangle GetSelectedPlayerRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0xC2D3E8", Offset = "0xC2D3E8", VA = "0xC2D3E8")]
	private void DrawSpectatorBar()
	{
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0xC2DCAC", Offset = "0xC2DCAC", VA = "0xC2DCAC")]
	private void PlayerDraw(Vector2 position, float backingScale, Player player, bool selected, int index)
	{
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B80")]
	[Address(RVA = "0xC2B380", Offset = "0xC2B380", VA = "0xC2B380")]
	private void UpdateSpectateList()
	{
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B81")]
	[Address(RVA = "0xC2EBC8", Offset = "0xC2EBC8", VA = "0xC2EBC8")]
	public GUISpectatorMode()
	{
	}

	// Token: 0x04000DA4 RID: 3492
	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0x8")]
	public bool SpectateNext;

	// Token: 0x04000DA5 RID: 3493
	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x9")]
	public bool SpectatePrevious;

	// Token: 0x04000DA6 RID: 3494
	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0xC")]
	private int CachedSpectating;

	// Token: 0x04000DA7 RID: 3495
	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x10")]
	private float TeleportButtonScale;

	// Token: 0x04000DA8 RID: 3496
	[Token(Token = "0x4000DA8")]
	[FieldOffset(Offset = "0x14")]
	private float CancelButtonScale;

	// Token: 0x04000DA9 RID: 3497
	[Token(Token = "0x4000DA9")]
	[FieldOffset(Offset = "0x18")]
	public GUIControllerSpecatorMode _controller;

	// Token: 0x04000DAA RID: 3498
	[Token(Token = "0x4000DAA")]
	[FieldOffset(Offset = "0x1C")]
	private float lastSpectateAxis;

	// Token: 0x04000DAB RID: 3499
	[Token(Token = "0x4000DAB")]
	[FieldOffset(Offset = "0x20")]
	private int _cachedFrame;

	// Token: 0x04000DAC RID: 3500
	[Token(Token = "0x4000DAC")]
	[FieldOffset(Offset = "0x24")]
	private bool _cachedHideUI;

	// Token: 0x04000DAD RID: 3501
	[Token(Token = "0x4000DAD")]
	[FieldOffset(Offset = "0x28")]
	public float ScrollOffset;

	// Token: 0x04000DAE RID: 3502
	[Token(Token = "0x4000DAE")]
	[FieldOffset(Offset = "0x2C")]
	private float ScrollMomentum;

	// Token: 0x04000DAF RID: 3503
	[Token(Token = "0x4000DAF")]
	[FieldOffset(Offset = "0x30")]
	private int ScrollDragging;

	// Token: 0x04000DB0 RID: 3504
	[Token(Token = "0x4000DB0")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 DragOffset;

	// Token: 0x04000DB1 RID: 3505
	[Token(Token = "0x4000DB1")]
	[FieldOffset(Offset = "0x3C")]
	private int lastDrawFrame;

	// Token: 0x04000DB2 RID: 3506
	[Token(Token = "0x4000DB2")]
	[FieldOffset(Offset = "0x40")]
	private int SpectateRequest;

	// Token: 0x04000DB3 RID: 3507
	[Token(Token = "0x4000DB3")]
	[FieldOffset(Offset = "0x44")]
	public float drawOffset;

	// Token: 0x04000DB4 RID: 3508
	[Token(Token = "0x4000DB4")]
	[FieldOffset(Offset = "0x48")]
	private List<int> spectateList;

	// Token: 0x04000DB5 RID: 3509
	[Token(Token = "0x4000DB5")]
	[FieldOffset(Offset = "0x4C")]
	private int SpecatingIndex;

	// Token: 0x04000DB6 RID: 3510
	[Token(Token = "0x4000DB6")]
	[FieldOffset(Offset = "0x50")]
	private float[] spectateScale;
}
