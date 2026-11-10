using System;
using Il2CppDummyDll;
using Terraria.Net;
using Terraria.Social.Base;

namespace Terraria.Social.Discord
{
	// Token: 0x0200062C RID: 1580
	[Token(Token = "0x200062C")]
	public class RichPresenceSocialModule : FileAPI
	{
		// Token: 0x06003D99 RID: 15769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D99")]
		[Address(RVA = "0x1E677B8", Offset = "0x1E677B8", VA = "0x1E677B8", Slot = "4")]
		public void Initialize()
		{
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9A")]
		[Address(RVA = "0x1E678D4", Offset = "0x1E678D4", VA = "0x1E678D4", Slot = "5")]
		public void Shutdown()
		{
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9B")]
		[Address(RVA = "0x1E679A0", Offset = "0x1E679A0", VA = "0x1E679A0")]
		private void UpdatePresence()
		{
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9C")]
		[Address(RVA = "0x1E67B14", Offset = "0x1E67B14", VA = "0x1E67B14")]
		private void PublishPresence(RichPresenceState state)
		{
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x0001EA38 File Offset: 0x0001CC38
		[Token(Token = "0x6003D9D")]
		[Address(RVA = "0x1E67D0C", Offset = "0x1E67D0C", VA = "0x1E67D0C")]
		private bool ShouldAllowJoinRequests(RichPresenceState state)
		{
			return default(bool);
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D9E")]
		[Address(RVA = "0x1E67D34", Offset = "0x1E67D34", VA = "0x1E67D34")]
		private string GetJoinSecret()
		{
			return null;
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9F")]
		[Address(RVA = "0x1E67D58", Offset = "0x1E67D58", VA = "0x1E67D58")]
		public RichPresenceSocialModule()
		{
		}

		// Token: 0x0400486B RID: 18539
		[Token(Token = "0x400486B")]
		[FieldOffset(Offset = "0x8")]
		private RichPresenceState _lastState;

		// Token: 0x0400486C RID: 18540
		[Token(Token = "0x400486C")]
		[FieldOffset(Offset = "0xC")]
		private Guid _uniquePartyId;

		// Token: 0x0400486D RID: 18541
		[Token(Token = "0x400486D")]
		[FieldOffset(Offset = "0x1C")]
		private NetGroupInfo _infoAboutNetGroup;
	}
}
