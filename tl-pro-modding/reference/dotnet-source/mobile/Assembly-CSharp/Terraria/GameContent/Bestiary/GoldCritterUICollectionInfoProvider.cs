using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C04 RID: 3076
	[Token(Token = "0x2000C04")]
	public class GoldCritterUICollectionInfoProvider : FileAPI
	{
		// Token: 0x06005C85 RID: 23685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C85")]
		[Address(RVA = "0x9A21F0", Offset = "0x9A21F0", VA = "0x9A21F0")]
		public GoldCritterUICollectionInfoProvider(int[] normalCritterPersistentId, string goldCritterPersistentId)
		{
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x0002B5C0 File Offset: 0x000297C0
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0x9A236C", Offset = "0x9A236C", VA = "0x9A236C", Slot = "4")]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			return default(BestiaryUICollectionInfo);
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x0002B5D8 File Offset: 0x000297D8
		[Token(Token = "0x6005C87")]
		[Address(RVA = "0x9A24E4", Offset = "0x9A24E4", VA = "0x9A24E4")]
		private bool TryFindingOneGoldCritterThatIsAlreadyUnlocked()
		{
			return default(bool);
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x0002B5F0 File Offset: 0x000297F0
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0x9A23FC", Offset = "0x9A23FC", VA = "0x9A23FC")]
		private BestiaryEntryUnlockState GetUnlockStateForCritter(string persistentId)
		{
			return BestiaryEntryUnlockState.NotKnownAtAll_0;
		}

		// Token: 0x04009D12 RID: 40210
		[Token(Token = "0x4009D12")]
		[FieldOffset(Offset = "0x8")]
		private string[] _normalCritterPersistentId;

		// Token: 0x04009D13 RID: 40211
		[Token(Token = "0x4009D13")]
		[FieldOffset(Offset = "0xC")]
		private string _goldCritterPersistentId;
	}
}
