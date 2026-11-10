using System;
using Il2CppDummyDll;
using Terraria.Social.Base;

namespace Terraria.Social.Discord
{
	// Token: 0x0200062B RID: 1579
	[Token(Token = "0x200062B")]
	public class DiscordJoinToServerRequest : UserJoinToServerRequest, FileAPI
	{
		// Token: 0x06003D95 RID: 15765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D95")]
		[Address(RVA = "0x1E66C34", Offset = "0x1E66C34", VA = "0x1E66C34")]
		public DiscordJoinToServerRequest(string userDisplayName, string fullIdentifier, int durationInSeconds = 30)
		{
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x0001EA08 File Offset: 0x0001CC08
		[Token(Token = "0x6003D96")]
		[Address(RVA = "0x1E675A8", Offset = "0x1E675A8", VA = "0x1E675A8", Slot = "4")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D97")]
		[Address(RVA = "0x1E67648", Offset = "0x1E67648", VA = "0x1E67648", Slot = "5")]
		public override string GetUserWrapperText()
		{
			return null;
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x0001EA20 File Offset: 0x0001CC20
		[Token(Token = "0x6003D98")]
		[Address(RVA = "0x1E6778C", Offset = "0x1E6778C", VA = "0x1E6778C", Slot = "6")]
		public bool Equals(DiscordJoinToServerRequest other)
		{
			return default(bool);
		}

		// Token: 0x0400486A RID: 18538
		[Token(Token = "0x400486A")]
		[FieldOffset(Offset = "0x18")]
		private DateTime _expirationTime;
	}
}
