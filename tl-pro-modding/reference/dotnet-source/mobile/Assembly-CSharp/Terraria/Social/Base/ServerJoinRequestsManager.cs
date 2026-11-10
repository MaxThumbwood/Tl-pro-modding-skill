using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x02000639 RID: 1593
	[Token(Token = "0x2000639")]
	public class ServerJoinRequestsManager
	{
		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06003DE6 RID: 15846 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003DE7 RID: 15847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000031")]
		public event ServerJoinRequestEvent OnRequestAdded
		{
			[Token(Token = "0x6003DE6")]
			[Address(RVA = "0x1E681D0", Offset = "0x1E681D0", VA = "0x1E681D0")]
			add
			{
			}
			[Token(Token = "0x6003DE7")]
			[Address(RVA = "0x1E68280", Offset = "0x1E68280", VA = "0x1E68280")]
			remove
			{
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06003DE8 RID: 15848 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003DE9 RID: 15849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000032")]
		public event ServerJoinRequestEvent OnRequestRemoved
		{
			[Token(Token = "0x6003DE8")]
			[Address(RVA = "0x1E68330", Offset = "0x1E68330", VA = "0x1E68330")]
			add
			{
			}
			[Token(Token = "0x6003DE9")]
			[Address(RVA = "0x1E683E0", Offset = "0x1E683E0", VA = "0x1E683E0")]
			remove
			{
			}
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEA")]
		[Address(RVA = "0x1E62144", Offset = "0x1E62144", VA = "0x1E62144")]
		public ServerJoinRequestsManager()
		{
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEB")]
		[Address(RVA = "0x1E68490", Offset = "0x1E68490", VA = "0x1E68490")]
		public void Update()
		{
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEC")]
		[Address(RVA = "0x1E66E68", Offset = "0x1E66E68", VA = "0x1E66E68")]
		public void Add(UserJoinToServerRequest request)
		{
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DED")]
		[Address(RVA = "0x1E68570", Offset = "0x1E68570", VA = "0x1E68570")]
		private void RemoveRequestAtIndex(int i)
		{
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x1E68648", Offset = "0x1E68648", VA = "0x1E68648")]
		private void RemoveRequest(UserJoinToServerRequest request)
		{
		}

		// Token: 0x0400487A RID: 18554
		[Token(Token = "0x400487A")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<UserJoinToServerRequest> _requests;

		// Token: 0x0400487B RID: 18555
		[Token(Token = "0x400487B")]
		[FieldOffset(Offset = "0xC")]
		public readonly ReadOnlyCollection<UserJoinToServerRequest> CurrentRequests;

		// Token: 0x0200063A RID: 1594
		[Token(Token = "0x200063A")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003DEF RID: 15855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003DEF")]
			[Address(RVA = "0x1E68640", Offset = "0x1E68640", VA = "0x1E68640")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06003DF0 RID: 15856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003DF0")]
			[Address(RVA = "0x1E686D8", Offset = "0x1E686D8", VA = "0x1E686D8")]
			internal void <Add>b__0()
			{
			}

			// Token: 0x06003DF1 RID: 15857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003DF1")]
			[Address(RVA = "0x1E68774", Offset = "0x1E68774", VA = "0x1E68774")]
			internal void <Add>b__1()
			{
			}

			// Token: 0x0400487E RID: 18558
			[Token(Token = "0x400487E")]
			[FieldOffset(Offset = "0x8")]
			public ServerJoinRequestsManager <>4__this;

			// Token: 0x0400487F RID: 18559
			[Token(Token = "0x400487F")]
			[FieldOffset(Offset = "0xC")]
			public UserJoinToServerRequest request;
		}
	}
}
