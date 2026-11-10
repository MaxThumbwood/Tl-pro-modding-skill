using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Input;

// Token: 0x02000316 RID: 790
[Token(Token = "0x2000316")]
public class LocalUserXNAState
{
	// Token: 0x0600139F RID: 5023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139F")]
	[Address(RVA = "0xDA4620", Offset = "0xDA4620", VA = "0xDA4620")]
	public LocalUserXNAState()
	{
	}

	// Token: 0x0400274D RID: 10061
	[Token(Token = "0x400274D")]
	[FieldOffset(Offset = "0x0")]
	public static LocalUserXNAState Instance;

	// Token: 0x0400274E RID: 10062
	[Token(Token = "0x400274E")]
	[FieldOffset(Offset = "0x8")]
	public int scrollAccum;

	// Token: 0x0400274F RID: 10063
	[Token(Token = "0x400274F")]
	[FieldOffset(Offset = "0xC")]
	public float _uiX;

	// Token: 0x04002750 RID: 10064
	[Token(Token = "0x4002750")]
	[FieldOffset(Offset = "0x10")]
	public float _uiY;

	// Token: 0x04002751 RID: 10065
	[Token(Token = "0x4002751")]
	[FieldOffset(Offset = "0x14")]
	public float _X;

	// Token: 0x04002752 RID: 10066
	[Token(Token = "0x4002752")]
	[FieldOffset(Offset = "0x18")]
	public float _Y;

	// Token: 0x04002753 RID: 10067
	[Token(Token = "0x4002753")]
	[FieldOffset(Offset = "0x1C")]
	public float _worldScreenOffsetY;

	// Token: 0x04002754 RID: 10068
	[Token(Token = "0x4002754")]
	[FieldOffset(Offset = "0x20")]
	public int _mouseX;

	// Token: 0x04002755 RID: 10069
	[Token(Token = "0x4002755")]
	[FieldOffset(Offset = "0x24")]
	public int _mouseY;

	// Token: 0x04002756 RID: 10070
	[Token(Token = "0x4002756")]
	[FieldOffset(Offset = "0x28")]
	public int _lastMouseX;

	// Token: 0x04002757 RID: 10071
	[Token(Token = "0x4002757")]
	[FieldOffset(Offset = "0x2C")]
	public int _lastMouseY;

	// Token: 0x04002758 RID: 10072
	[Token(Token = "0x4002758")]
	[FieldOffset(Offset = "0x30")]
	public int _worldMouseX;

	// Token: 0x04002759 RID: 10073
	[Token(Token = "0x4002759")]
	[FieldOffset(Offset = "0x34")]
	public int _worldMouseY;

	// Token: 0x0400275A RID: 10074
	[Token(Token = "0x400275A")]
	[FieldOffset(Offset = "0x38")]
	public bool _mouseLeft;

	// Token: 0x0400275B RID: 10075
	[Token(Token = "0x400275B")]
	[FieldOffset(Offset = "0x39")]
	public bool _mouseRight;

	// Token: 0x0400275C RID: 10076
	[Token(Token = "0x400275C")]
	[FieldOffset(Offset = "0x3A")]
	public bool _mouseLeftRelease;

	// Token: 0x0400275D RID: 10077
	[Token(Token = "0x400275D")]
	[FieldOffset(Offset = "0x3B")]
	public bool _mouseRightRelease;

	// Token: 0x0400275E RID: 10078
	[Token(Token = "0x400275E")]
	[FieldOffset(Offset = "0x3C")]
	public int _overloadScreenWidth;

	// Token: 0x0400275F RID: 10079
	[Token(Token = "0x400275F")]
	[FieldOffset(Offset = "0x40")]
	public int _overloadScreenHeight;

	// Token: 0x04002760 RID: 10080
	[Token(Token = "0x4002760")]
	[FieldOffset(Offset = "0x44")]
	public int _overloadScreenOffsetX;

	// Token: 0x04002761 RID: 10081
	[Token(Token = "0x4002761")]
	[FieldOffset(Offset = "0x48")]
	public int _overloadScreenOffsetY;

	// Token: 0x04002762 RID: 10082
	[Token(Token = "0x4002762")]
	[FieldOffset(Offset = "0x4C")]
	public Mouse.OverrideState _virtualCursorOverride;

	// Token: 0x04002763 RID: 10083
	[Token(Token = "0x4002763")]
	[FieldOffset(Offset = "0x50")]
	public ButtonState _virtualCursorOverrideState;

	// Token: 0x04002764 RID: 10084
	[Token(Token = "0x4002764")]
	[FieldOffset(Offset = "0x54")]
	public float _virtualCursorOverrideX;

	// Token: 0x04002765 RID: 10085
	[Token(Token = "0x4002765")]
	[FieldOffset(Offset = "0x58")]
	public float _virtualCursorOverrideY;

	// Token: 0x04002766 RID: 10086
	[Token(Token = "0x4002766")]
	[FieldOffset(Offset = "0x5C")]
	public bool _overrideRMB;

	// Token: 0x04002767 RID: 10087
	[Token(Token = "0x4002767")]
	[FieldOffset(Offset = "0x60")]
	public ButtonState _rmbOverrideState;

	// Token: 0x04002768 RID: 10088
	[Token(Token = "0x4002768")]
	[FieldOffset(Offset = "0x64")]
	public float scrollAccumPartial;

	// Token: 0x04002769 RID: 10089
	[Token(Token = "0x4002769")]
	[FieldOffset(Offset = "0x68")]
	public XNAUnityRunner.MouseStateBackup _uiMouseState;

	// Token: 0x0400276A RID: 10090
	[Token(Token = "0x400276A")]
	[FieldOffset(Offset = "0x6C")]
	public XNAUnityRunner.MouseStateBackup _worldMouseState;

	// Token: 0x0400276B RID: 10091
	[Token(Token = "0x400276B")]
	[FieldOffset(Offset = "0x70")]
	public int _lastUIFrame;
}
