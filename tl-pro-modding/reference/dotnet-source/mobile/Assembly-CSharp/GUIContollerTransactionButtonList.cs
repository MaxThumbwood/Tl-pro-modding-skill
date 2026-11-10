using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000090 RID: 144
[Token(Token = "0x2000090")]
public class GUIContollerTransactionButtonList : FileAPI
{
	// Token: 0x060003BA RID: 954 RVA: 0x00002FE8 File Offset: 0x000011E8
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xC4E468", Offset = "0xC4E468", VA = "0xC4E468", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xC4E4F8", Offset = "0xC4E4F8", VA = "0xC4E4F8")]
	public GUIContollerTransactionButtonList(bool vertical, bool wrapAround, TransactionButton_Layout[] items, [Optional] GUIContollerTransactionButtonList.SetupRegions regionSetup, int defaultItem = 0)
	{
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xC4E538", Offset = "0xC4E538", VA = "0xC4E538", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xC4E544", Offset = "0xC4E544", VA = "0xC4E544")]
	public void SelectOption(int option)
	{
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00003000 File Offset: 0x00001200
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xC4E54C", Offset = "0xC4E54C", VA = "0xC4E54C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xC4E600", Offset = "0xC4E600", VA = "0xC4E600", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationAxis)
	{
		return null;
	}

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x40005BE")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private bool _vertical;

	// Token: 0x040005BF RID: 1471
	[Token(Token = "0x40005BF")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	private bool _wrapAround;

	// Token: 0x040005C0 RID: 1472
	[Token(Token = "0x40005C0")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private int _selectedItem;

	// Token: 0x040005C1 RID: 1473
	[Token(Token = "0x40005C1")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int _defaultItem;

	// Token: 0x040005C2 RID: 1474
	[Token(Token = "0x40005C2")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout[] _items;

	// Token: 0x040005C3 RID: 1475
	[Token(Token = "0x40005C3")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GUIContollerTransactionButtonList.SetupRegions _regionSetup;

	// Token: 0x02000091 RID: 145
	// (Invoke) Token: 0x060003C1 RID: 961
	[Token(Token = "0x2000091")]
	public delegate void SetupRegions(bool setup);
}
