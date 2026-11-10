using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001E6 RID: 486
[Token(Token = "0x20001E6")]
public class ControlsTutorial_Layout : LayoutDefinition
{
	// Token: 0x06000D35 RID: 3381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D35")]
	[Address(RVA = "0xC7B240", Offset = "0xC7B240", VA = "0xC7B240")]
	private void Awake()
	{
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D36")]
	[Address(RVA = "0xC7B294", Offset = "0xC7B294", VA = "0xC7B294")]
	public ControlsTutorial_Layout()
	{
	}

	// Token: 0x040013BC RID: 5052
	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x0")]
	public static ControlsTutorial_Layout Instance;

	// Token: 0x040013BD RID: 5053
	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0xC")]
	public float TooltipTime;

	// Token: 0x040013BE RID: 5054
	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x10")]
	public float TooltipFadeTime;

	// Token: 0x040013BF RID: 5055
	[Token(Token = "0x40013BF")]
	[FieldOffset(Offset = "0x14")]
	public int MaximumTooltipWidth;

	// Token: 0x040013C0 RID: 5056
	[Token(Token = "0x40013C0")]
	[FieldOffset(Offset = "0x18")]
	public int InteractPriority;

	// Token: 0x040013C1 RID: 5057
	[Token(Token = "0x40013C1")]
	[FieldOffset(Offset = "0x1C")]
	public int AutoSelectPriority;

	// Token: 0x040013C2 RID: 5058
	[Token(Token = "0x40013C2")]
	[FieldOffset(Offset = "0x20")]
	public int AutoFirePriority;

	// Token: 0x040013C3 RID: 5059
	[Token(Token = "0x40013C3")]
	[FieldOffset(Offset = "0x24")]
	public int QuickHealPriority;

	// Token: 0x040013C4 RID: 5060
	[Token(Token = "0x40013C4")]
	[FieldOffset(Offset = "0x28")]
	public int QuickManaPriority;

	// Token: 0x040013C5 RID: 5061
	[Token(Token = "0x40013C5")]
	[FieldOffset(Offset = "0x2C")]
	public int QuickBuffPriority;

	// Token: 0x040013C6 RID: 5062
	[Token(Token = "0x40013C6")]
	[FieldOffset(Offset = "0x30")]
	public int InventoryTogglePriority;

	// Token: 0x040013C7 RID: 5063
	[Token(Token = "0x40013C7")]
	[FieldOffset(Offset = "0x34")]
	public int ZoomOutPriority;

	// Token: 0x040013C8 RID: 5064
	[Token(Token = "0x40013C8")]
	[FieldOffset(Offset = "0x38")]
	public int MovementAxisPriority;

	// Token: 0x040013C9 RID: 5065
	[Token(Token = "0x40013C9")]
	[FieldOffset(Offset = "0x3C")]
	public ControlAnchor.ControlId LeftAnchorControl;

	// Token: 0x040013CA RID: 5066
	[Token(Token = "0x40013CA")]
	[FieldOffset(Offset = "0x40")]
	public LayoutCalculator.AnchorType LeftAnchor;

	// Token: 0x040013CB RID: 5067
	[Token(Token = "0x40013CB")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 LeftLocation;

	// Token: 0x040013CC RID: 5068
	[Token(Token = "0x40013CC")]
	[FieldOffset(Offset = "0x4C")]
	public int FirePriority;

	// Token: 0x040013CD RID: 5069
	[Token(Token = "0x40013CD")]
	[FieldOffset(Offset = "0x50")]
	public int TargetLockOnPriority;

	// Token: 0x040013CE RID: 5070
	[Token(Token = "0x40013CE")]
	[FieldOffset(Offset = "0x54")]
	public int SmartCursorPriority;

	// Token: 0x040013CF RID: 5071
	[Token(Token = "0x40013CF")]
	[FieldOffset(Offset = "0x58")]
	public int JumpPriority;

	// Token: 0x040013D0 RID: 5072
	[Token(Token = "0x40013D0")]
	[FieldOffset(Offset = "0x5C")]
	public int QuickMountPriority;

	// Token: 0x040013D1 RID: 5073
	[Token(Token = "0x40013D1")]
	[FieldOffset(Offset = "0x60")]
	public int ZoomInPriority;

	// Token: 0x040013D2 RID: 5074
	[Token(Token = "0x40013D2")]
	[FieldOffset(Offset = "0x64")]
	public int FireAxisPriority;

	// Token: 0x040013D3 RID: 5075
	[Token(Token = "0x40013D3")]
	[FieldOffset(Offset = "0x68")]
	public int GrappleAxisPriority;

	// Token: 0x040013D4 RID: 5076
	[Token(Token = "0x40013D4")]
	[FieldOffset(Offset = "0x6C")]
	public int ProfileSwitchPriority;

	// Token: 0x040013D5 RID: 5077
	[Token(Token = "0x40013D5")]
	[FieldOffset(Offset = "0x70")]
	public ControlAnchor.ControlId RightAnchorControl;

	// Token: 0x040013D6 RID: 5078
	[Token(Token = "0x40013D6")]
	[FieldOffset(Offset = "0x74")]
	public LayoutCalculator.AnchorType RightAnchor;

	// Token: 0x040013D7 RID: 5079
	[Token(Token = "0x40013D7")]
	[FieldOffset(Offset = "0x78")]
	public Vector2 RightLocation;

	// Token: 0x040013D8 RID: 5080
	[Token(Token = "0x40013D8")]
	[FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout TutorialButton;

	// Token: 0x040013D9 RID: 5081
	[Token(Token = "0x40013D9")]
	[FieldOffset(Offset = "0x84")]
	public TransactionButton_Layout TutorialButtonOpen;

	// Token: 0x040013DA RID: 5082
	[Token(Token = "0x40013DA")]
	[FieldOffset(Offset = "0x88")]
	public ControlAnchor.ControlId ToggleAnchorControl;

	// Token: 0x040013DB RID: 5083
	[Token(Token = "0x40013DB")]
	[FieldOffset(Offset = "0x8C")]
	public LayoutCalculator.AnchorType ToggleAnchor;

	// Token: 0x040013DC RID: 5084
	[Token(Token = "0x40013DC")]
	[FieldOffset(Offset = "0x90")]
	public Vector2 ToggleLocation;

	// Token: 0x040013DD RID: 5085
	[Token(Token = "0x40013DD")]
	[FieldOffset(Offset = "0x98")]
	public String_Layout TitleFormat;

	// Token: 0x040013DE RID: 5086
	[Token(Token = "0x40013DE")]
	[FieldOffset(Offset = "0x9C")]
	public ControlAnchor.ControlId MenuAnchorControl;

	// Token: 0x040013DF RID: 5087
	[Token(Token = "0x40013DF")]
	[FieldOffset(Offset = "0xA0")]
	public LayoutCalculator.AnchorType MenuAnchor;

	// Token: 0x040013E0 RID: 5088
	[Token(Token = "0x40013E0")]
	[FieldOffset(Offset = "0xA4")]
	public Vector2 MenuLocation;

	// Token: 0x040013E1 RID: 5089
	[Token(Token = "0x40013E1")]
	[FieldOffset(Offset = "0xAC")]
	public Vector2 MenuTopLocation;

	// Token: 0x040013E2 RID: 5090
	[Token(Token = "0x40013E2")]
	[FieldOffset(Offset = "0xB4")]
	public Vector2 MenuBottomLocation;
}
