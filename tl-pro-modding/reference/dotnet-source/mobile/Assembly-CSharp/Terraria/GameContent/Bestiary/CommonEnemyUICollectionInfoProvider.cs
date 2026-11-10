using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C02 RID: 3074
	[Token(Token = "0x2000C02")]
	public class CommonEnemyUICollectionInfoProvider : FileAPI
	{
		// Token: 0x06005C7C RID: 23676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7C")]
		[Address(RVA = "0x99E9A8", Offset = "0x99E9A8", VA = "0x99E9A8")]
		public CommonEnemyUICollectionInfoProvider(string persistentId, bool quickUnlock)
		{
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x0002B548 File Offset: 0x00029748
		[Token(Token = "0x6005C7D")]
		[Address(RVA = "0x9A1BB4", Offset = "0x9A1BB4", VA = "0x9A1BB4")]
		public static int GetKillCountNeeded(string persistentId)
		{
			return 0;
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x0002B560 File Offset: 0x00029760
		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0x9A1DBC", Offset = "0x9A1DBC", VA = "0x9A1DBC", Slot = "4")]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			return default(BestiaryUICollectionInfo);
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x0002B578 File Offset: 0x00029778
		[Token(Token = "0x6005C7F")]
		[Address(RVA = "0x9A1F34", Offset = "0x9A1F34", VA = "0x9A1F34")]
		public BestiaryEntryUnlockState GetUnlockStateByKillCount(int killCount, bool quickUnlock)
		{
			return BestiaryEntryUnlockState.NotKnownAtAll_0;
		}

		// Token: 0x06005C80 RID: 23680 RVA: 0x0002B590 File Offset: 0x00029790
		[Token(Token = "0x6005C80")]
		[Address(RVA = "0x9A1F9C", Offset = "0x9A1F9C", VA = "0x9A1F9C")]
		public static BestiaryEntryUnlockState GetUnlockStateByKillCount(int killCount, bool quickUnlock, int fullKillCountNeeded)
		{
			return BestiaryEntryUnlockState.NotKnownAtAll_0;
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C81")]
		[Address(RVA = "0x9A2004", Offset = "0x9A2004", VA = "0x9A2004")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D0D RID: 40205
		[Token(Token = "0x4009D0D")]
		[FieldOffset(Offset = "0x8")]
		private string _persistentIdentifierToCheck;

		// Token: 0x04009D0E RID: 40206
		[Token(Token = "0x4009D0E")]
		[FieldOffset(Offset = "0xC")]
		private bool _quickUnlock;

		// Token: 0x04009D0F RID: 40207
		[Token(Token = "0x4009D0F")]
		[FieldOffset(Offset = "0x10")]
		private int _killCountNeededToFullyUnlock;
	}
}
