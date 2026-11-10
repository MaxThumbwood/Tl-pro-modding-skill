using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000A3 RID: 163
[Token(Token = "0x20000A3")]
public class GUIControllerModalResponse : FileAPI
{
	// Token: 0x06000425 RID: 1061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000425")]
	[Address(RVA = "0xD5D4E4", Offset = "0xD5D4E4", VA = "0xD5D4E4", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000426")]
	[Address(RVA = "0xD5D4F0", Offset = "0xD5D4F0", VA = "0xD5D4F0", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00003330 File Offset: 0x00001530
	[Token(Token = "0x6000427")]
	[Address(RVA = "0xD5D520", Offset = "0xD5D520", VA = "0xD5D520", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00003348 File Offset: 0x00001548
	[Token(Token = "0x6000428")]
	[Address(RVA = "0xD5D5F4", Offset = "0xD5D5F4", VA = "0xD5D5F4", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000429")]
	[Address(RVA = "0xD5D5FC", Offset = "0xD5D5FC", VA = "0xD5D5FC")]
	public GUIControllerModalResponse()
	{
	}

	// Token: 0x04000608 RID: 1544
	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x8")]
	public GUIControllerModalResponse.Controls selectedControl;

	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public enum Controls
	{
		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		Cancel,
		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		Confirm
	}
}
