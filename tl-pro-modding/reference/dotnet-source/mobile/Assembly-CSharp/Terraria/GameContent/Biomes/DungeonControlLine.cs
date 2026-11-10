using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.GameContent.Generation.Dungeon;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B96 RID: 2966
	[Token(Token = "0x2000B96")]
	public class DungeonControlLine
	{
		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06005A86 RID: 23174 RVA: 0x0002A6D8 File Offset: 0x000288D8
		[Token(Token = "0x17000A0B")]
		public Vector2D Center
		{
			[Token(Token = "0x6005A86")]
			[Address(RVA = "0x9266FC", Offset = "0x9266FC", VA = "0x9266FC")]
			get
			{
				return default(Vector2D);
			}
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A87")]
		[Address(RVA = "0x9267E0", Offset = "0x9267E0", VA = "0x9267E0")]
		private DungeonControlLine()
		{
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A88")]
		[Address(RVA = "0x9267E8", Offset = "0x9267E8", VA = "0x9267E8")]
		public DungeonControlLine(Vector2D start, Vector2D end, double startRadius, double endRadius, int progressionStage, DungeonGenerationStyleData style)
		{
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A89")]
		[Address(RVA = "0x926A2C", Offset = "0x926A2C", VA = "0x926A2C")]
		private void CacheNormals()
		{
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x0002A6F0 File Offset: 0x000288F0
		[Token(Token = "0x6005A8A")]
		[Address(RVA = "0x926B64", Offset = "0x926B64", VA = "0x926B64")]
		public bool CanPaint(int x, int y, out double distance, out double normalizedLineProgress)
		{
			return default(bool);
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A8B")]
		[Address(RVA = "0x926F80", Offset = "0x926F80", VA = "0x926F80")]
		public void Paint(int x, int y)
		{
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8C")]
		[Address(RVA = "0x927494", Offset = "0x927494", VA = "0x927494")]
		public DungeonGenerationStyleData GetStyleWithDitheredTransition(int x, int y, double normalizedLineProgress)
		{
			return null;
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x0002A708 File Offset: 0x00028908
		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0x927748", Offset = "0x927748", VA = "0x927748")]
		public static bool SkipPaintForEdge(int x, int y, DungeonGenerationStyleData style, double normalizedDistanceForPoint)
		{
			return default(bool);
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A8E")]
		[Address(RVA = "0x927C98", Offset = "0x927C98", VA = "0x927C98")]
		public void Paint(Rectangle dungeonBounds)
		{
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x0002A720 File Offset: 0x00028920
		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0x927FDC", Offset = "0x927FDC", VA = "0x927FDC")]
		public bool IsSelfIntersecting()
		{
			return default(bool);
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x0002A738 File Offset: 0x00028938
		[Token(Token = "0x6005A90")]
		[Address(RVA = "0x928218", Offset = "0x928218", VA = "0x928218")]
		public bool AdjustTangentsToPreventSelfIntersection()
		{
			return default(bool);
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x0002A750 File Offset: 0x00028950
		[Token(Token = "0x6005A91")]
		[Address(RVA = "0x928554", Offset = "0x928554", VA = "0x928554")]
		public bool IsInsideBorder(Point point)
		{
			return default(bool);
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x0002A768 File Offset: 0x00028968
		[Token(Token = "0x6005A92")]
		[Address(RVA = "0x92866C", Offset = "0x92866C", VA = "0x92866C")]
		public Vector2D GetPotentialRoomPosition(double normalizedDistanceAlong, double normalizedOffset, int roomRadius)
		{
			return default(Vector2D);
		}

		// Token: 0x04009BBC RID: 39868
		[Token(Token = "0x4009BBC")]
		[FieldOffset(Offset = "0x8")]
		public int Index;

		// Token: 0x04009BBD RID: 39869
		[Token(Token = "0x4009BBD")]
		[FieldOffset(Offset = "0xC")]
		public DungeonControlLine Next;

		// Token: 0x04009BBE RID: 39870
		[Token(Token = "0x4009BBE")]
		[FieldOffset(Offset = "0x10")]
		public DungeonControlLine Prev;

		// Token: 0x04009BBF RID: 39871
		[Token(Token = "0x4009BBF")]
		[FieldOffset(Offset = "0x18")]
		public Vector2D Start;

		// Token: 0x04009BC0 RID: 39872
		[Token(Token = "0x4009BC0")]
		[FieldOffset(Offset = "0x28")]
		public Vector2D End;

		// Token: 0x04009BC1 RID: 39873
		[Token(Token = "0x4009BC1")]
		[FieldOffset(Offset = "0x38")]
		public Vector2D StartTangent;

		// Token: 0x04009BC2 RID: 39874
		[Token(Token = "0x4009BC2")]
		[FieldOffset(Offset = "0x48")]
		public Vector2D EndTangent;

		// Token: 0x04009BC3 RID: 39875
		[Token(Token = "0x4009BC3")]
		[FieldOffset(Offset = "0x58")]
		public Vector2D StartNormal;

		// Token: 0x04009BC4 RID: 39876
		[Token(Token = "0x4009BC4")]
		[FieldOffset(Offset = "0x68")]
		public Vector2D EndNormal;

		// Token: 0x04009BC5 RID: 39877
		[Token(Token = "0x4009BC5")]
		[FieldOffset(Offset = "0x78")]
		public double CrossTangent;

		// Token: 0x04009BC6 RID: 39878
		[Token(Token = "0x4009BC6")]
		[FieldOffset(Offset = "0x80")]
		public double StartRadius;

		// Token: 0x04009BC7 RID: 39879
		[Token(Token = "0x4009BC7")]
		[FieldOffset(Offset = "0x88")]
		public double EndRadius;

		// Token: 0x04009BC8 RID: 39880
		[Token(Token = "0x4009BC8")]
		[FieldOffset(Offset = "0x0")]
		public static double NormalizedDistanceSafeFromDither;

		// Token: 0x04009BC9 RID: 39881
		[Token(Token = "0x4009BC9")]
		private const double StyleTransitionDitherWidth = 0.5;

		// Token: 0x04009BCA RID: 39882
		[Token(Token = "0x4009BCA")]
		private const int BorderWidth = 4;

		// Token: 0x04009BCB RID: 39883
		[Token(Token = "0x4009BCB")]
		[FieldOffset(Offset = "0x90")]
		public Vector2D NormalizedLineDirection;

		// Token: 0x04009BCC RID: 39884
		[Token(Token = "0x4009BCC")]
		[FieldOffset(Offset = "0xA0")]
		public double LineLength;

		// Token: 0x04009BCD RID: 39885
		[Token(Token = "0x4009BCD")]
		[FieldOffset(Offset = "0xA8")]
		public DungeonGenerationStyleData Style;

		// Token: 0x04009BCE RID: 39886
		[Token(Token = "0x4009BCE")]
		[FieldOffset(Offset = "0xAC")]
		public int ProgressionStage;

		// Token: 0x04009BCF RID: 39887
		[Token(Token = "0x4009BCF")]
		[FieldOffset(Offset = "0xB0")]
		public bool CurveLine;
	}
}
