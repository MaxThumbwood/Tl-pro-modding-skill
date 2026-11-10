using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000D52 RID: 3410
	[Token(Token = "0x2000D52")]
	public struct PlayerStatsSnapshot
	{
		// Token: 0x06006522 RID: 25890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006522")]
		[Address(RVA = "0xB41A34", Offset = "0xB41A34", VA = "0xB41A34")]
		public PlayerStatsSnapshot(Player player)
		{
		}

		// Token: 0x0400A286 RID: 41606
		[Token(Token = "0x400A286")]
		[FieldOffset(Offset = "0x0")]
		public int Life;

		// Token: 0x0400A287 RID: 41607
		[Token(Token = "0x400A287")]
		[FieldOffset(Offset = "0x4")]
		public int LifeMax;

		// Token: 0x0400A288 RID: 41608
		[Token(Token = "0x400A288")]
		[FieldOffset(Offset = "0x8")]
		public int LifeFruitCount;

		// Token: 0x0400A289 RID: 41609
		[Token(Token = "0x400A289")]
		[FieldOffset(Offset = "0xC")]
		public float LifePerSegment;

		// Token: 0x0400A28A RID: 41610
		[Token(Token = "0x400A28A")]
		[FieldOffset(Offset = "0x10")]
		public int Mana;

		// Token: 0x0400A28B RID: 41611
		[Token(Token = "0x400A28B")]
		[FieldOffset(Offset = "0x14")]
		public int ManaMax;

		// Token: 0x0400A28C RID: 41612
		[Token(Token = "0x400A28C")]
		[FieldOffset(Offset = "0x18")]
		public float ManaPerSegment;
	}
}
