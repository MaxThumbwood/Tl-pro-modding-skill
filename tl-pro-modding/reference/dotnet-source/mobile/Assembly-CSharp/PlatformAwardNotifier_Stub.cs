using System;
using Il2CppDummyDll;

// Token: 0x020002E8 RID: 744
[Token(Token = "0x20002E8")]
public class PlatformAwardNotifier_Stub : FileAPI
{
	// Token: 0x06001274 RID: 4724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001274")]
	[Address(RVA = "0xD8F888", Offset = "0xD8F888", VA = "0xD8F888", Slot = "4")]
	public void Initialize(LocalUser user)
	{
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001275")]
	[Address(RVA = "0xD8F88C", Offset = "0xD8F88C", VA = "0xD8F88C", Slot = "5")]
	public void NoteSlimeDefeated(eSlimeKillStatistics slimeID)
	{
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001276")]
	[Address(RVA = "0xD8F890", Offset = "0xD8F890", VA = "0xD8F890", Slot = "6")]
	public void NoteItemCrafted(eCraftingStatistics craftingID)
	{
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001277")]
	[Address(RVA = "0xD8F894", Offset = "0xD8F894", VA = "0xD8F894", Slot = "7")]
	public void NoteTraveled(eDistanceStatistics distanceID)
	{
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001278")]
	[Address(RVA = "0xD8FA38", Offset = "0xD8FA38", VA = "0xD8FA38", Slot = "8")]
	public void NoteMined(eMiningStatistics miningID, int amount)
	{
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001279")]
	[Address(RVA = "0xD8FA3C", Offset = "0xD8FA3C", VA = "0xD8FA3C", Slot = "9")]
	public void NoteBossKill(eBossKillStatistics bossID)
	{
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127A")]
	[Address(RVA = "0xD8FA40", Offset = "0xD8FA40", VA = "0xD8FA40", Slot = "10")]
	public void NoteTrigger(eTrigger triggerType)
	{
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127B")]
	[Address(RVA = "0xD8FA44", Offset = "0xD8FA44", VA = "0xD8FA44")]
	public PlatformAwardNotifier_Stub()
	{
	}

	// Token: 0x0400240A RID: 9226
	[Token(Token = "0x400240A")]
	[FieldOffset(Offset = "0x8")]
	private int lastTraveledPercent;
}
