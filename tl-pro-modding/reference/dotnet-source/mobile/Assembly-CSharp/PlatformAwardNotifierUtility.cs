using System;
using Il2CppDummyDll;
using Terraria;

// Token: 0x020002F6 RID: 758
[Token(Token = "0x20002F6")]
public class PlatformAwardNotifierUtility
{
	// Token: 0x06001286 RID: 4742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001286")]
	[Address(RVA = "0xD8FAC8", Offset = "0xD8FAC8", VA = "0xD8FAC8")]
	public static void NoteSlimeDefeatedForPlayer(Player player, eSlimeKillStatistics slimeID)
	{
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001287")]
	[Address(RVA = "0xD8FC4C", Offset = "0xD8FC4C", VA = "0xD8FC4C")]
	public static void NoteItemCraftedForPlayer(Player player, eCraftingStatistics craftingID)
	{
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001288")]
	[Address(RVA = "0xD8FD8C", Offset = "0xD8FD8C", VA = "0xD8FD8C")]
	public static void NoteTraveledForPlayer(Player player, eDistanceStatistics distanceID)
	{
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001289")]
	[Address(RVA = "0xD8FECC", Offset = "0xD8FECC", VA = "0xD8FECC")]
	public static void NoteMinedForPlayer(Player player, eMiningStatistics miningID)
	{
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128A")]
	[Address(RVA = "0xD901BC", Offset = "0xD901BC", VA = "0xD901BC")]
	public static void NoteTriggerForPlayer(Player player, eTrigger triggerType)
	{
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128B")]
	[Address(RVA = "0xD902FC", Offset = "0xD902FC", VA = "0xD902FC")]
	public static void NoteBossKillForAllLocalUsers(eBossKillStatistics bossID)
	{
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128C")]
	[Address(RVA = "0xD90630", Offset = "0xD90630", VA = "0xD90630")]
	public static void NoteTriggerForAllLocalUsers(eTrigger triggerType)
	{
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128D")]
	[Address(RVA = "0xD90928", Offset = "0xD90928", VA = "0xD90928")]
	public static void NoteItemPickedUpForPlayer(Player player, int itemID)
	{
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x00008808 File Offset: 0x00006A08
	[Token(Token = "0x600128E")]
	[Address(RVA = "0xD90D2C", Offset = "0xD90D2C", VA = "0xD90D2C")]
	public static bool IsArmorForAchievement(int itemID)
	{
		return default(bool);
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128F")]
	[Address(RVA = "0xD90DC8", Offset = "0xD90DC8", VA = "0xD90DC8")]
	public static void NoteCraftingStationUsed(Player player, int tileID)
	{
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x00008820 File Offset: 0x00006A20
	[Token(Token = "0x6001290")]
	[Address(RVA = "0xD91094", Offset = "0xD91094", VA = "0xD91094")]
	public static int GetAchievementIDFromTileID(int tileID)
	{
		return 0;
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x00008838 File Offset: 0x00006A38
	[Token(Token = "0x6001291")]
	[Address(RVA = "0xD9114C", Offset = "0xD9114C", VA = "0xD9114C")]
	public static eSlimeKillStatistics GetSlimeStatIDFromNetID(int netID)
	{
		return eSlimeKillStatistics.BabySlime;
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x00008850 File Offset: 0x00006A50
	[Token(Token = "0x6001292")]
	[Address(RVA = "0xD91394", Offset = "0xD91394", VA = "0xD91394")]
	public static eBossKillStatistics GetBossStatIDFromNetID(int netID)
	{
		return (eBossKillStatistics)0;
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001293")]
	[Address(RVA = "0xD91544", Offset = "0xD91544", VA = "0xD91544")]
	public static void RegisterKillTileStatistic(Player player, int tileType)
	{
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001294")]
	[Address(RVA = "0xD91978", Offset = "0xD91978", VA = "0xD91978")]
	public PlatformAwardNotifierUtility()
	{
	}

	// Token: 0x0400250B RID: 9483
	[Token(Token = "0x400250B")]
	[FieldOffset(Offset = "0x0")]
	public static int[] AchievementArmors;

	// Token: 0x0400250C RID: 9484
	[Token(Token = "0x400250C")]
	[FieldOffset(Offset = "0x4")]
	public static int[] AchievementCraftingStationsTracking;
}
