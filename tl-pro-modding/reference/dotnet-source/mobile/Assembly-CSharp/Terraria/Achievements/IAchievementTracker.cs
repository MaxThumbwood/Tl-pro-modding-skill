using System;
using Il2CppDummyDll;

namespace Terraria.Achievements
{
	// Token: 0x020007ED RID: 2029
	[Token(Token = "0x20007ED")]
	public interface IAchievementTracker
	{
		// Token: 0x060045DC RID: 17884
		[Token(Token = "0x60045DC")]
		void ReportAs(string name);

		// Token: 0x060045DD RID: 17885
		[Token(Token = "0x60045DD")]
		TrackerType GetTrackerType();

		// Token: 0x060045DE RID: 17886
		[Token(Token = "0x60045DE")]
		void Load();

		// Token: 0x060045DF RID: 17887
		[Token(Token = "0x60045DF")]
		void Clear();
	}
}
