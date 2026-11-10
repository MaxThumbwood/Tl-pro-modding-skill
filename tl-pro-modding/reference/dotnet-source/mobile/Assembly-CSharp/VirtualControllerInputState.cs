using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Terraria;
using Terraria.ID;
using Terraria.IO;

// Token: 0x02000195 RID: 405
[Token(Token = "0x2000195")]
public class VirtualControllerInputState
{
	// Token: 0x06000BFA RID: 3066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0xC55878", Offset = "0xC55878", VA = "0xC55878")]
	private static void SetupLookups()
	{
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000112")]
	private string ConfigFile
	{
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0xC55BD4", Offset = "0xC55BD4", VA = "0xC55BD4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000113")]
	private string RightConfigFile
	{
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0xC55C5C", Offset = "0xC55C5C", VA = "0xC55C5C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0xC55CE4", Offset = "0xC55CE4", VA = "0xC55CE4")]
	private static void SaveCodeArrayCategories()
	{
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0xC5615C", Offset = "0xC5615C", VA = "0xC5615C")]
	public void SaveRightClickMode()
	{
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0xC56B74", Offset = "0xC56B74", VA = "0xC56B74")]
	public void SaveDefaultCategories()
	{
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C00")]
	[Address(RVA = "0xC5705C", Offset = "0xC5705C", VA = "0xC5705C")]
	public void LoadDefaultCategories()
	{
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C01")]
	[Address(RVA = "0xC57060", Offset = "0xC57060", VA = "0xC57060")]
	public void RefreshAlternativeModeMappings()
	{
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00006E40 File Offset: 0x00005040
	[Token(Token = "0x17000114")]
	public bool SwapAlternativeFiteModeActive
	{
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0xC57238", Offset = "0xC57238", VA = "0xC57238")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00006E58 File Offset: 0x00005058
	// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000115")]
	public bool ToggleAlternativeFireMode
	{
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0xC570FC", Offset = "0xC570FC", VA = "0xC570FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0xC5733C", Offset = "0xC5733C", VA = "0xC5733C")]
		set
		{
		}
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00006E70 File Offset: 0x00005070
	[Token(Token = "0x6000C05")]
	[Address(RVA = "0xC57494", Offset = "0xC57494", VA = "0xC57494")]
	public float GetItemDeadZone(Item item)
	{
		return 0f;
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x00006E88 File Offset: 0x00005088
	[Token(Token = "0x6000C06")]
	[Address(RVA = "0xC57730", Offset = "0xC57730", VA = "0xC57730")]
	public static VirtualControllerInputState.Category GetItemCategory(int item)
	{
		return VirtualControllerInputState.Category.None;
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C07")]
	[Address(RVA = "0xC57960", Offset = "0xC57960", VA = "0xC57960")]
	public void UpdateState(int selectedItem)
	{
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00006EA0 File Offset: 0x000050A0
	[Token(Token = "0x17000116")]
	public bool ForceAutoReuse
	{
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0xC57F14", Offset = "0xC57F14", VA = "0xC57F14")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00006EB8 File Offset: 0x000050B8
	[Token(Token = "0x17000117")]
	public float NoFireDeadZone
	{
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0xC57F98", Offset = "0xC57F98", VA = "0xC57F98")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00006ED0 File Offset: 0x000050D0
	[Token(Token = "0x17000118")]
	public VirtualControllerInputState.CursorInputMode TouchAimAndUseChecked
	{
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0xC57FA0", Offset = "0xC57FA0", VA = "0xC57FA0")]
		get
		{
			return VirtualControllerInputState.CursorInputMode.Item;
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00006EE8 File Offset: 0x000050E8
	[Token(Token = "0x17000119")]
	public VirtualControllerInputState.CursorInputMode TouchSmartCursorChecked
	{
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0xC58118", Offset = "0xC58118", VA = "0xC58118")]
		get
		{
			return VirtualControllerInputState.CursorInputMode.Item;
		}
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0xC581D8", Offset = "0xC581D8", VA = "0xC581D8")]
	public void InvalidateRightStickCache()
	{
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0xC5828C", Offset = "0xC5828C", VA = "0xC5828C")]
	private void UpdateControlsCache(VirtualControlsHardwareConfiguration_Layout hardware)
	{
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00006F00 File Offset: 0x00005100
	[Token(Token = "0x1700011A")]
	public bool HasToggleFireInteract
	{
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0xC5878C", Offset = "0xC5878C", VA = "0xC5878C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00006F18 File Offset: 0x00005118
	[Token(Token = "0x1700011B")]
	public bool HasTouchHeal
	{
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0xC58830", Offset = "0xC58830", VA = "0xC58830")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00006F30 File Offset: 0x00005130
	[Token(Token = "0x1700011C")]
	public bool HasTouchMana
	{
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0xC588D4", Offset = "0xC588D4", VA = "0xC588D4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00006F48 File Offset: 0x00005148
	[Token(Token = "0x1700011D")]
	public bool HasTouchBuff
	{
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0xC58978", Offset = "0xC58978", VA = "0xC58978")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00006F60 File Offset: 0x00005160
	[Token(Token = "0x1700011E")]
	public bool HasAimUseToggle
	{
		[Token(Token = "0x6000C12")]
		[Address(RVA = "0xC58074", Offset = "0xC58074", VA = "0xC58074")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00006F78 File Offset: 0x00005178
	[Token(Token = "0x1700011F")]
	public bool HasTouchRightStick
	{
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0xC57FD0", Offset = "0xC57FD0", VA = "0xC57FD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00006F90 File Offset: 0x00005190
	[Token(Token = "0x17000120")]
	public bool HasSmartCursor
	{
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0xC58134", Offset = "0xC58134", VA = "0xC58134")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00006FA8 File Offset: 0x000051A8
	[Token(Token = "0x17000121")]
	public bool HasLockon
	{
		[Token(Token = "0x6000C15")]
		[Address(RVA = "0xC58A1C", Offset = "0xC58A1C", VA = "0xC58A1C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00006FC0 File Offset: 0x000051C0
	// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000122")]
	public bool SmartDigEnabled
	{
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0xC58AC0", Offset = "0xC58AC0", VA = "0xC58AC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0xC58D70", Offset = "0xC58D70", VA = "0xC58D70")]
		set
		{
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00006FD8 File Offset: 0x000051D8
	// (set) Token: 0x06000C19 RID: 3097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000123")]
	public bool AimAndUseEnabled
	{
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0xC58FA0", Offset = "0xC58FA0", VA = "0xC58FA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0xC592C0", Offset = "0xC592C0", VA = "0xC592C0")]
		set
		{
		}
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0xC57B2C", Offset = "0xC57B2C", VA = "0xC57B2C")]
	private void SetCatergoryState(VirtualControllerInputState.Category category)
	{
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x00006FF0 File Offset: 0x000051F0
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0xC57F60", Offset = "0xC57F60", VA = "0xC57F60")]
	private bool GetCategoryAutoSwing(VirtualControllerInputState.Category category)
	{
		return default(bool);
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0xC577AC", Offset = "0xC577AC", VA = "0xC577AC")]
	private void GetCategoryDefaults(VirtualControllerInputState.Category category, out bool smartCursor, out bool aimAndUse, out float noFireDeadZone)
	{
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0xC593E0", Offset = "0xC593E0", VA = "0xC593E0")]
	public void ResetConfiguration()
	{
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0xC59540", Offset = "0xC59540", VA = "0xC59540")]
	public void LoadConfiguration(Preferences preferences)
	{
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0xC599B8", Offset = "0xC599B8", VA = "0xC599B8")]
	public void SaveConfiguration(Preferences preferences)
	{
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C20")]
	[Address(RVA = "0xC59DA4", Offset = "0xC59DA4", VA = "0xC59DA4")]
	public VirtualControllerInputState()
	{
	}

	// Token: 0x04000E9F RID: 3743
	[Token(Token = "0x4000E9F")]
	[FieldOffset(Offset = "0x0")]
	private static string[] IdLookup;

	// Token: 0x04000EA0 RID: 3744
	[Token(Token = "0x4000EA0")]
	[FieldOffset(Offset = "0x8")]
	public bool globalToggleAlternativeFireModeInternal;

	// Token: 0x04000EA1 RID: 3745
	[Token(Token = "0x4000EA1")]
	[FieldOffset(Offset = "0x9")]
	public bool toggleAlternativeFireModeInternal;

	// Token: 0x04000EA2 RID: 3746
	[Token(Token = "0x4000EA2")]
	[FieldOffset(Offset = "0x4")]
	private static VirtualControlsHardwareConfigurationMapping_Layout.ContolType[] DefaultMode;

	// Token: 0x04000EA3 RID: 3747
	[Token(Token = "0x4000EA3")]
	[FieldOffset(Offset = "0x8")]
	private static VirtualControlsHardwareConfigurationMapping_Layout.ContolType[] RemappedMode;

	// Token: 0x04000EA4 RID: 3748
	[Token(Token = "0x4000EA4")]
	[FieldOffset(Offset = "0xC")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType[] RemappedBindings;

	// Token: 0x04000EA5 RID: 3749
	[Token(Token = "0x4000EA5")]
	[FieldOffset(Offset = "0xC")]
	public static int[] ItemCategories;

	// Token: 0x04000EA6 RID: 3750
	[Token(Token = "0x4000EA6")]
	[FieldOffset(Offset = "0x10")]
	public bool printMessages;

	// Token: 0x04000EA7 RID: 3751
	[Token(Token = "0x4000EA7")]
	[FieldOffset(Offset = "0x11")]
	public bool ForceAutoSwingEnabled;

	// Token: 0x04000EA8 RID: 3752
	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x14")]
	public VirtualControllerInputState.CursorInputMode TouchSmartCursor;

	// Token: 0x04000EA9 RID: 3753
	[Token(Token = "0x4000EA9")]
	[FieldOffset(Offset = "0x18")]
	public VirtualControllerInputState.CursorInputMode TouchAimAndUse;

	// Token: 0x04000EAA RID: 3754
	[Token(Token = "0x4000EAA")]
	[FieldOffset(Offset = "0x1C")]
	public VirtualControllerInputState.CursorInputMode ControllerSmartCursor;

	// Token: 0x04000EAB RID: 3755
	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x20")]
	public VirtualControllerInputState.CursorInputMode ControllerAimAndUse;

	// Token: 0x04000EAC RID: 3756
	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x24")]
	public VirtualControllerInputState.CursorInputMode MouseSmartCursor;

	// Token: 0x04000EAD RID: 3757
	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0x28")]
	public VirtualControllerInputState.CursorInputMode TouchToggleFireInteract;

	// Token: 0x04000EAE RID: 3758
	[Token(Token = "0x4000EAE")]
	[FieldOffset(Offset = "0x2C")]
	public bool AutoSelectSmartDigEnabled;

	// Token: 0x04000EAF RID: 3759
	[Token(Token = "0x4000EAF")]
	[FieldOffset(Offset = "0x2D")]
	public bool GlobalSmartDigEnabled;

	// Token: 0x04000EB0 RID: 3760
	[Token(Token = "0x4000EB0")]
	[FieldOffset(Offset = "0x2E")]
	public bool GlobalAimAndUseEnabled;

	// Token: 0x04000EB1 RID: 3761
	[Token(Token = "0x4000EB1")]
	[FieldOffset(Offset = "0x30")]
	private VirtualControlsHardwareConfiguration_Layout cachedControlsLayout;

	// Token: 0x04000EB2 RID: 3762
	[Token(Token = "0x4000EB2")]
	[FieldOffset(Offset = "0x34")]
	private bool hasTouchRightStick;

	// Token: 0x04000EB3 RID: 3763
	[Token(Token = "0x4000EB3")]
	[FieldOffset(Offset = "0x35")]
	private bool hasLockOn;

	// Token: 0x04000EB4 RID: 3764
	[Token(Token = "0x4000EB4")]
	[FieldOffset(Offset = "0x36")]
	private bool hasSmartCursor;

	// Token: 0x04000EB5 RID: 3765
	[Token(Token = "0x4000EB5")]
	[FieldOffset(Offset = "0x37")]
	private bool hasToggleFireInteract;

	// Token: 0x04000EB6 RID: 3766
	[Token(Token = "0x4000EB6")]
	[FieldOffset(Offset = "0x38")]
	private bool hasAimUseToggle;

	// Token: 0x04000EB7 RID: 3767
	[Token(Token = "0x4000EB7")]
	[FieldOffset(Offset = "0x39")]
	private bool hasTouchHeal;

	// Token: 0x04000EB8 RID: 3768
	[Token(Token = "0x4000EB8")]
	[FieldOffset(Offset = "0x3A")]
	private bool hasTouchBuff;

	// Token: 0x04000EB9 RID: 3769
	[Token(Token = "0x4000EB9")]
	[FieldOffset(Offset = "0x3B")]
	private bool hasTouchMana;

	// Token: 0x04000EBA RID: 3770
	[Token(Token = "0x4000EBA")]
	[FieldOffset(Offset = "0x3C")]
	private bool _currentSmartCursor;

	// Token: 0x04000EBB RID: 3771
	[Token(Token = "0x4000EBB")]
	[FieldOffset(Offset = "0x3D")]
	private bool _currentAimAndUse;

	// Token: 0x04000EBC RID: 3772
	[Token(Token = "0x4000EBC")]
	[FieldOffset(Offset = "0x40")]
	private float _noFireDeadZone;

	// Token: 0x04000EBD RID: 3773
	[Token(Token = "0x4000EBD")]
	[FieldOffset(Offset = "0x44")]
	private bool _currentAutoReuse;

	// Token: 0x04000EBE RID: 3774
	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<VirtualControllerInputState.Category, bool> SmartCursorState;

	// Token: 0x04000EBF RID: 3775
	[Token(Token = "0x4000EBF")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<VirtualControllerInputState.Category, bool> AimAndUseState;

	// Token: 0x04000EC0 RID: 3776
	[Token(Token = "0x4000EC0")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<VirtualControllerInputState.Category, float> NoFireDeadZoneState;

	// Token: 0x04000EC1 RID: 3777
	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<VirtualControllerInputState.Category, bool> TouchToggleFireInteractState;

	// Token: 0x04000EC2 RID: 3778
	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x58")]
	public VirtualControllerInputState.Category CurrentlyBoundCategory;

	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	public enum AlternativeFireCaetgory
	{
		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000EC4")]
		Disabled,
		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		CanAimAndUse,
		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		UseItemUseTile,
		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000EC7")]
		UseAlternativeFire
	}

	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	public enum Category
	{
		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000EC9")]
		None,
		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		Generic,
		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		Axe,
		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		PickAxe,
		// Token: 0x04000ECD RID: 3789
		[Token(Token = "0x4000ECD")]
		Drills,
		// Token: 0x04000ECE RID: 3790
		[Token(Token = "0x4000ECE")]
		Chainsaw,
		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		Broadsword,
		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		NonAutoFireMeleeStab,
		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		NonAutoFireMeleeSwing,
		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000ED2")]
		AutoFireMeleeSwing,
		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		AutoFireMeleeProjectile,
		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		AutoFireMeleeProjectileNoAim,
		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		Spears,
		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		Boomerangs,
		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		Flails,
		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		FlailsAutoSwing,
		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		Yoyo,
		// Token: 0x04000EDA RID: 3802
		[Token(Token = "0x4000EDA")]
		Bow,
		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		AutoFireBow,
		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		Repeaters,
		// Token: 0x04000EDD RID: 3805
		[Token(Token = "0x4000EDD")]
		ManualGuns,
		// Token: 0x04000EDE RID: 3806
		[Token(Token = "0x4000EDE")]
		AutomaticGuns,
		// Token: 0x04000EDF RID: 3807
		[Token(Token = "0x4000EDF")]
		GrapplingHooks,
		// Token: 0x04000EE0 RID: 3808
		[Token(Token = "0x4000EE0")]
		RocketConsuming,
		// Token: 0x04000EE1 RID: 3809
		[Token(Token = "0x4000EE1")]
		AutoFireRocketConsuming,
		// Token: 0x04000EE2 RID: 3810
		[Token(Token = "0x4000EE2")]
		SummoningMinion,
		// Token: 0x04000EE3 RID: 3811
		[Token(Token = "0x4000EE3")]
		SummoningSentry,
		// Token: 0x04000EE4 RID: 3812
		[Token(Token = "0x4000EE4")]
		ThrowingWeapons,
		// Token: 0x04000EE5 RID: 3813
		[Token(Token = "0x4000EE5")]
		MagicWeapons,
		// Token: 0x04000EE6 RID: 3814
		[Token(Token = "0x4000EE6")]
		AutoFireMagicWeapons,
		// Token: 0x04000EE7 RID: 3815
		[Token(Token = "0x4000EE7")]
		ControlledMagicWeapons,
		// Token: 0x04000EE8 RID: 3816
		[Token(Token = "0x4000EE8")]
		AutoFireControlledMagicWeapons,
		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		Torches,
		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		Hammer,
		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		PlacementSingle,
		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		PlacementMulti,
		// Token: 0x04000EED RID: 3821
		[Token(Token = "0x4000EED")]
		PlacementMultiWalls,
		// Token: 0x04000EEE RID: 3822
		[Token(Token = "0x4000EEE")]
		HealingPotion,
		// Token: 0x04000EEF RID: 3823
		[Token(Token = "0x4000EEF")]
		ManaPotion,
		// Token: 0x04000EF0 RID: 3824
		[Token(Token = "0x4000EF0")]
		BuffPotion,
		// Token: 0x04000EF1 RID: 3825
		[Token(Token = "0x4000EF1")]
		FoodAndDrink,
		// Token: 0x04000EF2 RID: 3826
		[Token(Token = "0x4000EF2")]
		Flasks,
		// Token: 0x04000EF3 RID: 3827
		[Token(Token = "0x4000EF3")]
		OtherPotions,
		// Token: 0x04000EF4 RID: 3828
		[Token(Token = "0x4000EF4")]
		Seeds,
		// Token: 0x04000EF5 RID: 3829
		[Token(Token = "0x4000EF5")]
		FishingPoles,
		// Token: 0x04000EF6 RID: 3830
		[Token(Token = "0x4000EF6")]
		ExcludedAutoSwingAimUse,
		// Token: 0x04000EF7 RID: 3831
		[Token(Token = "0x4000EF7")]
		ExcludedAutoSwing,
		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		NonFireItems,
		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		HousingNPC,
		// Token: 0x04000EFA RID: 3834
		[Token(Token = "0x4000EFA")]
		AutoFireMeleeStab,
		// Token: 0x04000EFB RID: 3835
		[Token(Token = "0x4000EFB")]
		MiscPlace,
		// Token: 0x04000EFC RID: 3836
		[Token(Token = "0x4000EFC")]
		MiscPlaceWalls,
		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4000EFD")]
		MiscBreak,
		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		Instrument,
		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		GolfClubs,
		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		SummoningWhip,
		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		Glowsticks,
		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		AutoFireMeleeThrow,
		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000F03")]
		MountUsage,
		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000F04")]
		Critters,
		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000F05")]
		Kites,
		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000F06")]
		Count
	}

	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	public struct CaterogryEntry
	{
		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x0")]
		private ItemID item;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x4")]
		private VirtualControllerInputState.Category category;
	}

	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	public enum CursorInputMode
	{
		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000F0A")]
		Item,
		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		Global,
		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		Disabled,
		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		AlwaysOn
	}

	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000C23 RID: 3107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0xC5A16C", Offset = "0xC5A16C", VA = "0xC5A16C")]
		public <>c()
		{
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0xC5A174", Offset = "0xC5A174", VA = "0xC5A174")]
		internal bool <SetupLookups>b__4_0(FieldInfo f)
		{
			return default(bool);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0xC5A230", Offset = "0xC5A230", VA = "0xC5A230")]
		internal void <SetupLookups>b__4_1(FieldInfo field)
		{
		}

		// Token: 0x04000F0E RID: 3854
		[Token(Token = "0x4000F0E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly VirtualControllerInputState.<>c <>9;

		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000F0F")]
		[FieldOffset(Offset = "0x4")]
		public static Func<FieldInfo, bool> <>9__4_0;

		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x8")]
		public static Action<FieldInfo> <>9__4_1;
	}
}
