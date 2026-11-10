using System;
using Il2CppDummyDll;

namespace Terraria.Testing
{
	// Token: 0x020005EF RID: 1519
	[Token(Token = "0x20005EF")]
	public static class WorldUpdateStepper
	{
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06003C62 RID: 15458 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
		// (set) Token: 0x06003C63 RID: 15459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700079F")]
		public static bool Paused
		{
			[Token(Token = "0x6003C62")]
			[Address(RVA = "0x1E59C94", Offset = "0x1E59C94", VA = "0x1E59C94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003C63")]
			[Address(RVA = "0x1E59CE4", Offset = "0x1E59CE4", VA = "0x1E59CE4")]
			private set
			{
			}
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x0001E708 File Offset: 0x0001C908
		[Token(Token = "0x6003C64")]
		[Address(RVA = "0x1E59D38", Offset = "0x1E59D38", VA = "0x1E59D38")]
		public static bool ShouldUpdateWorld()
		{
			return default(bool);
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C65")]
		[Address(RVA = "0x1E59E4C", Offset = "0x1E59E4C", VA = "0x1E59E4C")]
		private static void GetStepKeyState(out bool down, out bool wasDown)
		{
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C66")]
		[Address(RVA = "0x1E5A074", Offset = "0x1E5A074", VA = "0x1E5A074")]
		public static void TogglePaused()
		{
		}

		// Token: 0x040047B7 RID: 18359
		[Token(Token = "0x40047B7")]
		[FieldOffset(Offset = "0x0")]
		public static bool DrawnThisUpdate;

		// Token: 0x040047B8 RID: 18360
		[Token(Token = "0x40047B8")]
		[FieldOffset(Offset = "0x1")]
		private static bool <Paused>k__BackingField;

		// Token: 0x040047B9 RID: 18361
		[Token(Token = "0x40047B9")]
		[FieldOffset(Offset = "0x4")]
		private static uint StartUpdateCount;

		// Token: 0x040047BA RID: 18362
		[Token(Token = "0x40047BA")]
		[FieldOffset(Offset = "0x8")]
		private static int StepHeldCount;
	}
}
