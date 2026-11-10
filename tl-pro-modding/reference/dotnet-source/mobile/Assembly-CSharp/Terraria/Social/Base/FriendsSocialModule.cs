using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x02000632 RID: 1586
	[Token(Token = "0x2000632")]
	public abstract class FriendsSocialModule : FileAPI
	{
		// Token: 0x06003DC1 RID: 15809
		[Token(Token = "0x6003DC1")]
		public abstract string GetUsername();

		// Token: 0x06003DC2 RID: 15810
		[Token(Token = "0x6003DC2")]
		public abstract void OpenJoinInterface();

		// Token: 0x06003DC3 RID: 15811
		[Token(Token = "0x6003DC3")]
		public abstract void Initialize();

		// Token: 0x06003DC4 RID: 15812
		[Token(Token = "0x6003DC4")]
		public abstract void Shutdown();

		// Token: 0x06003DC5 RID: 15813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x1E68010", Offset = "0x1E68010", VA = "0x1E68010")]
		protected FriendsSocialModule()
		{
		}
	}
}
