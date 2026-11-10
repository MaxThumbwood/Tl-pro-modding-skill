using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000AC RID: 172
[Token(Token = "0x20000AC")]
public class GUIControllerNPCDialogue : FileAPI
{
	// Token: 0x06000455 RID: 1109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000455")]
	[Address(RVA = "0xD64874", Offset = "0xD64874", VA = "0xD64874", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x000034C8 File Offset: 0x000016C8
	[Token(Token = "0x6000456")]
	[Address(RVA = "0xD64880", Offset = "0xD64880", VA = "0xD64880", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000457")]
	[Address(RVA = "0xD64888", Offset = "0xD64888", VA = "0xD64888", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x000034E0 File Offset: 0x000016E0
	[Token(Token = "0x6000458")]
	[Address(RVA = "0xD6498C", Offset = "0xD6498C", VA = "0xD6498C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000459")]
	[Address(RVA = "0xD64B7C", Offset = "0xD64B7C", VA = "0xD64B7C")]
	public GUIControllerNPCDialogue()
	{
	}

	// Token: 0x04000648 RID: 1608
	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x8")]
	private int _selected;
}
