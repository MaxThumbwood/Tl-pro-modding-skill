using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.IO;

// Token: 0x02000277 RID: 631
[Token(Token = "0x2000277")]
public class VirtualControlsStyles_Layout : LayoutDefinition
{
	// Token: 0x06000EC0 RID: 3776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0xC9BEB8", Offset = "0xC9BEB8", VA = "0xC9BEB8")]
	private void Awake()
	{
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000189")]
	public VirtualControlsProfile_Layout ActiveProfile
	{
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0xC9BF0C", Offset = "0xC9BF0C", VA = "0xC9BF0C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0xC9C078", Offset = "0xC9C078", VA = "0xC9C078")]
	public void SetActiveProfile(VirtualControlsProfile_Layout profile)
	{
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0xC9A078", Offset = "0xC9A078", VA = "0xC9A078")]
	public VirtualControlsButtonConfiguration_Layout GetButtonConfiguration(string Id)
	{
		return null;
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0xC9BC9C", Offset = "0xC9BC9C", VA = "0xC9BC9C")]
	public VirtualControlsGroupConfiguration_Layout GetGroupConfiguration(string Id)
	{
		return null;
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0xC9BE20", Offset = "0xC9BE20", VA = "0xC9BE20")]
	public VirtualControlsAxisConfiguration_Layout GetAxisConfiguration(string Id)
	{
		return null;
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0xC9B3A4", Offset = "0xC9B3A4", VA = "0xC9B3A4")]
	public VirtualControlsHardwareConfiguration_Layout GetHardwareConfiguration(string id)
	{
		return null;
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0xC9BFE0", Offset = "0xC9BFE0", VA = "0xC9BFE0")]
	public VirtualControlsProfile_Layout GetProfile(string id)
	{
		return null;
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0xC9C30C", Offset = "0xC9C30C", VA = "0xC9C30C")]
	public static string GetShareCode(VirtualControlsProfile_Layout profile)
	{
		return null;
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0xC9CCA0", Offset = "0xC9CCA0", VA = "0xC9CCA0")]
	public void SaveConfiguration(Preferences preferences)
	{
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0xC9CFBC", Offset = "0xC9CFBC", VA = "0xC9CFBC")]
	public void SetAllConfigurationsToDefault()
	{
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECB")]
	[Address(RVA = "0xC9D278", Offset = "0xC9D278", VA = "0xC9D278")]
	public void InitialiseProfile(VirtualControlsProfile_Layout profile)
	{
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECC")]
	[Address(RVA = "0xC9DA90", Offset = "0xC9DA90", VA = "0xC9DA90")]
	public void LoadConfiguration(Preferences preferences)
	{
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00007A70 File Offset: 0x00005C70
	[Token(Token = "0x6000ECD")]
	[Address(RVA = "0xC9E1B8", Offset = "0xC9E1B8", VA = "0xC9E1B8")]
	private bool GetAnchorItem(VirtualControlsHardwareConfiguration_Layout hardware, VirtualControlsProfile_Layout bindings, ControlAnchor.ControlId controlSide, out Vector2 position)
	{
		return default(bool);
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECE")]
	[Address(RVA = "0xC9E150", Offset = "0xC9E150", VA = "0xC9E150")]
	public VirtualControlsStyles_Layout()
	{
	}

	// Token: 0x04001E42 RID: 7746
	[Token(Token = "0x4001E42")]
	[FieldOffset(Offset = "0x0")]
	public static VirtualControlsStyles_Layout Instance;

	// Token: 0x04001E43 RID: 7747
	[Token(Token = "0x4001E43")]
	[FieldOffset(Offset = "0x4")]
	public static string LastUsedProfile;

	// Token: 0x04001E44 RID: 7748
	[Token(Token = "0x4001E44")]
	[FieldOffset(Offset = "0x8")]
	public static string LastUsedCustomProfile;

	// Token: 0x04001E45 RID: 7749
	[Token(Token = "0x4001E45")]
	[FieldOffset(Offset = "0xC")]
	public VirtualControlsButtonConfiguration_Layout[] ButtonTypes;

	// Token: 0x04001E46 RID: 7750
	[Token(Token = "0x4001E46")]
	[FieldOffset(Offset = "0x10")]
	public VirtualControlsAxisConfiguration_Layout[] AxisTypes;

	// Token: 0x04001E47 RID: 7751
	[Token(Token = "0x4001E47")]
	[FieldOffset(Offset = "0x14")]
	public VirtualControlsGroupConfiguration_Layout[] GroupTypes;

	// Token: 0x04001E48 RID: 7752
	[Token(Token = "0x4001E48")]
	[FieldOffset(Offset = "0x18")]
	public VirtualControlsHardwareConfiguration_Layout[] HardwareStyles;

	// Token: 0x04001E49 RID: 7753
	[Token(Token = "0x4001E49")]
	[FieldOffset(Offset = "0x1C")]
	public VirtualControlsProfile_Layout[] Profiles;

	// Token: 0x04001E4A RID: 7754
	[Token(Token = "0x4001E4A")]
	[FieldOffset(Offset = "0x20")]
	private VirtualControlsProfile_Layout _activeProfile;
}
