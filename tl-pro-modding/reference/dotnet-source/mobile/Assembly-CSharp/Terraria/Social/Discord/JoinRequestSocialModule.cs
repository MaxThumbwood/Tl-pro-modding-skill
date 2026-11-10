using System;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria.Social.Discord
{
	// Token: 0x02000629 RID: 1577
	[Token(Token = "0x2000629")]
	public class JoinRequestSocialModule : FileAPI
	{
		// Token: 0x06003D8B RID: 15755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8B")]
		[Address(RVA = "0x1E664B8", Offset = "0x1E664B8", VA = "0x1E664B8", Slot = "4")]
		public void Initialize()
		{
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8C")]
		[Address(RVA = "0x1E66710", Offset = "0x1E66710", VA = "0x1E66710", Slot = "5")]
		public void Shutdown()
		{
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8D")]
		[Address(RVA = "0x1E66924", Offset = "0x1E66924", VA = "0x1E66924")]
		private void ReceiveJoinRequest(ref DiscordRpc.DiscordUser request)
		{
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8E")]
		[Address(RVA = "0x1E67288", Offset = "0x1E67288", VA = "0x1E67288")]
		private void ReceiveJoinCallback(string secret)
		{
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8F")]
		[Address(RVA = "0x1E67318", Offset = "0x1E67318", VA = "0x1E67318")]
		private void TestSecretIsWhatWeExpectItToBe(string secret)
		{
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
		[Token(Token = "0x6003D90")]
		[Address(RVA = "0x1E673A8", Offset = "0x1E673A8", VA = "0x1E673A8")]
		private bool CanJoinGame()
		{
			return default(bool);
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D91")]
		[Address(RVA = "0x1E67408", Offset = "0x1E67408", VA = "0x1E67408")]
		public JoinRequestSocialModule()
		{
		}

		// Token: 0x04004868 RID: 18536
		[Token(Token = "0x4004868")]
		[FieldOffset(Offset = "0x8")]
		private NetGroupInfo _infoAboutNetGroup;

		// Token: 0x0200062A RID: 1578
		[Token(Token = "0x200062A")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003D92 RID: 15762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D92")]
			[Address(RVA = "0x1E66C2C", Offset = "0x1E66C2C", VA = "0x1E66C2C")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06003D93 RID: 15763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D93")]
			[Address(RVA = "0x1E67410", Offset = "0x1E67410", VA = "0x1E67410")]
			internal void <ReceiveJoinRequest>b__0()
			{
			}

			// Token: 0x06003D94 RID: 15764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D94")]
			[Address(RVA = "0x1E674D0", Offset = "0x1E674D0", VA = "0x1E674D0")]
			internal void <ReceiveJoinRequest>b__1()
			{
			}

			// Token: 0x04004869 RID: 18537
			[Token(Token = "0x4004869")]
			[FieldOffset(Offset = "0x8")]
			public string userId;
		}
	}
}
