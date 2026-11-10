using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000C5F RID: 3167
	[Token(Token = "0x2000C5F")]
	public class ItemCraftCondition : AchievementCondition
	{
		// Token: 0x06005E12 RID: 24082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E12")]
		[Address(RVA = "0x9B8290", Offset = "0x9B8290", VA = "0x9B8290")]
		private ItemCraftCondition(LocalUser user, short itemId)
		{
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E13")]
		[Address(RVA = "0x9B872C", Offset = "0x9B872C", VA = "0x9B872C")]
		private ItemCraftCondition(LocalUser user, short[] itemIds)
		{
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E14")]
		[Address(RVA = "0x9B87F4", Offset = "0x9B87F4", VA = "0x9B87F4", Slot = "5")]
		public override void Shutdown()
		{
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E15")]
		[Address(RVA = "0x9B8394", Offset = "0x9B8394", VA = "0x9B8394")]
		private static void ListenForCraft(ItemCraftCondition condition)
		{
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E16")]
		[Address(RVA = "0x9B8924", Offset = "0x9B8924", VA = "0x9B8924")]
		private static void ItemCraftListener(Player player, short itemId, int count)
		{
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E17")]
		[Address(RVA = "0x9B8B9C", Offset = "0x9B8B9C", VA = "0x9B8B9C")]
		public static AchievementCondition Create(LocalUser user, short[] items)
		{
			return null;
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E18")]
		[Address(RVA = "0x9B8C14", Offset = "0x9B8C14", VA = "0x9B8C14")]
		public static AchievementCondition Create(LocalUser user, short item)
		{
			return null;
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E19")]
		[Address(RVA = "0x9B8C8C", Offset = "0x9B8C8C", VA = "0x9B8C8C")]
		public static AchievementCondition[] CreateMany(LocalUser user, short[] items)
		{
			return null;
		}

		// Token: 0x04009DC8 RID: 40392
		[Token(Token = "0x4009DC8")]
		public const string Identifier = "ITEM_PICKUP";

		// Token: 0x04009DC9 RID: 40393
		[Token(Token = "0x4009DC9")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<short, List<ItemCraftCondition>> _listeners;

		// Token: 0x04009DCA RID: 40394
		[Token(Token = "0x4009DCA")]
		[FieldOffset(Offset = "0x4")]
		private static bool _isListenerHooked;

		// Token: 0x04009DCB RID: 40395
		[Token(Token = "0x4009DCB")]
		[FieldOffset(Offset = "0x18")]
		private short[] _itemIds;

		// Token: 0x04009DCC RID: 40396
		[Token(Token = "0x4009DCC")]
		[FieldOffset(Offset = "0x1C")]
		private readonly LocalUser _user;
	}
}
