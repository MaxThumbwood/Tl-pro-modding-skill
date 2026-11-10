using System;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000079 RID: 121
[Token(Token = "0x2000079")]
public class GUIControllerMappingEntry : GUIControllerMappingEntryBase
{
	// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000293")]
	[Address(RVA = "0x4B85BC", Offset = "0x4B85BC", VA = "0x4B85BC")]
	public GUIControllerMappingEntry(ControllerActionVector action, GUIControllerMappingStateTable table)
	{
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000294")]
	[Address(RVA = "0x4B8694", Offset = "0x4B8694", VA = "0x4B8694")]
	public GUIControllerMappingEntry(ControllerActionButton buttonMapping, GUIControllerMappingStateTable table)
	{
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000295 RID: 661 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x1700007B")]
	public bool HasMapping
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x4B8764", Offset = "0x4B8764", VA = "0x4B8764")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x4B8794", Offset = "0x4B8794", VA = "0x4B8794", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x4B87C4", Offset = "0x4B87C4", VA = "0x4B87C4")]
	public void RemoveBinding()
	{
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x4B8810", Offset = "0x4B8810", VA = "0x4B8810")]
	private void RemoveAxisBindings(ControllerActionVector actionAxis)
	{
	}

	// Token: 0x06000299 RID: 665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x4B8A64", Offset = "0x4B8A64", VA = "0x4B8A64")]
	private void RebindAxis(ControllerActionVector actionAxis, Axis x, Axis y, int stateIndex)
	{
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029A")]
	[Address(RVA = "0x4B8DA8", Offset = "0x4B8DA8", VA = "0x4B8DA8")]
	private void RebindButton(ControllerActionButton actionButton, AxisButtons axisButton, int stateIndex)
	{
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x4B9F7C", Offset = "0x4B9F7C", VA = "0x4B9F7C")]
	private void RebindButton(ControllerActionButton actionButton, Buttons axisButton, int stateIndex)
	{
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x4BAFB8", Offset = "0x4BAFB8", VA = "0x4BAFB8", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00002DD8 File Offset: 0x00000FD8
	[Token(Token = "0x600029D")]
	[Address(RVA = "0x4BD0A0", Offset = "0x4BD0A0", VA = "0x4BD0A0", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x600029E")]
	[Address(RVA = "0x4BD118", Offset = "0x4BD118", VA = "0x4BD118")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x4BC7B4", Offset = "0x4BC7B4", VA = "0x4BC7B4")]
	private string GetTitle()
	{
		return null;
	}

	// Token: 0x040004AF RID: 1199
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x1C")]
	private GUIControllerMappingStateTable Table;

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0x20")]
	private ControllerActionVector vector;

	// Token: 0x040004B1 RID: 1201
	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x24")]
	private ControllerActionButton button;

	// Token: 0x040004B2 RID: 1202
	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x28")]
	private GUIControllerMappingState _state;

	// Token: 0x040004B3 RID: 1203
	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x2C")]
	private float buttonScale;

	// Token: 0x040004B4 RID: 1204
	[Token(Token = "0x40004B4")]
	[FieldOffset(Offset = "0x30")]
	private float scale;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x34")]
	private bool drawingOverlay;

	// Token: 0x040004B6 RID: 1206
	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x0")]
	private static int LastButtonMapped;

	// Token: 0x040004B7 RID: 1207
	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x35")]
	public bool displayOptions;

	// Token: 0x040004B8 RID: 1208
	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x38")]
	private GUIInputRegionExclusive _optionsBlocker;
}
