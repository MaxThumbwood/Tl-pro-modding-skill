using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000AD RID: 173
[Token(Token = "0x20000AD")]
public class GUIControllerPlayerAndGameModeMistmatch : FileAPI
{
	// Token: 0x0600045A RID: 1114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045A")]
	[Address(RVA = "0xD64B84", Offset = "0xD64B84", VA = "0xD64B84", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600045B")]
	[Address(RVA = "0xD64B90", Offset = "0xD64B90", VA = "0xD64B90", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x600045C")]
	[Address(RVA = "0xD64B94", Offset = "0xD64B94", VA = "0xD64B94", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00003510 File Offset: 0x00001710
	[Token(Token = "0x600045D")]
	[Address(RVA = "0xD64C70", Offset = "0xD64C70", VA = "0xD64C70", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045E")]
	[Address(RVA = "0xD64C78", Offset = "0xD64C78", VA = "0xD64C78")]
	public GUIControllerPlayerAndGameModeMistmatch()
	{
	}

	// Token: 0x04000649 RID: 1609
	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x8")]
	public GUIControllerPlayerAndGameModeMistmatch.Controls selectedControl;

	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	public enum Controls
	{
		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		Cancel
	}
}
