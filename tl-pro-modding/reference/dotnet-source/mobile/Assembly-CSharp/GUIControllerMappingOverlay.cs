using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200007F RID: 127
[Token(Token = "0x200007F")]
public class GUIControllerMappingOverlay : FileAPI
{
	// Token: 0x060002CA RID: 714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x4C2A04", Offset = "0x4C2A04", VA = "0x4C2A04", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002E98 File Offset: 0x00001098
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x4CD214", Offset = "0x4CD214", VA = "0x4CD214", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x4CCEA4", Offset = "0x4CCEA4", VA = "0x4CCEA4")]
	private void UpdateScroll()
	{
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x4CD21C", Offset = "0x4CD21C", VA = "0x4CD21C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x4BC79C", Offset = "0x4BC79C", VA = "0x4BC79C")]
	public void ActivateOverlay(GUIControllerMappingEntry overlayEntry, Rectangle overlayRegion)
	{
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x4CD5EC", Offset = "0x4CD5EC", VA = "0x4CD5EC")]
	public void ActivateOverlay(GUIControllerPulldownEntry overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x4BC904", Offset = "0x4BC904", VA = "0x4BC904")]
	public void DeactivateOverlay()
	{
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00002EB0 File Offset: 0x000010B0
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x4CD614", Offset = "0x4CD614", VA = "0x4CD614", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x4CCDDC", Offset = "0x4CCDDC", VA = "0x4CCDDC")]
	public GUIControllerMappingOverlay()
	{
	}

	// Token: 0x04000589 RID: 1417
	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x8")]
	public GUIControllerMappingEntryBase _overlayEntry;

	// Token: 0x0400058A RID: 1418
	[Token(Token = "0x400058A")]
	[FieldOffset(Offset = "0xC")]
	public Rectangle _overlayRegion;

	// Token: 0x0400058B RID: 1419
	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x1C")]
	public int _overlayIndex;

	// Token: 0x0400058C RID: 1420
	[Token(Token = "0x400058C")]
	[FieldOffset(Offset = "0x20")]
	public float _overlayOffset;

	// Token: 0x0400058D RID: 1421
	[Token(Token = "0x400058D")]
	[FieldOffset(Offset = "0x24")]
	public GUIControllerMappingOverlay.Controls selectedControl;

	// Token: 0x0400058E RID: 1422
	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x28")]
	public int _selectedItem;

	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public enum Controls
	{
		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		PageGeneral,
		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		PageExplore,
		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		PageFight,
		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		PageMisc,
		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		PageInventory,
		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		PageChest,
		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		PageEquipment,
		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		PageShopsCraft,
		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		PagePVP,
		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		PageMap,
		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		Element,
		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		Reset,
		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		Back
	}
}
