using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000271 RID: 625
[Token(Token = "0x2000271")]
[Serializable]
public class VirtualControlsHardwareConfigurationMapping_Layout
{
	// Token: 0x06000EAE RID: 3758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0xC9A474", Offset = "0xC9A474", VA = "0xC9A474")]
	public void Copy(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00007A10 File Offset: 0x00005C10
	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0xC9A6C0", Offset = "0xC9A6C0", VA = "0xC9A6C0")]
	public bool IsSame(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
		return default(bool);
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0xC9A9C0", Offset = "0xC9A9C0", VA = "0xC9A9C0")]
	public VirtualControlsHardwareConfigurationMapping_Layout()
	{
	}

	// Token: 0x04001E08 RID: 7688
	[Token(Token = "0x4001E08")]
	[FieldOffset(Offset = "0x8")]
	public string SlotId;

	// Token: 0x04001E09 RID: 7689
	[Token(Token = "0x4001E09")]
	[FieldOffset(Offset = "0xC")]
	public VirtualControlsSlotTypeMapping_Layout Style;

	// Token: 0x04001E0A RID: 7690
	[Token(Token = "0x4001E0A")]
	[FieldOffset(Offset = "0x10")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType DefaultControl;

	// Token: 0x04001E0B RID: 7691
	[Token(Token = "0x4001E0B")]
	[FieldOffset(Offset = "0x14")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType[] DefaultGroupControl;

	// Token: 0x04001E0C RID: 7692
	[Token(Token = "0x4001E0C")]
	[FieldOffset(Offset = "0x18")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04001E0D RID: 7693
	[Token(Token = "0x4001E0D")]
	[FieldOffset(Offset = "0x1C")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04001E0E RID: 7694
	[Token(Token = "0x4001E0E")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 Location;

	// Token: 0x04001E0F RID: 7695
	[Token(Token = "0x4001E0F")]
	[FieldOffset(Offset = "0x28")]
	public bool MultiTouch;

	// Token: 0x02000272 RID: 626
	[Token(Token = "0x2000272")]
	public enum ContolType
	{
		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		AutoFire,
		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		SmartCursor,
		// Token: 0x04001E13 RID: 7699
		[Token(Token = "0x4001E13")]
		CombatTargetting,
		// Token: 0x04001E14 RID: 7700
		[Token(Token = "0x4001E14")]
		Jump,
		// Token: 0x04001E15 RID: 7701
		[Token(Token = "0x4001E15")]
		Heal,
		// Token: 0x04001E16 RID: 7702
		[Token(Token = "0x4001E16")]
		Mana,
		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		Buff,
		// Token: 0x04001E18 RID: 7704
		[Token(Token = "0x4001E18")]
		Mount,
		// Token: 0x04001E19 RID: 7705
		[Token(Token = "0x4001E19")]
		Interact,
		// Token: 0x04001E1A RID: 7706
		[Token(Token = "0x4001E1A")]
		Fire,
		// Token: 0x04001E1B RID: 7707
		[Token(Token = "0x4001E1B")]
		GrappleAxis,
		// Token: 0x04001E1C RID: 7708
		[Token(Token = "0x4001E1C")]
		AutoSelect,
		// Token: 0x04001E1D RID: 7709
		[Token(Token = "0x4001E1D")]
		ZoomIn,
		// Token: 0x04001E1E RID: 7710
		[Token(Token = "0x4001E1E")]
		ZoomOut,
		// Token: 0x04001E1F RID: 7711
		[Token(Token = "0x4001E1F")]
		Move,
		// Token: 0x04001E20 RID: 7712
		[Token(Token = "0x4001E20")]
		Aim,
		// Token: 0x04001E21 RID: 7713
		[Token(Token = "0x4001E21")]
		GrappleFire,
		// Token: 0x04001E22 RID: 7714
		[Token(Token = "0x4001E22")]
		ProfileSwitch,
		// Token: 0x04001E23 RID: 7715
		[Token(Token = "0x4001E23")]
		InventoryToggle,
		// Token: 0x04001E24 RID: 7716
		[Token(Token = "0x4001E24")]
		Settings,
		// Token: 0x04001E25 RID: 7717
		[Token(Token = "0x4001E25")]
		Loadout1,
		// Token: 0x04001E26 RID: 7718
		[Token(Token = "0x4001E26")]
		Loadout2,
		// Token: 0x04001E27 RID: 7719
		[Token(Token = "0x4001E27")]
		Loadout3,
		// Token: 0x04001E28 RID: 7720
		[Token(Token = "0x4001E28")]
		LoadoutCycle,
		// Token: 0x04001E29 RID: 7721
		[Token(Token = "0x4001E29")]
		InteractOnly,
		// Token: 0x04001E2A RID: 7722
		[Token(Token = "0x4001E2A")]
		ToggleFireInteract,
		// Token: 0x04001E2B RID: 7723
		[Token(Token = "0x4001E2B")]
		Dash,
		// Token: 0x04001E2C RID: 7724
		[Token(Token = "0x4001E2C")]
		ArmorSetAbility,
		// Token: 0x04001E2D RID: 7725
		[Token(Token = "0x4001E2D")]
		Count
	}
}
