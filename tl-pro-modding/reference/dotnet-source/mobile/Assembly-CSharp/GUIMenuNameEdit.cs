using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200029A RID: 666
[Token(Token = "0x200029A")]
public class GUIMenuNameEdit
{
	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00007D58 File Offset: 0x00005F58
	// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000190")]
	public bool Enabled
	{
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0xCC5E58", Offset = "0xCC5E58", VA = "0xCC5E58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F94")]
		[Address(RVA = "0xCC5E60", Offset = "0xCC5E60", VA = "0xCC5E60")]
		set
		{
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000191")]
	public string Name
	{
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0xCC5EE4", Offset = "0xCC5EE4", VA = "0xCC5EE4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F96")]
	[Address(RVA = "0xCC5EEC", Offset = "0xCC5EEC", VA = "0xCC5EEC")]
	public void Enable(string nomen)
	{
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F97")]
	[Address(RVA = "0xCC5FCC", Offset = "0xCC5FCC", VA = "0xCC5FCC")]
	public string GetInputText(Rectangle region, int maxCharacters = -1)
	{
		return null;
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0xCC6218", Offset = "0xCC6218", VA = "0xCC6218")]
	public GUIMenuNameEdit()
	{
	}

	// Token: 0x04001FD4 RID: 8148
	[Token(Token = "0x4001FD4")]
	[FieldOffset(Offset = "0x8")]
	private string _editedName;

	// Token: 0x04001FD5 RID: 8149
	[Token(Token = "0x4001FD5")]
	[FieldOffset(Offset = "0xC")]
	private bool _enabled;
}
