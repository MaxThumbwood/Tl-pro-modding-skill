using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CDC RID: 3292
	[Token(Token = "0x2000CDC")]
	public class ItemsSacrificedUnlocksTracker : FileAPI, GUIControllerItem
	{
		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060061C0 RID: 25024 RVA: 0x0002D168 File Offset: 0x0002B368
		// (set) Token: 0x060061C1 RID: 25025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A97")]
		public int LastEditId
		{
			[Token(Token = "0x60061C0")]
			[Address(RVA = "0xADE3F8", Offset = "0xADE3F8", VA = "0xADE3F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60061C1")]
			[Address(RVA = "0xADE400", Offset = "0xADE400", VA = "0xADE400")]
			private set
			{
			}
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C2")]
		[Address(RVA = "0xADE408", Offset = "0xADE408", VA = "0xADE408")]
		public void DismissNewlyUnlockedFromTeamMatesIcon()
		{
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C3")]
		[Address(RVA = "0xADE238", Offset = "0xADE238", VA = "0xADE238")]
		public ItemsSacrificedUnlocksTracker()
		{
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x0002D180 File Offset: 0x0002B380
		[Token(Token = "0x60061C4")]
		[Address(RVA = "0xADE414", Offset = "0xADE414", VA = "0xADE414")]
		public int GetSacrificeCount(int itemId)
		{
			return 0;
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C5")]
		[Address(RVA = "0xADE504", Offset = "0xADE504", VA = "0xADE504")]
		public void ForEachItemWithResearchProgress(Action<int> action)
		{
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C6")]
		[Address(RVA = "0xADE708", Offset = "0xADE708", VA = "0xADE708")]
		public void FillListOfItemsThatCanBeObtainedInfinitely(List<int> toObtainInfinitely)
		{
		}

		// Token: 0x060061C7 RID: 25031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C7")]
		[Address(RVA = "0xADEB14", Offset = "0xADEB14", VA = "0xADEB14")]
		public void CountFullyResearchedItems(out int fullyResearchedItems, out int allItems)
		{
		}

		// Token: 0x060061C8 RID: 25032 RVA: 0x0002D198 File Offset: 0x0002B398
		[Token(Token = "0x60061C8")]
		[Address(RVA = "0xADE9A4", Offset = "0xADE9A4", VA = "0xADE9A4")]
		public bool TryGetSacrificeNumbers(int itemId, out int amountWeHave, out int amountNeededTotal)
		{
			return default(bool);
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x0002D1B0 File Offset: 0x0002B3B0
		[Token(Token = "0x60061C9")]
		[Address(RVA = "0xADEBA4", Offset = "0xADEBA4", VA = "0xADEBA4")]
		public bool IsFullyResearched(int itemId)
		{
			return default(bool);
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		[Token(Token = "0x60061CA")]
		[Address(RVA = "0xADEBEC", Offset = "0xADEBEC", VA = "0xADEBEC")]
		public bool IsNewlyResearched(int itemId)
		{
			return default(bool);
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CB")]
		[Address(RVA = "0xADEC58", Offset = "0xADEC58", VA = "0xADEC58")]
		public void ClearNewlyResearchedStatus(int itemId)
		{
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x0002D1E0 File Offset: 0x0002B3E0
		[Token(Token = "0x60061CC")]
		[Address(RVA = "0xADECC4", Offset = "0xADECC4", VA = "0xADECC4")]
		public bool TryGetTeammateUnlockCredit(int itemId, out string teammateName)
		{
			return default(bool);
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CD")]
		[Address(RVA = "0xADED38", Offset = "0xADED38", VA = "0xADED38")]
		public void RegisterItemSacrifice(int itemId, int amount, [Optional] string teammateName)
		{
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CE")]
		[Address(RVA = "0xADF6D8", Offset = "0xADF6D8", VA = "0xADF6D8")]
		public void SetSacrificeCountDirectly(string persistentId, int sacrificeCount)
		{
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CF")]
		[Address(RVA = "0xADDC18", Offset = "0xADDC18", VA = "0xADDC18", Slot = "4")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D0")]
		[Address(RVA = "0xADDD78", Offset = "0xADDD78", VA = "0xADDD78", Slot = "5")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D1")]
		[Address(RVA = "0xADF890", Offset = "0xADF890", VA = "0xADF890", Slot = "6")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D2")]
		[Address(RVA = "0xADE08C", Offset = "0xADE08C", VA = "0xADE08C", Slot = "7")]
		public void Reset()
		{
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D3")]
		[Address(RVA = "0xADE1BC", Offset = "0xADE1BC", VA = "0xADE1BC", Slot = "8")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		// Token: 0x060061D4 RID: 25044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D4")]
		[Address(RVA = "0xADF6C8", Offset = "0xADF6C8", VA = "0xADF6C8")]
		public void MarkContentsDirty()
		{
		}

		// Token: 0x0400A052 RID: 41042
		[Token(Token = "0x400A052")]
		public const int POSITIVE_SACRIFICE_COUNT_CAP = 9999;

		// Token: 0x0400A053 RID: 41043
		[Token(Token = "0x400A053")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ConcurrentDictionary<string, int> _sacrificeCountByItemPersistentId;

		// Token: 0x0400A054 RID: 41044
		[Token(Token = "0x400A054")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Dictionary<int, int> SacrificesCountByItemIdCache;

		// Token: 0x0400A055 RID: 41045
		[Token(Token = "0x400A055")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<int, string> _unlockedByTeammate;

		// Token: 0x0400A056 RID: 41046
		[Token(Token = "0x400A056")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private HashSet<int> _newlyUnlocked;

		// Token: 0x0400A057 RID: 41047
		[Token(Token = "0x400A057")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool AnyNewUnlocksFromTeammates;

		// Token: 0x0400A058 RID: 41048
		[Token(Token = "0x400A058")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int <LastEditId>k__BackingField;

		// Token: 0x0400A059 RID: 41049
		[Token(Token = "0x400A059")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int lastReportedFrame;

		// Token: 0x0400A05A RID: 41050
		[Token(Token = "0x400A05A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int lastReportedItem;
	}
}
