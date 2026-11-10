using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x02000636 RID: 1590
	[Token(Token = "0x2000636")]
	public class RichPresenceState : FileAPI
	{
		// Token: 0x06003DDF RID: 15839 RVA: 0x0001EA68 File Offset: 0x0001CC68
		[Token(Token = "0x6003DDF")]
		[Address(RVA = "0x1E67AE8", Offset = "0x1E67AE8", VA = "0x1E67AE8", Slot = "4")]
		public bool Equals(RichPresenceState other)
		{
			return default(bool);
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE0")]
		[Address(RVA = "0x1E679EC", Offset = "0x1E679EC", VA = "0x1E679EC")]
		public static RichPresenceState GetCurrentState()
		{
			return null;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE1")]
		[Address(RVA = "0x1E68028", Offset = "0x1E68028", VA = "0x1E68028")]
		public RichPresenceState()
		{
		}

		// Token: 0x04004873 RID: 18547
		[Token(Token = "0x4004873")]
		[FieldOffset(Offset = "0x8")]
		public RichPresenceState.GameModeState GameMode;

		// Token: 0x02000637 RID: 1591
		[Token(Token = "0x2000637")]
		public enum GameModeState
		{
			// Token: 0x04004875 RID: 18549
			[Token(Token = "0x4004875")]
			InMainMenu,
			// Token: 0x04004876 RID: 18550
			[Token(Token = "0x4004876")]
			CreatingPlayer,
			// Token: 0x04004877 RID: 18551
			[Token(Token = "0x4004877")]
			CreatingWorld,
			// Token: 0x04004878 RID: 18552
			[Token(Token = "0x4004878")]
			PlayingSingle,
			// Token: 0x04004879 RID: 18553
			[Token(Token = "0x4004879")]
			PlayingMulti
		}
	}
}
