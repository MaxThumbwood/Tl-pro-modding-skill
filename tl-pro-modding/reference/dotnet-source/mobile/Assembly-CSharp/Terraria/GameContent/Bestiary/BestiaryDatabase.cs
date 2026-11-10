using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.GameContent.ItemDropRules;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BC9 RID: 3017
	[Token(Token = "0x2000BC9")]
	public class BestiaryDatabase
	{
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06005B95 RID: 23445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A32")]
		public List<BestiaryEntry> Entries
		{
			[Token(Token = "0x6005B95")]
			[Address(RVA = "0x990FF8", Offset = "0x990FF8", VA = "0x990FF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06005B96 RID: 23446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A33")]
		public List<IBestiaryEntryFilter> Filters
		{
			[Token(Token = "0x6005B96")]
			[Address(RVA = "0x991000", Offset = "0x991000", VA = "0x991000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06005B97 RID: 23447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A34")]
		public List<IBestiarySortStep> SortSteps
		{
			[Token(Token = "0x6005B97")]
			[Address(RVA = "0x991008", Offset = "0x991008", VA = "0x991008")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B98")]
		[Address(RVA = "0x991010", Offset = "0x991010", VA = "0x991010")]
		public BestiaryEntry Register(BestiaryEntry entry)
		{
			return null;
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B99")]
		[Address(RVA = "0x9911FC", Offset = "0x9911FC", VA = "0x9911FC")]
		public IBestiaryEntryFilter Register(IBestiaryEntryFilter filter)
		{
			return null;
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0x9912C0", Offset = "0x9912C0", VA = "0x9912C0")]
		public IBestiarySortStep Register(IBestiarySortStep sortStep)
		{
			return null;
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0x991384", Offset = "0x991384", VA = "0x991384")]
		public BestiaryEntry FindEntryByNPCID(int npcNetId)
		{
			return null;
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0x991478", Offset = "0x991478", VA = "0x991478")]
		public void Merge(ItemDropDatabase dropsDatabase)
		{
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0x9914AC", Offset = "0x9914AC", VA = "0x9914AC")]
		private void ExtractDropsForNPC(ItemDropDatabase dropsDatabase, int npcId)
		{
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0x9919D8", Offset = "0x9919D8", VA = "0x9919D8")]
		public void ApplyPass(BestiaryDatabase.BestiaryEntriesPass pass)
		{
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9F")]
		[Address(RVA = "0x991AA4", Offset = "0x991AA4", VA = "0x991AA4")]
		public BestiaryDatabase()
		{
		}

		// Token: 0x04009C3D RID: 39997
		[Token(Token = "0x4009C3D")]
		[FieldOffset(Offset = "0x8")]
		private List<BestiaryEntry> _entries;

		// Token: 0x04009C3E RID: 39998
		[Token(Token = "0x4009C3E")]
		[FieldOffset(Offset = "0xC")]
		private List<IBestiaryEntryFilter> _filters;

		// Token: 0x04009C3F RID: 39999
		[Token(Token = "0x4009C3F")]
		[FieldOffset(Offset = "0x10")]
		private List<IBestiarySortStep> _sortSteps;

		// Token: 0x04009C40 RID: 40000
		[Token(Token = "0x4009C40")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<int, BestiaryEntry> _byNpcId;

		// Token: 0x04009C41 RID: 40001
		[Token(Token = "0x4009C41")]
		[FieldOffset(Offset = "0x18")]
		private BestiaryEntry _trashEntry;

		// Token: 0x02000BCA RID: 3018
		// (Invoke) Token: 0x06005BA1 RID: 23457
		[Token(Token = "0x2000BCA")]
		public delegate void BestiaryEntriesPass(BestiaryEntry entry);
	}
}
