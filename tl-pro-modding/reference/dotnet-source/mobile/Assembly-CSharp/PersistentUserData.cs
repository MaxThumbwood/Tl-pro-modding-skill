using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000318 RID: 792
[Token(Token = "0x2000318")]
public class PersistentUserData
{
	// Token: 0x060013A7 RID: 5031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A7")]
	[Address(RVA = "0xDA5F2C", Offset = "0xDA5F2C", VA = "0xDA5F2C")]
	public static PersistentUserData LoadFromData(byte[] data, bool textBased)
	{
		return null;
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A8")]
	[Address(RVA = "0xDA695C", Offset = "0xDA695C", VA = "0xDA695C")]
	public void Save()
	{
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x00008DD8 File Offset: 0x00006FD8
	[Token(Token = "0x60013A9")]
	[Address(RVA = "0xDA81BC", Offset = "0xDA81BC", VA = "0xDA81BC")]
	private bool MaxMerge(ref uint val, uint otherVal)
	{
		return default(bool);
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x00008DF0 File Offset: 0x00006FF0
	[Token(Token = "0x60013AA")]
	[Address(RVA = "0xDA8244", Offset = "0xDA8244", VA = "0xDA8244")]
	private bool MaxMerge(ref long val, long otherVal)
	{
		return default(bool);
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x00008E08 File Offset: 0x00007008
	[Token(Token = "0x60013AB")]
	[Address(RVA = "0xDA82E4", Offset = "0xDA82E4", VA = "0xDA82E4")]
	public bool Merge(PersistentUserData other)
	{
		return default(bool);
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AC")]
	[Address(RVA = "0xDA7E38", Offset = "0xDA7E38", VA = "0xDA7E38")]
	public void EnsureObjects()
	{
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AD")]
	[Address(RVA = "0xDA91B0", Offset = "0xDA91B0", VA = "0xDA91B0")]
	public void OnKillBoss(eBossKillStatistics bossID)
	{
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00008E20 File Offset: 0x00007020
	[Token(Token = "0x60013AE")]
	[Address(RVA = "0xDA92E0", Offset = "0xDA92E0", VA = "0xDA92E0")]
	public int GetProgressNumberOfTimesKilledAllBosses()
	{
		return 0;
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x00008E38 File Offset: 0x00007038
	[Token(Token = "0x60013AF")]
	[Address(RVA = "0xDA97B8", Offset = "0xDA97B8", VA = "0xDA97B8")]
	public int GetNormlBossCount()
	{
		return 0;
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x00008E50 File Offset: 0x00007050
	[Token(Token = "0x60013B0")]
	[Address(RVA = "0xDA9C4C", Offset = "0xDA9C4C", VA = "0xDA9C4C")]
	public int GetHardBossCount()
	{
		return 0;
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x00008E68 File Offset: 0x00007068
	[Token(Token = "0x60013B1")]
	[Address(RVA = "0xDAA1DC", Offset = "0xDAA1DC", VA = "0xDAA1DC")]
	public int GetNumberOfTimesKilledAllBosses()
	{
		return 0;
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x00008E80 File Offset: 0x00007080
	[Token(Token = "0x60013B2")]
	[Address(RVA = "0xDAA678", Offset = "0xDAA678", VA = "0xDAA678")]
	public int GetNumberOfTimesKilledPrimeBosses()
	{
		return 0;
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x00008E98 File Offset: 0x00007098
	[Token(Token = "0x60013B3")]
	[Address(RVA = "0xDAA8B4", Offset = "0xDAA8B4", VA = "0xDAA8B4")]
	public int GetNumberOfRequiredSlimesKilled()
	{
		return 0;
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B4")]
	[Address(RVA = "0xDA2F38", Offset = "0xDA2F38", VA = "0xDA2F38")]
	public PersistentUserData()
	{
	}

	// Token: 0x0400276D RID: 10093
	[Token(Token = "0x400276D")]
	[FieldOffset(Offset = "0x0")]
	private static byte[] _cryptoKey;

	// Token: 0x0400276E RID: 10094
	[Token(Token = "0x400276E")]
	[FieldOffset(Offset = "0x8")]
	public uint TotalBarsCrafted;

	// Token: 0x0400276F RID: 10095
	[Token(Token = "0x400276F")]
	[FieldOffset(Offset = "0xC")]
	public uint TotalPicked;

	// Token: 0x04002770 RID: 10096
	[Token(Token = "0x4002770")]
	[FieldOffset(Offset = "0x10")]
	public uint TotalAnvilCrafting;

	// Token: 0x04002771 RID: 10097
	[Token(Token = "0x4002771")]
	[FieldOffset(Offset = "0x14")]
	public uint TotalWires;

	// Token: 0x04002772 RID: 10098
	[Token(Token = "0x4002772")]
	[FieldOffset(Offset = "0x18")]
	public uint TotalAirTime;

	// Token: 0x04002773 RID: 10099
	[Token(Token = "0x4002773")]
	[FieldOffset(Offset = "0x1C")]
	public uint CurrentAirTime;

	// Token: 0x04002774 RID: 10100
	[Token(Token = "0x4002774")]
	[FieldOffset(Offset = "0x20")]
	public IntHashSet ArmorCollected;

	// Token: 0x04002775 RID: 10101
	[Token(Token = "0x4002775")]
	[FieldOffset(Offset = "0x24")]
	public IntHashSet CraftingsStationsUsed;

	// Token: 0x04002776 RID: 10102
	[Token(Token = "0x4002776")]
	[FieldOffset(Offset = "0x28")]
	public IntHashSet SlimeTypesKilled;

	// Token: 0x04002777 RID: 10103
	[Token(Token = "0x4002777")]
	[FieldOffset(Offset = "0x2C")]
	public IntHashSet PetBuffsSpawned;

	// Token: 0x04002778 RID: 10104
	[Token(Token = "0x4002778")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<int, int> BossesKilled;

	// Token: 0x04002779 RID: 10105
	[Token(Token = "0x4002779")]
	[FieldOffset(Offset = "0x38")]
	public long TotalGemsMined;

	// Token: 0x0400277A RID: 10106
	[Token(Token = "0x400277A")]
	[FieldOffset(Offset = "0x40")]
	public long TotalOresMined;

	// Token: 0x0400277B RID: 10107
	[Token(Token = "0x400277B")]
	[FieldOffset(Offset = "0x48")]
	public long TotalSoilMined;

	// Token: 0x0400277C RID: 10108
	[Token(Token = "0x400277C")]
	[FieldOffset(Offset = "0x50")]
	public long TotalWoodMined;

	// Token: 0x0400277D RID: 10109
	[Token(Token = "0x400277D")]
	[FieldOffset(Offset = "0x58")]
	public long TotalResourcesMined;
}
