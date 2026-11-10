using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001DD RID: 477
[Token(Token = "0x20001DD")]
[Serializable]
public class TransactionButtonStyle_Definition
{
	// Token: 0x06000D18 RID: 3352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D18")]
	[Address(RVA = "0xC7906C", Offset = "0xC7906C", VA = "0xC7906C")]
	public void Apply(TransactionButton_Layout layout)
	{
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D19")]
	[Address(RVA = "0xC79654", Offset = "0xC79654", VA = "0xC79654")]
	public void Copy(TransactionButton_Layout layout)
	{
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0xC79D94", Offset = "0xC79D94", VA = "0xC79D94")]
	public TransactionButtonStyle_Definition()
	{
	}

	// Token: 0x04001308 RID: 4872
	[Token(Token = "0x4001308")]
	[FieldOffset(Offset = "0x8")]
	public string StyleId;

	// Token: 0x04001309 RID: 4873
	[Token(Token = "0x4001309")]
	[FieldOffset(Offset = "0xC")]
	public float Scale;

	// Token: 0x0400130A RID: 4874
	[Token(Token = "0x400130A")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 PickBorder;

	// Token: 0x0400130B RID: 4875
	[Token(Token = "0x400130B")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 PickOffset;

	// Token: 0x0400130C RID: 4876
	[Token(Token = "0x400130C")]
	[FieldOffset(Offset = "0x20")]
	public Color Color;

	// Token: 0x0400130D RID: 4877
	[Token(Token = "0x400130D")]
	[FieldOffset(Offset = "0x24")]
	public bool UseCirclePickingRegion;

	// Token: 0x0400130E RID: 4878
	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x25")]
	public Color DisabledColour;

	// Token: 0x0400130F RID: 4879
	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x29")]
	public Color PressedColour;

	// Token: 0x04001310 RID: 4880
	[Token(Token = "0x4001310")]
	[FieldOffset(Offset = "0x2D")]
	public Color IconColour;

	// Token: 0x04001311 RID: 4881
	[Token(Token = "0x4001311")]
	[FieldOffset(Offset = "0x31")]
	public Color DisabledIconColour;

	// Token: 0x04001312 RID: 4882
	[Token(Token = "0x4001312")]
	[FieldOffset(Offset = "0x35")]
	public Color PressedIconColour;

	// Token: 0x04001313 RID: 4883
	[Token(Token = "0x4001313")]
	[FieldOffset(Offset = "0x39")]
	public Color LabelHighlightTint;

	// Token: 0x04001314 RID: 4884
	[Token(Token = "0x4001314")]
	[FieldOffset(Offset = "0x40")]
	public float ScaleSpeed;

	// Token: 0x04001315 RID: 4885
	[Token(Token = "0x4001315")]
	[FieldOffset(Offset = "0x44")]
	public float DisabledScale;

	// Token: 0x04001316 RID: 4886
	[Token(Token = "0x4001316")]
	[FieldOffset(Offset = "0x48")]
	public float PressedScale;

	// Token: 0x04001317 RID: 4887
	[Token(Token = "0x4001317")]
	[FieldOffset(Offset = "0x4C")]
	public int IconMaxSizeInset;

	// Token: 0x04001318 RID: 4888
	[Token(Token = "0x4001318")]
	[FieldOffset(Offset = "0x50")]
	public Texture_Layout BackingDisabled;

	// Token: 0x04001319 RID: 4889
	[Token(Token = "0x4001319")]
	[FieldOffset(Offset = "0x54")]
	public Texture_Layout BackingNormal;

	// Token: 0x0400131A RID: 4890
	[Token(Token = "0x400131A")]
	[FieldOffset(Offset = "0x58")]
	public Texture_Layout BackingPressed;

	// Token: 0x0400131B RID: 4891
	[Token(Token = "0x400131B")]
	[FieldOffset(Offset = "0x5C")]
	public Texture_Layout BackingPressedHighlight;

	// Token: 0x0400131C RID: 4892
	[Token(Token = "0x400131C")]
	[FieldOffset(Offset = "0x60")]
	public Color BackingPressedHighlightColour;

	// Token: 0x0400131D RID: 4893
	[Token(Token = "0x400131D")]
	[FieldOffset(Offset = "0x64")]
	public Texture_Layout OverBackingHighlight;

	// Token: 0x0400131E RID: 4894
	[Token(Token = "0x400131E")]
	[FieldOffset(Offset = "0x68")]
	public Texture_Layout HighlightBackingDisabled;

	// Token: 0x0400131F RID: 4895
	[Token(Token = "0x400131F")]
	[FieldOffset(Offset = "0x6C")]
	public Color HighlightDisabledColour;

	// Token: 0x04001320 RID: 4896
	[Token(Token = "0x4001320")]
	[FieldOffset(Offset = "0x70")]
	public Texture_Layout HighlightBackingNormal;

	// Token: 0x04001321 RID: 4897
	[Token(Token = "0x4001321")]
	[FieldOffset(Offset = "0x74")]
	public Color HighlightColour;

	// Token: 0x04001322 RID: 4898
	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0x78")]
	public Texture_Layout HighlightBackingPressed;

	// Token: 0x04001323 RID: 4899
	[Token(Token = "0x4001323")]
	[FieldOffset(Offset = "0x7C")]
	public Color HighlightPressedColour;

	// Token: 0x04001324 RID: 4900
	[Token(Token = "0x4001324")]
	[FieldOffset(Offset = "0x80")]
	public bool DrawLabel;

	// Token: 0x04001325 RID: 4901
	[Token(Token = "0x4001325")]
	[FieldOffset(Offset = "0x81")]
	public bool DrawIcon;

	// Token: 0x04001326 RID: 4902
	[Token(Token = "0x4001326")]
	[FieldOffset(Offset = "0x82")]
	public bool DrawItem;

	// Token: 0x04001327 RID: 4903
	[Token(Token = "0x4001327")]
	[FieldOffset(Offset = "0x83")]
	public bool DrawControlsIconOnFocus;

	// Token: 0x04001328 RID: 4904
	[Token(Token = "0x4001328")]
	[FieldOffset(Offset = "0x84")]
	public String_Layout Label;

	// Token: 0x04001329 RID: 4905
	[Token(Token = "0x4001329")]
	[FieldOffset(Offset = "0x88")]
	public bool ScaleToFit;

	// Token: 0x0400132A RID: 4906
	[Token(Token = "0x400132A")]
	[FieldOffset(Offset = "0x8C")]
	public float ScaleToFitLeftPad;

	// Token: 0x0400132B RID: 4907
	[Token(Token = "0x400132B")]
	[FieldOffset(Offset = "0x90")]
	public float ScaleToFitRightPad;

	// Token: 0x0400132C RID: 4908
	[Token(Token = "0x400132C")]
	[FieldOffset(Offset = "0x94")]
	public float ScaleToFitMaxScale;

	// Token: 0x0400132D RID: 4909
	[Token(Token = "0x400132D")]
	[FieldOffset(Offset = "0x98")]
	public Color DisabledLabelColour;

	// Token: 0x0400132E RID: 4910
	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x9C")]
	public Color PressedLabelColour;

	// Token: 0x0400132F RID: 4911
	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0xA0")]
	public bool DisableIconResize;

	// Token: 0x04001330 RID: 4912
	[Token(Token = "0x4001330")]
	[FieldOffset(Offset = "0xA4")]
	public Vector2 IconOffset;

	// Token: 0x04001331 RID: 4913
	[Token(Token = "0x4001331")]
	[FieldOffset(Offset = "0xAC")]
	public bool ForceIconScale;

	// Token: 0x04001332 RID: 4914
	[Token(Token = "0x4001332")]
	[FieldOffset(Offset = "0xB0")]
	public float ForcedIconScale;

	// Token: 0x04001333 RID: 4915
	[Token(Token = "0x4001333")]
	[FieldOffset(Offset = "0xB4")]
	public bool DisableIconOnFocus;

	// Token: 0x04001334 RID: 4916
	[Token(Token = "0x4001334")]
	[FieldOffset(Offset = "0xB5")]
	public bool DisableControlIconResize;

	// Token: 0x04001335 RID: 4917
	[Token(Token = "0x4001335")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2 ControlIconOffset;

	// Token: 0x04001336 RID: 4918
	[Token(Token = "0x4001336")]
	[FieldOffset(Offset = "0xC0")]
	public bool ForceControlIconScale;

	// Token: 0x04001337 RID: 4919
	[Token(Token = "0x4001337")]
	[FieldOffset(Offset = "0xC4")]
	public float ForcedControlIconScale;

	// Token: 0x04001338 RID: 4920
	[Token(Token = "0x4001338")]
	[FieldOffset(Offset = "0xC8")]
	public bool DisableItemResize;

	// Token: 0x04001339 RID: 4921
	[Token(Token = "0x4001339")]
	[FieldOffset(Offset = "0xC9")]
	public bool ForceItemScale;

	// Token: 0x0400133A RID: 4922
	[Token(Token = "0x400133A")]
	[FieldOffset(Offset = "0xCC")]
	public float ForcedItemScale;

	// Token: 0x0400133B RID: 4923
	[Token(Token = "0x400133B")]
	[FieldOffset(Offset = "0xD0")]
	public Vector2 ItemOffset;

	// Token: 0x0400133C RID: 4924
	[Token(Token = "0x400133C")]
	[FieldOffset(Offset = "0xD8")]
	public Texture_Layout DefaultItemTexture;

	// Token: 0x0400133D RID: 4925
	[Token(Token = "0x400133D")]
	[FieldOffset(Offset = "0xDC")]
	public Color ItemColour;

	// Token: 0x0400133E RID: 4926
	[Token(Token = "0x400133E")]
	[FieldOffset(Offset = "0xE0")]
	public Color DisabledItemColour;

	// Token: 0x0400133F RID: 4927
	[Token(Token = "0x400133F")]
	[FieldOffset(Offset = "0xE4")]
	public Color PressedItemColour;

	// Token: 0x04001340 RID: 4928
	[Token(Token = "0x4001340")]
	[FieldOffset(Offset = "0xE8")]
	public bool overloadSize;

	// Token: 0x04001341 RID: 4929
	[Token(Token = "0x4001341")]
	[FieldOffset(Offset = "0xEC")]
	public Vector2 overloadedSize;

	// Token: 0x04001342 RID: 4930
	[Token(Token = "0x4001342")]
	[FieldOffset(Offset = "0xF4")]
	public bool DrawDivider;

	// Token: 0x04001343 RID: 4931
	[Token(Token = "0x4001343")]
	[FieldOffset(Offset = "0xF8")]
	public Panel_Layout Divider;

	// Token: 0x04001344 RID: 4932
	[Token(Token = "0x4001344")]
	[FieldOffset(Offset = "0xFC")]
	public bool UseDividerHighlightColours;

	// Token: 0x04001345 RID: 4933
	[Token(Token = "0x4001345")]
	[FieldOffset(Offset = "0xFD")]
	public Color DividerHighlightColour;

	// Token: 0x04001346 RID: 4934
	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0x101")]
	public Color DividerHighlightBorderColour;

	// Token: 0x04001347 RID: 4935
	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0x105")]
	public Color DividerPressedColour;

	// Token: 0x04001348 RID: 4936
	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0x109")]
	public Color DividerPressedBorderColour;

	// Token: 0x04001349 RID: 4937
	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0x10D")]
	public Color DividerPressedHighlightColour;

	// Token: 0x0400134A RID: 4938
	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x111")]
	public Color DividerPressedHighlightBorderColour;

	// Token: 0x0400134B RID: 4939
	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0x115")]
	public Color DividerDisabledColour;

	// Token: 0x0400134C RID: 4940
	[Token(Token = "0x400134C")]
	[FieldOffset(Offset = "0x119")]
	public Color DividerDisabledBorderColour;

	// Token: 0x0400134D RID: 4941
	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0x11D")]
	public Color DividerDisabledHighlightColour;

	// Token: 0x0400134E RID: 4942
	[Token(Token = "0x400134E")]
	[FieldOffset(Offset = "0x121")]
	public Color DividerDisabledHighlightBorderColour;

	// Token: 0x0400134F RID: 4943
	[Token(Token = "0x400134F")]
	[FieldOffset(Offset = "0x128")]
	public Texture_Layout BorderDisabled;

	// Token: 0x04001350 RID: 4944
	[Token(Token = "0x4001350")]
	[FieldOffset(Offset = "0x12C")]
	public Color DisabledBorderColour;

	// Token: 0x04001351 RID: 4945
	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0x130")]
	public Texture_Layout BorderNormal;

	// Token: 0x04001352 RID: 4946
	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0x134")]
	public Color NormalBorderColour;

	// Token: 0x04001353 RID: 4947
	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0x138")]
	public Texture_Layout BorderPressed;

	// Token: 0x04001354 RID: 4948
	[Token(Token = "0x4001354")]
	[FieldOffset(Offset = "0x13C")]
	public Color PressedBorderColour;
}
