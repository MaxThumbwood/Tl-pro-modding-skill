using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001E2 RID: 482
[Token(Token = "0x20001E2")]
public class ControlsBanner_Layout : LayoutDefinition
{
	// Token: 0x06000D2E RID: 3374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0xC7ACDC", Offset = "0xC7ACDC", VA = "0xC7ACDC")]
	private void Awake()
	{
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x00007530 File Offset: 0x00005730
	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0xC7AEA4", Offset = "0xC7AEA4", VA = "0xC7AEA4")]
	public int GetMappingPriority(string id)
	{
		return 0;
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D30")]
	[Address(RVA = "0xC7B07C", Offset = "0xC7B07C", VA = "0xC7B07C")]
	public ControlsBanner_Layout()
	{
	}

	// Token: 0x0400139B RID: 5019
	[Token(Token = "0x400139B")]
	[FieldOffset(Offset = "0x0")]
	public static ControlsBanner_Layout Current;

	// Token: 0x0400139C RID: 5020
	[Token(Token = "0x400139C")]
	[FieldOffset(Offset = "0x4")]
	public static ControlsBanner_Layout Instance;

	// Token: 0x0400139D RID: 5021
	[Token(Token = "0x400139D")]
	[FieldOffset(Offset = "0x8")]
	public static ControlsBanner_Layout LeftPageExpanded;

	// Token: 0x0400139E RID: 5022
	[Token(Token = "0x400139E")]
	[FieldOffset(Offset = "0xC")]
	public static ControlsBanner_Layout LeftPageCollapsed;

	// Token: 0x0400139F RID: 5023
	[Token(Token = "0x400139F")]
	[FieldOffset(Offset = "0x10")]
	public static ControlsBanner_Layout RightPageExpanded;

	// Token: 0x040013A0 RID: 5024
	[Token(Token = "0x40013A0")]
	[FieldOffset(Offset = "0x14")]
	public static ControlsBanner_Layout RightPageCollapsed;

	// Token: 0x040013A1 RID: 5025
	[Token(Token = "0x40013A1")]
	[FieldOffset(Offset = "0xC")]
	public ControlsBanner_Layout.PriorityMappings MappingPriority;

	// Token: 0x040013A2 RID: 5026
	[Token(Token = "0x40013A2")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 LineOffset;

	// Token: 0x040013A3 RID: 5027
	[Token(Token = "0x40013A3")]
	[FieldOffset(Offset = "0x18")]
	public int MaxLines;

	// Token: 0x040013A4 RID: 5028
	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0x1C")]
	public bool ControlMappingLast;

	// Token: 0x040013A5 RID: 5029
	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0x20")]
	public String_Layout ActionDisplay;

	// Token: 0x040013A6 RID: 5030
	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout PageToolBannerDisplay;

	// Token: 0x040013A7 RID: 5031
	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 PageToolBackingOffset_TL;

	// Token: 0x040013A8 RID: 5032
	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 PageToolBackingOffset_BR;

	// Token: 0x040013A9 RID: 5033
	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout PageToolBacking;

	// Token: 0x040013AA RID: 5034
	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0x3C")]
	public String_Layout StatusBannerDisplay;

	// Token: 0x040013AB RID: 5035
	[Token(Token = "0x40013AB")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 StatusBackingOffset_TL;

	// Token: 0x040013AC RID: 5036
	[Token(Token = "0x40013AC")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 StatusBackingOffset_BR;

	// Token: 0x040013AD RID: 5037
	[Token(Token = "0x40013AD")]
	[FieldOffset(Offset = "0x50")]
	public Panel_Layout StatusBacking;

	// Token: 0x040013AE RID: 5038
	[Token(Token = "0x40013AE")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 BackingOffset_TL;

	// Token: 0x040013AF RID: 5039
	[Token(Token = "0x40013AF")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2 BackingOffset_BR;

	// Token: 0x040013B0 RID: 5040
	[Token(Token = "0x40013B0")]
	[FieldOffset(Offset = "0x64")]
	public Panel_Layout Backing;

	// Token: 0x040013B1 RID: 5041
	[Token(Token = "0x40013B1")]
	[FieldOffset(Offset = "0x68")]
	public int ScreenEdgeAmount;

	// Token: 0x040013B2 RID: 5042
	[Token(Token = "0x40013B2")]
	[FieldOffset(Offset = "0x6C")]
	public int MaxWidth;

	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	[Serializable]
	public class PriorityMappings
	{
		// Token: 0x06000D31 RID: 3377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0xC7B0E4", Offset = "0xC7B0E4", VA = "0xC7B0E4")]
		public PriorityMappings()
		{
		}

		// Token: 0x040013B3 RID: 5043
		[Token(Token = "0x40013B3")]
		[FieldOffset(Offset = "0x8")]
		public List<string> Ids;
	}
}
