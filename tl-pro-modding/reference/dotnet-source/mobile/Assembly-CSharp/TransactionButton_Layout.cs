using System;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001E1 RID: 481
[Token(Token = "0x20001E1")]
[Serializable]
public class TransactionButton_Layout : QuickActionButton_Layout
{
	// Token: 0x06000D28 RID: 3368 RVA: 0x000074E8 File Offset: 0x000056E8
	[Token(Token = "0x6000D28")]
	[Address(RVA = "0xC7A71C", Offset = "0xC7A71C", VA = "0xC7A71C")]
	private bool IsNotUsingStyle()
	{
		return default(bool);
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x00007500 File Offset: 0x00005700
	[Token(Token = "0x6000D29")]
	[Address(RVA = "0xC7A740", Offset = "0xC7A740", VA = "0xC7A740")]
	private bool ShowScaleToFit()
	{
		return default(bool);
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x00007518 File Offset: 0x00005718
	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0xC7A774", Offset = "0xC7A774", VA = "0xC7A774")]
	private bool ShowScaleToFitOptions()
	{
		return default(bool);
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000156")]
	public ControllerActionButton LinkedActionMapping
	{
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0xC7A7B8", Offset = "0xC7A7B8", VA = "0xC7A7B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0xC7A7C0", Offset = "0xC7A7C0", VA = "0xC7A7C0")]
		set
		{
		}
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D2D")]
	[Address(RVA = "0xC7A7C8", Offset = "0xC7A7C8", VA = "0xC7A7C8")]
	public TransactionButton_Layout()
	{
	}

	// Token: 0x0400135B RID: 4955
	[Token(Token = "0x400135B")]
	[FieldOffset(Offset = "0x74")]
	public TransactionButtonStyle_Layout Style;

	// Token: 0x0400135C RID: 4956
	[Token(Token = "0x400135C")]
	[FieldOffset(Offset = "0x78")]
	public bool DrawLabel;

	// Token: 0x0400135D RID: 4957
	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x79")]
	public bool DrawIcon;

	// Token: 0x0400135E RID: 4958
	[Token(Token = "0x400135E")]
	[FieldOffset(Offset = "0x7A")]
	public bool DrawItem;

	// Token: 0x0400135F RID: 4959
	[Token(Token = "0x400135F")]
	[FieldOffset(Offset = "0x7B")]
	public bool DrawControlsIconOnFocus;

	// Token: 0x04001360 RID: 4960
	[Token(Token = "0x4001360")]
	[FieldOffset(Offset = "0x7C")]
	public bool ClickOnRelease;

	// Token: 0x04001361 RID: 4961
	[Token(Token = "0x4001361")]
	[FieldOffset(Offset = "0x80")]
	public String_Layout Label;

	// Token: 0x04001362 RID: 4962
	[Token(Token = "0x4001362")]
	[FieldOffset(Offset = "0x84")]
	public bool MouseHoverFade;

	// Token: 0x04001363 RID: 4963
	[Token(Token = "0x4001363")]
	[FieldOffset(Offset = "0x85")]
	public bool ScaleToFit;

	// Token: 0x04001364 RID: 4964
	[Token(Token = "0x4001364")]
	[FieldOffset(Offset = "0x88")]
	public float ScaleToFitLeftPad;

	// Token: 0x04001365 RID: 4965
	[Token(Token = "0x4001365")]
	[FieldOffset(Offset = "0x8C")]
	public float ScaleToFitRightPad;

	// Token: 0x04001366 RID: 4966
	[Token(Token = "0x4001366")]
	[FieldOffset(Offset = "0x90")]
	public float ScaleToFitMaxScale;

	// Token: 0x04001367 RID: 4967
	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0x94")]
	public float ScaleToFitOrigTextX;

	// Token: 0x04001368 RID: 4968
	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0x98")]
	public Color DisabledLabelColour;

	// Token: 0x04001369 RID: 4969
	[Token(Token = "0x4001369")]
	[FieldOffset(Offset = "0x9C")]
	public Color PressedLabelColour;

	// Token: 0x0400136A RID: 4970
	[Token(Token = "0x400136A")]
	[FieldOffset(Offset = "0xA0")]
	public bool DisableIconResize;

	// Token: 0x0400136B RID: 4971
	[Token(Token = "0x400136B")]
	[FieldOffset(Offset = "0xA4")]
	public Vector2 IconOffset;

	// Token: 0x0400136C RID: 4972
	[Token(Token = "0x400136C")]
	[FieldOffset(Offset = "0xAC")]
	public bool ForceIconScale;

	// Token: 0x0400136D RID: 4973
	[Token(Token = "0x400136D")]
	[FieldOffset(Offset = "0xB0")]
	public float ForcedIconScale;

	// Token: 0x0400136E RID: 4974
	[Token(Token = "0x400136E")]
	[FieldOffset(Offset = "0xB4")]
	public Texture_Layout IconTexture;

	// Token: 0x0400136F RID: 4975
	[Token(Token = "0x400136F")]
	[FieldOffset(Offset = "0xB8")]
	public Texture_Layout IconTextureHighlight;

	// Token: 0x04001370 RID: 4976
	[Token(Token = "0x4001370")]
	[FieldOffset(Offset = "0xBC")]
	public bool DisableIconOnFocus;

	// Token: 0x04001371 RID: 4977
	[Token(Token = "0x4001371")]
	[FieldOffset(Offset = "0xBD")]
	public bool DisableItemOnFocus;

	// Token: 0x04001372 RID: 4978
	[Token(Token = "0x4001372")]
	[FieldOffset(Offset = "0xC0")]
	public GUIControllerInputButton.LinkedControlType LinkedControl;

	// Token: 0x04001373 RID: 4979
	[Token(Token = "0x4001373")]
	[FieldOffset(Offset = "0xC4")]
	private ControllerActionButton _linkedActionMapping;

	// Token: 0x04001374 RID: 4980
	[Token(Token = "0x4001374")]
	[FieldOffset(Offset = "0xC8")]
	public bool DisableControlIconResize;

	// Token: 0x04001375 RID: 4981
	[Token(Token = "0x4001375")]
	[FieldOffset(Offset = "0xCC")]
	public Vector2 ControlIconOffset;

	// Token: 0x04001376 RID: 4982
	[Token(Token = "0x4001376")]
	[FieldOffset(Offset = "0xD4")]
	public bool ForceControlIconScale;

	// Token: 0x04001377 RID: 4983
	[Token(Token = "0x4001377")]
	[FieldOffset(Offset = "0xD8")]
	public float ForcedControlIconScale;

	// Token: 0x04001378 RID: 4984
	[Token(Token = "0x4001378")]
	[FieldOffset(Offset = "0xDC")]
	public bool DisableItemResize;

	// Token: 0x04001379 RID: 4985
	[Token(Token = "0x4001379")]
	[FieldOffset(Offset = "0xDD")]
	public bool ForceItemScale;

	// Token: 0x0400137A RID: 4986
	[Token(Token = "0x400137A")]
	[FieldOffset(Offset = "0xE0")]
	public float ForcedItemScale;

	// Token: 0x0400137B RID: 4987
	[Token(Token = "0x400137B")]
	[FieldOffset(Offset = "0xE4")]
	public Vector2 ItemOffset;

	// Token: 0x0400137C RID: 4988
	[Token(Token = "0x400137C")]
	[FieldOffset(Offset = "0xEC")]
	public Texture_Layout DefaultItemTexture;

	// Token: 0x0400137D RID: 4989
	[Token(Token = "0x400137D")]
	[FieldOffset(Offset = "0xF0")]
	public Color ItemColour;

	// Token: 0x0400137E RID: 4990
	[Token(Token = "0x400137E")]
	[FieldOffset(Offset = "0xF4")]
	public Color DisabledItemColour;

	// Token: 0x0400137F RID: 4991
	[Token(Token = "0x400137F")]
	[FieldOffset(Offset = "0xF8")]
	public Color PressedItemColour;

	// Token: 0x04001380 RID: 4992
	[Token(Token = "0x4001380")]
	[FieldOffset(Offset = "0xFC")]
	public bool overloadSize;

	// Token: 0x04001381 RID: 4993
	[Token(Token = "0x4001381")]
	[FieldOffset(Offset = "0x100")]
	public Vector2 overloadedSize;

	// Token: 0x04001382 RID: 4994
	[Token(Token = "0x4001382")]
	[FieldOffset(Offset = "0x108")]
	public Texture_Layout HighlightBackingDisabled;

	// Token: 0x04001383 RID: 4995
	[Token(Token = "0x4001383")]
	[FieldOffset(Offset = "0x10C")]
	public Color HighlightDisabledColour;

	// Token: 0x04001384 RID: 4996
	[Token(Token = "0x4001384")]
	[FieldOffset(Offset = "0x110")]
	public Texture_Layout HighlightBackingNormal;

	// Token: 0x04001385 RID: 4997
	[Token(Token = "0x4001385")]
	[FieldOffset(Offset = "0x114")]
	public Color HighlightColour;

	// Token: 0x04001386 RID: 4998
	[Token(Token = "0x4001386")]
	[FieldOffset(Offset = "0x118")]
	public Texture_Layout HighlightBackingPressed;

	// Token: 0x04001387 RID: 4999
	[Token(Token = "0x4001387")]
	[FieldOffset(Offset = "0x11C")]
	public Color HighlightPressedColour;

	// Token: 0x04001388 RID: 5000
	[Token(Token = "0x4001388")]
	[FieldOffset(Offset = "0x120")]
	public bool DrawDivider;

	// Token: 0x04001389 RID: 5001
	[Token(Token = "0x4001389")]
	[FieldOffset(Offset = "0x124")]
	public Panel_Layout Divider;

	// Token: 0x0400138A RID: 5002
	[Token(Token = "0x400138A")]
	[FieldOffset(Offset = "0x128")]
	public bool UseDividerHighlightColours;

	// Token: 0x0400138B RID: 5003
	[Token(Token = "0x400138B")]
	[FieldOffset(Offset = "0x129")]
	public Color DividerHighlightColour;

	// Token: 0x0400138C RID: 5004
	[Token(Token = "0x400138C")]
	[FieldOffset(Offset = "0x12D")]
	public Color DividerHighlightBorderColour;

	// Token: 0x0400138D RID: 5005
	[Token(Token = "0x400138D")]
	[FieldOffset(Offset = "0x131")]
	public Color DividerPressedColour;

	// Token: 0x0400138E RID: 5006
	[Token(Token = "0x400138E")]
	[FieldOffset(Offset = "0x135")]
	public Color DividerPressedBorderColour;

	// Token: 0x0400138F RID: 5007
	[Token(Token = "0x400138F")]
	[FieldOffset(Offset = "0x139")]
	public Color DividerPressedHighlightColour;

	// Token: 0x04001390 RID: 5008
	[Token(Token = "0x4001390")]
	[FieldOffset(Offset = "0x13D")]
	public Color DividerPressedHighlightBorderColour;

	// Token: 0x04001391 RID: 5009
	[Token(Token = "0x4001391")]
	[FieldOffset(Offset = "0x141")]
	public Color DividerDisabledColour;

	// Token: 0x04001392 RID: 5010
	[Token(Token = "0x4001392")]
	[FieldOffset(Offset = "0x145")]
	public Color DividerDisabledBorderColour;

	// Token: 0x04001393 RID: 5011
	[Token(Token = "0x4001393")]
	[FieldOffset(Offset = "0x149")]
	public Color DividerDisabledHighlightColour;

	// Token: 0x04001394 RID: 5012
	[Token(Token = "0x4001394")]
	[FieldOffset(Offset = "0x14D")]
	public Color DividerDisabledHighlightBorderColour;

	// Token: 0x04001395 RID: 5013
	[Token(Token = "0x4001395")]
	[FieldOffset(Offset = "0x154")]
	public Texture_Layout BorderDisabled;

	// Token: 0x04001396 RID: 5014
	[Token(Token = "0x4001396")]
	[FieldOffset(Offset = "0x158")]
	public Color DisabledBorderColour;

	// Token: 0x04001397 RID: 5015
	[Token(Token = "0x4001397")]
	[FieldOffset(Offset = "0x15C")]
	public Texture_Layout BorderNormal;

	// Token: 0x04001398 RID: 5016
	[Token(Token = "0x4001398")]
	[FieldOffset(Offset = "0x160")]
	public Color NormalBorderColour;

	// Token: 0x04001399 RID: 5017
	[Token(Token = "0x4001399")]
	[FieldOffset(Offset = "0x164")]
	public Texture_Layout BorderPressed;

	// Token: 0x0400139A RID: 5018
	[Token(Token = "0x400139A")]
	[FieldOffset(Offset = "0x168")]
	public Color PressedBorderColour;
}
