using System;
using Il2CppDummyDll;

// Token: 0x02000275 RID: 629
[Token(Token = "0x2000275")]
[Serializable]
public class VirtualControlsSlotTypeMapping_Layout
{
	// Token: 0x06000EBC RID: 3772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0xC9A6B8", Offset = "0xC9A6B8", VA = "0xC9A6B8")]
	public VirtualControlsSlotTypeMapping_Layout()
	{
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000186")]
	public VirtualControlsButtonConfiguration_Layout ButtonConfiguration
	{
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0xC9BAC4", Offset = "0xC9BAC4", VA = "0xC9BAC4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000187")]
	public VirtualControlsGroupConfiguration_Layout GroupConfiguration
	{
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0xC9BBB0", Offset = "0xC9BBB0", VA = "0xC9BBB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000188")]
	public VirtualControlsAxisConfiguration_Layout AxisConfiguration
	{
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0xC9BD34", Offset = "0xC9BD34", VA = "0xC9BD34")]
		get
		{
			return null;
		}
	}

	// Token: 0x04001E38 RID: 7736
	[Token(Token = "0x4001E38")]
	[FieldOffset(Offset = "0x8")]
	public string ControlTypeId;

	// Token: 0x04001E39 RID: 7737
	[Token(Token = "0x4001E39")]
	[FieldOffset(Offset = "0xC")]
	public VirtualControlsSlotTypeMapping_Layout.SlotType ControlType;

	// Token: 0x04001E3A RID: 7738
	[Token(Token = "0x4001E3A")]
	[FieldOffset(Offset = "0x10")]
	private VirtualControlsButtonConfiguration_Layout _buttonMapping;

	// Token: 0x04001E3B RID: 7739
	[Token(Token = "0x4001E3B")]
	[FieldOffset(Offset = "0x14")]
	private VirtualControlsGroupConfiguration_Layout _groupMapping;

	// Token: 0x04001E3C RID: 7740
	[Token(Token = "0x4001E3C")]
	[FieldOffset(Offset = "0x18")]
	private VirtualControlsAxisConfiguration_Layout _axisMapping;

	// Token: 0x04001E3D RID: 7741
	[Token(Token = "0x4001E3D")]
	[FieldOffset(Offset = "0x1C")]
	private string _lastControlTypeId;

	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public enum SlotType
	{
		// Token: 0x04001E3F RID: 7743
		[Token(Token = "0x4001E3F")]
		Axis,
		// Token: 0x04001E40 RID: 7744
		[Token(Token = "0x4001E40")]
		Button,
		// Token: 0x04001E41 RID: 7745
		[Token(Token = "0x4001E41")]
		Group
	}
}
