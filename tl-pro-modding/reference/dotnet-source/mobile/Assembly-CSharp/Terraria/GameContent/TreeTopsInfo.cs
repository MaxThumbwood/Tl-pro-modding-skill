using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	// Token: 0x020009E6 RID: 2534
	[Token(Token = "0x20009E6")]
	public class TreeTopsInfo
	{
		// Token: 0x0600529B RID: 21147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529B")]
		[Address(RVA = "0x7E12BC", Offset = "0x7E12BC", VA = "0x7E12BC")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529C")]
		[Address(RVA = "0x7E1364", Offset = "0x7E1364", VA = "0x7E1364")]
		public void Load(BinaryReader reader, int loadVersion)
		{
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529D")]
		[Address(RVA = "0x7E18C0", Offset = "0x7E18C0", VA = "0x7E18C0")]
		public void SyncSend(BinaryWriter writer)
		{
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529E")]
		[Address(RVA = "0x7E1938", Offset = "0x7E1938", VA = "0x7E1938")]
		public void SyncReceive(BinaryReader reader)
		{
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x000267F0 File Offset: 0x000249F0
		[Token(Token = "0x600529F")]
		[Address(RVA = "0x7E19E0", Offset = "0x7E19E0", VA = "0x7E19E0")]
		public int GetTreeStyle(int areaId)
		{
			return 0;
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A0")]
		[Address(RVA = "0x7E1A04", Offset = "0x7E1A04", VA = "0x7E1A04")]
		public void RandomizeTreeStyleBasedOnWorldPosition(UnifiedRandom rand, Vector2 worldPosition)
		{
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A1")]
		[Address(RVA = "0x7E225C", Offset = "0x7E225C", VA = "0x7E225C")]
		public void RandomizeTreeStyle(UnifiedRandom rand, int areaId)
		{
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A2")]
		[Address(RVA = "0x7E19DC", Offset = "0x7E19DC", VA = "0x7E19DC")]
		private void DoTreeFX(int areaID)
		{
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A3")]
		[Address(RVA = "0x7E26B4", Offset = "0x7E26B4", VA = "0x7E26B4")]
		public void CopyExistingWorldInfoForWorldGeneration()
		{
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A4")]
		[Address(RVA = "0x7E15FC", Offset = "0x7E15FC", VA = "0x7E15FC")]
		public void CopyExistingWorldInfo()
		{
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A5")]
		[Address(RVA = "0x7E26B8", Offset = "0x7E26B8", VA = "0x7E26B8")]
		public TreeTopsInfo()
		{
		}

		// Token: 0x040096E0 RID: 38624
		[Token(Token = "0x40096E0")]
		[FieldOffset(Offset = "0x8")]
		private int[] _variations;

		// Token: 0x020009E7 RID: 2535
		[Token(Token = "0x20009E7")]
		public class AreaId
		{
			// Token: 0x060052A6 RID: 21158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052A6")]
			[Address(RVA = "0x7E2754", Offset = "0x7E2754", VA = "0x7E2754")]
			public AreaId()
			{
			}

			// Token: 0x040096E1 RID: 38625
			[Token(Token = "0x40096E1")]
			public const int Forest1 = 0;

			// Token: 0x040096E2 RID: 38626
			[Token(Token = "0x40096E2")]
			public const int Forest2 = 1;

			// Token: 0x040096E3 RID: 38627
			[Token(Token = "0x40096E3")]
			public const int Forest3 = 2;

			// Token: 0x040096E4 RID: 38628
			[Token(Token = "0x40096E4")]
			public const int Forest4 = 3;

			// Token: 0x040096E5 RID: 38629
			[Token(Token = "0x40096E5")]
			public const int Corruption = 4;

			// Token: 0x040096E6 RID: 38630
			[Token(Token = "0x40096E6")]
			public const int Jungle = 5;

			// Token: 0x040096E7 RID: 38631
			[Token(Token = "0x40096E7")]
			public const int Snow = 6;

			// Token: 0x040096E8 RID: 38632
			[Token(Token = "0x40096E8")]
			public const int Hallow = 7;

			// Token: 0x040096E9 RID: 38633
			[Token(Token = "0x40096E9")]
			public const int Crimson = 8;

			// Token: 0x040096EA RID: 38634
			[Token(Token = "0x40096EA")]
			public const int Desert = 9;

			// Token: 0x040096EB RID: 38635
			[Token(Token = "0x40096EB")]
			public const int Ocean = 10;

			// Token: 0x040096EC RID: 38636
			[Token(Token = "0x40096EC")]
			public const int GlowingMushroom = 11;

			// Token: 0x040096ED RID: 38637
			[Token(Token = "0x40096ED")]
			public const int Underworld = 12;

			// Token: 0x040096EE RID: 38638
			[Token(Token = "0x40096EE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int Count;
		}
	}
}
