using System;
using Il2CppDummyDll;

namespace Terraria.Social.Discord
{
	// Token: 0x0200061C RID: 1564
	[Token(Token = "0x200061C")]
	public class DiscordHooks
	{
		// Token: 0x06003D5C RID: 15708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5C")]
		[Address(RVA = "0x1E64170", Offset = "0x1E64170", VA = "0x1E64170")]
		public void RegisterTo(ref DiscordRpc.EventHandlers handlers)
		{
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5D")]
		[Address(RVA = "0x1E64984", Offset = "0x1E64984", VA = "0x1E64984")]
		public void UnRegisterFrom(ref DiscordRpc.EventHandlers handlers)
		{
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5E")]
		[Address(RVA = "0x1E655D4", Offset = "0x1E655D4", VA = "0x1E655D4")]
		private void OnReadyInfo(ref DiscordRpc.DiscordUser connectedUser)
		{
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5F")]
		[Address(RVA = "0x1E655F0", Offset = "0x1E655F0", VA = "0x1E655F0")]
		private void OnDisconnectedInfo(int errorCode, string message)
		{
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D60")]
		[Address(RVA = "0x1E6560C", Offset = "0x1E6560C", VA = "0x1E6560C")]
		private void OnErrorInfo(int errorCode, string message)
		{
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D61")]
		[Address(RVA = "0x1E65628", Offset = "0x1E65628", VA = "0x1E65628")]
		private void OnJoinInfo(string secret)
		{
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D62")]
		[Address(RVA = "0x1E65644", Offset = "0x1E65644", VA = "0x1E65644")]
		private void OnSpectateInfo(string secret)
		{
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D63")]
		[Address(RVA = "0x1E65660", Offset = "0x1E65660", VA = "0x1E65660")]
		private void OnRequestInfo(ref DiscordRpc.DiscordUser request)
		{
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D64")]
		[Address(RVA = "0x1E64168", Offset = "0x1E64168", VA = "0x1E64168")]
		public DiscordHooks()
		{
		}

		// Token: 0x04004834 RID: 18484
		[Token(Token = "0x4004834")]
		[FieldOffset(Offset = "0x8")]
		public DiscordRpc.OnReadyInfo readyCallback;

		// Token: 0x04004835 RID: 18485
		[Token(Token = "0x4004835")]
		[FieldOffset(Offset = "0xC")]
		public DiscordRpc.OnDisconnectedInfo disconnectedCallback;

		// Token: 0x04004836 RID: 18486
		[Token(Token = "0x4004836")]
		[FieldOffset(Offset = "0x10")]
		public DiscordRpc.OnErrorInfo errorCallback;

		// Token: 0x04004837 RID: 18487
		[Token(Token = "0x4004837")]
		[FieldOffset(Offset = "0x14")]
		public DiscordRpc.OnJoinInfo joinCallback;

		// Token: 0x04004838 RID: 18488
		[Token(Token = "0x4004838")]
		[FieldOffset(Offset = "0x18")]
		public DiscordRpc.OnSpectateInfo spectateCallback;

		// Token: 0x04004839 RID: 18489
		[Token(Token = "0x4004839")]
		[FieldOffset(Offset = "0x1C")]
		public DiscordRpc.OnRequestInfo requestCallback;
	}
}
