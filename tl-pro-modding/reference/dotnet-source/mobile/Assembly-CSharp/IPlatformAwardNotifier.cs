using System;
using Il2CppDummyDll;

// Token: 0x020002F1 RID: 753
[Token(Token = "0x20002F1")]
public interface IPlatformAwardNotifier
{
	// Token: 0x0600127C RID: 4732
	[Token(Token = "0x600127C")]
	void Initialize(LocalUser user);

	// Token: 0x0600127D RID: 4733
	[Token(Token = "0x600127D")]
	void NoteSlimeDefeated(eSlimeKillStatistics slimeID);

	// Token: 0x0600127E RID: 4734
	[Token(Token = "0x600127E")]
	void NoteItemCrafted(eCraftingStatistics craftingID);

	// Token: 0x0600127F RID: 4735
	[Token(Token = "0x600127F")]
	void NoteTraveled(eDistanceStatistics distanceID);

	// Token: 0x06001280 RID: 4736
	[Token(Token = "0x6001280")]
	void NoteMined(eMiningStatistics miningID, int amount);

	// Token: 0x06001281 RID: 4737
	[Token(Token = "0x6001281")]
	void NoteBossKill(eBossKillStatistics bossID);

	// Token: 0x06001282 RID: 4738
	[Token(Token = "0x6001282")]
	void NoteTrigger(eTrigger triggerType);
}
