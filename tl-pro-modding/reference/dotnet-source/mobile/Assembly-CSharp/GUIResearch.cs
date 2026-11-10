using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Graphics.Renderers;

// Token: 0x0200017C RID: 380
[Token(Token = "0x200017C")]
public class GUIResearch
{
	// Token: 0x06000B02 RID: 2818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0xBEAC44", Offset = "0xBEAC44", VA = "0xBEAC44")]
	public static void LoadContent()
	{
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x000066F0 File Offset: 0x000048F0
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0xBEB0B0", Offset = "0xBEB0B0", VA = "0xBEB0B0")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x00006708 File Offset: 0x00004908
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0xBEB0F8", Offset = "0xBEB0F8", VA = "0xBEB0F8")]
	public GUIResearch.ResearchState CanBeResearched(Item item, out int percent)
	{
		return GUIResearch.ResearchState.Invalid;
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B05")]
	[Address(RVA = "0xBEB274", Offset = "0xBEB274", VA = "0xBEB274")]
	public void DrawInventoryResearchBinding()
	{
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B06")]
	[Address(RVA = "0xBEB768", Offset = "0xBEB768", VA = "0xBEB768")]
	public void DrawInventoryResearchButton()
	{
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B07")]
	[Address(RVA = "0xBEC258", Offset = "0xBEC258", VA = "0xBEC258")]
	public void AddUIExcludeRegions(List<Rectangle> regions)
	{
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x00006720 File Offset: 0x00004920
	[Token(Token = "0x6000B08")]
	[Address(RVA = "0xBEC624", Offset = "0xBEC624", VA = "0xBEC624")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B09")]
	[Address(RVA = "0xBEBEAC", Offset = "0xBEBEAC", VA = "0xBEBEAC")]
	public void Open(int item)
	{
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0xBECA20", Offset = "0xBECA20", VA = "0xBECA20")]
	public void Close()
	{
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0xBECAC0", Offset = "0xBECAC0", VA = "0xBECAC0")]
	public void Draw()
	{
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0xBED99C", Offset = "0xBED99C", VA = "0xBED99C")]
	private void DrawResearchParticles()
	{
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0xBEDAB0", Offset = "0xBEDAB0", VA = "0xBEDAB0")]
	private void DrawMainButtons()
	{
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0xBEE1EC", Offset = "0xBEE1EC", VA = "0xBEE1EC")]
	private void BeginResearchAnimation(int itemResearched, int amountStart, int amountSubmitted, bool completed)
	{
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0xBEDE90", Offset = "0xBEDE90", VA = "0xBEDE90")]
	private void ActionResearch()
	{
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B10")]
	[Address(RVA = "0xBECE4C", Offset = "0xBECE4C", VA = "0xBECE4C")]
	private void DrawBacking()
	{
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x00006738 File Offset: 0x00004938
	[Token(Token = "0x6000B11")]
	[Address(RVA = "0xBEE4C0", Offset = "0xBEE4C0", VA = "0xBEE4C0")]
	private int UpdateResearchAnimation()
	{
		return 0;
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B12")]
	[Address(RVA = "0xBECF40", Offset = "0xBECF40", VA = "0xBECF40")]
	private void DrawResearchBacking()
	{
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x00006750 File Offset: 0x00004950
	[Token(Token = "0x6000B13")]
	[Address(RVA = "0xBEF3F8", Offset = "0xBEF3F8", VA = "0xBEF3F8")]
	public Rectangle SetupFrame(Texture2D texture, int frameCountHorizontal, int frameCountVertical, int frameX, int frameY)
	{
		return default(Rectangle);
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B14")]
	[Address(RVA = "0xBED20C", Offset = "0xBED20C", VA = "0xBED20C")]
	public void DrawResearchCogs()
	{
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B15")]
	[Address(RVA = "0xBEF4A4", Offset = "0xBEF4A4", VA = "0xBEF4A4")]
	public void DrawTexture(Panel_Layout layout, Texture2D texture, float rotation)
	{
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B16")]
	[Address(RVA = "0xBEF5B8", Offset = "0xBEF5B8", VA = "0xBEF5B8")]
	public void DrawTexture(Vector2 position, Vector2 size, Texture2D texture, Color color, float rotation)
	{
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B17")]
	[Address(RVA = "0xBEE388", Offset = "0xBEE388", VA = "0xBEE388")]
	private Item GetResearchItem()
	{
		return null;
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0xBED3D0", Offset = "0xBED3D0", VA = "0xBED3D0")]
	private void DrawItemProgress()
	{
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0xBEEBC4", Offset = "0xBEEBC4", VA = "0xBEEBC4")]
	private void DrawResearchItem()
	{
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0xBEF7BC", Offset = "0xBEF7BC", VA = "0xBEF7BC")]
	public GUIResearch()
	{
	}

	// Token: 0x04000D26 RID: 3366
	[Token(Token = "0x4000D26")]
	[FieldOffset(Offset = "0x8")]
	private int OpenedFrame;

	// Token: 0x04000D27 RID: 3367
	[Token(Token = "0x4000D27")]
	[FieldOffset(Offset = "0xC")]
	public bool Displaying;

	// Token: 0x04000D28 RID: 3368
	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0x0")]
	private static Asset<Texture2D> pistonsAsset;

	// Token: 0x04000D29 RID: 3369
	[Token(Token = "0x4000D29")]
	[FieldOffset(Offset = "0x4")]
	private static Asset<Texture2D> pistonParticleAsset;

	// Token: 0x04000D2A RID: 3370
	[Token(Token = "0x4000D2A")]
	[FieldOffset(Offset = "0x8")]
	private static Asset<Texture2D> cogsSmall;

	// Token: 0x04000D2B RID: 3371
	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0xC")]
	private static Asset<Texture2D> cogsMedium;

	// Token: 0x04000D2C RID: 3372
	[Token(Token = "0x4000D2C")]
	[FieldOffset(Offset = "0x10")]
	private static Asset<Texture2D> cogsLarge;

	// Token: 0x04000D2D RID: 3373
	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x10")]
	private float inventoryResearchScale;

	// Token: 0x04000D2E RID: 3374
	[Token(Token = "0x4000D2E")]
	[FieldOffset(Offset = "0x14")]
	private GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x04000D2F RID: 3375
	[Token(Token = "0x4000D2F")]
	[FieldOffset(Offset = "0x18")]
	private int selectedResearchItem;

	// Token: 0x04000D30 RID: 3376
	[Token(Token = "0x4000D30")]
	[FieldOffset(Offset = "0x1C")]
	private float closeScale;

	// Token: 0x04000D31 RID: 3377
	[Token(Token = "0x4000D31")]
	[FieldOffset(Offset = "0x20")]
	private float researchScale;

	// Token: 0x04000D32 RID: 3378
	[Token(Token = "0x4000D32")]
	[FieldOffset(Offset = "0x24")]
	public bool ResearchAnimationInProgress;

	// Token: 0x04000D33 RID: 3379
	[Token(Token = "0x4000D33")]
	[FieldOffset(Offset = "0x28")]
	private DateTime ResearchAnimationTime;

	// Token: 0x04000D34 RID: 3380
	[Token(Token = "0x4000D34")]
	[FieldOffset(Offset = "0x30")]
	private int ResearchItem;

	// Token: 0x04000D35 RID: 3381
	[Token(Token = "0x4000D35")]
	[FieldOffset(Offset = "0x34")]
	private int ResearchItemStart;

	// Token: 0x04000D36 RID: 3382
	[Token(Token = "0x4000D36")]
	[FieldOffset(Offset = "0x38")]
	private int ResearchItemCount;

	// Token: 0x04000D37 RID: 3383
	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0x3C")]
	private int ResearchFrame;

	// Token: 0x04000D38 RID: 3384
	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x40")]
	private bool ResearchCompleted;

	// Token: 0x04000D39 RID: 3385
	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x44")]
	private ParticleRendererSettings ResearchParticleSettings;

	// Token: 0x04000D3A RID: 3386
	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x4C")]
	private List<CreativeSacrificeParticle> ResearchParticles;

	// Token: 0x04000D3B RID: 3387
	[Token(Token = "0x4000D3B")]
	[FieldOffset(Offset = "0x50")]
	private float _smallRotation;

	// Token: 0x04000D3C RID: 3388
	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x54")]
	private float _mediumRotation;

	// Token: 0x04000D3D RID: 3389
	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x58")]
	private float _largeRotation;

	// Token: 0x04000D3E RID: 3390
	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x5C")]
	private float testProgress;

	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public enum ResearchState
	{
		// Token: 0x04000D40 RID: 3392
		[Token(Token = "0x4000D40")]
		Invalid,
		// Token: 0x04000D41 RID: 3393
		[Token(Token = "0x4000D41")]
		Valid,
		// Token: 0x04000D42 RID: 3394
		[Token(Token = "0x4000D42")]
		Complete
	}
}
