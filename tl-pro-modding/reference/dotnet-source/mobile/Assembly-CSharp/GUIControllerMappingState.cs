using System;
using System.Collections.Generic;
using Controller;
using Il2CppDummyDll;
using Terraria.IO;

// Token: 0x02000081 RID: 129
[Token(Token = "0x2000081")]
public class GUIControllerMappingState
{
	// Token: 0x060002D3 RID: 723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xC37540", Offset = "0xC37540", VA = "0xC37540")]
	public void Clear()
	{
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00002EC8 File Offset: 0x000010C8
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xC37824", Offset = "0xC37824", VA = "0xC37824")]
	public bool IsSame(GUIControllerMappingState other)
	{
		return default(bool);
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xC37A4C", Offset = "0xC37A4C", VA = "0xC37A4C")]
	public void DisableConflictingActions(GUIControllerMappingState other)
	{
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xC37F3C", Offset = "0xC37F3C", VA = "0xC37F3C")]
	public void SetupWorldRequiredStateOverloads(GUIControllerMappingStateTable altStates)
	{
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xC396B4", Offset = "0xC396B4", VA = "0xC396B4")]
	public void Copy(GUIControllerMappingState other)
	{
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xC39838", Offset = "0xC39838", VA = "0xC39838")]
	public void LoadConfiguration(string prefix, Preferences preferences, ref bool mappingsCleared, List<ControllerActionButton> allowedButtons, List<ControllerActionAxis> allowedAxis)
	{
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xC3A0D4", Offset = "0xC3A0D4", VA = "0xC3A0D4")]
	public void TransferMapping(ControllerActionButton mapping, GUIControllerMappingState other)
	{
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xC3A238", Offset = "0xC3A238", VA = "0xC3A238")]
	public void SaveConfiguration(string prefix, Preferences preferences)
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xC3A670", Offset = "0xC3A670", VA = "0xC3A670")]
	public void SetupMappings(GUIControllerMappingStateTable altStates)
	{
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xC3B034", Offset = "0xC3B034", VA = "0xC3B034")]
	public GUIControllerMappingState()
	{
	}

	// Token: 0x0400059D RID: 1437
	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x8")]
	public ControllerActionButton.RequiredButtonState RequiredState;

	// Token: 0x0400059E RID: 1438
	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0xC")]
	public ControllerActionButton[] ButtonBindings;

	// Token: 0x0400059F RID: 1439
	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x10")]
	public ControllerActionButton[] AxisButtonBindings;

	// Token: 0x040005A0 RID: 1440
	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x14")]
	public ControllerActionAxis[] AxisBindings;
}
