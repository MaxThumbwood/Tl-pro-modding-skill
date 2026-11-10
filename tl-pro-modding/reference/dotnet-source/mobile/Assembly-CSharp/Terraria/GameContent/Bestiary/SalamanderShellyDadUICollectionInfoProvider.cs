using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C05 RID: 3077
	[Token(Token = "0x2000C05")]
	public class SalamanderShellyDadUICollectionInfoProvider : FileAPI
	{
		// Token: 0x06005C89 RID: 23689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x9A2754", Offset = "0x9A2754", VA = "0x9A2754")]
		public SalamanderShellyDadUICollectionInfoProvider(string persistentId)
		{
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x0002B608 File Offset: 0x00029808
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x9A277C", Offset = "0x9A277C", VA = "0x9A277C", Slot = "4")]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			return default(BestiaryUICollectionInfo);
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x0002B620 File Offset: 0x00029820
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0x9A2AE0", Offset = "0x9A2AE0", VA = "0x9A2AE0")]
		private BestiaryEntryUnlockState GetLowestAvailableUnlockStateFromEntriesThatAreInWorld(BestiaryEntryUnlockState unlockstatus)
		{
			return BestiaryEntryUnlockState.NotKnownAtAll_0;
		}

		// Token: 0x06005C8C RID: 23692 RVA: 0x0002B638 File Offset: 0x00029838
		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0x9A28EC", Offset = "0x9A28EC", VA = "0x9A28EC")]
		private bool IsIncludedInCurrentWorld()
		{
			return default(bool);
		}

		// Token: 0x06005C8D RID: 23693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0x9A2D8C", Offset = "0x9A2D8C", VA = "0x9A2D8C")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D14 RID: 40212
		[Token(Token = "0x4009D14")]
		[FieldOffset(Offset = "0x8")]
		private string _persistentIdentifierToCheck;

		// Token: 0x04009D15 RID: 40213
		[Token(Token = "0x4009D15")]
		[FieldOffset(Offset = "0xC")]
		private int _killCountNeededToFullyUnlock;
	}
}
