using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Graphics.Effects;
using UnityEngine;

// Token: 0x0200036C RID: 876
[Token(Token = "0x200036C")]
public class ScreenPostProcessor : MonoBehaviour
{
	// Token: 0x170001EE RID: 494
	// (get) Token: 0x06001591 RID: 5521 RVA: 0x000097C8 File Offset: 0x000079C8
	// (set) Token: 0x06001592 RID: 5522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EE")]
	public static bool Enabled
	{
		[Token(Token = "0x6001591")]
		[Address(RVA = "0xDFC088", Offset = "0xDFC088", VA = "0xDFC088")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001592")]
		[Address(RVA = "0xDFC0F0", Offset = "0xDFC0F0", VA = "0xDFC0F0")]
		set
		{
		}
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x06001593 RID: 5523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001EF")]
	public static List<ScreenPostProcessor> Instances
	{
		[Token(Token = "0x6001593")]
		[Address(RVA = "0xDFC15C", Offset = "0xDFC15C", VA = "0xDFC15C")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06001594 RID: 5524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F0")]
	public static List<ScreenPostProcessor> UIInstances
	{
		[Token(Token = "0x6001594")]
		[Address(RVA = "0xDFC1C4", Offset = "0xDFC1C4", VA = "0xDFC1C4")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x06001595 RID: 5525 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001596 RID: 5526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F1")]
	public static List<Filter> Filters
	{
		[Token(Token = "0x6001595")]
		[Address(RVA = "0xDFC22C", Offset = "0xDFC22C", VA = "0xDFC22C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001596")]
		[Address(RVA = "0xDFC294", Offset = "0xDFC294", VA = "0xDFC294")]
		set
		{
		}
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001597")]
	[Address(RVA = "0xDFC300", Offset = "0xDFC300", VA = "0xDFC300")]
	public static void BeginUpdate()
	{
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001598")]
	[Address(RVA = "0xDFC4B8", Offset = "0xDFC4B8", VA = "0xDFC4B8")]
	public static void AddFilter(Filter filter)
	{
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001599")]
	[Address(RVA = "0xDFC9B0", Offset = "0xDFC9B0", VA = "0xDFC9B0")]
	public static void EndUpdate()
	{
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x0600159A RID: 5530 RVA: 0x000097E0 File Offset: 0x000079E0
	// (set) Token: 0x0600159B RID: 5531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F2")]
	private static int countUpdate
	{
		[Token(Token = "0x600159A")]
		[Address(RVA = "0xDFC948", Offset = "0xDFC948", VA = "0xDFC948")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600159B")]
		[Address(RVA = "0xDFC44C", Offset = "0xDFC44C", VA = "0xDFC44C")]
		set
		{
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x0600159C RID: 5532 RVA: 0x000097F8 File Offset: 0x000079F8
	// (set) Token: 0x0600159D RID: 5533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F3")]
	private static int renderCheck
	{
		[Token(Token = "0x600159C")]
		[Address(RVA = "0xDFCF30", Offset = "0xDFCF30", VA = "0xDFCF30")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600159D")]
		[Address(RVA = "0xDFCEC4", Offset = "0xDFCEC4", VA = "0xDFCEC4")]
		set
		{
		}
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600159E")]
	[Address(RVA = "0xDFCF98", Offset = "0xDFCF98", VA = "0xDFCF98")]
	private void OnRenderImage(RenderTexture source, RenderTexture dest)
	{
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600159F")]
	[Address(RVA = "0xDFD954", Offset = "0xDFD954", VA = "0xDFD954")]
	public ScreenPostProcessor()
	{
	}

	// Token: 0x040029EA RID: 10730
	[Token(Token = "0x40029EA")]
	[FieldOffset(Offset = "0xC")]
	private int order;

	// Token: 0x040029EB RID: 10731
	[Token(Token = "0x40029EB")]
	[FieldOffset(Offset = "0x10")]
	private Filter filter;

	// Token: 0x040029EC RID: 10732
	[Token(Token = "0x40029EC")]
	[FieldOffset(Offset = "0x14")]
	private bool setActive;

	// Token: 0x040029ED RID: 10733
	[Token(Token = "0x40029ED")]
	[FieldOffset(Offset = "0x18")]
	public LocalUser User;

	// Token: 0x040029EE RID: 10734
	[Token(Token = "0x40029EE")]
	[FieldOffset(Offset = "0x0")]
	private static int MainTexId;

	// Token: 0x040029EF RID: 10735
	[Token(Token = "0x40029EF")]
	[FieldOffset(Offset = "0x4")]
	private static int SecTexId;

	// Token: 0x040029F0 RID: 10736
	[Token(Token = "0x40029F0")]
	[FieldOffset(Offset = "0x8")]
	private static int SecTexPalId;

	// Token: 0x040029F1 RID: 10737
	[Token(Token = "0x40029F1")]
	[FieldOffset(Offset = "0xC")]
	private static int SecPalScaleSizeId;

	// Token: 0x040029F2 RID: 10738
	[Token(Token = "0x40029F2")]
	[FieldOffset(Offset = "0x10")]
	private static int ThirdTexId;

	// Token: 0x040029F3 RID: 10739
	[Token(Token = "0x40029F3")]
	[FieldOffset(Offset = "0x14")]
	private static int ForthTexId;

	// Token: 0x040029F4 RID: 10740
	[Token(Token = "0x40029F4")]
	[FieldOffset(Offset = "0x18")]
	private static int _imageSize1Id;
}
