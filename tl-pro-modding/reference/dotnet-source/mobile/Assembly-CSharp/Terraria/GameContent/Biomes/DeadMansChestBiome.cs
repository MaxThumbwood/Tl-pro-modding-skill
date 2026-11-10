using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B90 RID: 2960
	[Token(Token = "0x2000B90")]
	public class DeadMansChestBiome : MicroBiome
	{
		// Token: 0x06005A6B RID: 23147 RVA: 0x0002A648 File Offset: 0x00028848
		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0x9070E4", Offset = "0x9070E4", VA = "0x9070E4", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x90A2B0", Offset = "0x90A2B0", VA = "0x90A2B0")]
		private void PlaceWiresForExplosives(Point origin)
		{
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x0002A660 File Offset: 0x00028860
		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0x908BF8", Offset = "0x908BF8", VA = "0x908BF8")]
		private bool AreThereEnoughTraps()
		{
			return default(bool);
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x907C9C", Offset = "0x907C9C", VA = "0x907C9C")]
		private void ClearCaches()
		{
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0x907E0C", Offset = "0x907E0C", VA = "0x907E0C")]
		private void FindBoulderTrapSpots(Point position)
		{
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A70")]
		[Address(RVA = "0x90A4D0", Offset = "0x90A4D0", VA = "0x90A4D0")]
		private void FindBoulderTrapSpot(Point position)
		{
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A71")]
		[Address(RVA = "0x90A674", Offset = "0x90A674", VA = "0x90A674")]
		private void FindBoulderTrapSpot_CheckSpot(Point position, int yPush)
		{
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A72")]
		[Address(RVA = "0x908214", Offset = "0x908214", VA = "0x908214")]
		private void FindDartTrapSpots(Point position)
		{
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x0002A678 File Offset: 0x00028878
		[Token(Token = "0x6005A73")]
		[Address(RVA = "0x90B624", Offset = "0x90B624", VA = "0x90B624")]
		private bool FindDartTrapSpotSingle(Point position, int directionX)
		{
			return default(bool);
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A74")]
		[Address(RVA = "0x908430", Offset = "0x908430", VA = "0x908430")]
		private void FindExplosiveTrapSpots(Point position)
		{
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x0002A690 File Offset: 0x00028890
		[Token(Token = "0x6005A75")]
		[Address(RVA = "0x90BE00", Offset = "0x90BE00", VA = "0x90BE00")]
		private bool IsGoodSpotsForExplosive(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A76")]
		[Address(RVA = "0x90C368", Offset = "0x90C368", VA = "0x90C368")]
		public List<int> GetPossibleChestsToTrapify(StructureMap structures)
		{
			return null;
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x0002A6A8 File Offset: 0x000288A8
		[Token(Token = "0x6005A77")]
		[Address(RVA = "0x9078E8", Offset = "0x9078E8", VA = "0x9078E8")]
		private static bool IsAGoodSpot(Point position)
		{
			return default(bool);
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A78")]
		[Address(RVA = "0x908CB4", Offset = "0x908CB4", VA = "0x908CB4")]
		private void TurnGoldChestIntoDeadMansChest(Point position)
		{
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A79")]
		[Address(RVA = "0x909038", Offset = "0x909038", VA = "0x909038")]
		private void ActuallyPlaceDartTrap(Point position, int directionX, int x, int y, int xPush, Tile t)
		{
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0x90935C", Offset = "0x90935C", VA = "0x90935C")]
		private void PlaceWireLine(Point start, int offsetX, int offsetY, int steps)
		{
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7B")]
		[Address(RVA = "0x9094D0", Offset = "0x9094D0", VA = "0x9094D0")]
		private void ActuallyPlaceBoulderTrap(Point position, int yPush, int requiredHeight, int bestType)
		{
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7C")]
		[Address(RVA = "0x909FB4", Offset = "0x909FB4", VA = "0x909FB4")]
		private void ActuallyPlaceExplosive(Point position)
		{
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7D")]
		[Address(RVA = "0x90C768", Offset = "0x90C768", VA = "0x90C768")]
		public DeadMansChestBiome()
		{
		}

		// Token: 0x04009BA5 RID: 39845
		[Token(Token = "0x4009BA5")]
		[FieldOffset(Offset = "0x8")]
		private List<DeadMansChestBiome.DartTrapPlacementAttempt> _dartTrapPlacementSpots;

		// Token: 0x04009BA6 RID: 39846
		[Token(Token = "0x4009BA6")]
		[FieldOffset(Offset = "0xC")]
		private List<DeadMansChestBiome.WirePlacementAttempt> _wirePlacementSpots;

		// Token: 0x04009BA7 RID: 39847
		[Token(Token = "0x4009BA7")]
		[FieldOffset(Offset = "0x10")]
		private List<DeadMansChestBiome.BoulderPlacementAttempt> _boulderPlacementSpots;

		// Token: 0x04009BA8 RID: 39848
		[Token(Token = "0x4009BA8")]
		[FieldOffset(Offset = "0x14")]
		private List<DeadMansChestBiome.ExplosivePlacementAttempt> _explosivePlacementAttempt;

		// Token: 0x04009BA9 RID: 39849
		[Token(Token = "0x4009BA9")]
		[FieldOffset(Offset = "0x18")]
		private IntRange _numberOfDartTraps;

		// Token: 0x04009BAA RID: 39850
		[Token(Token = "0x4009BAA")]
		[FieldOffset(Offset = "0x20")]
		private IntRange _numberOfBoulderTraps;

		// Token: 0x04009BAB RID: 39851
		[Token(Token = "0x4009BAB")]
		[FieldOffset(Offset = "0x28")]
		private IntRange _numberOfStepsBetweenBoulderTraps;

		// Token: 0x02000B91 RID: 2961
		[Token(Token = "0x2000B91")]
		private class DartTrapPlacementAttempt
		{
			// Token: 0x06005A7E RID: 23166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A7E")]
			[Address(RVA = "0x925F00", Offset = "0x925F00", VA = "0x925F00")]
			public DartTrapPlacementAttempt(Point position, int directionX, int x, int y, int xPush, Tile t)
			{
			}

			// Token: 0x04009BAC RID: 39852
			[Token(Token = "0x4009BAC")]
			[FieldOffset(Offset = "0x8")]
			public int directionX;

			// Token: 0x04009BAD RID: 39853
			[Token(Token = "0x4009BAD")]
			[FieldOffset(Offset = "0xC")]
			public int xPush;

			// Token: 0x04009BAE RID: 39854
			[Token(Token = "0x4009BAE")]
			[FieldOffset(Offset = "0x10")]
			public int x;

			// Token: 0x04009BAF RID: 39855
			[Token(Token = "0x4009BAF")]
			[FieldOffset(Offset = "0x14")]
			public int y;

			// Token: 0x04009BB0 RID: 39856
			[Token(Token = "0x4009BB0")]
			[FieldOffset(Offset = "0x18")]
			public Point position;

			// Token: 0x04009BB1 RID: 39857
			[Token(Token = "0x4009BB1")]
			[FieldOffset(Offset = "0x20")]
			public Tile t;
		}

		// Token: 0x02000B92 RID: 2962
		[Token(Token = "0x2000B92")]
		private class BoulderPlacementAttempt
		{
			// Token: 0x06005A7F RID: 23167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A7F")]
			[Address(RVA = "0x925F48", Offset = "0x925F48", VA = "0x925F48")]
			public BoulderPlacementAttempt(Point position, int yPush, int requiredHeight, int bestType)
			{
			}

			// Token: 0x04009BB2 RID: 39858
			[Token(Token = "0x4009BB2")]
			[FieldOffset(Offset = "0x8")]
			public Point position;

			// Token: 0x04009BB3 RID: 39859
			[Token(Token = "0x4009BB3")]
			[FieldOffset(Offset = "0x10")]
			public int yPush;

			// Token: 0x04009BB4 RID: 39860
			[Token(Token = "0x4009BB4")]
			[FieldOffset(Offset = "0x14")]
			public int requiredHeight;

			// Token: 0x04009BB5 RID: 39861
			[Token(Token = "0x4009BB5")]
			[FieldOffset(Offset = "0x18")]
			public int bestType;
		}

		// Token: 0x02000B93 RID: 2963
		[Token(Token = "0x2000B93")]
		private class WirePlacementAttempt
		{
			// Token: 0x06005A80 RID: 23168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A80")]
			[Address(RVA = "0x925F84", Offset = "0x925F84", VA = "0x925F84")]
			public WirePlacementAttempt(Point position, int dirX, int dirY, int steps)
			{
			}

			// Token: 0x04009BB6 RID: 39862
			[Token(Token = "0x4009BB6")]
			[FieldOffset(Offset = "0x8")]
			public Point position;

			// Token: 0x04009BB7 RID: 39863
			[Token(Token = "0x4009BB7")]
			[FieldOffset(Offset = "0x10")]
			public int dirX;

			// Token: 0x04009BB8 RID: 39864
			[Token(Token = "0x4009BB8")]
			[FieldOffset(Offset = "0x14")]
			public int dirY;

			// Token: 0x04009BB9 RID: 39865
			[Token(Token = "0x4009BB9")]
			[FieldOffset(Offset = "0x18")]
			public int steps;
		}

		// Token: 0x02000B94 RID: 2964
		[Token(Token = "0x2000B94")]
		private class ExplosivePlacementAttempt
		{
			// Token: 0x06005A81 RID: 23169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A81")]
			[Address(RVA = "0x925FC0", Offset = "0x925FC0", VA = "0x925FC0")]
			public ExplosivePlacementAttempt(Point position)
			{
			}

			// Token: 0x04009BBA RID: 39866
			[Token(Token = "0x4009BBA")]
			[FieldOffset(Offset = "0x8")]
			public Point position;
		}
	}
}
