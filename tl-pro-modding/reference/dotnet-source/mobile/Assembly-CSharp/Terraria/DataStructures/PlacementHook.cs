using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000780 RID: 1920
	[Token(Token = "0x2000780")]
	public struct PlacementHook
	{
		// Token: 0x0600435D RID: 17245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435D")]
		[Address(RVA = "0x4FF624", Offset = "0x4FF624", VA = "0x4FF624")]
		public PlacementHook(PlacementHook.HookFormat hook, int badReturn, int badResponse, bool processedCoordinates)
		{
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x00020700 File Offset: 0x0001E900
		[Token(Token = "0x600435E")]
		[Address(RVA = "0x4FF634", Offset = "0x4FF634", VA = "0x4FF634")]
		public static bool operator ==(PlacementHook first, PlacementHook second)
		{
			return default(bool);
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x00020718 File Offset: 0x0001E918
		[Token(Token = "0x600435F")]
		[Address(RVA = "0x4FF684", Offset = "0x4FF684", VA = "0x4FF684")]
		public static bool operator !=(PlacementHook first, PlacementHook second)
		{
			return default(bool);
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x00020730 File Offset: 0x0001E930
		[Token(Token = "0x6004360")]
		[Address(RVA = "0x4FF6D4", Offset = "0x4FF6D4", VA = "0x4FF6D4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x00020748 File Offset: 0x0001E948
		[Token(Token = "0x6004361")]
		[Address(RVA = "0x4FF7D0", Offset = "0x4FF7D0", VA = "0x4FF7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04008AB1 RID: 35505
		[Token(Token = "0x4008AB1")]
		[FieldOffset(Offset = "0x0")]
		public PlacementHook.HookFormat hook;

		// Token: 0x04008AB2 RID: 35506
		[Token(Token = "0x4008AB2")]
		[FieldOffset(Offset = "0x4")]
		public int badReturn;

		// Token: 0x04008AB3 RID: 35507
		[Token(Token = "0x4008AB3")]
		[FieldOffset(Offset = "0x8")]
		public int badResponse;

		// Token: 0x04008AB4 RID: 35508
		[Token(Token = "0x4008AB4")]
		[FieldOffset(Offset = "0xC")]
		public bool processedCoordinates;

		// Token: 0x04008AB5 RID: 35509
		[Token(Token = "0x4008AB5")]
		[FieldOffset(Offset = "0x0")]
		public static PlacementHook Empty;

		// Token: 0x04008AB6 RID: 35510
		[Token(Token = "0x4008AB6")]
		public const int Response_AllInvalid = 0;

		// Token: 0x02000781 RID: 1921
		// (Invoke) Token: 0x06004364 RID: 17252
		[Token(Token = "0x2000781")]
		public delegate int HookFormat(int x, int y, int type, int style, int direction, int alternate);
	}
}
