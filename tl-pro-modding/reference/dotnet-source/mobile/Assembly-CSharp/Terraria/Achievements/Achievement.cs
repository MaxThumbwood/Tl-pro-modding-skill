using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Terraria.Localization;

namespace Terraria.Achievements
{
	// Token: 0x020007E1 RID: 2017
	[Token(Token = "0x20007E1")]
	public class Achievement
	{
		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06004588 RID: 17800 RVA: 0x000212D0 File Offset: 0x0001F4D0
		[Token(Token = "0x17000857")]
		public AchievementCategory Category
		{
			[Token(Token = "0x6004588")]
			[Address(RVA = "0x5825A0", Offset = "0x5825A0", VA = "0x5825A0")]
			get
			{
				return AchievementCategory.Slayer;
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06004589 RID: 17801 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600458A RID: 17802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000043")]
		public event Achievement.AchievementCompleted OnCompleted
		{
			[Token(Token = "0x6004589")]
			[Address(RVA = "0x5825A8", Offset = "0x5825A8", VA = "0x5825A8")]
			add
			{
			}
			[Token(Token = "0x600458A")]
			[Address(RVA = "0x582658", Offset = "0x582658", VA = "0x582658")]
			remove
			{
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600458B RID: 17803 RVA: 0x000212E8 File Offset: 0x0001F4E8
		[Token(Token = "0x17000858")]
		public bool HasTracker
		{
			[Token(Token = "0x600458B")]
			[Address(RVA = "0x582708", Offset = "0x582708", VA = "0x582708")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458C")]
		[Address(RVA = "0x582718", Offset = "0x582718", VA = "0x582718")]
		public IAchievementTracker GetTracker()
		{
			return null;
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x00021300 File Offset: 0x0001F500
		[Token(Token = "0x17000859")]
		public bool IsCompleted
		{
			[Token(Token = "0x600458D")]
			[Address(RVA = "0x582720", Offset = "0x582720", VA = "0x582720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458E")]
		[Address(RVA = "0x582794", Offset = "0x582794", VA = "0x582794")]
		public Achievement(string name)
		{
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458F")]
		[Address(RVA = "0x582934", Offset = "0x582934", VA = "0x582934")]
		public void ClearProgress()
		{
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004590")]
		[Address(RVA = "0x582B84", Offset = "0x582B84", VA = "0x582B84")]
		public void Shutdown()
		{
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004591")]
		[Address(RVA = "0x582D4C", Offset = "0x582D4C", VA = "0x582D4C")]
		public void Load(Dictionary<string, JObject> conditions)
		{
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004592")]
		[Address(RVA = "0x583E04", Offset = "0x583E04", VA = "0x583E04")]
		public void AddCondition(AchievementCondition condition)
		{
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004593")]
		[Address(RVA = "0x58418C", Offset = "0x58418C", VA = "0x58418C")]
		public void OnConditionsComplete()
		{
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004594")]
		[Address(RVA = "0x5845A4", Offset = "0x5845A4", VA = "0x5845A4")]
		private void OnConditionComplete(AchievementCondition condition)
		{
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004595")]
		[Address(RVA = "0x584624", Offset = "0x584624", VA = "0x584624")]
		private void UseTracker(IAchievementTracker tracker)
		{
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004596")]
		[Address(RVA = "0x584714", Offset = "0x584714", VA = "0x584714")]
		public void UseTrackerFromCondition(string conditionName)
		{
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004597")]
		[Address(RVA = "0x584860", Offset = "0x584860", VA = "0x584860")]
		public void UseConditionsCompletedTracker()
		{
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004598")]
		[Address(RVA = "0x584D08", Offset = "0x584D08", VA = "0x584D08")]
		public void UseConditionsCompletedTracker(string[] conditions)
		{
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004599")]
		[Address(RVA = "0x584E18", Offset = "0x584E18", VA = "0x584E18")]
		public void ClearTracker()
		{
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459A")]
		[Address(RVA = "0x5847C0", Offset = "0x5847C0", VA = "0x5847C0")]
		private IAchievementTracker GetConditionTracker(string name)
		{
			return null;
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459B")]
		[Address(RVA = "0x584E54", Offset = "0x584E54", VA = "0x584E54")]
		public void AddConditions(AchievementCondition[] conditions)
		{
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459C")]
		[Address(RVA = "0x584EA0", Offset = "0x584EA0", VA = "0x584EA0")]
		public AchievementCondition GetCondition(string conditionName)
		{
			return null;
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459D")]
		[Address(RVA = "0x584F2C", Offset = "0x584F2C", VA = "0x584F2C")]
		public void SetCategory(AchievementCategory category)
		{
		}

		// Token: 0x04008CEB RID: 36075
		[Token(Token = "0x4008CEB")]
		[FieldOffset(Offset = "0x0")]
		private static int _totalAchievements;

		// Token: 0x04008CEC RID: 36076
		[Token(Token = "0x4008CEC")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Name;

		// Token: 0x04008CED RID: 36077
		[Token(Token = "0x4008CED")]
		[FieldOffset(Offset = "0xC")]
		public readonly LocalizedText FriendlyName;

		// Token: 0x04008CEE RID: 36078
		[Token(Token = "0x4008CEE")]
		[FieldOffset(Offset = "0x10")]
		public readonly LocalizedText Description;

		// Token: 0x04008CEF RID: 36079
		[Token(Token = "0x4008CEF")]
		[FieldOffset(Offset = "0x14")]
		public readonly int Id;

		// Token: 0x04008CF0 RID: 36080
		[Token(Token = "0x4008CF0")]
		[FieldOffset(Offset = "0x18")]
		private AchievementCategory _category;

		// Token: 0x04008CF1 RID: 36081
		[Token(Token = "0x4008CF1")]
		[FieldOffset(Offset = "0x1C")]
		private IAchievementTracker _tracker;

		// Token: 0x04008CF3 RID: 36083
		[Token(Token = "0x4008CF3")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<string, AchievementCondition> _conditions;

		// Token: 0x04008CF4 RID: 36084
		[Token(Token = "0x4008CF4")]
		[FieldOffset(Offset = "0x28")]
		private int _completedCount;

		// Token: 0x020007E2 RID: 2018
		// (Invoke) Token: 0x0600459F RID: 17823
		[Token(Token = "0x20007E2")]
		public delegate void AchievementCompleted(Achievement achievement);
	}
}
