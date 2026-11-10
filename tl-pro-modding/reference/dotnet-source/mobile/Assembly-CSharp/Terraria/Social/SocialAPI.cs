using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.Social.Base;

namespace Terraria.Social
{
	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	public static class SocialAPI
	{
		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x0001E8D0 File Offset: 0x0001CAD0
		[Token(Token = "0x170007AB")]
		public static SocialMode Mode
		{
			[Token(Token = "0x6003D31")]
			[Address(RVA = "0x1E61C98", Offset = "0x1E61C98", VA = "0x1E61C98")]
			get
			{
				return SocialMode.None;
			}
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D32")]
		[Address(RVA = "0x1E61CE8", Offset = "0x1E61CE8", VA = "0x1E61CE8")]
		public static void Initialize([Optional] SocialMode? mode)
		{
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D33")]
		[Address(RVA = "0x1E62244", Offset = "0x1E62244", VA = "0x1E62244")]
		public static void Shutdown()
		{
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D34")]
		private static T LoadModule<T>() where T : ISocialModule, new()
		{
			return null;
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D35")]
		private static T LoadModule<T>(T module) where T : ISocialModule
		{
			return null;
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D36")]
		[Address(RVA = "0x1E624B0", Offset = "0x1E624B0", VA = "0x1E624B0")]
		private static void LoadDiscord()
		{
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D37")]
		[Address(RVA = "0x1E62240", Offset = "0x1E62240", VA = "0x1E62240")]
		private static void LoadSteam()
		{
		}

		// Token: 0x0400481B RID: 18459
		[Token(Token = "0x400481B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SocialMode _mode;

		// Token: 0x0400481C RID: 18460
		[Token(Token = "0x400481C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static FriendsSocialModule Friends;

		// Token: 0x0400481D RID: 18461
		[Token(Token = "0x400481D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static AchievementsSocialModule Achievements;

		// Token: 0x0400481E RID: 18462
		[Token(Token = "0x400481E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static CloudSocialModule Cloud;

		// Token: 0x0400481F RID: 18463
		[Token(Token = "0x400481F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static NetSocialModule Network;

		// Token: 0x04004820 RID: 18464
		[Token(Token = "0x4004820")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static OverlaySocialModule Overlay;

		// Token: 0x04004821 RID: 18465
		[Token(Token = "0x4004821")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static ServerJoinRequestsManager JoinRequests;

		// Token: 0x04004822 RID: 18466
		[Token(Token = "0x4004822")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static PlatformSocialModule Platform;

		// Token: 0x04004823 RID: 18467
		[Token(Token = "0x4004823")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<ISocialModule> _modules;
	}
}
