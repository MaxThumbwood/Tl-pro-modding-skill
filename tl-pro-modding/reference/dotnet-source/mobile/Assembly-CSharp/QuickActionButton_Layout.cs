using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001D2 RID: 466
[Token(Token = "0x20001D2")]
[Serializable]
public class QuickActionButton_Layout : Button_Layout
{
	// Token: 0x06000CFA RID: 3322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0xC75108", Offset = "0xC75108", VA = "0xC75108")]
	public QuickActionButton_Layout()
	{
	}

	// Token: 0x04001282 RID: 4738
	[Token(Token = "0x4001282")]
	[FieldOffset(Offset = "0x31")]
	public Color DisabledColour;

	// Token: 0x04001283 RID: 4739
	[Token(Token = "0x4001283")]
	[FieldOffset(Offset = "0x35")]
	public Color PressedColour;

	// Token: 0x04001284 RID: 4740
	[Token(Token = "0x4001284")]
	[FieldOffset(Offset = "0x39")]
	public Color IconColour;

	// Token: 0x04001285 RID: 4741
	[Token(Token = "0x4001285")]
	[FieldOffset(Offset = "0x3D")]
	public Color DisabledIconColour;

	// Token: 0x04001286 RID: 4742
	[Token(Token = "0x4001286")]
	[FieldOffset(Offset = "0x41")]
	public Color PressedIconColour;

	// Token: 0x04001287 RID: 4743
	[Token(Token = "0x4001287")]
	[FieldOffset(Offset = "0x45")]
	public Color LabelHighlightTint;

	// Token: 0x04001288 RID: 4744
	[Token(Token = "0x4001288")]
	[FieldOffset(Offset = "0x4C")]
	public float ScaleSpeed;

	// Token: 0x04001289 RID: 4745
	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0x50")]
	public float DisabledScale;

	// Token: 0x0400128A RID: 4746
	[Token(Token = "0x400128A")]
	[FieldOffset(Offset = "0x54")]
	public float PressedScale;

	// Token: 0x0400128B RID: 4747
	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0x58")]
	public int IconMaxSizeInset;

	// Token: 0x0400128C RID: 4748
	[Token(Token = "0x400128C")]
	[FieldOffset(Offset = "0x5C")]
	public Texture_Layout BackingDisabled;

	// Token: 0x0400128D RID: 4749
	[Token(Token = "0x400128D")]
	[FieldOffset(Offset = "0x60")]
	public Texture_Layout BackingNormal;

	// Token: 0x0400128E RID: 4750
	[Token(Token = "0x400128E")]
	[FieldOffset(Offset = "0x64")]
	public Texture_Layout BackingPressed;

	// Token: 0x0400128F RID: 4751
	[Token(Token = "0x400128F")]
	[FieldOffset(Offset = "0x68")]
	public Texture_Layout BackingPressedHighlight;

	// Token: 0x04001290 RID: 4752
	[Token(Token = "0x4001290")]
	[FieldOffset(Offset = "0x6C")]
	public Color BackingPressedHighlightColour;

	// Token: 0x04001291 RID: 4753
	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0x70")]
	public Texture_Layout OverBackingHighlight;

	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	public enum QuickActionControl
	{
		// Token: 0x04001293 RID: 4755
		[Token(Token = "0x4001293")]
		Heal,
		// Token: 0x04001294 RID: 4756
		[Token(Token = "0x4001294")]
		Mana,
		// Token: 0x04001295 RID: 4757
		[Token(Token = "0x4001295")]
		Mount,
		// Token: 0x04001296 RID: 4758
		[Token(Token = "0x4001296")]
		Buff,
		// Token: 0x04001297 RID: 4759
		[Token(Token = "0x4001297")]
		Grapple,
		// Token: 0x04001298 RID: 4760
		[Token(Token = "0x4001298")]
		Jump,
		// Token: 0x04001299 RID: 4761
		[Token(Token = "0x4001299")]
		Fire,
		// Token: 0x0400129A RID: 4762
		[Token(Token = "0x400129A")]
		SmartCursor,
		// Token: 0x0400129B RID: 4763
		[Token(Token = "0x400129B")]
		AutoFire,
		// Token: 0x0400129C RID: 4764
		[Token(Token = "0x400129C")]
		ZoomIn,
		// Token: 0x0400129D RID: 4765
		[Token(Token = "0x400129D")]
		ZoomOut,
		// Token: 0x0400129E RID: 4766
		[Token(Token = "0x400129E")]
		ZoomDefault,
		// Token: 0x0400129F RID: 4767
		[Token(Token = "0x400129F")]
		MapZoomIn,
		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		MapZoomOut,
		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		MapZoomDefault,
		// Token: 0x040012A2 RID: 4770
		[Token(Token = "0x40012A2")]
		MinimapZoomIn,
		// Token: 0x040012A3 RID: 4771
		[Token(Token = "0x40012A3")]
		MinimapZoomOut,
		// Token: 0x040012A4 RID: 4772
		[Token(Token = "0x40012A4")]
		MinimapZoomDefault,
		// Token: 0x040012A5 RID: 4773
		[Token(Token = "0x40012A5")]
		Interact,
		// Token: 0x040012A6 RID: 4774
		[Token(Token = "0x40012A6")]
		Inventory,
		// Token: 0x040012A7 RID: 4775
		[Token(Token = "0x40012A7")]
		Reforge,
		// Token: 0x040012A8 RID: 4776
		[Token(Token = "0x40012A8")]
		AutoSelect,
		// Token: 0x040012A9 RID: 4777
		[Token(Token = "0x40012A9")]
		GrappleFire,
		// Token: 0x040012AA RID: 4778
		[Token(Token = "0x40012AA")]
		Map,
		// Token: 0x040012AB RID: 4779
		[Token(Token = "0x40012AB")]
		TargetLockOn,
		// Token: 0x040012AC RID: 4780
		[Token(Token = "0x40012AC")]
		ProfileSwitch,
		// Token: 0x040012AD RID: 4781
		[Token(Token = "0x40012AD")]
		Settings,
		// Token: 0x040012AE RID: 4782
		[Token(Token = "0x40012AE")]
		Loadout1,
		// Token: 0x040012AF RID: 4783
		[Token(Token = "0x40012AF")]
		Loadout2,
		// Token: 0x040012B0 RID: 4784
		[Token(Token = "0x40012B0")]
		Loadout3,
		// Token: 0x040012B1 RID: 4785
		[Token(Token = "0x40012B1")]
		LoadoutCycle,
		// Token: 0x040012B2 RID: 4786
		[Token(Token = "0x40012B2")]
		InteractOnly,
		// Token: 0x040012B3 RID: 4787
		[Token(Token = "0x40012B3")]
		ToggleFireInteract,
		// Token: 0x040012B4 RID: 4788
		[Token(Token = "0x40012B4")]
		Dash,
		// Token: 0x040012B5 RID: 4789
		[Token(Token = "0x40012B5")]
		ArmorSetAbility,
		// Token: 0x040012B6 RID: 4790
		[Token(Token = "0x40012B6")]
		Unbound
	}
}
