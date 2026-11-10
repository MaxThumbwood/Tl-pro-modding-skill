using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000C60 RID: 3168
	[Token(Token = "0x2000C60")]
	public class ItemPickupCondition : AchievementCondition
	{
		// Token: 0x06005E1B RID: 24091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1B")]
		[Address(RVA = "0x9B8E70", Offset = "0x9B8E70", VA = "0x9B8E70")]
		private ItemPickupCondition(LocalUser user, short itemId)
		{
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1C")]
		[Address(RVA = "0x9B930C", Offset = "0x9B930C", VA = "0x9B930C")]
		private ItemPickupCondition(LocalUser user, short[] itemIds)
		{
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1D")]
		[Address(RVA = "0x9B93D4", Offset = "0x9B93D4", VA = "0x9B93D4", Slot = "5")]
		public override void Shutdown()
		{
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1E")]
		[Address(RVA = "0x9B8F74", Offset = "0x9B8F74", VA = "0x9B8F74")]
		private static void ListenForPickup(ItemPickupCondition condition)
		{
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0x9B9504", Offset = "0x9B9504", VA = "0x9B9504")]
		private static void ItemPickupListener(Player player, short itemId, int count)
		{
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E20")]
		[Address(RVA = "0x9B977C", Offset = "0x9B977C", VA = "0x9B977C")]
		public static AchievementCondition Create(LocalUser user, short[] items)
		{
			return null;
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E21")]
		[Address(RVA = "0x9B97F4", Offset = "0x9B97F4", VA = "0x9B97F4")]
		public static AchievementCondition Create(LocalUser user, short item)
		{
			return null;
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E22")]
		[Address(RVA = "0x9B986C", Offset = "0x9B986C", VA = "0x9B986C")]
		public static AchievementCondition[] CreateMany(LocalUser user, short[] items)
		{
			return null;
		}

		// Token: 0x04009DCD RID: 40397
		[Token(Token = "0x4009DCD")]
		public const string Identifier = "ITEM_PICKUP";

		// Token: 0x04009DCE RID: 40398
		[Token(Token = "0x4009DCE")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalUser _user;

		// Token: 0x04009DCF RID: 40399
		[Token(Token = "0x4009DCF")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<short, List<ItemPickupCondition>> _listeners;

		// Token: 0x04009DD0 RID: 40400
		[Token(Token = "0x4009DD0")]
		[FieldOffset(Offset = "0x4")]
		private static bool _isListenerHooked;

		// Token: 0x04009DD1 RID: 40401
		[Token(Token = "0x4009DD1")]
		[FieldOffset(Offset = "0x1C")]
		private short[] _itemIds;
	}
}
