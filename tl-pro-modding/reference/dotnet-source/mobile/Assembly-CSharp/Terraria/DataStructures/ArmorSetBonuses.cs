using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200073F RID: 1855
	[Token(Token = "0x200073F")]
	public class ArmorSetBonuses
	{
		// Token: 0x06004226 RID: 16934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004226")]
		[Address(RVA = "0x4EDEFC", Offset = "0x4EDEFC", VA = "0x4EDEFC")]
		public static void Initialize()
		{
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004227")]
		[Address(RVA = "0x4F3BBC", Offset = "0x4F3BBC", VA = "0x4F3BBC")]
		public static void BuildLookup()
		{
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004228")]
		[Address(RVA = "0x4F4C9C", Offset = "0x4F4C9C", VA = "0x4F4C9C")]
		public static ArmorSetBonus GetCompleteSet(ArmorSetBonus.QueryContext context)
		{
			return null;
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004229")]
		[Address(RVA = "0x4F3138", Offset = "0x4F3138", VA = "0x4F3138")]
		private static ArmorSetBonus.Builder Create(ArmorSetBonus.ArmorSetEffect effect, string textKey, ArmorSetBonus.PartType primaryPart = ArmorSetBonus.PartType.None)
		{
			return null;
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422A")]
		[Address(RVA = "0x4F35D8", Offset = "0x4F35D8", VA = "0x4F35D8")]
		public static void Add(ArmorSetBonus.ArmorSetEffect Effect, string TextKey, int Head, int Body, int Legs)
		{
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422B")]
		[Address(RVA = "0x4F3788", Offset = "0x4F3788", VA = "0x4F3788")]
		public static void Add(ArmorSetBonus.ArmorSetEffect Effect, string TextKey, ArmorSetBonus.PartType PrimaryPart, int Head, int Body, int Legs)
		{
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x4F5078", Offset = "0x4F5078", VA = "0x4F5078")]
		public ArmorSetBonuses()
		{
		}

		// Token: 0x040089EF RID: 35311
		[Token(Token = "0x40089EF")]
		[FieldOffset(Offset = "0x0")]
		public static List<ArmorSetBonus> All;

		// Token: 0x040089F0 RID: 35312
		[Token(Token = "0x40089F0")]
		[FieldOffset(Offset = "0x4")]
		public static ArmorSetBonus[][] SetsContaining;

		// Token: 0x02000740 RID: 1856
		[Token(Token = "0x2000740")]
		public static class Benefits
		{
			// Token: 0x0600422E RID: 16942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600422E")]
			[Address(RVA = "0x4F512C", Offset = "0x4F512C", VA = "0x4F512C")]
			public static void Tiki(Player player)
			{
			}

			// Token: 0x0600422F RID: 16943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600422F")]
			[Address(RVA = "0x4F5194", Offset = "0x4F5194", VA = "0x4F5194")]
			public static void Spooky(Player player)
			{
			}

			// Token: 0x06004230 RID: 16944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004230")]
			[Address(RVA = "0x4F51D8", Offset = "0x4F51D8", VA = "0x4F51D8")]
			public static void Bee(Player player)
			{
			}

			// Token: 0x06004231 RID: 16945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004231")]
			[Address(RVA = "0x4F529C", Offset = "0x4F529C", VA = "0x4F529C")]
			public static void Spider(Player player)
			{
			}

			// Token: 0x06004232 RID: 16946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004232")]
			[Address(RVA = "0x4F52E4", Offset = "0x4F52E4", VA = "0x4F52E4")]
			public static void Solar(Player player)
			{
			}

			// Token: 0x06004233 RID: 16947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004233")]
			[Address(RVA = "0x4F5308", Offset = "0x4F5308", VA = "0x4F5308")]
			public static void Vortex(Player player)
			{
			}

			// Token: 0x06004234 RID: 16948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004234")]
			[Address(RVA = "0x4F5328", Offset = "0x4F5328", VA = "0x4F5328")]
			public static void Nebula(Player player)
			{
			}

			// Token: 0x06004235 RID: 16949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004235")]
			[Address(RVA = "0x4F5358", Offset = "0x4F5358", VA = "0x4F5358")]
			public static void Stardust(Player player)
			{
			}

			// Token: 0x06004236 RID: 16950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004236")]
			[Address(RVA = "0x4F537C", Offset = "0x4F537C", VA = "0x4F537C")]
			public static void Forbidden(Player player)
			{
			}

			// Token: 0x06004237 RID: 16951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004237")]
			[Address(RVA = "0x4F5468", Offset = "0x4F5468", VA = "0x4F5468")]
			public static void SquireTier2(Player player)
			{
			}

			// Token: 0x06004238 RID: 16952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004238")]
			[Address(RVA = "0x4F54B4", Offset = "0x4F54B4", VA = "0x4F54B4")]
			public static void ApprenticeTier2(Player player)
			{
			}

			// Token: 0x06004239 RID: 16953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004239")]
			[Address(RVA = "0x4F5500", Offset = "0x4F5500", VA = "0x4F5500")]
			public static void HuntressTier2(Player player)
			{
			}

			// Token: 0x0600423A RID: 16954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600423A")]
			[Address(RVA = "0x4F554C", Offset = "0x4F554C", VA = "0x4F554C")]
			public static void MonkTier2(Player player)
			{
			}

			// Token: 0x0600423B RID: 16955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600423B")]
			[Address(RVA = "0x4F5598", Offset = "0x4F5598", VA = "0x4F5598")]
			public static void SquireTier3(Player player)
			{
			}

			// Token: 0x0600423C RID: 16956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600423C")]
			[Address(RVA = "0x4F55F4", Offset = "0x4F55F4", VA = "0x4F55F4")]
			public static void ApprenticeTier3(Player player)
			{
			}

			// Token: 0x0600423D RID: 16957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600423D")]
			[Address(RVA = "0x4F5650", Offset = "0x4F5650", VA = "0x4F5650")]
			public static void HuntressTier3(Player player)
			{
			}

			// Token: 0x0600423E RID: 16958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600423E")]
			[Address(RVA = "0x4F56AC", Offset = "0x4F56AC", VA = "0x4F56AC")]
			public static void MonkTier3(Player player)
			{
			}

			// Token: 0x0600423F RID: 16959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600423F")]
			[Address(RVA = "0x4F5708", Offset = "0x4F5708", VA = "0x4F5708")]
			public static void ObsidianOutlaw(Player player)
			{
			}

			// Token: 0x06004240 RID: 16960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004240")]
			[Address(RVA = "0x4F57B4", Offset = "0x4F57B4", VA = "0x4F57B4")]
			public static void ChlorophyteMelee(Player player)
			{
			}

			// Token: 0x06004241 RID: 16961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004241")]
			[Address(RVA = "0x4F5858", Offset = "0x4F5858", VA = "0x4F5858")]
			public static void ChlorophyteSummon(Player player)
			{
			}

			// Token: 0x06004242 RID: 16962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004242")]
			[Address(RVA = "0x4F58E8", Offset = "0x4F58E8", VA = "0x4F58E8")]
			public static void Chlorophyte(Player player)
			{
			}

			// Token: 0x06004243 RID: 16963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004243")]
			[Address(RVA = "0x4F5950", Offset = "0x4F5950", VA = "0x4F5950")]
			public static void Angler(Player player)
			{
			}

			// Token: 0x06004244 RID: 16964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004244")]
			[Address(RVA = "0x4F5970", Offset = "0x4F5970", VA = "0x4F5970")]
			public static void Cactus(Player player)
			{
			}

			// Token: 0x06004245 RID: 16965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004245")]
			[Address(RVA = "0x4F5990", Offset = "0x4F5990", VA = "0x4F5990")]
			public static void Turtle(Player player)
			{
			}

			// Token: 0x06004246 RID: 16966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004246")]
			[Address(RVA = "0x4F5A04", Offset = "0x4F5A04", VA = "0x4F5A04")]
			public static void CobaltCaster(Player player)
			{
			}

			// Token: 0x06004247 RID: 16967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004247")]
			[Address(RVA = "0x4F5A4C", Offset = "0x4F5A4C", VA = "0x4F5A4C")]
			public static void CobaltMelee(Player player)
			{
			}

			// Token: 0x06004248 RID: 16968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004248")]
			[Address(RVA = "0x4F5A90", Offset = "0x4F5A90", VA = "0x4F5A90")]
			public static void CobaltRanged(Player player)
			{
			}

			// Token: 0x06004249 RID: 16969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004249")]
			[Address(RVA = "0x4F5AB0", Offset = "0x4F5AB0", VA = "0x4F5AB0")]
			public static void MythrilCaster(Player player)
			{
			}

			// Token: 0x0600424A RID: 16970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600424A")]
			[Address(RVA = "0x4F5AF8", Offset = "0x4F5AF8", VA = "0x4F5AF8")]
			public static void MythrilMelee(Player player)
			{
			}

			// Token: 0x0600424B RID: 16971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600424B")]
			[Address(RVA = "0x4F5B2C", Offset = "0x4F5B2C", VA = "0x4F5B2C")]
			public static void MythrilRanged(Player player)
			{
			}

			// Token: 0x0600424C RID: 16972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600424C")]
			[Address(RVA = "0x4F5B4C", Offset = "0x4F5B4C", VA = "0x4F5B4C")]
			public static void AdamantiteCaster(Player player)
			{
			}

			// Token: 0x0600424D RID: 16973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600424D")]
			[Address(RVA = "0x4F5B94", Offset = "0x4F5B94", VA = "0x4F5B94")]
			public static void AdamantiteMelee(Player player)
			{
			}

			// Token: 0x0600424E RID: 16974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600424E")]
			[Address(RVA = "0x4F5C08", Offset = "0x4F5C08", VA = "0x4F5C08")]
			public static void AdamantiteRanged(Player player)
			{
			}

			// Token: 0x0600424F RID: 16975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600424F")]
			[Address(RVA = "0x4F5C28", Offset = "0x4F5C28", VA = "0x4F5C28")]
			public static void Palladium(Player player)
			{
			}

			// Token: 0x06004250 RID: 16976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004250")]
			[Address(RVA = "0x4F5C48", Offset = "0x4F5C48", VA = "0x4F5C48")]
			public static void Orichalcum(Player player)
			{
			}

			// Token: 0x06004251 RID: 16977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004251")]
			[Address(RVA = "0x4F5C68", Offset = "0x4F5C68", VA = "0x4F5C68")]
			public static void Titanium(Player player)
			{
			}

			// Token: 0x06004252 RID: 16978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004252")]
			[Address(RVA = "0x4F5C88", Offset = "0x4F5C88", VA = "0x4F5C88")]
			public static void HallowedSummoner(Player player)
			{
			}

			// Token: 0x06004253 RID: 16979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004253")]
			[Address(RVA = "0x4F5CD0", Offset = "0x4F5CD0", VA = "0x4F5CD0")]
			public static void Hallowed(Player player)
			{
			}

			// Token: 0x06004254 RID: 16980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004254")]
			[Address(RVA = "0x4F5CF0", Offset = "0x4F5CF0", VA = "0x4F5CF0")]
			public static void CrystalAssassin(Player player)
			{
			}

			// Token: 0x06004255 RID: 16981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004255")]
			[Address(RVA = "0x4F5E28", Offset = "0x4F5E28", VA = "0x4F5E28")]
			public static void Crimson(Player player)
			{
			}

			// Token: 0x06004256 RID: 16982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004256")]
			[Address(RVA = "0x4F5E48", Offset = "0x4F5E48", VA = "0x4F5E48")]
			public static void SpectreHealing(Player player)
			{
			}

			// Token: 0x06004257 RID: 16983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004257")]
			[Address(RVA = "0x4F5EA8", Offset = "0x4F5EA8", VA = "0x4F5EA8")]
			public static void SpectreDamage(Player player)
			{
			}

			// Token: 0x06004258 RID: 16984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004258")]
			[Address(RVA = "0x4F5EC8", Offset = "0x4F5EC8", VA = "0x4F5EC8")]
			public static void Meteor(Player player)
			{
			}

			// Token: 0x06004259 RID: 16985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004259")]
			[Address(RVA = "0x4F5EE8", Offset = "0x4F5EE8", VA = "0x4F5EE8")]
			public static void Frost(Player player)
			{
			}

			// Token: 0x0600425A RID: 16986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600425A")]
			[Address(RVA = "0x4F5F74", Offset = "0x4F5F74", VA = "0x4F5F74")]
			public static void Jungle(Player player)
			{
			}

			// Token: 0x0600425B RID: 16987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600425B")]
			[Address(RVA = "0x4F5FBC", Offset = "0x4F5FBC", VA = "0x4F5FBC")]
			public static void Molten(Player player)
			{
			}

			// Token: 0x0600425C RID: 16988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600425C")]
			[Address(RVA = "0x4F605C", Offset = "0x4F605C", VA = "0x4F605C")]
			public static void Snow(Player player)
			{
			}

			// Token: 0x0600425D RID: 16989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600425D")]
			[Address(RVA = "0x4F60B4", Offset = "0x4F60B4", VA = "0x4F60B4")]
			public static void Mining(Player player)
			{
			}

			// Token: 0x0600425E RID: 16990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600425E")]
			[Address(RVA = "0x4F60F8", Offset = "0x4F60F8", VA = "0x4F60F8")]
			public static void Wizard(Player player)
			{
			}

			// Token: 0x0600425F RID: 16991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600425F")]
			[Address(RVA = "0x4F612C", Offset = "0x4F612C", VA = "0x4F612C")]
			public static void MagicHat(Player player)
			{
			}

			// Token: 0x06004260 RID: 16992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004260")]
			[Address(RVA = "0x4F6160", Offset = "0x4F6160", VA = "0x4F6160")]
			public static void ShadowScale(Player player)
			{
			}

			// Token: 0x06004261 RID: 16993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004261")]
			[Address(RVA = "0x4F6180", Offset = "0x4F6180", VA = "0x4F6180")]
			public static void BeetleDefense(Player player)
			{
			}

			// Token: 0x06004262 RID: 16994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004262")]
			[Address(RVA = "0x4F61A4", Offset = "0x4F61A4", VA = "0x4F61A4")]
			public static void BeetleDamage(Player player)
			{
			}

			// Token: 0x06004263 RID: 16995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004263")]
			[Address(RVA = "0x4F61C8", Offset = "0x4F61C8", VA = "0x4F61C8")]
			public static void Gladiator(Player player)
			{
			}

			// Token: 0x06004264 RID: 16996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004264")]
			[Address(RVA = "0x4F61E8", Offset = "0x4F61E8", VA = "0x4F61E8")]
			public static void Ninja(Player player)
			{
			}

			// Token: 0x06004265 RID: 16997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004265")]
			[Address(RVA = "0x4F6230", Offset = "0x4F6230", VA = "0x4F6230")]
			public static void Fossil(Player player)
			{
			}

			// Token: 0x06004266 RID: 16998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004266")]
			[Address(RVA = "0x4F6250", Offset = "0x4F6250", VA = "0x4F6250")]
			public static void Necro(Player player)
			{
			}

			// Token: 0x06004267 RID: 16999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004267")]
			[Address(RVA = "0x4F6284", Offset = "0x4F6284", VA = "0x4F6284")]
			public static void Pumpkin(Player player)
			{
			}

			// Token: 0x06004268 RID: 17000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004268")]
			[Address(RVA = "0x4F6340", Offset = "0x4F6340", VA = "0x4F6340")]
			public static void Platinum(Player player)
			{
			}

			// Token: 0x06004269 RID: 17001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004269")]
			[Address(RVA = "0x4F6374", Offset = "0x4F6374", VA = "0x4F6374")]
			public static void MetalTier2(Player player)
			{
			}

			// Token: 0x0600426A RID: 17002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600426A")]
			[Address(RVA = "0x4F63A8", Offset = "0x4F63A8", VA = "0x4F63A8")]
			public static void MetalTier1(Player player)
			{
			}

			// Token: 0x0600426B RID: 17003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600426B")]
			[Address(RVA = "0x4F63DC", Offset = "0x4F63DC", VA = "0x4F63DC")]
			public static void Shroomite(Player player)
			{
			}

			// Token: 0x0600426C RID: 17004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600426C")]
			[Address(RVA = "0x4F63FC", Offset = "0x4F63FC", VA = "0x4F63FC")]
			public static void Wood(Player player)
			{
			}

			// Token: 0x0600426D RID: 17005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600426D")]
			[Address(RVA = "0x4F6430", Offset = "0x4F6430", VA = "0x4F6430")]
			public static void AshWood(Player player)
			{
			}
		}

		// Token: 0x02000741 RID: 1857
		[Token(Token = "0x2000741")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600426F RID: 17007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600426F")]
			[Address(RVA = "0x4F64C4", Offset = "0x4F64C4", VA = "0x4F64C4")]
			public <>c()
			{
			}

			// Token: 0x06004270 RID: 17008 RVA: 0x00020310 File Offset: 0x0001E510
			[Token(Token = "0x6004270")]
			[Address(RVA = "0x4F64CC", Offset = "0x4F64CC", VA = "0x4F64CC")]
			internal int <BuildLookup>b__4_0(ArmorSetBonus set)
			{
				return 0;
			}

			// Token: 0x06004271 RID: 17009 RVA: 0x00020328 File Offset: 0x0001E528
			[Token(Token = "0x6004271")]
			[Address(RVA = "0x4F64F0", Offset = "0x4F64F0", VA = "0x4F64F0")]
			internal int <BuildLookup>b__4_1(ArmorSetBonus set)
			{
				return 0;
			}

			// Token: 0x06004272 RID: 17010 RVA: 0x00020340 File Offset: 0x0001E540
			[Token(Token = "0x6004272")]
			[Address(RVA = "0x4F6514", Offset = "0x4F6514", VA = "0x4F6514")]
			internal int <BuildLookup>b__4_2(ArmorSetBonus set)
			{
				return 0;
			}

			// Token: 0x040089F1 RID: 35313
			[Token(Token = "0x40089F1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ArmorSetBonuses.<>c <>9;

			// Token: 0x040089F2 RID: 35314
			[Token(Token = "0x40089F2")]
			[FieldOffset(Offset = "0x4")]
			public static Func<ArmorSetBonus, int> <>9__4_0;

			// Token: 0x040089F3 RID: 35315
			[Token(Token = "0x40089F3")]
			[FieldOffset(Offset = "0x8")]
			public static Func<ArmorSetBonus, int> <>9__4_1;

			// Token: 0x040089F4 RID: 35316
			[Token(Token = "0x40089F4")]
			[FieldOffset(Offset = "0xC")]
			public static Func<ArmorSetBonus, int> <>9__4_2;
		}
	}
}
