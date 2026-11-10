using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x0200020D RID: 525
[Token(Token = "0x200020D")]
public class Map_Layout : LayoutDefinition
{
	// Token: 0x06000DD1 RID: 3537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0xC8F42C", Offset = "0xC8F42C", VA = "0xC8F42C")]
	private void Awake()
	{
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x000078A8 File Offset: 0x00005AA8
	// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700016A")]
	public static bool UseLargeMinimap
	{
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0xC8F480", Offset = "0xC8F480", VA = "0xC8F480")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0xC8F4FC", Offset = "0xC8F4FC", VA = "0xC8F4FC")]
		set
		{
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016B")]
	public Panel_Layout DisplayMinimap
	{
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0xC8F57C", Offset = "0xC8F57C", VA = "0xC8F57C")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016C")]
	public Panel_Layout DisplayMinimapFrame
	{
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0xC8F604", Offset = "0xC8F604", VA = "0xC8F604")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x000078C0 File Offset: 0x00005AC0
	[Token(Token = "0x1700016D")]
	public float MinMinimapScale
	{
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0xC8F784", Offset = "0xC8F784", VA = "0xC8F784")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000078D8 File Offset: 0x00005AD8
	[Token(Token = "0x1700016E")]
	public float MaxMinimapScale
	{
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0xC8F7E0", Offset = "0xC8F7E0", VA = "0xC8F7E0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000078F0 File Offset: 0x00005AF0
	[Token(Token = "0x1700016F")]
	public float DefaultMinimapScale
	{
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0xC8F83C", Offset = "0xC8F83C", VA = "0xC8F83C")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000170")]
	public QuickActionButton_Layout HUDMap
	{
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0xC8F898", Offset = "0xC8F898", VA = "0xC8F898")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000171")]
	public QuickActionButton_Layout HUDMiniMapToggle
	{
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0xC8F930", Offset = "0xC8F930", VA = "0xC8F930")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0xC8F9D0", Offset = "0xC8F9D0", VA = "0xC8F9D0")]
	public Map_Layout()
	{
	}

	// Token: 0x0400166A RID: 5738
	[Token(Token = "0x400166A")]
	[FieldOffset(Offset = "0x0")]
	public static Map_Layout Instance;

	// Token: 0x0400166B RID: 5739
	[Token(Token = "0x400166B")]
	[FieldOffset(Offset = "0xC")]
	public int DefaultMiniMapWorldWidth;

	// Token: 0x0400166C RID: 5740
	[Token(Token = "0x400166C")]
	[FieldOffset(Offset = "0x10")]
	public int MinMiniMapWorldWidth;

	// Token: 0x0400166D RID: 5741
	[Token(Token = "0x400166D")]
	[FieldOffset(Offset = "0x14")]
	public int MaxMiniMapWorldWidth;

	// Token: 0x0400166E RID: 5742
	[Token(Token = "0x400166E")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout Minimap;

	// Token: 0x0400166F RID: 5743
	[Token(Token = "0x400166F")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout MinimapFrame;

	// Token: 0x04001670 RID: 5744
	[Token(Token = "0x4001670")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout MinimapLarge;

	// Token: 0x04001671 RID: 5745
	[Token(Token = "0x4001671")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout MinimapLargeFrame;

	// Token: 0x04001672 RID: 5746
	[Token(Token = "0x4001672")]
	[FieldOffset(Offset = "0x28")]
	public float MinimapScale;

	// Token: 0x04001673 RID: 5747
	[Token(Token = "0x4001673")]
	[FieldOffset(Offset = "0x2C")]
	public QuickActionButton_Layout MinimapZoomDefault;

	// Token: 0x04001674 RID: 5748
	[Token(Token = "0x4001674")]
	[FieldOffset(Offset = "0x30")]
	public QuickActionButton_Layout MinimapZoomIn;

	// Token: 0x04001675 RID: 5749
	[Token(Token = "0x4001675")]
	[FieldOffset(Offset = "0x34")]
	public QuickActionButton_Layout MinimapZoomOut;

	// Token: 0x04001676 RID: 5750
	[Token(Token = "0x4001676")]
	[FieldOffset(Offset = "0x38")]
	public QuickActionButton_Layout MapZoomDefault;

	// Token: 0x04001677 RID: 5751
	[Token(Token = "0x4001677")]
	[FieldOffset(Offset = "0x3C")]
	public QuickActionButton_Layout MapZoomIn;

	// Token: 0x04001678 RID: 5752
	[Token(Token = "0x4001678")]
	[FieldOffset(Offset = "0x40")]
	public QuickActionButton_Layout MapZoomOut;

	// Token: 0x04001679 RID: 5753
	[Token(Token = "0x4001679")]
	[FieldOffset(Offset = "0x44")]
	public QuickActionButton_Layout Map;

	// Token: 0x0400167A RID: 5754
	[Token(Token = "0x400167A")]
	[FieldOffset(Offset = "0x48")]
	public QuickActionButton_Layout MapHorizontal;

	// Token: 0x0400167B RID: 5755
	[Token(Token = "0x400167B")]
	[FieldOffset(Offset = "0x4C")]
	public ControlAnchor.ControlId SliderAnchorControl;

	// Token: 0x0400167C RID: 5756
	[Token(Token = "0x400167C")]
	[FieldOffset(Offset = "0x50")]
	public LayoutCalculator.AnchorType SliderAnchor;

	// Token: 0x0400167D RID: 5757
	[Token(Token = "0x400167D")]
	[FieldOffset(Offset = "0x54")]
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	// Token: 0x0400167E RID: 5758
	[Token(Token = "0x400167E")]
	[FieldOffset(Offset = "0x5C")]
	public float SliderBackScale;

	// Token: 0x0400167F RID: 5759
	[Token(Token = "0x400167F")]
	[FieldOffset(Offset = "0x60")]
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	// Token: 0x04001680 RID: 5760
	[Token(Token = "0x4001680")]
	[FieldOffset(Offset = "0x68")]
	public float SliderIndicatorScale;

	// Token: 0x04001681 RID: 5761
	[Token(Token = "0x4001681")]
	[FieldOffset(Offset = "0x6C")]
	public float SliderEndCap;

	// Token: 0x04001682 RID: 5762
	[Token(Token = "0x4001682")]
	[FieldOffset(Offset = "0x70")]
	public float ControllerMovementSpeed;

	// Token: 0x04001683 RID: 5763
	[Token(Token = "0x4001683")]
	[FieldOffset(Offset = "0x74")]
	public float SliderDefaultPosition;

	// Token: 0x04001684 RID: 5764
	[Token(Token = "0x4001684")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve SliderToPixelScale;

	// Token: 0x04001685 RID: 5765
	[Token(Token = "0x4001685")]
	[FieldOffset(Offset = "0x7C")]
	public QuickActionButton_Layout MinimapToggle;

	// Token: 0x04001686 RID: 5766
	[Token(Token = "0x4001686")]
	[FieldOffset(Offset = "0x80")]
	public QuickActionButton_Layout MinimapToggleHorizontal;
}
