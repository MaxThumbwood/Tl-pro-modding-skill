using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x02000635 RID: 1589
	[Token(Token = "0x2000635")]
	public abstract class PlatformSocialModule : FileAPI
	{
		// Token: 0x06003DDC RID: 15836
		[Token(Token = "0x6003DDC")]
		public abstract void Initialize();

		// Token: 0x06003DDD RID: 15837
		[Token(Token = "0x6003DDD")]
		public abstract void Shutdown();

		// Token: 0x06003DDE RID: 15838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x1E62BFC", Offset = "0x1E62BFC", VA = "0x1E62BFC")]
		protected PlatformSocialModule()
		{
		}
	}
}
