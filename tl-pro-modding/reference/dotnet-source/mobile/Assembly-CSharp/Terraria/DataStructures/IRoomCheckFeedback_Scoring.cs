using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	public interface IRoomCheckFeedback_Scoring
	{
		// Token: 0x060042FF RID: 17151
		[Token(Token = "0x60042FF")]
		void BeginScoring();

		// Token: 0x06004300 RID: 17152
		[Token(Token = "0x6004300")]
		void ReportScore(int x, int y, int score);

		// Token: 0x06004301 RID: 17153
		[Token(Token = "0x6004301")]
		void SetAsHighScore(int x, int y, int score);

		// Token: 0x06004302 RID: 17154
		[Token(Token = "0x6004302")]
		void EndScoring();
	}
}
