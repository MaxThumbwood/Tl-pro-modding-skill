using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x02000267 RID: 615
[Token(Token = "0x2000267")]
public class SpectatorMode_Layout : LayoutDefinition
{
	// Token: 0x06000E95 RID: 3733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E95")]
	[Address(RVA = "0xC99A40", Offset = "0xC99A40", VA = "0xC99A40")]
	private void Awake()
	{
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E96")]
	[Address(RVA = "0xC99A94", Offset = "0xC99A94", VA = "0xC99A94")]
	public SpectatorMode_Layout()
	{
	}

	// Token: 0x04001DA0 RID: 7584
	[Token(Token = "0x4001DA0")]
	[FieldOffset(Offset = "0x0")]
	public static SpectatorMode_Layout Instance;

	// Token: 0x04001DA1 RID: 7585
	[Token(Token = "0x4001DA1")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x04001DA2 RID: 7586
	[Token(Token = "0x4001DA2")]
	[FieldOffset(Offset = "0x10")]
	public DraggableItemGrid_Layout Grid;

	// Token: 0x04001DA3 RID: 7587
	[Token(Token = "0x4001DA3")]
	[FieldOffset(Offset = "0x14")]
	public Microsoft.Xna.Framework.Graphics.Color OtherPlayerBackingColour;

	// Token: 0x04001DA4 RID: 7588
	[Token(Token = "0x4001DA4")]
	[FieldOffset(Offset = "0x18")]
	public Microsoft.Xna.Framework.Graphics.Color MyBackingColour;

	// Token: 0x04001DA5 RID: 7589
	[Token(Token = "0x4001DA5")]
	[FieldOffset(Offset = "0x1C")]
	public float SelectedScale;

	// Token: 0x04001DA6 RID: 7590
	[Token(Token = "0x4001DA6")]
	[FieldOffset(Offset = "0x20")]
	public float UnselectedScale;

	// Token: 0x04001DA7 RID: 7591
	[Token(Token = "0x4001DA7")]
	[FieldOffset(Offset = "0x24")]
	public float ScaleSpeed;

	// Token: 0x04001DA8 RID: 7592
	[Token(Token = "0x4001DA8")]
	[FieldOffset(Offset = "0x28")]
	public float HeadScale;

	// Token: 0x04001DA9 RID: 7593
	[Token(Token = "0x4001DA9")]
	[FieldOffset(Offset = "0x2C")]
	public Microsoft.Xna.Framework.Vector2 HeadOffset;

	// Token: 0x04001DAA RID: 7594
	[Token(Token = "0x4001DAA")]
	[FieldOffset(Offset = "0x34")]
	public float GraveStoneScale;

	// Token: 0x04001DAB RID: 7595
	[Token(Token = "0x4001DAB")]
	[FieldOffset(Offset = "0x38")]
	public Microsoft.Xna.Framework.Vector2 GraveStoneOffset;

	// Token: 0x04001DAC RID: 7596
	[Token(Token = "0x4001DAC")]
	[FieldOffset(Offset = "0x40")]
	public String_Layout StatusString;

	// Token: 0x04001DAD RID: 7597
	[Token(Token = "0x4001DAD")]
	[FieldOffset(Offset = "0x44")]
	public Panel_Layout StatusBacking;

	// Token: 0x04001DAE RID: 7598
	[Token(Token = "0x4001DAE")]
	[FieldOffset(Offset = "0x48")]
	public Microsoft.Xna.Framework.Vector2 StatusBackingTLOffset;

	// Token: 0x04001DAF RID: 7599
	[Token(Token = "0x4001DAF")]
	[FieldOffset(Offset = "0x50")]
	public Microsoft.Xna.Framework.Vector2 StatusBackingBROffset;

	// Token: 0x04001DB0 RID: 7600
	[Token(Token = "0x4001DB0")]
	[FieldOffset(Offset = "0x58")]
	public Panel_Layout DividerHeader;

	// Token: 0x04001DB1 RID: 7601
	[Token(Token = "0x4001DB1")]
	[FieldOffset(Offset = "0x5C")]
	public Panel_Layout DividerButtons;

	// Token: 0x04001DB2 RID: 7602
	[Token(Token = "0x4001DB2")]
	[FieldOffset(Offset = "0x60")]
	public float DeathSizeAdjustment;

	// Token: 0x04001DB3 RID: 7603
	[Token(Token = "0x4001DB3")]
	[FieldOffset(Offset = "0x64")]
	public TransactionButton_Layout Cancel;

	// Token: 0x04001DB4 RID: 7604
	[Token(Token = "0x4001DB4")]
	[FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Teleport;

	// Token: 0x04001DB5 RID: 7605
	[Token(Token = "0x4001DB5")]
	[FieldOffset(Offset = "0x6C")]
	public AnimationCurve SkipTextOpacity;

	// Token: 0x04001DB6 RID: 7606
	[Token(Token = "0x4001DB6")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve SkipTextScale;

	// Token: 0x04001DB7 RID: 7607
	[Token(Token = "0x4001DB7")]
	[FieldOffset(Offset = "0x74")]
	public AnimationCurve SkipTextOffset;

	// Token: 0x04001DB8 RID: 7608
	[Token(Token = "0x4001DB8")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve SkipTextAdvance;
}
