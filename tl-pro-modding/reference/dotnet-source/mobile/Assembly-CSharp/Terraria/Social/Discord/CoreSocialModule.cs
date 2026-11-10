using System;
using Il2CppDummyDll;

namespace Terraria.Social.Discord
{
	// Token: 0x0200061B RID: 1563
	[Token(Token = "0x200061B")]
	public class CoreSocialModule : FileAPI
	{
		// Token: 0x06003D58 RID: 15704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D58")]
		[Address(RVA = "0x1E63FC0", Offset = "0x1E63FC0", VA = "0x1E63FC0", Slot = "4")]
		public void Initialize()
		{
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D59")]
		[Address(RVA = "0x1E647F0", Offset = "0x1E647F0", VA = "0x1E647F0", Slot = "5")]
		public void Shutdown()
		{
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5A")]
		[Address(RVA = "0x1E64F10", Offset = "0x1E64F10", VA = "0x1E64F10")]
		private void Pulse()
		{
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5B")]
		[Address(RVA = "0x1E65030", Offset = "0x1E65030", VA = "0x1E65030")]
		public CoreSocialModule()
		{
		}

		// Token: 0x0400482F RID: 18479
		[Token(Token = "0x400482F")]
		[FieldOffset(Offset = "0x8")]
		private string TERRARIA_STEAM_APPLICATION_ID;

		// Token: 0x04004830 RID: 18480
		[Token(Token = "0x4004830")]
		private const string TERRARIA_DISCORD_APPLICATION_ID = "356943499456937984";

		// Token: 0x04004831 RID: 18481
		[Token(Token = "0x4004831")]
		private const bool AUTO_REGISTER_STEAM = false;

		// Token: 0x04004832 RID: 18482
		[Token(Token = "0x4004832")]
		[FieldOffset(Offset = "0x0")]
		public static DiscordHooks Hooks;

		// Token: 0x04004833 RID: 18483
		[Token(Token = "0x4004833")]
		[FieldOffset(Offset = "0xC")]
		private DiscordRpc.EventHandlers _handlers;
	}
}
