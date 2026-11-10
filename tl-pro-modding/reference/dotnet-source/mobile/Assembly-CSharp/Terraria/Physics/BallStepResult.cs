using System;
using Il2CppDummyDll;

namespace Terraria.Physics
{
	// Token: 0x0200064A RID: 1610
	[Token(Token = "0x200064A")]
	public struct BallStepResult
	{
		// Token: 0x06003E56 RID: 15958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x1E6D35C", Offset = "0x1E6D35C", VA = "0x1E6D35C")]
		private BallStepResult(BallState state)
		{
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x0001EC48 File Offset: 0x0001CE48
		[Token(Token = "0x6003E57")]
		[Address(RVA = "0x1E6AEE8", Offset = "0x1E6AEE8", VA = "0x1E6AEE8")]
		public static BallStepResult OutOfBounds()
		{
			return default(BallStepResult);
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x0001EC60 File Offset: 0x0001CE60
		[Token(Token = "0x6003E58")]
		[Address(RVA = "0x1E6B370", Offset = "0x1E6B370", VA = "0x1E6B370")]
		public static BallStepResult Moving()
		{
			return default(BallStepResult);
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x0001EC78 File Offset: 0x0001CE78
		[Token(Token = "0x6003E59")]
		[Address(RVA = "0x1E6B378", Offset = "0x1E6B378", VA = "0x1E6B378")]
		public static BallStepResult Resting()
		{
			return default(BallStepResult);
		}

		// Token: 0x040048B5 RID: 18613
		[Token(Token = "0x40048B5")]
		[FieldOffset(Offset = "0x0")]
		public readonly BallState State;
	}
}
