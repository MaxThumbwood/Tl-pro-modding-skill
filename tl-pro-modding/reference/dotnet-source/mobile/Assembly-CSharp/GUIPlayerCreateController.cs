using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000100 RID: 256
[Token(Token = "0x2000100")]
public class GUIPlayerCreateController : FileAPI
{
	// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B9")]
	[Address(RVA = "0xF29CB4", Offset = "0xF29CB4", VA = "0xF29CB4")]
	public GUIPlayerCreateController()
	{
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BA")]
	[Address(RVA = "0xF2A0C4", Offset = "0xF2A0C4", VA = "0xF2A0C4", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BB")]
	[Address(RVA = "0xF2A594", Offset = "0xF2A594", VA = "0xF2A594")]
	public void ActivateRandomise()
	{
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00004950 File Offset: 0x00002B50
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0xF2A5C4", Offset = "0xF2A5C4", VA = "0xF2A5C4", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0xF2A5CC", Offset = "0xF2A5CC", VA = "0xF2A5CC", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00004968 File Offset: 0x00002B68
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0xF2A69C", Offset = "0xF2A69C", VA = "0xF2A69C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060006BF RID: 1727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B9")]
	public GUIControllerItem CurrentItem
	{
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xF2A770", Offset = "0xF2A770", VA = "0xF2A770")]
		get
		{
			return null;
		}
	}

	// Token: 0x04000773 RID: 1907
	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0x8")]
	private GUIControllerItem _activeItem;

	// Token: 0x04000774 RID: 1908
	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0xC")]
	public readonly GUIPlayerCreateController_MainButtons Buttons;

	// Token: 0x04000775 RID: 1909
	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x10")]
	public readonly GUIPlayerCreateController_Tabs Tabs;

	// Token: 0x04000776 RID: 1910
	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x14")]
	public readonly GUIPlayerCreateController_Info InfoPage;

	// Token: 0x04000777 RID: 1911
	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x18")]
	public readonly GUIPlayerCreateController_Voice VoicePage;

	// Token: 0x04000778 RID: 1912
	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x1C")]
	public readonly GUIPlayerCreateController_Gender GenderPage;

	// Token: 0x04000779 RID: 1913
	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x20")]
	public readonly GUIPlayerCreateController_HairStyle HairStlyePage;

	// Token: 0x0400077A RID: 1914
	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x24")]
	public readonly GUIPlayerCreateController_ItemColour HairColour;

	// Token: 0x0400077B RID: 1915
	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x28")]
	public readonly GUIPlayerCreateController_ItemColour EyeColour;

	// Token: 0x0400077C RID: 1916
	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x2C")]
	public readonly GUIPlayerCreateController_ItemColour SkinColour;

	// Token: 0x0400077D RID: 1917
	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x30")]
	public readonly GUIPlayerCreateController_ItemColour ShirtColour;

	// Token: 0x0400077E RID: 1918
	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x34")]
	public readonly GUIPlayerCreateController_ItemColour UndershirtColour;

	// Token: 0x0400077F RID: 1919
	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x38")]
	public readonly GUIPlayerCreateController_ItemColour PantsColour;

	// Token: 0x04000780 RID: 1920
	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x3C")]
	public readonly GUIPlayerCreateController_ItemColour ShoesColour;
}
