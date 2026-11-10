using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x020004EA RID: 1258
	[Token(Token = "0x20004EA")]
	public class EquipmentLoadout : FileAPI
	{
		// Token: 0x0600316A RID: 12650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316A")]
		[Address(RVA = "0x19FA95C", Offset = "0x19FA95C", VA = "0x19FA95C")]
		public EquipmentLoadout()
		{
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600316B")]
		[Address(RVA = "0x19FA9D8", Offset = "0x19FA9D8", VA = "0x19FA9D8")]
		private Item[] CreateItemArray(int length)
		{
			return null;
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316C")]
		[Address(RVA = "0x19FAAD8", Offset = "0x19FAAD8", VA = "0x19FAAD8")]
		public void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316D")]
		[Address(RVA = "0x19FAC20", Offset = "0x19FAC20", VA = "0x19FAC20")]
		public void Deserialize(BinaryReader reader, int gameVersion)
		{
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316E")]
		[Address(RVA = "0x19FAD7C", Offset = "0x19FAD7C", VA = "0x19FAD7C")]
		public void Swap(Player player)
		{
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316F")]
		[Address(RVA = "0x19FAF70", Offset = "0x19FAF70", VA = "0x19FAF70")]
		public void TryDroppingItems(Player player, IEntitySource source)
		{
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003170")]
		[Address(RVA = "0x19FB04C", Offset = "0x19FB04C", VA = "0x19FB04C", Slot = "4")]
		public void FixLoadedData()
		{
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003171")]
		[Address(RVA = "0x19FB170", Offset = "0x19FB170", VA = "0x19FB170")]
		public void CopyVisuals(EquipmentLoadout other)
		{
		}

		// Token: 0x0400421D RID: 16925
		[Token(Token = "0x400421D")]
		[FieldOffset(Offset = "0x8")]
		public Item[] Armor;

		// Token: 0x0400421E RID: 16926
		[Token(Token = "0x400421E")]
		[FieldOffset(Offset = "0xC")]
		public Item[] Dye;

		// Token: 0x0400421F RID: 16927
		[Token(Token = "0x400421F")]
		[FieldOffset(Offset = "0x10")]
		public bool[] Hide;
	}
}
