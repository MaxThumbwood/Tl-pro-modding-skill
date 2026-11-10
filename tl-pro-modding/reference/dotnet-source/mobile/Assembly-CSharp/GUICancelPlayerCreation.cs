using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000284 RID: 644
[Token(Token = "0x2000284")]
public class GUICancelPlayerCreation
{
	// Token: 0x06000EF9 RID: 3833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0xCA509C", Offset = "0xCA509C", VA = "0xCA509C")]
	public void Draw()
	{
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0xCA5BBC", Offset = "0xCA5BBC", VA = "0xCA5BBC")]
	private void Discard()
	{
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0xCA5B28", Offset = "0xCA5B28", VA = "0xCA5B28")]
	private void Back()
	{
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0xCA5D20", Offset = "0xCA5D20", VA = "0xCA5D20")]
	private void PlayerDraw(Panel_Layout backingLayout, Player player, TimeSpan playTime, Projectile UIPetProjectile)
	{
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFD")]
	[Address(RVA = "0xCA6CF8", Offset = "0xCA6CF8", VA = "0xCA6CF8")]
	private void UpdateAnim(Player player, bool animated)
	{
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFE")]
	[Address(RVA = "0xCA69B0", Offset = "0xCA69B0", VA = "0xCA69B0")]
	private void DrawPlayer(Player player, Projectile pet, bool animated)
	{
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFF")]
	[Address(RVA = "0xCA7450", Offset = "0xCA7450", VA = "0xCA7450")]
	public void DrawPlayerUI(Player player, Vector2 origin, Vector2 size)
	{
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F00")]
	[Address(RVA = "0xCA6F70", Offset = "0xCA6F70", VA = "0xCA6F70")]
	public void DrawPet(Player player, Projectile proj, Vector2 playerPosition, bool animated)
	{
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F01")]
	[Address(RVA = "0xCA7AD4", Offset = "0xCA7AD4", VA = "0xCA7AD4")]
	public GUICancelPlayerCreation()
	{
	}

	// Token: 0x04001F00 RID: 7936
	[Token(Token = "0x4001F00")]
	[FieldOffset(Offset = "0x8")]
	private float scale0;

	// Token: 0x04001F01 RID: 7937
	[Token(Token = "0x4001F01")]
	[FieldOffset(Offset = "0xC")]
	private float scale1;

	// Token: 0x04001F02 RID: 7938
	[Token(Token = "0x4001F02")]
	[FieldOffset(Offset = "0x10")]
	private float scale2;

	// Token: 0x04001F03 RID: 7939
	[Token(Token = "0x4001F03")]
	[FieldOffset(Offset = "0x14")]
	private float titleScale;

	// Token: 0x04001F04 RID: 7940
	[Token(Token = "0x4001F04")]
	[FieldOffset(Offset = "0x18")]
	private GUIControllerGenericPopup _controller;

	// Token: 0x04001F05 RID: 7941
	[Token(Token = "0x4001F05")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 CharacterOffset;

	// Token: 0x04001F06 RID: 7942
	[Token(Token = "0x4001F06")]
	[FieldOffset(Offset = "0x24")]
	private Item _blankItem;
}
