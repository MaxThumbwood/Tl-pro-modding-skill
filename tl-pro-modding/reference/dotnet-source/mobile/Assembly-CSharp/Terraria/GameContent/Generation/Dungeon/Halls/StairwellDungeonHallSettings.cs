using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B5F RID: 2911
	[Token(Token = "0x2000B5F")]
	public class StairwellDungeonHallSettings : DungeonHallSettings
	{
		// Token: 0x060059C6 RID: 22982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C6")]
		[Address(RVA = "0x8B76B0", Offset = "0x8B76B0", VA = "0x8B76B0")]
		public StairwellDungeonHallSettings()
		{
		}

		// Token: 0x04009B4C RID: 39756
		[Token(Token = "0x4009B4C")]
		[FieldOffset(Offset = "0x3C")]
		public int MaxDistFromLine;

		// Token: 0x04009B4D RID: 39757
		[Token(Token = "0x4009B4D")]
		[FieldOffset(Offset = "0x40")]
		public int PointVariance;

		// Token: 0x04009B4E RID: 39758
		[Token(Token = "0x4009B4E")]
		[FieldOffset(Offset = "0x44")]
		public int InnerBoundsSize;

		// Token: 0x04009B4F RID: 39759
		[Token(Token = "0x4009B4F")]
		[FieldOffset(Offset = "0x48")]
		public int OuterBoundsSize;

		// Token: 0x04009B50 RID: 39760
		[Token(Token = "0x4009B50")]
		[FieldOffset(Offset = "0x50")]
		public double Gradient;

		// Token: 0x04009B51 RID: 39761
		[Token(Token = "0x4009B51")]
		[FieldOffset(Offset = "0x58")]
		public bool IsEntranceHall;
	}
}
