using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x0200099F RID: 2463
	[Token(Token = "0x200099F")]
	public struct DestinationInventory
	{
		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060050FB RID: 20731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000999")]
		public ChestItem[] chestItems
		{
			[Token(Token = "0x60050FB")]
			[Address(RVA = "0x776178", Offset = "0x776178", VA = "0x776178")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099A")]
		public Item[] items
		{
			[Token(Token = "0x60050FC")]
			[Address(RVA = "0x7761B0", Offset = "0x7761B0", VA = "0x7761B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060050FD RID: 20733 RVA: 0x00025A40 File Offset: 0x00023C40
		[Token(Token = "0x1700099B")]
		public int itemCount
		{
			[Token(Token = "0x60050FD")]
			[Address(RVA = "0x7761C4", Offset = "0x7761C4", VA = "0x7761C4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FE")]
		[Address(RVA = "0x7761F8", Offset = "0x7761F8", VA = "0x7761F8")]
		public DestinationInventory(InventoryStorage storage, Vector2 position)
		{
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FF")]
		[Address(RVA = "0x77621C", Offset = "0x77621C", VA = "0x77621C")]
		public DestinationInventory(Chest chest, Vector2 position)
		{
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x00025A58 File Offset: 0x00023C58
		[Token(Token = "0x6005100")]
		[Address(RVA = "0x77626C", Offset = "0x77626C", VA = "0x77626C")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x040094C6 RID: 38086
		[Token(Token = "0x40094C6")]
		[FieldOffset(Offset = "0x0")]
		public int ChestIndex;

		// Token: 0x040094C7 RID: 38087
		[Token(Token = "0x40094C7")]
		[FieldOffset(Offset = "0x4")]
		public InventoryStorage storage;

		// Token: 0x040094C8 RID: 38088
		[Token(Token = "0x40094C8")]
		[FieldOffset(Offset = "0x8")]
		public Chest chest;

		// Token: 0x040094C9 RID: 38089
		[Token(Token = "0x40094C9")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 position;

		// Token: 0x040094CA RID: 38090
		[Token(Token = "0x40094CA")]
		[FieldOffset(Offset = "0x14")]
		public bool Locked;
	}
}
