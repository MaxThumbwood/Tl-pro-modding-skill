using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Il2CppDummyDll;
using Terraria.IO;

// Token: 0x02000082 RID: 130
[Token(Token = "0x2000082")]
public class GUIControllerMappingStateTable
{
	// Token: 0x060002DD RID: 733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xC3B0D4", Offset = "0xC3B0D4", VA = "0xC3B0D4")]
	public GUIControllerMappingStateTable()
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00002EE0 File Offset: 0x000010E0
	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xC38B44", Offset = "0xC38B44", VA = "0xC38B44")]
	public bool IsAnyLeftButtonConflict(Buttons button)
	{
		return default(bool);
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00002EF8 File Offset: 0x000010F8
	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xC38C4C", Offset = "0xC38C4C", VA = "0xC38C4C")]
	public bool IsAnyRightButtonConflict(Buttons button)
	{
		return default(bool);
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00002F10 File Offset: 0x00001110
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xC38D54", Offset = "0xC38D54", VA = "0xC38D54")]
	public bool IsAnyLeftAxisButtonConflict(AxisButtons button)
	{
		return default(bool);
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00002F28 File Offset: 0x00001128
	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xC38EB4", Offset = "0xC38EB4", VA = "0xC38EB4")]
	public bool IsAnyRightAxisButtonConflict(AxisButtons button)
	{
		return default(bool);
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00002F40 File Offset: 0x00001140
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xC39014", Offset = "0xC39014", VA = "0xC39014")]
	public bool IsAnyLeftAxisConflict(Axis axis)
	{
		return default(bool);
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00002F58 File Offset: 0x00001158
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xC39364", Offset = "0xC39364", VA = "0xC39364")]
	public bool IsAnyRightAxisConflict(Axis axis)
	{
		return default(bool);
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xC3B384", Offset = "0xC3B384", VA = "0xC3B384")]
	public void Backup()
	{
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xC3B3F0", Offset = "0xC3B3F0", VA = "0xC3B3F0")]
	public void RestoreBackup()
	{
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xC3B45C", Offset = "0xC3B45C", VA = "0xC3B45C")]
	public void ClearMappings()
	{
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xC3B600", Offset = "0xC3B600", VA = "0xC3B600")]
	public void LoadMappingValues()
	{
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xC3B71C", Offset = "0xC3B71C", VA = "0xC3B71C")]
	public void TransferMapping(ControllerActionButton button, GUIControllerMappingStateTable other)
	{
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xC3B7A8", Offset = "0xC3B7A8", VA = "0xC3B7A8")]
	public void SaveConfiguration(string configurationTable, Preferences preferences)
	{
	}

	// Token: 0x060002EA RID: 746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xC3B8CC", Offset = "0xC3B8CC", VA = "0xC3B8CC")]
	public void LoadConfiguration(string configurationTable, Preferences preferences, ref bool mappingsCleared, List<ControllerActionButton> allowedButtons, List<ControllerActionAxis> allowedAxis)
	{
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xC3BA28", Offset = "0xC3BA28", VA = "0xC3BA28")]
	public bool IsSame(GUIControllerMappingStateTable other)
	{
		return default(bool);
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xC3BABC", Offset = "0xC3BABC", VA = "0xC3BABC")]
	public void Copy(GUIControllerMappingStateTable other)
	{
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xC3BB38", Offset = "0xC3BB38", VA = "0xC3BB38")]
	public void SetChildState(GUIControllerMappingStateTable childState)
	{
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xC3BC04", Offset = "0xC3BC04", VA = "0xC3BC04")]
	public void DisableConflictingActions(GUIControllerMappingStateTable other, bool altDisableFaceBindings = true)
	{
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xC3BD74", Offset = "0xC3BD74", VA = "0xC3BD74")]
	public GUIControllerMappingState GetState(int stateIndex)
	{
		return null;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xC3BD98", Offset = "0xC3BD98", VA = "0xC3BD98")]
	public void ClearLinkedButtonBindings(int stateIndex, Buttons button, [Optional] List<ControllerActionButton> allowedActions)
	{
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xC3C2EC", Offset = "0xC3C2EC", VA = "0xC3C2EC")]
	public void ClearLinkedAxisBindings(int stateIndex, Axis x, Axis y, bool tableOnly = false)
	{
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xC3C908", Offset = "0xC3C908", VA = "0xC3C908")]
	public void ClearLinkedButtonBindings(int stateIndex, AxisButtons axisButton, [Optional] List<ControllerActionButton> allowedActions, bool tableOnly = false)
	{
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xC3CE50", Offset = "0xC3CE50", VA = "0xC3CE50")]
	public void RemoveButtonBindings(ControllerActionButton actionButton)
	{
	}

	// Token: 0x040005A1 RID: 1441
	[Token(Token = "0x40005A1")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public GUIControllerMappingState Normal;

	// Token: 0x040005A2 RID: 1442
	[Token(Token = "0x40005A2")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GUIControllerMappingState Left;

	// Token: 0x040005A3 RID: 1443
	[Token(Token = "0x40005A3")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GUIControllerMappingState Right;

	// Token: 0x040005A4 RID: 1444
	[Token(Token = "0x40005A4")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GUIControllerMappingState BackupNormal;

	// Token: 0x040005A5 RID: 1445
	[Token(Token = "0x40005A5")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GUIControllerMappingState BackupLeft;

	// Token: 0x040005A6 RID: 1446
	[Token(Token = "0x40005A6")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GUIControllerMappingState BackupRight;

	// Token: 0x040005A7 RID: 1447
	[Token(Token = "0x40005A7")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GUIControllerMappingStateTable LinkedChildState;

	// Token: 0x040005A8 RID: 1448
	[Token(Token = "0x40005A8")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private List<GUIControllerMappingStateTable> LinkedParentStates;
}
