using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CD4 RID: 3284
	[Token(Token = "0x2000CD4")]
	public class CreativeItemSacrificesCatalog
	{
		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600618E RID: 24974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A94")]
		public Dictionary<int, int> SacrificeCountNeededByItemId
		{
			[Token(Token = "0x600618E")]
			[Address(RVA = "0xAB60A8", Offset = "0xAB60A8", VA = "0xAB60A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618F")]
		[Address(RVA = "0xAB60B0", Offset = "0xAB60B0", VA = "0xAB60B0")]
		public void Initialize()
		{
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x0002D090 File Offset: 0x0002B290
		[Token(Token = "0x6006190")]
		[Address(RVA = "0xAB6918", Offset = "0xAB6918", VA = "0xAB6918")]
		public bool TryGetSacrificeCountCapToUnlockInfiniteItems(int itemId, out int amountNeeded)
		{
			return default(bool);
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006191")]
		[Address(RVA = "0xAB6A04", Offset = "0xAB6A04", VA = "0xAB6A04")]
		public CreativeItemSacrificesCatalog()
		{
		}

		// Token: 0x0400A026 RID: 40998
		[Token(Token = "0x400A026")]
		[FieldOffset(Offset = "0x0")]
		public static CreativeItemSacrificesCatalog Instance;

		// Token: 0x0400A027 RID: 40999
		[Token(Token = "0x400A027")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, int> _sacrificeCountNeededByItemId;
	}
}
