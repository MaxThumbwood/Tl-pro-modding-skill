using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020009A0 RID: 2464
	[Token(Token = "0x20009A0")]
	public static class NearbyChests
	{
		// Token: 0x06005101 RID: 20737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005101")]
		[Address(RVA = "0x7763B4", Offset = "0x7763B4", VA = "0x7763B4")]
		public static List<DestinationInventory> GetChestsInRangeOf(Vector2 position, float range = 0f)
		{
			return null;
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005102")]
		[Address(RVA = "0x7766C4", Offset = "0x7766C4", VA = "0x7766C4")]
		public static List<DestinationInventory> GetBanksInRangeOf(Player player, float range = 0f)
		{
			return null;
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x00025A70 File Offset: 0x00023C70
		[Token(Token = "0x6005103")]
		[Address(RVA = "0x777328", Offset = "0x777328", VA = "0x777328")]
		private static bool Contains(List<DestinationInventory> list, Chest chest)
		{
			return default(bool);
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x00025A88 File Offset: 0x00023C88
		[Token(Token = "0x6005104")]
		[Address(RVA = "0x777148", Offset = "0x777148", VA = "0x777148")]
		private static bool Contains(List<DestinationInventory> list, InventoryStorage chest)
		{
			return default(bool);
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00025AA0 File Offset: 0x00023CA0
		[Token(Token = "0x6005105")]
		[Address(RVA = "0x77703C", Offset = "0x77703C", VA = "0x77703C")]
		private static bool ContainerIndexToPlayerBank(Player player, int container, out InventoryStorage bank)
		{
			return default(bool);
		}

		// Token: 0x040094CB RID: 38091
		[Token(Token = "0x40094CB")]
		[FieldOffset(Offset = "0x0")]
		private static List<DestinationInventory> _scratch;
	}
}
