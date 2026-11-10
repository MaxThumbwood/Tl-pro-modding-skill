using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Social.Discord
{
	// Token: 0x0200061D RID: 1565
	[Token(Token = "0x200061D")]
	public class DiscordRpc
	{
		// Token: 0x06003D65 RID: 15717
		[Token(Token = "0x6003D65")]
		[Address(RVA = "0x1E64670", Offset = "0x1E64670", VA = "0x1E64670")]
		[PreserveSig]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x06003D66 RID: 15718
		[Token(Token = "0x6003D66")]
		[Address(RVA = "0x1E64E80", Offset = "0x1E64E80", VA = "0x1E64E80")]
		[PreserveSig]
		public static extern void Shutdown();

		// Token: 0x06003D67 RID: 15719
		[Token(Token = "0x6003D67")]
		[Address(RVA = "0x1E64FA0", Offset = "0x1E64FA0", VA = "0x1E64FA0")]
		[PreserveSig]
		public static extern void RunCallbacks();

		// Token: 0x06003D68 RID: 15720
		[Token(Token = "0x6003D68")]
		[Address(RVA = "0x1E65680", Offset = "0x1E65680", VA = "0x1E65680")]
		[PreserveSig]
		private static extern void UpdatePresenceNative(ref DiscordRpc.RichPresenceStruct presence);

		// Token: 0x06003D69 RID: 15721
		[Token(Token = "0x6003D69")]
		[Address(RVA = "0x1E657F0", Offset = "0x1E657F0", VA = "0x1E657F0")]
		[PreserveSig]
		public static extern void ClearPresence();

		// Token: 0x06003D6A RID: 15722
		[Token(Token = "0x6003D6A")]
		[Address(RVA = "0x1E65880", Offset = "0x1E65880", VA = "0x1E65880")]
		[PreserveSig]
		public static extern void Respond(string userId, DiscordRpc.Reply reply);

		// Token: 0x06003D6B RID: 15723
		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x1E65950", Offset = "0x1E65950", VA = "0x1E65950")]
		[PreserveSig]
		public static extern void UpdateHandlers(ref DiscordRpc.EventHandlers handlers);

		// Token: 0x06003D6C RID: 15724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x1E65A84", Offset = "0x1E65A84", VA = "0x1E65A84")]
		public static void UpdatePresence(DiscordRpc.RichPresence presence)
		{
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x1E65D74", Offset = "0x1E65D74", VA = "0x1E65D74")]
		public DiscordRpc()
		{
		}

		// Token: 0x0200061E RID: 1566
		// (Invoke) Token: 0x06003D6F RID: 15727
		[Token(Token = "0x200061E")]
		public delegate void OnReadyInfo(ref DiscordRpc.DiscordUser connectedUser);

		// Token: 0x0200061F RID: 1567
		// (Invoke) Token: 0x06003D73 RID: 15731
		[Token(Token = "0x200061F")]
		public delegate void OnDisconnectedInfo(int errorCode, string message);

		// Token: 0x02000620 RID: 1568
		// (Invoke) Token: 0x06003D77 RID: 15735
		[Token(Token = "0x2000620")]
		public delegate void OnErrorInfo(int errorCode, string message);

		// Token: 0x02000621 RID: 1569
		// (Invoke) Token: 0x06003D7B RID: 15739
		[Token(Token = "0x2000621")]
		public delegate void OnJoinInfo(string secret);

		// Token: 0x02000622 RID: 1570
		// (Invoke) Token: 0x06003D7F RID: 15743
		[Token(Token = "0x2000622")]
		public delegate void OnSpectateInfo(string secret);

		// Token: 0x02000623 RID: 1571
		// (Invoke) Token: 0x06003D83 RID: 15747
		[Token(Token = "0x2000623")]
		public delegate void OnRequestInfo(ref DiscordRpc.DiscordUser request);

		// Token: 0x02000624 RID: 1572
		[Token(Token = "0x2000624")]
		public struct EventHandlers
		{
			// Token: 0x0400483A RID: 18490
			[Token(Token = "0x400483A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DiscordRpc.OnReadyInfo readyCallback;

			// Token: 0x0400483B RID: 18491
			[Token(Token = "0x400483B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public DiscordRpc.OnDisconnectedInfo disconnectedCallback;

			// Token: 0x0400483C RID: 18492
			[Token(Token = "0x400483C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public DiscordRpc.OnErrorInfo errorCallback;

			// Token: 0x0400483D RID: 18493
			[Token(Token = "0x400483D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public DiscordRpc.OnJoinInfo joinCallback;

			// Token: 0x0400483E RID: 18494
			[Token(Token = "0x400483E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DiscordRpc.OnSpectateInfo spectateCallback;

			// Token: 0x0400483F RID: 18495
			[Token(Token = "0x400483F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public DiscordRpc.OnRequestInfo requestCallback;
		}

		// Token: 0x02000625 RID: 1573
		[Token(Token = "0x2000625")]
		[Serializable]
		public struct RichPresenceStruct
		{
			// Token: 0x04004840 RID: 18496
			[Token(Token = "0x4004840")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr state;

			// Token: 0x04004841 RID: 18497
			[Token(Token = "0x4004841")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public IntPtr details;

			// Token: 0x04004842 RID: 18498
			[Token(Token = "0x4004842")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long startTimestamp;

			// Token: 0x04004843 RID: 18499
			[Token(Token = "0x4004843")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long endTimestamp;

			// Token: 0x04004844 RID: 18500
			[Token(Token = "0x4004844")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IntPtr largeImageKey;

			// Token: 0x04004845 RID: 18501
			[Token(Token = "0x4004845")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public IntPtr largeImageText;

			// Token: 0x04004846 RID: 18502
			[Token(Token = "0x4004846")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IntPtr smallImageKey;

			// Token: 0x04004847 RID: 18503
			[Token(Token = "0x4004847")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public IntPtr smallImageText;

			// Token: 0x04004848 RID: 18504
			[Token(Token = "0x4004848")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IntPtr partyId;

			// Token: 0x04004849 RID: 18505
			[Token(Token = "0x4004849")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int partySize;

			// Token: 0x0400484A RID: 18506
			[Token(Token = "0x400484A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int partyMax;

			// Token: 0x0400484B RID: 18507
			[Token(Token = "0x400484B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public IntPtr matchSecret;

			// Token: 0x0400484C RID: 18508
			[Token(Token = "0x400484C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public IntPtr joinSecret;

			// Token: 0x0400484D RID: 18509
			[Token(Token = "0x400484D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public IntPtr spectateSecret;

			// Token: 0x0400484E RID: 18510
			[Token(Token = "0x400484E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool instance;
		}

		// Token: 0x02000626 RID: 1574
		[Token(Token = "0x2000626")]
		[Serializable]
		public struct DiscordUser
		{
			// Token: 0x0400484F RID: 18511
			[Token(Token = "0x400484F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string userId;

			// Token: 0x04004850 RID: 18512
			[Token(Token = "0x4004850")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public string username;

			// Token: 0x04004851 RID: 18513
			[Token(Token = "0x4004851")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string discriminator;

			// Token: 0x04004852 RID: 18514
			[Token(Token = "0x4004852")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public string avatar;
		}

		// Token: 0x02000627 RID: 1575
		[Token(Token = "0x2000627")]
		public enum Reply
		{
			// Token: 0x04004854 RID: 18516
			[Token(Token = "0x4004854")]
			No,
			// Token: 0x04004855 RID: 18517
			[Token(Token = "0x4004855")]
			Yes,
			// Token: 0x04004856 RID: 18518
			[Token(Token = "0x4004856")]
			Ignore
		}

		// Token: 0x02000628 RID: 1576
		[Token(Token = "0x2000628")]
		public class RichPresence
		{
			// Token: 0x06003D86 RID: 15750 RVA: 0x0001E9C0 File Offset: 0x0001CBC0
			[Token(Token = "0x6003D86")]
			[Address(RVA = "0x1E65B18", Offset = "0x1E65B18", VA = "0x1E65B18")]
			internal DiscordRpc.RichPresenceStruct GetStruct()
			{
				return default(DiscordRpc.RichPresenceStruct);
			}

			// Token: 0x06003D87 RID: 15751 RVA: 0x0001E9D8 File Offset: 0x0001CBD8
			[Token(Token = "0x6003D87")]
			[Address(RVA = "0x1E660BC", Offset = "0x1E660BC", VA = "0x1E660BC")]
			private IntPtr StrToPtr(string input)
			{
				return 0;
			}

			// Token: 0x06003D88 RID: 15752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D88")]
			[Address(RVA = "0x1E662E8", Offset = "0x1E662E8", VA = "0x1E662E8")]
			private static string StrToUtf8NullTerm(string toconv)
			{
				return null;
			}

			// Token: 0x06003D89 RID: 15753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D89")]
			[Address(RVA = "0x1E65C50", Offset = "0x1E65C50", VA = "0x1E65C50")]
			internal void FreeMem()
			{
			}

			// Token: 0x06003D8A RID: 15754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D8A")]
			[Address(RVA = "0x1E6641C", Offset = "0x1E6641C", VA = "0x1E6641C")]
			public RichPresence()
			{
			}

			// Token: 0x04004857 RID: 18519
			[Token(Token = "0x4004857")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private DiscordRpc.RichPresenceStruct _presence;

			// Token: 0x04004858 RID: 18520
			[Token(Token = "0x4004858")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private readonly List<IntPtr> _buffers;

			// Token: 0x04004859 RID: 18521
			[Token(Token = "0x4004859")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public string state;

			// Token: 0x0400485A RID: 18522
			[Token(Token = "0x400485A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string details;

			// Token: 0x0400485B RID: 18523
			[Token(Token = "0x400485B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public long startTimestamp;

			// Token: 0x0400485C RID: 18524
			[Token(Token = "0x400485C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public long endTimestamp;

			// Token: 0x0400485D RID: 18525
			[Token(Token = "0x400485D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public string largeImageKey;

			// Token: 0x0400485E RID: 18526
			[Token(Token = "0x400485E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public string largeImageText;

			// Token: 0x0400485F RID: 18527
			[Token(Token = "0x400485F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public string smallImageKey;

			// Token: 0x04004860 RID: 18528
			[Token(Token = "0x4004860")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public string smallImageText;

			// Token: 0x04004861 RID: 18529
			[Token(Token = "0x4004861")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public string partyId;

			// Token: 0x04004862 RID: 18530
			[Token(Token = "0x4004862")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public int partySize;

			// Token: 0x04004863 RID: 18531
			[Token(Token = "0x4004863")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public int partyMax;

			// Token: 0x04004864 RID: 18532
			[Token(Token = "0x4004864")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public string matchSecret;

			// Token: 0x04004865 RID: 18533
			[Token(Token = "0x4004865")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public string joinSecret;

			// Token: 0x04004866 RID: 18534
			[Token(Token = "0x4004866")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public string spectateSecret;

			// Token: 0x04004867 RID: 18535
			[Token(Token = "0x4004867")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public bool instance;
		}
	}
}
