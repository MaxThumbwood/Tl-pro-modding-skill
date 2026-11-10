using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000BF RID: 191
[Token(Token = "0x20000BF")]
public class GUIWorldCreateController : FileAPI
{
	// Token: 0x060004A7 RID: 1191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xD6B784", Offset = "0xD6B784", VA = "0xD6B784", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00003750 File Offset: 0x00001950
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xD6B81C", Offset = "0xD6B81C", VA = "0xD6B81C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00003768 File Offset: 0x00001968
	[Token(Token = "0x17000084")]
	private int MaxSeedSecondRowColumn
	{
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xD6B824", Offset = "0xD6B824", VA = "0xD6B824")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xD6B884", Offset = "0xD6B884", VA = "0xD6B884", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xD6BE98", Offset = "0xD6BE98", VA = "0xD6BE98")]
	public void ActivateName()
	{
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xD6BEA4", Offset = "0xD6BEA4", VA = "0xD6BEA4")]
	public void DeactivateName()
	{
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0xD6BEB0", Offset = "0xD6BEB0", VA = "0xD6BEB0")]
	public void ActivateSeed()
	{
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0xD6BEBC", Offset = "0xD6BEBC", VA = "0xD6BEBC")]
	public void DeactivateSeed()
	{
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0xD6BEC8", Offset = "0xD6BEC8", VA = "0xD6BEC8")]
	public void ActivateDifficultyOptions(int selectedOption, int wrapAround)
	{
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0xD6BEE0", Offset = "0xD6BEE0", VA = "0xD6BEE0")]
	public void DeactivateDifficultyOptions()
	{
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0xD6BEEC", Offset = "0xD6BEEC", VA = "0xD6BEEC")]
	public void ActivateWorldOptions(int selectedOption)
	{
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0xD6BEFC", Offset = "0xD6BEFC", VA = "0xD6BEFC")]
	public void DeactivateWorldOptions()
	{
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0xD6BF08", Offset = "0xD6BF08", VA = "0xD6BF08")]
	public void ActivateEvilTypeOptions(int selectedOption, int wrapAround)
	{
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0xD6BF20", Offset = "0xD6BF20", VA = "0xD6BF20")]
	public void DeactivateEvilTypeOptions()
	{
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00003780 File Offset: 0x00001980
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xD6BF2C", Offset = "0xD6BF2C", VA = "0xD6BF2C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xD6C748", Offset = "0xD6C748", VA = "0xD6C748")]
	public GUIWorldCreateController()
	{
	}

	// Token: 0x04000690 RID: 1680
	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x8")]
	public GUIWorldCreateController.ItemSelection selectedItem;

	// Token: 0x04000691 RID: 1681
	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0xC")]
	private bool nameActive;

	// Token: 0x04000692 RID: 1682
	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0xD")]
	private bool seedActive;

	// Token: 0x04000693 RID: 1683
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0xE")]
	private bool worldActive;

	// Token: 0x04000694 RID: 1684
	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x10")]
	private int worldIndex;

	// Token: 0x04000695 RID: 1685
	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x14")]
	private bool difficultyActive;

	// Token: 0x04000696 RID: 1686
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x18")]
	private int difficultyIndex;

	// Token: 0x04000697 RID: 1687
	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x1C")]
	private int difficultyWrapAround;

	// Token: 0x04000698 RID: 1688
	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x20")]
	private bool evilTypeActive;

	// Token: 0x04000699 RID: 1689
	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x24")]
	private int evilTypeIndex;

	// Token: 0x0400069A RID: 1690
	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x28")]
	private int evilTypeWrapAround;

	// Token: 0x0400069B RID: 1691
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x2C")]
	private bool seedConfigActive;

	// Token: 0x0400069C RID: 1692
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x30")]
	private int seedColumn;

	// Token: 0x0400069D RID: 1693
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x34")]
	private int seedRow;

	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	public enum ItemSelection
	{
		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		GeneralTab,
		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		SeedTab,
		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		General_Size,
		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		General_Difficulty,
		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		General_Evil,
		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		General_Name,
		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		Seed_Grid,
		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		Seed_Value,
		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		Back,
		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		Randomise,
		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		Create
	}
}
