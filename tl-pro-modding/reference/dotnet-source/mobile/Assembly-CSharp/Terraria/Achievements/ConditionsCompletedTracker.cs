using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.Achievements
{
	// Token: 0x020007EB RID: 2027
	[Token(Token = "0x20007EB")]
	public class ConditionsCompletedTracker : ConditionIntTracker
	{
		// Token: 0x060045D8 RID: 17880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D8")]
		[Address(RVA = "0x584B3C", Offset = "0x584B3C", VA = "0x584B3C")]
		public void AddCondition(AchievementCondition condition)
		{
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D9")]
		[Address(RVA = "0x587D10", Offset = "0x587D10", VA = "0x587D10")]
		private void OnConditionCompleted(AchievementCondition condition)
		{
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DA")]
		[Address(RVA = "0x587DB4", Offset = "0x587DB4", VA = "0x587DB4", Slot = "9")]
		protected override void Load()
		{
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DB")]
		[Address(RVA = "0x584A64", Offset = "0x584A64", VA = "0x584A64")]
		public ConditionsCompletedTracker()
		{
		}

		// Token: 0x04008D0D RID: 36109
		[Token(Token = "0x4008D0D")]
		[FieldOffset(Offset = "0x18")]
		private List<AchievementCondition> _conditions;
	}
}
