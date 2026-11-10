using System;
using System.Collections.Generic;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x02000290 RID: 656
[Token(Token = "0x2000290")]
public class GUIInterfaceEdit
{
	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00007BD8 File Offset: 0x00005DD8
	[Token(Token = "0x1700018D")]
	public bool InInputWorld
	{
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0xCB1E2C", Offset = "0xCB1E2C", VA = "0xCB1E2C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00007BF0 File Offset: 0x00005DF0
	[Token(Token = "0x1700018E")]
	public bool InTestMode
	{
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0xCB1F2C", Offset = "0xCB1F2C", VA = "0xCB1F2C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F49")]
	[Address(RVA = "0xCB1FD4", Offset = "0xCB1FD4", VA = "0xCB1FD4")]
	public void Draw()
	{
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x00007C08 File Offset: 0x00005E08
	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0xCB68B4", Offset = "0xCB68B4", VA = "0xCB68B4")]
	private bool CanSpawn(List<GUIPageIconGrouping> groups, List<GUIPageIconGrouping> otherGroups, bool left, out Microsoft.Xna.Framework.Vector2 position)
	{
		return default(bool);
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00007C20 File Offset: 0x00005E20
	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0xCB7020", Offset = "0xCB7020", VA = "0xCB7020")]
	private bool FindSpaceToSpawn(out Microsoft.Xna.Framework.Vector2 position, out bool left)
	{
		return default(bool);
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00007C38 File Offset: 0x00005E38
	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0xCB7284", Offset = "0xCB7284", VA = "0xCB7284")]
	public int SortGroupByPosition(GUIPageIconGrouping x, GUIPageIconGrouping y)
	{
		return 0;
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x00007C50 File Offset: 0x00005E50
	[Token(Token = "0x6000F4D")]
	[Address(RVA = "0xCB737C", Offset = "0xCB737C", VA = "0xCB737C")]
	private float PageScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0xCB7384", Offset = "0xCB7384", VA = "0xCB7384")]
	private void PageOver(int index)
	{
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00007C68 File Offset: 0x00005E68
	[Token(Token = "0x6000F4F")]
	[Address(RVA = "0xCB770C", Offset = "0xCB770C", VA = "0xCB770C")]
	public Microsoft.Xna.Framework.Vector2 ItemSize(int index)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F50")]
	[Address(RVA = "0xCB7884", Offset = "0xCB7884", VA = "0xCB7884")]
	private void PageIconDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F51")]
	[Address(RVA = "0xCB7AB8", Offset = "0xCB7AB8", VA = "0xCB7AB8")]
	private void PageIconOver(int index)
	{
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x00007C80 File Offset: 0x00005E80
	[Token(Token = "0x6000F52")]
	[Address(RVA = "0xCB7ABC", Offset = "0xCB7ABC", VA = "0xCB7ABC")]
	private float PageIconScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x00007C98 File Offset: 0x00005E98
	[Token(Token = "0x6000F53")]
	[Address(RVA = "0xCB7AC4", Offset = "0xCB7AC4", VA = "0xCB7AC4")]
	private bool LoadSettingAnchor(GUIPageIconGrouping.SettingCategory category, ref Rectangle itemRegion)
	{
		return default(bool);
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F54")]
	[Address(RVA = "0xCB7D50", Offset = "0xCB7D50", VA = "0xCB7D50")]
	private void PageDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00007CB0 File Offset: 0x00005EB0
	[Token(Token = "0x6000F55")]
	[Address(RVA = "0xCB8AB8", Offset = "0xCB8AB8", VA = "0xCB8AB8")]
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F56")]
	[Address(RVA = "0xCB8B14", Offset = "0xCB8B14", VA = "0xCB8B14")]
	public void RefreshSelected()
	{
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F57")]
	[Address(RVA = "0xCB3744", Offset = "0xCB3744", VA = "0xCB3744")]
	private void DrawPgeGroups()
	{
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F58")]
	[Address(RVA = "0xCB4938", Offset = "0xCB4938", VA = "0xCB4938")]
	private void DrawGroupEditControls()
	{
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F59")]
	[Address(RVA = "0xCB5E64", Offset = "0xCB5E64", VA = "0xCB5E64")]
	private void DrawSafeRegionOptions()
	{
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00007CC8 File Offset: 0x00005EC8
	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0xCB91AC", Offset = "0xCB91AC", VA = "0xCB91AC")]
	private bool CanApply()
	{
		return default(bool);
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0xCB3C6C", Offset = "0xCB3C6C", VA = "0xCB3C6C")]
	private void DrawOptions()
	{
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0xCB6248", Offset = "0xCB6248", VA = "0xCB6248")]
	private void DrawControlsOptions()
	{
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0xCB6704", Offset = "0xCB6704", VA = "0xCB6704")]
	public void CancelChanges()
	{
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0xCB9730", Offset = "0xCB9730", VA = "0xCB9730")]
	public void ClampUIScale()
	{
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0xCB99C0", Offset = "0xCB99C0", VA = "0xCB99C0")]
	private string GetDisplayName(InterfaceProfile_Layout profile, float maxWidth, bool isTemplate)
	{
		return null;
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00007CE0 File Offset: 0x00005EE0
	[Token(Token = "0x6000F60")]
	[Address(RVA = "0xCB9C60", Offset = "0xCB9C60", VA = "0xCB9C60")]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F61")]
	[Address(RVA = "0xCB6698", Offset = "0xCB6698", VA = "0xCB6698")]
	public void CloseNameEdit()
	{
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F62")]
	[Address(RVA = "0xCB6598", Offset = "0xCB6598", VA = "0xCB6598")]
	public void CloseProfileOptions()
	{
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F63")]
	[Address(RVA = "0xCB6618", Offset = "0xCB6618", VA = "0xCB6618")]
	public void CloseTemplateOptions()
	{
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F64")]
	[Address(RVA = "0xCB9DF4", Offset = "0xCB9DF4", VA = "0xCB9DF4")]
	private void DrawProfile()
	{
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F65")]
	[Address(RVA = "0xCBB61C", Offset = "0xCBB61C", VA = "0xCBB61C")]
	private void RefreshTemplate()
	{
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F66")]
	[Address(RVA = "0xCBB7A4", Offset = "0xCBB7A4", VA = "0xCBB7A4")]
	public void EnsureSelectedGroupVisible()
	{
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F67")]
	[Address(RVA = "0xCBBA6C", Offset = "0xCBBA6C", VA = "0xCBBA6C")]
	private void DrawTemplate()
	{
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F68")]
	[Address(RVA = "0xCB5D24", Offset = "0xCB5D24", VA = "0xCB5D24")]
	public void DrawWidgetOverlays()
	{
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F69")]
	[Address(RVA = "0xCB3FC0", Offset = "0xCB3FC0", VA = "0xCB3FC0")]
	private void DrawUITweaks()
	{
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0xCBD33C", Offset = "0xCBD33C", VA = "0xCBD33C")]
	public void Backup()
	{
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0xCBDB98", Offset = "0xCBDB98", VA = "0xCBDB98")]
	public void CopyProfile()
	{
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0xCBDC8C", Offset = "0xCBDC8C", VA = "0xCBDC8C")]
	public void PasteProfile()
	{
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0xCBD7EC", Offset = "0xCBD7EC", VA = "0xCBD7EC")]
	public void AddControlUndo()
	{
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00007CF8 File Offset: 0x00005EF8
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0xCBDE98", Offset = "0xCBDE98", VA = "0xCBDE98")]
	public bool HasUndo()
	{
		return default(bool);
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0xCBE034", Offset = "0xCBE034", VA = "0xCBE034")]
	public void ControlUndo()
	{
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00007D10 File Offset: 0x00005F10
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0xCBE508", Offset = "0xCBE508", VA = "0xCBE508")]
	public bool HasRedo()
	{
		return default(bool);
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0xCBE564", Offset = "0xCBE564", VA = "0xCBE564")]
	public void ControlRedo()
	{
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0xCBE8E8", Offset = "0xCBE8E8", VA = "0xCBE8E8")]
	public void ClearControlRedo()
	{
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F73")]
	[Address(RVA = "0xCB90E8", Offset = "0xCB90E8", VA = "0xCB90E8")]
	public void ClearControlUndoRedo()
	{
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0xCBEA10", Offset = "0xCBEA10", VA = "0xCBEA10")]
	public void LoadDefaultProfilePositions()
	{
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F75")]
	[Address(RVA = "0xCB8DF4", Offset = "0xCB8DF4", VA = "0xCB8DF4")]
	public void RestoreDefaults()
	{
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0xCBEB7C", Offset = "0xCBEB7C", VA = "0xCBEB7C")]
	public void UpdateControlsRegions()
	{
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F77")]
	[Address(RVA = "0xCBEBA0", Offset = "0xCBEBA0", VA = "0xCBEBA0")]
	private void BuildControlsRegion(out Rectangle region, ControlAnchor.ControlId anchor)
	{
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F78")]
	[Address(RVA = "0xCBF344", Offset = "0xCBF344", VA = "0xCBF344")]
	public void BackupControlsPosition()
	{
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F79")]
	[Address(RVA = "0xCBF3A0", Offset = "0xCBF3A0", VA = "0xCBF3A0")]
	public void RestoreControlPositionBackup()
	{
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0xCB91B4", Offset = "0xCB91B4", VA = "0xCB91B4")]
	public void RestoreBackup()
	{
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F7B")]
	[Address(RVA = "0xCBF3CC", Offset = "0xCBF3CC", VA = "0xCBF3CC")]
	public GUIInterfaceEdit()
	{
	}

	// Token: 0x04001F55 RID: 8021
	[Token(Token = "0x4001F55")]
	[FieldOffset(Offset = "0x8")]
	public GUIInterfaceEdit.EditMode Mode;

	// Token: 0x04001F56 RID: 8022
	[Token(Token = "0x4001F56")]
	[FieldOffset(Offset = "0xC")]
	public bool Enabled;

	// Token: 0x04001F57 RID: 8023
	[Token(Token = "0x4001F57")]
	[FieldOffset(Offset = "0x10")]
	public GUIControllerInterfaceEdit _controller;

	// Token: 0x04001F58 RID: 8024
	[Token(Token = "0x4001F58")]
	[FieldOffset(Offset = "0x14")]
	private int cachedResolutionX;

	// Token: 0x04001F59 RID: 8025
	[Token(Token = "0x4001F59")]
	[FieldOffset(Offset = "0x18")]
	private int cachedResolutionY;

	// Token: 0x04001F5A RID: 8026
	[Token(Token = "0x4001F5A")]
	[FieldOffset(Offset = "0x1C")]
	public bool FromPauseMenu;

	// Token: 0x04001F5B RID: 8027
	[Token(Token = "0x4001F5B")]
	[FieldOffset(Offset = "0x1D")]
	public bool FromConfigPopup;

	// Token: 0x04001F5C RID: 8028
	[Token(Token = "0x4001F5C")]
	[FieldOffset(Offset = "0x20")]
	private float InterfacePositionScale;

	// Token: 0x04001F5D RID: 8029
	[Token(Token = "0x4001F5D")]
	[FieldOffset(Offset = "0x24")]
	private float ControlsPositionScale;

	// Token: 0x04001F5E RID: 8030
	[Token(Token = "0x4001F5E")]
	[FieldOffset(Offset = "0x28")]
	private float SafeRegionScale;

	// Token: 0x04001F5F RID: 8031
	[Token(Token = "0x4001F5F")]
	[FieldOffset(Offset = "0x2C")]
	private float EditControlScale;

	// Token: 0x04001F60 RID: 8032
	[Token(Token = "0x4001F60")]
	[FieldOffset(Offset = "0x30")]
	private float TitleScale;

	// Token: 0x04001F61 RID: 8033
	[Token(Token = "0x4001F61")]
	[FieldOffset(Offset = "0x34")]
	private float defaultsScale;

	// Token: 0x04001F62 RID: 8034
	[Token(Token = "0x4001F62")]
	[FieldOffset(Offset = "0x38")]
	private float finishScale;

	// Token: 0x04001F63 RID: 8035
	[Token(Token = "0x4001F63")]
	[FieldOffset(Offset = "0x3C")]
	private float resetScale;

	// Token: 0x04001F64 RID: 8036
	[Token(Token = "0x4001F64")]
	[FieldOffset(Offset = "0x40")]
	public float ScrollOffset;

	// Token: 0x04001F65 RID: 8037
	[Token(Token = "0x4001F65")]
	[FieldOffset(Offset = "0x44")]
	private float ScrollMomentum;

	// Token: 0x04001F66 RID: 8038
	[Token(Token = "0x4001F66")]
	[FieldOffset(Offset = "0x48")]
	private int ScrollDragging;

	// Token: 0x04001F67 RID: 8039
	[Token(Token = "0x4001F67")]
	[FieldOffset(Offset = "0x4C")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x04001F68 RID: 8040
	[Token(Token = "0x4001F68")]
	[FieldOffset(Offset = "0x54")]
	private int _groupCount;

	// Token: 0x04001F69 RID: 8041
	[Token(Token = "0x4001F69")]
	[FieldOffset(Offset = "0x58")]
	private int pageOver;

	// Token: 0x04001F6A RID: 8042
	[Token(Token = "0x4001F6A")]
	[FieldOffset(Offset = "0x5C")]
	private Rectangle NewItemtemRegion;

	// Token: 0x04001F6B RID: 8043
	[Token(Token = "0x4001F6B")]
	[FieldOffset(Offset = "0x6C")]
	private Rectangle SelectedItemRegion;

	// Token: 0x04001F6C RID: 8044
	[Token(Token = "0x4001F6C")]
	[FieldOffset(Offset = "0x7C")]
	public int SelectedItem;

	// Token: 0x04001F6D RID: 8045
	[Token(Token = "0x4001F6D")]
	[FieldOffset(Offset = "0x80")]
	private GUIPageIconGrouping currentGroup;

	// Token: 0x04001F6E RID: 8046
	[Token(Token = "0x4001F6E")]
	[FieldOffset(Offset = "0x84")]
	private Microsoft.Xna.Framework.Vector2 pageButtonRegionSize;

	// Token: 0x04001F6F RID: 8047
	[Token(Token = "0x4001F6F")]
	[FieldOffset(Offset = "0x8C")]
	private Rectangle fullClipRegion;

	// Token: 0x04001F70 RID: 8048
	[Token(Token = "0x4001F70")]
	[FieldOffset(Offset = "0x9C")]
	private Rectangle dragClipRegion;

	// Token: 0x04001F71 RID: 8049
	[Token(Token = "0x4001F71")]
	[FieldOffset(Offset = "0xAC")]
	public bool CanSpawnState;

	// Token: 0x04001F72 RID: 8050
	[Token(Token = "0x4001F72")]
	[FieldOffset(Offset = "0xB0")]
	private float SideControls;

	// Token: 0x04001F73 RID: 8051
	[Token(Token = "0x4001F73")]
	[FieldOffset(Offset = "0xB4")]
	private float TopControls;

	// Token: 0x04001F74 RID: 8052
	[Token(Token = "0x4001F74")]
	[FieldOffset(Offset = "0xB8")]
	private float BottomControls;

	// Token: 0x04001F75 RID: 8053
	[Token(Token = "0x4001F75")]
	[FieldOffset(Offset = "0xBC")]
	private GUISlider.DragState dragState;

	// Token: 0x04001F76 RID: 8054
	[Token(Token = "0x4001F76")]
	[FieldOffset(Offset = "0xC0")]
	private float uiScale;

	// Token: 0x04001F77 RID: 8055
	[Token(Token = "0x4001F77")]
	[FieldOffset(Offset = "0xC4")]
	private float EditGroupsScale;

	// Token: 0x04001F78 RID: 8056
	[Token(Token = "0x4001F78")]
	[FieldOffset(Offset = "0xC8")]
	private global::UnityEngine.Vector2 lastCursorPosition;

	// Token: 0x04001F79 RID: 8057
	[Token(Token = "0x4001F79")]
	[FieldOffset(Offset = "0xD0")]
	private int lastDirection;

	// Token: 0x04001F7A RID: 8058
	[Token(Token = "0x4001F7A")]
	[FieldOffset(Offset = "0xD4")]
	public bool editingName;

	// Token: 0x04001F7B RID: 8059
	[Token(Token = "0x4001F7B")]
	[FieldOffset(Offset = "0xD8")]
	private string editNameValue;

	// Token: 0x04001F7C RID: 8060
	[Token(Token = "0x4001F7C")]
	[FieldOffset(Offset = "0xDC")]
	private int textBlinkerCount;

	// Token: 0x04001F7D RID: 8061
	[Token(Token = "0x4001F7D")]
	[FieldOffset(Offset = "0xE0")]
	private int textBlinkerState;

	// Token: 0x04001F7E RID: 8062
	[Token(Token = "0x4001F7E")]
	[FieldOffset(Offset = "0xE4")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04001F7F RID: 8063
	[Token(Token = "0x4001F7F")]
	[FieldOffset(Offset = "0xE8")]
	public bool displayProfileOptions;

	// Token: 0x04001F80 RID: 8064
	[Token(Token = "0x4001F80")]
	[FieldOffset(Offset = "0xE9")]
	private bool drawnProfileOptions;

	// Token: 0x04001F81 RID: 8065
	[Token(Token = "0x4001F81")]
	[FieldOffset(Offset = "0xEC")]
	private float ProfileScale;

	// Token: 0x04001F82 RID: 8066
	[Token(Token = "0x4001F82")]
	[FieldOffset(Offset = "0xF0")]
	private float ProfileRenameScale;

	// Token: 0x04001F83 RID: 8067
	[Token(Token = "0x4001F83")]
	[FieldOffset(Offset = "0xF4")]
	private float Profile1Scale;

	// Token: 0x04001F84 RID: 8068
	[Token(Token = "0x4001F84")]
	[FieldOffset(Offset = "0xF8")]
	private float Profile2Scale;

	// Token: 0x04001F85 RID: 8069
	[Token(Token = "0x4001F85")]
	[FieldOffset(Offset = "0xFC")]
	private float Profile3Scale;

	// Token: 0x04001F86 RID: 8070
	[Token(Token = "0x4001F86")]
	[FieldOffset(Offset = "0x100")]
	private float Profile4Scale;

	// Token: 0x04001F87 RID: 8071
	[Token(Token = "0x4001F87")]
	[FieldOffset(Offset = "0x104")]
	public bool displayTemplateOptions;

	// Token: 0x04001F88 RID: 8072
	[Token(Token = "0x4001F88")]
	[FieldOffset(Offset = "0x105")]
	private bool drawnTemplateOptions;

	// Token: 0x04001F89 RID: 8073
	[Token(Token = "0x4001F89")]
	[FieldOffset(Offset = "0x108")]
	private float TemplateScale;

	// Token: 0x04001F8A RID: 8074
	[Token(Token = "0x4001F8A")]
	[FieldOffset(Offset = "0x10C")]
	private float Template1Scale;

	// Token: 0x04001F8B RID: 8075
	[Token(Token = "0x4001F8B")]
	[FieldOffset(Offset = "0x110")]
	private float Template2Scale;

	// Token: 0x04001F8C RID: 8076
	[Token(Token = "0x4001F8C")]
	[FieldOffset(Offset = "0x114")]
	private float Template3Scale;

	// Token: 0x04001F8D RID: 8077
	[Token(Token = "0x4001F8D")]
	[FieldOffset(Offset = "0x118")]
	private float Template4Scale;

	// Token: 0x04001F8E RID: 8078
	[Token(Token = "0x4001F8E")]
	[FieldOffset(Offset = "0x11C")]
	private float Template5Scale;

	// Token: 0x04001F8F RID: 8079
	[Token(Token = "0x4001F8F")]
	[FieldOffset(Offset = "0x120")]
	private bool selectedCustom;

	// Token: 0x04001F90 RID: 8080
	[Token(Token = "0x4001F90")]
	[FieldOffset(Offset = "0x124")]
	private InterfaceProfile_Layout currentProfile;

	// Token: 0x04001F91 RID: 8081
	[Token(Token = "0x4001F91")]
	[FieldOffset(Offset = "0x128")]
	public float _pulldownShift;

	// Token: 0x04001F92 RID: 8082
	[Token(Token = "0x4001F92")]
	[FieldOffset(Offset = "0x12C")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware1;

	// Token: 0x04001F93 RID: 8083
	[Token(Token = "0x4001F93")]
	[FieldOffset(Offset = "0x130")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware2;

	// Token: 0x04001F94 RID: 8084
	[Token(Token = "0x4001F94")]
	[FieldOffset(Offset = "0x134")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware3;

	// Token: 0x04001F95 RID: 8085
	[Token(Token = "0x4001F95")]
	[FieldOffset(Offset = "0x138")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware4;

	// Token: 0x04001F96 RID: 8086
	[Token(Token = "0x4001F96")]
	[FieldOffset(Offset = "0x13C")]
	private VirtualControlsProfile_Layout BackupProfile1;

	// Token: 0x04001F97 RID: 8087
	[Token(Token = "0x4001F97")]
	[FieldOffset(Offset = "0x140")]
	private VirtualControlsProfile_Layout BackupProfile2;

	// Token: 0x04001F98 RID: 8088
	[Token(Token = "0x4001F98")]
	[FieldOffset(Offset = "0x144")]
	private VirtualControlsProfile_Layout BackupProfile3;

	// Token: 0x04001F99 RID: 8089
	[Token(Token = "0x4001F99")]
	[FieldOffset(Offset = "0x148")]
	private VirtualControlsProfile_Layout BackupProfile4;

	// Token: 0x04001F9A RID: 8090
	[Token(Token = "0x4001F9A")]
	[FieldOffset(Offset = "0x14C")]
	private VirtualControlsProfile_Layout BackupActiveProfile;

	// Token: 0x04001F9B RID: 8091
	[Token(Token = "0x4001F9B")]
	[FieldOffset(Offset = "0x150")]
	private Microsoft.Xna.Framework.Vector2 backupLeftPosition;

	// Token: 0x04001F9C RID: 8092
	[Token(Token = "0x4001F9C")]
	[FieldOffset(Offset = "0x158")]
	private Microsoft.Xna.Framework.Vector2 backupRightPosition;

	// Token: 0x04001F9D RID: 8093
	[Token(Token = "0x4001F9D")]
	[FieldOffset(Offset = "0x160")]
	private Rect backupSafeRegion;

	// Token: 0x04001F9E RID: 8094
	[Token(Token = "0x4001F9E")]
	[FieldOffset(Offset = "0x170")]
	private bool backupVPPIOverride;

	// Token: 0x04001F9F RID: 8095
	[Token(Token = "0x4001F9F")]
	[FieldOffset(Offset = "0x174")]
	private float backupVPPI;

	// Token: 0x04001FA0 RID: 8096
	[Token(Token = "0x4001FA0")]
	[FieldOffset(Offset = "0x178")]
	private InterfaceProfile_Layout BackupInterfaceProfile;

	// Token: 0x04001FA1 RID: 8097
	[Token(Token = "0x4001FA1")]
	[FieldOffset(Offset = "0x17C")]
	private int SelectedSlot;

	// Token: 0x04001FA2 RID: 8098
	[Token(Token = "0x4001FA2")]
	[FieldOffset(Offset = "0x180")]
	private List<GUIInterfaceEdit.BackupResotrePoint> RestorePoints;

	// Token: 0x04001FA3 RID: 8099
	[Token(Token = "0x4001FA3")]
	[FieldOffset(Offset = "0x184")]
	private List<GUIInterfaceEdit.BackupResotrePoint> RedoPoints;

	// Token: 0x04001FA4 RID: 8100
	[Token(Token = "0x4001FA4")]
	[FieldOffset(Offset = "0x188")]
	public GUIInterfaceEdit.BackupResotrePoint ClipboardProfile;

	// Token: 0x04001FA5 RID: 8101
	[Token(Token = "0x4001FA5")]
	[FieldOffset(Offset = "0x18C")]
	public Rectangle LeftControlsRegion;

	// Token: 0x04001FA6 RID: 8102
	[Token(Token = "0x4001FA6")]
	[FieldOffset(Offset = "0x19C")]
	public Rectangle RightControlsRegion;

	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	public enum EditMode
	{
		// Token: 0x04001FA8 RID: 8104
		[Token(Token = "0x4001FA8")]
		SafeRegion,
		// Token: 0x04001FA9 RID: 8105
		[Token(Token = "0x4001FA9")]
		InterfacePosition,
		// Token: 0x04001FAA RID: 8106
		[Token(Token = "0x4001FAA")]
		InterfacePositionAdjust,
		// Token: 0x04001FAB RID: 8107
		[Token(Token = "0x4001FAB")]
		EditControls,
		// Token: 0x04001FAC RID: 8108
		[Token(Token = "0x4001FAC")]
		PlayControls,
		// Token: 0x04001FAD RID: 8109
		[Token(Token = "0x4001FAD")]
		AdjustControls
	}

	// Token: 0x02000292 RID: 658
	[Token(Token = "0x2000292")]
	public class BackupResotrePoint
	{
		// Token: 0x06000F7C RID: 3964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0xCBF748", Offset = "0xCBF748", VA = "0xCBF748")]
		public BackupResotrePoint(VirtualControlsHardwareConfiguration_Layout hardware, VirtualControlsProfile_Layout profile)
		{
		}

		// Token: 0x04001FAE RID: 8110
		[Token(Token = "0x4001FAE")]
		[FieldOffset(Offset = "0x8")]
		public VirtualControlsHardwareConfiguration_Layout Hardware;

		// Token: 0x04001FAF RID: 8111
		[Token(Token = "0x4001FAF")]
		[FieldOffset(Offset = "0xC")]
		public VirtualControlsProfile_Layout Profile;
	}

	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	private sealed class <>c__DisplayClass98_0
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0xCBF864", Offset = "0xCBF864", VA = "0xCBF864")]
		public <>c__DisplayClass98_0()
		{
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0xCBF86C", Offset = "0xCBF86C", VA = "0xCBF86C")]
		internal void <DrawUITweaks>b__0()
		{
		}

		// Token: 0x04001FB0 RID: 8112
		[Token(Token = "0x4001FB0")]
		[FieldOffset(Offset = "0x8")]
		public int resolution;
	}
}
