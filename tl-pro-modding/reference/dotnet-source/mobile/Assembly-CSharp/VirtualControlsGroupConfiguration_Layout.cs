using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000270 RID: 624
[Token(Token = "0x2000270")]
[Serializable]
public class VirtualControlsGroupConfiguration_Layout
{
	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000182")]
	public VirtualControlsButtonConfiguration_Layout CentreMapping
	{
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0xC99FAC", Offset = "0xC99FAC", VA = "0xC99FAC")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000183")]
	public VirtualControlsButtonConfiguration_Layout OuterMapping
	{
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0xC9A110", Offset = "0xC9A110", VA = "0xC9A110")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x000079E0 File Offset: 0x00005BE0
	[Token(Token = "0x17000184")]
	public float OuterButtonScaleTime
	{
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0xC9A1DC", Offset = "0xC9A1DC", VA = "0xC9A1DC")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x000079F8 File Offset: 0x00005BF8
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0xC9A2B4", Offset = "0xC9A2B4", VA = "0xC9A2B4")]
	public float GetOuterButtonScale(float time)
	{
		return 0f;
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0xC9A348", Offset = "0xC9A348", VA = "0xC9A348")]
	public Texture_Layout GetEntry(int index)
	{
		return null;
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0xC9A37C", Offset = "0xC9A37C", VA = "0xC9A37C")]
	public Texture_Layout GetEmpty(int index)
	{
		return null;
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0xC9A3B0", Offset = "0xC9A3B0", VA = "0xC9A3B0")]
	public Texture_Layout GetSelected(int index)
	{
		return null;
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0xC9A3E4", Offset = "0xC9A3E4", VA = "0xC9A3E4")]
	public VirtualControlsGroupConfiguration_Layout()
	{
	}

	// Token: 0x04001DE4 RID: 7652
	[Token(Token = "0x4001DE4")]
	[FieldOffset(Offset = "0x8")]
	public string Id;

	// Token: 0x04001DE5 RID: 7653
	[Token(Token = "0x4001DE5")]
	[FieldOffset(Offset = "0xC")]
	private VirtualControlsButtonConfiguration_Layout _centreMapping;

	// Token: 0x04001DE6 RID: 7654
	[Token(Token = "0x4001DE6")]
	[FieldOffset(Offset = "0x10")]
	private VirtualControlsButtonConfiguration_Layout _outerMapping;

	// Token: 0x04001DE7 RID: 7655
	[Token(Token = "0x4001DE7")]
	[FieldOffset(Offset = "0x14")]
	public string CentreButtonStyle;

	// Token: 0x04001DE8 RID: 7656
	[Token(Token = "0x4001DE8")]
	[FieldOffset(Offset = "0x18")]
	public string OuterButtonStyle;

	// Token: 0x04001DE9 RID: 7657
	[Token(Token = "0x4001DE9")]
	[FieldOffset(Offset = "0x1C")]
	public float OuterButtonRadiusMin;

	// Token: 0x04001DEA RID: 7658
	[Token(Token = "0x4001DEA")]
	[FieldOffset(Offset = "0x20")]
	public float OuterButtonRadiusMax;

	// Token: 0x04001DEB RID: 7659
	[Token(Token = "0x4001DEB")]
	[FieldOffset(Offset = "0x24")]
	public float OuterButtonScaleMin;

	// Token: 0x04001DEC RID: 7660
	[Token(Token = "0x4001DEC")]
	[FieldOffset(Offset = "0x28")]
	public float OuterButtonScaleMax;

	// Token: 0x04001DED RID: 7661
	[Token(Token = "0x4001DED")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout Backing;

	// Token: 0x04001DEE RID: 7662
	[Token(Token = "0x4001DEE")]
	[FieldOffset(Offset = "0x30")]
	public Texture_Layout Backing_Entry1;

	// Token: 0x04001DEF RID: 7663
	[Token(Token = "0x4001DEF")]
	[FieldOffset(Offset = "0x34")]
	public Texture_Layout Backing_Entry2;

	// Token: 0x04001DF0 RID: 7664
	[Token(Token = "0x4001DF0")]
	[FieldOffset(Offset = "0x38")]
	public Texture_Layout Backing_Entry3;

	// Token: 0x04001DF1 RID: 7665
	[Token(Token = "0x4001DF1")]
	[FieldOffset(Offset = "0x3C")]
	public Texture_Layout Backing_Entry4;

	// Token: 0x04001DF2 RID: 7666
	[Token(Token = "0x4001DF2")]
	[FieldOffset(Offset = "0x40")]
	public Texture_Layout Backing_Empty1;

	// Token: 0x04001DF3 RID: 7667
	[Token(Token = "0x4001DF3")]
	[FieldOffset(Offset = "0x44")]
	public Texture_Layout Backing_Empty2;

	// Token: 0x04001DF4 RID: 7668
	[Token(Token = "0x4001DF4")]
	[FieldOffset(Offset = "0x48")]
	public Texture_Layout Backing_Empty3;

	// Token: 0x04001DF5 RID: 7669
	[Token(Token = "0x4001DF5")]
	[FieldOffset(Offset = "0x4C")]
	public Texture_Layout Backing_Empty4;

	// Token: 0x04001DF6 RID: 7670
	[Token(Token = "0x4001DF6")]
	[FieldOffset(Offset = "0x50")]
	public Texture_Layout Backing_Selected1;

	// Token: 0x04001DF7 RID: 7671
	[Token(Token = "0x4001DF7")]
	[FieldOffset(Offset = "0x54")]
	public Texture_Layout Backing_Selected2;

	// Token: 0x04001DF8 RID: 7672
	[Token(Token = "0x4001DF8")]
	[FieldOffset(Offset = "0x58")]
	public Texture_Layout Backing_Selected3;

	// Token: 0x04001DF9 RID: 7673
	[Token(Token = "0x4001DF9")]
	[FieldOffset(Offset = "0x5C")]
	public Texture_Layout Backing_Selected4;

	// Token: 0x04001DFA RID: 7674
	[Token(Token = "0x4001DFA")]
	[FieldOffset(Offset = "0x60")]
	public Color TealColor;

	// Token: 0x04001DFB RID: 7675
	[Token(Token = "0x4001DFB")]
	[FieldOffset(Offset = "0x64")]
	public Color BlueColor;

	// Token: 0x04001DFC RID: 7676
	[Token(Token = "0x4001DFC")]
	[FieldOffset(Offset = "0x68")]
	public Color GreenColor;

	// Token: 0x04001DFD RID: 7677
	[Token(Token = "0x4001DFD")]
	[FieldOffset(Offset = "0x6C")]
	public Color EmptyColor;

	// Token: 0x04001DFE RID: 7678
	[Token(Token = "0x4001DFE")]
	[FieldOffset(Offset = "0x70")]
	public Color BadColor;

	// Token: 0x04001DFF RID: 7679
	[Token(Token = "0x4001DFF")]
	[FieldOffset(Offset = "0x74")]
	public float BackingScaleMin;

	// Token: 0x04001E00 RID: 7680
	[Token(Token = "0x4001E00")]
	[FieldOffset(Offset = "0x78")]
	public float BackingScaleMax;

	// Token: 0x04001E01 RID: 7681
	[Token(Token = "0x4001E01")]
	[FieldOffset(Offset = "0x7C")]
	public Color IndicatorDirectionColor;

	// Token: 0x04001E02 RID: 7682
	[Token(Token = "0x4001E02")]
	[FieldOffset(Offset = "0x80")]
	public Color IndicatorSelectedColor;

	// Token: 0x04001E03 RID: 7683
	[Token(Token = "0x4001E03")]
	[FieldOffset(Offset = "0x84")]
	public Color IndicatorAvailableColor;

	// Token: 0x04001E04 RID: 7684
	[Token(Token = "0x4001E04")]
	[FieldOffset(Offset = "0x88")]
	public Panel_Layout Indicator;

	// Token: 0x04001E05 RID: 7685
	[Token(Token = "0x4001E05")]
	[FieldOffset(Offset = "0x8C")]
	public float IndicatorScale;

	// Token: 0x04001E06 RID: 7686
	[Token(Token = "0x4001E06")]
	[FieldOffset(Offset = "0x90")]
	public Anchor_Layout ControlLayoutPosition;

	// Token: 0x04001E07 RID: 7687
	[Token(Token = "0x4001E07")]
	[FieldOffset(Offset = "0x94")]
	public float ControlLayoutScale;
}
