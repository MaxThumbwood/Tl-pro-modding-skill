using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000098 RID: 152
[Token(Token = "0x2000098")]
public class GUIControllerEmotes : FileAPI
{
	// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0xC51EB0", Offset = "0xC51EB0", VA = "0xC51EB0", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xC51EC0", Offset = "0xC51EC0", VA = "0xC51EC0", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x1700007F")]
	private static int maxRowIndex
	{
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xC51EC8", Offset = "0xC51EC8", VA = "0xC51EC8")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060003FA RID: 1018 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x17000080")]
	private static int maxRowColumn
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xC51FC8", Offset = "0xC51FC8", VA = "0xC51FC8")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xC520C4", Offset = "0xC520C4", VA = "0xC520C4")]
	private void UpdateEmoteScroll()
	{
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xC524AC", Offset = "0xC524AC", VA = "0xC524AC", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x000031E0 File Offset: 0x000013E0
	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xC526D0", Offset = "0xC526D0", VA = "0xC526D0", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xC52C78", Offset = "0xC52C78", VA = "0xC52C78")]
	public GUIControllerEmotes()
	{
	}

	// Token: 0x040005DA RID: 1498
	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0x8")]
	public GUIControllerEmotes.Controls selectedControl;

	// Token: 0x040005DB RID: 1499
	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0x0")]
	private static float maxScrollOffset;

	// Token: 0x040005DC RID: 1500
	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0xC")]
	private int SelectedRow;

	// Token: 0x040005DD RID: 1501
	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x10")]
	private int SelectedColumn;

	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public enum Controls
	{
		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		General,
		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		RPS,
		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		Items,
		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		BiomesAndEvents,
		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		TownNPCs,
		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		Critters,
		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		Bosses,
		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		Element,
		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		Back
	}
}
