using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	public class MinionSpawnFromInventoryItem : MinionSpawnInfo
	{
		// Token: 0x0600433A RID: 17210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433A")]
		[Address(RVA = "0x4FDAF8", Offset = "0x4FDAF8", VA = "0x4FDAF8")]
		public MinionSpawnFromInventoryItem(Item item)
		{
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433B")]
		[Address(RVA = "0x4FDB40", Offset = "0x4FDB40", VA = "0x4FDB40")]
		public MinionSpawnFromInventoryItem(int itemType, int itemPrefix)
		{
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x00020610 File Offset: 0x0001E810
		[Token(Token = "0x600433C")]
		[Address(RVA = "0x4FDB64", Offset = "0x4FDB64", VA = "0x4FDB64", Slot = "5")]
		protected virtual bool ItemMatches(Item item)
		{
			return default(bool);
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433D")]
		[Address(RVA = "0x4FDBA8", Offset = "0x4FDBA8", VA = "0x4FDBA8", Slot = "4")]
		public override void TryRespawn(Player player)
		{
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433E")]
		[Address(RVA = "0x4FDC80", Offset = "0x4FDC80", VA = "0x4FDC80")]
		protected Item FindMatchingItem(Player player)
		{
			return null;
		}

		// Token: 0x04008A9A RID: 35482
		[Token(Token = "0x4008A9A")]
		[FieldOffset(Offset = "0x8")]
		public int ItemType;

		// Token: 0x04008A9B RID: 35483
		[Token(Token = "0x4008A9B")]
		[FieldOffset(Offset = "0xC")]
		public int ItemPrefix;
	}
}
