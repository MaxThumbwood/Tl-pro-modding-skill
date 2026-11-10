using System;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x020001A0 RID: 416
[Token(Token = "0x20001A0")]
public class GUIKeyboardMappingEntry
{
	// Token: 0x06000C3A RID: 3130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0xC5E724", Offset = "0xC5E724", VA = "0xC5E724")]
	public GUIKeyboardMappingEntry(ControllerActionVector action, int index)
	{
	}

	// Token: 0x06000C3B RID: 3131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0xC5E980", Offset = "0xC5E980", VA = "0xC5E980")]
	public void Backup()
	{
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0xC5EA88", Offset = "0xC5EA88", VA = "0xC5EA88")]
	public void Restore()
	{
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0xC5EB88", Offset = "0xC5EB88", VA = "0xC5EB88")]
	public GUIKeyboardMappingEntry(ControllerActionButton action)
	{
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00007020 File Offset: 0x00005220
	// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000124")]
	public KeyCode Binding
	{
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0xC5E994", Offset = "0xC5E994", VA = "0xC5E994")]
		get
		{
			return KeyCode.None;
		}
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0xC5EA90", Offset = "0xC5EA90", VA = "0xC5EA90")]
		set
		{
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00007038 File Offset: 0x00005238
	[Token(Token = "0x17000125")]
	public bool HasMapping
	{
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0xC5ECEC", Offset = "0xC5ECEC", VA = "0xC5ECEC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C41")]
	[Address(RVA = "0xC5ED00", Offset = "0xC5ED00", VA = "0xC5ED00")]
	public void DrawOverlay()
	{
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C42")]
	[Address(RVA = "0xC600D0", Offset = "0xC600D0", VA = "0xC600D0")]
	public void RemoveBinding()
	{
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C43")]
	[Address(RVA = "0xC5ED24", Offset = "0xC5ED24", VA = "0xC5ED24")]
	public void Draw()
	{
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00007050 File Offset: 0x00005250
	[Token(Token = "0x6000C44")]
	[Address(RVA = "0xC606C8", Offset = "0xC606C8", VA = "0xC606C8")]
	public float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x00007068 File Offset: 0x00005268
	[Token(Token = "0x6000C45")]
	[Address(RVA = "0xC60740", Offset = "0xC60740", VA = "0xC60740")]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C46")]
	[Address(RVA = "0xC60204", Offset = "0xC60204", VA = "0xC60204")]
	private string GetTitle()
	{
		return null;
	}

	// Token: 0x04000F1B RID: 3867
	[Token(Token = "0x4000F1B")]
	[FieldOffset(Offset = "0x8")]
	private ControllerActionButton buttonAction;

	// Token: 0x04000F1C RID: 3868
	[Token(Token = "0x4000F1C")]
	[FieldOffset(Offset = "0xC")]
	private ControllerActionVector axisAction;

	// Token: 0x04000F1D RID: 3869
	[Token(Token = "0x4000F1D")]
	[FieldOffset(Offset = "0x10")]
	private int actionIndex;

	// Token: 0x04000F1E RID: 3870
	[Token(Token = "0x4000F1E")]
	[FieldOffset(Offset = "0x14")]
	private KeyCode backupBinding;

	// Token: 0x04000F1F RID: 3871
	[Token(Token = "0x4000F1F")]
	[FieldOffset(Offset = "0x18")]
	private readonly string localisationId;

	// Token: 0x04000F20 RID: 3872
	[Token(Token = "0x4000F20")]
	[FieldOffset(Offset = "0x1C")]
	private float buttonScale;

	// Token: 0x04000F21 RID: 3873
	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x20")]
	private float scale;

	// Token: 0x04000F22 RID: 3874
	[Token(Token = "0x4000F22")]
	[FieldOffset(Offset = "0x24")]
	private bool drawingOverlay;

	// Token: 0x04000F23 RID: 3875
	[Token(Token = "0x4000F23")]
	[FieldOffset(Offset = "0x0")]
	private static int LastButtonMapped;

	// Token: 0x04000F24 RID: 3876
	[Token(Token = "0x4000F24")]
	[FieldOffset(Offset = "0x4")]
	private static bool ignoreClick;

	// Token: 0x04000F25 RID: 3877
	[Token(Token = "0x4000F25")]
	[FieldOffset(Offset = "0x25")]
	public bool displayOptions;

	// Token: 0x04000F26 RID: 3878
	[Token(Token = "0x4000F26")]
	[FieldOffset(Offset = "0x28")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04000F27 RID: 3879
	[Token(Token = "0x4000F27")]
	[FieldOffset(Offset = "0x2C")]
	public KeyboardMappingsCategories_Layout.Category Category;

	// Token: 0x04000F28 RID: 3880
	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0x30")]
	public int SortOrder;
}
