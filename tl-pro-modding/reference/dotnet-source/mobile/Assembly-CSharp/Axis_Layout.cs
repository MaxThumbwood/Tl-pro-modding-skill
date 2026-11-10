using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x020001C4 RID: 452
[Token(Token = "0x20001C4")]
[Serializable]
public class Axis_Layout
{
	// Token: 0x06000CA9 RID: 3241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0xC6C6B8", Offset = "0xC6C6B8", VA = "0xC6C6B8")]
	public Axis_Layout()
	{
	}

	// Token: 0x040011E1 RID: 4577
	[Token(Token = "0x40011E1")]
	[FieldOffset(Offset = "0x8")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x040011E2 RID: 4578
	[Token(Token = "0x40011E2")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x040011E3 RID: 4579
	[Token(Token = "0x40011E3")]
	[FieldOffset(Offset = "0x10")]
	public Microsoft.Xna.Framework.Vector2 CentreLocation;

	// Token: 0x040011E4 RID: 4580
	[Token(Token = "0x40011E4")]
	[FieldOffset(Offset = "0x18")]
	public float Scale;

	// Token: 0x040011E5 RID: 4581
	[Token(Token = "0x40011E5")]
	[FieldOffset(Offset = "0x1C")]
	public Microsoft.Xna.Framework.Graphics.Color Color;

	// Token: 0x040011E6 RID: 4582
	[Token(Token = "0x40011E6")]
	[FieldOffset(Offset = "0x20")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledColor;

	// Token: 0x040011E7 RID: 4583
	[Token(Token = "0x40011E7")]
	[FieldOffset(Offset = "0x24")]
	public Microsoft.Xna.Framework.Graphics.Color AlternativeColor;

	// Token: 0x040011E8 RID: 4584
	[Token(Token = "0x40011E8")]
	[FieldOffset(Offset = "0x28")]
	public Microsoft.Xna.Framework.Graphics.Color BackingColor;

	// Token: 0x040011E9 RID: 4585
	[Token(Token = "0x40011E9")]
	[FieldOffset(Offset = "0x2C")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledBackingColor;

	// Token: 0x040011EA RID: 4586
	[Token(Token = "0x40011EA")]
	[FieldOffset(Offset = "0x30")]
	public Microsoft.Xna.Framework.Graphics.Color IconColor;

	// Token: 0x040011EB RID: 4587
	[Token(Token = "0x40011EB")]
	[FieldOffset(Offset = "0x34")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledIconColor;

	// Token: 0x040011EC RID: 4588
	[Token(Token = "0x40011EC")]
	[FieldOffset(Offset = "0x38")]
	public bool UseCirclePickingRegion;

	// Token: 0x040011ED RID: 4589
	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0x3C")]
	public Microsoft.Xna.Framework.Vector2 PickSize;

	// Token: 0x040011EE RID: 4590
	[Token(Token = "0x40011EE")]
	[FieldOffset(Offset = "0x44")]
	public Microsoft.Xna.Framework.Vector2 DeadZone;

	// Token: 0x040011EF RID: 4591
	[Token(Token = "0x40011EF")]
	[FieldOffset(Offset = "0x4C")]
	public AnimationCurve AxisFalloff;

	// Token: 0x040011F0 RID: 4592
	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x50")]
	public bool RecentreOnTouch;

	// Token: 0x040011F1 RID: 4593
	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x51")]
	public bool RecentreInputOnly;

	// Token: 0x040011F2 RID: 4594
	[Token(Token = "0x40011F2")]
	[FieldOffset(Offset = "0x54")]
	public Microsoft.Xna.Framework.Vector2 NubbinPickSize;

	// Token: 0x040011F3 RID: 4595
	[Token(Token = "0x40011F3")]
	[FieldOffset(Offset = "0x5C")]
	public bool Draggable;

	// Token: 0x040011F4 RID: 4596
	[Token(Token = "0x40011F4")]
	[FieldOffset(Offset = "0x5D")]
	public bool UseCircleDeadZone;

	// Token: 0x040011F5 RID: 4597
	[Token(Token = "0x40011F5")]
	[FieldOffset(Offset = "0x60")]
	public int IconMaxSizeInset;

	// Token: 0x040011F6 RID: 4598
	[Token(Token = "0x40011F6")]
	[FieldOffset(Offset = "0x64")]
	public bool ClampInside;

	// Token: 0x040011F7 RID: 4599
	[Token(Token = "0x40011F7")]
	[FieldOffset(Offset = "0x68")]
	public Texture_Layout Backing;

	// Token: 0x040011F8 RID: 4600
	[Token(Token = "0x40011F8")]
	[FieldOffset(Offset = "0x6C")]
	public Texture_Layout Inner;

	// Token: 0x040011F9 RID: 4601
	[Token(Token = "0x40011F9")]
	[FieldOffset(Offset = "0x70")]
	public Texture_Layout AlternativeInner;
}
