using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x0200063D RID: 1597
	[Token(Token = "0x200063D")]
	public abstract class AWorkshopProgressReporter
	{
		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06003E0E RID: 15886
		[Token(Token = "0x170007AE")]
		public abstract bool HasOngoingTasks
		{
			[Token(Token = "0x6003E0E")]
			get;
		}

		// Token: 0x06003E0F RID: 15887
		[Token(Token = "0x6003E0F")]
		public abstract bool TryGetProgress(out float progress);

		// Token: 0x06003E10 RID: 15888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E10")]
		[Address(RVA = "0x1E6939C", Offset = "0x1E6939C", VA = "0x1E6939C")]
		protected AWorkshopProgressReporter()
		{
		}
	}
}
