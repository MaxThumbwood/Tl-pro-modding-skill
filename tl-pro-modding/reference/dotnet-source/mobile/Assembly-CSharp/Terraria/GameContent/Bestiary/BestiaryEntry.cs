using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BF2 RID: 3058
	[Token(Token = "0x2000BF2")]
	public class BestiaryEntry
	{
		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06005C50 RID: 23632 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C51 RID: 23633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A43")]
		public List<IBestiaryInfoElement> Info
		{
			[Token(Token = "0x6005C50")]
			[Address(RVA = "0x99DBA4", Offset = "0x99DBA4", VA = "0x99DBA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C51")]
			[Address(RVA = "0x99DBAC", Offset = "0x99DBAC", VA = "0x99DBAC")]
			private set
			{
			}
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C52")]
		[Address(RVA = "0x99DBB4", Offset = "0x99DBB4", VA = "0x99DBB4")]
		public BestiaryEntry()
		{
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C53")]
		[Address(RVA = "0x99DC4C", Offset = "0x99DC4C", VA = "0x99DC4C")]
		public static BestiaryEntry Enemy(int npcNetId)
		{
			return null;
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C54")]
		[Address(RVA = "0x99EBB0", Offset = "0x99EBB0", VA = "0x99EBB0")]
		public static BestiaryEntry TownNPC(int npcNetId)
		{
			return null;
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C55")]
		[Address(RVA = "0x99F39C", Offset = "0x99F39C", VA = "0x99F39C")]
		public static BestiaryEntry Critter(int npcNetId)
		{
			return null;
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C56")]
		[Address(RVA = "0x99FB88", Offset = "0x99FB88", VA = "0x99FB88")]
		public static BestiaryEntry Biome(string nameLanguageKey, string texturePath, Func<bool> unlockCondition)
		{
			return null;
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C57")]
		[Address(RVA = "0x99FEA0", Offset = "0x99FEA0", VA = "0x99FEA0")]
		public void AddTags(IBestiaryInfoElement[] elements)
		{
		}

		// Token: 0x04009CF2 RID: 40178
		[Token(Token = "0x4009CF2")]
		[FieldOffset(Offset = "0x8")]
		public IEntryIcon Icon;

		// Token: 0x04009CF3 RID: 40179
		[Token(Token = "0x4009CF3")]
		[FieldOffset(Offset = "0xC")]
		private List<IBestiaryInfoElement> <Info>k__BackingField;

		// Token: 0x04009CF4 RID: 40180
		[Token(Token = "0x4009CF4")]
		[FieldOffset(Offset = "0x10")]
		public IBestiaryUICollectionInfoProvider UIInfoProvider;
	}
}
