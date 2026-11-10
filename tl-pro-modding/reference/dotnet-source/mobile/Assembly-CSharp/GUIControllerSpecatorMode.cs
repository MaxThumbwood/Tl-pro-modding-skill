using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000B8 RID: 184
[Token(Token = "0x20000B8")]
public class GUIControllerSpecatorMode : FileAPI
{
	// Token: 0x0600048E RID: 1166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048E")]
	[Address(RVA = "0xD697D4", Offset = "0xD697D4", VA = "0xD697D4", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600048F")]
	[Address(RVA = "0xD697E0", Offset = "0xD697E0", VA = "0xD697E0", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000490")]
	[Address(RVA = "0xD699D8", Offset = "0xD699D8", VA = "0xD699D8")]
	public void Clamp()
	{
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00003690 File Offset: 0x00001890
	[Token(Token = "0x6000491")]
	[Address(RVA = "0xD69A5C", Offset = "0xD69A5C", VA = "0xD69A5C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x000036A8 File Offset: 0x000018A8
	[Token(Token = "0x6000492")]
	[Address(RVA = "0xD69C3C", Offset = "0xD69C3C", VA = "0xD69C3C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000493")]
	[Address(RVA = "0xD69C44", Offset = "0xD69C44", VA = "0xD69C44")]
	public GUIControllerSpecatorMode()
	{
	}

	// Token: 0x04000670 RID: 1648
	[Token(Token = "0x4000670")]
	[FieldOffset(Offset = "0x8")]
	private GUIControllerSpecatorMode.SelectedControl Control;

	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	public enum SelectedControl
	{
		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		PlayerList,
		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		Close,
		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		Teleport
	}
}
