using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000F1 RID: 241
[Token(Token = "0x20000F1")]
public class GUIPageContentController : FileAPI
{
	// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063A")]
	[Address(RVA = "0xF217B8", Offset = "0xF217B8", VA = "0xF217B8")]
	protected GUIPageContentController(GUIPageIcons.Category pageCategory)
	{
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063B")]
	[Address(RVA = "0xF256CC", Offset = "0xF256CC", VA = "0xF256CC")]
	protected GUIPageContentController(GUIPageIconGrouping.SettingCategory settingCategory)
	{
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x000045A8 File Offset: 0x000027A8
	[Token(Token = "0x600063C")]
	[Address(RVA = "0xF256F0", Offset = "0xF256F0", VA = "0xF256F0", Slot = "8")]
	public virtual int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x000045C0 File Offset: 0x000027C0
	[Token(Token = "0x600063D")]
	[Address(RVA = "0xF256F8", Offset = "0xF256F8", VA = "0xF256F8")]
	public bool IsPageContoller(GUIControllerItem item)
	{
		return default(bool);
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600063E RID: 1598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000098")]
	public GUIPageIconGrouping ParentGrouping
	{
		[Token(Token = "0x600063E")]
		[Address(RVA = "0xF252E0", Offset = "0xF252E0", VA = "0xF252E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063F")]
	[Address(RVA = "0xF22714", Offset = "0xF22714", VA = "0xF22714")]
	public void LoadPageAnchor()
	{
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000640")]
	[Address(RVA = "0xF2574C", Offset = "0xF2574C", VA = "0xF2574C", Slot = "9")]
	public virtual void Activate()
	{
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000641")]
	[Address(RVA = "0xF25750", Offset = "0xF25750", VA = "0xF25750", Slot = "10")]
	public virtual GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x000045D8 File Offset: 0x000027D8
	[Token(Token = "0x6000642")]
	[Address(RVA = "0xF25754", Offset = "0xF25754", VA = "0xF25754", Slot = "11")]
	public virtual Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000643")]
	[Address(RVA = "0xF25760", Offset = "0xF25760", VA = "0xF25760", Slot = "12")]
	public virtual void NavigateInto(int column, int row)
	{
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x000045F0 File Offset: 0x000027F0
	[Token(Token = "0x6000644")]
	[Address(RVA = "0xF25764", Offset = "0xF25764", VA = "0xF25764", Slot = "13")]
	public virtual bool HasContent()
	{
		return default(bool);
	}

	// Token: 0x04000753 RID: 1875
	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x8")]
	public readonly GUIPageIcons.Category PageCategory;

	// Token: 0x04000754 RID: 1876
	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0xC")]
	private readonly GUIPageIconGrouping.SettingCategory SettingCategory;

	// Token: 0x04000755 RID: 1877
	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x10")]
	public int ResearchButton;
}
