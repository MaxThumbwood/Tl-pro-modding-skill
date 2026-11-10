using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.GameContent.Personalities;

namespace Terraria.GameContent
{
	// Token: 0x020009CF RID: 2511
	[Token(Token = "0x20009CF")]
	public class ShopHelper
	{
		// Token: 0x060051E8 RID: 20968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E8")]
		[Address(RVA = "0x7D28A4", Offset = "0x7D28A4", VA = "0x7D28A4")]
		public ShopHelper()
		{
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x000261C0 File Offset: 0x000243C0
		[Token(Token = "0x60051E9")]
		[Address(RVA = "0x7D2B34", Offset = "0x7D2B34", VA = "0x7D2B34")]
		public ShoppingSettings GetShoppingSettings(Player player, NPC npc)
		{
			return default(ShoppingSettings);
		}

		// Token: 0x060051EA RID: 20970 RVA: 0x000261D8 File Offset: 0x000243D8
		[Token(Token = "0x60051EA")]
		[Address(RVA = "0x7D340C", Offset = "0x7D340C", VA = "0x7D340C")]
		public static int PriceAdjustmentToHapinessIndex(float priceAdjustment)
		{
			return 0;
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x000261F0 File Offset: 0x000243F0
		[Token(Token = "0x60051EB")]
		[Address(RVA = "0x7D345C", Offset = "0x7D345C", VA = "0x7D345C")]
		private float GetSkeletonMerchantPrices(NPC npc)
		{
			return 0f;
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x00026208 File Offset: 0x00024408
		[Token(Token = "0x60051EC")]
		[Address(RVA = "0x7D3614", Offset = "0x7D3614", VA = "0x7D3614")]
		private float GetTravelingMerchantPrices(NPC npc)
		{
			return 0f;
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051ED")]
		[Address(RVA = "0x7D2BA4", Offset = "0x7D2BA4", VA = "0x7D2BA4")]
		private void ProcessMood(Player player, NPC npc)
		{
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x00026220 File Offset: 0x00024420
		[Token(Token = "0x60051EE")]
		[Address(RVA = "0x7D4274", Offset = "0x7D4274", VA = "0x7D4274")]
		private float LimitAndRoundMultiplier(float priceAdjustment)
		{
			return 0f;
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EF")]
		[Address(RVA = "0x7D43A0", Offset = "0x7D43A0", VA = "0x7D43A0")]
		private static string BiomeNameByKey(string biomeNameKey)
		{
			return null;
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F0")]
		[Address(RVA = "0x7D4090", Offset = "0x7D4090", VA = "0x7D4090")]
		private void AddHappinessReportText(string textKeyInCategory, [Optional] object substitutes)
		{
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F1")]
		[Address(RVA = "0x7D4438", Offset = "0x7D4438", VA = "0x7D4438")]
		public void LikeBiome(string nameKey)
		{
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F2")]
		[Address(RVA = "0x7D4598", Offset = "0x7D4598", VA = "0x7D4598")]
		public void LoveBiome(string nameKey)
		{
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F3")]
		[Address(RVA = "0x7D46F8", Offset = "0x7D46F8", VA = "0x7D46F8")]
		public void DislikeBiome(string nameKey)
		{
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F4")]
		[Address(RVA = "0x7D4858", Offset = "0x7D4858", VA = "0x7D4858")]
		public void HateBiome(string nameKey)
		{
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F5")]
		[Address(RVA = "0x7D49B8", Offset = "0x7D49B8", VA = "0x7D49B8")]
		public void LikeNPC(int npcType)
		{
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F6")]
		[Address(RVA = "0x7D4AC8", Offset = "0x7D4AC8", VA = "0x7D4AC8")]
		public void LoveNPCByTypeName(int npcType)
		{
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F7")]
		[Address(RVA = "0x7D4C44", Offset = "0x7D4C44", VA = "0x7D4C44")]
		public void LikePrincess()
		{
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F8")]
		[Address(RVA = "0x7D4D50", Offset = "0x7D4D50", VA = "0x7D4D50")]
		public void LoveNPC(int npcType)
		{
		}

		// Token: 0x060051F9 RID: 20985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F9")]
		[Address(RVA = "0x7D4E60", Offset = "0x7D4E60", VA = "0x7D4E60")]
		public void DislikeNPC(int npcType)
		{
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FA")]
		[Address(RVA = "0x7D4F70", Offset = "0x7D4F70", VA = "0x7D4F70")]
		public void HateNPC(int npcType)
		{
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051FB")]
		[Address(RVA = "0x7D3BB8", Offset = "0x7D3BB8", VA = "0x7D3BB8")]
		private List<NPC> GetNearbyResidentNPCs(NPC npc, out int npcsWithinHouse, out int npcsWithinVillage)
		{
			return null;
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x00026238 File Offset: 0x00024438
		[Token(Token = "0x60051FC")]
		[Address(RVA = "0x7D37D4", Offset = "0x7D37D4", VA = "0x7D37D4")]
		private bool RuinMoodIfHomeless(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00026250 File Offset: 0x00024450
		[Token(Token = "0x60051FD")]
		[Address(RVA = "0x7D385C", Offset = "0x7D385C", VA = "0x7D385C")]
		private bool IsFarFromHome(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x00026268 File Offset: 0x00024468
		[Token(Token = "0x60051FE")]
		[Address(RVA = "0x7D39EC", Offset = "0x7D39EC", VA = "0x7D39EC")]
		private bool IsPlayerInEvilBiomes(Player player)
		{
			return default(bool);
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00026280 File Offset: 0x00024480
		[Token(Token = "0x60051FF")]
		[Address(RVA = "0x7D3794", Offset = "0x7D3794", VA = "0x7D3794")]
		private bool IsNotReallyTownNPC(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x04009525 RID: 38181
		[Token(Token = "0x4009525")]
		public const float LowestPossiblePriceMultiplier = 0.75f;

		// Token: 0x04009526 RID: 38182
		[Token(Token = "0x4009526")]
		public const float MaxHappinessAchievementPriceMultiplier = 0.82f;

		// Token: 0x04009527 RID: 38183
		[Token(Token = "0x4009527")]
		public const float HighestPossiblePriceMultiplier = 1.5f;

		// Token: 0x04009528 RID: 38184
		[Token(Token = "0x4009528")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string _currentHappiness;

		// Token: 0x04009529 RID: 38185
		[Token(Token = "0x4009529")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float _currentPriceAdjustment;

		// Token: 0x0400952A RID: 38186
		[Token(Token = "0x400952A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NPC _currentNPCBeingTalkedTo;

		// Token: 0x0400952B RID: 38187
		[Token(Token = "0x400952B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Player _currentPlayerTalking;

		// Token: 0x0400952C RID: 38188
		[Token(Token = "0x400952C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PersonalityDatabase _database;

		// Token: 0x0400952D RID: 38189
		[Token(Token = "0x400952D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private AShoppingBiome[] _dangerousBiomes;

		// Token: 0x0400952E RID: 38190
		[Token(Token = "0x400952E")]
		private const float likeValue = 0.94f;

		// Token: 0x0400952F RID: 38191
		[Token(Token = "0x400952F")]
		private const float dislikeValue = 1.06f;

		// Token: 0x04009530 RID: 38192
		[Token(Token = "0x4009530")]
		private const float loveValue = 0.88f;

		// Token: 0x04009531 RID: 38193
		[Token(Token = "0x4009531")]
		private const float hateValue = 1.12f;
	}
}
