using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x02000631 RID: 1585
	[Token(Token = "0x2000631")]
	public abstract class DLCSocialModule : FileAPI
	{
		// Token: 0x06003DBD RID: 15805
		[Token(Token = "0x6003DBD")]
		public abstract void Initialize();

		// Token: 0x06003DBE RID: 15806
		[Token(Token = "0x6003DBE")]
		public abstract void Shutdown();

		// Token: 0x06003DBF RID: 15807
		[Token(Token = "0x6003DBF")]
		public abstract bool HasDLC(DLCName dlc);

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC0")]
		[Address(RVA = "0x1E68008", Offset = "0x1E68008", VA = "0x1E68008")]
		protected DLCSocialModule()
		{
		}
	}
}
