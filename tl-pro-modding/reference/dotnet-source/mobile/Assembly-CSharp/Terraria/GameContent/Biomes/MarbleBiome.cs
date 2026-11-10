using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000BA5 RID: 2981
	[Token(Token = "0x2000BA5")]
	public class MarbleBiome : MicroBiome
	{
		// Token: 0x06005AE2 RID: 23266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0x93DFDC", Offset = "0x93DFDC", VA = "0x93DFDC")]
		private void SmoothSlope(int x, int y)
		{
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0x93E4E0", Offset = "0x93E4E0", VA = "0x93E4E0")]
		private void PlaceSlab(MarbleBiome.Slab slab, int originX, int originY, int scale)
		{
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x0002AA38 File Offset: 0x00028C38
		[Token(Token = "0x6005AE4")]
		[Address(RVA = "0x93ECDC", Offset = "0x93ECDC", VA = "0x93ECDC")]
		private static bool IsGroupSolid(int x, int y, int scale)
		{
			return default(bool);
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x0002AA50 File Offset: 0x00028C50
		[Token(Token = "0x6005AE5")]
		[Address(RVA = "0x93EDC0", Offset = "0x93EDC0", VA = "0x93EDC0", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE6")]
		[Address(RVA = "0x93F95C", Offset = "0x93F95C", VA = "0x93F95C")]
		public MarbleBiome()
		{
		}

		// Token: 0x04009BE9 RID: 39913
		[Token(Token = "0x4009BE9")]
		private const int SCALE = 3;

		// Token: 0x04009BEA RID: 39914
		[Token(Token = "0x4009BEA")]
		[FieldOffset(Offset = "0x8")]
		private MarbleBiome.Slab[,] _slabs;

		// Token: 0x02000BA6 RID: 2982
		// (Invoke) Token: 0x06005AE8 RID: 23272
		[Token(Token = "0x2000BA6")]
		private delegate bool SlabState(int x, int y, int scale);

		// Token: 0x02000BA7 RID: 2983
		[Token(Token = "0x2000BA7")]
		private static class SlabStates
		{
			// Token: 0x06005AEB RID: 23275 RVA: 0x0002AA68 File Offset: 0x00028C68
			[Token(Token = "0x6005AEB")]
			[Address(RVA = "0x93FA70", Offset = "0x93FA70", VA = "0x93FA70")]
			public static bool Empty(int x, int y, int scale)
			{
				return default(bool);
			}

			// Token: 0x06005AEC RID: 23276 RVA: 0x0002AA80 File Offset: 0x00028C80
			[Token(Token = "0x6005AEC")]
			[Address(RVA = "0x93FA78", Offset = "0x93FA78", VA = "0x93FA78")]
			public static bool Solid(int x, int y, int scale)
			{
				return default(bool);
			}

			// Token: 0x06005AED RID: 23277 RVA: 0x0002AA98 File Offset: 0x00028C98
			[Token(Token = "0x6005AED")]
			[Address(RVA = "0x93FA80", Offset = "0x93FA80", VA = "0x93FA80")]
			public static bool HalfBrick(int x, int y, int scale)
			{
				return default(bool);
			}

			// Token: 0x06005AEE RID: 23278 RVA: 0x0002AAB0 File Offset: 0x00028CB0
			[Token(Token = "0x6005AEE")]
			[Address(RVA = "0x93FA94", Offset = "0x93FA94", VA = "0x93FA94")]
			public static bool BottomRightFilled(int x, int y, int scale)
			{
				return default(bool);
			}

			// Token: 0x06005AEF RID: 23279 RVA: 0x0002AAC8 File Offset: 0x00028CC8
			[Token(Token = "0x6005AEF")]
			[Address(RVA = "0x93FAAC", Offset = "0x93FAAC", VA = "0x93FAAC")]
			public static bool BottomLeftFilled(int x, int y, int scale)
			{
				return default(bool);
			}

			// Token: 0x06005AF0 RID: 23280 RVA: 0x0002AAE0 File Offset: 0x00028CE0
			[Token(Token = "0x6005AF0")]
			[Address(RVA = "0x93FAC0", Offset = "0x93FAC0", VA = "0x93FAC0")]
			public static bool TopRightFilled(int x, int y, int scale)
			{
				return default(bool);
			}

			// Token: 0x06005AF1 RID: 23281 RVA: 0x0002AAF8 File Offset: 0x00028CF8
			[Token(Token = "0x6005AF1")]
			[Address(RVA = "0x93FAD4", Offset = "0x93FAD4", VA = "0x93FAD4")]
			public static bool TopLeftFilled(int x, int y, int scale)
			{
				return default(bool);
			}
		}

		// Token: 0x02000BA8 RID: 2984
		[Token(Token = "0x2000BA8")]
		private struct Slab
		{
			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x06005AF2 RID: 23282 RVA: 0x0002AB10 File Offset: 0x00028D10
			[Token(Token = "0x17000A11")]
			public bool IsSolid
			{
				[Token(Token = "0x6005AF2")]
				[Address(RVA = "0x93E350", Offset = "0x93E350", VA = "0x93E350")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005AF3 RID: 23283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AF3")]
			[Address(RVA = "0x93FAEC", Offset = "0x93FAEC", VA = "0x93FAEC")]
			private Slab(MarbleBiome.SlabState state, bool hasWall)
			{
			}

			// Token: 0x06005AF4 RID: 23284 RVA: 0x0002AB28 File Offset: 0x00028D28
			[Token(Token = "0x6005AF4")]
			[Address(RVA = "0x93E4CC", Offset = "0x93E4CC", VA = "0x93E4CC")]
			public MarbleBiome.Slab WithState(MarbleBiome.SlabState state)
			{
				return default(MarbleBiome.Slab);
			}

			// Token: 0x06005AF5 RID: 23285 RVA: 0x0002AB40 File Offset: 0x00028D40
			[Token(Token = "0x6005AF5")]
			[Address(RVA = "0x93F94C", Offset = "0x93F94C", VA = "0x93F94C")]
			public static MarbleBiome.Slab Create(MarbleBiome.SlabState state, bool hasWall)
			{
				return default(MarbleBiome.Slab);
			}

			// Token: 0x04009BEB RID: 39915
			[Token(Token = "0x4009BEB")]
			[FieldOffset(Offset = "0x0")]
			public readonly MarbleBiome.SlabState State;

			// Token: 0x04009BEC RID: 39916
			[Token(Token = "0x4009BEC")]
			[FieldOffset(Offset = "0x4")]
			public readonly bool HasWall;
		}
	}
}
