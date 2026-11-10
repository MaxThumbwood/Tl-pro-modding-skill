using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x02000976 RID: 2422
	[Token(Token = "0x2000976")]
	public static class FakeCursorItem
	{
		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06005027 RID: 20519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000990")]
		public static Item Item
		{
			[Token(Token = "0x6005027")]
			[Address(RVA = "0x761C34", Offset = "0x761C34", VA = "0x761C34")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005028")]
		[Address(RVA = "0x761E6C", Offset = "0x761E6C", VA = "0x761E6C")]
		public static void Reset()
		{
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005029")]
		[Address(RVA = "0x761ED8", Offset = "0x761ED8", VA = "0x761ED8")]
		public static void Add(int itemType, int itemStack, int itemPrefix = 0)
		{
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502A")]
		[Address(RVA = "0x750CBC", Offset = "0x750CBC", VA = "0x750CBC")]
		public static void Add(Item item)
		{
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502B")]
		[Address(RVA = "0x752C00", Offset = "0x752C00", VA = "0x752C00")]
		public static void Remove(int itemType, int itemStack)
		{
		}

		// Token: 0x040093F5 RID: 37877
		[Token(Token = "0x40093F5")]
		[FieldOffset(Offset = "0x0")]
		private static int _type;

		// Token: 0x040093F6 RID: 37878
		[Token(Token = "0x40093F6")]
		[FieldOffset(Offset = "0x4")]
		private static int _stack;

		// Token: 0x040093F7 RID: 37879
		[Token(Token = "0x40093F7")]
		[FieldOffset(Offset = "0x8")]
		private static int _prefix;

		// Token: 0x040093F8 RID: 37880
		[Token(Token = "0x40093F8")]
		[FieldOffset(Offset = "0xC")]
		private static Item _item;
	}
}
