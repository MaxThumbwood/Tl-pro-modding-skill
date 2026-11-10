using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001F8 RID: 504
[Token(Token = "0x20001F8")]
public class InterfaceStyles_Layout : LayoutDefinition
{
	// Token: 0x06000D8E RID: 3470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0xC87090", Offset = "0xC87090", VA = "0xC87090")]
	private void Awake()
	{
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000168")]
	public static InterfaceProfile_Layout Active
	{
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0xC870F8", Offset = "0xC870F8", VA = "0xC870F8")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000169")]
	public static InterfaceProfile_Layout _active
	{
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0xC871C4", Offset = "0xC871C4", VA = "0xC871C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0xC87240", Offset = "0xC87240", VA = "0xC87240")]
		set
		{
		}
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0xC872C0", Offset = "0xC872C0", VA = "0xC872C0")]
	public static void LoadUIResolution()
	{
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0xC87A1C", Offset = "0xC87A1C", VA = "0xC87A1C")]
	public static void SetActiveLayout(InterfaceProfile_Layout active)
	{
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0xC88FC4", Offset = "0xC88FC4", VA = "0xC88FC4")]
	public InterfaceProfile_Layout GetDefaultProfile(string profileName)
	{
		return null;
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0xC8905C", Offset = "0xC8905C", VA = "0xC8905C")]
	public InterfaceProfile_Layout GetLegacyProfile(string profileName)
	{
		return null;
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D96")]
	[Address(RVA = "0xC890F4", Offset = "0xC890F4", VA = "0xC890F4")]
	public void SaveConfiguration()
	{
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D97")]
	[Address(RVA = "0xC89410", Offset = "0xC89410", VA = "0xC89410")]
	public void RefreshProfileNames()
	{
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D98")]
	[Address(RVA = "0xC895B8", Offset = "0xC895B8", VA = "0xC895B8")]
	public void LoadConfiguration(bool allowLoad)
	{
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D99")]
	[Address(RVA = "0xC89F14", Offset = "0xC89F14", VA = "0xC89F14")]
	public InterfaceStyles_Layout()
	{
	}

	// Token: 0x0400154E RID: 5454
	[Token(Token = "0x400154E")]
	[FieldOffset(Offset = "0x0")]
	public static InterfaceStyles_Layout Instance;

	// Token: 0x0400154F RID: 5455
	[Token(Token = "0x400154F")]
	[FieldOffset(Offset = "0x4")]
	private static List<GUIPageIcons.Category> refreshCategories;

	// Token: 0x04001550 RID: 5456
	[Token(Token = "0x4001550")]
	[FieldOffset(Offset = "0xC")]
	public InterfaceProfile_Layout[] Profiles;

	// Token: 0x04001551 RID: 5457
	[Token(Token = "0x4001551")]
	[FieldOffset(Offset = "0x10")]
	public InterfaceProfile_Layout[] CustomProfiles;

	// Token: 0x04001552 RID: 5458
	[Token(Token = "0x4001552")]
	[FieldOffset(Offset = "0x14")]
	public InterfaceProfile_Layout[] LegacyProfiles;
}
