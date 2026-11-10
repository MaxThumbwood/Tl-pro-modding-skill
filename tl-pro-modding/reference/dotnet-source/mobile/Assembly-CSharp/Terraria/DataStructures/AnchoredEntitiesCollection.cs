using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x020007C1 RID: 1985
	[Token(Token = "0x20007C1")]
	public class AnchoredEntitiesCollection
	{
		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x00020C58 File Offset: 0x0001EE58
		[Token(Token = "0x1700083A")]
		public int AnchoredPlayersAmount
		{
			[Token(Token = "0x600447E")]
			[Address(RVA = "0x5599CC", Offset = "0x5599CC", VA = "0x5599CC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447F")]
		[Address(RVA = "0x559A24", Offset = "0x559A24", VA = "0x559A24")]
		public AnchoredEntitiesCollection()
		{
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004480")]
		[Address(RVA = "0x559AE4", Offset = "0x559AE4", VA = "0x559AE4")]
		public void ClearNPCAnchors()
		{
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004481")]
		[Address(RVA = "0x559B44", Offset = "0x559B44", VA = "0x559B44")]
		public void ClearPlayerAnchors()
		{
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004482")]
		[Address(RVA = "0x559BA4", Offset = "0x559BA4", VA = "0x559BA4")]
		public void AddNPC(int npcIndex, Point coords)
		{
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x00020C70 File Offset: 0x0001EE70
		[Token(Token = "0x6004483")]
		[Address(RVA = "0x559C8C", Offset = "0x559C8C", VA = "0x559C8C")]
		public int GetNextPlayerStackIndexInCoords(Point coords)
		{
			return 0;
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004484")]
		[Address(RVA = "0x559E40", Offset = "0x559E40", VA = "0x559E40")]
		public void AddPlayerAndGetItsStackedIndexInCoords(int playerIndex, Point coords, out int stackedIndexInCoords)
		{
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x00020C88 File Offset: 0x0001EE88
		[Token(Token = "0x6004485")]
		[Address(RVA = "0x559C90", Offset = "0x559C90", VA = "0x559C90")]
		private int GetEntitiesInCoords(Point coords)
		{
			return 0;
		}

		// Token: 0x04008BF5 RID: 35829
		[Token(Token = "0x4008BF5")]
		[FieldOffset(Offset = "0x8")]
		private List<AnchoredEntitiesCollection.IndexPointPair> _anchoredNPCs;

		// Token: 0x04008BF6 RID: 35830
		[Token(Token = "0x4008BF6")]
		[FieldOffset(Offset = "0xC")]
		private List<AnchoredEntitiesCollection.IndexPointPair> _anchoredPlayers;

		// Token: 0x020007C2 RID: 1986
		[Token(Token = "0x20007C2")]
		private struct IndexPointPair
		{
			// Token: 0x04008BF7 RID: 35831
			[Token(Token = "0x4008BF7")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04008BF8 RID: 35832
			[Token(Token = "0x4008BF8")]
			[FieldOffset(Offset = "0x4")]
			public Point coords;
		}
	}
}
