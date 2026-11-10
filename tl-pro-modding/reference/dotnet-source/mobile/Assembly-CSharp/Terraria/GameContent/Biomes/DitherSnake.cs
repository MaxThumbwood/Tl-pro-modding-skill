using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B97 RID: 2967
	[Token(Token = "0x2000B97")]
	public class DitherSnake : List<DungeonControlLine>
	{
		// Token: 0x06005A93 RID: 23187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A93")]
		[Address(RVA = "0x928904", Offset = "0x928904", VA = "0x928904")]
		public new void Add(DungeonControlLine line)
		{
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A94")]
		[Address(RVA = "0x928A40", Offset = "0x928A40", VA = "0x928A40")]
		public DungeonControlLine GetClosestLineTo(Vector2D pos)
		{
			return null;
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A95")]
		[Address(RVA = "0x928C80", Offset = "0x928C80", VA = "0x928C80")]
		public DungeonControlLine GetLineContaining(Vector2D pos, [Optional] DungeonControlLine initialGuess, int depth = 0)
		{
			return null;
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x0002A780 File Offset: 0x00028980
		[Token(Token = "0x6005A96")]
		[Address(RVA = "0x928ED8", Offset = "0x928ED8", VA = "0x928ED8")]
		public double GetPositionAlongSnake(Vector2D pos)
		{
			return 0.0;
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x0002A798 File Offset: 0x00028998
		[Token(Token = "0x6005A97")]
		[Address(RVA = "0x928FC8", Offset = "0x928FC8", VA = "0x928FC8")]
		public bool IsCircleInsideBorderWithStyle(DungeonGenerationStyleData style, Vector2D center, int radius)
		{
			return default(bool);
		}

		// Token: 0x06005A98 RID: 23192 RVA: 0x0002A7B0 File Offset: 0x000289B0
		[Token(Token = "0x6005A98")]
		[Address(RVA = "0x929040", Offset = "0x929040", VA = "0x929040")]
		public bool IsCircleInsideBorderWithMatchingStyle(DungeonControlLine nearbyLine, Vector2D center, int radius)
		{
			return default(bool);
		}

		// Token: 0x06005A99 RID: 23193 RVA: 0x0002A7C8 File Offset: 0x000289C8
		[Token(Token = "0x6005A99")]
		[Address(RVA = "0x9292B0", Offset = "0x9292B0", VA = "0x9292B0")]
		public Vector2D GetRoomPositionInsideBorder(DungeonControlLine line, double normalizedDistanceAlong, double normalizedDistanceFrom, int roomRadius, out SnakeOrientation orientation)
		{
			return default(Vector2D);
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9A")]
		[Address(RVA = "0x9297FC", Offset = "0x9297FC", VA = "0x9297FC")]
		public void SetTangents()
		{
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9B")]
		[Address(RVA = "0x929A74", Offset = "0x929A74", VA = "0x929A74")]
		public void AdjustTangentsToPreventSelfIntersection()
		{
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x0002A7E0 File Offset: 0x000289E0
		[Token(Token = "0x6005A9C")]
		[Address(RVA = "0x929C34", Offset = "0x929C34", VA = "0x929C34")]
		public bool IsLineInsideBorder(Vector2D from, Vector2D to, int halfWidth)
		{
			return default(bool);
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x0002A7F8 File Offset: 0x000289F8
		[Token(Token = "0x6005A9D")]
		[Address(RVA = "0x929FAC", Offset = "0x929FAC", VA = "0x929FAC")]
		public bool IsLineInsideBorder(Vector2D from, Vector2D to)
		{
			return default(bool);
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9E")]
		[Address(RVA = "0x92A198", Offset = "0x92A198", VA = "0x92A198")]
		public DitherSnake()
		{
		}

		// Token: 0x04009BD0 RID: 39888
		[Token(Token = "0x4009BD0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector2D[] CircleTestPoints;

		// Token: 0x04009BD1 RID: 39889
		[Token(Token = "0x4009BD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly double ExtraBuffer;

		// Token: 0x02000B98 RID: 2968
		[Token(Token = "0x2000B98")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06005AA0 RID: 23200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AA0")]
			[Address(RVA = "0x92A190", Offset = "0x92A190", VA = "0x92A190")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06005AA1 RID: 23201 RVA: 0x0002A810 File Offset: 0x00028A10
			[Token(Token = "0x6005AA1")]
			[Address(RVA = "0x92A3C0", Offset = "0x92A3C0", VA = "0x92A3C0")]
			internal bool <IsLineInsideBorder>b__0(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x04009BD2 RID: 39890
			[Token(Token = "0x4009BD2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public DungeonControlLine line;

			// Token: 0x04009BD3 RID: 39891
			[Token(Token = "0x4009BD3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public DitherSnake <>4__this;
		}

		// Token: 0x02000B99 RID: 2969
		[Token(Token = "0x2000B99")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005AA3 RID: 23203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AA3")]
			[Address(RVA = "0x92A4FC", Offset = "0x92A4FC", VA = "0x92A4FC")]
			public <>c()
			{
			}

			// Token: 0x06005AA4 RID: 23204 RVA: 0x0002A828 File Offset: 0x00028A28
			[Token(Token = "0x6005AA4")]
			[Address(RVA = "0x92A508", Offset = "0x92A508", VA = "0x92A508")]
			internal Vector2D <.cctor>b__14_0(int i)
			{
				return default(Vector2D);
			}

			// Token: 0x04009BD4 RID: 39892
			[Token(Token = "0x4009BD4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DitherSnake.<>c <>9;
		}
	}
}
