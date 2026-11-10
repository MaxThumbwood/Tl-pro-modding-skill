using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria.GameContent
{
	// Token: 0x0200093D RID: 2365
	[Token(Token = "0x200093D")]
	public static class BannerSystem
	{
		// Token: 0x06004F03 RID: 20227 RVA: 0x00024C90 File Offset: 0x00022E90
		[Token(Token = "0x6004F03")]
		[Address(RVA = "0x7452D0", Offset = "0x7452D0", VA = "0x7452D0")]
		public static int GetKillCount(int banner)
		{
			return 0;
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F04")]
		[Address(RVA = "0x74534C", Offset = "0x74534C", VA = "0x74534C")]
		private static void RefreshHasBannerAvailable()
		{
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F05")]
		[Address(RVA = "0x74545C", Offset = "0x74545C", VA = "0x74545C")]
		public static ushort[] GetClaimableBannerCounts()
		{
			return null;
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x00024CA8 File Offset: 0x00022EA8
		[Token(Token = "0x6004F06")]
		[Address(RVA = "0x7454C0", Offset = "0x7454C0", VA = "0x7454C0")]
		public static bool IsNewBanner(int banner)
		{
			return default(bool);
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F07")]
		[Address(RVA = "0x74553C", Offset = "0x74553C", VA = "0x74553C")]
		public static void SetNewBanner(int banner)
		{
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F08")]
		[Address(RVA = "0x7455D4", Offset = "0x7455D4", VA = "0x7455D4")]
		public static void ClearNewBanner(int banner)
		{
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F09")]
		[Address(RVA = "0x745788", Offset = "0x745788", VA = "0x745788")]
		public static void Clear()
		{
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0A")]
		[Address(RVA = "0x745880", Offset = "0x745880", VA = "0x745880")]
		public static void Save(BinaryWriter writer)
		{
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0B")]
		[Address(RVA = "0x745A10", Offset = "0x745A10", VA = "0x745A10")]
		public static void Load(BinaryReader reader, int version)
		{
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0C")]
		[Address(RVA = "0x745C5C", Offset = "0x745C5C", VA = "0x745C5C")]
		public static void ValidateWorld(BinaryReader reader, int version)
		{
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0D")]
		[Address(RVA = "0x745CF8", Offset = "0x745CF8", VA = "0x745CF8")]
		public static void AddNPCKillBy(int npcType, int plr)
		{
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0E")]
		[Address(RVA = "0x7467F8", Offset = "0x7467F8", VA = "0x7467F8")]
		private static void AddClaimableBanner(int banner)
		{
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0F")]
		[Address(RVA = "0x7465DC", Offset = "0x7465DC", VA = "0x7465DC")]
		private static void AddKill(int banner)
		{
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F10")]
		[Address(RVA = "0x746A04", Offset = "0x746A04", VA = "0x746A04")]
		public static void RequestBannerClaim(int banner, int amount)
		{
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F11")]
		[Address(RVA = "0x745694", Offset = "0x745694", VA = "0x745694")]
		private static void RefreshAnyNewClaimableBanners()
		{
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F12")]
		[Address(RVA = "0x746C08", Offset = "0x746C08", VA = "0x746C08")]
		private static void HandleBannerClaimRequest(int banner, ushort amount, int plr)
		{
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F13")]
		[Address(RVA = "0x746FFC", Offset = "0x746FFC", VA = "0x746FFC")]
		private static void HandleBannerClaimResponse(int banner, ushort amount, bool granted)
		{
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x00024CC0 File Offset: 0x00022EC0
		[Token(Token = "0x6004F14")]
		[Address(RVA = "0x746728", Offset = "0x746728", VA = "0x746728")]
		public static int BannerToItem(int banner)
		{
			return 0;
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x00024CD8 File Offset: 0x00022ED8
		[Token(Token = "0x6004F15")]
		[Address(RVA = "0x7465B8", Offset = "0x7465B8", VA = "0x7465B8")]
		public static int NPCtoBanner(int i)
		{
			return 0;
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x00024CF0 File Offset: 0x00022EF0
		[Token(Token = "0x6004F16")]
		[Address(RVA = "0x7469DC", Offset = "0x7469DC", VA = "0x7469DC")]
		public static int BannerToNPC(int i)
		{
			return 0;
		}

		// Token: 0x04009358 RID: 37720
		[Token(Token = "0x4009358")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MaxBannerTypes;

		// Token: 0x04009359 RID: 37721
		[Token(Token = "0x4009359")]
		[FieldOffset(Offset = "0x4")]
		private static int[] killCount;

		// Token: 0x0400935A RID: 37722
		[Token(Token = "0x400935A")]
		[FieldOffset(Offset = "0x8")]
		private static ushort[] claimableBanners;

		// Token: 0x0400935B RID: 37723
		[Token(Token = "0x400935B")]
		[FieldOffset(Offset = "0xC")]
		private static bool[] newBanner;

		// Token: 0x0400935C RID: 37724
		[Token(Token = "0x400935C")]
		[FieldOffset(Offset = "0x10")]
		public static int bannerState;

		// Token: 0x0400935D RID: 37725
		[Token(Token = "0x400935D")]
		[FieldOffset(Offset = "0x14")]
		public static bool hasBannerAvailable;

		// Token: 0x0400935E RID: 37726
		[Token(Token = "0x400935E")]
		[FieldOffset(Offset = "0x15")]
		public static bool AnyNewClaimableBanners;

		// Token: 0x0200093E RID: 2366
		[Token(Token = "0x200093E")]
		public class NetBannersModule : NetModule
		{
			// Token: 0x06004F18 RID: 20248 RVA: 0x00024D08 File Offset: 0x00022F08
			[Token(Token = "0x6004F18")]
			[Address(RVA = "0x7474A8", Offset = "0x7474A8", VA = "0x7474A8")]
			public static NetPacket WriteFullState()
			{
				return default(NetPacket);
			}

			// Token: 0x06004F19 RID: 20249 RVA: 0x00024D20 File Offset: 0x00022F20
			[Token(Token = "0x6004F19")]
			[Address(RVA = "0x7475B8", Offset = "0x7475B8", VA = "0x7475B8")]
			public static NetPacket WriteKillCountUpdate(int bannerId)
			{
				return default(NetPacket);
			}

			// Token: 0x06004F1A RID: 20250 RVA: 0x00024D38 File Offset: 0x00022F38
			[Token(Token = "0x6004F1A")]
			[Address(RVA = "0x747738", Offset = "0x747738", VA = "0x747738")]
			public static NetPacket WriteClaimCountUpdate(int bannerId)
			{
				return default(NetPacket);
			}

			// Token: 0x06004F1B RID: 20251 RVA: 0x00024D50 File Offset: 0x00022F50
			[Token(Token = "0x6004F1B")]
			[Address(RVA = "0x7478B8", Offset = "0x7478B8", VA = "0x7478B8")]
			public static NetPacket WriteClaimRequest(int bannerId, int amount)
			{
				return default(NetPacket);
			}

			// Token: 0x06004F1C RID: 20252 RVA: 0x00024D68 File Offset: 0x00022F68
			[Token(Token = "0x6004F1C")]
			[Address(RVA = "0x7479EC", Offset = "0x7479EC", VA = "0x7479EC")]
			public static NetPacket WriteClaimResponse(int bannerId, int amount, bool granted)
			{
				return default(NetPacket);
			}

			// Token: 0x06004F1D RID: 20253 RVA: 0x00024D80 File Offset: 0x00022F80
			[Token(Token = "0x6004F1D")]
			[Address(RVA = "0x747B58", Offset = "0x747B58", VA = "0x747B58", Slot = "4")]
			public override bool Deserialize(BinaryReader reader, int userId)
			{
				return default(bool);
			}

			// Token: 0x06004F1E RID: 20254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F1E")]
			[Address(RVA = "0x74804C", Offset = "0x74804C", VA = "0x74804C")]
			public NetBannersModule()
			{
			}

			// Token: 0x0200093F RID: 2367
			[Token(Token = "0x200093F")]
			private enum MessageType
			{
				// Token: 0x04009360 RID: 37728
				[Token(Token = "0x4009360")]
				FullState,
				// Token: 0x04009361 RID: 37729
				[Token(Token = "0x4009361")]
				KillCountUpdate,
				// Token: 0x04009362 RID: 37730
				[Token(Token = "0x4009362")]
				ClaimCountUpdate,
				// Token: 0x04009363 RID: 37731
				[Token(Token = "0x4009363")]
				ClaimRequest,
				// Token: 0x04009364 RID: 37732
				[Token(Token = "0x4009364")]
				ClaimResponse
			}
		}
	}
}
