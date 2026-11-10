using System;
using Il2CppDummyDll;

// Token: 0x0200026D RID: 621
[Token(Token = "0x200026D")]
[Serializable]
public class VirtualControlsBinding_Layout
{
	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x000079C8 File Offset: 0x00005BC8
	[Token(Token = "0x17000181")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType ReboundAction
	{
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0xC99E1C", Offset = "0xC99E1C", VA = "0xC99E1C")]
		get
		{
			return VirtualControlsHardwareConfigurationMapping_Layout.ContolType.AutoFire;
		}
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0xC99EBC", Offset = "0xC99EBC", VA = "0xC99EBC")]
	public VirtualControlsBinding_Layout()
	{
	}

	// Token: 0x04001DD5 RID: 7637
	[Token(Token = "0x4001DD5")]
	[FieldOffset(Offset = "0x8")]
	public string SlotId;

	// Token: 0x04001DD6 RID: 7638
	[Token(Token = "0x4001DD6")]
	[FieldOffset(Offset = "0xC")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType Action;

	// Token: 0x04001DD7 RID: 7639
	[Token(Token = "0x4001DD7")]
	[FieldOffset(Offset = "0x10")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType[] GroupActions;
}
