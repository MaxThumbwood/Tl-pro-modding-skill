using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000A5 RID: 165
[Token(Token = "0x20000A5")]
public class GUIControllerMultiplayerHost : FileAPI
{
	// Token: 0x0600042A RID: 1066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042A")]
	[Address(RVA = "0xD5D604", Offset = "0xD5D604", VA = "0xD5D604", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00003360 File Offset: 0x00001560
	[Token(Token = "0x600042B")]
	[Address(RVA = "0xD5D610", Offset = "0xD5D610", VA = "0xD5D610", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042C")]
	[Address(RVA = "0xD5D618", Offset = "0xD5D618", VA = "0xD5D618", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042D")]
	[Address(RVA = "0xD5D7B4", Offset = "0xD5D7B4", VA = "0xD5D7B4")]
	public void ActivateServerPassword()
	{
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042E")]
	[Address(RVA = "0xD5D7C0", Offset = "0xD5D7C0", VA = "0xD5D7C0")]
	public void DeactivateServerPassword()
	{
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00003378 File Offset: 0x00001578
	[Token(Token = "0x600042F")]
	[Address(RVA = "0xD5D7CC", Offset = "0xD5D7CC", VA = "0xD5D7CC", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000430")]
	[Address(RVA = "0xD5D9FC", Offset = "0xD5D9FC", VA = "0xD5D9FC")]
	public GUIControllerMultiplayerHost()
	{
	}

	// Token: 0x0400060C RID: 1548
	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x8")]
	private bool serverPasswordActive;

	// Token: 0x0400060D RID: 1549
	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0xC")]
	public int selectionIndex;
}
